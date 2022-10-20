using SLZ.Interaction;
using UnityEngine;

namespace SLZ.VRMK
{
	public class NpcAvatar : MonoBehaviour
	{
		[SerializeField]
		private Avatar _avatar;

		public Rigidbody rbRoot;

		public Rigidbody rbHip_L;

		public Rigidbody rbKnee_L;

		public Rigidbody rbAnkle_L;

		public Rigidbody rbHip_R;

		public Rigidbody rbKnee_R;

		public Rigidbody rbAnkle_R;

		public Rigidbody rbSpine;

		public Rigidbody rbChest;

		public Rigidbody rbNeck;

		public Rigidbody rbHead;

		public Rigidbody rbJaw;

		public Rigidbody rbShoulder_L;

		public Rigidbody rbElbow_L;

		public Rigidbody rbWrist_L;

		public Rigidbody rbShoulder_R;

		public Rigidbody rbElbow_R;

		public Rigidbody rbWrist_R;

		public ConfigurableJoint jRoot;

		public ConfigurableJoint jHip_L;

		public ConfigurableJoint jKnee_L;

		public ConfigurableJoint jAnkle_L;

		public ConfigurableJoint jHip_R;

		public ConfigurableJoint jKnee_R;

		public ConfigurableJoint jAnkle_R;

		public ConfigurableJoint jSpine;

		public ConfigurableJoint jChest;

		public ConfigurableJoint jNeck;

		public ConfigurableJoint jHead;

		public ConfigurableJoint jJaw;

		public ConfigurableJoint jShoulder_L;

		public ConfigurableJoint jElbow_L;

		public ConfigurableJoint jWrist_L;

		public ConfigurableJoint jShoulder_R;

		public ConfigurableJoint jElbow_R;

		public ConfigurableJoint jWrist_R;

		public ConfigurableJoint jSupportHead;

		public ConfigurableJoint jSupportArmLf;

		public ConfigurableJoint jSupportArmRt;

		public MeshCollider cRoot;

		public MeshCollider cSpine;

		public MeshCollider cChest;

		public MeshCollider cHead;

		public MeshCollider cBreastLf;

		public MeshCollider cBreastRt;

		public MeshCollider cButt_Lf;

		public MeshCollider cButt_Rt;

		public CapsuleCollider cHip_L;

		public CapsuleCollider cKnee_L;

		public CapsuleCollider cAnkle_L;

		public CapsuleCollider cHip_R;

		public CapsuleCollider cKnee_R;

		public CapsuleCollider cAnkle_R;

		public CapsuleCollider cNeck;

		public CapsuleCollider cShoulder_L;

		public CapsuleCollider cElbow_L;

		public CapsuleCollider cWrist_L;

		public CapsuleCollider cShoulder_R;

		public CapsuleCollider cElbow_R;

		public CapsuleCollider cWrist_R;

		public BoxCollider cJaw;

		public CylinderGrip gKnee_L;

		public CylinderGrip gKnee_R;

		public CylinderGrip gShoulder_L;

		public CylinderGrip gShoulder_R;

		public CylinderGrip gElbow_L;

		public CylinderGrip gElbow_R;

		private Quaternion[] _initRots;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetAvatar()
		{
		}

		private void ApplyRotationOffsetsToRig(Avatar avatar)
		{
		}

		private void MountPuppetMuscle(Transform artTran, Rigidbody rb, Quaternion rotOffset)
		{
		}

		private void CaptureStartRots()
		{
		}

		private void RestoreStartRots()
		{
		}

		private void SetJoints()
		{
		}

		private void SetJoint(ConfigurableJoint j, Vector3 cA)
		{
		}

		private void SetColliders()
		{
		}

		private void SetGrips()
		{
		}

		private void SetMass()
		{
		}

		private void SetStrength()
		{
		}

		private void CloneHierarchyAndRebind()
		{
		}

		private void LateUpdate()
		{
		}

		public NpcAvatar()
			: base()
		{
		}
	}
}
