using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Dog: Animal
    {
        string name;
        string say;
        string animaltype;
        public override string AnimalType
        {
            get => animaltype;

            set => animaltype = value;

        }
        public Dog(string anymaltype, string name, string say)
            : base(anymaltype)
        {
            this.say = say;
            this.name = name;
        }

        public Dog(string animaltype, string v) 
            : base(animaltype)
        {
        }

        public override void GateSay()
        {
            Console.WriteLine("Bow! - Bow!");
        }
    }
    
    
}
