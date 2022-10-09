using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Slider")]
	public class SliderNode : BaseNode
	{
		[Tooltip("Output response curve (multiplied by input)")]
		[SerializeField]
		private AnimationCurve _curve;

		[Min(0f)]
		[Tooltip("Slider Types:\n0 => Free\n1 => Momentary\n2+ => Stepped")]
		[SerializeField]
		private int _steps;

		[Tooltip("Slider joint that drives the output power value")]
		[SerializeField]
		private ConfigurableJoint _sliderConfigurableJoint;

		[Tooltip("Intearactable host i.e. for running haptics")]
		[SerializeField]
		private InteractableHost _interactableHost;

		[SerializeField]
		[Header("Force")]
		private float force_Spring;

		[SerializeField]
		private float force_Damper;

		[SerializeField]
		private float force_Max;

		[Header("Audio")]
		[SerializeField]
		private AudioMixerGroup _mixerGroup;

		[SerializeField]
		private AudioClip clip_clickOn;

		[SerializeField]
		private AudioClip clip_clickOff;

		private Haptor _haptor;

		private bool _canHaptic;

		private bool _sliderThresholdHit;

		private float _localPowerValue;

		private static readonly IReadOnlyList<InputDescription> _inputs;

		public ConfigurableJoint SliderConfigurableJoint
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Rigidbody SliderRigidBody { get; private set; }

		public Haptor Haptor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void SLIDERCHECK(bool canSound = false)
		{
		}

		protected override float CalculateValue()
		{
			return default(float);
		}

		private void HAPTOUT()
		{
		}

		public override void AppendNodeInfo(StringBuilder sb)
		{
		}

		public override IReadOnlyList<InputDescription> DescribeInputs()
		{
			return null;
		}

		public SliderNode()
			: base()
		{
		}
	}
}
