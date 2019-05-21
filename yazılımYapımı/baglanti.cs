using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazılımYapımı
{
    class baglanti
    {
        SqlConnection bag;

        public baglanti()
        {
            string conString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=YazılımYapımı;Integrated Security=True";
            //Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
            //Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.
            bag = new SqlConnection(conString);
            //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşturuyoruz
        }
        public void kayitGetir(string sqlstr, System.Windows.Forms.DataGridView dataGrid)
        {
            bag.Open();
            string kayit = sqlstr;
            SqlCommand komut = new SqlCommand(kayit, bag);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid.DataSource = dt;
            bag.Close();
        }
        public DataTable select(string sqlstr)
        {
            bag.Open();
            string kayit = sqlstr;
            SqlCommand komut = new SqlCommand(kayit, bag);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bag.Close();
            return dt;
        }
        public void update(string kayit)
        {
            SqlCommand komut = new SqlCommand();
            bag.Open();
            komut.CommandText = kayit;
            komut.Connection = bag;
            komut.ExecuteNonQuery();
            bag.Close();


        }
        public string login(string a, string b)
        {
            string str = "-1";
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            bag.Open();
            cmd.Connection = bag;
            cmd.CommandText = "SELECT yetki FROM kullanici where kullaniciadi='" + a + "' AND sifre='" + b + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                str = dr["yetki"].ToString();
            }
            bag.Close();
            return str;
        }
        public void insert(string sqlstr)
        {
            SqlCommand cmd = new SqlCommand();
            bag.Open();
            cmd.Connection = bag;
            cmd.CommandText = sqlstr;
            cmd.ExecuteNonQuery(); 
            bag.Close();
        }
        public void delete(string sqlstr)
        {
            SqlCommand cmd = new SqlCommand();
            bag.Open();
            cmd.Connection = bag;
            cmd.CommandText = sqlstr;
            cmd.ExecuteNonQuery();
            bag.Close();
        }
    }
}
