using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazılımYapımı
{
    public partial class UserControl1 : UserControl
    {
        baglanti baglan;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            baglan = new baglanti();
            baglan.kayitGetir("select Turkce,Ing,turu,id from kelime ", kelimeview);
            baglan.kayitGetir("select Turkce,Ing,turu,id from kelime where tipi=1", ogrenilenview);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = kelimeview.CurrentRow.Index;
            string a = kelimeview.Rows[index].Cells[3].Value.ToString();
            string kayit = "update kelime set tipi=1,test_tipi=1 where id=" + a;
            baglan.update(kayit);
            baglan.kayitGetir("select Turkce,Ing,turu,id from kelime where tipi=1", ogrenilenview);           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = ogrenilenview.CurrentRow.Index;
            string a = ogrenilenview.Rows[index].Cells[3].Value.ToString();
            string kayit = "update kelime set tipi=0,test_tipi=0" +
                " where id=" + a;
            baglan.update(kayit);
            baglan.kayitGetir("select Turkce,Ing,turu,id from kelime where tipi=1", ogrenilenview);
        }
    }
}
