using System.Runtime.InteropServices;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[CreateAssetMenu(fileName = "MeshBakerSettings", menuName = "Mesh Baker/Mesh Baker Settings")]
	public class MB3_MeshCombinerSettings : ScriptableObject, MB_IMeshBakerSettingsHolder
	{
		public MB3_MeshCombinerSettingsData data;

		public MB_IMeshBakerSettings GetMeshBakerSettings()
		{
			return null;
		}

		public void GetMeshBakerSettingsAsSerializedProperty([Out] string propertyName, [Out] Object targetObj)
		{
		}

		public MB3_MeshCombinerSettings()
			: base()
		{
		}
	}
}
