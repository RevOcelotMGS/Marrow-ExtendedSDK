using UnityEngine;
using UnityEngine.Serialization;

namespace VLB.Samples
{
	public class Rotater : MonoBehaviour
	{
		[FormerlySerializedAs("m_EulerSpeed")]
		public Vector3 EulerSpeed;

		[SerializeField]
		private bool localSpace;

		private void Update()
		{
		}

		public Rotater()
			: base()
		{
		}
	}
}
