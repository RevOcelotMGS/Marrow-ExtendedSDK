using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public interface IAssignToMeshCustomizer
	{
		void meshAssign_UV0(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes);

		void meshAssign_UV2(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes);

		void meshAssign_UV3(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes);

		void meshAssign_UV4(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes);

		void meshAssign_UV5(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes);

		void meshAssign_UV6(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes);

		void meshAssign_UV7(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes);

		void meshAssign_UV8(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes);

		void meshAssign_colors(MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Color[] colors, float[] sliceIndexes);
	}
}
