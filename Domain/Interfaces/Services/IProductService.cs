using Cadastro.Domain.Entities;
using Cadastro.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Cadastro.Domain.Interfaces.Services
{
    public interface IProductService
    {
        public Product GetProductById(Guid id);
        public List<Product> GetAll();
        public void AddProduct(string name, decimal value, Client client);
        public Product Update(ProductUpdateViewModel product);
        public void Delete(Guid id);
    }
}
