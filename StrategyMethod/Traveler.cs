using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyMethod
{
    public class Traveler
    {
        private string _name;
        private int _age;
        private ITransport _transportStrategy;

        public Traveler(string n, int a)
        {
            _name = n;
            _age = a;
        }

        public void SetTransportStrategy(ITransport t)
        {
            _transportStrategy = t;
        }

        public void Travel(string origin, string destination)
        {
            _transportStrategy.Travel(origin, destination);

        }

    }
}
