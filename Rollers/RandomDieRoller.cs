using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemiplaneTemplate.Rollers
{
    public class RandomDieRoller : IArbitraryDieRoller
    {
        private Random random = new Random();

        public int RollDx(int x)
        {
            return random.Next(1, x + 1);
        }
    }
}
