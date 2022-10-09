using SLZ.Combat;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PuppetMasta
{
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Muscle Collision Broadcaster")]
	public class MuscleCollisionBroadcaster : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		private static ComponentCache<MuscleCollisionBroadcaster> _cache;

		[HideInInspector]
		[SerializeField]
		public PuppetMaster puppetMaster;

		[SerializeField]
		[HideInInspector]
		public int muscleIndex;

		private const string onMuscleHit = "OnMuscleHit";

		private const string onMuscleCollision = "OnMuscleCollision";

		private const string onMuscleCollisionExit = "OnMuscleCollisionExit";

		private MuscleCollisionBroadcaster otherBroadcaster;

		public static ComponentCache<MuscleCollisionBroadcaster> Cache
		{
			get
			{
				return null;
			}
		}

		protected virtual void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void Hit(Attack attack)
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		public virtual void OnCollisionEnter(Collision collision)
		{
		}

		public MuscleCollisionBroadcaster()
			: base()
		{
		}
	}
}
