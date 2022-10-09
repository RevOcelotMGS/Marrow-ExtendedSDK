using System;
using System.Runtime.InteropServices;

public static class OVRPlugin
{
	[StructLayout(LayoutKind.Sequential)]
	private class GUID
	{
		public int a;

		public short b;

		public short c;

		public byte d0;

		public byte d1;

		public byte d2;

		public byte d3;

		public byte d4;

		public byte d5;

		public byte d6;

		public byte d7;

		public GUID()
			: base()
		{
		}
	}

	public enum Bool
	{
		False = 0,
		True = 1
	}

	public enum Result
	{
		Success = 0,
		Success_EventUnavailable = 1,
		Success_Pending = 2,
		Failure = -1000,
		Failure_InvalidParameter = -1001,
		Failure_NotInitialized = -1002,
		Failure_InvalidOperation = -1003,
		Failure_Unsupported = -1004,
		Failure_NotYetImplemented = -1005,
		Failure_OperationFailed = -1006,
		Failure_InsufficientSize = -1007,
		Failure_DataIsInvalid = -1008,
		Failure_DeprecatedOperation = -1009
	}

	public enum XrApi
	{
		Unknown = 0,
		CAPI = 1,
		VRAPI = 2,
		OpenXR = 3,
		EnumSize = int.MaxValue
	}

	public enum Node
	{
		None = -1,
		EyeLeft = 0,
		EyeRight = 1,
		EyeCenter = 2,
		HandLeft = 3,
		HandRight = 4,
		TrackerZero = 5,
		TrackerOne = 6,
		TrackerTwo = 7,
		TrackerThree = 8,
		Head = 9,
		DeviceObjectZero = 10,
		TrackedKeyboard = 11,
		Count = 12
	}

	public enum Step
	{
		Render = -1,
		Physics = 0
	}

	public enum FixedFoveatedRenderingLevel
	{
		Off = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		HighTop = 4,
		EnumSize = int.MaxValue
	}

	public struct Vector2f
	{
		public float x;

		public float y;
	}

	public struct Vector3f
	{
		public float x;

		public float y;

		public float z;

		public static readonly Vector3f zero;

		public override string ToString()
		{
			return null;
		}
	}

	public struct Quatf
	{
		public float x;

		public float y;

		public float z;

		public float w;

		public static readonly Quatf identity;

		public override string ToString()
		{
			return null;
		}
	}

	public struct Posef
	{
		public Quatf Orientation;

		public Vector3f Position;

		public static readonly Posef identity;

		public override string ToString()
		{
			return null;
		}
	}

	public struct PoseStatef
	{
		public Posef Pose;

		public Vector3f Velocity;

		public Vector3f Acceleration;

		public Vector3f AngularVelocity;

		public Vector3f AngularAcceleration;

		public double Time;

		public static readonly PoseStatef identity;
	}

	public struct ControllerState4
	{
		public uint ConnectedControllers;

		public uint Buttons;

		public uint Touches;

		public uint NearTouches;

		public float LIndexTrigger;

		public float RIndexTrigger;

		public float LHandTrigger;

		public float RHandTrigger;

		public Vector2f LThumbstick;

		public Vector2f RThumbstick;

		public Vector2f LTouchpad;

		public Vector2f RTouchpad;

		public byte LBatteryPercentRemaining;

		public byte RBatteryPercentRemaining;

		public byte LRecenterCount;

		public byte RRecenterCount;

		public byte Reserved_27;

		public byte Reserved_26;

		public byte Reserved_25;

		public byte Reserved_24;

		public byte Reserved_23;

		public byte Reserved_22;

		public byte Reserved_21;

		public byte Reserved_20;

		public byte Reserved_19;

		public byte Reserved_18;

		public byte Reserved_17;

		public byte Reserved_16;

		public byte Reserved_15;

		public byte Reserved_14;

		public byte Reserved_13;

		public byte Reserved_12;

		public byte Reserved_11;

		public byte Reserved_10;

		public byte Reserved_09;

		public byte Reserved_08;

		public byte Reserved_07;

		public byte Reserved_06;

		public byte Reserved_05;

		public byte Reserved_04;

		public byte Reserved_03;

		public byte Reserved_02;

