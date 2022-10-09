using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MB_MultiMaterialTexArray
{
	public Material combinedMaterial;

	public List<MB_TexArraySlice> slices;

	public List<MB_TexArrayForProperty> textureProperties;

	public MB_MultiMaterialTexArray()
		: base()
	{
	}
}
