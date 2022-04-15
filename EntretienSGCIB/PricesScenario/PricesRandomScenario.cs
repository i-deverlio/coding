using System;
using System.Collections.Generic;

namespace PricesScenario
{
    public class PricesRandomScenario : IPricesScenario, IPricesDisplay
    {
        public IList<double> GenerateScenario(double priceInitial, int horizonEstimation, decimal factor)
        {
            //Si l'estimation et la variation ne sont pas nulles, generer un scénario
            if (horizonEstimation > 0 && factor > 0)
            {
                //Initialiser le prix courant
                var currentPrice = priceInitial;

                //Initialiser un générateur aléatoire
                var randomPricer = new Random();

                //Generer les prix
                var prices = new List<double>();

                for (int iHorizon = 0; iHorizon < horizonEstimation; iHorizon++)
                {
                    //Prix aléatoire
                    var randomPrice = GetVariation(randomPricer, -1, 1);
                    currentPrice += randomPrice * decimal.ToDouble(factor);

                    prices.Add(currentPrice);
                }

                return prices;
            }
            return default;
        }

        public void DisplayPrices(IEnumerable<double> listeDesPrix)
        {
            if (listeDesPrix != null)
            {
                foreach (var prix in listeDesPrix)
                {
                    Console.WriteLine($"Le prix est {prix}");
                }
            }
            else
            {
                Console.WriteLine("La liste des prix ne contient aucun prix");
            }
        }



        private double GetVariation(Random random, decimal min, decimal max)
        {
            return random.NextDouble() 
                //Range shift
                * (decimal.ToDouble(max) - decimal.ToDouble(min)) 
                + decimal.ToDouble(min);
        }

    }
}
