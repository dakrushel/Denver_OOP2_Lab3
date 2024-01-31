using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krushel_lab3
{
    public class Cat : Animal
    {
        public Cat() { }

        public Cat(string name, string colour, int age)
        {
            this.Name = name;
            this.Colour = colour;
            this.Age = age;
            Console.WriteLine($"New cat {this.Name} created");
        }

        public override string ToString()
        {
            return $"Cat name: {this.Name}\nColor: {this.Colour}\nAge: {this.Age}";
        }
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.\n");
        }
    }
}
