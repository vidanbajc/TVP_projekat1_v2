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

        public void Ucitaj()
        {
            Destinacija nadjen = null;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;

            foreach (Rezervacija r in Podaci.rezervacije)
            {
                if (r.id_korisnika_r == id_korisnika)
                {
                    foreach (Destinacija d in Podaci.destinacije)
                    {
                        if (d.id_destinacije == r.id_destinacije_r && d.datum_polaska >= DateTime.Now.Date)
                        {
                            nadjen = d;
                            break;
                        }
                    }
                }

                if (nadjen != null)
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
            //nece da resetuje kako treba
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Podaci.klijent_rezervacije;


            dataGridView2.DataSource = null;
            dataGridView2.SelectionChanged -= dataGridView2_SelectionChanged;
            dataGridView2.DataSource = Podaci.klijent_rezervacije;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
        }

        public void popuni_cb1()
        {
            bool nadjen;
            foreach (Destinacija d in Podaci.destinacije)
            {
                nadjen = false;
                if (cb_mesto.Items.Count == 0)
                    cb_mesto.Items.Add(d.mesto);

                foreach (var cb in cb_mesto.Items)
                {
                    if (cb.ToString() == d.mesto)
                        nadjen = true;
                }
                if (!nadjen)
                    cb_mesto.Items.Add(d.mesto);
            }
        }

        public void popuni_cb2()
        {
            bool nadjen;
            foreach (Destinacija d in Podaci.destinacije)
            {
                nadjen = false;
                if (cb_drzava.Items.Count == 0)
                    cb_drzava.Items.Add(d.drzava);

                foreach (var cb in cb_drzava.Items)
                {
                    if (cb.ToString() == d.drzava)
                        nadjen = true;
                }
                if (!nadjen)
                    cb_drzava.Items.Add(d.drzava);
            }
        }

        private void odjava3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Klijent_Load(object sender, EventArgs e)
        {
            Nadji();
            Ucitaj();

            popuni_cb1();
            popuni_cb2();
        }

        private void Klijent_FormClosed(object sender, FormClosedEventArgs e)
        {
            p.Show();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                DataGridViewRow red = dataGridView2.CurrentRow;

                cb_mesto.Text = red.Cells[0].Value.ToString();
                cb_drzava.Text = red.Cells[1].Value.ToString();
                tb_br_rezervisanih.Text = red.Cells[4].Value.ToString();

                if (DateTime.TryParse(red.Cells[2].Value.ToString(), out DateTime datum))
                    dateTimePicker1.Value = datum;
            }
        }

        private void dodaj_rezervaciju_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cb_mesto.Text) ||
                string.IsNullOrWhiteSpace(cb_drzava.Text) ||
                string.IsNullOrWhiteSpace(tb_br_rezervisanih.Text))
            {
                MessageBox.Show("Morate popuniti sva neophodna polja!", "Upozorenje", MessageBoxButtons.OK);
            }

            else if (dateTimePicker1.Value.Date < DateTime.Now.Date)
                MessageBox.Show("Morate uneti danasnji ili predstojeci datum!", "Upozorenje", MessageBoxButtons.OK);

            else if (int.TryParse(tb_br_rezervisanih.Text, out int br_rezervisanih))
            {
                if (br_rezervisanih < 1)
                {
                    MessageBox.Show("Morate uneti ispravne brojeve (+)!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                int uk_br_mesta = 0;
                int uk_br_rezervisanih = 0;
                int id_destinacije = 0;
                double cena = 0;

                foreach(Destinacija d in Podaci.destinacije)
                {
                    if(d.mesto.ToLower() == cb_mesto.Text.ToLower() &&
                       d.drzava.ToLower() == cb_drzava.Text.ToLower() &&
                       d.datum_polaska.Date == dateTimePicker1.Value.Date)
                    {
                        uk_br_mesta = d.uk_mesta;
                        id_destinacije = d.id_destinacije;
                        cena = d.cena;

                        foreach (Rezervacija r in Podaci.rezervacije)
                        {
                            if(d.id_destinacije == r.id_destinacije_r)
                            {
                                uk_br_rezervisanih += r.br_rezervisanih;
                            }
                        }
                        break;
                    }
                }

                if(uk_br_mesta == 0)
                {
                    MessageBox.Show($"Destinacija koju zelite da rezervisete ne postoji", "Obavestenje", MessageBoxButtons.OK);
                    return;
                }

                if((uk_br_mesta - uk_br_rezervisanih) >= br_rezervisanih)
                {
                    Podaci.rezervacije.Add(new Rezervacija
                    (
                        // videti za popust
                        // da li da cena bude po osobi ili po danu
                        // kao i popust po osobi ili ukupan popust
                        id_korisnika_r: id_korisnika,
                        id_destinacije_r: id_destinacije,
                        uk_cena: cena * br_rezervisanih,
                        br_rezervisanih: br_rezervisanih,
                        datum_vreme: DateTime.Now
                    ));

                    Podaci.Sacuvaj();

                    // ne resetuje
                    MessageBox.Show("Uspesno ste rezervisali destinaciju!", "Upozorenje", MessageBoxButtons.OK);
                    dataGridView2.DataSource = null;
                    Ucitaj();
                }
                else
                {
                    MessageBox.Show($"Zao nam je.\nTrenutno nemamo {br_rezervisanih} mesta za ovu destinaciju", "Obavestenje", MessageBoxButtons.OK);
                    return;
                }
            }
            else
                MessageBox.Show("Niste uneli dobre podatke!", "Upozorenje", MessageBoxButtons.OK);
        }
    }
}
