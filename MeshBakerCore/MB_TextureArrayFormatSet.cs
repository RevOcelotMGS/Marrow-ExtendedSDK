using System;
using DigitalOpus.MB.Core;
using UnityEngine;

[Serializable]
public class MB_TextureArrayFormatSet
{
	public string name;

	public TextureFormat defaultFormat;

	public MB_TextureArrayFormat[] formatOverrides;

	public bool ValidateTextureImporterFormatsExistsForTextureFormats(MB2_EditorMethodsInterface editorMethods, int idx)
	{
		return default(bool);
	}

	public TextureFormat GetFormatForProperty(string propName)
	{
		return default(TextureFormat);
	}

	public MB_TextureArrayFormatSet()
		: base()
	{
	}
}
