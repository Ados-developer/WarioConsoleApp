using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WarioConsoleApp.Data;
using WarioConsoleApp.Models;

namespace WarioConsoleApp.Repositories
{
    public class WarioRepository
    {
        private readonly WarioDbContext _db;
        public WarioRepository(WarioDbContext db)
        {
            _db = db;
        }
        public void Save(Wario? data)
        {
            string json = data != null ? JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true }) : "{}";
            bool wasAvailable = data != null;

            _db.Database.EnsureCreated();
            _db.WarioRecords.Add(new WarioRecord
            {
                DataCreate = DateTime.Now,
                JsonData = json,
                wasAvailable = wasAvailable
            });
            _db.SaveChanges();
        }
    }
}
