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
    public partial class YazarEkle : Form
    {
        AnaEkran anaEkran;
        
        public YazarEkle(AnaEkran parametre)
        {
            InitializeComponent();
            anaEkran= parametre;
            
        }

        private void YazarEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitap kitap = new kitap();
            kitap.Yazar = textBox1.Text;

            KitapEkle kitapEkle = new KitapEkle(anaEkran);
            anaEkran.yazarlistesi.Add( textBox1.Text);
            this.Hide();

            anaEkran.Show();
            
        }
    }
}