		public byte Reserved_01;

		public byte Reserved_00;

		public ControllerState4(ControllerState2 cs)
		{
			this.Reserved_00 = default(byte);
			this.Reserved_01 = default(byte);
			this.Reserved_02 = default(byte);
			this.Reserved_03 = default(byte);
			this.Reserved_04 = default(byte);
			this.Reserved_05 = default(byte);
			this.Reserved_06 = default(byte);
			this.Reserved_07 = default(byte);
			this.Reserved_08 = default(byte);
			this.Reserved_09 = default(byte);
			this.Reserved_10 = default(byte);
			this.Reserved_11 = default(byte);
			this.Reserved_12 = default(byte);
			this.Reserved_13 = default(byte);
			this.Reserved_14 = default(byte);
			this.Reserved_15 = default(byte);
			this.Reserved_16 = default(byte);
			this.Reserved_17 = default(byte);
			this.Reserved_18 = default(byte);
			this.Reserved_19 = default(byte);
			this.Reserved_20 = default(byte);
			this.Reserved_21 = default(byte);
			this.Reserved_22 = default(byte);
			this.Reserved_23 = default(byte);
			this.Reserved_24 = default(byte);
			this.Reserved_25 = default(byte);
			this.Reserved_26 = default(byte);
			this.Reserved_27 = default(byte);
			this.RRecenterCount = default(byte);
			this.LRecenterCount = default(byte);
			this.RBatteryPercentRemaining = default(byte);
			this.LBatteryPercentRemaining = default(byte);
			this.RTouchpad = default(Vector2f);
			this.LTouchpad = default(Vector2f);
			this.RThumbstick = default(Vector2f);
			this.LThumbstick = default(Vector2f);
			this.RHandTrigger = default(float);
			this.LHandTrigger = default(float);
			this.RIndexTrigger = default(float);
			this.LIndexTrigger = default(float);
			this.NearTouches = default(uint);
			this.Touches = default(uint);
			this.Buttons = default(uint);
			this.ConnectedControllers = default(uint);
		}
	}

	public struct ControllerState2
	{
		public uint ConnectedControllers;

		public uint Buttons;

		public uint Touches;

		public uint NearTouches;

		public float LIndexTrigger;

		public float RIndexTrigger;

		public float LHandTrigger;

		public float RHandTrigger;

		public Vector2f LThumbstick;

		public Vector2f RThumbstick;

		public Vector2f LTouchpad;

		public Vector2f RTouchpad;

		public ControllerState2(ControllerState cs)
		{
			this.RTouchpad = default(Vector2f);
			this.LTouchpad = default(Vector2f);
			this.RThumbstick = default(Vector2f);
			this.LThumbstick = default(Vector2f);
			this.RHandTrigger = default(float);
			this.LHandTrigger = default(float);
			this.RIndexTrigger = default(float);
			this.LIndexTrigger = default(float);
			this.NearTouches = default(uint);
			this.Touches = default(uint);
			this.Buttons = default(uint);
			this.ConnectedControllers = default(uint);
		}
	}

	public struct ControllerState
	{
		public uint ConnectedControllers;

		public uint Buttons;

		public uint Touches;

		public uint NearTouches;

		public float LIndexTrigger;

		public float RIndexTrigger;

		public float LHandTrigger;

		public float RHandTrigger;

		public Vector2f LThumbstick;

		public Vector2f RThumbstick;
	}

	public enum TrackingConfidence
	{
		Low = 0,
		High = 1065353216
	}

	public enum Hand
	{
		None = -1,
		HandLeft = 0,
		HandRight = 1
	}

	[Flags]
	public enum HandStatus
	{
		HandTracked = 1,
		InputStateValid = 2,
		SystemGestureInProgress = 0x40,
		DominantHand = 0x80,
		MenuPressed = 0x100
	}

