using Mild.App.TodoSpa.Models;
using Microsoft.EntityFrameworkCore;

namespace Mild.App.TodoSpa.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}