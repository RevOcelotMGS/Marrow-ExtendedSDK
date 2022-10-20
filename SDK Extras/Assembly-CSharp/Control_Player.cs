using SLZ;
using SLZ.Data;
using SLZ.Rig;
using SLZ.VRMK;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Control_Player : MonoBehaviour
{
	public UIRig uiRig;

	[HideInInspector]
	public BodyVitals body_vitals;

	[HideInInspector]
	public float stored_offset_Sitting;

	public RigScreenOptions rigScreen;

	public Audio_Manager audioManager;

	public Control_GlobalTime control_GlobalTime;

	public UniversalRenderPipelineAsset CustomPipelineAsset;

	public bool toolTipDisplay
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public int physicsUpdateRate
	{
		get
		{
			return default(int);
		}
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	private void InstanceOnDataManagerEventPublished(object sender, DataManagerEventArgs args)
	{
	}

	private void Startup()
	{
	}

	public void STANDING()
	{
	}

	public void SendHeight()
	{
	}

	public void UpdateSpectator()
	{
	}

	public void SEND_GRAPHICS()
	{
	}

	public void SEND_VITALS()
	{
	}

	public void AUDIOUPDATE()
	{
	}

	public void SEND_BODYLOG_VITALS()
	{
	}

	public Control_Player()
		: base()
	{
	}
}
