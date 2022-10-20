using UnityEngine;

public class TextureStreamingSummary : MonoBehaviour
{
	public float X;

	public float Y;

	public int MemoryBudgetPercentThreshold;

	public int TextureStreamingPercentThreshold;

	public bool discardUnusedMips;

	private ulong HighestDesiredTextureMemory;

	private Rect TextRect;

	public void Start()
	{
	}

	public static string HumanReadableSize(ulong size)
	{
		return null;
	}

	private void ShowText(string text)
	{
	}

	public void OnGUI()
	{
	}

	public TextureStreamingSummary()
		: base()
	{
	}
}
