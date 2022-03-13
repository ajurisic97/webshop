using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopAYuri.Models
{
    public class Proizvod
    {
        public string Naziv { get; set; }
        public string Marka { get; set; }
        public string Opis { get; set; }

        public double Cijena { get; set; }

        public string Slika { get; set; }

        public Kategorija Kategorija { get; set; }

        public int? IdProizvod { get; set; }

        public Proizvod(int id,string naziv,string marka,string opis,double cijena,string slika,Kategorija kat)
        {
            IdProizvod = id;
            Naziv = naziv;
            Marka = marka;
            Opis = opis;
            Cijena = cijena;
            Slika = slika;
            Kategorija = kat;
        }




    }
}
