using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public class MBVersion
	{
		public enum PipelineType
		{
			Unsupported = 0,
			Default = 1,
			URP = 2,
			HDRP = 3
		}

		public const string MB_USING_HDRP = "MB_USING_HDRP";

		private static MBVersionInterface _MBVersion;

		private static MBVersionInterface _CreateMBVersionConcrete()
		{
			return null;
		}

		public static string version()
		{
			return null;
		}

		public static int GetMajorVersion()
		{
			return default(int);
		}

		public static int GetMinorVersion()
		{
			return default(int);
		}

		public static bool GetActive(GameObject go)
		{
			return default(bool);
		}

		public static void SetActive(GameObject go, bool isActive)
		{
		}

		public static void SetActiveRecursively(GameObject go, bool isActive)
		{
		}

		public static UnityEngine.Object[] FindSceneObjectsOfType(Type t)
		{
			return null;
		}

		public static bool IsRunningAndMeshNotReadWriteable(Mesh m)
		{
			return default(bool);
		}

		public static Vector2[] GetMeshChannel(int channel, Mesh m, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		public static void MeshClear(Mesh m, bool t)
		{
		}

		public static void MeshAssignUVChannel(int channel, Mesh m, Vector2[] uvs)
		{
		}

		public static Vector4 GetLightmapTilingOffset(Renderer r)
		{
			return default(Vector4);
		}

		public static Transform[] GetBones(Renderer r, bool isSkinnedMeshWithBones)
		{
			return null;
		}

		public static void OptimizeMesh(Mesh m)
		{
		}

		public static int GetBlendShapeFrameCount(Mesh m, int shapeIndex)
		{
			return default(int);
		}

		public static float GetBlendShapeFrameWeight(Mesh m, int shapeIndex, int frameIndex)
		{
			return default(float);
		}

		public static void GetBlendShapeFrameVertices(Mesh m, int shapeIndex, int frameIndex, Vector3[] vs, Vector3[] ns, Vector3[] ts)
		{
		}

		public static void ClearBlendShapes(Mesh m)
		{
		}

		public static void AddBlendShapeFrame(Mesh m, string nm, float wt, Vector3[] vs, Vector3[] ns, Vector3[] ts)
		{
		}

		public static int MaxMeshVertexCount()
		{
			return default(int);
		}

		public static void SetMeshIndexFormatAndClearMesh(Mesh m, int numVerts, bool vertices, bool justClearTriangles)
		{
		}

		public static bool GraphicsUVStartsAtTop()
		{
			return default(bool);
		}

		public static bool IsTextureReadable(Texture2D tex)
		{
			return default(bool);
		}

		public static void CollectPropertyNames(List<ShaderTextureProperty> texPropertyNames, ShaderTextureProperty[] shaderTexPropertyNames, List<ShaderTextureProperty> _customShaderPropNames, Material resultMaterial, MB2_LogLevel LOG_LEVEL)
		{
		}

		internal static void DoSpecialRenderPipeline_TexturePackerFastSetup(GameObject cameraGameObject)
		{
		}

		internal static ColorSpace GetProjectColorSpace()
		{
			return default(ColorSpace);
		}

		public static PipelineType DetectPipeline()
		{
			return default(PipelineType);
		}

		public static string UnescapeURL(string url)
		{
			return null;
		}

		public static bool IsUsingAddressables()
		{
			return default(bool);
		}

		internal static IEnumerator FindRuntimeMaterialsFromAddresses(MB2_TextureBakeResults textureBakeResult, MB2_TextureBakeResults.CoroutineResult isComplete)
		{
			return null;
		}

		public MBVersion()
			: base()
		{
		}
	}
}
