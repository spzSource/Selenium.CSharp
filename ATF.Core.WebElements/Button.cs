using OpenQA.Selenium;

namespace ATF.Core.WebElements
{
    public class Button<TPageObject> : BaseElement<TPageObject>
	{
		public Button(By by)
		{
			this.ByLocator = by;
		}

		public override bool IsDisplayed()
		{
			return WebElement.Displayed;
		}
	}
}
