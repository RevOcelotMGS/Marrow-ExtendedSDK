using System;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	public class SerializableSourceBlendShape2Combined
	{
		public GameObject[] srcGameObject;

		public int[] srcBlendShapeIdx;

		public GameObject[] combinedMeshTargetGameObject;

		public int[] blendShapeIdx;

		public void SetBuffers(GameObject[] srcGameObjs, int[] srcBlendShapeIdxs, GameObject[] targGameObjs, int[] targBlendShapeIdx)
		{
		}

		public void DebugPrint()
		{
		}

		public Dictionary<MB3_MeshCombiner.MBBlendShapeKey, MB3_MeshCombiner.MBBlendShapeValue> GenerateMapFromSerializedData()
		{
			return null;
		}

		public SerializableSourceBlendShape2Combined()
			: base()
		{
		}
	}
}
