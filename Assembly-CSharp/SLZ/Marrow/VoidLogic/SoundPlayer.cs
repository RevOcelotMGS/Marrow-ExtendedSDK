using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Endpoints/VoidLogic Sound Player")]
	public class SoundPlayer : MonoBehaviour, InputDescribable
	{
		[SerializeField]
		[Tooltip("Previous node in the chain")]
		private BaseNode _previousNode;

		[SerializeField]
		private AnimationCurve _curve;

		private float _priorValue;

		protected bool _wasOn;

		[Header("Audio")]
		[SerializeField]
		private AudioMixerGroup _mixerGroup;

		[SerializeField]
		private AudioClip _onSound;

		[SerializeField]
		private AudioClip _offSound;

		private static readonly IReadOnlyList<InputDescription> _inputs;

		public BaseNode PreviousNode
		{
			get
			{
				return null;
			}
		}

		private void Update()
		{
		}

		public void AppendEndpointInfo(StringBuilder sb)
		{
		}

		IReadOnlyList<InputDescription> InputDescribable.DescribeInputs()
		{
			return null;
		}

		public SoundPlayer()
			: base()
		{
		}
	}
}
