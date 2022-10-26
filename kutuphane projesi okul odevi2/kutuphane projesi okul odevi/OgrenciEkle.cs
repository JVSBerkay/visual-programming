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
    public partial class OgrenciEkle : Form
    {
        AnaEkran anaEkran;
        public OgrenciEkle(AnaEkran parametre2)
        {
            InitializeComponent();
            anaEkran = parametre2;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(" Adi = "+textBox1.Text+" Soyadi = "+textBox2.Text+" Numarasi = "+textBox3.Text) ;
        }

        private void OgrenciEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkran.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Secilmisogrenci = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(Secilmisogrenci);
        }

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
