using ContactBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContactBook.Infrastructure
{
    public class ContactBookDbContext : DbContext
    {
        public ContactBookDbContext(DbContextOptions<ContactBookDbContext> options) : base(options) { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonMap());
        }
    }
}
