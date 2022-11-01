using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace kutuphane_projesi_okul_odevi
{
    
    public partial class AnaEkran : Form
    {
        public ArrayList yazarlistesi = new ArrayList();
        public static string kitapdegistirme1;
        public AnaEkran()
        {
            InitializeComponent();
        }


       
       public void kitapekle (kitap kitap)
        {
            Listbox1.Items.Add(kitap);
        }

        public void Yazardegistir(kitap kitap)
        {
            Listbox1.Items[Listbox1.SelectedIndex]=kitap;
        }
      
        private void AnaEkran_Load(object sender, EventArgs e)
        {
           
        }

       public void yazarEkle(kitap yazar)
        {
            
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle(this);
            kitapEkle.Show();
        }
        

            public void Listbox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
            
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
            KitapEkle kitapekle = new KitapEkle(this, (kitap)Listbox1.Items[Listbox1.SelectedIndex]);
            this.Hide();
            kitapekle.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilmiskitap = Listbox1.SelectedIndex;
            DialogResult dialogResult = MessageBox.Show("Kitabi Silmek Istediginize emin misiniz", "Silme Ekrani", MessageBoxButtons.YesNo);
                if (dialogResult ==DialogResult.Yes) {
                Listbox1.Items.RemoveAt(secilmiskitap);
            }
            else { }
          

        }

        private void button3_Click(object sender, EventArgs e)
        {

            KitapEkle kitapEkle = new KitapEkle(this);
            kitapEkle.Show();
            this.Hide();
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

        private void button4_Click(object sender, EventArgs e)
        {
            YazarEkle yazarEkle = new YazarEkle(this);
            yazarEkle.Show();
            this.Hide();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
