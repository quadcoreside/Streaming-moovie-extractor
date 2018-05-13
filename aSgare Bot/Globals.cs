using aSgare_Bot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

internal sealed class Globals
{
    public static MainForm frmMain;

    public static string USER_AGENT = "Mozilla/5.0 (Windows; U; Windows NT 5.1; pt-PT; rv:1.9.1.2) Gecko/20090729 Firefox/3.5.2 (.NET CLR 3.5.30729)";
    public static bool HTTP_ALLOW_AUTO_REDIRECT = true;
    public static bool HTTP_ENCONDING_HEADERS = true;
    public static int TIMEOUT = 15000;

    public static string API_URL = "http://localhost/wara_gateway";
    public const string CONFIG_FOLDER = "Configs";
    public const string DATA_FOLDER = "Data";
    public const string CACHE_FOLDER = "Cache";
    public static string ENCRYPTION_KEY = "piWUCi7DsWLUTwOLou9QbiBP33NVk3yAyWRrAIXrdtg";

    public static void UpDateStatus(string status)
    {
        SetText(frmMain.txt_status, status);
    }
    public delegate void ControlStringConsumer(Control control, string text);
    public static void SetText(Control control, string text)
    {
        if (control.InvokeRequired)
        {
            control.Invoke(new ControlStringConsumer(SetText), new object[] { control, text });
        }
        else
        {
            control.Text = text;
        }
    }
}
