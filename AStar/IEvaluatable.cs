﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AStar
{
    public interface IEvaluatable
    {
        double Value { get; }
    }
}
