using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
[AddComponentMenu("Event/vR Graphic Raycaster")]
public class VRGraphicRaycaster : BaseRaycaster
{
	public enum BlockingObjects
	{
		None = 0,
		TwoD = 1,
		ThreeD = 2,
		All = 3
	}

	public Camera eventCameraOverride;

	protected const int kNoEventMaskSet = -1;

	[FormerlySerializedAs("ignoreReversedGraphics")]
	[SerializeField]
	private bool m_IgnoreReversedGraphics;

	[FormerlySerializedAs("blockingObjects")]
	[SerializeField]
	private BlockingObjects m_BlockingObjects;

	[SerializeField]
	protected LayerMask m_BlockingMask;

	private Canvas m_Canvas;

	private RectTransform m_CanvasRect;

	[NonSerialized]
	private List<Graphic> m_RaycastResults;

	[NonSerialized]
	private static readonly List<Graphic> s_SortedGraphics;

	public override int sortOrderPriority
	{
		get
		{
			return default(int);
		}
	}

	public override int renderOrderPriority
	{
		get
		{
			return default(int);
		}
	}

	public bool ignoreReversedGraphics
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public BlockingObjects blockingObjects
	{
		get
		{
			return default(BlockingObjects);
		}
		set
		{
		}
	}

	private Canvas canvas
	{
		get
		{
			return null;
		}
	}

	private RectTransform canvasRect
	{
		get
		{
			return null;
		}
	}

	public override Camera eventCamera
	{
		get
		{
			return null;
		}
	}

	protected VRGraphicRaycaster()
		: base()
	{
	}

	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
	{
	}

	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
	{
	}
}
