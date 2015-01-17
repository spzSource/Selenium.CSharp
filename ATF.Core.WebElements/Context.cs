using System;

namespace ATF.Core.WebElements
{
    public class PageContext<TPageObject>
        where TPageObject : BasePage
    {
        public TPageObject Context
        {
            get;
            private set;
        }

        public PageContext(TPageObject context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            Context = context;
        }
    }
}

