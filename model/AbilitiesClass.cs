using System;

namespace model
{
    public class AbilitiesClass
    {
        public Ability? ability { get; set; }

        public override string? ToString()
        {
            return ability?.name?.ToUpper();
        }
    }
}
