using System;
using Newtonsoft.Json;

[Serializable]
public class Arena_TrialsProfile
{
	[JsonProperty("title")]
	public string title;

	[JsonProperty("is_locked")]
	public bool isLocked;

	[JsonProperty("completed_easy")]
	public bool completedEasy;

	[JsonProperty("completed_medium")]
	public bool completedMedium;

	[JsonProperty("completed_hard")]
	public bool completedHard;

	public Arena_TrialsProfile()
		: base()
	{
	}
}
