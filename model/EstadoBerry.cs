using System;

namespace model
{
    public class EstadoBerry
    {
        public string? name { get; set; }

        public override string? ToString()
        {
            return name;
        }
    }
}
