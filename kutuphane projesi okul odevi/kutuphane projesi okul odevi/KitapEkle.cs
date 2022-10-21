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
    public partial class KitapEkle : Form
    {
        AnaEkran anaEkran;
        public KitapEkle(AnaEkran parametresi)
        {
            InitializeComponent();
            anaEkran = parametresi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anaEkran.YazarEkle(" Yazar = " + textBox1.Text + " Kitap = " + textBox2.Text);

            anaEkran.Show();

        }



        private void KitapEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkran.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
             
            }
        }
    }
}