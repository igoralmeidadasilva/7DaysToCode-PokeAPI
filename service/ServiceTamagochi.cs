using System;
using System.Text.Json;
using model;
using RestSharp;

namespace service
{
    public static class ServiceTamagochi
    {
        private static List<Pokemon> listaMascote = new List<Pokemon>();
        private static void getPokemon(string pokemon)
        {
            var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{pokemon}");
            RestRequest request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            if((response.StatusCode == System.Net.HttpStatusCode.OK) && (response.Content != null)){
                Pokemon? mascote = JsonSerializer.Deserialize<Pokemon>(response.Content);
                if(mascote != null){
                    listaMascote.Add(mascote);
                }
            } else {
                Console.WriteLine(response.ErrorMessage);
            }
        }

        public static void buscarPokemon()
        {
            getPokemon("pikachu");
            getPokemon("eevee");
            getPokemon("charmander");
            getPokemon("bulbasaur");
            getPokemon("squirtle");
        }

        public static IList<Pokemon> getListaMascote(){
            buscarPokemon();
            return listaMascote;
        }

        private static Berry getBerrys(string num)
        {
            var client = new RestClient($"https://pokeapi.co/api/v2/berry/{num}");
            RestRequest request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            if((response.StatusCode == System.Net.HttpStatusCode.OK) && (response.Content != null)){
                Berry berry= JsonSerializer.Deserialize<Berry>(response.Content!)!;
                if(berry != null){
                    return berry;
                }
            } else {
                Console.WriteLine(response.ErrorMessage);
            }
            return new Berry();
        }

        public static List<Berry> getListaBerry()
        {
            var retorno = new List<Berry>();
            for (int i = 1; i < 21; i++)
            {
                retorno.Add(getBerrys(Convert.ToString(i)));
            }
            return retorno;
        }
    }
}
