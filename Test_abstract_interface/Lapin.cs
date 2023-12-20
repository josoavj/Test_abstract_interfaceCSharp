using System;
using System.Collections.Generic;
using System.Text;

namespace Test_abstract_interface
{
    class Lapin : Animal, IProie
    {
        public override void Identify()
        {
            Console.WriteLine("I'm a rabbit");
        }
        public override void Crier()
        {
            Console.WriteLine("Psiou Psiou Psiou");
        }

        public void Etremanger()
        {
            Console.WriteLine("Help me!!!");
        }
    }
}
