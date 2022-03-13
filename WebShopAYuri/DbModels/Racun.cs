using System;
using System.Collections.Generic;

namespace WebShopAYuri.DbModels
{
    public partial class Racun
    {
        public Racun()
        {
            Item = new HashSet<Item>();
        }

        public int Idracun { get; set; }
        public string RacunDatum { get; set; }
        public int? KorisnikId { get; set; }
        public int? NacinPlacanjaId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual NacinPlacanja NacinPlacanja { get; set; }
        public virtual ICollection<Item> Item { get; set; }
    }
}
