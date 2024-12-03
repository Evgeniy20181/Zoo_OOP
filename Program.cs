using System;
using System.Collections.Generic;

namespace ZooManagement
{
    // Base class (Superklasse)
    public abstract class Animal
    {
        public string Name { get; private set; }
        public string Species { get; private set; }

        protected Animal(string name, string species)
        {
            Name = name;
            Species = species;
        }

        // Metoder som kan overstyres (polymorfisme)
        public abstract string LagerHvilkenLyd();
        public abstract void Spiser();
        public abstract bool ErFarlig();

        public override string ToString()
        {
            return $"{Name} ({Species})";
        }
    }

    // Derived class (Undertype 1)
    public class Lion : Animal
    {
        public Lion(string name) : base(name, "Lion") { }

        public override string LagerHvilkenLyd() => "Roar!";
        public override void Spiser() => Console.WriteLine($"{Name} spiser kjøtt.");
        public override bool ErFarlig() => true;

        public void Jager() => Console.WriteLine($"{Name} er ute på jakt!");
    }

    // Derived class (Undertype 2)
    public class Elephant : Animal
    {
        public Elephant(string name) : base(name, "Elephant") { }

        public override string LagerHvilkenLyd() => "Trumpet!";
        public override void Spiser() => Console.WriteLine($"{Name} spiser planter.");
        public override bool ErFarlig() => false;

        public void KanLofteHvorTungt(int kg) => Console.WriteLine($"{Name} kan løfte {kg} kg!");
    }

    // Derived class (Undertype 3)
    public class Frog : Animal
    {
        public Frog(string name) : base(name, "Frog") { }

        public override string LagerHvilkenLyd() => "Croak!";
        public override void Spiser() => Console.WriteLine($"{Name} spiser insekter.");
        public override bool ErFarlig() => false;

        public void TrengerVannIHabitat() => Console.WriteLine($"{Name} trenger vann i sitt habitat.");
    }

    // Zoo Management System
    public class Zoo
    {
        private readonly List<Animal> _animals = new();

        public void RegistrerDyr(Animal animal)
        {
            _animals.Add(animal);
            Console.WriteLine($"Dyret {animal} er registrert i dyrehagen.");
        }

        public void VisAlleDyr()
        {
            Console.WriteLine("Dyrene i dyrehagen:");
            foreach (var animal in _animals)
            {
                Console.WriteLine(animal);
            }
        }

        public void UtførHandlinger()
        {
            foreach (var animal in _animals)
            {
                Console.WriteLine($"\nDyret: {animal}");
                Console.WriteLine($"Lyd: {animal.LagerHvilkenLyd()}");
                animal.Spiser();
                Console.WriteLine($"Er farlig: {(animal.ErFarlig() ? "Ja" : "Nei")}");
            }
        }
    }

    // Program Execution
    class Program
    {
        static void Main(string[] args)
        {
            var zoo = new Zoo();

            // Oppretter ulike dyr
            var lion = new Lion("Simba");
            var elephant = new Elephant("Dumbo");
            var frog = new Frog("Kermit");

            // Registrer dyr i dyrehagen
            zoo.RegistrerDyr(lion);
            zoo.RegistrerDyr(elephant);
            zoo.RegistrerDyr(frog);

            // Vis dyr og utfør handlinger
            Console.WriteLine();
            zoo.VisAlleDyr();
            Console.WriteLine();
            zoo.UtførHandlinger();

            // Spesifikke handlinger
            Console.WriteLine();
            lion.Jager();
            elephant.KanLofteHvorTungt(500);
            frog.TrengerVannIHabitat();
        }
    }
}
