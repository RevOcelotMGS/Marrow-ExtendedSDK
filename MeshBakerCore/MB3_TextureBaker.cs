using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DigitalOpus.MB.Core;
using UnityEngine;

public class MB3_TextureBaker : MB3_MeshBakerRoot
{
	public delegate void OnCombinedTexturesCoroutineSuccess();

	public delegate void OnCombinedTexturesCoroutineFail();

	public MB2_LogLevel LOG_LEVEL;

	[SerializeField]
	protected MB2_TextureBakeResults _textureBakeResults;

	[SerializeField]
	protected int _atlasPadding;

	[SerializeField]
	protected int _maxAtlasSize;

	[SerializeField]
	protected bool _useMaxAtlasWidthOverride;

	[SerializeField]
	protected int _maxAtlasWidthOverride;

	[SerializeField]
	protected bool _useMaxAtlasHeightOverride;

	[SerializeField]
	protected int _maxAtlasHeightOverride;

	[SerializeField]
	protected bool _resizePowerOfTwoTextures;

	[SerializeField]
	protected bool _fixOutOfBoundsUVs;

	[SerializeField]
	protected int _maxTilingBakeSize;

	[SerializeField]
	protected MB2_PackingAlgorithmEnum _packingAlgorithm;

	[SerializeField]
	protected int _layerTexturePackerFastMesh;

	[SerializeField]
	protected bool _meshBakerTexturePackerForcePowerOfTwo;

	[SerializeField]
	protected List<ShaderTextureProperty> _customShaderProperties;

	[SerializeField]
	protected List<string> _customShaderPropNames_Depricated;

	[SerializeField]
	protected MB2_TextureBakeResults.ResultType _resultType;

	[SerializeField]
	protected bool _doMultiMaterial;

	[SerializeField]
	protected bool _doMultiMaterialSplitAtlasesIfTooBig;

	[SerializeField]
	protected bool _doMultiMaterialSplitAtlasesIfOBUVs;

	[SerializeField]
	protected Material _resultMaterial;

	[SerializeField]
	protected bool _considerNonTextureProperties;

	[SerializeField]
	protected bool _doSuggestTreatment;

	private MB3_TextureCombiner.CreateAtlasesCoroutineResult _coroutineResult;

	public MB_MultiMaterial[] resultMaterials;

	public MB_MultiMaterialTexArray[] resultMaterialsTexArray;

	public MB_TextureArrayFormatSet[] textureArrayOutputFormats;

	public List<GameObject> objsToMesh;

	public OnCombinedTexturesCoroutineSuccess onBuiltAtlasesSuccess;

	public OnCombinedTexturesCoroutineFail onBuiltAtlasesFail;

	public MB_AtlasesAndRects[] OnCombinedTexturesCoroutineAtlasesAndRects;

	public override MB2_TextureBakeResults textureBakeResults
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int atlasPadding
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public virtual int maxAtlasSize
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public virtual bool useMaxAtlasWidthOverride
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public virtual int maxAtlasWidthOverride
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public virtual bool useMaxAtlasHeightOverride
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public virtual int maxAtlasHeightOverride
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public virtual bool resizePowerOfTwoTextures
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public virtual bool fixOutOfBoundsUVs
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public virtual int maxTilingBakeSize
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public virtual MB2_PackingAlgorithmEnum packingAlgorithm
	{
		get
		{
			return default(MB2_PackingAlgorithmEnum);
		}
		set
		{
		}
	}

	public virtual int layerForTexturePackerFastMesh
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public bool meshBakerTexturePackerForcePowerOfTwo
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public virtual List<ShaderTextureProperty> customShaderProperties
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual List<string> customShaderPropNames
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual MB2_TextureBakeResults.ResultType resultType
	{
		get
		{
			return default(MB2_TextureBakeResults.ResultType);
		}
		set
		{
		}
	}

	public virtual bool doMultiMaterial
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public virtual bool doMultiMaterialSplitAtlasesIfTooBig
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public virtual bool doMultiMaterialSplitAtlasesIfOBUVs
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public virtual Material resultMaterial
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool considerNonTextureProperties
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool doSuggestTreatment
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public MB3_TextureCombiner.CreateAtlasesCoroutineResult CoroutineResult
	{
		get
		{
			return null;
		}
	}

	public override List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	public MB_AtlasesAndRects[] CreateAtlases()
	{
		return null;
	}

	public IEnumerator CreateAtlasesCoroutine(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CreateAtlasesCoroutineResult coroutineResult, bool saveAtlasesAsAssets = false, MB2_EditorMethodsInterface editorMethods = default(MB2_EditorMethodsInterface), float maxTimePerFrame = 0.01f)
	{
		return null;
	}

	private IEnumerator _CreateAtlasesCoroutineAtlases(MB3_TextureCombiner combiner, ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CreateAtlasesCoroutineResult coroutineResult, bool saveAtlasesAsAssets = false, MB2_EditorMethodsInterface editorMethods = default(MB2_EditorMethodsInterface), float maxTimePerFrame = 0.01f)
	{
		return null;
	}

	internal IEnumerator _CreateAtlasesCoroutineTextureArray(MB3_TextureCombiner combiner, ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CreateAtlasesCoroutineResult coroutineResult, bool saveAtlasesAsAssets = false, MB2_EditorMethodsInterface editorMethods = default(MB2_EditorMethodsInterface), float maxTimePerFrame = 0.01f)
	{
		return null;
	}

	private IEnumerator _CreateAtlasesCoroutine(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CreateAtlasesCoroutineResult coroutineResult, bool saveAtlasesAsAssets = false, MB2_EditorMethodsInterface editorMethods = default(MB2_EditorMethodsInterface), float maxTimePerFrame = 0.01f)
	{
		return null;
	}

	public MB_AtlasesAndRects[] CreateAtlases(ProgressUpdateDelegate progressInfo, bool saveAtlasesAsAssets = false, MB2_EditorMethodsInterface editorMethods = default(MB2_EditorMethodsInterface))
	{
		return null;
	}

	private void unpackMat2RectMap(MB_AtlasesAndRects[] rawResults)
	{
	}

	internal void unpackMat2RectMap(MB_TextureArrayResultMaterial[] rawResults)
	{
	}

	public MB3_TextureCombiner CreateAndConfigureTextureCombiner()
	{
		return null;
	}

	public static void ConfigureNewMaterialToMatchOld(Material newMat, Material original)
	{
	}

	private string PrintSet(HashSet<Material> s)
	{
		return null;
	}

	private bool _ValidateResultMaterials()
	{
		return default(bool);
	}

	public MB3_TextureBaker()
		: base()
	{
	}
}
