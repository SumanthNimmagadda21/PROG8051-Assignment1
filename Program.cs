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

        public void ShowStatus()
        {
            Console.WriteLine("\n--- " + name + "'s Status ---");
            Console.WriteLine("Hunger: " + hunger + "/10");
            Console.WriteLine("Happiness: " + happiness + "/10");
            Console.WriteLine("Health: " + health + "/10");

            if (hunger >= 9)
                Console.WriteLine("⚠️ Warning: Hunger is very high!");
            if (happiness <= 2)
                Console.WriteLine("⚠️ Warning: Happiness is very low!");
            if (health <= 2)
                Console.WriteLine("⚠️ Warning: Health is very low!");

            if (hunger >= 10 || happiness <= 1)
            {
                health = Math.Max(1, health - 1);
                Console.WriteLine("⚠️ " + name + "'s health is deteriorating due to neglect.");
            }
        }

        public void TimePasses()
        {
            hunger = Math.Min(10, hunger + 1);
            happiness = Math.Max(1, happiness - 1);
        }

        public void Wait()
        {
            Console.WriteLine("\nTime passes...");
            TimePasses();
            ShowStatus();
        }

    }
        
    class Program
    {
        static void Main()
        {
            Console.WriteLine("🐾 Welcome to the Virtual Pet Simulator! 🐾");
            Console.WriteLine("Take care of your pet by feeding, playing, and resting.");
            Console.WriteLine("Keep an eye on its hunger, happiness, and health!\n");

            Console.Write("Choose your pet type (cat/dog/rabbit): ");
            
            string type = Console.ReadLine();

            Console.Write("Give your pet a name: ");
            string name = Console.ReadLine();

            VirtualPet pet = new VirtualPet(name, type);

            Console.WriteLine("\n🎉 You adopted a " + type + " named " + name + "!\n");

            bool playing = true;

            while (playing)
            {
                pet.ShowStatus();
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Feed");
                Console.WriteLine("2. Play");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Pass Time");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                    pet.Feed();
                else if (choice == "2")
                    pet.Play();
                else if (choice == "3")
                    pet.Rest();
                else if (choice == "4")
                    pet.Wait();
                else if (choice == "5")
                {
                    playing = false;
                    Console.WriteLine("Thanks for playing! Bye!");
                }
            }
        }
    }
}