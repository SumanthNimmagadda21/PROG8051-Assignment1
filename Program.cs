using System;

namespace VirtualPetApp
{
    class VirtualPet
    {
        public string name;
        public string type;
        public int hunger = 5;
        public int happiness = 5;
        public int health = 5;

        public VirtualPet(string petName, string petType)
        {
            name = petName;
            type = petType;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Virtual Pet Simulator");
        }
    }
}