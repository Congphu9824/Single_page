using Data.DTO;
using Data.Enum;
using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace API.ApplicationDbContext
{
    public class StaffDbContext : DbContext
    {
        public StaffDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Staffs> Staffs { get; set; }
        public DbSet<Notes> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Staff data
            modelBuilder.Entity<Staffs>().HasData(
                new Staffs
                {
                    Id = Guid.NewGuid(),
                    FirstName = "John",
                    LastName = "Doe",
                    NickName = "Johnny",
                    Place = "New York",
                    Salary = 50000,
                    Gender = "Male",
                    Position = "Developer",
                    Status = "Active",
                    DateOfBirth = new DateTime(1990, 5, 1)
                },
                new Staffs
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jane",
                    LastName = "Smith",
                    NickName = "Janey",
                    Place = "London",
                    Salary = 60000,
                    Gender = "Female",
                    Position = "Manager",
                    Status = "Inactive",
                    DateOfBirth = new DateTime(1985, 3, 10)
                }, 
                new Staffs
                {
                    Id = Guid.NewGuid(),
                    FirstName = "John",
                    LastName = "Doe",
                    NickName = "Johnny",
                    Place = "New York",
                    Salary = 55000,
                    Position = "Designer",
                    Status = "Active",
                    DateOfBirth = new DateTime(1990, 5, 15)
                }, 
                new Staffs
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Alice",
                    LastName = "Johnson",
                    NickName = "Ally",
                    Place = "Los Angeles",
                    Salary = 70000,
                    Position = "tester",
                    Status = "Active",
                    DateOfBirth = new DateTime(1987, 7, 20)
                }, 
                new Staffs
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Bob",
                    LastName = "Brown",
                    NickName = "Bobby",
                    Place = "San Francisco",
                    Salary = 65000,
                    Position = "Developer",
                    Status = "Inactive",
                    DateOfBirth = new DateTime(1992, 11, 5)
                }
            );

            // Seed Note data
            modelBuilder.Entity<Notes>().HasData(
                new Notes
                {
                    Id = Guid.NewGuid(),
                    Text = "Welcome Note",
                    DateCreated = DateTime.Now,
                    StaffId = null // No staff assigned yet
                },
                new Notes
                {
                    Id = Guid.NewGuid(),
                    Text = "Take note",
                    DateCreated = DateTime.Now,
                    StaffId = null // No staff assigned yet
                }
            );
        }
    }
}
