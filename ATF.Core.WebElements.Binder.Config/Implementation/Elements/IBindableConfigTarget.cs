namespace ATF.Core.WebElements.Binder.Config.Implementation.Elements
{
    public interface IBindableConfigTarget
    {
        IBindableTargetClass[] TargetClasses
        {
            get;
            set;
        }
    }
}