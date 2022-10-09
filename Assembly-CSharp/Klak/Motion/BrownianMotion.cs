using UnityEngine;

namespace Klak.Motion
{
	[AddComponentMenu("Klak/Motion/Brownian Motion")]
	public class BrownianMotion : MonoBehaviour
	{
		[SerializeField]
		private bool _enablePositionNoise;

		[SerializeField]
		private bool _enableRotationNoise;

		[SerializeField]
		private float _positionFrequency;

		[SerializeField]
		private float _rotationFrequency;

		[SerializeField]
		private float _positionAmplitude;

		[SerializeField]
		private float _rotationAmplitude;

		[SerializeField]
		private Vector3 _positionScale;

		[SerializeField]
		private Vector3 _rotationScale;

		[Range(0f, 8f)]
		[SerializeField]
		private int _positionFractalLevel;

		[SerializeField]
		[Range(0f, 8f)]
		private int _rotationFractalLevel;

		private const float _fbmNorm = 1.3333334f;

		private Vector3 _initialPosition;

		private Quaternion _initialRotation;

		private float[] _time;

		public bool enablePositionNoise
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool enableRotationNoise
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float positionFrequency
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float rotationFrequency
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float positionAmplitude
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float rotationAmplitude
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Vector3 positionScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 rotationScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public int positionFractalLevel
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int rotationFractalLevel
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public void Rehash()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		public BrownianMotion()
			: base()
		{
		}
	}
}
