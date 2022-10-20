using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.AI;
using SLZ.Marrow.Utilities;
using SLZ.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class InteractableHost : ObjectCleanupEvents, IGrippable
	{
		private static ComponentCache<InteractableHost> _cache;

		public InteractableHostManager manager;

		public bool ignoreBodyOnGrab;

		private ConfigurableJoint _bodyJoint;

		private ConfigurableJoint _spineJoint;

		private ConfigurableJoint _chestJoint;

		private ConfigurableJoint _headJoint;

		private Hand _lastHand;

		private List<Grip> _grips;

		private List<ForcePullGrip> _fpGrips;

		private RigidbodyData _rbData;

		private Rigidbody _rb;

		public Action<InteractableHost, Hand> onHandAttachedDelegate;

		public Action<InteractableHost, Hand> onHandDetachedDelegate;

		private List<Hand> _hands;

		private Coroutine checkForSleepCoroutine;

		public new static ComponentCache<InteractableHost> Cache
		{
			get
			{
				return null;
			}
		}

		public VirtualController VirtualController { get; private set; }

		public TriggerRefProxy LastGrabbedProxy { get; private set; }

		public Collider[] Colliders { get; private set; }

		public bool IsInteractionDisabled { get; private set; }

		public bool IsFarHoverEnabled { get; private set; }

		public bool IsStatic { get; set; }

		public bool HasRigidbody { get; private set; }

		public Rigidbody Rb
		{
			get
			{
				return null;
			}
		}

		public bool IsAttached
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsPulling
		{
			get
			{
				return default(bool);
			}
		}

		private void Reset()
		{
		}

		public SimpleTransform GetHostTransform()
		{
			return default(SimpleTransform);
		}

		public Transform GetTransform()
		{
			return null;
		}

		public GameObject GetHostGameObject()
		{
			return null;
		}

		public override void Awake()
		{
		}

		private void DecorateHostOnChildGrips(Transform t)
		{
		}

		private void OnEnable()
		{
		}

		public override void OnDestroy()
		{
		}

		public void RemoveProxy()
		{
		}

		public void SetProxy(GameObject proxyObject)
		{
		}

		public void DisableColliders()
		{
		}

		public void EnableColliders()
		{
		}

		public void DisableInteraction()
		{
		}

		public void DisableFarHover()
		{
		}

		public void EnableFarHover()
		{
		}

		public void EnableInteraction()
		{
		}

		public void DestroyJoints()
		{
		}

		public void DestroyRigidbody()
		{
		}

		public void CreateRigidbody()
		{
		}

		public void AttachHand(Hand hand)
		{
		}

		public void DetachHand(Hand hand)
		{
		}

		public Hand GetHand(int idx = 0)
		{
			return null;
		}

		public void ClearAttachedHandsForDespawn()
		{
		}

		public Hand GetLastHand()
		{
			return null;
		}

		public int HandCount()
		{
			return default(int);
		}

		public void ForceDetach()
		{
		}

		public Grip GetGrip()
		{
			return null;
		}

		public ForcePullGrip GetForcePullGrip()
		{
			return null;
		}

		private IEnumerator CoCheckForSleep()
		{
			return null;
		}

		public override void OnCleanup()
		{
		}

		public InteractableHost()
			: base()
		{
		}
	}
}
