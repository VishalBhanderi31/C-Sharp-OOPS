using System;

namespace C_Sharp_OOPS
{
    public class Car : Vehicle
    {
        public Car(string regisrationNumber) 
            : base(regisrationNumber)
        {
            //Always intialise field specific to car class.
            Console.WriteLine("Car is being initialized. registartionNumber {0}",regisrationNumber);
        }
    }
}