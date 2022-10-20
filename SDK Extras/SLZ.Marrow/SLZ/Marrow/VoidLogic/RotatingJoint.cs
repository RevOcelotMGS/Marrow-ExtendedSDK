using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Endpoints/VoidLogic Rotating Joint")]
	public sealed class RotatingJoint : MonoBehaviour, InputDescribable
	{
		[Tooltip("Previous node in the chain")]
		[SerializeField]
		private BaseNode _previousNode;

		private float _priorValue;

		[SerializeField]
		private ConfigurableJoint _configurableJoint;

		private Rigidbody _rigidBody;

		[SerializeField]
		[Header("Joint Control")]
		private bool _varyTargetRotation;

		[SerializeField]
		private float _minDegreesX;

		[SerializeField]
		private float _maxDegreesX;

		[SerializeField]
		private bool _varyTargetAngVelocity;

		[SerializeField]
		private Vector3 _minAngVelocity;

		[SerializeField]
		private Vector3 _maxAngVelocity;

		[SerializeField]
		private bool _varyAngularDrive;

		[SerializeField]
		private Vector3 _xAngMinSpringDamperForce;

		[SerializeField]
		private Vector3 _xAngMaxSpringDamperForce;

		private static readonly IReadOnlyList<InputDescription> _inputs;

		public BaseNode PreviousNode
		{
			get
			{
				return null;
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

		private void SETJOINT(float voltage = 1f)
		{
		}

		public void AppendEndpointInfo(StringBuilder sb)
		{
		}

		IReadOnlyList<InputDescription> InputDescribable.DescribeInputs()
		{
			return null;
		}

		public RotatingJoint()
			: base()
		{
		}
	}
}
