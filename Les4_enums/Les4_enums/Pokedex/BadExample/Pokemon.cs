namespace Les4_enums.BadExample
{
    public class Pokemon
    {
        public string Name { get; private set; }
        public int Type { get; private set; }
        
        public Pokemon(string name, int type)
        {
            Name = name;
            Type = type;
        }
    }
}