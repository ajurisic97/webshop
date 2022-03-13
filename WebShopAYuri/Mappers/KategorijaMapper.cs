using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopAYuri.Models;

namespace WebShopAYuri.Mappers
{
    public class KategorijaMapper
    {
        public static Kategorija FromDatabase(DbModels.Kategorija kategorija)
        {
            return new Kategorija(kategorija.Idkategorija,kategorija.Naziv);
        }
    }
}
