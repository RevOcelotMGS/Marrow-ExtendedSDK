using UnityEngine;
using UnityEngine.Events;

public class HubModule_AvatarSelect : MonoBehaviour
{
	[SerializeField]
	public UnityEvent onConfirm;

	public void CONFIRM()
	{
	}

	public HubModule_AvatarSelect()
		: base()
	{
	}
}
