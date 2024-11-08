using OOP_med_flere_types;
using System;
using System.IO;
using System.Media;

namespace OOP_med_flere_types
{
    internal class Sheep : Animal
    {
        public Sheep(string name) : base(name) { }

        public override string MakeSound()
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string filePath = Path.Combine(projectDirectory, "Lydfil", "sheep.wav");
            SoundPlayer player = new SoundPlayer(filePath);
            player.PlaySync();
            return "BAAHHHHHHHHHHHHH";
        }
    }   
}
