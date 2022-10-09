using System;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	[Serializable]
	public struct MarrowGuid : IEquatable<MarrowGuid>
	{
		[SerializeField]
		private byte[] _byteArray;

		public byte[] ByteArray
		{
			get
			{
				return null;
			}
		}

		public MarrowGuid(byte[] byteArray)
		{
			this._byteArray = default(byte[]);
		}

		public MarrowGuid(string hexString)
		{
			this._byteArray = default(byte[]);
		}

		public void GenerateGuid(bool firstBit)
		{
		}

		public bool Equals(MarrowGuid other)
		{
			return default(bool);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public static bool operator ==(MarrowGuid guid, MarrowGuid otherGuid)
		{
			return default(bool);
		}

		public static bool operator !=(MarrowGuid guid, MarrowGuid otherGuid)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public bool IsValid()
		{
			return default(bool);
		}

		public static bool IsValid(MarrowGuid guid)
		{
			return default(bool);
		}

		public string ToHexString()
		{
			return null;
		}

		public void FromHexString(string hexString)
		{
		}
	}
}
