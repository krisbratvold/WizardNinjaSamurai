using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            health = 50;
            Intelligence = 25;
        }
        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.health -= dmg;
            this.health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
        public void Heal(Human target)
        {
            int heal = Intelligence * 10;
            target.health += heal;
        }
    }
}