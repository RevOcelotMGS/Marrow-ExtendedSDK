using System;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	[Serializable]
	public abstract class BonePropertyBase
	{
		[SerializeField]
		public BonePropertyInfo GetterInfo;

		[SerializeField]
		public BonePropertyInfo SetterInfo;

		[SerializeField]
		private string _backingFieldName;

		[SerializeField]
		private UnityEngine.Object _targetObject;

		public string BackingFieldName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UnityEngine.Object TargetObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BonePropertyBase()
			: base()
		{
		}
	}
}
