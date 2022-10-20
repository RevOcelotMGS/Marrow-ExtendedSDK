using System;
using System.Diagnostics;

namespace SLZ.Marrow.Graphs
{
	[DebuggerDisplay("Value = {value}")]
	public class Vertex<TNode> : IEquatable<Vertex<TNode>> where TNode : IEquatable<TNode>
	{
		internal int _tarjanIndex;

		internal int _tarjanLowLink;

		public TNode value;

		public Vertex(TNode value)
			: base()
		{
		}

		bool IEquatable<Vertex<TNode>>.Equals(Vertex<TNode> other)
		{
			return default(bool);
		}

		public override bool Equals(object other)
		{
			return default(bool);
		}

		public static bool operator ==(Vertex<TNode> lhs, Vertex<TNode> rhs)
		{
			return default(bool);
		}

		public static bool operator !=(Vertex<TNode> lhs, Vertex<TNode> rhs)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
