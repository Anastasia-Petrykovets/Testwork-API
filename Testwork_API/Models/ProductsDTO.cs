using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testwork_API.Models
{
    internal class ProductsDTO : DTO
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
}
