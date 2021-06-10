using System;

namespace WizardNinjaSamurai
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            health = 200;
        }
        public override int Attack(Human target)
        {
            int dmg = 100;
            target.health -= dmg;
            if(target.health < 50)
            {
                target.health = 0;
            }
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
        public void Meditate()
        {
            this.health = 200;
        }
    }
}