using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemiplaneTemplate.Rollers
{
    public class DrunkAsFuckRoller : IArbitraryDieRoller
    {
        private Random random = new Random();

        public String Name
        {
            get
            {
                return "Drunk as Fuck Dice";
            }
        }

        public int RollDx(int x)
        {
            var upperBound = (int) (x / .75);
            var lowerBound = (int) (x / .25);

            var roll = 0;

            do
            {
                roll = this.random.Next(1, x + 1);
            } while (roll < upperBound && roll > lowerBound);
            
            return roll;
        }
    }
}
