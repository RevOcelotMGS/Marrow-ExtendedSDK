using System;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Serializable]
	public class RegisteredSaveableInfo
	{
		[ReadOnly(false)]
		[SerializeField]
		private Saveable _saveable;

		[ReadOnly(false)]
		[SerializeField]
		private string _uniqueId;

		public Saveable Saveable
		{
			get
			{
				return null;
			}
		}

		public string UniqueId
		{
			get
			{
				return null;
			}
		}

		public RegisteredSaveableInfo(string uniqueId, Saveable saveable)
			: base()
		{
		}
	}
}
