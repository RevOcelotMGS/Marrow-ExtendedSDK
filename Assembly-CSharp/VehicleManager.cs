using UnityEngine;

public class VehicleManager : MonoBehaviour
{
	public RCC_GroundMaterials groundMaterials;

	public RCC_Skidmarks[] skidmarks;

	public int[] skidmarksIndexes;

	private int _lastGroundIndex;

	public VehicleSettings defaultVData;

	public VehicleSettings driftVData;

	private void Start()
	{
	}

	public int AddSkidMark(Vector3 pos, Vector3 normal, float intensity, int lastIndex, int groundIndex)
	{
		return default(int);
	}

	public int AddSkidMark(Vector3 pos, Vector3 normal, float intensity, int lastIndex, int groundIndex, float width)
	{
		return default(int);
	}

	public void CleanSkidMark()
	{
	}

	public void CleanSkidMark(int index)
	{
	}

	public VehicleManager()
		: base()
	{
	}
}
