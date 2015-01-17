namespace ATF.Core.WebElements.Binder.Locators.Factories
{
    public interface ILocatorFactory<out TLocator, out TLocatorType>
    {
        TLocatorType LocatorType
        {
            get;
        }

        TLocator Create(string source);
    }
}