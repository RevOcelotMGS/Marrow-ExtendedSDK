using UnityEngine;

[ExecuteInEditMode]
public class PlayerZipSetup : MonoBehaviour
{
	public float zipTotalLength;

	public float zipMechLength;

	public GameObject zipObj;

	public CapsuleCollider zipCollider;

	public ZipJointMover zipJointMover;

	public GameObject upStartObj;

	public GameObject upEndObj;

	public PlayerZipSetup()
		: base()
	{
	}
}
