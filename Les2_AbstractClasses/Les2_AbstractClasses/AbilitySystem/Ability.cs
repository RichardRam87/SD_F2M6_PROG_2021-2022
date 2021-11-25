namespace Les2_AbstractClasses.AbilitySystem
{
    public abstract class Ability
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        protected Ability(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
        public abstract void Use();
    }
}
