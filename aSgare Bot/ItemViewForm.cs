using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aSgare_Bot
{
    public partial class ItemViewForm : Form
    {
        public ItemViewForm(ListViewItem lvi)
        {
            InitializeComponent();
            dynamic item = lvi.Tag;
            string vUrls = "";
            foreach (dynamic part in item["parts"])
            {
                vUrls += "\t" + part["name"] + ":" + part["url"] + Environment.NewLine;
            }
            vUrls += "\r\n\r\n";
            richTextBox1.Text = "Nom: " + item["name"] + Environment.NewLine +
                                "URL: " + item["url"] + Environment.NewLine +
                                "Image: " + item["image"] + Environment.NewLine +
                                "Nombre URLS: " + item["countParts"] + Environment.NewLine +
                                "Vidéo URLS: " + Environment.NewLine + vUrls + Environment.NewLine +
                                "Description: " + Environment.NewLine + item["description"] + Environment.NewLine +
                                "Domaine: " + item["domain"] + Environment.NewLine +
                                "Date: " + item["date"] + Environment.NewLine;

        }

        private void ItemViewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
