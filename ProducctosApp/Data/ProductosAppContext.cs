using Microsoft.EntityFrameworkCore;
using ProducctosApp.Models;

namespace ProducctosApp.Data
{
    public class ProductosAppContext :DbContext
    {
        public DbSet<Producto> Productos {get; set;}
        public ProductosAppContext(DbContextOptions dco): base(dco){

        }
    }
}