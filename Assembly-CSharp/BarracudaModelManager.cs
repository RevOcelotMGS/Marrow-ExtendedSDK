using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Unity.Barracuda;
using UnityEngine;

public class BarracudaModelManager
{
	public GameObject agentPrefab;

	public GameObject area;

	public bool handle_placement;

	public int requested_rows;

	public float spacing;

	[HideInInspector]
	public bool exitWorker;

	public bool do_sim_update;

	public NNModel srcModel;

	public int nb_agents;

	public int nb_network_slices;

	public int nb_sim_steps;

	public int actionmask_size;

	public Transform target;

	public bool warm;

	public string[] string_obs_names;

	public string[] output_names;

	public Dictionary<string, Tensor> tensor_observation_dict;

	public Dictionary<string, float[]> float_observation_dict;

	public Dictionary<string, Tensor> tensor_action_dict;

	private float[] accept_all_action_mask;

	[HideInInspector]
	public int batch_size;

	public InferenceAgent[] agent_list;

	private Model model;

	private IWorker engine;

	public int nb_agents_collected;

	private int fixed_counter;

	private void FixedUpdate()
	{
	}

	public void AcceptAllActionMask()
	{
	}

	public void WarmStartModelManager(ModelManagerConfig bmmConfig)
	{
	}

	private void InitDictionaries()
	{
	}

	public void WarmUp()
	{
	}

	public UniTaskVoid Run(CancellationTokenSource cancelToken)
	{
		return default(UniTaskVoid);
	}

	public void Dispose()
	{
	}

	public BarracudaModelManager()
		: base()
	{
	}
}
