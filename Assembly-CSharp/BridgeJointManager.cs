using UnityEngine;

public class BridgeJointManager : MonoBehaviour
{
	public bool isWalkable;

	public bool setNavCost;

	public string navAreaTitle;

	public SetJointRot[] bridgeControls;

	[ContextMenu("ToggleBridge")]
	public void ToggleBridge()
	{
	}

	public BridgeJointManager()
		: base()
	{
	}
}
