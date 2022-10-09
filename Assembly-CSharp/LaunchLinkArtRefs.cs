using SLZ.Combat;
using UnityEngine;

public class LaunchLinkArtRefs : MonoBehaviour
{
	public GameObject forwardObjs;

	public GameObject reverseObjs;

	public Animator forwardArtAnim;

	public Animator reverseArtAnim;

	public MeshRenderer[] colorRends;

	public GameObject forwExplicitTriggerObj;

	public GameObject reverseExplicitTriggerObj;

	public GenericAttackReceiver[] genAttackRecievers;

	public GenGameControl_Trigger forwTrig;

	public GenGameControl_Trigger revTrig;

	public GameObject playerTargForw;

	public GameObject playerTargRev;

	public LaunchLinkArtRefs()
		: base()
	{
	}
}