	public enum BoneId
	{
		Invalid = -1,
		Hand_Start = 0,
		Hand_WristRoot = 0,
		Hand_ForearmStub = 1,
		Hand_Thumb0 = 2,
		Hand_Thumb1 = 3,
		Hand_Thumb2 = 4,
		Hand_Thumb3 = 5,
		Hand_Index1 = 6,
		Hand_Index2 = 7,
		Hand_Index3 = 8,
		Hand_Middle1 = 9,
		Hand_Middle2 = 10,
		Hand_Middle3 = 11,
		Hand_Ring1 = 12,
		Hand_Ring2 = 13,
		Hand_Ring3 = 14,
		Hand_Pinky0 = 15,
		Hand_Pinky1 = 16,
		Hand_Pinky2 = 17,
		Hand_Pinky3 = 18,
		Hand_MaxSkinnable = 19,
		Hand_ThumbTip = 19,
		Hand_IndexTip = 20,
		Hand_MiddleTip = 21,
		Hand_RingTip = 22,
		Hand_PinkyTip = 23,
		Hand_End = 24,
		Max = 50
	}

	[Flags]
	public enum HandFingerPinch
	{
		Thumb = 1,
		Index = 2,
		Middle = 4,
		Ring = 8,
		Pinky = 0x10
	}

	public struct HandState
	{
		public HandStatus Status;

		public Posef RootPose;

		public Quatf[] BoneRotations;

		public HandFingerPinch Pinches;

		public float[] PinchStrength;

		public Posef PointerPose;

		public float HandScale;

		public TrackingConfidence HandConfidence;

		public TrackingConfidence[] FingerConfidences;

		public double RequestedTimeStamp;

		public double SampleTimeStamp;
	}

	private struct HandStateInternal
	{
		public HandStatus Status;

		public Posef RootPose;

		public Quatf BoneRotations_0;

		public Quatf BoneRotations_1;

		public Quatf BoneRotations_2;

		public Quatf BoneRotations_3;

		public Quatf BoneRotations_4;

		public Quatf BoneRotations_5;

		public Quatf BoneRotations_6;

		public Quatf BoneRotations_7;

		public Quatf BoneRotations_8;

		public Quatf BoneRotations_9;

		public Quatf BoneRotations_10;

		public Quatf BoneRotations_11;

		public Quatf BoneRotations_12;

		public Quatf BoneRotations_13;

		public Quatf BoneRotations_14;

		public Quatf BoneRotations_15;

		public Quatf BoneRotations_16;

		public Quatf BoneRotations_17;

		public Quatf BoneRotations_18;

		public Quatf BoneRotations_19;

		public Quatf BoneRotations_20;

		public Quatf BoneRotations_21;

		public Quatf BoneRotations_22;

		public Quatf BoneRotations_23;

		public HandFingerPinch Pinches;

		public float PinchStrength_0;

		public float PinchStrength_1;

		public float PinchStrength_2;

		public float PinchStrength_3;

		public float PinchStrength_4;

		public Posef PointerPose;

		public float HandScale;

		public TrackingConfidence HandConfidence;

		public TrackingConfidence FingerConfidences_0;

		public TrackingConfidence FingerConfidences_1;

		public TrackingConfidence FingerConfidences_2;

		public TrackingConfidence FingerConfidences_3;

		public TrackingConfidence FingerConfidences_4;

		public double RequestedTimeStamp;

		public double SampleTimeStamp;
	}

	public struct BoneCapsule
	{
		public short BoneIndex;

		public Vector3f StartPoint;

		public Vector3f EndPoint;

		public float Radius;
	}

	public struct Bone
	{
		public BoneId Id;

		public short ParentBoneIndex;

		public Posef Pose;
	}

	public enum SkeletonType
	{
		None = -1,
		HandLeft = 0,
		HandRight = 1
	}

	public struct Skeleton
	{
		public SkeletonType Type;

		public uint NumBones;

		public uint NumBoneCapsules;

		public Bone[] Bones;

		public BoneCapsule[] BoneCapsules;
	}

	public struct Skeleton2
	{
		public SkeletonType Type;

		public uint NumBones;

		public uint NumBoneCapsules;

		public Bone[] Bones;

		public BoneCapsule[] BoneCapsules;
	}

	private struct Skeleton2Internal
	{
		public SkeletonType Type;

		public uint NumBones;

		public uint NumBoneCapsules;

		public Bone Bones_0;

		public Bone Bones_1;

		public Bone Bones_2;

		public Bone Bones_3;

		public Bone Bones_4;

		public Bone Bones_5;

		public Bone Bones_6;

