using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarioConsoleApp.Models
{
    public class WarioRecord
    {
        public int Id { get; set; }
        public DateTime DataCreate { get; set; }
        public string? JsonData { get; set; }
        public bool wasAvailable { get; set; }
    }
}
