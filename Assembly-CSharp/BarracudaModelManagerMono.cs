using Assets.Marrow_ExtendedSDK.StubClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BarracudaModelManagerMono : MonoBehaviour
{
	[Tooltip("The neural network to do inference with")]
	[Header("Model/Inference Pipeline Specific")]
	public NNModel srcModel;

	[Tooltip("How many layers to operate on per BMM output tick")]
	public int nb_network_slices;

	[Tooltip("Whether to allow for extra steps in the decision request pipeline for the simulation to update before next observation is made")]
	public bool do_sim_update;

	[Tooltip("How many steps to use that updates the sim state before next observation is made")]
	public int nb_sim_steps;

	[Tooltip("Size of input for nn")]
	public int observationSize;

	[Tooltip("Names of the different outputs to reference when agents are trying to get their actions")]
	public string[] output_names;

	[Tooltip("Size of action mask (this is required for discrete actions)")]
	public int actionmask_size;

	[Tooltip("Can be used to prevent the firing of the inference run co-routine")]
	public bool blockRun;

	[HideInInspector]
	public int batch_size;

	[Tooltip("Used for breaking out of inference loop")]
	public bool exitWorker;

	[Tooltip("Indicates if the inference coroutine is running")]
	public bool running;

	[Tooltip("Indicates if model, engine, and dicts are fully ready")]
	public bool warm;

	[Tooltip("Indicates if tensor dictionaries have been instantiated")]
	public bool dictsEmpty;

	[Tooltip("Indicates if model and engine need to be loaded/created")]
	private bool needsInit;

	[Tooltip("The agent to spawn and manage, only necessary if BMM is managing spawning")]
	[Header("Inference Agent Specific")]
	public GameObject agentPrefab;

	[Tooltip("How many agents the BMM is responsible for managing")]
	public int nb_agents;

	[Tooltip("Reference for the parent game object of the agents, only for bmm spawning")]
	public GameObject area;

	[Tooltip("References to the agents that are being managed by this BMM")]
	public InferenceAgent[] agent_list;

	public List<int> available_inds;

	[Tooltip("Transform reference of the target for agents (not required)")]
	public Transform target;

	[Tooltip("Debug value")]
	public int nb_agents_collected;

	[Tooltip("Variable used by [single] zone spawners to keep track of how many agents are active in scene")]
	public int _total_;

	[Header("BMM Placement Section")]
	[Tooltip("If the bmm is handling spawning of agents")]
	public bool handle_placement;

	[Tooltip("How to line up the agents when bmm is spawning")]
	public int requested_rows;

	[Tooltip("Space between agents when bmm is spawnign")]
	public float spacing;

	public Dictionary<string, Tensor> tensor_observation_dict;

	public Dictionary<string, float[]> float_observation_dict;

	public Dictionary<string, Tensor> tensor_action_dict;

	private float[] accept_all_action_mask;

	private IEnumerator engineIterator;

	private Tensor output;

	private Tensor action_masks;

	[Tooltip("Fills public arrays that can be used for quick debugging")]
	public bool useDbgArrays;

	[Tooltip("Public array containing all agent's inputs")]
	public float[] fullDbgInput;

	[Tooltip("Public array containing all agent's outputs")]
	public float[] fullDbgOutput;

	public int recycleCounter;

	public bool agentsUnsubd;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void InitBMM()
	{
	}

	public void InitDictionaries()
	{
	}

	public void WarmStartModelManager(ModelManagerConfig bmmConfig)
	{
	}

	public void WarmUp()
	{
	}

	public void ClearAvailableInds()
	{
	}

	public IEnumerator Run()
	{
		return null;
	}

	public void DisposeTensors()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	public void Dispose()
	{
	}

	public void DisposeTensorsOnly()
	{
	}

	public void ConnectAgentToBmm(GameObject agent, int agentId)
	{
	}

	public void DeactivateAllAgents()
	{
	}

	public void ActivateAllAgents()
	{
	}

	public void StartManager()
	{
	}

	public void StopManager()
	{
	}

	private void PlaceAgents()
	{
	}

	public BarracudaModelManagerMono()
		: base()
	{
	}
}
