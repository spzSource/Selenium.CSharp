using System;

namespace ATF.Core.WebElements
{
    public class RadioBox<TPageObject> : BaseElement<TPageObject>
	{
		public RadioBox(By by)
		{
			if (by == null)
			{
				throw new ArgumentNullException("by");
			}
			ByLocator = by;
		}

		public TPageObject Set(string value)
		{
			WebElement.Click();
            return Owner;
		}

		public override bool IsDisplayed()
		{
			return WebElement.Displayed;
		}
	}
}
