using Assets.Marrow_ExtendedSDK.StubClasses;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class TurretAgentSelfPlay : TurretAgent
{
	private float episodeLength;

	private Rigidbody _rb;

	private bool canShoot;

	private float shootCoolDown;

	private Vector3 bulletSpawnLoc;

	private int barrelLayerMask_1;

	private int barrelLayerMask_2;

	private int barrelLayerMask_3;

	private new int finalMask;

	private RaycastHit barrelOnTarget;

	private float lookingAtTarget;

	public TurretAreaSelfPlay turretArea_SP;

	private void Start()
	{
	}

	public override void OnMiss()
	{
	}

	private void TurretReset()
	{
	}

	public override void OnEpisodeBegin()
	{
	}

	private void FixedUpdate()
	{
	}

	private float CheckBarrelRay()
	{
		return default(float);
	}

	private void RecenterTurret()
	{
	}

	public void OnWin()
	{
	}

	public void OnLoss()
	{
	}

	public void OnTie()
	{
	}

	private void ManageCoolDown()
	{
	}

	public override void CollectObservations(VectorSensor sensor)
	{
	}

	public override void Heuristic([In] ActionBuffers actionBuffers)
	{
	}

	public override void OnActionReceived(ActionBuffers actionBuffers)
	{
	}

	private void ShootBullet()
	{
	}

	private float NormRot(float rot)
	{
		return default(float);
	}

	private void MovementSignal(float x_val, float y_val)
	{
	}

	public TurretAgentSelfPlay()
		: base()
	{
	}
}
