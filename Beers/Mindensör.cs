using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Beers
{
    public partial class Mindensör : Form
    {
        public Mindensör()
        {
            InitializeComponent();
            LoadSörök();
        }

        private void LoadSörök()
        {
            XmlDocument sör = new XmlDocument();
            sör.Load("sörök.xml");

            foreach (XmlNode item in sör.DocumentElement)
            {
                string neve = item.Attributes[0].Value;
                double alkoholfok = double.Parse(item["alkohol"].InnerText);
                string íz = item["íz"].InnerText;
                string fajta = item["típus"].InnerText;
               string származás = item["származás"].InnerText;
               string fogyasztás = item["fogyasztás"].InnerText;
               int ár = int.Parse(item["ár"].InnerText);
               int minőség = int.Parse(item["minőség"].InnerText);
                listBox1.Items.Add(new Sörök(neve, alkoholfok, íz, fajta, származás, fogyasztás, ár, minőség));   


            }
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                propertyGrid1.SelectedObject = listBox1.SelectedItem;
           
        }
    }
}
