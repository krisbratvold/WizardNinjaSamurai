using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Wizard kris = new Wizard("Kris");
            Ninja bill = new Ninja("Bill");
            Samurai bob = new Samurai("Bob");
            bill.Attack(kris);
            bill.Steal(bob);

            Console.WriteLine("done");
        }
    }
}
