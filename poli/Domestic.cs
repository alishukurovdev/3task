using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poli
{
    abstract class Domestic : Animal,Iswim
    {
        public Domestic(string name) : base(name)
        {
        }

        public int MaxSwimTime { get; set; } = 1;

        public void Pet()
        {
            Console.WriteLine("Being pet");
        }

        public void Swim()
        {
            Console.WriteLine("dog swimming");
        }
    }
}
