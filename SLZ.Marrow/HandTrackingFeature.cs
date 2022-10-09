using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Assets.Marrow_ExtendedSDK.StubClasses;
using Steam.VR.Features;
using UnityEngine;

public class HandTrackingFeature : OpenXRFeature
{
	public enum HandIndex
	{
		L = 0,
		R = 1
	}

	internal delegate int Type_xrCreateHandTrackerEXT(ulong session, [In] XrHandTrackerCreateInfoEXT createInfo, [Out] ulong tracker);

	internal delegate int Type_xrDestroyHandTrackerEXT(ulong tracker);

	internal delegate int Type_xrLocateHandJointsEXT(ulong tracker, [In] XrHandJointsLocateInfoEXT locateInfoEXT, XrHandJointLocationsEXT locations);

	internal delegate int Type_xrWaitFrame(ulong session, [In] XrFrameWaitInfo waitInfo, XrFrameState state);

	internal struct XrFrameWaitInfo
	{
		private int stype;

		private IntPtr next;
	}

	internal struct XrFrameState
	{
		private int stype;

		private IntPtr next;

		public long predictedDisplayTime;

		public long predictedDisplayPeriod;

		public int shouldRender;
	}

	internal struct XrHandJointsLocateInfoEXT
	{
		private int stype;

		private IntPtr next;

		private ulong space;

		private long time;

		public XrHandJointsLocateInfoEXT(ulong space, long time)
		{
			this.time = default(long);
			this.space = default(ulong);
			this.next = default(IntPtr);
			this.stype = default(int);
		}
	}

	private enum XrSpaceLocationFlags
	{
		XR_SPACE_LOCATION_ORIENTATION_VALID_BIT = 1,
		XR_SPACE_LOCATION_POSITION_VALID_BIT = 2,
		XR_SPACE_LOCATION_ORIENTATION_TRACKED_BIT = 4,
		XR_SPACE_LOCATION_POSITION_TRACKED_BIT = 8
	}

	internal struct XrHandJointLocationEXT
	{
		public ulong locationFlags;

		public XrPosef pose;

		public float radius;
	}

	internal struct XrHandJointLocationsEXT
	{
		private int stype;

		private IntPtr next;

		private int isActive;

		private uint jointCount;

		private IntPtr jointLocations;

		public XrHandJointLocationsEXT(XrHandJointLocationEXT[] jointArray)
		{
			this.jointLocations = default(IntPtr);
			this.jointCount = default(uint);
			this.isActive = default(int);
			this.next = default(IntPtr);
			this.stype = default(int);
		}

		public void Unpin()
		{
		}
	}

	internal struct XrHandTrackerCreateInfoEXT
	{
		private int stype;

		private IntPtr next;

		private int hand;

		private int handJointSet;

		public XrHandTrackerCreateInfoEXT(int hand)
		{
			this.handJointSet = default(int);
			this.hand = default(int);
			this.next = default(IntPtr);
			this.stype = default(int);
		}
	}

	internal struct XrPosef
	{
		public XrVector4f orientation;

		public XrVector3f position;
	}

	internal struct XrVector2f
	{
		public float x;

		public float y;
	}

	internal struct XrVector3f
	{
		public float x;

		public float y;

		public float z;
	}

	internal struct XrVector4f
	{
		public float x;

		public float y;

		public float z;

		public float w;
	}

	internal struct XrVector4sFB
	{
		public short x;

		public short y;

		public short z;

		public short w;
	}

	internal class HandMeshArrays
	{
		public XrPosef[] jointBindPoses;

		public float[] jointRadii;

		public int[] jointParents;

		public XrVector3f[] vertexPositions;

		public XrVector3f[] vertexNormals;

		public XrVector2f[] vertexUVs;

		public XrVector4sFB[] vertexBlendIndices;

		public XrVector4f[] vertexBlendWeights;

		public short[] indices;

		private GCHandle[] gcPins;

		public HandMeshArrays(uint joints, uint vertices, uint indexCount, XrHandTrackingMeshFB owner)
			: base()
		{
		}

		~HandMeshArrays()
		{
		}
	}

	internal struct XrHandTrackingMeshFB
	{
		private int stype;

		private IntPtr next;

		public uint jointCapacityInput;

		public uint jointCountOutput;

		public IntPtr jointBindPoses;

		public IntPtr jointRadii;

		public IntPtr jointParents;

		public uint vertexCapacityInput;

