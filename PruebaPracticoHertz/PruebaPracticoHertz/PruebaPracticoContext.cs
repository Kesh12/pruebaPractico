using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPracticoHertz
{
    class PruebaPracticoContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }

        public PruebaPracticoContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PruebaPracticoContext>());
        }
    }
}
