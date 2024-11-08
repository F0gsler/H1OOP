using OOP_med_flere_types;
using System;
using System.IO;
using System.Media;

namespace OOP_med_flere_types
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override string MakeSound()
        {
            string opgaveDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string filePath = Path.Combine(opgaveDirectory, "Lydfil", "dog.wav");
            SoundPlayer player = new SoundPlayer(filePath);
            player.PlaySync();
            return "VUFFFFFF";
        }
    }
}
