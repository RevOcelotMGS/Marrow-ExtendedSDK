using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Control_UI_ProgressBoard : MonoBehaviour
{
	public CraneControlBox craneControlBox;

	public GameControl_Hub gcHub;

	public MeshRenderer[] progressionLight;

	public Material mat_lightOff;

	public Material mat_lightOn;

	public Material mat_lightBlue;

	public MeshRenderer[] jimmyKeyLights;

	public GameObject jimmyKeyHolo;

	public Material mat_jimmyLightOff;

	public Material mat_jimmyLightOn;

	public GameObject[] lightLinesINPUT;

	public GameObject[] lightLinesOUTPUT;

	public GameObject[] imageRing;

	public GameObject lightLine_gate;

	public GameObject lightLine_exit;

	public Transform[] realSphere;

	private Vector3[] realSpherePos;

	private Quaternion[] realSphereRot;

	public Transform[] uiSphere;

	public Transform[] realCrane;

	public Transform[] uiCrane;

	public Renderer uiCraneHook;

	public Transform realZero;

	public Transform localZero;

	public Transform gate_left;

	public Transform gate_right;

	public Image[] lockImages;

	public Sprite unlockSprite;

	public Color unlockColor;

	private Vector3 gate_left_start;

	private Vector3 gate_right_start;

	public Vector3 gate_left_end;

	public Vector3 gate_right_end;

	public Rigidbody[] keyCoreRbs;

	public Transform[] socketPos;

	public Transform[] uiSocketPos;

	public AudioClip[] craneIUSounds;

	public AudioMixerGroup outputMixer;

	public ParticleSystem[] confettiSocket;

	private SimpleSFX[] confettiSocket_sfx;

	public InteractableHost[] controlHosts;

	private IEnumerator boardUpdateLoop;

	private AudioPlayer apCrane;

	private AudioPlayer apCraneUI;

	private int lastSocketIndex;

	private void OnEnable()
	{
	}

	private void InitializeBoard()
	{
	}

	private void Start()
	{
	}

	private IEnumerator BoardUpdateLoop()
	{
		return null;
	}

	public void UPDATEDBOARD()
	{
	}

	public void ACTIVATEBOARD()
	{
	}

	public void DEACTIVATEBOARD()
	{
	}

	public void BALLSACTIVE(int i)
	{
	}

	public void KEYINSERTED()
	{
	}

	public void RESETBALLS()
	{
	}

	private void CheckProgressLights()
	{
	}

	private void CheckLightLines()
	{
	}

	private void UpdateLockUI(int i)
	{
	}

	private void CheckSpheres()
	{
	}

	private void CheckCrane()
	{
	}

	public void CraneRBCollected(Rigidbody rb)
	{
	}

	public void CraneRBReleased(Rigidbody rb)
	{
	}

	public void CraneKeyLock(int i)
	{
	}

	private void HapticEvent(InteractableHost host, float duration, float frequency, float amplitude)
	{
	}

	private void ConfettiDelay()
	{
	}

	private void SwitchMats(Renderer ren, Material mat, Index i)
	{
	}

	private void PlayAudioClip(AudioPlayer ap, AudioClip clip, float volume, float minDist, Transform pos)
	{
	}

	private void CheckGate()
	{
	}

	public Control_UI_ProgressBoard()
		: base()
	{
	}
}
