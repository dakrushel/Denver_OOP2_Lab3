namespace Krushel_lab3_pt2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a dog name:");
            string uIName = Console.ReadLine();
            Console.WriteLine("Enter the dog's colour:");
            string uIColour = Console.ReadLine();
            Console.WriteLine("Enter the dog's height:");
            double uIHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the dog's age:");
            int uIAge = int.Parse(Console.ReadLine());
            Dog dog1 = new Dog(uIName, uIColour, uIHeight, uIAge);
            dog1.Eat();
            Console.WriteLine(dog1.Cry());

            Console.WriteLine("Enter a cat name:");
            uIName = Console.ReadLine();
            Console.WriteLine("Enter the cat's colour:");
            uIColour = Console.ReadLine();
            Console.WriteLine("Enter the cat's height:");
            uIHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the cat's age:");
            uIAge = int.Parse(Console.ReadLine());
            Cat cat1 = new Cat(uIName, uIColour, uIHeight, uIAge);
            cat1.Eat();
            Console.WriteLine(cat1.Cry());

            Dog dog2 = new Dog("Gus", "black", 21, 5);
            Cat cat2 = new Cat("Tigger", "grey", 11, 1);

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(dog1);
            animals.Add(dog2);
            animals.Add(cat1);
            animals.Add(cat2);

            foreach(IAnimal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
