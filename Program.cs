using Projeto_RPG.src.Entities;
using System;

namespace Projeto_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Knight = new Knight("Arus",23,"Knight");
            Wizard wizard = new Wizard("Jenica", 23,"White Wizard");
            Console.WriteLine(Knight);
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
        }
    }
}
