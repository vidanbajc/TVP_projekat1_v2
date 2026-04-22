using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_projekat1_v2
{
    public class KlijentRezervacija
    {
        public string mesto { get; set; }
        public string drzava { get; set; }
        public string datum_polaska { get; set; }
        public int br_dana { get; set; }
        public int br_rezervisanih { get; set; }
        public double uk_cena { get; set; }

        public KlijentRezervacija() { }
        public KlijentRezervacija(string mesto, string drzava, string datum_polaska, int br_dana, int br_rezervisanih, double uk_cena)
        {
            this.mesto = mesto;
            this.drzava = drzava;
            this.datum_polaska = datum_polaska;
            this.br_dana = br_dana;
            this.br_rezervisanih = br_rezervisanih;
            this.uk_cena = uk_cena;
        }
    }
}
