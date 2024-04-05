using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poli
{
    abstract class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Bird ate wheat");
        }
        public virtual void Fly()
        {
            Console.WriteLine("Bird flied");
        }
    }
}
