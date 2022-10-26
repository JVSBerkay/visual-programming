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
    public partial class AnaEkran : Form
    {
        public static string kitapdegistirme1;
        public AnaEkran()
        {
            InitializeComponent();
        }


        public void KitapEkle(String KitapAdi)
        {
            Listbox1.Items.Add(KitapAdi);


        }
        public void YazarEkle(String YazarAdi)
        {
            Listbox1.Items.Add(YazarAdi);
        }


        public void Yazardegistir(string Yazardegis)
        {
            int secilmiskitap = Listbox1.SelectedIndex;


            Listbox1.Items.Remove(Listbox1.SelectedItem);
            Listbox1.Items.Insert(secilmiskitap,Yazardegis);
        }
      
        private void AnaEkran_Load(object sender, EventArgs e)
        {
           
        }

       

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle(this);
            kitapEkle.Show();
        }
        

            public void Listbox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            kitapdegistirme1 = Listbox1.Text;
            
            if (Listbox1.SelectedIndex >= 0 )
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitapdegistirme kitapdegistirme = new kitapdegistirme(this);
            kitapdegistirme.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilmiskitap = Listbox1.SelectedIndex;
            Listbox1.Items.RemoveAt(secilmiskitap);
          

        }

        private void button3_Click(object sender, EventArgs e)
        {

            KitapEkle kitapEkle = new KitapEkle(this);
            kitapEkle.Show();
            
        }

        private void borclularToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle(this);
            ogrenciEkle.Show();
            this.Hide();
        }
    }
}
