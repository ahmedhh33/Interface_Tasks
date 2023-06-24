using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTasks
{
    internal interface IVechile
    {
        public abstract void Start();
        public abstract void Break();
        public abstract void Accelerate(int speed,double time);
    }

    internal class Car : IVechile
    {
        public void Accelerate(int speed, double time)
        {
            Console.WriteLine($"The Car aceleration = {speed / time}");
        }

        public void Break()
        {
            Console.WriteLine("The car not moving");
        }

        public void Start()
        {
            Console.WriteLine("The car is start moving");
        }
    }
    internal class Motorcycle : IVechile
    {
        public void Accelerate(int speed, double time)
        {
            Console.WriteLine($"The Motorcycle aceleration = {speed / time}");

        }

        public void Break()
        {
            Console.WriteLine("The Motorcycle not moving");
        }

        public void Start()
        {
            Console.WriteLine("The Motorcycle is start moving");
        }
    }
}
