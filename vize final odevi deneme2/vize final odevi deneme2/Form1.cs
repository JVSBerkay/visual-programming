using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_final_odevi_deneme2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double vize, final, final2, ort;

        private void button1_Click(object sender, KeyEventArgs e)
        {

        }

        private void form1_load(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double.TryParse(numericUpDown1.Text, out vize);

            double.TryParse(numericUpDown2.Text, out final);



            ort = vize * 0.4 + final * 0.6;


            if (final < 50)

            {

                label3.Text = "Ortalamanız: " + ort + " Harf Notunuz: FF";

                label3.ForeColor = Color.Red;

                MessageBox.Show("(Final) sinavinda baraji gecemediginiz icin Kaldiniz !! :(");

            }


            else

            {

                if (ort >= 90 && ort <= 100)

                {

                    label3.Text = "Ortalamanız: " + ort + " AA (Gectiniz !!) :) ";

                    label3.ForeColor = Color.Green;

                }

                else if (ort >= 80 && ort < 90)

                {

                    label3.Text = "Ortalamanız: " + ort + " BA (Gectiniz !!) :) ";

                    label3.ForeColor = Color.Green;

                }

                else if (ort >= 70 && ort < 80)

                {

                    label3.Text = "Ortalamanız: " + ort + " BB (Gectiniz !!) :) ";

                    label3.ForeColor = Color.Green;

                }

                else if (ort >= 60 && ort < 70)

                {

                    label3.Text = "Ortalamanız: " + ort + " CB (Gectiniz !!) :) ";

                    label3.ForeColor = Color.Green;

                }

                else if (ort >= 50 && ort < 60)

                {

                    label3.Text = "Ortalamanız: " + ort + " CC (Gectiniz !!) :) ";

                    label3.ForeColor = Color.Green;

                }

                else if (ort >= 45 && ort < 50)

                {

                    label3.Text = "Ortalamanız: " + ort + " DD (Kaldiniz !) :( ";

                    label3.ForeColor = Color.Red;

                }

                else if (ort >= 0 && ort < 45)

                {

                    label3.Text = "Ortalamanız: " + ort + " FF (Kaldiniz !) :( ";

                    label3.ForeColor = Color.Red;


                }

            

            }

        }


    }

   
}
