using System;
using src.entities;

namespace RPG_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero1 = new Knight("Arus", 28, "Warrior");
            Hero hero2 = new Wizard("Amalia", 28, "Mage");


            Console.WriteLine(hero1.GetHP());
            Console.WriteLine(hero1.GetMP());


            Console.WriteLine(hero2.GetHP());
            Console.WriteLine(hero2.GetMP());




            
           // Console.WriteLine(hero1.Attack());
           // Console.WriteLine(hero2.Attack());
        }
    }
}
