using Unity.Collections;
using UnityEngine;
using UnityEngine.Animations;

namespace RootMotion.FinalIK
{
	public struct AimIKJob : IAnimationJob
	{
		public TransformSceneHandle _target;

		public TransformSceneHandle _poleTarget;

		public TransformStreamHandle _transform;

		public PropertySceneHandle _IKPositionWeight;

		public PropertySceneHandle _poleWeight;

		public PropertySceneHandle _axisX;

		public PropertySceneHandle _axisY;

		public PropertySceneHandle _axisZ;

		public PropertySceneHandle _poleAxisX;

		public PropertySceneHandle _poleAxisY;

		public PropertySceneHandle _poleAxisZ;

		public PropertySceneHandle _clampWeight;

		public PropertySceneHandle _clampSmoothing;

		public PropertySceneHandle _maxIterations;

		public PropertySceneHandle _tolerance;

		public PropertySceneHandle _XY;

		public PropertySceneHandle _useRotationLimits;

		private NativeArray<TransformStreamHandle> bones;

		private NativeArray<PropertySceneHandle> boneWeights;

		private Vector3 lastLocalDirection;

		private float step;

		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		private NativeArray<Vector3> limitAxisArray;

		private NativeArray<int> hingeFlags;

		private NativeArray<PropertySceneHandle> hingeMinArray;

		private NativeArray<PropertySceneHandle> hingeMaxArray;

		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		private NativeArray<Quaternion> hingeLastRotations;

		private NativeArray<float> hingeLastAngles;

		private NativeArray<int> angleFlags;

		private NativeArray<Vector3> angleSecondaryAxisArray;

		private NativeArray<PropertySceneHandle> angleLimitArray;

		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		public void Setup(Animator animator, Transform[] bones, Transform target, Transform poleTarget, Transform aimTransform)
		{
		}

		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		private void DisposeRotationLimits()
		{
		}

		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		public void ProcessAnimation(AnimationStream stream)
		{
		}

		private void Update(AnimationStream s)
		{
		}

		private void RotateToTarget(AnimationStream s, Vector3 targetPosition, Vector3 polePosition, int i, float weight, float poleWeight, bool XY, bool useRotationLimits, Vector3 axis, Vector3 poleAxis)
		{
		}

		public float GetAngle(AnimationStream s, Vector3 axis, Vector3 IKPosition)
		{
			return default(float);
		}

		private Vector3 GetClampedIKPosition(AnimationStream s, float clampWeight, int clampSmoothing, Vector3 IKPosition, Vector3 transformPosition, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		private Vector3 GetLocalDirection(AnimationStream s, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		public void Dispose()
		{
		}
	}
}
