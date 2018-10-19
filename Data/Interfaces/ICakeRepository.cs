using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakesBruno.Data.Models;

namespace CakesBruno.Data.Interfaces
{
    public interface ICakeRepository
    {
        IEnumerable<Cake> Cakes { get; }
        IEnumerable<Cake> PreferredCakes { get; }
        Cake GetCakeById(int cakeId);
    }
}
