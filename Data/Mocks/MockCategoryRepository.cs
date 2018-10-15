using CakesBruno.Data.Interfaces;
using CakesBruno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakesBruno.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Wedding Cakes", Description = "All wedding cakes"},
                    new Category { CategoryName = "Birthday Cakes", Description = "All birthday cakes"}
                };
            }
        }
    }
}
