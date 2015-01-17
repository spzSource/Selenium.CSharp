namespace ATF.Core.WebElements.Binder
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Globalization;
    using System.Linq;
    using System.Xml.Linq;

    using OpenQA.Selenium;

    internal static class ByFactory
    {
        private static IEnumerable<XElement> ClassSection;
        private static string ClassName;

        public static By From(How how, string elementName, string className)
        {
            var locator = GetLocatorString(elementName, className);
            switch (how)
            {
                case How.Id:
                    return By.Id(locator);
                case How.Name:
                    return By.Name(locator);
                case How.TagName:
                    return By.TagName(locator);
                case How.ClassName:
                    return By.ClassName(locator);
                case How.CssSelector:
                    return By.CssSelector(locator);
                case How.LinkText:
                    return By.LinkText(locator);
                case How.PartialLinkText:
                    return By.PartialLinkText(locator);
                case How.XPath:
                    return By.XPath(locator);
            }

            throw new ArgumentException(string.Format(CultureInfo.InvariantCulture,
                "Did not know how to construct How from how {0}, locator{1}", how, locator));
        }

        private static string GetLocatorString(string elementName, string className)
        {
            var fileLocation = ConfigurationManager.AppSettings["locators_path"];
            var document = XDocument.Load(fileLocation);

            // cached class section if field in same class
            if (!className.Equals(ClassName))
            {
                ClassSection = from sct in document.Descendants("class")
                    where sct.Attribute("name").Value.Equals(className)
                    select sct;

                ClassName = className;
            }

            IEnumerable<XElement> classSection = ClassSection as XElement[] ?? ClassSection.ToArray();
            if (ClassSection == null || !classSection.Any())
            {
                throw new Exception(
                    string.Format("Element with name: {0} in class: {1} not found in file by location: {2}",
                        elementName, className, fileLocation));
            }
            var locator = classSection.Descendants("field")
                .ToList()
                .Find(e => e.Attribute("field_name").Value.Equals(elementName))
                .Attribute("locator").Value;

            if (string.IsNullOrEmpty(locator))
            {
                throw new Exception(
                    string.Format("Element with name: {0} in class: {1} not found in file by location: {2}",
                        elementName, className, fileLocation));
            }
            return locator;
        }
    }
}