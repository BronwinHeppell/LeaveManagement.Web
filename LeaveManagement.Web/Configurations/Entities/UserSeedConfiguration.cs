using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                 new Employee
                 {
                     Id = "40faac37-e036-4ea7-b14a-fc1da0dc8746",
                     Email = "admin1@gmail.com",
                     NormalizedEmail = "ADMIN1@GMAIL.COM",
                     NormalizedUserName = "ADMIN1@GMAIL.COM",
                     UserName = "admin1@gmail.com",
                     Firstname = "System",
                     Lastname = "Admin",
                     PasswordHash = hasher.HashPassword(null, "B980719h!"),
                     EmailConfirmed = true
                 },
                 new Employee
                 {
                     Id = "b2b63da8-e248-411b-a5fc-f568ae0ceee1",
                     Email = "user@localhost.com",
                     NormalizedEmail = "USER@LOCALHOST.COM",
                     NormalizedUserName = "USER@LOCALHOST.COM",
                     UserName = "user@localhost.com",
                     Firstname = "System",
                     Lastname = "User",
                     PasswordHash = hasher.HashPassword(null, "B980719h!"),
                     EmailConfirmed = true
                 }
            );
        }
    }
}