using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPracticoHertz
{
    interface IDeviceRepository
    {
        void Create(Device device);

        Device GetAll();

        void Update(Device device);

        void Delete(Device device);
    }
}
