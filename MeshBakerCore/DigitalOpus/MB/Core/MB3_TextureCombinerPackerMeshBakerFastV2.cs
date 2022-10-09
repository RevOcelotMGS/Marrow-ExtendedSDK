using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	internal class MB3_TextureCombinerPackerMeshBakerFastV2 : MB_ITextureCombinerPacker
	{
		private Mesh mesh;

		private GameObject renderAtlasesGO;

		private GameObject cameraGameObject;

		public bool Validate(MB3_TextureCombinerPipeline.TexturePipelineData data)
		{
			return default(bool);
		}

		public IEnumerator ConvertTexturesToReadableFormats(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		public virtual AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		public IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		private void OneTimeSetup(MB3_AtlasPackerRenderTextureUsingMesh atlasRenderer, GameObject atlasMesh, GameObject cameraGameObject, int atlasWidth, int atlasHeight, int padding, int layer, MB2_LogLevel logLevel)
		{
		}

		public MB3_TextureCombinerPackerMeshBakerFastV2()
			: base()
		{
		}
	}
}
