using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Interaction
{
	public class KeyReciever : InteractionReciever
	{
		[Flags]
		public enum Code
		{
			CODE_A = 1,
			CODE_B = 2,
			CODE_C = 4,
			CODE_D = 8,
			CODE_E = 0x10,
			CODE_F = 0x20,
			CODE_G = 0x40,
			CODE_H = 0x80,
			CODE_I = 0x100,
			CODE_J = 0x200,
			CODE_K = 0x400
		}

		private enum _States
		{
			EMPTY = 0,
			SWITCHING = 1,
			EJECTING = 2,
			HOVERING = 3,
			INSERTED = 4,
			SLIDING = 5
		}

		[Header("References")]
		public Transform startInsertTarget;

		public Transform endInsertTarget;

		public AudioClip[] insertClips;

		public AudioClip[] ejectClips;

		public Code code;

		[Tooltip("Keep the key in the reciever after it has been inserted")]
		public bool isKeyConsumed;

		public UnityEvent onUnlock;

		public UnityEvent onLock;

		[HideInInspector]
		public Action<Key> OnInserted;

		public Action OnRemoved;

		public Action<Key> OnKeyRemoved;

		private float _sqInsertDistance;

		private _States _State;

		private SphereCollider _sphereCollider;

		private HandJointConfiguration _handJointConfig;

		private InteractableHost _keyHost;

		private Key _key;

		private ConfigurableJoint _CartridgeJoint;

		private float _MovingPerc;

		private float _PercVelocity;

		private bool _isActive;

		private SimpleTransform _InsertTargetToHand;

		private SimpleTransform _HandToInsertTarget;

		private SimpleTransform _HandTargetTransform;

		private bool _WasMagazineGrabbed;

		private float _CartridgeGrabbedTime;

		private bool _IsHoverEject;

		private float _ActivePerc;

		private float _ActivePercVel;

		public static HashSet<IGrippable> ClaimedHosts { get; private set; }

		public bool hasCartridge
		{
			get
			{
				return default(bool);
			}
		}

		public InteractableHost GetHost()
		{
			return null;
		}

		private void CalculateMagazineRig(Transform insert, InteractableHost host)
		{
		}

		protected override void Awake()
		{
		}

		private void OnAttachedHandDelegate(Hand hand)
		{
		}

		private void OnDetachedHandDelegate(Hand hand)
		{
		}

		private void UpdateMagazineGrab(Hand hand)
		{
		}

		private void CreateJointConfig()
		{
		}

		public void SetHoverEject()
		{
		}

		private IEnumerator CoEjectMagazine(Action callback = default(Action))
		{
			return null;
		}

		private IEnumerator CoWaitLockMagazine()
		{
			return null;
		}

		private IEnumerator CoSelfDestructJoint(GameObject source, Rigidbody target, float time)
		{
			return null;
		}

		private void DestroyJoint()
		{
		}

		private void CreateJoint(Rigidbody rb)
		{
		}

		private void OnPreRealtimeRig()
		{
		}

		public override void OnInteractableHostEnter(InteractableHost host)
		{
		}

		public override void OnInteractableHostExit(InteractableHost host)
		{
		}

		public override void OnInteractableHostStay(InteractableHost host)
		{
		}

		private void MoveTowardsStartInsertTarget()
		{
		}

		private void SlideTowardsEndInsertTarget()
		{
		}

		private void MakeStatic()
		{
		}

		private void OnMagazineLocked()
		{
		}

		public void Release(Action callback)
		{
		}

		public void Release()
		{
		}

		private void OnMagazineGrabbed(InteractableHost host, Hand hand)
		{
		}

		private void OnMagazineUnlocked()
		{
		}

		private void MakeDynamic()
		{
		}

		public KeyReciever()
			: base()
		{
		}
	}
}
