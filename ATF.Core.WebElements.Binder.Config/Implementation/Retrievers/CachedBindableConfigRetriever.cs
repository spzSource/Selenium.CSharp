using System;

using ATF.Core.WebElements.Binder.Config.Implementation.Elements;

namespace ATF.Core.WebElements.Binder.Config.Implementation.Retrievers
{
    public abstract class CachedBindableConfigRetriever : IBindableConfigRetriever
    {
        private IBindableConfig cachedItem;
        private readonly IBindableConfigRetriever internalRetriever;

        protected CachedBindableConfigRetriever(
            IBindableConfigRetriever internalRetriever)
        {
            if (internalRetriever == null)
            {
                throw new ArgumentNullException("internalRetriever");
            }
            this.internalRetriever = internalRetriever;
        }

        public virtual IBindableConfig Retrieve()
        {
            return cachedItem ?? (cachedItem = internalRetriever.Retrieve());
        }
    }
}