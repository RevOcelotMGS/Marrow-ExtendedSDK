using System;

[Serializable]
public class Data_Player
{
	public float SheetVersion;

	public DateTime dateModified;

	public int slot_player;

	public bool DebugControl;

	public string profile_Name;

	public string player_Name;

	public float player_Height;

	public float offset_Sitting;

	public float offset_Floor;

	public bool standing;

	public int difficulty;

	public int playMode;

	public int physicsUpdateRate;

	public int loco_Curve;

	public int loco_Direction;

	public float loco_DegreesPerSnap;

	public int loco_SnapDegreesPerFrame;

	public bool isRightHanded;

	public bool SnapEnabled;

	public bool VirtualCrouching;

	public int mouseSensitivityNew;

	public int joySensitivityNew;

	public bool isInverted;

	public float GrabRadius;

	public bool isAdaptiveOn;

	public int aliasing;

	public int resX;

	public int resY;

	public bool motionBlur;

	public bool bloom;

	public bool fisheye;

	public bool ambientOcclusion;

	public bool postEffects;

	public float audio_GlobalVolume;

	public float audio_Music;

	public float audio_SFX;

	public bool subtitlesOn;

	public string language;

	public bool hasBeatenGame;

	public bool playIntroCheck;

	public string scene_Continue;

	public int scene_Saved;

	public bool archiveCheck;

	public bool hasBeatenFantasyArena;

	public bool beltRightSide;

	public float mod_Haptic;

	public int TextureResolution;

	public bool additionalLighting;

	public bool toolTipDisplay;

	public Data_Player()
		: base()
	{
	}
}
