﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts
{
    public interface IPrivate : ISoldier
    {
        double Salary { get; }
    }
}

