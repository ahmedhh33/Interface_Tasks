using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTasks
{
    internal interface IAnimal
    {
        public abstract void Eat();
        public abstract void Sleep();
    }

    internal class Dog : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The dog eat Faster ");
        }

        public void Sleep()
        {
            Console.WriteLine("The dog dont fill to sleep ");
        }
    }

    internal class Cat : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The Cat eat sloly ");
        }

        public void Sleep()
        {
            Console.WriteLine("The Cat sleep in afternoon ");
        }
    }
}
