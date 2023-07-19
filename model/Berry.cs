using System;

namespace model
{
    public class Berry
    {
        public List<Flavor?> flavors { get; set; }
        public int id { get; set; }
        public string? name { get; set; }

        public EstadoBerry? estadoDestaBerry;

        public override string? ToString()
        {
            return $"Nome: {name},";
        }
        public void showFlavors(){
            foreach (var item in flavors)
            {
                Console.WriteLine(item);
            }
        }
    }
}
