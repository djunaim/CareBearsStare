using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearsStare.Bears
{
    class TinderHeart : CareBearBase
    {
        public TinderHeart()
        {
            Name = "Tinder Heart";
            BellyBadge = "Cell phone";
            Color = BearColor.Gold;
        }
        public override void Stare()
        {
            Console.WriteLine("Swipe left.");
        }
        public override void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"Swipes right on {careBearToHug.Name}");
        }
    }
}
