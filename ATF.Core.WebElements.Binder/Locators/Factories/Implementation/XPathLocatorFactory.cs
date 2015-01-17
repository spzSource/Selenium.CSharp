namespace ATF.Core.WebElements.Binder.Locators.Factories.Implementation
{
    using ATF.Core.WebElements.Binder.Locators.Factories;

    using OpenQA.Selenium;

    public class XPathLocatorFactory : ILocatorFactory<By, How>
    {
        public How LocatorType => How.XPath;

        public By Create(string source)
        {
            return By.XPath(source);
        }
    }
}