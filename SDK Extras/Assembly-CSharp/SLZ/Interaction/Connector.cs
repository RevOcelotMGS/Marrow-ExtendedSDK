using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Interaction
{
	public class Connector : OverlapTrigger
	{
		public enum Type
		{
			None = 0,
			Plug = 1,
			Socket = 2
		}

		private static ComponentCache<Connector> _cache;

		[Header("Connector")]
		[SerializeField]
		private Type _type;

		[SerializeField]
		private ConnectorInterface _interface;

		public readonly float minDistance;

		public readonly float maxDistance;

		public UnityEvent OnHover;

		public UnityEvent OnHoverBegin;

		public UnityEvent OnHoverEnd;

		private readonly HashSet<Connector> _otherConnectors;

		public new static ComponentCache<Connector> Cache
		{
			get
			{
				return null;
			}
		}

		public bool HasOtherConnector { get; private set; }

		public Connector OtherConnector { get; private set; }

		public Quaternion AlignRotation { get; private set; }

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void OnOverlapEnter(GameObject other)
		{
		}

		public override void OnOverlapExit(GameObject other)
		{
		}

		private void MarrowUpdate()
		{
		}

		protected virtual void OnConnectorHoverBegin()
		{
		}

		protected virtual void OnConnectorHover()
		{
		}

		protected virtual void OnConnectorHoverEnd()
		{
		}

		public Connector()
			: base()
		{
		}
	}
}
