using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireworthVets
{
    internal class Shifts
    {
        public int ID { get; set; }
        public string username { get; set; }
        public DateTime startDateTime { get; set; }
        public DateTime endDateTime { get; set; }
        public string role { get; set; }
        public string comments { get; set; }
    }
}
