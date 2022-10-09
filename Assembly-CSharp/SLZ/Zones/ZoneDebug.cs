using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Zones
{
	public class ZoneDebug : MonoBehaviour
	{
		public Grip triggerGrip;

		public Mesh boxMeshInv;

		public Mesh sphereMesh;

		public Material material;

		private Matrix4x4[] _boxMatrices;

		private Matrix4x4[] _iconMatrices;

		private Matrix4x4[] _matricesFinal;

		private int _itemCount;

		private MaterialPropertyBlock _properties;

		private Vector4[] _colors;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public ZoneDebug()
			: base()
		{
		}
	}
}
