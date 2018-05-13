using aSgare_Bot.HTTP;
using HtmlAgilityPack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace aSgare_Bot
{
    class ScraperEngine
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            {"div", "//div[@[t]]"},
            {"a", "//a"},

            {"iframe", "//iframe"},
            {"span", "//span"},

            {"href", "//a"},
            {"img", "//img"},
            {"text", ""},
        };

        Hashtable itemsCollection = new Hashtable();
        HttpRequester http = new HttpRequester();
        ConfigObject conf;

        public void worker()
        {
            conf = MainForm.conf;

            List<string> urlsDone = new List<string>();
            string[] urls = conf.Urls.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var url in urls)
            {
                if (!urlsDone.Contains(url))
                {
                    addInGui(extract(url, ref itemsCollection));

                    if (conf.recheckStepOne)
                    {
                        foreach (dynamic item in itemsCollection)
                        {
                            Hashtable ht = extract(item["itemUrl"], ref itemsCollection);
                            addInGui(ht);
                        }
                    }
                    urlsDone.Add(url);
                }
            }

            Globals.frmMain.Invoke((MethodInvoker)(() =>
            {
                Globals.frmMain.workFinish();
            }));
        }

        private void addInGui(Hashtable ht)
        {
            var items = new List<ListViewItem>();

            foreach (dynamic item in ht.Values)
            {
                ListViewItem lvi = new ListViewItem(item["name"]);
                lvi.SubItems.Add(item["countParts"]);
                lvi.SubItems.Add(item["domain"]);
                lvi.SubItems.Add(item["date"]);
                lvi.Tag = item;

                items.Add(lvi);
            }

            Globals.frmMain.list_result.Invoke((MethodInvoker)(() =>
            {
                Globals.frmMain.list_result.BeginUpdate();
                Globals.frmMain.list_result.Items.AddRange(items.ToArray());
                Globals.frmMain.list_result.EndUpdate();
            }));
        }

        private Hashtable extract(string url, ref Hashtable ht)
        {
            Hashtable newHt = new Hashtable();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            string html = http.get(url);
            doc.LoadHtml(html);

            string xpath = Build(conf.itemsCollectionIndices);

            var collection = doc.DocumentNode.SelectNodes(xpath)
                  .Select(p => p.InnerHtml)
                  .ToList();

            foreach (string item in collection)
            {
                try
                {
                    doc.LoadHtml(item);

                    xpath = Build(conf.itemsNameIndices);
                    string itemName = HttpUtility.HtmlDecode(doc.DocumentNode.SelectSingleNode(xpath).InnerText);

                    xpath = Build(conf.itemsUrlIndices);
                    string itemUrl = doc.DocumentNode.SelectSingleNode(xpath).Attributes["href"].Value;

                    string itemImage = string.Empty;
                    if (conf.itemsImageIndices != string.Empty)
                    {
                        xpath = Build(conf.itemsImageIndices);
                        itemImage = doc.DocumentNode.SelectSingleNode(xpath).Attributes["src"].Value;
                    }

                    if (checkURL(itemUrl))
                    {
                        html = http.get(itemUrl);
                        doc.LoadHtml(html);

                        List<object> partsList = new List<object>();

                        xpath = Build(conf.itemUrlSourceIndices);
                        string itemFirstPartName = string.Empty;
                        string itemFirstUrlSource = string.Empty;
                        string[] xp = xpath.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                        if (xp.Length >= 1)
                        {
                            itemFirstUrlSource = doc.DocumentNode
                            .SelectSingleNode(xp[0] + xp[1])
                            .Attributes["src"].Value;
                        }
                        partsList.Add(new { name = "Source 1", url = HttpUtility.HtmlDecode(itemFirstUrlSource) });

                        xpath = Build(conf.itemDescriptionIndices);
                        string itemDescription = doc.DocumentNode.SelectSingleNode(xpath).InnerText;

                        string key = itemName.ToLower();

                        if (!conf.nameAsUnique && ht.ContainsKey(key))
                        {
                            int i = 1;
                            while (true)
                            {
                                if (ht.ContainsKey(key))
                                    key = key + "_" + i;
                                else
                                    break;
                            }
                        }

                        if (conf.itemPartCollectionIndices != string.Empty)
                        {
                            xpath = Build(conf.itemPartCollectionIndices);

                            try
                            {
                                var parts = doc.DocumentNode.SelectNodes("//div[@class='keremiya_part']/a")
                                                    .Select(p => p.InnerText + "S|P" + p.Attributes["href"].Value)
                                                    .ToList();

                                foreach (string part in parts)
                                {
                                    string[] a = part.Split(new string[] { "S|P" }, StringSplitOptions.RemoveEmptyEntries);

                                    string partName = a[0];

                                    html = http.get(a[1]);
                                    doc.LoadHtml(html);

                                    string subUrlSource = string.Empty;
                                    xpath = Build(conf.itemUrlSourceIndices);
                                    xp = xpath.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                                    if (xp.Length >= 1)
                                    {
                                        subUrlSource = doc.DocumentNode
                                        .SelectSingleNode(xp[0] + xp[1])
                                        .Attributes["src"].Value;
                                    }

                                    partsList.Add(new { name = HttpUtility.HtmlDecode(partName), url = HttpUtility.HtmlDecode(subUrlSource), });
                                }

                                if (partsList.Count > 1)
                                {
                                    dynamic expl = partsList[partsList.Count - 1];
                                    dynamic first = partsList[0];

                                    string nameScheme = expl.name;
                                    nameScheme = nameScheme.TrimStart().Split(' ')[0];
                                    nameScheme = nameScheme + " 1";

                                    partsList[0] = new { name = nameScheme, url = expl.url };
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.ToString());
                            }
                        }

                        dynamic obj = new
                        {
                            key = key,
                            name = itemName,
                            url = HttpUtility.HtmlDecode(itemUrl),
                            image = HttpUtility.HtmlDecode(itemImage),
                            description = clearStartDescription(HttpUtility.HtmlDecode(itemDescription)),
                            parts = partsList,
                            countParts = partsList.Count.ToString(),
                            domain = new Uri(url).Host,
                            date = DateTime.Now.ToString()
                        };
                        JavaScriptSerializer ser = new JavaScriptSerializer();
                        obj = ser.DeserializeObject(ser.Serialize(obj));
                        ht.Add(key, obj);
                        //Nouveaux
                        newHt.Add(key, obj);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            return newHt;
        }

        private string clearStartDescription(string text)
        {
            List<string> inutiles = new List<string>()
            {
                "<br>",
                "<br />",
                "< br />",
                "\r",
                "\n",
                "\t",
                " ",
            };
            while (true)
            {
                bool affecter = false;
                foreach (string item in inutiles)
                {
                    if (text.StartsWith(item))
                    {
                        text = text.Remove(0, item.Length);
                        affecter = true;
                    }
                }
                if (!affecter)
                {
                    break;
                }

            }
            return text;
        }

        private string Build(string indices)
        {
            string xpath = string.Empty;
            string[] mrc = indices.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in mrc)
            {
                if (xpath.Contains("[t]"))
                {
                    Regex regex = new Regex(@"[a-zA-Z]*='[^']*'");
                    Match match = regex.Match(item);
                    if (match.Success)
	                {
                        xpath = xpath.Replace("[t]", item);
	                }
                }
                else
                {
                    string output = string.Empty;
                    if (dictionary.ContainsKey(item))
                    {
                        dictionary.TryGetValue(item, out output);
                    }
                    if (xpath == string.Empty)
                        xpath = output;
                    else
                        xpath += ";" + output;
                }
            }

            return xpath;
        }
        
        private bool checkURL(string url)
        {
            Uri uriResult;
            return Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                     && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }
    }
}
