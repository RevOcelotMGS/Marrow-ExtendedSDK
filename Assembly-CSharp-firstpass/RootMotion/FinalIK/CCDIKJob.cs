using Unity.Collections;
using UnityEngine;
using UnityEngine.Animations;

namespace RootMotion.FinalIK
{
	public struct CCDIKJob : IAnimationJob
	{
		public TransformSceneHandle _target;

		public PropertySceneHandle _IKPositionWeight;

		public PropertySceneHandle _maxIterations;

		public PropertySceneHandle _tolerance;

		public PropertySceneHandle _XY;

		public PropertySceneHandle _useRotationLimits;

		private NativeArray<TransformStreamHandle> bones;

		private NativeArray<PropertySceneHandle> boneWeights;

		private NativeArray<float> boneSqrMags;

		private float chainSqrMag;

		private Vector3 lastLocalDirection;

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

		public void Setup(Animator animator, Transform[] bones, Transform target)
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

		private void Read(AnimationStream s)
		{
		}

		private void Solve(AnimationStream s, Vector3 targetPosition, bool XY, float weight, int it, bool useRotationLimits)
		{
		}

		private Vector3 GetLocalDirection(AnimationStream s)
		{
			return default(Vector3);
		}

		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		private Vector3 GetSingularityOffset(AnimationStream s, Vector3 IKPosition, bool useRotationLimits)
		{
			return default(Vector3);
		}

		private bool SingularityDetected(AnimationStream s, Vector3 IKPosition)
		{
			return default(bool);
		}

		public void Dispose()
		{
		}
	}
}
