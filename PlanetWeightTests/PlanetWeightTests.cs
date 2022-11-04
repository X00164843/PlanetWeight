using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanetWeights;
using System.ComponentModel.DataAnnotations;

namespace PlanetWeightTests.UnitTest
{
	[TestClass]
	public class PlanetWeightTests
	{
		PlanetWeight? planet;

		[TestInitialize]
		public void TestInit()
		{
			planet = new PlanetWeight();
		}

		[DataRow(0, false)]
		[DataRow(501, false)]
		[DataRow(250, true)]
		[DataTestMethod]
		public void Weight_RangeValidation_ParamTest(double weight, Boolean expectedResult)
		{
			planet.weight = weight;

			var actualResult = Validator.TryValidateObject(planet, new ValidationContext(planet, null, null), null, true);

			Assert.AreEqual(expectedResult, actualResult);
		}

		[DataRow(Planets.mercury, 28.35)]
		[DataRow(Planets.venus, 68.025)]
		[DataRow(Planets.moon, 12.45)]
		[DataRow(Planets.mars, 28.275)]
		[DataRow(Planets.jupiter, 177)]
		[DataRow(Planets.saturn, 68.7)]
		[DataRow(Planets.uranus, 66.675)]
		[DataRow(Planets.neptune, 84)]
		[DataRow(Planets.pluto, 5.325)]
		[DataTestMethod]
		public void WeightOnPlanet_ParamTest(Planets selectedPlanet, double expectedResult)
		{
			planet.weight = 75;
			planet.planet = selectedPlanet;

			double actualResult = Math.Round(planet.weightOnPlanet, 3);

			Assert.AreEqual(expectedResult, actualResult);
		}

		[DataRow(Planets.mercury, 0.378)]
		[DataRow(Planets.venus, 0.907)]
		[DataRow(Planets.moon, 0.166)]
		[DataRow(Planets.mars, 0.377)]
		[DataRow(Planets.jupiter, 2.36)]
		[DataRow(Planets.saturn, 0.916)]
		[DataRow(Planets.uranus, 0.889)]
		[DataRow(Planets.neptune, 1.12)]
		[DataRow(Planets.pluto, 0.071)]
		[DataTestMethod]
		public void DisplayPlanetSurfaceGravity_ParamTest(Planets selectedPlanet, double expectedResult)
		{
			planet.planet = selectedPlanet;

			double actualResult = planet.planetSurfaceGravity;

			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestCleanup]
		public void TestCleanup()
		{
			this.planet = null;
		}
	}
}