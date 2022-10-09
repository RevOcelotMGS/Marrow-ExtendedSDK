using UnityEngine;

public class ForceLevels : MonoBehaviour
{
	[Header("Oculus Settings")]
	[SerializeField]
	private OVRPlugin.ColorSpace QuestColorSpace;

	[SerializeField]
	private OVRPlugin.FixedFoveatedRenderingLevel FoveatedLevel;

	[SerializeField]
	private bool DynamicFoveatedRendering;

	private void Awake()
	{
	}

	public ForceLevels()
		: base()
	{
	}
}
