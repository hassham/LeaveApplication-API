using System;
using LeaveApplication.API.Model;
using Microsoft.EntityFrameworkCore;

namespace LeaveApplication.API
{
    public class MyDataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<LeaveApplicationRequest> LeaveApplicationRequests { get; set; }

        public MyDataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FullName = "Sarah Johnson",
                    Username = "sarahjohnson",
                    Password = "Abcd1234",
                    ManagerId = 2
                }, 
                new User
                {
                    Id = 2,
                    FullName = "Michael Brown",
                    Username = "michaelbrown",
                    Password = "Abcd1234",
                    ManagerId = 1
                },
                new User
                {
                    Id = 3,
                    FullName = "Elizabeth Davis",
                    Username = "elizabethdavis",
                    Password = "Abcd1234",
                    ManagerId = 1
                },
                new User
                {
                    Id = 4,
                    FullName = "William Smith",
                    Username = "williamsmith",
                    Password = "Abcd1234",
                    ManagerId = 1
                },
                new User
                {
                    Id = 5,
                    FullName = "James Wilson",
                    Username = "jameswilson",
                    Password = "Abcd1234",
                    ManagerId = 1
                },
                new User
                {
                    Id = 6,
                    FullName = "Catherine White",
                    Username = "catherinewhite",
                    Password = "Abcd1234",
                    ManagerId = 1
                },
                new User
                {
                    Id = 7,
                    FullName = "Jennifer Anderson",
                    Username = "jenniferanderson",
                    Password = "Abcd1234",
                    ManagerId = 2
                },
                new User
                {
                    Id = 8,
                    FullName = "Christopher Lee",
                    Username = "christopherlee",
                    Password = "Abcd1234",
                    ManagerId = 2
                },
                new User
                {
                    Id = 9,
                    FullName = "Susan Taylor",
                    Username = "susantaylor",
                    Password = "Abcd1234",
                    ManagerId = 2
                },
                new User
                {
                    Id = 10,
                    FullName = "David Green",
                    Username = "davidgreen",
                    Password = "Abcd1234",
                    ManagerId = 2
                }
            );
        }
    }
}
