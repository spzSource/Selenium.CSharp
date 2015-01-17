using System;
using System.Text.RegularExpressions;

using ATF.Core.Framework;
using ATF.Core.Framework.WebElements;
using ATF.Core.Framework.WebElements.Utils;

namespace Lab4.Test.Automation.WebPages
{
    public class HomePage : BasePage
    {
        [Bind(How = How.XPath, Name = "MenuBlock")]
        private Block<HomePage> MenuBlock { get; set; }

        [Bind(How = How.XPath, Name = "BannersBlock")]
        private Block<HomePage> BannersBlock { get; set; }

        [Bind(How = How.XPath, Name = "FooterBlock")]
        private Block<HomePage> FooterBlock { get; set; }

        [Bind(How = How.XPath, Name = "NameInput")]
        private Input<HomePage> NameInput { get; set; }

        [Bind(How = How.XPath, Name = "HeightInput")]
        private Input<HomePage> HeightInput { get; set; }

        [Bind(How = How.XPath, Name = "WeightInput")]
        private Input<HomePage> WeightInput { get; set; }

        [Bind(How = How.XPath, Name = "GenderCheckBox")]
        private RadioBox<HomePage> GenderCheckBox { get; set; }

		[Bind(How = How.XPath, Name = "CalculateButton")]
        private Input<HomePage> CalculateButton { get; set; }

		[Bind(How = How.XPath, Name = "HeightWeightDisproportion")]
        private Block<HomePage> HeightWeightDisproposal { get; set; }

		[Bind(How = How.XPath, Name = "HeightWeightValidation")]
        private Block<HomePage> HeightWeightValidation { get; set; }

		[Bind(How = How.XPath, Name = "DateLabel")]
        private Label<HomePage> DateLabel { get; set; }
		

        public HomePage()
        {
            PageFactory.InitElements(this);
        }

        public bool MenuAndFooterPresented()
        {
            return MenuBlock.IsPresent() 
                && BannersBlock.IsPresent();
        }

	    public bool AllElementsArePresented()
	    {
			return NameInput.IsPresent()
				&& HeightInput.IsPresent()
				&& WeightInput.IsPresent()
				&& GenderCheckBox.IsPresent()
				&& CalculateButton.IsPresent();
	    }

        public bool FooterPresented()
        {
            return FooterBlock.IsPresent();
        }

        public bool InputsPresented()
        {
            return NameInput.IsEmpty()
                && HeightInput.IsEmpty()
                && WeightInput.IsEmpty()
                && GenderCheckBox.IsDisplayed();
        }

        private HomePage ProcessWeightAndHightDisproportion(
            string name, string height, string weight, string gender)
        {
            return NameInput.SetText(name)
                .HeightInput.SetText(height)
                .WeightInput.SetText(weight)
                .GenderCheckBox.Set(gender)
                .CalculateButton.Click();
        }

        public bool CheckWeightAndHightDisproportion(
            string name, string height, string weight, string gender)
        {
            return ProcessWeightAndHightDisproportion(name, height, weight, gender)
                .HeightWeightDisproposal.IsPresent();
        }

		public bool CheckWeightAndHightValidation(
			string name, string height, string weight, string gender)
		{
            return ProcessWeightAndHightDisproportion(name, height, weight, gender)
                .HeightWeightValidation.IsPresent();
		}

	    public bool CheckDateFormat()
	    {
		    string date = DateLabel.Text;
            const string pattern = @"\d+\.\d+\.\d+";

		    string matchedDate = Regex.Match(date, pattern).Captures[0].Value;

		    DateTime dateTime;
			return DateTime.TryParse(matchedDate, out dateTime);
	    }
    }
}

