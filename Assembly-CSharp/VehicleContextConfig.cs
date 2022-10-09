using UnityEngine;

[CreateAssetMenu(fileName = "VehicleContextConfig", menuName = "ContextConfigs/VehicleContextConfigs", order = 1)]
public class VehicleContextConfig : ScriptableObject
{
	[SerializeField]
	private float taskFloat;

	[SerializeField]
	private bool driveThrough;

	[SerializeField]
	private float preSpeedMin;

	[SerializeField]
	private float preSpeedMax;

	[SerializeField]
	private float inSpeedMin;

	[SerializeField]
	private float inSpeedMax;

	[SerializeField]
	private float goalRadius;

	[SerializeField]
	private float proxRadius;

	public float TaskFloat
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public bool DriveThrough
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public float PreSpeedMin
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float PreSpeedMax
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float InSpeedMin
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float InSpeedMax
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float GoalRadius
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float ProxRadius
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public VehicleContextConfig()
		: base()
	{
	}
}
