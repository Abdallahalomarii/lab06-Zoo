using classes.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Zoo.Interface;

namespace classes.Concreate_Classes
{
    // concreate Class third Layer of inheritance 
    public class Crocodile : Reptiles, IEggLayer,ISwimable,IHaveClaw
    {
        // override the abstract methods 
        public override bool HasLegs { get; set; }
        // override the abstract  member
        public override string FurColor { get; set; }
        // override the Polymorphism member
        public override bool IsPoisonous { get; set; }
        // Encapsulation 
        private double Length { get; set; }

        // member From IEggLayer Interface
        public int AverageEgg { get; set; }
        // Member from ISwimmable interface
        public int SwimmingSpeed { get; set; }
        // Member from IHaveClaw interface
        public double ClawLength { get; set; }

        public Crocodile(string name, int age, double speed, bool isPoisonous, bool hasLegs, string furColor , double length)
            : base(name, age, speed, isPoisonous)
        {
            HasLegs = hasLegs;
            FurColor = furColor;
            IsPoisonous = isPoisonous;
            Length = length;
        }
        // override the abstract  method form the base class

        public override string Eat()
        {
            return $"{Name} primarily feeds on fish, birds, and mammals near the water.";
        }
        // override the abstract  method form the base class

        public override string Sleep()
        {
            return $"{Name} often rests and sunbathes on the banks of rivers or lakes.";
        }
        // override the abstract  method form the base class

        public override string Sound()
        {
            return $"{Name} produces low-frequency vocalizations, including deep rumbles and hisses.";
        }
        // override the abstract  method form the base class

        public override string Living()
        {
            return $"{Name} is commonly found in freshwater habitats such as rivers, lakes, and swamps.";
        }
        // override the abstract  method form the Reptiles Class

        public override string Legs()
        {
            if (HasLegs)
            {
                return $"{Name} has four strong legs for movement both on land and in water.";
            }
            else
            {
                return $"{Name} moves with the help of its long tail while swimming.";
            }
        }
        // override the abstract  method form the Reptiles Class

        public override string Fur_Color()
        {
            return $"{Name} has {FurColor} coloration, providing camouflage in its natural habitat.";
        }
        // override the abstract  method form the Reptiles Class

        public override string Poisonous()
        {
            if (IsPoisonous)
            {
                return $"{Name} has venomous glands in its jaws, making it a dangerous predator.";
            }
            else
            {
                return $"{Name} is not known to be venomous. but it is predator";
            }
        }
        // override the Polymorphism  method from the Reptiles Class

        public override string SharpTeeth()
        {
            return $"{Name} has powerful jaws filled with sharp teeth used for capturing and tearing its prey.";
        }

        public string BodyLength()
        {
            return $"{Name} has a body length of {Length} Meters";
        }

        //Method Called from the Interface IEggLayer
        public void LayEgg()
        {
            Console.WriteLine($"The Crocodile {Name} Lay Eggs With Average of {AverageEgg}");
        }

        //Method from the ISimmable Interface
        public void Swimmable()
        {
            Console.WriteLine($"The Crocodile {Name} Also Can Swim and Can reach speed about {SwimmingSpeed} KM/h in the water");
        }

        // Methods from the IHaveClaw Interface
        public void Claw()
        {
            Console.WriteLine($"The Crocodile {Name} has A Claw length {ClawLength}Cm");
        }
    }
}
