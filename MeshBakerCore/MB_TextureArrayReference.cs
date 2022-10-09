using System;
using UnityEngine;

[Serializable]
public class MB_TextureArrayReference
{
	public string texFromatSetName;

	public Texture2DArray texArray;

	public MB_TextureArrayReference(string formatSetName, Texture2DArray ta)
		: base()
	{
	}
}
