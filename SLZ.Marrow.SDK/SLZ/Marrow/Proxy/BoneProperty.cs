using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	[Serializable]
	public class BoneProperty<PropertyType> : BonePropertyBase
	{
		[SerializeField]
		private Func<PropertyType> _getter;

		[SerializeField]
		public Action<PropertyType> _setter;

		public Func<PropertyType> Getter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Action<PropertyType> Setter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BoneProperty(Func<PropertyType> get = default(Func<PropertyType>), Action<PropertyType> set = default(Action<PropertyType>))
			: base()
		{
		}

		public BoneProperty(string backingFieldName = default(string), UnityEngine.Object targetObject = default(UnityEngine.Object), Func<PropertyType> get = default(Func<PropertyType>), Action<PropertyType> set = default(Action<PropertyType>))
			: base()
		{
		}
	}
}
