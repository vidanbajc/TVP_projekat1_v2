using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TVP_projekat1_v2
{
    internal class Podaci
    {
        public static List<Korisnik> korisnici = new List<Korisnik>();
        public static List<Destinacija> destinacije = new List<Destinacija>();
        public static List<Rezervacija> rezervacije = new List<Rezervacija>();
        public static List<KlijentRezervacija> klijent_rezervacije = new List<KlijentRezervacija>();

        public static void Sacuvaj()
        {
            XmlSerializer s1 = new XmlSerializer(typeof(List<Korisnik>));
            FileStream fs1 = new FileStream("korisnici.xml", FileMode.Create);
            s1.Serialize(fs1, korisnici);
            fs1.Close();

            XmlSerializer s2 = new XmlSerializer(typeof(List<Destinacija>));
            FileStream fs2 = new FileStream("destinacije.xml", FileMode.Create);
            s2.Serialize(fs2, destinacije);
            fs2.Close();

            XmlSerializer s3 = new XmlSerializer(typeof(List<Rezervacija>));
            FileStream fs3 = new FileStream("rezervacije.xml", FileMode.Create);
            s3.Serialize(fs3, rezervacije);
            fs3.Close();
        }

        public static void Ucitaj()
        {
            if (File.Exists("korisnici.xml"))
            {
                XmlSerializer s1 = new XmlSerializer(typeof(List<Korisnik>));
                FileStream fs1 = new FileStream("korisnici.xml", FileMode.Open);
                korisnici = (List<Korisnik>)s1.Deserialize(fs1);
                fs1.Close();
            }

            if (File.Exists("destinacije.xml"))
            {
                XmlSerializer s2 = new XmlSerializer(typeof(List<Destinacija>));
                FileStream fs2 = new FileStream("destinacije.xml", FileMode.Open);
                destinacije = (List<Destinacija>)s2.Deserialize(fs2);
                fs2.Close();
            }

            if (File.Exists("rezervacije.xml"))
            {
                XmlSerializer s3 = new XmlSerializer(typeof(List<Rezervacija>));
                FileStream fs3 = new FileStream("rezervacije.xml", FileMode.Open);
                rezervacije = (List<Rezervacija>)s3.Deserialize(fs3);
                fs3.Close();
            }
        }

        public static void Inicijalizacija()
        {
            if (File.Exists("korisnici.xml") && File.Exists("destinacije.xml") && File.Exists("rezervacije.xml"))
                return;

            if (File.Exists("korisnici.xml")) { }
            else
            {
                korisnici.Add(new Korisnik(1, "a", "a", "a", "a", "admin"));
                korisnici.Add(new Korisnik(2, "Ognjen", "Colovic", "cj", "sifra", "klijent"));
                korisnici.Add(new Korisnik(3, "Nemanja", "Marinkovic", "sj", "sifra", "klijent"));
                korisnici.Add(new Korisnik(4, "b", "b", "b", "b", "klijent"));
            }

            if (File.Exists("destinacije.xml")) { }
            else
            {
                destinacije.Add(new Destinacija(1, "Arandjelovac", "Srbija", 24000, 6000, 7, 5, DateTime.Now.Date));
                destinacije.Add(new Destinacija(2, "Topola", "Srbija", 24000, 4000, 5, 3, DateTime.Now.Date));
                destinacije.Add(new Destinacija(3, "Jagodina", "Srbija", 32000, 4000, 5, 3, new DateTime(2026, 4, 18)));
            }

            if (File.Exists("rezervacije.xml")) { }
            else
                rezervacije.Add(new Rezervacija(2, 1, 24000, 1, DateTime.Now.Date));

            Sacuvaj();
        }

        public static int NoviIdKorisnik()
        {
            if (korisnici.Count == 0)
                return 1;

            int max = korisnici[0].id_korisnika;

            foreach (var korisnik in korisnici)
            {
                if (korisnik.id_korisnika > max)
                    max = korisnik.id_korisnika;
            }

            return max + 1;
        }

        public static int NoviIdDestinacija()
        {
            if (destinacije.Count == 0)
                return 1;

            int max = destinacije[0].id_destinacije;

            foreach (var destinacija in destinacije)
            {
                if (destinacija.id_destinacije > max)
                    max = destinacija.id_destinacije;
            }

            return max + 1;
        }
    }
}
