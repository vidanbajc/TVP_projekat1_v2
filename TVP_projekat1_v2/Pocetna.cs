using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TVP_projekat1_v2
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
            Podaci.Inicijalizacija();
            Podaci.Ucitaj();
        }

        private void prijava_Click(object sender, EventArgs e)
        {
            if (tb_korisnicko_ime == null || tb_korisnicko_ime.Text == "")
                MessageBox.Show("Morate uneti korisnicko ime", "Upozorenje", MessageBoxButtons.OK);

            else if (tb_lozinka == null || tb_lozinka.Text == "")
                MessageBox.Show("Morate uneti lozinku", "Upozorenje", MessageBoxButtons.OK);

            else
            {
                string korisnicko_ime = tb_korisnicko_ime.Text;
                string lozinka = tb_lozinka.Text;

                Korisnik korisnik = null;

                foreach (Korisnik x in Podaci.korisnici)
                {
                    if (x.korisnicko_ime1 == korisnicko_ime && x.lozinka == lozinka)
                    {
                        korisnik = x;
                        break;
                    }
                }

                if (korisnik == null)
                    MessageBox.Show("Uneli ste nepostojeceg korisnika, pokusajte ponovo", "Upozorenje", MessageBoxButtons.OK);

                else if (korisnik.vrsta_korisnika == "admin")
                {
                    MessageBox.Show($"Uspesno ste se ulogovali kao {korisnik.vrsta_korisnika} {korisnicko_ime}!", "Dobrodosli", MessageBoxButtons.OK);
                    Administrator a = new Administrator(this, korisnicko_ime);
                    a.Show();

                    tb_korisnicko_ime.Clear();
                    tb_lozinka.Clear();
                    this.Hide();
                }
                else if (korisnik.vrsta_korisnika == "klijent")
                {
                    MessageBox.Show($"Uspesno ste se ulogovali kao {korisnik.vrsta_korisnika} {korisnicko_ime}!", "Dobrodosli", MessageBoxButtons.OK);
                    Klijent k = new Klijent();
                    k.Show();

                    tb_korisnicko_ime.Clear();
                    tb_lozinka.Clear();
                    this.Hide();
                }
            }
        }

        private void izlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
