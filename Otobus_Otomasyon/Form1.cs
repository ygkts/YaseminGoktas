using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobus_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonBiletKes_Click(object sender, EventArgs e)
        {
            Form_OtobusSecim sec = new Form_OtobusSecim();
            sec.ShowDialog();
        }
        private void buttonKontrol_Click(object sender, EventArgs e)
        {
            Form_Kontrol kont = new Form_Kontrol();
            kont.ShowDialog();
        }
        private void buttonAracTakip_Click(object sender, EventArgs e)
        {
            Form_AracTakip takip = new Form_AracTakip();
            takip.ShowDialog();
        }
    }
}
