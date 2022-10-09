using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthCanvas : MonoBehaviour
{
	public Slider healthSlider;

	public Image regenIcon;

	public Image deathIcon;

	public TMP_Text timeToDeathText;

	public TMP_Text healthText;

	public PlayerHealthCanvas()
		: base()
	{
	}
}
