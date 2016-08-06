using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSS_Reader
{
    public partial class Form1 : Form
    {
        private String[,] rssData;
        public Form1()
        {
            InitializeComponent();
        }

        private String[,] getRssData(String canal)
        {
            WebRequest webRequest = WebRequest.Create(canal);
            WebResponse webResponse = webRequest.GetResponse();

            Stream rssStream = webResponse.GetResponseStream();
            XmlDocument rssDoc = new XmlDocument();

            rssDoc.Load(rssStream);

            XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

            String[,] tempRssData = new String[rssItems.Count, 3];

            for (int i = 0; i < rssItems.Count; i++)
            {
                XmlNode rssNode = rssItems.Item(i).SelectSingleNode("title");
                tempRssData[i, 0] = rssNode != null ? rssNode.InnerText : "";

                rssNode = rssItems.Item(i).SelectSingleNode("description");
                tempRssData[i, 1] = rssNode != null ? rssNode.InnerText : "";

                rssNode = rssItems.Item(i).SelectSingleNode("link");
                tempRssData[i, 2] = rssNode != null ? rssNode.InnerText : "";
            }

            return tempRssData;
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            this.comboBoxItems.Items.Clear();
            this.rssData = getRssData(textBoxCanal.Text);

            for (int i = 0; i < rssData.GetLength(0); i++)
            {
                if (rssData[i, 0] != null) this.comboBoxItems.Items.Add(this.rssData[i, 0]);
            }
            this.comboBoxItems.SelectedIndex = 0;
        }

        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.rssData[this.comboBoxItems.SelectedIndex, 1] != null)
            {
                this.textBoxContenido.Text = this.rssData[this.comboBoxItems.SelectedIndex, 1];
            }

            if (this.rssData[this.comboBoxItems.SelectedIndex, 2] != null)
            {
                this.linkLabelLiga.Text = "Ir a: " + this.rssData[this.comboBoxItems.SelectedIndex, 2];
            }
        }

        private void linkLabelLiga_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.rssData[this.comboBoxItems.SelectedIndex, 2] != null)
            {
                Process.Start(this.rssData[this.comboBoxItems.SelectedIndex, 2]);
            }
        }


    }
}
