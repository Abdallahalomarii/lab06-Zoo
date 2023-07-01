﻿using classes.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace classes.Concreate_Classes
{
    // concreate Class third Layer of inheritance 
    public class Duck :Birds
    {
        // override the abstract  member
        public override bool CanFly { get; set; }
        // override the Polymorphism member
        public override double WingSpan { get; set; }
        // Encapsulation 
        private string Habitat { get; set; }

        public Duck(string name, int age, double speed, double wingSpan, bool canFly, string habitat) : base(name, age, speed, wingSpan)
        {
            CanFly = canFly;
            WingSpan = wingSpan;
            Habitat = habitat;
        }
        // override the abstract  method form the base class
        public override string Eat()
        {
            return $"{Name} feeds on aquatic plants, insects, and small aquatic animals.";
        }
        // override the abstract  method form the base class

        public override string Sleep()
        {
            return $"{Name} rests and sleeps on land or in nests near water bodies.";
        }
        // override the abstract  method form the base class

        public override string Sound()
        {
            return $"{Name} makes a quacking sound as its vocalization.";
        }
        // override the abstract  method form the base class

        public override string Living()
        {
            return $"{Name} can be found in various habitats, including lakes, rivers, and wetlands. but {Name} lives in {Habitat}";
        }
        // override the abstract  method form the Birds Class

        public override string Fly()
        {
            if (CanFly)
            {
                return $"{Name} can fly and often migrates long distances.";
            }
            else
            {
                return $"{Name} is not known for long-distance flying.";
            }
        }
        // override the Polymorphism  method form the Birds Class

        public override string DisplayWingSize()
        {
            return $"{Name}'s wing span is approximately {WingSpan} centimeters.";
        }

        public string Swim()
        {
            return $"{Name} is a proficient swimmer, moving gracefully through the water at a speed of {Speed} km/h.";
        }
    }
}
