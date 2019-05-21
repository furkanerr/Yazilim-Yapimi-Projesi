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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        baglanti baglan = new baglanti();
        private void button2_Click(object sender, EventArgs e)
        {
            
            string trkelime = tr.Text;
            string enkelime = en.Text;
            string tur = turbox.Text;
            string tip = "0";
            string testtip = "0";
            DateTime dt = DateTime.Today;
            string tarih = dt.ToString("yyyy-MM-dd");
            string kayit = "insert into kelime(Turkce, Ing,turu,Tipi,test_tipi,tarih) values('" + trkelime + "', '" + enkelime + "', '" + tur + "', '" + tip + "','" + testtip + "', '" + tarih + "' )";
            MessageBox.Show(kayit);
            baglan.insert(kayit);
            baglan.kayitGetir("select Turkce,Ing,turu,id from kelime ", dataGridView1);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
            baglan.kayitGetir("select Turkce,Ing,turu,id from kelime ", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string a = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string kayit = "delete from kelime where id=" + a + "";
            baglan.delete(kayit);
            baglan.kayitGetir("select Turkce,Ing,turu,id from kelime ", dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
