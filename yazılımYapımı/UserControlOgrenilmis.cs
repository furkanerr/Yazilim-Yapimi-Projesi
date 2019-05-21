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
    public partial class UserControlOgrenilmis : UserControl
    {
        public UserControlOgrenilmis()
        {
            InitializeComponent();
        }

        private void UserControlOgrenilmis_Load(object sender, EventArgs e)
        {
            baglanti baglan = new baglanti();
            baglan.kayitGetir("select Turkce,Ing,turu,id from kelime where tipi=2", ogrenilmisview);
        }
    }
}
