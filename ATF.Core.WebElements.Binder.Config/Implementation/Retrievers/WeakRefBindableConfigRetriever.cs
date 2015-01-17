namespace ATF.Core.WebElements.Binder.Config.Implementation.Retrievers
{
    using System;

    using Elements;

    public abstract class WeakRefBindableConfigRetriever : IBindableConfigRetriever
    {
        private readonly IBindableConfigRetriever inretnalRetriever;
        private readonly WeakReference<IBindableConfig> weakConfig = null;

        protected WeakRefBindableConfigRetriever(
            IBindableConfigRetriever inretnalRetriever)
        {
            if (inretnalRetriever == null)
            {
                throw new ArgumentNullException("inretnalRetriever");
            }
            this.inretnalRetriever = inretnalRetriever;
        }

        public virtual IBindableConfig Retrieve()
        {
            IBindableConfig bindableConfig;

            if (!weakConfig.TryGetTarget(out bindableConfig))
            {
                weakConfig.SetTarget(inretnalRetriever.Retrieve());
            }

            return bindableConfig;
        }
    }
}