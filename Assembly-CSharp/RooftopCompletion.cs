using System;
using SLZ.Bonelab;

[Obsolete("Replace with a LevelCompletion instance with the LevelKey set")]
public class RooftopCompletion : LevelCompletion
{
	protected override string LevelKey
	{
		get
		{
			return null;
		}
	}

	public RooftopCompletion()
		: base()
	{
	}
}
