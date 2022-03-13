using System;
using System.Collections.Generic;

namespace WebShopAYuri.DbModels
{
    public partial class Item
    {
        public int Iditem { get; set; }
        public int? ProizvodId { get; set; }
        public int? RacunId { get; set; }
        public int? Kolicina { get; set; }

        public virtual Proizvod Proizvod { get; set; }
        public virtual Racun Racun { get; set; }
    }
}
