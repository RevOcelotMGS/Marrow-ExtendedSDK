using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MB_AtlasesAndRects
{
	public Texture2D[] atlases;

	[NonSerialized]
	public List<MB_MaterialAndUVRect> mat2rect_map;

	public string[] texPropertyNames;

	public MB_AtlasesAndRects()
		: base()
	{
	}
}
