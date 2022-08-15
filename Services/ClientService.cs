using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces.Repositories;
using Cadastro.Domain.Interfaces.Services;
using Cadastro.Models.Clients;
using System;
using System.Collections.Generic;
namespace Cadastro.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public void AddClient(string name, string lastName, string email)
        {
            var client = new Client(name, lastName, email);
            var newClient = _clientRepository.Insert(client);
        }

        public void DeleteClient(Guid id)
        {
            var client = GetClientById(id);
            _clientRepository.Delete(client);
        }

        public List<Client> GetAllClients()
        {
            var clients = _clientRepository.GetAll();
            return clients;
        }

        public Client GetClientById(Guid id)
        {
            var client = _clientRepository.GetClientById(id);
            return client;
        }

        public Client UpdateClient(ClientUpdateViewModel model)
        {
            var clientUpdate = GetClientById(model.Id);
            if (clientUpdate == null) throw new System.Exception("Não foi possível encontrar esse cliente: " + model.Id);
            clientUpdate.Name = model.Name;
            clientUpdate.LastName = model.LastName;
            clientUpdate.Email = model.Email;
            clientUpdate.Active = model.Active;

            _clientRepository.Update(clientUpdate);
            return clientUpdate;
        }
    }
}
