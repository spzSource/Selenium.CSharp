using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ATF.Core.Driver.Forefox
{
    public class FirefoxBrowser : IBrowser
    {
        public IWebDriver Driver
        {
            get;
            private set;
        }

        public FirefoxBrowser(
            BinaryConfiguration binaryConfiguration)
        {
            if (binaryConfiguration == null)
            {
                throw new ArgumentNullException("binaryConfiguration");
            }
            
            Initialize(binaryConfiguration);
        }

        private void Initialize(BinaryConfiguration binaryConfig)
        {
            FirefoxBinary binary = new FirefoxBinary(binaryConfig.BinaryPath);
            FirefoxProfile profile = new FirefoxProfile { EnableNativeEvents = true };
            Driver = new FirefoxDriver(binary, profile);
        }

        public void Open()
        {
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
        }

        public void Navigate(Uri url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void Exit()
        {
            if (Driver != null)
            {
                Driver.Close();
                Driver.Quit();
            }
        }
    }
}
