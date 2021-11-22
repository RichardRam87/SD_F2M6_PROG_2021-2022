using System;

namespace Les2_AbstractClasses.AbilitySystem
{
    public class PenetratingRound : Ability
    {
        private int damage = 20;
        public PenetratingRound(string name, string description) : base(name, description)
        {
        }

        public override void Use()
        {
            Console.WriteLine($"You used {Name} on the enemy dealing {damage} damage!");
        }
    }
}