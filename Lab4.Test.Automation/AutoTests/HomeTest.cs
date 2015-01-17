using ATF.Core.Framework;

using NUnit.Framework;
using Lab4.Test.Automation.WebPages;

namespace Lab4.Test.Automation.AutoTests
{
    public class HomeTest : BaseTest
    {
        [Test]
        public void MenuAndFooterPresentedTest()
        {
            HomePage homePage = new HomePage();
			Assert.IsTrue(homePage.MenuAndFooterPresented(), 
				"Menu and benners blocks are not displayed.");
        }

		[Test]
	    public void FooterPresentedTest()
	    {
			HomePage homePage = new HomePage();
			Assert.IsTrue(homePage.FooterPresented(), 
				"Footer block is not displayed.");
	    }

		[Test]
		public void InputsPresentedTest()
		{
			HomePage homePage = new HomePage();
			Assert.IsTrue(homePage.InputsPresented(), 
				"Inputs are not empty.");
		}

		[Test]
		[TestCaseSource("GetTestData")]
		public void WeightAndHightDisproportionTest(
			string name, string height, string weight, string gender)
		{
			HomePage homePage = new HomePage();
			Assert.IsTrue(homePage.CheckWeightAndHightDisproportion(name, height, weight, gender), 
				"Missing warning message");
		}
    }
}

