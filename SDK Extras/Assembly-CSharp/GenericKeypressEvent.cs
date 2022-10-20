using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class GenericKeypressEvent : MonoBehaviour
{
	private enum KeyPressType
	{
		Key = 0,
		Down = 1,
		Up = 2
	}

	[SerializeField]
	private KeyCode ActivationKey;

	[SerializeField]
	private KeyPressType KeyActivationType;

	[SerializeField]
	private UnityEvent EventToDo;

	private void Start()
	{
	}

	private IEnumerator lookForPress()
	{
		return null;
	}

	private IEnumerator lookForDown()
	{
		return null;
	}

	private IEnumerator lookForUp()
	{
		return null;
	}

	public GenericKeypressEvent()
		: base()
	{
	}
}
