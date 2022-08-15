using System;

namespace Cadastro.Domain.Entities
{
    public abstract class Base
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
