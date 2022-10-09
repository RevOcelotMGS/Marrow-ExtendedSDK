using System.Collections.Generic;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.EventSystems;

public class VRInput : BaseInput
{
	public struct TrackedInput
	{
		public int id;

		public TouchPhase phase;

		public bool isPressed;

		public bool isReleased;

		public Vector2 position;

		public Hand hand;

		public TrackedInput(Hand h, Vector2 p, bool isNew, bool hasMoved, bool isButtonDown, bool isButtonUp, int i)
		{
			this.hand = default(Hand);
			this.position = default(Vector2);
			this.isReleased = default(bool);
			this.isPressed = default(bool);
			this.phase = default(TouchPhase);
			this.id = default(int);
		}
	}

	public List<TrackedInput> trackedInputs;

	public override string compositionString
	{
		get
		{
			return null;
		}
	}

	public override IMECompositionMode imeCompositionMode
	{
		get
		{
			return default(IMECompositionMode);
		}
		set
		{
		}
	}

	public override Vector2 compositionCursorPos
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public override bool mousePresent
	{
		get
		{
			return default(bool);
		}
	}

	public override Vector2 mousePosition
	{
		get
		{
			return default(Vector2);
		}
	}

	public override Vector2 mouseScrollDelta
	{
		get
		{
			return default(Vector2);
		}
	}

	public override bool touchSupported
	{
		get
		{
			return default(bool);
		}
	}

	public override int touchCount
	{
		get
		{
			return default(int);
		}
	}

	public override bool GetMouseButtonDown(int button)
	{
		return default(bool);
	}

	public override bool GetMouseButtonUp(int button)
	{
		return default(bool);
	}

	public override bool GetMouseButton(int button)
	{
		return default(bool);
	}

	public override Touch GetTouch(int index)
	{
		return default(Touch);
	}

	public override float GetAxisRaw(string axisName)
	{
		return default(float);
	}

	public override bool GetButtonDown(string buttonName)
	{
		return default(bool);
	}

	public VRInput()
		: base()
	{
	}
}
