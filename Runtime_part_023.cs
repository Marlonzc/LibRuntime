	static UnityEngine.Color GetTeamColor(System.Int32 teamId); // 0x05ab2d1c
	static System.Void RGBToHSB(UnityEngine.Color rgbColor, System.Single& hue, System.Single& saturation, System.Single& brightness); // 0x05ab2ea4
	static UnityEngine.Color HSBToRGB(System.Single hue, System.Single saturation, System.Single brightness); // 0x05ab3028
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.FullScreenEffectData : System.ValueType
{
	System.String Type; // 0x10
	System.Int32 Priority; // 0x18
	System.String TextureName; // 0x20
	SOC.TA.FullScreenUiMatData MatData; // 0x28
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrFullScreenEffect : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger <log>k__BackingField; // 0x0
	SOC.TA.FullScreenUiRenderingController effectController; // 0x18
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.FullScreenEffectData> effectCfgList; // 0x20
	System.Collections.Generic.List<System.String> showInScreenList; // 0x28
	System.Single radiationPoisonCache; // 0x30
	System.Single[] radiationAlphaList; // 0x38
	UnityEngine.Transform fullScreenUINode; // 0x40
	System.Boolean IsHudShow; // 0x48
	System.Boolean IsHudLayerShow; // 0x49
	System.Boolean UiInventoryViewIsShow; // 0x4a
	System.Collections.Generic.Dictionary<System.Int32,SOC.TA.EFullScreenUiStretchMode> stretchMap; // 0x50
	System.Collections.Generic.Dictionary<System.String,UnityEngine.Texture2D> name2Texture; // 0x58
	static SocLogger get_log(); // 0x05ab321c
	System.Threading.Tasks.Task OnEnterWorld(); // 0x05ab32a4
	System.Void SetHudShowStatus(System.Boolean isHide); // 0x05ab398c
	System.Void SetHudLayerShowStatus(System.Boolean isHide); // 0x05ab3f6c
	System.Void SetUiInventoryViewIsShow(System.Boolean isShow); // 0x05ab4138
	System.Void SetFullScreenNodeVisible(); // 0x05ab41ac
	System.Void InitControllerScript(); // 0x05ab3798
	UnityEngine.Texture2D GetTexture(System.String name); // 0x05ab4478
	System.Void CheckUnLoadTexture(); // 0x05ab45d4
	System.Void InitConfig(); // 0x05ab3400
	System.Void ShowFullScreenEffect(System.String type); // 0x05ab4b5c
	System.Void HideFullScreenEffect(System.String type); // 0x05ab4f14
	System.Void SortShowInScreenList(); // 0x05ab4e44
	System.Void RefreshEffect(); // 0x05ab3b58
	System.Void ShowTeleScopeMaskEffect(); // 0x05ab5178
	System.Void ShowLockMissileMaskEffect(); // 0x05ab51f4
	System.Void CameraChangeState(WizardGames.Soc.Common.Unity.CameraState lastCameraState, WizardGames.Soc.Common.Unity.CameraState nowCameraState); // 0x05ab5274
	System.Void CheckEquipFullScreenEffect(); // 0x05ab52f4
	System.Void ShowRadiationEffect(System.Single newAlphaValue); // 0x05ab5700
	System.Void HideRadiationEffect(); // 0x05ab585c
	System.Void ClearOnDeath(); // 0x05aa7c0c
	System.Threading.Tasks.Task OnExitWorld(); // 0x05ab58dc
	System.Void .ctor(); // 0x05ab5aa0
	static System.Void .cctor(); // 0x05ab5d40
	System.Int32 <SortShowInScreenList>b__25_0(System.String a, System.String b); // 0x05ab5e14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrRedDot : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.String,System.Int32> redDotData; // 0x18
	System.Collections.Generic.Dictionary<System.String,System.Int32> saveToServerData; // 0x20
	System.Int64 pushDataTimerId; // 0x28
	System.Boolean serverDataDirty; // 0x30
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.RedDotType,WizardGames.Soc.SocClient.Ui.MgrRedDot.RedDotNode> allNodes; // 0x38
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.MgrRedDot.RedDotNode> markTypeToNodeMap; // 0x40
	System.Collections.Generic.Stack<WizardGames.Soc.SocClient.Ui.MgrRedDot.RedDotNode> nodeStack; // 0x48
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.MgrRedDot.RedDotNode> nodeQueue; // 0x50
	System.Void Init(); // 0x05ab5ef0
	System.Void UnRegisterAll(); // 0x05ab70d0
	System.Void SwitchRedDotToGame(); // 0x05ab720c
	System.Void SwitchRedDotToLobby(); // 0x05ab860c
	WizardGames.Soc.SocClient.Ui.MgrRedDot.RedDotNode FindMarkNode(System.String markType); // 0x05ab8678
	System.Void Register(WizardGames.Soc.SocClient.Ui.RedDotType parent, WizardGames.Soc.SocClient.Ui.RedDotType type, System.Func<System.Int32> updateVal); // 0x05ab8724
	System.Void Register(WizardGames.Soc.SocClient.Ui.RedDotType parent, WizardGames.Soc.SocClient.Ui.RedDotType type, System.Func<System.Boolean> updateVal); // 0x05ab8b70
	System.Void Register(WizardGames.Soc.SocClient.Ui.RedDotType parent, System.String markRedDotName, System.Func<System.Int32> updateVal); // 0x05ab8d18
	System.Void Register(WizardGames.Soc.SocClient.Ui.RedDotType parent, System.String markRedDotName, System.Func<System.Boolean> updateVal); // 0x05ab92c8
	System.Void Unregister(WizardGames.Soc.SocClient.Ui.MgrRedDot.RedDotNode toDelete); // 0x05ab9470
	System.Void OnAccountLogined(); // 0x05ab9a58
	System.Void OnAccountEnterLobby(); // 0x05ab9cf0
	System.Void RegitserTimer(); // 0x055049cc
	System.Void ClearTimer(); // 0x05ab9f18
	System.Void OnAccountLogout(); // 0x05aba028
	System.Void SaveLocalData(); // 0x05aba0a0
	System.Void Unregister(WizardGames.Soc.SocClient.Ui.RedDotType type); // 0x05aba304
	System.Int32 RefreshRedDot(WizardGames.Soc.SocClient.Ui.RedDotType type); // 0x05aba5a8
	System.Int32 RefreshRedDot(System.String markType); // 0x05aba9bc
	System.Int32 DoRefreshRedDot(WizardGames.Soc.SocClient.Ui.MgrRedDot.RedDotNode node); // 0x05aba668
	System.Int32 GetRedDotVal(WizardGames.Soc.SocClient.Ui.RedDotType type, System.Boolean refreshWhenGet); // 0x05abaa58
	System.Int32 GetRedDotVal(System.String markType, System.Boolean refreshWhenGet); // 0x05abab80
	System.Boolean GetRedDotBool(WizardGames.Soc.SocClient.Ui.RedDotType type, System.Boolean refreshWhenGet); // 0x05abacd4
	System.Boolean GetRedDotBool(System.String markType, System.Boolean refreshWhenGet); // 0x05abad68
	System.Void SetRedDotVal(WizardGames.Soc.SocClient.Ui.RedDotType type, System.Int32 val); // 0x05abadfc
	System.Void SetRedDotVal(System.String markType, System.Int32 val); // 0x05abaefc
	System.Void SetRedDotBool(WizardGames.Soc.SocClient.Ui.RedDotType type, System.Boolean on); // 0x05abb0c0
	System.Void SetRedDotBool(System.String markType, System.Boolean on); // 0x05abb150
	System.Void RegisterRedDotUpdate(WizardGames.Soc.SocClient.Ui.RedDotType type, System.Action<System.Int32> onValUpdate); // 0x05abb1e0
	System.Void RegisterRedDotUpdate(System.String markType, System.Action<System.Int32> onValUpdate); // 0x05abb3e4
	System.Void UnregisterRedDotUpdate(WizardGames.Soc.SocClient.Ui.RedDotType type, System.Action<System.Int32> onValUpdate); // 0x05abb5c0
	System.Void UnregisterRedDotUpdate(System.String markType, System.Action<System.Int32> onValUpdate); // 0x05abb704
	System.Void PullRedDotData(); // 0x05ab9d60
	System.Void ApplyRedDotData(System.Collections.Generic.Dictionary<System.String,System.Int32> configData); // 0x05abb81c
	System.Void ApplyLocalRedDotData(); // 0x05abba84
	System.Int32 GetSaveToServerValue(System.String key); // 0x05abac14
	System.Void SetSaveToServerValue(System.String key, System.Int32 value); // 0x05abaf84
	System.Void PushRedDotData(); // 0x05abbdb0
	System.Void SetLocalRedDotValue(System.String key, System.Int32 value); // 0x05aba178
	System.Int32 GetLocalRedDotValue(System.String key); // 0x05abbc8c
	System.Void RegisterLobbyAll(); // 0x05ab6028
	System.Void UnRegisterLobbyAll(); // 0x05ab71a4
	System.Void RegisterGameAll(); // 0x05ab7278
	System.Void UnRegisterGameAll(); // 0x05ab713c
	System.Void .ctor(); // 0x05abc324
	static System.Void .cctor(); // 0x05abc55c
	System.Void <RegitserTimer>b__24_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05abc5f0
	System.Void <PullRedDotData>b__47_0(SimpleJSON.JSONNode res); // 0x05abc684
	System.Void <PushRedDotData>b__52_0(SimpleJSON.JSONNode res); // 0x05abca84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrRedDot.RedDotNode : System.Object
{
	WizardGames.Soc.SocClient.Ui.RedDotType type; // 0x10
	WizardGames.Soc.SocClient.Ui.MgrRedDot.RedDotNode parent; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.MgrRedDot.RedDotNode> childs; // 0x20
	System.Action<System.Int32> onUpdateVal; // 0x28
	System.Func<System.Int32> updateVal; // 0x30
	System.String markTypeName; // 0x38
	System.Int32 <Value>k__BackingField; // 0x40
	System.Int32 get_Value(); // 0x05abcafc
	System.Void set_Value(System.Int32 value); // 0x05abcb60
	System.Void .ctor(System.String markTypeName); // 0x05ab9234
	System.Void .ctor(); // 0x05ab5fb8
	System.Void Update(System.Int32 value); // 0x05ab95b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrRedDot.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.MgrRedDot.<>c <>9; // 0x0
	static System.Func<System.Boolean> <>9__55_0; // 0x8
	static System.Func<System.Boolean> <>9__55_1; // 0x10
	static System.Func<System.Boolean> <>9__55_2; // 0x18
	static System.Func<System.Boolean> <>9__55_3; // 0x20
	static System.Func<System.Boolean> <>9__55_4; // 0x28
	static System.Func<System.Boolean> <>9__57_0; // 0x30
	static System.Func<System.Boolean> <>9__57_1; // 0x38
	static System.Func<System.Int32> <>9__57_2; // 0x40
	static System.Func<System.Boolean> <>9__57_3; // 0x48
	static System.Func<System.Boolean> <>9__57_4; // 0x50
	static System.Func<System.Boolean> <>9__57_5; // 0x58
	static System.Func<System.Boolean> <>9__57_6; // 0x60
	static System.Void .cctor(); // 0x05abcbd8
	System.Void .ctor(); // 0x05abcc3c
	System.Boolean <RegisterLobbyAll>b__55_0(); // 0x05abcca4
	System.Boolean <RegisterLobbyAll>b__55_1(); // 0x05abcd4c
	System.Boolean <RegisterLobbyAll>b__55_2(); // 0x05abcdf4
	System.Boolean <RegisterLobbyAll>b__55_3(); // 0x05abce9c
	System.Boolean <RegisterLobbyAll>b__55_4(); // 0x05abcf44
	System.Boolean <RegisterGameAll>b__57_0(); // 0x05abcfe0
	System.Boolean <RegisterGameAll>b__57_1(); // 0x05abd07c
	System.Int32 <RegisterGameAll>b__57_2(); // 0x05abd118
	System.Boolean <RegisterGameAll>b__57_3(); // 0x05abd1b8
	System.Boolean <RegisterGameAll>b__57_4(); // 0x05abd260
	System.Boolean <RegisterGameAll>b__57_5(); // 0x05abd308
	System.Boolean <RegisterGameAll>b__57_6(); // 0x05abd3b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrRedDot.<>c__DisplayClass16_0 : System.Object
{
	System.Func<System.Int32> updateVal; // 0x10
	WizardGames.Soc.SocClient.Ui.RedDotType parent; // 0x18
	WizardGames.Soc.SocClient.Ui.RedDotType type; // 0x1c
	System.Void .ctor(); // 0x05ab8b08
	System.Int32 <Register>b__0(); // 0x05abd458
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrRedDot.<>c__DisplayClass17_0 : System.Object
{
	System.Func<System.Boolean> updateVal; // 0x10
	System.Void .ctor(); // 0x05ab8cb0
	System.Int32 <Register>b__0(); // 0x05abd5cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrRedDot.<>c__DisplayClass18_0 : System.Object
{
	System.Func<System.Int32> updateVal; // 0x10
	WizardGames.Soc.SocClient.Ui.MgrRedDot <>4__this; // 0x18
	System.String markRedDotName; // 0x20
	WizardGames.Soc.SocClient.Ui.RedDotType parent; // 0x28
	System.Void .ctor(); // 0x05ab91cc
	System.Int32 <Register>b__0(); // 0x05abd64c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrRedDot.<>c__DisplayClass19_0 : System.Object
{
	System.Func<System.Boolean> updateVal; // 0x10
	System.Void .ctor(); // 0x05ab9408
	System.Int32 <Register>b__0(); // 0x05abd83c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.RedDotType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.RedDotType Invalid = -1;
	static WizardGames.Soc.SocClient.Ui.RedDotType Root = 0;
	static WizardGames.Soc.SocClient.Ui.RedDotType Lobby = 1;
	static WizardGames.Soc.SocClient.Ui.RedDotType Mail = 2;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbySkin = 3;
	static WizardGames.Soc.SocClient.Ui.RedDotType Friend = 4;
	static WizardGames.Soc.SocClient.Ui.RedDotType Friend_Tab = 5;
	static WizardGames.Soc.SocClient.Ui.RedDotType Friend_Request = 6;
	static WizardGames.Soc.SocClient.Ui.RedDotType ChatInLobby = 7;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyTeam = 8;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyTeamInvite = 9;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyMainTeamApply = 10;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyTeamApply = 11;
	static WizardGames.Soc.SocClient.Ui.RedDotType AppointmentTeamApply = 12;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyPandora = 13;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyPlayerHome = 14;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyPlayerHome_MainPage = 15;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyPlayerHome_HeadIcon = 16;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyPlayerHome_HeadFrame = 17;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyPlayerHome_NameCard = 18;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyPlayerHome_ChatBg = 19;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyPlayerHome_LightCard = 20;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyPlayerHome_PersonalTags = 21;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyPlayerHome_MedalPage = 22;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyPlayerHome_MedalReward = 23;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyHistoryBattle = 24;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyHistoryBattleItem = 25;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyMainQuest = 26;
	static WizardGames.Soc.SocClient.Ui.RedDotType Lobby_MainQuest_Faction_1 = 27;
	static WizardGames.Soc.SocClient.Ui.RedDotType Lobby_MainQuest_Detail_Faction_1 = 28;
	static WizardGames.Soc.SocClient.Ui.RedDotType Lobby_MainQuest_Faction_2 = 29;
	static WizardGames.Soc.SocClient.Ui.RedDotType Lobby_MainQuest_Detail_Faction_2 = 30;
	static WizardGames.Soc.SocClient.Ui.RedDotType Lobby_MainQuest_Faction_3 = 31;
	static WizardGames.Soc.SocClient.Ui.RedDotType Lobby_MainQuest_Detail_Faction_3 = 32;
	static WizardGames.Soc.SocClient.Ui.RedDotType Lobby_MainQuest_Faction_4 = 33;
	static WizardGames.Soc.SocClient.Ui.RedDotType Lobby_MainQuest_Detail_Faction_4 = 34;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyBattlePass = 35;
	static WizardGames.Soc.SocClient.Ui.RedDotType LOBBY_STASH = 36;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyBtnMore = 37;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyBtnMore_XinYue = 38;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyUnion = 39;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyUnionInvite = 40;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyUnionApply = 41;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbySkill = 42;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyTalentSkill = 43;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbySeasonSkill = 44;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyActiveMall = 45;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyActiveMallShop = 46;
	static WizardGames.Soc.SocClient.Ui.RedDotType LobbyActiveMallLotteryDraw = 47;
	static WizardGames.Soc.SocClient.Ui.RedDotType Game = 48;
	static WizardGames.Soc.SocClient.Ui.RedDotType Hud = 49;
	static WizardGames.Soc.SocClient.Ui.RedDotType Backpack = 50;
	static WizardGames.Soc.SocClient.Ui.RedDotType BP_Craft = 51;
	static WizardGames.Soc.SocClient.Ui.RedDotType BPC_Common = 52;
	static WizardGames.Soc.SocClient.Ui.RedDotType BPC_Construction = 53;
	static WizardGames.Soc.SocClient.Ui.RedDotType BPC_Material = 54;
	static WizardGames.Soc.SocClient.Ui.RedDotType BPC_Weapon = 55;
	static WizardGames.Soc.SocClient.Ui.RedDotType BPC_Equip = 56;
	static WizardGames.Soc.SocClient.Ui.RedDotType BPC_Tools = 57;
	static WizardGames.Soc.SocClient.Ui.RedDotType BPC_Consumables = 58;
	static WizardGames.Soc.SocClient.Ui.RedDotType BPC_Electric = 59;
	static WizardGames.Soc.SocClient.Ui.RedDotType BP_Item = 60;
	static WizardGames.Soc.SocClient.Ui.RedDotType BP_Badge = 61;
	static WizardGames.Soc.SocClient.Ui.RedDotType BP_Reputation = 62;
	static WizardGames.Soc.SocClient.Ui.RedDotType GameHudEntryList = 63;
	static WizardGames.Soc.SocClient.Ui.RedDotType Manual = 64;
	static WizardGames.Soc.SocClient.Ui.RedDotType GameSetting = 65;
	static WizardGames.Soc.SocClient.Ui.RedDotType GameMail = 66;
	static WizardGames.Soc.SocClient.Ui.RedDotType GameFriend = 67;
	static WizardGames.Soc.SocClient.Ui.RedDotType GameFriend_Tab = 68;
	static WizardGames.Soc.SocClient.Ui.RedDotType GameFriend_Temp = 69;
	static WizardGames.Soc.SocClient.Ui.RedDotType Story = 70;
	static WizardGames.Soc.SocClient.Ui.RedDotType StoryInfo = 71;
	static WizardGames.Soc.SocClient.Ui.RedDotType StoryReputation = 72;
	static WizardGames.Soc.SocClient.Ui.RedDotType SouDJInfo = 73;
	static WizardGames.Soc.SocClient.Ui.RedDotType GamePandora = 74;
	static WizardGames.Soc.SocClient.Ui.RedDotType TakePhotos = 75;
	static WizardGames.Soc.SocClient.Ui.RedDotType Task_ActionListEntry = 76;
	static WizardGames.Soc.SocClient.Ui.RedDotType Task_DailyTab = 77;
	static WizardGames.Soc.SocClient.Ui.RedDotType Task_ActionExpansion_TreasureTask = 78;
	static WizardGames.Soc.SocClient.Ui.RedDotType Task_ActionExpansion_BeeBuzzTask = 79;
	static WizardGames.Soc.SocClient.Ui.RedDotType GameMainQuestEntry = 80;
	static WizardGames.Soc.SocClient.Ui.RedDotType Game_MainQuest_Faction_1 = 81;
	static WizardGames.Soc.SocClient.Ui.RedDotType Game_MainQuest_Detail_Faction_1 = 82;
	static WizardGames.Soc.SocClient.Ui.RedDotType Game_MainQuest_Faction_2 = 83;
	static WizardGames.Soc.SocClient.Ui.RedDotType Game_MainQuest_Detail_Faction_2 = 84;
	static WizardGames.Soc.SocClient.Ui.RedDotType Game_MainQuest_Faction_3 = 85;
	static WizardGames.Soc.SocClient.Ui.RedDotType Game_MainQuest_Detail_Faction_3 = 86;
	static WizardGames.Soc.SocClient.Ui.RedDotType Game_MainQuest_Faction_4 = 87;
	static WizardGames.Soc.SocClient.Ui.RedDotType Game_MainQuest_Detail_Faction_4 = 88;
	static WizardGames.Soc.SocClient.Ui.RedDotType BattleReport = 89;
	static WizardGames.Soc.SocClient.Ui.RedDotType BattleReportAttack = 90;
	static WizardGames.Soc.SocClient.Ui.RedDotType BattleReportDefend = 91;
	static WizardGames.Soc.SocClient.Ui.RedDotType BattlePass = 92;
	static WizardGames.Soc.SocClient.Ui.RedDotType Medal = 93;
	static WizardGames.Soc.SocClient.Ui.RedDotType Game_MedalPage = 94;
	static WizardGames.Soc.SocClient.Ui.RedDotType Game_MedalStyleReward1001 = 95;
	static WizardGames.Soc.SocClient.Ui.RedDotType Game_MedalStyleReward1002 = 96;
	static WizardGames.Soc.SocClient.Ui.RedDotType Game_MedalStyleReward1003 = 97;
	static WizardGames.Soc.SocClient.Ui.RedDotType Game_MedalStyleReward1004 = 98;
	static WizardGames.Soc.SocClient.Ui.RedDotType Game_MedalStyleReward1005 = 99;
	static WizardGames.Soc.SocClient.Ui.RedDotType Union = 100;
	static WizardGames.Soc.SocClient.Ui.RedDotType Task = 101;
	static WizardGames.Soc.SocClient.Ui.RedDotType Task_PointTab = 102;
	static WizardGames.Soc.SocClient.Ui.RedDotType Task_BoxTab = 103;
	static WizardGames.Soc.SocClient.Ui.RedDotType Task_ActionExpansion = 104;
	static WizardGames.Soc.SocClient.Ui.RedDotType GameTeam = 105;
	static WizardGames.Soc.SocClient.Ui.RedDotType GameTeamInvite = 106;
	static WizardGames.Soc.SocClient.Ui.RedDotType GameTeamApply = 107;
	static WizardGames.Soc.SocClient.Ui.RedDotType GameTeamImpeach = 108;
	static WizardGames.Soc.SocClient.Ui.RedDotType ChatInGame = 109;
	static WizardGames.Soc.SocClient.Ui.RedDotType SideReputation_BtnBadge = 110;
	static WizardGames.Soc.SocClient.Ui.RedDotType Reputation_BadgeBox = 111;
	static WizardGames.Soc.SocClient.Ui.RedDotType Reputation_SelectBadge = 112;
	static WizardGames.Soc.SocClient.Ui.RedDotType Reputation_UnlockBadge = 113;
	static WizardGames.Soc.SocClient.Ui.RedDotType Tribe = 114;
	static WizardGames.Soc.SocClient.Ui.RedDotType Tribe_Invite = 115;
	static WizardGames.Soc.SocClient.Ui.RedDotType Tribe_Apply = 116;
	static WizardGames.Soc.SocClient.Ui.RedDotType Tribe_Upgrade = 117;
	static WizardGames.Soc.SocClient.Ui.RedDotType Mall = 118;
	static WizardGames.Soc.SocClient.Ui.RedDotType MallGacha = 119;
	static WizardGames.Soc.SocClient.Ui.RedDotType Season = 120;
	static WizardGames.Soc.SocClient.Ui.RedDotType SeasonReward = 121;
	static WizardGames.Soc.SocClient.Ui.RedDotType SeasonRankReward = 122;
	static WizardGames.Soc.SocClient.Ui.RedDotType Skill = 123;
	static WizardGames.Soc.SocClient.Ui.RedDotType TalentSkill = 124;
	static WizardGames.Soc.SocClient.Ui.RedDotType SeasonSkill = 125;
	static WizardGames.Soc.SocClient.Ui.RedDotType ActiveMall = 126;
	static WizardGames.Soc.SocClient.Ui.RedDotType ActiveMallShop = 127;
	static WizardGames.Soc.SocClient.Ui.RedDotType ActiveMallLotteryDraw = 128;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SprayBinder : System.Object
{
	System.String poolKey; // 0x10
	UnityEngine.GameObject obj; // 0x18
	UnityEngine.Renderer renderer; // 0x20
	UnityEngine.ParticleSystem parSys; // 0x28
	UnityEngine.Texture oriText; // 0x30
	System.Single oriIntensity; // 0x38
	UnityEngine.Texture loadText; // 0x40
	UnityEngine.ParticleSystem get_Particle(); // 0x05abd8bc
	UnityEngine.GameObject CreateGO(); // 0x05abd920
	System.Void SetTexture(System.String path); // 0x05abdae0
	System.Void ResetTexture(); // 0x05abdcfc
	System.Void SetDissolveIntensity(System.Single intensity); // 0x05abde80
	System.Void SetActive(System.Boolean active); // 0x05abdf94
	System.Void Dispose(); // 0x05abe068
	System.Void .ctor(); // 0x05abe1c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComPriceBtn : WizardGames.Soc.SocClient.Ui.ComTextBtn
{
	FairyGUI.Transition clickAnim; // 0x330
	FairyGUI.GTextField titleText; // 0x338
	FairyGUI.Controller ctrlCost; // 0x340
	FairyGUI.Controller ctrlDiscount; // 0x348
	FairyGUI.Controller ctrlIcon; // 0x350
	FairyGUI.GTextField priceText; // 0x358
	FairyGUI.GTextField discountText; // 0x360
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05abe22c
	System.Void SetTitle(System.String title); // 0x05abe6a8
	System.Void SetPrice(System.Int32 num); // 0x05abe728
	System.Void SetIconWithNum(System.Int64 propId, System.Int32 price); // 0x05abe7ec
	System.Void SetIcon(System.Int64 propId); // 0x05abe8d0
	System.Void PlayClickAnimation(System.Action completeAction); // 0x05abe9f0
	System.Void .ctor(); // 0x05abebd8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComPriceBtn.<>c__DisplayClass20_0 : System.Object
{
	System.Action completeAction; // 0x10
	System.Void .ctor(); // 0x05abeb70
	System.Void <PlayClickAnimation>b__0(); // 0x05abecd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComPriceBtnNew : FairyGUI.GButton
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComPriceBtnNewBinder binder; // 0x318
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05abed48
	System.Void SetTitle(System.String title); // 0x05abee18
	System.Void SetPrice(System.Int32 num); // 0x05abeee4
	System.Void SetIconWithNum(System.Int64 propId, System.Int32 price); // 0x05abeffc
	System.Void SetIcon(System.String icon); // 0x05abf254
	System.Void SetIcon(System.Int64 propId); // 0x05abf134
	System.Void SetHasDiscount(System.Boolean hasDiscount); // 0x05abf2c8
	System.Void SetHasIcon(System.Boolean hasIcon); // 0x05abf424
	System.Void SetDiscountInfo(System.String discount, System.String price); // 0x05abf580
	System.Void set_Enable(System.Boolean value); // 0x05abf7cc
	System.Void SetDisableText(System.String str); // 0x05abf928
	System.Void .ctor(); // 0x05abf9f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSkipBtn : FairyGUI.GButton
{
	
	System.Void SetSkipFinishCallback(FairyGUI.EventCallback0 callback); // 0x05abfa5c
	System.Void OnEnable(); // 0x05abfaec
	System.Void OnDisable(); // 0x05abfb4c
	System.Void .ctor(); // 0x05abfbac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComStateBtn : FairyGUI.GButton
{
	FairyGUI.GObject RedDot; // 0x318
	FairyGUI.Controller showTipsCtrl; // 0x320
	FairyGUI.GLabel tipLabel; // 0x328
	FairyGUI.EventCallback0 SkipFinishCallback; // 0x330
	FairyGUI.GLabel titleLabel; // 0x338
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05abfc14
	System.Void ShowTips(System.Boolean show, System.String tips); // 0x05abfda8
	System.Void SetIcon(System.String iconUrl); // 0x05abfea8
	System.Void set_Enable(System.Boolean value); // 0x05abff28
	System.Void SetTitle(System.String str); // 0x05abffac
	System.Void Dispose(); // 0x05ac002c
	System.Void .ctor(); // 0x05ac00dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTextBtn : FairyGUI.GButton
{
	FairyGUI.GLabel tipsLabel; // 0x318
	FairyGUI.Controller controller; // 0x320
	System.String tipsStr; // 0x328
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05abe598
	System.Void .ctor(); // 0x05abec3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTimerBtn : WizardGames.Soc.SocClient.Ui.ComTextBtn
{
	FairyGUI.GTextField cdText; // 0x330
	FairyGUI.Transition clickAnim; // 0x338
	System.String disStr; // 0x340
	System.String cdStr; // 0x348
	System.Int64 timerID; // 0x350
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ac0358
	System.Void Dispose(); // 0x05ac04e4
	System.Void .ctor(); // 0x05ac05e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComAvatarSquare : FairyGUI.GComponent
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComAvatar_SquareBinder binder; // 0x288
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComAvatar_SquareMaskBinder avatar; // 0x290
	System.Action onClickCallback; // 0x298
	System.Boolean showRoleCard; // 0x2a0
	System.Boolean fromTeamUi; // 0x2a1
	System.Boolean isAppointment; // 0x2a2
	System.String fromTribeId; // 0x2a8
	System.String roleId; // 0x2b0
	System.Boolean StopPropagationOnTouch; // 0x2b8
	WizardGames.Soc.SocClient.Ui.ReportEntry reportEntry; // 0x2bc
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ac0690
	System.Void OnClickAvatar(FairyGUI.EventContext context); // 0x05ac0890
	System.Void SetOnClickCallback(System.Action callback); // 0x05ac0a4c
	System.Void Show(System.String roleId, System.Boolean grayed); // 0x05ac0acc
	System.Void GetRoleInfoCallBack(SimpleJSON.JSONNode jsonNode); // 0x05ac0bf0
	System.Void Show(System.String avatarUrl, System.Int32 level, System.Int32 frameId, System.String roleId, System.Boolean grayed); // 0x05ac0dcc
	System.Void Show(System.String avatarUrl, System.String roleId, System.Boolean grayed); // 0x05ac14fc
	System.Void set_AvatarGrayed(System.Boolean value); // 0x05ac1268
	System.Void set_ShowLevel(System.Boolean value); // 0x05ac168c
	System.Void set_ShowFrame(System.Boolean value); // 0x05ac1760
	System.Void set_Empty(System.Boolean value); // 0x05ac1834
	System.Void SetAvatar(System.String url, System.Boolean isSDK, System.String roleId); // 0x05ac1028
	System.Void Dispose(); // 0x05ac1960
	System.Void SetLevel(System.Int32 level); // 0x05ac133c
	System.Void SetFrame(System.Int32 id, System.Boolean isSelf); // 0x05ac1444
	System.Void SetFrame(System.String url); // 0x05ac1a9c
	System.Void .ctor(); // 0x05ac1c44
	System.Void <SetAvatar>b__25_0(WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconHandle handle); // 0x05ac1ce8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBackpack : FairyGUI.GComponent
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComBackpackBinder Binder; // 0x288
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> modalBtnInfos; // 0x290
	System.Action closeAction; // 0x298
	FairyGUI.GList get_List(); // 0x05ac2110
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ac21b4
	System.Void RenderBtnItem(System.Int32 index, FairyGUI.GObject item); // 0x05ac25c0
	System.Void SetBtnList(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> btnInfos); // 0x05ac27f4
	System.Void SetItemUrl(System.String itemUrl); // 0x05ac2948
	System.Void SetStatusConstroller(System.Int32 index); // 0x05ac2a1c
	System.Void SetTitleTips(System.String desc); // 0x05ac2af0
	System.Void SetEmptyTips(System.String desc); // 0x05ac2c0c
	System.Void SetBtnGray(System.Int32 index, System.Boolean gray); // 0x05ac2d30
	System.Void .ctor(); // 0x05ac2ee0
	System.Void <ConstructFromXML>b__5_0(FairyGUI.EventContext ctx); // 0x05ac2f48
	System.Void <ConstructFromXML>b__5_1(FairyGUI.EventContext ctx); // 0x05ac2fe0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBackpack.<>c__DisplayClass6_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ModalBtnInfo btnInfo; // 0x10
	System.Void .ctor(); // 0x05ac278c
	System.Void <RenderBtnItem>b__0(FairyGUI.EventContext ctx); // 0x05ac3078
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EComBadgeNumPosState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EComBadgeNumPosState down = 0;
	static WizardGames.Soc.SocClient.Ui.EComBadgeNumPosState up = 1;
	static WizardGames.Soc.SocClient.Ui.EComBadgeNumPosState outsider_medal = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBadgeItem : FairyGUI.GComponent
{
	FairyGUI.GLoader bigIcon; // 0x288
	FairyGUI.GTextField numberTxt; // 0x290
	FairyGUI.Controller ShowNumCtrl; // 0x298
	FairyGUI.Controller posCtrl; // 0x2a0
	WizardGames.Soc.SocClient.Ui.ComRedDot redDot; // 0x2a8
	FairyGUI.GTextField get_NumberTxt(); // 0x05ac3104
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ac3168
	System.Void SetBadgeIcon(System.String iconUrl); // 0x05ac34c4
	System.Void SetBadgeIcon(System.String iconUrl, System.String num, WizardGames.Soc.SocClient.Ui.EComBadgeNumPosState posState); // 0x05ac3594
	System.Void SetRedDot(System.Boolean haveRedDot); // 0x05ac36a0
	System.Void .ctor(); // 0x05ac3728
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBaseGuideView : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger Logger; // 0x0
	FairyGUI.GComponent <ComView>k__BackingField; // 0x10
	FairyGUI.GComponent comMask; // 0x18
	FairyGUI.GObject holeObj; // 0x20
	WizardGames.Soc.SocClient.Guide.GuideData curData; // 0x28
	FairyGUI.GObject guideGObj; // 0x30
	System.Int64 timerId; // 0x38
	System.Int64 startAnimLoopTimerId; // 0x40
	System.Int64 animLoopTimerId; // 0x48
	FairyGUI.GObject root; // 0x50
	FairyGUI.GComponent parentUi; // 0x58
	System.Collections.Generic.List<FairyGUI.GObject> registerLst; // 0x60
	FairyGUI.Transition curTransition; // 0x68
	FairyGUI.GList list; // 0x70
	System.Boolean isList; // 0x78
	System.Int32 listIndex; // 0x7c
	System.Boolean isAnimPlaying; // 0x80
	WizardGames.Soc.SocClient.Ui.UiHudElem curHudElem; // 0x88
	FairyGUI.GLoader dynamicLoader; // 0x90
	System.Single maskAlpha; // 0x98
	System.Single FIXED_DEFAULT_POS_Y; // 0x9c
	WizardGames.Soc.SocClient.Ui.EGuideTipsDir dir; // 0xa0
	FairyGUI.GTextField tipsText; // 0xa8
	FairyGUI.GObject tipsTextBg; // 0xb0
	FairyGUI.GObject separator; // 0xb8
	FairyGUI.GImage bgImage1; // 0xc0
	FairyGUI.GImage bgImage2; // 0xc8
	FairyGUI.GImage bgImage3; // 0xd0
	FairyGUI.GLoader bgloader; // 0xd8
	FairyGUI.Transition loopAnim; // 0xe0
	FairyGUI.Transition contractAnim; // 0xe8
	FairyGUI.Controller tipsArrowCtrl; // 0xf0
	System.Boolean guideObjActive; // 0xf8
	System.Single pcScale; // 0xfc
	FairyGUI.GComponent get_ComView(); // 0x05ac3790
	System.Void set_ComView(FairyGUI.GComponent value); // 0x05ac37f4
	System.Boolean get_IsValid(); // 0x05ac3874
	System.Void Init(WizardGames.Soc.SocClient.Guide.GuideData data, FairyGUI.GObject guideGObj, FairyGUI.GComponent parentUi); // 0x05ac3aec
	System.Void OnRemoveFromStage(); // 0x05ac7750
	System.Void GetTitlePosition(System.Single& x, System.Single& y); // 0x05ac7934
	System.Void GetGuideTipPivotXY(System.Single& pivotX, System.Single& pivotY); // 0x05ac7c78
	System.Void SetGuideTipsPivotAndRelation(); // 0x05ac7d68
	System.Void SetTipsTextRelation(); // 0x05ac8780
	System.Void ResetAnim(); // 0x05ac6124
	System.Void PlayContractAnim(); // 0x05ac8938
	System.Void PlayTransition(System.String prefix); // 0x05ac89b0
	System.Void RecursiveAnim(); // 0x05ac9308
	System.Void SetTitleShowFrameValue(); // 0x05ac8fa8
	System.Void PlayAnim(); // 0x05ac967c
	FairyGUI.GComponent LoadCom(); // 0x054e7844
	FairyGUI.GComponent LoadMask(); // 0x05ac5864
	System.Void Release(); // 0x055049cc
	System.Void OnGet(); // 0x05ac96dc
	System.Void OnRelease(); // 0x05ac9744
	System.Void OnDestroy(); // 0x05acaab4
	System.Void ReleaseGuideCom(); // 0x05acab14
	System.Void OnClickScreen(); // 0x05acac74
	System.Void OnClickButtonFirst(); // 0x05acb02c
	System.Void OnClickButtonFinal(); // 0x05acb290
	System.Void RegisterParentEvent(); // 0x05ac5950
	System.Void UnregisterParentEvent(); // 0x05aca510
	System.Void RefreshPos(); // 0x05acb32c
	System.Void RefreshVisible(); // 0x05ac6d30
	System.Void RefreshGuideObjActive(); // 0x05ac67e0
	System.Void RefreshTrans(); // 0x05ac6c3c
	System.Void OnSizeChanged(); // 0x05acba5c
	System.Void Start(); // 0x05ac60c0
	System.Void Update(); // 0x05acbd70
	System.Void OnListScroll(); // 0x05acbf0c
	System.Void OnUpdate(); // 0x05acc0cc
	System.Void Init(WizardGames.Soc.SocClient.Guide.GuideData data, FairyGUI.GObject guideGObj, FairyGUI.GComponent parentUi, System.Int32 index); // 0x05acc12c
	System.Void OnScrollToViewByListIndex(); // 0x05acd518
	System.Void RefreshGuideObj(); // 0x05acd5b8
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05acddf4
	System.Void OnClickListItem(FairyGUI.EventContext context); // 0x05acde90
	System.Void InitHud(WizardGames.Soc.SocClient.Guide.GuideData data, WizardGames.Soc.SocClient.Ui.UiHudElem hudElem); // 0x05ace244
	System.Void OnHudEnable(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x05ace474
	System.Void HudInEdit(System.Boolean isInEdit); // 0x05acede4
	System.Void OnHudDisable(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x05acee5c
	System.Void OnStart(); // 0x05acf1d0
	System.Void OnStageSizeChanged(); // 0x05acf2d4
	System.Void SwitchEnvIndex(); // 0x05aca4b0
	System.Void .ctor(); // 0x05acf418
	static System.Void .cctor(); // 0x05acf588
	System.Void <Init>b__43_1(System.Int64 id, System.Object data, System.Boolean delete); // 0x05acf65c
	System.Void <RecursiveAnim>b__52_0(); // 0x05acf88c
	System.Void <RecursiveAnim>b__52_1(System.Int64 _, System.Object _, System.Boolean _); // 0x05acfafc
	System.Void <Init>b__83_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x05acfc8c
	System.Void <OnHudEnable>b__89_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x05acfebc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBaseGuideView.<>c__DisplayClass43_0 : System.Object
{
	System.Int32 stepId; // 0x10
	WizardGames.Soc.SocClient.Ui.ComBaseGuideView <>4__this; // 0x18
	System.Void .ctor(); // 0x05ac57fc
	System.Void <Init>b__0(); // 0x05acff50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBaseGuideView.<>c__DisplayClass44_0 : System.Object
{
	FairyGUI.GObject gobj; // 0x10
	System.Int32 guideId; // 0x18
	System.Void .ctor(); // 0x05ac78cc
	System.Void <OnRemoveFromStage>b__0(System.Object obj); // 0x05ad00e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBaseGuideView.<>c__DisplayClass51_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComBaseGuideView <>4__this; // 0x10
	System.String prefix; // 0x18
	WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__1; // 0x20
	System.Void .ctor(); // 0x05ac8f40
	System.Void <PlayTransition>b__0(); // 0x05ad0200
	System.Void <PlayTransition>b__1(System.Int64 _, System.Object _, System.Boolean _); // 0x05ad04f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBaseGuideView.<>c__DisplayClass85_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComBaseGuideView <>4__this; // 0x10
	System.Int32 stepId; // 0x18
	System.Void .ctor(); // 0x05acdd8c
	System.Void <RefreshGuideObj>b__0(); // 0x05ad0590
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EGuideTipsDir : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EGuideTipsDir Default = 0;
	static WizardGames.Soc.SocClient.Ui.EGuideTipsDir Left = 1;
	static WizardGames.Soc.SocClient.Ui.EGuideTipsDir Right = 2;
	static WizardGames.Soc.SocClient.Ui.EGuideTipsDir Top = 3;
	static WizardGames.Soc.SocClient.Ui.EGuideTipsDir Bottom = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EBuildItemIconGrayedType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EBuildItemIconGrayedType All = 0;
	static WizardGames.Soc.SocClient.Ui.EBuildItemIconGrayedType Common = 1;
	static WizardGames.Soc.SocClient.Ui.EBuildItemIconGrayedType Cd = 2;
	static WizardGames.Soc.SocClient.Ui.EBuildItemIconGrayedType Craft = 3;
	static WizardGames.Soc.SocClient.Ui.EBuildItemIconGrayedType Lock = 4;
	static WizardGames.Soc.SocClient.Ui.EBuildItemIconGrayedType CanNotEdit = 5;
	static WizardGames.Soc.SocClient.Ui.EBuildItemIconGrayedType InsufficientUseNum = 6;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EBuildItemProgressTextType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EBuildItemProgressTextType All = 0;
	static WizardGames.Soc.SocClient.Ui.EBuildItemProgressTextType Common = 1;
	static WizardGames.Soc.SocClient.Ui.EBuildItemProgressTextType Cd = 2;
	static WizardGames.Soc.SocClient.Ui.EBuildItemProgressTextType Craft = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBuildItemIcon : FairyGUI.GButton
{
	FairyGUI.GLoader icon; // 0x318
	FairyGUI.GList listChild; // 0x320
	FairyGUI.GTextField textUseNum; // 0x328
	FairyGUI.GLabel trackDot; // 0x330
	FairyGUI.GTextField textName; // 0x338
	FairyGUI.GTextField text; // 0x340
	FairyGUI.GTextField textCdProgress; // 0x348
	FairyGUI.GProgressBar progressBarCd; // 0x350
	FairyGUI.Controller controllerLockState; // 0x358
	FairyGUI.Controller controllerTalentState; // 0x360
	FairyGUI.Controller controllerGrayedState; // 0x368
	FairyGUI.Transition glowTransition; // 0x370
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase <buildItemData>k__BackingField; // 0x378
	System.Boolean isSelected; // 0x380
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.EBuildItemIconGrayedType> grayedTypes; // 0x388
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.EBuildItemProgressTextType> progressTextTypes; // 0x390
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase get_buildItemData(); // 0x05ad0724
	System.Void set_buildItemData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase value); // 0x05ad0788
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ad0808
	System.Void OnInit(); // 0x05ad0890
	System.Void SetData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase itemData, System.Boolean isSelect); // 0x05ad0bc0
	System.Void UpdateLockState(); // 0x05ad0d60
	System.String GetLockStateForBlueprint(); // 0x05ad17fc
	System.Void UpdateTalentStatus(); // 0x05ad0e60
	System.String SetUnlockDescription(); // 0x05ad18f0
	System.Void UpdateIcon(); // 0x05ad0fd8
	System.Void ConfigureIconAppearance(); // 0x05ad1a00
	System.Void SetIconAlphaAndGray(); // 0x05ad1bec
	System.Void ConfigureIconForNonCore(); // 0x05ad1d44
	System.Void ConfigureUpgradeAndRemouldIcon(); // 0x05ad1aa0
	System.Void UpdateChildList(); // 0x05ad1140
	System.Void UpdateListChildAppearance(); // 0x05ad1f28
	System.Void UpdateChildIcons(); // 0x05ad2204
	System.Void UpdateUsageText(); // 0x05ad11ac
	System.Void CloseCraftCdProgress(); // 0x05ad28a8
	System.Void CloseCdProgress(); // 0x05ad2814
	System.Void SetGrayed(System.Boolean isGrayed, WizardGames.Soc.SocClient.Ui.EBuildItemIconGrayedType grayedType); // 0x05ad2c0c
	System.Int32 UpdateBlueprintUsage(); // 0x05ad2490
	System.Void UpdateNodeUsage(System.Int64 templateId); // 0x05ad2924
	System.Void UpdateMissionGroupVisibility(); // 0x05ad13b4
	System.Void SetCdProgressText(System.String progressText, WizardGames.Soc.SocClient.Ui.EBuildItemProgressTextType textType); // 0x05ad2a8c
	System.Void SetCdProgressBarValue(System.Single value); // 0x05ad2d5c
	System.Void PlayGlowEffect(); // 0x05ad2e14
	System.Void .ctor(); // 0x05ad2e8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComComboBox : FairyGUI.GComboBox
{
	FairyGUI.GTextField titleTxt; // 0x318
	FairyGUI.GLoader iconLoad; // 0x320
	FairyGUI.GImage arrowImg; // 0x328
	FairyGUI.Controller buttonCtr; // 0x330
	FairyGUI.Controller iconCtr; // 0x338
	System.Action<System.Int32> onSelectBack; // 0x340
	System.Collections.Generic.List<System.String> iconUrlList; // 0x348
	System.Collections.Generic.List<System.String> nameList; // 0x350
	System.Collections.Generic.List<System.String> valueList; // 0x358
	System.Boolean isIcon; // 0x360
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ad2f98
	System.Void InitCom(System.Collections.Generic.List<System.String> nameList, System.Action<System.Int32> onChangeBack, System.Collections.Generic.List<System.String> iconUrlList, System.Collections.Generic.List<System.String> valueList); // 0x05ad31c0
	System.Void OnRenderDropdownItem(System.Int32 index, FairyGUI.GObject item); // 0x05ad35d4
	System.Void SetDefaultData(System.String name, System.String url); // 0x05ad34d0
	System.Void OnSelectChange(); // 0x05ad3780
	System.String GetCurValue(); // 0x05ad3928
	System.String GetCurName(); // 0x05ad3990
	System.Void .ctor(); // 0x05ad3b1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComCountdown : FairyGUI.GComponent
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComCountdownBinder binder; // 0x288
	System.Int32 curMs; // 0x290
	System.Int32 maxMs; // 0x294
	FairyGUI.EventCallback0 onFinishCall; // 0x298
	FairyGUI.EventCallback0 onCancelCall; // 0x2a0
	FairyGUI.EventCallback0 onAbortCall; // 0x2a8
	System.String secPostfix; // 0x2b0
	System.Int64 timerUpdate; // 0x2b8
	System.Int32 MS_UPDATE_OFFSET; // 0x2c0
	System.Diagnostics.Stopwatch stopwatch; // 0x2c8
	System.Boolean AutoClearOnCall; // 0x2d0
	System.Boolean AutoHideWhenCancel; // 0x2d1
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ad3b84
	System.Void CallAbort(); // 0x05ad3e7c
	System.Void CallCancel(); // 0x05ad4064
	System.Void SetCountdown(System.Int32 ms); // 0x05ad412c
	System.Void Clear(); // 0x05ad3f24
	System.Void OnFinish(); // 0x05ad44fc
	System.Void OnCancel(); // 0x05ad45a4
	System.Void OnTimerUpdate(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05ad464c
	System.Void SetData(System.Int32 msCountdown, System.String tips, FairyGUI.EventCallback0 onFinish, FairyGUI.EventCallback0 onClickCancel, FairyGUI.EventCallback0 onAbort, System.Boolean autoHideWhenCancel); // 0x05511128
	System.Void SetIcon(System.String iconUrl); // 0x05ad4adc
	System.Void SetKeyTipsAction(); // 0x05ad4e44
	System.Void ClearKeyTipsAction(); // 0x05ad4ea4
	System.Void Dispose(); // 0x05ad4fe4
	System.Void .ctor(); // 0x05ad5054
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComCustomButton : FairyGUI.GComponent
{
	static SocLogger logger; // 0x0
	System.Boolean isInited; // 0x288
	FairyGUI.GLoader loaderBtn; // 0x290
	FairyGUI.EventCallback0 callback0; // 0x298
	FairyGUI.EventCallback1 callback1; // 0x2a0
	System.Single clickCDRemain; // 0x2a8
	System.String soundEventClick; // 0x2b0
	System.String soundEventClickCD; // 0x2b8
	System.Single clickCD; // 0x2c0
	System.Boolean disableCDClickTip; // 0x2c4
	System.Int32 cdClickTipId; // 0x2c8
	System.String btnTitle; // 0x2d0
	System.Action onCDClick; // 0x2d8
	System.Action onCDStart; // 0x2e0
	System.Action<System.Single> onCDUpdate; // 0x2e8
	System.Action onCDFinished; // 0x2f0
	System.Action<FairyGUI.GButton> onInit; // 0x2f8
	FairyGUI.GButton btn; // 0x300
	System.Void add_callback1(FairyGUI.EventCallback1 value); // 0x05ad510c
	System.Void remove_callback1(FairyGUI.EventCallback1 value); // 0x05ad51e4
	FairyGUI.GButton get_Btn(); // 0x05ad52bc
	System.Void set_Btn(FairyGUI.GButton value); // 0x05ad57d8
	System.Void set_BtnTitle(System.String value); // 0x05ad5858
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ad590c
	System.Void InitBtn(); // 0x05ad5330
	System.Void AddClickListener(FairyGUI.EventCallback1 callback); // 0x05ad5c54
	System.Void SetClickListener(FairyGUI.EventCallback0 callback); // 0x05ad5cdc
	System.Void SetClickListener(FairyGUI.EventCallback1 callback); // 0x05ad5d5c
	System.Void PlaySoundByEvent(System.String strEv); // 0x05ad5ddc
	System.Void FireClick(FairyGUI.EventContext ctx); // 0x05ad5f44
	System.Void StartCD(); // 0x05ad624c
	System.Void ResetCD(); // 0x05ad62cc
	System.Void OnComponentUpdate(); // 0x05ad6330
	System.String TransTextWithUserData(); // 0x05ad59dc
	System.String TransImgWithUserData(); // 0x05ad5b24
	System.Void .ctor(); // 0x05ad646c
	static System.Void .cctor(); // 0x05ad6508
	System.Void <InitBtn>b__29_0(FairyGUI.EventContext ctx); // 0x05ad65dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComDropArea : FairyGUI.GComponent
{
	FairyGUI.Controller ctrlDropArea; // 0x288
	System.Boolean closeQuickActByDropArea; // 0x290
	System.Int32 dropAreaDropAmount; // 0x294
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ad6658
	System.Void InitDropBar(System.String barName); // 0x05ad67f4
	System.Void InitTrigger(System.String triggerName, System.String page); // 0x05ad6a40
	System.Boolean OnItemDrop(FairyGUI.EventContext context); // 0x05ad6c6c
	System.Void ShowDropArea(WizardGames.Soc.SocClient.Ui.ComItemIcon icon, System.Int32 ammount); // 0x05ad6dcc
	System.Void HideDropArea(); // 0x05ad70e8
	System.Void .ctor(); // 0x05ad7188
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComDropArea.<>c__DisplayClass4_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComDropArea <>4__this; // 0x10
	FairyGUI.Controller ctrl; // 0x18
	System.Void .ctor(); // 0x05ad6b9c
	System.Void <InitDropBar>b__0(); // 0x05ad71f8
	System.Void <InitDropBar>b__1(); // 0x05ad7340
	System.Void <InitDropBar>b__2(FairyGUI.EventContext ctx); // 0x05ad7430
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComDropArea.<>c__DisplayClass5_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComDropArea <>4__this; // 0x10
	System.String page; // 0x18
	System.Void .ctor(); // 0x05ad6c04
	System.Void <InitTrigger>b__0(); // 0x05ad751c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EDualTabType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EDualTabType Icon = 0;
	static WizardGames.Soc.SocClient.Ui.EDualTabType Text = 1;
	static WizardGames.Soc.SocClient.Ui.EDualTabType IconAndText = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComDualTabs : FairyGUI.GComponent
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComDualTabsBinder binder; // 0x288
	System.Collections.Generic.List<System.Int32> firstTabIdList; // 0x290
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.ComDualTabs.TabData> firstTabDataDic; // 0x298
	System.Collections.Generic.List<System.Int32> secondTabIdList; // 0x2a0
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.ComDualTabs.TabData>> secondTabDataDic; // 0x2a8
	System.Action<System.Int32> EventFirstTabClick; // 0x2b0
	System.Action<System.Int32,System.Int32> EventSecondTabClick; // 0x2b8
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x2c0
	System.Void add_EventFirstTabClick(System.Action<System.Int32> value); // 0x05ad7598
	System.Void remove_EventFirstTabClick(System.Action<System.Int32> value); // 0x05ad7688
	System.Void add_EventSecondTabClick(System.Action<System.Int32,System.Int32> value); // 0x05ad7778
	System.Void remove_EventSecondTabClick(System.Action<System.Int32,System.Int32> value); // 0x05ad7868
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ad7958
	System.Void ClickBack(WizardGames.Soc.SocClient.Ui.NavBarData navbarData, System.Boolean click); // 0x05ad7bbc
	System.Void AddOption(System.Int32 id, System.String title, System.String icon, WizardGames.Soc.SocClient.Ui.EDualTabType style, System.Int32 parentId); // 0x05ad7e44
	WizardGames.Soc.SocClient.Ui.NavBarData AddOptionNew(System.Int32 id, System.String title, System.String icon, WizardGames.Soc.SocClient.Ui.EDualTabType style, System.Int32 parentId); // 0x05ad7fa0
	System.Void Refresh(System.Boolean defaultSelect); // 0x05ad80d0
	System.Void RefreshRedDot(); // 0x05ad8180
	WizardGames.Soc.SocClient.Ui.NavBarData GetTabData(System.Int32 mainId, System.Int32 subId); // 0x05ad81f8
	System.Void Select(System.Int32 menuId_1, System.Int32 menuId_2); // 0x05ad8298
	System.Void UpdateData(System.Int32 firstTabId, System.Int32 secondTabId, System.String title, System.String icon, WizardGames.Soc.SocClient.Ui.EDualTabType style); // 0x05ad832c
	System.Void SetCtrlStyle(System.String pageName); // 0x05ad8450
	System.Void Clear(); // 0x05ad85a4
	System.Void .ctor(); // 0x05ad8690
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComDualTabs.TabData : System.Object
{
	
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComExpandPopup : FairyGUI.GComponent
{
	FairyGUI.GImage ArrowUp; // 0x288
	FairyGUI.GImage ArrowDown; // 0x290
	FairyGUI.GList ListItem; // 0x298
	FairyGUI.GButton UnequipBtn; // 0x2a0
	FairyGUI.GButton EquipBtn; // 0x2a8
	FairyGUI.Controller CtrlArrowSide; // 0x2b0
	FairyGUI.Controller CtrlOp; // 0x2b8
	System.Single halfWidth; // 0x2c0
	System.Single height; // 0x2c4
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ad879c
	System.Void SetExpandPopPosition(WizardGames.Soc.SocClient.Ui.EExpandPopupVerticalPosition verticalPos, FairyGUI.GObject targetObj, FairyGUI.GObject parentObj); // 0x05ad8ae8
	System.Void .ctor(); // 0x05ad9350
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EExpandPopupVerticalPosition : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EExpandPopupVerticalPosition Up = 0;
	static WizardGames.Soc.SocClient.Ui.EExpandPopupVerticalPosition Down = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComHudDropBar : FairyGUI.GComponent
{
	FairyGUI.Controller dropStateCtrl; // 0x288
	System.Action beforeItemDrop; // 0x290
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ad93b8
	System.Void OnRollOver(); // 0x05ad95b0
	System.Void OnRollOut(); // 0x05ad976c
	System.Void OnItemDrop(FairyGUI.EventContext ctx); // 0x05ad9800
	System.Boolean DoItemDrop(FairyGUI.EventContext context); // 0x05ad98e8
	System.Void RelockUpdateAfterFrameIfLock(System.Int32 frame); // 0x05ad9644
	System.Void .ctor(); // 0x05ad9a58
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComInfoButton : FairyGUI.GButton
{
	WizardGames.Soc.SocClient.Ui.UiHoverTip.EHoverTipHorizontalDirection eDirection; // 0x314
	System.String customToolTips; // 0x318
	System.Int32 customToolTipsId; // 0x320
	System.Func<System.String> customToolTipsFunc; // 0x328
	System.Void Setup_AfterAdd(FairyGUI.Utils.ByteBuffer buffer, System.Int32 beginPos); // 0x05ad9ac0
	System.Void set_CustomToolTipsId(System.Int32 value); // 0x05ad9c68
	System.Void set_CustomToolTipsFunc(System.Func<System.String> value); // 0x05ada014
	System.Void OnClicked(FairyGUI.EventContext context); // 0x05ada0b4
	System.Void ShowTooltips(); // 0x05ada140
	System.Void HideTooltips(); // 0x05ada240
	System.Void Dispose(); // 0x05ada374
	System.Void set_CustomToolTips(System.String value); // 0x05ad9dd4
	System.Void .ctor(); // 0x05ada580
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComInputBox : FairyGUI.GComponent
{
	FairyGUI.GTextInput inputText; // 0x288
	FairyGUI.TextFormat textFormat; // 0x290
	FairyGUI.Controller colorCtrl; // 0x298
	FairyGUI.Controller headShowCtrl; // 0x2a0
	FairyGUI.Controller ruleTipsCtrl; // 0x2a8
	FairyGUI.GTextField ruleTips; // 0x2b0
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ada5e8
	System.Void SetChangedCallback(FairyGUI.EventCallback0 callback); // 0x05ada8a0
	System.Void set_Enable(System.Boolean value); // 0x05ada934
	System.String get_text(); // 0x05ada9bc
	System.Void set_text(System.String value); // 0x05adaa2c
	System.Void SetHeadShowCtrl(System.String showStr); // 0x05ada80c
	System.Void SetColorCtrl(System.String colorStr); // 0x05adaaac
	System.Void SetRuleTipsCtrl(System.String ctrlName, System.String tipsStr); // 0x05adab40
	System.Void SetHintText(System.String str); // 0x05adac5c
	System.Void Dispose(); // 0x05adace4
	System.Void .ctor(); // 0x05adad4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComItemCardBase : FairyGUI.GComponent
{
	System.Action OnClickIcon; // 0x288
	System.Action OnClick; // 0x290
	static System.Single lastClickTime; // 0x0
	System.Action OnDoubleClick; // 0x298
	FairyGUI.GTextField Name; // 0x2a0
	FairyGUI.GLoader Icon; // 0x2a8
	FairyGUI.GTextField Num; // 0x2b0
	FairyGUI.Controller CtrlPressState; // 0x2b8
	FairyGUI.GLoader AppPrivilegeIconLoder; // 0x2c0
	System.Void SetIconByItemId(System.Int64 itemId, System.Int64 skinId); // 0x05adadb4
	System.Void SetNum(System.Int32 num, System.Boolean isStack); // 0x05adb050
	System.Void OnClickIconHandler(FairyGUI.EventContext context); // 0x05adb190
	System.Void OnClickHandler(FairyGUI.EventContext context); // 0x05adb228
	System.Void SetIcon(System.String iconPath); // 0x05adafc8
	System.Void SetCommonElement(FairyGUI.GTextField textName, FairyGUI.GLoader loadIcon, FairyGUI.GTextField textNum, FairyGUI.Controller pressState); // 0x05adb3c0
	System.Void SetAppPrivilegeElement(FairyGUI.GLoader appPrivilegeIconLoder); // 0x05adb494
	System.Void RefreshAppPrivilegeIcon(System.Int64 skinId); // 0x05adb514
	System.Void OnTouchBeginHandler(FairyGUI.EventContext context); // 0x05adb6b4
	System.Void OnTouchEndHandler(FairyGUI.EventContext context); // 0x05adb750
	System.Void .ctor(); // 0x05adb7ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComItemCardDisplay : WizardGames.Soc.SocClient.Ui.ComItemCardBase
{
	System.Action OnClickStarBtn; // 0x2c8
	System.Action OnClickCloseBtn; // 0x2d0
	System.Boolean showSkinLevel; // 0x2d8
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComItemCardDisplayBinder binder; // 0x2e0
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05adb854
	System.Void Dispose(); // 0x05adbebc
	System.Void SetSelectState(System.Boolean isSelected); // 0x05adbf64
	System.Void SetStarState(System.Boolean value); // 0x05adc0f8
	System.Void SetShowSkinLevel(System.Boolean value); // 0x05adc1fc
	System.Void SetEquipedState(System.Boolean value); // 0x05adc278
	System.Void SetLockState(WizardGames.Soc.SocClient.Ui.EComItemLockState state); // 0x05adc37c
	System.Void SetTechLevel(System.Int32 level); // 0x05adc450
	System.Void SetCloseBtnState(System.Boolean needClose); // 0x05adc558
	System.Void SetShowNewTag(System.Boolean show); // 0x05adc65c
	System.Void SetShowTaskTag(System.Boolean show); // 0x05adc760
	System.Void PlayAppearTransition(System.Single delay, FairyGUI.PlayCompleteCallback onComplete); // 0x05adc864
	System.Void PlayAppearTransition_01(); // 0x05adc954
	System.Void Empty(System.Boolean showBg); // 0x05adca10
	System.Void NotEmpty(); // 0x05adcd44
	System.Void ShowItem(WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint, System.Boolean isSelected, WizardGames.Soc.Common.Data.DataItem.SkinConfig skinConfig, System.Boolean useItemInfo); // 0x05adcec4
	System.Void RegisterEvents(); // 0x05adbb3c
	System.Void OnClickCloseBtnHandler(FairyGUI.EventContext context); // 0x05add2f8
	System.Void OnClickStarHandler(FairyGUI.EventContext context); // 0x05add390
	System.Void SetSkinLevel(System.Int32 level); // 0x05adcc70
	System.Void .ctor(); // 0x05add428
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EComItemLockState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EComItemLockState Unlock = 0;
	static WizardGames.Soc.SocClient.Ui.EComItemLockState Locked = 1;
	static WizardGames.Soc.SocClient.Ui.EComItemLockState Disable = 2;
	static WizardGames.Soc.SocClient.Ui.EComItemLockState CannotMake = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComItemCardInQueue : WizardGames.Soc.SocClient.Ui.ComItemCardBase, WizardGames.Soc.Common.Unity.Ui.IUiFps2Update
{
	System.Action OnClickCancel; // 0x2c8
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComItemCardInQueueBinder binder; // 0x2d0
	System.Int64 endTime; // 0x2d8
	System.Int32 <Position>k__BackingField; // 0x2e0
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05add48c
	System.Void Dispose(); // 0x05add890
	System.Void OnFps2Update(System.Single dt); // 0x05add928
	System.Void RegisterEvents(); // 0x05add668
	System.Void OnClickCancelHandler(FairyGUI.EventContext context); // 0x05addaf8
	System.Void UpdateCountdown(); // 0x05add9a0
	System.Void .ctor(); // 0x05addb90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComItemCardLarge : WizardGames.Soc.SocClient.Ui.ComItemCardBase
{
	System.Action OnClickBtnCancel; // 0x2c8
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComItemCardLargeBinder binder; // 0x2d0
	FairyGUI.GButton get_Cancel(); // 0x05addbfc
	FairyGUI.GTextField get_Num(); // 0x05addca0
	FairyGUI.GLoader get_Background(); // 0x05addd44
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05addde8
	System.Void Dispose(); // 0x05ade404
	System.Void SetName(System.String name); // 0x05ade49c
	System.Void SetNumVisible(System.Boolean visible); // 0x05ade544
	System.Void SetStatus(WizardGames.Soc.SocClient.Ui.EComItemLargeState status); // 0x05ade5f8
	System.Void SetCurrencyNum(System.Int32 num, System.Boolean isStack); // 0x05ade6cc
	System.Void SetOriginCurrencyNum(System.Int32 num, System.Boolean isStack); // 0x05ade8e8
	System.Void SetCurrencyIcon(System.String iconPath); // 0x05adeb58
	System.Void SetStorageInfo(System.String storageInfo); // 0x05adec2c
	System.Void SetSoldoutState(System.Boolean isSoldout); // 0x05aded28
	System.Void SetCancelVisible(System.Boolean visible); // 0x05ade308
	System.Void SetDiscountState(System.Int32 stateIndex); // 0x05adee2c
	System.Void SetDiscountInfo(System.UInt32 price, System.UInt32 originPrice, System.Single talentDiscount); // 0x05adef00
	System.Void SetStoryStageLimit(System.Int32 id); // 0x05adf920
	System.Void SetTalentVisible(System.Boolean visible); // 0x05adfae4
	System.Void RegisterEvents(); // 0x05ade030
	System.Void OnClickBtnCancelHandler(FairyGUI.EventContext context); // 0x05adfc08
	System.Void .ctor(); // 0x05adfca0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EComItemLargeState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EComItemLargeState Normal = 0;
	static WizardGames.Soc.SocClient.Ui.EComItemLargeState Choose = 1;
	static WizardGames.Soc.SocClient.Ui.EComItemLargeState AddCom = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComItemIconForConstruction : FairyGUI.GComponent
{
	System.Int64 curItemId; // 0x288
	FairyGUI.GLoader icon; // 0x290
	FairyGUI.GTextField labelNeed; // 0x298
	FairyGUI.GTextField labelNumHas; // 0x2a0
	System.Int32 curNeedNum; // 0x2a8
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05adfd04
	System.Void SetIdAndNum(System.Int64 id, System.Int32 curNum); // 0x05adfe48
	System.Void RefreshIcon(); // 0x05adff54
	System.Void RefreshRemainValue(); // 0x05ae0068
	System.Void .ctor(); // 0x05ae019c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComKeyTips : FairyGUI.GLabel
{
	
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ae0204
	System.Void .ctor(); // 0x05ae0294
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComKeyTipsUtils : System.Object
{
	
	static System.Void InitKeyTips(FairyGUI.GComponent root, System.String childName, WizardGames.Soc.Common.Data.ActionName actionName, WizardGames.Soc.SocClient.Manager.EHotKeyLayer group, System.String title); // 0x05ad3db0
	static System.Void SetKeyTipsAction(FairyGUI.GComponent root, System.String childName, FairyGUI.EventCallback0 callback, WizardGames.Soc.SocClient.Manager.EResponseLevel responseLevel, FairyGUI.EventCallback0 callbackBreak); // 0x05ae02fc
	static System.Void ClearKeyTipsAction(FairyGUI.GComponent root, System.String childName); // 0x05ad4f70
	static WizardGames.Soc.SocClient.Ui.ComKeyTips GetComKeyTips(FairyGUI.GComponent root, System.String childName); // 0x05ae0394
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComLazyLoader : FairyGUI.GComponent
{
	FairyGUI.GLoader loader; // 0x288
	System.String dynamicUrl; // 0x290
	FairyGUI.GComponent comLoaded; // 0x298
	System.Action<FairyGUI.GComponent> OnCreateCall; // 0x2a0
	System.Action OnDestoryCall; // 0x2a8
	System.Int64 delayUnloadTimeId; // 0x2b0
	System.Boolean get_HasContent(); // 0x05ae040c
	System.Boolean get_InDelayDestroy(); // 0x05ae0478
	System.Boolean get_IsCintentValid(); // 0x05ae04e4
	FairyGUI.GComponent get_Component(); // 0x05ae0568
	System.Void Setup_BeforeAdd(FairyGUI.Utils.ByteBuffer buffer, System.Int32 beginPos); // 0x05ae087c
	System.Void ResizeToFit(); // 0x05ae0b1c
	FairyGUI.GComponent GetComponent(); // 0x05ae05cc
	System.Void DestoryComponent(); // 0x05ae0e14
	System.Void CancelTimer(); // 0x05ae0d08
	System.Void DelayDestoryComponent(System.Int32 timeout); // 0x05ae0ef4
	System.Void Dispose(); // 0x05ae1084
	System.Void OnCreate(FairyGUI.GComponent comRoot); // 0x05ae10f4
	System.Void OnDestory(); // 0x05ae1168
	System.Void .ctor(); // 0x05ae11c8
	System.Boolean <Setup_BeforeAdd>b__14_0(System.String url); // 0x05ae1238
	System.Void <DelayDestoryComponent>b__19_0(System.Int64 a, System.Object b, System.Boolean c); // 0x05ae12c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComLeftJoystickGuideView : WizardGames.Soc.SocClient.Ui.ComBaseGuideView
{
	
	FairyGUI.GComponent LoadCom(); // 0x05ae1354
	System.Void Release(); // 0x05ae1488
	System.Void .ctor(); // 0x05ae1528
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComListArrow : FairyGUI.GComponent
{
	static System.Boolean IsOpenListArrow; // 0x0
	SocLogger log; // 0x288
	FairyGUI.GList list; // 0x290
	System.Boolean isShowArrow; // 0x298
	FairyGUI.Transition arrowTransition; // 0x2a0
	System.Func<System.Boolean> extCondition; // 0x2a8
	WizardGames.Soc.SocClient.Ui.ComListArrow.EArrowDirection arrowDirection; // 0x2b0
	System.Action OnDispose; // 0x2b8
	System.Void Init(FairyGUI.GList list, WizardGames.Soc.SocClient.Ui.ComListArrow.EArrowStyle style, System.String iconUrl); // 0x05ae198c
	System.Void SetArrowStyle(WizardGames.Soc.SocClient.Ui.ComListArrow.EArrowStyle style, System.String iconUrl); // 0x05ae1aa0
	System.Void BindList(); // 0x05ae1f5c
	System.Void SetArrowPosition(); // 0x05ae240c
	System.Void BindExtCondition(System.Func<System.Boolean> func); // 0x05ae2650
	System.Void ForceSetArrowVisible(System.Boolean visible); // 0x05ae26d0
	System.Void RefreshArrow(); // 0x05ae282c
	System.Void OnTabListScroll(); // 0x05ae21c4
	System.Void SetArrowVisible(System.Boolean visible); // 0x05ae274c
	System.Void Dispose(); // 0x05ae2890
	System.Void .ctor(); // 0x05ae2910
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ComListArrow.EArrowStyle : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ComListArrow.EArrowStyle UpLeft = 0;
	static WizardGames.Soc.SocClient.Ui.ComListArrow.EArrowStyle DownRight = 1;
	static WizardGames.Soc.SocClient.Ui.ComListArrow.EArrowStyle Double = 2;
	static WizardGames.Soc.SocClient.Ui.ComListArrow.EArrowStyle None = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ComListArrow.EArrowDirection : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ComListArrow.EArrowDirection Up = 0;
	static WizardGames.Soc.SocClient.Ui.ComListArrow.EArrowDirection Down = 1;
	static WizardGames.Soc.SocClient.Ui.ComListArrow.EArrowDirection Left = 2;
	static WizardGames.Soc.SocClient.Ui.ComListArrow.EArrowDirection Right = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComMarquee : FairyGUI.GLabel
{
	ComCommonMarquee core; // 0x298
	System.Void set_fMoveSpeed(System.Single value); // 0x05ae2a10
	System.Void set_fStartStayTime(System.Single value); // 0x05ae2a94
	System.Void set_fEndStayTime(System.Single value); // 0x05ae2b18
	System.Void set_strText(System.String value); // 0x05ae2b9c
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ae2c24
	System.Void OnComponentUpdate(); // 0x05ae2cf4
	System.Void .ctor(); // 0x05ae2dac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComMedalItem : FairyGUI.GComponent
{
	FairyGUI.GLoader bigIcon; // 0x288
	FairyGUI.GLoader smallIcon; // 0x290
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ae2e14
	System.Void SetMedalIcon(System.String bigIconUrl, System.String smallIconUrl); // 0x05ae3014
	System.Void .ctor(); // 0x05ae30e8
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.ModalBtnInfo : System.ValueType
{
	System.String Text; // 0x10
	System.String Style; // 0x18
	System.Action Callback; // 0x20
	System.Boolean IgnoreAutoClosePop; // 0x28
	System.Boolean IsDefaultChoose; // 0x29
	WizardGames.Soc.Common.Data.ActionName HotKey; // 0x2c
	System.Int32 CountDownTime; // 0x30
	System.String CountDownTimeText; // 0x38
	System.Boolean PlayLoopAnim; // 0x40
	System.Void .ctor(System.String text, System.String style, System.Action callback, System.Boolean ignoreAutoClosePop, System.Boolean defaultChose, WizardGames.Soc.Common.Data.ActionName hotKey, System.Int32 countDownTime, System.String countDownTimeText, System.Boolean playLoopAnim); // 0x05ae3150
	System.Void .ctor(System.String text, System.Action callback, System.Boolean ignoreAutoClosePop, System.Boolean defaultChose, WizardGames.Soc.Common.Data.ActionName hotKey, System.Int32 countDownTime, System.String countDownTimeText, System.Boolean playLoopAnim); // 0x05ae329c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComModal : FairyGUI.GLabel
{
	static SocLogger logIns; // 0x0
	FairyGUI.Controller ctrlState; // 0x298
	FairyGUI.Controller ctrlSize; // 0x2a0
	FairyGUI.GLabel titleTxt; // 0x2a8
	FairyGUI.GButton closeBtn; // 0x2b0
	FairyGUI.GList btnList; // 0x2b8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> btnInfos; // 0x2c0
	FairyGUI.GButton get_CloseBtn(); // 0x05ae33c4
	System.Void set_ModalState(WizardGames.Soc.SocClient.Ui.ComModal.EModalState value); // 0x05ae3428
	System.Void set_ModalSize(WizardGames.Soc.SocClient.Ui.ComModal.EModalSize value); // 0x05ae34d8
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ae3588
	System.Void Clear(); // 0x05ae3834
	static System.Void FillBtnInfosWithMsgBoxCfg(WizardGames.Soc.Common.Data.tips.MsgBoxConfig modalCfg, System.Collections.Generic.List<System.Action> btnActs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> outInfos); // 0x05ae38d4
	System.Void SetModalByCfgID(System.Int32 id, System.Collections.Generic.List<System.Action> btnActs); // 0x05ae3d98
	System.Void SetCloseClick(FairyGUI.EventCallback0 onCloseBack); // 0x05ae429c
	System.Void CallClose(); // 0x05ae4330
	System.Void SetTitle(System.String title); // 0x05ae3fa4
	System.Void SetBtnInfos(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> infos); // 0x05ae406c
	FairyGUI.GButton GetButton(System.Int32 index); // 0x05ae43ac
	System.Void SetBtnStyle(System.Int32 index, System.String style); // 0x05ae4450
	System.Void SetBtnText(System.Int32 index, System.String btnText, System.String style); // 0x05ae450c
	System.Void BtnRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05ae4628
	System.Void OnClickBtn(System.Int32 index); // 0x05ae49f4
	System.Void SetEmpty(); // 0x05ae4b10
	System.Void SetSelectedIndex(System.Int32 index); // 0x05ae4b8c
	System.Void ShowTipsButton(System.Int32 languageConstId); // 0x05ae4c14
	FairyGUI.GButton GetCloseButton(); // 0x05ae3798
	System.Void .ctor(); // 0x05ae4d6c
	static System.Void .cctor(); // 0x05ae4e20
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ComModal.EModalState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ComModal.EModalState Normal = 0;
	static WizardGames.Soc.SocClient.Ui.ComModal.EModalState NoClose = 1;
	static WizardGames.Soc.SocClient.Ui.ComModal.EModalState NoBtns = 2;
	static WizardGames.Soc.SocClient.Ui.ComModal.EModalState Max = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ComModal.EModalSize : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ComModal.EModalSize Small = 0;
	static WizardGames.Soc.SocClient.Ui.ComModal.EModalSize Middle = 1;
	static WizardGames.Soc.SocClient.Ui.ComModal.EModalSize Max = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComModal.<>c__DisplayClass30_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComModal <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x05ae498c
	System.Void <BtnRenderer>b__0(); // 0x05ae4ef4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBgEffect01 : WizardGames.Soc.SocClient.Ui.ComBgEffectBase
{
	
	System.String get_FxResourcePath(); // 0x05ae4f64
	System.Void .ctor(); // 0x05ae504c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBgEffect02 : WizardGames.Soc.SocClient.Ui.ComBgEffectBase
{
	
	System.String get_FxResourcePath(); // 0x05ae5118
	System.Void .ctor(); // 0x05ae5200
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBgEffectBase : FairyGUI.GComponent
{
	FairyGUI.GoWrapper fxWrapper; // 0x288
	System.String get_FxResourcePath(); // 0x05ae5264
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ae52e4
	System.Void OnFxDispose(); // 0x05ae5514
	System.Void .ctor(); // 0x05ae50b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComCommonBg : FairyGUI.GComponent
{
	
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ae5680
	System.Void OnAddedToStage(FairyGUI.EventContext context); // 0x05ae5770
	System.Void Dispose(); // 0x05ae5aa0
	System.Void .ctor(); // 0x05ae5b78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComNameMedal : FairyGUI.GLabel
{
	FairyGUI.GLoader medalIcon; // 0x298
	FairyGUI.Controller controller; // 0x2a0
	FairyGUI.Controller controllerLabel; // 0x2a8
	FairyGUI.GGroup layout; // 0x2b0
	FairyGUI.Controller medalIconTypeCtrl; // 0x2b8
	System.Boolean get_IsValid(); // 0x05ae5be0
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ae5d64
	System.Void SetNameMedalData(System.String nickName, Config.EUserPrivacy userPrivacy, System.Int32 rankPoint, System.Boolean isMedal, System.Int32 styleID, System.Int32 medalIconType, System.Int32 mType, System.Int32 Identity); // 0x05ae5f00
	System.Void HideRankIcon(); // 0x05ae6290
	System.String GetMedalNameRankIconUrl(System.Int32 rankScore, System.Int32 styleID); // 0x05ae6148
	System.Int32 GetMedalRankID(System.Int32 rankScore); // 0x05ae6328
	System.Void SetNameMedalData(System.String nickName); // 0x05ae6508
	System.Void .ctor(); // 0x05ae6598
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComNavBarTop : FairyGUI.GComponent
{
	FairyGUI.GList gList; // 0x288
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ae6600
	System.Void .ctor(); // 0x05ae66d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComNavTab : FairyGUI.GComponent
{
	FairyGUI.GList tabList; // 0x288
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> tabGODic; // 0x290
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NavTabData> tabDataLst; // 0x298
	System.Single oriPosX; // 0x2a0
	System.Action<System.Single> adjustFinishedCallback; // 0x2a8
	System.Action<FairyGUI.EventContext,System.Object> onClickTab; // 0x2b0
	System.Single safeX; // 0x2b8
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05ae6738
	System.Void Setup_AfterAdd(FairyGUI.Utils.ByteBuffer buffer, System.Int32 beginPos); // 0x05ae6acc
	System.Void UpdateSafeAreaInfo(); // 0x05ae6dd0
	System.Void Adjust(); // 0x05ae6bcc
	System.Void Dispose(); // 0x05ae6fd8
	System.Void OnRenderTabItem(System.Int32 index, FairyGUI.GObject obj); // 0x05ae70dc
	System.Void OnClickTabItem(FairyGUI.EventContext context); // 0x05ae73d4
	System.Void .ctor(); // 0x05ae7524
	System.Void <Setup_AfterAdd>b__9_0(System.Object _); // 0x05ae7630
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.NavTabData : System.Object
{
	System.Object tagObj; // 0x10
	System.String nameStr; // 0x18
	System.String titleStr; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.QuickChatMessageClient : System.Object
{
	System.Int32 msgId; // 0x10
	WizardGames.Soc.SocClient.RoleInfo role; // 0x18
	System.Boolean isPlaceHolder; // 0x20
	System.Void .ctor(); // 0x05ae76a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComQuickChat : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat btnQuickChat; // 0x10
	FairyGUI.GList presetList; // 0x18
	FairyGUI.GList tabList; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.QuickChatMessageClient> presetDatas; // 0x28
	System.Collections.Generic.List<System.String> tabTitles; // 0x30
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat.ETabType,System.Collections.Generic.List<System.String>> displayStrDic; // 0x38
	System.Collections.Generic.List<System.String> tabIconUrls; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.ComQuickChatBinder binder; // 0x48
	FairyGUI.GComponent get_Root(); // 0x05ae7710
	System.Void .ctor(FairyGUI.GComponent comQuickChat, WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat btnQuickChat); // 0x05ae77b8
	System.Void OnCreate(); // 0x05ae88f8
	System.Void OnEnable(); // 0x05ae8a80
	System.Void OnDisable(); // 0x05ae8b84
	System.Void OnDestroy(); // 0x05ae8c28
	System.Void StartEdit(); // 0x05ae8df0
	System.Void OpenPreview(); // 0x05ae8ed8
	System.Void ClosePreview(); // 0x05ae8f98
	System.Void OnHudBlockElemChange(); // 0x05ae90a8
	System.Void OnListeningCloseWindow(UnityEngine.Vector2 vector); // 0x05ae9220
	System.Void OnHudEditModeChanged(System.Boolean isInEdit); // 0x05ae9544
	System.Void SelectType(WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat.ETabType tabType); // 0x05ae87c4
	System.Void SendMessage(System.Int32 msgId); // 0x05ae9640
	System.Boolean CloseAndCheckSendCD(); // 0x05ae984c
	System.Void OnClickPresetList(FairyGUI.EventContext context); // 0x05ae9c2c
	System.Void OnRenderTabListItem(System.Int32 index, FairyGUI.GObject item); // 0x05ae9ef0
	System.Void InitPlatformComs(); // 0x05ae8898
	System.Void InitTab(); // 0x05ae85f8
	System.Void OpenPresetPanel(); // 0x05aea2ac
	System.Void ClosePresetPanel(); // 0x05ae9b04
	System.Void OnRenderPresetListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05aea42c
	static System.Void .cctor(); // 0x05aea618
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComQuickChat.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ComQuickChat.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__12_0; // 0x8
	static FairyGUI.ListItemProvider <>9__12_1; // 0x10
	static System.Void .cctor(); // 0x05aea6ec
	System.Void .ctor(); // 0x05aea750
	System.Void <.ctor>b__12_0(FairyGUI.EventContext context); // 0x05aea7b8
	System.String <.ctor>b__12_1(System.Int32 i); // 0x05aea83c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComQuickChat.<>c__DisplayClass30_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComQuickChat <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat.ETabType tab; // 0x18
	System.Void .ctor(); // 0x05aea244
	System.Void <OnRenderTabListItem>b__0(FairyGUI.EventContext context); // 0x05aea8c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComQuickChatBubble : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.ComQuickChatBubbleBinder binder; // 0x10
	FairyGUI.GTextField quickChatBubble; // 0x18
	System.Int64 _showTimeId; // 0x20
	FairyGUI.GComponent _root; // 0x28
	FairyGUI.Transition showAnim; // 0x30
	WizardGames.Soc.SocClient.Ui.UiQuickChatBubble _win; // 0x38
	FairyGUI.Controller _controller; // 0x40
	FairyGUI.GComponent rotateNode; // 0x48
	FairyGUI.GImage bg; // 0x50
	System.Int64 senderEntityID; // 0x58
	System.Boolean isColding; // 0x60
	SocLogger logger; // 0x68
	System.Int32 raycastMask; // 0x70
	System.Single HUDAngle; // 0x74
	System.Single MaxDistance; // 0x78
	System.Void set_position(UnityEngine.Vector2 value); // 0x05aea97c
	UnityEngine.Vector2 get_position(); // 0x05aeaa14
	UnityEngine.Vector2 get_topleft(); // 0x05aeaa84
	UnityEngine.Vector2 get_bottomright(); // 0x05aeaaf4
	UnityEngine.Vector2 get_center(); // 0x05aeab94
	System.Void .ctor(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiQuickChatBubble win); // 0x05aeac2c
	System.Void OnCreate(System.Int32 textId, System.Int64 senderEntityId); // 0x05aeb0c4
	System.Void UpdatePosition(UnityEngine.Vector3 worldPos); // 0x05aeb5d8
	UnityEngine.Vector2 GetBubblePos(UnityEngine.Vector3 pos); // 0x05aebde0
	System.Void SetRotateNode(); // 0x05aec000
	System.Void Destroy(); // 0x05aec294
	System.Boolean CanBubbleShow(UnityEngine.Vector3 senderPos); // 0x05aeb798
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComQuickChatBubble.<>c__DisplayClass25_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComQuickChatBubble <>4__this; // 0x10
	System.Int64 senderEntityId; // 0x18
	System.Void .ctor(); // 0x05aeb570
	System.Void <OnCreate>b__0(System.Int64 id, System.Object data, System.Boolean delete); // 0x05aec424
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComRecipeInQueue : ComRecipeBase, WizardGames.Soc.Common.Unity.Ui.IUiFps2Update
{
	System.Action OnClickCancel; // 0x2b0
	WizardGames.Soc.SocClient.Ui.Binder.GameCraft.ComRecipeQueueBinder binder; // 0x2b8
	System.Int64 roundTime; // 0x2c0
	System.Int64 endTime; // 0x2c8
	System.Boolean <IsEmpty>k__BackingField; // 0x2d0
	System.Int32 totalCount; // 0x2d4
	static System.Int64 lastestPlayedFinishAnimTime; // 0x0
	WizardGames.Soc.Common.Data.DataItem.ItemConfig <ItemCfg>k__BackingField; // 0x2d8
	System.Int32 <Position>k__BackingField; // 0x2e0
	FairyGUI.Transition get_AnimDelete(); // 0x05aec518
	FairyGUI.GButton get_Cancel(); // 0x05aec5bc
	System.Boolean get_IsEmpty(); // 0x05aec660
	System.Void set_IsEmpty(System.Boolean value); // 0x05aec6c4
	WizardGames.Soc.Common.Data.DataItem.ItemConfig get_ItemCfg(); // 0x05aec740
	System.Void set_ItemCfg(WizardGames.Soc.Common.Data.DataItem.ItemConfig value); // 0x05aec7a4
	System.Int32 get_Position(); // 0x05aec824
	System.Void set_Position(System.Int32 value); // 0x05aec888
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05aec900
	System.Void SetJoinHook(System.String label, FairyGUI.TransitionHook callback); // 0x05aecca0
	System.Void Dispose(); // 0x05aecd84
	System.Void OnFps2Update(System.Single dt); // 0x05aece1c
	System.Void PlayJoinAnim(System.Single delay, FairyGUI.PlayCompleteCallback onComplete); // 0x05aecfec
	System.Void PlayDeleteAnim(); // 0x05aed0dc
	System.Void PlayMoveAnim(System.Single delay, FairyGUI.PlayCompleteCallback onComplete); // 0x05aed198
	System.Void RegisterEvents(); // 0x05aeca78
	System.Void OnClickCancelHandler(FairyGUI.EventContext context); // 0x05aed288
	System.Void UpdateCountdown(); // 0x05aece94
	System.Void SetEmpty(System.Boolean hasAnim, System.Action callback); // 0x05aed320
	System.Void SetData(WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint, System.Int64 roundTime, System.Int64 endTime, System.Int32 count, System.Int32 totalCount, System.Boolean hasAnim, System.Int64 skinId, System.Boolean isFirst); // 0x05aed758
	System.Int64 UpdateState(); // 0x05aee268
	System.Void .ctor(); // 0x05aee4d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComRecipeInQueue.<>c__DisplayClass33_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComRecipeInQueue <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x05aed6f0
	System.Void <SetEmpty>b__0(); // 0x05aee540
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ERedDotStyle : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ERedDotStyle Invalid = -1;
	static WizardGames.Soc.SocClient.Ui.ERedDotStyle Dot = 0;
	static WizardGames.Soc.SocClient.Ui.ERedDotStyle Num = 1;
	static WizardGames.Soc.SocClient.Ui.ERedDotStyle Exclamation = 2;
	static WizardGames.Soc.SocClient.Ui.ERedDotStyle Text = 3;
	static WizardGames.Soc.SocClient.Ui.ERedDotStyle Custom = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ERedDotNumStyle : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ERedDotNumStyle Style99 = 0;
	static WizardGames.Soc.SocClient.Ui.ERedDotNumStyle Style999 = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComRedDot : FairyGUI.GComponent
{
	FairyGUI.GLoader specialIcon; // 0x288
	FairyGUI.GTextField textValue; // 0x290
	FairyGUI.Controller ctrlStyle; // 0x298
	WizardGames.Soc.SocClient.Ui.RedDotType redDotType; // 0x2a0
	System.String redDotMarkName; // 0x2a8
	WizardGames.Soc.SocClient.Ui.ERedDotNumStyle maxNumStyle; // 0x2b0
	System.Func<WizardGames.Soc.SocClient.Ui.ERedDotStyle> refreshRedDotStyle; // 0x2b8
	System.Void Setup_AfterAdd(FairyGUI.Utils.ByteBuffer buffer, System.Int32 beginPos); // 0x05aee640
	System.Void SetData(WizardGames.Soc.SocClient.Ui.RedDotType type, System.Boolean refresh, System.Func<WizardGames.Soc.SocClient.Ui.ERedDotStyle> styleFunc); // 0x05aee874
	System.Void SetData(System.String markName, System.Boolean refresh, System.Func<WizardGames.Soc.SocClient.Ui.ERedDotStyle> styleFunc); // 0x05aeeaec
	System.Void Dispose(); // 0x05aeed58
	System.Void RefreshByVal(System.Int32 val); // 0x05aeeee4
	System.Void SetNum(System.Int32 num); // 0x05aef0c0
	System.Void SetDotStyle(); // 0x05aef1c0
	System.Void SetNumStyle(); // 0x05aef228
	System.Void SetStyle(WizardGames.Soc.SocClient.Ui.ERedDotStyle style); // 0x05aef020
	System.Void SetCustomValue(System.String url); // 0x05aef290
	System.Void Refresh(System.Boolean refreshData); // 0x05aef330
	System.Void .ctor(); // 0x05aef428
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComRightJoystickGuideView : WizardGames.Soc.SocClient.Ui.ComBaseGuideView
{
	
	FairyGUI.GComponent LoadCom(); // 0x05aef4c4
	System.Void Release(); // 0x05aef5f8
	System.Void .ctor(); // 0x05aef698
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSeasonMedalItem : FairyGUI.GComponent
{
	FairyGUI.GLoader bigIcon; // 0x288
	FairyGUI.GLoader smallIcon; // 0x290
	FairyGUI.Transition rankUpdateTransition; // 0x298
	FairyGUI.Transition updateTransition; // 0x2a0
	FairyGUI.Transition appearTransition; // 0x2a8
	System.String curEffectName; // 0x2b0
	System.String[] bigSeasonEffectNames; // 0x2b8
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05aef724
	System.Void SetSeasonIcon(System.Int32 rankId, System.String smallIconUrl); // 0x05aef9a4
	System.Void .ctor(); // 0x05aefb40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComShowItemModel : System.Object
{
	FairyGUI.GLoader loader; // 0x10
	UnityEngine.GameObject modelGO; // 0x18
	static UnityEngine.RaycastHit[] hitBuffer; // 0x0
	System.Void Hide(); // 0x05aefd4c
	static System.Void .cctor(); // 0x05aefe74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSideShot : FairyGUI.GComponent
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComSideShotBinder Binder; // 0x288
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> modalBtnInfos; // 0x290
	System.Action closeAction; // 0x298
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05aefee8
	System.Void RenderBtnItem(System.Int32 index, FairyGUI.GObject item); // 0x05af02b0
	System.Void SetEmptyTitle(System.String title); // 0x05af04e4
	System.Void SetTitle(System.String mainTitle, System.String subTitle); // 0x05af05b8
	System.Void .ctor(); // 0x05af0704
	System.Void <ConstructFromXML>b__5_0(FairyGUI.EventContext ctx); // 0x05af076c
	System.Void <ConstructFromXML>b__5_1(FairyGUI.EventContext ctx); // 0x05af0804
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSideShot.<>c__DisplayClass7_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ModalBtnInfo btnInfo; // 0x10
	System.Void .ctor(); // 0x05af047c
	System.Void <RenderBtnItem>b__0(FairyGUI.EventContext ctx); // 0x05af089c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSliderBar : FairyGUI.GSlider
{
	
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05af0928
	System.Void SetSliderData(System.Int32 min, System.Int32 max, FairyGUI.ProgressTitleType sliderType); // 0x05af09a8
	System.Void .ctor(); // 0x05af0a84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSliderBarBtn : FairyGUI.GComponent
{
	FairyGUI.GButton lowBtn; // 0x288
	FairyGUI.GButton highBtn; // 0x290
	FairyGUI.GButton btnMax; // 0x298
	WizardGames.Soc.SocClient.Ui.ComSliderBar comSlider; // 0x2a0
	System.Int32 step; // 0x2a8
	System.Int32 mouseScrollStep; // 0x2ac
	FairyGUI.Controller mouseScrollWheelEnableCtrl; // 0x2b0
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05af0aec
	System.Void OnClickMax(FairyGUI.EventContext context); // 0x05af0eac
	System.Void SetSliderData(System.Int32 min, System.Int32 max, System.Int32 step, FairyGUI.ProgressTitleType sliderType); // 0x05af0f98
	System.Void SetChangeBack(FairyGUI.EventCallback0 changeBack); // 0x05af1078
	System.Void RemoveChangeEvent(FairyGUI.EventCallback0 changeBack); // 0x05af110c
	System.Void OnClickAdd(); // 0x05af11a0
	System.Void OnClickSub(); // 0x05af134c
	System.Double GetValue(); // 0x05af14f8
	System.Double GetMaxValue(); // 0x05af159c
	System.Double GetMinValue(); // 0x05af1640
	System.Void SetValue(System.Single value); // 0x05af16e4
	System.Void RefreshPercent(System.Single percent); // 0x05af176c
	System.Void .ctor(); // 0x05af17f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSliderBarText : FairyGUI.GComponent
{
	FairyGUI.GTextField lowText; // 0x288
	FairyGUI.GTextField highText; // 0x290
	WizardGames.Soc.SocClient.Ui.ComSliderBar comSlider; // 0x298
	FairyGUI.Controller mouseScrollWheelEnableCtrl; // 0x2a0
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05af185c
	System.Void .ctor(); // 0x05af1a80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComStateButton : FairyGUI.GButton
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComStateBtn_LittleNewBinder binder; // 0x318
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05af1ae8
	System.Void SetPureText(System.String text); // 0x05af1bb8
	System.Void SetStyle(System.Int32 style); // 0x05af1cb4
	System.Void .ctor(); // 0x05af1d88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTipsFixedSphereGuideView : WizardGames.Soc.SocClient.Ui.ComBaseGuideView
{
	
	System.Void OnStart(); // 0x05af1df0
	System.Void PlayAnim(); // 0x05af222c
	System.Void OnSizeChanged(); // 0x05af22b8
	FairyGUI.GComponent LoadCom(); // 0x05af2340
	System.Void ReleaseGuideCom(); // 0x05af242c
	System.Void Release(); // 0x05af2628
	System.Void .ctor(); // 0x05af26c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTipsRectGuideView : WizardGames.Soc.SocClient.Ui.ComBaseGuideView
{
	static SocLogger logger; // 0x0
	System.Void OnStart(); // 0x05af2754
	System.Void PlayAnim(); // 0x05af2cd8
	System.Void SetAnimValueFrameValue(); // 0x05af2d6c
	System.Void OnSizeChanged(); // 0x05af35c4
	FairyGUI.GComponent LoadCom(); // 0x05af3ab0
	System.Void ReleaseGuideCom(); // 0x05af3b9c
	System.Void SetText(); // 0x05af2b74
	System.Void Release(); // 0x05af3d98
	System.Void .ctor(); // 0x05af3e38
	static System.Void .cctor(); // 0x05af3ec4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTipsRectWeakGuideView : WizardGames.Soc.SocClient.Ui.ComBaseGuideView
{
	
	System.Void OnStart(); // 0x05af3f98
	System.Void PlayAnim(); // 0x05af45dc
	System.Void SetAnimValueFrameValue(); // 0x05af4670
	System.Void OnSizeChanged(); // 0x05af4fb8
	FairyGUI.GComponent LoadCom(); // 0x05af51e4
	System.Void ReleaseGuideCom(); // 0x05af52d0
	System.Void Release(); // 0x05af54cc
	System.Void .ctor(); // 0x05af556c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTipsSphereGuideView : WizardGames.Soc.SocClient.Ui.ComBaseGuideView
{
	
	System.Void OnStart(); // 0x05af55f8
	System.Void PlayAnim(); // 0x05af5aa4
	System.Void OnSizeChanged(); // 0x05af5b30
	FairyGUI.GComponent LoadCom(); // 0x05af5f74
	System.Void ReleaseGuideCom(); // 0x05af6060
	System.Void Release(); // 0x05af625c
	System.Void .ctor(); // 0x05af62fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTipsSphereWeakGuideView : WizardGames.Soc.SocClient.Ui.ComBaseGuideView
{
	
	System.Void OnStart(); // 0x05af6388
	System.Void PlayAnim(); // 0x05af6a28
	System.Void OnSizeChanged(); // 0x05af6ab4
	FairyGUI.GComponent LoadCom(); // 0x05af6d38
	System.Void ReleaseGuideCom(); // 0x05af6e24
	System.Void Release(); // 0x05af7020
	System.Void .ctor(); // 0x05af70c0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.HudButtonType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.HudButtonType Information = 1;
	static WizardGames.Soc.SocClient.Ui.HudButtonType Battle = 2;
	static WizardGames.Soc.SocClient.Ui.HudButtonType ShortCut = 3;
	static WizardGames.Soc.SocClient.Ui.HudButtonType Other = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTouchArea : FairyGUI.GComponent
{
	WizardGames.Soc.SocClient.Ui.UiHudElem _hudElem; // 0x288
	WizardGames.Soc.SocClient.Ui.UiHud _hudWin; // 0x290
	System.Boolean hasInit; // 0x298
	FairyGUI.InputEvent OldCtx; // 0x2a0
	System.Boolean IsTouchEnd; // 0x2a8
	System.Int32 _touchId; // 0x2ac
	static System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.HudButtonType,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.HudButtonType>> _blockDict; // 0x0
	static System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.HudButtonType,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.HudButtonType>> _breakDict; // 0x8
	WizardGames.Soc.SocClient.Ui.HudButtonType get_Type(); // 0x05af714c
	System.Boolean get_IsElemValid(); // 0x05af71bc
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05af72bc
	System.Void Dispose(); // 0x05af7a3c
	System.Void DoInit(); // 0x05af7ab0
	System.Void OnTouchBegin(FairyGUI.EventContext context); // 0x05af7e84
	System.Void OnTouchMove(FairyGUI.EventContext context); // 0x05af8768
	System.Void OnTouchEnd(FairyGUI.EventContext context); // 0x05af889c
	System.Void OnClick(FairyGUI.EventContext context); // 0x05af8c04
	System.Void Break(); // 0x05af83a4
	System.Void Interrupt(); // 0x05af8ce0
	System.Void Block(FairyGUI.EventContext context); // 0x05af8320
	System.Boolean CheckBlock(WizardGames.Soc.SocClient.Ui.HudButtonType type); // 0x05af8270
	WizardGames.Soc.SocClient.Ui.UiHudElem GetHudElem(); // 0x05af7d10
	WizardGames.Soc.SocClient.Ui.UiHud GetHudWin(); // 0x05af7c08
	System.Void InitBlockDict(); // 0x05af74dc
	System.Void InitBreakDict(); // 0x05af7790
	System.Void .ctor(); // 0x05af8d64
	System.Void <DoInit>b__14_0(); // 0x05af8ddc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComAngle : FairyGUI.GComponent
{
	
	System.Void .ctor(); // 0x05af8fd8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComCursor : FairyGUI.GComponent
{
	UnityEngine.Vector3 n26Pos; // 0x288
	UnityEngine.Vector3 n41Pos; // 0x294
	System.Void .ctor(); // 0x05af9040
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ModelConfig : System.Object
{
	UnityEngine.Vector3 DisplayScale; // 0x10
	UnityEngine.Vector3 DisplayRotation; // 0x1c
	UnityEngine.Vector3 DisplayPosOffset; // 0x28
	UnityEngine.Vector3 DisplayRotationPoint; // 0x34
	System.Void .ctor(); // 0x05af90a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ItemModelConfig : WizardGames.Soc.SocClient.Ui.ModelConfig
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig <ItemCfg>k__BackingField; // 0x40
	WizardGames.Soc.Common.Data.DataItem.ItemConfig get_ItemCfg(); // 0x05af91a4
	System.Void set_ItemCfg(WizardGames.Soc.Common.Data.DataItem.ItemConfig value); // 0x05af9208
	System.Single[] get_DisplayOffsetXY(); // 0x05af9288
	System.Boolean get_BlockAxisX(); // 0x05af9368
	System.Void .ctor(System.Int64 itemId); // 0x05af9424
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SkinModelConfig : WizardGames.Soc.SocClient.Ui.ModelConfig
{
	WizardGames.Soc.Common.Data.DataItem.SkinConfig <SkinCfg>k__BackingField; // 0x40
	WizardGames.Soc.Common.Data.DataItem.SkinConfig get_SkinCfg(); // 0x05af97b8
	System.Void set_SkinCfg(WizardGames.Soc.Common.Data.DataItem.SkinConfig value); // 0x05af981c
	System.Void .ctor(System.Int64 skinId); // 0x05af989c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComUiModel : FairyGUI.GComponent
{
	static SocLogger logger; // 0x0
	FairyGUI.GLoader loaderModel; // 0x288
	FairyGUI.GLoader loaderIcon; // 0x290
	System.Single TOUCH_ROTATE_FACTOR_X; // 0x298
	System.Single TOUCH_ROTATE_FACTOR_Y; // 0x29c
	WizardGames.Soc.SocClient.Ui.ItemModelConfig modelConfig; // 0x2a0
	WizardGames.Soc.Common.Data.DataItem.SkinConfig skinConfig; // 0x2a8
	WizardGames.Soc.Common.Data.resource.OBJSkin commonSkinConfig; // 0x2b0
	System.String itemModelPath; // 0x2b8
	WizardGames.Soc.Common.Data.DataItem.SkinCharm skinCharmConfig; // 0x2c0
	System.String charmModelPath; // 0x2c8
	UnityEngine.Vector2 lastTouchPos; // 0x2d0
	System.Boolean IsTouchingModel; // 0x2d8
	System.Boolean AutoStraighten; // 0x2d9
	WizardGames.Soc.SocClient.Ui.MgrUiModel.StageInfo stageInfo; // 0x2e0
	UnityEngine.GameObject curModelGo; // 0x2e8
	UnityEngine.GameObject curCharmModelGo; // 0x2f0
	UnityEngine.Camera StateCamera; // 0x2f8
	UnityEngine.GameObject objRotateX; // 0x300
	UnityEngine.GameObject objRotateY; // 0x308
	UnityEngine.Quaternion initialRotation; // 0x310
	System.Boolean isSetRotate; // 0x320
	System.Single rotateSpeed; // 0x324
	System.Boolean <IsShowSceneType>k__BackingField; // 0x328
	WizardGames.Soc.SocClient.Manager.EPreviewType <PreviewType>k__BackingField; // 0x32c
	System.Int32 <PreviewBgId>k__BackingField; // 0x330
	System.Int32 curBgId; // 0x334
	UnityEngine.Material matOriBac; // 0x338
	UnityEngine.Material matDynamicBac; // 0x340
	UnityEngine.Renderer bgRenderer; // 0x348
	UnityEngine.GameObject objModelHolder; // 0x350
	System.Collections.Generic.HashSet<System.String> usePoolKeys; // 0x358
	System.Boolean DestroyModelResOnFree; // 0x360
	System.Boolean showSpecialModel; // 0x361
	System.Int64 showSkinId; // 0x368
	System.Int64 showItemId; // 0x370
	System.Int64 showSkinCharmId; // 0x378
	UnityEngine.AzureSky.AzureWeatherPresetEnum azureType; // 0x380
	UnityEngine.AzureSky.EAzureControllerPresetEnum newPreset; // 0x384
	System.Boolean isUseModify; // 0x388
	System.Boolean useMallPosConfig; // 0x389
	FairyGUI.GLoader get_LoaderModel(); // 0x05af9c30
	UnityEngine.GameObject get_CurModelGo(); // 0x05af9c94
	UnityEngine.GameObject get_CurCharmModelGo(); // 0x05af9cf8
	UnityEngine.GameObject get_ObjRotateY(); // 0x05af9d5c
	System.Void set_IsShowSceneType(System.Boolean value); // 0x05af9dc0
	System.Boolean get_IsShowSceneType(); // 0x05af9e3c
	System.Void set_PreviewType(WizardGames.Soc.SocClient.Manager.EPreviewType value); // 0x05af9ea0
	WizardGames.Soc.SocClient.Manager.EPreviewType get_PreviewType(); // 0x05af9f18
	System.Void set_PreviewBgId(System.Int32 value); // 0x05af9f7c
	System.Int32 get_PreviewBgId(); // 0x05af9ff4
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05afa058
	System.Void SetScenePreview(WizardGames.Soc.SocClient.Manager.EPreviewType previewType, System.Int32 previewBgId); // 0x05afa1b4
	System.Void SetScenePreview(WizardGames.Soc.SocClient.Manager.EPreviewType previewType, System.Int32 previewBgId, UnityEngine.AzureSky.AzureWeatherPresetEnum azureType, UnityEngine.AzureSky.EAzureControllerPresetEnum newPreset); // 0x05afa490
	System.ValueTuple<UnityEngine.AzureSky.AzureWeatherPresetEnum,UnityEngine.AzureSky.EAzureControllerPresetEnum> GetAzureType(WizardGames.Soc.SocClient.Manager.EPreviewType previewType); // 0x05afa330
	System.Void InitData(System.String gameObjName); // 0x05afa624
	System.Void SetTouchRotateFactor(System.Single x, System.Single y); // 0x05afad64
	System.Void EnableTouchRotate(); // 0x05afade8
	System.Void OnModelTouchBegin(FairyGUI.EventContext ctx); // 0x05afaf90
	System.Void OnModelTouchMove(FairyGUI.EventContext ctx); // 0x05afb07c
	System.Void OnModeTouchEnd(FairyGUI.EventContext ctx); // 0x05afb2b8
	System.Void OnComponentUpdate(); // 0x05afb330
	UnityEngine.GameObject GoPoolGetAndRecord(System.String modelPath); // 0x05afb46c
	System.String GetModelPathFromPool(System.String modelPath); // 0x05afb538
	System.Void FreeAllGoPools(); // 0x05afb710
	System.Void FreeLastModel(); // 0x05afb940
	System.Void FreeLastCharmModel(); // 0x05afbaf4
	System.Void SetOffset(UnityEngine.Vector3 offset); // 0x05afbcb0
	System.Void SetSceneCameraPlan(System.Int32 planId); // 0x05afbe98
	System.Void SetItemData(System.Int64 itemId, System.Int64 skinId, System.Int64 skinCharmId, System.Boolean showAfterSet, System.Boolean onlyShowIcon, System.Boolean useMallPosConfig); // 0x05afbf94
	System.Void SetCharmData(System.Int64 skinCharmId); // 0x05afc794
	System.Void SetResouceData(System.Int64 itemId, System.Int64 skinId, System.Boolean showAfterSet, System.Boolean onlyShowIcon); // 0x05afc998
	System.Void SetItemModel(); // 0x05afd060
	System.Void HangCharmModel(); // 0x05afdf00
	System.Void EnableRotate(FairyGUI.GObject touchArea, WizardGames.Soc.SocClient.Manager.ERotateMode rotateMode, System.Single horizontalAngleOffset, System.Single verticalAngleOffset); // 0x05afe290
	System.Void ResetModelRotate(); // 0x05afe44c
	System.Void SetItemPic(); // 0x05afdca4
	System.Void Show(System.Boolean useLoaderSize); // 0x05afc4d0
	System.Void Hide(); // 0x05afe704
	System.Void SetPreviewVisible(System.Boolean isShow); // 0x05afe538
	System.Void SwitchWeather(); // 0x05afe8cc
	System.Void Dispose(); // 0x05afe974
	System.Boolean AdjustMaterial(); // 0x05afed0c
	System.Void OnAllLoadComplete(UnityEngine.GameObject objBg, UnityEngine.GameObject objModel); // 0x05afef40
	System.Void ResetBg(); // 0x05afec18
	System.Void RefreshBg(); // 0x05aff034
	System.Void SetBg(System.Int32 bgId); // 0x05aff220
	System.Void .ctor(); // 0x05aff2b4
	static System.Void .cctor(); // 0x05aff384
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComUiPlayerModel : FairyGUI.GComponent
{
	System.Int32 curBgId; // 0x288
	UnityEngine.Material matOriBac; // 0x290
	UnityEngine.Material matDynamicBac; // 0x298
	UnityEngine.Renderer bgRenderer; // 0x2a0
	FairyGUI.GLoader loaderMan; // 0x2a8
	WizardGames.Soc.SocClient.GoLoader.DisplayModel <displayModel>k__BackingField; // 0x2b0
	UnityEngine.GameObject objModelRoot; // 0x2b8
	UnityEngine.GameObject objPlayerPreview; // 0x2c0
	UnityEngine.Camera camPlayerModel; // 0x2c8
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent objPlayerModelPoint; // 0x2d0
	WizardGames.Soc.Common.CustomType.PlayerDisplayData displayData; // 0x2d8
	UnityEngine.Vector3 manOriEulerAng; // 0x2e0
	UnityEngine.Vector2 lastTouchPos; // 0x2ec
	System.Boolean IsTouchingModel; // 0x2f4
	System.Boolean isModelInited; // 0x2f5
	WizardGames.Soc.SocClient.Ui.MgrUiModel.StageInfo stageInfo; // 0x2f8
	System.Int64 templateID; // 0x300
	System.Boolean isSetTod; // 0x308
	UnityEngine.AzureSky.AzureWeatherPresetEnum azureType; // 0x30c
	UnityEngine.AzureSky.EAzureControllerPresetEnum newPreset; // 0x310
	System.String createAnimPath; // 0x318
	System.Boolean isPlaySuitAnim; // 0x320
	System.String DefaultIdleAnimPath; // 0x328
	System.String DefaultStartAnimPath; // 0x330
	System.Boolean <IsShowSceneType>k__BackingField; // 0x338
	WizardGames.Soc.SocClient.Manager.EPreviewType <PreviewType>k__BackingField; // 0x33c
	System.Int32 <PreviewBgId>k__BackingField; // 0x340
	System.Action OnModelLoadEnd; // 0x348
	UnityEngine.Vector3 PreviewScenePos; // 0x350
	WizardGames.Soc.Common.Unity.Ui.WindowComBase curWindowCom; // 0x360
	System.Boolean isUseModify; // 0x368
	System.Boolean playSuitPerformance; // 0x369
	DG.Tweening.Tween cameraTween; // 0x370
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> saveColorDic; // 0x378
	System.Void set_displayModel(WizardGames.Soc.SocClient.GoLoader.DisplayModel value); // 0x05aff458
	WizardGames.Soc.SocClient.GoLoader.DisplayModel get_displayModel(); // 0x05aff4d8
	System.Void set_IsShowSceneType(System.Boolean value); // 0x05aff53c
	System.Boolean get_IsShowSceneType(); // 0x05aff5b8
	System.Void set_PreviewType(WizardGames.Soc.SocClient.Manager.EPreviewType value); // 0x05aff61c
	WizardGames.Soc.SocClient.Manager.EPreviewType get_PreviewType(); // 0x05aff694
	System.Void set_PreviewBgId(System.Int32 value); // 0x05aff6f8
	System.Int32 get_PreviewBgId(); // 0x05aff770
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05aff7d4
	static WizardGames.Soc.SocClient.Ui.ComUiPlayerModel InitModel(FairyGUI.GLoader loader, System.String name, System.Int64 templateID, WizardGames.Soc.SocClient.GoLoader.ModelType modelType, WizardGames.Soc.SocClient.Ui.PlayerAppearanceInfo appearanceInfo, WizardGames.Soc.SocClient.Ui.MgrUiModel.ModelType type, System.Action<WizardGames.Soc.SocClient.Ui.ComUiPlayerModel> action, WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x05aff8d0
	static WizardGames.Soc.SocClient.Ui.ComUiPlayerModel OnlyInitModel(FairyGUI.GLoader loader); // 0x05b00cb4
	UnityEngine.GameObject GetObjModelRoot(); // 0x05b00df0
	System.Void AlignCameraLocator(); // 0x05b00e54
	System.Boolean PlayAnim(System.String animPath, System.String placeholderName, System.String stateName); // 0x05b00f70
	System.Boolean PlaySuitPerformance(WizardGames.Soc.SocClient.Suit.SuitPerformanceStage stage); // 0x05b011f0
	System.Boolean StopSuitPerformance(); // 0x05b01318
	System.Boolean PlayGestureAnim(System.String animPath); // 0x05b01420
	System.Void TriggerInterruptEvent(System.String placeholderName); // 0x05b01528
	WizardGames.Soc.SocClient.GoLoader.DisplayWeapon AddHandWeapon(WizardGames.Soc.SocClient.GoLoader.IWeaponData weaponData, WizardGames.Soc.Common.Data.DataItem.SkinWeaponDisplayAnim weaponDisplayAnim, System.Action<WizardGames.Soc.SocClient.GoLoader.DisplayWeapon> afterGoLoadedHandler); // 0x05b0164c
	System.Void RemoveHandWeapon(System.Boolean reloadAnim); // 0x05b01790
	System.Void SetScenePreview(WizardGames.Soc.SocClient.Manager.EPreviewType previewType, System.Int32 previewBgId, System.Boolean isSetTod, System.Int32 previewBgPosX, System.Int32 previewBgPosY, System.Int32 previewBgPosZ); // 0x05b01868
	System.Void SetScenePreview(WizardGames.Soc.SocClient.Manager.EPreviewType previewType, System.Int32 previewBgId, UnityEngine.AzureSky.AzureWeatherPresetEnum presetEnum, UnityEngine.AzureSky.EAzureControllerPresetEnum controllerPresetEnum, System.Boolean isSetTod, System.Int32 previewBgPosX, System.Int32 previewBgPosY, System.Int32 previewBgPosZ); // 0x05b01b5c
	System.ValueTuple<UnityEngine.AzureSky.AzureWeatherPresetEnum,UnityEngine.AzureSky.EAzureControllerPresetEnum> GetAzureType(WizardGames.Soc.SocClient.Manager.EPreviewType previewType); // 0x05b01a54
	System.Void InitModel(System.Int64 templateID, WizardGames.Soc.SocClient.GoLoader.DisplayModel _displayModel, WizardGames.Soc.SocClient.Ui.MgrUiModel.ModelType type, System.Boolean useLoaderSize, WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x05b01d60
	System.Void OnAllLoadComplete(UnityEngine.GameObject objBg, UnityEngine.GameObject objModel); // 0x05b02b54
	System.Void InitModel(System.String name, System.Int64 templateID, WizardGames.Soc.SocClient.GoLoader.ModelType modelType, WizardGames.Soc.SocClient.Ui.PlayerAppearanceInfo appearanceInfo, WizardGames.Soc.SocClient.Ui.MgrUiModel.ModelType type, System.Boolean usePlayerEntity, WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x05affbdc
	System.Void EnableRotate(FairyGUI.GObject touchArea, WizardGames.Soc.SocClient.Manager.ERotateMode rotateMode, System.Single horizontalAngleOffset, System.Single verticalAngleOffset); // 0x05b03294
	System.Void SetTouch(System.Boolean enableTouch); // 0x05b0343c
	System.Void SetPlayData(WizardGames.Soc.Common.CustomType.PlayerDisplayData playData); // 0x05b034c4
	System.Void SetOffset(UnityEngine.Vector3 offset); // 0x05b030ac
	System.Void SetSceneCameraPlan(System.Int32 planId); // 0x05b03544
	System.Void ChangeSex(System.Int32 sex); // 0x05b03640
	System.Void SetDefalutModel(System.Int32 sex); // 0x05b02e98
	System.Void SetCamreaTrack(System.Int32 track); // 0x05b02824
	System.Void SetCameraTemplateID(System.Int32 templateID); // 0x05b038c8
	System.Void StopCameraTween(); // 0x05b0394c
	System.Void ChangeAppearance(WizardGames.Soc.SocClient.Ui.PlayerAppearanceInfo info); // 0x05b02f90
	System.Void OnComponentUpdate(); // 0x05b039ec
	System.Void VerdictModelSex(System.Int32 skinId); // 0x05b03b90
	System.Void Show(System.Boolean useLoaderSize); // 0x05b02664
	System.Void Hide(); // 0x05b03eb0
	System.Void SetVisiblePlayOnly(System.Boolean isShow); // 0x05b040a4
	System.Void SetPreviewVisible(System.Boolean isShow); // 0x05b03cf4
	System.Void PutOn(System.Int32 itemId, System.Int32 skinId); // 0x05b04178
	System.Void PutOn(System.Collections.Generic.List<System.Int32> itemIds, System.Collections.Generic.List<System.Int32> skinIds); // 0x05b043bc
	System.Void SetPlayerEquip(System.Collections.Generic.Dictionary<System.Int32,System.Int32> equips, System.Boolean callUpdate); // 0x05b046dc
	System.Void TransToColorSkin(System.Collections.Generic.Dictionary<System.Int32,System.Int32> skinDic); // 0x05b04984
	System.Void TransToColorSkinList(System.Collections.Generic.List<System.Int32> skinList); // 0x05b0458c
	System.Void SetStartAnim(System.Int32 id); // 0x05b04ca8
	System.Void SetSpecialIdleAnim(System.Int32 id); // 0x05b04d74
	System.Void ClearSpecialIdleAnim(); // 0x05b04f28
	System.Void UpdateAllPart(); // 0x05b04308
	System.Void PutOnPlan(System.Collections.Generic.Dictionary<System.Int32,System.Int32> useDic, System.Collections.Generic.Dictionary<System.Int32,System.Int32> useCostume); // 0x05b04f9c
	System.Void Dispose(); // 0x05b054ec
	System.Void ResetBg(); // 0x05b05894
	System.Void SetBg(System.Int32 bgId); // 0x05b05988
	System.Void RefreshBg(); // 0x05b02cac
	System.Void OnModeTouchBegin(FairyGUI.EventContext ctx); // 0x05b05a1c
	System.Void OnModeTouchMove(FairyGUI.EventContext ctx); // 0x05b05b08
	System.Void OnModeTouchEnd(FairyGUI.EventContext ctx); // 0x05b05ca8
	System.Void OnFps30Update(System.Single dt); // 0x05b05d20
	System.Void .ctor(); // 0x05affac4
	System.Void <InitModel>b__63_0(); // 0x05b05e90
	System.Void <InitModel>b__65_0(); // 0x05b05fa0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlayerAppearanceInfo : System.Object
{
	System.Int32 FaceId; // 0x10
	System.Int32 Sex; // 0x14
	System.Int32 HairID; // 0x18
	System.Int32 HairColorID; // 0x1c
	System.Void Clear(); // 0x05b06384
	System.Void .ctor(); // 0x05b063f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComVideo : FairyGUI.GComponent
{
	static SocLogger <Logger>k__BackingField; // 0x0
	WizardGames.Soc.SocClient.Ui.ComCommonVideo <videoPlayer>k__BackingField; // 0x288
	WizardGames.Soc.SocClient.Ui.ComCommonVideoSubtitle <videoSubtitle>k__BackingField; // 0x290
	static System.String <subtitleVideoPath>k__BackingField; // 0x8
	static System.Int32 originalFrameRate; // 0x10
	System.Int64 videoPlayerSubtitleTimerId; // 0x298
	static SocLogger get_Logger(); // 0x05b06468
	WizardGames.Soc.SocClient.Ui.ComCommonVideo get_videoPlayer(); // 0x05b064f0
	System.Void set_videoPlayer(WizardGames.Soc.SocClient.Ui.ComCommonVideo value); // 0x05b06554
	WizardGames.Soc.SocClient.Ui.ComCommonVideoSubtitle get_videoSubtitle(); // 0x05b065d4
	System.Void set_videoSubtitle(WizardGames.Soc.SocClient.Ui.ComCommonVideoSubtitle value); // 0x05b06638
	static System.String get_subtitleVideoPath(); // 0x05b066b8
	static System.Void set_subtitleVideoPath(System.String value); // 0x05b06740
	System.Boolean get_IsPlaying(); // 0x05b067d4
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05b068d4
	System.Void SetVideoLoaderVisible(System.Boolean visible); // 0x05b06b74
	System.Void PlayFromUrl(System.String url, System.Boolean isLoop); // 0x05b06cec
	System.Void Play(System.String path, System.Boolean isLoop); // 0x05b06fe4
	System.Void InitVideoPlayer(System.Int32 w, System.Int32 h); // 0x05b071fc
	System.Void RestoreFrameRate(); // 0x05b07320
	System.Void Stop(); // 0x05b0765c
	System.Void Dispose(); // 0x05b07958
	System.Void DisposePlayer(); // 0x05b079d0
	static System.String TransVideoPath(System.String videoPath); // 0x05b07c88
	System.Void PlayCommercialVideo(System.String videoLink, System.Boolean isLoop); // 0x05b0821c
	static System.String GetVideoSubtitlePath(System.String videoName); // 0x05b083f0
	System.Void PlayVideoSubtitle(); // 0x05b06f04
	System.Threading.Tasks.Task InitVideoSubtitle(); // 0x05b085b0
	System.Void StopVideoSubtitle(); // 0x05b07810
	System.Void DisposeVideoSubtitle(); // 0x05b07b34
	System.Void set_OnPrepareCompleted(System.Action<UnityEngine.Video.VideoPlayer> value); // 0x05b086c0
	System.Void set_OnVideoLoopPointReached(System.Action<UnityEngine.Video.VideoPlayer> value); // 0x05b0878c
	System.Void set_OnFirstFrameReady(System.Action<UnityEngine.Video.VideoPlayer> value); // 0x05b08858
	System.Void Play(); // 0x05b08924
	static System.String GetVideoRootPath(); // 0x05b0819c
	System.Void .ctor(); // 0x05b08a74
	static System.Void .cctor(); // 0x05b08adc
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.ComVideo.<InitVideoSubtitle>d__38 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Ui.ComVideo <>4__this; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x38
	System.Void MoveNext(); // 0x05b08bc4
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x05b09014
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.ComVideo.<PlayVideoSubtitle>d__37 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Ui.ComVideo <>4__this; // 0x38
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x40
	System.Void MoveNext(); // 0x055049cc
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x05b09834
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComWaterContainerItem : FairyGUI.GButton
{
	System.Boolean successConstructed; // 0x311
	WizardGames.Soc.SocClient.Ui.ComItemIcon comItem; // 0x318
	FairyGUI.GObject comName; // 0x320
	FairyGUI.GObject comHint; // 0x328
	FairyGUI.GObject comTotBar; // 0x330
	FairyGUI.GObject comVolume; // 0x338
	FairyGUI.GLoader comNowBar; // 0x340
	FairyGUI.GObject comMask; // 0x348
	System.String strNotHave; // 0x350
	System.String strUnitWater; // 0x358
	static System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> SetupItem; // 0x0
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05b098b4
	System.Void .ctor(); // 0x05b09ccc
	static System.Void .cctor(); // 0x05b09d34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComWaterContainerItem.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ComWaterContainerItem.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x05b09e04
	System.Void .ctor(); // 0x05b09e68
	System.Void <.cctor>b__14_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05b09ed0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComDragIcon : FairyGUI.GComponent
{
	
	System.Void .ctor(); // 0x05b0a20c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComPlaidDrag : FairyGUI.GComponent
{
	
	System.Void .ctor(); // 0x05b0a274
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComAutoIcon : FairyGUI.GComponent
{
	WizardGames.Soc.SocClient.Ui.ComBaseIcon curIcon; // 0x288
	WizardGames.Soc.SocClient.Ui.ComBaseIcon get_AsBaseIcon(); // 0x05b0a2dc
	WizardGames.Soc.SocClient.Ui.ComItemIcon get_AsItemIcon(); // 0x05b0a340
	WizardGames.Soc.SocClient.Ui.ComResIcon get_AsResIcon(); // 0x05b0a520
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05b0a70c
	System.Void ReleaseCurIcon(); // 0x05b0a834
	System.Void AdjustIconState(); // 0x05b0abf4
	WizardGames.Soc.SocClient.Ui.ComItemIcon SwitchToItemIcon(); // 0x05b0a3a4
	WizardGames.Soc.SocClient.Ui.ComResIcon SwitchToResIcon(); // 0x05b0a584
	WizardGames.Soc.SocClient.Ui.ComBaseIcon SwithToSameTypeWith(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05b0ada0
	System.Void .ctor(); // 0x05b0aebc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.IconDoubleClickCfg : System.Object
{
	System.String tips; // 0x10
	System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> onDoubleClick; // 0x18
	System.Func<WizardGames.Soc.SocClient.Ui.ComItemIcon,System.Boolean> checkDoubleClick; // 0x20
	System.Boolean CheckAction(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05b0af24
	System.Void .ctor(); // 0x05b0afb4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.IconAutoUnChooseMethod : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.IconAutoUnChooseMethod Always = 0;
	static WizardGames.Soc.SocClient.Ui.IconAutoUnChooseMethod OnDataChange = 1;
	static WizardGames.Soc.SocClient.Ui.IconAutoUnChooseMethod Nerver = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.SlowDragDir : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.SlowDragDir None = 0;
	static WizardGames.Soc.SocClient.Ui.SlowDragDir Horizontal = 1;
	static WizardGames.Soc.SocClient.Ui.SlowDragDir Vertical = 2;
	static WizardGames.Soc.SocClient.Ui.SlowDragDir Both = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EComItemWidgetType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EComItemWidgetType None = -1;
	static WizardGames.Soc.SocClient.Ui.EComItemWidgetType ItemIconFrequency = 0;
	static WizardGames.Soc.SocClient.Ui.EComItemWidgetType ItemIconSlot = 1;
	static WizardGames.Soc.SocClient.Ui.EComItemWidgetType ItemIconSeed = 2;
	static WizardGames.Soc.SocClient.Ui.EComItemWidgetType Max = 3;
	
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.IComItemWidget : 
{
	
	System.Void OnShowWidget(WizardGames.Soc.SocClient.Ui.ComBaseIcon owner, WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x0552d210
	System.Void OnCheckClearWidget(WizardGames.Soc.SocClient.Ui.ComBaseIcon owner, WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x0552d210
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBaseIcon : FairyGUI.GComponent
{
	System.Single oriWidth; // 0x288
	System.Single oriHeight; // 0x28c
	FairyGUI.GLoader loaderBac; // 0x290
	FairyGUI.GLoader loaderBg; // 0x298
	FairyGUI.GTextField textValue; // 0x2a0
	FairyGUI.GObject objDarkCover; // 0x2a8
	System.Boolean <DisableTouchEffect>k__BackingField; // 0x2b0
	FairyGUI.Controller ctrlBacStyle; // 0x2b8
	FairyGUI.GObject objBacChooseOri; // 0x2c0
	FairyGUI.GObject objBacChoose; // 0x2c8
	FairyGUI.Controller ctrlBottomStyle; // 0x2d0
	FairyGUI.GObject imgFlagEmptyOri; // 0x2d8
	FairyGUI.GObject imgFlagEmpty; // 0x2e0
	FairyGUI.GLoader <loaderIcon>k__BackingField; // 0x2e8
	FairyGUI.Controller ctrlEmptyStyle; // 0x2f0
	FairyGUI.Controller ctrlPressState; // 0x2f8
	FairyGUI.GImage rareBg; // 0x300
	System.Single lastComUpdateTime; // 0x308
	WizardGames.Soc.SocClient.Ui.SlowDragDir slowDragDir; // 0x30c
	System.Boolean <bInTouch>k__BackingField; // 0x310
	System.Single fDragDeltaTime; // 0x314
	System.Single slowDragTriggerTime; // 0x318
	System.Single slowDragTriggerAngle; // 0x31c
	UnityEngine.Vector2 v2StartDragPos; // 0x320
	System.Int32 iCurTouchID; // 0x328
	System.Boolean EnableUpdateLock; // 0x32c
	System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon> OnClickIcon; // 0x330
	System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon,System.Boolean> OnChoose; // 0x338
	System.Action<System.Object> OnNoDragReceiver; // 0x340
	System.Func<WizardGames.Soc.SocClient.Ui.ItemDragInfo,System.Boolean> OnIconDragStart; // 0x348
	System.Action OnIconDragEnd; // 0x350
	System.Func<WizardGames.Soc.SocClient.Ui.ComBaseIcon,WizardGames.Soc.SocClient.Ui.ItemDragInfo,System.Boolean> OnIconAcceptDrag; // 0x358
	System.Action<FairyGUI.EventContext> OnMouseOrTouchBegin; // 0x360
	System.Action<FairyGUI.EventContext> OnMouseOrTouchEnd; // 0x368
	System.Action<FairyGUI.EventContext> OnMouseOrTouchMoveIn; // 0x370
	System.Action<FairyGUI.EventContext> OnMouseOrTouchMoveOut; // 0x378
	System.Boolean CanDrag; // 0x380
	System.Boolean SlowDragOnly; // 0x381
	System.Boolean StopParentMoveWhenDrag; // 0x382
	System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon,System.Boolean> OnSetIconEnable; // 0x388
	System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon> OnIconDisableClick; // 0x390
	System.Action<System.Int32> OnIconLockUpdate; // 0x398
	System.Action OnIconUnlockUpdate; // 0x3a0
	System.Boolean <IsIconEnable>k__BackingField; // 0x3a8
	System.Boolean CanChooseOnEmpty; // 0x3a9
	System.Boolean <EnablePressState>k__BackingField; // 0x3aa
	System.Boolean IsClickSoundEnable; // 0x3ab
	System.Boolean IsDragSoundEnable; // 0x3ac
	System.Boolean IsDropSoundEnable; // 0x3ad
	UnityEngine.Vector2 iconStartTouchGlobalPos; // 0x3b0
	System.Boolean UseStrictClick; // 0x3b8
	FairyGUI.GObject triggerArea; // 0x3c0
	System.Single IconStandardAlpha; // 0x3c8
	System.Func<WizardGames.Soc.Common.Data.DataItem.ItemConfig,System.String> IconUrlHandler; // 0x3d0
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EComItemWidgetType,WizardGames.Soc.SocClient.Ui.IComItemWidget> itemWidgetDic; // 0x3d8
	System.Boolean isMouseOrTouchMoveIn; // 0x3e0
	System.Single get_BacAlpha(); // 0x05b0b01c
	System.Void set_BacAlpha(System.Single value); // 0x05b0b0c0
	FairyGUI.GTextField get_TextValue(); // 0x05b0b148
	System.Boolean get_BeDark(); // 0x05b0b1ac
	System.Void set_BeDark(System.Boolean value); // 0x05b0b250
	System.Boolean get_DisableTouchEffect(); // 0x05b0b454
	System.Void set_DisableTouchEffect(System.Boolean value); // 0x05b0b4b8
	System.Void set_ChooseAlpha(System.Single value); // 0x05b0b534
	System.Void set_FlagEmptyStyle(System.String value); // 0x05b0b5bc
	FairyGUI.GLoader get_loaderIcon(); // 0x05b0b66c
	System.Void set_loaderIcon(FairyGUI.GLoader value); // 0x05b0b6d0
	System.Boolean get_bInTouch(); // 0x05b0b750
	System.Void set_bInTouch(System.Boolean value); // 0x05b0b7b4
	System.Boolean get_IsIconEnable(); // 0x05b0b830
	System.Void set_IsIconEnable(System.Boolean value); // 0x05b0b894
	System.Boolean get_EnablePressState(); // 0x05b0b910
	System.Void set_EnablePressState(System.Boolean value); // 0x05b0b974
	System.Boolean get_Choose(); // 0x05b0b9f0
	System.Void set_Choose(System.Boolean value); // 0x05b0ba94
	System.Boolean get_IsEmpty(); // 0x05b0bc44
	System.Boolean IsIconEmpty(); // 0x054c4760
	System.Void OnPlayIconClickSound(); // 0x055049cc
	System.Void OnPlayIconDragSound(); // 0x055049cc
	System.Void OnPlayIconAcceptSound(WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05523a54
	WizardGames.Soc.SocClient.Ui.ItemDragInfo GetDragInfo(); // 0x054e7844
	System.Void CheckAllWidgetsLoad(); // 0x05b0bca8
	System.Void CheckAllWidgetsUnload(); // 0x05b0bd08
	System.Void CopyFromIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05b0bd68
	System.Void InitItemWidgets(); // 0x05b0bddc
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05b0be3c
	System.Void OnInit(); // 0x05b0bed0
	System.Void ResetForRecovery(); // 0x055049cc
	System.Void ClearAllWidgetsUI(); // 0x05b0a9e4
	WizardGames.Soc.SocClient.Ui.IComItemWidget GetWidget(WizardGames.Soc.SocClient.Ui.EComItemWidgetType widgetType); // 0x05b0d138
	System.Void LockUpdateIfEnableLock(System.Int32 frame); // 0x05b0b354
	System.Void UnlockUpdateIfEnableLock(System.Boolean skipFrame); // 0x05b0cf44
	System.Void SetBgVisible(System.Boolean visible); // 0x05b0d1e8
	System.Void SetPressState(System.Boolean isPress); // 0x05b0d27c
	System.Void SetPressOverState(System.Boolean isOver); // 0x05b0d368
	System.Void SetSlowDragCfg(System.Single time, System.Single angle); // 0x05b0c630
	System.Void SetHorizontalDragSlow(System.Single time, System.Single angle); // 0x05b0d45c
	System.Void SetVerticalDragSlow(System.Single time, System.Single angle); // 0x05b0d4f4
	System.Void DisableDragSlow(); // 0x05b0cd40
	System.Boolean IsSlowDragDir(UnityEngine.Vector2 start, UnityEngine.Vector2 end); // 0x05b0d590
	System.Void OnTouchStart(FairyGUI.EventContext context); // 0x05b0d730
	System.Void ResetDragState(); // 0x05b0da8c
	System.Void OnRollOut(FairyGUI.EventContext context); // 0x05523a54
	System.Boolean PassByStrictClick(); // 0x05b0deb8
	System.Void OnTouchEnd(FairyGUI.EventContext context); // 0x05b0dfec
	System.Void OnRollOver(FairyGUI.EventContext context); // 0x05523a54
	System.Void OnItemDrop(FairyGUI.EventContext context); // 0x05b0e3ac
	System.Void SetAsInvalid(); // 0x055049cc
	System.Boolean IsInvalid(); // 0x05b0e5c0
	System.Void SetInteractiveState(System.Boolean canInteractive, System.Single alpha); // 0x05b0e650
	System.Void SetShowIconOnly(System.Boolean withBac); // 0x05b0e790
	System.Boolean SetEmpty(System.Boolean force); // 0x054deca4
	System.Void SetAlpha(System.Single a, System.Boolean flushToStandardAlpha); // 0x05b0e88c
	System.Void SetValue(System.String value); // 0x05b0ec1c
	System.Void SetValue(System.Int32 value, System.Boolean isStack, System.Boolean forceValue); // 0x05b0ed1c
	System.Void SetValue(System.Int32 amount, System.Int32 needAmount, System.Boolean needColor); // 0x05b0ee68
	System.Void SetBottomStyle(System.String style); // 0x05b0eff0
	System.Void SetIcon(System.String url); // 0x05b0f0bc
	System.Void SetIconSize(UnityEngine.Vector2 size); // 0x05b0f1e0
	System.Void ReplaceEmptyFlag(FairyGUI.GObject imgFlag); // 0x05b0f2b8
	System.Void ReplaceEmptyFlag(System.String strFlag); // 0x05b0cc90
	System.Void ResetEmptyFlag(); // 0x05b0cdb0
	System.Void SetEmptyFlagAlpha(System.Single alphaValue); // 0x05b0d088
	System.Void ReplaceChooseFlag(FairyGUI.GObject imgFlag); // 0x05b0f3d8
	System.Void ResetChooseFlag(); // 0x05b0ce84
	System.Void OnChooseStateChange(System.Boolean curState); // 0x05b0f4f8
	System.Void OnIconClick(); // 0x05b0f594
	System.Void DoClickAction(); // 0x05b0e1a0
	System.Boolean OnIconDragAction(System.Int32 touchPointID); // 0x05b0f618
	System.Void DoDragAction(System.Int32 touchPointID); // 0x05b0ddd4
	static System.Boolean GetDragInfoFromContext(FairyGUI.EventContext ctx, WizardGames.Soc.SocClient.Ui.ItemDragInfo& dragInfo); // 0x05b0f690
	System.Boolean OnIconAcceptAction(WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05b0f7b4
	System.Boolean DoAcceptAction(WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05b0f858
	System.Boolean DoAcceptAction(FairyGUI.EventContext context); // 0x05b0e468
	System.Void OnComponentUpdate(); // 0x05b0f924
	System.Void SetIconEnable(System.Boolean state); // 0x05b0fa9c
	System.Void SetRare(System.Boolean state); // 0x05b0fb9c
	System.Void ClearTriggerHotArea(System.Boolean recoverToIconSelf); // 0x05b0ca98
	System.Void SetTriggerHotArea(FairyGUI.GObject hotArea); // 0x05b0c3b8
	System.Void SetIsMouseOrTouchMoveIn(System.Boolean value); // 0x05523a7c
	System.Void SetRightClick(); // 0x05b0fc9c
	System.Void ClearRightClick(); // 0x05b0fc3c
	System.Boolean CheckRightClick(FairyGUI.EventContext context); // 0x05b0da14
	System.Void .ctor(); // 0x05b0fcfc
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EIconCDStyle : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EIconCDStyle Loot = 0;
	static WizardGames.Soc.SocClient.Ui.EIconCDStyle Drop = 1;
	static WizardGames.Soc.SocClient.Ui.EIconCDStyle Use = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComItemIcon : WizardGames.Soc.SocClient.Ui.ComBaseIcon
{
	FairyGUI.GObject objSubItemMark; // 0x3e8
	FairyGUI.GGroup groupCondition; // 0x3f0
	FairyGUI.GImage imgConditionBac; // 0x3f8
	FairyGUI.GImage imgConditionProgress; // 0x400
	FairyGUI.GImage imgConditionMaxLoss; // 0x408
	FairyGUI.Controller ctrlRTTag; // 0x410
	FairyGUI.Controller ctrlMTTag; // 0x418
	FairyGUI.GImage imgCD; // 0x420
	FairyGUI.GObject objHighlight; // 0x428
	FairyGUI.Controller ctrlCdStyle; // 0x430
	FairyGUI.Controller tagController; // 0x438
	FairyGUI.Transition animBlink; // 0x440
	WizardGames.Soc.SocClient.Ui.ComIconRewardget rewardget; // 0x448
	FairyGUI.GImage onpressmask; // 0x450
	FairyGUI.GLoader loaderQualityBg; // 0x458
	FairyGUI.Controller qualityStateCtrl; // 0x460
	System.Single fDoubleClickAppearTimeRemain; // 0x468
	System.Single fDoubleClickStartTime; // 0x46c
	System.Single fDoubleClickCDTime; // 0x470
	System.Boolean isItemDamaged; // 0x474
	System.Boolean checkNewSignOnClick; // 0x475
	WizardGames.Soc.SocClient.Ui.IconDoubleClickCfg DoubleClickCfg; // 0x478
	WizardGames.Soc.SocClient.Ui.IconAutoUnChooseMethod AutoUnchooseMethod; // 0x480
	System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> OnItemDamaged; // 0x488
	System.Boolean CanDoubleClickToMove; // 0x490
	System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> OnItemNodeUpdateCallback; // 0x498
	System.Action OnItemChangeCallback; // 0x4a0
	WizardGames.Soc.Common.Data.resource.OBJGenaral objTipsCfg; // 0x4a8
	WizardGames.Soc.Common.Data.DataItem.ItemConfig itemTipsCfg; // 0x4b0
	WizardGames.Soc.Common.Data.DataItem.SkinConfig skinTipsCfg; // 0x4b8
	WizardGames.Soc.Common.CustomType.BaseItemNode <InstItem>k__BackingField; // 0x4c0
	WizardGames.Soc.Common.Data.DataItem.ItemConfig <TbItem>k__BackingField; // 0x4c8
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap <BindNode>k__BackingField; // 0x4d0
	System.Int32 <Position>k__BackingField; // 0x4d8
	System.Int32 lastWearCondTime; // 0x4dc
	System.Boolean isShowRareBg; // 0x4e0
	System.Action actUpdateItemNode; // 0x4e8
	System.Int64 chainsawSubscribId; // 0x4f0
	System.Int64 conditionSubscribId; // 0x4f8
	System.Boolean <IsBatchSelect>k__BackingField; // 0x500
	System.Boolean get_HasDoubleClickAction(); // 0x05b0fdd0
	WizardGames.Soc.Common.Data.resource.OBJGenaral get_ObjTipsCfg(); // 0x05b0fe54
	System.Void set_ObjTipsCfg(WizardGames.Soc.Common.Data.resource.OBJGenaral value); // 0x05b0feb8
	WizardGames.Soc.Common.Data.DataItem.ItemConfig get_ItemTipsCfg(); // 0x05b0ff58
	System.Void set_ItemTipsCfg(WizardGames.Soc.Common.Data.DataItem.ItemConfig value); // 0x05b0ffbc
	System.Boolean get_HasTipsCfg(); // 0x05b1005c
	System.Void set_ShowSubItemMark(System.Boolean value); // 0x05b100ec
	System.Boolean get_IsInCD(); // 0x05b101f0
	WizardGames.Soc.Common.CustomType.BaseItemNode get_InstItem(); // 0x05b10298
	System.Void set_InstItem(WizardGames.Soc.Common.CustomType.BaseItemNode value); // 0x05b102fc
	WizardGames.Soc.Common.Data.DataItem.ItemConfig get_TbItem(); // 0x05b1037c
	System.Void set_TbItem(WizardGames.Soc.Common.Data.DataItem.ItemConfig value); // 0x05b103e0
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap get_BindNode(); // 0x05b10460
	System.Void set_BindNode(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap value); // 0x05b104c4
	WizardGames.Soc.Common.CustomType.Alpha3ContainerClient get_BindContainer(); // 0x05b10544
	System.Int32 get_Position(); // 0x05b10654
	System.Void set_Position(System.Int32 value); // 0x05b106b8
	System.Boolean get_IsBindWithContainer(); // 0x05b10730
	System.Void set_IsBatchSelect(System.Boolean value); // 0x05b10830
	WizardGames.Soc.Common.Entity.IItemEntity get_BindEntity(); // 0x05b108ac
	System.Void OnInit(); // 0x05b10aa8
	System.Void Dispose(); // 0x055049cc
	System.Void InitItemWidgets(); // 0x05b110f4
	System.Void CheckAllWidgetsLoad(); // 0x05b113ac
	System.Void CheckAllWidgetsUnload(); // 0x05b11674
	System.Boolean IsIconEmpty(); // 0x05b11940
	System.Void ResetForRecovery(); // 0x05b11a44
	System.Void SetContainerData(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container, System.Int32 position); // 0x05525b70
	System.Void ClearContainerData(); // 0x05b11b7c
	System.Void DisablePressEffect(); // 0x05b12198
	System.Void SetAsInvalid(System.Boolean clearContainer); // 0x05b1220c
	System.Void RefreshContainerIcon(); // 0x05b11ff4
	System.Void OnItemNodeUpdate(); // 0x05b122ac
	System.Void OnItemNodeUpdate(System.Boolean force); // 0x05b12348
	System.Void ClearInstItem(); // 0x055049cc
	System.Void CheckUnChoose(System.Boolean dataChange); // 0x05b12c1c
	System.Void DoInstItemSubscribe(WizardGames.Soc.Common.CustomType.BaseItemNode instItem); // 0x05b12cc0
	System.Void DoInstItemUnsubscribe(WizardGames.Soc.Common.CustomType.BaseItemNode instItem); // 0x05b12a18
	System.Void SetInstData(WizardGames.Soc.Common.CustomType.BaseItemNode instItem, System.Boolean showIconOnly); // 0x0552af28
	System.Void SetTepmlateData(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, System.Boolean showIconOnly); // 0x05b135b4
	System.Void SetTepmlateData(WizardGames.Soc.Common.Data.resource.OBJGenaral genaralCfg, System.Boolean showIconOnly); // 0x05b13888
	System.Void SetQualityStateCtrl(WizardGames.Soc.Common.Data.resource.ENUMResourceRare eRare); // 0x05b1398c
	System.Void SetShowIconOnly(System.Boolean withBac); // 0x05b13b0c
	System.Void SetShowWorldSourceMode(); // 0x05b13db0
	System.Boolean SetEmpty(System.Boolean force); // 0x054deca4
	System.Void SetIconBgVisible(System.Boolean show); // 0x05b13f6c
	System.Void SetIconQualityBgVisible(System.Boolean show); // 0x05b14064
	System.Void HandleItemDamaged(); // 0x05b14168
	System.Void SetTag(); // 0x05b09f68
	System.Void SetTag(System.String tag, System.Boolean state); // 0x05b13c40
	System.Void SetConditionInternal(System.Single curP, System.Single curMP, System.Single cfgMP); // 0x05b14210
	System.Void SetCondition(); // 0x05b12674
	System.Void TrySetRemainTime(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig, System.Single Condition); // 0x05b148dc
	System.Void SetConditionByEntity(WizardGames.Soc.Common.Entity.IItemEntity entity); // 0x05b14458
	System.Void SetConditionValueDirectly(System.Single curCond, System.Single maxCond); // 0x05b14b10
	System.Void SetConditionVisible(System.Boolean state); // 0x05b14bec
	System.Boolean IsItemBroken(); // 0x05b14cf0
	System.Void SetValue(); // 0x05b14f2c
	System.Void SetExtendPackValue(); // 0x05b15464
	System.Void SetChainsawValue(); // 0x05b158bc
	System.String GetItemIconUrl(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, WizardGames.Soc.Common.Data.DataItem.SkinConfig skinCfg); // 0x05b15aac
	System.Void SetIcon(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, WizardGames.Soc.Common.Data.DataItem.SkinConfig skinCfg); // 0x05b133e0
	System.Void SetCD(System.Single progress, WizardGames.Soc.SocClient.Ui.EIconCDStyle style); // 0x05b15b70
	System.Void SetCustomBg(System.String url); // 0x05b15c88
	System.Void ResetCustomBg(); // 0x05b11d4c
	System.Void CopyFromIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05b15d60
	System.Void SwapContainerData(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05b15f3c
	System.Void OnChooseStateChange(System.Boolean curState); // 0x05b16168
	System.Void OnPlayIconClickSound(); // 0x055049cc
	System.Void OnIconClick(); // 0x05b165bc
	System.Void CancelDoubleCliclAction(); // 0x05b11c98
	System.Boolean DoDoubleClickAction(); // 0x05b169c8
	System.Void OnPlayIconDragSound(); // 0x05b17360
	WizardGames.Soc.SocClient.Ui.ItemDragInfo GetDragInfo(); // 0x05b1754c
	System.Boolean OnIconDragAction(System.Int32 touchPointID); // 0x05b17638
	System.Boolean CheckAcceptWeaponAccessory(WizardGames.Soc.Common.CustomType.BaseItemNode dropItem, System.Boolean isEquip); // 0x05b177a0
	System.Void OnPlayIconAcceptSound(WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05b179dc
	System.Boolean OnIconAcceptAction(WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05b17b24
	System.Boolean DoDefaultDragAcceptAction(WizardGames.Soc.Common.CustomType.BaseItemNode dropItem); // 0x05b17dac
	System.Boolean IsTypeOf(System.Int32 type); // 0x05b181c4
	System.Void OnComponentUpdate(); // 0x05b182d8
	System.Void SetHighlight(System.Boolean on); // 0x05b11dcc
	System.Boolean IsHighlightOn(); // 0x05b18438
	System.Void RefreshTag(System.Boolean onlyMission); // 0x05b184e0
	System.Void CheckAndCloseNewMark(); // 0x05b16770
	System.Void DoBlink(); // 0x05b1880c
	System.Void StopBlink(); // 0x05b188e8
	System.Void SetRareBg(); // 0x05b12454
	System.Void SetShowRareBg(System.Boolean isRareBg); // 0x05b189b8
	System.Void EnableItemTipsClick(FairyGUI.GComponent com, FairyGUI.GComponent baseCom, System.Boolean tipsAtPosLeft, System.Boolean touchAnywhereToHide, System.Boolean useHover); // 0x05b18a34
	System.Void ShowTips(FairyGUI.GComponent com, FairyGUI.GComponent baseCom, WizardGames.Soc.SocClient.Ui.EOpenSource openSource); // 0x05b18ce8
	System.Void SetRewardState(System.Int32 state); // 0x05b18f70
	System.Void ClearRewardget(); // 0x05b12b70
	System.Void SetBatchSelectState(System.Boolean state, WizardGames.Soc.SocClient.Ui.EIconCDStyle style); // 0x05b191b8
	System.Void EnableItemTipsClickAutoPosition(System.Boolean touchAnywhereToHide, System.Boolean useHover, WizardGames.Soc.SocClient.Ui.EOpenSource openSource); // 0x05b192e0
	System.Void EnableItemTipsClick(UnityEngine.Vector2 pivotOffset, System.Boolean tipsAtPosLeft, System.Boolean touchAnywhereToHide, System.Boolean useHover, FairyGUI.GComponent com, FairyGUI.GComponent baseCom); // 0x05b18b5c
	System.Void .ctor(); // 0x05b19500
	System.Void <DoInstItemSubscribe>b__103_0(WizardGames.Soc.Share.Framework.CustomTypeBase _, System.Int32 _, System.Int32 _); // 0x05b19584
	System.Void <DoInstItemSubscribe>b__103_1(WizardGames.Soc.Share.Framework.CustomTypeBase obj, System.Single _, System.Single _); // 0x05b19618
	System.Void <DoDoubleClickAction>b__141_0(WizardGames.Soc.Share.Framework.EntityBase loot, System.Boolean needToast); // 0x05b197a0
	System.Void <DoBlink>b__156_0(); // 0x05b199bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComItemIcon.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ComItemIcon.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Share.Framework.EntityBase> <>9__141_1; // 0x8
	static System.Void .cctor(); // 0x05b19a24
	System.Void .ctor(); // 0x05b19a88
	System.Void <DoDoubleClickAction>b__141_1(WizardGames.Soc.Share.Framework.EntityBase loot); // 0x05b19af0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComItemIcon.<>c__DisplayClass166_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.EOpenSource openSource; // 0x18
	System.Void .ctor(); // 0x05b19430
	System.Void <EnableItemTipsClickAutoPosition>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05b19c2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComItemIcon.<>c__DisplayClass167_0 : System.Object
{
	UnityEngine.Vector2 pivotOffset; // 0x10
	WizardGames.Soc.SocClient.Ui.ComItemIcon <>4__this; // 0x18
	System.Void .ctor(); // 0x05b19498
	System.Void <EnableItemTipsClick>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05b19ddc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComItemIconLoader : FairyGUI.GComponent
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon curIcon; // 0x288
	WizardGames.Soc.SocClient.Ui.ComItemIcon get_Icon(); // 0x05b19f6c
	System.Boolean get_HasIcon(); // 0x05b1a138
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05b1a1a4
	WizardGames.Soc.SocClient.Ui.ComItemIcon RequestIcon(); // 0x05b19fd0
	System.Void ReturnIcon(); // 0x05b1a2cc
	System.Void .ctor(); // 0x05b1a3ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComResIcon : WizardGames.Soc.SocClient.Ui.ComBaseIcon
{
	WizardGames.Soc.Common.Data.resource.OBJGenaral <ResItem>k__BackingField; // 0x3e8
	System.Action OnItemChangeCallback; // 0x3f0
	FairyGUI.Controller qualityStateCtrl; // 0x3f8
	FairyGUI.GLoader loaderQualityBg; // 0x400
	FairyGUI.Controller tagController; // 0x408
	FairyGUI.Controller typeTagCtrl; // 0x410
	FairyGUI.GTextField tagTitle; // 0x418
	FairyGUI.GTextField skinTrialCardTime; // 0x420
	FairyGUI.GTextField timeTxt; // 0x428
	FairyGUI.Controller ctrlMask; // 0x430
	FairyGUI.Transition receiveTrans; // 0x438
	WizardGames.Soc.Common.Data.resource.OBJGenaral get_ResItem(); // 0x05b1a454
	System.Void set_ResItem(WizardGames.Soc.Common.Data.resource.OBJGenaral value); // 0x05b1a4b8
	System.Void set_ShowMask(System.Boolean value); // 0x05b1a538
	System.Void OnInit(); // 0x05b1a5cc
	System.Boolean IsIconEmpty(); // 0x05b1a8a8
	System.Void Dispose(); // 0x05b1a958
	System.Void ResetForRecovery(); // 0x05b1a9d0
	System.Boolean SetEmpty(System.Boolean force); // 0x05b1aa44
	System.Void SetResData(WizardGames.Soc.Common.Data.resource.OBJGenaral resItem, System.Boolean showIconOnly); // 0x05b1ab80
	System.Void SetIcon(WizardGames.Soc.Common.Data.resource.OBJGenaral resItemCfg); // 0x05b1adc0
	System.Void SetTalent(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x05b1b598
	System.Void CopyFromIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05b1b740
	System.Void SetQualityStateCtrl(WizardGames.Soc.Common.Data.resource.ENUMResourceRare eRare); // 0x05b1b070
	System.Void SetIconQualityBgVisible(System.Boolean show); // 0x05b1b880
	System.Void SetReceiveState(System.Boolean canReceive); // 0x05b1aacc
	System.Void SetNewMark(System.Boolean state); // 0x05b1b984
	System.Void SetSkinTrialCard(System.Boolean state, System.String tagTitle); // 0x05b1b290
	System.Void SetTimeStr(System.String str); // 0x05b1ba24
	System.Void SetSkinTrialCardTime(System.Int32 id); // 0x05b1b3a4
	System.Void SetSkinShard(System.Boolean state); // 0x05b1b1f0
	WizardGames.Soc.SocClient.Ui.ItemDragInfo GetDragInfo(); // 0x05b1badc
	System.Void OnPlayIconClickSound(); // 0x05b1bbc8
	System.Void OnPlayIconDragSound(); // 0x05b1bd4c
	System.Void OnPlayIconAcceptSound(WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05b1bed0
	System.Void EnableItemTipsClickAutoPosition(System.Boolean touchAnywhereToHide, WizardGames.Soc.SocClient.Ui.EOpenSource openSource); // 0x05b1bfa0
	System.Void CallShowTips(System.Boolean touchAnywhereToHide, WizardGames.Soc.SocClient.Ui.EOpenSource openSource); // 0x05b1c174
	System.Void EnableItemTipsClickAutoPosition(System.Int64 expireAt, System.Boolean touchAnywhereToHide, WizardGames.Soc.SocClient.Ui.EOpenSource openSource); // 0x05b1c2cc
	System.Void EnableItemTipsClick(UnityEngine.Vector2 pivotOffset, System.Boolean tipsAtPosLeft, System.Boolean touchAnywhereToHide, WizardGames.Soc.SocClient.Ui.EOpenSource openSource, FairyGUI.GComponent com, FairyGUI.GComponent baseCom); // 0x05b1c4bc
	System.Void EnableItemTipsClick(FairyGUI.GComponent com, FairyGUI.GComponent baseCom, System.Boolean tipsAtPosLeft, System.Boolean touchAnywhereToHide); // 0x05b1c708
	System.Void .ctor(); // 0x05b1c84c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComResIcon.<>c__DisplayClass39_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComResIcon <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.EOpenSource openSource; // 0x18
	System.Void .ctor(); // 0x05b1c10c
	System.Void <EnableItemTipsClickAutoPosition>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05b1c8b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComResIcon.<>c__DisplayClass41_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComResIcon <>4__this; // 0x10
	System.Int64 expireAt; // 0x18
	WizardGames.Soc.SocClient.Ui.EOpenSource openSource; // 0x20
	System.Void .ctor(); // 0x05b1c454
	System.Void <EnableItemTipsClickAutoPosition>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05b1ca10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComResIcon.<>c__DisplayClass42_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComResIcon <>4__this; // 0x10
	FairyGUI.GComponent com; // 0x18
	FairyGUI.GComponent baseCom; // 0x20
	WizardGames.Soc.SocClient.Ui.EOpenSource openSource; // 0x28
	System.Void .ctor(); // 0x05b1c6a0
	System.Void <EnableItemTipsClick>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05b1ccb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComResIconLarge : WizardGames.Soc.SocClient.Ui.ComResIcon
{
	
	System.Void .ctor(); // 0x05b1cdec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComIconDoubleClick : FairyGUI.GComponent
{
	FairyGUI.GTextField textDoubleClickTips; // 0x288
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05b1ce50
	System.Void Show(System.String tips); // 0x05b1cf14
	System.Void Hide(); // 0x05b1d014
	System.Void .ctor(); // 0x05b1d080
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComIconFrequency : System.Object, WizardGames.Soc.SocClient.Ui.IComItemWidget
{
	FairyGUI.GTextField frequencyTxt; // 0x10
	FairyGUI.GComponent rootCom; // 0x18
	System.Int32 frequency; // 0x20
	System.Void RefreshUI(WizardGames.Soc.SocClient.Ui.ComBaseIcon owner); // 0x05b1d0e8
	System.Void ClearUI(); // 0x05b1d308
	System.Void ApplyWidget(); // 0x05b1d250
	System.Boolean InitData(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05b1d3ac
	System.Void OnShowWidget(WizardGames.Soc.SocClient.Ui.ComBaseIcon owner, WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05b1d4e4
	System.Void OnCheckClearWidget(WizardGames.Soc.SocClient.Ui.ComBaseIcon owner, WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05b1d684
	System.Void .ctor(); // 0x05b1126c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComIconRewardget : FairyGUI.GComponent
{
	FairyGUI.Controller ctrlReward; // 0x288
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05b1d7d4
	System.Void SetRewardState(System.Int32 state); // 0x05b19124
	System.Void .ctor(); // 0x05b1d8a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComIconSeed : System.Object, WizardGames.Soc.SocClient.Ui.IComItemWidget
{
	FairyGUI.GComponent rootCom; // 0x10
	FairyGUI.GTextField textSeedGen; // 0x18
	System.Void RefreshUI(WizardGames.Soc.SocClient.Ui.ComBaseIcon owner); // 0x05b1d90c
	System.Void ClearUI(); // 0x05b1da94
	System.Void SetSeedText(System.String text); // 0x05b1dba4
	System.String GetSeedText(); // 0x05b1dc60
	System.Void SetPlantSeedNode(WizardGames.Soc.Common.CustomType.PlantSeedNode seedNode); // 0x05b1dcd8
	System.Void SetPlantWildSeedNode(); // 0x05b1e124
	System.Void OnShowWidget(WizardGames.Soc.SocClient.Ui.ComBaseIcon owner, WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05b1e1d8
	System.Void OnCheckClearWidget(WizardGames.Soc.SocClient.Ui.ComBaseIcon owner, WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05b1e344
	System.Void .ctor(); // 0x05b11344
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComIconSlot : System.Object, WizardGames.Soc.SocClient.Ui.IComItemWidget
{
	FairyGUI.GComponent rootCom; // 0x10
	FairyGUI.GImage slotBac; // 0x18
	FairyGUI.GImage slotFront; // 0x20
	System.Single totalAmount; // 0x28
	System.Single filledAmount; // 0x2c
	System.Void RefreshUI(WizardGames.Soc.SocClient.Ui.ComBaseIcon owner); // 0x05b1e498
	System.Void ClearUI(); // 0x05b1e6e4
	System.Void ApplyWidget(); // 0x05b1e648
	System.Void RefreshData(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05b1e798
	System.Boolean SetWeaponSlot(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Single& totalNum, System.Single& filledNum); // 0x05b1e8cc
	System.Boolean SetEngineSlot(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Single& totalNum, System.Single& filledNum); // 0x05b1ebc0
	System.Void OnShowWidget(WizardGames.Soc.SocClient.Ui.ComBaseIcon owner, WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05b1ee00
	System.Void OnCheckClearWidget(WizardGames.Soc.SocClient.Ui.ComBaseIcon owner, WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05b1ef84
	System.Void .ctor(); // 0x05b112d4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ENavTabRedDotType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ENavTabRedDotType Dot = 0;
	static WizardGames.Soc.SocClient.Ui.ENavTabRedDotType Exclamation = 1;
	static WizardGames.Soc.SocClient.Ui.ENavTabRedDotType Num = 2;
	static WizardGames.Soc.SocClient.Ui.ENavTabRedDotType custom = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.NavBarItemBinder : System.Object
{
	FairyGUI.GComponent <Root>k__BackingField; // 0x10
	FairyGUI.Controller <ShowIconCtr>k__BackingField; // 0x18
	FairyGUI.GLoader <BigIcon>k__BackingField; // 0x20
	FairyGUI.Controller <TriangleCtrl>k__BackingField; // 0x28
	FairyGUI.Controller <ButtonCtrl>k__BackingField; // 0x30
	FairyGUI.Controller <TranslucentCtrl>k__BackingField; // 0x38
	FairyGUI.Controller <BtnStyleCtr>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.ComRedDot <ComRedDot>k__BackingField; // 0x48
	FairyGUI.GTextField <Num>k__BackingField; // 0x50
	FairyGUI.Controller <LockCtrl>k__BackingField; // 0x58
	FairyGUI.Controller <UnfoldCtrl>k__BackingField; // 0x60
	FairyGUI.Controller <IsFinalCtrl>k__BackingField; // 0x68
	FairyGUI.GObject <TrackDot>k__BackingField; // 0x70
	FairyGUI.Transition <TrackDotShowAnim>k__BackingField; // 0x78
	FairyGUI.GComponent get_Root(); // 0x05b1f0c4
	System.Void set_Root(FairyGUI.GComponent value); // 0x05b1f128
	FairyGUI.Controller get_ShowIconCtr(); // 0x05b1f1a8
	System.Void set_ShowIconCtr(FairyGUI.Controller value); // 0x05b1f20c
	FairyGUI.GLoader get_BigIcon(); // 0x05b1f28c
	System.Void set_BigIcon(FairyGUI.GLoader value); // 0x05b1f2f0
	FairyGUI.Controller get_TriangleCtrl(); // 0x05b1f370
	System.Void set_TriangleCtrl(FairyGUI.Controller value); // 0x05b1f3d4
	System.Void set_ButtonCtrl(FairyGUI.Controller value); // 0x05b1f454
	FairyGUI.Controller get_TranslucentCtrl(); // 0x05b1f4d4
	System.Void set_TranslucentCtrl(FairyGUI.Controller value); // 0x05b1f538
	FairyGUI.Controller get_BtnStyleCtr(); // 0x05b1f5b8
	System.Void set_BtnStyleCtr(FairyGUI.Controller value); // 0x05b1f61c
	WizardGames.Soc.SocClient.Ui.ComRedDot get_ComRedDot(); // 0x05b1f69c
	System.Void set_ComRedDot(WizardGames.Soc.SocClient.Ui.ComRedDot value); // 0x05b1f700
	FairyGUI.GTextField get_Num(); // 0x05b1f780
	System.Void set_Num(FairyGUI.GTextField value); // 0x05b1f7e4
	FairyGUI.Controller get_LockCtrl(); // 0x05b1f864
	System.Void set_LockCtrl(FairyGUI.Controller value); // 0x05b1f8c8
	FairyGUI.Controller get_UnfoldCtrl(); // 0x05b1f948
	System.Void set_UnfoldCtrl(FairyGUI.Controller value); // 0x05b1f9ac
	FairyGUI.Controller get_IsFinalCtrl(); // 0x05b1fa2c
	System.Void set_IsFinalCtrl(FairyGUI.Controller value); // 0x05b1fa90
	FairyGUI.GObject get_TrackDot(); // 0x05b1fb10
	System.Void set_TrackDot(FairyGUI.GObject value); // 0x05b1fb74
	FairyGUI.Transition get_TrackDotShowAnim(); // 0x05b1fbf4
	System.Void set_TrackDotShowAnim(FairyGUI.Transition value); // 0x05b1fc58
	System.Void .ctor(FairyGUI.GComponent root); // 0x05b1fcd8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComCommonNavBar : System.Object
{
	System.Boolean <AlwaysUnfold>k__BackingField; // 0x10
	FairyGUI.GList listCom; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NavBarData> showNavBarDataList; // 0x20
	System.Int32 selectedIndex; // 0x28
	FairyGUI.GList listSubCom; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NavBarData> showSubNavBarDataList; // 0x38
	System.Int32 selectedSubIndex; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NavBarData> tempDataList; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NavBarData> tempSubDataList; // 0x50
	System.Action<WizardGames.Soc.SocClient.Ui.NavBarData,System.Boolean> onClickBack; // 0x58
	WizardGames.Soc.SocClient.Ui.NavBarData lastSelectPrimary; // 0x60
	WizardGames.Soc.SocClient.Ui.NavBarData lastSelectSecondary; // 0x68
	WizardGames.Soc.SocClient.Ui.NavBarData realClickedData; // 0x70
	WizardGames.Soc.SocClient.Ui.NavBarData lastClickedData; // 0x78
	WizardGames.Soc.SocClient.Ui.NavBarData navDataRoot; // 0x80
	WizardGames.Soc.SocClient.Ui.ENavTabRedDotType redDotStyle; // 0x88
	System.Boolean hasSecondTab; // 0x8c
	System.Boolean isVirtual; // 0x8d
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.NavBarItemBinder> itemBinders; // 0x90
	System.Boolean <IsCallbackEveryClick>k__BackingField; // 0x98
	System.Boolean <IsHideFirstTabRedDot>k__BackingField; // 0x99
	FairyGUI.GComponent <Root>k__BackingField; // 0xa0
	FairyGUI.GComponent <SecRoot>k__BackingField; // 0xa8
	System.Action numItemsChangedAction; // 0xb0
	System.Boolean lockCanSelect; // 0xb8
	System.Boolean UseDefaultSound; // 0xb9
	System.String defaultPrimarySound; // 0xc0
	System.String defaultSecondarySound; // 0xc8
	System.String replacePrimarySound; // 0xd0
	System.String replaceSecondarySound; // 0xd8
	System.String redDotCustomUrl; // 0xe0
	System.Boolean get_AlwaysUnfold(); // 0x05b204f4
	System.Void set_AlwaysUnfold(System.Boolean value); // 0x05b20558
	System.Boolean get_IsCallbackEveryClick(); // 0x05b205d4
	System.Void set_IsCallbackEveryClick(System.Boolean value); // 0x05b20638
	System.Void set_IsHideFirstTabRedDot(System.Boolean value); // 0x05b206b4
	System.Boolean get_IsHideFirstTabRedDot(); // 0x05b20730
	FairyGUI.GComponent get_Root(); // 0x05b20794
	System.Void set_Root(FairyGUI.GComponent value); // 0x05b207f8
	FairyGUI.GComponent get_SecRoot(); // 0x05b20878
	System.Void set_SecRoot(FairyGUI.GComponent value); // 0x05b208dc
	System.Void Init(FairyGUI.GComponent root, System.Boolean hasSecondTab, FairyGUI.GComponent secRoot); // 0x05b2095c
	System.Void LinkTopBar(WizardGames.Soc.SocClient.Ui.ComTopBar topBar, System.Boolean autoTransToPc); // 0x05b212ec
	System.Void StopTransitions(FairyGUI.GList list, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NavBarData> dataList); // 0x05b215b0
	System.Void CreateItem(); // 0x05b218cc
	System.Void InitItemBinders(); // 0x05b21d44
	System.Void ForEveryTab(System.Action<WizardGames.Soc.SocClient.Ui.NavBarData,FairyGUI.GComponent> action); // 0x05b21eb4
	System.Void SetVirtual(); // 0x05b22048
	System.Void HideRoot(); // 0x05b220dc
	System.Void HideTab(); // 0x05b22238
	System.Void AddTabData(WizardGames.Soc.SocClient.Ui.NavBarData navData, System.Int32 mainTabId); // 0x05b22404
	System.Int32 GetCurSelectFirstTabId(); // 0x05b22860
	System.Int32 GetCurSelectSecTabId(); // 0x05b22908
	System.Void ClearTabData(); // 0x05b229b0
	WizardGames.Soc.SocClient.Ui.NavBarData GetTabData(System.Int32 mainId, System.Int32 subId); // 0x05b23220
	System.Void SetClickBack(System.Action<WizardGames.Soc.SocClient.Ui.NavBarData,System.Boolean> clickBack); // 0x05b23414
	System.Void SetRedType(WizardGames.Soc.SocClient.Ui.ENavTabRedDotType redStyle); // 0x05b23494
	System.Void SetRedCustomUrl(System.String url); // 0x05b2350c
	System.Void SetChild(WizardGames.Soc.SocClient.Ui.NavBarData parent, WizardGames.Soc.SocClient.Ui.NavBarData child); // 0x05b22600
	System.Void Refresh(); // 0x05b2358c
	System.Void InternalRefresh(System.Boolean force); // 0x05b235f4
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05b241e4
	System.Void OnSubItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05b242c4
	System.Void UpdateItem(FairyGUI.GObject obj, WizardGames.Soc.SocClient.Ui.NavBarData navData, System.Boolean isFinal); // 0x05b243a4
	System.Void UpdateTrackDot(System.Boolean showTrackDot, WizardGames.Soc.SocClient.Ui.NavBarItemBinder itemBinder); // 0x05b25480
	System.Void UpdateRedDot(WizardGames.Soc.SocClient.Ui.NavBarItemBinder itemBinder, WizardGames.Soc.SocClient.Ui.NavBarData navData); // 0x05b256d4
	System.Void UpdateButtonStyle(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.NavBarData navData); // 0x05b25f00
	System.Int32 RefreshRed(System.Int32 tabId); // 0x05b25b88
	System.Void RefreshRedDot(); // 0x05b26110
	System.Void RefreshTrackDot(); // 0x05b26310
	System.Void ScrollAndSelect(System.Int32 mainId, System.Int32 subId); // 0x05b269f4
	System.Void OnlyScroll(System.Int32 mainId, System.Int32 subId); // 0x05b27248
	System.Void SetSelectSubTab(System.Int32 mainId, System.Int32 subId); // 0x05b27570
	System.Void ClickItemBack(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean autoSelectSecTab, System.Boolean isBtnClicked); // 0x05b26d34
	System.Boolean OnClickSamePrimary(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean autoSelectSecTab, System.Boolean isBtnClicked); // 0x05b27898
	System.Boolean OnClickDiffPrimary(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean autoSelectSecTab, System.Boolean isBtnClicked); // 0x05b27cd0
	System.Void ResetAll(); // 0x05b280c0
	System.Void CancelPrimarySelect(); // 0x05b28264
	System.Void LinkTopBarForPlatform(WizardGames.Soc.SocClient.Ui.ComTopBar topBar); // 0x05b283e8
	System.String GetLineUrl(); // 0x05b21ccc
	System.Void .ctor(); // 0x05b28474
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComCommonNavBar.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ComCommonNavBar.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.NavBarItemBinder> <>9__54_0; // 0x8
	static System.Void .cctor(); // 0x05b2859c
	System.Void .ctor(); // 0x05b28600
	WizardGames.Soc.SocClient.Ui.NavBarItemBinder <InitItemBinders>b__54_0(FairyGUI.GComponent c); // 0x05b28668
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComCommonNavBar.<>c__DisplayClass75_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.NavBarData navData; // 0x18
	System.Void .ctor(); // 0x05b25418
	System.Void <UpdateItem>b__0(); // 0x05b28708
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.NavBarData : System.Object
{
	System.Int32 <TabId>k__BackingField; // 0x10
	System.String <Title>k__BackingField; // 0x18
	System.Int32 <Num>k__BackingField; // 0x20
	System.String <Icon>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.ETabStyle <TabStyle>k__BackingField; // 0x30
	System.Int32 <FinishGuideId>k__BackingField; // 0x34
	System.Int32 <FinishGuideStepId>k__BackingField; // 0x38
	System.Int32 <NxtGuideStepId>k__BackingField; // 0x3c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NavBarData> <ChildList>k__BackingField; // 0x40
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.NavBarData> <ChildDic>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.NavBarData <Parent>k__BackingField; // 0x50
	System.Boolean <IsShowChild>k__BackingField; // 0x58
	System.Boolean <Locked>k__BackingField; // 0x59
	System.Boolean <IsGray>k__BackingField; // 0x5a
	WizardGames.Soc.SocClient.Ui.RedDotType <RedDotType>k__BackingField; // 0x5c
	System.Boolean <IsShowRedDot>k__BackingField; // 0x60
	System.Boolean <IsSelect>k__BackingField; // 0x61
	System.Boolean <IsFirstTabShowTriangle>k__BackingField; // 0x62
	System.Boolean <IsTranslucent>k__BackingField; // 0x63
	System.Boolean <Visible>k__BackingField; // 0x64
	System.String UnlockKey; // 0x68
	System.String WinName; // 0x70
	System.Object UserData; // 0x78
	System.Boolean <ShowTrackDot>k__BackingField; // 0x80
	WizardGames.Soc.SocClient.Ui.ENavIconType <IconType>k__BackingField; // 0x84
	System.Void set_TabId(System.Int32 value); // 0x05b28a9c
	System.Int32 get_TabId(); // 0x05b28b14
	System.Void set_Title(System.String value); // 0x05b28b78
	System.String get_Title(); // 0x05b28bf8
	System.Int32 get_Num(); // 0x05b28c5c
	System.Void set_Num(System.Int32 value); // 0x05b28cc0
	System.Void set_Icon(System.String value); // 0x05b28d38
	System.String get_Icon(); // 0x05b28db8
	System.Void set_TabStyle(WizardGames.Soc.SocClient.Ui.ETabStyle value); // 0x05b28e1c
	WizardGames.Soc.SocClient.Ui.ETabStyle get_TabStyle(); // 0x05b28e94
	System.Int32 get_FinishGuideId(); // 0x05b28ef8
	System.Void set_FinishGuideId(System.Int32 value); // 0x05b28f5c
	System.Int32 get_FinishGuideStepId(); // 0x05b28fd4
	System.Void set_FinishGuideStepId(System.Int32 value); // 0x05b29038
	System.Int32 get_NxtGuideStepId(); // 0x05b290b0
	System.Void set_NxtGuideStepId(System.Int32 value); // 0x05b29114
	System.Void set_ChildList(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NavBarData> value); // 0x05b2918c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NavBarData> get_ChildList(); // 0x05b2920c
	System.Void set_ChildDic(System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.NavBarData> value); // 0x05b29270
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.NavBarData> get_ChildDic(); // 0x05b292f0
	System.Void set_Parent(WizardGames.Soc.SocClient.Ui.NavBarData value); // 0x05b29354
	WizardGames.Soc.SocClient.Ui.NavBarData get_Parent(); // 0x05b293d4
	System.Void set_IsShowChild(System.Boolean value); // 0x05b29438
	System.Boolean get_IsShowChild(); // 0x05b294b4
	System.Boolean get_Locked(); // 0x05b29518
	System.Void set_Locked(System.Boolean value); // 0x05b2957c
	System.Boolean get_IsGray(); // 0x05b295f8
	System.Void set_IsGray(System.Boolean value); // 0x05b2965c
	System.Void set_RedDotType(WizardGames.Soc.SocClient.Ui.RedDotType value); // 0x05b296d8
	WizardGames.Soc.SocClient.Ui.RedDotType get_RedDotType(); // 0x05b29750
	System.Void set_IsShowRedDot(System.Boolean value); // 0x05b297b4
	System.Boolean get_IsShowRedDot(); // 0x05b29830
	System.Boolean get_IsSelect(); // 0x05b29894
	System.Void set_IsSelect(System.Boolean value); // 0x05b298f8
	System.Boolean get_IsFirstTabShowTriangle(); // 0x05b29974
	System.Boolean get_IsTranslucent(); // 0x05b299d8
	System.Void set_IsTranslucent(System.Boolean value); // 0x05b29a3c
	System.Boolean get_Visible(); // 0x05b29ab8
	System.Void set_Visible(System.Boolean value); // 0x05b29b1c
	System.Boolean get_ShowTrackDot(); // 0x05b29b98
	System.Void set_ShowTrackDot(System.Boolean value); // 0x05b29bfc
	System.Void set_IconType(WizardGames.Soc.SocClient.Ui.ENavIconType value); // 0x05b29c78
	WizardGames.Soc.SocClient.Ui.ENavIconType get_IconType(); // 0x05b29cf0
	System.Void .ctor(System.String title, System.Int32 tabId, System.String icon, WizardGames.Soc.SocClient.Ui.ENavIconType iconType); // 0x05b20e00
	System.Void SetNavType(WizardGames.Soc.SocClient.Ui.ETabStyle navType); // 0x05b210ec
	System.Void UpdateData(System.String title, System.String icon); // 0x05b29d54
	System.Void Reset(); // 0x05b22ee0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ETabStyle : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ETabStyle Primary = 0;
	static WizardGames.Soc.SocClient.Ui.ETabStyle Secondary = 1;
	static WizardGames.Soc.SocClient.Ui.ETabStyle Normal = 2;
	static WizardGames.Soc.SocClient.Ui.ETabStyle Separator = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ENavIconType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ENavIconType NoIcon = 0;
	static WizardGames.Soc.SocClient.Ui.ENavIconType BigIcon = 1;
	static WizardGames.Soc.SocClient.Ui.ENavIconType SmallIcon = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MissionBookNavBarData : WizardGames.Soc.SocClient.Ui.NavBarData
{
	WizardGames.Soc.SocClient.Ui.UiMissionBook.EBookTabType tabType; // 0x88
	WizardGames.Soc.SocClient.Ui.UiMissionBook.EBookTabType get_TabType(); // 0x05b2a4dc
	System.Void .ctor(System.String title, System.Int32 tabId, WizardGames.Soc.SocClient.Ui.UiMissionBook.EBookTabType tabType, System.String icon, WizardGames.Soc.SocClient.Ui.ENavIconType iconType); // 0x05b2a540
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MissionBookNavBarItemBinder : WizardGames.Soc.SocClient.Ui.NavBarItemBinder
{
	FairyGUI.GTextField title; // 0x80
	FairyGUI.Controller styleCtrl; // 0x88
	System.Void .ctor(FairyGUI.GComponent root); // 0x05b2a60c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MissionBookNavBar : WizardGames.Soc.SocClient.Ui.ComCommonNavBar
{
	
	System.Void InitItemBinders(); // 0x05b2a708
	System.Void UpdateItem(FairyGUI.GObject obj, WizardGames.Soc.SocClient.Ui.NavBarData navData, System.Boolean isFinal); // 0x05b2a878
	System.Void .ctor(); // 0x05b2aad8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MissionBookNavBar.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.MissionBookNavBar.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.NavBarItemBinder> <>9__0_0; // 0x8
	static System.Void .cctor(); // 0x05b2ab40
	System.Void .ctor(); // 0x05b2aba4
	WizardGames.Soc.SocClient.Ui.NavBarItemBinder <InitItemBinders>b__0_0(FairyGUI.GComponent c); // 0x05b2ac0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MissionTraceNavBarData : WizardGames.Soc.SocClient.Ui.NavBarData
{
	WizardGames.Soc.Common.Data.MissionTabType type; // 0x88
	System.Void .ctor(System.String title, System.Int32 tabId, WizardGames.Soc.Common.Data.MissionTabType tabType, System.String icon, WizardGames.Soc.SocClient.Ui.ENavIconType iconType); // 0x05b2acac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MissionTraceNavBarItemBinder : WizardGames.Soc.SocClient.Ui.NavBarItemBinder
{
	FairyGUI.GLoader traceLoader; // 0x80
	FairyGUI.GTextField title1; // 0x88
	FairyGUI.GTextField title2; // 0x90
	System.Void .ctor(FairyGUI.GComponent root); // 0x05b2ad78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MissionTraceNavBar : WizardGames.Soc.SocClient.Ui.ComCommonNavBar
{
	
	System.Void InitItemBinders(); // 0x05b2aec0
	System.Void UpdateItem(FairyGUI.GObject obj, WizardGames.Soc.SocClient.Ui.NavBarData navData, System.Boolean isFinal); // 0x05b2b030
	System.Void UpdateButtonStyle(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.NavBarData navData); // 0x05b2b684
	System.Void .ctor(); // 0x05b2ba58
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MissionTraceNavBar.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.MissionTraceNavBar.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.NavBarItemBinder> <>9__0_0; // 0x8
	static System.Void .cctor(); // 0x05b2bac0
	System.Void .ctor(); // 0x05b2bb24
	WizardGames.Soc.SocClient.Ui.NavBarItemBinder <InitItemBinders>b__0_0(FairyGUI.GComponent c); // 0x05b2bb8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlayModeNavBarData : WizardGames.Soc.SocClient.Ui.NavBarData
{
	System.Boolean <HasPlayed>k__BackingField; // 0x88
	System.String <Time>k__BackingField; // 0x90
	System.Boolean <IsLimitModeOpen>k__BackingField; // 0x98
	System.Int32 <CfgId>k__BackingField; // 0x9c
	System.Boolean get_HasPlayed(); // 0x05b2bc2c
	System.Void set_HasPlayed(System.Boolean value); // 0x05b2bc90
	System.String get_Time(); // 0x05b2bd0c
	System.Void set_Time(System.String value); // 0x05b2bd70
	System.Boolean get_IsLimitModeOpen(); // 0x05b2bdf0
	System.Void set_IsLimitModeOpen(System.Boolean value); // 0x05b2be54
	System.Int32 get_CfgId(); // 0x05b2bed0
	System.Void set_CfgId(System.Int32 value); // 0x05b2bf34
	System.Void .ctor(System.String title, System.Int32 tabId, System.String icon, WizardGames.Soc.SocClient.Ui.ENavIconType iconType); // 0x05b2bfac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlayModeNavBarItemBinder : WizardGames.Soc.SocClient.Ui.NavBarItemBinder
{
	FairyGUI.Controller openTipsCtrl; // 0x80
	FairyGUI.Controller showTimeCtrl; // 0x88
	FairyGUI.GImage hasPlayed; // 0x90
	FairyGUI.GTextField timeShow; // 0x98
	FairyGUI.Transition loopTrans; // 0xa0
	FairyGUI.Transition recommendTrans; // 0xa8
	FairyGUI.Controller recommendCtrl; // 0xb0
	FairyGUI.GLoader bgLoader; // 0xb8
	System.Void .ctor(FairyGUI.GComponent root); // 0x05b2c05c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlayModeNavBar : WizardGames.Soc.SocClient.Ui.ComCommonNavBar
{
	
	System.Void InitItemBinders(); // 0x05b2c2a8
	System.Void UpdateItem(FairyGUI.GObject obj, WizardGames.Soc.SocClient.Ui.NavBarData navData, System.Boolean isFinal); // 0x0552d23c
	System.Void RefreshNewbieRecommend(); // 0x05b2c9cc
	FairyGUI.GList GetFirstList(); // 0x05b2cc58
	System.Void .ctor(); // 0x05b2ccbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlayModeNavBar.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.PlayModeNavBar.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.NavBarItemBinder> <>9__0_0; // 0x8
	static System.Void .cctor(); // 0x05b2cd24
	System.Void .ctor(); // 0x05b2cd88
	WizardGames.Soc.SocClient.Ui.NavBarItemBinder <InitItemBinders>b__0_0(FairyGUI.GComponent c); // 0x05b2cdf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ShadowNavBarItemBinder : WizardGames.Soc.SocClient.Ui.NavBarItemBinder
{
	FairyGUI.GRichTextField TitleShadow; // 0x80
	System.Void .ctor(FairyGUI.GComponent root); // 0x05b2ce90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ShadowNavBar : WizardGames.Soc.SocClient.Ui.ComCommonNavBar
{
	
	System.Void InitItemBinders(); // 0x05b2cf5c
	System.Void UpdateItem(FairyGUI.GObject obj, WizardGames.Soc.SocClient.Ui.NavBarData navData, System.Boolean isFinal); // 0x05b2d0cc
	System.Void .ctor(); // 0x05b2d260
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ShadowNavBar.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ShadowNavBar.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.NavBarItemBinder> <>9__0_0; // 0x8
	static System.Void .cctor(); // 0x05b2d2c8
	System.Void .ctor(); // 0x05b2d32c
	WizardGames.Soc.SocClient.Ui.NavBarItemBinder <InitItemBinders>b__0_0(FairyGUI.GComponent c); // 0x05b2d394
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TwoStyleNavBarData : WizardGames.Soc.SocClient.Ui.NavBarData
{
	
	System.Void .ctor(System.String title, System.Int32 tabId, System.String icon, WizardGames.Soc.SocClient.Ui.ENavIconType iconType); // 0x05b2d434
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TwoStyleNavBarItemBinder : WizardGames.Soc.SocClient.Ui.NavBarItemBinder
{
	FairyGUI.Controller Occupy; // 0x80
	FairyGUI.Controller triangleStarusCtrl; // 0x88
	System.Void .ctor(FairyGUI.GComponent root); // 0x05b2d4e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TwoStyleNavBar : WizardGames.Soc.SocClient.Ui.ComCommonNavBar
{
	
	System.Void InitItemBinders(); // 0x05b2d5d4
	System.Void CreateItem(); // 0x05b2d744
	System.String get_PrimaryTabPath(); // 0x05b2dc48
	System.String get_SecondaryTabPath(); // 0x05b2dbd0
	System.Void .ctor(); // 0x05b2dcc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TwoStyleNavBar.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.TwoStyleNavBar.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.NavBarItemBinder> <>9__0_0; // 0x8
	static System.Void .cctor(); // 0x05b2dd28
	System.Void .ctor(); // 0x05b2dd8c
	WizardGames.Soc.SocClient.Ui.NavBarItemBinder <InitItemBinders>b__0_0(FairyGUI.GComponent c); // 0x05b2ddf4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComPieItemIcon : FairyGUI.GComponent
{
	FairyGUI.GImage imagePie; // 0x288
	FairyGUI.GLoader icon; // 0x290
	FairyGUI.Controller stateController; // 0x298
	System.Boolean optionEnable; // 0x2a0
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05b2de94
	System.Void OnInit(); // 0x05b2df1c
	System.Void SetState(System.Boolean enable); // 0x05b2e030
	System.Void SetIconPosXY(UnityEngine.Vector2 pos); // 0x05b2e0c4
	System.Void SetIconSprite(System.String spritePath); // 0x05b2e158
	System.Void SetPieProgressAndRotation(System.Single progress, System.Single rotationAngle); // 0x05b2e1e0
	System.Void .ctor(); // 0x05b2e284
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComRoulette : FairyGUI.GComponent
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComRouletteBinder binder; // 0x288
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComRoulette.RouletteData> optionDataList; // 0x290
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.RouletteIconBinder> allIcons; // 0x298
	System.Collections.Generic.List<FairyGUI.GComponent> allSpliters; // 0x2a0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComRoulette.RouletteData> groupDataList; // 0x2a8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.RouletteIconBinder> allGroupIcons; // 0x2b0
	System.Collections.Generic.List<FairyGUI.GComponent> allGroupSpliters; // 0x2b8
	UnityEngine.Vector2 centerPos; // 0x2c0
	System.Single curSplitDegree; // 0x2c8
	FairyGUI.Shape sectorShape; // 0x2d0
	System.Boolean enableClick; // 0x2d8
	System.Action<System.Int32> clickItemBack; // 0x2e0
	System.Action clickClearBack; // 0x2e8
	System.Action<System.Int32,System.Boolean> OnUpdateDirection; // 0x2f0
	System.Single useScale; // 0x2f8
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05b2e2f4
	System.Void Init(System.Boolean isEnableClick, System.Action<System.Int32> onItemClick, System.Action onClearClick, System.Single scale); // 0x05b2ea30
	System.Int32 GetActiveIndex(System.Single rot); // 0x05b2eb00
	System.Void UpdateDirection(UnityEngine.Vector2 direction, System.Int32 activeIndex, System.Int32 activeGroup, System.Boolean isCancel); // 0x05b2ec68
	System.Void OnClickCircle(FairyGUI.EventContext context); // 0x05b2fb10
	System.Void UpdateClickDirection(UnityEngine.Vector2 direction, System.Int32 activeIndex); // 0x05b300ec
	System.Void ForceSelectFirstIndex(); // 0x05b30834
	System.Void SetTitle(System.String title); // 0x05b30e38
	System.Void StartDragJoyStick(); // 0x05b30f04
	System.Void EndDragJoyStick(); // 0x05b31030
	System.Void ResetSelect(); // 0x05b31284
	System.Void AddOption(System.String title, System.String iconUrl, System.Single degree, System.Boolean changeSelectedColor, System.Boolean showTitle, System.Int64 Id); // 0x05b312ec
	System.Void SetHighlightSectorVisible(System.Boolean visible); // 0x05b2e760
	System.Void UpdateItem(System.Int32 index, System.String title, System.String iconUrl, System.Int64 Id); // 0x05b322f8
	System.Void UpdateAddIcon(WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.RouletteIconBinder iconBinder); // 0x05b32170
	System.Void OnClickClear(FairyGUI.EventContext context); // 0x05b32598
	System.Boolean IsOptionEnabled(System.Int32 index); // 0x05b2f9a4
	System.Void Clear(); // 0x05b326d0
	System.Void Dispose(); // 0x05b32ac8
	System.Void .ctor(); // 0x05b32b38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComRoulette.RouletteData : System.Object
{
	System.String <Title>k__BackingField; // 0x10
	System.String <IconUrl>k__BackingField; // 0x18
	System.Int64 <Id>k__BackingField; // 0x20
	System.Void set_Title(System.String value); // 0x05b32d1c
	System.String get_Title(); // 0x05b32d9c
	System.Void set_IconUrl(System.String value); // 0x05b32e00
	System.Void set_Id(System.Int64 value); // 0x05b32e80
	System.Int64 get_Id(); // 0x05b32ef8
	System.Void SetData(System.String title, System.String iconUrl, System.Int64 id); // 0x05b31fd8
	System.Void .ctor(); // 0x05b32f5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComRouletteHandler : FairyGUI.GComponent
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComRouletteHandlerBinder binder; // 0x288
	WizardGames.Soc.SocClient.Ui.ComRoulette roulette; // 0x290
	System.Boolean isDraging; // 0x298
	System.Boolean isClickCancel; // 0x299
	System.Boolean isActionCancel; // 0x29a
	System.Single cancelRadius; // 0x29c
	System.Single groupRadius; // 0x2a0
	System.Collections.Generic.List<System.Action<System.Int32>> groupActions; // 0x2a8
	System.Collections.Generic.List<System.String> groupIconUrls; // 0x2b0
	System.Int32 preActiveGroup; // 0x2b8
	System.Collections.Generic.List<System.Action<System.Int32>> optionActions; // 0x2c0
	System.Collections.Generic.List<System.String> optionIconUrls; // 0x2c8
	FairyGUI.Shape sectorShape; // 0x2d0
	UnityEngine.Vector2 centerPos; // 0x2d8
	FairyGUI.GLoader controlledIcon; // 0x2e0
	UnityEngine.Vector2 startPos; // 0x2e8
	UnityEngine.Vector2 touchStartPos; // 0x2f0
	System.Action OnClick; // 0x2f8
	System.Action OnStartTouch; // 0x300
	System.Action OnEndTouch; // 0x308
	System.Action OnStartDrag; // 0x310
	System.Action OnEndDrag; // 0x318
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05b32fc4
	System.Void UpdateJoyStickPos(FairyGUI.EventContext context); // 0x05b33a78
	System.Void EndDragJoyStick(FairyGUI.EventContext context); // 0x05b34e28
	System.Int32 GetSplitCount(); // 0x05b353f0
	System.Single GetSplitDegree(); // 0x05b3546c
	System.Int32 GetGroupCount(); // 0x05b34a1c
	System.Single GetGroupSplitDegree(); // 0x05b354e4
	System.Int32 GetActiveIndex(); // 0x05b34bf4
	System.Int32 GetActiveGroup(System.Single rot); // 0x05b34a98
	System.Void OnLongPressBegin(FairyGUI.EventContext context); // 0x05b3555c
	System.Void OnJoyStickTouchMove(FairyGUI.EventContext context); // 0x05b35b5c
	System.Void OnJoyStickClick(); // 0x05b35dc4
	System.Void StartDragJoyStick(FairyGUI.EventContext context); // 0x05b35628
	System.Void onDragingJoyStick(FairyGUI.EventContext context); // 0x05b35ae0
	System.Void Dispose(); // 0x05b35e44
	System.Void InitEvents(); // 0x05b3363c
	System.Void ClickCancelOnEndDragJoyStick(); // 0x05b35390
	System.Void OnJoyStickTouchBegin(FairyGUI.EventContext context); // 0x05b35ec0
	System.Void OnJoyStickTouchEnd(FairyGUI.EventContext context); // 0x05b35ff4
	System.Void .ctor(); // 0x05b360bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComStepper : FairyGUI.GComponent
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComStepperBinder binder; // 0x288
	System.Action<System.Int32> OnValueChange; // 0x290
	System.Int32 mouseScrollStep; // 0x298
	FairyGUI.Controller mouseScrollWheelEnableCtrl; // 0x2a0
	System.Int32 maxNum; // 0x2a8
	System.Int32 minNum; // 0x2ac
	System.Int32 curNum; // 0x2b0
	System.Int32 stepNum; // 0x2b4
	System.Int32 oldNum; // 0x2b8
	UnityEngine.Vector2 CounterPos; // 0x2bc
	UnityEngine.Vector2 stepperAnchor; // 0x2c4
	UnityEngine.Vector2 counterAnchor; // 0x2cc
	System.Void set_Enable(System.Boolean value); // 0x05b3622c
	System.Void Init(System.Int32 max, System.Int32 initial, System.Int32 step, System.Int32 min); // 0x05b3674c
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05b36b34
	System.Void OnClickMax(FairyGUI.EventContext context); // 0x05b36f00
	System.Void OnClickInput(FairyGUI.EventContext context); // 0x05b36f9c
	System.Void OnCounterConfirmCallBack(System.Int32 num); // 0x05b3714c
	System.Void OnCounterChangeCallBack(System.Int32 num); // 0x05b37280
	System.Void SetValue(System.Int32 num); // 0x05b371c8
	System.Void OnClickAdd(FairyGUI.EventContext context); // 0x05b372fc
	System.Void OnClickMinus(FairyGUI.EventContext context); // 0x05b373a0
	System.Void RefreshNum(); // 0x05b368ec
	System.Void RefreshBtnEnable(); // 0x05b36520
	System.Int32 GetValue(); // 0x05b37444
	System.Int32 GetMaxValue(); // 0x05b374a8
	System.Void Dispose(); // 0x05b3750c
	System.Void .ctor(); // 0x05b37574
	static System.Void .cctor(); // 0x05b375f4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EEnumRightTopComId : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EEnumRightTopComId Settings = 0;
	static WizardGames.Soc.SocClient.Ui.EEnumRightTopComId More = 1;
	static WizardGames.Soc.SocClient.Ui.EEnumRightTopComId CheckTechLevel = 2;
	static WizardGames.Soc.SocClient.Ui.EEnumRightTopComId TechLevel = 3;
	static WizardGames.Soc.SocClient.Ui.EEnumRightTopComId HomeBtnSlot = 4;
	static WizardGames.Soc.SocClient.Ui.EEnumRightTopComId Season = 5;
	static WizardGames.Soc.SocClient.Ui.EEnumRightTopComId ReportBtnSlot = 6;
	static WizardGames.Soc.SocClient.Ui.EEnumRightTopComId PowerLevelSlot = 7;
	static WizardGames.Soc.SocClient.Ui.EEnumRightTopComId CoinSlot = 8;
	static WizardGames.Soc.SocClient.Ui.EEnumRightTopComId CoinTextSlot = 9;
	static WizardGames.Soc.SocClient.Ui.EEnumRightTopComId BtnTipSlot = 10;
	static WizardGames.Soc.SocClient.Ui.EEnumRightTopComId BtnLogSlot = 11;
	static WizardGames.Soc.SocClient.Ui.EEnumRightTopComId BtnServiceSlot = 12;
	static WizardGames.Soc.SocClient.Ui.EEnumRightTopComId AnnouncementSlot = 13;
	static WizardGames.Soc.SocClient.Ui.EEnumRightTopComId Code = 14;
	static WizardGames.Soc.SocClient.Ui.EEnumRightTopComId Drama = 15;
	static WizardGames.Soc.SocClient.Ui.EEnumRightTopComId Share = 16;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RightTopbar : FairyGUI.GComponent
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int32,FairyGUI.GComponent> componentMap; // 0x288
	System.Collections.Generic.List<System.Int32> idList; // 0x290
	System.Collections.Generic.Dictionary<System.Int32,System.String> packageMap; // 0x298
	System.Collections.Generic.Dictionary<System.Int32,System.String> nameMap; // 0x2a0
	System.String DefaultPackageName; // 0x2a8
	System.Single columnGap; // 0x2b0
	System.Void .ctor(); // 0x05b376c8
	System.Void RegisterComName(WizardGames.Soc.SocClient.Ui.EEnumRightTopComId id, System.String componentName); // 0x05b37af0
	System.Void UpdateItem(WizardGames.Soc.SocClient.Ui.EEnumRightTopComId id, System.Action<FairyGUI.GComponent> updateAction); // 0x05b37b98
	System.Void SetItemVisible(WizardGames.Soc.SocClient.Ui.EEnumRightTopComId id, System.Boolean visible); // 0x05b38600
	FairyGUI.GComponent GetComponentById(WizardGames.Soc.SocClient.Ui.EEnumRightTopComId id); // 0x05b386dc
	System.Void OnChildSizeChanged(FairyGUI.EventContext context); // 0x05b38790
	System.Void SortAndRebuild(); // 0x05b3801c
	System.Void RefreshLayoutAnimated(); // 0x05b38240
	static System.Void .cctor(); // 0x05b38808
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BottomButtonData : System.Object
{
	System.Int32 Id; // 0x10
	WizardGames.Soc.SocClient.Manager.EHotKeyLayer Group; // 0x14
	FairyGUI.EventCallback1 Action; // 0x18
	WizardGames.Soc.SocClient.Manager.EResponseLevel ResponseLevel; // 0x20
	System.Void .ctor(); // 0x05b388dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.CurrencyInfo : System.Object
{
	System.String Icon; // 0x10
	System.Func<System.String> TextFunc; // 0x18
	FairyGUI.EventCallback1 OnAddButtonClicked; // 0x20
	FairyGUI.EventCallback0 OnShowTips; // 0x28
	FairyGUI.EventCallback0 OnHideTips; // 0x30
	System.Func<System.Boolean> VisibleFunc; // 0x38
	System.Void .ctor(); // 0x05b38954
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTopBar : FairyGUI.GLabel
{
	FairyGUI.Controller navTabStyleCtrl; // 0x298
	FairyGUI.GLabel titleTextField; // 0x2a0
	FairyGUI.GButton tipsButton; // 0x2a8
	FairyGUI.Controller btnTipStyleCtrl; // 0x2b0
	System.Boolean backButtonVisible; // 0x2b8
	FairyGUI.GButton backButton; // 0x2c0
	FairyGUI.GLoader firstNavTab; // 0x2c8
	FairyGUI.GLoader secondNavTab; // 0x2d0
	FairyGUI.GList coinList; // 0x2d8
	FairyGUI.GTextField coinText; // 0x2e0
	System.Boolean isEnabled; // 0x2e8
	FairyGUI.GComponent rightList; // 0x2f0
	FairyGUI.GButton homeBackBtn; // 0x2f8
	FairyGUI.GButton reportBtn; // 0x300
	FairyGUI.GButton serviceBtn; // 0x308
	WizardGames.Soc.SocClient.Ui.ComTopBar.EServiceUrl serviceUrl; // 0x310
	FairyGUI.GButton logBtn; // 0x318
	FairyGUI.GButton announceBtn; // 0x320
	FairyGUI.GButton btnMore; // 0x328
	FairyGUI.GButton btnWriteOff; // 0x330
	FairyGUI.Controller openMorePanelCtrl; // 0x338
	FairyGUI.GTextField TechTipText; // 0x340
	FairyGUI.GButton TechTipBtn; // 0x348
	FairyGUI.GLoader TechIcon; // 0x350
	FairyGUI.Controller TechIconCtrl; // 0x358
	FairyGUI.GButton checkTechBtn; // 0x360
	FairyGUI.Controller titleLineCtrl; // 0x368
	FairyGUI.GTextField SeasonTimeText; // 0x370
	FairyGUI.GComponent ShareCom; // 0x378
	FairyGUI.GButton shareBtn; // 0x380
	FairyGUI.GButton chatBtn; // 0x388
	FairyGUI.GButton pictureBtn; // 0x390
	FairyGUI.Controller openSharePanelCtrl; // 0x398
	FairyGUI.EventCallback0 chatBtnCallback; // 0x3a0
	FairyGUI.EventCallback0 pictureBtnCallback; // 0x3a8
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar linkNavBar; // 0x3b0
	FairyGUI.GComponent forceLevel; // 0x3b8
	FairyGUI.GImage forceLevelProgress; // 0x3c0
	FairyGUI.GTextField forceName; // 0x3c8
	FairyGUI.GTextField forceLevelText; // 0x3d0
	FairyGUI.GTextField forceLevelExp; // 0x3d8
	WizardGames.Soc.Common.Data.common.CurrencyIDsVector3[] currencyIDsVector3Array; // 0x3e0
	System.Boolean isCurrencyAutoSetByConfig; // 0x3e8
	FairyGUI.GList <FirstNavList>k__BackingField; // 0x3f0
	FairyGUI.GList <SecondNavList>k__BackingField; // 0x3f8
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComTopBarBinder rootBinder; // 0x400
	WizardGames.Soc.SocClient.Ui.RightTopbar rightTopbar; // 0x408
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.CurrencyInfo> currencyDatas; // 0x410
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComTopBar_CoinListItemBinder> currencyBinders; // 0x418
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.ComTopBar.ToolTipsBinder> toolTipsBinders; // 0x420
	static SocLogger <logger>k__BackingField; // 0x0
	FairyGUI.GList get_CoinList(); // 0x05b389bc
	FairyGUI.GList get_FirstNavList(); // 0x05b38a20
	System.Void set_FirstNavList(FairyGUI.GList value); // 0x05b38a84
	FairyGUI.GList get_SecondNavList(); // 0x05b38b04
	System.Void set_SecondNavList(FairyGUI.GList value); // 0x05b38b68
	System.Void set_Title(System.String value); // 0x05b38be8
	System.Void set_CoinText(System.String value); // 0x05b38c68
	FairyGUI.GButton get_TipsButton(); // 0x05b38de8
	static SocLogger get_logger(); // 0x05b38f8c
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05b39014
	System.Void OnAddedToStage(); // 0x05b39604
	System.Void OnRemovedFromStage(); // 0x05b39764
	System.Void OnReportBtnClicked(FairyGUI.EventContext context); // 0x05b3998c
	System.Void ConstructExtension(FairyGUI.Utils.ByteBuffer buffer); // 0x05b39aac
	System.Void Setup_AfterAdd(FairyGUI.Utils.ByteBuffer buffer, System.Int32 beginPos); // 0x05b39b60
	System.Void InitCurrencyList(); // 0x05b39dc0
	System.Void OnHomeButtonClicked(); // 0x05b3a25c
	System.Void OnClickLogBtn(FairyGUI.EventContext context); // 0x05b3a328
	System.Void OnClicAnnounceBtn(FairyGUI.EventContext context); // 0x05b3a9c8
	System.Void OnClickBtnMore(); // 0x05b3ab64
	System.Void HideClickBtnMore(UnityEngine.Vector2 uiPos); // 0x05b3ad64
	System.Void OnClickService(FairyGUI.EventContext context); // 0x05b3af08
	System.Void RefreshServiceButton(System.Boolean isShow, WizardGames.Soc.SocClient.Ui.ComTopBar.EServiceUrl url); // 0x05b3afb4
	System.Void RefreshReportButton(System.Boolean isShow); // 0x05b3b0c4
	System.Void RefreshTechLevel(System.Boolean isShow); // 0x05b3b1b8
	System.Void SetCheckTechVisible(System.Boolean isVisible); // 0x05b3b2bc
	System.Void SetReportButton(System.Boolean selected); // 0x05b3b38c
	System.Void RefreshLogButton(System.Boolean isShow); // 0x05b3b414
	System.Void SetAnnounceButton(System.Boolean isShow); // 0x05b3b518
	System.Void SetBtnMore(System.Boolean isShow); // 0x05b3b61c
	System.Void RefreshTitleLineCtrlState(System.Boolean isShow); // 0x05b3b720
	System.Void SetShareBtn(System.Boolean isShow); // 0x05b3b7b8
	System.Void OnClickShare(); // 0x05b3b8bc
	System.Void HideSharePanel(UnityEngine.Vector2 uiPos); // 0x05b3babc
	System.Void SetShareButtonCallbacks(FairyGUI.EventCallback0 onChat, FairyGUI.EventCallback0 onPicture); // 0x05b3bcbc
	System.Void coinItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05b3bdb0
	System.Void RefreshCurrencyInfoByConfig(); // 0x05b3c8a0
	static System.String SetCoinIcon(WizardGames.Soc.Common.Data.resource.OBJGenaral objGenaral); // 0x05b3c78c
	System.Void SetCurrency(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.CurrencyInfo> currencyDatas); // 0x05b3c94c
	System.Void RefreshCurrency(); // 0x05b3a0ec
	System.Void HideCurrency(); // 0x05b3c9d8
	System.Void OnEnable(); // 0x05b39668
	System.Void OnDisable(); // 0x05b397c8
	System.Void RegisterEvents(); // 0x05b3ca54
	System.Void UnRegisterEvents(); // 0x05b3cf30
	System.Void HideTab(); // 0x05b3d1a8
	System.Void ShowForceLevel(System.Int32 forceId, System.Int32 level, System.Int32 exp); // 0x05b3d23c
	System.Void SetSeasonTimeVisible(System.Boolean isVisible); // 0x05b3d510
	System.Void ShowStoryStage(System.Int32 stageId); // 0x05b3d614
	System.Void RefreshTipButton(System.Boolean isShow); // 0x05b3d778
	System.Void Dispose(); // 0x05b3d800
	System.Void InitForPlatform(); // 0x05b39528
	System.Void SetHotKeyPosition(); // 0x05b3d9e4
	System.Void SetupForPlatform(); // 0x05b39d60
	System.Void SetBackButtonVisible(System.Boolean visible); // 0x05b3da44
	System.Void SetBackButtonClicked(FairyGUI.EventCallback1 callback); // 0x05b3dad4
	System.Void ClearBackButtonClicked(); // 0x05b3d968
	System.Void FireBackButtonClick(); // 0x05b3db68
	System.Void ShowTabWithTrans(System.String navBarUrl, System.String secondBarUrl); // 0x05b3dbf4
	System.Void ShowTab(System.String navBarUrl, System.String secondBarUrl); // 0x05b3dc70
	System.Void OnEnableImpl(); // 0x05b3cba0
	System.Void OnDisableImpl(); // 0x05b3d07c
	System.Void AddBottomDataList(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BottomButtonData> dataList); // 0x05b3df44
	System.Void RemoveBottomDataList(System.Int32[] dataIds); // 0x05b3dfb8
	System.Void SetHelpTooltips(System.String text); // 0x05b3e02c
	System.Void SetHelpWindow(FairyGUI.EventCallback0 callback, System.Int32 manualId); // 0x05b3e1d4
	System.Void HideHelp(); // 0x05b3e378
	System.Void RefreshHomeButton(); // 0x05b3e3ec
	System.Void SetEscTitle(System.String title); // 0x05b3e510
	System.Void SetNavTabStyle(System.Int32 value); // 0x05b3ccf8
	System.Void SetBackButtonDataId(System.Int32 id); // 0x05b3e584
	System.Void SetReportBtnOffset(); // 0x05b3cc00
	System.Void SetShareBtnOffset(); // 0x05b3cc7c
	System.Void set_LinkNavBar(WizardGames.Soc.SocClient.Ui.ComCommonNavBar value); // 0x05b3e5f8
	System.Void .ctor(); // 0x05b3e678
	static System.Void .cctor(); // 0x05b3e8d8
	System.Void <Setup_AfterAdd>b__77_0(System.Object _); // 0x05b3e970
	System.Void <RefreshServiceButton>b__85_0(FairyGUI.GComponent comp); // 0x05b3e9e8
	System.Void <RefreshReportButton>b__86_0(FairyGUI.GComponent comp); // 0x05b3eb6c
	System.Void <RefreshTechLevel>b__87_0(FairyGUI.GComponent comp); // 0x05b3ec70
	System.Void <SetCheckTechVisible>b__88_0(FairyGUI.GComponent comp); // 0x05b3eddc
	System.Void <RefreshLogButton>b__90_0(FairyGUI.GComponent comp); // 0x05b3ee94
	System.Void <SetAnnounceButton>b__91_0(FairyGUI.GComponent comp); // 0x05b3f018
	System.Void <SetBtnMore>b__92_0(FairyGUI.GComponent comp); // 0x05b3f11c
	System.Void <SetShareBtn>b__95_0(FairyGUI.GComponent comp); // 0x05b3f360
	System.Void <RefreshCurrency>b__104_0(FairyGUI.GComponent comp); // 0x05b3f5c0
	System.Void <SetSeasonTimeVisible>b__114_0(FairyGUI.GComponent comp); // 0x05b3f938
	System.Void <RefreshHomeButton>b__136_0(FairyGUI.GComponent comp); // 0x05b3f9f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTopBar.ToolTipsBinder : System.Object, WizardGames.Soc.SocClient.Ui.Utils.IToolTips
{
	FairyGUI.GComponent Target; // 0x10
	WizardGames.Soc.SocClient.Ui.CurrencyInfo data; // 0x18
	static System.Int64 delayTimer; // 0x0
	WizardGames.Soc.Common.Data.resource.OBJGenaral objGenaral; // 0x20
	System.Void set_Data(WizardGames.Soc.SocClient.Ui.CurrencyInfo value); // 0x05b3c694
	System.Void set_ObjGenaral(WizardGames.Soc.Common.Data.resource.OBJGenaral value); // 0x05b3c810
	System.Void .ctor(FairyGUI.GComponent target); // 0x05b3faf4
	System.Void ShowTips(FairyGUI.EventContext context); // 0x05b3fb80
	System.Void HideTips(); // 0x05b3cd80
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ComTopBar.EServiceUrl : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ComTopBar.EServiceUrl None = 0;
	static WizardGames.Soc.SocClient.Ui.ComTopBar.EServiceUrl UiLogin = 14;
	static WizardGames.Soc.SocClient.Ui.ComTopBar.EServiceUrl UiLobbyTopup = 15;
	static WizardGames.Soc.SocClient.Ui.ComTopBar.EServiceUrl UiSetting = 16;
	static WizardGames.Soc.SocClient.Ui.ComTopBar.EServiceUrl UiActivity = 17;
	static WizardGames.Soc.SocClient.Ui.ComTopBar.EServiceUrl UiLobby = 18;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTopBar.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ComTopBar.<>c <>9; // 0x0
	static System.Comparison<System.IO.FileInfo> <>9__80_0; // 0x8
	static System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__81_0; // 0x10
	static FairyGUI.EventCallback0 <>9__92_1; // 0x18
	static FairyGUI.EventCallback0 <>9__115_2; // 0x20
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComTopBar_CoinListItemBinder> <>9__147_0; // 0x28
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.ComTopBar.ToolTipsBinder> <>9__147_1; // 0x30
	static System.Void .cctor(); // 0x05b3fda8
	System.Void .ctor(); // 0x05b3fe0c
	System.Int32 <OnClickLogBtn>b__80_0(System.IO.FileInfo x, System.IO.FileInfo y); // 0x05b3fe74
	System.Void <OnClicAnnounceBtn>b__81_0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05b3ff60
	System.Void <SetBtnMore>b__92_1(); // 0x05b40034
	System.Void <ShowStoryStage>b__115_2(); // 0x05b400d0
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComTopBar_CoinListItemBinder <.ctor>b__147_0(FairyGUI.GComponent c); // 0x05b40134
	WizardGames.Soc.SocClient.Ui.ComTopBar.ToolTipsBinder <.ctor>b__147_1(FairyGUI.GComponent c); // 0x05b401d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTopBar.<>c__DisplayClass100_0 : System.Object
{
	System.Int32 jumpType; // 0x10
	System.Int32 jumpID; // 0x14
	System.Int32 currencyId; // 0x18
	System.Void .ctor(); // 0x05b3c724
	System.Void <coinItemRenderer>b__0(FairyGUI.EventContext context); // 0x05b40278
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTopBar.<>c__DisplayClass112_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComTopBar <>4__this; // 0x10
	WizardGames.Soc.Common.Data.Play.OBJMainTaskForce cfg; // 0x18
	System.Int32 level; // 0x20
	WizardGames.Soc.Common.Data.Play.OBJMainTaskForceLevel levelCfg; // 0x28
	System.Int32 exp; // 0x30
	System.Void .ctor(); // 0x05b3d4a8
	System.Void <ShowForceLevel>b__0(FairyGUI.GComponent comp); // 0x05b40370
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTopBar.<>c__DisplayClass115_0 : System.Object
{
	System.Int32 stageId; // 0x10
	System.Void .ctor(); // 0x05b3d710
	System.Void <ShowStoryStage>b__0(FairyGUI.GComponent comp); // 0x05b40754
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTopBar.<>c__DisplayClass115_1 : System.Object
{
	FairyGUI.GComponent comp; // 0x10
	System.Void .ctor(); // 0x05b40a24
	System.Void <ShowStoryStage>b__1(); // 0x05b40a8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTopBar.<>c__DisplayClass133_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComTopBar <>4__this; // 0x10
	System.String text; // 0x18
	System.Void .ctor(); // 0x05b3e16c
	System.Void <SetHelpTooltips>b__0(); // 0x05b40ce4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTopBar.<>c__DisplayClass134_0 : System.Object
{
	System.Int32 manualId; // 0x10
	FairyGUI.EventCallback0 callback; // 0x18
	System.Void .ctor(); // 0x05b3e310
	System.Void <SetHelpWindow>b__0(); // 0x05b40d60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTopBar.<>c__DisplayClass62_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComTopBar <>4__this; // 0x10
	System.String value; // 0x18
	System.Void .ctor(); // 0x05b38d80
	System.Void <set_CoinText>b__0(FairyGUI.GComponent comp); // 0x05b40e48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTopBar.<>c__DisplayClass64_0 : System.Object
{
	FairyGUI.GComponent btn; // 0x10
	System.Void .ctor(); // 0x05b38f24
	System.Void <get_TipsButton>b__0(FairyGUI.GComponent comp); // 0x05b40f20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PieOptionData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.String IconUrl; // 0x10
	System.Boolean Enable; // 0x18
	static WizardGames.Soc.SocClient.Ui.PieOptionData Get(); // 0x05b40fa0
	static System.Void Release(WizardGames.Soc.SocClient.Ui.PieOptionData obj); // 0x05b41034
	System.Void OnGet(); // 0x05b410d4
	System.Void OnRelease(); // 0x05b41168
	System.Void OnDestroy(); // 0x05b411c8
	System.Void .ctor(); // 0x05b41228
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.WireInterfaceComGroupAutoConnection : WizardGames.Soc.SocClient.Ui.WireInterfaceComGroupBase
{
	WizardGames.Soc.SocClient.Ui.ComInfoButton btnTip; // 0x20
	System.Void OnUiCreate(FairyGUI.GComponent node, WizardGames.Soc.SocClient.Ui.UiHudElemWireInterfaceBeta2 hud); // 0x05b41290
	System.Void .ctor(); // 0x05b4150c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.WireInterfaceComGroupBase : System.Object
{
	FairyGUI.GComponent rootGroup; // 0x10
	WizardGames.Soc.SocClient.Ui.UiHudElemWireInterfaceBeta2 hudElem; // 0x18
	System.Void OnUiCreate(FairyGUI.GComponent node, WizardGames.Soc.SocClient.Ui.UiHudElemWireInterfaceBeta2 hud); // 0x05b41474
	System.Void OnEnable(); // 0x05b415d8
	System.Void OnDisable(); // 0x05b41654
	System.Void OnUiDispose(); // 0x05b416d0
	System.Void .ctor(); // 0x05b41570
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.WireInterfaceComGroupEmpty : WizardGames.Soc.SocClient.Ui.WireInterfaceComGroupBase
{
	
	System.Void .ctor(); // 0x05b4175c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ESlotType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ESlotType ElectricInput = 0;
	static WizardGames.Soc.SocClient.Ui.ESlotType ElectricOutput = 1;
	static WizardGames.Soc.SocClient.Ui.ESlotType FluidicInput = 2;
	static WizardGames.Soc.SocClient.Ui.ESlotType FluidicOutput = 3;
	static WizardGames.Soc.SocClient.Ui.ESlotType SignalInput = 4;
	static WizardGames.Soc.SocClient.Ui.ESlotType SignalOutput = 5;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.WireInterfaceComGroupSelect : WizardGames.Soc.SocClient.Ui.WireInterfaceComGroupBase
{
	FairyGUI.GList listWireInterface; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ESlotType> slotTypeList; // 0x28
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ESlotType,System.Collections.Generic.List<WizardGames.Soc.Common.Electric.IOSlotBase>> slotConnectDic; // 0x30
	System.Collections.Generic.List<FairyGUI.GButton> itemList; // 0x38
	System.Int32 itemIndex; // 0x40
	System.Void OnUiCreate(FairyGUI.GComponent node, WizardGames.Soc.SocClient.Ui.UiHudElemWireInterfaceBeta2 hud); // 0x05b417c0
	System.Void OnEnable(); // 0x05b41914
	System.Void OnDisable(); // 0x05b41c7c
	System.Void UpdateRaycastTarget(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x05b41e60
	System.Void RefreshViewWireList(); // 0x05b41efc
	System.Void RefreshWireSlot(); // 0x05b42874
	System.Void ResetWireSlot(); // 0x05b41d6c
	System.Void OnRenderWireSlotItem(System.Int32 index, FairyGUI.GObject obj); // 0x05b429b4
	System.Void .ctor(); // 0x05b42d58
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.WireInterfaceComGroupSelect.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.WireInterfaceComGroupSelect <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ESlotType slotType; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.Electric.IOSlotBase> slotList; // 0x20
	FairyGUI.GList slotConnectList; // 0x28
	System.Void .ctor(); // 0x05b42cf0
	System.Void <OnRenderWireSlotItem>b__0(System.Int32 index, FairyGUI.GObject obj); // 0x05b42eb8
	System.Void <OnRenderWireSlotItem>b__1(FairyGUI.EventContext context); // 0x05b432fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.WireInterfaceComGroupSelect.<>c__DisplayClass6_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.WireInterfaceComGroupSelect <>4__this; // 0x10
	System.Int32 defaultItemWidth; // 0x18
	System.Void .ctor(); // 0x05b41c14
	System.Void <OnEnable>b__0(); // 0x05b43510
	System.Void <OnEnable>b__1(); // 0x05b4366c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.WireInterfaceComGroupWiring : WizardGames.Soc.SocClient.Ui.WireInterfaceComGroupBase
{
	static SocLogger Logger; // 0x0
	FairyGUI.GComponent comInterface1; // 0x20
	FairyGUI.GObject imgArrow1; // 0x28
	FairyGUI.GObject imgBg1; // 0x30
	FairyGUI.GComponent comInterface2; // 0x38
	FairyGUI.GObject imgArrow2; // 0x40
	FairyGUI.GObject imgBg2; // 0x48
	FairyGUI.Controller ctrDirection; // 0x50
	FairyGUI.Controller ctrWireState; // 0x58
	FairyGUI.Controller comboBoxInterface1SlotTypeCtr; // 0x60
	FairyGUI.Controller comboBoxInterface2SlotTypeCtr; // 0x68
	FairyGUI.Controller device1ComboBoxStateCtr; // 0x70
	FairyGUI.Controller device2ComboBoxStateCtr; // 0x78
	FairyGUI.GTextField device1TextName; // 0x80
	FairyGUI.GTextField device2TextName; // 0x88
	FairyGUI.GLoader device1Icon; // 0x90
	FairyGUI.GLoader device2Icon; // 0x98
	FairyGUI.Controller device2StateCtr; // 0xa0
	FairyGUI.GButton device2ClearWireBtn; // 0xa8
	FairyGUI.Controller ctrInterface2WireState; // 0xb0
	FairyGUI.Controller ctrComboBox2WireState; // 0xb8
	FairyGUI.GTextField txtTips; // 0xc0
	System.Collections.Generic.List<WizardGames.Soc.Common.Electric.IOSlotBase> device1WireSlotLst; // 0xc8
	System.Collections.Generic.List<System.String> deviceNameList; // 0xd0
	System.Boolean isHaveElectricity; // 0xd8
	FairyGUI.GComboBox device1ComboBox; // 0xe0
	FairyGUI.GComboBox device2ComboBox; // 0xe8
	System.Void OnUiCreate(FairyGUI.GComponent node, WizardGames.Soc.SocClient.Ui.UiHudElemWireInterfaceBeta2 hud); // 0x05b437c8
	System.Void OnEnable(); // 0x05b44200
	System.Void OnDisable(); // 0x05b443e4
	System.Void OnCheckWireHaveElectricity(System.Boolean isHave); // 0x05b445c8
	System.Void UpdateControllerStateAndTip(); // 0x05b446f4
	System.Void UpdateControllerState(); // 0x05b44648
	System.Void UpdateTips(); // 0x05b44760
	System.Int32 GetWireState(); // 0x05b44998
	System.Void RefreshDeviceSlots(); // 0x05b44f48
	System.Void UpdateDirectionCtr(WizardGames.Soc.SocClient.Ui.ESlotType slotType); // 0x05b46144
	System.Void UpdateDeviceInfo(WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug pending, System.Boolean isDevice1); // 0x05b45dc4
	System.Void AddSlotNamesToList(System.Collections.Generic.List<WizardGames.Soc.Common.Electric.IOSlotBase> slots, System.Collections.Generic.List<System.String> nameList); // 0x05b46208
	System.Void OnClickClearWire(); // 0x05b46470
	System.Void OnDropdownListClick(); // 0x05b46704
	System.Void SetTips(System.String tips); // 0x05b44e84
	System.Void OnCreateInterface(FairyGUI.GComponent node); // 0x05b439bc
	System.Void BindKey(); // 0x05b44384
	System.Void UnBindKey(); // 0x05b44568
	System.Void UpdateComboBoxState(System.Boolean isIntelligent, System.Boolean enable); // 0x05b467a8
	System.Void UpdateComboBox(System.Collections.Generic.List<WizardGames.Soc.Common.Electric.IOSlotBase> slots, FairyGUI.GComboBox comboBox, WizardGames.Soc.Common.Electric.IOSlotBase selectedSlot, System.Boolean isComboBoxEnable); // 0x05b45fd4
	System.Void ItemRenderer1(System.Int32 index, FairyGUI.GObject item); // 0x05b468b0
	System.Void ItemRenderer2(System.Int32 index, FairyGUI.GObject item); // 0x05b46a3c
	System.Void OnClickComboBox(FairyGUI.EventContext context); // 0x05b46bd4
	System.Void OnChangeComboBox1(FairyGUI.EventContext context); // 0x05b46dcc
	System.Void OnChangeComboBox2(FairyGUI.EventContext context); // 0x05b47164
	System.Void .ctor(); // 0x05b47608
	static System.Void .cctor(); // 0x05b47710
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIPieComInfoTipsBase : System.Object
{
	WizardGames.Soc.SocClient.Ui.ConstructionInfoData curInfoData; // 0x10
	System.Void Hide(); // 0x05b477e4
	System.Void Show(WizardGames.Soc.SocClient.Ui.ConstructionInfoData infoData); // 0x05b47844
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIPieConstructionInfoTips : System.Object
{
	static System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EConstructionEditMode,WizardGames.Soc.SocClient.Ui.EConstructionInfoType> editModeToInfoTypeDic; // 0x0
	FairyGUI.Controller ctrTipState; // 0x10
	WizardGames.Soc.SocClient.Ui.EConstructionEditMode curEditMode; // 0x18
	WizardGames.Soc.SocClient.Ui.EConstructionInfoType curInfoType; // 0x1c
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EConstructionInfoType,WizardGames.Soc.SocClient.Ui.UIPieComInfoTipsBase> comInfoTipsDic; // 0x20
	System.Void ShowTips(WizardGames.Soc.SocClient.Ui.EConstructionEditMode editMode, WizardGames.Soc.SocClient.Ui.ConstructionInfoData infoData); // 0x05b478c4
	System.Void SetTipState(WizardGames.Soc.SocClient.Ui.EConstructionInfoType constructionInfoType); // 0x05b47ae0
	System.Void ClearTipData(); // 0x05b47a1c
	static System.Void .cctor(); // 0x05b47b68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComPie : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemPieMenu <PieMenu>k__BackingField; // 0x10
	FairyGUI.GComponent gComPieOptionPanel; // 0x18
	WizardGames.Soc.SocClient.Ui.ComPieOptionItem comPieOptionSelectedItem; // 0x20
	WizardGames.Soc.SocClient.Ui.Construction.PlaceholderPartViewData placeholderPartViewData; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase> partViewDataList; // 0x30
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase curPreSelctedData; // 0x38
	System.Int32 curSelectedIndex; // 0x40
	System.Action<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase> onOptionSelected; // 0x48
	WizardGames.Soc.SocClient.Ui.ComPieListItemBlueprintCD listItemBlueprintCd; // 0x50
	WizardGames.Soc.SocClient.Ui.ComPieListItemDeployCraftCD listItemDeployCraftCd; // 0x58
	System.Boolean isSelected; // 0x60
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.ComPieOptionItem> cacheComPieOptionItemDic; // 0x68
	System.Single radius; // 0x70
	FairyGUI.GList listIconInfoTips; // 0x78
	FairyGUI.GTextField txtTitle; // 0x80
	FairyGUI.GTextField txtDesc; // 0x88
	WizardGames.Soc.SocClient.Ui.UIPieConstructionInfoTips infoTips; // 0x90
	WizardGames.Soc.SocClient.Ui.ConstructionInfoData constructionInfoData; // 0x98
	WizardGames.Soc.SocClient.Ui.EConstructionEditMode constructionEditMode; // 0xa0
	WizardGames.Soc.SocClient.Ui.UiHudElemPieMenu get_PieMenu(); // 0x05b47cc8
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05b47d2c
	System.Boolean IsHasValidData(); // 0x05b47df0
	System.Void RefreshSelectedPanel(); // 0x05b47e94
	System.Void PlayAnim(); // 0x05b49074
	System.Void RefreshSelectOption(System.Int32 selectIndex); // 0x05b48af4
	System.Void RefreshOptionSelectedEvent(); // 0x05b484ac
	System.Void RefreshTips(); // 0x05b48580
	System.Void RefreshListMain(); // 0x05b49514
	System.Single get_anglePerItem(); // 0x05b496a4
	System.Int32 GetSelectedIndex(); // 0x05b4871c
	System.Void GetPieItemGenerateData(System.Int32 index, System.Single& angle, System.Single& progress, UnityEngine.Vector2& iconPos); // 0x05b492f0
	UnityEngine.Vector2 CalculateCirclePoint(UnityEngine.Vector2 center, System.Single pieRadius, System.Single angleDegrees); // 0x05b49730
	System.Void RefreshBaseInfo(); // 0x05b48c50
	System.Void ShowTips(); // 0x05b494a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComPieListItemBlueprintCD : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComPie buildPanel; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.ComPieOptionItem> itemDataBlueprintDic; // 0x18
	System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.SocClient.Ui.ComPieOptionItem> selectedItemDataBlueprintDic; // 0x20
	System.Boolean get_isShowBlueprintCDState(); // 0x05b6e1dc
	System.Void SetBuildSelectedItemData(WizardGames.Soc.SocClient.Ui.ComPieOptionItem obj, WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x05b6e274
	System.Void OnFps30Update(); // 0x05b6e398
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComPieListItemDeployCraftCD : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComPie buildPanel; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.ComPieOptionItem> itemDataDeployCraftDic; // 0x18
	System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.SocClient.Ui.ComPieOptionItem> selectedItemDataBlueprintDic; // 0x20
	System.Boolean get_isShowCraftCDState(); // 0x05b6ef34
	System.Void SetBuildSelectedItemData(WizardGames.Soc.SocClient.Ui.ComPieOptionItem obj, WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x05b6f0f0
	System.Void OnFps30Update(); // 0x05b6f214
	System.Void CloseCraftCdProgress(WizardGames.Soc.SocClient.Ui.ComPieOptionItem obj); // 0x05b6f784
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EPieOptionItemState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EPieOptionItemState None = -1;
	static WizardGames.Soc.SocClient.Ui.EPieOptionItemState Normal = 0;
	static WizardGames.Soc.SocClient.Ui.EPieOptionItemState Gray = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComPieOptionItem : FairyGUI.GComponent
{
	FairyGUI.Controller ctrOptionItemStatus; // 0x288
	FairyGUI.GComponent gComPieIcon; // 0x290
	FairyGUI.GImage imgBg; // 0x298
	FairyGUI.GList listIcon; // 0x2a0
	FairyGUI.GTextField textUseNum; // 0x2a8
	FairyGUI.GTextField textCdProgress; // 0x2b0
	FairyGUI.GProgressBar progressBarCd; // 0x2b8
	FairyGUI.GTextField textTalent; // 0x2c0
	FairyGUI.GLabel trackDot; // 0x2c8
	FairyGUI.Controller controllerLockState; // 0x2d0
	FairyGUI.Controller controllerTalentState; // 0x2d8
	FairyGUI.Transition glowTransition; // 0x2e0
	WizardGames.Soc.SocClient.Ui.EPieOptionItemState <pieOptionItemState>k__BackingField; // 0x2e8
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData; // 0x2f0
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.EBuildItemIconGrayedType> grayedTypes; // 0x2f8
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.EBuildItemProgressTextType> progressTextTypes; // 0x300
	System.Boolean isSelectedOption; // 0x308
	WizardGames.Soc.SocClient.Ui.EPieOptionItemState get_pieOptionItemState(); // 0x05b6f88c
	System.Void set_pieOptionItemState(WizardGames.Soc.SocClient.Ui.EPieOptionItemState value); // 0x05b6f8f0
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05b6f968
	System.Void UpdatePieItem(System.Single progress, System.Single rotationAngle, UnityEngine.Vector2 pos); // 0x05b6fc9c
	System.Void SetData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase partViewDataBase, System.Boolean isSelectedOption); // 0x05b6fd74
	System.Void UpdateView(); // 0x05b6fe0c
	System.Void UpdateItemBg(); // 0x05b6feb0
	System.Void UpdateLockState(); // 0x05b7053c
	System.String GetLockStateForBlueprint(); // 0x05b70d0c
	System.Void UpdateTalentStatus(); // 0x05b70608
	System.String SetUnlockDescription(); // 0x05b70db4
	System.Void UpdateIcon(); // 0x05b706f4
	System.Void ConfigureIconAppearance(); // 0x05b70e80
	System.Void SetIconGrayState(); // 0x05b70fdc
	System.Void ConfigureIconForNonCore(); // 0x05b711dc
	System.Void ConfigureUpgradeAndRemouldIcon(); // 0x05b70ee4
	System.Void UpdateUsageText(); // 0x05b707d4
	System.Void CloseCraftCdProgress(); // 0x05b6f810
	System.Void CloseCdProgress(); // 0x05b715d8
	System.Void SetCdProgressText(System.String progressText, WizardGames.Soc.SocClient.Ui.EBuildItemProgressTextType textType); // 0x05b6ecfc
	System.Void SetGrayed(System.Boolean isGrayed, WizardGames.Soc.SocClient.Ui.EBuildItemIconGrayedType grayedType); // 0x05b6eb10
	System.Int32 UpdateBlueprintUsage(); // 0x05b712e4
	System.Void UpdateNodeUsage(System.Int64 templateId); // 0x05b7166c
	System.Void UpdateMissionGroupVisibility(); // 0x05b70924
	System.Void UpdatePartViewDataEnableState(); // 0x05b70c40
	System.Void SetCdProgressBarValue(System.Single value); // 0x05b6ee7c
	System.Void .ctor(); // 0x05b717d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemPieMenu : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	static System.Boolean IsShow; // 0x0
	WizardGames.Soc.SocClient.Ui.ComPie comPie; // 0x190
	FairyGUI.GGraph <DefaultSelectArea>k__BackingField; // 0x198
	WizardGames.Soc.SocClient.Ui.Construction.BuildTagData CurSelectedBuildTagData; // 0x1a0
	FairyGUI.GGraph get_DefaultSelectArea(); // 0x05b718e0
	static System.Void ClosePieMenu(); // 0x05b71944
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05b719d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBuildPanelPie : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GObject <TipsTargetPos>k__BackingField; // 0x190
	FairyGUI.GObject get_TipsTargetPos(); // 0x05b71a6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SelectedBuildData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.Int32 FirstTagId; // 0x10
	System.Int32 SecondTagId; // 0x14
	System.Int64 DataTemplateId; // 0x18
	System.Boolean IsCombo; // 0x20
	System.Int64 ChildGroupId; // 0x28
	System.Boolean NeedInitDataId; // 0x30
	System.Void SetData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData, System.Boolean selected, System.Boolean clearTag, System.Boolean needInitDataId); // 0x05b71ad0
	System.Void CopyFrom(WizardGames.Soc.SocClient.Ui.SelectedBuildData data); // 0x05b71d38
	System.Boolean DataAuthentication(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x05b71dd4
	WizardGames.Soc.SocClient.Ui.Construction.BuildTagData get_BuildTagData(); // 0x05b71f88
	System.Void Clear(System.Boolean clearTag, System.Boolean needInitDataId); // 0x05b71ca0
	System.Void OnGet(); // 0x05b7200c
	System.Void OnRelease(); // 0x05b72078
	System.Void OnDestroy(); // 0x05b720e4
	System.Void .ctor(); // 0x05b72144
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBuildModeSwitchList : System.Object
{
	System.Collections.Generic.List<System.Int32> secondModeIds; // 0x10
	System.Void .ctor(); // 0x05b721b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemAutoSnapOption : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton btnAutoSnap; // 0x190
	FairyGUI.Controller controller; // 0x198
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05b72268
	System.Void OnEnable(); // 0x05b723f4
	WizardGames.Soc.SocClient.Manager.EHotKeyLayer get_HotKeyGroup(); // 0x05b725cc
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05b72630
	System.Void OnHotKeyAction(); // 0x05b72694
	System.Void UpdateController(); // 0x05b72510
	System.Void .ctor(); // 0x05b72710
	System.Void <OnUiCreate>b__2_0(); // 0x05b72778
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnAutoConnect : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton btnAutoConnect; // 0x190
	FairyGUI.Controller controller; // 0x198
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05b7294c
	System.Void OnEnable(); // 0x05b72bb4
	System.Void OnDisable(); // 0x05b72f90
	WizardGames.Soc.SocClient.Manager.EHotKeyLayer get_HotKeyGroup(); // 0x05b7302c
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05b73090
	System.Void OnHotKeyAction(); // 0x05b730f4
	System.Void UpdateController(); // 0x05b72d80
	System.Void .ctor(); // 0x05b73170
	System.Void <OnUiCreate>b__2_0(); // 0x05b731d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnClearWire : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton btnClearWire; // 0x190
	WizardGames.Soc.SocClient.Manager.EHotKeyLayer <HotKeyGroup>k__BackingField; // 0x198
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05b734b4
	WizardGames.Soc.SocClient.Manager.EHotKeyLayer get_HotKeyGroup(); // 0x05b735ec
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05b73650
	System.Void OnHotKeyAction(); // 0x05b736b4
	System.Void OnClick(); // 0x05b73730
	System.Void .ctor(); // 0x05b739c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBuildComboBox : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	System.Int32 curTargetMode; // 0x190
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.constraction.BuildFirstMode> buildFirstModeList; // 0x198
	System.Collections.Generic.List<System.String> modeNameList; // 0x1a0
	System.Collections.Generic.List<System.String> modeIdList; // 0x1a8
	System.Collections.Generic.List<System.String> modeIconList; // 0x1b0
	System.Collections.Generic.List<System.String> modeIconListSelected; // 0x1b8
	System.Collections.Generic.List<System.String> modeTipsList; // 0x1c0
	FairyGUI.GComboBox comboBoxMode; // 0x1c8
	FairyGUI.GButton btnModeExit; // 0x1d0
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05b73a34
	System.Void OnEnable(); // 0x05b73a98
	System.Void OnDisable(); // 0x05b74ae0
	System.Void OnBuildModeChange(); // 0x05b74d74
	System.Void RefreshBuildFirstModeData(); // 0x05b73ca0
	System.Void OpenTip(WizardGames.Soc.Common.Data.EBuildFirstModeType firstModeType); // 0x05b751c8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05b755a4
	System.Void OnRemovedFromStage(); // 0x05b75b00
	System.Void OnAddedToStage(); // 0x05b75d3c
	System.Void TriggerGuide(); // 0x05b744a4
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05b75f44
	System.Void ItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05b7608c
	System.Void RefreshComboBox(); // 0x05b74dd8
	System.Void OnClickTip(FairyGUI.EventContext context, System.Int32 index); // 0x05b76388
	System.Void GradeComboOnChange(); // 0x05b76498
	System.Void OnHotKeyAction(); // 0x05b76704
	System.Void ComboBoxDisable(); // 0x05b74ce0
	System.Void .ctor(); // 0x05b768d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBuildComboBox.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudElemBuildComboBox.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__16_0; // 0x8
	static FairyGUI.EventCallback0 <>9__16_1; // 0x10
	static FairyGUI.EventCallback1 <>9__16_2; // 0x18
	static System.Void .cctor(); // 0x05b76a70
	System.Void .ctor(); // 0x05b76ad4
	System.Void <OnUiCreate>b__16_0(); // 0x05b76b3c
	System.Void <OnUiCreate>b__16_1(); // 0x05b76c6c
	System.Void <OnUiCreate>b__16_2(FairyGUI.EventContext context); // 0x05b76d9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBuildComboBox.<>c__DisplayClass21_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemBuildComboBox <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x05b76320
	System.Void <ItemRenderer>b__0(FairyGUI.EventContext context); // 0x05b76e68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBuildDelete : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.Controller buildOkController; // 0x190
	FairyGUI.GButton btn; // 0x198
	System.Int64 upgradeDoorMissionId; // 0x1a0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05b76ef0
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05b7705c
	System.Void OnHotKeyAction(); // 0x05b770c0
	System.Void SetBtnType(System.Boolean isDelete); // 0x05b7713c
	System.Void ShowAtType(System.Boolean isDelete); // 0x05b771d4
	System.Void OnClick(); // 0x05b77260
	System.Void .ctor(); // 0x05b77644
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBuildExitDeploy : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GTextField _textTitle; // 0x190
	FairyGUI.GButton mainBtn; // 0x198
	System.Int64 upgradeDoorMissionId; // 0x1a0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05b776b8
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05b77854
	System.Void OnHotKeyAction(); // 0x05b778b8
	System.Boolean TryExitModeByShortcuts(); // 0x05b77934
	System.Void OnClick(); // 0x05b77a54
	System.Void CancelSelect(); // 0x05b77bf0
	System.Void .ctor(); // 0x05b77e50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBuildListItemBlueprintCD : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemBuildPanel buildPanel; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> hasUseBlueprintDict; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.ComBuildItemIcon> itemDataBlueprintDic; // 0x20
	System.Boolean get_isShowBlueprintCDState(); // 0x05b77ec4
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiHudElemBuildPanel buildPanel); // 0x05b78010
	System.Void OnEnable(); // 0x05b78134
	System.Void OnDisable(); // 0x05b78268
	System.Void RefreshListBuildItem(); // 0x05b7839c
	System.Void SetBuildItemData(WizardGames.Soc.SocClient.Ui.ComBuildItemIcon obj, WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x05b78648
	System.Void BlueprintUseNumChange(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 id, System.Int32 oldInfo); // 0x05b788cc
	System.Void BlueprintUseNumChange(); // 0x05b78960
	System.Void OnFps30Update(System.Single dt); // 0x05b78e9c
	System.Void CloseCdProgress(WizardGames.Soc.SocClient.Ui.ComBuildItemIcon obj, System.Boolean playGlow); // 0x05b7859c
	System.Void PlayGlowAnim(WizardGames.Soc.SocClient.Ui.ComBuildItemIcon obj); // 0x05b78da0
	System.Void Reset(); // 0x05b7965c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBuildListItemDeployCraftCD : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemBuildPanel buildPanel; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.ComBuildItemIcon> itemDataDeployCraftDic; // 0x18
	System.Boolean get_isShowCraftCDState(); // 0x05b79704
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiHudElemBuildPanel buildPanel); // 0x05b79934
	System.Void RefreshListBuildItem(); // 0x05b79a0c
	System.Void SetBuildItemData(WizardGames.Soc.SocClient.Ui.ComBuildItemIcon obj, WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x05b79c68
	System.Void CloseCraftCdProgress(WizardGames.Soc.SocClient.Ui.ComBuildItemIcon obj); // 0x05b79be4
	System.Void OnFps30Update(System.Single dt); // 0x05b79eec
	System.Void Reset(); // 0x05b7a3f4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EBuildButtonMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EBuildButtonMode None = 0;
	static WizardGames.Soc.SocClient.Ui.EBuildButtonMode Build = 1;
	static WizardGames.Soc.SocClient.Ui.EBuildButtonMode Place = 2;
	static WizardGames.Soc.SocClient.Ui.EBuildButtonMode Modify = 3;
	static WizardGames.Soc.SocClient.Ui.EBuildButtonMode Repair = 4;
	static WizardGames.Soc.SocClient.Ui.EBuildButtonMode Move = 5;
	static WizardGames.Soc.SocClient.Ui.EBuildButtonMode LayoutPoints = 6;
	static WizardGames.Soc.SocClient.Ui.EBuildButtonMode LayoutLines = 7;
	static WizardGames.Soc.SocClient.Ui.EBuildButtonMode Check = 8;
	static WizardGames.Soc.SocClient.Ui.EBuildButtonMode ReplaceWire = 9;
	static WizardGames.Soc.SocClient.Ui.EBuildButtonMode UseSkin = 10;
	static WizardGames.Soc.SocClient.Ui.EBuildButtonMode Upgrade = 11;
	static WizardGames.Soc.SocClient.Ui.EBuildButtonMode Remake = 12;
	static WizardGames.Soc.SocClient.Ui.EBuildButtonMode AutoConnect = 13;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBuildOk : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	static SocLogger Logger; // 0x0
	FairyGUI.GButton btn; // 0x190
	FairyGUI.GTextField textName; // 0x198
	FairyGUI.GTextField textCd; // 0x1a0
	FairyGUI.GImage imageCd; // 0x1a8
	FairyGUI.GLoader loaderParent; // 0x1b0
	FairyGUI.GList listChild; // 0x1b8
	FairyGUI.Controller statusController; // 0x1c0
	WizardGames.Soc.SocClient.Ui.EBuildButtonMode curButtonMode; // 0x1c8
	System.Collections.Generic.List<System.String> childIconUrls; // 0x1d0
	System.Int64 endTime; // 0x1d8
	System.Int64 cdTime; // 0x1e0
	System.Action finishCallback; // 0x1e8
	System.Boolean isCdActive; // 0x1f0
	WizardGames.Soc.SocClient.Ui.BuildOkBtnState lastState; // 0x1f4
	WizardGames.Soc.SocClient.Ui.EBuildButtonMode get_CurButtonMode(); // 0x05b7a478
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05b7a4dc
	WizardGames.Soc.SocClient.Manager.EHotKeyLayer get_HotKeyGroup(); // 0x05b7a8dc
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05b7a940
	System.Void OnHotKeyAction(); // 0x05b7a9a4
	System.Void OnDisable(); // 0x05b7aa20
	System.Void SetModifyUiState(System.Boolean isShow); // 0x05b7a840
	System.Void OnClick(); // 0x05b7acf4
	System.Void OnRenderBuildItem(System.Int32 index, FairyGUI.GObject obj); // 0x05b7af8c
	System.Void ShowSubIcon(System.Boolean isSubIcon); // 0x05b7b090
	System.Void Show(WizardGames.Soc.SocClient.Ui.EBuildButtonMode buttonMode, System.Boolean enable, System.Boolean gray, System.Boolean showModifyIcon); // 0x05b7b228
	WizardGames.Soc.SocClient.Manager.HotKeyCenterGuideData GetHotKeyCenterGuideData(); // 0x05b7ba00
	System.Void SetCdTimeStampSec(System.Int64 endTimeStampSec, System.Int32 cdTimeSec, System.Action callback); // 0x05b7ac14
	System.Void OnFps30Update(System.Single dt); // 0x05b7baa0
	System.Void UpdateUI(System.Single progress, System.String time); // 0x05b7bc7c
	System.Void SetCdInfo(System.Boolean isShow); // 0x05b7aac4
	System.Void .ctor(); // 0x05b7bde4
	static System.Void .cctor(); // 0x05b7be98
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.BuildOkBtnState : System.ValueType
{
	WizardGames.Soc.SocClient.Ui.EBuildButtonMode ButtonMode; // 0x10
	System.Boolean IsEnabled; // 0x14
	System.Boolean IsGrayed; // 0x15
	System.Boolean Equals(WizardGames.Soc.SocClient.Ui.BuildOkBtnState other); // 0x05b7bf6c
	System.Boolean CanReplace(WizardGames.Soc.SocClient.Ui.BuildOkBtnState other); // 0x05b7b920
	System.Void Clear(); // 0x05b7abac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBuildPanel : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	static SocLogger Logger; // 0x0
	FairyGUI.GComponent root; // 0x190
	FairyGUI.GList listBuildFirstTag; // 0x198
	FairyGUI.GList listBuildSecondTag; // 0x1a0
	FairyGUI.GList listBuildItem; // 0x1a8
	FairyGUI.Controller stateController; // 0x1b0
	FairyGUI.GTextField textTip; // 0x1b8
	WizardGames.Soc.SocClient.Ui.UiHudElemBuildListItemDeployCraftCD listItemDeployCraftCd; // 0x1c0
	WizardGames.Soc.SocClient.Ui.UiHudElemBuildListItemBlueprintCD listItemBlueprintCd; // 0x1c8
	WizardGames.Soc.SocClient.Ui.UiHudElemBuildPanelEffect buildPanelEffect; // 0x1d0
	System.Collections.Generic.List<System.Int32> secondTagList; // 0x1d8
	WizardGames.Soc.SocClient.Ui.SelectedBuildData selectedBuildData; // 0x1e0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase> buildItemDataList; // 0x1e8
	System.Int32 curDataIndex; // 0x1f0
	FairyGUI.GObject tipsTargetPos; // 0x1f8
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> itemGoDic; // 0x200
	WizardGames.Soc.SocClient.Ui.UiBuildModeSwitchList uiModeSwitchList; // 0x208
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelLeftAction; // 0x210
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelRightAction; // 0x218
	FairyGUI.GComponent get_Root(); // 0x05b7c014
	FairyGUI.GList get_ListBuildFirstTag(); // 0x05b7c078
	FairyGUI.GList get_ListBuildItem(); // 0x05b7c0dc
	WizardGames.Soc.SocClient.Manager.BuildListOperation get_buildListOperation(); // 0x05b7c140
	System.Collections.Generic.List<System.Int32> get_FirstTagList(); // 0x05b7c1d8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.BuildTagData> get_buildTagDataList(); // 0x05b7c24c
	WizardGames.Soc.SocClient.Ui.SelectedBuildData get_SelectedBuildData(); // 0x05b7c2c0
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase get_CurBuildItemData(); // 0x05b795f4
	System.Int32 get_CurDataIndex(); // 0x05b7c3f4
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> get_firstTagToSecondTagDict(); // 0x05b7c458
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.Construction.BuildTagData,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase>> get_secondTagToBuildItemDataDict(); // 0x05b7c4cc
	FairyGUI.GObject get_TipsTargetPos(); // 0x05b7c540
	System.Boolean get_isEmptyState(); // 0x05b7c5a4
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05b7c660
	System.Void OnUiDestroy(); // 0x05b7d51c
	UnityEngine.Vector2 GetHudElemSize(); // 0x05b7d63c
	System.Void OnEnable(); // 0x05b7d6b4
	System.Void OnDisable(); // 0x05b7df30
	UnityEngine.Rect GetNodeBlockArea(); // 0x05b7e3bc
	System.Void RefreshBuildPanel(); // 0x05b7dce8
	System.Void RefreshListFirstTag(); // 0x05b7e7b4
	System.Boolean RefreshHasDeployItemDataList(System.Int32 firstTagId); // 0x05b7f438
	System.Void SetFirstTag(System.Int32 firstTagId); // 0x05b7f360
	System.Void SetSecondTag(System.Int32 secondTagId); // 0x05b7fc68
	System.Void RefreshListSecondTag(); // 0x05b7f654
	System.Void CancelSelectBuildItem(); // 0x05b80400
	System.Void OnBlueprintCreatComplete(); // 0x05b8050c
	System.Void RefreshListBuildItem(System.Boolean isInventoryItemChange); // 0x05b7ffbc
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase GetRecommendedBuildItemData(WizardGames.Soc.SocClient.Ui.SelectedBuildData selectedBuildData, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase> buildItemDataList); // 0x05b806a4
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase GetLastSelectedBuildItemData(WizardGames.Soc.SocClient.Ui.SelectedBuildData selectedBuildData, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase> buildItemDataList); // 0x05b805ac
	System.Void SetSelectedData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData, System.Boolean needInitDataId); // 0x05b8090c
	System.Int32 GetSelectedBuildItemDataIndex(); // 0x05b80db8
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase GetBuildItemDataByIndex(System.Int32 index); // 0x05b7c324
	System.Void RefreshListMain(); // 0x05b78e24
	System.Void BuildItemDataChange(); // 0x05b80490
	System.Void OnClickFirstTagItem(FairyGUI.EventContext context); // 0x05b80e98
	System.Void OnClickSecondTagItem(FairyGUI.EventContext context); // 0x05b81170
	System.Void OnClickBuildItem(FairyGUI.EventContext context); // 0x05b814ac
	System.Void RefreshBuildItemListState(System.Int32 dataIndex); // 0x05b815f0
	System.Void OnInventoryItemChange(); // 0x05b82308
	System.Void ShowItemTips(); // 0x05b81928
	System.Void OnFps30Update(System.Single dt); // 0x05b82444
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05b824e4
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05b8293c
	FairyGUI.GObject GetBuildItemObjByTemplateId(System.Int64 id); // 0x05b82ee8
	FairyGUI.GObject GetBuildItemObjByTemplateId(WizardGames.Soc.SocClient.Manager.BuildGuideItemData targetData); // 0x05b82d90
	FairyGUI.GObject GetFirstTagObjByTemplateId(System.Int64 id); // 0x05b82b04
	FairyGUI.GObject GetSecondTagObjByTemplateId(System.Int64 id); // 0x05b82c54
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase> get_buildItemMarkerDataLst(); // 0x05b8308c
	System.Void OnRenderFirstTagItem(System.Int32 index, FairyGUI.GObject obj); // 0x05b83100
	System.Void OnRenderSecondTagItem(System.Int32 index, FairyGUI.GObject obj); // 0x05b83628
	System.Void OnRenderBuildItem(System.Int32 index, FairyGUI.GObject obj); // 0x05b83d8c
	System.Void SetBuildItemData(FairyGUI.GObject obj, WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x05b83e68
	System.Boolean MarkFirstTagByMission(System.Int32 firstTagId); // 0x05b83494
	System.Boolean MarkSecondTagByMission(System.Int32 secondTagId); // 0x05b83bf4
	System.Void OnUiCreatePC(); // 0x05b7d364
	System.Void OnEnablePC(); // 0x05b7ded0
	System.Void OnDisablePC(); // 0x05b7e35c
	System.Void InitHotKey(); // 0x05b7d3c4
	System.Void EnableHotKey(); // 0x05b7d97c
	System.Void DisableHotKey(); // 0x05b7e1f8
	System.Void BuildFirstTagUp(); // 0x05b83ff0
	System.Void BuildFirstTagDown(); // 0x05b841b0
	System.Void BuildSecondTagLeft(); // 0x05b8438c
	System.Void BuildSecondTagRight(); // 0x05b8453c
	System.Void OnWheelLeft(); // 0x05b84718
	System.Void OnWheelRight(); // 0x05b848e0
	System.Void .ctor(); // 0x05b84abc
	static System.Void .cctor(); // 0x05b84c04
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBuildPanelEffect : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemBuildPanel buildPanel; // 0x10
	FairyGUI.GButton btnExpand; // 0x18
	FairyGUI.GButton btnSearch; // 0x20
	FairyGUI.Controller btnExpandStateController; // 0x28
	FairyGUI.GImage ImgLeftOverlay; // 0x30
	FairyGUI.GImage ImgRightOverlay; // 0x38
	FairyGUI.GImage ImgDownOverlay; // 0x40
	FairyGUI.Transition appearTransition; // 0x48
	System.Boolean isExpand; // 0x50
	System.Single rootWidth; // 0x54
	System.Single shinkHeight; // 0x58
	System.Single heightOffset; // 0x5c
	FairyGUI.GComponent get_Root(); // 0x05b84cd8
	System.Int32 get_firstTagColumnCountThreshold(); // 0x05b84d7c
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiHudElemBuildPanel buildPanel); // 0x05b7cbe8
	System.Void Init(); // 0x05b7cd04
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05b82574
	System.Void Reset(); // 0x05b7d5dc
	System.Void ScrollToFirstSibling(System.Int32 index, System.Boolean ani); // 0x05b809e8
	System.Void UpdateFirstTagListColumnCount(); // 0x05b7efc8
	System.Void UpdateItemStatusConstroller(FairyGUI.GButton item); // 0x05b8339c
	System.Void OnClickSearch(); // 0x05b84e64
	System.Void OnClickExpand(); // 0x05b84f74
	System.Void OnUpdateExpandState(); // 0x05b85020
	System.Void UpdateExpandBtnState(); // 0x05b7e938
	System.Void UpdateBuildPanelSize(); // 0x05b7d108
	System.Void UpdateConstructionInfoTipPos(); // 0x05b85114
	System.Void <UpdateExpandBtnState>b__30_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05b8525c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBuildTurnRight : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	UnityEngine.Vector2 initPos; // 0x190
	System.Boolean isRecordPos; // 0x198
	FairyGUI.GButton mainBtn; // 0x1a0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05b853f4
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05b85748
	System.Void OnHotKeyAction(); // 0x05b857ac
	System.Void OnDisable(); // 0x05b85828
	System.Void OnClick(); // 0x05b85be0
	System.Void FollowNodePosition(FairyGUI.GObject targetNode); // 0x05b8589c
	System.Void .ctor(); // 0x05b85d30
	System.Void <OnUiCreate>b__3_0(FairyGUI.EventContext ctx); // 0x05b85d98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemSecondModeSwitch : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	static SocLogger Logger; // 0x0
	FairyGUI.GButton mainBtn; // 0x190
	FairyGUI.GTextField labelInfo; // 0x198
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05b85e10
	System.Void OnHotKeyAction(); // 0x05b85f88
	System.Boolean OnShowCheck(); // 0x05b85fe8
	System.Void OnShow(); // 0x05b8630c
	System.Void OnClick(); // 0x05b8673c
	System.Void .ctor(); // 0x05b868b4
	static System.Void .cctor(); // 0x05b8691c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemSkinPanel : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	static SocLogger Logger; // 0x0
	FairyGUI.GList listSkinList; // 0x190
	FairyGUI.Controller ctrMode; // 0x198
	WizardGames.Soc.SocClient.Ui.ComInfoButton btnTip; // 0x1a0
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> skinObjDic; // 0x1a8
	FairyGUI.GComponent root; // 0x1b0
	FairyGUI.GComponent leftKey; // 0x1b8
	FairyGUI.GComponent rightKey; // 0x1c0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SkinData> skinDataList; // 0x1c8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05b869f0
	System.Void OnEnable(); // 0x05b86ddc
	System.Void OnSkinLeft(); // 0x05b8712c
	System.Void OnSkinRight(); // 0x05b872e0
	System.Void OnDisable(); // 0x05b874b0
	System.Void OnConstructionSkinChanged(System.Int64 entityId); // 0x05b8761c
	System.Void RefreshView(); // 0x05b86fe4
	System.Int32 GetSelectedBuildItemDataIndex(); // 0x05b883a8
	System.Void RefreshSkinDataList(); // 0x05b87848
	System.Void OnRenderSkinItem(System.Int32 index, FairyGUI.GObject obj); // 0x05b885d0
	System.Void LoadCache(FairyGUI.GObject obj); // 0x05b88a20
	System.Void OnClickSkinItem(FairyGUI.EventContext context); // 0x05b88c34
	System.Void .ctor(); // 0x05b88e10
	static System.Void .cctor(); // 0x05b88f1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemSkinPanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudElemSkinPanel.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.SkinData> <>9__19_0; // 0x8
	static System.Void .cctor(); // 0x05b88ff0
	System.Void .ctor(); // 0x05b89054
	System.Int32 <RefreshSkinDataList>b__19_0(WizardGames.Soc.SocClient.Ui.SkinData skinData1, WizardGames.Soc.SocClient.Ui.SkinData skinData2); // 0x05b890bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.CableItemInfo : System.Object
{
	WizardGames.Soc.Common.Unity.Electric.WireColour colorType; // 0x10
	System.String name; // 0x18
	System.String imgUrl; // 0x20
	System.Void .ctor(); // 0x05b891ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemWireColorBasePanel : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GList cableLst; // 0x190
	FairyGUI.Transition transitionShow; // 0x198
	FairyGUI.Transition transitionHide; // 0x1a0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.CableItemInfo> cableInfoLst; // 0x1a8
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Electric.WireColour,System.Int32> color2IdxDic; // 0x1b0
	WizardGames.Soc.Common.Unity.Electric.WireColour curSelectColor; // 0x1b8
	WizardGames.Soc.Common.Unity.Electric.WireColour curUseColor; // 0x1bc
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05b89298
	System.Void OnEnable(); // 0x05b899dc
	System.Void OnDisable(); // 0x05b89b30
	System.Void OnClickOutsideWindow(); // 0x05b89bb8
	System.Void UpdateCableData(); // 0x05b89ab0
	System.Void InitCableData(); // 0x05b894d4
	System.Void OnRenderCableItem(System.Int32 index, FairyGUI.GObject obj); // 0x05b89c1c
	System.Void OnClickCable(FairyGUI.EventContext context); // 0x05b89d60
	System.Void OnFirstShowCable(WizardGames.Soc.Common.Unity.Electric.WireColour color); // 0x05b89fb0
	System.Void OnSelectedColor(WizardGames.Soc.Common.Unity.Electric.WireColour color); // 0x05b8a114
	System.Void .ctor(); // 0x05b8a188
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemWireColorPanel : WizardGames.Soc.SocClient.Ui.UiHudElemWireColorBasePanel
{
	
	System.Void OnSelectedColor(WizardGames.Soc.Common.Unity.Electric.WireColour color); // 0x05b8a29c
	System.Void .ctor(); // 0x05b8a37c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EWireInterfaceMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EWireInterfaceMode Empty = 0;
	static WizardGames.Soc.SocClient.Ui.EWireInterfaceMode Select = 1;
	static WizardGames.Soc.SocClient.Ui.EWireInterfaceMode Wiring = 2;
	static WizardGames.Soc.SocClient.Ui.EWireInterfaceMode AutoConnection = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EIoSlotType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EIoSlotType Input = 0;
	static WizardGames.Soc.SocClient.Ui.EIoSlotType Output = 1;
	static WizardGames.Soc.SocClient.Ui.EIoSlotType SignalInput = 2;
	static WizardGames.Soc.SocClient.Ui.EIoSlotType SignalOutput = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EIoSlotIconType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EIoSlotIconType Signal = 0;
	static WizardGames.Soc.SocClient.Ui.EIoSlotIconType Electric = 1;
	static WizardGames.Soc.SocClient.Ui.EIoSlotIconType Fluidic = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemWireInterfaceBeta2 : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	static SocLogger Logger; // 0x0
	FairyGUI.GComponent root; // 0x190
	FairyGUI.GObject tipsTargetPos; // 0x198
	FairyGUI.Controller ctrMode; // 0x1a0
	WizardGames.Soc.SocClient.Ui.EWireInterfaceMode curMode; // 0x1a8
	WizardGames.Soc.SocClient.Ui.WireInterfaceComGroupBase curComGroup; // 0x1b0
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EWireInterfaceMode,WizardGames.Soc.SocClient.Ui.WireInterfaceComGroupBase> comGroupDic; // 0x1b8
	System.Collections.Generic.List<WizardGames.Soc.Common.Electric.IOSlotBase> wireSlotLst; // 0x1c0
	System.Single rootWidth; // 0x1c8
	FairyGUI.GObject get_TipsTargetPos(); // 0x05b8a3e0
	WizardGames.Soc.SocClient.Construction.BuildMode.WireTool get_wireTool(); // 0x05b8a444
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05b8a540
	System.Void OnEnable(); // 0x05b8a704
	System.Void OnDisable(); // 0x05b8ac5c
	System.Void OnWireToolBuildModeSlotPowerChange(WizardGames.Soc.Common.Component.ElectricBaseComponent electricBaseComponent); // 0x05b8b044
	System.Void RefreshView(); // 0x05b8aae0
	WizardGames.Soc.SocClient.Ui.EWireInterfaceMode GetWireInterfaceMode(); // 0x05b8b0bc
	System.Void SetViewMode(WizardGames.Soc.SocClient.Ui.EWireInterfaceMode mode); // 0x05b8a9cc
	System.Void RefreshGroup(WizardGames.Soc.SocClient.Ui.EWireInterfaceMode mode); // 0x05b8b428
	System.Void DisposeGroup(); // 0x05b8adec
	WizardGames.Soc.SocClient.Ui.ESlotType GetSlotType(WizardGames.Soc.Common.Electric.IOSlotBase slot); // 0x05b8baf0
	System.ValueTuple<WizardGames.Soc.SocClient.Ui.EIoSlotType,WizardGames.Soc.SocClient.Ui.EIoSlotIconType> GetIoSlotType(WizardGames.Soc.Common.Electric.IOSlotBase slot); // 0x05b8bbd4
	System.Single get_aspectRatio(); // 0x05b8bdc4
	System.Void OnUiCreatePlatform(); // 0x05b8a648
	System.Void OnEnablePlatform(); // 0x05b8abfc
	System.Void OnDisablePlatform(); // 0x05b8afe4
	System.Void CreateGroup(WizardGames.Soc.SocClient.Ui.EWireInterfaceMode mode); // 0x05b8b6ec
	System.Void UpdateBuildPanelSize(); // 0x05b8beac
	System.Void .ctor(); // 0x05b8c03c
	static System.Void .cctor(); // 0x05b8c18c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemWireInterfaceComConnectInfo : System.Object
{
	FairyGUI.GTextField txtTitle; // 0x10
	WizardGames.Soc.SocClient.Ui.ComInfoButton btnTips; // 0x18
	FairyGUI.GLoader loaderIcon; // 0x20
	FairyGUI.GTextField txtName; // 0x28
	FairyGUI.GTextField txtConsumeDesc; // 0x30
	FairyGUI.GComponent comFlowNormal; // 0x38
	FairyGUI.GComponent comFlowLack; // 0x40
	FairyGUI.Controller controllerSlotTypeIcon; // 0x48
	FairyGUI.Controller controllerSlotConnectState; // 0x50
	FairyGUI.Controller controllerState; // 0x58
	WizardGames.Soc.Common.Electric.IOSlotBase slotBase; // 0x60
	System.Void .ctor(FairyGUI.GComponent root); // 0x05b8c260
	System.String GetBtnTips(); // 0x05b8c618
	System.Void Init(WizardGames.Soc.SocClient.Ui.ESlotType slotType, WizardGames.Soc.Common.Electric.IOSlotBase slotBase, System.Int32 index); // 0x05b8c7a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemWireModifyColorPanel : WizardGames.Soc.SocClient.Ui.UiHudElemWireColorBasePanel
{
	
	System.Void OnSelectedColor(WizardGames.Soc.Common.Unity.Electric.WireColour color); // 0x05b8d2d4
	System.Void .ctor(); // 0x05b8d8f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemWireModifyColorPanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudElemWireModifyColorPanel.<>c <>9; // 0x0
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__0_0; // 0x8
	static System.Void .cctor(); // 0x05b8d95c
	System.Void .ctor(); // 0x05b8d9c0
	System.Void <OnSelectedColor>b__0_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05b8da28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemWithToolCupboard : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton btn; // 0x190
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05b8db48
	System.Void OnEnable(); // 0x05b8dca0
	System.Void UpdateElemPos(); // 0x05b8de4c
	System.Void .ctor(); // 0x05b8e1cc
	System.Void <OnUiCreate>b__1_0(); // 0x05b8e234
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemICSlot : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemMission : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	static SocLogger logger; // 0x0
	System.Boolean editMode; // 0x190
	WizardGames.Soc.SocClient.Ui.Binder.GameHudElemLeftTab.ElemMissionTabNewBinder binder; // 0x198
	FairyGUI.GComponent normalMissionCom; // 0x1a0
	FairyGUI.GList normalMissionList; // 0x1a8
	FairyGUI.Controller normalMissionStateCtrl; // 0x1b0
	FairyGUI.GTextField normalMissionTitleTxt; // 0x1b8
	FairyGUI.GLoader normalMissionMarkerLoader; // 0x1c0
	System.Int32 curNormalMissionType; // 0x1c8
	FairyGUI.Transition normalCompleteTransition; // 0x1d0
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,System.Object>> normalMissionItemDic; // 0x1d8
	System.Boolean needUpdate; // 0x1e0
	System.Boolean initPreTrackId; // 0x1e1
	System.Int64 preTrackId; // 0x1e8
	FairyGUI.GComponent specialMissionCom; // 0x1f0
	FairyGUI.GList specialMissionList; // 0x1f8
	FairyGUI.Controller specialMissionStateCtrl; // 0x200
	FairyGUI.GTextField specialMissionTitleTxt; // 0x208
	FairyGUI.GLoader specialMissionMarkerLoader; // 0x210
	System.Int32 curSpecialMissionType; // 0x218
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,System.Object>> specialMissionItemDic; // 0x220
	System.Boolean canShowMonumentTips; // 0x228
	System.Boolean canShowDeadSheepTips; // 0x229
	System.Collections.Generic.List<System.Int64> dailyDataLst; // 0x230
	System.Collections.Generic.List<System.Int64> exploreDataLst; // 0x238
	System.Collections.Generic.List<WizardGames.Soc.SocClient.MainQuestData> mainQuestDataLst; // 0x240
	System.Collections.Generic.List<WizardGames.Soc.SocClient.MonumentMissionRemoteData> monumentDataLst; // 0x248
	System.Collections.Generic.List<System.Int64> newbieDataBackupLst; // 0x250
	System.Collections.Generic.List<System.Int64> curNewbieDataLst; // 0x258
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> lastNumDic; // 0x260
	FairyGUI.GTextField souDJOverallRanking; // 0x268
	FairyGUI.GTextField souDJDailyChart; // 0x270
	FairyGUI.GTextField souDJTimeText; // 0x278
	FairyGUI.Controller souDJStatus; // 0x280
	FairyGUI.Transition souDJShowTransition; // 0x288
	MgrSouDJ.ESouDJStageName currentSouDJStage; // 0x290
	System.Collections.Generic.IReadOnlyList<WizardGames.Soc.Common.Data.Play.SouDJStageCfg> curSouDjCfgList; // 0x298
	System.Int64 treasureHuntMissionId; // 0x2a0
	System.Void OnUiCreate(FairyGUI.GComponent root); // 0x05b8e4a4
	System.Void BindSpecialMission(); // 0x05b8f034
	System.Void OnEnable(); // 0x05b8f3b8
	System.Void OnDisable(); // 0x05b91cd4
	System.Void OnStageChange(); // 0x05b92374
	System.Void StartEdit(); // 0x05b92474
	System.Void OnFps1Update(System.Single dt); // 0x05b926b0
	System.Void OnRenderNormalMissionItem(System.Int32 index, FairyGUI.GObject obj); // 0x05b927d8
	System.Void OnRenderEmptyItem(System.Int32 index, FairyGUI.GObject obj); // 0x05b95bb0
	System.Void OnRenderSpecialMissionItem(System.Int32 index, FairyGUI.GObject obj); // 0x05b95d38
	System.Void RefreshNormalMission(); // 0x05b908a8
	System.Void RefreshSpecialMission(); // 0x05b90e94
	System.Void OnTrackIdChanged(); // 0x05b98424
	System.Void OnNextViewGuide(System.Int32 guideId, System.Int32 stepId); // 0x05b984c4
	System.Void OnEditModeChanged(System.Boolean isEdit); // 0x05b98944
	System.Void RefreshMainQuestTraining(); // 0x05b914d4
	System.Void TryPlayTeamGuide(); // 0x05b98788
	System.Boolean IsValidGuide(); // 0x05b98a28
	System.Void OnClickExpand(); // 0x05b98b5c
	System.Void OnClickNormalMission(); // 0x05b98cd8
	System.Void OnClickSpeciaMission(); // 0x05b98f24
	System.Void OnClickTraining(); // 0x05b99264
	System.Void RefreshDailyMission(); // 0x05b97524
	System.Void OnRenderDailyItem(System.Int32 index, FairyGUI.GObject obj); // 0x05b94138
	System.Void RefreshDeadSheepMission(); // 0x05b97d7c
	System.Void OnRenderDeadSheepMission(System.Int32 index, FairyGUI.GObject obj); // 0x05b96470
	System.Void RefreshExploreMission(); // 0x05b97840
	System.Void OnRenderExploreItem(System.Int32 index, FairyGUI.GObject obj); // 0x05b94910
	System.Void RefreshMainQuestMission(); // 0x05b97084
	System.Void OnRenderMainQuestItem(System.Int32 index, FairyGUI.GObject obj); // 0x05b93748
	System.Void RefreshMonumentMission(); // 0x05b98144
	System.Void OnRenderMonumentItem(System.Int32 index, FairyGUI.GObject obj); // 0x05b95dfc
	System.Void RefreshNewbieMission(); // 0x05b96aac
	System.Void OnRenderNewbieItem(System.Int32 index, FairyGUI.GObject obj); // 0x05b92920
	System.Void PlayNewbieAnim(); // 0x05b999b8
	System.Void InitSouDJCom(); // 0x05b8e88c
	System.Void OnClickSouDJRoot(FairyGUI.EventContext context); // 0x05b99ca0
	System.Void RefreshSouDJCom(); // 0x05b8fd8c
	System.String GetSouDJStageEndTime(); // 0x05b9a010
	System.String ConvertCountDown(System.Int32 countDown); // 0x05b9a0b8
	System.Void RefreshSouDJRanking(); // 0x05b99da8
	System.Void RefreshTreasureHuntMission(); // 0x05b97b10
	System.Void OnRenderTreasureHuntItem(System.Int32 index, FairyGUI.GObject obj); // 0x05b94ef0
	System.Void .ctor(); // 0x05b9a1f0
	static System.Void .cctor(); // 0x05b9a404
	System.Void <OnEnable>b__26_0(); // 0x05b9a4d8
	System.Void <RefreshNormalMission>b__34_0(System.Object param); // 0x05b9a63c
	System.Void <RefreshSpecialMission>b__35_0(System.Object param); // 0x05b9a77c
	System.Void <PlayNewbieAnim>b__65_0(System.Object param); // 0x05b9a8bc
	System.Void <PlayNewbieAnim>b__65_1(); // 0x05b9a9fc
	System.Void <PlayNewbieAnim>b__65_2(System.Object param); // 0x05b9ac7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemMission.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudElemMission.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestTraining> <>9__45_1; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestTraining> <>9__45_0; // 0x10
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestTraining> <>9__45_3; // 0x18
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMissionBook> <>9__45_4; // 0x20
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestTraining> <>9__45_5; // 0x28
	static System.Void .cctor(); // 0x05b9adbc
	System.Void .ctor(); // 0x05b9ae20
	System.Void <OnClickTraining>b__45_1(WizardGames.Soc.SocClient.Ui.UiMainQuestTraining win); // 0x05b9ae88
	System.Void <OnClickTraining>b__45_0(WizardGames.Soc.SocClient.Ui.UiMainQuestTraining win); // 0x05b9af18
	System.Void <OnClickTraining>b__45_3(WizardGames.Soc.SocClient.Ui.UiMainQuestTraining win); // 0x05b9afa8
	System.Void <OnClickTraining>b__45_4(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x05b9b038
	System.Void <OnClickTraining>b__45_5(WizardGames.Soc.SocClient.Ui.UiMainQuestTraining win); // 0x05b9b0c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemMission.<>c__DisplayClass39_0 : System.Object
{
	FairyGUI.GLoader trainingCom; // 0x10
	System.Void .ctor(); // 0x05b989c0
	System.Void <RefreshMainQuestTraining>b__0(); // 0x05b9b154
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemMission.<>c__DisplayClass45_0 : System.Object
{
	System.Int32 factionId; // 0x10
	System.Void .ctor(); // 0x05b998e8
	System.Void <OnClickTraining>b__2(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x05b9b288
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemMission.<>c__DisplayClass53_0 : System.Object
{
	System.Int32 taskId; // 0x10
	System.Void .ctor(); // 0x05b99950
	System.Boolean <OnRenderExploreItem>b__0(WizardGames.Soc.Common.Data.Play.QuestPhase taskData); // 0x05b9b314
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MSDKWebViewHandle : System.Object
{
	static SocLogger <Logger>k__BackingField; // 0x0
	static System.String path; // 0x8
	static System.String pathTest; // 0x10
	static System.String sigkey; // 0x18
	static System.String zhijiPath; // 0x20
	static System.String token; // 0x28
	static System.String openId; // 0x30
	static System.Int32 channelId; // 0x38
	static System.Int32 os; // 0x3c
	static System.Int32 zhiji_os; // 0x40
	static System.Void ParseResultJson(System.String resultJsonStr); // 0x05b9b3a0
	static System.Void .cctor(); // 0x05b9b554
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MSDKWebViewHandle.GCloudMSDKRes : System.Object
{
	System.String OpenId; // 0x10
	System.String Token; // 0x18
	System.Int32 ChannelId; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AutoPriorityPickChecker : System.Object
{
	System.Boolean <IgnoreBlackList>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.CheckWeaponCondition checkWeaponCondition; // 0x18
	WizardGames.Soc.SocClient.Ui.CheckWeaponAccessoryCondition checkFirstWeaponAccessoryCondition; // 0x20
	WizardGames.Soc.SocClient.Ui.CheckWeaponAccessoryCondition checkSecondWeaponAccessoryCondition; // 0x28
	WizardGames.Soc.SocClient.Ui.CheckBulletCondition checkFirstBulletCondition; // 0x30
	WizardGames.Soc.SocClient.Ui.CheckBulletCondition checkSecondBulletCondition; // 0x38
	WizardGames.Soc.SocClient.Ui.CheckWearCondition checkWearCondition; // 0x40
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ECheckConditionType,WizardGames.Soc.SocClient.Ui.ICheckItemCondition> checkItemConditionDic; // 0x48
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ECheckConditionType,WizardGames.Soc.SocClient.Ui.ItemNodeInfo> itemNodeInfoDic; // 0x50
	System.Int32 resultIndex; // 0x58
	WizardGames.Soc.SocClient.Ui.ECheckConditionType[] sortCheckConditionTypeArray; // 0x60
	System.Int32[] equipPosArray; // 0x68
	WizardGames.Soc.SocClient.Ui.ItemNodeInfo get_CheckResultItemNodeInfo(); // 0x05b9b740
	WizardGames.Soc.SocClient.Ui.ItemNodeInfo get_HighestItemNodeInfo(); // 0x05b9b814
	System.Boolean get_IgnoreBlackList(); // 0x05b9b9bc
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.PageType pageType); // 0x05b9ba20
	System.Void CheckAutoPickItems(System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> autoItemList, System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> nonAutoItemList, System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> autoPickExtendBagItemListDic, System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> nonAutoPickExtendBagItemListDic); // 0x05b9c3d8
	System.Void CheckItems(System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> itemList, System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> autoPickExtendBagItemListDic, System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> nonAutoPickExtendBagItemListDic); // 0x05b9c914
	System.Void CheckExpansionBackpacks(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> autoPickExtendBagItemListDic, System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> nonAutoPickExtendBagItemListDic); // 0x05b9ccc0
	System.Int32 GetItemCount(System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> itemListDic, System.Int64 nodeId); // 0x05b9d1e0
	System.Void CheckExtendBagItems(System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> itemList); // 0x05b9d2c0
	System.Void CheckAutoPickItems(System.Collections.Generic.List<System.Int64> deadPlayerOrderList, System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> autoItemListDic, System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> autoPickDeadPlayerItemListDic, System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> nonAutoPickDeadPlayerItemListDic); // 0x05b9d460
	System.Boolean CheckItemList(System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> itemList, System.Int64 collectionId, System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> autoPickDeadPlayerItemListDic, System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> nonAutoPickDeadPlayerItemListDic); // 0x05b9d6d0
	System.Void Reset(); // 0x05b9c4bc
	System.Void CheckItem(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Int64 collectionId); // 0x05b9ce48
	System.Void CheckResultIndex(); // 0x05b9cbd4
	System.Void CheckWeaponUnsetPart(WizardGames.Soc.Common.CustomType.BaseItemNode weaponItemNode, System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.ItemSlot> availableParts); // 0x05b9dd38
	System.Int32[] GetWeaponAvailableBullet(WizardGames.Soc.Common.CustomType.BaseItemNode weaponItemNode); // 0x05b9db78
	System.Void CheckWearUndressed(System.Collections.Generic.List<System.Int32> undressedPosList); // 0x05b9e2b0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ECheckConditionType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ECheckConditionType Weapon = 0;
	static WizardGames.Soc.SocClient.Ui.ECheckConditionType FirstWeaponAccessory = 1;
	static WizardGames.Soc.SocClient.Ui.ECheckConditionType SecondWeaponAccessory = 2;
	static WizardGames.Soc.SocClient.Ui.ECheckConditionType FirstBullet = 3;
	static WizardGames.Soc.SocClient.Ui.ECheckConditionType SecondBullet = 4;
	static WizardGames.Soc.SocClient.Ui.ECheckConditionType Wear = 5;
	
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.ICheckItemCondition : 
{
	
	System.Void CheckItem(WizardGames.Soc.SocClient.Ui.ItemNodeInfo itemNodeInfo, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Int64 collectionId); // 0x0552c3bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.CheckWeaponCondition : System.Object, WizardGames.Soc.SocClient.Ui.ICheckItemCondition
{
	System.Boolean isFirstWeapon; // 0x10
	System.Boolean isSecondWeapon; // 0x11
	System.Void Refresh(System.Boolean isFirstWeapon, System.Boolean isSecondWeapon); // 0x05b9da4c
	System.Void CheckItem(WizardGames.Soc.SocClient.Ui.ItemNodeInfo itemNodeInfo, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Int64 collectionId); // 0x05b9e760
	System.Void .ctor(); // 0x05b9c1a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.CheckWeaponAccessoryCondition : System.Object, WizardGames.Soc.SocClient.Ui.ICheckItemCondition
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.ItemSlot> itemShotList; // 0x10
	System.Action<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.ItemSlot>> RefreshAction; // 0x18
	System.Void Refresh(WizardGames.Soc.Common.CustomType.BaseItemNode weaponItemNode); // 0x05b9dad8
	System.Void CheckItem(WizardGames.Soc.SocClient.Ui.ItemNodeInfo itemNodeInfo, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Int64 collectionId); // 0x05b9e8cc
	System.Void .ctor(); // 0x05b9c208
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.CheckBulletCondition : System.Object, WizardGames.Soc.SocClient.Ui.ICheckItemCondition
{
	System.Int32[] availableBulletArray; // 0x10
	System.Void Refresh(System.Int32[] availableBulletArray); // 0x05b9ea70
	System.Void CheckItem(WizardGames.Soc.SocClient.Ui.ItemNodeInfo itemNodeInfo, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Int64 collectionId); // 0x05b9eaf0
	System.Void .ctor(); // 0x05b9c2bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.CheckWearCondition : System.Object, WizardGames.Soc.SocClient.Ui.ICheckItemCondition
{
	System.Collections.Generic.List<System.Int32> wearUndressedPosList; // 0x10
	System.Action<System.Collections.Generic.List<System.Int32>> RefreshAction; // 0x18
	System.Void Refresh(); // 0x05b9dcb4
	System.Void CheckItem(WizardGames.Soc.SocClient.Ui.ItemNodeInfo itemNodeInfo, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Int64 collectionId); // 0x05b9ec18
	System.Void .ctor(); // 0x05b9c324
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ItemNodeInfo : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode itemNode; // 0x10
	WizardGames.Soc.SocClient.Ui.PageType pageType; // 0x18
	System.Int64 collectionId; // 0x20
	System.Boolean get_IsEmpty(); // 0x05b9cb68
	System.Void SetPageType(WizardGames.Soc.SocClient.Ui.PageType pageType); // 0x05b9ee08
	System.Void SetInfo(WizardGames.Soc.SocClient.Ui.ItemNodeInfo itemNodeInfo); // 0x05b9ee80
	System.Void SetInfo(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Int64 collectionId); // 0x05b9e83c
	System.Void Clear(); // 0x05b9d9d8
	System.Void .ctor(); // 0x05b9b954
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCollectionItemsListHandle : System.Object
{
	System.Int64 collectionId; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> autoPickItemNodeList; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> nonAutoPickItemNodeList; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> autoPickExtendBagItemNodeList; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> nonAutoPickExtendBagItemNodeList; // 0x30
	System.Void Clear(); // 0x05b9ef2c
	System.Void .ctor(); // 0x05b9f058
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPickListData : System.Object
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.CorpseEntity> corpseEntityDic; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> autoPickCorpseExtendBagItemsDic; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> nonAutoPickCorpseExtendBagItemsDic; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.BoxEntity> rewardBoxEntityDic; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> autoPickDeadPlayerItemsDic; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> nonAutoPickDeadPlayerItemsDic; // 0x38
	System.Int32 deadPlayerItemsNum; // 0x40
	System.Collections.Generic.List<System.Int64> deadPlayerOrderList; // 0x48
	System.Collections.Generic.Dictionary<System.Int64,System.Boolean> deadPlayerExistDic; // 0x50
	System.Collections.Generic.Dictionary<System.Int64,System.String> playerNameDic; // 0x58
	System.Collections.Generic.List<System.Int64> playerIdList; // 0x60
	System.Collections.Generic.HashSet<System.Int64> playerIds; // 0x68
	System.Boolean isRequestPlayerName; // 0x70
	System.Int64 lastRequestPlayerNameTime; // 0x78
	System.Int64 requestPlayerNameTimeOut; // 0x80
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> autoPickItemsList; // 0x88
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> nonAutoPickItemsList; // 0x90
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> autoPickExtendBagItemsDic; // 0x98
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> nonAutoPickExtendBagItemsDic; // 0xa0
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> autoPickItemsDic; // 0xa8
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> nonAutoPickItemsDic; // 0xb0
	System.Int32 pickableItemsNum; // 0xb8
	System.Int32 decorationItemsNum; // 0xbc
	System.Collections.Generic.List<System.Int64> pickableOrderList; // 0xc0
	System.Collections.Generic.List<System.Int64> decorationOrderList; // 0xc8
	System.Collections.Generic.Dictionary<System.Int64,System.Boolean> decorationExistDic; // 0xd0
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> collectionNumCacheDic; // 0xd8
	System.Int32 dropItemFakeId; // 0xe0
	WizardGames.Soc.SocClient.Ui.ItemNodeInfo preAutoPickItem; // 0xe8
	WizardGames.Soc.SocClient.Ui.PageType curPageType; // 0xf0
	System.Int32 lineNum; // 0xf4
	System.Int64 restoreTime; // 0xf8
	System.Int64 triggerTime; // 0x100
	System.Boolean <IgnoreBlackList>k__BackingField; // 0x108
	static System.Comparison<WizardGames.Soc.Common.CustomType.BaseItemNode> pickListDisplayComparer; // 0x0
	WizardGames.Soc.SocClient.Ui.AutoPriorityPickChecker autoPickPickableChecker; // 0x110
	WizardGames.Soc.SocClient.Ui.AutoPriorityPickChecker autoPickDecorationChecker; // 0x118
	WizardGames.Soc.SocClient.Ui.AutoPriorityPickChecker autoPickRewardBoxChecker; // 0x120
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> tempAutoPickItemsList; // 0x128
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> tempNonAutoPickItemsList; // 0x130
	System.Collections.Generic.List<WizardGames.Soc.Share.Framework.EntityBase> getAllCollectionsRes; // 0x138
	System.Void UpdateAutoPickDeadPlayerItems(); // 0x05b9f184
	System.Void RefreshCorpseCollectionPlayerName(System.Int64 collectionId); // 0x05ba153c
	System.Void RefreshRewardBoxCollectionPlayerName(System.Int64 collectionId); // 0x05ba1694
	System.String GetPlayerNameByCollectionId(System.Int64 collectionId, System.Boolean& isStorage); // 0x05ba17dc
	System.Void UpdateAutoPickCorpseItems(); // 0x05b9fc44
	System.Void UpdateAutoPickRewardBoxItems(); // 0x05ba0724
	System.Void UpdateCorpseExtendBag(System.Int64 collectionId, WizardGames.Soc.Common.CustomType.ItemContainerNode mainContainer); // 0x05ba1be0
	System.Void SetPickItemInSequenceDeadPlayer(); // 0x05ba1ffc
	System.Void OnGetMultiPlayerNames(System.Collections.Generic.Dictionary<System.Int64,System.String> playerIds2Names); // 0x05ba2518
	System.Void UpdateAutoPickItems(); // 0x05ba26f8
	System.Void UpdateCollectDecorationItems(); // 0x05ba30c0
	System.Void UpdateExtendBag(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05ba397c
	System.Void SetPickItemInSequencePickable(); // 0x05ba3ee4
	System.Void UpdateCollectionNumCacheDic(WizardGames.Soc.SocClient.Ui.PageType pageType); // 0x05ba4524
	System.Void set_IgnoreBlackList(System.Boolean value); // 0x05ba49bc
