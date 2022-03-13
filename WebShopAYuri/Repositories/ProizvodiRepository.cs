using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopAYuri.DbModels;
using WebShopAYuri.Mappers;

namespace WebShopAYuri.Repositories
{
    public class ProizvodiRepository
    {
        private readonly WebShopAndeloContext _dbContext;
        public ProizvodiRepository(WebShopAndeloContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public object ProizvodiMapper { get; private set; }

        public IEnumerable<Models.Proizvod> GetAll()
        {
            
            return _dbContext.Proizvod
                .Include(x=>x.Kategorija)
                .Select(x => ProizvodMapper.FromDataBase(x));
        }

        public void Save(Models.Proizvod jedanProizvod)
        {
            var dbProizvod = ProizvodMapper.ToDataBase(jedanProizvod);
            _dbContext.Proizvod.Add(dbProizvod);
            _dbContext.SaveChanges();
        }

    }
}
