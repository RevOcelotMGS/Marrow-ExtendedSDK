using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Environment
{
	public class JointSleeper : MonoBehaviour
	{
		public ConfigurableJoint joint;

		public Rigidbody rb;

		private HandJointConfiguration _handJointConfiguration;

		public bool sleepOnAwake;

		private void Awake()
		{
		}

		public void Sleep()
		{
		}

		public void Wakeup()
		{
		}

		private void Update()
		{
		}

		public JointSleeper()
			: base()
		{
		}
	}
}
