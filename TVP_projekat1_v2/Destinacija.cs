using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_projekat1_v2
{
    public class Destinacija
    {
        public int id_destinacije { get; set; }
        public string mesto { get; set; }
        public string drzava { get; set; }
        public double cena { get; set; }
        public double popust { get; set; }
        public int br_dana { get; set; }
        public int uk_mesta { get; set; }
        public DateTime datum_polaska { get; set; }

        public Destinacija() { }

        public Destinacija(int id_destinacije, string mesto, string drzava, double cena, double popust, int br_dana, int uk_mesta, DateTime datum_polaska)
        {
            this.id_destinacije = id_destinacije;
            this.mesto = mesto;
            this.drzava = drzava;
            this.cena = cena;
            this.popust = popust;
            this.br_dana = br_dana;
            this.uk_mesta = uk_mesta;
            this.datum_polaska = datum_polaska;
        }
    }
}
