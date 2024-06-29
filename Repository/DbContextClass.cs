using Microsoft.EntityFrameworkCore;
using Models;
using Microsoft.Extensions.Configuration;


namespace Repository;

public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<StudentDetails> Students { get; set; }
    }