		public Bone Bones_7;

		public Bone Bones_8;

		public Bone Bones_9;

		public Bone Bones_10;

		public Bone Bones_11;

		public Bone Bones_12;

		public Bone Bones_13;

		public Bone Bones_14;

		public Bone Bones_15;

		public Bone Bones_16;

		public Bone Bones_17;

		public Bone Bones_18;

		public Bone Bones_19;

		public Bone Bones_20;

		public Bone Bones_21;

		public Bone Bones_22;

		public Bone Bones_23;

		public Bone Bones_24;

		public Bone Bones_25;

		public Bone Bones_26;

		public Bone Bones_27;

		public Bone Bones_28;

		public Bone Bones_29;

		public Bone Bones_30;

		public Bone Bones_31;

		public Bone Bones_32;

		public Bone Bones_33;

		public Bone Bones_34;

		public Bone Bones_35;

		public Bone Bones_36;

		public Bone Bones_37;

		public Bone Bones_38;

		public Bone Bones_39;

		public Bone Bones_40;

		public Bone Bones_41;

		public Bone Bones_42;

		public Bone Bones_43;

		public Bone Bones_44;

		public Bone Bones_45;

		public Bone Bones_46;

		public Bone Bones_47;

		public Bone Bones_48;

		public Bone Bones_49;

		public BoneCapsule BoneCapsules_0;

		public BoneCapsule BoneCapsules_1;

		public BoneCapsule BoneCapsules_2;

		public BoneCapsule BoneCapsules_3;

		public BoneCapsule BoneCapsules_4;

		public BoneCapsule BoneCapsules_5;

		public BoneCapsule BoneCapsules_6;

		public BoneCapsule BoneCapsules_7;

		public BoneCapsule BoneCapsules_8;

		public BoneCapsule BoneCapsules_9;

		public BoneCapsule BoneCapsules_10;

		public BoneCapsule BoneCapsules_11;

		public BoneCapsule BoneCapsules_12;

		public BoneCapsule BoneCapsules_13;

		public BoneCapsule BoneCapsules_14;

		public BoneCapsule BoneCapsules_15;

		public BoneCapsule BoneCapsules_16;

		public BoneCapsule BoneCapsules_17;

		public BoneCapsule BoneCapsules_18;
	}

	public enum ColorSpace
	{
		Unknown = 0,
		Unmanaged = 1,
		Rec_2020 = 2,
		Rec_709 = 3,
		Rift_CV1 = 4,
		Rift_S = 5,
		Quest = 6,
		P3 = 7,
		Adobe_RGB = 8
	}

	private static class OVRP_0_1_0
	{
		public static readonly Version version;
	}

	private static class OVRP_0_1_2
	{
		public static readonly Version version;

		public static extern Posef ovrp_GetNodePose(Node nodeId);

		public static extern Bool ovrp_SetControllerVibration(uint controllerMask, float frequency, float amplitude);
	}

	private static class OVRP_0_5_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_1_0
	{
		public static readonly Version version;

		public static extern Bool ovrp_GetInitialized();

		private static extern IntPtr _ovrp_GetVersion();

		public static string ovrp_GetVersion()
		{
			return null;
		}

		public static extern Bool ovrp_GetNodePositionTracked(Node nodeId);

		public static extern ControllerState ovrp_GetControllerState(uint controllerMask);

		private static extern IntPtr _ovrp_GetSystemProductName();

		public static string ovrp_GetSystemProductName()
		{
			return null;
		}

		public static extern float ovrp_GetUserIPD();
	}

	private static class OVRP_1_3_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_8_0
	{
		public static readonly Version version;

		public static extern Posef ovrp_GetNodePose2(int stateId, Node nodeId);
	}

	private static class OVRP_1_12_0
	{
		public static readonly Version version;

		public static extern PoseStatef ovrp_GetNodePoseState(Step stepId, Node nodeId);

		public static extern ControllerState2 ovrp_GetControllerState2(uint controllerMask);
	}

	private static class OVRP_1_16_0
	{
		public static readonly Version version;

		public static extern Result ovrp_GetControllerState4(uint controllerMask, ControllerState4 controllerState);
	}

	private static class OVRP_1_18_0
	{
		public static readonly Version version;

