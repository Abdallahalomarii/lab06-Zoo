using classes.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes.Concreate_Classes
{
    // concreate Class third Layer of inheritance 
    public class Eagle : Birds
    {
        // override the abstract  member
        public override bool CanFly { get; set; }
        // override the Polymorphism member
        public override double WingSpan { get; set; }
        // Encapsulation 
        private double BeakLength { get; set; }

        public Eagle(string name,int age, double speed, double wingSpan, bool canFly , double beakLength) : base(name, age, speed, wingSpan)
        {
            CanFly = canFly;
            WingSpan = wingSpan;
            BeakLength = beakLength;
        }
        // override the abstract  method form the Birds Class
        public override string Eat()
        {
            return $"{Name} feeds on small mammals, fish, and reptiles.";
        }
        // override the abstract  method form the Birds Class
        public override string Sleep()
        {
            return $"{Name} rests and sleeps perched on high branches or cliffs.";
        }
        // override the abstract  method form the Birds Class
        public override string Sound()
        {
            return $"{Name} emits a high-pitched screech or whistle as its vocalization.";
        }
        // override the abstract  method form the Birds Class
        public override string Living()
        {
            return $"{Name} inhabits various habitats, including forests, mountains, and coasts.";
        }
        // override the abstract  method form the Birds Class
        public override string Fly()
        {
            if (CanFly)
            {
                return $"{Name} soars through the sky with majestic wings, utilizing its exceptional flying abilities.";
            }
            else
            {
                return $"{Name} Cannot fly.";
            }
        }
        // override the Polymorphism  method form the Birds Class
        public override string DisplayWingSize()
        {
            return $"{Name}'s wing span is approximately {WingSpan} meters.";
        }

        public string Beak()
        {
            return $"{Name}'s Beak Length about {BeakLength}Cm";
        }


    }
}
