using OOP_med_flere_types;

namespace OOP_med_flere_types
{
    internal static class animalstyper
    {
        public static Animal CreateAnimal(animalsenum animalType, string name)
        {
            return animalType switch
            {
                animalsenum.Dog => new Dog(name),
                animalsenum.Cat => new Cat(name),
                animalsenum.Sheep => new Sheep(name),
                _ => null
            };
        }
    }
}
