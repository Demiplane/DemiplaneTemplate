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
            return this.random.Next(1, x + 1);
        }
    }
}
