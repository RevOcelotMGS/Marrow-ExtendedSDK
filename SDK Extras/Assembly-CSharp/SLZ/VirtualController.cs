using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ
{
	[Serializable]
	public class VirtualController
	{
		private const float displaceSoftLimitArmLengths = 0.18f;

		private const float displaceHardLimitArmLengths = 0.58f;

		private const float angDisplaceSoftLimitDegrees = 16f;

		private const float angDisplaceHardLimitDegrees = 142f;

		private float _twistWindup;

		[Header("Virtual Controller Settings")]
		public VirtualControllerSettings defaultSettings;

		private SimpleTransform _hostOffset;

		private Vector3 _acceleration;

		private Vector3 _velocity;

		private float _artificialDelta;

		private float _artDelVelocity;

		private float _artificialDeltaAng;

		private float _artDelAngVelocity;

		private float _blend;

		[HideInInspector]
		public SimpleTransform overrideVCTransform;

		public Action OnPreSolve;

		public Action<SimpleTransform> OnVirtualControllerSolve;

		private static float targRotDeltaSpeed;

		private Quaternion _priLastTargRotDelta;

		private Quaternion _secLastTargRotDelta;

		private bool _priSnapshot;

		private bool _secSnapshot;

		private bool _isDoubleVCFirstPass;

		private bool _isSingleVCFirstPass;

		private HandGripPair _priPair;

		private HandGripPair _secPair;

		private bool _hasDoubleVCBeenCalled;

		private bool _hasSingleVCBeenCalled;

		private VirtualControlerPayload _vcPayload;

		private Dictionary<Grip, VirtualControllerOverride> _vcOverrides;

		private VirtualControllerOverride _staticVCOverride;

		private VirtualControllerOverride _lastVCOverride;

		private SimpleTransform _lastBlendTransform;

		private Dictionary<Hand, float> _desyncTime;

		private Quaternion _priLocalDelta;

		private Quaternion _secLocalDelta;

		private Quaternion _lastPriContHandleRot;

		private Quaternion _lastSecContHandle;

		private SimpleTransform _lastVCTransform;

		private bool _twistInverted;

		public VirtualControllerSettings Settings { get; private set; }

		public List<HandGripPair> HandGripPairs { get; }

		public void AttachPair(Hand hand, Grip grip)
		{
		}

		public void DetachPair(Hand hand)
		{
		}

		private bool CheckHandDesync(HandGripPair pair, SimpleTransform contHandle, SimpleTransform rigHandle)
		{
			return default(bool);
		}

		public bool FetchGrips([Out] HandGripPair primary)
		{
			return default(bool);
		}

		public bool FetchGrips([Out] HandGripPair primary, [Out] HandGripPair secondary)
		{
			return default(bool);
		}

		public void AddVCOverride(Grip grip, VirtualControllerOverride vcOverride)
		{
		}

		public void RemoveVCOverride(Grip grip, VirtualControllerOverride vcOverride)
		{
		}

		private bool GetVirtualControllerOverride(Grip primary, Grip secondary, [Out] VirtualControllerOverride vcOverride)
		{
			return default(bool);
		}

		private bool ContainsVirtualControllerOverride(Grip primary)
		{
			return default(bool);
		}

		private bool GetVirtualControllerOverride(Grip primary, [Out] VirtualControllerOverride vcOverride)
		{
			return default(bool);
		}

		public void CalcBlendOffset(HandGripPair pair)
		{
		}

		public SimpleTransform HandleBlendOffset(bool isFirstPass, bool isSingleHanded, SimpleTransform vcInWorld, SimpleTransform rigInHost, [Out] float rotDelta)
		{
			return default(SimpleTransform);
		}

		public void BlendTargetRotationOffset(bool isOverrideBlend = false, float overrideRotDelta = 0f)
		{
		}

		public static Quaternion SynthesizeRotation(Vector3 right, Vector3 up)
		{
			return default(Quaternion);
		}

		private void DrawVC(SimpleTransform rigTransform, SimpleTransform priTarget, SimpleTransform secTarget, Color color, string text, int offset)
		{
		}

		public void Solve()
		{
		}

		public VirtualController()
			: base()
		{
		}
	}
}
