using System;
using Les2_AbstractClasses.AbilitySystem;

namespace Les2_AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            AbilitySystemComponent abilitySystemComponent = new AbilitySystemComponent();

            Ability penetratingRound = new PenetratingRound("Penetrating Round",
                "Deal 205 (+4% per level) damage, knock back, and Slow enemies in a line by 20% for 2 seconds. Enemies close to Raynor are knocked back further.");

            Ability inspire = new Inspire("Inspire",
                "All nearby allied Minions and Mercenaries gain 30% Attack Speed and 10% Movement Speed for 4 seconds.");
            
            abilitySystemComponent.AddAbility(penetratingRound);
            abilitySystemComponent.AddAbility(inspire);
            
            abilitySystemComponent.Use(0);
        }
    }
}