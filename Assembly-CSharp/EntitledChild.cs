using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

public class EntitledChild : MonoBehaviour
{
	private void OnEnable()
	{
	}

	private UniTaskVoid CheckAsync()
	{
		return default(UniTaskVoid);
	}

	public EntitledChild()
		: base()
	{
	}
}
