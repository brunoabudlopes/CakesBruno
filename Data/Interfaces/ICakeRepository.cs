using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakesBruno.Data.Models;

namespace CakesBruno.Data.Interfaces
{
    public interface ICakeRepository
    {
        IEnumerable<Cake> Cakes { get; set; }
        IEnumerable<Cake> PreferredCakes { get; set; }
        Cake GetCakeById(int cakeId);
    }
}
