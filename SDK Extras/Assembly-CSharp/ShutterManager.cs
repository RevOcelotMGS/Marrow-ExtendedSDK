using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ShutterManager : MonoBehaviour
{
	public ConfigurableJoint[] windowJoints;

	public ConfigurableJoint doorJointA;

	public ConfigurableJoint doorJointB;

	public ConfigurableJoint skylightJointA;

	public ConfigurableJoint skylightJointB;

	[ContextMenu("OpenShutters")]
	public void OpenShutters()
	{
	}

	private IEnumerator CoStaggerShuttersSurvival()
	{
		return null;
	}

	public ShutterManager()
		: base()
	{
	}
}
