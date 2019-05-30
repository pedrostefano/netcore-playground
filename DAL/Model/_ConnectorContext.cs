using System;
using System.IO;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DAL
{
    public class ConnectorContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             => optionsBuilder.UseNpgsql("Host=localhost;Database=cimsoa;Port=32771;Username=postgres;Password=12345678");

        public virtual DbSet<TConnector> Connectors { get; set; }
        public virtual DbSet<TDatasource> Datasources { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TDatasource>()
                .HasOne(c => c.Connector)
                .WithMany(d => d.Datasources)
                .HasForeignKey(cw => cw.ConnectorId);

        }
    }

}
