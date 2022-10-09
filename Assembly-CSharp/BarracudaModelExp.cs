using System.Collections.Generic;
using Unity.Barracuda;
using UnityEngine;

public class BarracudaModelExp : MonoBehaviour
{
	public NNModel srcModel;

	private Model model;

	private IWorker engine;

	private int batchSize;

	private Dictionary<string, Tensor> inputs;

	public ArmWorm_SlicedInference[] agent_list;

	private void Start()
	{
	}

	public BarracudaModelExp()
		: base()
	{
	}
}
