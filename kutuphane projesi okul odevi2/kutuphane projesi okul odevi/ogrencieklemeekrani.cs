using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_projesi_okul_odevi
{
    public partial class ogrencieklemeekrani : Form
    {
        OgrenciEkle ogrenciEkle;
        public ogrencieklemeekrani(OgrenciEkle parametredenogrenciekle)
        {
            InitializeComponent();
            ogrenciEkle = parametredenogrenciekle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciEkle.ogrekle(" Adi = " + textBox1.Text + " Soyadi = " + textBox2.Text + " Numarasi = " + textBox3.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text == null || textBox2.Text == null|| textBox3.Text == null)
            {
                button1.Enabled = false;

            }
            else
            {
                button1.Enabled = true;

            }
        }

        private void ogrencieklemeekrani_Load(object sender, EventArgs e)
        {

        }
    }
}
