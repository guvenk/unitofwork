using Microsoft.EntityFrameworkCore;
using System;

namespace UnitOfWork
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed the initial data to work with
            SeedData(builder);

            // Configure Tables
            ConfigureLibrariesTable(builder);
            ConfigureBooksTable(builder);
        }

        private void ConfigureLibrariesTable(ModelBuilder builder)
        {
            builder.Entity<Library>(entity =>
            {
                entity.ToTable(nameof(Libraries));
                entity.HasKey(a => a.Id);
                entity.Property(a => a.CreateDate).IsRequired();
            });
        }

        private void ConfigureBooksTable(ModelBuilder builder)
        {
            builder.Entity<Book>(entity =>
            {
                entity.ToTable(nameof(Books));
                entity.HasKey(a => a.Id);

                entity.Property(a => a.Title)
                .IsRequired()
                .HasMaxLength(256);

                entity.Property(a => a.Author)
                .IsRequired()
                .HasMaxLength(256);

                entity.Property(a => a.CreateDate)
                .IsRequired();
            });
        }

        private void SeedData(ModelBuilder builder)
        {
            Library[] library = new[]
            {
                new Library
                {
                    Id = 1,
                    Name = "Library 1",
                    CreateDate = DateTime.UtcNow,
                }
            };

            builder.Entity<Library>().HasData(library);

            Book[] books = new[]
            {
                new Book
                {
                    Id = 1,
                    Title = "Harry Potter",
                    CreateDate = DateTime.UtcNow,
                    Author = "J. K. Rowling",
                },
                new Book
                {
                    Id = 2,
                    Title = "Don Quixote",
                    CreateDate = DateTime.UtcNow,
                    Author = "Miguel De Cervantes",
                },
                new Book
                {
                    Id = 3,
                    Title = "Crime and Punishment",
                    CreateDate = DateTime.UtcNow,
                    Author = "Fyodor Dostoyevsky",
                }
            };

            builder.Entity<Book>().HasData(books);
        }
    }
}