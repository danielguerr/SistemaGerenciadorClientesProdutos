using Cadastro.Domain.Entities;
using Cadastro.Models.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Domain.Interfaces.Services
{
    public interface IClientService
    {
        public List<Client> GetAllClients();
        public Client GetClientById(Guid id);
        public void AddClient(string name, string lastName, string email);
        public Client UpdateClient(ClientUpdateViewModel client);
        public void DeleteClient(Guid id);
    }
}
