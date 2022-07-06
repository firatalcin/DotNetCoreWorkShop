using System;
using System.Collections.Generic;
using AutoMapperApp.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AutoMapperApp.API.Contexts
{
    public partial class FluentValidationDbContext : DbContext
    {
        public FluentValidationDbContext()
        {
        }

        public FluentValidationDbContext(DbContextOptions<FluentValidationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasIndex(e => e.CustomerId, "IX_Addresses_CustomerId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CustomerId);
            });
        }
    }
}