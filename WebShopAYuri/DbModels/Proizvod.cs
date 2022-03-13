using System;
using System.Collections.Generic;

namespace WebShopAYuri.DbModels
{
    public partial class Proizvod
    {
        public Proizvod()
        {
            Item = new HashSet<Item>();
        }

        public int Idproizvod { get; set; }
        public string Naziv { get; set; }
        public string Marka { get; set; }
        public string Opis { get; set; }
        public double? Cijena { get; set; }
        public string Img { get; set; }
        public int? KategorijaId { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual ICollection<Item> Item { get; set; }
    }
}
