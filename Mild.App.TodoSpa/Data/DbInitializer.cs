using Mild.App.TodoSpa.Models;
using System;
using System.Linq;

namespace Mild.App.TodoSpa.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            // Look for any students.
            if (context.Accounts.Any())
            {
                return;   // DB has been seeded
            }
        
            var adminUser = new Account{FirstName="Thada",LastName="Wangthammang",Email="mildronize@gmail.com"};
            context.Accounts.Add(adminUser);

            context.SaveChanges();
        }
    }
}