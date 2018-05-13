using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace aSgare_Bot
{
    public partial class ConfigScrapForm : Form
    {
        public ConfigScrapForm()
        {
            InitializeComponent();
        }
        JavaScriptSerializer serializer = new JavaScriptSerializer();
        private void ConfigScrapForm_Load(object sender, EventArgs e)
        {
            refreshList();
        }

        private void refreshList()
        {
            list_configs.Items.Clear();
            if (!Directory.Exists(Globals.CONFIG_FOLDER))
            {
                Directory.CreateDirectory(@"Configs");
            }
            foreach (string item in Directory.GetFiles(Globals.CONFIG_FOLDER))
            {
                list_configs.Items.Add(Path.GetFileNameWithoutExtension(item));
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveConfig();   
        }

        private void SaveConfig()
        {
            if (txt_configName.Text != string.Empty)
            {
                if (txt_itemsColllectionIndices.Text != string.Empty)
                {
                    if (txt_itemsColllectionIndices.Text != string.Empty)
                    {
                        string content = serializer.Serialize(new
                        {
                            txt_configName = txt_configName.Text,

                            txt_urls = txt_urls.Text,

                            txt_itemDescriptionIndices = txt_itemDescriptionIndices.Text,
                            txt_itemImageIndices = txt_itemImageIndices.Text,
                            txt_itemNameIndices = txt_itemNameIndices.Text,

                            txt_itemsColllectionIndices = txt_itemsColllectionIndices.Text,
                            txt_itemUrlIndices = txt_itemUrlIndices.Text,
                            txt_itemUrlSourceIndices = txt_itemUrlSourceIndices.Text,

                            chk_nameAsUnique = chk_nameAsUnique.Checked,
                            chk_reCheckStep1 = chk_reCheckStep1.Checked,

                            txt_itemPartCollectionIndices = txt_itemPartCollectionIndices.Text,
                            txt_itemPartNameIndices = txt_itemPartNameIndices.Text,
                            txt_itemPartUrlSourceIndices = txt_itemPartUrlSourceIndices.Text
                        });
                        if (!Directory.Exists(Globals.CONFIG_FOLDER))
                        {
                            Directory.CreateDirectory(@"Configs");
                        }
                        string path = Globals.CONFIG_FOLDER + @"\" + txt_configName.Text + ".json";
                        File.WriteAllText(path, content);
                        refreshList();
                    }
                }
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            SaveConfig();
            ConfigObject co = new ConfigObject();
            co.Name = txt_configName.Text;
            co.Urls = txt_urls.Text;
            co.itemDescriptionIndices = txt_itemDescriptionIndices.Text;
            co.itemsCollectionIndices = txt_itemsColllectionIndices.Text;
            co.itemsImageIndices = txt_itemImageIndices.Text;
            co.itemsNameIndices = txt_itemNameIndices.Text;
            co.itemsUrlIndices = txt_itemUrlIndices.Text;
            co.itemUrlSourceIndices = txt_itemUrlSourceIndices.Text;
            co.nameAsUnique = chk_nameAsUnique.Checked;
            co.recheckStepOne = chk_reCheckStep1.Checked;
            co.itemPartCollectionIndices = txt_itemPartCollectionIndices.Text;
            co.itemPartNameIndices = txt_itemPartNameIndices.Text;
            co.itemPartUrlSourceIndices = txt_itemPartUrlSourceIndices.Text;
            MainForm.conf = co;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void list_configs_DoubleClick(object sender, EventArgs e)
        {
            if (list_configs.SelectedItems.Count > 0)
            {
                try
                {
                    string path = Globals.CONFIG_FOLDER + @"\" + list_configs.SelectedItems[0].ToString() + ".json";
                    string content = File.ReadAllText(path);
                    dynamic dt = serializer.DeserializeObject(content);
                    txt_configName.Text = dt["txt_configName"];
                    txt_urls.Text = dt["txt_urls"];
                    txt_itemDescriptionIndices.Text = dt["txt_itemDescriptionIndices"];
                    txt_itemsColllectionIndices.Text = dt["txt_itemsColllectionIndices"];
                    txt_itemImageIndices.Text = dt["txt_itemImageIndices"];
                    txt_itemNameIndices.Text = dt["txt_itemNameIndices"];
                    txt_itemUrlIndices.Text = dt["txt_itemUrlIndices"];
                    txt_itemUrlSourceIndices.Text = dt["txt_itemUrlSourceIndices"];
                    chk_nameAsUnique.Checked = dt["chk_nameAsUnique"];
                    chk_reCheckStep1.Checked = dt["chk_reCheckStep1"];

                    refreshList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Echec chargement de la configuration," + Environment.NewLine + ex.ToString(), "Echec chargement: " + list_configs.SelectedItems[0].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
