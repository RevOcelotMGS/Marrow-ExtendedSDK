using TMPro;
using UnityEngine;

public class HubModule_GameSelect : MonoBehaviour
{
	[Header("LEVEL LIST")]
	public TextMeshProUGUI txt_Mode;

	public string[] name_Mode;

	private int cur_Mode;

	public string[] ARENA;

	public string[] TACTRIAL;

	public string[] PARKOUR;

	public string[] SANDBOX;

	public string[] EXPERIMENTAL;

	public void BUTTON_MODE(int mode = 0)
	{
	}

	private void DISPLAYUI()
	{
	}

	public HubModule_GameSelect()
		: base()
	{
	}
}
