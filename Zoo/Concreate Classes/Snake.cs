using classes.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace classes.Concreate_Classes
{
    // concreate Class third Layer of inheritance 
    public class Snake : Reptiles
    {
        // override the abstract  member
        public override bool HasLegs { get; set; }
        // override the abstract  member
        public override string FurColor { get; set; }
        // override the Polymorphism member
        public override bool IsPoisonous { get; set; }
        public Snake(string name, int age, double speed, bool isPoisonous, bool hasLegs, string furColor)
            : base(name, age, speed, isPoisonous)
        {
            HasLegs = hasLegs;
            FurColor = furColor;
            IsPoisonous = isPoisonous;
        }
        // override the abstract  method form the base class
        public override string Eat()
        {
            return $"{Name} primarily feeds on small mammals, birds, and reptiles.";
        }
        // override the abstract  method form the base class
        public override string Sleep()
        {
            return $"{Name} rests in hidden areas such as burrows or vegetation.";
        }
        // override the abstract  method form the base class
        public override string Sound()
        {
            return $"{Name} produces hissing sounds when threatened.";
        }
        // override the abstract  method form the base class
        public override string Living()
        {
            return $"{Name} inhabits various environments including forests, grasslands, and deserts.";
        }
        // override the abstract  method form the Reptiles Class

        public override string Legs()
        {
            if (HasLegs)
            {
                return $"{Name} has a unique body structure without legs.";
            }
            else
            {
                return $"{Name} Doesn't has Legs.";
            }
        }
        // override the abstract  method form the Reptiles Class

        public override string Fur_Color()
        {
            return $"{Name} exhibits a wide range of colors and patterns, but this snake has {FurColor} color";
        }
        // override the abstract  method form the Reptiles Class

        public override string Poisonous()
        {
            if (IsPoisonous)
            {
                return $"{Name} is venomous, delivering potent venom through its fangs. and Dangerous on Humans";
            }
            else
            {
                return $"{Name} is not venomous. Some snakes are not killed by poison, but by swallowing";
            }
        }
        // override the Polymorphism  method form the Reptiles Class
        public override string SharpTeeth()
        {
            return $"{Name} has sharp teeth used for capturing and gripping its prey.";
        }

        public string ShedSkin()
        {
            return $"{Name} periodically sheds its skin as it grows.";
        }
    }

}
