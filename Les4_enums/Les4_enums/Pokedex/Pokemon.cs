namespace Les4_enums
{
    public class Pokemon
    {
        public string Name { get; private set; }
        public PokemonTypes Type { get; private set; }
        
        public Pokemon(string name, PokemonTypes type)
        {
            Name = name;
            Type = type;
        }
    }
}