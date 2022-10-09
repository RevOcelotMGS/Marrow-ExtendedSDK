using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class Turret : MonoBehaviour
	{
		[Serializable]
		public class Part
		{
			public Transform transform;

			private RotationLimit rotationLimit;

			public void AimAt(Transform target)
			{
			}

			public Part()
				: base()
			{
			}
		}

		public Transform target;

		public Part[] parts;

		private void Update()
		{
		}

		public Turret()
			: base()
		{
		}
	}
}
