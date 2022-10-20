using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Graphs
{
	public class DirectedGraph<TNode> where TNode : IEquatable<TNode>
	{
		internal HashSet<Vertex<TNode>> _nodes;

		internal List<Vertex<TNode>> _orderedNodes;

		internal Dictionary<Vertex<TNode>, HashSet<Vertex<TNode>>> _edges;

		internal Dictionary<Vertex<TNode>, HashSet<Vertex<TNode>>> _reverseEdges;

		public bool AddNode(Vertex<TNode> node)
		{
			return default(bool);
		}

		public void AddEdge(Vertex<TNode> from, Vertex<TNode> to)
		{
		}

		public bool[] AddNodes(params Vertex<TNode>[] nodes)
		{
			nodes = default(Vertex<TNode>[]);
			return null;
		}

		public void AddEdges(params ValueTuple<Vertex<TNode>, Vertex<TNode>>[] edges)
		{
			edges = default(ValueTuple<Vertex<TNode>, Vertex<TNode>>[]);
		}

		public void AddEdge(ValueTuple<Vertex<TNode>, Vertex<TNode>> pair)
		{
		}

		public List<List<Vertex<TNode>>> ConnectedComponents_Tarjan()
		{
			return null;
		}

		private void Tarjan_StrongConnect(Vertex<TNode> v, int index, Stack<Vertex<TNode>> stack, List<List<Vertex<TNode>>> stronglyConnectedComponents)
		{
		}

		public DirectedGraph()
			: base()
		{
		}
	}
}
