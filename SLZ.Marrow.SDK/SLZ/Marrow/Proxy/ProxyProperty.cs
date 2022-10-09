using System;
using System.Runtime.InteropServices;

namespace SLZ.Marrow.Proxy
{
	[Serializable]
	public class ProxyProperty<PropertyType> : ProxyPropertyBase
	{
		private bool overriden;

		private bool overridenReverse;

		public new BoneProperty<PropertyType> ProxyProp
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public new BoneProperty<PropertyType> MappedProp
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ProxyProperty()
			: base()
		{
		}

		public ProxyProperty(Func<PropertyType> get = default(Func<PropertyType>), Action<PropertyType> set = default(Action<PropertyType>))
			: this()
		{
		}

		public override void ProxyOverride()
		{
		}

		public override void ProxyOverrideReverse()
		{
		}
	}
}
