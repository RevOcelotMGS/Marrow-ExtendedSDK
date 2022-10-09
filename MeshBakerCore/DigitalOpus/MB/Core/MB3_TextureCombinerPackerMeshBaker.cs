using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	internal class MB3_TextureCombinerPackerMeshBaker : MB3_TextureCombinerPackerRoot
	{
		public override bool Validate(MB3_TextureCombinerPipeline.TexturePipelineData data)
		{
			return default(bool);
		}

		public override IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		internal static IEnumerator CopyScaledAndTiledToAtlas(MeshBakerMaterialTexture source, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName, DRect srcSamplingRect, int targX, int targY, int targW, int targH, AtlasPadding padding, Color[][] atlasPixels, bool isNormalMap, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, ProgressUpdateDelegate progressInfo = default(ProgressUpdateDelegate), MB2_LogLevel LOG_LEVEL = MB2_LogLevel.info)
		{
			return null;
		}

		public MB3_TextureCombinerPackerMeshBaker()
			: base()
		{
		}
	}
}
