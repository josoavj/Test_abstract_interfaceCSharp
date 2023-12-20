using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Test_abstract_interface;

class Program
{
    static void Main(string[] args)
    {
        // Instanciation des classes
        // Les classes abstraites ne peuvent être instancié mais uniquement
        // par les classes qui les  héritent
        Chien c = new Chien();
        Lapin l = new Lapin();
        Chat ch = new Chat();

        // Faire crier le chat 
        ch.Identify();
        ch.Crier();
        Console.WriteLine(" ");
        
        // Chasser et dévorer
        static void faireChasser(IPredateur p, IProie proie)
        {
            p.Chasser(proie);
        }

        // Identification du prédateur
        Console.WriteLine("I'm the predator");
        c.Identify();
        c.Crier();
        Console.WriteLine(" ");

        // Identification du cible
        Console.WriteLine("I'm the target XD");
        l.Identify();
        l.Crier();
        Console.WriteLine(" ");

        // Whoami
        Console.WriteLine("Who's the target?");
        faireChasser(c,l);
    }
}