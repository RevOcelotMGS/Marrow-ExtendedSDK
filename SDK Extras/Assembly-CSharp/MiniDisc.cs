using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.SFX;
using SLZ.VFX;
using UnityEngine;

public class MiniDisc : MonoBehaviour
{
	public BoxGrip grip;

	public RadioSong clip_song;

	public AmbientSFX source;

	private string songName;

	public string unlockEventName;

	private bool used;

	[SerializeField]
	private Spawnable vfxSpawnable;

	public Transform vfxPoint;

	public Blip blip;

	public void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void UNLOCKTHISSONG()
	{
	}

	private void OnHandAttached(Hand hand)
	{
	}

	public void POPFX(Spawnable effect)
	{
	}

	private UniTaskVoid PopFXAsync(Spawnable effect)
	{
		return default(UniTaskVoid);
	}

	public MiniDisc()
		: base()
	{
	}
}
