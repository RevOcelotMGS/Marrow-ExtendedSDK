using UnityEngine;

namespace SLZ.Interaction
{
	public class Slide : MonoBehaviour
	{
		[Header("Options")]
		[Tooltip("Axis is realtive to parent")]
		public Vector3 slideAxis;

		public float limit;

		[Header("References")]
		public Grip slideGrip;

		public Slide()
			: base()
		{
		}
	}
}
