using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poli
{
    class Chicken : Bird
    {
        public Chicken(string name) : base(name)
        {
        }

        public override void Fly()
        {
            Console.WriteLine("Chicken cannot fly =(");
        }
    }
}
