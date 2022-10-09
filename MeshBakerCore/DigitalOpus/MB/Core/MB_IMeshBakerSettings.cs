using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public interface MB_IMeshBakerSettings
	{
		bool doBlendShapes { get; set; }

		bool doCol { get; set; }

		bool doNorm { get; set; }

		bool doTan { get; set; }

		bool doUV { get; set; }

		bool doUV3 { get; set; }

		bool doUV4 { get; set; }

		bool doUV5 { get; set; }

		bool doUV6 { get; set; }

		bool doUV7 { get; set; }

		bool doUV8 { get; set; }

		float WeldVerts { get; set; }

		float BlendWeld { get; set; }

		MB2_LightmapOptions lightmapOption { get; set; }

		float uv2UnwrappingParamsHardAngle { get; set; }

		float uv2UnwrappingParamsPackMargin { get; set; }

		bool optimizeAfterBake { get; set; }

		MB_MeshPivotLocation pivotLocationType { get; set; }

		Vector3 pivotLocation { get; set; }

		bool clearBuffersAfterBake { get; set; }

		MB_RenderType renderType { get; set; }

		bool smrNoExtraBonesWhenCombiningMeshRenderers { get; set; }

		bool smrMergeBlendShapesWithSameNames { get; set; }

		IAssignToMeshCustomizer assignToMeshCustomizer { get; set; }
	}
}
