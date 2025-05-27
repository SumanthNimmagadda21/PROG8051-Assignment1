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
        
        public void Feed()
        {
            hunger = Math.Max(1, hunger - 2);
            health = Math.Min(10, health + 1);
            Console.WriteLine(name + " enjoyed the food! Hunger decreased, health improved.");
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