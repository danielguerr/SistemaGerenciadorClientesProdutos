using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Models.Products
{
    public class ProductCreateViewModel
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public Guid idClient { get; set; }
    }
}
