using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace RayFire
{
	[DisallowMultipleComponent]
	[AddComponentMenu("RayFire/Rayfire Man")]
	[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-man-component/")]
	public class RayfireMan : MonoBehaviour
	{
		public static RayfireMan inst;

		public static int buildMajor;

		public static int buildMinor;

		public bool setGravity;

		public float multiplier;

		public RigidbodyInterpolation interpolation;

		public float colliderSize;

		public static float colliderSizeStatic;

		[FormerlySerializedAs("collisionDetection")]
		public CollisionDetectionMode meshCollision;

		public CollisionDetectionMode clusterCollision;

		public float minimumMass;

		public float maximumMass;

		public RFMaterialPresets materialPresets;

		public GameObject parent;

		public float globalSolidity;

		public float timeQuota;

		public RFManDemolition advancedDemolitionProperties;

		public RFPoolingFragment fragments;

		public RFPoolingParticles particles;

		public Transform transForm;

		public List<string> layers;

		public RFStorage storage;

		public float maxTimeThisFrame;

		public HashSet<string> layersHash;

		public static bool MaxAmountCheck
		{
			get
			{
				return default(bool);
			}
		}

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private void Reset()
		{
		}

		private void SetInstance()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		private void SetVariables()
		{
		}

		private void SetGravity()
		{
		}

		public static void RayFireManInit()
		{
		}

		private void SetLayers()
		{
		}

		private void SetPooling()
		{
		}

		private void SetStorage()
		{
		}

		public static void SetParentByManager(Transform tm, Transform original, bool noRegister = false)
		{
		}

		public static void SetParentToManager(Transform tm)
		{
		}

		public static void SetParentByManager(Transform tm)
		{
		}

		public static void DestroyFragment(RayfireRigid scr, Transform tm, float time = 0f)
		{
		}

		public static void DestroyShard(RayfireRigidRoot scr, RFShard shard)
		{
		}

		public static void DestroyGo(GameObject go)
		{
		}

		private static void DestroyOp(RayfireRigid scr, Transform tm, float time = 0f)
		{
		}

		public RayfireMan()
			: base()
		{
		}
	}
}
