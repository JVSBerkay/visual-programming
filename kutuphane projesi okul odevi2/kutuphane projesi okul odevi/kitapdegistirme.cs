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
    public partial class kitapdegistirme : Form
    {
    
        
        AnaEkran anaEkran;
        public kitapdegistirme(AnaEkran parametredengelen)
        {
            InitializeComponent();
            anaEkran = parametredengelen;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
         dialog= MessageBox.Show("YAZAR ve KITAP Degistirilecek Emin Misiniz ?!","UYARI",MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                anaEkran.Yazardegistir("Kitap = " + textBox1.Text + " Yazar = " + textBox2.Text);
                anaEkran.Show();
                this.Hide();
            }
            else
            {
               
            }

          
        }
        
          


        

        private void kitapdegistirme_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkran.Show();
        }


       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void kitapdegistirme_Load(object sender, EventArgs e)
        {
            textBox3.Text = AnaEkran.kitapdegistirme1;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kitap bilgilerini duzenlemek icin yukarida ki kutucuklara yaziniz!!");
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Kitap bilgilerini duzenlemek icin yukarida ki kutucuklara yaziniz!!");
        }
    }
}