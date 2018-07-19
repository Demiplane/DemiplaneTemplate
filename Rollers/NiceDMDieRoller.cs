using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemiplaneTemplate.Rollers
{
    public class NiceDMDieRoller : IArbitraryDieRoller
    {
        private Random random = new Random();

        public string Name => "Nice DM Dice";

        public int RollDx(int x)
        {
            var numOfDice = random.Next(1, 4);

            var roll = x;

            for (int i = 0; i < numOfDice; i++)
            {
                roll = Math.Min(roll, this.random.Next(1, x + 1));
            }

            return roll;
        }
    }
}
