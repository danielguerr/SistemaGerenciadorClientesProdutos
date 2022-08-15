using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces.Repositories;
using Cadastro.Infrastructure.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Infrastructure.Data.Repositories
{

    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _dataContext;
        public ProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Delete(Product product)
        {
            _dataContext.Product.Remove(product);
            _dataContext.SaveChanges();
        }

        public Product GetProductById(Guid id)
        {
            return _dataContext.Product.FirstOrDefault(x => x.Id == id);
        }

        public List<Product> GetAll()
        {
            return _dataContext.Product.Include(x => x.Client).ToList();
        }

        public Product AddProduct(Product product)
        {
            _dataContext.Product.Add(product);
            _dataContext.SaveChanges();
            return product;
        }

        public Product Update(Product product)
        {
            _dataContext.Product.Update(product);
            _dataContext.SaveChanges();
            return product;
        }
    }
}
