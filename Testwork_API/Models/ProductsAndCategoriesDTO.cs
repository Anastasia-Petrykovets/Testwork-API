using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testwork_API.Models
{
    internal class ProductsAndCategoriesDTO
    {
        public List<ProductsDTO> Products { get; set; }
        public List<CategoriesDTO> Categories { get; set; }
    }
}
