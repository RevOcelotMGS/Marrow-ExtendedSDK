using UnityEngine;

namespace SLZ.Props.Weapons
{
	public class ConstraintTracker : MonoBehaviour
	{
		public ConfigurableJoint joint;

		public ConstraintTracker otherTracker;

		public Constrainer source;

		public int index;

		public Constrainer.ConstraintMode mode;

		public Transform attachPoint;

		public LineRenderer lineRenderer;

		public bool isHost;

		public void SetupTracker(ConfigurableJoint j, ConstraintTracker oT, Constrainer s, int i, Constrainer.ConstraintMode m, Transform aP, LineRenderer lR)
		{
		}

		private void OnDisable()
		{
		}

		private void OnJointBreak(float breakForce)
		{
		}

		public void DeleteConstraint()
		{
		}

		private void Update()
		{
		}

		public void UpdateLines()
		{
		}

		public ConstraintTracker()
			: base()
		{
		}
	}
}
