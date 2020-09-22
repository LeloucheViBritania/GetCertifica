using ApiMe.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiMe.DAL
{
    public class CertiDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Data Source=sql5080.site4now.net;Initial Catalog=DB_A673E5_DbCaiman;Persist Security Info=True;User ID=DB_A673E5_DbCaiman_admin;Password=Olivier10;TrustServerCertificate=True"));
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            modelBuilder.Entity<Post>()
                .HasMany(c => c.Comments)
                .WithOne(e => e.Post);
            modelBuilder.Entity<Comment>()
                .Ignore(x => x.Post);

            modelBuilder.Entity<Tag>()
                .HasMany(c => c.Posts)
                .WithOne(e => e.Tag);
            modelBuilder.Entity<Post>()
                .Ignore(x => x.Tag);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Posts)
                .WithOne(e => e.Category);
            modelBuilder.Entity<Post>()
                .Ignore(x => x.Category);
        }
        public DbSet<Tag> Tags { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }


        public DbSet<Category> Categories { get; set; }

    }
}