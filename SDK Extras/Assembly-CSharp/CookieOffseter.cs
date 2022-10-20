using UnityEngine;
using UnityEngine.Rendering.Universal;

[RequireComponent(typeof(Light))]
public class CookieOffseter : MonoBehaviour
{
	public UniversalAdditionalLightData LightData;

	public Vector2 cookieOffsetSpeed;

	private void Update()
	{
	}

	private void Reset()
	{
	}

	public CookieOffseter()
		: base()
	{
	}
}
