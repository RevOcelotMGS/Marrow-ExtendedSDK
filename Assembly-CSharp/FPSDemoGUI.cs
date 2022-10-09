using UnityEngine;

public class FPSDemoGUI : MonoBehaviour
{
	public GameObject[] Prefabs;

	public Transform muzzleFlashPoint;

	public GameObject Gun;

	public float reactivateTime;

	public Light Sun;

	public bool IsMobile;

	private int currentNomber;

	private GameObject currentInstance;

	private GUIStyle guiStyleHeader;

	private float sunIntensity;

	private float dpiScale;

	private void Start()
	{
	}

	private void OnGUI()
	{
	}

	private void ChangeCurrent(int delta)
	{
	}

	private void Reactivator()
	{
	}

	public FPSDemoGUI()
		: base()
	{
	}
}
