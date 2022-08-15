using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        public Product GetProductById(Guid id);
        public List<Product> GetAll();
        public Product AddProduct(Product product);
        public Product Update(Product product);
        public void Delete(Product product);
    }
}
