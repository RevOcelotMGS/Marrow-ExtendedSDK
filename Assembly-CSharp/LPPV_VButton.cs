using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class LPPV_VButton : MonoBehaviour
{
	public enum ButtonType
	{
		TriggerButton = 0,
		HoldButton = 1
	}

	public ButtonType buttonType;

	[HideInInspector]
	public bool value;

	private EventTrigger _eventTrigger;

	private void Start()
	{
	}

	private void SetEventTrigger()
	{
	}

	private void Update()
	{
	}

	public void OnButtonDown()
	{
	}

	public void OnButtonUp()
	{
	}

	public LPPV_VButton()
		: base()
	{
	}
}
