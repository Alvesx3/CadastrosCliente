using CadastrosCliente.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastrosCliente.Context
{
    public class BaseContext : DbContext
    {
        public DbSet<ClienteModel> Farmacia { get; set; }
        public BaseContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ClienteConnection"));
        }
    }
}
