using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;

public class LoreClipboardProxy : MonoBehaviour
{
	[Header("Text")]
	[Space(10f)]
	public string title;

	[TextArea(5, 20)]
	public string body;

	[Space(30f)]
	public TMP_FontAsset font_custom;

	public bool useColor;

	public Color textColor;

	[Tooltip("Will default to prefab value if null")]
	public AudioClip audioActivateOverride;

	[Tooltip("Will default to prefab value if null")]
	public AudioClip audioDeactivateOverride;

	public void Spawn(SpawnableCratePlacer placer, GameObject go)
	{
	}

	public LoreClipboardProxy()
		: base()
	{
	}
}
