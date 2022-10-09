using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
	[SelectionBase]
	[AddComponentMenu("RayFire/Rayfire Dust")]
	[HelpURL("http://rayfirestudios.com/unity-online-help/components/unity-dust-component/")]
	public class RayfireDust : MonoBehaviour
	{
		[Header("  Emit Dust")]
		public bool onDemolition;

		[Space(1f)]
		public bool onActivation;

		[Space(1f)]
		public bool onImpact;

		[Header("  Main")]
		[Range(0.01f, 1f)]
		[Space(3f)]
		public float opacity;

		[Space(2f)]
		public Material dustMaterial;

		[Space(2f)]
		public List<Material> dustMaterials;

		[Space(2f)]
		public Material emissionMaterial;

		[Header("  Properties")]
		[Space(3f)]
		public RFParticleEmission emission;

		[Space(2f)]
		public RFParticleDynamicDust dynamic;

		[Space(2f)]
		public RFParticleNoise noise;

		[Space(2f)]
		public RFParticleCollisionDust collision;

		[Space(2f)]
		public RFParticleLimitations limitations;

		[Space(2f)]
		public RFParticleRendering rendering;

		[HideInInspector]
		public RayfireRigid rigid;

		[HideInInspector]
		public ParticleSystem pSystem;

		[HideInInspector]
		public Transform hostTm;

		[HideInInspector]
		public bool initialized;

		[HideInInspector]
		public List<RayfireDust> children;

		[HideInInspector]
		public int amountFinal;

		[HideInInspector]
		public bool oldChild;

		public bool HasChildren
		{
			get
			{
				return default(bool);
			}
		}

		public bool HasMaterials
		{
			get
			{
				return default(bool);
			}
		}

		public void CopyFrom(RayfireDust source)
		{
		}

		public void Initialize()
		{
		}

		public ParticleSystem Emit()
		{
			return null;
		}

		public void Clean()
		{
		}

		public void CreateDust(RayfireDust scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
		{
		}

		private void SetParticleRendererDust(ParticleSystemRenderer rend, RayfireDust scr)
		{
		}

		private void SetMaterialDust(ParticleSystemRenderer rend, List<Material> mats)
		{
		}

		public RayfireDust()
			: base()
		{
		}
	}
}
