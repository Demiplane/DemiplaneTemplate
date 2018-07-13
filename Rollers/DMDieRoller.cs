using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemiplaneTemplate.Rollers
{
    public class DMDieRoller : IArbitraryDieRoller
    {
        private Random random = new Random();

        public string Name => "DM Dice";
        
        public int RollDx(int x)
        {
            var numOfDice = random.Next(1, 4);

            var roll = 0;

            for (int i = 0; i < numOfDice; i++)
            {
                roll = Math.Max(roll, this.random.Next(1, x + 1));
            }

            return roll;
        }
    }
}
