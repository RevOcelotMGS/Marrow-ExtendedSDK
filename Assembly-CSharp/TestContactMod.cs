using Unity.Collections;
using UnityEngine;

public class TestContactMod : MonoBehaviour
{
	public Collider col;

	public Rigidbody rb;

	public float maxDepth;

	public float minForce;

	public float maxForce;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void ModificationCallback(PhysicsScene scene, NativeArray<ModifiableContactPair> contactPairs)
	{
	}

	public TestContactMod()
		: base()
	{
	}
}
