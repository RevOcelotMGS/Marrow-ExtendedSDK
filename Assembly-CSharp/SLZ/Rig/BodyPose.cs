using System;
using UnityEngine;

namespace SLZ.Rig
{
	[Serializable]
	public class BodyPose
	{
		public Quaternion headRotationInWorld;

		public Quaternion chestRotationInWorld;

		public Quaternion spineRotationInWorld;

		public Quaternion pelvisRotationInWorld;

		public Vector3 cervicalDeviationInWorld;

		public Vector3 clavLfDirInWorld;

		public Vector3 clavRtDirInWorld;

		public Vector3 armLfNormInWorld;

		public Vector3 armRtNormInWorld;

		public float armLfExtension;

		public float armRtExtension;

		public Quaternion handLfRotationInWorld;

		public Quaternion handRtRotationInWorld;

		public Vector3 legLfDirInWorld;

		public Vector3 legRtDirInWorld;

		public float legLfExtension;

		public float legRtExtension;

		public Quaternion footLfRotationInWorld;

		public Quaternion footRtRotationInWorld;

		public Vector3 palmRtToLfDirInWorld;

		public float handSeparation;

		public float torsoYHandLf;

		public float torsoTHandLf;

		public Vector2 torsoSinHandLf;

		public Quaternion torsoRotInWorldHandLf;

		public Vector3 spineInPalmLfNormed;

		public float torsoYHandRt;

		public float torsoTHandRt;

		public Vector2 torsoSinHandRt;

		public Quaternion torsoRotInWorldHandRt;

		public Vector3 spineInPalmRtNormed;

		public BodyPose()
			: base()
		{
		}
	}
}
