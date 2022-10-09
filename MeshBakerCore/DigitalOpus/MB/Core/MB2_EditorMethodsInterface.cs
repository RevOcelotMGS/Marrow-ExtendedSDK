using System.Collections.Generic;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public interface MB2_EditorMethodsInterface
	{
		void Clear();

		void RestoreReadFlagsAndFormats(ProgressUpdateDelegate progressInfo);

		void SetReadWriteFlag(Texture2D tx, bool isReadable, bool addToList);

		void ConvertTextureFormat_DefaultPlatform(Texture2D tx, TextureFormat targetFormat, bool isNormalMap);

		void ConvertTextureFormat_PlatformOverride(Texture2D tx, TextureFormat targetFormat, bool isNormalMap);

		void SaveTextureArrayToAssetDatabase(Texture2DArray atlas, TextureFormat foramt, string texPropertyName, int atlasNum, Material resMat);

		void SaveAtlasToAssetDatabase(Texture2D atlas, ShaderTextureProperty texPropertyName, int atlasNum, bool doAnySrcMatsHaveProperty, Material resMat);

		bool IsNormalMap(Texture2D tx);

		string GetPlatformString();

		void SetTextureSize(Texture2D tx, int size);

		bool IsCompressed(Texture2D tx);

		void CheckBuildSettings(long estimatedAtlasSize);

		bool CheckPrefabTypes(MB_ObjsToCombineTypes prefabType, List<GameObject> gos);

		bool ValidateSkinnedMeshes(List<GameObject> mom);

		void CommitChangesToAssets();

		void OnPreTextureBake();

		void OnPostTextureBake();

		void Destroy(Object o);

		void DestroyAsset(Object o);

		bool IsAnAsset(Object o);

		Texture2D CreateTemporaryAssetCopy(ShaderTextureProperty prop, Texture2D sliceTex, int w, int h, TextureFormat format, MB2_LogLevel logLevel);

		bool TextureImporterFormatExistsForTextureFormat(TextureFormat texFormat);

		bool ConvertTexture2DArray(Texture2DArray inArray, Texture2DArray outArray, TextureFormat outFormat);

		void GetMaterialPrimaryKeysIfAddressables(MB2_TextureBakeResults textureBakeResults);
	}
}
