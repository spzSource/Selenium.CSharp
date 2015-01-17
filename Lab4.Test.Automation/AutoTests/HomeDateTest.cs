using ATF.Core.Framework;

using Lab4.Test.Automation.WebPages;

using NUnit.Framework;

namespace Lab4.Test.Automation.AutoTests
{
	public class HomeDateTest : BaseTest
	{
		[Test]
		public void DateFormatTest()
		{
			HomePage homePage = new HomePage();
			Assert.IsTrue(homePage.CheckDateFormat(),
				"Wrong date format.");
		}
	}
}
