using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemiplaneTemplate.Rollers
{
    public class ArbitraryDieAdapter : IDieRoller
    {
        private readonly IArbitraryDieRoller roller;

        public ArbitraryDieAdapter(IArbitraryDieRoller roller)
        {
            this.roller = roller;
        }

        public int RollD2()
        {
            return this.roller.RollDx(2);
        }

        public int RollD4()
        {
            return this.roller.RollDx(4);
        }

        public int RollD6()
        {
            return this.roller.RollDx(6);
        }

        public int RollD8()
        {
            return this.roller.RollDx(8);
        }

        public int RollD10()
        {
            return this.roller.RollDx(10);
        }

        public int RollD12()
        {
            return this.roller.RollDx(12);
        }

        public int RollD20()
        {
            return this.roller.RollDx(20);
        }

        public int RollD100()
        {
            return this.roller.RollDx(100);
        }
    }
}
