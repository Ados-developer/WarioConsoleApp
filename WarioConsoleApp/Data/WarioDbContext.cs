using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarioConsoleApp.Models;

namespace WarioConsoleApp.Data
{
    public class WarioDbContext : DbContext
    {
        public DbSet<WarioRecord> WarioRecords { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=WarioConsoleApp.db");
        }
    }
}
