using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;

public class BatteryReciever : MonoBehaviour, IInteractionReceivable
{
	public Transform target;

	private ConfigurableJoint ignoreJoint;

	private InteractableHost batteryHost;

	private void CreateJoint(Rigidbody rb)
	{
	}

	private void DestroyJoint()
	{
	}

	public void OnInteractableHostEnter(InteractableHost host)
	{
	}

	public virtual void OnInteractableHostDrop(InteractableHost host)
	{
	}

	public void OnInteractableHostExit(InteractableHost host)
	{
	}

	public void OnInteractableHostStay(InteractableHost host)
	{
	}

	protected void GetHandPositionFromWorldHandle(Hand hand, Vector3 worldHandlePosition, Quaternion worldHandleRotation, [Out] Vector3 handPosition, [Out] Quaternion handRotation)
	{
	}

	protected void GetHandPositionFromWorldHandle(Hand hand, SimpleTransform worldHandleTransform, [Out] SimpleTransform handTransform)
	{
	}

	public void Generic(Grip grip, Hand hand, InteractableHost host, float perc)
	{
	}

	private IEnumerator CoDriftIntoTransform()
	{
		return null;
	}

	private IEnumerator CoDriftOutOfTransform()
	{
		return null;
	}

	public BatteryReciever()
		: base()
	{
	}
}
