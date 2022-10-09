using System;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class Barcode : IEquatable<Barcode>, ISerializationCallbackReceiver
	{
		[SerializeField]
		private string _id;

		private string _group;

		private string _name;

		[SerializeField]
		[ReadOnly(false)]
		private bool generated;

		public static string separator;

		public static readonly string EMPTY;

		private static readonly string EMPTY_OLD;

		public static readonly int MAX_SIZE;

		public string ID
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public static Barcode EmptyBarcode()
		{
			return null;
		}

		public Barcode()
			: base()
		{
		}

		public Barcode(Barcode other)
			: this()
		{
		}

		public Barcode(string newId)
			: this()
		{
		}

		public static string BuildBarcode(params string[] parts)
		{
			parts = default(string[]);
			return null;
		}

		public static bool IsValidSize(string barcode)
		{
			return default(bool);
		}

		public static bool IsValid(string barcode)
		{
			return default(bool);
		}

		public void GenerateID(params string[] parts)
		{
			parts = default(string[]);
		}

		public void GenerateID(bool forceGeneration = false, params string[] parts)
		{
			parts = default(string[]);
		}

		public static implicit operator string(Barcode b)
		{
			return null;
		}

		public static explicit operator Barcode(string s)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public bool Equals(Barcode other)
		{
			return default(bool);
		}

		public static bool operator ==(Barcode barcode, Barcode otherBarcode)
		{
			return default(bool);
		}

		public static bool operator !=(Barcode barcode, Barcode otherBarcode)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
