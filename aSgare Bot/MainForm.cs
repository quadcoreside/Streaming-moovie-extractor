using aSgare_Bot.HTTP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace aSgare_Bot
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Globals.frmMain = this;
            __FOUNDED__ = new Hashtable();
        }

        public static ConfigObject conf;
        Thread th;
        Hashtable __FOUNDED__;
        public List<ItemFound> items = new List<ItemFound>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            remetDonne();
            UpStats();
            btnValiderParametre.PerformClick();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveData();
        }
        public void saveData()
        {
            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.High;
            bool existe = Directory.Exists(Globals.DATA_FOLDER);
            if (!existe)
            {
                Directory.CreateDirectory(Globals.DATA_FOLDER);
            }

            SaveListView(foundedPath, list_result);
            SaveListView(sendedPath, list_sended);
        }
        internal void remetDonne()
        {
            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.High;
            bool existe = Directory.Exists(Globals.DATA_FOLDER);
            if (existe)
            {
                SetListView(foundedPath, list_result);
                SetListView(sendedPath, list_sended);
            }
            if (!existe)
            {
                Directory.CreateDirectory(Globals.DATA_FOLDER);
            }
        }
        private string foundedPath = Globals.DATA_FOLDER + "/" + "founded.lv";
        private string sendedPath = Globals.DATA_FOLDER + "/" + "sended.lv";
        private void SaveListView(string chemin, ListView lv)
        {
            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.High;
            List<object[]> liste = new List<object[]> { };

            lv.Invoke((MethodInvoker)delegate
            {
                foreach (ListViewItem lvi in lv.Items)
                {
                    List<object> column = new List<object>();
                    for (int i = 0; i < lvi.SubItems.Count; i++)
                    {
                        column.Add(lvi.SubItems[i].Text);
                    }
                    column.Add(lvi.Tag);
                    liste.Add(column.ToArray());
                }
            });

            File.WriteAllText(chemin, ser.Serialize(new { items = liste.ToArray() }));
        }
        private void SetListView(string chemin, ListView lv)
        {
            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.High;

            if (File.Exists(chemin))
            {
                dynamic data = ser.DeserializeObject(File.ReadAllText(chemin));

                lv.BeginUpdate();
                foreach (var item in data["items"])
                {
                    List<object> row = new List<object>();
                    foreach (var sitem in item)
	                {
                        row.Add(sitem);
	                }
                    object tag = row[row.Count - 1];
                    row = row.Take(row.Count - 1).ToList();

                    List<string> rowLvText = new List<string>();
                    foreach (object r in row)
                    {
                        rowLvText.Add(r.ToString());
                    }

                    ListViewItem lvi = new ListViewItem(rowLvText.ToArray());
                    lvi.Tag = tag;
                    lv.Items.Add(lvi);
                }
                lv.EndUpdate();
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (th == null || !th.IsAlive)
            {
                ScraperEngine se = new ScraperEngine();
                th = new Thread(() => se.worker());
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 50;

                btn_start.Text = "Annuler";
                btn_start.BackColor = Color.Red;
                btn_loadConfig.Enabled = false;
            }
            else
            {
                th.Abort();
                th = null;

                progressBar1.Style = ProgressBarStyle.Blocks;

                btn_start.Text = "Démarer";
                btn_start.BackColor = Color.Transparent;
                btn_loadConfig.Enabled = true;
            }
            
        }
        internal void workFinish()
        {
            th = null;
            progressBar1.Style = ProgressBarStyle.Blocks;
            btn_start.Text = "Démarer";
            btn_start.BackColor = Color.Transparent;
            btn_loadConfig.Enabled = true;
            saveData();
            UpStats();
        }
        private void UpStats()
        {
            this.tableLayoutPanel1.Invoke((MethodInvoker)(() =>
            {
                txt_items_found.Text = "Items Found " + list_result.Items.Count;
                txt_items_sended.Text = "Items Sended " + list_sended.Items.Count;
            }));
        }
        private void btn_loadConfig_Click(object sender, EventArgs e)
        {
            DialogResult result = new ConfigScrapForm().ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                if (conf != null)
                {
                    txt_configName.Text = conf.Name;
                    btn_start.Enabled = true;
                }
                else
                {
                    txt_configName.Text = "N/A";
                    btn_start.Enabled = false;
                }
            }
            else
            {
                conf = null;
                txt_configName.Text = "N/A";
                btn_start.Enabled = false;
            }
            
        }

        HttpRequester hr = new HttpRequester();
        public static JavaScriptSerializer ser = new JavaScriptSerializer();
        private void StartSendingServer(List<ListViewItem> items)
        {
            string countryCode = txt_country.Text;
            string onlineState = txt_onlineState.Text;
            Thread th = new Thread(() =>
            {
                foreach (ListViewItem lvi in items)
                {
                    dynamic item = lvi.Tag;
                    string extension = Path.GetExtension(item["image"]);
                    string fileName = "image" + extension;
                    if (!Directory.Exists(Globals.CACHE_FOLDER))
                    {
                        Directory.CreateDirectory(Globals.CACHE_FOLDER);
                    }

                    string filePath = Globals.CACHE_FOLDER + @"\" + fileName;
                    DownloadRemoteImageFile(item["image"], filePath);

                    string response = hr.postFile(Globals.API_URL + "/gateway/tube/picture/upload", filePath, "videospicture");
                   
                    if (response != string.Empty)
                    {
                        dynamic blob = ser.DeserializeObject(response);
                        blob = Encryption.Decrypt(Globals.ENCRYPTION_KEY, blob["d"]);
                        dynamic data = ser.DeserializeObject(blob);

                        if (data["success"])
                        {
                            object dataObj = new
                            {
                                name = item["name"],
                                collectionStreamLink = ser.Serialize(item["parts"]),
                                description = item["description"],
                                picture_id = data["picture_id"],
                                source = item["domain"],
                                countryCode = countryCode,
                                online = onlineState,
                            };

                           string dataPost = "d=" + HttpUtility.UrlEncode(Encryption.Encrypt(Globals.ENCRYPTION_KEY, ser.Serialize(dataObj)));

                            response = hr.post(Globals.API_URL + "/gateway/tube/post", dataPost);
                            blob = ser.DeserializeObject(response);
                            response = Encryption.Decrypt(Globals.ENCRYPTION_KEY, blob["d"]);
                            Console.Write(response);
                        }
                    }
                    list_sended.Invoke((MethodInvoker)(() =>
                    {
                        list_sended.Items.Add((ListViewItem)lvi.Clone());
                        lvi.Remove();
                    }));
                }

            });
            th.Start();
        }
        private static void DownloadRemoteImageFile(string uri, string fileName)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Check that the remote file was found. The ContentType
            // check is performed since a request for a non-existent
            // image file might be redirected to a 404-page, which would
            // yield the StatusCode "OK", even though the image was not
            // found.
            if ((response.StatusCode == HttpStatusCode.OK ||
                response.StatusCode == HttpStatusCode.Moved ||
                response.StatusCode == HttpStatusCode.Redirect) &&
                response.ContentType.StartsWith("image", StringComparison.OrdinalIgnoreCase))
            {

                // if the remote file was found, download oit
                using (Stream inputStream = response.GetResponseStream())
                using (Stream outputStream = File.OpenWrite(fileName))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    do
                    {
                        bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                        outputStream.Write(buffer, 0, bytesRead);
                    } while (bytesRead != 0);
                }
            }
        }

        private void btnValiderParametre_Click(object sender, EventArgs e)
        {
            if (txt_urlAPi.Text.StartsWith("http") && txt_urlAPi.Text.Contains("://"))
            {
                Globals.API_URL = txt_urlAPi.Text;
            }
        }

        #region Founded
        private void voirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_result.SelectedItems)
            {
                ItemViewForm ivf = new ItemViewForm(item);
                ivf.Show();
            }
        }
        private void envoyerAuServeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            foreach (ListViewItem item in list_result.SelectedItems)
            {
                items.Add(item);
            }
            StartSendingServer(items);
        }
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in list_result.SelectedItems)
            {
                lvi.Remove();
            }
        }
        private void list_result_DoubleClick(object sender, EventArgs e)
        {
            ItemViewForm ivf = new ItemViewForm(list_result.SelectedItems[0]);
            ivf.Show();
        }
        #endregion

        #region Sended
        private void renvoyerStripMenuItem2_Click(object sender, EventArgs e)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            foreach (ListViewItem item in list_sended.SelectedItems)
            {
                items.Add(item);
            }
            StartSendingServer(items);
        }
        private void supprimerStripMenuItem3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in list_sended.SelectedItems)
            {
                lvi.Remove();
            }
        }
        private void voirStripMenuItem1_Click(object sender, EventArgs e)
        {
            ItemViewForm ivf = new ItemViewForm(list_sended.SelectedItems[0]);
            ivf.Show();
        } 
        #endregion
    }
}
