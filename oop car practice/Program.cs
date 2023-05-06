using System;

namespace oop_car_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Vehicle
    {
        private string colour;
        public int maxSpeed;
        protected decimal price;

        public void DisplayInfo()
        {
            colour = "blue";
            maxSpeed= 85;
            price = 54000;

            Console.WriteLine(colour + maxSpeed+ price);
        }
    }
}
