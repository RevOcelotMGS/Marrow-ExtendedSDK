using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class ExplosionDemo : MonoBehaviour
	{
		public SimpleLocomotion character;

		public float forceMlp;

		public float upForce;

		public float weightFalloffSpeed;

		public AnimationCurve weightFalloff;

		public AnimationCurve explosionForceByDistance;

		public AnimationCurve scale;

		private float weight;

		private Vector3 defaultScale;

		private Rigidbody r;

		private FullBodyBipedIK ik;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void SetEffectorWeights(float w)
		{
		}

		public ExplosionDemo()
			: base()
		{
		}
	}
}
