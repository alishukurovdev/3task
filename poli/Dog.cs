using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poli
{
    internal class Dog : Domestic
    {
        public Dog(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("eating bone");
        }
    }


}
