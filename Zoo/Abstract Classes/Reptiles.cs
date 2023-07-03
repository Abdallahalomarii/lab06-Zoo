using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace classes.Abstract_Classes
{
    // Second Layer inheritance from Animal and it is abstract class
    public abstract class Reptiles : Animal
    {
        // abstract member
        public abstract bool HasLegs { get; set; }
        // abstract member
        public abstract string FurColor { get; set; }
        // polymorphism member
        public virtual bool IsPoisonous { get; set; }



        public Reptiles(string name, int age, double speed, bool isPoisonous)
            : base (name,age,speed)
        {

        }
        // abstract method
        public abstract string Legs();
        // abstract method
        public abstract string Fur_Color();
        // abstract method
        public abstract string Poisonous();
        // polymorphism method
        public virtual string SharpTeeth()
        {
            return "These reptiles has sharp Teeth";
        }
    }
}
