using ContactBookApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactBookApp.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Contact> Contacts { get; set; }
    }
}
