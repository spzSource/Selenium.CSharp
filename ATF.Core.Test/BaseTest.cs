using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Xml.Linq;

using ATF.Core.Driver;

using NUnit.Framework;

namespace ATF.Core.Test
{
	public class BaseTest
	{
	    private readonly IBrowser browser;

	    public BaseTest(IBrowser browser)
	    {
	        if (browser == null)
	        {
	            throw new ArgumentNullException("browser");
	        }
	        this.browser = browser;
	    }

	    [OneTimeSetUp]
		public void BeforeClass()
		{
			browser.Open();
		}

		[SetUp]
		public void BeforeTest()
		{
			browser.Navigate(new Uri(ConfigurationManager.AppSettings["start_url"]));
		}

		[OneTimeTearDown]
		public void AfterClass()
		{
			browser.Exit();
		}

		public IEnumerable<object[]> GetTestData()
		{
			string dataPath = ConfigurationManager.AppSettings["test_data_path"];

			XDocument document = XDocument.Load(dataPath);
			var section = from sct in document.Descendants("test_data")
						  where sct.Attribute("name").Value.Equals(GetType().Name)
						  select sct;

			return section.Descendants("data_item")
						  .Select(e => e.Attributes().Select(el => el.Value).Cast<object>().ToArray());
		}
	}
}
