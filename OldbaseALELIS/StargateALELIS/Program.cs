using System;
using StargateALELIS.FighterServiceReference;

namespace StargateALELIS
{
    class Program
    {
        static void Main()
        {
            var clientOldbase = new FighterServiceClient();
            var fighter = new Fighter
            {
                Name = "Aleksander",
                Power = 17,
                Shield = 19
            };
            clientOldbase.CreateFighter(fighter);
            var returndFighter = clientOldbase.GetFighter("Aleksander");
            Console.WriteLine($"{returndFighter.Name},{returndFighter.Power},{returndFighter.Shield}");
            Console.ReadKey();
        }
    }
}
