using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	public class MB3_MeshCombinerSettingsData : MB_IMeshBakerSettings
	{
		[SerializeField]
		protected MB_RenderType _renderType;

		[SerializeField]
		protected MB2_OutputOptions _outputOption;

		[SerializeField]
		protected MB2_LightmapOptions _lightmapOption;

		[SerializeField]
		protected bool _doNorm;

		[SerializeField]
		protected bool _doTan;

		[SerializeField]
		protected bool _doCol;

		[SerializeField]
		protected bool _doUV;

		[SerializeField]
		protected bool _doUV3;

		[SerializeField]
		protected bool _doUV4;

		[SerializeField]
		protected bool _doUV5;

		[SerializeField]
		protected bool _doUV6;

		[SerializeField]
		protected bool _doUV7;

		[SerializeField]
		protected bool _doUV8;

		[SerializeField]
		protected float _WeldVerts;

		[SerializeField]
		protected float _BlendWeld;

		[SerializeField]
		protected bool _doBlendShapes;

		[FormerlySerializedAs("_recenterVertsToBoundsCenter")]
		[SerializeField]
		protected MB_MeshPivotLocation _pivotLocationType;

		[SerializeField]
		protected Vector3 _pivotLocation;

		[SerializeField]
		protected bool _clearBuffersAfterBake;

		[SerializeField]
		public bool _optimizeAfterBake;

		[SerializeField]
		protected float _uv2UnwrappingParamsHardAngle;

		[SerializeField]
		protected float _uv2UnwrappingParamsPackMargin;

		[SerializeField]
		protected bool _smrNoExtraBonesWhenCombiningMeshRenderers;

		[SerializeField]
		protected bool _smrMergeBlendShapesWithSameNames;

		[SerializeField]
		protected UnityEngine.Object _assignToMeshCustomizer;

		public virtual MB_RenderType renderType
		{
			get
			{
				return default(MB_RenderType);
			}
			set
			{
			}
		}

		public virtual MB2_OutputOptions outputOption
		{
			get
			{
				return default(MB2_OutputOptions);
			}
			set
			{
			}
		}

		public virtual MB2_LightmapOptions lightmapOption
		{
			get
			{
				return default(MB2_LightmapOptions);
			}
			set
			{
			}
		}

		public virtual bool doNorm
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public virtual bool doTan
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public virtual bool doCol
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public virtual bool doUV
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public virtual bool doUV3
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public virtual bool doUV4
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public virtual bool doUV5
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public virtual bool doUV6
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public virtual bool doUV7
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public virtual bool doUV8
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public virtual float WeldVerts
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public virtual float BlendWeld
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public virtual bool doBlendShapes
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public virtual MB_MeshPivotLocation pivotLocationType
		{
			get
			{
				return default(MB_MeshPivotLocation);
			}
			set
			{
			}
		}

		public virtual Vector3 pivotLocation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public bool clearBuffersAfterBake
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool optimizeAfterBake
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float uv2UnwrappingParamsHardAngle
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float uv2UnwrappingParamsPackMargin
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool smrNoExtraBonesWhenCombiningMeshRenderers
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool smrMergeBlendShapesWithSameNames
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public IAssignToMeshCustomizer assignToMeshCustomizer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MB3_MeshCombinerSettingsData()
			: base()
		{
		}
	}
}
