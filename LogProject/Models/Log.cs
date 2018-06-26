using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogProject.Models
{
    public class Log
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public string Thread { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public int UserId { get; set; }
    }
}
