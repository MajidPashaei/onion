using Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Context
{
    public class ContextDb :DbContext
    {


        // db set
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }


        // conection
        protected override void OnConfiguring(DbContextOptionsBuilder Db)
        {
            Db.UseSqlServer("Data source=.;Initial Catalog=Schools;Integrated Security=True");
        }
    }
}