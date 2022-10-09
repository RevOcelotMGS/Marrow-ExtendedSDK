using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using RayFire.DotNet;
using UnityEngine;

namespace RayFire
{
	public static class RFFragment
	{
		private static bool silentMode;

		private static List<Mesh> meshListStatic;

		private static List<Vector3> pivotListStatic;

		private static List<Dictionary<int, int>> subIdsListStatic;

		public static void CacheMeshes(Mesh[] meshes, Vector3[] pivots, List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
		{
		}

		private static void RemovePlanar(Mesh[] meshes, Vector3[] pivots, List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
		{
		}

		private static void RemoveBySize(Mesh[] meshes, Vector3[] pivots, List<RFDictionary> origSubMeshIdsRf, RayfireShatter scr)
		{
		}

		public static bool InputMesh(RayfireRigid scr)
		{
			return default(bool);
		}

		private static bool SetRigidShatter(RayfireRigid scr)
		{
			return default(bool);
		}

		public static void CacheMeshesInst(Mesh[] meshes, Vector3[] pivots, List<RFDictionary> origSubMeshIdsRf, RayfireRigid scrRigid)
		{
		}

		public static void CacheMeshesMult(Transform tmSaved, List<Mesh> meshesList, List<Vector3> pivotsList, List<RFDictionary> subList, RayfireRigid scrRigid, List<int> batchAmount, int batchInd)
		{
		}

		private static void FinalCacheMeshes(Mesh[] meshes, RayfireRigid scrRigid, bool successState)
		{
		}

		private static Mesh GetDemolitionMesh(RayfireRigid scr)
		{
			return null;
		}

		private static Mesh GetDemolitionMesh(RayfireShatter scr)
		{
			return null;
		}

		public static void SliceMeshes(Mesh[] meshes, Vector3[] pivots, List<RFDictionary> origSubMeshIdsRf, RayfireRigid scr, List<Vector3> sliceData)
		{
		}

		private static bool Compute(int shatterMode, RFShatter shatter, Transform tm, Mesh[] meshes, Vector3[] pivots, Mesh mesh, int innerSubId, List<Dictionary<int, int>> subIds, UnityEngine.Object obj, List<int> markedElements = default(List<int>))
		{
			return default(bool);
		}

		private static int GetShatterMode(RayfireShatter scrShatter = default(RayfireShatter))
		{
			return default(int);
		}

		private static bool EmptyMeshState(Mesh[] meshes)
		{
			return default(bool);
		}

		private static void SetShatterFragmentProperties(RFShatter shatter, RayfireShatter scrSh)
		{
		}

		private static void SetRigidFragmentProperties(RFShatter shatter, RayfireShatter scrSh, RayfireRigid scrRigid)
		{
		}

		private static RFShatter SetShatter(FragmentMode fragmentMode, int shatterMode, Mesh mesh, Transform transform, RFSurface interior, bool decompose, bool delete_collinear = false, int seed = 1, bool pre_cap = true, bool remove_cap_faces = false, bool remove_double_faces = true, bool exclude_inside = false, bool post_normals_smooth = false, int min_bbox_diag_size_filter_perc = 3, int meshRemoveMinFaceFilter = 4, bool postWeld = true)
		{
			return null;
		}

		private static void SetShatterEditorMode(RFShatter shatter, float min_bbox_diag_size_filter, bool pre_cap, bool remove_cap_faces, bool remove_double_faces, bool exclude_inside, int meshRemoveMinFaceFilter)
		{
		}

		private static void SetShatterRuntimeMode(RFShatter shatter, bool pre_cap, int meshRemoveMinFaceFilter)
		{
		}

		private static void SetVoronoi(RFShatter shatter, int numFragments, Transform tm, Vector3 centerPos, float centerBias)
		{
		}

		private static void SetSplinters(RFShatter shatter, int numFragments, RFSplinters splint, Transform tm, Vector3 centerPos, float centerBias)
		{
		}

		private static void SetSlabs(RFShatter shatter, int numFragments, RFSplinters slabs, Transform tm, Vector3 centerPos, float centerBias)
		{
		}

		private static void SetRadial(RFShatter shatter, RFRadial radial, Transform tm, Vector3 centerPos, Quaternion centerDirection)
		{
		}

		private static void SetCustom(RFShatter shatter, RFCustom custom, Transform tm, Bounds bound, int seed)
		{
		}

		private static void SetMirrored(RFShatter shatter, RFMirrored mirror, Transform tm, Bounds bound, int seed)
		{
		}

		private static void SetSlices(RFShatter shatter, Transform tm, RFSlice slices)
		{
		}

		private static void SetBricks(RFShatter shatter, Transform tm, RFBricks bricks, Bounds bounds)
		{
		}

		private static void SetVoxels(RFShatter shatter, Transform tm, RFVoxels voxels, Bounds bounds)
		{
		}

		private static float BoolToFloat(bool v)
		{
			return default(float);
		}

		private static void SetTet(RFShatter shatter, Bounds bounds, RFTets tets)
		{
		}

		private static void SetDecompose(RFShatter shatter)
		{
		}

		private static void SetClusters(RFShatter shatter, RFShatterCluster gluing)
		{
		}

		private static void SetStretching(RFShatter shatter, AxisType axis, float strength, FragType fragType)
		{
		}

		private static Vector3 DirectionAxis(AxisType axisType)
		{
			return default(Vector3);
		}

		public static void RescaleMesh(Mesh mesh, float scale)
		{
		}
	}
}
