using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces.Repositories;
using Cadastro.Domain.Interfaces.Services;
using Cadastro.Models.Products;
using System;
using System.Collections.Generic;

namespace Cadastro.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Delete(Guid id)
        {
            var product = GetProductById(id);
            _productRepository.Delete(product);
        }

        public List<Product> GetAll()
        {
            var product = _productRepository.GetAll();
            return product;
        }

        public Product GetProductById(Guid id)
        {
            var product = _productRepository.GetProductById(id);
            return product;
        }

        public void AddProduct(string name, decimal value, Client client)
        {
            var product = new Product(name, Convert.ToDecimal(value), client);
            var newProduct = _productRepository.AddProduct(product);
        }

        public Product Update(ProductUpdateViewModel product)
        {
            var productUpdate = GetProductById(product.Id);
            if (productUpdate == null) throw new System.Exception("Não foi possível encontrar esse produto: " + product.Id);
            productUpdate.Name = product.Name;
            productUpdate.Value = product.Value;
            productUpdate.Active = product.Active;

            _productRepository.Update(productUpdate);
            return productUpdate;
        }
    }
}
