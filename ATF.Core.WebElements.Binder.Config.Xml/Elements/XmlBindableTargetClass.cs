using System.Xml.Serialization;

namespace ATF.Core.WebElements.Binder.Config.Xml.Elements
{
    using Implementation.Elements;

    public class XmlBindableTargetClass : IBindableTargetClass
    {
        [XmlAttribute(AttributeName = "name")]
        public string ClassName
        {
            get;
            set;
        }

        [XmlElement("Field")]
        public IBindableConfigClassField[] Fields
        {
            get;
            set;
        }
    }
}