using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;

public class AIManager : MonoBehaviour
{
	public struct AICompareResult
	{
		public float distance;

		public float angle;
	}

	public struct AICompareInput
	{
		public int isSkipSensorCalc;
	}

	public struct CopyToTransformBufferJob : IJobParallelForTransform
	{
		public NativeArray<Vector3> positionBuffer;

		public NativeArray<Quaternion> rotationBuffer;

		public void Execute(int i, TransformAccess transform)
		{
		}
	}

	public struct AICompareJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray<Vector3> positionBuffer;

		[ReadOnly]
		public NativeArray<Quaternion> rotationBuffer;

		[ReadOnly]
		public int length;

		public NativeArray<RaycastCommand> aiRaycastCommands;

		public NativeArray<AICompareResult> aiResults;

		public void Execute(int i)
		{
		}
	}

	[Tooltip("Sets the maximum amount of sensors that can be considered for calculation")]
	public int maxSensorCount;

	private TransformAccessArray _aiSensorTransforms;

	private Dictionary<Transform, int> _aiSensorKeyToIndexMap;

	private NativeArray<RaycastCommand> _aiRaycastCommands;

	private NativeArray<RaycastHit> _aiRaycastHits;

	private NativeArray<AICompareInput> _aiInput;

	private NativeArray<AICompareResult> _aiResults;

	private NativeArray<Vector3> _nPostionBuffer;

	private NativeArray<Quaternion> _nRotationBuffer;

	private static AIManager _instance;

	private CopyToTransformBufferJob _copySensorTransformJob;

	private AICompareJob _aiCompareJob;

	private JobHandle _copySensorTransformHandle;

	private JobHandle _aiCompareJobHandle;

	private JobHandle _aiRaycastCommandHandle;

	public static AIManager Instance
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public void AddSensorTransform(Transform t, bool isSkipSensorCalc = false)
	{
	}

	public void RemoveSensorTransform(Transform t)
	{
	}

	public void OnDisable()
	{
	}

	public AIManager()
		: base()
	{
	}
}
