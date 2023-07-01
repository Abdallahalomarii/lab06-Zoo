using classes.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
        // concreate Class third Layer of inheritance 
    public class Lion : Mammals
    {
        // override the abstract  member
        public override string MainColor { get; set; }

        // override the Polymorphism  member
        public override bool HasFur { get; set; }

        // Encapsulation 
        private string Habitat { get; set; }

        public Lion(string name, int age, double speed, bool hasFur, string mainColor, string habitat) : base(name, age, speed, hasFur)
        {
            this.HasFur = hasFur;
            MainColor = mainColor;
            this.Habitat = habitat;
        }

        // override the abstract  method form the base class
        public override string Eat()
        {
            return $"{Name} eating meats so they are Carnivores";
        }
        // override the abstract  method form the base class
        public override string Sleep()
        {
            return $"{Name} sleep under the Trees";
        }
        // override the abstract  method form the base class
        public override string Sound()
        {
            return $"{Name} Roars Loudly!";
        }
        // override the abstract  method form the base class, using the private members here...
        public override string Living()
        {
            string living = $"{Name} lives in grasslands, savannas, open woodlands";
            return $"{living} but {Name} living in {Habitat}";
        }

        // override the Polymorphism  method from the Mammal Class
        public override string Dangerous()
        {
            return $"{Name} are dangerous, Including humans!";
        }

        // normal method 
        public string Hunt()
        {
            return $"{Name}'s Hunting for his Prey. his Speed can Reach to {Speed} Km/h when he is hunting.";
        }

    }
}
