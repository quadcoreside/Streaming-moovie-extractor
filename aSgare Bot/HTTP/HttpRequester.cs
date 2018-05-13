using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace aSgare_Bot.HTTP
{
    class HttpRequester
    {
        private int tantativeMax = 6;

        public string get(string url)
        {
            var requete = (HttpWebRequest)WebRequest.Create(url);
            requete.UserAgent = Globals.USER_AGENT;
            requete.CookieContainer = new CookieContainer();
            requete.AllowAutoRedirect = true;
            requete.KeepAlive = true;

            var reponseString = string.Empty;

            for (int t = 0; t < tantativeMax; t++)
            {
                try
                {
                    using (var response = (HttpWebResponse)requete.GetResponse())
                    {
                        reponseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                        break;
                    }
                }
                catch (WebException ex)
                {
                    if (checkNetwork())
                    {
                        if (ex.Status == WebExceptionStatus.UnknownError ||
                        ex.Status == WebExceptionStatus.TrustFailure ||
                        ex.Status == WebExceptionStatus.ServerProtocolViolation ||
                        ex.Status == WebExceptionStatus.SendFailure ||
                        ex.Status == WebExceptionStatus.SecureChannelFailure ||
                        ex.Status == WebExceptionStatus.RequestProhibitedByCachePolicy ||
                        ex.Status == WebExceptionStatus.RequestCanceled ||
                        ex.Status == WebExceptionStatus.ReceiveFailure ||
                        ex.Status == WebExceptionStatus.ProtocolError ||
                        ex.Status == WebExceptionStatus.PipelineFailure ||
                        ex.Status == WebExceptionStatus.CacheEntryNotFound)
                        {
                            using (var stream = ex.Response.GetResponseStream())
                            using (var reader = new StreamReader(stream))
                            {
                                reponseString = reader.ReadToEnd();
                            }
                            Console.WriteLine(ex.ToString());
                            Console.WriteLine(reponseString);
                        }
                    }
                    else
                    {
                        if (!waitNetwork())
                        {
                            return reponseString;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return reponseString;
        }
        public string post(string url, string donne)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var data = Encoding.ASCII.GetBytes(donne);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            request.UserAgent = Globals.USER_AGENT;
            request.KeepAlive = true;

            var reponseString = string.Empty;

            for (int t = 0; t < tantativeMax; t++)
            {
                try
                {
                    using (var stream = request.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }

                    var response = (HttpWebResponse)request.GetResponse();
                    reponseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    break;
                }
                catch (WebException ex)
                {
                    if (checkNetwork())
                    {
                        using (var stream = ex.Response.GetResponseStream())
                        using (var reader = new StreamReader(stream))
                        {
                            reponseString = reader.ReadToEnd();
                        }
                        Console.WriteLine(ex.ToString());
                        Console.WriteLine(reponseString);
                    }
                    else
                    {
                        if (!waitNetwork())
                        {
                            return reponseString;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            return reponseString;
        }
        public string postFile(string url, string pathFile, string context)
        {
            string response = string.Empty;

            for (int t = 0; t <= 2; t++)//3 essaye
            {
                try
                {
                    using (WebClient cl = new WebClient())
                    {
                        cl.Headers.Add("Context", context);
                        cl.Headers.Add("User-Agent", Globals.USER_AGENT);
                        response = Encoding.ASCII.GetString(cl.UploadFile(url, "POST", pathFile));
                    }
                    break;
                }
                catch (WebException webex)
                {
                    if (checkNetwork())
                    {
                        WebResponse errResp = webex.Response;
                        using (Stream respStream = errResp.GetResponseStream())
                        {
                            StreamReader reader = new StreamReader(respStream);
                            response = reader.ReadToEnd();
                        }
                    }
                    else
                    {
                        waitNetwork();
                    }
                }
            }
            return response;
        }

        public bool waitNetwork()
        {
            int cycle = 0;
            while (true)
            {
                if (checkNetwork())
                {
                    return true;
                }
                else
                {
                    if (cycle > 120)
                    {
                        return false;
                    }
                    cycle++;
                    Thread.Sleep(5517);
                }
            }
        }

        public bool checkNetwork()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
