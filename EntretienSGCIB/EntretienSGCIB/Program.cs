using System;

namespace EntretienSGCIB
{
    /*
     * Fonctions de prix : Simulation de prix - variation aléatoire à 10 Jours. 
     * Target : static void GenerateScenario(double t0, int horizon, decimal factor);
     * Depuis le prix t0, générer la liste des prix à t jusqu'à l'horizon
     * Factor : variation +/- 5% 
     */
    class Program
    {
        static void Main(string[] args)
        {            
            double priceT0 = 10;
            int horizon = 20;
            decimal factor = 2;

            var pricesScenario = new PricesScenario.PricesRandomScenario();

            //Generer un scénario
            var prices = pricesScenario.GenerateScenario(priceT0, horizon, factor);

            //Afficher les prix du scénario
            pricesScenario.DisplayPrices(prices);

            Console.ReadLine();
        }

    }
}

