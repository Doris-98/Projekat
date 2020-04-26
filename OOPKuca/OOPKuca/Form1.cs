using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPKuca
{
    public partial class Form1 : Form
    {
        private Kuca[] nizKuca;
        private int brojKuca;
        private Soba[] nizSoba;
        private int brojSoba;

        public Form1()
        {
            InitializeComponent();
            nizKuca = new Kuca[20];
            brojKuca = 0;
            nizSoba = new Soba[20];
            brojSoba = 0;
        }

        private void buttonUnosKuce_Click(object sender, EventArgs e)
        {
            double povrsina;
            int brSoba;
            try
            {
                povrsina = Convert.ToDouble(textBoxPovršinaKuće.Text);
                brSoba = Convert.ToInt32(textBoxBrojSobeUKući.Text);
                Kuca k1 = new Kuca();
                k1.brojSoba = brSoba;
                k1.povrsinaKuce = povrsina;
                bool velika;
                velika = k1.Velika();
                if (velika == true) 
                    MessageBox.Show("Uspešno ste kreirali kuću.\nPo našem kriterijumu Vaša kuća je velika!");
                else
                    MessageBox.Show("Uspešno ste kreirali kuću.\nPo našem kriterijumu Vaša kuća je mala!");
                nizKuca[brojKuca] = k1;
                brojKuca++;
            }
            catch (FormatException)
            {
                MessageBox.Show("Greška pri unosu podataka.");
            }

        }

        private void dugmePodaciOKući_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Površina kuće: " + textBoxPovršinaKuće.Text + "\nBroj soba je: " + textBoxBrojSobeUKući.Text);
        }

        private void dugmeUnosSobe_Click(object sender, EventArgs e)
        {
            double povrsinaSoba;
            string boja;
            try
            {
                povrsinaSoba = Convert.ToDouble(textBoxPovrsinaSobe.Text);
                boja = textBoxBojaSobe.Text;
                Soba s1 = new Soba();
                s1.povrsinaSoba = povrsinaSoba;
                s1.boja = boja;
                MessageBox.Show("Uspešno ste kreirali sobu.");
                nizSoba[brojSoba] = s1;
                brojSoba++;
            }
            catch (FormatException)
            {
                MessageBox.Show("Greška pri unosu podataka. \nMolimo Vas unesite broj.");
            }
        }

        private void DugmeIspisSoba_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Površina sobe: " + textBoxPovrsinaSobe.Text + "\nBoja soba je: " + textBoxBojaSobe.Text);
        }

        private void dugmeNovaPovršina_Click(object sender, EventArgs e)
        {
            double novaPovršina;
            string novaBoja;
            try
            {
                novaPovršina = Convert.ToDouble(textBoxNovaPovršina.Text);
                novaBoja = textBoxNovaBoja.Text;
                textBoxPovrsinaSobe.Text = textBoxNovaPovršina.Text;
                textBoxBojaSobe.Text = textBoxNovaBoja.Text;
                MessageBox.Show("Uspešno ste uneli nove podatke sobe.");
            }
            catch
            {
                MessageBox.Show("Greška pri unosu podataka. \nMolimo Vas unesite broj.");
            }
        }

        private void dugmeIzlistavanje_Click(object sender, EventArgs e)
        {
            int brojMalihKuca = 0;
            int brojVelikihKuca = 0;
            for (int i = 0; i < brojKuca; i++)
            {
                if (nizKuca[i].Velika())
                    brojVelikihKuca++;
                else
                    brojMalihKuca++;
            }
            MessageBox.Show("U nizu postoji " + brojVelikihKuca + " velika/e kuća/e i " + brojMalihKuca + " mala/e kuća/e.");
        }
    }
}
