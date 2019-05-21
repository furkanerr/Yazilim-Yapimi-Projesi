using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yazılımYapımı
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection  con = new SqlConnection("Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=YazılımYapımı;Integrated Security=True");
          
        

        

        
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti baglan = new baglanti();
            string kullaniciadi = t1.Text;
            string sifre = t2.Text;
            string yetki = baglan.login(kullaniciadi,sifre);
             if (yetki == "1")
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }else if(yetki == "0"){
                    kullanıcı kullanıcı = new kullanıcı();
                    kullanıcı.Show();
                    this.Hide();
                }else{
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                }
            

        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void t1_Click(object sender, EventArgs e)
        {
            t1.Clear();
            t1.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void t2_Click(object sender, EventArgs e)
        {
            t2.Clear();
            t2.ForeColor = Color.FromArgb(78, 184, 206);


        }
    }
}
