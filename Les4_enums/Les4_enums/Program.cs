using System;

namespace Les4_enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            Pokemon pikachu = new Pokemon("Pikachu", PokemonTypes.Electric);
            Pokemon charmander = new Pokemon("Charmander", PokemonTypes.Fire);
            Pokemon voltorb = new Pokemon("Voltorb", PokemonTypes.Electric);
            
            pokedex.AddPokemon(pikachu);
            pokedex.AddPokemon(charmander);
            pokedex.AddPokemon(voltorb);

            Pokemon[] allElectricPokemon = pokedex.GetPokemonOfType(PokemonTypes.Electric);

            foreach (Pokemon pokemon in allElectricPokemon)
            {
                Console.WriteLine($"{pokemon.Name}");
            }
        }
    }
}