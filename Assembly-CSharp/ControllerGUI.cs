using UnityEngine;

public class ControllerGUI : MonoBehaviour
{
	public Transform sceneLightObject;

	public float lightDirection;

	public float lightIntensity;

	public GameObject modeObjectE;

	public GameObject modeObjectF;

	public Transform targetObjectE;

	public Transform targetObjectF1;

	public Transform targetObjectF2;

	public bool autoDilate;

	public float lodLevel;

	public float parallaxAmt;

	public float pupilDilation;

	public float scleraSize;

	public float irisSize;

	public Color irisColor;

	public Color scleraColor;

	public int irisTexture;

	public Texture[] irisTextures;

	public Texture2D texTitle;

	public Texture2D texTD;

	public Texture2D texDiv1;

	public Texture2D texSlideA;

	public Texture2D texSlideB;

	public Texture2D texSlideD;

	public Transform lodLevel0;

	public Transform lodLevel1;

	public Transform lodLevel2;

	[HideInInspector]
	public string sceneMode;

	private float currentLodLevel;

	private float doLodSwitch;

	private Vector3 lodRot;

	private Light sceneLight;

	private Renderer targetRenderer;

	private Renderer targetRenderer1;

	private Renderer targetRenderer2;

	private float lightAngle;

	private float ambientFac;

	private float irisTextureF;

	private float irisTextureD;

	private Color colorGold;

	private Color colorGrey;

	private Color colorHighlight;

	private EyeAdv_AutoDilation autoDilateObject;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	private void GenerateSlider(string title, int sX, int sY, bool showPercent, string funcName, int sWidth)
	{
	}

	public ControllerGUI()
		: base()
	{
	}
}
