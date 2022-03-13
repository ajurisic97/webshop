using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopAYuri.Models;

namespace WebShopAYuri.Mappers
{
    public class ProizvodMapper
    {
        public static Proizvod FromDataBase(DbModels.Proizvod proizvod)
        {
            var cij = Convert.ToDouble(proizvod.Cijena);
            
            return new Proizvod(
                proizvod.Idproizvod,
                proizvod.Naziv,
                proizvod.Marka,
                proizvod.Opis,
                cij,
                proizvod.Img,
                KategorijaMapper.FromDatabase(proizvod.Kategorija)
                );
        }

        public static DbModels.Proizvod ToDataBase(Proizvod proizvod)
        {
            if (proizvod is null)
            {
                throw new ArgumentNullException(nameof(proizvod));
            }

            return new DbModels.Proizvod
            {
                Idproizvod = proizvod.IdProizvod.HasValue ? proizvod.IdProizvod.Value : 0,
                Naziv = proizvod.Naziv,
                Marka = proizvod.Marka,
                Opis = proizvod.Opis,
                Cijena = proizvod.Cijena,
                Img = proizvod.Slika,
                KategorijaId = proizvod.Kategorija.Id

            };
        }
    }
}
