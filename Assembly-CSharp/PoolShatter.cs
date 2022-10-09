using System;
using UnityEngine;

public class PoolShatter : MonoBehaviour
{
	[Serializable]
	public struct SimpleTrans
	{
		public Vector3 Position;

		public Quaternion Rotation;

		public Vector3 Scale;
	}

	public GameObject TargetObject;

	public GameObject[] Objects;

	[SerializeField]
	private SimpleTrans[] transforms;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void SetPoser()
	{
	}

	private void Reset()
	{
	}

	[ContextMenu("Gather Transforms")]
	private void GatherTransforms()
	{
	}

	private void OnDisable()
	{
	}

	public PoolShatter()
		: base()
	{
	}
}
