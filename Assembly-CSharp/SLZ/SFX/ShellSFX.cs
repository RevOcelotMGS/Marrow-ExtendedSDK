using SLZ.Data;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.SFX
{
	public class ShellSFX : MonoBehaviour
	{
		public AudioMixerGroup outputMixer;

		public AudioVarianceData impact;

		public AudioVarianceData eject;

		public AudioVarianceData ejectSlowmo;

		public float minVelocity;

		private const float _lowPitchRange = 0.88f;

		private const float _highPitchRange = 1.12f;

		private const float _velToVol = 0.08f;

		private float _minVelSquared;

		private bool _isHeavy;

		private bool _isPlastic;

		public bool spatialize;

		private float _lastImpactTime;

		private void Awake()
		{
		}

		private void Initialize()
		{
		}

		private void Start()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		public void ImpactSound(Collision c)
		{
		}

		public void ShellEject()
		{
		}

		private void CallBack(GameObject go)
		{
		}

		public ShellSFX()
			: base()
		{
		}
	}
}
