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
    public partial class Form_AracTakip : Form
    {
        public Form_AracTakip()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=YASEMINGOKTAS; Database=otobusOtomasyon; Trusted_Connection=True;");
        SqlCommand cmd;
        String tarih;
        private void PlakaDoldur()  // plaka combobox'ını dolduran metod
        {
            string sorgu = "select Plaka from Kontrol";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd = new SqlCommand(sorgu, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxOtobusSec.Items.Add(dr[0].ToString());
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        private void Form_AracTakip_Load(object sender, EventArgs e)
        {
            PlakaDoldur();
        }
        private void comboBoxOtobusSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSefer.Text = "";
            string sorgu = "select SeferKalkis +' => ' + SeferVaris from Kontrol where Plaka = '" + comboBoxOtobusSec.SelectedItem.ToString() + "'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd = new SqlCommand(sorgu, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtSefer.Text = dr[0].ToString();
            }
            else
            {
                txtSefer.Text = "veri cekilemedi";
            }
            dr.Close();
            string sorgu2 = "select COUNT(*), Tarih from Kontrol where Plaka = '" + comboBoxOtobusSec.SelectedItem.ToString() + "'";
            cmd = new SqlCommand(sorgu2, conn);
            SqlDataReader dr2 = cmd.ExecuteReader();
            if (dr2.Read())
            {
                txtKisiSayisi.Text = dr2[0].ToString();
                tarih = dr2[1].ToString();
            }
            else
            {
                txtKisiSayisi.Text = "veri cekilemedi";
            }
            dr2.Close();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        private void buttonAracHareketlendir_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=YASEMINGOKTAS; Database=otobusOtomasyon; Trusted_Connection=True;");
            SqlCommand cmd;
            DialogResult sonuc = MessageBox.Show("Aracı Hareketini Onaylıyor musunuz?", "UYARI", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sorguHareketEkle = "insert into Hareketler (Plaka, Tarih, ToplamHasilat) values ('"+ comboBoxOtobusSec.SelectedItem.ToString() +"','"+ tarih +"',) ";
                cmd = new SqlCommand(sorguHareketEkle, con);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
