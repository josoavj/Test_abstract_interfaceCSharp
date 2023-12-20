using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_abstract_interface
{
    class Chien : Animal, IPredateur
    {
        public override void Identify()
        {
            Console.WriteLine("I'm a dog");
        }
        public override void Crier()
        {
            Console.WriteLine("Woof Woof");
        }

        public void Chasser(IProie p)
        {
            Console.WriteLine("Run then eat the target");
            p.Etremanger();
        }
    }
}
