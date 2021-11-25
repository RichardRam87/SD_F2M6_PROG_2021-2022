namespace Les2_AbstractClasses.AbilitySystem.BadExamples
{
    // this is a bad example, do not copy...
    /*
     * Deze class doorbreekt open open closed principe.
     * Als een ability  geen mana kost, waarom heeft deze dan wel een variable?
     * Als je ability geen mana kost, waarom is hier dan wel een variabel voor?
     * Voor elke ability die je gaat verzinnen zul je, deze class moeten bewerken
     * En dat wil je zoveel mogelijk voorkomen.
     *
     * Deze class is dus niet gesloten voor verandering
     */
    public class Ability
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public bool isRanged { get; private set; }
        public bool isMelee { get; private set; }
        
        public int manaCost { get; private set; }
        public int otherResourceCost { get; private set; }
        
        protected Ability(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public void Use()
        {
            if (isRanged)
            {
                // specifieke functie call dit past bij een ranged attack
                // je zult hier nog moeten specificeren wat de ranged attack doet?
                // Zijn er meerdere ranged attacks, ga je dit hier moeten bewerken
            }
            else if (isMelee)
            {
                
            }
        }
    }
}
