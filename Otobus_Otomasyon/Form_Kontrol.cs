using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobus_Otomasyon
{
    public partial class Form_Kontrol : Form
    {
        public Form_Kontrol()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=YASEMINGOKTAS; Database=otobusOtomasyon; Trusted_Connection=True;");
        SqlCommand komut;
        
        private string ToplamBul(string Plaka)
        {
            object dondur = 0, deger;
            if (Plaka.ToString() != "Hepsi")
            {
                string sorgu = "select sum(TutarTL) from Kontrol where Plaka = '" + Plaka.Trim().ToString() + "'";
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                komut = new SqlCommand(sorgu, conn);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    // plakaya ait bi kayıt yoksa null geldiği için hata veriyordu.! Bu hatayı aşağıdaki if koşuluyla atlatmış olduk:
                    if (dr[0].ToString() != "")
                    {
                        deger = dr[0];
                        dondur = deger;
                    }
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            else if (Plaka.ToString() == "Hepsi")
            {
                string sorgu = "select sum(TutarTL) from Kontrol";
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                komut = new SqlCommand(sorgu, conn);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    // plakaya ait bi kayıt yoksa null geldiği için hata veriyordu.! Bu hatayı aşağıdaki if koşuluyla atlatmış olduk:
                    if (dr[0].ToString() != "")
                    {
                        dondur = dr[0];
                    }
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dondur.ToString();
        }
        private void Form_Kontrol_Load(object sender, EventArgs e)
        {
            string sorgu = "Select * from Kontrol";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            komut = new SqlCommand(sorgu,conn);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[1].ToString(), dr[7].ToString(), dr[2].ToString() + " => " + dr[3].ToString(), dr[4].ToString() + " " + dr[5].ToString(), Convert.ToInt16(dr[8]));
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        private void comboBoxOtobusSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHasilat.Text = ToplamBul(comboBoxOtobusSec.SelectedItem.ToString());
        }
    }
}
