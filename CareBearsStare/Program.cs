using System;
using System.Collections.Generic;
using System.Linq;
using CareBearsStare.Bears;

namespace CareBearsStare
{
    class Program
    {
        static void Main(string[] args)
        {
            var definitions = new Dictionary<string, List<string>>();
            definitions.Add("monica", new List<string> { "smart", "sleepy" });
            definitions["monica"].Where(word => word.StartsWith('s'));
            Console.WriteLine(string.Join("you are", definitions["monica"]));

            var grumpyBear = new GrumpyBear();
            var tenderHeart = new TenderHeart();
            var tinderHeart = new TinderHeart();

            // a new list of CareBearBase
            var careBears = new List<CareBearBase>() { grumpyBear, tenderHeart, tinderHeart };
            
            foreach (var bear in careBears)
            {
                bear.Care("Jo");
                bear.Stare();
            }

            // where similar to filter method from js
            // will create another list but this will only have a list of bears that start with letter T
            var namesThatStartWithT = careBears.Where(bear => bear.Name.StartsWith('T'));

            // transformation. Change shape of collection - what the collection is made of
            // returning collection of strings
            var careBearNames = careBears.Select(bear => bear.Name);

            // order matters
            // do filtering first and then transformation for efficiency
            var careBearNamesThatStartWithT = careBears
                                                .Where(bear => bear.Name.StartsWith('T'))
                                                .Select(bear => bear.Name);

            // returning boolean expression 'is there any bear that is a TinderHeart?'
            // finds the first 1 that is true, and only return that
            var anyTinderHearts = careBears.Any(bear => bear is TinderHeart);

            // will only return true if every care bear is a TinderHeart
            // All method will look until it finds something that doesn't match, and exists out
            var allTinderHearts = careBears.All(bear => bear is TinderHeart);

            // first finds the first thing on the list and returns it
            // can also pass in boolean expression
            var firstBear = careBears.First();
            // give me the first name that starts with letter T
            var firstBearStartingWithT = careBears.First(bear => bear.Name.StartsWith('T'));

            // will throw an exception because no name start with W
            //var blowsUp = careBears.First(bear => bear.Name.StartsWith('W'));

            // give first one that matches or give default view of CareBearBase
            // in this case it will give null value
            var works = careBears.FirstOrDefault(bear => bear.Name.StartsWith('W'));

            // skip 1st item and take next 2 items
            // will throw an exception if List doesn't have 3 items
            var skippedGrumpy = careBears.Skip(1).Take(2);

            // sum total of all bear names
            var numOfChar = careBears.Sum(bear => bear.Name.Length);

            // order bears by BellyBadge. Alphabetical order
            var orderedBears = careBears.OrderBy(bear => bear.BellyBadge);

            // Bedtime Bear, Birthday Bear, Cheer Bear, Friend Bear, Funshine Bear, Good Luck Bear, Grumpy Bear, Love-a-lot Bear, Tenderheart Bear, and Wish Bear

        }
    }
}
