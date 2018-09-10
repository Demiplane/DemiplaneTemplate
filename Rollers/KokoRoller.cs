using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemiplaneTemplate.Rollers
{
    public class KokoRoller : IArbitraryDieRoller
    {
        private Random random = new Random();

        public string Name => "Koko Dice";

        public int RollDx(int x)
        {
            var originalNumber = this.random.Next(1, x + 1);

            if (originalNumber > (x/.75) )
            {
                return Math.Min(originalNumber + 1, x + 1);
            }
            else if (originalNumber < (x/.25))
            {
                return Math.Max(originalNumber - 1, 1);
            }
            else
            {
                return originalNumber;
            }
        }
    }
}
