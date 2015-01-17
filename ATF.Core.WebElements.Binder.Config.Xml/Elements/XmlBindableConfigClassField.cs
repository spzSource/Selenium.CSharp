using System.Xml.Serialization;

namespace ATF.Core.WebElements.Binder.Config.Xml.Elements
{
    using Implementation.Elements;

    public class XmlBindableConfigClassField : IBindableConfigClassField
    {
        [XmlAttribute("field_name")]
        public string FieldName
        {
            get;
            set;
        }

        [XmlAttribute("locator")]
        public string Locator
        {
            get;
            set;
        }
    }
}