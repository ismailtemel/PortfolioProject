using PortfolioProject.API.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace PortfolioProject.API.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-7KQ98D0\\SQLEXPRESS;database=PortfolioDb2; integrated security=true;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Category> Categories { get; set; }
    }
}
