using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public interface MBVersionInterface
	{
		string version();

		int GetMajorVersion();

		int GetMinorVersion();

		bool GetActive(GameObject go);

		void SetActive(GameObject go, bool isActive);

		void SetActiveRecursively(GameObject go, bool isActive);

		UnityEngine.Object[] FindSceneObjectsOfType(Type t);

		bool IsRunningAndMeshNotReadWriteable(Mesh m);

		Vector2[] GetMeshUVChannel(int channel, Mesh m, MB2_LogLevel LOG_LEVEL);

		void MeshClear(Mesh m, bool t);

		void MeshAssignUVChannel(int channel, Mesh m, Vector2[] uvs);

		Vector4 GetLightmapTilingOffset(Renderer r);

		Transform[] GetBones(Renderer r, bool isSkinnedMeshWithBones);

		void OptimizeMesh(Mesh m);

		int GetBlendShapeFrameCount(Mesh m, int shapeIndex);

		float GetBlendShapeFrameWeight(Mesh m, int shapeIndex, int frameIndex);

		void GetBlendShapeFrameVertices(Mesh m, int shapeIndex, int frameIndex, Vector3[] vs, Vector3[] ns, Vector3[] ts);

		void ClearBlendShapes(Mesh m);

		void AddBlendShapeFrame(Mesh m, string nm, float wt, Vector3[] vs, Vector3[] ns, Vector3[] ts);

		int MaxMeshVertexCount();

		void SetMeshIndexFormatAndClearMesh(Mesh m, int numVerts, bool vertices, bool justClearTriangles);

		bool GraphicsUVStartsAtTop();

		bool IsTextureReadable(Texture2D tex);

		bool CollectPropertyNames(List<ShaderTextureProperty> texPropertyNames, ShaderTextureProperty[] shaderTexPropertyNames, List<ShaderTextureProperty> _customShaderPropNames, Material resultMaterial, MB2_LogLevel LOG_LEVEL);

		void DoSpecialRenderPipeline_TexturePackerFastSetup(GameObject cameraGameObject);

		ColorSpace GetProjectColorSpace();

		MBVersion.PipelineType DetectPipeline();

		string UnescapeURL(string url);

		IEnumerator FindRuntimeMaterialsFromAddresses(MB2_TextureBakeResults textureBakeResult, MB2_TextureBakeResults.CoroutineResult isComplete);
	}
}
