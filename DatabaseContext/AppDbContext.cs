using GenericController.Entities;
using Microsoft.EntityFrameworkCore;

namespace GenericControllerProject.DatabaseContext
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Person> Persons { get; set; }
    }
}
