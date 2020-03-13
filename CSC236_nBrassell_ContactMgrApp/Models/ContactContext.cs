using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC236_nBrassell_ContactMgrApp.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Other" }
                );

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FirstName = "Mary Ellen",
                    LastName = "Walton",
                    Phone = "555-123-4567",
                    Email = "maryEllen@yahoo.com",
                    CategoryId = 1,
                    DateAdded = DateTime.Now
                },
                new Contact
                {
                    ContactId = 2,
                    FirstName = "Sarah",
                    LastName = "Vimes",
                    Phone = "303-514-6845",
                    Email = "sarah@hotmail.com",
                    CategoryId = 3,
                    DateAdded = DateTime.Now
                },
                new Contact
                {
                    ContactId = 3,
                    FirstName = "Fohn",
                    LastName = "Barnes",
                    Phone = "258-865-9248",
                    Email = "jBarnes@gmail.com",
                    CategoryId = 2,
                    DateAdded = DateTime.Now
                }
                );
        }
    }
}
