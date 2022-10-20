using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.MIA
{
	[Serializable]
	public sealed class MIAFeatureTable : MonoBehaviour
	{
		[SerializeField]
		private List<MIAFeatureDescriptor> _features;

		public MIAFeatureTable()
			: base()
		{
		}
	}
}
