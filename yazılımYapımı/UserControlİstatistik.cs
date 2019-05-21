using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace yazılımYapımı
{
    public partial class UserControlİstatistik : UserControl
    {
        public UserControlİstatistik()
        {
            InitializeComponent();
        }
            SqlConnection baglan = 
            new SqlConnection("Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=YazılımYapımı;Integrated Security=True");

        private void UserControlİstatistik_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand GetirKomutu = new SqlCommand("select YEAR(Tarih) as Yıl, MONTH(Tarih) as Ay,count(Tarih) as sayı from kelime where Tarih between '2019-01-01' and '2019-12-31' and Tipi=2 and test_tipi=5 group by YEAR(Tarih), MONTH(Tarih) order by Yıl, Ay", baglan);
            SqlDataReader Oku = GetirKomutu.ExecuteReader();
            string[] aylar = { "ocak", "şubat", "mart", "nisan", "mayıs", "haziran", "temmuz", "agustos", "eylül", "ekim", "kasım", "aralık" }; 
            int[] aydeger = { 0,0,0,0,0,0,0,0,0,0,0,0};
            while (Oku.Read())
            {
                aydeger[(int)Oku[1]] =(int)Oku[2];
            }
            int j = 0;
            while (j<12)
            {
                chart2.Series["aylar"].Points.AddXY(j.ToString() , aydeger[j]);
                j++;
            }
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
