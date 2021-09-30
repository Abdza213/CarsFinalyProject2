 using _Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _DataAccess.Context
{
    public class NorthWindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB;
                           Database = C:\USERS\ASUS\SOURCE\REPOS\CARSFINALYPROJECT\ENTITES\NORTHWIND\PERSONELITEM\CARS.MDF;
                            Trusted_Connection = true ");
        }

        public DbSet<Cars> cars { get; set; }

        public DbSet<Brands> brands { get; set; }

        public DbSet<Colors> colors { get; set; }

    }
}
