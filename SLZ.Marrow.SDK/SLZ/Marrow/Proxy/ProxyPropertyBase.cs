using System;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	[Serializable]
	public abstract class ProxyPropertyBase
	{
		[SerializeField]
		protected BonePropertyBase _proxyProp;

		[SerializeField]
		protected BonePropertyBase _mappedProp;

		public BonePropertyBase ProxyProp
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BonePropertyBase MappedProp
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public abstract void ProxyOverride();

		public abstract void ProxyOverrideReverse();

		public ProxyPropertyBase()
			: base()
		{
		}
	}
}
