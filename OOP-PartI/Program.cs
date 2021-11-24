using System;

namespace OOP_PartI
{
    class Program
    {
        class Dog
        {
            //class fields
            string name;
            string spots;
            double happiness;

            public Dog(string _name, int _spots)//constructor
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} has been created");
            }

            //getters
            public string Name
            {
                get { return name; }
            }

            public string Spots
            {
                get { return spots; }

            }
            public double Happiness
            {
                get { return happiness; }
            }

            public void Meows()
            {
                Console.WriteLine("meeoww");
                happiness += 0.2; //happiness = happiness + 0.2
            }

            public void Wags()
            {
                Console.WriteLine("wiggle wiggle");
            }

            public void Rename(string newName)
            {
                name = newName;
            }

            public void ShowDogData()
            {
                Console.WriteLine($"name: {Name}");
                Console.WriteLine($"spots: {Spots}");
                Console.WriteLine($"happiness: {Happiness}");
            }
        }
        static void Main(string[] args)
        {
            Dog myDog = new Dog("pablo", 15);
            myDog.Meows ();
            Console.WriteLine($"{myDog.Name}'s level of happiness: {myDog.Happiness}");
            

            while (myDog.Happiness != 1)
            {
                myDog.Meows();
            }
            myDog.Wags();

            Console.WriteLine($"Enter a new name for the dog {myDog.Name}");
            string userInput = Console.ReadLine();
            myDog.Rename(userInput);
            myDog.ShowDogData();

        }

    }
    
}
