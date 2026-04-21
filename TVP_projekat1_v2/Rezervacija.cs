using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_projekat1_v2
{
    public class Rezervacija
    {
        public int id_korisnika_r { get; set; }
        public int id_destinacije_r { get; set; }
        public double uk_cena { get; set; }
        public int br_rezervisanih { get; set; }
        public DateTime datum_vreme { get; set; }

        public Rezervacija() { }
        public Rezervacija(int id_korisnika_r, int id_destinacije_r, double uk_cena, int br_rezervisanih, DateTime datum_vreme)
        {
            this.id_korisnika_r = id_korisnika_r;
            this.id_destinacije_r = id_destinacije_r;
            this.uk_cena = uk_cena;
            this.br_rezervisanih = br_rezervisanih;
            this.datum_vreme = datum_vreme;
        }
    }
}
