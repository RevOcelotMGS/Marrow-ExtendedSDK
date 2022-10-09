using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace SLZ.AI
{
	public class TriggerManager : MonoBehaviour
	{
		public struct TriggerCompareResult
		{
			public readonly int triggerIndex;

			public readonly int targetIndex;

			public readonly int isInTrigger;

			public readonly int hasStateChanged;

			public readonly float distance;

			public readonly Vector3 direction;

			public readonly float angleFromForward;

			public TriggerCompareResult(int triggerIndex, int targetIndex, int isInTrigger, int hasStateChanged, float distance, Vector3 direction, float angleFromForward)
			{
				this.angleFromForward = default(float);
				this.direction = default(Vector3);
				this.distance = default(float);
				this.hasStateChanged = default(int);
				this.isInTrigger = default(int);
				this.targetIndex = default(int);
				this.triggerIndex = default(int);
			}
		}

		public struct JobTransform
		{
			public readonly Vector3 position;

			public readonly Quaternion rotation;

			public JobTransform(Vector3 position, Quaternion rotation)
			{
				this.rotation = default(Quaternion);
				this.position = default(Vector3);
			}
		}

		public struct TriggerEventGroup
		{
			public bool wasInTrigger;

			public readonly Action<AITarget> onTriggerEnterDelegate;

			public readonly Action<AITarget> onTriggerExitDelegate;

			public TriggerEventGroup(Action<AITarget> onTriggerEnter, Action<AITarget> onTriggerExit)
			{
				this.onTriggerExitDelegate = default(Action<AITarget>);
				this.onTriggerEnterDelegate = default(Action<AITarget>);
				this.wasInTrigger = default(bool);
			}
		}

		public struct TriggerData
		{
			public readonly int enterTriggerType;

			public readonly float enterRadius;

			public readonly float enterFovAngle;

			public readonly int exitTriggerType;

			public readonly float exitRadius;

			public readonly float exitFovAngle;

			public TriggerData(int triggerType, float radius, float fovAngle)
			{
				this.exitFovAngle = default(float);
				this.exitRadius = default(float);
				this.exitTriggerType = default(int);
				this.enterFovAngle = default(float);
				this.enterRadius = default(float);
				this.enterTriggerType = default(int);
			}

			public TriggerData(int enterTriggerType, float enterRadius, float enterFovAngle, int exitTriggerType, float exitRadius, float exitFovAngle)
			{
				this.exitFovAngle = default(float);
				this.exitRadius = default(float);
				this.exitTriggerType = default(int);
				this.enterFovAngle = default(float);
				this.enterRadius = default(float);
				this.enterTriggerType = default(int);
			}
		}

		public struct TargetData
		{
			public readonly int targetType;

			public readonly float radius;

			public TargetData(int targetType, float radius)
			{
				this.radius = default(float);
				this.targetType = default(int);
			}
		}

		public enum TriggerTypes
		{
			Sphere = 1,
			Cone = 2
		}

		public enum TargetTypes
		{
			Sphere = 1
		}

		public struct AICompareJob : IJobParallelFor
		{
			[ReadOnly]
			public NativeArray<TriggerData> triggerInputs;

			[ReadOnly]
			public NativeArray<JobTransform> triggerTransforms;

			[ReadOnly]
			public NativeArray<TargetData> targetInputs;

			[ReadOnly]
			public NativeArray<JobTransform> targetTransforms;

			[ReadOnly]
			public int targetsLengths;

			[ReadOnly]
			public int targetsLength;

			public NativeArray<TriggerCompareResult> aiResults;

			public void Execute(int i)
			{
			}
		}

		private static TriggerManager _instance;

		private AICompareJob _aiCompareJob;

		private JobHandle _aiCompareJobHandle;

		public int defaultBufferSize;

		private Dictionary<AITrigger, Dictionary<AITarget, TriggerCompareResult>> _resultLookupTable;

		private Dictionary<AITrigger, int> _triggerInputTracker;

		private AITrigger[] _aiTriggers;

		private NativeArray<TriggerData> _triggerInputs;

		private TriggerEventGroup[] _triggerEventGroups;

		private NativeArray<JobTransform> _triggerJobTransforms;

		private int _triggersLength;

		private Dictionary<AITarget, int> _targetInputTracker;

		private AITarget[] _aiTargets;

		private NativeArray<TargetData> _targetInputs;

		private NativeArray<JobTransform> _targetJobTransforms;

		private int _targetsLength;

		private NativeArray<TriggerCompareResult> _aiResults;

		private bool _isFirstPass;

		public static TriggerManager Instance
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public bool TryGetResult(AITrigger trigger, AITarget target, [Out] TriggerCompareResult result)
		{
			return default(bool);
		}

		public static void CreateTrigger(AITrigger aiTrigger, [In] TriggerData triggerData, Action<AITarget> onTriggerEnter, Action<AITarget> onTriggerExit)
		{
		}

		public static void UpdateTriggerData(AITrigger aiTrigger, [In] TriggerData triggerData)
		{
		}

		public static void DestroyTrigger(AITrigger aiTrigger)
		{
		}

		public static void CreateTarget(AITarget aiTarget, TargetData targetData)
		{
		}

		public static void UpdateTargetData(AITarget aiTarget, TargetData targetData)
		{
		}

		public static void DestroyTarget(AITarget aiTarget)
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		public TriggerManager()
			: base()
		{
		}
	}
}
