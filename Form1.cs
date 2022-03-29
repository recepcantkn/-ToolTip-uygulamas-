using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(txtAd, "Adınızı giriniz.");
            tt.SetToolTip(txtSoyad, "Soyadınızı giriniz.");
            tt.SetToolTip(txtDTarih, "Doğum tarihinizi gg/aa/yyyy şeklinde giriniz.");
            tt.SetToolTip(txtAdres, "Adresinizi giriniz.");
            tt.SetToolTip(btnKaydet, "Kaydetmek için tıklayınız.");
        }
    }
}
