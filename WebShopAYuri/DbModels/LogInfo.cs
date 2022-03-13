using System;
using System.Collections.Generic;

namespace WebShopAYuri.DbModels
{
    public partial class LogInfo
    {
        public int IdlogInfo { get; set; }
        public int? KorisnikId { get; set; }
        public string LogDate { get; set; }
        public string Ipadress { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}
