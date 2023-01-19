using la_mia_pizzeria_crud_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_crud_mvc.Database
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizzes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=MenuPizzeria1;" +
            "Integrated Security=True;TrustServerCertificate=True");
        }

    }

}
