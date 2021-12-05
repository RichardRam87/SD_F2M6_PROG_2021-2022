using System.Collections.Generic;

namespace Les2_AbstractClasses.AbilitySystem
{
    public class AbilitySystemComponent
    {
        private List<Ability> abilities;

        public AbilitySystemComponent()
        {
            abilities = new List<Ability>();
        }

        public void AddAbility(Ability ability)
        {
            abilities.Add(ability);
        }

        public void Use(int index)
        {
            abilities[index].Use();
        }
    }
}