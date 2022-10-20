using Assets.Marrow_ExtendedSDK.StubClasses;
using System;
using System.Collections.Generic;
using UnityEngine;

public class InferenceAgent : MonoBehaviour
{
	public string vector_obs_str;

	public int agent_number;

	public int nb_stacked_obs;

	public int observation_size;

	public int nb_stacked_ray_obs;

	public int action_size;

	public Tensor obs;

	public float[] input_data;

	public float[] current_input;

	public float[] last_input;

	public float[] new_stack;

	public BaseInferenceSensor[] inferenceSensors;

	public GameObject training_area;

	public bool inference_switch;

	public int obs_counter;

	public bool actions_between_decisions;

	public bool do_prestep;

	public Transform TargetPrefab;

	public bool activelyManaged;

	public Dictionary<string, float[]> actionDict;

	public BarracudaModelManagerMono cuda_manager;

	public Action<int> recycleAction;

	public void VecToTensor(Vector3 vec)
	{
	}

	public void QuatToTensor(Quaternion quat)
	{
	}

	protected virtual void Start()
	{
	}

	public virtual void Setup()
	{
	}

	public virtual void OnActionReceived(Dictionary<string, float[]> actionBuffers)
	{
	}

	public virtual void CollectObservations()
	{
	}

	public void RecycleAgent()
	{
	}

	public InferenceAgent()
		: base()
	{
	}
}
