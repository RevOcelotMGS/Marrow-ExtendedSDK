using System.Collections;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	internal interface MB_ITextureCombinerPacker
	{
		bool Validate(MB3_TextureCombinerPipeline.TexturePipelineData data);

		IEnumerator ConvertTexturesToReadableFormats(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL);

		AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL);

		IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL);
	}
}
