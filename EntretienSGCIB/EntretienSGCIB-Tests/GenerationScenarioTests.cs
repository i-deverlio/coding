using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntretienSGCIB_Tests
{
    [TestClass]
    public class GenerateScenarioTests
    {
        [TestMethod("Generer un scénario sans aucun horizon, ni de variation")]
        public void GenerateScenario_ReturnNothing_WhenNoEstimation_AndNoFactor()
        {
            //Initialize
            var pricesScenario = new PricesScenario.PricesRandomScenario();

            //Failded/Sucess Test
            var prices = pricesScenario.GenerateScenario(10, default, default);

            //Result
            Assert.IsNull(prices);
            pricesScenario.DisplayPrices(prices);
        }

        [TestMethod("Generer un scénario sans aucun horizon mais une variation X %")]
        public void GenerateScenario_ReturnNothing_WhenNoEstimation_AndFactorSet()
        {
            //Initialize
            var pricesScenario = new PricesScenario.PricesRandomScenario();

            //Failded/Sucess Test
            var prices = pricesScenario.GenerateScenario(10, default, (decimal)4.6);

            //Result
            Assert.IsNull(prices);
            pricesScenario.DisplayPrices(prices);
        }

        [TestMethod("Generer un scénario de prix quand l'estimation est d'un jour à une variation 2 %")]
        public void GenerateScenario_ReturnPrices_WhenEstimationSetOneDay_AndFactorSet2PerCent()
        {
            //Initialize
            var pricesScenario = new PricesScenario.PricesRandomScenario();

            //Failded/Sucess Test
            var prices = pricesScenario.GenerateScenario(10, 1, 2);

            //Result
            Assert.IsNotNull(prices);
            pricesScenario.DisplayPrices(prices);
        }

        [TestMethod("Generer un scénario de prix quand l'estimation est d'un jour à une variation 5 %")]
        public void GenerateScenario_ReturnPrices_WhenEstimationSetOneDay_AndFactorSet5PerCent()
        {
            //Initialize
            var pricesScenario = new PricesScenario.PricesRandomScenario();

            //Failded/Sucess Test
            var prices = pricesScenario.GenerateScenario(10, 1, 5);

            //Result
            Assert.IsNotNull(prices);
            pricesScenario.DisplayPrices(prices);
        }

        [TestMethod("Generer un scénario de prix quand l'estimation est de 20 jours à une variation 2 %")]
        public void GenerateScenario_ReturnPrices_WhenEstimationSet20Days_AndFactorSet2PerCent()
        {
            //Failed Case
            var pricesScenario = new PricesScenario.PricesRandomScenario();

            //Failded Test
            var prices = pricesScenario.GenerateScenario(10, 20, 2);

            //Result
            Assert.IsNotNull(prices);
            pricesScenario.DisplayPrices(prices);
        }

        [TestMethod("Generer un scénario de prix quand l'estimation est de 20 jours à une variation 5 %")]
        public void GenerateScenario_ReturnPrices_WhenEstimationSet20Days_AndFactorSet5PerCent()
        {
            //Failed Case
            var pricesScenario = new PricesScenario.PricesRandomScenario();

            //Failded Test
            var prices = pricesScenario.GenerateScenario(10, 20, 5);

            //Result
            Assert.IsNotNull(prices);
            pricesScenario.DisplayPrices(prices);
        }

        [TestMethod("Generer un scénario de prix quand l'estimation est de 20 jours à une variation décimale (ex 3,4 %)")]
        public void GenerateScenario_ReturnPrices_WhenEstimationSet20Days_AndFactorSetDecimalPerCent()
        {
            //Failed Case
            var pricesScenario = new PricesScenario.PricesRandomScenario();

            //Failded Test
            var prices = pricesScenario.GenerateScenario(10, 20, (decimal)3.4);

            //Result
            Assert.IsNotNull(prices);
            pricesScenario.DisplayPrices(prices);

        }

    }
}
