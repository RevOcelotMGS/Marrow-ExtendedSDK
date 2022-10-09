using Assets.Marrow_ExtendedSDK.StubClasses;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.MLAgentsExamples;
using UnityEngine;

[RequireComponent(typeof(JointDriveController))]
public class ArmWormAgent : Agent
{
	public StatsRecorder statsRecorder;

	private int sensor_counter;

	public float jumpRewardOnly;

	public bool inference_switch;

	public GameObject arm_parent;

	public GameObject training_area;

	private const float m_MaxWalkingSpeed = 10f;

	[Header("Target Prefabs")]
	public Transform TargetPrefab;

	private Transform m_Target;

	[SerializeField]
	private float goal_height;

	[SerializeField]
	private float goal_impact;

	[SerializeField]
	private float target_move_speed;

	[SerializeField]
	private float target_move_radius;

	[SerializeField]
	private float target_scale;

	[Header("Body Parts")]
	public Transform bodySegment0;

	public Transform bodySegment1;

	public Transform bodySegment2;

	public PhysicMaterial high_friction;

	public PhysicMaterial low_friction;

	private float last_friction_val;

	public float jump_cd_time;

	public float jump_cd_max;

	private bool jump_cooldown;

	private ImpactTargetController target_controller;

	public OrientationCubeController m_OrientationCube;

	public GameObject forward_reference;

	private DirectionIndicator m_DirectionIndicator;

	private JointDriveController m_JdController;

	private Vector3 m_StartingPos;

	private float heur_temp;

	public bool shoulder_rotation;

	public float shoulder_rotation_value;

	public float shoulder_rot_lerp_scale;

	public bool elbow_x_rot_heur;

	public bool wrist_x_rot_heur;

	public bool wrist_y_rot_heur;

	public bool wrist_z_rot_heur;

	public bool friction_switch;


}
