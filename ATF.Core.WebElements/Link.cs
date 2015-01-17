namespace ATF.Core.WebElements
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public class Link<TPageObject> : BaseElement<TPageObject>
	{
		public Link(By by)
		{
			this.ByLocator = by;
		}

        public TPageObject MoveToElement(Actions action)
		{
			action.MoveToElement(WebElement);
            return Owner;
		}

		public override bool IsDisplayed()
		{
			return WebElement.Displayed;
		}
	}

    public class BaseElement<T>
    {
    }
}
