namespace ATF.Core.WebElements
{
    public class Label<TPageObject> : BaseElement<TPageObject>
	{
		public Label(By by)
		{
			this.ByLocator = by;
		}

		public string Text
		{
			get 
			{
				return WebElement.Text; 
			}
		}

		public bool IsSelected()
		{
			return WebElement.Selected;
		}

		public override bool IsDisplayed()
		{
			return WebElement.Displayed;
		}
	}
}
