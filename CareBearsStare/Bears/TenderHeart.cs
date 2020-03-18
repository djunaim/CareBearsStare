using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearsStare.Bears
{
    class TenderHeart : CareBearBase
    {
        public TenderHeart()
        {
            Name = "Tender Heart";
            BellyBadge = "Heart";
            Color = BearColor.Brown;
        }
        public override void Stare()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;            
            // font color
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{Name} shoots hearts from his belly.");
            Console.ResetColor();
        }
    }
}
