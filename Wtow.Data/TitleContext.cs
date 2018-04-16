using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Wtow.Domain;

namespace Wtow.Data
{
    public class TitleContext : IdentityDbContext<AppUser>
    {
        public TitleContext(DbContextOptions<TitleContext> options) : base(options)
        {
        }

        public DbSet<Title> Titles { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<UserTitle> UserTitles { get; set; }
    }
}
