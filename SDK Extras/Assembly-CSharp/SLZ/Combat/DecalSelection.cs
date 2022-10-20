using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Combat
{
	public class DecalSelection : MonoBehaviour
	{

		[SerializeField]
		private GameObject LightCone;

		[HideInInspector]
		public ImpactProperties SurfaceProperties;


		private void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		public void PickDecal()
		{
		}


		private void OnDisable()
		{
		}

		public DecalSelection()
			: base()
		{
		}
	}
}
