using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	public abstract class MB3_MeshCombiner : MB_IMeshBakerSettings
	{
		public delegate void GenerateUV2Delegate(Mesh m, float hardAngle, float packMargin);

		public class MBBlendShapeKey
		{
			public GameObject gameObject;

			public int blendShapeIndexInSrc;

			public MBBlendShapeKey(GameObject srcSkinnedMeshRenderGameObject, int blendShapeIndexInSource)
				: base()
			{
			}

			public override bool Equals(object obj)
			{
				return default(bool);
			}

			public override int GetHashCode()
			{
				return default(int);
			}
		}

		public class MBBlendShapeValue
		{
			public GameObject combinedMeshGameObject;

			public int blendShapeIndex;

			public MBBlendShapeValue()
				: base()
			{
			}
		}

		[SerializeField]
		protected MB2_ValidationLevel _validationLevel;

		[SerializeField]
		protected string _name;

		[SerializeField]
		protected MB2_TextureBakeResults _textureBakeResults;

		[SerializeField]
		protected GameObject _resultSceneObject;

		[SerializeField]
		protected Renderer _targetRenderer;

		[SerializeField]
		protected MB2_LogLevel _LOG_LEVEL;

		[SerializeField]
		protected UnityEngine.Object _settingsHolder;

		[SerializeField]
		protected MB2_OutputOptions _outputOption;

		[SerializeField]
		protected MB_RenderType _renderType;

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

		[SerializeField]
		[FormerlySerializedAs("_recenterVertsToBoundsCenter")]
		protected MB_MeshPivotLocation _pivotLocationType;

		[SerializeField]
		protected Vector3 _pivotLocation;

		[SerializeField]
		protected bool _clearBuffersAfterBake;

		[SerializeField]
		public bool _optimizeAfterBake;

		[SerializeField]
		[FormerlySerializedAs("uv2UnwrappingParamsHardAngle")]
		protected float _uv2UnwrappingParamsHardAngle;

		[SerializeField]
		[FormerlySerializedAs("uv2UnwrappingParamsPackMargin")]
		protected float _uv2UnwrappingParamsPackMargin;

		[SerializeField]
		protected bool _smrNoExtraBonesWhenCombiningMeshRenderers;

		[SerializeField]
		protected bool _smrMergeBlendShapesWithSameNames;

		[SerializeField]
		protected UnityEngine.Object _assignToMeshCustomizer;

		protected bool _usingTemporaryTextureBakeResult;

		public static bool EVAL_VERSION
		{
			get
			{
				return default(bool);
			}
		}

		public virtual MB2_ValidationLevel validationLevel
		{
			get
			{
				return default(MB2_ValidationLevel);
			}
			set
			{
			}
		}

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual MB2_TextureBakeResults textureBakeResults
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual GameObject resultSceneObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual Renderer targetRenderer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual MB2_LogLevel LOG_LEVEL
		{
			get
			{
				return default(MB2_LogLevel);
			}
			set
			{
			}
		}

		public MB_IMeshBakerSettings settings
		{
			get
			{
				return null;
			}
		}

		public virtual MB_IMeshBakerSettingsHolder settingsHolder
		{
			get
			{
				return null;
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

		public virtual bool doUV1
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

		public virtual bool clearBuffersAfterBake
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

		public virtual bool doUV2()
		{
			return default(bool);
		}

		public abstract int GetLightmapIndex();

		public abstract void ClearBuffers();

		public abstract void ClearMesh();

		public abstract void ClearMesh(MB2_EditorMethodsInterface editorMethods);

		public abstract void DisposeRuntimeCreated();

		public abstract void DestroyMesh();

		public abstract void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods);

		public abstract List<GameObject> GetObjectsInCombined();

		public abstract int GetNumObjectsInCombined();

		public abstract int GetNumVerticesFor(GameObject go);

		public abstract int GetNumVerticesFor(int instanceID);

		[Obsolete("BuildSourceBlendShapeToCombinedIndexMap is deprecated. The map will be attached to the combined SkinnedMeshRenderer object as the MB_BlendShape2CombinedMap Component.")]
		public abstract Dictionary<MBBlendShapeKey, MBBlendShapeValue> BuildSourceBlendShapeToCombinedIndexMap();

		public virtual void Apply()
		{
		}

		public abstract void Apply(GenerateUV2Delegate uv2GenerationMethod);

		public abstract void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool uv5, bool uv6, bool uv7, bool uv8, bool colors, bool bones = false, bool blendShapeFlag = false, GenerateUV2Delegate uv2GenerationMethod = default(GenerateUV2Delegate));

		public abstract void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, bool blendShapeFlag = false, GenerateUV2Delegate uv2GenerationMethod = default(GenerateUV2Delegate));

		public virtual bool UpdateGameObjects(GameObject[] gos)
		{
			return default(bool);
		}

		public virtual bool UpdateGameObjects(GameObject[] gos, bool updateBounds)
		{
			return default(bool);
		}

		public abstract bool UpdateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateColors, bool updateSkinningInfo);

		public abstract bool UpdateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateUV5, bool updateUV6, bool updateUV7, bool updateUV8, bool updateColors, bool updateSkinningInfo);

		public abstract bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true);

		public abstract bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource);

		public abstract bool CombinedMeshContains(GameObject go);

		public abstract void UpdateSkinnedMeshApproximateBounds();

		public abstract void UpdateSkinnedMeshApproximateBoundsFromBones();

		public abstract void CheckIntegrity();

		public abstract void UpdateSkinnedMeshApproximateBoundsFromBounds();

		public static void UpdateSkinnedMeshApproximateBoundsFromBonesStatic(Transform[] bs, SkinnedMeshRenderer smr)
		{
		}

		public static void UpdateSkinnedMeshApproximateBoundsFromBoundsStatic(List<GameObject> objectsInCombined, SkinnedMeshRenderer smr)
		{
		}

		protected virtual bool _CreateTemporaryTextrueBakeResult(GameObject[] gos, List<Material> matsOnTargetRenderer)
		{
			return default(bool);
		}

		public abstract List<Material> GetMaterialsOnTargetRenderer();

		public MB3_MeshCombiner()
			: base()
		{
		}
	}
}
