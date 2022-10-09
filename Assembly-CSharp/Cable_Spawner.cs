using UnityEngine;

public class Cable_Spawner : MonoBehaviour
{
	[Header("CABLE LIFT REF")]
	[ContextMenuItem("Generate Cable", "Generate")]
	[Space(5f)]
	public CabletSeUp[] cableSetup;

	[Space(5f)]
	public bool isBinary;

	private float colOffset;

	public void Generate()
	{
	}

	public Cable_Spawner()
		: base()
	{
	}
}
