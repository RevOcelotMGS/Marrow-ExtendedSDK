using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.VRMK
{
	public class LiteLoco : MonoBehaviour
	{
		[Serializable]
		public class StepGroup
		{
			public Transform pelvis;

			public int sisterStepGroup;

			public float legLength;

			[Tooltip("Tries to maintain this distance between the legs.")]
			public AnimationCurve FootXVCurve;

			[SerializeField]
			private int _gear;

			public bool computeAnimCycle;

			public bool visualizeAnimCycle;

			public float animCycle;

			public Gear[] gears;

			public Grounder grounder;

			public Footstep[] footsteps;

			private bool wasStepping;

			private float _lastAnimCycle;

			public int _Gear
			{
				get
				{
					return default(int);
				}
			}

			public void Initiate(HashSet<Rigidbody> selfRbs, StepGroup sisterGroup = default(StepGroup))
			{
			}

			public void Reset()
			{
			}

			public void SetStep(int step, Vector3 position, Quaternion rotation, bool isWorld = false)
			{
			}

			public void SetStance(int step, Vector3 position, float rotationOffset = 0f)
			{
			}

			public float GetMuscleUsage(int step)
			{
				return default(float);
			}

			public void Solve(Transform root, Vector3 localPos, Quaternion localRot, float weight, Vector3 accelOffset, float accelMag, float rotDelta)
			{
			}

			private bool CanStep()
			{
				return default(bool);
			}

			public void UpdateAnimCycle(float stepRate)
			{
			}

			public StepGroup()
				: base()
			{
			}
		}

		[Serializable]
		public class Gear
		{
			[Tooltip("Velocity Threshold to upshift to next gear if existent")]
			public float upshiftVel;

			[Tooltip("Velocity Threshold to downshift to previous gear if existent")]
			public float downshiftVel;

			[Tooltip("Percentage of previous step completion before another can be triggered 0-1f")]
			[Range(0f, 1f)]
			public float stepProgressThreshold;

			[Tooltip("Blend of how much step is behind and in front of neutral point")]
			[Range(0f, 1f)]
			public float stepfromtoWeight;

			public float minStepThreshold;

			public AnimationCurve StepRateVCurve;

			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			public AnimationCurve StepZInterp;

			public AnimationCurve StepAnkleBend;

			public AnimationCurve MuscleUsage;

			public Gear()
				: base()
			{
			}
		}

		[Serializable]
		public class Grounder
		{
			[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
			public LayerMask layers;

			[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
			public float maxStep;

			[Tooltip("The speed of moving the feet up/down.")]
			public float footSpeed;

			private HashSet<Rigidbody> _selfRbs;

			public void SetSelfRbs(HashSet<Rigidbody> selfRbs)
			{
			}

			public float GetWorldY(Vector3 origin)
			{
				return default(float);
			}

			public Grounder()
				: base()
			{
			}
		}

		[Serializable]
		public class Footstep
		{
			private float _stepRate;

			private Vector3 _positionLocal;

			private Vector3 _stepFromLocal;

			private Vector3 _stepToLocal;

			private float _stepToRot;

			private float _stepFromRot;

			private float _rotationFloat;

			public Transform hip;

			public Transform foot;

			public Transform neutralTarget;

			public float rotationOffset;

			public Collider footCollider;

			public PhysicMaterial liftedMat;

			public FootstepSFX stepSfx;

			private Vector3 _localVelocity;

			private Vector3 _stepLz;

			private Footstep _sisterStep;

			private PhysicMaterial _groundedMat;

			private bool _isLifted;

			private Grounder grounder;

			private bool _wasGrounded;

			private float _lerpedGrounderOffset;

			public bool isStepping
			{
				get
				{
					return default(bool);
				}
			}

			public float stepProgress { get; private set; }

			public float grounderOffset { get; set; }

			public Footstep(Grounder g, Transform hipTran, Transform footTran, Transform neutralTran)
				: base()
			{
			}

			public void Initiate(Grounder g, Footstep sisterStep = default(Footstep))
			{
			}

			public void Reset(Vector3 position, Quaternion rotation, bool isWorld = false)
			{
			}

			public void SetStance(Vector3 positionLocal, float rotationOff = 0f)
			{
			}

			public void PrepStep(Transform root, Gear gear, Vector3 localPos, Quaternion localRot, float stepRateUpdate, Vector3 accelOffset, float rotDelta, float neutralX)
			{
			}

			public float CalculateStepDistance(Gear gear, float legLength, float bestValue, float accelMag)
			{
				return default(float);
			}

			public void StartStep(float stepRateUpdate)
			{
			}

			public void Update(Gear gear, float velocityMag, float weight)
			{
			}

			public float CheckGround()
			{
				return default(float);
			}

			private void SetPhysMat(bool isLifted)
			{
			}
		}

		[Range(0f, 1f)]
		[Tooltip("Used for blending in/out of procedural locomotion.")]
		public float weight;

		public Transform root;

		public Transform neutralRoot;

		public StepGroup[] stepGroups;

		private Vector3 _velocity;

		public Vector3 accelOffset { get; private set; }

		public void Initiate(HashSet<Rigidbody> selfRbs)
		{
		}

		public void Reset(Vector3 initialVelocity)
		{
		}

		public void SetStep(int stepGroup, int foot, Vector3 positionWorld, Quaternion rotationWorld)
		{
		}

		public void SetStance(int stepGroup, int foot, Vector3 positionLocal, float rotationOffset = 0f)
		{
		}

		public float GetMuscleUsage(int stepGroup, int step)
		{
			return default(float);
		}

		public void UpdateLiteLoco(Vector3 worldVelocity, float rotDelta, bool accelOffsetY = true)
		{
		}

		public void UpdateStepgroupPelvis(Vector3 localPos, Quaternion localRot, int stepGroup = 0)
		{
		}

		public LiteLoco()
			: base()
		{
		}
	}
}
