using System.Collections.Generic;
using Unity.Splines.Examples;
using UnityEngine;
using UnityEngine.Splines;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class Rollercoaster : MonoBehaviour, ISplineProvider
{
	[SerializeField]
	private RollercoasterTrack m_Track;

	[SerializeField]
	private Transform m_Cart;

	[SerializeField]
	private float m_Speed;

	public IEnumerable<Spline> Splines
	{
		get
		{
			return null;
		}
	}

	private void Update()
	{
	}

	public Rollercoaster()
		: base()
	{
	}
}
