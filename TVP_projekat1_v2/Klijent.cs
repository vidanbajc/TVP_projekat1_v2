using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_projekat1_v2
{
    public partial class Klijent : Form
    {
        public Pocetna p;
        private string korisnicko_ime;
        private int id_korisnika;
        public Klijent(Pocetna p, string korisnicko_ime)
        {
            InitializeComponent();
            this.p = p;
            this.korisnicko_ime = korisnicko_ime;
        }

        public void Nadji()
        {
            foreach(Korisnik k in Podaci.korisnici)
            {
                if (k.korisnicko_ime1 == korisnicko_ime) 
                {
                    id_korisnika = k.id_korisnika;
                    break;
                }
            }
        }

        private void odjava3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Klijent_Load(object sender, EventArgs e)
        {
            Nadji();
            Destinacija nadjen = null;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;

            foreach (Rezervacija r in Podaci.rezervacije)
            {
                if(r.id_korisnika_r == id_korisnika)
                {
                    foreach(Destinacija d in Podaci.destinacije)
                    {
                        if(d.id_destinacije == r.id_destinacije_r)
                        {
                            nadjen = d; 
                            break;
                        }
                    }

                }

                if(nadjen != null)
                {
                    KlijentRezervacija kr = new KlijentRezervacija();

                    kr.mesto = nadjen.mesto;
                    kr.drzava = nadjen.drzava;
                    kr.datum_polaska = nadjen.datum_polaska.ToShortDateString();
                    kr.br_dana = nadjen.br_dana;
                    kr.br_rezervisanih = r.br_rezervisanih;
                    kr.uk_cena = r.uk_cena;

                    Podaci.klijent_rezervacije.Add(kr);
                }
            }

            dataGridView1.DataSource = Podaci.klijent_rezervacije;
            dataGridView2.DataSource = Podaci.klijent_rezervacije;
        }

        private void Klijent_FormClosed(object sender, FormClosedEventArgs e)
        {
            p.Show();
        }
    }
}
