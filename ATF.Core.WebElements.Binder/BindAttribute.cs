using System;

namespace ATF.Core.WebElements.Binder
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public sealed class BindAttribute : Attribute
	{
		public How How { get; set; }
		public string Name { get; set; }
	}
}
