using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakesBruno.Data.Interfaces;
using CakesBruno.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CakesBruno.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;
        public HomeController(ICakeRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredCakes = _cakeRepository.PreferredCakes
            };
            return View(homeViewModel);
        }
    }
}
