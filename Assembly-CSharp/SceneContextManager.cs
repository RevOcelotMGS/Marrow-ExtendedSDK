using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.MLAgents;
using UnityEngine;

public class SceneContextManager : MonoBehaviour
{
	public string[] allSceneContexts;

	public string[] desiredSceneContexts;

	public string[] sceneNames;

	protected Dictionary<string, float[]> paramDict;

	public int sceneInd;

	public string currentScene;

	protected int sceneCounter;

	private SceneContextManager thisManager;

	protected static int nbContexts;

	public string currentContext;

	public Dictionary<string, string> contextSceneNamesDict;

	public float[] currentParams;

	public bool useCur;

	[HideInInspector]
	public EnvironmentParameters envParams;

	protected virtual void Awake()
	{
	}

	public IEnumerator SelectAndLoadScene()
	{
		return null;
	}

	[ContextMenu("Increment Scene")]
	public void IncrementScene()
	{
	}

	public SceneContextManager()
		: base()
	{
	}

	protected event Action sceneLoaded;
}
