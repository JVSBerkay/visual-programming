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
    public partial class ogrenciduzenleme : Form
    {
        OgrenciEkle ogrenciEkle;
        public ogrenciduzenleme(OgrenciEkle parametredenogrenciduzenleme)
        {
            InitializeComponent();
            ogrenciEkle = parametredenogrenciduzenleme;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciEkle.ogrencidegistirme(" Adi = " + textBox1.Text + " Soyadi = " + textBox2.Text + " Numarasi = " + textBox3.Text);
            this.Hide();
        }
      
            private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text  == null|| textBox1.Text == null || textBox3.Text==null)
            {
                button1.Enabled = false;
               
            }
            else
            {
                button1.Enabled = true ;
              
            }
        }

     

       
        }
    }

