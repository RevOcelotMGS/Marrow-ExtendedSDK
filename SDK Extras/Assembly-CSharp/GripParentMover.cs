using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Events;

public class GripParentMover : MonoBehaviour
{
	[SerializeField]
	private ConfigurableJoint[] joints;

	[SerializeField]
	private InteractableHost[] hosts;

	[SerializeField]
	private float lerpDuration;

	private Coroutine moveRoutine;

	[SerializeField]
	private Collider[] localColliders;

	[SerializeField]
	private Collider[] collidersToIgnore;

	[SerializeField]
	private UnityEvent OnCompleteMove;

	[SerializeField]
	private Vector3 startPos;

	[SerializeField]
	private Vector3 endPos;

	private void Start()
	{
	}

	[ContextMenu("StartMove")]
	public void ExtrudeAndStartCountdown()
	{
	}

	private IEnumerator CoMoveJoints()
	{
		return null;
	}

	public void ForceDetachAll()
	{
	}

	public void IgnoreColliders(bool ignore = true)
	{
	}

	public GripParentMover()
		: base()
	{
	}
}
