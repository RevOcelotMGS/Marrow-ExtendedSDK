using System.Collections.Generic;
using DigitalOpus.MB.Core;
using UnityEngine;

[ExecuteInEditMode]
public class MB3_AtlasPackerRenderTexture : MonoBehaviour
{
	private MB_TextureCombinerRenderTexture fastRenderer;

	private bool _doRenderAtlas;

	public int width;

	public int height;

	public int padding;

	public bool isNormalMap;

	public bool fixOutOfBoundsUVs;

	public bool considerNonTextureProperties;

	public MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender;

	public Rect[] rects;

	public Texture2D tex1;

	public List<MB_TexSet> textureSets;

	public int indexOfTexSetToRender;

	public ShaderTextureProperty texPropertyName;

	public MB2_LogLevel LOG_LEVEL;

	public Texture2D testTex;

	public Material testMat;

	public Texture2D OnRenderAtlas(MB3_TextureCombiner combiner)
	{
		return null;
	}

	private void OnRenderObject()
	{
	}

	public MB3_AtlasPackerRenderTexture()
		: base()
	{
	}
}
