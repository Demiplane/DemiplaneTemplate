using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemiplaneTemplate.Rollers
{
    public interface IArbitraryDieRoller
    {
        int RollDx(int x);
    }
}
