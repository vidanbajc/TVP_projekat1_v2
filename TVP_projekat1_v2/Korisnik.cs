using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_projekat1_v2
{
    public class Korisnik
    {
        public int id_korisnika { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string korisnicko_ime1 { get; set; }
        public string lozinka { get; set; }
        public string vrsta_korisnika { get; set; }

        public Korisnik() { }
        public Korisnik(int id_korisnika, string ime, string prezime, string korisnicko_ime1, string lozinka, string vrsta_korisnika)
        {
            this.id_korisnika = id_korisnika;
            this.ime = ime;
            this.prezime = prezime;
            this.korisnicko_ime1 = korisnicko_ime1;
            this.lozinka = lozinka;
            this.vrsta_korisnika = vrsta_korisnika;
        }
    }
}
