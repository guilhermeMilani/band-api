using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    internal class BandaContext : DbContext
    {
        public DbSet<Banda> Banda { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5439; Database=postgres; UserId=postgres; Password=123456");
        }
    }
}
