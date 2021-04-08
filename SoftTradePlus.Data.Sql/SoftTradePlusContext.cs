using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftTradePlus.Data.Sql
{
    public class SoftTradePlusContext : DbContext
    {
        public SoftTradePlusContext()
        {
            Database.EnsureCreated();
        }


        public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<GoodEntity> Goods { get; set; }
        public DbSet<ManagerEntity> Managers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SoftTradePlusDb;Trusted_Connection=True;");
        }
    }
}
