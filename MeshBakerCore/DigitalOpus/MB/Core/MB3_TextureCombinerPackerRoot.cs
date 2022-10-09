using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	internal abstract class MB3_TextureCombinerPackerRoot : MB_ITextureCombinerPacker
	{
		public abstract bool Validate(MB3_TextureCombinerPipeline.TexturePipelineData data);

		internal static void CreateTemporaryTexturesForAtlas(List<MB_TexSet> distinctMaterialTextures, MB3_TextureCombiner combiner, int propIdx, MB3_TextureCombinerPipeline.TexturePipelineData data)
		{
		}

		internal static void SaveAtlasAndConfigureResultMaterial(MB3_TextureCombinerPipeline.TexturePipelineData data, MB2_EditorMethodsInterface textureEditorMethods, Texture2D atlas, ShaderTextureProperty property, int propIdx)
		{
		}

		public static AtlasPackingResult[] CalculateAtlasRectanglesStatic(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		public static void MakeProceduralTexturesReadable(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
		}

		public virtual IEnumerator ConvertTexturesToReadableFormats(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		public virtual AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		public abstract IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL);

		public MB3_TextureCombinerPackerRoot()
			: base()
		{
		}
	}
}
