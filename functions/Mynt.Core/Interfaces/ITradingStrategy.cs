﻿using System.Collections.Generic;
using Mynt.Core.Models;

namespace Mynt.Core.Interfaces
{
    public interface ITradingStrategy
    {
        string Name { get;  }
        List<Candle> Candles { get; set; }
        List<int> Prepare();
    }
}
