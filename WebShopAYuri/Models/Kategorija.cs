using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopAYuri.Models
{
    public class Kategorija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        

        public Kategorija(int id, string naz)
        {
            Id = id;
            Naziv = naz;
        }
    }
}
