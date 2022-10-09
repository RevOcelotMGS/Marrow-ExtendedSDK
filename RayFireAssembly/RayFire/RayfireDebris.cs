using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RayFire
{
	[SelectionBase]
	[AddComponentMenu("RayFire/Rayfire Debris")]
	[HelpURL("http://rayfirestudios.com/unity-online-help/components/unity-debris-component/")]
	public class RayfireDebris : MonoBehaviour
	{
		[Header("  Emit Debris")]
		public bool onDemolition;

		[Space(1f)]
		public bool onActivation;

		[Space(1f)]
		public bool onImpact;

		[Header("  Main")]
		[Space(3f)]
		public GameObject debrisReference;

		[Space(2f)]
		public Material debrisMaterial;

		[Space(2f)]
		public Material emissionMaterial;

		[Header("  Properties")]
		[Space(3f)]
		public RFParticleEmission emission;

		[Space(3f)]
		public RFParticleDynamicDebris dynamic;

		[Space(3f)]
		public RFParticleNoise noise;

		[Space(3f)]
		public RFParticleCollisionDebris collision;

		[Space(3f)]
		public RFParticleLimitations limitations;

		[Space(3f)]
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
		public List<Mesh> debrisMeshList;

		[HideInInspector]
		public Vector3 refScale;

		[HideInInspector]
		public List<RayfireDebris> children;

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

		public void CopyFrom(RayfireDebris source)
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

		public void CreateDebris(RayfireDebris scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
		{
		}

		private void SetParticleRendererDebris(ParticleSystemRenderer rend, RayfireDebris scr)
		{
		}

		private void SetReferenceMeshes(GameObject refs)
		{
		}

		private void SetDebrisMaterial(List<MeshFilter> mfs)
		{
		}

		public RayfireDebris()
			: base()
		{
		}
	}
}
