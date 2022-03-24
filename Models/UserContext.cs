using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using UserApp.Configuration;
using UserApp.Models;

namespace UserApp.Models
{
    public class UserContext : DbContext

    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        { }

        public UserContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserPageConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new PageConfiguration());
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
        }
       /* public UserContext()
        {
        }
        public static UserContext Create()
        {
            return new UserContext();
        }*/
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserPage> UserPages { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
} 
