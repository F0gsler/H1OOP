using System;

namespace OOP_med_flere_types
{
    internal abstract class Animal
    {
        public string Name { get; set; }

        protected Animal(string name)
        {
            Name = name;
        }

        public abstract string MakeSound();
    }
}
