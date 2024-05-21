
using ContactTask.Shared.Data;
using Microsoft.EntityFrameworkCore;
namespace ContactTask.Server.Models

{

    public partial class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {

        }
        public DbSet<Contact> contacts { get; set; }

    }

}