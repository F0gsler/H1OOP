using OOP_med_flere_types;
using System;

namespace OOP_med_flere_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = animalstyper.CreateAnimal(animalsenum.Dog, "Pyrus");
            Animal cat = animalstyper.CreateAnimal(animalsenum.Cat, "Adolfo");
            Animal sheep = animalstyper.CreateAnimal(animalsenum.Sheep, "Sheepymaker");

            Console.WriteLine(dog.MakeSound());
            Console.WriteLine(cat.MakeSound());
            Console.WriteLine(sheep.MakeSound());
        }
    }
}
