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
        
        bool DuzenlemeModu;
        public KitapEkle(AnaEkran ana)
        {
            InitializeComponent();
            anaEkran = ana;
            DuzenlemeModu = false;
            button2.Text = "EKLE";
        }
        public KitapEkle(AnaEkran ana, kitap kitap)
        {
            InitializeComponent();
            anaEkran = ana;
            DuzenlemeModu = true;
            button2.Text = "DUZENLE";

            textBox1.Text = kitap.ISSN;
            textBox2.Text = kitap.Kitapadi;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitap kitap = new kitap();
            kitap.ISSN = textBox1.Text;
            kitap.Kitapadi = textBox2.Text;
            kitap.Yazar = comboBox1.Text;
            
            if(DuzenlemeModu == false)
            {
                anaEkran.kitapekle(kitap);
            }
            else
            {
                anaEkran.Yazardegistir(kitap);
            }
            anaEkran.Show();
            this.Close();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       

        private void KitapEkle_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < anaEkran.yazarlistesi.Count; i++)
            {
                comboBox1.Items.Add(anaEkran.yazarlistesi[i]);
            }
        }
    }
}