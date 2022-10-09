using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[CreateAssetMenu(fileName = "MeshAssignCustomizerPutSliceIdxInUV0_z", menuName = "Mesh Baker/Assign To Mesh Customizer/Put Slice Index In UV0.z", order = 1)]
	public class CustomizerPutSliceIndexInUV0_z : MB_DefaultMeshAssignCustomizer
	{
		public override void meshAssign_UV0(int channel, MB_IMeshBakerSettings settings, MB2_TextureBakeResults textureBakeResults, Mesh mesh, Vector2[] uvs, float[] sliceIndexes)
		{
		}

		public CustomizerPutSliceIndexInUV0_z()
			: base()
		{
		}
	}
}
