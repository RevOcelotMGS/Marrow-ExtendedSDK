using Assets.Marrow_ExtendedSDK.StubClasses;
using UnityEngine;

[CreateAssetMenu(fileName = "BarracudaModelManagerConfig", menuName = "ModelManagerConfigs/BMMConfigs", order = 1)]
public class ModelManagerConfig : ScriptableObject
{
	[SerializeField]
	private NNModel srcModel;

	[SerializeField]
	private Transform initialTarget;

	[SerializeField]
	private string[] output_names;

	[SerializeField]
	private int nb_network_slices;

	[SerializeField]
	private int nb_sim_steps;

	[SerializeField]
	private bool do_sim_update;

	[SerializeField]
	private bool inference_switch;

	[SerializeField]
	private int max_nb_agents;

	public NNModel SrcModel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Transform InitialTarget
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string[] Output_names
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Nb_network_slices
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int Nb_sim_steps
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int Max_nb_agents
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public bool Do_sim_update
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool Inference_switch
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public ModelManagerConfig()
		: base()
	{
	}
}
