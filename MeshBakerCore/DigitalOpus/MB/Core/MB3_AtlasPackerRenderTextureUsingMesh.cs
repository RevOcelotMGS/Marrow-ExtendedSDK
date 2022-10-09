using System.Collections.Generic;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public class MB3_AtlasPackerRenderTextureUsingMesh
	{
		public class MeshRectInfo
		{
			public int vertIdx;

			public int triIdx;

			public int atlasIdx;

			public MeshRectInfo()
				: base()
			{
			}
		}

		public class MeshAtlas
		{
			internal static void BuildAtlas(AtlasPackingResult packedAtlasRects, List<MB_TexSet> distinctMaterialTextures, int propIdx, int atlasSizeX, int atlasSizeY, Mesh m, List<Material> generatedMats, ShaderTextureProperty property, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
			{
			}

			private static void ConfigureMaterial_DefaultPipeline(Material mt, Texture2D t, bool isSavingAsANormalMapAssetThatWillBeImported, MB2_LogLevel LOG_LEVEL)
			{
			}

			public static MeshRectInfo AddQuad(Rect wldRect, Rect uvRect, List<Vector3> verts, List<Vector2> uvs, List<int> tris)
			{
				return null;
			}

			public static void AddNineSlicedRect(Rect atlasRectRaw, float paddingX, float paddingY, Rect srcUVRectt, List<Vector3> verts, List<Vector2> uvs, List<int> tris, float srcTexWidth, float srcTexHeight, string texName)
			{
			}

			public MeshAtlas()
				: base()
			{
			}
		}

		public int camMaskLayer;

		public int width;

		public int height;

		public int padding;

		public MB2_LogLevel LOG_LEVEL;

		private bool _initialized;

		private bool _camSetup;

		public void Initialize(int camMaskLayer, int width, int height, int padding, MB2_LogLevel LOG_LEVEL = MB2_LogLevel.info)
		{
		}

		internal void SetupCameraGameObject(GameObject camGameObject)
		{
		}

		internal Texture2D DoRenderAtlas(GameObject go, int width, int height, bool isNormalMap, ShaderTextureProperty propertyName)
		{
			return null;
		}

		public MB3_AtlasPackerRenderTextureUsingMesh()
			: base()
		{
		}
	}
}
