using System;

namespace SLZ.Bonelab
{
	[Obsolete("Replace with a LevelCompletion instance with the LevelKey set")]
	public class ThreeGunCompletion : LevelCompletion
	{
		protected override string LevelKey
		{
			get
			{
				return null;
			}
		}

		public ThreeGunCompletion()
			: base()
		{
		}
	}
}
