using UnityEngine;

namespace SplineMesh
{
	[RequireComponent(typeof(Spline))]
	[ExecuteInEditMode]
	public class ExampleFollowSpline : MonoBehaviour
	{
		private GameObject generated;

		private Spline spline;

		private float rate;

		public GameObject Follower;

		public float DurationInSecond;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void EditorUpdate()
		{
		}

		private void PlaceFollower()
		{
		}

		public ExampleFollowSpline()
			: base()
		{
		}
	}
}
