using ATF.Core.Framework;

using Lab4.Test.Automation.WebPages;

using NUnit.Framework;

namespace Lab4.Test.Automation.AutoTests
{
	public class HomeTestSecond : BaseTest
	{
		[Test]
		public void InputsPresentedTest()
		{
			HomePage homePage = new HomePage();
			Assert.IsTrue(homePage.AllElementsArePresented(),
				"Elements are not presented.");
		}

		[Test]
		[TestCaseSource("GetTestData")]
		public void WeightAndHightValidationTest(
			string name, string height, string weight, string gender)
		{
			HomePage homePage = new HomePage();
			Assert.IsTrue(homePage.CheckWeightAndHightValidation(name, height, weight, gender),
				"Wrong parameters (weight and weight).");
		}
	}
}
