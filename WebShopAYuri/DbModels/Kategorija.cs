using System;
using System.Collections.Generic;

namespace WebShopAYuri.DbModels
{
    public partial class Kategorija
    {
        public Kategorija()
        {
            Proizvod = new HashSet<Proizvod>();
        }

        public int Idkategorija { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Proizvod> Proizvod { get; set; }
    }
}
