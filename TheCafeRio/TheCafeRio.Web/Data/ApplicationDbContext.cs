using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheCafeRio.Web.Entities;
using TheCafeRio.Web.Models;

namespace TheCafeRio.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private string _connectionString;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public ApplicationDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Reservation> Reservations { get; set; }

    }
}
