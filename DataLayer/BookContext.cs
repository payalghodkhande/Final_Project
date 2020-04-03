using Microsoft.EntityFrameworkCore;
using Pocos;
using System;

namespace DataLayer
{
    public class BookContex : DbContext
    {
        public DbSet<Book> ApplicationEducations { get; set; }
        public DbSet<Author> ApplicantJobApplications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-TM9QR0JI\HUMBERBRIDGING;Initial Catalog=college;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
           .HasMany(c => c.Books)
           .WithOne(e => e.Author);

            base.OnModelCreating(modelBuilder);
        }
    }

   
}
