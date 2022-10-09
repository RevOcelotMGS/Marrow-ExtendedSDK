using System.Collections.Generic;
using UnityEngine;

namespace RayFire.DotNet
{
	public class sl_element_mesh_par_params
	{
		public int numElems;

		public int sbc;

		public Mesh origMesh;

		public int InnerFacesSubMeshID;

		public Transform transform;

		public List<Dictionary<int, int>> OrigSubMeshIDs;

		public Mesh[] out_mesh;

		public Vector3[] pivots;

		public sl_element_mesh_par_params()
			: base()
		{
		}
	}
}
