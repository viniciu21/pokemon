using System.Collections.Generic;
using System.Threading.Tasks;
using PokeApi.Model;

namespace PokeApi.Repositories
{
  public interface IPokemonRepository
  {
    Task AddPokemons(List<Pokemon> pokemons);
    Task<List<Pokemon>> GetPokemonsAsync();
    List<Pokemon> GetPokemons();
    List<PokemonSerialize> GetPokemonsSerialized();
  }
}