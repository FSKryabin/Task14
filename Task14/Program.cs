using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Cat", "Meow");
            cat.Say();
            Dog dog = new Dog("Dog", "Bow");
            dog.Say();
            Console.ReadKey();
        }
    }
}
