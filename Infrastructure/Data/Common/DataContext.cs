using Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Infrastructure.Data.Common
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Client> Client { get; set; }
        public DbSet<Product> Product { get; set; }
        
    }
}
