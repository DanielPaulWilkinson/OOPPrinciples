using System;

namespace Object_Orintated_Programming
{

    public abstract class Animal
    {
        private int _numberOfLegs = 0;
        public int NumberOfLegs
        {
            get { return _numberOfLegs; }
            set { _numberOfLegs = value; }
        }

        private string _name { get; set; } = "Animal";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Animal(string Name, int NumberOfLegs)
        {
            this.Name = Name;
            this.NumberOfLegs = NumberOfLegs;
        }

        public abstract void AnimalInformation();
    }

    public class Cat : Animal
    {
        public Cat(string Name, int NumberOfLegs) : base(Name, NumberOfLegs) { }
        
        public override void AnimalInformation()
        {
            Console.WriteLine($"-----------------------");
            Console.WriteLine($"Cat Name: {Name}");
            Console.WriteLine($"Number Of Legs: {NumberOfLegs}");
        }
    }

    public class Horse : Animal
    {
        public Horse(string Name, int NumberOfLegs) : base(Name, NumberOfLegs) { }

        public override void AnimalInformation()
        {
            Console.WriteLine($"-----------------------");
            Console.WriteLine($"Horse Name: {Name}");
            Console.WriteLine($"Number Of Legs: {NumberOfLegs}");
        }
    }

    public class Thoroughbred : Horse
    {
        public Thoroughbred(string Name, int NumberOfLegs) : base(Name, NumberOfLegs) { }

        public override void AnimalInformation()
        {
            Console.WriteLine($"-----------------------");
            Console.WriteLine($"Thoroughbred Name: {Name}");
            Console.WriteLine($"Number Of Legs: {NumberOfLegs}");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Jeff the cat", 4);
            cat.AnimalInformation();

            Animal horse = new Horse("Barney the horse", 4);
            horse.AnimalInformation();

            Animal thoroughbred = new Thoroughbred("Jenny the Thoroughbred", 4);
            thoroughbred.AnimalInformation();
        }
    }
}
