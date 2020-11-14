using System;

namespace StrategyMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //se crea el traveler con su nombre y edad
            Traveler traveler = new Traveler("Luis", 24);
            
            //aqui se establece el metodo de transporte
            traveler.SetTransportStrategy(new Bike());

            //luego se usa el metodo travel para realizar el viaje con cierto tipo de transporte
            traveler.Travel("Cercado", "Quillacollo");


        }
    }
}
