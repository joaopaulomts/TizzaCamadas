﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    internal class DataContext
    {
    }
}

using Microsoft.EntityFrameworkCore;

namespace Entidades
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Pizzaria> Pizzaria { get; set; }
        public DbSet<Promover> Promover { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizzaria>().HasKey(p => p.Id);

            modelBuilder.Entity<Promover>().HasKey(p => p.Id);
            modelBuilder.Entity<Promover>().HasOne(p => p.Pizzaria).WithMany()
                .HasForeignKey(p => p.CodigoPizzaria);

            base.OnModelCreating(modelBuilder);
        }
    }
}

