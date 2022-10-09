using System;
using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
	[AddComponentMenu("RayFire/Rayfire Rigid")]
	[SelectionBase]
	[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-rigid-component/")]
	[DisallowMultipleComponent]
	public class RayfireRigid : MonoBehaviour
	{
		public enum InitType
		{
			ByMethod = 0,
			AtStart = 1
		}

		public InitType initialization;

		public SimType simulationType;

		public ObjectType objectType;

		public DemolitionType demolitionType;

		public RFPhysic physics;

		public RFActivation activation;

		public RFLimitations limitations;

		public RFDemolitionMesh meshDemolition;

		public RFDemolitionCluster clusterDemolition;

		public RFReferenceDemolition referenceDemolition;

		public RFSurface materials;

		public RFDamage damage;

		public RFFade fading;

		public RFReset reset;

		public bool initialized;

		public bool corState;

		public Mesh[] meshes;

		public Vector3[] pivots;

		public RFMesh[] rfMeshes;

		public List<RFDictionary> subIds;

		public List<RayfireRigid> fragments;

		public Quaternion cacheRotation;

		public Transform transForm;

		public Transform rootChild;

		public Transform rootParent;

		public MeshFilter meshFilter;

		public MeshRenderer meshRenderer;

		public SkinnedMeshRenderer skinnedMeshRend;

		public List<RayfireDebris> debrisList;

		public List<RayfireDust> dustList;

		public RayfireRestriction restriction;

		public RayfireSound sound;

		[NonSerialized]
		public RayfireRigidRoot rigidRoot;

		public RFDemolitionEvent demolitionEvent;

		public RFActivationEvent activationEvent;

		public RFRestrictionEvent restrictionEvent;

		public bool HasFragments
		{
			get
			{
				return default(bool);
			}
		}

		public bool HasMeshes
		{
			get
			{
				return default(bool);
			}
		}

		public bool HasRfMeshes
		{
			get
			{
				return default(bool);
			}
		}

		public bool HasDebris
		{
			get
			{
				return default(bool);
			}
		}

		public bool HasDust
		{
			get
			{
				return default(bool);
			}
		}

		public bool HasSlices
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsCluster
		{
			get
			{
				return default(bool);
			}
		}

		public float AmountIntegrity
		{
			get
			{
				return default(float);
			}
		}

		private void Awake()
		{
		}

		public void Initialize()
		{
		}

		private void AwakeMethods()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		public void EditorSetup()
		{
		}

		public void ResetSetup()
		{
		}

		public void SetComponentsBasic()
		{
		}

		private void SetComponentsPhysics()
		{
		}

		private void EditorSetupMeshRoot()
		{
		}

		private bool SetupMeshRoot()
		{
			return default(bool);
		}

		private void MeshRootCheck()
		{
		}

		private void AddMeshRootRigid()
		{
		}

		private void InitConnectivity()
		{
		}

		private void ResetMeshRootSetup()
		{
		}

		private void SetObjectType()
		{
		}

		public void Default()
		{
		}

		private void SetPhysics()
		{
		}

		public void StartAllCoroutines()
		{
		}

		public void InactiveCors()
		{
		}

		public void MeshInput()
		{
		}

		protected virtual void OnCollisionEnter(Collision collision)
		{
		}

		protected virtual bool CollisionDemolition(Collision collision)
		{
			return default(bool);
		}

		public bool State()
		{
			return default(bool);
		}

		public virtual bool DemolitionState()
		{
			return default(bool);
		}

		public void Demolish()
		{
		}

		public void CopyPropertiesTo(RayfireRigid toScr)
		{
		}

		public void InitMeshFragments()
		{
		}

		public void Prefragment()
		{
		}

		public void DeleteCache()
		{
		}

		public void DeleteFragments()
		{
		}

		public void AddSlicePlane(Vector3[] slicePlane)
		{
		}

		public void Slice()
		{
		}

		public void CacheFrames()
		{
		}

		[ContextMenu("SaveInitTransform")]
		public void SaveInitTransform()
		{
		}

		public bool ApplyDamage(float damageValue, Vector3 damagePoint, float damageRadius = 0f)
		{
			return default(bool);
		}

		public void Activate(bool connCheck = true)
		{
		}

		public void Fade()
		{
		}

		public void ResetRigid()
		{
		}

		public void DestroyCollider(Collider col)
		{
		}

		public void DestroyObject(GameObject go)
		{
		}

		public void DestroyRigid(RayfireRigid rigid)
		{
		}

		public void DestroyRb(Rigidbody rb)
		{
		}

		public RayfireRigid()
			: base()
		{
		}
	}
}
