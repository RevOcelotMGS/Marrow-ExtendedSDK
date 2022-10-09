using System.Runtime.InteropServices;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public interface MB_IMeshBakerSettingsHolder
	{
		MB_IMeshBakerSettings GetMeshBakerSettings();

		void GetMeshBakerSettingsAsSerializedProperty([Out] string propertyName, [Out] Object targetObj);
	}
}
