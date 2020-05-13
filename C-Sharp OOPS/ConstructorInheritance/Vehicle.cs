using System;

namespace C_Sharp_OOPS
{
    public class Vehicle
    {
        private readonly string _regisrationNumber;

        public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialized.");
        }

        public Vehicle(string regisrationNumber)
            : this()
        {
            _regisrationNumber = regisrationNumber;
        }

    }
}