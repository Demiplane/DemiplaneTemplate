using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemiplaneTemplate.Rollers
{
    public class AllOrNothingDieRoller : IArbitraryDieRoller
    {
        private readonly Random random = new Random();

        public String Name
        {
            get
            {
                return "All Or Nothing";
            }
        }

        public int RollDx(int x)
        {
            if (random.Next(0,2) == 1)
            {
                return x;
            }
            else
            {
                return 1;
            }
        }
    }
}
