using CakesBruno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakesBruno.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Cake> PreferredCakes { get; set; }
    }
}
