using System;
using TechTalk.SpecFlow;
using PlanetWeights;

namespace SpecFlowAcceptanceTests.StepDefinitions
{
    [Binding]
    public class PlanetWeightStepDefinitions
    {
        private PlanetWeight? planet;
        private double actualResult = 0;

        [Given(@"the planet is mercury")]
        public void GivenThePlanetIsMercury()
        {
            planet = new PlanetWeight();
            planet.planet = Planets.mercury;
        }

        [Given(@"the weight is (.*)")]
        public void GivenTheWeightIs(int weightIn)
        {
            planet.weight = weightIn;
        }

        [When(@"the planet weight is calculated")]
        public void WhenThePlanetWeightIsCalculated()
        {
            actualResult = planet.weightOnPlanet;
        }

        [When(@"the planet surface gravity is calculated")]
        public void WhenThePlanetSurfaceGravityIsCalculated()
        {
            actualResult = planet.planetSurfaceGravity;
        }

        [Then(@"the result is (.*)")]
        public void ThenTheResultIs(double expectedResult)
        {
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
