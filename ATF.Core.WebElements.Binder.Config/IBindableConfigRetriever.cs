using ATF.Core.WebElements.Binder.Config.Implementation.Elements;

namespace ATF.Core.WebElements.Binder.Config
{
    /// <summary>
    /// Provides a retrieving of configuration.
    /// </summary>
    public interface IBindableConfigRetriever
    {
        /// <summary>
        /// Retrieves the <see cref="IBindableConfig"/> from specific source.
        /// </summary>
        /// <returns>The object of <see cref="IBindableConfig"/> implementation.</returns>
        IBindableConfig Retrieve();
    }
}