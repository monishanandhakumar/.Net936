using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjCodeFirstincore.Models
{
    public class EFContext:DbContext
    {
       // private const string connectionString = "Server=DESKTOP-U8J1M3C\\MSSQLSERVER01;Database=OnlineShopping;Trusted_Connection=True;";

        public EFContext(DbContextOptions<EFContext> options)
           : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(connectionString);
        //}

        public DbSet<Product> Products { get; set; }
    }
}
