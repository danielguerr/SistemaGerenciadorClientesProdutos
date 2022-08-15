using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro.Models.Products;

namespace Cadastro.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IClientService _clientService;
        private readonly IProductService _productService;
        public ProductsController(IProductService productService, IClientService clientService)
        {
            _productService = productService;
            _clientService = clientService;
        }
        public IActionResult Index()
        {
            List<Product> products = _productService.GetAll();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult CreateProduct(ProductCreateViewModel model)
        {
            var client = _clientService.GetClientById(model.idClient);
            _productService.AddProduct(model.Name, model.Value, client);
            return RedirectToAction("Index");
        }
        public IActionResult EditProduct(ProductUpdateViewModel model)
        {
            _productService.Update(model);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(Guid id)
        {
            var product = _productService.GetProductById(id);
            return View(product);
        }

        public IActionResult Delete(ProductDeleteViewModel model)
        {
            _productService.Delete(model.Id);
            return RedirectToAction("Index");
        }
    }
}
