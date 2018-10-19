using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakesBruno.Data.Interfaces;
using CakesBruno.Data.Models;
using CakesBruno.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CakesBruno.Data.Controllers
{
    public class CakeController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICakeRepository _cakeRepository;

        public CakeController(ICategoryRepository categoryRepository, ICakeRepository cakeRepository)
        {
            _categoryRepository = categoryRepository;
            _cakeRepository = cakeRepository;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Cake> cakes;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                cakes = _cakeRepository.Cakes.OrderBy(p => p.CakeId);
                currentCategory = "All Cakes";
            }
            else
            {
                if (string.Equals("Weeding Cake", _category, StringComparison.OrdinalIgnoreCase))
                    cakes = _cakeRepository.Cakes.Where(p => p.Category.CategoryName.Equals("Weeding Cake")).OrderBy(p => p.Name);
                else
                    cakes = _cakeRepository.Cakes.Where(p => p.Category.CategoryName.Equals("Birthday Cake")).OrderBy(p => p.Name);

                currentCategory = _category;
            }

            return View(new CakeListViewModel
            {
                Cakes = cakes,
                CurrentCategory = currentCategory
            });
        }
    }
}
