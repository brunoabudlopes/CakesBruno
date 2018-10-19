using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakesBruno.Data.Interfaces;
using CakesBruno.Data.Models;

namespace CakesBruno.Data.Mocks
{
    public class MockCakeRepository : ICakeRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Cake> Cakes
        {
            get
            {
                return new List<Cake>
                {
                    new Cake {
                        Name = "Confetti Birthday Cake",
                        Price = 190.00M, ShortDescription = "Confetti Birthday Cake",
                        LongDescription = "Three layers of fluffy white vanilla bean cake with a hint of almond folded and baked with pastel confetti. Each layer is filled and frosted with vanilla bean buttercream. The cake is topped with pastel confetti and finished with a ribbon border. This birthday cake is perfect for any birthday party. Available in pastel pink or pastel blue.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "../Images/cake5-L.jpg",
                        InStock = true,
                        IsPreferredCake = true,
                        ImageThumbnailUrl = "../Images/test.jpg"
                    },
                    new Cake {
                        Name = "Pumpkin Chocolate Cake",
                        Price = 185.00M, ShortDescription = "Pumpkin Chocolate Cake",
                        LongDescription = "Two layers of pumpkin spice cake with one layer of Valhrona chocolate cake filled with Belgian chocolate chip cream cheese and homemade caramel. Topped with Valhrona chocolate fudge frosting, chopped Heath bars and more caramel. Viggo Mortensen loves our cake for Thanksgiving celebration.",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "../Images/cake2-L.jpg",
                        InStock = true,
                        IsPreferredCake = false,
                        ImageThumbnailUrl = "../Images/test.jpg"
                    },
                    new Cake {
                        Name = "Winter Color Scheme ",
                        Price = 500.95M, ShortDescription = "Winter Color Scheme",
                        LongDescription = "Painted stripes of icy blue, see-through sapphire, and inky jet tied this Las Vegas Custom Cakes creation back to the couple's snowy Nevada venue.",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "../Images/cake3-L.jpg",
                        InStock = true,
                        IsPreferredCake = false,
                        ImageThumbnailUrl = "../Images/test.jpg"
                    },
                    new Cake
                    {
                        Name = "Berries ",
                        Price = 550.95M,
                        ShortDescription = "Berries",
                        LongDescription = "Tuscan Wedding Cakes dotted their gold-dipped dessert with bright fondant strawberries for a destination wedding in Italy.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "../Images/cake4-L.jpg",
                        InStock = true,
                        IsPreferredCake = false,
                        ImageThumbnailUrl = "../Images/test.jpg"
                    }
                };
            }
            set { }
        }
        public IEnumerable<Cake> PreferredCakes { get; set; }
        public Cake GetCakeById(int cakeId)
        {
            throw new NotImplementedException();
        }
    }
}