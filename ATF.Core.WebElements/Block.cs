using OpenQA.Selenium;

namespace ATF.Core.WebElements
{
    public class Block<TPageObject> : BaseElement<TPageObject>
	{
		public Block(By by)
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
