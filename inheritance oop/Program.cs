using System;

namespace inheritance_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FourWheeledVehicle car= new FourWheeledVehicle();
            car.StartCar();
            car.NewCapacity();
            car.ChangePrice();
            car.ChangeColor();
        }
    }
}
