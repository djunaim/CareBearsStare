using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearsStare.Bears
{
    class GrumpyBear : CareBearBase
    {
        // constructor initializes things to a place that makes sense to start from
        public GrumpyBear()
        {
            BellyBadge = "Rain Cloud";
            Color = BearColor.Blue;
            Name = "Grumpy Bear";
        }
        // override is sibling of abstract key word
        // changing behavior from base class to what it is now
        public override void Stare()
        {
            {
                Console.WriteLine("Stares aggressively into the distance while shooting a beam from his belly.");
            }
        }

        // use override to cnange Hug method
        public override void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"Gumpy bear hates hugs and instead shuns {careBearToHug.Name}.");
        }
    }
}
