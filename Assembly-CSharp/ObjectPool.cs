using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
	public static ObjectPool SharedInstance;

	public List<GameObject> pooledObjects;

	public GameObject objectToPool;

	public int amountToPool;

	public void GeneratePool(GameObject parent)
	{
	}

	private void Awake()
	{
	}

	public GameObject GetPooledObject()
	{
		return null;
	}

	public GameObject GetActiveObject()
	{
		return null;
	}

	public ObjectPool()
		: base()
	{
	}
}
