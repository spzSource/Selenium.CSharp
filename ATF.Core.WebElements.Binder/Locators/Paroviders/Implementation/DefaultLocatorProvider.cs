namespace ATF.Core.WebElements.Binder.Locators.Paroviders.Implementation
{
    using System.Linq;

    using Factories;
    using Factories.Implementation;

    using OpenQA.Selenium;

    public class DefaultLocatorProvider : ILocatorProvider<By, How>
    {
        private readonly ILocatorFactory<By, How>[] factories =
        {
            new XPathLocatorFactory()
        };

        public ILocatorFactory<By, How> Get(How type)
        {
            return factories.FirstOrDefault(e => e.LocatorType == type);
        }
    }
}