using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearsStare.Bears
{
    // abstract cannot be instantiated on its own, can only be inherited
    // can still have properties and fields attached to it
    abstract class CareBearBase
    {
        public BearColor Color { get; protected set; }
        public string BellyBadge { get; protected set; }

        // protected - get access to setter and anything that inherits from this, gets access to setter
        public string Name { get; protected set; }

        // abstract method does not specify what method does, but requires anything that inherits this class to have the method and define it
        public abstract void Stare();

        // void method is shared behavior. Anything that inherits this base will have the exact behavior
        public void Care(string humanToCareFor)
        {
            Console.WriteLine($"{Name} cares deeply for {humanToCareFor}");
        }

        // virtual method means each individual care bear can change the behavior if they want to, but don't have to
        public virtual void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"{Name} runs over to {careBearToHug.Name} and squeezes them, pressing their {BellyBadge} and {careBearToHug.BellyBadge} together.");
        }
    }
}
