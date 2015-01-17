namespace ATF.Core.WebElements.Binder.Locators.Paroviders
{
    using Factories;

    public interface ILocatorProvider<out TLocator, TLocatorType>
    {
        ILocatorFactory<TLocator, TLocatorType> Get(TLocatorType type);
    }
}