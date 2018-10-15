using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakesBruno.Data.Interfaces;
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

        public ViewResult List()
        {
            ViewBag.Name = "DotNet, How?";
            CakeListViewModel vm = new CakeListViewModel();
            vm.Cakes = _cakeRepository.Cakes;
            vm.CurrentCategory = "CakeCategory";
            return View(vm);
        }
    }
}
