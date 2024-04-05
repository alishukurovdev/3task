using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poli
{
    class Cat : Domestic
    {
        public Cat(string name) : base(name)
        {
        }

        public void Risofkalanmaq()
        {
            Console.WriteLine("Meow");
        }
        public override void Eat()
        {
            Console.WriteLine("Cat ate lausania");
        }
    }
}
