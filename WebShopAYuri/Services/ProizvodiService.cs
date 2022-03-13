using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopAYuri.Models;
using WebShopAYuri.Repositories;

namespace WebShopAYuri.Services
{
    public class ProizvodiService
    {
        private readonly ProizvodiRepository _proizvodiRepository;
        public ProizvodiService(ProizvodiRepository pRepository)
        {
            _proizvodiRepository = pRepository;
        }

        public IEnumerable<Models.Proizvod> GetAll()
        {
            return _proizvodiRepository.GetAll();
        }

        public void Save(Proizvod proizvod)
        {
            _proizvodiRepository.Save(proizvod);
        }

    }
}
