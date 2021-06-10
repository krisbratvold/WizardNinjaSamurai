using System;

namespace WizardNinjaSamurai
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }
        public override int Attack(Human target)
        {
            Random rand = new Random();
            int dmg = (Dexterity + 5);
            if (rand.Next(1,6) == 2){
                dmg *= 2;
            }
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
        public void Steal(Human target)
        {
            int dmg = 5;
            this.health += dmg;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            Console.WriteLine($"{Name} has {this.health} health");

        }
    }
}