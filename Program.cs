using Projeto_RPG.src.Entities;
using System;

namespace Projeto_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus",42,"Knight");
            Ninja ninja = new Ninja("Wedge",42,"Ninja"); 
            WhiteWizard ww = new WhiteWizard("Jenica", 42,"White Wizard");
            BlackWizard bw = new BlackWizard("Topapa", 42, "Black Wizard");
            Console.WriteLine(knight);
            Console.WriteLine(knight.Attack());
            Console.WriteLine(ninja);
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(ww);
            Console.WriteLine(ww.Heal(1));
            Console.WriteLine(ww.Heal(7));
            Console.WriteLine(bw);
            Console.WriteLine(bw.Attack(1));
            Console.WriteLine(bw.Attack(7));
        }
    }
}
