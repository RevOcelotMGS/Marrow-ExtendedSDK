using System.Runtime.InteropServices;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public class MB_Utility
	{
		public struct MeshAnalysisResult
		{
			public Rect uvRect;

			public bool hasOutOfBoundsUVs;

			public bool hasOverlappingSubmeshVerts;

			public bool hasOverlappingSubmeshTris;

			public bool hasUVs;

			public float submeshArea;
		}

		private class MB_Triangle
		{
			private int submeshIdx;

			private int[] vs;

			public bool isSame(object obj)
			{
				return default(bool);
			}

			public bool sharesVerts(MB_Triangle obj)
			{
				return default(bool);
			}

			public void Initialize(int[] ts, int idx, int sIdx)
			{
			}

			public MB_Triangle()
				: base()
			{
			}
		}

		public static bool DO_INTEGRITY_CHECKS;

		public static Texture2D createTextureCopy(Texture2D source)
		{
			return null;
		}

		public static bool ArrayBIsSubsetOfA(object[] a, object[] b)
		{
			return default(bool);
		}

		public static Material[] GetGOMaterials(GameObject go)
		{
			return null;
		}

		public static Mesh GetMesh(GameObject go)
		{
			return null;
		}

		public static void SetMesh(GameObject go, Mesh m)
		{
		}

		public static Renderer GetRenderer(GameObject go)
		{
			return null;
		}

		public static void DisableRendererInSource(GameObject go)
		{
		}

		public static bool hasOutOfBoundsUVs(Mesh m, Rect uvBounds)
		{
			return default(bool);
		}

		public static bool hasOutOfBoundsUVs(Mesh m, MeshAnalysisResult putResultHere, int submeshIndex = -1, int uvChannel = 0)
		{
			return default(bool);
		}

		public static bool hasOutOfBoundsUVs(Vector2[] uvs, Mesh m, MeshAnalysisResult putResultHere, int submeshIndex = -1)
		{
			return default(bool);
		}

		public static void setSolidColor(Texture2D t, Color c)
		{
		}

		public static Texture2D resampleTexture(Texture2D source, int newWidth, int newHeight)
		{
			return null;
		}

		public static bool AreAllSharedMaterialsDistinct(Material[] sharedMaterials)
		{
			return default(bool);
		}

		public static int doSubmeshesShareVertsOrTris(Mesh m, MeshAnalysisResult mar)
		{
			return default(int);
		}

		public static bool GetBounds(GameObject go, [Out] Bounds b)
		{
			return default(bool);
		}

		public static void Destroy(Object o)
		{
		}

		public static string ConvertAssetsRelativePathToFullSystemPath(string pth)
		{
			return null;
		}

		public static bool IsSceneInstance(GameObject go)
		{
			return default(bool);
		}

		public MB_Utility()
			: base()
		{
		}
	}
}
