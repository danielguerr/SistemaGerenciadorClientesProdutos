using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces.Repositories;
using Cadastro.Infrastructure.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro.Infrastructure.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _dataContext;
        public ClientRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Client Insert(Client client)
        {
            _dataContext.Client.Add(client);
            _dataContext.SaveChanges();
            return client;
        }

        public void Delete(Client client)
        {
            _dataContext.Client.Remove(client);
            _dataContext.SaveChanges();
        }

        public Client Update(Client client)
        {
            _dataContext.Client.Update(client);
            _dataContext.SaveChanges();
            return client;
        }

        public List<Client> GetAll()
        {
            return _dataContext.Client.ToList();
        }

        public Client GetClientById(Guid id)
        {
            return _dataContext.Client.FirstOrDefault(x => x.Id == id);
        }
    }
}
