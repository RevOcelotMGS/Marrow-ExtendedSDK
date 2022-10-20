using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using UnityEngine;
using UnityEngine.Events;

public class AvatarDice : MonoBehaviour
{
	public Dice dice;

	public List<AvatarCrateReference> avatars;

	public bool useOverrideFirstAvatar;

	public AvatarCrateReference firstAvatar;

	private RigManager rigManager;

	private InteractableHost interactableHost;

	private bool handAttachEventSetup;

	private bool firstRoll;

	public UnityEvent OnHandAttach;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private UniTaskVoid ActiveRoll(int result)
	{
		return default(UniTaskVoid);
	}

	private UniTaskVoid DiceResult(int result)
	{
		return default(UniTaskVoid);
	}

	private UniTask ChangeAvatar(int result, bool isResultRoll = false)
	{
		return default(UniTask);
	}

	private void OnHandAttached(InteractableHost host, Hand hand)
	{
	}

	private void _listenForHandAttach()
	{
	}

	private void _unlistenForHandAttach()
	{
	}

	private void _simulateRoll(int result)
	{
	}

	[ContextMenu("Simulate Roll 1")]
	private void _simulateRoll1()
	{
	}

	[ContextMenu("Simulate Roll 2")]
	private void _simulateRoll2()
	{
	}

	[ContextMenu("Simulate Roll 3")]
	private void _simulateRoll3()
	{
	}

	[ContextMenu("Simulate Roll 4")]
	private void _simulateRoll4()
	{
	}

	[ContextMenu("Simulate Roll 5")]
	private void _simulateRoll5()
	{
	}

	[ContextMenu("Simulate Roll 6")]
	private void _simulateRoll6()
	{
	}

	public AvatarDice()
		: base()
	{
	}
}
