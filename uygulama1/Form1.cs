using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGir_Click(object sender, EventArgs e)
        {
            string kullanici_adi;
            kullanici_adi = textBox1.Text;
            if (kullanici_adi == "milliegitim @meb.k12.tr")
            {
                MessageBox.Show("Kullanıcı sisteme kayıtlıdır");
            }
             else
            {
                MessageBox.Show("Kullanıcı adınız yanlıştır");
            }
        }
    }
}