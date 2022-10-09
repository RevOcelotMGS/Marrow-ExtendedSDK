using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.Input
{
	public class SubsystemManager<TIntegratedSubsystem, TIntegratedSubsystemDescriptor> where TIntegratedSubsystem : IntegratedSubsystem where TIntegratedSubsystemDescriptor : IntegratedSubsystemDescriptor
	{
		private readonly List<TIntegratedSubsystem> _displaySubsystems;

		private readonly List<TIntegratedSubsystemDescriptor> _displaySubsystemDescriptors;

		private TIntegratedSubsystem _activeSubsystem;

		public TIntegratedSubsystem ActiveSubsystem
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public bool IsValid()
		{
			return default(bool);
		}

		public TIntegratedSubsystem GetCurrentSubsystem()
		{
			return null;
		}

		public string ListActiveSubsystems()
		{
			return null;
		}

		public SubsystemManager()
			: base()
		{
		}
	}
}
