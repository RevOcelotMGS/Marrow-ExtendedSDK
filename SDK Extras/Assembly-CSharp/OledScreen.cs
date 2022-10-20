using UnityEngine;

public class OledScreen : MonoBehaviour
{
	[Header("Electronic Ref")]
	[SerializeField]
	private Powerable m_Electronic;

	[SerializeField]
	[Header("Renderer")]
	private Renderer m_Renderer;

	private void Awake()
	{
	}

	private void M_DisplayIcon()
	{
	}

	private void M_SetShader(bool on)
	{
	}

	public OledScreen()
		: base()
	{
	}
}
