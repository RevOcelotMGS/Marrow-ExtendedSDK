using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class VRPhysicsRaycaster : BaseRaycaster
{
	protected const int kNoEventMaskSet = -1;

	[SerializeField]
	protected LayerMask m_EventMask;

	[SerializeField]
	protected int m_MaxRayIntersections;

	protected int m_LastMaxRayIntersections;

	private RaycastHit[] m_Hits;

	public override Camera eventCamera
	{
		get
		{
			return null;
		}
	}

	public virtual int depth
	{
		get
		{
			return default(int);
		}
	}

	public int finalEventMask
	{
		get
		{
			return default(int);
		}
	}

	public LayerMask eventMask
	{
		get
		{
			return default(LayerMask);
		}
		set
		{
		}
	}

	public int maxRayIntersections
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	protected VRPhysicsRaycaster()
		: base()
	{
	}

	protected void ComputeRayAndDistance(PointerEventData eventData, [Out] Ray ray, [Out] float distanceToClipPlane)
	{
	}

	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
	{
	}
}
