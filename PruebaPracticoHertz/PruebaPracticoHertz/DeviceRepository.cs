using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPracticoHertz
{
    class DeviceRepositoryImplementation : IDeviceRepository
    {
        public void Create(Device device)
        {
            using (var db = new PruebaPracticoContext())
            {
                db.Devices.Add(device);
                db.SaveChanges();
            }
        }

        public List<Device> GetAll()
        {
            using (var db = new PruebaPracticoContext())
            {

            }
            return new List<Device>();
        }

        public void Update(Device device)
        {
            using (var db = new PruebaPracticoContext())
            {
                db.SaveChanges();
            }
        }

        public void Delete(Device device)
        {
            using (var db = new PruebaPracticoContext())
            {
                db.Devices.Remove(device);
                db.SaveChanges();
            }
        }
    }
}
