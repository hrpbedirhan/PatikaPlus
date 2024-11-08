using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5_kapanis
{
    public class Car
    {
        public DateTime ProductionDate { get; private set; }
        public string SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int DoorCount { get; set; }

        public Car()
        {
            ProductionDate = DateTime.Now;
        }

    }
}
