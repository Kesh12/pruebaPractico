using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPracticoHertz
{
    class Device
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime LastTimeReported { get; set; }
        public List<Reading> Readings { get; set; }
        [Required]
        public Location Location { get; set; }
    }
}
