using System;
using UnityEngine;

public class MaterialType : MonoBehaviour
{
	[Serializable]
	public enum MaterialTypeEnum
	{
		Plaster = 0,
		Metall = 1,
		Folliage = 2,
		Rock = 3,
		Wood = 4,
		Brick = 5,
		Concrete = 6,
		Dirt = 7,
		Glass = 8,
		Water = 9
	}

	public MaterialTypeEnum TypeOfMaterial;

	public MaterialType()
		: base()
	{
	}
}
