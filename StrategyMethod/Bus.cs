﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyMethod
{
    public class Bus : ITransport
    {
        public void Travel(string origin, string destination)
        {
            Console.WriteLine("You travel from " + origin + " to " + destination + " by Bus.");
        }
    }
}
