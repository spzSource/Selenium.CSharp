using System.Xml.Serialization;

namespace ATF.Core.WebElements.Binder.Config.Xml.Elements
{
    using Implementation.Elements;

    [XmlRoot(ElementName = "TargetClasses")]
    public class XmlBindableConfig : IBindableConfig
    {
        [XmlElement("TargetClass")]
        public IBindableTargetClass[] TargetClasses
        {
            get;
            set;
        }
    }
}