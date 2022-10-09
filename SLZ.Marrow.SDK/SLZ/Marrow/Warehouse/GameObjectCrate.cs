using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using SLZ.Serialize;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Marrow.Warehouse
{
	public class GameObjectCrate : CrateT<GameObject>
	{
		[SerializeField]
		[FormerlySerializedAs("_assetReference")]
		private MarrowGameObject _mainAsset;

		[SerializeField]
		private MarrowAssetT<Mesh> _previewMesh;

		[SerializeField]
		private bool _customQuality;

		[Range(0f, 1f)]
		[SerializeField]
		private float _previewMeshQuality;

		[SerializeField]
		[Range(0f, 5f)]
		private int _maxLODLevel;

		[SerializeField]
		public Bounds _colliderBounds;

		public override MarrowAsset MainAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MarrowGameObject MainGameObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MarrowAssetT<Mesh> PreviewMesh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool CustomQuality
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float PreviewMeshQuality
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public int MaxLODLevel
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public Bounds ColliderBounds
		{
			get
			{
				return default(Bounds);
			}
			set
			{
			}
		}

		public override List<PackedAsset> CollectPackedAssets()
		{
			return null;
		}

		public override void Pack(ObjectStore store, JObject json)
		{
		}

		public override void Unpack(ObjectStore store, ObjectId objectId)
		{
		}

		public GameObjectCrate()
			: base()
		{
		}
	}
}
