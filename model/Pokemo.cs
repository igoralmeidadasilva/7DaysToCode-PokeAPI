using System;
using System.Text.Json.Serialization;

namespace model
{
    public class Pokemon
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("weight")]
        public double Weight { get; set; }
        [JsonPropertyName("height")]
        public double Height { get; set; }
        
        public List<AbilitiesClass>? abilities { get; set; }

        public override string? ToString()
        {
            return $"Nome: {Name}\n" +
                   $"Altura: {Weight}\n" +
                   $"Peso: {Height}";
        }

        public void showAbilities (){
            if(this.abilities != null){
                Console.WriteLine("HABILIDADES:");
                foreach (var item in abilities)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
