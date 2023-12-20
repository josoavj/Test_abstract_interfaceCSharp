using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_abstract_interface
{
    class Chat : Animal, IPredateur
    {
        public override void Identify()
        {
            Console.WriteLine("I'm a cat");
        }
        public override void Crier()
        {
            Console.WriteLine("Meow");
        }

        public void Chasser(IProie p)
        {
            Console.WriteLine("Miazakazaka dia mihinana");
            p.Etremanger();
        }
    }
}
