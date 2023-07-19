using System;

namespace model
{
    public class Flavor
    {
        public EstadoBerry? flavor { get; set; }
        public int potency { get; set; }

        public override string? ToString()
        {
            return $"Potência: {potency}, Sabor: {flavor}";
        }
    }
}
