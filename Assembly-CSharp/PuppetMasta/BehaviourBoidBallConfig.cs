using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourBoidBallConfig : BaseEnemyConfig
	{
		[SerializeField]
		private float state_lerp_rate;

		[SerializeField]
		private float rest_goal_min;

		[SerializeField]
		private float rest_goal_max;

		[SerializeField]
		private float rest_prox_min;

		[SerializeField]
		private float rest_prox_max;

		[SerializeField]
		private float rest_lerp_speed_min;

		[SerializeField]
		private float rest_lerp_speed_max;

		[SerializeField]
		private float rest_height;

		[SerializeField]
		private float roam_goal_min;

		[SerializeField]
		private float roam_goal_max;

		[SerializeField]
		private float roam_prox_min;

		[SerializeField]
		private float roam_prox_max;

		[SerializeField]
		private float roam_lerp_speed_min;

		[SerializeField]
		private float roam_lerp_speed_max;

		[SerializeField]
		private float roam_height;

		[SerializeField]
		private float investigate_goal_min;

		[SerializeField]
		private float investigate_goal_max;

		[SerializeField]
		private float investigate_prox_min;

		[SerializeField]
		private float investigate_prox_max;

		[SerializeField]
		private float investigate_lerp_speed_min;

		[SerializeField]
		private float investigate_lerp_speed_max;

		[SerializeField]
		private float investigate_height;

		[SerializeField]
		private float agro_goal_min;

		[SerializeField]
		private float agro_goal_max;

		[SerializeField]
		private float agro_prox_min;

		[SerializeField]
		private float agro_prox_max;

		[SerializeField]
		private float agro_lerp_speed_min;

		[SerializeField]
		private float agro_lerp_speed_max;

		[SerializeField]
		private float agro_height;

		public void ApplyToBall(BehaviourBoidBall ball)
		{
		}

		public BehaviourBoidBallConfig()
			: base()
		{
		}
	}
}
