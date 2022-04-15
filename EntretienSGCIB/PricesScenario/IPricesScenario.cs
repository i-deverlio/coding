using System.Collections.Generic;

namespace PricesScenario
{
    /// <summary>
    /// Propose des scénarios d'estimation de prix
    /// </summary>
    public interface IPricesScenario
    {
        /// <summary>
        /// Retourne un scénario de prix en fonction du prix initial, l'horizon d'estimation en jours
        /// </summary>
        /// <param name="priceInitial">Prix de départ du scénario</param>
        /// <param name="horizonEstimation">Nombre de jour de l'estimation</param>
        /// <param name="factor">Variation de prix</param>
        /// <returns></returns>
        IList<double> GenerateScenario(double priceInitial, int horizonEstimation, decimal factor);
    }
}
