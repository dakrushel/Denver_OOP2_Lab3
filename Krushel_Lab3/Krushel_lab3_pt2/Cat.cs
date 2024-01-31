using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krushel_lab3_pt2
{
    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        //ctor
        public Cat() { }
        public Cat(string name, string colour, double height, int age)
        {
            this.Name = name;
            this.Colour = colour;
            this.Height = height;
            this.Age = age;
        }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }
        public string Cry()
        {
            return "Meow!";
        }
    }
}
