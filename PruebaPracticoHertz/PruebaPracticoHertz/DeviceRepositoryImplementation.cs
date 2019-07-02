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

        public Device GetById(int id)
        {
            using (var db = new PruebaPracticoContext())
            {
                return db.Devices.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public List<Device> GetAll()
        {
            using (var db = new PruebaPracticoContext())
            {
                return db.Devices.ToList();
            }
        }

        public Device GetDeviceReportedLatest()
        {
            using (var db = new PruebaPracticoContext())
            {
                return db.Devices
                    .Where(x => x.Readings.Count > 0)
                    .OrderBy(x => x.LastTimeReported)
                    .FirstOrDefault();
            }
        }

        public void Update(Device device)
        {
            using (var db = new PruebaPracticoContext())
            {
                var savedDevice = db.Devices.Where(x => x.Id == device.Id).FirstOrDefault();
                if (savedDevice == null)
                {
                    return;
                }
                db.Entry(savedDevice).CurrentValues.SetValues(savedDevice);
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
