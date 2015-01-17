namespace ATF.Core.WebElements
{
    public class Input<TPageObject> : BaseElement<TPageObject>
	{
		public Input(By by)
		{
			this.ByLocator = by;
		}

		public TPageObject SetText(string text)
		{
			WebElement.SendKeys(text);
			return Owner;
		}

        public TPageObject ClearText()
		{
			WebElement.Clear();
            return Owner;
		}

        public bool IsEmpty()
        {
            return WebElement.Text.Equals(string.Empty);
        }

		public override bool IsDisplayed()
		{
			return WebElement.Displayed;
		}
	}
}
