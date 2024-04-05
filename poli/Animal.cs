using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poli
{
    abstract class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Eat();
        public override string ToString()
        {
            return $"{{Name : {Name}}}";
        }
    }
}
