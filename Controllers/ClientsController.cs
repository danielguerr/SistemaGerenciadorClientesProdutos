using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces.Services;
using Cadastro.Models.Clients;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace Cadastro.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IClientService _clientService;
        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }
        public IActionResult Index()
        {
            List<Client> clients = _clientService.GetAllClients();
            return View(clients);
        }
        public IActionResult Delete(ClientDeleteViewModel model)
        {
            _clientService.DeleteClient(model.Id);
            return RedirectToAction("Index");
        }
        public IActionResult EditClient(ClientUpdateViewModel model)
        {
            _clientService.UpdateClient(model);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(Guid id)
        {
            var client =_clientService.GetClientById(id);
            return View(client);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult CreateClient(ClientCreateViewModel model) 
        {
            _clientService.AddClient(model.Name, model.LastName, model.Email);
            return RedirectToAction("Index");
        }
        

    }
}
