﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemiplaneTemplate.Rollers
{
    public interface IArbitraryDieRoller
    {
        String Name { get; }

        int RollDx(int x);
    }
}
