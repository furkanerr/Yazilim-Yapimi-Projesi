using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazılımYapımı
{
    public partial class kullanıcı : Form
    {
        public kullanıcı()
        {
            InitializeComponent();
            SidePanel.Height = Ogrenilen_btn.Height;
            SidePanel.Top = Ogrenilen_btn.Top;
            userControl11.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Ogrenilen_btn.Height;
            SidePanel.Top = Ogrenilen_btn.Top;
            userControl11.BringToFront();
            


            //Ogrenilen ogrenilen = new Ogrenilen();
               //  ogrenilen.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Test_btn.Height;
            SidePanel.Top = Test_btn.Top;
            userControlTest1.BringToFront();
            //Test test = new Test();
            //test.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Ogrenilmis_btn.Height;
            SidePanel.Top = Ogrenilmis_btn.Top;
            userControlOgrenilmis1.BringToFront();

            //ogrenilmis ogrenilmis = new ogrenilmis();
            // ogrenilmis.Show();
        }

        private void kullanıcı_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            userControlİstatistik1.BringToFront();
        }
    }
}
