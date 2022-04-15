using System.Collections.Generic;

namespace PricesScenario
{
    /// <summary>
    /// Permet d'afficher une liste de prix
    /// </summary>
    public interface IPricesDisplay
    {
        //Affiche la liste des prix
        void DisplayPrices(IEnumerable<double> listeDesPrix);
    }
}
