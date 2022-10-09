using System;

[Serializable]
public class MB_TexArrayForProperty
{
	public string texPropertyName;

	public MB_TextureArrayReference[] formats;

	public MB_TexArrayForProperty(string name, MB_TextureArrayReference[] texRefs)
		: base()
	{
	}
}
