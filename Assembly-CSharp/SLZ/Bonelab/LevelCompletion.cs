using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class LevelCompletion : MonoBehaviour
	{
		protected virtual string LevelKey { get; }

		public virtual void SaveWrite()
		{
		}

		public LevelCompletion()
			: base()
		{
		}
	}
}
