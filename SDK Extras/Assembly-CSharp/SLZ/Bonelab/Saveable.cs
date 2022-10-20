using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Saveable : MonoBehaviour
	{
		public string BakedObjectPath { get; private set; }

		public string HashAlgorithm { get; private set; }

		public string UniqueId { get; private set; }

		public string LastBaked { get; private set; }

		public string Data { get; set; }

		public void CopyFrom(Saveable other)
		{
		}

		public void Unbake(bool thisIsRiskyAndIKnowWhatImDoing = false)
		{
		}

		public Saveable()
			: base()
		{
		}
	}
}
