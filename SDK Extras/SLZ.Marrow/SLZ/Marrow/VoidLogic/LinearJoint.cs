using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Endpoints/VoidLogic Linear Joint (Sliding)")]
	public sealed class LinearJoint : MonoBehaviour, InputDescribable
	{
		[SerializeField]
		[Tooltip("Previous node in the chain")]
		private BaseNode _previousNode;

		private float _priorValue;

		[SerializeField]
		private bool _warpOnStart;

		[SerializeField]
		private ConfigurableJoint _configurableJoint;

		private Rigidbody _rigidBody;

		[SerializeField]
		[Header("Joint Control")]
		private bool _varyTargetPosition;

		[SerializeField]
		private float _additiveTargetPosMultiplier;

		[SerializeField]
		private Vector3 _minPosition;

		[SerializeField]
		private Vector3 _maxPosition;

		[SerializeField]
		private bool _varyTargetVelocity;

		[SerializeField]
		private Vector3 _minVelocity;

		[SerializeField]
		private Vector3 _maxVelocity;

		[SerializeField]
		private bool _varyPrismaticDrive;

		[SerializeField]
		private Vector3 _xMinSpringDamperForce;

		[SerializeField]
		private Vector3 _xMaxSpringDamperForce;

		[SerializeField]
		private bool _varyPrismaticY;

		[SerializeField]
		private Vector3 _yMinSpringDamperForce;

		[SerializeField]
		private Vector3 _yMaxSpringDamperForce;

		[SerializeField]
		private bool _varyPrismaticZ;

		[SerializeField]
		private Vector3 _zMinSpringDamperForce;

		[SerializeField]
		private Vector3 _zMaxSpringDamperForce;

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

		private void WarpJoint()
		{
		}

		public void AppendEndpointInfo(StringBuilder sb)
		{
		}

		IReadOnlyList<InputDescription> InputDescribable.DescribeInputs()
		{
			return null;
		}

		public LinearJoint()
			: base()
		{
		}
	}
}
