using SLZ.Data.SaveData;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SLZ.Data
{
	public class GraphicsManager
	{
		[SerializeField]
		public static UniversalRenderPipelineAsset CustomPipelineAsset;

		[SerializeField]
		public static UniversalRendererData CustomRendererData;

		[SerializeField]
		public static VolumetricData CustomVolumetricRenderingSettings;

		[SerializeField]
		public static VolumetricData QuestVolumetricRenderingSettings;

		[SerializeField]
		public static VolumetricData PCVolumetricRenderingSettings;

		[SerializeField]
		public static Volume MainSceneVolume;

		[SerializeField]
		public static VolumeProfile MainVolumeProfile;

		[SerializeField]
		public static VolumeProfile CustomVolumeProfile;

		private static int HBAOFeature;

		private static int BloomFeature;

		private static float PercentToFloat;

		public static void DecreaseQualityLevel()
		{
		}

		public static void IncreaseQualityLevel()
		{
		}

		public static void SaveQualityLevel()
		{
		}

		public static void SaveQualityLevel(GraphicsQuality graphicsQuality)
		{
		}

		private static void RefreshQualitySettings()
		{
		}

		private static void CustomSet()
		{
		}

		public static void SetQualityFromPreset(GraphicsQuality quality)
		{
		}

		public static void InitializeCustomSettings()
		{
		}

		private static void CheckRenderfeatures()
		{
		}

		public static void SetCurrentRenderer(UniversalRenderPipelineAsset pipelineAsset)
		{
		}

		public static void SetLODBias()
		{
		}

		public static void IncreaseShadowQuality()
		{
		}

		public static void DecreaseShadowQuality()
		{
		}

		private static void SetShadowVariables(SettingLevel currentLevel)
		{
		}

		public static void IncreaseShadowCascade()
		{
		}

		public static void DecreaseShadowCascade()
		{
		}

		public static void SetShadowCascades(int count)
		{
		}

		public static void IncreaseMSAA()
		{
		}

		public static void DecreaseMSAA()
		{
		}

		public static void SetMSAAVariables(int TargetAA)
		{
		}

		public static void IncreaseRenderScale()
		{
		}

		public static void DecreaseRenderScale()
		{
		}

		public static void SetRenderscale(int scale)
		{
		}

		public static void IncreaseLODBias()
		{
		}

		public static void DecreaseLODBias()
		{
		}

		public static void SetLODBias(int biasUnscaled)
		{
		}

		public static void SetLODBias(float bias)
		{
		}

		public static float ComputeXRLODBias(float InputBias)
		{
			return default(float);
		}

		private static float LODQualityFromLevel(GraphicsQuality graphicsQuality)
		{
			return default(float);
		}

		public static void IncreaseBloom()
		{
		}

		public static void DecreaseBloom()
		{
		}

		public static void IncreaseHBAO()
		{
		}

		public static void DecreaseHBAO()
		{
		}

		public static void IncreaseSSR()
		{
		}

		public static void DecreaseSSR()
		{
		}

		public static void IncreaseSMAA()
		{
		}

		public static void DecreaseSMAA()
		{
		}

		public static void SetPostAAVariables(SettingLevel antialiasingQuality)
		{
		}

		public static void IncreaseVolumetrics()
		{
		}

		public static void DecreaseVolumetrics()
		{
		}

		public static void SetVolumetricVariables(SettingLevel currentlevel)
		{
		}

		public static void ReintializeVolumetricRenderer(VolumetricRendering VolumetricRender)
		{
		}

		public static void GetDefaultVolumeticValues()
		{
		}

		public static void SetVolumeticValuesFromSettings(SettingLevel level)
		{
		}

		public static void SetSSRVariables(SettingLevel SSRSettings)
		{
		}

		public static void SetHBAOVariables(SettingLevel SSRSettings)
		{
		}

		public static void SetBloomVariables(SettingLevel GlowSettings)
		{
		}

		public GraphicsManager()
			: base()
		{
		}
	}
}
