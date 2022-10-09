using SLZ.Interaction;
using UnityEngine;

public class trackBatteriesReciever : InteractionReciever
{
	private InteractableHost interactableHost;

	private GameObject go;

	private trackBatteries trackBatteries;

	public override void OnInteractableHostEnter(InteractableHost host)
	{
	}

	public void LockBattery()
	{
	}

	public trackBatteriesReciever()
		: base()
	{
	}
}
