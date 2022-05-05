using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Api.Entities;
using TodoList.Models.Enums;
using Task = System.Threading.Tasks.Task;

namespace TodoList.Api.Data
{
    public class TodoListDbContextSeed
    {
        private readonly IPasswordHasher<User> _passwordHasher = new PasswordHasher<User>();
        public async Task SeedAsync(TodoListDbContext context, ILogger<TodoListDbContextSeed> logger)
        {
            if (!context.Users.Any())
            {
                var user = new User()
                {
                    Id = Guid.NewGuid(),//UUID
                    FirstName = "Mr",
                    LastName = "A",
                    Email = "admin1@gmail.com",
                    PhoneNumber = "0334061783",
                    UserName = "admin"
                };
                user.PasswordHash = _passwordHasher.HashPassword(user, "Admin@123$");//Hash Password thành SHA1
                context.Users.Add(user);

                user = new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Nguyen Thanh",
                    LastName = "Loc",
                    Email = "loc@sadad.com",
                    PhoneNumber = "012323",
                    UserName = "locgacui",
                    PasswordHash = _passwordHasher.HashPassword(user, "Snowfox123")
                };
                context.Users.Add(user);
            }

            if (!context.Tasks.Any())
            {
                context.Tasks.Add(new Entities.Task() 
                { 
                    Id = Guid.NewGuid(),
                    Name = "Same tasks 1",
                    CreateDate = DateTime.Now,
                    Priority = Priority.High,
                    Status = Status.Open
                });
            }
            await context.SaveChangesAsync();

        }
    }
}
