using Microsoft.EntityFrameworkCore;
using Puc.Atividade7.Domain.Entities;
using Puc.Atividade7.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Atividade7.Infra.Data.Context
{
    public class SQLiteContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Utilizando um servidor SQLite local. Aqui poderíamos configurar qualquer outro banco de dados.
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlite("DataSource=app.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
        }
    }
}
