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
        public DbSet<Status> Statuses { get; set; }
        public DbSet<TaskManager> TaskManagers { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<User>().HasData(
                 new User { Id = 1, Email = "shiwansh@gmail.com", Password = "Test@123", Firstname = "Shiwansh", Lastname = "Kumar", Mobile = "9876543210" },

                 new User { Id = 2, Email = "rajuadmin@gmail.com", Password = "Test@123", Firstname = "Raju", Lastname = "Chauhan", Mobile = "9876543211" },
                 new User { Id = 3, Email = "rajudoctor@gmail.com", Password = "Test@123", Firstname = "Raju", Lastname = "Chauhan", Mobile = "9876543212" },
                 new User { Id = 4, Email = "rajupatient@gmail.com", Password = "Test@123", Firstname = "Raju", Lastname = "Chauhan", Mobile = "9876543213" },

                 new User { Id = 5, Email = "vickyadmin@gmail.com", Password = "Test@123", Firstname = "Vicky", Lastname = "Kumar", Mobile = "9876543214" },
                 new User { Id = 6, Email = "vickyemployee@gmail.com", Password = "Test@123", Firstname = "Vicky", Lastname = "Kumar", Mobile = "9876543215" },
                 new User { Id = 7, Email = "vickyemployer@gmail.com", Password = "Test@123", Firstname = "Vicky", Lastname = "Kumar", Mobile = "9876543216" },

                 new User { Id = 8, Email = "avijitadmin@gmail.com", Password = "Test@123", Firstname = "Avijit", Lastname = "Gorai", Mobile = "9876543217" },
                 new User { Id = 9, Email = "avijitowner@gmail.com", Password = "Test@123", Firstname = "Avijit", Lastname = "Gorai", Mobile = "9876543218" },
                 new User { Id = 10, Email = "avijittenant@gmail.com", Password = "Test@123", Firstname = "Avijit", Lastname = "Gorai", Mobile = "9876543219" },

                 new User { Id = 11, Email = "aniladmin@gmail.com", Password = "Test@123", Firstname = "Anil", Lastname = "Dhakad", Mobile = "9876543200" },
                 new User { Id = 12, Email = "anilbuyer@gmail.com", Password = "Test@123", Firstname = "Anil", Lastname = "Dhakad", Mobile = "9876543220" },
                 new User { Id = 13, Email = "anilseller@gmail.com", Password = "Test@123", Firstname = "Anil", Lastname = "Dhakad", Mobile = "9876543310" },

                 new User { Id = 14, Email = "roshanadmin@gmail.com", Password = "Test@123", Firstname = "Roshan", Lastname = "Kumar", Mobile = "9876543410" },
                 new User { Id = 15, Email = "roshanteacher@gmail.com", Password = "Test@123", Firstname = "Roshan", Lastname = "Kumar", Mobile = "9876543510" },
                 new User { Id = 16, Email = "roshanstudent@gmail.com", Password = "Test@123", Firstname = "Roshan", Lastname = "Kumar", Mobile = "9876543610" }
            );

            modelBuilder.Entity<UserRole>().HasData(
               new UserRole { Id = 1, UserId = 1, RoleId = 1 },

               new UserRole { Id = 2, UserId = 2, RoleId = 2 },
               new UserRole { Id = 3, UserId = 3, RoleId = 3 },
               new UserRole { Id = 4, UserId = 4, RoleId = 4 },

               new UserRole { Id = 5, UserId = 5, RoleId = 5 },
               new UserRole { Id = 6, UserId = 6, RoleId = 6 },
               new UserRole { Id = 7, UserId = 7, RoleId = 7 },

               new UserRole { Id = 8, UserId = 8, RoleId = 8 },
               new UserRole { Id = 9, UserId = 9, RoleId = 9 },
               new UserRole { Id = 10, UserId = 10, RoleId = 10 },

               new UserRole { Id = 11, UserId = 11, RoleId = 11 },
               new UserRole { Id = 12, UserId = 12, RoleId = 12 },
               new UserRole { Id = 13, UserId = 13, RoleId = 13 },

               new UserRole { Id = 14, UserId = 14, RoleId = 14 },
               new UserRole { Id = 15, UserId = 15, RoleId = 15 },
               new UserRole { Id = 16, UserId = 16, RoleId = 16 }
            );

            modelBuilder.Entity<Company>().HasData(
            new Company { Id = 1, Name = "SS Job Portal", Image = "jobportal.png" },

            new Company { Id = 2, Name = "SS Health Care", Image = "healthcare.png" },
            new Company { Id = 3, Name = "SS Health Care", Image = "healthcare.png" },
            new Company { Id = 4, Name = "SS Health Care", Image = "healthcare.png" },

            new Company { Id = 5, Name = "SS Job Portal", Image = "jobportal.png" },
            new Company { Id = 6, Name = "SS Job Portal", Image = "jobportal.png" },
            new Company { Id = 7, Name = "SS Job Portal", Image = "jobportal.png" },

            new Company { Id = 8, Name = "SS E-Housing", Image = "ehousing.png" },
            new Company { Id = 9, Name = "SS E-Housing", Image = "ehousing.png" },
            new Company { Id = 10, Name = "SS E-Housing", Image = "ehousing.png" },

            new Company { Id = 11, Name = "SS Zepto", Image = "sszepto.png" },
            new Company { Id = 12, Name = "SS Zepto", Image = "sszepto.png" },
            new Company { Id = 13, Name = "SS Zepto", Image = "sszepto.png" },

            new Company { Id = 14, Name = "SS School" , Image = "ssschool.png" },
            new Company { Id = 15, Name = "SS School", Image = "ssschool.png" },
            new Company { Id = 16, Name = "SS School", Image = "ssschool.png" }
        );

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "SuperAdmin" , CompanyId= 1},

                new Role { Id = 2, Name = "HealthCareAdmin", CompanyId = 2 },
                new Role { Id = 3, Name = "Doctor", CompanyId = 3},
                new Role { Id = 4, Name = "Patient", CompanyId = 4},

                new Role { Id = 5, Name = "JobPortalAdmin", CompanyId = 5},
                new Role { Id = 6, Name = "Employee", CompanyId = 6},
                new Role { Id = 7, Name = "Employer", CompanyId = 7},

                new Role { Id = 8, Name = "HousingAdmin", CompanyId = 8},
                new Role { Id = 9, Name = "Owner", CompanyId = 9},
                new Role { Id = 10, Name = "Tenant", CompanyId = 10},

                new Role { Id = 11, Name = "GrosseryAdmin", CompanyId = 11},
                new Role { Id = 12, Name = "Buyer", CompanyId = 12},
                new Role { Id = 13, Name = "Seller", CompanyId = 13},

                new Role { Id = 14, Name = "SchoolAdmin", CompanyId = 14},
                new Role { Id = 15, Name = "Teacher", CompanyId = 15},
                new Role { Id = 16, Name = "Student", CompanyId = 16}
            );



            modelBuilder.Entity<Sidebar>().HasData(
              new Sidebar { Id = 1, Name = "Assign Role", RoleId = 1, Path = "assignrole" },
              new Sidebar { Id = 2, Name = "Role", RoleId = 1, Path = "role" },
              new Sidebar { Id = 3, Name = "Task Manager", RoleId = 1, Path = "taskmanager" },

              new Sidebar { Id = 4, Name = "Doctors", RoleId = 2, Path = "doctor" },
              new Sidebar { Id = 5, Name = "Nurses", RoleId = 2, Path = "nurses" },
              new Sidebar { Id = 6, Name = "Patients", RoleId = 2, Path = "patients" },
              new Sidebar { Id = 7, Name = "Reports", RoleId = 2, Path = "healthcarereports" },
              new Sidebar { Id = 8, Name = "Billings", RoleId = 2, Path = "billings" },
              new Sidebar { Id = 9, Name = "Rooms", RoleId = 2, Path = "rooms" },
              new Sidebar { Id = 10, Name = "Inventory", RoleId = 2, Path = "inventory" },

              new Sidebar { Id = 11, Name = "Appointments", RoleId = 3, Path = "doctorappointments" },
              new Sidebar { Id = 12, Name = "Patient Records", RoleId = 3, Path = "patientrecords" },
              new Sidebar { Id = 13, Name = "Prescriptions", RoleId = 3, Path = "doctorprescriptions" },
              new Sidebar { Id = 14, Name = "Medical Notes", RoleId = 3, Path = "medicalnotes" },
              new Sidebar { Id = 15, Name = "Test Reports", RoleId = 3, Path = "testreports" },

              new Sidebar { Id = 16, Name = "Appointments", RoleId = 4, Path = "patientappointments" },
              new Sidebar { Id = 17, Name = "Prescriptions", RoleId = 4, Path = "patientprescriptions" },
              new Sidebar { Id = 18, Name = "Billing History", RoleId = 4, Path = "billinghistory" },
              new Sidebar { Id = 19, Name = "Reports", RoleId = 4, Path = "patientreports" },
              new Sidebar { Id = 20, Name = "Messages", RoleId = 4, Path = "patientmessages" },

              new Sidebar { Id = 21, Name = "Country", RoleId = 2, Path = "country" },
              new Sidebar { Id = 22, Name = "State", RoleId = 2, Path = "state" },
              new Sidebar { Id = 23, Name = "District", RoleId = 2, Path = "district" },

              new Sidebar { Id = 24, Name = "Sidebar", RoleId = 1, Path = "sidebar" }
           );
        }
    }
}
