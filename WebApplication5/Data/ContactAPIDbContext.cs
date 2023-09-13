
using System.Collections.Generic;
using WebApplication5.Models;

namespace WebApplication5.Data
{
    public class ContactAPIDBContext : 
    {
        public DbSet<Contact> Contacts { get; set; }

        public ContactAPIDBContext(DbContextOptions<ContactAPIDBContext> options)
            : base(options)
        {
        }

        // Other configuration, if needed
    }
}
