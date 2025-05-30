using Microsoft.EntityFrameworkCore;
using SSHealthCare.Domain.Entities;


namespace SSHealthCare.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Sidebar> Sidebars { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "Doctor" },
                new Role { Id = 3, Name = "Patient" }
            );
            modelBuilder.Entity<UserRole>().HasData(
               new UserRole { Id = 1, UserId = 1, RoleId = 1 },
               new UserRole { Id = 2, UserId = 2, RoleId = 2 },
               new UserRole { Id = 3, UserId = 3, RoleId = 3 }
            );
            modelBuilder.Entity<Sidebar>().HasData(
              new Sidebar { Id = 1, Name = "AssignRole", RoleId = 1, Path = "test" },
              new Sidebar { Id = 2, Name = "Role", RoleId = 1, Path = "test" },
              new Sidebar { Id = 3, Name = "Country", RoleId = 1, Path = "test" },
              new Sidebar { Id = 4, Name = "State", RoleId = 1, Path = "test" },
              new Sidebar { Id = 5, Name = "District", RoleId = 1, Path = "test" },
              new Sidebar { Id = 6, Name = "TaskManager", RoleId = 1, Path = "test" }


           );
        }
    }
}
