using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemiplaneTemplate.Rollers
{
    public interface IDieRoller
    {
        String Name { get; }

        int RollD2();
        int RollD4();
        int RollD6();
        int RollD8();
        int RollD10();
        int RollD12();
        int RollD20();
        int RollD100();
    }
}
