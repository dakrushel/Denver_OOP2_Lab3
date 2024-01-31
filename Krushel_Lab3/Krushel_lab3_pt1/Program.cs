namespace Krushel_lab3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a dog name.");
            string animalName = Console.ReadLine();
            //Console.WriteLine($"Your pet's name is {animalName}");

            Animal dog = new Dog(animalName, "brown", 2);
            Console.WriteLine(dog.ToString());
            dog.Eat();
            Console.WriteLine("Please enter a cat name.");
            animalName = Console.ReadLine();
            Animal cat = new Cat(animalName, "grey", 5);
            Console.WriteLine(cat.ToString());
            cat.Eat();
        }
    }
}
