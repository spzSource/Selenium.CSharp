namespace ATF.Core.WebElements
{
    public class ComboBox<TPageObject> : BaseElement<TPageObject>
	{
		public ComboBox(By by)
		{
			this.ByLocator = by;
		}

        public TPageObject SendKeys(string key)
		{
			WebElement.SendKeys(key);
            return Owner;
		}

		public override bool IsDisplayed()
		{
			return WebElement.Displayed;
		}
	}
}
