namespace ATF.Core.WebElements.Binder.Config.Implementation.Elements
{
    public interface IBindableTargetClass
    {
        string ClassName
        {
            get;
            set;
        }

        IBindableConfigClassField[] Fields
        {
            get;
            set;
        }
    }
}