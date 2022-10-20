using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Data.SaveData;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.SceneStreaming
{
	public class SceneBootstrapper_Bonelab : MonoBehaviour
	{
		public LevelCrateReference MenuHollowCrateRef;

		public LevelCrateReference VoidG114CrateRef;

		public LevelCrateReference LevelLoaderCrateRef;

		private static PlayerProgression p
		{
			get
			{
				return null;
			}
		}

		private UniTaskVoid Start()
		{
			return default(UniTaskVoid);
		}

		public SceneBootstrapper_Bonelab()
			: base()
		{
		}
	}
}
