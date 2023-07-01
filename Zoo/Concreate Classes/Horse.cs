using classes.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    // concreate Class third Layer of inheritance 
    public class Horse : Mammals
    {
        // override the abstract Property 
        public override string MainColor { get; set; }

        // override the abstract Property 
        public override bool HasFur { get; set; }

        // override the polymorphism method 
        private string Breed { get; set; }

        
        public Horse(string name, int age, double speed, bool hasFur, string mainColor, string breed) : base(name, age, speed, hasFur)
        {
            this.HasFur = hasFur;
            this.MainColor = mainColor;
            this.Breed = breed;
        }

        // override the abstract method from the base class
        public override string Eat()
        {
            return $"{Name} primarily eats grass and other vegetation, making them herbivores.";
        }
        // override the abstract method from the base class
        public override string Sleep()
        {
            return $"{Name} typically sleeps while standing, but they can also lay down.";
        }
        // override the abstract method from the base class
        public override string Sound()
        {
            return $"{Name} makes sounds like neighing, snorting, and whinnying.";
        }
        // override the abstract method from the base class
        public override string Living()
        {
            string living = $"{Name} lives in various habitats, including grasslands, forests, and deserts.";
            return $"{living} They are adaptable and can thrive in different environments.";
        }
        // override the abstract method  from the mammal class
        public override string Dangerous()
        {
            return $"{Name} can be dangerous in certain situations, but they are generally docile and domesticated animals.";
        }

        public string Gallop()
        {
            return $"The {Breed} horse named {Name} is galloping at a speed of {Speed} km/h.";
        }


    }
}
