using CakesBruno.Data.Interfaces;
using CakesBruno.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakesBruno.Data.Repositories
{
    public class CakeRepository : ICakeRepository
    {
        private readonly AppDbContext _appDbContext;

        public CakeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Cake> Cakes => _appDbContext.Cakes.Include(c => c.Category);

        public IEnumerable<Cake> PreferredCakes => _appDbContext.Cakes.Where(p => p.IsPreferredCake).Include(c => c.Category);

        public Cake GetCakeById(int cakeId) => _appDbContext.Cakes.FirstOrDefault(p => p.CakeId == cakeId);
    }
}
