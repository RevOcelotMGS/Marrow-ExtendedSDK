using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public class VRIKRootController : MonoBehaviour
	{
		private Transform pelvisTarget;

		private Transform leftFootTarget;

		private Transform rightFootTarget;

		private VRIK ik;

		public Vector3 pelvisTargetRight { get; private set; }

		private void Awake()
		{
		}

		public void Calibrate()
		{
		}

		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		private void OnPreUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		public VRIKRootController()
			: base()
		{
		}
	}
}
