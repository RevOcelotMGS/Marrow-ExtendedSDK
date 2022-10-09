using System;
using UnityEngine.Playables;

[Serializable]
public class ActionDirector
{
	public string actionKey;

	public PlayableDirector director;

	public bool wasTriggered;

	public ActionDirector()
		: base()
	{
	}
}
