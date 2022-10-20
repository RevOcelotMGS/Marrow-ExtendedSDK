using UnityEngine;
using UnityEngine.Events;

public class Control_UI_Profile : MonoBehaviour
{
	[Space(10f)]
	public UnityEvent completionEvent;

	public Feedback_Tactile tactiler;

	private bool clickedLoad;

	public void COMPLETE()
	{
	}

	public Control_UI_Profile()
		: base()
	{
	}
}
