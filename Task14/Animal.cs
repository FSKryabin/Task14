using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    abstract class Animal
    {
       public abstract string AnimalType { get; set; }

        public Animal(string animaltype)
        {
            AnimalType = animaltype;
        }
        public abstract void GateSay();

        public void Say()
        {
           Console.WriteLine("I am a {0}", AnimalType);
            GateSay();
        }
    }
}
