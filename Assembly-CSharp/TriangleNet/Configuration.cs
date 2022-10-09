using System;
using System.Runtime.CompilerServices;

namespace TriangleNet
{
	public class Configuration
	{
		public Func<IPredicates> Predicates { get; set; }

		public Func<TrianglePool> TrianglePool { get; set; }

		public Configuration()
			: base()
		{
		}

		public Configuration(Func<IPredicates> predicates)
			: this()
		{
		}

		public Configuration(Func<IPredicates> predicates, Func<TrianglePool> trianglePool)
			: this()
		{
		}
	}
}
