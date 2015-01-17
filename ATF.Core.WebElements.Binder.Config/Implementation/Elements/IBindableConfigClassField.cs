namespace ATF.Core.WebElements.Binder.Config.Implementation.Elements
{
    public interface IBindableConfigClassField
    {
        string FieldName
        {
            get;
            set;
        }

        string Locator
        {
            get;
            set;
        }
    }
}