using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beers
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            nevszerint nev = new nevszerint();
            //Menu menü = new Menu();
            this.Hide();
            nev.Show();
           
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
              if(DialogResult.Yes ==
              MessageBox.Show("Biztosan ki akarsz lépni ebből a fantasztikus programból?","Kilépés", MessageBoxButtons.YesNo));

              {
            this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
             Mindensör minden= new Mindensör();
            //Menu menü = new Menu();
            this.Hide();
            minden.Show();
        }
    }
}
