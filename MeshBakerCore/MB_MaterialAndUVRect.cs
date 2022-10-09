using System;
using System.Collections.Generic;
using DigitalOpus.MB.Core;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class MB_MaterialAndUVRect
{
	public Material material;

	public Rect atlasRect;

	public string srcObjName;

	public int textureArraySliceIdx;

	public bool allPropsUseSameTiling;

	[FormerlySerializedAs("sourceMaterialTiling")]
	public Rect allPropsUseSameTiling_sourceMaterialTiling;

	[FormerlySerializedAs("samplingEncapsulatinRect")]
	public Rect allPropsUseSameTiling_samplingEncapsulatinRect;

	public Rect propsUseDifferntTiling_srcUVsamplingRect;

	[NonSerialized]
	public List<GameObject> objectsThatUse;

	public MB_TextureTilingTreatment tilingTreatment;

	public MB_MaterialAndUVRect(Material mat, Rect destRect, bool allPropsUseSameTiling, Rect sourceMaterialTiling, Rect samplingEncapsulatingRect, Rect srcUVsamplingRect, MB_TextureTilingTreatment treatment, string objName)
		: base()
	{
	}

	public override int GetHashCode()
	{
		return default(int);
	}

	public override bool Equals(object obj)
	{
		return default(bool);
	}

	public Rect GetEncapsulatingRect()
	{
		return default(Rect);
	}

	public Rect GetMaterialTilingRect()
	{
		return default(Rect);
	}
}
