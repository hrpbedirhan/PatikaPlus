using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_odev
{
    internal class Car
    {

        //parametless constructor
        public Car() {}

        //parameters constructor
        public Car(string brand, string model, string color, int doorsCount)
        {
            Brand = brand;
            Model = model;
            Color = color;
            DoorCount = doorsCount;
        }

        //properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        private int _doorCount;
        public int DoorCount
        {
            get { return _doorCount; }
            set 
            {
                if (2 == value || 4 == value) //set control
                {
                    _doorCount = value;
                }
                else
                {
                    Console.WriteLine("Hata: Kapı sayısı sadece 2 veya 4 olabilir. Kapı sayısı -1 olarak ayarlandı.");
                    _doorCount = -1;
                }
            }
        }

        //get car information
        public void GetCarInfo()
        {
            Console.WriteLine($"Marka: {Brand}, Model: {Model}, Renk: {Color}, Kapı Sayısı: {DoorCount}");
        }
    }
}
