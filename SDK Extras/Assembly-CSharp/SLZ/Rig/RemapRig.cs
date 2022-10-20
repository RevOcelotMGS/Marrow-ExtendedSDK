using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class RemapRig : HeptaRig
	{
		[Header("RemapHeptaRig")]
		public Transform testGazeTarget;

		private float _lfCurlLerp;

		private float _rtCurlLerp;

		public override void Reset()
		{
		}

		public override void OnAwake()
		{
		}

		public override void OnStart()
		{
		}

		public override void OnFirstFixedUpdate()
		{
		}

		public override void OnFixedUpdate(float deltaTime)
		{
		}

		public override void OnUpdate()
		{
		}

		public override void Teleport(Vector3 displace, bool zeroVelocity = false)
		{
		}

		public override void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		private void UpdateHeptaBody(Rig inRig, float deltaTime, Vector2 velocity, Vector2 accel)
		{
		}

		public RemapRig()
			: base()
		{
		}
	}
}
