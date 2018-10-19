using CakesBruno.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakesBruno.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ShoppingCartTotal { get; set; }
    }
}
