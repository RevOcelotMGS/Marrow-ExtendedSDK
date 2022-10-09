using System;
using UnityEngine;

namespace PuppetMasta
{
	[Serializable]
	public abstract class SubBehaviourBase
	{
		protected BehaviourBase behaviour;

		protected static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		protected static Vector3 XYZ(Vector2 v)
		{
			return default(Vector3);
		}

		protected static Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		protected static Vector3 SetY(Vector3 v, float y)
		{
			return default(Vector3);
		}

		public SubBehaviourBase()
			: base()
		{
		}
	}
}
