using OpenQA.Selenium;

namespace ATF.Core.WebElements
{
    public class CheckBox<TPageObject> : BaseElement<TPageObject>
	{
		public CheckBox(By by)
		{
			this.ByLocator = by;
		}

		public bool IsSelected()
		{
			return WebElement.Selected;
		}

        public TPageObject Set(bool value)
		{
			if (value && !WebElement.Selected)
				WebElement.Click();
            return Owner;
		}

        public TPageObject UnSet()
		{
			if (WebElement.Enabled)
				WebElement.Click();
            return Owner;
		}

		public override bool IsDisplayed()
		{
			return WebElement.Displayed;
		}
	}
}
