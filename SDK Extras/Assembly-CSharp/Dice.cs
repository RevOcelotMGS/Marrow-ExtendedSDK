using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

public class Dice : MonoBehaviour
{
	[Serializable]
	public class UnityEventInt : UnityEvent<int>
	{
		public UnityEventInt()
			: base()
		{
		}
	}

	private enum DieState
	{
		Untouched = 0,
		Held = 1,
		Rolling = 2,
		Rolled = 3
	}

	[Serializable]
	public class dieSide
	{
		public Transform zDirection;

		public bool twoSided;

		public int fwdInt;

		public int backInt;

		public dieSide()
			: base()
		{
		}
	}

	private static ComponentCache<Dice> _cache;

	[SerializeField]
	public UnityEventInt activeRoll;

	public UnityEventInt resultRoll;

	[SerializeField]
	private Rigidbody _rb;

	[SerializeField]
	private InteractableHost _host;

	private Coroutine _rollingCo;

	private WaitForSeconds _wait;

	private int _lastRoll;

	private DieState _dieState;

	public dieSide[] sides;

	public static ComponentCache<Dice> Cache
	{
		get
		{
			return null;
		}
	}

	public InteractableHost host
	{
		get
		{
			return null;
		}
	}

	public Rigidbody rb
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Reset()
	{
	}

	public int GetUpInt(Vector3 upDirection)
	{
		return default(int);
	}

	private void OnHandAttached(InteractableHost host, Hand hand)
	{
	}

	private void OnHandDetached(InteractableHost host, Hand hand)
	{
	}

	private IEnumerator Rolling()
	{
		return null;
	}

	public Dice()
		: base()
	{
	}
}
