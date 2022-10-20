using Assets.Marrow_ExtendedSDK.StubClasses;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Data
{
	public class HandPoseViewer : MonoBehaviour
	{
		public enum ViewerMode
		{
			View = 0,
			Edit = 1
		}

		public HandPose handPoseToLoadFrom;

		public ViewerMode mode;

		[Range(0f, 5f)]
		[Header("Edit")]
		public int radiusGroupId;

		[Range(0f, 18f)]
		public int poseId;

		[Range(0f, 2f)]
		[Header("View")]
		public float radius;

		[Range(-90f, 90f)]
		public float pitch;

		[Range(-90f, 90f)]
		public float roll;

		[Range(-90f, 90f)]
		public float yaw;

		public HandPose handPoseToSaveTo;

		public Grip grip;

		public HandPoseAnimator animator;

		public RigBuilder rigBuilder;

		public TwoBoneIKConstraint thumbIk;

		public TwoBoneIKConstraint indexIk;

		public TwoBoneIKConstraint middleIk;

		public TwoBoneIKConstraint ringIk;

		public TwoBoneIKConstraint pinkyIk;

		public OverrideTransform handleIk;

		private int _lastRadiusId;

		private int _lastPoseId;

		private float _lastPitch;

		private float _lastRoll;

		private float _lastYaw;

		private float _lastRadius;

		private ViewerMode _lastMode;

		private Quaternion leftHandSpace;

		private Quaternion rightHandSpace;

		[ContextMenu("LoadHandPose")]
		public void LoadHandPose()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateArt()
		{
		}

		private void ApplyPose()
		{
		}

		[ContextMenu("SaveHandPose")]
		public void SaveHandPose()
		{
		}

		[ContextMenu("ExtrapolateHandleRotations")]
		public void ExtrapolateHandleRotations()
		{
		}

		private void SavePose()
		{
		}

		private float CheckEulerAngles(float e)
		{
			return default(float);
		}

		public HandPoseViewer()
			: base()
		{
		}
	}
}
