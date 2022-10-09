using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RayFire
{
	[AddComponentMenu("RayFire/Rayfire Shatter")]
	[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-shatter-component/")]
	public class RayfireShatter : MonoBehaviour
	{
		public enum FragLastMode
		{
			New = 0,
			ToLast = 1
		}

		public FragType type;

		public RFVoronoi voronoi;

		public RFSplinters splinters;

		public RFSplinters slabs;

		public RFRadial radial;

		public RFCustom custom;

		public RFMirrored mirrored;

		public RFSlice slice;

		public RFBricks bricks;

		public RFVoxels voxels;

		public RFTets tets;

		public FragmentMode mode;

		public RFSurface material;

		public RFShatterCluster clusters;

		public RFShatterAdvanced advanced;

		public RFMeshExport export;

		public bool showCenter;

		public Vector3 centerPosition;

		public Quaternion centerDirection;

		public Transform transForm;

		public MeshFilter meshFilter;

		public MeshRenderer meshRenderer;

		public SkinnedMeshRenderer skinnedMeshRend;

		public List<MeshFilter> meshFilters;

		public Mesh[] meshes;

		public Vector3[] pivots;

		public List<Transform> rootChildList;

		public List<GameObject> fragmentsAll;

		public List<GameObject> fragmentsLast;

		public List<RFDictionary> origSubMeshIdsRF;

		public Material[] materials;

		public int shatterMode;

		public bool colorPreview;

		public bool scalePreview;

		public float previewScale;

		public float size;

		public float rescaleFix;

		public Vector3 originalScale;

		[HideInInspector]
		public Bounds bound;

		[HideInInspector]
		public bool resetState;

		private static float minSize;

		private void Reset()
		{
		}

		private void SetVariables()
		{
		}

		private bool MainCheck()
		{
			return default(bool);
		}

		private bool SingleMeshCheck()
		{
			return default(bool);
		}

		private bool DefineComponents()
		{
			return default(bool);
		}

		public Bounds GetBound()
		{
			return default(Bounds);
		}

		public void Fragment(FragLastMode fragmentMode = FragLastMode.New)
		{
		}

		private List<GameObject> CreateFragments(GameObject lastRoot = default(GameObject))
		{
			return null;
		}

		public void DeleteFragmentsLast(int destroyMode = 0)
		{
		}

		public void DeleteFragmentsAll()
		{
		}

		public void ResetCenter()
		{
		}

		private void ScaleCheck()
		{
		}

		public void ResetScale(float scaleValue)
		{
		}

		public static void CopyRootMeshShatter(RayfireRigid source, List<RayfireRigid> targets)
		{
		}

		private void CopyFrom(RayfireShatter shatter)
		{
		}

		private void VertexLimitation()
		{
		}

		public RayfireShatter()
			: base()
		{
		}
	}
}