		public static extern Result ovrp_GetAppHasInputFocus([Out] Bool appHasInputFocus);
	}

	private static class OVRP_1_21_0
	{
		public static readonly Version version;

		public static extern Result ovrp_GetTiledMultiResSupported([Out] Bool foveationSupported);

		public static extern Result ovrp_SetTiledMultiResLevel(FixedFoveatedRenderingLevel level);
	}

	private static class OVRP_1_38_0
	{
		public static readonly Version version;

		public static extern Result ovrp_GetNodePositionValid(Node nodeId, Bool nodePositionValid);
	}

	private static class OVRP_1_44_0
	{
		public static readonly Version version;

		public static extern Result ovrp_GetHandState(Step stepId, Hand hand, [Out] HandStateInternal handState);

		public static extern Result ovrp_GetSkeleton(SkeletonType skeletonType, [Out] Skeleton skeleton);
	}

	private static class OVRP_1_46_0
	{
		public static readonly Version version;

		public static extern Result ovrp_SetTiledMultiResDynamic(Bool isDynamic);
	}

	private static class OVRP_1_49_0
	{
		public static readonly Version version;

		public static extern Result ovrp_SetClientColorDesc(ColorSpace colorSpace);
	}

	private static class OVRP_1_55_0
	{
		public static readonly Version version;

		public static extern Result ovrp_GetSkeleton2(SkeletonType skeletonType, [Out] Skeleton2Internal skeleton);

		public static extern Result ovrp_GetNativeXrApiType([Out] XrApi xrApi);
	}

	private static class OVRP_1_69_0
	{
		public static readonly Version version;
	}

	public static readonly Version wrapperVersion;

	private static Version _version;

	private static XrApi? _nativeXrApi;

	private static GUID _nativeAudioOutGuid;

	private static GUID _nativeAudioInGuid;

	private static bool perfStatWarningPrinted;

	private static bool resetPerfStatWarningPrinted;

	private static OVRNativeBuffer _nativeSystemDisplayFrequenciesAvailable;

	private static float[] _cachedSystemDisplayFrequenciesAvailable;

	private static HandStateInternal cachedHandState;

	private static Skeleton cachedSkeleton;

	private static Skeleton2Internal cachedSkeleton2;

	private static Version _versionZero;

	public static Version version
	{
		get
		{
			return null;
		}
	}

	public static bool initialized
	{
		get
		{
			return default(bool);
		}
	}

	public static XrApi nativeXrApi
	{
		get
		{
			return default(XrApi);
		}
	}

	public static bool hasInputFocus
	{
		get
		{
			return default(bool);
		}
	}

	public static string productName
	{
		get
		{
			return null;
		}
	}

	public static float ipd
	{
		get
		{
			return default(float);
		}
	}

	public static bool fixedFoveatedRenderingSupported
	{
		get
		{
			return default(bool);
		}
	}

	public static FixedFoveatedRenderingLevel fixedFoveatedRenderingLevel
	{
		set
		{
		}
	}

	public static bool useDynamicFixedFoveatedRendering
	{
		set
		{
		}
	}

	public static Posef GetNodePose(Node nodeId, Step stepId)
	{
		return default(Posef);
	}

	public static bool GetNodePositionTracked(Node nodeId)
	{
		return default(bool);
	}

	public static bool GetNodePositionValid(Node nodeId)
	{
		return default(bool);
	}

	public static ControllerState2 GetControllerState2(uint controllerMask)
	{
		return default(ControllerState2);
	}

	public static ControllerState4 GetControllerState4(uint controllerMask)
	{
		return default(ControllerState4);
	}

	public static bool SetControllerVibration(uint controllerMask, float frequency, float amplitude)
	{
		return default(bool);
	}

	public static bool GetHandState(Step stepId, Hand hand, HandState handState)
	{
		return default(bool);
	}

	public static bool GetSkeleton(SkeletonType skeletonType, [Out] Skeleton skeleton)
	{
		return default(bool);
	}

	public static bool GetSkeleton2(SkeletonType skeletonType, Skeleton2 skeleton)
	{
		return default(bool);
	}

	public static bool SetClientColorDesc(ColorSpace colorSpace)
	{
		return default(bool);
	}
}
