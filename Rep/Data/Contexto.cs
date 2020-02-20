using Microsoft.EntityFrameworkCore;
using Rep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rep.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Database/ClientesDb");
        }
    }
}
