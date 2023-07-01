using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes.Abstract_Classes
{
    public abstract class Mammals : Animal
    {
        // Abstract Porperty

        public abstract string MainColor { get; set; }
        // Polymorphism Property
        public virtual bool HasFur { get; set; }

        public Mammals(string name, int age, double speed, bool hasFur) : base(name, age, speed)
        {

        }
        // Polymorphism Method
        public virtual string Dangerous()
        {
            return "The Mammals can be Dangerous or can be Pet";
        }
    }
}
