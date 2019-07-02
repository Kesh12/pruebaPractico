using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPracticoHertz
{
    class Device
    {
        public string Name { get; set; }
        public DateTime LastTimeReported { get; set; }
        private List<Reading> Readings { get; set; }
        private Location Location { get; set; }
    }
}
