using LeaveManagementSystem.Controllers;
using LeaveManagementSystem.Models.LeaveTypes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1b1bb66e-6aa2-4728-8b5b-4e6de4fd899b",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole
                {
                    Id = "958e6340-4275-49ed-80ee-2cb5e2fad807",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                },
                new IdentityRole
                {
                    Id = "f4145e80-361d-4541-b311-9e95b4a95964",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR"
                });


            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "69321195-8b73-4f1a-919b-e7deee4b3909",
                UserName = "user1admin",
                NormalizedUserName = "USER1admin",
                Email = "user1adin@gmail.com",
                NormalizedEmail = "USER1admin@GMAIL.COM",
                PasswordHash =hasher.HashPassword(null, "lONGBADAO123@"),
                EmailConfirmed = true,
                FirstName ="Jay",
                LastName ="Van",
                DateOfBirth = new DateOnly(1990, 1, 1)

            },
            new ApplicationUser
            {
                Id = "bdee7c76-d0b8-4ff2-908c-f80177687964",
                UserName = "user2sup",
                NormalizedUserName = "USER2SUP",
                Email = "user2sup@gmail.com",
                NormalizedEmail = "USER2SUP@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "lONGBADAO123@"),
                EmailConfirmed = true,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateOnly(1992, 2, 2)
            });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "69321195-8b73-4f1a-919b-e7deee4b3909",
                    RoleId = "1b1bb66e-6aa2-4728-8b5b-4e6de4fd899b"
                },
                new IdentityUserRole<string>
                {
                    UserId = "bdee7c76-d0b8-4ff2-908c-f80177687964",
                    RoleId = "f4145e80-361d-4541-b311-9e95b4a95964"
                }
            );
        }




        public DbSet<LeaveType> LeaveTypes { get; set; }
        


    }
}
