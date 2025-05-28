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
        public void Play()
        {
            if (hunger >= 9)
            {
                Console.WriteLine(name + " is too hungry to play!");
                return;
            }

            happiness = Math.Min(10, happiness + 2);
            hunger = Math.Min(10, hunger + 1);
            Console.WriteLine(name + " had fun playing! Happiness increased, hunger increased slightly.");
        }

        public void Rest()
        {
            health = Math.Min(10, health + 2);
            happiness = Math.Max(1, happiness - 1);
            Console.WriteLine(name + " is resting. Health improved, happiness slightly decreased.");
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