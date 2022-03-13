using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopAYuri.Models;

namespace WebShopAYuri.DtoMapper
{
    public class ProizvodDto
    {
        public static Proizvod FromJson(JObject json)
        {
            var id = json["Idproizvod"].ToObject<int>();
            var naziv = json["Naziv"].ToObject<string>();
            var marka = json["Marka"].ToObject<string>();
            var opis = json["Opis"].ToObject<string>();
            var kategorijaId = json["Kategorija"].ToObject<int>();
            var cijena = json["Cijena"].ToObject<double>();
            var slika = json["Img"].ToObject<string>();
            var kategorija = new Kategorija(kategorijaId, "");
            
            


            return new Proizvod(id,naziv,marka,opis,cijena,slika,kategorija);
        }
    }
}
