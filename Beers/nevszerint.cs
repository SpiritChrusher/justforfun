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
    public partial class nevszerint : Form
    {
        public nevszerint()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eredmeny.Clear();
            try
            {
                if (searchInput.Text != null && searchInput.Text.Length > 4)
                {
                    XmlDocument sör = new XmlDocument();
                    sör.Load("sörök.xml");

                    foreach (XmlNode item in sör.DocumentElement)
                    {



                        string name = item.Attributes[0].InnerText;
                        if (name == searchInput.Text && name != null)
                        {
                            foreach (XmlNode child in item.ChildNodes)
                            {
                                Eredmeny.Items.Add(child.InnerText);
                            }
                             //Eredmeny.Show();
                        }                      
                    }

                }
                else
                {
                    MessageBox.Show("Helytelen bemenet");
                    searchInput.Text = string.Empty;
                    searchInput.Focus();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Nincs ilyen sör");
                searchInput.Text = string.Empty;
                searchInput.Clear();
                searchInput.Focus();

            }
        }
      
    
    
        private void nevszerint_Load(object sender, EventArgs e)
        {
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Biztos kilépsz?", "Exit", MessageBoxButtons.YesNo);
            this.Close();

        }
    }
}
