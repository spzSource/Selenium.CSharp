using System;

using OpenQA.Selenium;

namespace ATF.Core.Driver
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBrowser
    {
        /// <summary>
        /// 
        /// </summary>
        IWebDriver Driver
        {
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        void Open();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        void Navigate(Uri url);

        /// <summary>
        /// 
        /// </summary>
        void Exit();
    }
}