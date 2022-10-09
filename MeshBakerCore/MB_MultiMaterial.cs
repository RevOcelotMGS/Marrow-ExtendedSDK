using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MB_MultiMaterial
{
	public Material combinedMaterial;

	public bool considerMeshUVs;

	public List<Material> sourceMaterials;

	public MB_MultiMaterial()
		: base()
	{
	}
}
