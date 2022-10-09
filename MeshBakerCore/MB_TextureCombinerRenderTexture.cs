using System.Collections.Generic;
using DigitalOpus.MB.Core;
using UnityEngine;

public class MB_TextureCombinerRenderTexture
{
	public MB2_LogLevel LOG_LEVEL;

	private Material mat;

	private RenderTexture _destinationTexture;

	private Camera myCamera;

	private int _padding;

	private bool _isNormalMap;

	private bool _fixOutOfBoundsUVs;

	private bool _doRenderAtlas;

	private Rect[] rs;

	private List<MB_TexSet> textureSets;

	private int indexOfTexSetToRender;

	private ShaderTextureProperty _texPropertyName;

	private MB3_TextureCombinerNonTextureProperties _resultMaterialTextureBlender;

	private Texture2D targTex;

	public Texture2D DoRenderAtlas(GameObject gameObject, int width, int height, int padding, Rect[] rss, List<MB_TexSet> textureSetss, int indexOfTexSetToRenders, ShaderTextureProperty texPropertyname, MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender, bool isNormalMap, bool fixOutOfBoundsUVs, bool considerNonTextureProperties, MB3_TextureCombiner texCombiner, MB2_LogLevel LOG_LEV)
	{
		return null;
	}

	public void OnRenderObject()
	{
	}

	public static void ConvertRenderTextureToTexture2D(RenderTexture _destinationTexture, bool yIsFlipped, bool doLinearColorSpace, MB2_LogLevel LOG_LEVEL, Texture2D tempTexture)
	{
	}

	private Color32 ConvertNormalFormatFromUnity_ToStandard(Color32 c)
	{
		return default(Color32);
	}

	public static bool YisFlipped(MB2_LogLevel LOG_LEVEL)
	{
		return default(bool);
	}

	private void CopyScaledAndTiledToAtlas(MB_TexSet texSet, MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale, Rect rec, ShaderTextureProperty texturePropertyName, MB3_TextureCombinerNonTextureProperties resultMatTexBlender, bool yIsFlipped)
	{
	}

	private static void _printTexture(Texture2D t)
	{
	}

	public MB_TextureCombinerRenderTexture()
		: base()
	{
	}
}
