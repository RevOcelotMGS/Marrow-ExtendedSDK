using System.Collections.Generic;
using SLZ.Interaction;
using UnityEngine;

public class WorldUIManager : Grip
{
	private List<Hand> hands;

	public InteractableInputModule inputModule;

	public Canvas canvas;

	public override void OnHandHoverBegin(Hand hand)
	{
	}

	public override void OnHandHoverUpdate(Hand hand)
	{
	}

	public override void OnHandHoverEnd(Hand hand)
	{
	}

	protected void Update()
	{
	}

	public override void OnHandAttachedUpdate(Hand hand)
	{
	}

	public override void OnAttachedToHand(Hand hand)
	{
	}

	public override void OnDetachedFromHand(Hand hand)
	{
	}

	public override void OnFarHandHoverBegin(Hand hand)
	{
	}

	public override void OnFarHandHoverEnd(Hand hand)
	{
	}

	public override void OnFarHandHoverUpdate(Hand hand)
	{
	}

	public WorldUIManager()
		: base()
	{
	}
}
