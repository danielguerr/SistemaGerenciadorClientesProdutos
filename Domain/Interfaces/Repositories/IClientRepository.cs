using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Domain.Interfaces.Repositories
{
    public interface IClientRepository
    {
        public List<Client> GetAll();
        public Client GetClientById(Guid id);
        public Client Insert(Client client);
        public Client Update(Client client);
        public void Delete(Client client);
       
    }
}
