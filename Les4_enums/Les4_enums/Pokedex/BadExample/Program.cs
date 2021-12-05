using System;

namespace Les4_enums.BadExample
{
    public class Program
    {
        static void BadExampleMain(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            Pokemon pikachu = new Pokemon("Pikachu", 0);
            Pokemon charmander = new Pokemon("Charmander", 1);
            Pokemon voltorb = new Pokemon("Voltorb", 2);
            
            pokedex.AddPokemon(pikachu);
            pokedex.AddPokemon(charmander);
            pokedex.AddPokemon(voltorb);

            Pokemon[] allPokemonOfType = pokedex.GetPokemonOfType(1);

            foreach (Pokemon pokemon in allPokemonOfType)
            {
                Console.WriteLine($"{pokemon.Name}");
            }
        }
    }
}