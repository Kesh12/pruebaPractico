﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPracticoHertz
{
    class Reading
    {
        [Key]
        public int Id { get; set; }
        public uint Value { get; set; }
    }
}
