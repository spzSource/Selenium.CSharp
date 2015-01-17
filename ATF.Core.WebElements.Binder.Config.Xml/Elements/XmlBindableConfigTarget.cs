using System.Xml.Serialization;

namespace ATF.Core.WebElements.Binder.Config.Xml.Elements
{
    using Implementation.Elements;

    public class XmlBindableConfigTarget : IBindableConfigTarget
    {
        [XmlElement("TargetClass")]
        public IBindableTargetClass[] TargetClasses
        {
            get;
            set;
        }
    }
}