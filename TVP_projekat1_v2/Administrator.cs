using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TVP_projekat1_v2
{
    public partial class Administrator : Form
    {
        public Pocetna p;
        private string korisnicko_ime;
        public Administrator(Pocetna p, string korisnicko_ime)
        {
            InitializeComponent();
            this.p = p;
            this.korisnicko_ime = korisnicko_ime;
        }

        private void Administrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            p.Show();
        }

        public void Ocisti()
        {
            tb_id_korisnik.Clear();
            tb_ime.Clear();
            tb_prezime.Clear();
            tb_korisnicko_ime.Clear();
            tb_lozinka.Clear();
            tb_vrsta.Clear();


            tb_id_destinacije.Clear();
            tb_mesto.Clear();
            tb_drzava.Clear();
            tb_cena.Clear();
            tb_popust.Clear();
            tb_br_dana.Clear();
            tb_uk_mesta.Clear();
            dateTimePicker2.ResetText();


            tb_id_korisnika_r.Clear();
            tb_id_destinacije_r.Clear();
            tb_uk_cena.Clear();
            tb_br_rezervisanih_mesta.Clear();
        }

        private void dodaj_korisnika_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_ime.Text) || string.IsNullOrWhiteSpace(tb_prezime.Text) ||
                   string.IsNullOrWhiteSpace(tb_korisnicko_ime.Text) || string.IsNullOrWhiteSpace(tb_lozinka.Text) ||
                   string.IsNullOrWhiteSpace(tb_vrsta.Text))
            {
                MessageBox.Show("Morate popuniti sva neophodna polja!", "Upozorenje", MessageBoxButtons.OK);
            }

            else if (tb_vrsta.Text != "admin" && tb_vrsta.Text != "klijent")
                MessageBox.Show("Morate uneti validnu vrstu korisnika!", "Upozorenje", MessageBoxButtons.OK);

            else
            {
                string korisnicko_ime = tb_korisnicko_ime.Text;

                foreach (Korisnik k in Podaci.korisnici)
                {
                    if (k.korisnicko_ime1.ToString() == korisnicko_ime)
                    {
                        MessageBox.Show($"Korisnicko ime {korisnicko_ime} je zauzeto, pokusajte ponovo!", "Upozorenje", MessageBoxButtons.OK);
                        return;
                    }
                }

                int id = Podaci.NoviIdKorisnik();

                Podaci.korisnici.Add(new Korisnik
                (
                    id_korisnika: id,
                    ime: tb_ime.Text,
                    prezime: tb_prezime.Text,
                    korisnicko_ime1: tb_korisnicko_ime.Text,
                    lozinka: tb_lozinka.Text,
                    vrsta_korisnika: tb_vrsta.Text
                ));

                Podaci.Sacuvaj();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Podaci.korisnici;

                MessageBox.Show("Uspesno ste dodali novog korisnika!", "Obavestenje", MessageBoxButtons.OK);
                Ocisti();
            }
        }

        private void dodaj_destinaciju_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_mesto.Text) || string.IsNullOrWhiteSpace(tb_drzava.Text) ||
                   string.IsNullOrWhiteSpace(tb_cena.Text) || string.IsNullOrWhiteSpace(tb_popust.Text) ||
                   string.IsNullOrWhiteSpace(tb_br_dana.Text) || string.IsNullOrWhiteSpace(tb_uk_mesta.Text))
            {
                MessageBox.Show("Morate popuniti sva neophodna polja!", "Upozorenje", MessageBoxButtons.OK);
            }

            else if (dateTimePicker2.Value.Date <= DateTime.Now.Date)
                MessageBox.Show("Morate uneti danasnji ili predstojeci datum!", "Upozorenje", MessageBoxButtons.OK);

            else if (double.TryParse(tb_cena.Text, out double cena) &&
                     double.TryParse(tb_popust.Text, out double popust) &&
                     int.TryParse(tb_br_dana.Text, out int br_dana) &&
                     int.TryParse(tb_uk_mesta.Text, out int uk_mesta))
            {
                if (cena < 0 || popust < 0 || br_dana < 1 || uk_mesta < 1)
                {
                    MessageBox.Show("Morate uneti ispravne brojeve (+)!");
                    return;
                }

                // Dugme Dodaj za Destinaciju - admin ne moze da napravi novu destinaciju/izlet, ako takva skroz ista (bez id) vec postoji
                // videti oko datuma, nije mi prihvatilo danasnji datum

                int id = Podaci.NoviIdDestinacija();

                Podaci.destinacije.Add(new Destinacija
                (
                    id_destinacije: id,
                    mesto: tb_mesto.Text,
                    drzava: tb_drzava.Text,
                    cena: cena,
                    popust: popust,
                    br_dana: br_dana,
                    uk_mesta: uk_mesta,
                    datum_polaska: dateTimePicker2.Value
                ));

                Podaci.Sacuvaj();

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = Podaci.destinacije;

                MessageBox.Show("Uspesno ste dodali novu destinaciju!", "Obavestenje", MessageBoxButtons.OK);
                Ocisti();
            }

            else
                MessageBox.Show("Morate uneti ispravno formatirane brojeve (napisane ciframa)!", "Upozorenje", MessageBoxButtons.OK);
        }

        private void dodaj_rezervaciju_Click(object sender, EventArgs e)
        {
            // videti oko datuma, nije mi prihvatilo danasnji datum
            if (string.IsNullOrWhiteSpace(tb_id_korisnika_r.Text) || string.IsNullOrWhiteSpace(tb_id_destinacije_r.Text) ||
                   string.IsNullOrWhiteSpace(tb_uk_cena.Text) || string.IsNullOrWhiteSpace(tb_br_rezervisanih_mesta.Text))
            {
                MessageBox.Show("Morate popuniti sva neophodna polja!", "Upozorenje", MessageBoxButtons.OK);
            }

            else if (int.TryParse(tb_id_korisnika_r.Text, out int id_korisnika) &&
                     int.TryParse(tb_id_destinacije_r.Text, out int id_izleta) &&
                     double.TryParse(tb_uk_cena.Text, out double uk_cena) &&
                     int.TryParse(tb_br_rezervisanih_mesta.Text, out int broj_rezervisanih))
            {
                if (uk_cena < 0 || broj_rezervisanih < 1)
                {
                    MessageBox.Show("Morate uneti ispravne brojeve (+)!");
                    return;
                }

                Korisnik kor = null;
                Destinacija des = null;

                foreach (Korisnik k in Podaci.korisnici)
                {
                    if (k.id_korisnika == id_korisnika)
                    {
                        kor = k;
                        break;
                    }
                }

                foreach (Destinacija d in Podaci.destinacije)
                {
                    if (d.id_destinacije == id_izleta)
                    {
                        des = d;
                        break;
                    }
                }

                if (kor == null || des == null)
                {
                    MessageBox.Show("Morate uneti postojece korisnike i destinacije (id)!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                Podaci.rezervacije.Add(new Rezervacija
                (
                    id_korisnika_r: id_korisnika,
                    id_destinacije_r: id_izleta,
                    uk_cena: uk_cena,
                    br_rezervisanih: broj_rezervisanih,
                    datum_vreme: DateTime.Now
                ));

                Podaci.Sacuvaj();

                dataGridView3.DataSource = null;
                dataGridView3.DataSource = Podaci.rezervacije;

                MessageBox.Show("Uspesno ste dodali novu rezervaciju!", "Obavestenje", MessageBoxButtons.OK);
                Ocisti();
            }
        }

        private void izmeni_korisnika_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || string.IsNullOrWhiteSpace(tb_id_korisnik.Text))
            {
                MessageBox.Show("Morate selektovati red sa id-jem!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            DataGridViewRow red = dataGridView1.CurrentRow;
            Korisnik nadjen = null;
            string id = red.Cells[0].Value.ToString();

            foreach (Korisnik k in Podaci.korisnici)
            {
                if (k.id_korisnika.ToString() == id)
                {
                    nadjen = k;
                    break;
                }
            }

            if (nadjen == null)
            {
                MessageBox.Show("Korisnik nije pronadjen!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if (tb_vrsta.Text != "admin" && tb_vrsta.Text != "klijent")
            {
                MessageBox.Show("Morate uneti validnu vrstu korisnika!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if (tb_id_korisnik.Text != id)
            {
                MessageBox.Show("Zabranjeno je menjanje id-jeva!", "Upozorenje", MessageBoxButtons.OK);
                tb_id_korisnik.Text = id;
                return;
            }

            // Dugme Izmeni za Korisnika - obezbedi da korisnicko_ime ne moze da bude promenjeno u isto ili vec postojece.

            nadjen.ime = tb_ime.Text;
            nadjen.prezime = tb_prezime.Text;
            nadjen.korisnicko_ime1 = tb_korisnicko_ime.Text;
            nadjen.lozinka = tb_lozinka.Text;
            nadjen.vrsta_korisnika = tb_vrsta.Text;

            Podaci.Sacuvaj();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Podaci.korisnici;

            MessageBox.Show("Uspesno ste izmenili podatke o korisniku!", "Obavestenje", MessageBoxButtons.OK);
            Ocisti();
        }

        private void izmeni_destinaciju_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null && string.IsNullOrWhiteSpace(tb_id_destinacije.Text))
            {
                MessageBox.Show("Morate selektovati red sa id-jem!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            /*Dugme Izmeni za Destinaciju - ogranici da admin ne moze da izmeni destinaciju, ako za istu vec postoji rezervacija
                     niti moze da je promeni da bude ista kao neka koja vec postoji
                     niti destinacija sme da bude u proslosti od DataTime.Today (imas kod u Dodaj)*/

            DataGridViewRow red = dataGridView2.CurrentRow;
            Destinacija nadjen = null;
            string id = red.Cells[0].Value.ToString();

            foreach (Destinacija d in Podaci.destinacije)
            {
                if (d.id_destinacije.ToString() == id)
                {
                    nadjen = d;
                    break;
                }
            }

            if (nadjen == null)
            {
                MessageBox.Show("Destinacija nije pronadjena!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if (tb_id_destinacije.Text != id)
            {
                MessageBox.Show("Zabranjeno je menjanje id-jeva!", "Upozorenje", MessageBoxButtons.OK);
                tb_id_destinacije.Text = id;
                return;
            }

            //tryparse umesto neproverenog convert
            nadjen.mesto = tb_mesto.Text;
            nadjen.drzava = tb_drzava.Text;
            nadjen.cena = Convert.ToInt32(tb_cena.Text);
            nadjen.popust = Convert.ToInt32(tb_popust.Text);
            nadjen.br_dana = Convert.ToInt32(tb_br_dana.Text); 
            nadjen.uk_mesta = Convert.ToInt32(tb_uk_mesta.Text);
            // mora da se gleda i oko datuma, da li sme da se menja, za izlet/destinaciju vrv treba, 
            // a za rezervaciju ne zato sto je datum nastao kada i sama rezervacija i nemoguce je to promeniti

            //ee a sada nzm za ovo razmisli sutra
            //nadjen[7] = dateTimePicker1.Value;

            Podaci.Sacuvaj();

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = Podaci.destinacije;

            MessageBox.Show("Uspesno ste izmenili podatke o destinaciji!", "Obavestenje", MessageBoxButtons.OK);
            Ocisti();
        }

        private void izmeni_rezervaciju_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow == null || string.IsNullOrWhiteSpace(tb_id_korisnika_r.Text) || string.IsNullOrWhiteSpace(tb_id_destinacije_r.Text))
            {
                MessageBox.Show("Morate selektovati red sa id-jem!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            DataGridViewRow red = dataGridView3.CurrentRow;
            Rezervacija nadjen = null;
            string id_korisnika = red.Cells[0].Value.ToString();
            string id_izleta = red.Cells[1].Value.ToString();

            //dodati jos neki uslov ako je korisnik rezervisao istu destinaciju dvaput 2.0
            //na primer vreme

            foreach (Rezervacija r in Podaci.rezervacije)
            {
                if (r.id_korisnika_r.ToString() == id_korisnika && r.id_destinacije_r.ToString() == id_izleta)
                {
                    nadjen = r;
                    break;
                }
            }

            if (nadjen == null)
            {
                MessageBox.Show("Rezervacija nije pronadjena!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if (tb_id_korisnika_r.Text != id_korisnika || tb_id_destinacije_r.Text != id_izleta)
            {
                MessageBox.Show("Zabranjeno je menjanje id-jeva!", "Upozorenje", MessageBoxButtons.OK);
                tb_id_korisnika_r.Text = id_korisnika;
                tb_id_destinacije_r.Text = id_izleta;
                return;
            }

            /*Dugme Izmeni za Rezervaciju - dodati proveru da li su novi podaci za uk_cena i br_rezervisanih validni
                     (imas kod u Dugme Dodaj za Destinaciju)*/
            //pa reko sam
            //ubaciti tryparse ili nesto da proverimo da li uopste moze da konvertuje
            nadjen.uk_cena = Convert.ToInt32(tb_uk_cena.Text);
            nadjen.br_rezervisanih = Convert.ToInt32(tb_br_rezervisanih_mesta.Text);
            //nadjen[4] = dateTimePicker1.Value;

            Podaci.Sacuvaj();

            dataGridView3.DataSource = null;
            dataGridView3.DataSource = Podaci.rezervacije;

            MessageBox.Show("Uspesno ste izmenili podatke o rezervaciji!", "Obavestenje", MessageBoxButtons.OK);
            Ocisti();
        }

        private void obrisi_korisnika_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null && string.IsNullOrWhiteSpace(tb_id_korisnik.Text))
            {
                MessageBox.Show("Morate selektovati red sa id-jem!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            DataGridViewRow red = dataGridView1.CurrentRow;
            Korisnik nadjen = null;
            string id = red.Cells[0].Value.ToString();

            foreach (Korisnik k in Podaci.korisnici)
            {
                if (k.id_korisnika.ToString() == id)
                {
                    nadjen = k;
                    break;
                }
            }

            if (nadjen == null)
            {
                MessageBox.Show($"Korisnik sa id {id} nije pronadjen!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }
            else if (nadjen.korisnicko_ime1.ToString() == korisnicko_ime)
            {
                MessageBox.Show($"Ne mozete obrisati nalog preko koga ste prijavljeni!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            foreach (Rezervacija r in Podaci.rezervacije)
            {
                if (r.id_korisnika_r.ToString() == id)
                {
                    MessageBox.Show($"Nije moguce obrisati korisnika {tb_id_korisnik.Text} - {tb_korisnicko_ime.Text}, posto ima rezervaciju!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }
            }

            DialogResult yes_no = MessageBox.Show($"Da li ste sigurni da zelite da obrisete korisnika {tb_id_korisnik.Text} - {tb_korisnicko_ime.Text}?", "Pitanje", MessageBoxButtons.YesNo);

            if (yes_no == DialogResult.Yes)
            {
                Podaci.korisnici.Remove(nadjen);
                Podaci.Sacuvaj();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Podaci.korisnici;

                MessageBox.Show($"Uspesno ste obrisali korisnika {tb_korisnicko_ime.Text}!", "Obavestenje", MessageBoxButtons.OK);
                Ocisti();
            }
            else
            {
                Ocisti();
                return;
            }
        }

        private void obrisi_destinaciju_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null || string.IsNullOrWhiteSpace(tb_id_destinacije.Text))
            {
                MessageBox.Show("Morate selektovati red sa id-jem!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            DataGridViewRow red = dataGridView2.CurrentRow;
            Destinacija nadjen = null;
            string id = red.Cells[0].Value.ToString();

            foreach (Destinacija d in Podaci.destinacije)
            {
                if (d.id_destinacije.ToString() == id)
                {
                    nadjen = d;
                    break;
                }
            }

            if (nadjen == null)
            {
                MessageBox.Show("Destinacija nije pronadjena!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            foreach (Rezervacija r in Podaci.rezervacije)
            {
                if (r.id_destinacije_r.ToString() == id)
                {
                    MessageBox.Show($"Nije moguce obrisati destinaciju {tb_id_destinacije.Text} - {tb_mesto.Text} {tb_drzava.Text}, posto ima rezervaciju!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }
            }

            DialogResult yes_no = MessageBox.Show($"Da li ste sigurni da zelite da obrisete destinaciju {tb_id_destinacije.Text} - {tb_mesto.Text} {tb_drzava.Text}?", "Pitanje", MessageBoxButtons.YesNo);

            if (yes_no == DialogResult.Yes)
            {
                Podaci.destinacije.Remove(nadjen);
                Podaci.Sacuvaj();

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = Podaci.destinacije;

                MessageBox.Show($"Uspesno ste obrisali destinaciju {tb_id_destinacije.Text} - {tb_mesto.Text} {tb_drzava.Text}!", "Obavestenje", MessageBoxButtons.OK);
                Ocisti();
            }
            else
            {
                Ocisti();
                return;
            }
        }

        private void obrisi_rezervaciju_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow == null || string.IsNullOrWhiteSpace(tb_id_korisnika_r.Text) || string.IsNullOrWhiteSpace(tb_id_destinacije_r.Text))
            {
                MessageBox.Show("Morate selektovati red sa id-jem!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            DataGridViewRow red = dataGridView3.CurrentRow;
            Rezervacija nadjen = null;

            string id_korisnika = red.Cells[0].Value.ToString();
            string id_destinacije = red.Cells[1].Value.ToString();

            foreach (Rezervacija r in Podaci.rezervacije)
            {
                //dodati jos neki uslov ako je korisnik rezervisao istu destinaciju dvaput
                //na primer vreme
                if (r.id_korisnika_r.ToString() == id_korisnika && r.id_destinacije_r.ToString() == id_destinacije)
                {
                    nadjen = r;
                    break;
                }
            }

            if (nadjen == null)
            {
                MessageBox.Show("Rezervacija nije pronadjena!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }
            else
            {
                DialogResult yes_no = MessageBox.Show($"Da li ste sigurni da zelite da obrisete rezervaciju {id_korisnika} - {id_destinacije}?", "Pitanje", MessageBoxButtons.YesNo);

                if (yes_no == DialogResult.Yes)
                {
                    Podaci.rezervacije.Remove(nadjen);
                    Podaci.Sacuvaj();

                    dataGridView3.DataSource = null;
                    dataGridView3.DataSource = Podaci.rezervacije;

                    MessageBox.Show($"Uspesno ste obrisali rezervaciju {tb_id_korisnika_r.Text} - {tb_id_destinacije_r}!", "Obavestenje", MessageBoxButtons.OK);
                    Ocisti();
                }
                else
                {
                    Ocisti();
                    return;
                }
            }
        }

        private void odjava1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void odjava2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void odjava3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            label1.Text = $"Ulogovani ste kao {korisnicko_ime}";
            label18.Text = $"Ulogovani ste kao {korisnicko_ime}";
            label27.Text = $"Ulogovani ste kao {korisnicko_ime}";

            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
            dataGridView1.DataSource = Podaci.korisnici;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            dataGridView2.DataSource = null;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.SelectionChanged -= dataGridView2_SelectionChanged;
            dataGridView2.DataSource = Podaci.destinacije;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            dataGridView2_SelectionChanged(null, null);

            dataGridView3.DataSource = null;
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.SelectionChanged -= dataGridView3_SelectionChanged;
            dataGridView3.DataSource = Podaci.rezervacije;
            dataGridView3.SelectionChanged += dataGridView3_SelectionChanged;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow red = dataGridView1.CurrentRow;

                tb_id_korisnik.Text = red.Cells[0].Value.ToString();
                tb_ime.Text = red.Cells[1].Value.ToString();
                tb_prezime.Text = red.Cells[2].Value.ToString();
                tb_korisnicko_ime.Text = red.Cells[3].Value.ToString();
                tb_lozinka.Text = red.Cells[4].Value.ToString();
                tb_vrsta.Text = red.Cells[5].Value.ToString();
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                DataGridViewRow red = dataGridView2.CurrentRow;

                tb_id_destinacije.Text = red.Cells[0].Value.ToString();
                tb_mesto.Text = red.Cells[1].Value.ToString();
                tb_drzava.Text = red.Cells[2].Value.ToString();
                tb_cena.Text = red.Cells[3].Value.ToString();
                tb_popust.Text = red.Cells[4].Value.ToString();
                tb_br_dana.Text = red.Cells[5].Value.ToString();
                tb_uk_mesta.Text = red.Cells[6].Value.ToString();

                if (DateTime.TryParse(red.Cells[7].Value.ToString(), out DateTime datum))
                    dateTimePicker2.Value = datum;
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow != null)
            {
                DataGridViewRow red = dataGridView3.CurrentRow;

                tb_id_korisnika_r.Text = red.Cells[0].Value.ToString();
                tb_id_destinacije_r.Text = red.Cells[1].Value.ToString();
                tb_uk_cena.Text = red.Cells[2].Value.ToString();
                tb_br_rezervisanih_mesta.Text = red.Cells[3].Value.ToString();
            }
        }

        private void Administrator_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            p.Show();
        }
    }
}
