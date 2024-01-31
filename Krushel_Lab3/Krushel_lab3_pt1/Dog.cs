using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krushel_lab3
{
    public class Dog : Animal
    {
        public Dog() { }

        public Dog(string name, string colour, int age)
        {
            this.Name = name;
            this.Colour = colour;
            this.Age = age;
            Console.WriteLine($"New dog {this.Name} created");
        }

        public override string ToString()
        {
            return $"Doggy name: {this.Name}\nColor: {this.Colour}\nAge: {this.Age}";
        }

        public override void Eat()
        {
            Console.WriteLine($"Dogs eat meat.\n");
        }
    }
}
