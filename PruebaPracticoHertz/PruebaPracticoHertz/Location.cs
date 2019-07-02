using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPracticoHertz
{
    class Location
    {
        [Key]
        public int Id { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
    }
}