		public uint vertexCountOutput;

		public IntPtr vertexPositions;

		public IntPtr vertexNormals;

		public IntPtr vertexUVs;

		public IntPtr vertexBlendIndices;

		public IntPtr vertexBlendWeights;

		public uint indexCapacityInput;

		public uint indexCountOutput;

		public IntPtr indices;

		public XrHandTrackingMeshFB(uint joints, uint vertices, uint indexCount)
		{
			this.indices = default(IntPtr);
			this.indexCountOutput = default(uint);
			this.indexCapacityInput = default(uint);
			this.vertexBlendWeights = default(IntPtr);
			this.vertexBlendIndices = default(IntPtr);
			this.vertexUVs = default(IntPtr);
			this.vertexNormals = default(IntPtr);
			this.vertexPositions = default(IntPtr);
			this.vertexCountOutput = default(uint);
			this.vertexCapacityInput = default(uint);
			this.jointParents = default(IntPtr);
			this.jointRadii = default(IntPtr);
			this.jointBindPoses = default(IntPtr);
			this.jointCountOutput = default(uint);
			this.jointCapacityInput = default(uint);
			this.next = default(IntPtr);
			this.stype = default(int);
		}

		public HandMeshArrays GetArrays()
		{
			return null;
		}
	}

	internal delegate int Type_xrGetHandMeshFB(ulong handTracker, XrHandTrackingMeshFB mesh);

	private static HandTrackingFeature m_Singleton;

	private Vector3[] _positions;

	private Quaternion[] _rotations;

	private float[] _radius;

	public const string featureId = "com.joemarshall.handtracking";

	private Type_xrGetInstanceProcAddr mOldProc;

	private Type_xrWaitFrame mOldWaitFrame;

	private ulong curr_instanceid;

	private ulong curr_session;

	private long frame_time;

	private ulong handle_left;

	private ulong handle_right;

	private static GCHandle pinnedJointArray;

	private List<Delegate> callbacks;

	private static Dictionary<XrHandTrackingMeshFB, HandMeshArrays> hand_mesh_pinned_arrays;

	~HandTrackingFeature()
	{
	}

	private Vector3 PosToUnity(XrVector3f pos)
	{
		return default(Vector3);
	}

	private Quaternion OrientationToUnity(XrVector4f ori)
	{
		return default(Quaternion);
	}

	protected IntPtr GetCallback<T>(T functionAddr) where T : Delegate
	{
		return default(IntPtr);
	}

	protected override IntPtr HookGetInstanceProcAddr(IntPtr func)
	{
		return default(IntPtr);
	}

	public T GetInstanceProc<T>(string procName) where T : Delegate
	{
		return null;
	}

	[MonoPInvokeCallback(typeof(Type_xrGetInstanceProcAddr))]
	private static int xrGetInstanceProcAddr_HOOK_STATIC(ulong instance, string name, [Out] IntPtr function)
	{
		return default(int);
	}

	private int xrGetInstanceProcAddr_HOOK(ulong instance, string name, [Out] IntPtr function)
	{
		return default(int);
	}

	[MonoPInvokeCallback(typeof(Type_xrWaitFrame))]
	private static int xrWaitFrame_HOOK_STATIC(ulong session, [In] XrFrameWaitInfo waitInfo, XrFrameState state)
	{
		return default(int);
	}

	private int xrWaitFrame_HOOK(ulong session, [In] XrFrameWaitInfo waitInfo, XrFrameState state)
	{
		return default(int);
	}

	protected override void OnSessionBegin(ulong session)
	{
	}

	protected override void OnSessionEnd(ulong session)
	{
	}

	protected override void OnSessionDestroy(ulong xrSession)
	{
	}

	private void closeHandTracker()
	{
	}

	protected override bool OnInstanceCreate(ulong xrInstance)
	{
		return default(bool);
	}

	protected override void OnInstanceDestroy(ulong xrInstance)
	{
	}

	public void GetHandJoints(HandIndex hand, [Out] Vector3[] positions, [Out] Quaternion[] orientations, [Out] float[] radius)
	{
	}

	public void GetHandMesh(HandIndex hand, Transform parent, Material mat, [Out] GameObject handObj)
	{
	}

	public void ApplyHandJointsToMesh(HandIndex hand, GameObject handObj, float r1, float r2, float r3)
	{
	}

	public HandTrackingFeature()
		: base()
	{
	}
}
