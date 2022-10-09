using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public class GenericPoser : Poser
	{
		[Serializable]
		public class Map
		{
			public Transform bone;

			public Transform target;

			private Vector3 defaultLocalPosition;

			private Quaternion defaultLocalRotation;

			public Map(Transform bone, Transform target)
				: base()
			{
			}

			public void StoreDefaultState()
			{
			}

			public void FixTransform()
			{
			}

			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		public Map[] maps;

		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		protected override void InitiatePoser()
		{
		}

		protected override void UpdatePoser()
		{
		}

		protected override void FixPoserTransforms()
		{
		}

		private void StoreDefaultState()
		{
		}

		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		public GenericPoser()
			: base()
		{
		}
	}
}
