using System;
using UnityEngine;

[Serializable]
public class Data_Building
{
	public bool DoorLocked;

	public Color hdr_OnColor;

	public Color hdr_BlinkColor;

	public Color hdr_OffColor;

	public bool LightOn;

	public bool Flicker;

	public bool WindowLocked;

	public float LinearLimitSpring;

	public float LinearLimitDamperClosed;

	public float LinearLimitDamperOpen;

	public float LinearLimitLimClosed;

	public float LinearLimitLimOpen;

	public float LinearLimitBounce;

	public float LinearLimitContactDist;

	public Vector3 Anchor;

	public Vector3 TargetPosClosed;

	public Vector3 TargetPosOpen;

	public float MoveRate;

	public bool GarageDoorPowered;

	public GarageDoorPowerable.MOVINGSTATE MoveState;

	public bool TurnedOn;

	public bool FanPowered;

	public bool FuseBoxPowered;

	public bool FuseIn;

	public bool FuseOpening;

	public int LeverTries;

	public bool LeverPowered;

	public Data_Building()
		: base()
	{
	}
}
