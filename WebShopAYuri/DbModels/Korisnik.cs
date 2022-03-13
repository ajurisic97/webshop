using System;
using System.Collections.Generic;

namespace WebShopAYuri.DbModels
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            LogInfo = new HashSet<LogInfo>();
            Racun = new HashSet<Racun>();
        }

        public int Idkorisnik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string KorisnikPassword { get; set; }

        public virtual ICollection<LogInfo> LogInfo { get; set; }
        public virtual ICollection<Racun> Racun { get; set; }
    }
}
