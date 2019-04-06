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
using Microsoft.VisualBasic;

namespace Otobus_Otomasyon
{
    public partial class Form_OtobusSecim : Form
    {
        public Form_OtobusSecim()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=YASEMINGOKTAS; Database=otobusOtomasyon; Trusted_Connection=True;");
        SqlCommand cmd;
        Button btnkoltuk;
        private void Koltuk(string Plaka, bool deger)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (deger == true)
            {
                // SANAL BUTONLAR :
                int x1 = 200;
                for (int i = 29; i >= 1; i = i - 2) // Koltukların sayısı sağdan itibaren başlasın istedik.Bu yüzden for döngüsü azalan bir döngü olmalı.
                {                                   // koltuk dizilişi açısından i değişkenini 2 şer 2 şer azalttık. 
                    btnkoltuk = new Button();
                    btnkoltuk.Name = "btnKoltuk" + i.ToString();
                    btnkoltuk.Text = i.ToString();
                    btnkoltuk.BackColor = Color.YellowGreen;
                    // Otobus tablosundaki koltuk değerleri select sorgusuyla değiştiriliyor:
                    string sorgu = "Select 1 from Otobus where Koltuk" + i.ToString() + "=1 and Plaka = '" + Plaka + "'";
                    cmd = new SqlCommand(sorgu, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr[0].ToString() == "1")
                        {
                            btnkoltuk.BackColor = Color.Red;
                            btnkoltuk.Enabled = false;
                        }
                        else if (dr[0].ToString() == "0")
                        {
                            btnkoltuk.BackColor = Color.YellowGreen;
                            btnkoltuk.Enabled = true;
                        }
                    }
                    dr.Close();
                    btnkoltuk.Width = 45;
                    btnkoltuk.Height = 60;
                    btnkoltuk.Location = new Point(x1, 27);
                    btnkoltuk.Click += new EventHandler(btnkoltuk_Click);
                    flowLayoutPanel1.Controls.Add(btnkoltuk);

                    x1 += 60;
                }
                int x2 = 200;
                for (int i = 30; i > 1; i = i - 2)
                {
                    btnkoltuk = new Button();
                    btnkoltuk.Name = "btnKoltuk" + i.ToString();
                    btnkoltuk.Text = i.ToString();
                    btnkoltuk.BackColor = Color.YellowGreen;
                    string sorgu = "Select 1 from Otobus where Koltuk" + i.ToString() + "=1 and Plaka = '" + Plaka + "'";
                    cmd = new SqlCommand(sorgu, con);
                    SqlDataReader dr2 = cmd.ExecuteReader();
                    while (dr2.Read())
                    {
                        if (dr2[0].ToString() == "1")
                        {
                            btnkoltuk.BackColor = Color.Red;
                            btnkoltuk.Enabled = false;
                        }
                        else if (dr2[0].ToString() == "0")
                        {
                            btnkoltuk.BackColor = Color.YellowGreen;
                            btnkoltuk.Enabled = true;
                        }
                    }
                    dr2.Close();
                    btnkoltuk.Width = 45;
                    btnkoltuk.Height = 60;
                    btnkoltuk.Location = new Point(x2, 27);
                    btnkoltuk.Click += new EventHandler(btnkoltuk_Click);
                    flowLayoutPanel2.Controls.Add(btnkoltuk);

                    x2 += 60;
                }
            }
            else if (deger == false)    // her plaka seçildiğinde plowlayoutpaneller temizleniyor. bunu yapmazsak butonlar alt alta yazılıyorlar.
            {
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel2.Controls.Clear();
            }
               
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }
        private void ComboBoxDoldur()   // kalkış - varış comboboxlarını dolduran metod
        {
            string sorgu = "select *from City";
            cmd = new SqlCommand(sorgu, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxKalkis.Items.Add(dr[1].ToString());
                comboBoxVaris.Items.Add(dr[1].ToString());
            }
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }   
        private void PlakaDoldur()  // plaka combobox'ını dolduran metod
        {
            string sorgu = "select Plaka from Otobus";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            cmd = new SqlCommand(sorgu, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxOtobus.Items.Add(dr[0].ToString());             
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        private void btnkoltuk_Click(object sender, EventArgs e)
        {
            // Butonun name'indeki son haneyi substring ile alarak, bu index'i kullanarak SQL Sorgusunda kullanıyoruz. Where koşuluna göre eğer butonaun denk geldiği koltuk 0 ise boş olduğu anlamına geliyor ve bu durum da o koltuk 1 yapılıyor.
            Button buton = sender as Button;
            string donendeger = Interaction.InputBox("Müşteri Adı ve Soyadı Giriniz:", "Koltuk Seçimi İçin ", "Örn: Cem Adrian", 0, 0);
            DialogResult sonuc = MessageBox.Show("Rezervasyonu Onaylıyor musunuz?",donendeger,MessageBoxButtons.YesNo);
            char[] adSoyad = donendeger.ToCharArray();  // char dizisine çeviriyoruz.
            string ad = "";
            string soyad = "";
            int sayac = 0;
            foreach (var item in adSoyad)   // dizi elemanlarını dolaşıyoruz
            {
                if (item != ' ') { sayac++; ad += item; }    // boşluk bulana kadarki tüm karakterleri ad değişkeninde biriktiriyorum
                else { break; }     // boşluk bulunca foreach döndügünden çıkıyorum
            }
            for (int i = sayac + 1; i < adSoyad.Length; i++)    // sayac ile karakter dizisinde en son kaldığım yerden başlayarak, dizisinin son elemanına kadar olan kısmı soyad değşkeninde birleştiriyorum
            {
                soyad += adSoyad[i];
            }
            string sorguAdEKle = "insert into Kontrol (Plaka, SeferKalkis, SeferVaris, MusteriAd, MusteriSoyad,Tarih,KoltukNo, TutarTL) values ('"
                + comboBoxOtobus.SelectedItem.ToString()
                + "','" + comboBoxKalkis.SelectedItem.ToString()
                + "','" + comboBoxVaris.SelectedItem.ToString() + "','"
                + ad + "','"
                + soyad + "','"
                + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Year.ToString() + "',"
                + buton.Name.Substring(9)
                + ",100)";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand(sorguAdEKle, con);
            cmd.ExecuteNonQuery();

            if (sonuc == DialogResult.Yes)  // koltuk rengi değiştirme :
            {
                string sorgu = "Update Otobus Set Koltuk" + buton.Name.Substring(9) + " = 1 where Plaka = '" + comboBoxOtobus.SelectedItem.ToString() + "' and Koltuk" + buton.Name.Substring(9) + " = 0";

                cmd = new SqlCommand(sorgu, con);
                cmd.ExecuteNonQuery();
                if (cmd.ExecuteNonQuery() == 0) // executenonquery etkilediği kayıt sayısını döndürür. Eğer hiçbir kayıt etkilenmediyse buton rengi değişmemelidir.
                {
                    buton.BackColor = Color.Red;
                    buton.Enabled = false;
                }

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void Form_OtobusSecim_Load(object sender, EventArgs e)
        {
            // comboboxların sıralı seçimi için başlangıç değerleri böyle ayarlandı :
            comboBoxKalkis.Enabled = true;
            comboBoxVaris.Enabled = false;
            comboBoxOtobus.Enabled = false;
            labelKoltukSec.Visible = false;
            
            PlakaDoldur();
            ComboBoxDoldur();
            
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;         
        }
        // sırasıyla önce kalkış seferi, sonra varış seferi, sonra otobüs plakası seçilince koltuklar (butonlar) gelmektedir : 
        private void comboBoxOtobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Koltuk(comboBoxOtobus.SelectedItem.ToString(), false);  // eski koltukları flowlayout'dan temizledik
            Koltuk(comboBoxOtobus.SelectedItem.ToString(), true);   // flowlayout'u butonlarla doldurduk
            labelKoltukSec.Visible = true;  // kullanıcıya bilgi verildi.
            Form_OtobusSecim frm = new Form_OtobusSecim();
            
            if (comboBoxOtobus.SelectedIndex == 0)
            {
                lblAracAdi.Text = "V O L K S W A G E N";
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;                
            }
            else if (comboBoxOtobus.SelectedIndex == 1)
            {
                lblAracAdi.Text = "F O R D";
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;                
            }
            else if (comboBoxOtobus.SelectedIndex == 2)
            {
                lblAracAdi.Text = "M E R C E D E S";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
                pictureBox3.Visible = true;
            }
        }

        private void comboBoxKalkis_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxVaris.Enabled = true;
            comboBoxOtobus.Enabled = false;
        }
        private void comboBoxVaris_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxOtobus.Enabled = true;
        }
        
    }
}
