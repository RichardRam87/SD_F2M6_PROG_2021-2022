using System;

namespace Les2_AbstractClasses.AbilitySystem
{
    public class Inspire : Ability
    {
        public Inspire(string name, string description) : base(name, description)
        {
        }

        public override void Use()
        {
            Console.WriteLine($"You cast {Name}, inspiring all around you!");
        }
    }
}