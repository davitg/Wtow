using Microsoft.EntityFrameworkCore;
using System;
using Wtow.Domain;

namespace Wtow.Data
{
    public class TitleContext : DbContext
    {
        public TitleContext(DbContextOptions<TitleContext> options) : base(options)
        {

        }

        public DbSet<Title> Titles { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
