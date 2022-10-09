using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class HandReciever : MonoBehaviour
	{
		private static ComponentCache<HandReciever> _cache;

		private bool _isEnabled;

		[HideInInspector]
		private HandJointConfiguration _handJointConfig;

		public static ComponentCache<HandReciever> Cache
		{
			get
			{
				return null;
			}
		}

		public IGrippable Host { get; set; }

		public bool IsEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool IsFarHoverEnabled
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsStatic
		{
			get
			{
				return default(bool);
			}
		}

		public bool HasRigidbody
		{
			get
			{
				return default(bool);
			}
		}

		public bool HasHost
		{
			get
			{
				return default(bool);
			}
		}

		public HandJointConfiguration HandJointConfig
		{
			get
			{
				return null;
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public SimpleTransform GetHostTransform()
		{
			return default(SimpleTransform);
		}

		public virtual void DisableInteraction()
		{
		}

		public virtual void EnableInteraction()
		{
		}

		public virtual float ValidateGripScore(Hand hand, SimpleTransform handTransform)
		{
			return default(float);
		}

		public virtual void OnAttachedToHand(Hand hand)
		{
		}

		public virtual void OnJointAttached(Hand hand)
		{
		}

		public virtual void OnHandAttachedUpdate(Hand hand)
		{
		}

		public virtual void OnHandHoverEnd(Hand hand)
		{
		}

		public virtual void OnHandHoverBegin(Hand hand)
		{
		}

		public virtual void OnFarHandHoverEnd(Hand hand)
		{
		}

		public virtual void OnFarHandHoverBegin(Hand hand)
		{
		}

		public virtual void OnHandHoverUpdate(Hand hand)
		{
		}

		public virtual void OnFarHandHoverUpdate(Hand hand)
		{
		}

		public virtual void OnDetachedFromHand(Hand hand)
		{
		}

		public HandReciever()
			: base()
		{
		}
	}
}
