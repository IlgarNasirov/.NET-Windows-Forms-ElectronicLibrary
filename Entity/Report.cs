using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicLibrary.Entity
{
    public class Report
    {
        public int Id { get; set; }
        public int Book_id { get; set; }
        public string Username { get; set; }
        public DateTime Receive_date { get; set; }
        public DateTime Deadline { get; set;}
        public DateTime Return_date { get; set; }
        public Double Fine { get; set; }
        public bool Status { get; set; }
    }
}
