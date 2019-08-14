using Microsoft.EntityFrameworkCore;

namespace CadastroDeClientes.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions opt) : base(opt) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Address> Adresses { get; set; }
        public DbSet<Telephone> Telephones { get; set; }

    }
}