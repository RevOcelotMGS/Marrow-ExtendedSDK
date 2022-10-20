using UnityEngine;

public class SkyBoxFadeController : MonoBehaviour
{
	public GameObject playPos;

	public Camera camera;

	public RenderTexture renderTexture;

	public bool oneFacePerFrame;

	public float zStartDistance;

	public float zStopDistance;

	public float progress;

	public Renderer skyBoxBlendMat;

	public Light directionalLight;

	public Vector2 directionalLightMinMax;

	public Vector2 ambientIntensityMinMax;

	public AnimationCurve progressCurve;

	public float remapIncrement;

	private float lastRemap;

	private int lastFrameCount;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateCubemap(int faceMask)
	{
	}

	public SkyBoxFadeController()
		: base()
	{
	}
}
