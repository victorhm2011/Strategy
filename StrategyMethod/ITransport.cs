using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyMethod
{
    public interface ITransport
    {
        void Travel(string origin, string destination);
    }
}
