using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poli
{
    abstract class Fish : Animal,Iswim
    {
        public Fish(string name) : base(name)
        {
        }

        public int MaxSwimTime { get; set; } = -1;

        public void Swim()
        {
            Console.WriteLine("Fish swvim");
        }
    }
}
