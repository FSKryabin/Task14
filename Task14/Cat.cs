using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Cat : Animal
    {
        string name;
        string say;
        string animaltype;
        public override string AnimalType 
        {
            get => animaltype;

            set => animaltype = value;
            
        }
        public Cat(string anymaltype, string name, string say)
            :base(anymaltype)
        {
            this.name = name;
            this.say = say;
        }

        public Cat(string animaltype, string v) 
            : base(animaltype)
        {
        }

        public override void GateSay()
        {
            Console.WriteLine("Meow!");
        }
    }
}
