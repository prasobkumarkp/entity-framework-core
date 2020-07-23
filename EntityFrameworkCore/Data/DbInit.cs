using System;
using System.Linq;

namespace EntityFrameworkCore.Data
{
    public static class DbInit
    {
        public static void InitilizeWithFakeData(AppDbContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Contats.Any())
            {
                context.Contats.AddRange(
                    new Contact { FirstName = "Aditi", LastName = "Bhatia", Email = "aditi.bhatia@gmail.com" },
                    new Contact { FirstName = "Kiran", LastName = "Sharma", Email = "kiran.sharma@gmail.com" },
                    new Contact { FirstName = "James", LastName = "William", Email = "james.william@gmail.com" },
                    new Contact { FirstName = "Jennifer", LastName = "Muller", Email = "jennifer.muller@gmail.com" });
            }

            if (!context.ToDos.Any())
            {
                context.ToDos.AddRange(
                    new ToDo { Text = "Wash the dishes", Completed = true },
                    new ToDo { Text = "Take out the trash", Completed = true },
                    new ToDo { Text = "Prepare for interviews", Completed = true },
                    new ToDo { Text = "Buy milk", Completed = true });
            }

            context.SaveChanges();

        }
    }
}
