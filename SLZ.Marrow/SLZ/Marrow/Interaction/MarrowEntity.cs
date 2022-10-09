using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Marrow.Interaction
{
	[SelectionBase]
	public class MarrowEntity : MarrowBehaviour
	{
		private static ComponentCache<MarrowEntity> _cache;

		[Header("Marrow Object")]
		[SerializeField]
		private MarrowBody[] _bodies;

		[SerializeField]
		private MarrowJoint[] _joints;

		[SerializeField]
		private Collider[] _staticColliders;

		[SerializeField]
		private MarrowBody _anchorBody;

		private SimpleTransform[] _teleportTransformCache;

		private SimpleTransform[] _snapshotPoseTransformCache;

		private bool _hasBeenDisabled;

		public UnityEvent OnFreeze;

		public UnityEvent OnUnfreeze;

		public static ComponentCache<MarrowEntity> Cache
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		public void ResetJoints()
		{
		}

		public void ResetBodies()
		{
		}

		private void SnapshotPose()
		{
		}

		private void ApplyPose()
		{
		}

		public void Teleport(Vector3 position, Quaternion rotation, bool doResetPose = false)
		{
		}

		public void Freeze()
		{
		}

		public void Unfreeze()
		{
		}

		public MarrowEntity()
			: base()
		{
		}
	}
}
