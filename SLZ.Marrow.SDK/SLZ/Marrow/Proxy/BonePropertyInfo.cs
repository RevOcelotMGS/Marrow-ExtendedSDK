using System;
using System.Reflection;
using System.Runtime.InteropServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	[Serializable]
	public struct BonePropertyInfo
	{
		[SerializeField]
		public bool exists;

		[SerializeField]
		public string info;

		[SerializeField]
		public SerializableType propertyType;

		[SerializeField]
		public SerializableType containingType;

		public BonePropertyInfo(bool exists = false, MethodInfo methodInfo = default(MethodInfo), SerializableType propertyType = default(SerializableType), SerializableType containingType = default(SerializableType))
		{
			this.containingType = default(SerializableType);
			this.propertyType = default(SerializableType);
			this.info = default(string);
			this.exists = default(bool);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
