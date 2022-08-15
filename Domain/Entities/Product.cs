using System;

namespace Cadastro.Domain.Entities
{
    public class Product : Base
    {
        public decimal Value { get; set; }
        public Client Client { get; set; }

        public Product()
        {

        }
        public Product(string name, decimal value, Client client)
        {
            Id = Guid.NewGuid();
            Name = name;
            Value = value;
            Active = true;
            Client = client;
        }
    }
}
