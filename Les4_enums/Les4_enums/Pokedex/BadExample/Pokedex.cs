using System.Collections.Generic;

namespace Les4_enums.BadExample
{
    public class Pokedex
    {
        private List<Pokemon> _pokemons;

        public Pokedex()
        {
            _pokemons = new List<Pokemon>();
        }

        public void AddPokemon(Pokemon pokemon)
        {
            _pokemons.Add(pokemon);
        }

        public Pokemon[] GetAllPokemon()
        {
            return _pokemons.ToArray();
        }

        public Pokemon[] GetPokemonOfType(int type)
        {
            List<Pokemon> typedPokemon = new List<Pokemon>();

            foreach (Pokemon pokemon in _pokemons)
            {
                if (pokemon.Type == type)
                    typedPokemon.Add(pokemon);
            }

            if (typedPokemon.Count <= 0)
                return null;

            return typedPokemon.ToArray();
        }
    }
}