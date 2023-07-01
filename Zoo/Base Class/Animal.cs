using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    // Base Class and abstract class
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Speed { get; set; }

        public Animal(string name, int age, double speed)
        {
            Name = name;
            Age = age;
            Speed = speed;
        }
        // Abstract Methods 
        public abstract string Eat();
        public abstract string Sound();
        public abstract string Sleep();
        public abstract string Living();
    }
}
