using System;
using UnityEngine;

namespace SLZ.MIA
{
	[Serializable]
	public sealed class MIAFeatureDescriptor
	{
		[SerializeField]
		private string _name;

		[SerializeField]
		private FeatureType _type;

		[SerializeField]
		private FeatureVisibility _visibility;

		[SerializeField]
		private int _intValue;

		[SerializeField]
		private float _floatValue;

		[SerializeField]
		private bool _boolValue;

		[SerializeField]
		private UnityEngine.Object _objectValue;

		public MIAFeatureDescriptor()
			: base()
		{
		}
	}
}
