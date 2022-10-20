using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	public class AvatarProxy : BoneProxy
	{
		[InspectorDisplayName("Animator")]
		[SerializeField]
		[Header("Avatar Required Settings")]
		private Animator _proxyAnimator;

		[SerializeField]
		[Range(0.02f, 0.2f)]
		private float _headOffset;

		[SerializeField]
		[Tooltip("Neck Radius")]
		[Range(0.018f, 0.08f)]
		private float _neckRadius;

		[Tooltip("Horizontal Eye Depth Offset")]
		[Range(0f, 0.16f)]
		[SerializeField]
		[InspectorDisplayName("Eye Offset")]
		private float _eyeOffset;

		[Header("Avatar Optional Settings")]
		[InspectorDisplayName("Eye Center Override")]
		[SerializeField]
		private Transform _proxyEyeCenterOverride;

		[Header("Optional Bones")]
		[SerializeField]
		[InspectorDisplayName("Upper Neck")]
		private Transform _proxyUpperNeck;

		[SerializeField]
		[InspectorDisplayName("Scapula Left")]
		private Transform _proxyScapulaLeft;

		[InspectorDisplayName("Scapula Right")]
		[SerializeField]
		private Transform _proxyScapulaRight;

		[SerializeField]
		[Header("Optional Hand Bones")]
		[InspectorDisplayName("Wrist Left")]
		private Transform _proxyWristLeft;

		[SerializeField]
		[InspectorDisplayName("Wrist Right")]
		private Transform _proxyWristRight;

		[InspectorDisplayName("Carpal Left")]
		[SerializeField]
		private Transform _proxyCarpalLeft;

		[InspectorDisplayName("Carpal Right")]
		[SerializeField]
		private Transform _proxyCarpalRight;

		[InspectorDisplayName("Upper Arm Twist Left")]
		[SerializeField]
		[Header("Optional Arm Bones")]
		private Transform _proxyUpperArmTwistLeft;

		[InspectorDisplayName("Upper Arm Twist Right")]
		[SerializeField]
		private Transform _proxyUpperArmTwistRight;

		[InspectorDisplayName("Lower Arm Twist Left")]
		[SerializeField]
		private Transform _proxyLowerArmTwistLeft;

		[InspectorDisplayName("Lower Arm Twist Right")]
		[SerializeField]
		private Transform _proxyLowerArmTwistRight;

		[Header("Chest Values")]
		[Tooltip("Sternum Z / AvatarHeight")]
		[Range(0.02f, 0.3f)]
		[SerializeField]
		private float _sternumEllipseZ;

		[SerializeField]
		[Tooltip("Sternum Neg Z / AvatarHeight")]
		[Range(0.02f, 0.3f)]
		private float _sternumEllipseNegZ;

		[Tooltip("Chest Width on Z / AvatarHeight")]
		[SerializeField]
		[Range(0.02f, 0.3f)]
		private float _chestEllipseZ;

		[Tooltip("Chest Width on Neg Z / AvatarHeight")]
		[Range(0.02f, 0.3f)]
		[SerializeField]
		private float _chestEllipseNegZ;

		[Tooltip("Waist Width on Z / AvatarHeight")]
		[SerializeField]
		[Range(0.02f, 0.3f)]
		private float _waistEllipseZ;

		[Tooltip("Waist Width on Neg Z / AvatarHeight")]
		[SerializeField]
		[Range(0.02f, 0.3f)]
		private float _waistEllipseNegZ;

		[Tooltip("Hips Width on Z / AvatarHeight")]
		[Range(0.02f, 0.3f)]
		[SerializeField]
		private float _hipsEllipseZ;

		[Range(0.02f, 0.3f)]
		[Tooltip("Hips Width on Neg Z / AvatarHeight")]
		[SerializeField]
		private float _hipsEllipseNegZ;

		[SerializeField]
		[Range(0.04f, 0.3f)]
		[Tooltip("Chest Width on X / AvatarHeight. Default is .1")]
		private float _chestEllipseX;

		[SerializeField]
		[Range(0.04f, 0.3f)]
		[Tooltip("Waist Width on X / AvatarHeight. Default is .09")]
		private float _waistEllipseX;

		[SerializeField]
		[Range(0.04f, 0.3f)]
		[Tooltip("Hips Width on X / AvatarHeight. Default is .09")]
		private float _hipsEllipseX;

		public Animator Animator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float HeadOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float NeckRadius
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float EyeOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Transform EyeCenterOverride
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform UpperNeck
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform ScapulaLeft
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform ScapulaRight
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform WristLeft
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform WristRight
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform CarpalLeft
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform CarpalRight
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform UpperArmTwistLeft
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform UpperArmTwistRight
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform LowerArmTwistLeft
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform LowerArmTwistRight
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float SternumEllipseZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float SternumEllipseNegZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ChestEllipseZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ChestEllipseNegZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float WaistEllipseZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float WaistEllipseNegZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float HipsEllipseZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float HipsEllipseNegZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ChestEllipseX
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float WaistEllipseX
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float HipsEllipseX
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		protected override void SetupProperties()
		{
		}

		public AvatarProxy()
			: base()
		{
		}
	}
}
