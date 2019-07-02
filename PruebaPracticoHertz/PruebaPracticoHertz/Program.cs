using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPracticoHertz
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeviceRepository repository = new DeviceRepositoryImplementation();

            var device = new Device()
            {
                Id = 3,
                LastTimeReported = DateTime.Now,
                Name = "a name",
                Location = new Location()
                {
                    Id = 3,
                    Latitude = 34,
                    Longitude = 89
                }
            };
            repository.Create(device);
        }
    }
}
