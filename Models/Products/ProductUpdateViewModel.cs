using System;

namespace Cadastro.Models.Products
{
    public class ProductUpdateViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool Active { get; set; }
    }
}
