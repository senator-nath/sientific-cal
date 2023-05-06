using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_oop
{
    internal class Vehicle
    {

    }
    class WheeledVehicle : Vehicle
    {
        private string color;
        private decimal price;

        public string Colour {
            get { return color; }
            set { color = value; }
        }
        public decimal Price { get; set; }

        public void ChangeColor()
        {
            Console.WriteLine("color is changing \n color has changrd");
        }
        public void ChangePrice()
        {
            Console.WriteLine(75000);
        }
    }
    class FourWheeledVehicle : WheeledVehicle 
   
    {
        private string brandName;
        private int capacity;

        public string BrandName { get { return brandName; } set { brandName = value; } }
        public int Capacity { get { return capacity;} set { capacity = value; } }

        public void StartCar()
        {
            Console.WriteLine("car have started");
        }
        public void NewCapacity()
        {
            Console.WriteLine(85 + "kg");
        }
        public FourWheeledVehicle()
        {
                
        }
    }
}
