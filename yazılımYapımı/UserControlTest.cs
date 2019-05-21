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
    public partial class UserControlTest : UserControl 
    {
        public UserControlTest()
        {
            InitializeComponent();
        }
        baglanti baglan = new baglanti();
        private int i = 0;//yeni sorunun gelmesi  için sayaç degİŞkeni
        private Random _random = new Random();
        private string dcevap;
        private List<Array> soru;
        private string[] kelime;

        private List<Array> TestAlgoritma()//veritabanı soruları getirip oluşturuyor
        {
            //soru listesini çeken program
            List<Array> liste = new List<Array>();
            DateTime tarih2 = DateTime.Today;
            string trh1 = String.Format("{0:yyyy-MM-dd}", tarih2);
            //tip 1 ögrenilen kelime
            DataTable st = baglan.select("select * from kelime where Tipi=1 and Tarih<='" + trh1 + "'");
            int i = 0;
            while (i < st.Rows.Count)
            {
                //önce kelime dizisine sonra liste listesine ekliyor
                string[] kelime = new string[5];
                kelime[0] = st.Rows[i]["Turkce"].ToString();
                kelime[1] = st.Rows[i]["Ing"].ToString();
                kelime[2] = st.Rows[i]["Tarih"].ToString();
                kelime[3] = st.Rows[i]["id"].ToString();
                kelime[4] = st.Rows[i]["test_tipi"].ToString();
                liste.Add(kelime);
                i++;
            }
            return liste;
        }
        private void karıstır<T>(T[] array)//
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {

                int r = i + (int)(_random.NextDouble() * (n - i));
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }
        private string[] kelimegetir()//sıklar için türkçe kelimeler getiriyor
        {
            //sık oluşturmak için kullanılan kelimeleri getiren fonksiyon
            DataTable sf = baglan.select("select Turkce from kelime  ");
            string[] kelimeler = new string[sf.Rows.Count];
            int j = 0;
            A.Text = sf.Rows.Count.ToString();
            while (j < sf.Rows.Count)
            {
                //kelime dizisine ekleme
                kelimeler[j] = sf.Rows[j]["Turkce"].ToString();
                j++;
            }
            return kelimeler;
        }
        private string yenisoru(List<Array> soru, string[] kelime)
        {
            if (i < soru.Count)
            {
                string[] listestr = (string[])soru[i];
                Soru.Text = listestr[1].ToString() + " kelimesinin türkçe anlamı nedir ? ";
                /*şıklar oluturuyoruz*/
                string[] sıklar = new string[4];//[0,1,1,3]
                sıklar[0] = listestr[0].ToString();//dogru
                string dogru = listestr[0].ToString();
                int x = 0;
                Random rnd = new Random();
                while (x < 3)
                {
                    int temp = rnd.Next(0, kelime.Length);
                    if (Array.IndexOf(sıklar, kelime[temp]) != -1)
                    {

                    }
                    else
                    {
                        sıklar[x + 1] = kelime[temp];
                        x++;
                    }

                }
                karıstır<string>(sıklar);
                A.Text =sıklar[0];
                B.Text =sıklar[1];
                C.Text =sıklar[3];
                D.Text =sıklar[2];
                /*sıklar oluştu*/
                this.i++;
                return dogru;
            }
            else
            {
                return "0";
            }

        }
        private void cevapla(string cevap, string dcevap)
        {
            if (i == soru.Count)//soru bittigi zaman elemanları saklıyor
            {
                Soru.Text="Bugünlük bu kadar yarın tekrar SORU  ekliyoruz";
                A.Hide();
                B.Hide();
                C.Hide();
                D.Hide();
            }
            string[] strliste = (string[])this.soru[this.i - 1];
            if (cevap == dcevap)
            {
                int testtip = Convert.ToInt32(strliste[4].ToString());
                string[] tarih = strliste[2].Split('.');
                int yıl = Convert.ToInt32(tarih[2].Remove(4, 9));//gereksiz bilgi tamizligi
                int ay = Convert.ToInt32(tarih[1]);
                int gun = Convert.ToInt32(tarih[0]);
                DateTime tarih2 = DateTime.Today;
                DateTime dt = new DateTime((int)yıl, ay, gun);
                if (testtip == 1)
                {
                    tarih2 = dt.AddDays(6);
                }
                else if (testtip == 2)
                {
                    tarih2 = dt.AddDays(23);
                }
                else if (testtip == 3)
                {
                    tarih2 = dt.AddDays(60);
                }
                else
                {
                    tarih2 = DateTime.Today;
                }
                int id = Convert.ToInt32(strliste[3]);
                string trh = String.Format("{0:yyyy-MM-dd}", tarih2);
                testtip += 1;
                baglan.update("update kelime set test_tipi=" + testtip + ",Tarih='" + trh + "' where id=" + id + "");
                MessageBox.Show("cevabınız dogru.yeni soruya geçiniz");
            }
            else
            {
                int testtip = 1;
                int id = Convert.ToInt32(strliste[3]);
                DateTime tarih2 = DateTime.Today.AddDays(1);
                string trh = String.Format("{0:yyyy-MM-dd}", tarih2);
                baglan.update("update kelime set test_" +
                    "tipi=" + testtip + ",Tarih='" + trh + "' where id=" + id + "");
                MessageBox.Show("cevabınız yanlış.bu kelimeye ait testiniz 1.gün testinden tekrar baslayacaktır ");
            }
        }
        private void A_Click(object sender, EventArgs e)
        {
            string cevap = A.Text;
            islem(cevap);
        }
     
        private void B_Click(object sender, EventArgs e)
        {
            string cevap = B.Text;
            islem(cevap);
        }

        private void C_Click(object sender, EventArgs e)
        {
            string cevap = C.Text;
            islem(cevap);
        }

        private void D_Click(object sender, EventArgs e)
        {
            string cevap = D.Text;
            islem(cevap);
        }

        private void UserControlTest_Load(object sender, EventArgs e)
        {
            this.soru = TestAlgoritma();
            this.kelime = kelimegetir();
            if (soru.Count != 0)
            {
                dcevap = yenisoru(soru, kelime);
            }
            else
            {
                A.Hide();
                B.Hide();
                C.Hide();
                D.Hide();
                Soru.Text = "Şuan çözülecek sorunuz bulunmamaktadır";
            }
        }
        private void sonrakisoru()
        {
            dcevap = yenisoru(soru, kelime);
            if (dcevap == "0")
            {
                MessageBox.Show("sorular bitti çıkabilirsiniz");
            }
        }
        private void islem(string cevap)
        {
            cevapla(cevap, dcevap);
            sonrakisoru();
        }
    }
}
