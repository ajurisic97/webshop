using System;
using System.Collections.Generic;

namespace WebShopAYuri.DbModels
{
    public partial class NacinPlacanja
    {
        public NacinPlacanja()
        {
            Racun = new HashSet<Racun>();
        }

        public int IdnacinPlacanja { get; set; }
        public string NacinPlacanjaNaziv { get; set; }

        public virtual ICollection<Racun> Racun { get; set; }
    }
}
