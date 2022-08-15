using System;

namespace Cadastro.Domain.Entities
{
    public class Client : Base
    {
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; }

        public Client(string name, string lastName, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            Email = email;
            Date = DateTime.Now;
            Active = true;
        }
    }
}
