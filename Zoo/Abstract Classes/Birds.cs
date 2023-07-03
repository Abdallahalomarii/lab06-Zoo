using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace classes.Abstract_Classes
{
    // Second Layer inheritance from Animal and it is abstract class
    public abstract class Birds : Animal
    {
        // abstract member
        public abstract bool CanFly { get; set; }
        // polymorphism member
        public virtual double WingSpan { get; set; }

        public Birds(string name, int age, double speed, double wingSpan) : base(name, age, speed)
        {
        }
        // Abstract Method 
        public abstract string Fly();
        // Polymorphism method
        public virtual string DisplayWingSize() 
        {
            return "Size Of the Birds Wings";
        }
    }
}
