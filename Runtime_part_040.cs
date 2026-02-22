
// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass72_0 : System.Object
{
	System.Action<WizardGames.Soc.SocClient.Ui.TribeInfo> callback; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x18
	System.String tribeID; // 0x20
	System.Void .ctor(); // 0x06b26fcc
	System.Void <ReqUpdateMyTribeDetailInfo>b__0(SimpleJSON.JSONNode json); // 0x06b27034
	System.Void <ReqUpdateMyTribeDetailInfo>b__1(SimpleJSON.JSONNode error); // 0x06b273c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass73_0 : System.Object
{
	System.Boolean IsSourceCreateTribe; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x18
	System.String tribeID; // 0x20
	System.Void .ctor(); // 0x06b2768c
	System.Void <ReqInviteTribeMembers>b__0(SimpleJSON.JSONNode info); // 0x06b276f4
	System.Void <ReqInviteTribeMembers>b__1(SimpleJSON.JSONNode error); // 0x06b27988
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass74_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.String systemTribeId; // 0x18
	System.Action action; // 0x20
	System.Void .ctor(); // 0x06b27c4c
	System.Void <ReqReplaceSystemTribe>b__0(SimpleJSON.JSONNode info); // 0x06b27cb4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass76_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.String tribeID; // 0x18
	System.Action action; // 0x20
	System.Void .ctor(); // 0x06b27f88
	System.Void <ReqAcceptTribeInvite>b__0(SimpleJSON.JSONNode info); // 0x06b27ff0
	System.Void <ReqAcceptTribeInvite>b__1(SimpleJSON.JSONNode error); // 0x06b28190
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass77_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.String tribeID; // 0x18
	System.Action action; // 0x20
	System.Void .ctor(); // 0x06b28440
	System.Void <ReqRejectTribeInvite>b__0(SimpleJSON.JSONNode info); // 0x06b284a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass78_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.Action action; // 0x18
	System.Void .ctor(); // 0x06b28640
	System.Void <ReqRejectAllTribeInvite>b__0(SimpleJSON.JSONNode info); // 0x06b286a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass79_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.String tribeID; // 0x18
	System.String memberID; // 0x20
	System.Action action; // 0x28
	System.Void .ctor(); // 0x06b288ac
	System.Void <ReqKickTribeMember>b__0(SimpleJSON.JSONNode info); // 0x06b28914
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass80_0 : System.Object
{
	System.Action action; // 0x10
	System.Void .ctor(); // 0x06b28bb8
	System.Void <ReqApplyToTribe>b__0(SimpleJSON.JSONNode info); // 0x06b28c20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass81_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.String tribeID; // 0x18
	System.String roleID; // 0x20
	System.Action action; // 0x28
	System.Boolean isAccept; // 0x30
	System.String playerName; // 0x38
	System.Action<SimpleJSON.JSONNode> <>9__2; // 0x40
	System.Void .ctor(); // 0x06b28da4
	System.Void <ReqHandleTribeApply>b__0(SimpleJSON.JSONNode info); // 0x06b28e0c
	System.Void <ReqHandleTribeApply>b__2(SimpleJSON.JSONNode json); // 0x06b2917c
	System.Void <ReqHandleTribeApply>b__1(SimpleJSON.JSONNode error); // 0x06b292b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass82_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.String tribeID; // 0x18
	System.Action action; // 0x20
	System.Void .ctor(); // 0x06b29560
	System.Void <ReqRejectAllTribeApply>b__0(SimpleJSON.JSONNode info); // 0x06b295c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass83_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> action; // 0x10
	System.Void .ctor(); // 0x06b2976c
	System.Void <ReqSearchTribe>b__0(SimpleJSON.JSONNode info); // 0x06b297d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass84_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> action; // 0x10
	System.Void .ctor(); // 0x06b2994c
	System.Void <ReqGetRecommendTribe>b__0(SimpleJSON.JSONNode info); // 0x06b299b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass85_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.String tribeID; // 0x18
	System.String[] names; // 0x20
	System.Void .ctor(); // 0x06b29b2c
	System.Void <ReqModifyTribeLampTitles>b__0(SimpleJSON.JSONNode info); // 0x06b29b94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass86_0 : System.Object
{
	System.Action cb; // 0x10
	System.Void .ctor(); // 0x06b29d64
	System.Void <ReqEquipTribeLampTitle>b__0(SimpleJSON.JSONNode info); // 0x06b29dcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass87_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.String tribeID; // 0x18
	System.String announcement; // 0x20
	System.Action cb; // 0x28
	System.Void .ctor(); // 0x06b29f40
	System.Void <ReqSetTribeAnnouncement>b__0(SimpleJSON.JSONNode info); // 0x06b29fa8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass88_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.String tribeID; // 0x18
	System.Void .ctor(); // 0x06b2a198
	System.Void <ReqUpgradeToAdvancedTribe>b__0(SimpleJSON.JSONNode info); // 0x06b2a200
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass89_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.Boolean needSendChatMsg; // 0x18
	System.String tribeID; // 0x20
	System.Void .ctor(); // 0x06b2a574
	System.Void <EnterTribeNotify>b__0(SimpleJSON.JSONNode info); // 0x06b2a5dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass92_0 : System.Object
{
	System.String roleId; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x18
	System.Void .ctor(); // 0x06b2a8d8
	System.Void <OnTribeInvite>b__1(SimpleJSON.JSONNode json); // 0x06b2a940
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass97_0 : System.Object
{
	System.String tribeID; // 0x10
	WizardGames.Soc.SocClient.Manager.LobbyTeamData teamData; // 0x18
	System.Void .ctor(); // 0x06b2aaa8
	System.Void <ShareLobbyTeamToTribe>b__0(SimpleJSON.JSONArray jsonArrayInfo); // 0x06b2ab10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass98_0 : System.Object
{
	System.String tribeID; // 0x10
	WizardGames.Soc.SocClient.Manager.LobbyTeamData teamData; // 0x18
	System.Void .ctor(); // 0x06b2acfc
	System.Void <ShareAppointmentTeamToTribe>b__0(SimpleJSON.JSONArray jsonArrayInfo); // 0x06b2ad64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass99_0 : System.Object
{
	System.String tribeID; // 0x10
	System.Void .ctor(); // 0x06b2af50
	System.Void <ShareGameTeamToTribe>b__0(SimpleJSON.JSONArray jsonArrayInfo); // 0x06b2afb8
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.EReadyToJoinWarzone : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.EReadyToJoinWarzone None = 0;
	static WizardGames.Soc.SocClient.Manager.EReadyToJoinWarzone LobbyTeam = 1;
	static WizardGames.Soc.SocClient.Manager.EReadyToJoinWarzone CommunityCard = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.RoundTimeData : System.Object
{
	System.Int64 startTime; // 0x10
	System.Int64 endTime; // 0x18
	System.String startTimeStr; // 0x20
	System.String endTimeStr; // 0x28
	System.Void .ctor(); // 0x06b2b190
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.CustomBannerData : System.Object
{
	System.String Thumbnail; // 0x10
	System.String Name; // 0x18
	System.Int32 JumpId; // 0x20
	System.Action JumpAct; // 0x28
	System.Int32 Order; // 0x30
	System.Void .ctor(); // 0x06b2b1f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.LobbyBattleServerData> lobbyBattleServerDatas; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.LobbyBattleServerData>> lobbyBattleServerDatasDic; // 0x20
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.BattleTeamData> battleTeamDataDic; // 0x28
	WizardGames.Soc.Common.CustomType.PlayerDisplayData <PlayerSelfDisplayData>k__BackingField; // 0x30
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.RoundTimeData>> roundTimeDataListDic; // 0x38
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Manager.RoundTimeData> currentRoundDataDic; // 0x40
	System.Boolean <IsUILobbyMainShowAnimFinish>k__BackingField; // 0x48
	System.Int64 <NextCanRemoveBattleTime>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.Manager.EReadyToJoinWarzone CommunityCardReadyToJoinWarzoneType; // 0x58
	WizardGames.Soc.Common.CustomType.PlayerDisplayData get_PlayerSelfDisplayData(); // 0x06b2b260
	System.Void set_PlayerSelfDisplayData(WizardGames.Soc.Common.CustomType.PlayerDisplayData value); // 0x06b2b2c4
	System.Boolean get_IsUILobbyMainShowAnimFinish(); // 0x054c4760
	System.Void set_IsUILobbyMainShowAnimFinish(System.Boolean value); // 0x05523a7c
	System.Int64 get_NextCanRemoveBattleTime(); // 0x054a4380
	System.Void set_NextCanRemoveBattleTime(System.Int64 value); // 0x055112ac
	System.Void Init(); // 0x06b2b500
	System.Void OnAccountLogout(); // 0x055049cc
	System.Threading.Tasks.Task OnEnterWorld(); // 0x054e7844
	System.Void OnAccountEnterLobby(); // 0x06b2b838
	System.Void ReqChangeName(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String newName, System.Action callback, System.Boolean isRecordCD); // 0x05510ccc
	System.Void ReqChangePersonalTags(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Collections.Generic.List<System.Int32> tags, System.Action callback, System.Boolean isRecordCD); // 0x05510ccc
	System.Void ReqChangeGameStyle(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Collections.Generic.List<System.Int32> tags, System.Action callback, System.Boolean isRecordCD); // 0x05510ccc
	System.Void ReqChangeWeaponPlan(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Int32 plan, System.Action callback); // 0x05506970
	System.Void ReqChangeSuitPlan(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Int32 plan, System.Action callback); // 0x05506970
	System.Void ReqChangeAppearance(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, WizardGames.Soc.SocClient.Ui.PlayerAppearanceInfo info, System.Action callback, System.Boolean isRecordCD); // 0x05510ccc
	System.Void HandleChangeNameBanReason(SimpleJSON.JSONNode error, System.Boolean isRecordCD); // 0x06b2d1c8
	System.Void ReqOpenSocialServer(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Int32 gameMode, System.Action callback); // 0x05506970
	System.Void ReqUseInviteCode(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String inviteCode, System.Action callback); // 0x055105f0
	System.Void ReqChangeAvatar(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String avatar, System.Boolean showTip, System.Action callback); // 0x05510688
	System.Void GetPlayedServerList(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action callback); // 0x0550f6d4
	System.Void ReqDeleteBattleServer(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String battleServerId, System.Action callback); // 0x055105f0
	System.Void ReqBattleTeam(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String teamID, System.String battleServerID, System.Action<SimpleJSON.JSONNode> callback); // 0x05510c9c
	System.Void JoinBattle(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String serverId); // 0x0550f6d4
	System.Void JoinBattleByServerList(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String serverId); // 0x0550f6d4
	System.Void ReqPostBattleRoundList(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Int32 gameMode, System.Action callback); // 0x05506970
	System.Void GetBattleTeamData(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String battleServerId, System.Action callback); // 0x055105f0
	System.Void GetBattleTeamData(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String teamID, System.String battleServerId, System.Action<WizardGames.Soc.SocClient.Ui.BattleTeamData> callback); // 0x05510c9c
	System.Boolean IsFirstPlayerServerData(System.String battleServerId); // 0x06b2ff24
	System.String GetFirstBattleServerId(); // 0x06b30048
	System.Void RegisterLocalNotification(); // 0x06b30150
	System.Boolean HasCaptainImpeachment(); // 0x06b316a8
	System.Boolean IsShowLobbyHistoryBattleRedDot(); // 0x06b31c08
	System.Boolean ShowLobbyHistoryRedDot(); // 0x06b31c94
	System.Boolean ShowLobbyHistoryBattleRewardRedDot(); // 0x06b31dd0
	System.Boolean ShowLobbyHistoryBattleRewardRedDotByBattleServerId(System.String battleServerId); // 0x06b32058
	System.Boolean ShowRedByBattleId(System.String battleId); // 0x06b31ea4
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.RoundTimeData> GetRoundTimeDataList(System.Int32 modeId); // 0x054e7c9c
	System.String GetNextCurrentRoundTimeStr(System.Int32 modeId); // 0x054e7c9c
	System.Int64 GetCurrentRoundTime(System.Int32 modeId); // 0x054a4454
	System.Int64 GetCurrentRoundEndTime(System.Int32 modeId); // 0x054a4454
	System.Int64 GetNearestRoundStartTime(System.Int32 modeId); // 0x054a4454
	System.String GetCurrentRoundTimeStrNoSec(System.Int32 modeId); // 0x054e7c9c
	System.Int64 GetEndTimeByStartTime(System.Int64 startTime, System.Int32 modeId); // 0x054a47f8
	System.Boolean IsAppointmentMode(System.Int32 modeId); // 0x06b328ec
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.common.ENUMSwitchTimeType,System.Collections.Generic.List<System.Int32>> GetTimeRules(System.Int32 modeId); // 0x054e7c9c
	System.Boolean CheckIfOpenInTimeframes(System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.common.ENUMSwitchTimeType,System.Collections.Generic.List<System.Int32>> timeRules, WizardGames.Soc.Common.Data.common.ENUMSwitchTimeType[] typesToCheck); // 0x06b32d88
	System.Boolean IsActivityOpenByModeId(System.Int32 modeId); // 0x054c4f88
	System.Int32 GetBattleServerListByModeID(System.Int32 modeID); // 0x06b33464
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.LobbyBattleServerData> GetLobbyBattleServerDataByModeId(System.Int32 modeId); // 0x06b334fc
	System.Int32 IsPlayerNameLegal(System.String name, System.Boolean canSame); // 0x06b338c4
	System.Boolean IsPlayerNameLegal(System.String name, System.Boolean withErrorTips, System.Boolean canSame); // 0x06b33b84
	System.Void DeleteBattleServer(System.String battleServerId); // 0x05523a54
	WizardGames.Soc.SocClient.Ui.LobbyBattleServerData GetLobbyBattleServerData(System.String battleServerId); // 0x06b3420c
	System.Int64 GetCurrentUnixTimestampInSeconds(); // 0x06b34374
	System.Boolean IsHasLimitModeOpen(System.String& modeName); // 0x06b3448c
	System.Void GetBobbyBattleServerDataByLastMatchWarzoneTime(System.UInt64 lastMatchWarzoneTime, System.String& serverId); // 0x06b34718
	System.Void RemoveLobbyBattleServerDataByBattleServerId(System.String battleServerId); // 0x06b34b80
	System.Boolean CaptainImpeachmentTipIsInClientPrefs(System.String battleServerId); // 0x06b35040
	System.Void SetCaptainImpeachmentTipClientPrefs(System.String battleServerId); // 0x06b35278
	System.Boolean IsShowCaptainImpeachmentTip(System.String battleServerId); // 0x06b317e4
	System.Boolean CheckXinYueNeedRefreshRedDot(); // 0x06b354a4
	System.Int64 GetMondayOfCurWeekTime(); // 0x06b355a8
	System.Void UpdateXinYueRefreshTime(); // 0x06b35664
	System.Void OpenUiInputBoxByInviteCode(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
	static System.Void .cctor(); // 0x06b35c14
	System.Void <ReqOpenSocialServer>b__34_0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Manager.MgrLobby.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__26_1; // 0x8
	static System.Action<SimpleJSON.JSONNode> <>9__27_1; // 0x10
	static System.Action<SimpleJSON.JSONNode> <>9__34_1; // 0x18
	static System.Action<SimpleJSON.JSONNode> <>9__35_1; // 0x20
	static System.Action<SimpleJSON.JSONNode> <>9__36_2; // 0x28
	static System.Comparison<WizardGames.Soc.SocClient.Ui.LobbyBattleServerData> <>9__37_1; // 0x30
	static System.Action<SimpleJSON.JSONNode> <>9__40_1; // 0x38
	static System.Action<SimpleJSON.JSONNode> <>9__44_1; // 0x40
	static System.Action<SimpleJSON.JSONNode> <>9__45_1; // 0x48
	static System.Action<WizardGames.Soc.SocClient.PersistentData.CommonAccountPersistentData> <>9__72_0; // 0x50
	static System.Action <>9__84_1; // 0x58
	static System.Action<System.String> <>9__84_0; // 0x60
	static System.Void .cctor(); // 0x06b35e50
	System.Void .ctor(); // 0x06b35eb4
	System.Void <ReqChangePersonalTags>b__26_1(SimpleJSON.JSONNode error); // 0x05523a54
	System.Void <ReqChangeGameStyle>b__27_1(SimpleJSON.JSONNode error); // 0x05523a54
	System.Void <ReqOpenSocialServer>b__34_1(SimpleJSON.JSONNode error); // 0x05523a54
	System.Void <ReqUseInviteCode>b__35_1(SimpleJSON.JSONNode error); // 0x05523a54
	System.Void <ReqChangeAvatar>b__36_2(SimpleJSON.JSONNode error); // 0x05523a54
	System.Int32 <GetPlayedServerList>b__37_1(WizardGames.Soc.SocClient.Ui.LobbyBattleServerData a, WizardGames.Soc.SocClient.Ui.LobbyBattleServerData b); // 0x054a3b30
	System.Void <JoinBattle>b__40_1(SimpleJSON.JSONNode error); // 0x05523a54
	System.Void <ReqPostBattleRoundList>b__44_1(SimpleJSON.JSONNode error); // 0x05523a54
	System.Void <GetBattleTeamData>b__45_1(SimpleJSON.JSONNode error); // 0x05523a54
	System.Void <DeleteBattleServer>b__72_0(WizardGames.Soc.SocClient.PersistentData.CommonAccountPersistentData data); // 0x05523a54
	System.Void <OpenUiInputBoxByInviteCode>b__84_0(System.String str); // 0x05523a54
	System.Void <OpenUiInputBoxByInviteCode>b__84_1(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby.<>c__DisplayClass25_0 : System.Object
{
	System.String newName; // 0x10
	System.Boolean isRecordCD; // 0x18
	System.Action callback; // 0x20
	WizardGames.Soc.SocClient.Manager.MgrLobby <>4__this; // 0x28
	System.Void .ctor(); // 0x055049cc
	System.Void <ReqChangeName>b__0(SimpleJSON.JSONNode res); // 0x05523a54
	System.Void <ReqChangeName>b__1(SimpleJSON.JSONNode error); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby.<>c__DisplayClass26_0 : System.Object
{
	System.Action callback; // 0x10
	System.Void .ctor(); // 0x06b2be4c
	System.Void <ReqChangePersonalTags>b__0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby.<>c__DisplayClass27_0 : System.Object
{
	System.Action callback; // 0x10
	System.Void .ctor(); // 0x06b2c324
	System.Void <ReqChangeGameStyle>b__0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby.<>c__DisplayClass28_0 : System.Object
{
	System.Action callback; // 0x10
	System.Void .ctor(); // 0x06b2c7fc
	System.Void <ReqChangeWeaponPlan>b__0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby.<>c__DisplayClass29_0 : System.Object
{
	System.Action callback; // 0x10
	System.Void .ctor(); // 0x06b2cadc
	System.Void <ReqChangeSuitPlan>b__0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby.<>c__DisplayClass30_0 : System.Object
{
	System.Action callback; // 0x10
	System.Void .ctor(); // 0x06b2cdbc
	System.Void <ReqChangeAppearance>b__0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby.<>c__DisplayClass35_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrLobby <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x055049cc
	System.Void <ReqUseInviteCode>b__0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby.<>c__DisplayClass36_0 : System.Object
{
	System.String avatar; // 0x10
	WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule; // 0x18
	System.Action callback; // 0x20
	System.Action<SimpleJSON.JSONNode> <>9__1; // 0x28
	System.Void .ctor(); // 0x06b2dedc
	System.Void <ReqChangeAvatar>b__0(); // 0x055049cc
	System.Void <ReqChangeAvatar>b__1(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby.<>c__DisplayClass37_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrLobby <>4__this; // 0x10
	WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule; // 0x18
	System.Action callback; // 0x20
	System.Void .ctor(); // 0x06b2e0c4
	System.Void <GetPlayedServerList>b__0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby.<>c__DisplayClass38_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrLobby <>4__this; // 0x10
	System.String battleServerId; // 0x18
	System.Action callback; // 0x20
	System.Void .ctor(); // 0x06b2e12c
	System.Void <ReqDeleteBattleServer>b__0(SimpleJSON.JSONNode ret); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby.<>c__DisplayClass39_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> callback; // 0x10
	System.Void .ctor(); // 0x06b2e434
	System.Void <ReqBattleTeam>b__0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby.<>c__DisplayClass40_0 : System.Object
{
	WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule; // 0x10
	System.String serverId; // 0x18
	System.Void .ctor(); // 0x06b2e758
	System.Void <JoinBattle>b__0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby.<>c__DisplayClass43_0 : System.Object
{
	System.String serverId; // 0x10
	System.String battleIdUrl; // 0x18
	System.Void .ctor(); // 0x055049cc
	System.Void <JoinBattleByServerList>b__0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby.<>c__DisplayClass44_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrLobby <>4__this; // 0x10
	System.Int32 gameMode; // 0x18
	System.Action callback; // 0x20
	System.Void .ctor(); // 0x06b2f074
	System.Void <ReqPostBattleRoundList>b__0(SimpleJSON.JSONNode jsonNode); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby.<>c__DisplayClass45_0 : System.Object
{
	System.String battleServerId; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrLobby <>4__this; // 0x18
	System.Action callback; // 0x20
	System.Void .ctor(); // 0x06b2f804
	System.Void <GetBattleTeamData>b__0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobby.<>c__DisplayClass46_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrLobby <>4__this; // 0x10
	System.String strKey; // 0x18
	System.Action<WizardGames.Soc.SocClient.Ui.BattleTeamData> callback; // 0x20
	System.String battleServerId; // 0x28
	System.Void .ctor(); // 0x06b2fc20
	System.Void <GetBattleTeamData>b__0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrSkinModify : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> ColorIdToSkinId; // 0x18
	System.Void OnAccountLogined(); // 0x06b39894
	System.Int32 GetSkinIdByColorId(System.Int32 colorSkinId); // 0x06b39bdc
	System.Void PostEquipColorSkin(System.Int32 colorSkinId, System.Int32 opType, System.Action callBack); // 0x06b39c90
	System.Void GameEquipColorSkin(System.Int32 colorSkinId, System.Int32 opType, System.Action callBack); // 0x06b39dd8
	System.Void LobbyEquipColorSkin(System.Int32 colorSkinId, System.Int32 opType, System.Action callBack); // 0x06b3a0cc
	System.Void PostEquipHangingsop(System.Int32 hangingsSkinId, System.Int32 opType, System.Int32 skinId, System.Action callBack); // 0x06b3a5c4
	System.Void PostUnlockLevelReward(System.Int32 level, System.Int32 slot, System.Int32 skinId, System.Action callBack); // 0x06b3a934
	System.Boolean CheckCanModify(System.Int32 skinId); // 0x06b3aca4
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJSkinUpgrade> GetModifyLevelById(System.Int32 skinId); // 0x06b3adb4
	System.Boolean TryOpenModifyWnd(System.Int32 skinId); // 0x06b3b0a4
	System.Boolean CheckIsModify(System.Int32 skinId); // 0x06b3b1c0
	WizardGames.Soc.Common.Data.resource.OBJSkin GetModifyCfg(System.Int32 skinId); // 0x06b3b408
	System.String GetModifyShowIcon(System.Int64 skinId); // 0x06b3b614
	System.String GetModifyIcon(System.Int64 skinId); // 0x06b3b860
	WizardGames.Soc.Common.Data.collection.OBJCostumeSuit GetSuitDataBySkinId(System.Int32 skinId); // 0x06b3baac
	System.Void .ctor(); // 0x06b3bcb4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrSkinModify.<>c__DisplayClass5_0 : System.Object
{
	System.Int32 colorSkinId; // 0x10
	System.Int32 opType; // 0x14
	System.Action callBack; // 0x18
	System.Void .ctor(); // 0x06b3a55c
	System.Void <LobbyEquipColorSkin>b__0(SimpleJSON.JSONNode respon); // 0x06b3bd68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrSkinModify.<>c__DisplayClass6_0 : System.Object
{
	System.Int32 skinId; // 0x10
	System.Int32 hangingsSkinId; // 0x14
	System.Int32 opType; // 0x18
	System.Action callBack; // 0x20
	System.Void .ctor(); // 0x06b3a8cc
	System.Void <PostEquipHangingsop>b__0(SimpleJSON.JSONNode respon); // 0x06b3c00c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrSkinModify.<>c__DisplayClass7_0 : System.Object
{
	System.Int32 level; // 0x10
	System.Int32 slot; // 0x14
	System.Int32 skinId; // 0x18
	System.Action callBack; // 0x20
	System.Void .ctor(); // 0x06b3ac3c
	System.Void <PostUnlockLevelReward>b__0(SimpleJSON.JSONNode respon); // 0x06b3c328
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.CommonSkinData : System.Object
{
	System.Int64 <SkinId>k__BackingField; // 0x10
	WizardGames.Soc.Common.Data.resource.ENUMSkinType <SkinType>k__BackingField; // 0x18
	System.Int64 GotTime; // 0x20
	System.Int64 HostItemID; // 0x28
	System.Int64 <ConfHostItemID>k__BackingField; // 0x30
	System.Int64 StarredTime; // 0x38
	System.Int64 expirationAt; // 0x40
	System.Int32 count; // 0x48
	System.Int32 level; // 0x4c
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> levelInfo; // 0x50
	System.Int64 get_SkinId(); // 0x06b3c900
	WizardGames.Soc.Common.Data.resource.ENUMSkinType get_SkinType(); // 0x06b3c964
	System.Boolean get_IsEquiped(); // 0x06b3c9c8
	System.Int64 get_ConfHostItemID(); // 0x06b3ca34
	System.Boolean get_IsModify(); // 0x06b3ca98
	System.Boolean get_IsExpired(); // 0x06b3cbe0
	System.Void .ctor(System.Int64 skinId, WizardGames.Soc.Common.Data.resource.ENUMSkinType skinType, System.Int64 confHostItemID); // 0x06b3cc90
	System.Void SetHostItemId(System.Int64 hostItemID); // 0x06b3cd38
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Manager.ISkinService : 
{
	
	System.Void OnEnabled(); // 0x055049cc
	System.Void OnDisabled(); // 0x055049cc
	System.Void EquipSkin(System.Int64 skinId, System.Int64 hostItemId, System.Action callback, System.Boolean cancel); // 0x05511cd8
	System.Void CollectSkins(System.Int64 skinId, System.Action<System.Int64> callback, System.Boolean cancel); // 0x05512cfc
	WizardGames.Soc.Common.CustomType.SkinNode GetSkinNodeBySkinId(System.Int64 skinId); // 0x054e931c
	System.Void ChangeItemSkin(System.Int64 skinId, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Action callback); // 0x05512cd0
	System.Void PostUpdataPlan(System.Collections.Generic.Dictionary<System.Int32,System.Int32> costomPlan, System.Collections.Generic.Dictionary<System.Int32,System.Int32> equipPlan, System.Int32 planId, System.Action callBack); // 0x0552bef0
	System.Void PostUpdataOption(System.Collections.Generic.Dictionary<System.Int32,System.Boolean> optionDic, System.Action callBack); // 0x0552af00
	System.Void RequirePlayerAllCustomPlan(System.String roleId, System.Action<System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>>,System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>>> callback); // 0x0552af00
	System.Void PostSaveEmoteConfig(System.Collections.Generic.List<System.Int32> skinIds, WizardGames.Soc.Common.Data.resource.ENUMSkinType skinType); // 0x05525b70
	System.Void SetModifySkinData(WizardGames.Soc.SocClient.Manager.CommonSkinData skinData, SimpleJSON.JSONNode json); // 0x0552af00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbySkinService : System.Object, WizardGames.Soc.SocClient.Manager.ISkinService
{
	System.String LobbySkinServiceRoot; // 0x10
	System.Void OnDisabled(); // 0x06b3cdb0
	System.Void OnEnabled(); // 0x06b3ce10
	System.Void HandleArmorSkin(SimpleJSON.JSONNode json, System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.CommonSkinData>> callback); // 0x06b3ce70
	System.Void SetModifySkinEquipData(SimpleJSON.JSONNode response); // 0x06b3d810
	System.Void SetModifySkinData(WizardGames.Soc.SocClient.Manager.CommonSkinData skinData, SimpleJSON.JSONNode json); // 0x06b3d2c0
	System.Void HandleWeaponSkin(SimpleJSON.JSONNode response, System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.CommonSkinData>> callback); // 0x06b3dc78
	System.Void HandleBuildingSkins(SimpleJSON.JSONNode response); // 0x06b3e55c
	System.Void HandleFurnitureSkins(SimpleJSON.JSONNode response); // 0x06b3ec4c
	System.Void HandleDoorSkins(SimpleJSON.JSONNode response); // 0x06b3f0a4
	System.Void CollectSkins(System.Int64 skinId, System.Action<System.Int64> callback, System.Boolean cancel); // 0x06b3f4fc
	System.Void EquipSkin(System.Int64 skinId, System.Int64 hostItemId, System.Action callback, System.Boolean cancel); // 0x06b3f818
	WizardGames.Soc.Common.CustomType.SkinNode GetSkinNodeBySkinId(System.Int64 skinId); // 0x06b3fb78
	System.Void ChangeItemSkin(System.Int64 skinId, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Action callback); // 0x06b3fbf0
	System.Void HandleAllCustomPlan(SimpleJSON.JSONNode respons, System.Action callback); // 0x06b3fc80
	System.Void HandleCostumeData(SimpleJSON.JSONNode json); // 0x06b40478
	System.Void HandleOptionData(SimpleJSON.JSONNode json); // 0x06b40808
	System.Void PostUpdataPlan(System.Collections.Generic.Dictionary<System.Int32,System.Int32> costomPlan, System.Collections.Generic.Dictionary<System.Int32,System.Int32> equipPlan, System.Int32 planId, System.Action callBack); // 0x06b40ad0
	System.Void PostUpdataOption(System.Collections.Generic.Dictionary<System.Int32,System.Boolean> optionDic, System.Action callBack); // 0x06b41150
	System.Void RequirePlayerAllCustomPlan(System.String roleId, System.Action<System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>>,System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>>> callback); // 0x06b415b0
	System.Void RequireGestureInfo(); // 0x06b4186c
	System.Void HandleGestureInfo(SimpleJSON.JSONNode respons); // 0x06b419fc
	System.Void PostSaveEmoteConfig(System.Collections.Generic.List<System.Int32> skinIds, WizardGames.Soc.Common.Data.resource.ENUMSkinType skinType); // 0x06b4203c
	System.Void RequireAllSkinInfo(System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.CommonSkinData>> armorAction, System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.CommonSkinData>> weaponAction); // 0x06b42420
	System.Void .ctor(); // 0x06b42680
	System.Void <RequireGestureInfo>b__30_0(SimpleJSON.JSONNode respons); // 0x06b4270c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbySkinService.<>c__DisplayClass15_0 : System.Object
{
	System.Action<System.Int64> callback; // 0x10
	System.Void .ctor(); // 0x06b3f7b0
	System.Void <CollectSkins>b__0(SimpleJSON.JSONNode respons); // 0x06b42788
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbySkinService.<>c__DisplayClass16_0 : System.Object
{
	System.Action callback; // 0x10
	System.Void .ctor(); // 0x06b3fb10
	System.Void <EquipSkin>b__0(SimpleJSON.JSONNode respons); // 0x06b4284c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbySkinService.<>c__DisplayClass26_0 : System.Object
{
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> equipPlan; // 0x10
	System.Int32 planId; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> costomPlan; // 0x20
	System.Action callBack; // 0x28
	System.Void .ctor(); // 0x06b410e8
	System.Void <PostUpdataPlan>b__0(SimpleJSON.JSONNode respon); // 0x06b428d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbySkinService.<>c__DisplayClass28_0 : System.Object
{
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> optionDic; // 0x10
	System.Action callBack; // 0x18
	System.Void .ctor(); // 0x06b41548
	System.Void <PostUpdataOption>b__0(SimpleJSON.JSONNode respon); // 0x06b42cbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbySkinService.<>c__DisplayClass29_0 : System.Object
{
	System.Action<System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>>,System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>>> callback; // 0x10
	System.Void .ctor(); // 0x06b41804
	System.Void <RequirePlayerAllCustomPlan>b__0(SimpleJSON.JSONNode respons); // 0x06b42d94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbySkinService.<>c__DisplayClass32_0 : System.Object
{
	WizardGames.Soc.Common.Data.resource.ENUMSkinType skinType; // 0x10
	WizardGames.Soc.SocClient.Manager.LobbySkinService <>4__this; // 0x18
	System.Void .ctor(); // 0x06b423b8
	System.Void <PostSaveEmoteConfig>b__0(SimpleJSON.JSONNode respons); // 0x06b432fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbySkinService.<>c__DisplayClass33_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.LobbySkinService <>4__this; // 0x10
	System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.CommonSkinData>> armorAction; // 0x18
	System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.CommonSkinData>> weaponAction; // 0x20
	System.Void .ctor(); // 0x06b42618
	System.Void <RequireAllSkinInfo>b__0(SimpleJSON.JSONNode respons); // 0x06b43398
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.WorldSkinService : System.Object, WizardGames.Soc.SocClient.Manager.ISkinService
{
	System.String LobbySkinServiceRoot; // 0x10
	SocLogger logger; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.SkinNode> skinNodeCache; // 0x20
	WizardGames.Soc.Common.CustomType.SystemRootNode skinRootNode; // 0x28
	System.Action skinBatchChangeCallback; // 0x30
	System.Action<System.Int64> skinStarCallback; // 0x38
	System.Action inventoryItemSkinChangeCallback; // 0x40
	WizardGames.Soc.Common.CustomType.BaseItemNode currentItemNode; // 0x48
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.ESkinType,WizardGames.Soc.Common.Data.resource.ENUMSkinType> skinTypeAdapter; // 0x50
	WizardGames.Soc.Common.CustomType.SkinNode GetSkinNodeBySkinId(System.Int64 skinId); // 0x06b4364c
	System.Void OnEnabled(); // 0x06b43718
	System.Void OnDisabled(); // 0x06b43f18
	System.Void OnBuildSkinBatchChange(System.Int32 result); // 0x06b44268
	System.Void RefreshSkinNodeCache(); // 0x06b43918
	WizardGames.Soc.SocClient.Manager.CommonSkinData CreateSkinDataByNode(WizardGames.Soc.Common.CustomType.SkinNode node); // 0x06b44304
	System.Void OnStarredStatusChanged(WizardGames.Soc.Share.Framework.CustomTypeBase base, System.Int64 oldValue, System.Int64 newValue); // 0x06b4478c
	System.Void OnInventoryUpdateCallback(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int64 oldId, System.Int64 newId); // 0x06b4497c
	System.Void CollectSkins(System.Int64 skinId, System.Action<System.Int64> callback, System.Boolean cancel); // 0x06b44a98
	System.Void EquipSkin(System.Int64 skinId, System.Int64 hostItemId, System.Action callback, System.Boolean cancel); // 0x06b44c28
	System.Void EquipBuildSkin(System.Int64 toolCupboardEntityId, System.Int64 skinId, System.Int64 hostItemId, System.Action callback, System.Boolean cancel, System.Boolean changeDoor); // 0x06b44d8c
	System.Void ChangeItemSkin(System.Int64 skinNodeId, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Action callback); // 0x06b450b8
	System.Void SetModifySkinData(WizardGames.Soc.SocClient.Manager.CommonSkinData skinData, SimpleJSON.JSONNode json); // 0x06b45240
	System.Void WizardGames.Soc.SocClient.Manager.ISkinService.PostUpdataPlan(System.Collections.Generic.Dictionary<System.Int32,System.Int32> costomPlan, System.Collections.Generic.Dictionary<System.Int32,System.Int32> equipPlan, System.Int32 planId, System.Action callBack); // 0x06b45790
	System.Void WizardGames.Soc.SocClient.Manager.ISkinService.PostUpdataOption(System.Collections.Generic.Dictionary<System.Int32,System.Boolean> optionDic, System.Action callBack); // 0x06b45828
	System.Void WizardGames.Soc.SocClient.Manager.ISkinService.RequirePlayerAllCustomPlan(System.String roleId, System.Action<System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>>,System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>>> callback); // 0x06b45ed8
	System.Void PostSaveEmoteConfig(System.Collections.Generic.List<System.Int32> skinIds, WizardGames.Soc.Common.Data.resource.ENUMSkinType skinType); // 0x06b46194
	System.Void .ctor(); // 0x06b46210
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.WorldSkinService.<>c__DisplayClass32_0 : System.Object
{
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> optionDic; // 0x10
	System.Action callBack; // 0x18
	System.Void .ctor(); // 0x06b45e70
	System.Void <WizardGames.Soc.SocClient.Manager.ISkinService.PostUpdataOption>b__0(SimpleJSON.JSONNode respon); // 0x06b46418
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.WorldSkinService.<>c__DisplayClass33_0 : System.Object
{
	System.Action<System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>>,System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>>> callback; // 0x10
	System.Void .ctor(); // 0x06b4612c
	System.Void <WizardGames.Soc.SocClient.Manager.ISkinService.RequirePlayerAllCustomPlan>b__0(SimpleJSON.JSONNode respons); // 0x06b464f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.CachedCustomPlanInfo : System.Object
{
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> allEquipPlan; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> allCostumePlan; // 0x18
	System.Single cachedTime; // 0x20
	System.Void .ctor(); // 0x06b46a58
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobbySkin : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger soclog; // 0x0
	System.String LobbySkinService; // 0x18
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Manager.CachedCustomPlanInfo> localCache; // 0x20
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Manager.CachedCustomPlanInfo> tempLocalCache; // 0x28
	WizardGames.Soc.SocClient.Manager.ISkinService skinService; // 0x30
	System.Action WeaponSkinInfoReceived; // 0x38
	System.Action ArmorSkinInfoReceived; // 0x40
	System.Action BuildingSkinInfoReceived; // 0x48
	System.Action EquipResultReceived; // 0x50
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Manager.CommonSkinData> ownedSkins; // 0x58
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Manager.CommonSkinData> ownedCostumes; // 0x60
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> colorSkinDataDic; // 0x68
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> hangingDataDic; // 0x70
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> <AllCostumePlan>k__BackingField; // 0x78
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> <AllEquipPlan>k__BackingField; // 0x80
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> modifyEquipPlan; // 0x88
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> modifyCostumePlan; // 0x90
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> <ShowOptionDic>k__BackingField; // 0x98
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Manager.CommonSkinData> <OwnedGestures>k__BackingField; // 0xa0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Manager.CommonSkinData> <OwnedSprays>k__BackingField; // 0xa8
	System.Collections.Generic.List<System.Int32> <NewAddArmorSkin>k__BackingField; // 0xb0
	System.Collections.Generic.List<System.Int32> <NewAddWeaponSkin>k__BackingField; // 0xb8
	System.Collections.Generic.List<System.Int32> <NewAddBuildSkin>k__BackingField; // 0xc0
	System.Int32 <UsePlanId>k__BackingField; // 0xc8
	System.Int32 defaultPlanId; // 0xcc
	System.Int32 defaultSkinLevel; // 0xd0
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> gameCostumeDic; // 0xd8
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> gameCostumeToServer; // 0xe0
	System.Collections.Generic.List<SimpleJSON.JSONArray> cahceAcquiredResourcesList; // 0xe8
	WizardGames.Soc.SocClient.Manager.ERewardPopFlag rewardPopFlag; // 0xf0
	System.Collections.Generic.List<System.Int32> skinIDs; // 0xf8
	SimpleJSON.JSONArray cacheAcquiredResources; // 0x100
	System.Int32 <UseLobbyWeaponId>k__BackingField; // 0x108
	System.Boolean isAutoEquipWeapon; // 0x10c
	System.Int64 timerId; // 0x110
	SimpleJSON.JSONArray appPrivilegeCacheResources; // 0x118
	System.String appPrivilegeReason; // 0x120
	System.Collections.Generic.HashSet<System.Int32> autoEquipSkinIDs; // 0x128
	System.Int64 toolCupboardEntityId; // 0x130
	System.Void set_AllCostumePlan(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> value); // 0x06b46ac0
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> get_AllCostumePlan(); // 0x06b46b40
	System.Void set_AllEquipPlan(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> value); // 0x06b46ba4
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> get_AllEquipPlan(); // 0x06b46c24
	System.Void set_ShowOptionDic(System.Collections.Generic.Dictionary<System.Int32,System.Boolean> value); // 0x06b46c88
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> get_ShowOptionDic(); // 0x06b46d08
	System.Void set_OwnedGestures(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Manager.CommonSkinData> value); // 0x06b46d6c
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Manager.CommonSkinData> get_OwnedGestures(); // 0x06b46dec
	System.Void set_OwnedSprays(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Manager.CommonSkinData> value); // 0x06b46e50
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Manager.CommonSkinData> get_OwnedSprays(); // 0x06b46ed0
	System.Collections.Generic.List<System.Int32> get_NewAddArmorSkin(); // 0x06b46f34
	System.Collections.Generic.List<System.Int32> get_NewAddWeaponSkin(); // 0x06b46f98
	System.Collections.Generic.List<System.Int32> get_NewAddBuildSkin(); // 0x06b46ffc
	System.Void set_UsePlanId(System.Int32 value); // 0x06b47060
	System.Void set_UseLobbyWeaponId(System.Int32 value); // 0x06b470d8
	System.Int32 get_UseLobbyWeaponId(); // 0x06b47150
	System.Void OnAccountLogined(); // 0x06b471b4
	System.Void OnAccountEnterLobby(); // 0x06b4734c
	System.Void OnAccountLogout(); // 0x06b4749c
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06b4762c
	System.Void OnPlayerAwake(); // 0x06b47694
	System.Threading.Tasks.Task OnExitWorld(); // 0x06b47844
	System.Void SetUseLobbyWeaponId(System.Boolean isAuto, System.Int32 weaponId); // 0x06b479d4
	System.Void Init(); // 0x06b47af0
	System.Void Destroy(); // 0x06b47c68
	System.Void OnIsInLotteryProgress(System.Boolean isShow); // 0x06b47de0
	System.Void OnIsLotteryQuickBuy(System.Boolean isShow); // 0x06b47e64
	System.Void RequestLobbySkinInfo(); // 0x06b473bc
	System.Void WeaponSkinCallBack(System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.CommonSkinData> skinDataList); // 0x06b48064
	System.Void ArmorSkinCallBack(System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.CommonSkinData> skinDataList); // 0x06b482ec
	System.Void RequestSetLobbyWeapon(System.Int32 weaponId); // 0x06b48574
	System.Void OnLobbyWeaponInfoChange(SimpleJSON.JSONNode node); // 0x06b3e3f4
	System.Void AddColorSkinData(System.Collections.Generic.Dictionary<System.Int32,System.Int32> colorSkin); // 0x06b3da3c
	System.Void SetHangingsData(System.Collections.Generic.Dictionary<System.Int32,System.Int32> hangingData); // 0x06b4874c
	System.Void SetBuildData(System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.CommonSkinData> skinDataList); // 0x06b3e9dc
	System.Void UpdateColroSkinData(System.Int32 colorSkinId, System.Int32 opType); // 0x06b3be74
	System.Void UpdateHangingsData(System.Int32 skinId, System.Int32 hangingsId, System.Int32 opType); // 0x06b3c1b8
	System.Void UpdateColorSkinRewardItem(System.Int32 level, System.Int32 slot, System.Int32 skinId); // 0x06b3c43c
	System.Int32 GetColorSkinId(System.Int32 skinId); // 0x06b3b560
	System.Boolean CheckColorSkinIsEquip(System.Int32 colorSkinId); // 0x06b487cc
	System.Int32 GetHangingId(System.Int32 skinId); // 0x06b48884
	System.Int32 GetWeaponCountByHangingId(System.Int32 hangingId); // 0x06b489cc
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.CommonSkinData> GetItemOwnedSkins(System.Int64 hostItemId); // 0x06b48b54
	System.Boolean CheckSkinIsEquip(System.Int32 skinId); // 0x06b48e10
	System.Int64 GetItemEquippedSkin(System.Int64 hostItemId); // 0x06b48f60
	System.Boolean IsSkinOwned(System.Int64 skinId); // 0x06b49154
	WizardGames.Soc.SocClient.Manager.CommonSkinData GetSkinData(System.Int64 skinId); // 0x06b44900
	WizardGames.Soc.SocClient.Manager.CommonSkinData GetOtherSkinData(System.Int32 skinId); // 0x06b491dc
	System.Void AddOrUpdateSkinData(WizardGames.Soc.SocClient.Manager.CommonSkinData newData); // 0x06b44558
	System.Void CollectSkin(System.Int64 skinId, System.Boolean cancel, System.Action callback); // 0x06b49288
	System.Boolean CheckCanPreivew(WizardGames.Soc.Common.Data.resource.ENUMSkinType type); // 0x06b49434
	System.Boolean CheckCanPreviewById(System.Int32 itemId); // 0x06b49550
	System.Void RefreshAcquiredResourcesInnteral(SimpleJSON.JSONArray acquiredResources, System.Boolean isJumpDelay, System.Boolean isForceObtain); // 0x06b49704
	System.Void OnRefreshAcquiredResources(SimpleJSON.JSONArray acquiredResources); // 0x06b4af64
	System.Void CheckAppPrivilegeResources(SimpleJSON.JSONArray acquiredResources); // 0x06b4b0f8
	System.Void RefreshppPrivilegeResources(SimpleJSON.JSONArray acquiredResources, SimpleJSON.JSONNode resNode, System.Int32 removeIndex, System.Boolean isCache); // 0x06b4b44c
	System.Void CheckAppPrivilegeResourcesToGetRoleInfo(); // 0x06b4b5ac
	System.Void DelayShowAppPrivilegeResources(); // 0x06b4b788
	System.Void DelayShowAcquiredResources(); // 0x06b4b8e4
	System.Void EquipSkin(System.Int64 hostItemId, System.Int64 skinId, System.Action callback, System.Boolean silent); // 0x06b4bbd8
	System.Void UnequipSkin(System.Int64 hostItemId, System.Int64 skinId, System.Action callback, System.Boolean silent); // 0x06b4bd94
	System.Void EquipBuildSkin(System.Int64 hostItemId, System.Int64 skinId, System.Action callback, System.Boolean cancel, System.Boolean changeDoor); // 0x06b4bf70
	System.Int64 GetCurBuildSkin(System.Int32 hostItemId); // 0x06b4c1a8
	System.Void ChangeItemSkin(System.Int64 skinNodeId, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Action callback); // 0x06b3a468
	System.Void OnReceiveEquipSkinResult(System.Int64 hostItemId, System.Int64 skinId, System.Int64 oldSkinId); // 0x06b4c368
	System.Void OnReceiveUnequipSkinResult(System.Int64 hostItemId, System.Int64 skinId); // 0x06b4c594
	System.Boolean HasNewWeaponSkin(); // 0x06b4c6e0
	System.Boolean HasNewArmorSkin(); // 0x06b4ce44
	System.Boolean HasNewBuildingSkin(); // 0x06b4d3e0
	WizardGames.Soc.Common.CustomType.SkinNode GetSkinNodeBySkinId(System.Int64 skinId); // 0x06b3a38c
	System.Void SetAllCostumePlan(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> costumePlan); // 0x06b40264
	System.Void SetAllEquipPlan(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> equipPlan); // 0x06b40318
	System.Void UpdataEquipPlan(System.Collections.Generic.Dictionary<System.Int32,System.Int32> equipPlan, System.Int32 planId); // 0x06b429ec
	System.Void UpdataCostumePlan(System.Collections.Generic.Dictionary<System.Int32,System.Int32> costumePlan, System.Int32 planId); // 0x06b42b54
	System.Void SetUsePlanId(System.Int32 usePlanId); // 0x06b403cc
	System.Void SetCostumeData(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Manager.CommonSkinData> costumesData); // 0x06b4da24
	System.Void SetOptionData(System.Collections.Generic.Dictionary<System.Int32,System.Boolean> options); // 0x06b40a1c
	System.Boolean GetShowOptionValue(System.Int32 key); // 0x06b4daa4
	System.Void SetGestureData(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Manager.CommonSkinData> gestureData); // 0x06b41ed4
	System.Void SetSpraysData(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Manager.CommonSkinData> spraysData); // 0x06b41f88
	WizardGames.Soc.SocClient.Manager.CommonSkinData GetGestureData(System.Int64 skinId); // 0x06b4dbd8
	WizardGames.Soc.SocClient.Manager.CommonSkinData GetSpraysData(System.Int64 skinId); // 0x06b4dcd0
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> GetUseCostumePlanData(System.Int32 planId); // 0x06b4ddc8
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> GetUseEquipPlanData(System.Int32 planId); // 0x06b4e1b8
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> GetUseModifyEquipPlan(); // 0x06b4e544
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> GetUseModifyCostumePlan(); // 0x06b4e7c8
	System.String GetSkinShareCount(WizardGames.Soc.Common.Data.resource.ENUMSkinType skinType, System.Boolean isNewGet); // 0x06b4ea4c
	System.Int32 GetSkinTypeCount(WizardGames.Soc.Common.Data.resource.ENUMSkinType skinType); // 0x06b4ec30
	System.Boolean IsCostumeOwned(System.Int32 id); // 0x06b4ef40
	WizardGames.Soc.SocClient.Manager.CommonSkinData GetCostumeData(System.Int64 constumeId); // 0x06b4f0d0
	System.Void SetNoSkinNew(System.Int32 skinId); // 0x06b4f1ac
	System.Boolean GetIsSkinNew(System.Int32 skinId); // 0x06b4f2ec
	System.Void WearCostume(System.Int32 part, System.Int32 skinId, System.Collections.Generic.Dictionary<System.Int32,System.Int32> planDic); // 0x06b4f400
	System.Void UnwearCostume(System.Int32 part, System.Collections.Generic.Dictionary<System.Int32,System.Int32> planDic); // 0x06b4f97c
	System.Void SetCostumeOnChangeSex(System.Int32 sex, System.Collections.Generic.Dictionary<System.Int32,System.Int32> costumeDic); // 0x06b4fa80
	System.Void OnChangeRole(); // 0x06b4fe2c
	System.Boolean CheckCostumeWear(System.Int32 skinId, System.Int32 sex); // 0x06b50250
	System.Int32 GetPlanSex(System.Int32 curChosePlanId); // 0x06b50370
	System.Int32 GetPlanSexByDic(System.Collections.Generic.Dictionary<System.Int32,System.Int32> dic); // 0x06b504a8
	System.Void WearEquip(System.Int32 part, System.Int32 skinId, System.Collections.Generic.Dictionary<System.Int32,System.Int32> planDic); // 0x06b506f8
	System.Void UnwearEquipSkin(System.Int32 part, System.Collections.Generic.Dictionary<System.Int32,System.Int32> planDic); // 0x06b50cac
	System.Void CheckIsShowHideHeadTip(System.Int32 skinId); // 0x06b50db0
	System.Void OverridePlan(System.Int32 newPlan, System.Int32 oldPlan); // 0x06b50f70
	System.Void OverridePlan(System.Collections.Generic.Dictionary<System.Int32,System.Int32> newPlanDic, System.Collections.Generic.Dictionary<System.Int32,System.Int32> oldPlanDic); // 0x06b51f48
	System.Boolean CheckEquipIsWear(System.Int32 skinId, System.Collections.Generic.Dictionary<System.Int32,System.Int32> planDic); // 0x06b52174
	System.Boolean CheckCustomIsWear(System.Int32 skinId, System.Collections.Generic.Dictionary<System.Int32,System.Int32> planDic); // 0x06b5234c
	System.Boolean CheckIsCollect(System.Int32 skinId); // 0x06b524f4
	System.Boolean PartIsBeOvrride(System.Int32 part, System.Collections.Generic.Dictionary<System.Int32,System.Int32> value, System.Boolean isEquip); // 0x06b52584
	System.Int64 PartIsLowWeight(System.Int32 partSkinId, System.Boolean partIsEquip, System.Collections.Generic.Dictionary<System.Int32,System.Int32> targetDic); // 0x06b52a38
	System.String GetPlanDefaultIcon(System.Int32 part, System.Collections.Generic.Dictionary<System.Int32,System.Int32> plan, System.Boolean isCoustume); // 0x06b530f4
	System.Boolean CheckShowTime(System.Int32 resourceId); // 0x06b53630
	System.Boolean CheckAfterFirstTime(System.Int32 resourceId); // 0x06b53868
	System.Boolean CheckIsShowSkin(System.Int32 id); // 0x06b53ac4
	System.Collections.Generic.List<System.Int64> GetSparayList(); // 0x06b53c44
	System.Collections.Generic.List<System.Int64> GetGestureList(); // 0x06b53f08
	WizardGames.Soc.SocClient.Manager.CommonSkinData GetAllTypeSkinData(System.Int32 skinId); // 0x06b3b284
	System.Boolean CheckCanJump(System.Int32 skinId); // 0x06b541cc
	System.Void JumpBySkinId(System.Int32 skinId); // 0x06b54300
	System.Void AddNewGetSkinId(WizardGames.Soc.Common.Data.resource.OBJSkin skinCfg); // 0x06b4ac1c
	System.Void ClearNewAddSkinList(System.Collections.Generic.List<System.Int32> skinList); // 0x06b54468
	System.Boolean HasNewAddArmorSkin(); // 0x06b4d318
	System.Boolean HasNewAddWeaponSkin(); // 0x06b4cd7c
	System.Boolean HasNewAddBuildSkin(); // 0x06b4d95c
	System.Int32 GetWearSuitId(System.Collections.Generic.List<System.Int64> skinList); // 0x06b544f8
	System.String GetLimitTime(System.Int32 endTime); // 0x06b5489c
	System.Void SetLimitWeight(WizardGames.Soc.SocClient.Manager.CommonSkinData skinData, System.Int32& weight); // 0x06b54978
	System.Void RequireAllSkinInfo(); // 0x06b47ef0
	System.Void PostUpdataPlan(System.Action callBack, System.Int32 planId); // 0x06b4fef8
	System.Void PostUpdataOption(System.Collections.Generic.Dictionary<System.Int32,System.Boolean> optionDic, System.Action callBack); // 0x06b54a70
	System.Void RequirePlayerAllCustomPlan(System.String roleId, System.Action<System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>>,System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>>> callback); // 0x06b54b54
	System.Void CheckCacheDataDead(); // 0x06b54d98
	System.Void PostSaveEmoteConfig(System.Collections.Generic.List<System.Int32> skinIds, WizardGames.Soc.Common.Data.resource.ENUMSkinType skinType); // 0x06b550e0
	System.Void OverrideCostumePlan(WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> costumePlan, System.Int32 sex); // 0x06b551c4
	System.Void GameWearCostume(System.Collections.Generic.List<System.Int32> costumeIds); // 0x06b552a0
	System.Void OnSkinEquipChange(SimpleJSON.JSONNode push); // 0x06b55a38
	System.Void ClearAutoEquipSkinIDs(); // 0x06b475a8
	System.Void .ctor(); // 0x06b56110
	static System.Void .cctor(); // 0x06b5673c
	System.Void <RefreshAcquiredResourcesInnteral>b__114_0(); // 0x06b56810
	System.Void <RefreshAcquiredResourcesInnteral>b__114_1(System.Int64 _, System.Object data, System.Boolean delete); // 0x06b568c0
	System.Void <RefreshAcquiredResourcesInnteral>b__114_2(); // 0x06b56a68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobbySkin.<>c__DisplayClass111_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrLobbySkin <>4__this; // 0x10
	System.Int64 skinId; // 0x18
	System.Action callback; // 0x20
	System.Void .ctor(); // 0x06b56be0
	System.Void <CollectSkin>b__0(System.Int64 starredTime); // 0x06b56c48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobbySkin.<>c__DisplayClass122_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrLobbySkin <>4__this; // 0x10
	System.Int64 hostItemId; // 0x18
	System.Int64 skinId; // 0x20
	System.Int64 equippedSkinId; // 0x28
	System.Action callback; // 0x30
	System.Void .ctor(); // 0x06b56d18
	System.Void <EquipSkin>b__0(); // 0x06b56d80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobbySkin.<>c__DisplayClass123_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrLobbySkin <>4__this; // 0x10
	System.Int64 hostItemId; // 0x18
	System.Int64 skinId; // 0x20
	System.Action callback; // 0x28
	System.Void .ctor(); // 0x06b56e14
	System.Void <UnequipSkin>b__0(); // 0x06b56e7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobbySkin.<>c__DisplayClass124_0 : System.Object
{
	System.Boolean cancel; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x06b56f0c
	System.Void <EquipBuildSkin>b__0(); // 0x06b56f74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobbySkin.<>c__DisplayClass204_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrLobbySkin <>4__this; // 0x10
	System.String roleId; // 0x18
	System.Action<System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>>,System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>>> callback; // 0x20
	System.Void .ctor(); // 0x06b570a8
	System.Void <RequirePlayerAllCustomPlan>b__0(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> allCostumePlan, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> allEquipPlan); // 0x06b57110
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.ERewardPopFlag : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.ERewardPopFlag Normal = 0;
	static WizardGames.Soc.SocClient.Manager.ERewardPopFlag DelayPop = 1;
	static WizardGames.Soc.SocClient.Manager.ERewardPopFlag Drop = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrSkinPreview : WizardGames.Soc.Common.Manager.MgrBase
{
	
	WizardGames.Soc.SocClient.Manager.SkinPreviewData GetPreviewData(System.Int32 id, WizardGames.Soc.SocClient.Manager.MgrSkinPreview.ESkinPreviewType previewType); // 0x06b5724c
	WizardGames.Soc.SocClient.Manager.SkinPreviewData GetPreviewData(System.Int32 id, System.Int32 charmSkinId, WizardGames.Soc.SocClient.Manager.MgrSkinPreview.ESkinPreviewType previewType); // 0x06b575b4
	WizardGames.Soc.SocClient.Manager.SkinPreviewData GetGeneratePreviewData(System.Int32 id); // 0x06b57308
	WizardGames.Soc.SocClient.Manager.SkinPreviewData GetItemPreivewData(System.Int32 id); // 0x06b57478
	WizardGames.Soc.SocClient.Manager.SkinPreviewData GetSkinPreviewData(System.Int32 skinId); // 0x06b57680
	WizardGames.Soc.SocClient.Manager.SkinPreviewData GetFixSuitSkinPreviewData(System.Int32 id); // 0x06b57a68
	WizardGames.Soc.SocClient.Manager.SkinPreviewData GetGenerateData(WizardGames.Soc.Common.Data.resource.OBJGenaral gen); // 0x06b57d60
	WizardGames.Soc.SocClient.Manager.SkinPreviewData GetSkinDefaultData(System.Int32 itemId); // 0x06b57e64
	System.Void .ctor(); // 0x06b580cc
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.MgrSkinPreview.ESkinPreviewType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.MgrSkinPreview.ESkinPreviewType Generate = 0;
	static WizardGames.Soc.SocClient.Manager.MgrSkinPreview.ESkinPreviewType Item = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.SkinPreviewData : System.Object
{
	System.Int32 skinId; // 0x10
	System.Int32 charmSkinId; // 0x14
	System.String skinName; // 0x18
	System.String skinDesc; // 0x20
	System.String skinIcon; // 0x28
	System.String modelPath; // 0x30
	System.Int32 rarity; // 0x38
	System.Boolean isLock; // 0x3c
	System.Boolean isGot; // 0x3d
	System.Int32 giftId; // 0x40
	WizardGames.Soc.Common.Data.resource.OBJSkin skinCfg; // 0x48
	System.Boolean isShowEquip; // 0x50
	System.String tagTitle; // 0x58
	WizardGames.Soc.Common.Data.resource.OBJSkin GetSkinCfg(); // 0x06b58134
	System.Void .ctor(); // 0x06b58030
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobbyStash : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.LobbyStashIPropData> propDataList; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.LobbyStashProfileData> profileDataList; // 0x20
	System.Boolean reqProfileData; // 0x28
	System.Collections.Generic.HashSet<System.Int32> skipResGetPopup; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardData> rewardDataList; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardData> decomposeRewardDataList; // 0x40
	WizardGames.Soc.SocClient.Manager.EResReasonType resReasonType; // 0x48
	System.Void Init(); // 0x06b58250
	System.Void OnAccountEnterLobby(); // 0x06b583b8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.LobbyStashIPropData> GetPropDataList(); // 0x06b58964
	System.Boolean HasSkinInExperienceCard(System.Int32 rid); // 0x06b589c8
	System.Boolean IsExperienceCard(System.Int32 rid); // 0x06b58b7c
	System.Boolean IsSkinShard(System.Int32 rid); // 0x06b58c9c
	System.Boolean IsSkinShardAllSkinOwned(System.Int32 rid); // 0x06b58da8
	System.Int32 GetPropAmountByRID(System.Int32 rid); // 0x06b58fb0
	WizardGames.Soc.SocClient.Ui.LobbyStashIPropData GetPropDataByUniqueID(System.String uniqueID); // 0x06b59158
	System.Boolean IsShowLobbyStashRedDot(); // 0x06b592e0
	System.Boolean IsShowLobbyPlayerRedDot(); // 0x06b593b4
	System.Boolean IsShowLobbyHeadIconRedDot(); // 0x06b59658
	System.Boolean IsShowLobbyHeadFrameRedDot(); // 0x06b59918
	System.Boolean IsShowLobbyNameCardRedDot(); // 0x06b59b1c
	System.Boolean IsShowLobbyChatBgRedDot(); // 0x06b59d20
	System.Boolean IsShowLobbyPersonalTagRedDot(); // 0x06b59f24
	System.Boolean IsFromLottery(); // 0x06b5a128
	System.Void ReqDecompose(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.ExchangeResource> decomposeList, System.Action callback); // 0x06b5a1a8
	System.Void ReqExchangeskin(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Int32 srcID, System.Int32 targetID, System.Action callback); // 0x06b5a67c
	System.Void ReqResourceUse(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Int32 amount, System.String reason, System.Int32 rid, System.String uniqueID, System.Action callback); // 0x06b5aa40
	System.Void ReqResourceUse(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Int32 rid, System.Action callback); // 0x06b5ae8c
	System.Void ReqPullProppack(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action callback); // 0x06b5843c
	System.String GenerateSaveKey(System.String uniqueID); // 0x06b5b274
	System.String GenerateSaveKey(System.Int32 id); // 0x06b5b340
	System.Void ReqPullProfilepack(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule); // 0x06b586f8
	System.Boolean CheckResDefaultRedDot(System.Int32 id); // 0x06b5b40c
	System.Boolean OwnProfile(System.Int32 id); // 0x06b5b8bc
	System.Boolean OwnProfileRed(System.Int32 id); // 0x06b5985c
	WizardGames.Soc.SocClient.Ui.LobbyStashProfileData GetProfileData(System.Int32 id); // 0x06b5b984
	System.Void ClearOwnProfileRed(System.Int32 id); // 0x06b5b774
	System.Boolean CheckResPopupSkip(System.Int32 resID); // 0x06b5ba30
	System.Void OnRefreshAcquiredResources(SimpleJSON.JSONArray acquiredResources); // 0x06b5bb38
	System.Void OnRefreshLobbyProppackData(SimpleJSON.JSONArray proppackArray); // 0x06b5c9c4
	System.Boolean IsExistHighBonusCardInFixGift(System.Int32 fixGiftId); // 0x06b5d26c
	System.Void OnAccountLogined(); // 0x06b5d518
	System.Void .ctor(); // 0x06b5d5a4
	static System.Void .cctor(); // 0x06b5d784
	System.Void <ReqPullProfilepack>b__34_0(SimpleJSON.JSONNode jsonData); // 0x06b5d858
	System.Void <OnRefreshAcquiredResources>b__43_0(WizardGames.Soc.SocClient.Ui.UiCommonRewardDrawPop win); // 0x06b5dbac
	System.Void <OnRefreshAcquiredResources>b__43_1(WizardGames.Soc.SocClient.Ui.UiCommonRewardPop win); // 0x06b5dc34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobbyStash.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Manager.MgrLobbyStash.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__27_1; // 0x8
	static System.Action<SimpleJSON.JSONNode> <>9__28_1; // 0x10
	static System.Action<SimpleJSON.JSONNode> <>9__29_1; // 0x18
	static System.Action<SimpleJSON.JSONNode> <>9__30_1; // 0x20
	static System.Action<SimpleJSON.JSONNode> <>9__31_1; // 0x28
	static System.Action<SimpleJSON.JSONNode> <>9__34_1; // 0x30
	static System.Void .cctor(); // 0x06b5dcd4
	System.Void .ctor(); // 0x06b5dd38
	System.Void <ReqDecompose>b__27_1(SimpleJSON.JSONNode error); // 0x06b5dda0
	System.Void <ReqExchangeskin>b__28_1(SimpleJSON.JSONNode error); // 0x06b5de68
	System.Void <ReqResourceUse>b__29_1(SimpleJSON.JSONNode error); // 0x06b5df30
	System.Void <ReqResourceUse>b__30_1(SimpleJSON.JSONNode error); // 0x06b5dff8
	System.Void <ReqPullProppack>b__31_1(SimpleJSON.JSONNode error); // 0x06b5e06c
	System.Void <ReqPullProfilepack>b__34_1(SimpleJSON.JSONNode error); // 0x06b5e0e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobbyStash.<>c__DisplayClass27_0 : System.Object
{
	System.Action callback; // 0x10
	System.Void .ctor(); // 0x06b5a614
	System.Void <ReqDecompose>b__0(SimpleJSON.JSONNode node); // 0x06b5e154
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobbyStash.<>c__DisplayClass28_0 : System.Object
{
	System.Action callback; // 0x10
	System.Void .ctor(); // 0x06b5a9d8
	System.Void <ReqExchangeskin>b__0(SimpleJSON.JSONNode node); // 0x06b5e1ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobbyStash.<>c__DisplayClass29_0 : System.Object
{
	System.Action callback; // 0x10
	System.Void .ctor(); // 0x06b5ae24
	System.Void <ReqResourceUse>b__0(SimpleJSON.JSONNode node); // 0x06b5e284
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobbyStash.<>c__DisplayClass30_0 : System.Object
{
	System.Action callback; // 0x10
	System.Void .ctor(); // 0x06b5b1a4
	System.Void <ReqResourceUse>b__0(SimpleJSON.JSONNode node); // 0x06b5e31c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobbyStash.<>c__DisplayClass31_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrLobbyStash <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x06b5b20c
	System.Void <ReqPullProppack>b__0(SimpleJSON.JSONNode jsonData); // 0x06b5e3b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobbyStash.<>c__DisplayClass44_0 : System.Object
{
	System.String uniqueID; // 0x10
	System.Void .ctor(); // 0x06b5d204
	System.Boolean <OnRefreshLobbyProppackData>b__0(WizardGames.Soc.SocClient.Ui.LobbyStashIPropData x); // 0x06b5e818
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.ExchangeResource : System.Object
{
	System.Int32 rid; // 0x10
	System.Int32 amount; // 0x14
	System.Void .ctor(); // 0x06b5e8e4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.EResReasonType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.EResReasonType None = 0;
	static WizardGames.Soc.SocClient.Manager.EResReasonType Lottery = 1;
	static WizardGames.Soc.SocClient.Manager.EResReasonType TenLottery = 2;
	static WizardGames.Soc.SocClient.Manager.EResReasonType Lottery_2 = 3;
	static WizardGames.Soc.SocClient.Manager.EResReasonType TenLottery_2 = 4;
	static WizardGames.Soc.SocClient.Manager.EResReasonType talent = 5;
	static WizardGames.Soc.SocClient.Manager.EResReasonType decompose = 6;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMedal : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger log; // 0x0
	System.Collections.Generic.Dictionary<System.String,System.String> requestParam; // 0x18
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.String>> requestArraryParam; // 0x20
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Manager.StyleMedalLevelCountInfo> allStyleMedalCountMap; // 0x28
	WizardGames.Soc.Common.CustomType.MedalTaskContainer medalContainer; // 0x30
	System.Collections.Generic.HashSet<System.Int64> inProgressMedalTaskLst; // 0x38
	System.Collections.Generic.HashSet<System.Int64> notGetMedalTaskLst; // 0x40
	System.Collections.Generic.HashSet<System.Int64> completeMedalTaskLst; // 0x48
	System.Collections.Generic.HashSet<System.Int64> failedMedalTaskLst; // 0x50
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> inProgressAppearMedalTaskCountMap; // 0x58
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.HashSet<System.Int32>> medalLevelMap; // 0x60
	System.Collections.Generic.Dictionary<System.Int64,System.ValueTuple<System.Int32,System.Int32>> mainTaskMedalMap; // 0x68
	System.Collections.Generic.List<System.Int64> completeMedalTaskIds; // 0x70
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> styleRedDotMap; // 0x78
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> styleRankMap; // 0x80
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> styleScoreMap; // 0x88
	System.String openBattleServerID; // 0x90
	System.Int64 lastSwitchTime; // 0x98
	System.Int32 teamSizeInGame; // 0xa0
	System.Int32 gameModeId; // 0xa4
	System.Boolean HasRankPoint; // 0xa8
	System.Single[] thresholds; // 0xb0
	System.Boolean get_ConditionUnlock(); // 0x06b5e94c
	System.Int32 get_GameModePlayId(); // 0x06b5ea08
	System.Void CleanUp(); // 0x06b5eb00
	System.Void OnAccountLogout(); // 0x06b5ecb0
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06b5ee4c
	System.Threading.Tasks.Task OnExitWorld(); // 0x06b5ef50
	System.Boolean IsOpenRankMedal(); // 0x06b5f138
	System.Void OnReputationLevelChange(); // 0x06b5f264
	System.Void OnAccountEnterLobby(); // 0x06b5f6a4
	System.Void GetStyleMedalLevelCount(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Int32 styleId, System.String roleId, System.Action<System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Manager.StyleMedalLevelCountInfo>> callback); // 0x06b5f898
	System.Void GetStyleMedalLevelCount(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Collections.Generic.List<System.Int32> styleIds, System.String roleId, System.Action<System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Manager.StyleMedalLevelCountInfo>> callback); // 0x06b5f9f0
	System.Void GetSettleStyleRankPointsSwitch(); // 0x06b5f708
	System.Void SetSettleStyleRankPointsSwitch(System.String openBattleServerID); // 0x06b5fe6c
	System.Void DelSettleStyleRankPointsSwitch(System.String openBattleServerID); // 0x06b60148
	System.Void CreateMedalReconstructData(); // 0x06b60380
	System.Int32 GetMedalLevelRankPoint(System.Int32 medalId, System.Int32 level); // 0x06b607f4
	System.Int64 GetMedalLevelMainTaskId(System.Int32 medalId, System.Int32 level); // 0x06b6095c
	System.Void InitMedalTask(WizardGames.Soc.Common.CustomType.SystemRootNode systemRoot); // 0x06b60ab8
	WizardGames.Soc.SocClient.EDailyMissionState GetMedalTaskState(System.Int64 id); // 0x06b62aa0
	System.Void GetMedalCompletedTaskInfo(); // 0x06b62708
	System.Void RefreshInProgressMedalTask(); // 0x06b62bac
	System.Void ShowInProgressMedalTip(System.Int64 mainTaskId, System.Int64 subTaskId, System.Int32 count); // 0x06b63300
	System.Void RefreshNotGetMedalTask(); // 0x06b63910
	System.Void RefreshFailedMedalTask(); // 0x06b642f4
	System.Boolean IsMedalUnlock(System.Int32 medalId); // 0x06b636c0
	System.Void ShowFailedMedalTip(System.Int64 mainTaskId, System.Int64 subTaskId); // 0x06b64a80
	System.Void RefreshCompleteMedalTask(); // 0x06b64afc
	WizardGames.Soc.SocClient.Manager.StyleMedalLevelCountInfo GetStyleMedalMaxLevelFromCache(System.Int32 styleId); // 0x06b64f98
	WizardGames.Soc.Common.Data.Play.OBJStyleRank GetMedalRankId(System.Int32 point); // 0x06b6504c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MedalData_Game> GetAllRankMeals(); // 0x06b651dc
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.OBJGroupMedal> GetRankMealsByStyleId(System.Int32 styleId); // 0x06b657f0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.OBJGroupMedal_Lobby> GetLobbyRankMealsByStyleId(System.Int32 styleId, WizardGames.Soc.SocClient.Manager.StyleMedalLevelCountInfo styleMadlLevelCountInfo); // 0x06b660a0
	System.Collections.Generic.List<System.Int64> GetAllTasks(System.Int64 taskId); // 0x06b669e4
	System.String GetLeftMedalSyncTime(); // 0x06b66c2c
	System.Void OnPushMedalLevelChange(SimpleJSON.JSONNode push); // 0x06b66f00
	System.Boolean IsNeedPlayUnlocedMedalTrans(System.Int32 medalId, System.Int32 level); // 0x06b67410
	System.Void SavenlocedMedalTrans(System.Int32 medalId, System.Int32 level); // 0x06b67558
	System.Collections.Generic.List<System.Int32> GetStyleMedalNum(System.Int32 styleId); // 0x06b6769c
	System.Collections.Generic.List<System.Int32> GetStyleMedalNum(WizardGames.Soc.SocClient.Manager.StyleMedalLevelCountInfo styleMedalLevelCountInfo); // 0x06b67954
	System.Boolean IsShowStyle1001RedDot(); // 0x06b67bd4
	System.Boolean IsShowStyle1002RedDot(); // 0x06b67ce8
	System.Boolean IsShowStyle1003RedDot(); // 0x06b67d50
	System.Boolean IsShowStyle1004RedDot(); // 0x06b67db8
	System.Boolean IsShowStyle1005RedDot(); // 0x06b67e20
	System.Boolean IsShowMedalStyleRedDot(System.Int32 styleId); // 0x06b67c3c
	System.Void RefreshStyleRedDot(); // 0x06b5f2c8
	WizardGames.Soc.SocClient.Ui.RedDotType GetStyleRedDotType(System.Int32 styleId); // 0x06b67f48
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.OBJMedal> GetMedalAllLevelCfg(System.Int32 medalId); // 0x06b67fcc
	System.Void .ctor(); // 0x06b68300
	static System.Void .cctor(); // 0x06b68774
	System.Void <GetSettleStyleRankPointsSwitch>b__37_0(SimpleJSON.JSONNode res); // 0x06b68848
	System.Void <DelSettleStyleRankPointsSwitch>b__39_0(SimpleJSON.JSONNode res); // 0x06b6898c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMedal.<>c__DisplayClass35_0 : System.Object
{
	System.Collections.Generic.List<System.Int32> styleIds; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrMedal <>4__this; // 0x18
	System.Action<System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Manager.StyleMedalLevelCountInfo>> callback; // 0x20
	System.Void .ctor(); // 0x06b5fe04
	System.Void <GetStyleMedalLevelCount>b__0(SimpleJSON.JSONNode res); // 0x06b68a64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMedal.<>c__DisplayClass38_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrMedal <>4__this; // 0x10
	System.String openBattleServerID; // 0x18
	System.Void .ctor(); // 0x06b600e0
	System.Void <SetSettleStyleRankPointsSwitch>b__0(SimpleJSON.JSONNode res); // 0x06b693b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.StyleMedalLevelCountInfo : System.Object
{
	System.Int32 styleId; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MedalLevelCountInfo> medalLevelCountInfos; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> medalCountByLevel; // 0x20
	System.Void .ctor(System.Int32 styleId); // 0x06b68fa4
	System.Void .ctor(SimpleJSON.JSONNode styleMedalNode); // 0x06b690c4
	System.Void CalMedalCountByLevel(); // 0x06b694cc
	System.Int32 GetMedalCount(System.Int32 medalId, System.Int32 level); // 0x06b66698
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MedalLevelCountInfo : System.Object
{
	System.Int32 medalID; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> medalLevelCountMap; // 0x18
	System.Void .ctor(SimpleJSON.JSONNode madelLevelNode); // 0x06b6976c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.OBJGroupMedal : System.Object
{
	WizardGames.Soc.Common.Data.medal.ENUMType type; // 0x10
	System.Collections.Generic.List<System.Int32> medalsList; // 0x18
	WizardGames.Soc.Common.Data.Play.OBJMedalUnlock medalUnlockConfig; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MedalData_Game> medalDataList; // 0x28
	System.Void .ctor(WizardGames.Soc.Common.Data.medal.ENUMType type, System.Collections.Generic.List<System.Int32> medalsList); // 0x06b65d3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MedalData_Game : System.Object
{
	System.Int32 medalId; // 0x10
	System.Int32 maxLevel; // 0x14
	WizardGames.Soc.Common.Data.Play.OBJMedalUnlock medalUnlockConfig; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MedalLevelData_Game> levelDatas; // 0x20
	System.Boolean haveRedDot; // 0x28
	System.Boolean get_HaveRedDot(); // 0x06b67e88
	System.Void .ctor(System.Int32 medalId, WizardGames.Soc.Common.Data.Play.OBJMedalUnlock medalUnlockConfig); // 0x06b65554
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MedalLevelData_Game : System.Object
{
	WizardGames.Soc.Common.Data.Play.OBJMedal config; // 0x10
	WizardGames.Soc.Common.Data.Play.OBJMedalUnlock medalUnlockConfig; // 0x18
	System.Boolean canGetReward; // 0x20
	System.Boolean received; // 0x21
	System.Boolean get_HaveRedDot(); // 0x06b69c30
	System.Void .ctor(WizardGames.Soc.Common.Data.Play.OBJMedal config, WizardGames.Soc.Common.Data.Play.OBJMedalUnlock medalUnlockConfig); // 0x06b699a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.OBJGroupMedal_Lobby : System.Object
{
	WizardGames.Soc.Common.Data.medal.ENUMType type; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.OneMedalData> medalsList; // 0x18
	WizardGames.Soc.Common.Data.Play.OBJMedalUnlock medalUnlockConfig; // 0x20
	System.Void .ctor(WizardGames.Soc.Common.Data.medal.ENUMType type, System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.OneMedalData> medalsList); // 0x06b667e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.OneMedalData : System.Object
{
	WizardGames.Soc.Common.Data.Play.OBJMedal medalCfg; // 0x10
	System.Int32 count; // 0x18
	System.Void .ctor(); // 0x06b66630
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.EMedalTaskMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.EMedalTaskMode Two = 2;
	static WizardGames.Soc.SocClient.Manager.EMedalTaskMode Four = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildItemNode : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger Logger; // 0x0
	WizardGames.Soc.SocClient.Construction.BuildItemNode Parent; // 0x10
	WizardGames.Soc.Common.Entity.PartEntity PartEntity; // 0x18
	System.Int64 PartId; // 0x20
	UnityEngine.Vector3 Position; // 0x28
	System.Int32 GCost; // 0x34
	System.Int32 HCost; // 0x38
	WizardGames.Soc.SocClient.Construction.EBuildNodeType nodeType; // 0x3c
	System.Boolean isWallFrame; // 0x40
	System.Collections.Generic.List<UnityEngine.Vector3> frontFacePoints; // 0x48
	System.Collections.Generic.List<UnityEngine.Vector3> backFacePoints; // 0x50
	System.Collections.Generic.List<UnityEngine.Vector3> PathPoints; // 0x58
	UnityEngine.Vector3 InPoint; // 0x60
	UnityEngine.Vector3 OutPoint; // 0x6c
	System.Int32 get_FCost(); // 0x06b69cf8
	System.Void SetData(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06b69d60
	WizardGames.Soc.Common.Unity.Construction.TemplateGoConfig GetTemplateGoConfig(); // 0x06b6af08
	UnityEngine.Vector3[] GetBoundsCorners(WizardGames.Soc.Common.Framework.Algorithm.Bounds bounds); // 0x06b6afb0
	UnityEngine.Vector3 GetNearestPoint(System.Boolean isFront, UnityEngine.Vector3 targetPos); // 0x06b6b494
	System.Boolean NearestFaceIsFront(UnityEngine.Vector3 targetPos); // 0x06b6b760
	System.ValueTuple<System.Boolean,UnityEngine.Vector3> GetNearestPoint(UnityEngine.Vector3 targetPos); // 0x06b6b808
	System.Void FindPathPoint(UnityEngine.Vector3 endPos); // 0x06b6bbfc
	System.Void GetPartBoundsPoint(); // 0x06b69f4c
	System.Void OnGet(); // 0x06b6c940
	System.Void OnRelease(); // 0x06b6ca94
	System.Void OnDestroy(); // 0x06b6caf4
	System.Void .ctor(); // 0x06b6cb54
	static System.Void .cctor(); // 0x06b6cc08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.ConstructionEffectPlay : System.Object
{
	static SocLogger Logger; // 0x0
	System.Int64 partTemplateId; // 0x10
	System.Int64 partEntityId; // 0x18
	System.Int64 skinId; // 0x20
	System.Collections.Generic.Dictionary<System.Int32,Effect.EffectItemHandle<Effect.EffectItem>> effectItemHandleDic; // 0x28
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.ClientLight.LightItem> LightItemDic; // 0x30
	UnityEngine.Transform trans; // 0x38
	System.Void .ctor(System.Int64 templateId, System.Int64 entityId, UnityEngine.Transform transform); // 0x06b6ccdc
	System.Void .ctor(); // 0x06b6ce20
	System.Void SetTargetPartEntity(WizardGames.Soc.Common.Entity.PartEntity partEntity, System.Boolean isFollowSocket); // 0x06b6cf2c
	System.Void Play(System.Boolean isOn, System.Boolean addLight); // 0x06b6d198
	System.ValueTuple<System.Int32[],System.Int32[]> GetConstructionConfig(); // 0x06b6d9fc
	System.Void StopEffectsAndLights(); // 0x06b6d670
	System.Void LoadEffectCompleted(System.Boolean success, Effect.EffectItem effectItem, System.Object obj); // 0x06b6dbb4
	System.Void ManualUpdateFollow(); // 0x06b6dd1c
	static System.Void .cctor(); // 0x06b6dd7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.PoweredLightsTool : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Construction.BuildMode.BuildChristmasLightMode curBuildMode; // 0x10
	System.Single maxPlaceDistance; // 0x18
	System.Single lengthPerAmount; // 0x1c
	System.Single nextClickTime; // 0x20
	System.Single lineThickness; // 0x24
	System.Boolean <CanDeploy>k__BackingField; // 0x28
	UnityEngine.Vector3 targetPos; // 0x2c
	UnityEngine.Vector3 targetNormal; // 0x38
	UnityEngine.Ray viewRay; // 0x44
	System.Boolean get_CanDeploy(); // 0x06b6de50
	System.Void set_CanDeploy(System.Boolean value); // 0x06b6deb4
	WizardGames.Soc.Common.Component.ElectricChristmasLightComponent get_curModule(); // 0x06b6df30
	static WizardGames.Soc.SocClient.Construction.PoweredLightsTool Create(WizardGames.Soc.SocClient.Construction.BuildMode.BuildChristmasLightMode buildMode); // 0x06b6dfa0
	System.Void Init(WizardGames.Soc.SocClient.Construction.BuildMode.BuildChristmasLightMode buildMode); // 0x06b6e108
	System.Void Update(); // 0x06b6e188
	System.Void OnClickDeploy(); // 0x06b6ea04
	System.Void OnClickFinishDeploy(); // 0x06b6f074
	System.Void RequestCreatePart(System.Int64 itemUid); // 0x06b6ec44
	System.Void ClearDeployInfo(); // 0x06b6f0d8
	System.Void .ctor(); // 0x06b6e088
	static System.Void .cctor(); // 0x06b6f1d4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Construction.EDeploySocketType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Construction.EDeploySocketType Foundation = 0;
	static WizardGames.Soc.SocClient.Construction.EDeploySocketType Wall = 1;
	static WizardGames.Soc.SocClient.Construction.EDeploySocketType Ceiling = 2;
	static WizardGames.Soc.SocClient.Construction.EDeploySocketType Floor = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.WireAutoTool : System.Object
{
	static SocLogger logger; // 0x0
	static System.Random random; // 0x8
	System.Boolean wireDebug; // 0x10
	WizardGames.Soc.SocClient.Construction.ConnectionInfo connectionInfoFrom; // 0x18
	WizardGames.Soc.SocClient.Construction.ConnectionInfo connectionInfoTo; // 0x20
	WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug fromPlug; // 0x28
	WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug toPlug; // 0x48
	System.Collections.Generic.List<UnityEngine.Vector3> tempList; // 0x68
	System.Single rayLength; // 0x70
	System.Single socketPartHeightThreshold; // 0x74
	System.Boolean fullAutomatic; // 0x78
	System.Single detectionBoxScale; // 0x7c
	System.Single nodeOffset; // 0x80
	UnityEngine.Collider[] colliderBuffer; // 0x88
	UnityEngine.Vector3[] directions; // 0x90
	static System.Collections.Generic.List<UnityEngine.Vector3> tempPositions; // 0x10
	static System.Collections.Generic.List<WizardGames.Soc.Common.Construction.PartType> FoundationTypes; // 0x18
	static System.Collections.Generic.List<WizardGames.Soc.Common.Construction.PartType> WallTypes; // 0x20
	static System.Collections.Generic.List<WizardGames.Soc.Common.Construction.PartType> FloorTypes; // 0x28
	static System.Collections.Generic.List<WizardGames.Soc.Common.Construction.PartType> WallFrameTypes; // 0x30
	WizardGames.Soc.SocClient.Construction.WirePathFindTool wirePathFindTool; // 0x98
	System.Single get_detectionOffsetDis(); // 0x06b6f2a8
	System.Boolean CanConnect(UnityEngine.Vector3 srcPoint, UnityEngine.Vector3 tarPoint, System.Int32 maxLimit); // 0x06b6f368
	System.Boolean CanConnectHalfAuto(WizardGames.Soc.SocClient.Construction.ConnectionInfo from, UnityEngine.Vector3 tarPoint); // 0x06b6f4a4
	System.Boolean TryFindConnectionPoint(WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug fromPendingPlug, WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug toPendingPlug, UnityEngine.Vector3[] manualPoints); // 0x06b6fa84
	System.Boolean HalfAutoFindLineNode(); // 0x06b70944
	System.Boolean AutoFindLineNode(); // 0x06b6fee0
	System.Boolean IsElectricComponent(System.Int64 itemTempId); // 0x06b73e30
	System.Boolean InitConnectionInfo(WizardGames.Soc.SocClient.Construction.ConnectionInfo connectionInfo, WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug plug); // 0x06b6fd0c
	System.Boolean AddStartSlotPoint(WizardGames.Soc.SocClient.Construction.ConnectionInfo connectionInfo, WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug plug); // 0x06b70b54
	System.Void AddInitOffsetPoint(WizardGames.Soc.SocClient.Construction.ConnectionInfo connectionInfo, UnityEngine.Vector3 startPos); // 0x06b70eb8
	System.Void AddRightAnglePoint(System.Boolean isWallType); // 0x06b72528
	System.Boolean IsWallConnection(WizardGames.Soc.Common.Entity.PartEntity partGo1, WizardGames.Soc.Common.Entity.PartEntity partGo2); // 0x06b720d8
	UnityEngine.Vector3[] GetAllLineNode(); // 0x06b74160
	System.Boolean FindSocketNode(WizardGames.Soc.SocClient.Construction.ConnectionInfo connectionInfo, UnityEngine.Vector3 targetPos); // 0x06b7286c
	System.Void FindSocketPartGo(WizardGames.Soc.SocClient.Construction.ConnectionInfo connectionInfo); // 0x06b71864
	System.Void FindSocketPartGoForLineNode(WizardGames.Soc.SocClient.Construction.ConnectionInfo connectionInfo); // 0x06b71428
	WizardGames.Soc.Common.Entity.PartEntity GetPartEntityByCollider(UnityEngine.Collider collider); // 0x06b73f44
	System.Boolean GetHitPoints(UnityEngine.Vector3 origin, UnityEngine.Vector3 direct, UnityEngine.Vector3& hitPoint, System.Single maxDistance, UnityEngine.Vector3 targetPos); // 0x06b74448
	System.Void .ctor(); // 0x06b74cb4
	static System.Void .cctor(); // 0x06b752fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.ConnectionInfo : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Component.ElectricBaseComponent BaseModule; // 0x10
	UnityEngine.Vector3 SocketPartGoCheckPos; // 0x18
	WizardGames.Soc.Common.Entity.PartEntity PartEntity; // 0x28
	WizardGames.Soc.SocClient.Construction.EDeploySocketType DeploySocketType; // 0x30
	System.Collections.Generic.List<UnityEngine.Vector3> LineNodes; // 0x38
	System.Boolean IsFindSocketPoint; // 0x40
	System.Single offsetHeight; // 0x44
	UnityEngine.Vector3 get_SlotPosition(); // 0x06b74bd0
	System.Void .ctor(); // 0x06b75030
	System.Boolean get_IsOnCeiling(); // 0x06b75a48
	System.Boolean get_IsOnGround(); // 0x06b74b48
	System.Boolean get_IsOnWall(); // 0x06b71ff0
	System.Boolean IsDeploySocketType(WizardGames.Soc.SocClient.Construction.EDeploySocketType deploySocketType); // 0x06b72058
	System.Void AddNodePos(UnityEngine.Vector3 nodePos); // 0x06b70504
	System.Void AddNodePoints(System.Collections.Generic.List<UnityEngine.Vector3> pathPoints); // 0x06b75ab0
	UnityEngine.Vector3 LastNodePos(); // 0x06b70d8c
	UnityEngine.Vector3 GetRayOriginOffsetPos(); // 0x06b7431c
	System.Void SetInfo(WizardGames.Soc.Common.Component.ElectricBaseComponent baseModule); // 0x06b75b4c
	System.Void ResetInfo(); // 0x06b6fc1c
	static System.Void .cctor(); // 0x06b75bcc
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Construction.EBuildNodeType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Construction.EBuildNodeType Foundation = 0;
	static WizardGames.Soc.SocClient.Construction.EBuildNodeType Wall = 1;
	static WizardGames.Soc.SocClient.Construction.EBuildNodeType Floor = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.WirePathFindTool : System.Object
{
	static SocLogger Logger; // 0x0
	System.Collections.Generic.HashSet<System.Int64> wirePartTypeIdSet; // 0x10
	System.Collections.Generic.List<System.Int64> tempPartList; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Construction.BuildItemNode> tempPartNodeList; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Construction.BuildItemNode> pathNodeList; // 0x28
	static System.Collections.Generic.List<UnityEngine.GameObject> pointObjList; // 0x8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Construction.BuildItemNode> partNodeDic; // 0x30
	static UnityEngine.Material pathPointMat; // 0x10
	static System.Boolean DebugMode; // 0x18
	System.Void Init(); // 0x06b75ca0
	System.Void .ctor(); // 0x06b750f8
	WizardGames.Soc.SocClient.Construction.BuildItemNode GetBuildItemNode(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06b76078
	WizardGames.Soc.SocClient.Construction.BuildItemNode GetEmptyBuildItemNode(UnityEngine.Vector3 position); // 0x06b76240
	System.Boolean StartFindPath(WizardGames.Soc.SocClient.Construction.ConnectionInfo connectionInfoFrom, WizardGames.Soc.SocClient.Construction.ConnectionInfo connectionInfoTo); // 0x06b731c0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Construction.BuildItemNode> FindPathNode(WizardGames.Soc.SocClient.Construction.BuildItemNode startNode, WizardGames.Soc.SocClient.Construction.BuildItemNode targetNode); // 0x06b76334
	System.Int32 NodeSort(WizardGames.Soc.SocClient.Construction.BuildItemNode a, WizardGames.Soc.SocClient.Construction.BuildItemNode b); // 0x06b77554
	System.Int32 GetDistance(WizardGames.Soc.SocClient.Construction.BuildItemNode nodeA, WizardGames.Soc.SocClient.Construction.BuildItemNode nodeB); // 0x06b77438
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Construction.BuildItemNode> RetracePath(WizardGames.Soc.SocClient.Construction.BuildItemNode startNode, WizardGames.Soc.SocClient.Construction.BuildItemNode endNode); // 0x06b76b8c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Construction.BuildItemNode> GetNeighbors(WizardGames.Soc.SocClient.Construction.BuildItemNode node); // 0x06b76d64
	static UnityEngine.GameObject CreatePathPoint(UnityEngine.Vector3 position, System.Single scale, UnityEngine.PrimitiveType type, System.String name, UnityEngine.Color color); // 0x06b6c6dc
	static System.Void .cctor(); // 0x06b77648
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.WirePathPoint : UnityEngine.MonoBehaviour
{
	System.Boolean IsFront; // 0x30
	System.Void OnDrawGizmosSelected(); // 0x06b846c0
	System.Void .ctor(); // 0x06b8476c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.VirtualPartObj : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger Logger; // 0x0
	UnityEngine.GameObject MainGo; // 0x10
	System.Int64 <TemplateId>k__BackingField; // 0x18
	System.String <PrefabPath>k__BackingField; // 0x20
	UnityEngine.Vector3 <Position>k__BackingField; // 0x28
	UnityEngine.Vector3 <Rotation>k__BackingField; // 0x34
	System.UInt64 virtualGoLoadAsyncId; // 0x40
	System.Int64 get_TemplateId(); // 0x06b847dc
	System.Void set_TemplateId(System.Int64 value); // 0x06b84840
	System.String get_PrefabPath(); // 0x06b848b8
	System.Void set_PrefabPath(System.String value); // 0x06b8491c
	UnityEngine.Vector3 get_Position(); // 0x06b8499c
	System.Void set_Position(UnityEngine.Vector3 value); // 0x06b84a00
	UnityEngine.Vector3 get_Rotation(); // 0x06b84a98
	System.Void set_Rotation(UnityEngine.Vector3 value); // 0x06b84afc
	System.Void Init(WizardGames.Soc.SocClient.Manager.VirtualPartData data); // 0x06b84b94
	System.Void LoadVirtualPartFinish(UnityEngine.GameObject go); // 0x06b8511c
	System.Void OnGet(); // 0x06b852cc
	System.Void OnRelease(); // 0x06b854c0
	System.Void OnDestroy(); // 0x06b85630
	System.Void .ctor(); // 0x06b85694
	static System.Void .cctor(); // 0x06b856fc
	System.Void <Init>b__19_0(UnityEngine.GameObject go, System.Object[] objs); // 0x06b857d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BedGroup : WizardGames.Soc.SocClient.Construction.ConstructionScriptEditor
{
	WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_BedGroup configData; // 0x30
	System.Void SaveData(WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScriptNode node); // 0x06b859e4
	System.Void .ctor(); // 0x06b85a6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BonusChestId : WizardGames.Soc.SocClient.Construction.ConstructionScriptEditor
{
	WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_BonusChest configData; // 0x30
	System.Void SaveData(WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScriptNode node); // 0x06b85b38
	System.Void .ctor(); // 0x06b85bc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.ConstructionScriptEditor : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x06b85ad0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.GameplayData : WizardGames.Soc.SocClient.Construction.ConstructionScriptEditor
{
	WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_GameplayData configData; // 0x30
	System.Void SaveData(WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScriptNode node); // 0x06b85c24
	System.Void .ctor(); // 0x06b85cac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.OutDoorPartConfig : WizardGames.Soc.SocClient.Construction.ConstructionScriptEditor
{
	WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_OutDoorPartConfig configData; // 0x30
	System.Void SaveData(WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScriptNode node); // 0x06b85d10
	System.Void .ctor(); // 0x06b85d98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.RandomHp : WizardGames.Soc.SocClient.Construction.ConstructionScriptEditor
{
	WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_RandomHp configData; // 0x30
	System.Void SaveData(WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScriptNode node); // 0x06b85dfc
	System.Void .ctor(); // 0x06b85e84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.WallGroupConfig : WizardGames.Soc.SocClient.Construction.ConstructionScriptEditor, UnityEngine.ISerializationCallbackReceiver
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_WallGroupConfig configData; // 0x30
	System.Boolean isNecessary; // 0x38
	System.Single heightDelta; // 0x3c
	WizardGames.Soc.Common.Unity.Construction.ConstructionBase[] walls; // 0x40
	System.Void OnAfterDeserialize(); // 0x06b85ee8
	System.Void OnBeforeSerialize(); // 0x06b85f48
	System.Void RecoverData(WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_WallGroupConfig data); // 0x06b8610c
	System.Void SaveData(WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionGroupConfig node); // 0x06b866d0
	System.Void .ctor(); // 0x06b867c4
	static System.Void .cctor(); // 0x06b868a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.FaceShowFx : System.Object
{
	SocLogger log; // 0x10
	UnityEngine.GameObject fxGo; // 0x18
	System.UInt64 asyncId; // 0x20
	System.UInt64 asyncId1; // 0x28
	static System.String get_prefabResPath(); // 0x06b86974
	System.Void Enable(System.Int64 partyType, UnityEngine.GameObject goMainGo, UnityEngine.Vector3 partPos, UnityEngine.Quaternion partRot); // 0x06b86a54
	System.Void RefreshRot(UnityEngine.Quaternion rot); // 0x06b86edc
	System.Void Enable(System.Int64 partyType, UnityEngine.GameObject goMainGo); // 0x06b86ff0
	System.Void Disable(); // 0x06b872f0
	System.Boolean CheckResValid(System.Int64 partType); // 0x06b86ddc
	System.Void SetupFxGo(UnityEngine.GameObject fxGo, System.Int64 partType, UnityEngine.Transform partMainGo, UnityEngine.Vector3 partPos, UnityEngine.Quaternion partRot); // 0x06b8749c
	System.Void .ctor(); // 0x06b87914
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.FaceShowFx.<>c__DisplayClass11_0 : System.Object
{
	WizardGames.Soc.SocClient.Construction.FaceShowFx <>4__this; // 0x10
	System.Int64 partyType; // 0x18
	UnityEngine.GameObject goMainGo; // 0x20
	UnityEngine.Vector3 partPos; // 0x28
	UnityEngine.Quaternion partRot; // 0x34
	System.Void .ctor(); // 0x06b86d74
	System.Void <Enable>b__0(UnityEngine.GameObject go, System.Object[] objs); // 0x06b87a0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.FaceShowFx.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.SocClient.Construction.FaceShowFx <>4__this; // 0x10
	System.Int64 partyType; // 0x18
	UnityEngine.GameObject goMainGo; // 0x20
	System.Void .ctor(); // 0x06b87288
	System.Void <Enable>b__0(UnityEngine.GameObject go, System.Object[] objs); // 0x06b87b6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.RangeShowFx : System.Object
{
	Effect.EffectItemHandle<Effect.EffectItem> effectItemHandle; // 0x10
	System.Void Enable(System.Int64 entityId, System.Int64 templeteId, ConstructionSkinNodeConfig constructionSkinNodeConfig); // 0x06b87d70
	System.Void Disable(); // 0x06b881e0
	System.Void .ctor(); // 0x06b88298
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.RangeShowFx.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Construction.RangeShowFx.<>c <>9; // 0x0
	static System.Action<System.Boolean,Effect.EffectItem,System.Object> <>9__1_0; // 0x8
	static System.Void .cctor(); // 0x06b88300
	System.Void .ctor(); // 0x06b88364
	System.Void <Enable>b__1_0(System.Boolean success, Effect.EffectItem effectItem, System.Object o); // 0x06b883cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildPanelUtil : System.Object
{
	static SocLogger Logger; // 0x0
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase> BuildItemDataList; // 0x8
	static System.Collections.Generic.HashSet<System.Int32> firstTagSet; // 0x10
	static System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase> BuildItemRecordData; // 0x18
	static System.Void CollectBuildItemDataList(WizardGames.Soc.Common.Data.EBuildSecondModeType secondModeType); // 0x06b884a4
	static System.Void ClearBuildDataList(); // 0x06b88908
	static System.Void RefreshCustomBlueprintData(WizardGames.Soc.Common.Data.EBuildSecondModeType secondModeType); // 0x06b89efc
	static System.Void GetBuildCoreDataList(WizardGames.Soc.Common.Data.constraction.BuildSecondMode secondModeConfig); // 0x06b88b14
	static WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase FindHasDeployItemData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06b8acb8
	static System.Boolean RefreshDeployItemDataList(System.Int32 firstTagId); // 0x06b8a114
	static System.Int32 GetTargetTagId(System.Collections.Generic.List<System.Int32> tagIds, System.Boolean isEditMode); // 0x06b8a034
	static System.Void GetBuildComboDataList(WizardGames.Soc.Common.Data.constraction.BuildSecondMode secondModeConfig); // 0x06b891fc
	static System.Void GetBuildBlueprintDataList(WizardGames.Soc.Common.Data.constraction.BuildSecondMode secondModeConfig); // 0x06b895e0
	static System.Void GetCustomBlueprintDataList(WizardGames.Soc.Common.Data.constraction.BuildSecondMode secondModeConfig, System.Boolean addEmpty); // 0x06b899c4
	static System.Void AddEmptyCustomBlueprintData(WizardGames.Soc.Common.Data.constraction.BuildSecondMode secondModeConfig); // 0x06b8b0c4
	static System.Int32 SortBuildItemTagCommodity(WizardGames.Soc.SocClient.Ui.Construction.BuildTagData a, WizardGames.Soc.SocClient.Ui.Construction.BuildTagData b); // 0x06b8b61c
	static System.Int32 SortBuildSecondTagCommodity(System.Int32 a, System.Int32 b); // 0x06b8b8bc
	static System.Int32 GetItemAmount(System.Int64 itemId); // 0x06b8aff4
	static System.Int32 GetBlueprintCanUseCount(System.Int64 templateId); // 0x06b8ba6c
	static System.Void .cctor(); // 0x06b8bbfc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildBlueprintBuildMode : WizardGames.Soc.SocClient.Construction.BuildMode.BuildPlaceModeBase
{
	ConstructionBluePrint CurHoldingConstructionBlueprint; // 0x310
	WizardGames.Soc.Common.Unity.Construction.BuildingTarget blueprintBuildingTarget; // 0x318
	System.Int32 <CurHoldingBlueprintType>k__BackingField; // 0x3a0
	System.String blueprintResPath; // 0x3a8
	System.UInt64 blueprintAsyncId; // 0x3b0
	System.Boolean isBlueprintTurning; // 0x3b8
	UnityEngine.Vector3 blueprintRotationOffset; // 0x3bc
	System.Int32 blueprintTurnDir; // 0x3c8
	System.Int32 get_CurHoldingBlueprintType(); // 0x06b8bdd8
	System.Void set_CurHoldingBlueprintType(System.Int32 value); // 0x06b8be3c
	System.Void .ctor(System.Int32 modeId); // 0x06b8beb4
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastMode); // 0x06b8c118
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextMode); // 0x06b8c720
	System.Void LogicUpdate(); // 0x06b8cd40
	System.Void RaiseHoldingConstructionByDirAndHeight(System.Int32 dir, System.Single moveStep); // 0x06b8cea0
	System.Void CheckShowBlueprintCD(); // 0x06b8ce0c
	System.Void SetBuildItemData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06b8d064
	System.Void OnClickConstructionType(System.Int64 itemId, System.Int64 comboId, System.Boolean isBlueprint); // 0x06b8d1bc
	System.Void OnInventoryItemChange(); // 0x06b8df80
	System.Void ShowConstructionBlueprintTip(); // 0x06b8d6d0
	System.Void TestHoldingBluePrint(System.Int32 type, System.Boolean force); // 0x06b8d36c
	System.Void ClearHoldingBlueprintConstruction(); // 0x06b8cb00
	System.Void CreateConstructionBlueprintFinish(UnityEngine.GameObject instanceGo, System.Int32 type); // 0x06b8e35c
	System.Void RefreshBlueprintCDTime(); // 0x06b8e59c
	System.Void EnterConstructionBlueprintMode(); // 0x06b8d2e0
	System.Void SetBpEditBtnState(System.Boolean isShow); // 0x06b8e0b0
	System.Void PlaceHoldingObject(); // 0x06b8e8fc
	System.Void PlaceHoldingConstructionBlueprint(); // 0x06b8e9a8
	System.Void OnConfirmBuildOk(); // 0x06b8f434
	System.Boolean PlaceOnCreate(); // 0x06b8f574
	System.Boolean RequestCreateConstructionBlueprint(); // 0x06b8f690
	System.Boolean IsUnlockConstructionBlueprint(); // 0x06b8f308
	System.Void TestTurnHoldingBlueprint(System.Int32 dir); // 0x06b90648
	System.Void TestStopTurnHoldingBlueprint(); // 0x06b906c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildBlueprintBuildMode.<>c__DisplayClass21_0 : System.Object
{
	WizardGames.Soc.SocClient.Construction.BuildMode.BuildBlueprintBuildMode <>4__this; // 0x10
	System.Int32 type; // 0x18
	System.Void .ctor(); // 0x06b8dfe4
	System.Void <TestHoldingBluePrint>b__0(UnityEngine.GameObject go, System.Object[] objs); // 0x06b9072c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildChristmasLightMode : WizardGames.Soc.SocClient.Construction.BuildMode.BuildModeBase, WizardGames.Soc.SocClient.Construction.BuildMode.IPlaceMode
{
	WizardGames.Soc.Common.Unity.Event.MsgHandler handler; // 0x28
	WizardGames.Soc.Common.Component.ElectricChristmasLightComponent ChristmasLightsModule; // 0x30
	System.Int64 <NeedEditLightEntityId>k__BackingField; // 0x38
	WizardGames.Soc.Common.CustomType.BaseItemNode CurItemNode; // 0x40
	WizardGames.Soc.SocClient.Construction.PoweredLightsTool poweredLightsTool; // 0x48
	System.Boolean buildOkIsEnable; // 0x50
	System.Boolean isConfirmDoubleCheck; // 0x51
	System.Int64 get_NeedEditLightEntityId(); // 0x06b90888
	System.Void set_NeedEditLightEntityId(System.Int64 value); // 0x06b908ec
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastModeType); // 0x06b90964
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextBuildModeType); // 0x06b90c48
	System.Void SetEditLightEntityId(System.Int64 entityId); // 0x06b90d5c
	System.Void SetCurItemNode(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x06b90e08
	System.Void LogicUpdate(); // 0x06b90e88
	System.Void PlaceHoldingObject(); // 0x06b9115c
	WizardGames.Soc.Common.Entity.PartEntity GetCurEditLightPart(); // 0x06b911cc
	System.Void DoubleCheckConfirm(); // 0x06b912b8
	System.Void OnClickDeploy(); // 0x06b9132c
	System.Void OnClickFinishDeploy(); // 0x06b9175c
	System.Boolean CanBuildByPermission(); // 0x06b917cc
	System.Void .ctor(System.Int32 modeId); // 0x06b91928
	System.Void RenderUpdate(); // 0x06b919cc
	System.Void LateUpdate(); // 0x06b91a2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildCoreMode : WizardGames.Soc.SocClient.Construction.BuildMode.BuildPlaceModeBase
{
	WizardGames.Soc.Common.Entity.PartEntityPrebuild holdingCombinePart; // 0x310
	WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget combineVirtualTarget; // 0x318
	System.Int64 <CurComboId>k__BackingField; // 0x3b0
	WizardGames.Soc.Common.Construction.TerrainSocketRuntime _foundationTerrainSocketData; // 0x3b8
	System.Single terrainSocketOriginPosY; // 0x3c0
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.SimpleCreatePartData> multiCreatePartDataList; // 0x3c8
	static WizardGames.Soc.Common.Construction.ConstructionGrade defaultConstructionGrade; // 0x0
	System.Int64 get_CurComboId(); // 0x06b91a90
	System.Void set_CurComboId(System.Int64 value); // 0x06b91af4
	System.Void OnRotateCurHoldPart(); // 0x06b91b6c
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastMode); // 0x06b91d60
	System.Void SetBuildItemData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06b921a8
	System.Void ResetHoldingObject(); // 0x06b924b0
	System.Void CreatePartOver(System.Int64 markId, System.Int64 itemUid); // 0x06b92584
	System.Void OnInventoryItemChange(); // 0x06b9268c
	System.Void PlaceHoldingObject(); // 0x06b92a40
	System.Void RefreshRaiseAndDownButtonState(); // 0x06b93f90
	System.Void RaiseHoldingConstructionByDirAndHeight(System.Int32 dir, System.Single step); // 0x06b940a4
	System.Boolean PlaceOnCreate(); // 0x06b9435c
	System.Void OnClickConstructionType(System.Int64 itemId, System.Int64 comboId, System.Boolean isBlueprint); // 0x06b92324
	System.Void CreateHoldingObject(System.Int64 type, System.Int64 comboId); // 0x06b9704c
	System.Void OnInstantiateAsyncComplete(); // 0x06b97700
	System.Void SetSocketAndMeshRoot(); // 0x06b9741c
	System.Void ShowCurCostTipInfo(); // 0x06b927b0
	System.Void HandleCombineConstruction(System.Int64 itemId, System.Int32 itemCount, WizardGames.Soc.Common.Data.constraction.BuildingCore coreConfig, System.String labelName, System.String labelDes); // 0x06b98024
	System.Boolean IsConstructionUnlocked(); // 0x06b98adc
	WizardGames.Soc.Common.Data.constraction.BuildingCore GetCoreConfig(); // 0x06b979b8
	System.ValueTuple<System.String,System.String> GetCoreLabels(WizardGames.Soc.Common.Data.constraction.BuildingCore coreConfig); // 0x06b97aa4
	System.ValueTuple<System.Int64,System.Int32> GetBuildCostConfig(WizardGames.Soc.Common.Data.constraction.BuildingCore coreConfig); // 0x06b97b6c
	System.Boolean IsNotInCombineState(); // 0x06b97d54
	System.Void HandleBaseConstruction(WizardGames.Soc.Common.Data.constraction.ConstructionComboConfig comboConfig, System.String labelName, System.String labelDes, System.Int64 itemId, System.Int32 itemCount); // 0x06b97dc0
	System.Void UpdateConstructionInfoForCore(System.String labelName, System.String labelDes, System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemNeedDic); // 0x06b991ac
	System.Void UpdateConstructionInfoForCombo(WizardGames.Soc.Common.Data.constraction.ConstructionComboConfig comboConfig, System.String labelName, System.String labelDes, System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemNeedDic); // 0x06b98c0c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UIConstructionBaseDetailInfo> GetChildParts(WizardGames.Soc.Common.Data.constraction.ConstructionComboConfig comboConfig); // 0x06b994a4
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UIConstructionBaseDetailInfo> GetCombineOtherParts(WizardGames.Soc.Common.Data.constraction.BuildingCore coreConfig); // 0x06b98930
	System.Void SetHoldConstruction(System.Int64 constructionId, System.Boolean force, System.Int64 comboId); // 0x06b91f40
	System.Void RenderUpdate(); // 0x06b997c4
	System.Void LateUpdate(); // 0x06b99888
	System.Void CheckAndClearHoldingCombineObject(); // 0x06b9a278
	System.Void PlaceCombineHoldingObj(); // 0x06b9996c
	System.Void CreateHoldingCombineObject(System.Int32 partType); // 0x06b9a3a4
	System.Void OnInstantiateAsyncCompleteCombine(); // 0x06b9aa70
	System.Void ClearHoldingObject(); // 0x06b9ad28
	System.Void ClearHoldingCombineObj(); // 0x06b9a2f0
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextMode); // 0x06b9b1fc
	System.Void .ctor(System.Int32 modeId); // 0x06b9b44c
	static System.Void .cctor(); // 0x06b9b538
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildDeployCommonMode : WizardGames.Soc.SocClient.Construction.BuildMode.BuildModeBase, WizardGames.Soc.SocClient.Construction.BuildMode.IPlaceMode
{
	SocLogger logger; // 0x28
	WizardGames.Soc.Common.Unity.DeployObj holdingObject; // 0x30
	WizardGames.Soc.Common.Data.DataItem.ItemConfig curItemConfig; // 0x38
	System.Int64 curSelectedItemUid; // 0x40
	WizardGames.Soc.Common.Unity.Construction.PlaceTarget _placeTarget; // 0x48
	UnityEngine.Vector3 rotationOffset; // 0xc8
	System.UInt64 asyncId; // 0xd8
	System.Void .ctor(System.Int32 modeId); // 0x06b9b584
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastModeType); // 0x06b9b6f8
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextModeType); // 0x06b9b984
	System.Void OnRotateCurHoldPart(); // 0x06b9bc2c
	System.Void TryRotateHoldingObject(); // 0x06b9bc90
	System.Void SetBuildConfirmBtnState(WizardGames.Soc.SocClient.Ui.EBuildButtonMode mode); // 0x06b9b8a4
	System.Void OnConfirmBuildOk(); // 0x06b9bda4
	System.Void PlaceOnCreate(); // 0x06b9bee4
	System.Void ClearHoldingObject(); // 0x06b9baf0
	System.Void RenderUpdate(); // 0x06b9c138
	System.Void LateUpdate(); // 0x06b9c198
	System.Void LogicUpdate(); // 0x06b9c6e4
	System.Void SetHoldDeployItem(System.Int64 tempId, System.Int64 itemUid); // 0x06b9c744
	System.Void FillPlacement(WizardGames.Soc.Common.Unity.Construction.PlaceTarget& target, WizardGames.Soc.Common.Unity.DeployObj obj); // 0x06b9cc18
	System.Void PlaceHoldingObject(); // 0x06b9c1fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildDeployCommonMode.<>c__DisplayClass19_0 : System.Object
{
	WizardGames.Soc.SocClient.Construction.BuildMode.BuildDeployCommonMode <>4__this; // 0x10
	System.String path; // 0x18
	WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig; // 0x20
	System.Int64 itemUid; // 0x28
	System.Void .ctor(); // 0x06b9cbb0
	System.Void <SetHoldDeployItem>b__0(UnityEngine.GameObject go, System.Object[] objs); // 0x06b9cf80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildDeployMode : WizardGames.Soc.SocClient.Construction.BuildMode.BuildPlaceModeBase
{
	static SocLogger logger; // 0x0
	System.Int64 <CurSelectedItemUid>k__BackingField; // 0x310
	System.Int64 <CurHoldItemId>k__BackingField; // 0x318
	System.Boolean isShortcutsDeployMode; // 0x320
	System.Single nextClickTime; // 0x324
	System.String lockAttachedStr; // 0x328
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> curBuildElecItemList; // 0x330
	System.Boolean CampingShowTip; // 0x338
	System.Boolean IsMoveMode; // 0x339
	System.Boolean isDeplyPlaceEnable; // 0x33a
	System.Int64 get_CurSelectedItemUid(); // 0x06b9d304
	System.Void set_CurSelectedItemUid(System.Int64 value); // 0x06b9d368
	System.Int64 get_CurHoldItemId(); // 0x06b9d3e0
	System.Void set_CurHoldItemId(System.Int64 value); // 0x06b9d444
	System.Boolean get_IsCampingTentDeployMode(); // 0x06b9d4bc
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastMode); // 0x06b9d5c4
	System.Void OnRotateCurHoldPart(); // 0x06b9db38
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextMode); // 0x06b9db9c
	System.Void CloseMoveModeUi(); // 0x06b9ddac
	System.Void SetBuildItemData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06b9de88
	System.Void ClearHoldingObject(); // 0x06b9e5f8
	System.Void PlaceHoldingObject(); // 0x06b9efa8
	System.Void OnShortcutsChooseMenuStateChange(System.Boolean open); // 0x06b9f01c
	System.Void LogicUpdate(); // 0x06b9f6b0
	System.Int64 GetHoldingItemId(); // 0x06ba0650
	System.Void SetHoldDeployConstruction(System.Int64 itemId, System.Int64 uid); // 0x06b9e254
	System.Void ShowDeployPlaceTip(System.Int64 itemId, System.Int64 uid); // 0x06b9f124
	System.Void OnUiInventoryAnyUpdate(); // 0x06ba0a18
	System.Void UpdateTips(); // 0x06b9f724
	System.Void SetWaitMoveDeploy(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06ba0a7c
	System.Void CheckModeState(); // 0x06ba0eac
	System.Void OnInventoryItemChange(); // 0x06ba1000
	System.Boolean PlaceOnCreate(); // 0x06ba106c
	System.Void CreateHoldingObject(System.Int64 constructionId, System.Int64 comboId); // 0x06ba199c
	System.Void CreateMoveHoldingObject(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06ba0cd0
	System.Void CreateHoldingObjectFinish(); // 0x06ba1ba8
	System.Void .ctor(System.Int32 modeId); // 0x06ba1dd4
	System.Void SetRef(Construction.BuildMode.BuildEditBase edit); // 0x06ba1ec8
	System.Void StopCampingTentDeploying(); // 0x06ba1fa0
	System.Void UpdateCampintTentCheck(); // 0x06ba0428
	System.Void OnCampingTentConfirm(); // 0x06ba2008
	System.Void OnCampingTentCancel(); // 0x06ba2f50
	System.Void ToggleCampingTentTip(System.Boolean show, System.Boolean force); // 0x06b9e7bc
	System.Void RequestCreateCampingTent(System.Int64 partType, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget buildingTarget, System.Int64 itemUid, System.Boolean isCombinePart, System.Int64 comboId, System.Boolean requestCreateRelatedPart); // 0x06ba276c
	System.Void TryRemoveAimedConstruction(); // 0x06ba30c8
	System.Void UpdateRaycastTarget(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06ba31b8
	System.Void HideEditUINoTarget(); // 0x06ba33ac
	System.Void TriggerGuide(); // 0x06ba0738
	static System.Void .cctor(); // 0x06ba3444
	System.Void <UpdateTips>b__31_0(); // 0x06ba3518
	System.Void <UpdateTips>b__31_1(); // 0x06ba363c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildDeployMode.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Construction.BuildMode.BuildDeployMode.<>c <>9; // 0x0
	static System.Func<System.Boolean> <>9__46_0; // 0x8
	static System.Void .cctor(); // 0x06ba3754
	System.Void .ctor(); // 0x06ba37b8
	System.Boolean <ToggleCampingTentTip>b__46_0(); // 0x06ba3820
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildEditMode : Construction.BuildMode.BuildEditBase
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase> buildItemDataList; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.BuildTagData> tempDiscardTagList; // 0x58
	System.Boolean isConfirmDoubleCheck; // 0x60
	WizardGames.Soc.SocClient.Manager.BuildListOperation get_buildListOperation(); // 0x06ba3884
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastModeType); // 0x06ba391c
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextModeType); // 0x06ba4c90
	System.Void BuildModeCancelEvent(); // 0x06ba4d68
	System.Void RenderUpdate(); // 0x06ba4e0c
	System.Void OnTerritoryAtted(System.Int64 terrEntityId, System.Int64 stateTs); // 0x06ba4e74
	System.Void LogicUpdate(); // 0x06ba4f78
	System.Void UpdateSubIconState(); // 0x06ba4fe8
	System.Boolean CurrentItemDataIsUpgrade(); // 0x06ba52c8
	System.Void BuildItemSelect(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06ba3b18
	System.Void HideEditUINoTarget(); // 0x06ba5384
	System.Void UpdateDeployMoveCd(); // 0x06ba4ef4
	System.Void DoubleCheckConfirm(); // 0x06ba5428
	System.Void TryEnterDeployMoveState(); // 0x06ba54a8
	System.Void ConfirmBuildOkEvent(); // 0x06ba55ac
	System.Boolean CheckCanModify(); // 0x06ba5f30
	System.Void UpdateRaycastTarget(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06ba6124
	System.Void ReleaseData(); // 0x06ba655c
	System.Void GetChangeData(); // 0x06ba672c
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase AddBuildData(WizardGames.Soc.Common.Data.constraction.BuildingCore buildingCore, System.Int32 grade, System.Int32 priority, System.Int32 priorityPie); // 0x06ba7a8c
	System.Void AddBuildData(WizardGames.Soc.Common.Data.constraction.ConstructionComboChildGroupConfig childGroupConfig, System.Int32 grade); // 0x06ba7c5c
	System.Void .ctor(System.Int32 modeId); // 0x06ba7dc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildEmptyHandMode : Construction.BuildMode.BuildEditBase
{
	
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastModeType); // 0x06ba7ed8
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextModeType); // 0x06ba7fa4
	System.Void ConfirmBuildOkEvent(); // 0x06ba8024
	System.Void UpdateRaycastTarget(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06ba8084
	System.Void HideEditUINoTarget(); // 0x06ba8310
	System.Void .ctor(System.Int32 modeId); // 0x06ba83a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.WaitBuildData : System.Object
{
	System.Int64 markId; // 0x10
	System.Int64 requestTime; // 0x18
	System.Void .ctor(); // 0x06ba3060
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildPlaceModeBase : WizardGames.Soc.SocClient.Construction.BuildMode.BuildModeBase, WizardGames.Soc.SocClient.Construction.BuildMode.IPlaceMode
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Entity.PartEntityPrebuild <HoldingConstruction>k__BackingField; // 0x28
	WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget VirtualBuildingTargetRuntime; // 0x30
	UnityEngine.Vector3 RotationOffset; // 0xc8
	UnityEngine.RaycastHit hitInfo; // 0xd4
	WizardGames.Soc.Common.Construction.SocketRuntimeBase BufferSocketData; // 0x100
	System.Int64 BufferParentPartEntityId; // 0x108
	WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget LastPlacement; // 0x110
	WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget LastPlacementNoMono; // 0x1a8
	WizardGames.Soc.Common.Entity.PartEntity <CachedOldPart>k__BackingField; // 0x240
	System.Int64 cachedOldPartTerritoryId; // 0x248
	Construction.BuildMode.BuildEditBase editBase; // 0x250
	WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget lastFoundTarget; // 0x258
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.PartEntity> lastFoundPartGoesInSocketSnap; // 0x2f0
	System.Boolean isCampingTentDeploying; // 0x2f8
	System.Single startCampingTentChcekTime; // 0x2fc
	WizardGames.Soc.SocClient.Manager.ERaiseBlueprintState RaiseBlueprintState; // 0x300
	static System.Single RaiseStep; // 0x8
	static System.Single ShorPressTime; // 0xc
	System.Single startRaiseTime; // 0x304
	System.Int32 currentRaiseDir; // 0x308
	System.Boolean sleepingBagCDShareTip; // 0x30c
	System.Boolean isConfirmDoubleCheck; // 0x30d
	WizardGames.Soc.SocClient.Manager.BuildListOperation get_buildListOperation(); // 0x06b95134
	WizardGames.Soc.Common.Entity.PartEntityPrebuild get_HoldingConstruction(); // 0x06ba8428
	System.Void set_HoldingConstruction(WizardGames.Soc.Common.Entity.PartEntityPrebuild value); // 0x06ba848c
	WizardGames.Soc.Common.Entity.PlayerEntity get_selfPlayer(); // 0x06ba850c
	UnityEngine.Camera get_mainCam(); // 0x06b8efb0
	WizardGames.Soc.Common.Entity.PartEntity get_CachedOldPart(); // 0x06ba85a8
	System.Void set_CachedOldPart(WizardGames.Soc.Common.Entity.PartEntity value); // 0x06ba860c
	System.Boolean get_isMoving(); // 0x06ba868c
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastMode); // 0x06b8c378
	System.Void BuildModeCancelEvent(); // 0x06ba873c
	System.Void ResetHoldingObject(); // 0x06b9251c
	System.Void OnInventoryItemChange(); // 0x06b92750
	System.Void SetBuildItemData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06b8d148
	System.Void StopRaise(); // 0x06b8e04c
	System.Void HoldingStateChange(); // 0x06b8e1cc
	System.Void SetBuildConfirmBtnState(System.Boolean enable, WizardGames.Soc.SocClient.Ui.EBuildButtonMode mode); // 0x06ba8a50
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextBuildModeType); // 0x06b8ca14
	System.Void HideAllHudElem(); // 0x06ba8c70
	System.Void OnRaiseStart(System.Int32 dir); // 0x06ba8db0
	System.Void OnRaiseEnd(System.Int32 dir); // 0x06ba8e3c
	System.Void OnRaiseStep(System.Int32 dir); // 0x06ba8eb4
	System.Void ProcessBlueprint(); // 0x06ba8f6c
	System.Void RaiseHoldingConstructionByDirAndHeight(System.Int32 dir, System.Single moveHeight); // 0x06b8cfdc
	System.Void CreateHoldingObject(System.Int64 type, System.Int64 comboId); // 0x06ba1b2c
	System.Void OnConfirmBuildOk(); // 0x06ba906c
	System.Void CreatePartOver(System.Int64 markId, System.Int64 itemUid); // 0x06b9260c
	System.Boolean CheckPersonalLimit(System.Int64 type); // 0x06ba91bc
	System.Boolean CheckConsumeItem(System.Int64 type, System.Int64 grade); // 0x06ba9438
	System.Boolean CheckConsumeItem(System.Int64 type1, System.Int64 type2, System.Int64 grade); // 0x06b956e8
	System.Boolean CheckCreateCondition(WizardGames.Soc.Common.Construction.ConstructionGrade grade); // 0x06b951cc
	System.Boolean PlaceOnCreate(); // 0x06b8f62c
	System.Void ClearHoldingObject(); // 0x06b9adc4
	System.Void RequestCreateComboPart(System.Int64 partType, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget buildingTarget, System.Int32 comboId, System.Int32 grade); // 0x06b96308
	WizardGames.Soc.Common.SimpleCustom.SimpleCreatePartData CreateACreatePartData(System.Int64 partType, System.Int32 grade, UnityEngine.Vector3 posParam, UnityEngine.Quaternion rotation, System.Int64 targetPartId, System.Int32 targetSocketId, System.Int32 holdingMaleSocketId, System.Int64 markId, System.Int64 itemUid, System.Boolean requestCreateRelatedPart); // 0x06b95de8
	System.Void RequestCreateMultiCoreParts(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.SimpleCreatePartData> createPartDatas); // 0x06b95fe8
	System.Void RequestCreateOrMovePart(System.Int64 partType, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget buildingTarget, System.Int64 itemUid, System.Boolean isCombinePart, System.Int64 comboId, System.Boolean requestCreateRelatedPart, System.Int32 grade); // 0x06b96864
	System.Void OpenTentUI(); // 0x06baa864
	System.Void RequestMovePart(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget buildingTarget); // 0x06baa088
	System.Void RenderUpdate(); // 0x06b99828
	System.Void LateUpdate(); // 0x06b998f4
	System.Void LogicUpdate(); // 0x06b8cdac
	System.Boolean CheckSocketLegal(WizardGames.Soc.Common.Component.ConstructionSocketBaseComponent selfSocketComponent, WizardGames.Soc.Common.Entity.PartEntity parentPart, WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData, UnityEngine.Ray ray, System.Single buildDistance); // 0x06baae10
	System.Void FindAppropriateSocketAlpha3(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, WizardGames.Soc.Common.Entity.PartEntity construction); // 0x06bab124
	System.Void FindTerrainPlacementAlpha3(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, WizardGames.Soc.Common.Entity.PartEntity construction); // 0x06babdf0
	System.Void TryRotateHoldingObject(); // 0x06b91bd0
	System.Void FillPlacementAlpha3(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, WizardGames.Soc.Common.Entity.PartEntity construction); // 0x06bac2c8
	UnityEngine.Vector3 GetSelfPosition(); // 0x06b9a538
	UnityEngine.Quaternion GetSelfRotation(); // 0x06babd20
	System.Void SetHoldingObjValidNoMono(System.Boolean valid, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, System.Boolean force); // 0x06b9a5f8
	System.Void ShowAndHideSleepingBagTip(System.Boolean show); // 0x06ba87dc
	System.Boolean IsInWater(UnityEngine.Vector3 vPoint); // 0x06b8f014
	System.Void PlaceHoldingObject(); // 0x06b92aac
	System.Void MovePartPending(); // 0x06bac404
	static System.Void FindInvalidReasonAndShow(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget buildingTarget); // 0x06ba9a00
	System.Void .ctor(System.Int32 modeId); // 0x06b8bfa0
	System.Void OnTerritoryAtted(System.Int64 terrEntityId, System.Int64 stateTs); // 0x06bad12c
	System.Void DoubleCheckConfirm(); // 0x06bad278
	System.Void SetupAndCallRecoverDoubleCheck(); // 0x06b9042c
	static System.Void .cctor(); // 0x06bad2f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildPlaceModeBase.<>c__DisplayClass65_0 : System.Object
{
	WizardGames.Soc.SocClient.Construction.BuildMode.BuildPlaceModeBase <>4__this; // 0x10
	UnityEngine.Vector3 pos; // 0x18
	WizardGames.Soc.Common.Algorithm.Vector3 angle; // 0x24
	System.Void .ctor(); // 0x06bad95c
	System.Void <RequestMovePart>b__0(); // 0x06bad9c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildPlayerBlueprintMode : WizardGames.Soc.SocClient.Construction.BuildMode.BuildPlaceModeBase
{
	static System.Single MaxSnapDistance; // 0x0
	System.Int64 _holdingPlayerBlueprintId; // 0x310
	System.Single _holdingMaxDistance; // 0x318
	UnityEngine.GameObject _holdingObject; // 0x320
	UnityEngine.MeshRenderer _holdingObjectMeshRenderer; // 0x328
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.CheckConfigBase> _checkConfigBases; // 0x330
	WizardGames.AssetPool.AssetPoolHandle[] _validMaterials; // 0x338
	System.Int64 curCustomBlueprintId; // 0x340
	System.Int64 curCustomBlueprintSlotId; // 0x348
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> blueprintCostItemDic; // 0x350
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveData> curBlueprintPartDataList; // 0x358
	UnityEngine.Vector3 blueprintRotationOffset; // 0x360
	System.Single posYOffset; // 0x36c
	System.Boolean isInPlaceCdState; // 0x370
	System.Int32 blueprintTurnDir; // 0x374
	System.Single raiseStep; // 0x378
	System.Collections.Generic.HashSet<System.Int32> ignoreCheckType; // 0x380
	System.Boolean isBlueprintTurning; // 0x388
	System.Void .ctor(System.Int32 modeId); // 0x055056e8
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastMode); // 0x055056e8
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextBuildModeType); // 0x06bae088
	System.Void LogicUpdate(); // 0x06bae550
	System.Void TurnHoldingBlueprint(System.Int32 dir); // 0x06bae654
	System.Void StopTurnHoldingBlueprint(); // 0x06bae6d4
	System.Void RaiseHoldingConstructionByDirAndHeight(System.Int32 dir, System.Single moveHeight); // 0x06bae738
	System.Void CheckShowBlueprintCd(); // 0x06bae5c0
	System.Void RefreshBlueprintCdTime(); // 0x06bae8b8
	System.Void SwitchHoldingState(System.Boolean show); // 0x06baee80
	System.Void OnConfirmBuildOk(); // 0x06baf2dc
	System.Boolean PlaceOnCreate(); // 0x06baf41c
	System.ValueTuple<System.Boolean,System.Int32> CheckCreateBpCD(); // 0x06bb0064
	System.Boolean RequestCreateCustomBlueprint(); // 0x06baf4cc
	System.Void ReceiveBlueprintPartDataList(System.Int64 blueprintId, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveData> blueprintPartDataList); // 0x06bb0254
	System.Void OnInventoryItemChange(); // 0x06bb092c
	System.Void RefreshBuildTip(); // 0x06bb0400
	System.Void SetBuildItemData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06bb099c
	System.Void SetHoldingBlueprintIDAndGo(System.Int64 blueprintId, UnityEngine.GameObject gameObject); // 0x06bb0cf4
	System.Void ClearHoldingObject(); // 0x06bb1748
	System.Void GetCheckConfigList(); // 0x06bb1684
	UnityEngine.Quaternion UpdateRotation(UnityEngine.Vector3 dir, UnityEngine.Vector3 rotation); // 0x06bb19b8
	System.Void SetHoldingObjectValid(System.Boolean isValid); // 0x06bb1ca4
	System.Void PlaceHoldingObject(); // 0x06bb1e1c
	static System.Void .cctor(); // 0x06bb24dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildWireMode : WizardGames.Soc.SocClient.Construction.BuildMode.BuildModeBase, WizardGames.Soc.SocClient.Construction.BuildMode.IBuildWireMode
{
	WizardGames.Soc.SocClient.Ui.UiHudElectricWireInfo wireInfo; // 0x28
	WizardGames.Soc.SocClient.Ui.UiHudElectricWireModifyInfo wireModifyInfo; // 0x30
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnAutoConnect btnAutoConnect; // 0x38
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnClearWire btnClearWire; // 0x40
	WizardGames.Soc.SocClient.Ui.UiHudElemClearWirePoint uiHudElemClearWirePoint; // 0x48
	System.Boolean wasPendingInput; // 0x50
	System.Boolean wasPendingOutput; // 0x51
	WizardGames.Soc.Common.Component.ElectricBaseComponent curLockTargetDevice; // 0x58
	System.Int32 lastSelectedIndex; // 0x60
	WizardGames.Soc.SocClient.Construction.BuildMode.EWireState <CurEWireState>k__BackingField; // 0x64
	WizardGames.Soc.SocClient.Construction.BuildMode.EWireTipState curWireTipState; // 0x68
	System.Int32 <NowSubMode>k__BackingField; // 0x6c
	System.Int32 nextRequestTime; // 0x70
	System.Int32 requestInterval; // 0x74
	System.Boolean isShowConstructionInfoTips; // 0x78
	System.Int64 subscribeId; // 0x80
	System.Boolean needRefreshTip; // 0x88
	System.Boolean isShowOutline; // 0x89
	WizardGames.Soc.SocClient.Construction.BuildMode.WireOutlineParam redOutline; // 0x90
	WizardGames.Soc.SocClient.Construction.BuildMode.WireOutlineParam greenOutline; // 0x98
	WizardGames.Soc.SocClient.Construction.BuildMode.WireOutlineParam whiteOutline; // 0xa0
	WizardGames.Soc.SocClient.Construction.BuildMode.WireOutlineParam yellowOutline; // 0xa8
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> WireCreateLinkInfo; // 0xb0
	System.Boolean isFlag; // 0xb8
	System.Int64 timerId1; // 0xc0
	System.Int64 timerId2; // 0xc8
	System.Int64 lastOutlineEntityId; // 0xd0
	UnityEngine.GameObject pluggedHandle; // 0xd8
	UnityEngine.GameObject selectedDefaultHandle; // 0xe0
	UnityEngine.GameObject selectedOccupiedHandle; // 0xe8
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Electric.IOSlotBase,UnityEngine.GameObject> inputHandleDic; // 0xf0
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Electric.IOSlotBase,UnityEngine.GameObject> outputHandleDic; // 0xf8
	System.Collections.Generic.Dictionary<UnityEngine.GameObject,WizardGames.Soc.SocClient.Construction.BuildMode.HandlePrefabInfo> handlePrefabPathDic; // 0x100
	System.Int32 <SelectedIndex>k__BackingField; // 0x108
	System.Boolean <SelectedWasInput>k__BackingField; // 0x10c
	System.Collections.Generic.List<WizardGames.Soc.Common.Electric.IOSlotBase> <ioSlots>k__BackingField; // 0x110
	System.Int32 curIoSlotsIndex; // 0x118
	WizardGames.Soc.Common.Component.ElectricBaseComponent <LookingAt>k__BackingField; // 0x120
	System.Single nextClearSendTime; // 0x128
	System.Boolean isInput; // 0x12c
	WizardGames.AssetPool.AssetPoolHandle inputMaterialHandle; // 0x130
	WizardGames.AssetPool.AssetPoolHandle outputMaterialHandle; // 0x138
	System.Single connectionTimer; // 0x140
	WizardGames.Soc.Common.Component.ElectricBaseComponent cantConnectDevice; // 0x148
	System.Boolean intelligentSlotConfirm; // 0x150
	WizardGames.Soc.Common.Component.ElectricBaseComponent intelligentWireTarget; // 0x158
	System.Single finishLockTimer; // 0x160
	System.Single confirmTargetInterval; // 0x164
	WizardGames.Soc.SocClient.Construction.BuildMode.EIntelligentWireState <CurIntelligentWireState>k__BackingField; // 0x168
	WizardGames.Soc.SocClient.Construction.BuildMode.WireTool get_wireTool(); // 0x06bb2528
	WizardGames.Soc.SocClient.Construction.BuildMode.EWireState get_CurEWireState(); // 0x06bb2624
	System.Void set_CurEWireState(WizardGames.Soc.SocClient.Construction.BuildMode.EWireState value); // 0x06bb2688
	System.Int32 get_NowSubMode(); // 0x06bb2700
	System.Void set_NowSubMode(System.Int32 value); // 0x06bb2764
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastModeType); // 0x06bb27dc
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextModeType); // 0x06bb4cb0
	System.Void SwitchSubMode(System.Int32 subMode); // 0x06bb3a50
	System.Void ChangeWireColour(WizardGames.Soc.Common.Unity.Electric.WireColour wireColour); // 0x06bb5b7c
	System.Void SelectTargetSlot(WizardGames.Soc.Common.Electric.IOSlotBase slotBase); // 0x06bb6120
	System.Void OnClickAutoConnect(); // 0x06bb75c0
	System.Void OnChangePartGoTransform(System.Int64 entityId); // 0x06bb7790
	System.Void ClearWire(WizardGames.Soc.Common.Component.ElectricBaseComponent modules); // 0x06bb79a8
	System.Void FinishWire(System.Collections.Generic.List<WizardGames.Soc.Common.Component.ElectricBaseComponent> modules); // 0x06bb7abc
	System.Void UpdateBtnEWireState(WizardGames.Soc.SocClient.Construction.BuildMode.EWireState EWireState, System.Boolean force); // 0x06bb8134
	System.Boolean IsInWiringState(); // 0x06bb8620
	System.Void UpdateBtnWireColorState(); // 0x06bb3e10
	System.Void OnChangeWireColorAck(System.Int32 isSuccess, System.Int64 entityId, System.Int32 type, System.Int32 color); // 0x06bb871c
	System.Void UpdateBtnWireModifyColorState(); // 0x06bb3ff0
	System.Boolean CheckBuildingPrivilege(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06bb8a84
	System.Void RequestElectricalData(); // 0x06bb8bb0
	System.Void UpdateWireTool(); // 0x06bb8e9c
	System.Void RenderUpdate(); // 0x06bbb180
	System.Void LateUpdate(); // 0x06bbb1e4
	System.Boolean IsHasPower(WizardGames.Soc.Common.Component.ElectricBaseComponent electricBaseComponent); // 0x06bbb244
	System.Void UpdateWiringState(); // 0x06bba5c4
	System.Void UpdateTipState(WizardGames.Soc.Common.Unity.Electric.IOSlot ioSlot); // 0x06bbb6c0
	System.Void LogicUpdate(); // 0x06bbc22c
	System.Void WireTipStateControl(WizardGames.Soc.SocClient.Construction.BuildMode.EWireTipState tipState); // 0x06bbb30c
	System.Void ShowTips(System.Int32 index); // 0x06bbc324
	System.Void HideTips(); // 0x06bbc28c
	System.Boolean UpdateLookingAtEnt(); // 0x06bb9cb4
	System.Void RefreshTip(); // 0x06bb4414
	System.Void RefreshElectricPerformance(); // 0x06bbcc84
	System.Void ProcessLookingTarget(WizardGames.Soc.Common.Component.ElectricBaseComponent electricBaseComponent); // 0x06bbcd30
	System.Void UpdateHandle(WizardGames.Soc.Common.Component.ElectricBaseComponent electricBaseComponent, System.Boolean isForceUdpate); // 0x06bbde78
	System.Void UpdateHandleForce(); // 0x06bb7a40
	System.Void SetLastLookingToNull(); // 0x06bb56bc
	WizardGames.Soc.Common.Component.ElectricBaseComponent UpdateLookingAtElectric(); // 0x06bb95f8
	System.Void CloseUIInfo(WizardGames.Soc.SocClient.Construction.BuildMode.EElectricInfoGroup type); // 0x06bba52c
	System.Void OnClickAdd(); // 0x06bbf610
	System.Void SetCheckTargetAtEnt(); // 0x06bbfeb4
	System.Void OnPartEntityRemove(System.Int64 partId); // 0x06bc15e8
	System.Void OnPressRemove(); // 0x06bc1b0c
	System.Void OnReleaseRemove(); // 0x06bc1720
	System.Void .ctor(System.Int32 modeId); // 0x06bc1e04
	System.Void RefreshTipAndOuoline(); // 0x06bc22b0
	System.Void TryRemoveAimedConstruction(); // 0x06bc2364
	System.Void TryRotateCurAimConstruction(); // 0x06bc2454
	System.Void UpdateRaycastTarget(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06bc24ec
	System.Void HideEditUINoTarget(); // 0x06bc280c
	System.Void UpdateOutlineAndHighLightState(WizardGames.Soc.Common.Unity.Electric.IOSlot ioSlot); // 0x06bbb9b8
	System.Void EnableAimLockPendingOutline(WizardGames.Soc.SocClient.Construction.BuildMode.WireOutlineParam outlineParam); // 0x06bc2a38
	System.Void DisableAimLockPendingOutline(); // 0x06bb5918
	System.Void EnableOutline(WizardGames.Soc.Common.Entity.PartEntity partEntity, WizardGames.Soc.SocClient.Construction.BuildMode.WireOutlineParam outlineParam); // 0x06bc2c44
	System.Void DisableOutline(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06bc28ac
	System.Void EnableHightlight(WizardGames.Soc.Common.Component.ElectricBaseComponent baseComponent); // 0x06bb9a00
	System.Void SetCurWireEntityId(); // 0x06bbf8b0
	System.Void OnWireCreateLinkInfo(System.Int64 sourceEntityId, System.Int64 targetEntityId, WizardGames.Soc.Common.Unity.Electric.ClientIOLine line); // 0x06bc2df8
	System.Void CheckOutlineAndHighLightState(); // 0x06bc0278
	System.Void CheckCancelOutlineAndHighLightState(); // 0x06bb5220
	System.Boolean FilterOutline(System.Int64 entityId); // 0x06bc317c
	static System.Void OnLinePowerStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int32 oldValue, System.Int32 newValue); // 0x06bc356c
	System.Void CheckHaveElectricity(); // 0x06bc0908
	System.Boolean CheckHaveElectricity(WizardGames.Soc.Common.CustomType.ElectricCBase electricCBase, WizardGames.Soc.Common.Electric.IOSlotBase slotBase); // 0x06bc36a8
	System.String get_inputDefaultHandlePrefabPath(); // 0x06bc39d0
	System.String get_inputOccupiedHandlePrefabPath(); // 0x06bc3ab8
	System.String get_outputDefaultHandlePrefabPath(); // 0x06bc3ba0
	System.String get_outputOccupiedHandlePrefabPath(); // 0x06bc3c88
	System.String get_pluggedDefaultHandlePrefabPath(); // 0x06bc3d70
	System.String get_selectedDefaultHandlePrefabPath(); // 0x06bc3e58
	System.String get_occupiedDefaultHandlePrefabPath(); // 0x06bc3f40
	System.String get_emissionInputMaterialPath(); // 0x06bc4028
	System.String get_emissionOutputMaterialPath(); // 0x06bc4110
	System.Int32 get_SelectedIndex(); // 0x06bc41f8
	System.Void set_SelectedIndex(System.Int32 value); // 0x06bc425c
	System.Boolean get_SelectedWasInput(); // 0x06bc42d4
	System.Void set_SelectedWasInput(System.Boolean value); // 0x06bc4338
	System.Collections.Generic.List<WizardGames.Soc.Common.Electric.IOSlotBase> get_ioSlots(); // 0x06bc43b4
	WizardGames.Soc.Common.Component.ElectricBaseComponent get_LookingAt(); // 0x06bc4418
	System.Void set_LookingAt(WizardGames.Soc.Common.Component.ElectricBaseComponent value); // 0x06bc447c
	WizardGames.Soc.Common.Electric.IOSlotBase get_CurrentLookSelectSlot(); // 0x06bb700c
	System.Void SetLookAtDevice(WizardGames.Soc.Common.Component.ElectricBaseComponent module); // 0x06bbc6b0
	System.Void SetupHandles(WizardGames.Soc.Common.Component.ElectricBaseComponent module, System.Boolean showInputs, System.Boolean showOutputs); // 0x06bbe130
	System.Void ClearHandles(); // 0x06bbdb2c
	System.Void ReturnHandle(UnityEngine.GameObject handle); // 0x06bc4b98
	UnityEngine.GameObject CreatePrefab(System.String strPrefab, UnityEngine.Vector3 pos, System.Boolean initMeshRender); // 0x06bc44fc
	UnityEngine.Vector3 SetHandlePosition(UnityEngine.GameObject mainGo, WizardGames.Soc.Common.Electric.IOSlotBase slotToUse); // 0x06bc47fc
	System.Void SetHandleRotate(UnityEngine.GameObject goHandle, UnityEngine.Vector3 euler, WizardGames.Soc.Common.Entity.PartEntity partEntity, System.Boolean isOccupied); // 0x06bc48f4
	System.Void InitMaterialHandle(); // 0x06bc5048
	System.Void ReleaseMaterialHandle(); // 0x06bc5144
	System.Void SetSelectedHandleMaterial(System.Boolean isInput); // 0x06bc4670
	System.Void SetPluggedHandleMaterial(System.Boolean isInput); // 0x06bc533c
	System.Void FilterHandle(WizardGames.Soc.Common.Component.ElectricBaseComponent module); // 0x06bbe874
	System.Void ClearIOSlotData(); // 0x06bbda48
	System.Void UpdatePluggedHandlePos(System.Boolean needCreate); // 0x06bb6bbc
	System.Void SortHandle(WizardGames.Soc.Common.Component.ElectricBaseComponent module); // 0x06bbf468
	System.Void UpdateIoSlotInfo(System.Boolean needSelectSlot); // 0x06bb7e58
	System.Int32 GetFirstEmptyIoSlotIndex(); // 0x06bc5608
	System.Void SetSelectSlot(WizardGames.Soc.Common.Electric.IOSlotBase selectSlotBase); // 0x06bb70ec
	System.Void UpdateLookingActiveHandle(); // 0x06bbd09c
	System.Void ClearHandleData(); // 0x06bb57a4
	System.Void ClientRequestClearWire(); // 0x06bc5978
	System.Single get_confirmConnectionInterval(); // 0x06bbcb9c
	WizardGames.Soc.SocClient.Construction.BuildMode.EIntelligentWireState get_CurIntelligentWireState(); // 0x06bc5fb0
	System.Void set_CurIntelligentWireState(WizardGames.Soc.SocClient.Construction.BuildMode.EIntelligentWireState value); // 0x06bc6014
	System.Boolean get_IsInIntelligentWireState(); // 0x06bb7da8
	System.Void RecoverIntelligentSearchTargetState(); // 0x06bbc578
	System.Void ClearIntelligentWireState(); // 0x06bb5870
	System.Void SwitchManualWireEvent(); // 0x06bc608c
	System.Void SwitchManualWire(); // 0x06bc63c0
	WizardGames.Soc.Common.Electric.IOSlotBase TryIntelligentWire(WizardGames.Soc.Common.Component.ElectricBaseComponent lookTarget); // 0x06bbc908
	System.Void TryConfirmIntelligentConnection(); // 0x06bbce54
	System.Void RecordCantConnectDevice(WizardGames.Soc.Common.Component.ElectricBaseComponent electricBaseComponent); // 0x06bbc60c
	System.Void SetWireIntelligentState(WizardGames.Soc.SocClient.Construction.BuildMode.EIntelligentWireState state); // 0x06bb656c
	System.Boolean LockLookingTargetTimer(WizardGames.Soc.Common.Component.ElectricBaseComponent lookTarget); // 0x06bbc834
	System.Boolean StartCalculateWire(WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug& pendingPlug, WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug& lookPlug); // 0x06bc6610
	System.Void <RefreshTip>b__57_0(); // 0x06bc6dc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildWireMode.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Construction.BuildMode.BuildWireMode.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Electric.IOSlotBase> <>9__161_0; // 0x8
	static System.Void .cctor(); // 0x06bc6e2c
	System.Void .ctor(); // 0x06bc6e90
	System.Int32 <SortHandle>b__161_0(WizardGames.Soc.Common.Electric.IOSlotBase x, WizardGames.Soc.Common.Electric.IOSlotBase y); // 0x06bc6ef8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildWireMode.<>c__DisplayClass93_0 : System.Object
{
	WizardGames.Soc.SocClient.Construction.BuildMode.BuildWireMode <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.PartEntity source; // 0x18
	WizardGames.Soc.Common.Entity.PartEntity target; // 0x20
	System.Void .ctor(); // 0x06bc3114
	System.Void <OnWireCreateLinkInfo>b__0(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x06bc7058
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Construction.BuildMode.HandlePrefabInfo : System.ValueType
{
	System.String prefabPath; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Construction.BuildMode.RenderMaterialHandleInfo> rendeMaterialHandles; // 0x18
	System.Void .ctor(System.String prefabPath); // 0x06bc4dc8
	System.Void InitMeshRender(UnityEngine.GameObject prefabGo); // 0x06bc4e58
	System.Void SetMaterialHandle(WizardGames.AssetPool.AssetPoolHandle materialHandle); // 0x06bc51e4
	System.Void Clear(); // 0x06bc4d14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.RenderMaterialHandleInfo : System.Object
{
	UnityEngine.Renderer renderer; // 0x10
	WizardGames.AssetPool.AssetPoolHandle materialHandle; // 0x18
	System.Void .ctor(); // 0x06bc7134
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Construction.BuildMode.EIntelligentWireState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Construction.BuildMode.EIntelligentWireState None = 0;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EIntelligentWireState SearchTarget = 1;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EIntelligentWireState ReplaceWire = 2;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EIntelligentWireState EndWire = 3;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EIntelligentWireState CantConnect = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Construction.BuildMode.EWireState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Construction.BuildMode.EWireState None = 0;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EWireState StartWire = 1;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EWireState LayoutPoints = 2;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EWireState DisableLayoutPoints = 3;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EWireState ReplaceWire = 4;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EWireState EndWire = 5;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EWireState ClearWire = 6;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EWireState CheckWire = 7;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EWireState AutoConnect = 8;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Construction.BuildMode.EWireTipState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Construction.BuildMode.EWireTipState None = 0;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EWireTipState TooFar = 1;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EWireTipState NoSurface = 2;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EWireTipState NoAvailableSlot = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Construction.BuildMode.EElectricInfoGroup : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Construction.BuildMode.EElectricInfoGroup All = 0;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EElectricInfoGroup Slot = 1;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EElectricInfoGroup Line = 2;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EElectricInfoGroup Aim = 3;
	static WizardGames.Soc.SocClient.Construction.BuildMode.EElectricInfoGroup ElectricInfo = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.WireOutlineParam : System.Object
{
	System.String outlineColor; // 0x10
	System.Single outlineBoldness; // 0x18
	System.Single outlineOpacity; // 0x1c
	System.Void .ctor(System.String outlineColor, System.Single outlineBoldness, System.Single outlineOpacity); // 0x06bc2174
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.WireSubModeDetail : System.Object
{
	
	static System.Int32 get_NowWireSubModeType(); // 0x06bc719c
	static WizardGames.Soc.Common.Utility.HoldItemIndex GetSubModeHoldItem(); // 0x06bb5b14
	static System.String GetElectricalWirePath(WizardGames.Soc.Common.Electric.EIOSlotType subMode); // 0x06bc72b0
	static System.Int32 GetMidPointEffect(System.Int32 subMode); // 0x06bc7414
	static System.Int32 GetHeadTailEffect(System.Int32 subMode); // 0x06bc7480
	static WizardGames.Soc.Common.Data.constraction.ConstructionCable GetWireConfig(WizardGames.Soc.Common.Unity.Electric.WireColour colour); // 0x06bc74ec
	static System.String GetWireDesc(); // 0x06bc765c
	static System.Void WireColorChangeSuccessTips(); // 0x06bc7708
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Construction.BuildMode.IBuildMode : 
{
	
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastModeType); // 0x055056e8
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextModeType); // 0x055056e8
	System.Boolean IsExiting(); // 0x054c4760
	System.Void RenderUpdate(); // 0x055049cc
	System.Void LogicUpdate(); // 0x055049cc
	System.Void LateUpdate(); // 0x055049cc
	WizardGames.Soc.Common.Data.EBuildThirdModeType GetBuildModeType(); // 0x0548ba98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildModeBase : System.Object, WizardGames.Soc.SocClient.Construction.BuildMode.IBuildMode
{
	static SocLogger Logger; // 0x0
	WizardGames.Soc.Common.Unity.Event.MsgHandler handler; // 0x10
	System.Int32 ModeId; // 0x18
	System.Boolean <NeedSwitchHeldItem>k__BackingField; // 0x1c
	System.Boolean isExiting; // 0x1d
	System.Int32 markId; // 0x20
	WizardGames.Soc.SocClient.Manager.BuildOperationBase get_buildOperationBase(); // 0x06bc7804
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase get_curBuildItemData(); // 0x06bc78d4
	System.Boolean get_NeedSwitchHeldItem(); // 0x06bc7948
	System.Void set_NeedSwitchHeldItem(System.Boolean value); // 0x06bc79ac
	WizardGames.Soc.Common.Data.constraction.BuildThirdMode get_modeConfig(); // 0x06bc7a28
	WizardGames.Soc.SocClient.Ui.ConstructionInfoData get_constructionInfoData(); // 0x06bc7b14
	static WizardGames.Soc.SocClient.Ui.UiHudElemBuildOk get_btnBuildOk(); // 0x06bae3d0
	static WizardGames.Soc.SocClient.Ui.UiHudElemBuildOk get_btnBuildOkLeft(); // 0x06bae4dc
	static WizardGames.Soc.SocClient.Ui.UiHudElemBuildTurnRight get_btnTurn(); // 0x06bc2798
	static WizardGames.Soc.SocClient.Ui.UiHudElemBuildDelete get_btnBuildDelete(); // 0x06bc2724
	static WizardGames.Soc.SocClient.Ui.UiHudElemBuildExitDeploy get_buildExitDeploy(); // 0x06bb85ac
	static WizardGames.Soc.SocClient.Ui.UiHudElemBtnWujiTurnLeft get_btnBpTurnLeft(); // 0x06baf268
	static WizardGames.Soc.SocClient.Ui.UiHudElemBtnWujiTurnRight get_btnBpTurnRight(); // 0x06baf1f4
	static WizardGames.Soc.SocClient.Ui.UiHudElemBtnRaise get_btnRaise(); // 0x06baf10c
	static WizardGames.Soc.SocClient.Ui.UiHudElemBtnDown get_btnDown(); // 0x06baf180
	static WizardGames.Soc.SocClient.Ui.UiHudElemAutoSnapOption get_btnAutoSnapOption(); // 0x06bc7ba4
	static WizardGames.Soc.SocClient.Ui.UiHudElemWithToolCupboard get_uiWithToolCupboard(); // 0x06baefa0
	WizardGames.Soc.SocClient.Ui.UiElectricInfo get_UiElectricInfo(); // 0x06bbc1a4
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastModeType); // 0x06bb31b4
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextModeType); // 0x06bb5020
	System.Void RenderUpdate(); // 0x055049cc
	System.Void LateUpdate(); // 0x055049cc
	System.Void LogicUpdate(); // 0x055049cc
	WizardGames.Soc.Common.Data.EBuildThirdModeType GetBuildModeType(); // 0x06bc81a8
	System.Void ShowHudElem(WizardGames.Soc.SocClient.Ui.UiHudElem hudElem); // 0x06bc83a0
	System.Void HideHudElem(WizardGames.Soc.SocClient.Ui.UiHudElem hudElem); // 0x06bae444
	System.Void SetBuildModeHudElemState(WizardGames.Soc.SocClient.Ui.UiHudElem hudElem, System.Boolean isShow); // 0x06baf014
	System.Void SetBuildOkBtnCdTimeStampSec(System.Int64 endTimeStampSec, System.Int32 cdTimeSec, System.Action callback); // 0x06baecf8
	System.Void OnPartEntityRemove(System.Int64 partId); // 0x06bc16ac
	System.Boolean EquipHoldItem(); // 0x06bc7c18
	System.Void .ctor(System.Int32 modeId); // 0x06bc2224
	System.Boolean IsExiting(); // 0x06bc8434
	System.Int32 GenerateMarkId(); // 0x06bc8498
	static System.Void .cctor(); // 0x06bc8504
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Construction.BuildMode.IBuildWireMode : 
{
	
	System.Void CheckCancelOutlineAndHighLightState(); // 0x055049cc
	System.Void UpdateBtnEWireState(WizardGames.Soc.SocClient.Construction.BuildMode.EWireState EWireState, System.Boolean force); // 0x0550f700
	System.Void CheckHaveElectricity(); // 0x055049cc
	System.Int32 get_NowSubMode(); // 0x0548ba98
	WizardGames.Soc.SocClient.Construction.BuildMode.EIntelligentWireState get_CurIntelligentWireState(); // 0x0548ba98
	System.Boolean get_IsInIntelligentWireState(); // 0x054c4760
	WizardGames.Soc.SocClient.Construction.BuildMode.EWireState get_CurEWireState(); // 0x0548ba98
	System.Collections.Generic.List<WizardGames.Soc.Common.Electric.IOSlotBase> get_ioSlots(); // 0x054e7844
	WizardGames.Soc.Common.Electric.IOSlotBase get_CurrentLookSelectSlot(); // 0x054e7844
	System.Void SetSelectSlot(WizardGames.Soc.Common.Electric.IOSlotBase selectSlotBase); // 0x05523a54
	System.Boolean FilterOutline(System.Int64 entityId); // 0x054c5f44
	System.Void ClientRequestClearWire(); // 0x055049cc
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Construction.BuildMode.IPlaceMode : 
{
	
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.WireTool : System.Object
{
	static SocLogger Logger; // 0x0
	System.Single remainingDist; // 0x10
	WizardGames.Soc.Common.Unity.Electric.ClientIOLine pendingLine; // 0x18
	WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug Pending; // 0x20
	WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug <AimLockPending>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug CheckTarget; // 0x60
	System.Single clearProgress; // 0x80
	WizardGames.Soc.SocClient.Construction.WireAutoTool wireAutoTool; // 0x88
	static System.Boolean AutoConnectionWire; // 0x8
	static System.Single HitPointOffset; // 0xc
	System.Collections.Generic.List<WizardGames.Soc.Common.Electric.IOSlotBase> PendingAvailableSlotLst; // 0x90
	System.Boolean <CanLayoutPoint>k__BackingField; // 0x98
	WizardGames.Soc.Common.Unity.Electric.WireColour <WireColourValue>k__BackingField; // 0x9c
	WizardGames.Soc.SocClient.Construction.BuildMode.CachedWireInfo CachedInfo; // 0xa0
	System.Boolean isFlowColorState; // 0xa8
	System.Single get_MaxWireLength(); // 0x06bc85d8
	System.Int32 get_MaxLineNodes(); // 0x06bc86c8
	WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug get_AimLockPending(); // 0x06bc87b0
	System.Void set_AimLockPending(WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug value); // 0x06bc882c
	System.Int32 get_PointCount(); // 0x06bbb604
	System.Boolean get_CanLayoutPoint(); // 0x06bc88c8
	System.Void set_CanLayoutPoint(System.Boolean value); // 0x06bc892c
	static System.Int32 get_NowWireSubModeType(); // 0x06bc89a8
	WizardGames.Soc.Common.Unity.Electric.WireColour get_WireColourValue(); // 0x06bc8abc
	System.Void set_WireColourValue(WizardGames.Soc.Common.Unity.Electric.WireColour value); // 0x06bc8b20
	System.Void Init(); // 0x06bc8b98
	System.Void ClearPendingInfo(); // 0x06bb7938
	System.Void ClearPendingPlug(); // 0x06bc8f44
	System.Boolean HasPendingPlug(); // 0x06bb67bc
	System.Boolean HasAimLockPendingPlug(); // 0x06bc9180
	WizardGames.Soc.Common.Unity.Electric.IOSlot GetPendingIOSlot(WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug pendingPlug); // 0x06bbb424
	System.Boolean PendingPlugIsInput(); // 0x06bbe038
	System.Boolean PendingPlugIsOutput(); // 0x06bbe0b0
	System.Boolean PendingPlugRoot(); // 0x06bc5508
	System.Int32 get_PendingPlugExistMode(); // 0x06bc54a4
	System.Void BeginLine(UnityEngine.Vector3 startWorldPos); // 0x06bc9444
	System.Void EndLine(System.Boolean destroy); // 0x06bc8fb8
	System.Void OnClickLeftButton(); // 0x06bc0e98
	System.Void PlayMidPointEffect(UnityEngine.Vector3 pos); // 0x06bca058
	System.Void PlayHeadTailEffect(UnityEngine.Vector3 pos); // 0x06bca1b0
	System.Void OnRightButtonReleased(); // 0x06bc1b9c
	System.Void ResetClearProgress(); // 0x06bc1cb4
	System.Void Update(); // 0x06bbaadc
	UnityEngine.Color GetLineColor(System.Boolean bHit); // 0x06bca39c
	System.Boolean HasPendingWire(); // 0x06bca308
	WizardGames.Soc.Common.Component.ElectricBaseComponent GetLookingAtIOEnt(); // 0x06bca8f4
	System.Void SetLockTargetEnt(WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug looking); // 0x06bba3d4
	System.Void SetCheckTargetAtEnt(WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug checkTarget); // 0x06bcab04
	System.Void ClientAttemptConnection(System.Boolean input, System.Int32 index); // 0x06bc9c18
	System.Void TryMakeupAndChangeLine(WizardGames.Soc.Common.Electric.CachedConnectedInfo info); // 0x06bcbe98
	System.Void MakeupLine(WizardGames.Soc.Common.Component.ElectricBaseComponent module, System.Boolean isInput, System.Int32 index, WizardGames.Soc.Common.Electric.EMakeConnectionReason reason); // 0x06bcae00
	System.Void AutoConnectSlots(System.Boolean input, WizardGames.Soc.Common.Component.ElectricBaseComponent module, WizardGames.Soc.Common.Electric.IOSlotBase slot, System.Boolean pendingInput, System.Int32 pendingIndex); // 0x06bcb610
	System.Void MakeConnection(System.Int64 inputId, System.Int32 inputIndex, System.Int64 outputId, System.Int32 outputIndex, WizardGames.Soc.Common.Unity.Electric.WireColour color, System.Collections.Generic.List<UnityEngine.Vector3> linePositions, WizardGames.Soc.Common.Electric.EMakeConnectionReason reason); // 0x06bcc204
	static System.Boolean CanPlayerUseWires(); // 0x06bcaba0
	System.Single GetPendingLengthRemaining(); // 0x06bbc0f4
	static System.Boolean IsHaveSlot(WizardGames.Soc.Common.Component.ElectricBaseComponent module, System.Boolean input, System.Int32 index); // 0x06bcc394
	static System.Boolean IsSlotOccupied(WizardGames.Soc.Common.Component.ElectricBaseComponent module, System.Boolean input, System.Int32 index); // 0x06bcc450
	System.Boolean IsSlotValidType(WizardGames.Soc.Common.Component.ElectricBaseComponent module, System.Boolean input, System.Int32 index); // 0x06bcabfc
	System.Void OnClearUp(); // 0x06bb5730
	System.Int32 GetWireClicksRemaining(); // 0x06bc9f68
	static WizardGames.Soc.Common.Unity.Electric.ClientIOLine CreateLine(UnityEngine.Vector3 spawnPos, UnityEngine.Quaternion rotation, WizardGames.Soc.Common.Unity.Electric.WireColour color, System.Int32 lineType); // 0x06bc9714
	System.Void RecoverWireColorConfig(); // 0x06bc8bfc
	System.Boolean RecoverWiringConfig(); // 0x06bb3470
	System.Void SetPendingData(WizardGames.Soc.Common.Component.ElectricBaseComponent module, System.Boolean isInput, System.Int32 slotIndex, System.Boolean filterAvailable); // 0x06bc90c8
	System.Void SelectPendingSlot(WizardGames.Soc.Common.Electric.IOSlotBase slotBase, System.Boolean filterAvailable); // 0x06bb6878
	System.Void RefreshPendingAvailableSlotLst(System.Boolean filterAvailable); // 0x06bcc6e4
	System.Void ClearWiringCache(System.Boolean justNow); // 0x06bc1d84
	System.Void ClearOneWiringCache(); // 0x06bc1d18
	System.Void SaveWireColorConfig(); // 0x06bb5cd8
	static UnityEngine.Color get_defaultFlowColor(); // 0x06bccba8
	UnityEngine.Color get_inputFlowColor(); // 0x06bcccac
	UnityEngine.Color get_outputFlowColor(); // 0x06bccdb8
	System.Void UdpateFlowColor(System.Boolean isResetDefaultColor); // 0x06bcaa00
	System.Void UpdateColor(System.Boolean isResetDefaultColor); // 0x06bccec4
	System.Void UpdateInputColor(System.Boolean isResetDefaultColor); // 0x06bcd124
	System.Void UpdateOutputColor(System.Boolean isResetDefaultColor); // 0x06bcd4f0
	System.Void .ctor(); // 0x06bcd980
	static System.Void .cctor(); // 0x06bcdb68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.CachedWireInfo : System.Object
{
	System.Collections.Generic.List<UnityEngine.Vector3> points; // 0x10
	WizardGames.Soc.Common.Component.ElectricBaseComponent module; // 0x18
	System.Boolean isInput; // 0x20
	System.Int32 slotIndex; // 0x24
	UnityEngine.Vector3 modulePos; // 0x28
	UnityEngine.Vector3 rotate; // 0x34
	System.Void SetCache(System.Boolean input, System.Int32 index, WizardGames.Soc.Common.Component.ElectricBaseComponent module); // 0x06bcac90
	WizardGames.Soc.Common.Electric.IOSlotBase GetIOSlotBase(); // 0x06bb3990
	System.Void ClearCache(); // 0x06bcca58
	System.Boolean PreCheck(); // 0x06bcc520
	System.Void ClearOnePoint(); // 0x06bccaf8
	System.Void .ctor(); // 0x06bcdab4
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug : System.ValueType
{
	System.Int64 entityId; // 0x10
	WizardGames.Soc.Common.Component.ElectricBaseComponent electricBaseComp; // 0x18
	WizardGames.Soc.Common.Component.ConstructionBaseComponent constructionBaseCom; // 0x20
	System.Boolean Input; // 0x28
	System.Int32 Index; // 0x2c
	WizardGames.Soc.Common.Component.ElectricBaseComponent get_ElectricBaseComp(); // 0x06bcdc5c
	System.Void set_ElectricBaseComp(WizardGames.Soc.Common.Component.ElectricBaseComponent value); // 0x06bba2e4
	System.Int32 PendingPartState(); // 0x06bc92f0
	System.Boolean IsSlotOccupied(); // 0x06bb8050
	System.Boolean IsHaveSlot(); // 0x06bca810
	WizardGames.Soc.Common.Electric.IOSlotBase GetIOSlotBase(); // 0x06bb9b2c
	System.Collections.Generic.List<WizardGames.Soc.Common.Electric.IOSlotBase> GetAllSolotList(); // 0x06bcdcc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieBlueprintBuildMode : WizardGames.Soc.SocClient.Construction.BuildMode.BuildPiePlaceModeBase
{
	ConstructionBluePrint CurHoldingConstructionBlueprint; // 0x310
	WizardGames.Soc.Common.Unity.Construction.BuildingTarget blueprintBuildingTarget; // 0x318
	System.Int32 <CurHoldingBlueprintType>k__BackingField; // 0x3a0
	System.String blueprintResPath; // 0x3a8
	System.UInt64 blueprintAsyncId; // 0x3b0
	System.Boolean isBlueprintTurning; // 0x3b8
	UnityEngine.Vector3 blueprintRotationOffset; // 0x3bc
	System.Int32 blueprintTurnDir; // 0x3c8
	System.Int32 get_CurHoldingBlueprintType(); // 0x06bce04c
	System.Void set_CurHoldingBlueprintType(System.Int32 value); // 0x06bce0b0
	System.Void .ctor(System.Int32 modeId); // 0x06bce128
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastMode); // 0x06bce218
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextMode); // 0x06bce46c
	System.Void LogicUpdate(); // 0x06bce998
	System.Void RaiseHoldingConstructionByDirAndHeight(System.Int32 dir, System.Single moveStep); // 0x06bcea9c
	System.Void CheckShowBlueprintCD(); // 0x06bcea08
	System.Void SetBuildItemData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06bcebdc
	System.Void OnClickConstructionType(System.Int64 itemId, System.Int64 comboId, System.Boolean isBlueprint); // 0x06bcecc4
	System.Void OnInventoryItemChange(); // 0x06bcfa90
	System.Void ShowConstructionBlueprintTip(); // 0x06bcf1e0
	System.Void TestHoldingBluePrint(System.Int32 type, System.Boolean force); // 0x06bcee78
	System.Void ClearHoldingBlueprintConstruction(); // 0x06bce754
	System.Void CreateConstructionBlueprintFinish(UnityEngine.GameObject instanceGo, System.Int32 type); // 0x06bcfbe8
	System.Void RefreshBlueprintCDTime(); // 0x06bcfe2c
	System.Void EnterConstructionBlueprintMode(); // 0x06bcede8
	System.Void SetBpEditBtnState(System.Boolean isShow); // 0x06bcfaf4
	System.Void PlaceHoldingObject(); // 0x06bd0188
	System.Void PlaceHoldingConstructionBlueprint(); // 0x06bd0234
	System.Void OnConfirmBuildOk(); // 0x06bd0974
	System.Boolean PlaceOnCreate(); // 0x06bd0ab4
	System.Boolean RequestCreateConstructionBlueprint(); // 0x06bd0b70
	System.Boolean IsUnlockConstructionBlueprint(); // 0x06bd0848
	System.Void TestTurnHoldingBlueprint(System.Int32 dir); // 0x06bd1910
	System.Void TestStopTurnHoldingBlueprint(); // 0x06bd1990
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieBlueprintBuildMode.<>c__DisplayClass21_0 : System.Object
{
	WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieBlueprintBuildMode <>4__this; // 0x10
	System.Int32 type; // 0x18
	System.Void .ctor(); // 0x06bd2034
	System.Void <TestHoldingBluePrint>b__0(UnityEngine.GameObject go, System.Object[] objs); // 0x06bd209c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieCoreMode : WizardGames.Soc.SocClient.Construction.BuildMode.BuildPiePlaceModeBase
{
	WizardGames.Soc.Common.Entity.PartEntityPrebuild holdingCombinePart; // 0x310
	WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget combineVirtualTarget; // 0x318
	System.Int64 <CurComboId>k__BackingField; // 0x3b0
	WizardGames.Soc.Common.Construction.TerrainSocketRuntime _foundationTerrainSocketData; // 0x3b8
	System.Single terrainSocketOriginPosY; // 0x3c0
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.SimpleCreatePartData> multiCreatePartDataList; // 0x3c8
	static WizardGames.Soc.Common.Construction.ConstructionGrade defaultConstructionGrade; // 0x0
	System.Int64 get_CurComboId(); // 0x06bd21fc
	System.Void set_CurComboId(System.Int64 value); // 0x06bd2260
	System.Void OnRotateCurHoldPart(); // 0x06bd22d8
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastMode); // 0x06bd24cc
	System.Void SetBuildItemData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06bd2cbc
	System.Void CreatePartOver(System.Int64 markId, System.Int64 itemUid); // 0x06bd3038
	System.Void OnInventoryItemChange(); // 0x06bd3140
	System.Void PlaceHoldingObject(); // 0x06bd34f4
	System.Void RefreshRaiseAndDownButtonState(); // 0x06bd4a44
	System.Void RaiseHoldingConstructionByDirAndHeight(System.Int32 dir, System.Single step); // 0x06bd4b58
	System.Boolean PlaceOnCreate(); // 0x06bd4e98
	System.Void OnClickConstructionType(System.Int64 itemId, System.Int64 comboId, System.Boolean isBlueprint); // 0x06bd2eac
	System.Void CreateHoldingObject(System.Int64 type, System.Int64 comboId); // 0x06bd7f48
	System.Void OnInstantiateAsyncComplete(); // 0x06bd870c
	System.Void SetSocketAndMeshRoot(); // 0x06bd8418
	System.Void ShowCurCostTipInfo(); // 0x06bd3264
	System.Void HandleCombineConstruction(System.Int64 itemId, System.Int32 itemCount, WizardGames.Soc.Common.Data.constraction.BuildingCore coreConfig, System.String labelName, System.String labelDes); // 0x06bd9034
	System.Boolean IsConstructionUnlocked(); // 0x06bd9aec
	WizardGames.Soc.Common.Data.constraction.BuildingCore GetCoreConfig(); // 0x06bd89c8
	System.ValueTuple<System.String,System.String> GetCoreLabels(WizardGames.Soc.Common.Data.constraction.BuildingCore coreConfig); // 0x06bd8ab4
	System.ValueTuple<System.Int64,System.Int32> GetBuildCostConfig(WizardGames.Soc.Common.Data.constraction.BuildingCore coreConfig); // 0x06bd8b7c
	System.Boolean IsNotInCombineState(); // 0x06bd8d64
	System.Void HandleBaseConstruction(WizardGames.Soc.Common.Data.constraction.ConstructionComboConfig comboConfig, System.String labelName, System.String labelDes, System.Int64 itemId, System.Int32 itemCount); // 0x06bd8dd0
	System.Void UpdateConstructionInfoForCore(System.String labelName, System.String labelDes, System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemNeedDic); // 0x06bda1bc
	System.Void UpdateConstructionInfoForCombo(WizardGames.Soc.Common.Data.constraction.ConstructionComboConfig comboConfig, System.String labelName, System.String labelDes, System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemNeedDic); // 0x06bd9c1c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UIConstructionBaseDetailInfo> GetChildParts(WizardGames.Soc.Common.Data.constraction.ConstructionComboConfig comboConfig); // 0x06bda4b4
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UIConstructionBaseDetailInfo> GetCombineOtherParts(WizardGames.Soc.Common.Data.constraction.BuildingCore coreConfig); // 0x06bd9940
	System.Void SetHoldConstruction(System.Int64 constructionId, System.Boolean force, System.Int64 comboId); // 0x06bd2a54
	System.Void RenderUpdate(); // 0x06bda7d4
	System.Void CheckAndClearHoldingCombineObject(); // 0x06bdb1c4
	System.Void PlaceCombineHoldingObj(); // 0x06bda8b8
	System.Void CreateHoldingCombineObject(System.Int32 partType); // 0x06bdb2f0
	System.Void OnInstantiateAsyncCompleteCombine(); // 0x06bdbcb0
	System.Void ClearHoldingObject(); // 0x06bdbf6c
	System.Void ClearHoldingCombineObj(); // 0x06bdb23c
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextMode); // 0x06bdc42c
	System.Void .ctor(System.Int32 modeId); // 0x06bdc768
	static System.Void .cctor(); // 0x06bdc9cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieCoreMode.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieCoreMode.<>c <>9; // 0x0
	static System.Action <>9__23_0; // 0x8
	static System.Action <>9__23_1; // 0x10
	static System.Void .cctor(); // 0x06bdca18
	System.Void .ctor(); // 0x06bdca7c
	System.Void <PlaceOnCreate>b__23_0(); // 0x06bdcae4
	System.Void <PlaceOnCreate>b__23_1(); // 0x06bdcca0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieDeployMode : WizardGames.Soc.SocClient.Construction.BuildMode.BuildPiePlaceModeBase
{
	static SocLogger logger; // 0x0
	System.Int64 <CurSelectedItemUid>k__BackingField; // 0x310
	System.Boolean isShortcutsDeployMode; // 0x318
	System.Single nextClickTime; // 0x31c
	System.String lockAttachedStr; // 0x320
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> curBuildElecItemList; // 0x328
	System.Boolean CampingShowTip; // 0x330
	System.Boolean IsMoveMode; // 0x331
	System.Boolean isDeplyPlaceEnable; // 0x332
	System.Int64 get_CurSelectedItemUid(); // 0x06bdce5c
	System.Void set_CurSelectedItemUid(System.Int64 value); // 0x06bdcec0
	System.Boolean get_IsCampingTentDeployMode(); // 0x06bdcf38
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastMode); // 0x06bdd040
	System.Void OnRotateCurHoldPart(); // 0x06bdd530
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextMode); // 0x06bdd594
	System.Void CloseMoveModeUi(); // 0x06bdd7ec
	System.Void SetBuildItemData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06bdd8c8
	System.Void OnInventoryItemChange(); // 0x06bde038
	System.Void ClearHoldingObject(); // 0x06bde0dc
	System.Void PlaceHoldingObject(); // 0x06bde9f4
	System.Void OnShortcutsChooseMenuStateChange(System.Boolean open); // 0x06bdea68
	System.Void LogicUpdate(); // 0x06bdf0a8
	System.Void SetHoldDeployConstruction(System.Int64 itemId, System.Int64 uid); // 0x06bddc94
	System.Void ShowDeployPlaceTip(System.Int64 itemId, System.Int64 uid); // 0x06bdeb70
	System.Void OnUiInventoryAnyUpdate(); // 0x06be00a0
	System.Void UpdateTips(); // 0x06bdf17c
	System.Void SetWaitMoveDeploy(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06be019c
	System.Boolean IsItemExistInBag(System.Int64 itemUid); // 0x06be05cc
	System.Void CreatePartOver(System.Int64 markId, System.Int64 itemUid); // 0x06be0698
	System.Boolean PlaceOnCreate(); // 0x06be0790
	System.Void CreateHoldingObject(System.Int64 constructionId, System.Int64 comboId); // 0x06be10c4
	System.Void CreateMoveHoldingObject(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06be03f0
	System.Void CreateHoldingObjectFinish(); // 0x06be12d0
	System.Void .ctor(System.Int32 modeId); // 0x06be14fc
	System.Void SetRef(Construction.BuildMode.BuildPieEditBase edit); // 0x06be15f0
	System.Void StopCampingTentDeploying(); // 0x06be16c8
	System.Void UpdateCampintTentCheck(); // 0x06bdfe80
	System.Void OnCampingTentConfirm(); // 0x06be1730
	System.Void OnCampingTentCancel(); // 0x06be267c
	System.Void ToggleCampingTentTip(System.Boolean show, System.Boolean force); // 0x06bde208
	System.Void RequestCreateCampingTent(System.Int64 partType, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget buildingTarget, System.Int64 itemUid, System.Boolean isCombinePart, System.Int64 comboId, System.Boolean requestCreateRelatedPart); // 0x06be1e94
	System.Void TryRemoveAimedConstruction(); // 0x06be278c
	System.Void UpdateRaycastTarget(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06be2828
	System.Void HideEditUINoTarget(); // 0x06be2a1c
	static System.Void .cctor(); // 0x06be2ab4
	System.Void <UpdateTips>b__28_0(); // 0x06be2b88
	System.Void <UpdateTips>b__28_1(); // 0x06be2cac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieDeployMode.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieDeployMode.<>c <>9; // 0x0
	static System.Func<System.Boolean> <>9__43_0; // 0x8
	static System.Void .cctor(); // 0x06be2dc4
	System.Void .ctor(); // 0x06be2e28
	System.Boolean <ToggleCampingTentTip>b__43_0(); // 0x06be2e90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieEditMode : Construction.BuildMode.BuildPieEditBase
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase> buildItemDataList; // 0x50
	WizardGames.Soc.SocClient.Ui.UiHudElemBuildExitDeploy BuildExitDeploy; // 0x58
	System.Boolean isConfirmDoubleCheck; // 0x60
	WizardGames.Soc.SocClient.Manager.BuildPieOperation get_buildPieOperation(); // 0x06be2ef4
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> get_itemNeedDic(); // 0x06be2f8c
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastModeType); // 0x06be301c
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextModeType); // 0x06be3198
	System.Void BuildModeCancelEvent(); // 0x06be3244
	System.Void RenderUpdate(); // 0x06be32bc
	System.Void OnTerritoryAtted(System.Int64 terrEntityId, System.Int64 stateTs); // 0x06be3324
	System.Void LogicUpdate(); // 0x06be3428
	System.Void HideEditUINoTarget(); // 0x06be3490
	System.Void UpdateDeployMoveCd(); // 0x06be33a4
	System.Void DoubleCheckConfirm(); // 0x06be3508
	System.Void TryEnterDeployMoveState(); // 0x06be3588
	System.Void ConfirmBuildOkEvent(); // 0x06be368c
	System.Void ConfirmBuildEditEvent(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase selectItemData); // 0x06be36fc
	System.Void HandleCommonEditEvent(WizardGames.Soc.SocClient.Ui.Construction.EditPartViewData editPartViewData); // 0x06be3f7c
	System.Boolean CheckCanModify(); // 0x06be41dc
	System.Boolean CanUpgrade(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase targetBuildItemData); // 0x06be40cc
	System.Void UpdateRaycastTarget(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06be43d0
	System.Void ReleaseData(); // 0x06be476c
	System.Void GetPieEditData(); // 0x06be53a8
	System.Void GetChangeData(); // 0x06be493c
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase AddBuildData(WizardGames.Soc.Common.Data.constraction.BuildingCore buildingCore, System.Int32 grade, System.Boolean isUpgrade, System.Int32 priority, System.Int32 priorityPie, System.Boolean addData); // 0x06be5890
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase AddBuildData(WizardGames.Soc.Common.Data.constraction.ConstructionComboChildGroupConfig childGroupConfig, System.Int32 grade, System.Boolean isUpgrade, System.Boolean addData); // 0x06be5a0c
	System.Void AddBuildData(WizardGames.Soc.SocClient.Ui.Construction.EBuildEditType editType, System.Boolean isGrayed, System.Boolean addData); // 0x06be5708
	System.Void AddBuildData(System.Int32 grade, System.Boolean isGrayed, System.Boolean addData); // 0x06be5550
	System.Void .ctor(System.Int32 modeId); // 0x06be5b64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieEmptyHandMode : Construction.BuildMode.BuildPieEditBase
{
	
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastModeType); // 0x06be5c30
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextModeType); // 0x06be5cfc
	System.Void ConfirmBuildOkEvent(); // 0x06be5d7c
	System.Void UpdateRaycastTarget(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06be5ddc
	System.Void HideEditUINoTarget(); // 0x06be6068
	System.Void .ctor(System.Int32 modeId); // 0x06be6100
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildPiePlaceModeBase : WizardGames.Soc.SocClient.Construction.BuildMode.BuildModeBase, WizardGames.Soc.SocClient.Construction.BuildMode.IPlaceMode
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Entity.PartEntityPrebuild <HoldingConstruction>k__BackingField; // 0x28
	WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget VirtualBuildingTargetRuntime; // 0x30
	UnityEngine.Vector3 RotationOffset; // 0xc8
	UnityEngine.RaycastHit hitInfo; // 0xd4
	WizardGames.Soc.Common.Construction.SocketRuntimeBase BufferSocketData; // 0x100
	WizardGames.Soc.Common.Entity.PartEntity BufferParentPart; // 0x108
	WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget LastPlacement; // 0x110
	WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget LastPlacementNoMono; // 0x1a8
	WizardGames.Soc.Common.Entity.PartEntity <CachedOldPart>k__BackingField; // 0x240
	System.Int64 cachedOldPartTerritoryId; // 0x248
	Construction.BuildMode.BuildPieEditBase editBase; // 0x250
	WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget lastFoundTarget; // 0x258
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.PartEntity> lastFoundPartGoesInSocketSnap; // 0x2f0
	System.Boolean isCampingTentDeploying; // 0x2f8
	System.Single startCampingTentChcekTime; // 0x2fc
	WizardGames.Soc.SocClient.Manager.ERaiseBlueprintState RaiseBlueprintState; // 0x300
	static System.Single RaiseStep; // 0x8
	static System.Single ShorPressTime; // 0xc
	System.Single startRaiseTime; // 0x304
	System.Int32 currentRaiseDir; // 0x308
	System.Boolean sleepingBagCDShareTip; // 0x30c
	System.Boolean isConfirmDoubleCheck; // 0x30d
	WizardGames.Soc.SocClient.Manager.BuildPieOperation get_buildPieOperation(); // 0x06be0104
	WizardGames.Soc.Common.Entity.PartEntityPrebuild get_HoldingConstruction(); // 0x06be6180
	System.Void set_HoldingConstruction(WizardGames.Soc.Common.Entity.PartEntityPrebuild value); // 0x06be61e4
	WizardGames.Soc.Common.Entity.PlayerEntity get_selfPlayer(); // 0x06be6264
	UnityEngine.Camera get_mainCam(); // 0x06be6300
	WizardGames.Soc.Common.Entity.PartEntity get_CachedOldPart(); // 0x06be6364
	System.Void set_CachedOldPart(WizardGames.Soc.Common.Entity.PartEntity value); // 0x06be63c8
	System.Boolean get_isMoving(); // 0x06be6448
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastMode); // 0x06bd26ac
	System.Void BuildModeCancelEvent(); // 0x06be64f8
	System.Void OnInventoryItemChange(); // 0x06bd3204
	System.Void SetBuildItemData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06bd2e38
	System.Void StopRaise(); // 0x06be6598
	System.Void HoldingStateChange(); // 0x06bd8318
	System.Void SetBuildConfirmBtnState(System.Boolean enable, WizardGames.Soc.SocClient.Ui.EBuildButtonMode mode); // 0x06be6870
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextBuildModeType); // 0x06bdc67c
	System.Void HideAllHudElem(); // 0x06be6a90
	System.Void OnRaiseStart(System.Int32 dir); // 0x06be6bb8
	System.Void OnRaiseEnd(System.Int32 dir); // 0x06be6c44
	System.Void OnRaiseStep(System.Int32 dir); // 0x06be6cbc
	System.Void ProcessBlueprint(); // 0x06be6d74
	System.Void RaiseHoldingConstructionByDirAndHeight(System.Int32 dir, System.Single moveHeight); // 0x06bd4e10
	System.Void CreateHoldingObject(System.Int64 type, System.Int64 comboId); // 0x06be1254
	System.Void OnConfirmBuildOk(); // 0x06be6e74
	System.Void CreatePartOver(System.Int64 markId, System.Int64 itemUid); // 0x06bd30c0
	System.Boolean CheckPersonalLimit(System.Int64 type); // 0x06be6fc4
	System.Boolean CheckConsumeItem(System.Int64 type, System.Int64 grade); // 0x06be7240
	System.Boolean CheckConsumeItem(System.Int64 type1, System.Int64 type2, System.Int64 grade); // 0x06bd6568
	System.Boolean CheckCreateCondition(WizardGames.Soc.Common.Construction.ConstructionGrade grade); // 0x06bd5e30
	System.Boolean PlaceOnCreate(); // 0x06bd5dcc
	System.Void ClearHoldingObject(); // 0x06bdc008
	System.Void RequestCreateComboPart(System.Int64 partType, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget buildingTarget, System.Int32 comboId, System.Int32 grade, System.Action actionRequestSucceed); // 0x06bd7190
	WizardGames.Soc.Common.SimpleCustom.SimpleCreatePartData CreateACreatePartData(System.Int64 partType, System.Int32 grade, UnityEngine.Vector3 posParam, UnityEngine.Quaternion rotation, System.Int64 targetPartId, System.Int32 targetSocketId, System.Int32 holdingMaleSocketId, System.Int64 markId, System.Int64 itemUid, System.Boolean requestCreateRelatedPart); // 0x06bd6c6c
	System.Void RequestCreateMultiCoreParts(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.SimpleCreatePartData> createPartDatas); // 0x06bd6e6c
	System.Void RequestCreateOrMovePart(System.Int64 partType, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget buildingTarget, System.Int64 itemUid, System.Boolean isCombinePart, System.Int64 comboId, System.Boolean requestCreateRelatedPart, System.Int32 grade, System.Action actionRequestSucceed); // 0x06bd7734
	System.Void OpenTentUI(); // 0x06be866c
	System.Void RequestMovePart(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget buildingTarget); // 0x06be7e94
	System.Void RenderUpdate(); // 0x06bda840
	System.Void LateUpdate(); // 0x06be8c80
	System.Void LogicUpdate(); // 0x06bdf11c
	System.Boolean CheckSocketLegal(WizardGames.Soc.Common.Component.ConstructionSocketBaseComponent selfSocketComponent, WizardGames.Soc.Common.Entity.PartEntity parentPart, WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData, UnityEngine.Ray ray, System.Single buildDistance); // 0x06be8ce0
	System.Void FindAppropriateSocketAlpha3(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, WizardGames.Soc.Common.Entity.PartEntity construction); // 0x06be8ff4
	System.Void FindTerrainPlacementAlpha3(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, WizardGames.Soc.Common.Entity.PartEntity construction); // 0x06be9c20
	System.Void TryRotateHoldingObject(); // 0x06bd233c
	System.Void FillPlacementAlpha3(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, WizardGames.Soc.Common.Entity.PartEntity construction); // 0x06bea0f8
	UnityEngine.Vector3 GetSelfPosition(); // 0x06bdb778
	UnityEngine.Quaternion GetSelfRotation(); // 0x06be9b50
	System.Void SetHoldingObjValidNoMono(System.Boolean valid, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, System.Boolean force); // 0x06bdb838
	System.Void ShowAndHideSleepingBagTip(System.Boolean show); // 0x06be65fc
	System.Boolean IsInWater(UnityEngine.Vector3 vPoint); // 0x06bdb484
	System.Void PlaceHoldingObject(); // 0x06bd3560
	System.Void MovePartPending(); // 0x06bea234
	static System.Void FindInvalidReasonAndShow(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget buildingTarget); // 0x06be780c
	System.Void .ctor(System.Int32 modeId); // 0x06bdc854
	System.Void OnTerritoryAtted(System.Int64 terrEntityId, System.Int64 stateTs); // 0x06beaf5c
	System.Void DoubleCheckConfirm(); // 0x06beb0a8
	System.Void SetupAndCallRecoverDoubleCheck(); // 0x06bd634c
	static System.Void .cctor(); // 0x06beb128
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildPiePlaceModeBase.<>c__DisplayClass65_0 : System.Object
{
	WizardGames.Soc.SocClient.Construction.BuildMode.BuildPiePlaceModeBase <>4__this; // 0x10
	UnityEngine.Vector3 pos; // 0x18
	WizardGames.Soc.Common.Algorithm.Vector3 angle; // 0x24
	System.Void .ctor(); // 0x06be8c18
	System.Void <RequestMovePart>b__0(); // 0x06beb214
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildPiePlayerBlueprintMode : WizardGames.Soc.SocClient.Construction.BuildMode.BuildPiePlaceModeBase
{
	static System.Single MaxSnapDistance; // 0x0
	System.Int64 _holdingPlayerBlueprintId; // 0x310
	System.Single _holdingMaxDistance; // 0x318
	UnityEngine.GameObject _holdingObject; // 0x320
	UnityEngine.MeshRenderer _holdingObjectMeshRenderer; // 0x328
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.CheckConfigBase> _checkConfigBases; // 0x330
	WizardGames.AssetPool.AssetPoolHandle[] _validMaterials; // 0x338
	System.Int64 curCustomBlueprintId; // 0x340
	System.Int64 curCustomBlueprintSlotId; // 0x348
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> blueprintCostItemDic; // 0x350
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveData> curBlueprintPartDataList; // 0x358
	UnityEngine.Vector3 blueprintRotationOffset; // 0x360
	System.Single posYOffset; // 0x36c
	System.Boolean isInPlaceCdState; // 0x370
	System.Int32 blueprintTurnDir; // 0x374
	System.Single raiseStep; // 0x378
	System.Collections.Generic.HashSet<System.Int32> ignoreCheckType; // 0x380
	System.Boolean isBlueprintTurning; // 0x388
	System.Void .ctor(System.Int32 modeId); // 0x06beb364
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastMode); // 0x06beb5e4
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextBuildModeType); // 0x06beb8d0
	System.Void LogicUpdate(); // 0x06bebc24
	System.Void TurnHoldingBlueprint(System.Int32 dir); // 0x06bebd24
	System.Void StopTurnHoldingBlueprint(); // 0x06bebda4
	System.Void RaiseHoldingConstructionByDirAndHeight(System.Int32 dir, System.Single moveHeight); // 0x06bebe08
	System.Void CheckShowBlueprintCd(); // 0x06bebc90
	System.Void RefreshBlueprintCdTime(); // 0x06bebf88
	System.Void SwitchHoldingState(System.Boolean show); // 0x06bec3cc
	System.Void OnConfirmBuildOk(); // 0x06bec510
	System.Boolean PlaceOnCreate(); // 0x06bec650
	System.ValueTuple<System.Boolean,System.Int32> CheckCreateBpCD(); // 0x06bed298
	System.Boolean RequestCreateCustomBlueprint(); // 0x06bec700
	System.Void ReceiveBlueprintPartDataList(System.Int64 blueprintId, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveData> blueprintPartDataList); // 0x06bed488
	System.Void OnInventoryItemChange(); // 0x06bedb60
	System.Void RefreshBuildTip(); // 0x06bed634
	System.Void SetBuildItemData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06bedbcc
	System.Void SetHoldingBlueprintIDAndGo(System.Int64 blueprintId, UnityEngine.GameObject gameObject); // 0x06bedf20
	System.Void ClearHoldingObject(); // 0x06bee974
	System.Void GetCheckConfigList(); // 0x06bee8b0
	UnityEngine.Quaternion UpdateRotation(UnityEngine.Vector3 dir, UnityEngine.Vector3 rotation); // 0x06beebe4
	System.Void SetHoldingObjectValid(System.Boolean isValid); // 0x06beeed0
	System.Void PlaceHoldingObject(); // 0x06bef048
	static System.Void .cctor(); // 0x06bef700
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieWireMode : WizardGames.Soc.SocClient.Construction.BuildMode.BuildModeBase, WizardGames.Soc.SocClient.Construction.BuildMode.IBuildWireMode
{
	WizardGames.Soc.SocClient.Ui.UiHudElectricWireInfo wireInfo; // 0x28
	WizardGames.Soc.SocClient.Ui.UiHudElectricWireModifyInfo wireModifyInfo; // 0x30
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnAutoConnect btnAutoConnect; // 0x38
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnClearWire btnClearWire; // 0x40
	WizardGames.Soc.SocClient.Ui.UiHudElemClearWirePoint uiHudElemClearWirePoint; // 0x48
	System.Boolean wasPendingInput; // 0x50
	System.Boolean wasPendingOutput; // 0x51
	WizardGames.Soc.Common.Component.ElectricBaseComponent curLockTargetDevice; // 0x58
	System.Int32 lastSelectedIndex; // 0x60
	WizardGames.Soc.SocClient.Construction.BuildMode.EWireState <CurEWireState>k__BackingField; // 0x64
	WizardGames.Soc.SocClient.Construction.BuildMode.EWireTipState curWireTipState; // 0x68
	System.Int32 <NowSubMode>k__BackingField; // 0x6c
	System.Int32 nextRequestTime; // 0x70
	System.Int32 requestInterval; // 0x74
	System.Boolean isShowConstructionInfoTips; // 0x78
	System.Int64 subscribeId; // 0x80
	System.Boolean needRefreshTip; // 0x88
	System.Boolean isShowOutline; // 0x89
	WizardGames.Soc.SocClient.Construction.BuildMode.WireOutlineParam redOutline; // 0x90
	WizardGames.Soc.SocClient.Construction.BuildMode.WireOutlineParam greenOutline; // 0x98
	WizardGames.Soc.SocClient.Construction.BuildMode.WireOutlineParam whiteOutline; // 0xa0
	WizardGames.Soc.SocClient.Construction.BuildMode.WireOutlineParam yellowOutline; // 0xa8
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> WireCreateLinkInfo; // 0xb0
	System.Boolean isFlag; // 0xb8
	System.Int64 timerId1; // 0xc0
	System.Int64 timerId2; // 0xc8
	System.Int64 lastOutlineEntityId; // 0xd0
	UnityEngine.GameObject pluggedHandle; // 0xd8
	UnityEngine.GameObject selectedDefaultHandle; // 0xe0
	UnityEngine.GameObject selectedOccupiedHandle; // 0xe8
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Electric.IOSlotBase,UnityEngine.GameObject> inputHandleDic; // 0xf0
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Electric.IOSlotBase,UnityEngine.GameObject> outputHandleDic; // 0xf8
	System.Collections.Generic.Dictionary<UnityEngine.GameObject,WizardGames.Soc.SocClient.Construction.BuildMode.HandlePrefabInfo> handlePrefabPathDic; // 0x100
	System.Int32 <SelectedIndex>k__BackingField; // 0x108
	System.Boolean <SelectedWasInput>k__BackingField; // 0x10c
	System.Collections.Generic.List<WizardGames.Soc.Common.Electric.IOSlotBase> <ioSlots>k__BackingField; // 0x110
	System.Int32 curIoSlotsIndex; // 0x118
	WizardGames.Soc.Common.Component.ElectricBaseComponent <LookingAt>k__BackingField; // 0x120
	System.Single nextClearSendTime; // 0x128
	System.Boolean isInput; // 0x12c
	WizardGames.AssetPool.AssetPoolHandle inputMaterialHandle; // 0x130
	WizardGames.AssetPool.AssetPoolHandle outputMaterialHandle; // 0x138
	System.Single connectionTimer; // 0x140
	WizardGames.Soc.Common.Component.ElectricBaseComponent cantConnectDevice; // 0x148
	System.Boolean intelligentSlotConfirm; // 0x150
	WizardGames.Soc.Common.Component.ElectricBaseComponent intelligentWireTarget; // 0x158
	System.Single finishLockTimer; // 0x160
	System.Single confirmTargetInterval; // 0x164
	WizardGames.Soc.SocClient.Construction.BuildMode.EIntelligentWireState <CurIntelligentWireState>k__BackingField; // 0x168
	WizardGames.Soc.SocClient.Construction.BuildMode.WireTool get_wireTool(); // 0x06bef74c
	WizardGames.Soc.SocClient.Construction.BuildMode.EWireState get_CurEWireState(); // 0x06bef848
	System.Void set_CurEWireState(WizardGames.Soc.SocClient.Construction.BuildMode.EWireState value); // 0x06bef8ac
	System.Int32 get_NowSubMode(); // 0x06bef924
	System.Void set_NowSubMode(System.Int32 value); // 0x06bef988
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastModeType); // 0x06befa00
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextModeType); // 0x06bf17f8
	System.Void SwitchSubMode(System.Int32 subMode); // 0x06bf03ec
	System.Void ChangeWireColour(WizardGames.Soc.Common.Unity.Electric.WireColour wireColour); // 0x06bf2408
	System.Void SelectTargetSlot(WizardGames.Soc.Common.Electric.IOSlotBase slotBase); // 0x06bf2568
	System.Void OnClickAutoConnect(); // 0x06bf3628
	System.Void OnChangePartGoTransform(System.Int64 entityId); // 0x06bf37f8
	System.Void ClearWire(WizardGames.Soc.Common.Component.ElectricBaseComponent modules); // 0x06bf39a8
	System.Void FinishWire(System.Collections.Generic.List<WizardGames.Soc.Common.Component.ElectricBaseComponent> modules); // 0x06bf3abc
	System.Void UpdateBtnEWireState(WizardGames.Soc.SocClient.Construction.BuildMode.EWireState EWireState, System.Boolean force); // 0x06bf405c
	System.Boolean IsInWiringState(); // 0x06bf4528
	System.Void UpdateBtnWireColorState(); // 0x06bf07b0
	System.Void OnChangeWireColorAck(System.Int32 isSuccess, System.Int64 entityId, System.Int32 type, System.Int32 color); // 0x06bf4624
	System.Void UpdateBtnWireModifyColorState(); // 0x06bf0998
	System.Boolean CheckBuildingPrivilege(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06bf498c
	System.Void RequestElectricalData(); // 0x06bf4ab8
	System.Void UpdateWireTool(); // 0x06bf4da4
	System.Void RenderUpdate(); // 0x06bf6668
	System.Void LateUpdate(); // 0x06bf66cc
	System.Boolean IsHasPower(WizardGames.Soc.Common.Component.ElectricBaseComponent electricBaseComponent); // 0x06bf672c
	System.Void UpdateWiringState(); // 0x06bf611c
	System.Void UpdateTipState(WizardGames.Soc.Common.Unity.Electric.IOSlot ioSlot); // 0x06bf6914
	System.Void LogicUpdate(); // 0x06bf7354
	System.Void WireTipStateControl(WizardGames.Soc.SocClient.Construction.BuildMode.EWireTipState tipState); // 0x06bf67f4
	System.Void ShowTips(System.Int32 index); // 0x06bf744c
	System.Void HideTips(); // 0x06bf73b4
	System.Boolean UpdateLookingAtEnt(); // 0x06bf5a4c
	System.Void RefreshTip(); // 0x06bf0f40
	System.Void RefreshElectricPerformance(); // 0x06bf7dcc
	System.Void ProcessLookingTarget(WizardGames.Soc.Common.Component.ElectricBaseComponent electricBaseComponent); // 0x06bf7e78
	System.Void UpdateHandle(WizardGames.Soc.Common.Component.ElectricBaseComponent electricBaseComponent, System.Boolean isForceUdpate); // 0x06bf8fc8
	System.Void UpdateHandleForce(); // 0x06bf3a40
	System.Void SetLastLookingToNull(); // 0x06bf2020
	WizardGames.Soc.Common.Component.ElectricBaseComponent UpdateLookingAtElectric(); // 0x06bf5518
	System.Void CloseUIInfo(WizardGames.Soc.SocClient.Construction.BuildMode.EElectricInfoGroup type); // 0x06bf6080
	System.Void OnClickAdd(); // 0x06bfa69c
	System.Void SetCheckTargetAtEnt(); // 0x06bfaf50
	System.Void OnPartEntityRemove(System.Int64 partId); // 0x06bfbf44
	System.Void OnPressRemove(); // 0x06bfc408
	System.Void OnReleaseRemove(); // 0x06bfc010
	System.Void .ctor(System.Int32 modeId); // 0x06bfc4a4
	System.Void RefreshTipAndOuoline(); // 0x06bfc828
	System.Void TryRemoveAimedConstruction(); // 0x06bfc8dc
	System.Void TryRotateCurAimConstruction(); // 0x06bfc978
	System.Void UpdateRaycastTarget(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06bfca10
	System.Void HideEditUINoTarget(); // 0x06bfcc5c
	System.Void UpdateOutlineAndHighLightState(WizardGames.Soc.Common.Unity.Electric.IOSlot ioSlot); // 0x06bf6c18
	System.Void EnableAimLockPendingOutline(WizardGames.Soc.SocClient.Construction.BuildMode.WireOutlineParam outlineParam); // 0x06bfce98
	System.Void DisableAimLockPendingOutline(); // 0x06bf220c
	System.Void EnableOutline(WizardGames.Soc.Common.Entity.PartEntity partEntity, WizardGames.Soc.SocClient.Construction.BuildMode.WireOutlineParam outlineParam); // 0x06bfd0a4
	System.Void DisableOutline(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06bfcd0c
	System.Void EnableHightlight(WizardGames.Soc.Common.Component.ElectricBaseComponent baseComponent); // 0x06bf5920
	System.Void SetCurWireEntityId(); // 0x06bfa94c
	System.Void OnWireCreateLinkInfo(System.Int64 sourceEntityId, System.Int64 targetEntityId, WizardGames.Soc.Common.Unity.Electric.ClientIOLine line); // 0x06bfd258
	System.Void CheckOutlineAndHighLightState(); // 0x06bfb31c
	System.Void CheckCancelOutlineAndHighLightState(); // 0x06bf1b80
	System.Boolean FilterOutline(System.Int64 entityId); // 0x06bfd578
	static System.Void OnLinePowerStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int32 oldValue, System.Int32 newValue); // 0x06bfd96c
	System.Void CheckHaveElectricity(); // 0x06bfb9b0
	System.Boolean CheckHaveElectricity(WizardGames.Soc.Common.CustomType.ElectricCBase electricCBase, WizardGames.Soc.Common.Electric.IOSlotBase slotBase); // 0x06bfdaa8
	System.String get_inputDefaultHandlePrefabPath(); // 0x06bfddd0
	System.String get_inputOccupiedHandlePrefabPath(); // 0x06bfdeb8
	System.String get_outputDefaultHandlePrefabPath(); // 0x06bfdfa0
	System.String get_outputOccupiedHandlePrefabPath(); // 0x06bfe088
	System.String get_pluggedDefaultHandlePrefabPath(); // 0x06bfe170
	System.String get_selectedDefaultHandlePrefabPath(); // 0x06bfe258
	System.String get_occupiedDefaultHandlePrefabPath(); // 0x06bfe340
	System.String get_emissionInputMaterialPath(); // 0x06bfe428
	System.String get_emissionOutputMaterialPath(); // 0x06bfe510
	System.Int32 get_SelectedIndex(); // 0x06bfe5f8
	System.Void set_SelectedIndex(System.Int32 value); // 0x06bfe65c
	System.Boolean get_SelectedWasInput(); // 0x06bfe6d4
	System.Void set_SelectedWasInput(System.Boolean value); // 0x06bfe738
	System.Collections.Generic.List<WizardGames.Soc.Common.Electric.IOSlotBase> get_ioSlots(); // 0x06bfe7b4
	WizardGames.Soc.Common.Component.ElectricBaseComponent get_LookingAt(); // 0x06bfe818
	System.Void set_LookingAt(WizardGames.Soc.Common.Component.ElectricBaseComponent value); // 0x06bfe87c
	WizardGames.Soc.Common.Electric.IOSlotBase get_CurrentLookSelectSlot(); // 0x06bf305c
	System.Void SetLookAtDevice(WizardGames.Soc.Common.Component.ElectricBaseComponent module); // 0x06bf77d8
	System.Void SetupHandles(WizardGames.Soc.Common.Component.ElectricBaseComponent module, System.Boolean showInputs, System.Boolean showOutputs); // 0x06bf91a0
	System.Void ClearHandles(); // 0x06bf8c7c
	System.Void ReturnHandle(UnityEngine.GameObject handle); // 0x06bfefa8
	UnityEngine.GameObject CreatePrefab(System.String strPrefab, UnityEngine.Vector3 pos, System.Boolean initMeshRender); // 0x06bfe8fc
	UnityEngine.Vector3 SetHandlePosition(UnityEngine.GameObject mainGo, WizardGames.Soc.Common.Electric.IOSlotBase slotToUse); // 0x06bfec0c
	System.Void SetHandleRotate(UnityEngine.GameObject goHandle, UnityEngine.Vector3 euler, WizardGames.Soc.Common.Entity.PartEntity partEntity, System.Boolean isOccupied); // 0x06bfed04
	System.Void InitMaterialHandle(); // 0x06bff128
	System.Void ReleaseMaterialHandle(); // 0x06bff224
	System.Void SetSelectedHandleMaterial(System.Boolean isInput); // 0x06bfea78
	System.Void SetPluggedHandleMaterial(System.Boolean isInput); // 0x06bff2c4
	System.Void FilterHandle(WizardGames.Soc.Common.Component.ElectricBaseComponent module); // 0x06bf98e4
	System.Void ClearIOSlotData(); // 0x06bf8b98
	System.Void UpdatePluggedHandlePos(System.Boolean needCreate); // 0x06bf2c0c
	System.Void SortHandle(WizardGames.Soc.Common.Component.ElectricBaseComponent module); // 0x06bfa4f4
	System.Void UpdateIoSlotInfo(System.Boolean needSelectSlot); // 0x06bf3e64
	System.Int32 GetFirstEmptyIoSlotIndex(); // 0x06bff430
	System.Void SetSelectSlot(WizardGames.Soc.Common.Electric.IOSlotBase selectSlotBase); // 0x06bf3140
	System.Void UpdateLookingActiveHandle(); // 0x06bf81e8
	System.Void ClearHandleData(); // 0x06bf2094
	System.Void ClientRequestClearWire(); // 0x06bff7a0
	System.Single get_confirmConnectionInterval(); // 0x06bf7ce4
	WizardGames.Soc.SocClient.Construction.BuildMode.EIntelligentWireState get_CurIntelligentWireState(); // 0x06bffdd8
	System.Void set_CurIntelligentWireState(WizardGames.Soc.SocClient.Construction.BuildMode.EIntelligentWireState value); // 0x06bffe3c
	System.Boolean get_IsInIntelligentWireState(); // 0x06bf3db4
	System.Void RecoverIntelligentSearchTargetState(); // 0x06bf76a0
	System.Void ClearIntelligentWireState(); // 0x06bf2160
	System.Void SwitchManualWireEvent(); // 0x06bffeb4
	System.Void SwitchManualWire(); // 0x06c001e8
	WizardGames.Soc.Common.Electric.IOSlotBase TryIntelligentWire(WizardGames.Soc.Common.Component.ElectricBaseComponent lookTarget); // 0x06bf7a30
	System.Void TryConfirmIntelligentConnection(); // 0x06bf7f9c
	System.Void RecordCantConnectDevice(WizardGames.Soc.Common.Component.ElectricBaseComponent electricBaseComponent); // 0x06bf7734
	System.Void SetWireIntelligentState(WizardGames.Soc.SocClient.Construction.BuildMode.EIntelligentWireState state); // 0x06bf29bc
	System.Boolean LockLookingTargetTimer(WizardGames.Soc.Common.Component.ElectricBaseComponent lookTarget); // 0x06bf795c
	System.Boolean StartCalculateWire(WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug& pendingPlug, WizardGames.Soc.SocClient.Construction.BuildMode.PendingPlug& lookPlug); // 0x06c00440
	System.Void <RefreshTip>b__57_0(); // 0x06c00bf8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieWireMode.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieWireMode.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Electric.IOSlotBase> <>9__161_0; // 0x8
	static System.Void .cctor(); // 0x06c01070
	System.Void .ctor(); // 0x06c010d4
	System.Int32 <SortHandle>b__161_0(WizardGames.Soc.Common.Electric.IOSlotBase x, WizardGames.Soc.Common.Electric.IOSlotBase y); // 0x06c0113c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieWireMode.<>c__DisplayClass93_0 : System.Object
{
	WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieWireMode <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.PartEntity source; // 0x18
	WizardGames.Soc.Common.Entity.PartEntity target; // 0x20
	System.Void .ctor(); // 0x06c0129c
	System.Void <OnWireCreateLinkInfo>b__0(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x06c01304
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<System.Int64> safeBoxPath; // 0x18
	static System.Collections.Generic.List<System.Int64> AnywhereInPlayerInventory; // 0x8
	static System.Collections.Generic.List<System.Int64> tempPathList; // 0x10
	System.Action<WizardGames.Soc.Common.Const.ErrorCode> EventInventoryError; // 0x20
	System.Int64 CurUseDeployId; // 0x28
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Event.EventDefine,System.DateTime> lastEventTimes; // 0x30
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Int64> timerIds; // 0x38
	System.Int32 throttleTime; // 0x40
	System.Int64 lastDrinkWaterT; // 0x48
	System.Collections.Generic.Dictionary<System.Int64,System.String> customItemTips; // 0x50
	System.Collections.Generic.List<System.Int64> _targetItemNodePath; // 0x58
	System.Collections.Generic.List<System.Int64> _itemPath; // 0x60
	WizardGames.Soc.Common.CustomType.BaseItemNode cardCurItemNode; // 0x68
	WizardGames.Soc.Common.Entity.PlayerEntity get_Player(); // 0x06c013e8
	WizardGames.Soc.Common.Component.RootNodeComponent get_PlayerRoot(); // 0x06c01484
	WizardGames.Soc.Common.CustomType.SystemRootNode get_InventorySys(); // 0x06c01500
	WizardGames.Soc.Common.Component.PlayerInventoryComponent get_InventoryCom(); // 0x06c01580
	WizardGames.Soc.Common.Component.PlayerSeedBackpackComponent get_SeedCom(); // 0x06c015fc
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_ContainerMainNode(); // 0x06c01678
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_ContainerBeltNode(); // 0x06c016f4
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_ContainerWearNode(); // 0x06c01770
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_ContainerSeedNode(); // 0x06c017ec
	WizardGames.Soc.Common.CustomType.Alpha3ContainerClient get_ContainerMain(); // 0x06c01868
	WizardGames.Soc.Common.CustomType.Alpha3ContainerClient get_ContainerBelt(); // 0x06c018dc
	WizardGames.Soc.Common.CustomType.Alpha3ContainerClient get_ContainerWear(); // 0x06c01950
	WizardGames.Soc.Common.CustomType.Alpha3ContainerClient get_ContainerSeed(); // 0x06c019c4
	WizardGames.Soc.Common.Entity.SafetyBoxEntity get_SafetyBoxEntity(); // 0x06c01a38
	System.Int32 get_PlayerSafetyBoxState(); // 0x06c01b68
	System.Void add_EventInventoryError(System.Action<WizardGames.Soc.Common.Const.ErrorCode> value); // 0x06c01bf4
	System.Void remove_EventInventoryError(System.Action<WizardGames.Soc.Common.Const.ErrorCode> value); // 0x06c01ce4
	System.Void Init(); // 0x06c01dd4
	System.Void CleanUp(); // 0x06c01f8c
	System.Void OnUpdateItemCollection(System.Boolean isInventoryUpdate); // 0x06c020a0
	System.Int32 GetAmount(System.Int64 cfgID); // 0x06c026a8
	System.Void GetAllAmount(System.Collections.Generic.Dictionary<System.Int64,System.Int32> result); // 0x06c0278c
	System.Void ForeachInventoryContainer(System.Func<WizardGames.Soc.Common.CustomType.ItemContainerNode,System.Boolean> func); // 0x06c02860
	WizardGames.Soc.Common.CustomType.BaseItemNode GetItemByNodeId(System.Int64 uid); // 0x06c02978
	System.Boolean IsPlayerEquipExtraPack(); // 0x06c02a50
	System.Void MoveItem(System.Int64 itemUid, System.Int64 systemIndex, System.Int64 targetContainerId, System.Int32 targetPosition, System.Boolean isHorseEquip); // 0x06c02b2c
	System.Void MoveItem(System.Int64 itemUid, WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap targetContainerNode, System.Int32 targetPosition); // 0x06c044dc
	System.Void ExchangeItem(WizardGames.Soc.Common.Entity.PlayerEntity player, System.Collections.Generic.List<System.Int64> srcPath, System.Collections.Generic.List<System.Int64> tarPath); // 0x06c04374
	System.Void EqiupCloth(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.CustomType.ItemContainerNode containerNode, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x06c038bc
	System.Boolean IsEquipParachuteBagUsing(); // 0x06c04168
	System.Boolean CanClothEquip(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.CustomType.ItemContainerNode container, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x06c04d74
	System.Boolean WeaponPartEquip(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, WizardGames.Soc.Common.CustomType.WeaponItemNode weaponNode); // 0x06c03a10
	System.Boolean EnginePartEquip(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, WizardGames.Soc.Common.CustomType.EngineItemNode engineNode); // 0x06c03e8c
	System.Void EquipItem(System.Int64 itemUid, System.Int64 targetUid, System.Int32 targetPosition); // 0x06c053e0
	System.Void DropItem(System.UInt64 roleId, System.Int64 itemUId, System.Int32 count, System.Boolean isAheadSetDragIconEmpty); // 0x06c059b0
	System.Void PourWater(System.Int64 itemUId, System.Single velocityX, System.Single velocityY, System.Single velocityZ); // 0x06c05d5c
	System.Boolean CanMoveToInventory(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Boolean allowStack); // 0x06c05e5c
	System.Boolean CanMoveTo(WizardGames.Soc.Common.CustomType.BaseItemNode item, WizardGames.Soc.Share.Game.NodeSystem.IDirectoryNode target, System.Boolean allowStack, System.Action<WizardGames.Soc.Share.Framework.EntityBase,System.Boolean> onCanNotAccet, System.Action<WizardGames.Soc.Share.Framework.EntityBase> onFull); // 0x06c05fe0
	System.Boolean CanMultiMoveToInventory(System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> items, System.Boolean allowStack); // 0x06c062a0
	System.ValueTuple<System.Int32,System.Int32> GetContainerMainCountAndMax(); // 0x06c07080
	static System.Int32 CommonItemNodeSortInternal(WizardGames.Soc.Common.CustomType.BaseItemNode a, WizardGames.Soc.Common.CustomType.BaseItemNode b); // 0x06c0724c
	static System.Int32 CommonItemNodeBagSort(WizardGames.Soc.Common.CustomType.BaseItemNode a, WizardGames.Soc.Common.CustomType.BaseItemNode b); // 0x06c076e4
	System.String GetItemDescByDic(System.Collections.Generic.IDictionary<System.Int64,System.Int32> items); // 0x06c07800
	System.Void OnMoveExtraPackRes(System.Collections.Generic.List<System.Int64> srcPath, System.Collections.Generic.List<System.Int64> tarPath, System.Int32 code, System.Collections.Generic.IDictionary<System.Int64,System.Int32> oversizeItems); // 0x06c07d58
	System.Void OnDropExtraPackRes(System.Collections.Generic.List<System.Int64> itemPath, System.Int32 code, System.Collections.Generic.Dictionary<System.Int64,System.Int32> oversizeItems); // 0x06c086e8
	System.Void OnPickExtraPackRes(System.Collections.Generic.List<System.Int64> srcPath, System.Collections.Generic.List<System.Int64> tarPath, System.Int32 code, System.Collections.Generic.IDictionary<System.Int64,System.Int32> oversizeItems); // 0x06c08c78
	System.Boolean NeedPickItem(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x06c09268
	System.Boolean CanPutInfoWeaponSlot(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x06c09364
	System.Boolean CanAttachBulletToWeapon(WizardGames.Soc.Common.CustomType.BaseItemNode node, System.Int64 bulletConfigId); // 0x06c09424
	System.Boolean CanAttachAccessoryToWeapon(WizardGames.Soc.Common.CustomType.BaseItemNode node, WizardGames.Soc.Common.Data.DataItem.ItemSlot parttype); // 0x06c09544
	System.Boolean IsItemNew(WizardGames.Soc.Common.Data.DataItem.ItemConfig item); // 0x06c09680
	System.Int32 GetAllNewItemIds(System.Collections.Generic.List<System.Int64> res); // 0x06c09794
	System.Boolean IsBadgeAvailable(); // 0x06c099ec
	System.Void CloseItemNew(System.Int64 itemCfgId); // 0x06c09af8
	System.Void CloseAllItemNew(); // 0x06c09ce0
	WizardGames.Soc.Common.Entity.IHaveBulletEntity GetWeaponEntityOfItemNode(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Boolean localFirst); // 0x06c09fa0
	WizardGames.Soc.Common.Entity.IHaveBulletEntity GetWeaponBulletInfo(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Boolean localFirst, System.Int32& bulletId, System.Int32& bulletAmount); // 0x06c0a164
	static System.Boolean IsBullet(WizardGames.Soc.Common.CustomType.WeaponItemNode curWeaponItem, WizardGames.Soc.Common.CustomType.BaseItemNode bulletItemNode); // 0x06c0a494
	System.Boolean TryReloadBulletOfWeapon(WizardGames.Soc.Common.CustomType.BaseItemNode bulletItemNode, WizardGames.Soc.Common.CustomType.BaseItemNode weaponItemNode); // 0x06c0a58c
	System.Boolean TryUnloadBulletOfWeapon(WizardGames.Soc.Common.CustomType.BaseItemNode weaponItemNode, System.Boolean showTips); // 0x06c0ae2c
	System.Boolean CanItemUseInWater(WizardGames.Soc.Common.CustomType.BaseItemNode curItem, System.Boolean showTips); // 0x06c0b378
	static System.Boolean IterOneContainer(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap cc, System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> process); // 0x06c0b5ec
	System.Void FireInventoryUpdateMsgForItem(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x06c0b9f4
	System.Void TriggerEvent(WizardGames.Soc.Common.Unity.Event.EventDefine eventType); // 0x06c02170
	System.Void DoFireMsg(WizardGames.Soc.Common.Unity.Event.EventDefine msg); // 0x06c0bc10
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ItemContainerNode> GetSafetyBoxContainerNodes(); // 0x06c0bd40
	System.Boolean CheckSafeBoxIsEmpty(); // 0x06c0c024
	System.Boolean CheckLootingNodeIsEmpty(System.Int32 nodeIndex); // 0x06c0c340
	System.Void CallCloseSafetyBox(System.Int64 entityId, System.Action confirmCallback); // 0x06c0c414
	System.Boolean CallActiveSafetyBox(System.Int64 territoryCenterEntityId, System.Boolean destroyOther); // 0x06c0c7b8
	System.Boolean RemoteCallUseItem(System.Int64 entityId, System.Int64 itemUid, System.Int32 count); // 0x06c04f94
	System.Boolean RemoteCallOpenPackage(System.Int64 itemUid, System.Int32 selectDropId); // 0x06c0cf10
	System.Boolean DeployUseCheck(); // 0x06c0d0e4
	System.Boolean UseDeployItem(WizardGames.Soc.Common.CustomType.BaseItemNode curItem, System.Boolean isFromBackpack); // 0x06c0d4bc
	System.Boolean UseNormalItem(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x06c0d714
	System.Boolean UseHoldModelItem(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x06c0d848
	System.Void InternalUseHoldModelItem(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x06c0dc3c
	System.Void BagUseCardAllowed(); // 0x06c0dd0c
	System.Boolean UseItem(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x06c0dd74
	System.Boolean IsActiveSafetyBox(System.Int64 territoryCabinetId); // 0x06c0de64
	System.Void SetCustomItemTip(System.Int64 itemId, System.String customtips); // 0x06c0df4c
	System.String GetCustomItemTip(System.Int64 itemId); // 0x06c0dff4
	System.Boolean ClientEquipCloth(WizardGames.Soc.Common.CustomType.BaseItemNode itemWear); // 0x06c0e0c4
	System.Void .ctor(); // 0x06c0e404
	static System.Void .cctor(); // 0x06c0e6d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem.<>c : System.Object
{
	static WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Common.Const.ErrorCode> <>9__44_0; // 0x8
	static System.Action <>9__75_0; // 0x10
	static System.Action <>9__76_0; // 0x18
	static System.Void .cctor(); // 0x06c0e874
	System.Void .ctor(); // 0x06c0e8d8
	System.Void <Init>b__44_0(WizardGames.Soc.Common.Const.ErrorCode code); // 0x06c0e940
	System.Void <OnDropExtraPackRes>b__75_0(); // 0x06c0ea64
	System.Void <OnPickExtraPackRes>b__76_0(); // 0x06c0eb04
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem.<>c__DisplayClass100_0 : System.Object
{
	WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem <>4__this; // 0x10
	System.Int64 territoryCenterEntityId; // 0x18
	System.Void .ctor(); // 0x06c0cea8
	System.Void <CallActiveSafetyBox>b__0(); // 0x06c0eba4
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem.<>c__DisplayClass66_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode item; // 0x10
	System.Boolean needToast; // 0x18
	System.Boolean canAccept; // 0x19
	System.Boolean allowStack; // 0x1a
	System.Boolean canMoveTo; // 0x1b
	System.Boolean isFull; // 0x1c
	System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> <>9__1; // 0x20
	System.Void .ctor(); // 0x06c06238
	System.Boolean <CanMoveTo>b__0(WizardGames.Soc.Common.CustomType.ItemContainerNode container); // 0x06c0ec24
	System.Boolean <CanMoveTo>b__1(WizardGames.Soc.Common.CustomType.BaseItemNode toItem); // 0x06c0f1b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem.<>c__DisplayClass74_0 : System.Object
{
	WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem <>4__this; // 0x10
	System.Collections.Generic.List<System.Int64> srcPath; // 0x18
	System.Collections.Generic.List<System.Int64> tarPath; // 0x20
	System.Void .ctor(); // 0x06c08680
	System.Void <OnMoveExtraPackRes>b__0(); // 0x06c0f284
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem.<>c__DisplayClass75_0 : System.Object
{
	WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem <>4__this; // 0x10
	System.Collections.Generic.List<System.Int64> itemPath; // 0x18
	System.Void .ctor(); // 0x06c08c10
	System.Void <OnDropExtraPackRes>b__1(); // 0x06c0f304
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem.<>c__DisplayClass76_0 : System.Object
{
	WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem <>4__this; // 0x10
	System.Collections.Generic.List<System.Int64> srcPath; // 0x18
	System.Collections.Generic.List<System.Int64> tarPath; // 0x20
	System.Void .ctor(); // 0x06c09200
	System.Void <OnPickExtraPackRes>b__1(); // 0x06c0f388
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem.<>c__DisplayClass82_0 : System.Object
{
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> setGotItems; // 0x10
	System.Int32 count; // 0x18
	System.Collections.Generic.List<System.Int64> res; // 0x20
	System.Void .ctor(); // 0x06c09984
	System.Boolean <GetAllNewItemIds>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x06c0f408
	System.Boolean <GetAllNewItemIds>b__1(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x06c0f568
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem.<>c__DisplayClass94_0 : System.Object
{
	WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem <>4__this; // 0x10
	WizardGames.Soc.Common.Unity.Event.EventDefine eventType; // 0x18
	System.Void .ctor(); // 0x06c0bba8
	System.Void <TriggerEvent>b__0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x06c0f6c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem.<>c__DisplayClass99_0 : System.Object
{
	WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem <>4__this; // 0x10
	System.Action confirmCallback; // 0x18
	System.Void .ctor(); // 0x06c0c750
	System.Void <CallCloseSafetyBox>b__0(); // 0x06c0f7d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientItem.TbPartBaseExtension : System.Object
{
	
	static System.Collections.Generic.List<WizardGames.Soc.Common.Data.part.PartBase> GetList(WizardGames.Soc.Common.Data.part.TbPartBase tb, WizardGames.Soc.Common.Data.DataItem.ItemSlot partType); // 0x06c0f868
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientItem.TbPartBaseExtension.<>c__DisplayClass0_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemSlot partType; // 0x10
	System.Void .ctor(); // 0x06c0f994
	System.Boolean <GetList>b__0(WizardGames.Soc.Common.Data.part.PartBase m); // 0x06c0f9fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientItem.MgrItem : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Void Init(); // 0x06c0fa88
	System.Void CleanUp(); // 0x06c0faf0
	WizardGames.Soc.Common.Entity.IHeldItemEntity GetHeldEntity(System.Int64 itemUid); // 0x06c0fb58
	System.Void .ctor(); // 0x06c0fc30
	static System.Void .cctor(); // 0x06c0fc98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Collection.CustomTypeRegister : System.Object
{
	
	static T DeserializeFromPool<T>(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x052af1f0
	static System.Void Register(); // 0x06c0fd6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Collection.CustomTypeRegister.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Collection.CustomTypeRegister.<>c <>9; // 0x0
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_0; // 0x8
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_1; // 0x10
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_2; // 0x18
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_3; // 0x20
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_4; // 0x28
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_5; // 0x30
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_6; // 0x38
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_7; // 0x40
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_8; // 0x48
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_9; // 0x50
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_10; // 0x58
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_11; // 0x60
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_12; // 0x68
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_13; // 0x70
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_14; // 0x78
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_15; // 0x80
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_16; // 0x88
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_17; // 0x90
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_18; // 0x98
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_19; // 0xa0
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_20; // 0xa8
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_21; // 0xb0
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_22; // 0xb8
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_23; // 0xc0
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_24; // 0xc8
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_25; // 0xd0
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_26; // 0xd8
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_27; // 0xe0
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_28; // 0xe8
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_29; // 0xf0
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_30; // 0xf8
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_31; // 0x100
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_32; // 0x108
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_33; // 0x110
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor <>9__1_34; // 0x118
	static WizardGames.Soc.Share.Framework.CustomTypeFactoryEx.IArrayDataSetConstructor <>9__1_35; // 0x120
	static WizardGames.Soc.Share.Framework.CustomTypeFactoryEx.IArrayDataSetConstructor <>9__1_36; // 0x128
	static WizardGames.Soc.Share.Framework.CustomTypeFactoryEx.IArrayDataSetConstructor <>9__1_37; // 0x130
	static WizardGames.Soc.Share.Framework.CustomTypeFactoryEx.IArrayDataSetConstructor <>9__1_38; // 0x138
	static WizardGames.Soc.Share.Framework.CustomTypeFactoryEx.IArrayDataSetConstructor <>9__1_39; // 0x140
	static WizardGames.Soc.Share.Framework.CustomTypeFactoryEx.IArrayDataSetConstructor <>9__1_40; // 0x148
	static WizardGames.Soc.Share.Framework.CustomTypeFactoryEx.IArrayDataSetConstructor <>9__1_41; // 0x150
	static WizardGames.Soc.Share.Framework.CustomTypeFactoryEx.IArrayDataSetConstructor <>9__1_42; // 0x158
	static WizardGames.Soc.Share.Framework.CustomTypeFactoryEx.IArrayDataSetConstructor <>9__1_43; // 0x160
	static WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.ICustomTypeConstructorByJson <>9__1_44; // 0x168
	static System.Void .cctor(); // 0x06c121cc
	System.Void .ctor(); // 0x06c12230
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_0(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c12298
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_1(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c12334
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_2(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c123d0
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_3(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c1246c
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_4(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c12508
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_5(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c125a4
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_6(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c12640
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_7(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c126dc
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_8(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c12778
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_9(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c12814
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_10(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c128b0
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_11(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c1294c
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_12(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c129e8
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_13(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c12a84
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_14(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c12b20
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_15(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c12bbc
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_16(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c12c58
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_17(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c12cf4
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_18(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c12d90
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_19(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c12e2c
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_20(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c12ec8
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_21(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c12f64
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_22(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c13000
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_23(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c1309c
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_24(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c13138
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_25(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c131d4
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_26(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c13270
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_27(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c1330c
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_28(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c133a8
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_29(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c13444
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_30(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c134e0
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_31(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c1358c
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_32(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c13638
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_33(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c136e4
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_34(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06c13780
	WizardGames.Soc.Share.Framework.CustomTypeBase <Register>b__1_35(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06c13848
	WizardGames.Soc.Share.Framework.CustomTypeBase <Register>b__1_36(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06c1390c
	WizardGames.Soc.Share.Framework.CustomTypeBase <Register>b__1_37(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06c139d0
	WizardGames.Soc.Share.Framework.CustomTypeBase <Register>b__1_38(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06c13a94
	WizardGames.Soc.Share.Framework.CustomTypeBase <Register>b__1_39(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06c13b58
	WizardGames.Soc.Share.Framework.CustomTypeBase <Register>b__1_40(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06c13c1c
	WizardGames.Soc.Share.Framework.CustomTypeBase <Register>b__1_41(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06c13ce0
	WizardGames.Soc.Share.Framework.CustomTypeBase <Register>b__1_42(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06c13da4
	WizardGames.Soc.Share.Framework.CustomTypeBase <Register>b__1_43(System.Int64 identifier, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06c13e68
	WizardGames.Soc.Common.Framework.Types.ISerializeType <Register>b__1_44(SimpleJSON.JSONNode json); // 0x06c13f18
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Collection.Common.CanAcceptResult : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Collection.Common.CanAcceptResult CanAccept = 0;
	static WizardGames.Soc.SocClient.Collection.Common.CanAcceptResult CannotAccept = 1;
	static WizardGames.Soc.SocClient.Collection.Common.CanAcceptResult CannotAcceptWithToast = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Collection.Common.ItemContainerHelper : System.Object
{
	
	static WizardGames.Soc.Common.CustomType.BaseItemNode GetConflict(WizardGames.Soc.Share.Game.NodeSystem.IItemContainerNode parent, System.Int32 iTargetPos); // 0x06c13fc0
	static System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> GetConflictClothes(WizardGames.Soc.Share.Game.NodeSystem.IItemContainerNode parent, System.Int64 itemId); // 0x06c05190
}

// Client.Runtime
class WizardGames.Soc.SocClient.Network.RpcDecode : System.Object
{
	
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_914627788(MessagePack.MessagePackReader& reader); // 0x06c1453c
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_761096810(MessagePack.MessagePackReader& reader); // 0x06c14690
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_784810902(MessagePack.MessagePackReader& reader); // 0x06c147c4
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1830320586(MessagePack.MessagePackReader& reader); // 0x06c14918
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1615745611(MessagePack.MessagePackReader& reader); // 0x06c14a4c
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1375530870(MessagePack.MessagePackReader& reader); // 0x06c14c00
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_337903831(MessagePack.MessagePackReader& reader); // 0x06c14d84
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_135954072(MessagePack.MessagePackReader& reader); // 0x06c14f78
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1406515026(MessagePack.MessagePackReader& reader); // 0x06c150ac
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_151405266(MessagePack.MessagePackReader& reader); // 0x06c15200
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_2042563541(MessagePack.MessagePackReader& reader); // 0x06c15460
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1969628134(MessagePack.MessagePackReader& reader); // 0x06c15660
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_333370239(MessagePack.MessagePackReader& reader); // 0x06c15794
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1624131487(MessagePack.MessagePackReader& reader); // 0x06c158c8
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_112688892(MessagePack.MessagePackReader& reader); // 0x06c15bf4
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_669833913(MessagePack.MessagePackReader& reader); // 0x06c15d58
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_610387942(MessagePack.MessagePackReader& reader); // 0x06c15eb0
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1865441679(MessagePack.MessagePackReader& reader); // 0x06c1601c
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1600524543(MessagePack.MessagePackReader& reader); // 0x06c161a0
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1952191126(MessagePack.MessagePackReader& reader); // 0x06c16324
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_827946264(MessagePack.MessagePackReader& reader); // 0x06c164a8
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_93577080(MessagePack.MessagePackReader& reader); // 0x06c16824
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_2115978844(MessagePack.MessagePackReader& reader); // 0x06c169f4
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1335032369(MessagePack.MessagePackReader& reader); // 0x06c16b28
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_349185392(MessagePack.MessagePackReader& reader); // 0x06c16ed8
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_251536893(MessagePack.MessagePackReader& reader); // 0x06c1708c
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_522653293(MessagePack.MessagePackReader& reader); // 0x06c17454
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1001934740(MessagePack.MessagePackReader& reader); // 0x06c17690
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1654891911(MessagePack.MessagePackReader& reader); // 0x06c17954
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_2012375494(MessagePack.MessagePackReader& reader); // 0x06c17b60
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_762035519(MessagePack.MessagePackReader& reader); // 0x06c17d6c
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1974518753(MessagePack.MessagePackReader& reader); // 0x06c17ef0
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1169335902(MessagePack.MessagePackReader& reader); // 0x06c1812c
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1587990003(MessagePack.MessagePackReader& reader); // 0x06c18298
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_774812685(MessagePack.MessagePackReader& reader); // 0x06c1844c
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_262537770(MessagePack.MessagePackReader& reader); // 0x06c185d0
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1158173095(MessagePack.MessagePackReader& reader); // 0x06c18754
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_237197243(MessagePack.MessagePackReader& reader); // 0x06c188d8
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_84767104(MessagePack.MessagePackReader& reader); // 0x06c18a44
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_538327018(MessagePack.MessagePackReader& reader); // 0x06c18ba4
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1710203008(MessagePack.MessagePackReader& reader); // 0x06c18d34
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_295159418(MessagePack.MessagePackReader& reader); // 0x06c18e88
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_85875442(MessagePack.MessagePackReader& reader); // 0x06c18fc4
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_920735720(MessagePack.MessagePackReader& reader); // 0x06c19148
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1721734936(MessagePack.MessagePackReader& reader); // 0x06c192fc
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1962853280(MessagePack.MessagePackReader& reader); // 0x06c194b0
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_656724163(MessagePack.MessagePackReader& reader); // 0x06c19634
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1459485336(MessagePack.MessagePackReader& reader); // 0x06c197e8
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1958934963(MessagePack.MessagePackReader& reader); // 0x06c19970
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_697098161(MessagePack.MessagePackReader& reader); // 0x06c19af8
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_128307679(MessagePack.MessagePackReader& reader); // 0x06c19c64
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_699906333(MessagePack.MessagePackReader& reader); // 0x06c19de8
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_615940930(MessagePack.MessagePackReader& reader); // 0x06c19fb8
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_286963646(MessagePack.MessagePackReader& reader); // 0x06c1a10c
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1673252212(MessagePack.MessagePackReader& reader); // 0x06c1a240
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_2079477677(MessagePack.MessagePackReader& reader); // 0x06c1a394
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_2045680477(MessagePack.MessagePackReader& reader); // 0x06c1a4c8
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1577598552(MessagePack.MessagePackReader& reader); // 0x06c1a72c
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1918418888(MessagePack.MessagePackReader& reader); // 0x06c1a8dc
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_306289668(MessagePack.MessagePackReader& reader); // 0x06c1aa90
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_217296714(MessagePack.MessagePackReader& reader); // 0x06c1abcc
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_2075021765(MessagePack.MessagePackReader& reader); // 0x06c1ad20
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1386858159(MessagePack.MessagePackReader& reader); // 0x06c1aea4
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_427142523(MessagePack.MessagePackReader& reader); // 0x06c1b02c
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_416943005(MessagePack.MessagePackReader& reader); // 0x06c1b180
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1581443993(MessagePack.MessagePackReader& reader); // 0x06c1b2bc
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_841511669(MessagePack.MessagePackReader& reader); // 0x06c1b440
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1204487950(MessagePack.MessagePackReader& reader); // 0x06c1b594
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_282954435(MessagePack.MessagePackReader& reader); // 0x06c1b748
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1991812184(MessagePack.MessagePackReader& reader); // 0x06c1b948
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_212434689(MessagePack.MessagePackReader& reader); // 0x06c1bb18
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_2014446424(MessagePack.MessagePackReader& reader); // 0x06c1bcb8
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_1775484228(MessagePack.MessagePackReader& reader); // 0x06c1bf4c
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_170360040(MessagePack.MessagePackReader& reader); // 0x06c1c088
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_318801535(MessagePack.MessagePackReader& reader); // 0x06c1c1bc
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_38(MessagePack.MessagePackReader& reader); // 0x06c1c340
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_334941103(MessagePack.MessagePackReader& reader); // 0x06c1c580
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_263513662(MessagePack.MessagePackReader& reader); // 0x06c1c784
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode_19(MessagePack.MessagePackReader& reader); // 0x06c1c960
}

// Client.Runtime
class WizardGames.Soc.SocClient.Network.EntityRpcDecoder : System.Object
{
	static SocLogger <Logger>k__BackingField; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Share.Framework.Network.DecoderFunc> decoders; // 0x8
	static System.Collections.Generic.Dictionary<System.String,System.Int32> RpcName2HashCode; // 0x10
	static System.Void FrameworkInit(); // 0x06c1cae4
	static System.Boolean Decode(WizardGames.Soc.Common.Framework.Network.ReceivedEntityRpcPacket packet, WizardGames.Soc.Share.Framework.Network.DecodedRpc& decodedRpc); // 0x06c1cc3c
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc Decode(WizardGames.Soc.Share.Framework.Network.DecodedRpc decodedRpc, MessagePack.MessagePackReader& reader); // 0x06c1d428
	static System.Void DecodeRpcParam(WizardGames.Soc.Share.Framework.Network.DecodedRpc decodedRpc, MessagePack.MessagePackReader& reader, System.Int32[] paramTypes); // 0x06c1cfcc
	static System.Void .cctor(); // 0x06c1d618
}

// Client.Runtime
class WizardGames.Soc.SocClient.Network.LimitCallHelper : System.Object
{
	
	static WizardGames.Soc.Common.Framework.Network.RpcLimitCall GetRpcLimitCall(System.Int32 methodId, WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06c22c44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Network.KcpClient : WizardGames.Soc.Common.Framework.Network.Kcp.KcpPeer
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Framework.Network.Kcp.CallbackToken callbacks; // 0x48
	WizardGames.Soc.Common.Framework.Network.Kcp.KcpConfig config; // 0x50
	System.Byte[] rawReceiveBuffer; // 0x58
	System.Byte[] rawSendBuffer; // 0x60
	System.UInt32 lastCookie; // 0x68
	System.Int64 lastSwitchCookieTime; // 0x70
	System.Boolean Connected; // 0x78
	System.Boolean Active; // 0x79
	WizardGames.Soc.Common.Framework.Network.Impl.UdpNetClient udpClient; // 0x80
	System.Net.IPEndPoint RemoteEndPoint; // 0x88
	WizardGames.Soc.Common.Framework.Network.Encrypter encrypter; // 0x90
	WizardGames.Soc.Common.Framework.Network.Decrypter decrypter; // 0x98
	WizardGames.Soc.SocClient.Framework.KcpThread thread; // 0xa0
	WizardGames.Soc.Common.Framework.Network.ECompressorType <decompressorType>k__BackingField; // 0xa8
	WizardGames.Soc.Common.Framework.Network.DisconnectReason DisconnectReason; // 0xac
	System.Collections.Concurrent.ConcurrentQueue<WizardGames.Soc.Common.Framework.Network.IOutgoingPacket> <OutgoingQueue>k__BackingField; // 0xb0
	System.String lastAddress; // 0xb8
	System.UInt16 lastPort; // 0xc0
	System.Int32 tryCount; // 0xc4
	System.Int32 DropReceiveForEveryNPacket; // 0xc8
	System.Int32 normalReceiveCount; // 0xcc
	System.Int32 DropSendForEveryNPacket; // 0xd0
	System.Int32 normalSendCount; // 0xd4
	System.Int32 ChangeReceiveForEveryNPacket; // 0xd8
	System.Int32 normalChangeReceiveCount; // 0xdc
	System.Random random; // 0xe0
	WizardGames.Soc.Common.Framework.Network.ECompressorType get_decompressorType(); // 0x06c22d70
	System.Void set_decompressorType(WizardGames.Soc.Common.Framework.Network.ECompressorType value); // 0x06c22dd4
	System.Collections.Concurrent.ConcurrentQueue<WizardGames.Soc.Common.Framework.Network.IOutgoingPacket> get_OutgoingQueue(); // 0x06c22e4c
	System.Void .ctor(WizardGames.Soc.Common.Framework.Network.Kcp.CallbackToken token, WizardGames.Soc.Common.Framework.Network.Kcp.KcpConfig config); // 0x06c22eb0
	System.Void SetKcpThread(WizardGames.Soc.SocClient.Framework.KcpThread thread); // 0x06c2310c
	System.Void DisconnectOnNextTick(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x06c2318c
	System.Void Connect(System.String address, System.UInt16 port); // 0x06c23218
	System.Void OnAuthed(System.ArraySegment<System.Byte> message); // 0x06c2377c
	System.Void Decrypt(System.ArraySegment<System.Byte>& message); // 0x06c23d90
	System.Void OnData(System.ArraySegment<System.Byte> message, WizardGames.Soc.Common.Framework.Network.Kcp.EKcpChannel channel); // 0x06c23f8c
	System.Void OnDisconnected(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x06c24220
	System.Void OnError(WizardGames.Soc.Common.Framework.Network.Kcp.EErrorCode error, System.String message); // 0x06c24540
	System.Void OnRawDataReceived(System.ArraySegment<System.Byte> segment, WizardGames.Soc.Common.Framework.Network.Impl.UdpBuffer buffer); // 0x06c245e4
	System.Void Send(System.ArraySegment<System.Byte> segment, WizardGames.Soc.Common.Framework.Network.Kcp.EKcpChannel channel); // 0x06c24988
	System.Boolean SwitchCookie(System.UInt32 oldCookie, System.UInt32 newCookie); // 0x06c24c08
	System.Void RawInputInner(System.ArraySegment<System.Byte> segment, WizardGames.Soc.Common.Framework.Network.Kcp.EKcpChannel channel, System.UInt32 messageCookie); // 0x06c24eb8
	System.Void RawInput(System.ArraySegment<System.Byte>& segment); // 0x06c250c4
	System.Void Tick(); // 0x06c252f4
	System.Void OnProcessSend(); // 0x06c253d4
	System.Void SendKcpPacket(WizardGames.Soc.Common.Framework.Network.IOutgoingPacket packet); // 0x06c25620
	System.Void UdpSend(System.ArraySegment<System.Byte> data, System.Byte _); // 0x06c25e94
	static System.Void .cctor(); // 0x06c26108
	System.Void <OnDisconnected>b__45_0(); // 0x06c261dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Network.DisconnectMessage : WizardGames.Soc.Common.Framework.Network.BasePacket
{
	WizardGames.Soc.Common.Framework.Network.DisconnectReason Reason; // 0x18
	System.Void .ctor(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x06c26248
	System.Void ReturnToPool(); // 0x06c262cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Network.SocClientKcpNetworkEndpoint : WizardGames.Soc.Common.Framework.Network.Client.SocNetClient, WizardGames.Soc.Common.Framework.Network.Client.INetworkEndpointForClient, WizardGames.Soc.Common.Framework.Network.Client.INetworkEndpoint, SocDevKit.Network.IClientRpcLimitCheck
{
	static SocLogger logger; // 0x0
	System.Int32 port; // 0x48
	System.String ip; // 0x50
	WizardGames.Soc.SocClient.Network.KcpClient client; // 0x58
	WizardGames.Soc.SocClient.Framework.KcpThread kcpThread; // 0x60
	WizardGames.Soc.Common.Framework.Network.Kcp.CallbackToken currentToken; // 0x68
	WizardGames.Soc.SocClient.Network.SocClientKcpNetworkEndpoint.EState state; // 0x70
	WizardGames.Soc.SocClient.Network.UpdateClientTimeTask taskInstance; // 0x78
	System.Collections.Generic.Dictionary<System.Int32,SocDevKit.Network.RpcLimitCallRecord> <LimitCallRecords>k__BackingField; // 0x80
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> <OverLimitCount>k__BackingField; // 0x88
	System.Int64 <DurationStartTimeStamp>k__BackingField; // 0x90
	WizardGames.Soc.Common.Framework.MemoryBuffer fragmentBuffer; // 0x98
	System.Int32 fragmentCount; // 0xa0
	WizardGames.Soc.SocClient.Network.KcpClient get_Client(); // 0x06c26354
	WizardGames.Soc.SocClient.Framework.KcpThread get_KcpThread(); // 0x06c263b8
	System.Collections.Generic.Dictionary<System.Int32,SocDevKit.Network.RpcLimitCallRecord> get_LimitCallRecords(); // 0x06c2641c
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> get_OverLimitCount(); // 0x06c26480
	System.Int64 get_DurationStartTimeStamp(); // 0x06c264e4
	System.Void set_DurationStartTimeStamp(System.Int64 value); // 0x06c26548
	System.Void .ctor(System.String address, System.Int32 port); // 0x06c265c0
	System.Void Connect(); // 0x06c2682c
	System.Void OnClientConnected(); // 0x06c26bf4
	System.Void OnData(System.Memory<System.Byte> data, WizardGames.Soc.Common.Framework.Network.Kcp.EKcpChannel channel); // 0x06c26d80
	System.Void OnDisconnected(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x06c27cac
	System.Void OnError(WizardGames.Soc.Common.Framework.Network.Kcp.EErrorCode error, System.String message); // 0x06c27ed4
	System.Void DoDisconnect(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x06c281ac
	System.Void SendPacket(WizardGames.Soc.Common.Framework.Network.IOutgoingPacket packet); // 0x06c28358
	System.Boolean get_FragmentNotComplete(); // 0x06c27b1c
	System.Boolean ConcatFragment(System.Memory<System.Byte>& data, WizardGames.Soc.Common.Framework.MemoryBuffer& buffer); // 0x06c27524
	static System.Void .cctor(); // 0x06c2869c
	System.Void <OnClientConnected>b__31_0(); // 0x06c28770
	System.Void <OnDisconnected>b__33_0(); // 0x06c287d8
	System.Void <OnError>b__34_0(); // 0x06c28840
	System.Void <OnError>b__34_1(); // 0x06c288a8
	System.Void <ConcatFragment>g__Reset|39_0(); // 0x06c28628
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Network.SocClientKcpNetworkEndpoint.EState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Network.SocClientKcpNetworkEndpoint.EState NotConnect = 0;
	static WizardGames.Soc.SocClient.Network.SocClientKcpNetworkEndpoint.EState Conntected = 1;
	static WizardGames.Soc.SocClient.Network.SocClientKcpNetworkEndpoint.EState Disconnected = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Network.MgrNetworkMonitor : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Framework.Network.DisconnectReason curReason; // 0x14
	System.Int32 reconnectMaxCount; // 0x18
	System.Int32 reconnectCount; // 0x1c
	System.Int64 lastFastReconnectTimeMs; // 0x20
	System.Int64 nextReconnectTimerId; // 0x28
	System.Boolean bCancelReconnectWait; // 0x30
	System.Boolean IsAllowToFastReconnect; // 0x31
	System.Boolean forceFastReconnectTimeOut; // 0x32
	System.Boolean <IsInReconnect>k__BackingField; // 0x33
	System.Boolean EnableDisconnectTest; // 0x34
	System.Boolean EnableGameStateCheckBeforeReconnect; // 0x35
	System.Boolean CanGameStateCheckBeforeReconnect; // 0x36
	System.Boolean get_IsInReconnect(); // 0x06c28914
	System.Void set_IsInReconnect(System.Boolean value); // 0x06c28978
	System.Void Init(); // 0x06c289f4
	System.Void CleanUp(); // 0x06c28af0
	System.Threading.Tasks.Task OnExitWorld(); // 0x06c28d44
	System.Void CancelReconnect(); // 0x06c28b60
	System.Void OnWorldServerConnected(); // 0x06c28e20
	System.Void OnFastDisconnected(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x06c29134
	System.Void CheckGameStateAndFastReconnect(); // 0x06c29bb4
	System.Void OnFastReconnected(); // 0x06c2a4b0
	System.Void CheckForNextReconnect(); // 0x06c29354
	System.Void BackToLobby(); // 0x06c2a588
	System.Void OnReconnectMax(); // 0x06c2a66c
	System.Void CheckGameStateAndSlowReconnect(); // 0x06c2ab48
	System.Void OnFastReconnectTimeOut(); // 0x06c2ad94
	System.Boolean DoFastReconnect(); // 0x06c29db4
	System.Void OnLateUpdate(); // 0x06c2b2a0
	System.Void SwapGameLoop(System.Boolean gameLoopEnable); // 0x06c2970c
	System.Void WaitReconnectInGame(); // 0x06c29ad4
	System.Void .ctor(); // 0x06c2b300
	static System.Void .cctor(); // 0x06c2b378
	System.Void <CheckGameStateAndFastReconnect>b__25_0(System.Boolean res); // 0x06c2b44c
	System.Void <CheckForNextReconnect>b__27_0(System.Int64 _, System.Object _, System.Boolean _); // 0x06c2b8fc
	System.Void <OnReconnectMax>b__29_0(); // 0x06c2b990
	System.Void <OnReconnectMax>b__29_1(); // 0x06c2bab4
	System.Void <CheckGameStateAndSlowReconnect>b__30_0(System.Boolean res); // 0x06c2bb1c
	System.Void <OnFastReconnectTimeOut>b__31_1(); // 0x06c2be48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Network.MgrNetworkMonitor.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Network.MgrNetworkMonitor.<>c <>9; // 0x0
	static System.Action <>9__25_1; // 0x8
	static System.Action <>9__25_2; // 0x10
	static System.Action <>9__30_1; // 0x18
	static System.Action <>9__31_0; // 0x20
	static System.Void .cctor(); // 0x06c2beac
	System.Void .ctor(); // 0x06c2bf10
	System.Void <CheckGameStateAndFastReconnect>b__25_1(); // 0x06c2bf78
	System.Void <CheckGameStateAndFastReconnect>b__25_2(); // 0x06c2c024
	System.Void <CheckGameStateAndSlowReconnect>b__30_1(); // 0x06c2c0cc
	System.Void <OnFastReconnectTimeOut>b__31_0(); // 0x06c2c174
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Network.MgrNetworkMonitor.<WaitReconnectInGame>d__35 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Network.MgrNetworkMonitor <>4__this; // 0x38
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1; // 0x40
	System.Void MoveNext(); // 0x06c2c21c
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06c2d000
}

// Client.Runtime
class WizardGames.Soc.SocClient.Network.SocClientService : System.Object
{
	static SocLogger logger; // 0x0
	System.Int64 timeOnProcessPack; // 0x10
	System.Boolean appPaused; // 0x18
	WizardGames.Soc.Common.Framework.Network.Client.INetworkEndpointForClient <NetworkEndpoint>k__BackingField; // 0x20
	System.Boolean ForceUseTcp; // 0x28
	System.Int32 processCount; // 0x2c
	System.Boolean <BlockNetworkUpdate>k__BackingField; // 0x30
	WizardGames.Soc.Common.Unity.Utility.SocPing Ping; // 0x38
	System.Int32 LastPingNum; // 0x40
	System.Int64 LastPingUpdateTime; // 0x48
	System.Boolean nextConnectUseTcp; // 0x50
	WizardGames.Soc.Common.Framework.Network.Client.INetworkEndpointForClient get_NetworkEndpoint(); // 0x06c2d080
	System.Void set_NetworkEndpoint(WizardGames.Soc.Common.Framework.Network.Client.INetworkEndpointForClient value); // 0x06c2d0e4
	System.String get_WorldServerAddress(); // 0x06c2d164
	System.Int32 get_WorldServerTcpPort(); // 0x06c2d274
	System.Int32 get_WorldServerUdpPort(); // 0x06c2d360
	System.Boolean get_IsConnected(); // 0x06c2cea4
	System.Boolean get_IsUsingUdp(); // 0x06c2d44c
	WizardGames.Soc.Common.Framework.Network.Client.INetworkEndpoint get_Client(); // 0x06c2d544
	System.Boolean get_BlockNetworkUpdate(); // 0x06c2d5dc
	System.Void set_BlockNetworkUpdate(System.Boolean value); // 0x06c2d640
	System.Boolean get_connectUseTcp(); // 0x06c2d6bc
	System.Void .ctor(); // 0x06c2d730
	static System.Void .cctor(); // 0x06c2d7a8
	System.Void Init(); // 0x06c2da74
	System.Void StartService(); // 0x06c2ee88
	System.Boolean CheckPackProcessTimeout(); // 0x06c27344
	System.Void UpdateService(System.Boolean canBlock, System.Int32 warningCount); // 0x06c2f044
	System.Void ClearPackets(); // 0x06c2f610
	System.Void StopService(); // 0x06c2fc88
	System.Void HandlePacket(WizardGames.Soc.Common.Framework.Network.BasePacket packet); // 0x06c2feb8
	System.Void OnConnectedToWorld(); // 0x06c308c8
	System.Void OnConnectToWorldFailed(); // 0x06c30acc
	System.Void OnUdpConnectFailed(); // 0x06c30eb4
	System.Void WorldServerDisconnected(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x06c30f84
	System.Void CheckAndDoFastReconnect(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x06c31798
	System.Void UpdatePing(System.Boolean restart); // 0x06c2f4e0
	System.Int32 GetPingNum(System.Boolean greaterZero); // 0x06c318cc
	System.Void OnApplicationPause(System.Boolean pauseStatus); // 0x06c31958
}

// Client.Runtime
class WizardGames.Soc.SocClient.Network.SocClientService.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Network.SocClientService.<>c <>9; // 0x0
	static System.Action <>9__42_0; // 0x8
	static System.Action <>9__45_0; // 0x10
	static System.Void .cctor(); // 0x06c31aec
	System.Void .ctor(); // 0x06c31b50
	System.Void <OnConnectToWorldFailed>b__42_0(); // 0x06c31bb8
	System.Void <WorldServerDisconnected>b__45_0(); // 0x06c31d0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Network.SocClientService.<>c__DisplayClass45_0 : System.Object
{
	WizardGames.Soc.SocClient.Network.SocClientService <>4__this; // 0x10
	WizardGames.Soc.Common.Framework.Network.DisconnectReason reason; // 0x18
	System.Void .ctor(); // 0x06c31730
	System.Void <WorldServerDisconnected>b__1(); // 0x06c31da4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Network.SocClientNetUtil : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,SocDevKit.Network.RpcLimitCallRecord> limitCallRecord; // 0x8
	static WizardGames.Soc.Common.Framework.Network.INetworkDecompressor decompressor; // 0x10
	static System.Byte[] DecompressBuffer; // 0x18
	static System.Memory<System.Byte> DecompressPacket(System.Int32 length, System.ArraySegment<System.Byte> srcSegment, System.Int32 offset); // 0x06c31e14
	static WizardGames.Soc.Common.Framework.Network.BasePacket ClientDecodeOnePacket(System.Memory<System.Byte> data, WizardGames.Soc.Common.Framework.Network.ECompressorType decompressorType); // 0x06c27b88
	static WizardGames.Soc.Common.Framework.Network.BasePacket ClientDecodeOnePacket(System.Memory<System.Byte> data); // 0x06c325c8
	static System.Void .cctor(); // 0x06c3407c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Network.UpdateClientTimeTask : System.Object
{
	System.Int64 Ts; // 0x10
	System.Action Cb; // 0x18
	System.Void .ctor(); // 0x06c26770
	System.Void Trigger(WizardGames.Soc.Common.Framework.Network.ReceivedEntityRpcPacket rerp); // 0x06c341e8
	System.Void Invoke(); // 0x06c34350
}

// Client.Runtime
class WizardGames.Soc.SocClient.Network.SocClientTcpNetworkEndpoint : WizardGames.Soc.Common.Framework.Network.Client.SocNetClient, WizardGames.Soc.Common.Framework.Network.Client.INetworkEndpointForClient, WizardGames.Soc.Common.Framework.Network.Client.INetworkEndpoint, SocDevKit.Network.IClientRpcLimitCheck
{
	static SocLogger logger; // 0x0
	System.Int32 MAX_TRY_COUNT; // 0x48
	WizardGames.Soc.Common.Framework.Network.Impl.TcpNetClient tcpClient; // 0x50
	WizardGames.Soc.Common.Framework.Network.Encrypter encrypter; // 0x58
	WizardGames.Soc.Common.Framework.Network.Decrypter decrypter; // 0x60
	WizardGames.Soc.SocClient.Network.UpdateClientTimeTask taskInstance; // 0x68
	System.Collections.Generic.Dictionary<System.Int32,SocDevKit.Network.RpcLimitCallRecord> <LimitCallRecords>k__BackingField; // 0x70
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> <OverLimitCount>k__BackingField; // 0x78
	System.Int64 <DurationStartTimeStamp>k__BackingField; // 0x80
	System.Int32 tryCount; // 0x88
	System.Collections.Generic.Dictionary<System.Int32,SocDevKit.Network.RpcLimitCallRecord> get_LimitCallRecords(); // 0x06c343f0
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> get_OverLimitCount(); // 0x06c34454
	System.Int64 get_DurationStartTimeStamp(); // 0x06c344b8
	System.Void set_DurationStartTimeStamp(System.Int64 value); // 0x06c3451c
	System.Void .ctor(System.String address, System.Int32 tcpPort); // 0x06c2e850
	System.Void Connect(); // 0x06c34594
	System.Void SendPacket(WizardGames.Soc.Common.Framework.Network.IOutgoingPacket packet); // 0x06c34678
	System.Void OnClientConnected(); // 0x06c34b2c
	System.Void OnClientConnectFailed(); // 0x06c34d80
	System.Void OnClientDisconnected(System.Net.Sockets.SocketError reason); // 0x06c34f30
	System.Void OnClientNetworkReceive(System.Memory<System.Byte> message); // 0x06c35314
	System.Void OnData(System.Memory<System.Byte> message); // 0x06c359fc
	System.Void DoDisconnect(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x06c35d24
	static System.Void .cctor(); // 0x06c35ea4
	System.Void <OnClientConnectFailed>b__25_0(); // 0x06c35f78
	System.Void <OnClientNetworkReceive>b__27_0(); // 0x06c35fe0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Network.SocClientTcpNetworkEndpoint.<>c__DisplayClass26_0 : System.Object
{
	WizardGames.Soc.SocClient.Network.SocClientTcpNetworkEndpoint <>4__this; // 0x10
	System.Net.Sockets.SocketError reason; // 0x18
	System.Void .ctor(); // 0x06c352ac
	System.Void <OnClientDisconnected>b__0(); // 0x06c36048
	System.Void <OnClientDisconnected>b__1(); // 0x06c36108
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.ClientLagCompensationDebugger : WizardGames.Soc.Common.Unity.LagCompensationDebugger
{
	System.Boolean Move; // 0x58
	System.Boolean Sprint; // 0x59
	System.Single MaxDuration; // 0x5c
	System.Boolean moving; // 0x60
	System.Single cd; // 0x64
	System.Single d; // 0x68
	System.Boolean forward; // 0x6c
	System.Int32 total; // 0x70
	System.Int32 totaloot; // 0x74
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Auxiliary.ClientLagCompensationDebugger.HitStatistic> Statistics; // 0x78
	static System.Int32 ClientTotalHit; // 0x0
	static System.Int32 ServerHitWithoutScene; // 0x4
	static System.Int32 BloodTxtCount; // 0x8
	static System.Int32 BloodFXCount; // 0xc
	static System.Int32 confirmentitycount; // 0x10
	static System.Int32 missentitycount; // 0x14
	static System.Void ClearData(); // 0x06c3617c
	System.Void Update(); // 0x06c361f8
	System.Void AddStatistic(System.Int32 res, System.Int32 hitentity, System.Int64 serverTime); // 0x06c36574
	System.Void .ctor(); // 0x06c36844
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.ClientLagCompensationDebugger.HitStatistic : System.Object
{
	System.Int32 count; // 0x10
	System.Int32 outOfTimeCount1; // 0x14
	System.Int32 outOfTimeCount3; // 0x18
	System.Void .ctor(); // 0x06c367dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.FpEffectCrossSwitch : UnityEngine.MonoBehaviour
{
	static System.Int32 FpEffectCrossSwitchId; // 0x0
	System.Boolean FpCrossSwitch; // 0x30
	UnityEngine.Renderer[] renderers; // 0x38
	UnityEngine.MaterialPropertyBlock block; // 0x40
	System.Void ClearRender(); // 0x06c3691c
	System.Void OnRelease(); // 0x06c36988
	System.Void SetFpCrossSwitch(System.Boolean crossSwitch); // 0x06c369f4
	System.Void .ctor(); // 0x06c36c3c
	static System.Void .cctor(); // 0x06c36cac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.MgrAuxiliaryAim : WizardGames.Soc.Common.Manager.MgrBase
{
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.MgrAimSnap AimSnap; // 0x18
	WizardGames.Soc.SocClient.Auxiliary.AimRange.MgrAimRange AimRange; // 0x20
	UnityEngine.Transform CameraTransform; // 0x28
	UnityEngine.Vector3 CameraPosition; // 0x30
	UnityEngine.Quaternion CameraRotation; // 0x3c
	UnityEngine.Vector3 CameraEular; // 0x4c
	UnityEngine.Vector3 CameraForward; // 0x58
	UnityEngine.Vector2 ScreenWH; // 0x64
	System.Single BaseFovRadian; // 0x6c
	System.Single ResolutionRate; // 0x70
	System.Single CurHalfFovRadian; // 0x74
	System.Single HalfFovCoe; // 0x78
	WizardGames.Soc.Common.Data.gun.GunBase WeaponTable; // 0x80
	WizardGames.Soc.Common.Data.part.PartBase ScopeTable; // 0x88
	System.Single FovScaler; // 0x90
	System.Single RaycastMaxdis; // 0x94
	System.Int64 <CheckRaycastID>k__BackingField; // 0x98
	System.Single <CheckRaycastDistance>k__BackingField; // 0xa0
	System.Collections.Generic.List<UnityEngine.RaycastHit> tempHits; // 0xa8
	UnityEngine.RaycastHit[] hitBuffer; // 0xb0
	System.Single fps30; // 0xb8
	System.Single next30FpsUpdate; // 0xbc
	UnityEngine.Camera get_MainCamera(); // 0x06c36d14
	System.Void set_CheckRaycastID(System.Int64 value); // 0x06c36d78
	System.Int64 get_CheckRaycastID(); // 0x06c36df0
	System.Void set_CheckRaycastDistance(System.Single value); // 0x06c36e54
	System.Single get_CheckRaycastDistance(); // 0x06c36ecc
	System.Void OnCurrentHeldItemUpdate(WizardGames.Soc.Common.Entity.IHeldItemEntity heldItem); // 0x06c36f30
	System.Void UpdateBaseContextInfo(); // 0x06c37208
	System.Void OnUpdate(System.Single delta_time); // 0x06c378c4
	System.Void UpdateRaycastTarget(); // 0x06c373d8
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06c37fbc
	System.Threading.Tasks.Task OnExitWorld(); // 0x06c38d2c
	System.Void OnEntityGoCreated(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c39068
	System.Void OnEntityGoRemoved(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c39258
	System.Void .ctor(); // 0x06c39378
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnapGlobalConfig : UnityEngine.ScriptableObject
{
	System.Single AimAssistPercent; // 0x18
	System.Single AimAssistTime; // 0x1c
	System.Single AimAssistFar; // 0x20
	System.Single MinDistance; // 0x24
	System.Single MaxDistance; // 0x28
	System.Single BaseBoxFrameDistance; // 0x2c
	System.Single DefaultFov; // 0x30
	UnityEngine.AnimationCurve PriorityByDis; // 0x38
	System.Single BaseFilterAngle; // 0x40
	UnityEngine.AnimationCurve FilterAngleCoeByScope; // 0x48
	UnityEngine.AnimationCurve FireSnapCurve; // 0x50
	System.Int32 BaseVerticalResolution; // 0x58
	System.Single SlowAimMinRate; // 0x5c
	System.Single FollowAimAfterFireDuration; // 0x60
	System.Single FollowAimAngleRate; // 0x64
	System.Single FollowAimAngleSpeed; // 0x68
	UnityEngine.AnimationCurve AimrangeMeleeTurnCurve; // 0x70
	System.Int32 ScopeSnapAngleSpeed; // 0x78
	System.Single ScopeInterruptAimSpeed; // 0x7c
	System.Single ScopeDelayTime; // 0x80
	System.Single FollowTriggerDistance; // 0x84
	System.Void .ctor(); // 0x06c39508
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnap.AimSnapDebugger : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.SocClient.Auxiliary.AimSnap.AimSnapDebugger Instance; // 0x8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable> FireSnappables; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData> boxes; // 0x38
	UnityEngine.Material mat; // 0x40
	System.Collections.Generic.List<UnityEngine.Vector3> traceback; // 0x48
	UnityEngine.Vector3 start; // 0x50
	UnityEngine.Vector3 end; // 0x5c
	static System.Int32 show_box_flag; // 0x10
	System.Void Awake(); // 0x06c395c8
	System.Void OnEnable(); // 0x06c397a4
	System.Void OnDestroy(); // 0x06c39818
	System.Void AddBox(WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData box); // 0x06c39a0c
	System.Void ClearBoxes(); // 0x06c39968
	System.Void OnDisable(); // 0x06c39b64
	System.Void EndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext arg1, UnityEngine.Camera arg2); // 0x06c39bc8
	static System.Void EnableDebugger(WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType box_type); // 0x06c39e40
	static System.Void DisableDebugger(WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType box_type); // 0x06c3a05c
	static System.Void _UpdateDebugger(); // 0x06c39ee0
	static System.Boolean get_IsDebuggerOn(); // 0x06c3a0fc
	static System.Boolean IsBoxDebuggerOn(WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType box_type); // 0x06c3a1f8
	System.Void .ctor(); // 0x06c3a2b8
	static System.Void .cctor(); // 0x06c3a3c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnap.AimSnapFireSnapController : WizardGames.Soc.SocClient.Auxiliary.AimSnap.BaseAimSnapController
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable> filter_left; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable> filter_right; // 0x48
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable currentSnapping; // 0x50
	System.Single lockingStartTime; // 0x58
	System.Single lockingDuration; // 0x5c
	System.Single lockingSpeed; // 0x60
	UnityEngine.Quaternion or; // 0x64
	UnityEngine.Quaternion tr; // 0x74
	UnityEngine.Vector3 slerped_forward; // 0x84
	System.Single cd; // 0x90
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType get_ControllerBoxType(); // 0x06c3a4a8
	System.Void .ctor(WizardGames.Soc.SocClient.Auxiliary.AimSnap.MgrAimSnap mgr); // 0x06c3a50c
	System.Boolean CheckUpdate(System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable> snappables, System.Single delta_time); // 0x06c3a97c
	System.Void Update(System.Single delta_time); // 0x06c3b270
	System.Boolean filterSnappables(System.Collections.Generic.IEnumerable<WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable> snappables); // 0x06c3aa38
	System.Void startSnapping(WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable snappable, WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData box); // 0x06c3c4f8
	System.Boolean snapping(System.Single dt); // 0x06c3c764
	System.Boolean CheckLock(); // 0x06c3b5d0
	System.Boolean IsLocking(); // 0x06c3cb34
	System.Void LockTarget(); // 0x06c3cc04
	System.Void UnLockTarget(); // 0x06c3cba0
	System.Void OnGoRemoved(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c3d098
	System.Void Release(); // 0x06c3d174
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Auxiliary.AimSnap.FollowAimOnBit : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Auxiliary.AimSnap.FollowAimOnBit AfterFire = 0;
	static WizardGames.Soc.SocClient.Auxiliary.AimSnap.FollowAimOnBit AdsOn = 1;
	static WizardGames.Soc.SocClient.Auxiliary.AimSnap.FollowAimOnBit AdsOff = 2;
	static WizardGames.Soc.SocClient.Auxiliary.AimSnap.FollowAimOnBit Count = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnap.AimSnapFollowAngleController : WizardGames.Soc.SocClient.Auxiliary.AimSnap.BaseAimSnapController
{
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable candidate; // 0x40
	UnityEngine.Vector3 candidatePreWorldPos; // 0x48
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable currentSnapping; // 0x58
	System.Int32 stopFrameCount; // 0x60
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable lastSnapping; // 0x68
	UnityEngine.Vector3 targetPreWorldPos; // 0x70
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData snappingBox; // 0x80
	System.Boolean fireTriggerCountDown; // 0x88
	System.Boolean fireTriggerOn; // 0x89
	System.Single cd; // 0x8c
	System.Int32 dir; // 0x90
	System.Int32 targetMovedir; // 0x94
	UnityEngine.Quaternion targetCameraQOffset; // 0x98
	System.Single snappingY; // 0xa8
	UnityEngine.Quaternion startForwardQ; // 0xac
	UnityEngine.Quaternion snapTargetQ; // 0xbc
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType get_ControllerBoxType(); // 0x06c3d1d4
	System.Void .ctor(WizardGames.Soc.SocClient.Auxiliary.AimSnap.MgrAimSnap mgr); // 0x06c3d238
	System.Boolean CheckUpdate(System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable> snappables, System.Single delta_time); // 0x06c3d2d8
	System.Void Update(System.Single delta_time); // 0x06c3d73c
	System.Void OnGoRemoved(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c3ee50
	System.Boolean targetAway(WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable snappable, WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData box); // 0x06c3d92c
	System.Void startSnapping(WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable snappable, WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData box); // 0x06c3dd64
	System.Boolean snapping1(System.Single dt); // 0x06c3e0f4
	System.Void stopSnapping(); // 0x06c3edc0
	System.Void Release(); // 0x06c3ef34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnap.AimSnapMidlineController : WizardGames.Soc.SocClient.Auxiliary.AimSnap.BaseAimSnapController
{
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable currentSnapping; // 0x40
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData snappingBox; // 0x48
	System.Boolean snapping; // 0x50
	System.Single dir; // 0x54
	System.Boolean keep_close; // 0x58
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType get_ControllerBoxType(); // 0x06c3ef94
	System.Void .ctor(WizardGames.Soc.SocClient.Auxiliary.AimSnap.MgrAimSnap mgr); // 0x06c3eff8
	System.Boolean CheckUpdate(System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable> snappables, System.Single delta_time); // 0x06c3f098
	System.Void Update(System.Single delta_time); // 0x06c3f430
	System.Boolean IsInMidline(WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData box); // 0x06c3fc08
	System.Void StartSnap(WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData box); // 0x06c3fe3c
	System.Boolean Snapping(System.Single dt, System.Single speed); // 0x06c3ff28
	System.Void ClearSnap(); // 0x06c3fb80
	System.Void OnGoRemoved(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c40328
	System.Void Release(); // 0x06c403c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Go.BaseEntityGo EntityGo; // 0x10
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxSet SnapBox; // 0x18
	System.Int32 Priority; // 0x20
	UnityEngine.Vector3 Direction; // 0x24
	System.Single RealDistance; // 0x30
	System.Single Cos; // 0x34
	System.Single <CCRadius>k__BackingField; // 0x38
	System.Single get_CCRadius(); // 0x06c40428
	System.Void Init(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go, System.Int32 snapConfigId); // 0x06c4048c
	System.Boolean IsDuck(); // 0x06c4057c
	System.Boolean Ignore(); // 0x06c405e0
	System.Boolean ContainsBox(WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData box, WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType boxType); // 0x06c40644
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData> TypeBoxesItor(WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType boxType); // 0x06c3d010
	System.Void UpdateSnapBox(UnityEngine.Vector2 coe, WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType type); // 0x06c3ce0c
	System.Void OnGet(); // 0x06c407d8
	System.Void OnRelease(); // 0x06c40838
	System.Void OnDestroy(); // 0x06c40930
	static WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable CreateSnappable(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c40990
	System.Void .ctor(); // 0x06c40dc4
	static System.Void .cctor(); // 0x06c40e34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnap.PlayerSnappable : WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable
{
	WizardGames.Soc.Common.Unity.Go.BasePlayerGo player; // 0x40
	WizardGames.Soc.Common.Entity.PlayerEntity entity; // 0x48
	System.Void Init(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go, System.Int32 snapConfigId); // 0x06c40f08
	System.Boolean IsDuck(); // 0x06c410f8
	System.Boolean Ignore(); // 0x06c41178
	System.Single get_CCRadius(); // 0x06c4125c
	System.Void .ctor(); // 0x06c41344
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnap.MonsterSnappable : WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable
{
	WizardGames.Soc.SocClient.Go.MonsterGo monster; // 0x40
	WizardGames.Soc.Common.Entity.MonsterEntity entity; // 0x48
	System.Void Init(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go, System.Int32 snapConfigId); // 0x06c413cc
	System.Void OnDestroy(); // 0x06c415bc
	System.Boolean IsDuck(); // 0x06c41640
	System.Boolean Ignore(); // 0x06c416a4
	System.Single get_CCRadius(); // 0x06c41714
	System.Void .ctor(); // 0x06c41784
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnap.AimSnapScopeController : WizardGames.Soc.SocClient.Auxiliary.AimSnap.BaseAimSnapController
{
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable currentSnapping; // 0x40
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData snappingBox; // 0x48
	System.Single cd; // 0x50
	System.Single dir; // 0x54
	System.Int32 snapState; // 0x58
	System.Single delayTime; // 0x5c
	System.Single snappingTime; // 0x60
	System.Single snapAngleSpeed; // 0x64
	System.Boolean AdsOnToggle; // 0x68
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType get_ControllerBoxType(); // 0x06c4180c
	System.Void .ctor(WizardGames.Soc.SocClient.Auxiliary.AimSnap.MgrAimSnap mgr); // 0x06c41870
	System.Void OnAdsOn(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06c419c4
	System.Boolean CheckUpdate(System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable> snappables, System.Single delta_time); // 0x06c41a40
	System.Void Update(System.Single delta_time); // 0x06c41cf8
	System.Void OnGoRemoved(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c4243c
	System.Void startSnapping(WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable snappable, WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData box); // 0x06c41f34
	System.Boolean snapping(System.Single dt); // 0x06c42100
	System.Void Release(); // 0x06c42590
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnap.AimSnapSlowdownController : WizardGames.Soc.SocClient.Auxiliary.AimSnap.BaseAimSnapController
{
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable currentSnapping; // 0x40
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType get_ControllerBoxType(); // 0x06c42694
	System.Boolean CheckUpdate(System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable> snappables, System.Single delta_time); // 0x06c426f8
	System.Void .ctor(WizardGames.Soc.SocClient.Auxiliary.AimSnap.MgrAimSnap mgr); // 0x06c42930
	System.Void Update(System.Single delta_time); // 0x06c429d0
	System.Void OnGoRemoved(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c42efc
	System.Single GetScreenRadius(WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable s); // 0x06c42d10
	System.Void Release(); // 0x06c42fcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnap.BaseAimSnapController : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.MgrAimSnap AimMgr; // 0x10
	Contexts.ClientContext context; // 0x18
	WizardGames.Soc.SocClient.Control.InputAdditional InputAdditional; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable> sortedSnappables; // 0x28
	System.Collections.Generic.List<UnityEngine.RaycastHit> tempHits; // 0x30
	UnityEngine.RaycastHit[] hitBuffer; // 0x38
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType get_ControllerBoxType(); // 0x0548ba98
	System.Void .ctor(WizardGames.Soc.SocClient.Auxiliary.AimSnap.MgrAimSnap mgr); // 0x06c3a718
	System.Boolean CheckUpdate(System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable> snappables, System.Single delta_time); // 0x054e00b8
	System.Void Update(System.Single delta_time); // 0x05513724
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData GetCollideBoxData(WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable& snappable, UnityEngine.Camera cam, WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType boxType); // 0x06c3ba0c
	System.Void OnGoRemoved(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x05523a54
	System.Void CheckDebug(WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType boxType); // 0x06c3f6d8
	System.Void Release(); // 0x055049cc
	static System.Void .cctor(); // 0x06c4302c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnap.EditorAimSnapData : System.Object
{
	System.Single AimAssistPercent; // 0x10
	System.Single AimAssistTime; // 0x14
	System.Single FireSnapDistance; // 0x18
	System.Single AimAssistFar; // 0x1c
	System.Single MinDistance; // 0x20
	System.Single MaxDistance; // 0x24
	System.Single BaseBoxFrameDistance; // 0x28
	System.Single SlowAimMinRate; // 0x2c
	System.Single ScopeSnapDelay; // 0x30
	System.Single ScopeSnapSpeed; // 0x34
	System.Single ScopeSnapDisLimit; // 0x38
	System.Single ScopeInterruptAimSpeed; // 0x3c
	System.Int32 FollowAimOnState; // 0x40
	System.Single FollowAimDis; // 0x44
	WizardGames.Soc.Common.Data.AimRangeConfig[] aimRange; // 0x48
	System.Int32 type; // 0x50
	System.Int32 typeIndex; // 0x54
	System.Int32 hitboxId; // 0x58
	System.Int32 hitboxIdIndex; // 0x5c
	System.Int32 EnableAimSnap; // 0x60
	System.String[] fireSnapBonesName; // 0x68
	System.Collections.Generic.Dictionary<System.String,System.String[]> fireSnapBones; // 0x70
	System.String[] fireSnapBoneConfig; // 0x78
	System.Int32 selectFireSnapBoneIndex; // 0x80
	System.String[] slowDownBonesName; // 0x88
	System.Collections.Generic.Dictionary<System.String,System.String[]> slowDownBones; // 0x90
	System.String[] slowDownBoneConfig; // 0x98
	System.Int32 selectSlowDownBoneIndex; // 0xa0
	System.String[] scopeBonesName; // 0xa8
	System.Collections.Generic.Dictionary<System.String,System.String[]> scopeBones; // 0xb0
	System.String[] scopeBoneConfig; // 0xb8
	System.Int32 selectScopeBoneIndex; // 0xc0
	System.String[] followBonesName; // 0xc8
	System.Collections.Generic.Dictionary<System.String,System.String[]> followBones; // 0xd0
	System.String[] followBoneConfig; // 0xd8
	System.Int32 selectFollowBoneIndex; // 0xe0
	System.Void .ctor(System.Int64 weaponId); // 0x06c43100
	System.Void setBonesData(System.Int32 id); // 0x06c43270
	System.Void setConfig(System.String[] BoneConfig, System.String[]& BonesName, System.Collections.Generic.Dictionary<System.String,System.String[]>& Bones); // 0x06c43434
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnap.MgrAimSnap : System.Object
{
	static System.Boolean Opt; // 0x0
	static System.Boolean GlobalAimSnapToggle; // 0x1
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable> Snappables; // 0x10
	Contexts.ClientContext context; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.BaseAimSnapController> SnapControllers; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.BaseAimSnapController> activeControllers; // 0x28
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.EditorAimSnapData CurrentEditorConfig; // 0x30
	System.Boolean IsEditorStart; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable> validSnappables; // 0x40
	static System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Auxiliary.AimSnap.EditorAimSnapData> EditorAimSnapDatas; // 0x8
	System.Collections.Generic.HashSet<UnityEngine.Transform> CheckedBones; // 0x48
	System.Collections.Generic.List<System.ValueTuple<System.Int32,UnityEngine.Transform>> CheckResultMap; // 0x50
	UnityEngine.RaycastCommand[] RayCastCommandArray; // 0x58
	UnityEngine.RaycastHit[] RayCastHitResultArray; // 0x60
	System.Single cur_base_fov_r; // 0x68
	System.Single zoom_rate; // 0x6c
	UnityEngine.Transform self; // 0x70
	System.Boolean FireToggle; // 0x78
	WizardGames.Soc.SocClient.Control.InputAdditional Additional; // 0x80
	System.Collections.Generic.List<UnityEngine.RaycastHit> tempHits; // 0x88
	System.Collections.Generic.Dictionary<UnityEngine.Transform,System.Boolean> BoneReachableState; // 0x90
	WizardGames.Soc.SocClient.Auxiliary.MgrAuxiliaryAim AimContext; // 0x98
	static System.Comparison<WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable> PriorityComparison; // 0x10
	UnityEngine.Camera get_MainCamera(); // 0x06c3b9a8
	System.Void Init(WizardGames.Soc.SocClient.Auxiliary.MgrAuxiliaryAim aimContext); // 0x05523a54
	System.Void Destroy(); // 0x06c38ddc
	System.Void resetBoneConfig(System.Int32 Id); // 0x06c4380c
	System.Void OnEntityGoCreated(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c3916c
	System.Void OnEntityGoRemoved(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c392fc
	System.Void CreateSnappable(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c43c40
	System.Void RemoveSnappable(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c43dec
	System.Boolean UpdateSortedSnappables(); // 0x06c440c0
	UnityEngine.Vector2 GetSelfSnapBoxCoe(System.Single distance); // 0x06c3cc7c
	System.Int32 GetPriority(System.Single dis_in_scope); // 0x06c44978
	System.Boolean CheckNeedUpdate(); // 0x06c37aec
	System.Single GetRayCastRange(); // 0x06c37188
	System.Void Fps30Update(); // 0x06c37b64
	System.Void RenderUpdate(System.Single dt); // 0x06c37bc8
	System.Void OptPreCheckBoneReachable(System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.BaseAimSnapController> controllers); // 0x06c44a50
	System.Void StartStateChange(System.Boolean isStart); // 0x06c455cc
	System.Void .ctor(); // 0x06c3813c
	static System.Void .cctor(); // 0x06c45648
	System.Void <Init>b__25_0(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06c45778
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnap.MgrAimSnap.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Auxiliary.AimSnap.MgrAimSnap.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x06c4629c
	System.Void .ctor(); // 0x06c46300
	System.Int32 <.cctor>b__44_0(WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable s1, WizardGames.Soc.SocClient.Auxiliary.AimSnap.Snappable s2); // 0x06c46368
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType Fire = 0;
	static WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType SlowDown = 1;
	static WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType Scope = 2;
	static WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType Follow = 3;
	static WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType Midline = 4;
	static WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType Count = 5;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxData : System.Object
{
	System.String Attach; // 0x10
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType BoxType; // 0x18
	UnityEngine.Vector2 Offset; // 0x1c
	UnityEngine.Vector2 Size; // 0x24
	UnityEngine.Vector2 DuckCoe; // 0x2c
	System.Void .ctor(); // 0x06c4641c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxConfig : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxConfig> Caches; // 0x8
	static System.Boolean isEditorStart; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxData>[] SnapBoxConfigs; // 0x10
	System.Int32 ID; // 0x18
	static WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxConfig GetConfig(System.Int32 id); // 0x06c46484
	static System.Void ClearCacheAimData(System.Int32 id); // 0x06c46b9c
	System.Void .ctor(System.Int32 id); // 0x06c46574
	System.Void SetBoneCofig(WizardGames.Soc.SocClient.Auxiliary.AimSnap.EditorAimSnapData currentData, System.String[][]& BoneConfig); // 0x06c46fdc
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxData> CreateBoxDatas(WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType t, System.String[] config); // 0x06c46ca0
	static UnityEngine.Vector2 _ParseVector2(System.String vec); // 0x06c47320
	System.Void CreateRuntimeData(WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxSet set, WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent opc); // 0x06c4753c
	static System.Void .cctor(); // 0x06c47c84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	UnityEngine.Transform Attach; // 0x10
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxData Data; // 0x18
	UnityEngine.Vector4 RelativeBound; // 0x20
	UnityEngine.Vector2 Coe; // 0x30
	UnityEngine.Vector2 AttachScreenCenter; // 0x38
	UnityEngine.Vector4 ScreenRect; // 0x40
	UnityEngine.Color DebugColor; // 0x50
	System.Void CalculateBound(UnityEngine.Vector2 coe); // 0x06c47db0
	System.Boolean CheckInside(UnityEngine.Camera cam, UnityEngine.Vector2 screen_pos); // 0x06c47e5c
	System.Void DrawGizmo(UnityEngine.Camera cam, System.Boolean red); // 0x06c47f64
	System.Void OnGet(); // 0x06c4839c
	System.Void OnRelease(); // 0x06c483fc
	System.Void OnDestroy(); // 0x06c48470
	System.Void .ctor(); // 0x06c484d0
	static System.Void .cctor(); // 0x06c48540
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxSet : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData>[] SnapBoxes; // 0x10
	System.Boolean Initialized; // 0x18
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxConfig config; // 0x20
	System.Collections.Generic.List<UnityEngine.Transform> AttachedPoints; // 0x28
	System.Collections.Generic.List<System.Byte> AttachPointReachableState; // 0x30
	System.Boolean TryBindBoxAttachPoint(WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData data, WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent opc); // 0x06c47988
	System.Void ResetAttachPointsState(); // 0x06c48614
	System.Void SetAttachPointsState(UnityEngine.Transform point, System.Boolean reachable); // 0x06c486cc
	System.Int32 GetAttachPointsState(UnityEngine.Transform point); // 0x06c487bc
	System.Void InitConfig(System.Int32 configID); // 0x06c48898
	System.Void BindGo(WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent opc); // 0x06c48944
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxRuntimeData> GetSnapBoxesByType(WizardGames.Soc.SocClient.Auxiliary.AimSnap.SnapBoxType type); // 0x06c48a1c
	System.Void OnGet(); // 0x06c48ab4
	System.Void OnRelease(); // 0x06c48b18
	System.Void OnDestroy(); // 0x06c48db8
	System.Void .ctor(); // 0x06c48e18
	static System.Void .cctor(); // 0x06c48f2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeSelectTarget : System.Object
{
	WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeTarget Target; // 0x10
	UnityEngine.Transform Bone; // 0x18
	UnityEngine.Vector3 Direction; // 0x20
	UnityEngine.Vector2 ScreenPoint; // 0x2c
	System.Boolean get_Valid(); // 0x06c49000
	System.Void .ctor(); // 0x06c490ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeController : System.Object
{
	WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimRangeRegulator <Regulator>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimTargetSelector Selector; // 0x18
	WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimRangeHandler Handler; // 0x20
	WizardGames.Soc.Common.Unity.Go.BaseEntityGo FirstRaycasted; // 0x28
	WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeSelectTarget Target; // 0x30
	System.Boolean lastOnState; // 0x38
	System.Collections.Generic.List<UnityEngine.RaycastHit> tempHits; // 0x40
	WizardGames.Soc.SocClient.Auxiliary.AimRange.MgrAimRange MgrAimRange; // 0x48
	WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimRangeRegulator get_Regulator(); // 0x06c49114
	System.Void set_Regulator(WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimRangeRegulator value); // 0x06c49178
	System.Void .ctor(WizardGames.Soc.SocClient.Auxiliary.AimRange.MgrAimRange mgrAimRange, WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimRangeRegulator regulator, WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimTargetSelector selector, WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimRangeHandler handler); // 0x06c491f8
	System.Void OnEntityGoCreated(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c493b4
	System.Void OnEntityGoRemoved(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c49498
	System.Single RaycastRange(); // 0x06c49580
	System.Void Update(System.Single dt); // 0x06c49720
	System.Void Release(); // 0x06c49dac
	System.Void OnRenderScreen(); // 0x06c4a020
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeDebugger : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeDebugger Instance; // 0x8
	UnityEngine.Material mat; // 0x30
	System.Int32 CircleSegment; // 0x38
	UnityEngine.Color EnableColor; // 0x3c
	UnityEngine.Color[] DisableColors; // 0x50
	static System.Int32 magicBulletHitCount; // 0x10
	static System.Int32 bulletTotal; // 0x14
	System.Void Awake(); // 0x06c4a290
	System.Void OnDestroy(); // 0x06c4a43c
	System.Void EndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext arg1, UnityEngine.Camera arg2); // 0x06c4a50c
	static System.Void OpenDebugger(System.Boolean open); // 0x06c4a744
	static System.Boolean get_IsDebuggerOpen(); // 0x06c4a8a0
	System.Void .ctor(); // 0x06c4a99c
	static System.Void .cctor(); // 0x06c4aa90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeCircleDetection : System.Object
{
	WizardGames.Soc.Common.Data.AimRangeConfig RawConfig; // 0x10
	System.Single DetectDistanceMin; // 0x18
	System.Single DetectDistanceMax; // 0x1c
	System.Single DetectInitAngle; // 0x20
	System.Single DetectingAngle; // 0x24
	WizardGames.Soc.SocClient.Auxiliary.AimRange.Detection _detection; // 0x28
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeTarget> targets; // 0x30
	WizardGames.Soc.SocClient.Auxiliary.AimRange.Detection get_Detection(); // 0x06c4ab74
	System.Void .ctor(WizardGames.Soc.Common.Data.AimRangeConfig config); // 0x06c4abd8
	System.Void Release(); // 0x06c4ad30
	System.Void ClearTargets(); // 0x06c4addc
	System.Void AddTarget(WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeTarget target); // 0x06c4ae60
	System.Void RemoveTarget(WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeTarget target); // 0x06c4af38
	System.Boolean InFanRange(UnityEngine.Vector3 origin, UnityEngine.Vector3 forward, UnityEngine.Vector3 position); // 0x06c4afd4
	System.Void PrepareDetectionUpdate(System.Single fovRate); // 0x06c4b234
	System.Void UpdateDetection(UnityEngine.Vector3 origin, UnityEngine.Vector3 forward); // 0x06c4b2b8
	UnityEngine.Vector2 GetScreenInRangePosition(UnityEngine.Vector2 originPos, UnityEngine.Vector2 center); // 0x06c4bcb8
	System.Void DrawScreenRange(UnityEngine.Color color); // 0x06c4bf10
	System.Void DrawScreenTarget(UnityEngine.Color color); // 0x06c4c2e8
	System.Void _DrawCircle(UnityEngine.Vector2 center, System.Single rad, UnityEngine.Color color); // 0x06c4c06c
	System.Void _DrawCross(UnityEngine.Vector2 center, System.Single length, UnityEngine.Color color); // 0x06c4c50c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeTarget : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.Collections.Generic.List<System.Int32> colliderIndices; // 0x10
	WizardGames.Soc.Common.Entity.IEntity entity; // 0x18
	System.Collections.Generic.List<UnityEngine.Transform> Colliders; // 0x20
	System.Boolean Initialized; // 0x28
	UnityEngine.Transform Root; // 0x30
	System.Void Init(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go, System.Collections.Generic.List<System.Int32> colliderIndex); // 0x06c4c6c0
	System.Void UpdateRoot(UnityEngine.Transform root); // 0x06c4c7dc
	System.Void OnGet(); // 0x06c4ca90
	System.Void OnRelease(); // 0x06c4caf0
	System.Boolean IsValid(); // 0x06c4cbcc
	System.Void OnDestroy(); // 0x06c4cea8
	static WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeTarget CreateTarget(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go, System.Collections.Generic.List<System.Int32> colliderIndex); // 0x06c4cf08
	System.Void .ctor(); // 0x06c4cfd8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeTargetSelector : WizardGames.Soc.SocClient.Auxiliary.AimRange.BaseAimRangeSelector, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeCircleDetection> _detections; // 0x28
	WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeCircleDetection <NearestDetection>k__BackingField; // 0x30
	System.Single MaxDistance; // 0x38
	System.Void set_NearestDetection(WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeCircleDetection value); // 0x06c4d0e8
	WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeCircleDetection get_NearestDetection(); // 0x06c4d168
	System.Void Init(WizardGames.Soc.Common.Data.AimRangeConfig[] configs, WizardGames.Soc.Common.Data.AimRangeTargetConfig[] targets); // 0x06c4d1cc
	System.Single get_MaxRange(); // 0x06c4d7f8
	static WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeTargetSelector Create(WizardGames.Soc.Common.Data.AimRangeConfig[] configs, WizardGames.Soc.Common.Data.AimRangeTargetConfig[] targets); // 0x06c4d85c
	System.Void DoEntityGoRemoved(WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeTarget target); // 0x06c4d92c
	System.Boolean UpdateTarget(System.Single fovRate, WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeSelectTarget& Target); // 0x06c4da00
	System.Void OnRenderScreen(System.Boolean aimTarget); // 0x06c4e3c0
	System.Void OnGet(); // 0x06c4e5e4
	System.Void OnRelease(); // 0x06c4e644
	System.Void OnDestroy(); // 0x06c4e938
	System.Void .ctor(); // 0x06c4e998
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.AngleRangeDetector : System.Object
{
	static WizardGames.Soc.SocClient.Auxiliary.AimRange.AngleRangeDetector _detector; // 0x0
	System.Single forwardDis; // 0x10
	System.Single reverseDis; // 0x14
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimRange.Detection> sortedDetection; // 0x18
	System.Collections.Generic.List<UnityEngine.RaycastHit> tempHits; // 0x20
	UnityEngine.RaycastHit[] reachableCertiCache; // 0x28
	static WizardGames.Soc.SocClient.Auxiliary.AimRange.AngleRangeDetector GetDetector(System.Single forwardDis, System.Single reverseDis); // 0x06c4b3ac
	System.Void UpdateDetection(UnityEngine.Vector3 origin, UnityEngine.Vector3 forwardN, System.Single forwardRad, System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeTarget> targets, WizardGames.Soc.SocClient.Auxiliary.AimRange.Detection& final); // 0x06c4b488
	System.Boolean CanReachDetection(UnityEngine.Vector3 origin, WizardGames.Soc.SocClient.Auxiliary.AimRange.Detection d); // 0x06c4ed2c
	System.Void Clear(); // 0x06c4f370
	System.Void ClearSortedDetection(); // 0x06c4f3d4
	System.Void .ctor(); // 0x06c4ebf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.AngleRangeDetector.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Auxiliary.AimRange.AngleRangeDetector.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Auxiliary.AimRange.Detection> <>9__7_0; // 0x8
	static System.Void .cctor(); // 0x06c4f52c
	System.Void .ctor(); // 0x06c4f590
	System.Int32 <UpdateDetection>b__7_0(WizardGames.Soc.SocClient.Auxiliary.AimRange.Detection b1, WizardGames.Soc.SocClient.Auxiliary.AimRange.Detection b2); // 0x06c4f5f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.BaseAimRangeSelector : System.Object, WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimTargetSelector
{
	SocLogger logger; // 0x10
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Go.BaseEntityGo,WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeTarget> _aimRangeTargets; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Data.AimRangeTargetConfig> targetConfigs; // 0x20
	System.Void Init(WizardGames.Soc.Common.Data.AimRangeTargetConfig[] targets); // 0x06c4d368
	System.Void OnEntityGoCreated(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c4f86c
	System.Void DoCreateTarget(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go, System.Collections.Generic.List<System.Int32> colliderIndex); // 0x06c4f69c
	System.Void OnEntityGoRemoved(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c4f9f8
	System.Void DoEntityGoRemoved(WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeTarget target); // 0x06c4fc14
	System.Boolean IsTargetType(System.Int32 entityTypeId); // 0x06c4fc88
	System.Void ClearTargets(); // 0x06c4e758
	System.Void Release(); // 0x06c4fd24
	System.Single get_MaxRange(); // 0x054a5abc
	System.Boolean UpdateTarget(System.Single fovRate, WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeSelectTarget& Target); // 0x054c6d04
	System.Void OnRelease(); // 0x055049cc
	System.Void OnRenderScreen(System.Boolean aimTarget); // 0x05523a7c
	System.Void .ctor(); // 0x06c4ea48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.Detection : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeTarget target; // 0x10
	UnityEngine.Transform bone; // 0x18
	System.Single dot; // 0x20
	UnityEngine.Vector3 dir; // 0x24
	System.Boolean get_IsValid(); // 0x06c4c4a0
	System.Void Copy(WizardGames.Soc.SocClient.Auxiliary.AimRange.Detection d); // 0x06c4f2bc
	System.Void OnGet(); // 0x06c4fd90
	System.Void OnRelease(); // 0x06c4fdf0
	System.Void OnDestroy(); // 0x06c4fe6c
	System.Void .ctor(); // 0x06c4fecc
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimTargetSelector : 
{
	
	System.Void OnEntityGoCreated(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x05523a54
	System.Void OnEntityGoRemoved(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x05523a54
	System.Boolean IsTargetType(System.Int32 entityTypeId); // 0x054c4f88
	System.Boolean UpdateTarget(System.Single fovRate, WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeSelectTarget& Target); // 0x054c6d04
	System.Void Release(); // 0x055049cc
	System.Single get_MaxRange(); // 0x054a5abc
	System.Void OnRenderScreen(System.Boolean aimTarget); // 0x05523a7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.TpMeleeAttackSelector : WizardGames.Soc.SocClient.Auxiliary.AimRange.BaseAimRangeSelector, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer Player; // 0x28
	System.Single halfheight; // 0x30
	System.Single angle; // 0x34
	System.Single range; // 0x38
	System.Single maxDis; // 0x3c
	System.Single minDis; // 0x40
	UnityEngine.Transform selfCC; // 0x48
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeTarget> validTargets; // 0x50
	WizardGames.Soc.SocClient.Auxiliary.AimRange.Detection _detection; // 0x58
	static WizardGames.Soc.SocClient.Auxiliary.AimRange.TpMeleeAttackSelector Create(WizardGames.Soc.Common.Syncronization.MgrMyPlayer player, System.Single height, System.Single maxDis, System.Single minDis, System.Single angle, WizardGames.Soc.Common.Data.AimRangeTargetConfig[] targets); // 0x06c4ff34
	System.Single get_MaxRange(); // 0x06c50090
	System.Void OnGet(); // 0x06c500f4
	System.Void OnRelease(); // 0x06c50154
	System.Void OnDestroy(); // 0x06c501c0
	System.Boolean UpdateTarget(System.Single fovRate, WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeSelectTarget& Target); // 0x06c50220
	System.Void DrawFanGizmo(UnityEngine.Matrix4x4 trs); // 0x06c50944
	System.Void DrawRad(UnityEngine.Vector3 pos, UnityEngine.Matrix4x4 trs, System.Single radius, System.Single halfAngle, UnityEngine.Vector3& start, UnityEngine.Vector3& end); // 0x06c50c74
	System.Void OnRenderScreen(System.Boolean aimTarget); // 0x06c50f54
	System.Void .ctor(); // 0x06c50fc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.BulletRedirectHandler : System.Object, WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimRangeHandler
{
	static SocLogger logger; // 0x0
	System.Void Update(System.Single dt, System.Boolean hasTarget, WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeSelectTarget selectTarget); // 0x06c51078
	System.Void OnEnter(); // 0x06c5137c
	System.Void OnExit(); // 0x06c513dc
	System.Void Release(); // 0x06c5143c
	System.Void .ctor(); // 0x06c5149c
	static System.Void .cctor(); // 0x06c51504
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimRangeHandler : 
{
	
	System.Void Update(System.Single dt, System.Boolean hasTarget, WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeSelectTarget selectTarget); // 0x055141bc
	System.Void OnEnter(); // 0x055049cc
	System.Void OnExit(); // 0x055049cc
	System.Void Release(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.MeleeAttackSnapHandler : System.Object, WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimRangeHandler
{
	WizardGames.Soc.SocClient.Control.InputAdditional InputAdditional; // 0x10
	WizardGames.Soc.Common.Entity.PlayerEntity Player; // 0x18
	System.Boolean moving; // 0x20
	System.Single time; // 0x24
	System.Single delay; // 0x28
	System.Single delayTime; // 0x2c
	WizardGames.Soc.Common.CustomType.MeleeCustom Melee; // 0x30
	System.Boolean stateTrigger; // 0x38
	System.Int32 dir; // 0x3c
	System.Single speed; // 0x40
	System.Single duration; // 0x44
	UnityEngine.Vector3 TargetDir; // 0x48
	System.Void .ctor(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Entity.IHeldItemEntity heldItem); // 0x06c515d8
	System.Void Update(System.Single dt, System.Boolean hasTarget, WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeSelectTarget selectTarget); // 0x06c517fc
	System.Void OnEnter(); // 0x06c51e1c
	System.Void OnExit(); // 0x06c51e7c
	System.Void Release(); // 0x06c51f3c
	System.Boolean snapping(System.Single dt, WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeSelectTarget selectTarget); // 0x06c51ac8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.SwipeCardSnapHandler : System.Object, WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimRangeHandler
{
	WizardGames.Soc.SocClient.Control.InputAdditional InputAdditional; // 0x10
	UnityEngine.Vector3 targetPos; // 0x18
	System.Boolean trigger; // 0x24
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer Player; // 0x28
	System.Single time; // 0x30
	System.Single speed; // 0x34
	System.Single duration; // 0x38
	UnityEngine.Vector3 TargetDir; // 0x3c
	UnityEngine.Quaternion or; // 0x48
	UnityEngine.Quaternion tr; // 0x58
	UnityEngine.Vector3 slerped_forward; // 0x68
	System.Void .ctor(WizardGames.Soc.Common.Syncronization.MgrMyPlayer myplayer); // 0x06c51f9c
	System.Void OnEnter(); // 0x06c52068
	System.Void OnExit(); // 0x06c521c4
	System.Void Release(); // 0x06c52320
	System.Void Update(System.Single dt, System.Boolean hasTarget, WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeSelectTarget selectTarget); // 0x06c52380
	System.Void OnSwipeCard(WizardGames.Soc.SocClient.Go.IOGo target, UnityEngine.Vector3 pos); // 0x06c526a8
	System.Boolean snapping(System.Single dt); // 0x06c52494
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.TpMeleeAttackSnapHandler : System.Object, WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimRangeHandler
{
	WizardGames.Soc.SocClient.Control.InputAdditional InputAdditional; // 0x10
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer Player; // 0x18
	System.Boolean moving; // 0x20
	System.Single time; // 0x24
	System.Single delay; // 0x28
	System.Single delayTime; // 0x2c
	WizardGames.Soc.Common.CustomType.MeleeCustom Melee; // 0x30
	System.Boolean stateTrigger; // 0x38
	System.Int32 dir; // 0x3c
	System.Single speed; // 0x40
	System.Single duration; // 0x44
	UnityEngine.Vector3 TargetDir; // 0x48
	UnityEngine.Transform root; // 0x58
	WizardGames.Soc.Common.Data.holdItem.HoldItemBase HoldTb; // 0x60
	System.Void .ctor(WizardGames.Soc.Common.Syncronization.MgrMyPlayer player, WizardGames.Soc.Common.Entity.IHeldItemEntity heldItem); // 0x0552af00
	System.Void OnUseHeldItem(WizardGames.Soc.Common.Entity.PlayerEntity player, System.Int64 firetime); // 0x06c52d80
	System.Void Update(System.Single dt, System.Boolean hasTarget, WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeSelectTarget selectTarget); // 0x06c52ee4
	System.Void OnEnter(); // 0x06c5380c
	System.Void OnExit(); // 0x06c5386c
	System.Void Release(); // 0x055049cc
	System.Void StartSnap(WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeSelectTarget selectTarget); // 0x06c52fe4
	System.Void EndSnap(); // 0x06c52e14
	System.Boolean snapping(System.Single dt, WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeSelectTarget selectTarget); // 0x06c53164
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.MgrAimRange : System.Object
{
	static System.Boolean BlockRotateSwitch; // 0x0
	static System.Boolean isEditorStart; // 0x1
	WizardGames.Soc.SocClient.Auxiliary.MgrAuxiliaryAim AimContext; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeController> _controllers; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeController> _allcontrollers; // 0x20
	WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeController swipeCardController; // 0x28
	System.Void Init(WizardGames.Soc.SocClient.Auxiliary.MgrAuxiliaryAim aimContext); // 0x06c53a4c
	System.Void ClearCallbacks(); // 0x06c53af0
	System.Void Destroy(); // 0x06c53b50
	System.Void CleanUp(); // 0x06c53bb4
	System.Void OnEntityGoCreated(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c53ce8
	System.Void OnEntityGoRemoved(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06c53e1c
	System.Void OnHeldItemUpdate(WizardGames.Soc.Common.Entity.IHeldItemEntity helditem); // 0x06c53ef4
	System.Single GetRayCastRange(); // 0x06c55560
	System.Boolean CheckNeedUpdate(); // 0x06c55638
	System.Void Fps30Update(); // 0x06c557e0
	System.Void RenderUpdate(System.Single dt); // 0x06c55840
	System.Void OnRenderScreen(); // 0x06c4a688
	WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeController CreateRangeWeaponController(WizardGames.Soc.Common.CustomType.WeaponCustom weapon); // 0x06c5454c
	WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeController CreateMeleeWeaponAttackController(WizardGames.Soc.Common.CustomType.MeleeCustom melee); // 0x06c54950
	WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeController CreateMeleeWeaponTpAttackController(WizardGames.Soc.Common.CustomType.MeleeCustom melee); // 0x06c54df0
	WizardGames.Soc.SocClient.Auxiliary.AimRange.AimRangeController CreateMeleeWeaponThrowController(WizardGames.Soc.Common.CustomType.MeleeCustom melee); // 0x06c55080
	System.Void .ctor(); // 0x06c55b8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.DefaultRegulator : System.Object, WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimRangeRegulator
{
	static WizardGames.Soc.SocClient.Auxiliary.AimRange.DefaultRegulator _instance; // 0x0
	static WizardGames.Soc.SocClient.Auxiliary.AimRange.DefaultRegulator get_Instance(); // 0x06c554ac
	System.Void .ctor(); // 0x06c55c70
	System.Boolean get_IsOn(); // 0x06c55cd8
	System.Boolean get_BlockByRaycast(); // 0x06c55d3c
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimRangeRegulator : 
{
	
	System.Boolean get_IsOn(); // 0x054c4760
	System.Boolean get_BlockByRaycast(); // 0x054c4760
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.MeleeAttackRegulator : System.Object, WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimRangeRegulator
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer Player; // 0x10
	WizardGames.Soc.Common.CustomType.MeleeCustom Melee; // 0x18
	System.Void .ctor(WizardGames.Soc.Common.Syncronization.MgrMyPlayer player, WizardGames.Soc.Common.CustomType.MeleeCustom melee); // 0x06c559a0
	System.Boolean get_IsOn(); // 0x06c55da0
	System.Boolean get_BlockByRaycast(); // 0x06c55e68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.MeleeAttackTpRegulator : System.Object, WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimRangeRegulator
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer Player; // 0x10
	WizardGames.Soc.Common.CustomType.MeleeCustom Melee; // 0x18
	System.Void .ctor(WizardGames.Soc.Common.Syncronization.MgrMyPlayer player, WizardGames.Soc.Common.CustomType.MeleeCustom melee); // 0x06c55a44
	System.Boolean get_IsOn(); // 0x06c55ecc
	System.Boolean get_BlockByRaycast(); // 0x06c55f94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.MeleeThrowRegulator : System.Object, WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimRangeRegulator
{
	WizardGames.Soc.Common.Entity.PlayerEntity Player; // 0x10
	WizardGames.Soc.Common.CustomType.MeleeCustom Melee; // 0x18
	System.Boolean get_BlockByRaycast(); // 0x06c55ff8
	System.Void .ctor(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.CustomType.MeleeCustom melee); // 0x06c55ae8
	System.Boolean get_IsOn(); // 0x06c5605c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Auxiliary.AimRange.RangeWeaponRegulator : System.Object, WizardGames.Soc.SocClient.Auxiliary.AimRange.IAimRangeRegulator
{
	WizardGames.Soc.Common.CustomType.WeaponCustom weapon; // 0x10
	System.Boolean get_BlockByRaycast(); // 0x06c560fc
	System.Void .ctor(WizardGames.Soc.Common.CustomType.WeaponCustom weapon); // 0x06c55914
	System.Boolean get_IsOn(); // 0x06c56160
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.AmbAudioBlockData : UnityEngine.ScriptableObject
{
	System.Single[] data; // 0x18
	System.Void .ctor(); // 0x06c561c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.AmbAudioDecorPrecomputeSpawn : System.Object
{
	static SocLogger logger; // 0x0
	static System.Single maxDistance; // 0x8
	static System.Int32 blockSize; // 0xc
	static System.String folderPath; // 0x10
	System.Int32 topology; // 0x10
	UnityEngine.Transform Anchor; // 0x18
	UnityEngine.Vector3 terrainPos; // 0x20
	UnityEngine.Vector3 terrainSize; // 0x2c
	UnityEngine.Vector3 lastPosition; // 0x38
	WizardGames.Soc.SocClient.Audio.LRUCache<System.Int32,WizardGames.Soc.SocClient.Audio.AmbAudioBlockData> loadedBlocks; // 0x48
	WizardGames.Soc.SocClient.Audio.AmbienceEmitter emitter; // 0x50
	WizardGames.Soc.SocClient.Audio.AmbienceEmitterData emitterData; // 0x58
	WritableString blockPath; // 0x60
	System.Boolean isLoading; // 0x70
	System.Void Init(); // 0x06c5622c
	System.Void Update(); // 0x06c56418
	System.Void BlockRemoveCallBack(System.Int32 id, WizardGames.Soc.SocClient.Audio.AmbAudioBlockData data); // 0x06c56c30
	System.Void Destroy(); // 0x06c56cec
	System.Boolean Shift(); // 0x06c56798
	System.Void UpdateEmitterPos(); // 0x06c568c0
	System.Void LoadBlockFile(System.Int32 index, System.Int32 x, System.Int32 z); // 0x06c570c8
	System.Void SetEmitterPos(System.Single[] data, System.Int32 x, System.Int32 z); // 0x06c571e0
	System.Void .ctor(); // 0x06c57480
	static System.Void .cctor(); // 0x06c576fc
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Audio.AmbAudioDecorPrecomputeSpawn.<LoadBlockFile>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Audio.AmbAudioDecorPrecomputeSpawn <>4__this; // 0x38
	System.Int32 index; // 0x40
	System.Int32 x; // 0x44
	System.Int32 z; // 0x48
	System.Runtime.CompilerServices.TaskAwaiter<WizardGames.Soc.SocClient.Audio.AmbAudioBlockData> <>u__1; // 0x50
	System.Void MoveNext(); // 0x06c5780c
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06c57de0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.AmbienceDefinition : System.Object
{
	System.Boolean isAmbience; // 0x10
	WizardGames.Soc.SocClient.Audio.AmbienceDefinition.ValueRange stingFrequency; // 0x18
	System.Int32 biomes; // 0x20
	System.Int32 topologies; // 0x24
	System.Boolean useEnvironmentType; // 0x28
	System.Int32 environmentType; // 0x2c
	UnityEngine.AnimationCurve time; // 0x30
	WizardGames.Soc.SocClient.Audio.AmbienceDefinition.ValueRange rain; // 0x38
	WizardGames.Soc.SocClient.Audio.AmbienceDefinition.ValueRange wind; // 0x40
	WizardGames.Soc.SocClient.Audio.AmbienceDefinition.ValueRange snow; // 0x48
	System.Boolean isRTPCState; // 0x50
	System.String groupName; // 0x58
	System.String stateName; // 0x60
	System.String eventName; // 0x68
	System.Void .ctor(); // 0x06c57e60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.AmbienceDefinition.ValueRange : System.Object
{
	System.Single min; // 0x10
	System.Single max; // 0x14
	System.Void .ctor(System.Single min, System.Single max); // 0x06c58080
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.AmbienceCameraEmitter : WizardGames.Soc.SocClient.Audio.AmbienceEmitter
{
	System.Int32 currentBiome; // 0x40
	System.Int32 currentTopology; // 0x44
	System.Single crossfadeTime; // 0x48
	UnityEngine.Vector3 lastPosition; // 0x4c
	System.Collections.Generic.List<System.Int32> biomeReadings; // 0x58
	System.Collections.Generic.List<System.Int32> topologyReadings; // 0x60
	System.Int32 readingsToKeep; // 0x68
	WizardGames.Soc.SocClient.Audio.AmbienceDefinition lastBaseSound; // 0x70
	System.Single lastCrossfade; // 0x78
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Audio.AmbienceDefinition,System.Single> nextStingTime; // 0x80
	System.Collections.Generic.HashSet<System.String> stingEventNames; // 0x88
	static System.Collections.Generic.HashSet<System.String> baseAmbienceEventNames; // 0x0
	System.String lastUnderWaterStateName; // 0x90
	System.Single time; // 0x98
