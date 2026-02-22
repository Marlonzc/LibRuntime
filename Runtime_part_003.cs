{
	static Framework.Replay.ReplayMode replayMode; // 0x0
	static WizardGames.Soc.Common.Unity.CameraState DefaultCameraState; // 0x4
	static System.Boolean IntervalReplace; // 0x8
	static System.Void .cctor(); // 0x05fe1f34
}

// Client.Runtime
struct Framework.Replay.ReplayKillsInfo : System.ValueType
{
	System.Int64 time_in_seconds; // 0x10
	System.String playerName; // 0x18
	System.String playerId; // 0x20
	Framework.Replay.ReplayClientSDK_KillType kill_type; // 0x28
	
}

// Client.Runtime
class Framework.Replay.ReplayDetailInfo : System.Object
{
	System.Int64 TotalSeconds; // 0x10
	System.Collections.Generic.List<Framework.Replay.ReplayKillsInfo> KillsInfos; // 0x18
	System.Void .ctor(); // 0x05fdcf80
}

// Client.Runtime
class Framework.Replay.MgrReplayNewTime : WizardGames.Soc.Common.Synchronization.MgrTime
{
	
	System.Void UpdateRenderTime(System.Int32 timeInterval); // 0x05fe1f88
	System.Void .ctor(); // 0x05fe21b4
}

// Client.Runtime
class Framework.Replay.ReplayNewCommandLineParser : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Dictionary<System.String,System.String> commandLineArgs; // 0x8
	static System.Void ParseCommandLine(); // 0x05fe2240
	static System.Void .cctor(); // 0x05fe28a4
}

// Client.Runtime
enum Framework.Replay.EReplayState : System.Enum
{
	System.Int32 value__; // 0x10
	static Framework.Replay.EReplayState None = 0;
	static Framework.Replay.EReplayState DownloadingReplayFile = 1;
	static Framework.Replay.EReplayState LoadingReplayFile = 2;
	static Framework.Replay.EReplayState InitMgr = 3;
	static Framework.Replay.EReplayState ClearLobbyMgr = 4;
	static Framework.Replay.EReplayState SceneLoading = 5;
	static Framework.Replay.EReplayState Preload = 6;
	static Framework.Replay.EReplayState LoadSuccess = 7;
	static Framework.Replay.EReplayState StartReplay = 8;
	static Framework.Replay.EReplayState EndReplay = 9;
	
}

// Client.Runtime
class Framework.Replay.ReplayNewMgr : System.Object
{
	static Framework.Replay.ReplayNewMgr _; // 0x0
	static SocLogger Logger; // 0x8
	Framework.Replay.EReplayState State; // 0x10
	static Share.Framework.Replay.ReplayReader _replayReader; // 0x10
	WizardGames.Soc.Share.Framework.RecordInfo _header; // 0x18
	Framework.Replay.ReplayDetailInfo ReplayDetailInfo; // 0x20
	System.Boolean OutputAceData; // 0x28
	Systems.BaseSystem.SmoothSystem smoothSystem; // 0x30
	Framework.Replay.DataCollect.ACEDataCollecter _aceDataCollecter; // 0x38
	System.Int32 MapId; // 0x40
	System.Boolean IsInitMgr; // 0x44
	System.Int32 CurGameModeID; // 0x48
	System.Boolean isLoadingScene; // 0x4c
	WizardGames.Soc.Common.Main.Loop.CustomLoop Fps30Loop; // 0x50
	WizardGames.Soc.Common.Main.Loop.CustomLoop FpsUnlimitedLoop; // 0x58
	static System.Int64 lastNetWorkUpdateTs; // 0x18
	System.Boolean _startLoadingRpc; // 0x60
	System.Boolean _loadingSuccessAck; // 0x61
	System.Int64 _lastPlayerEntityRenderTime; // 0x68
	System.Boolean isJumpToTime; // 0x70
	System.Single ReplaySpeed; // 0x74
	WizardGames.Soc.Share.Framework.RecordInfo get_Header(); // 0x05fe29d0
	System.Void OnFps30Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x05fe2a34
	System.Void OnFpsUnlimitedUpdate(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x05fe4330
	System.Void UpdateReplayFileLoad(System.Single delta); // 0x05fe2c00
	System.Void UpdateInitMgr(System.Single delta); // 0x05fe2c74
	System.Void UpdateClearLobbyMgr(System.Single delta); // 0x05fe35e8
	System.Void UpdatePreload(System.Single delta); // 0x05fe3c1c
	System.Boolean ProcessRpcWithCheck(); // 0x05fe4760
	WizardGames.Soc.Common.SimpleCustom.LoginBaseInfo GetFakeLoginBaseInfo(); // 0x05fe4980
	System.Void UpdateLoadSuccess(System.Single delta); // 0x05fe3d50
	System.Void UpdateSceneLoading(System.Single delta); // 0x05fe3b90
	System.Void UpdateReplay(System.Single delta); // 0x05fe420c
	System.Boolean UpdateNetWork(); // 0x05fe45a8
	System.Void CollectAceData(); // 0x05fe50a0
	System.Void UpdateWhenJumping(); // 0x05fe525c
	System.Void ParseIncrementalSnapshot(WizardGames.Soc.Common.Synchronization.SnapshotIncremental obj); // 0x05fe8428
	System.Void UpdateReplayEnd(System.Single delta); // 0x05fe42b8
	System.Void CleanUp(); // 0x05fe853c
	System.Void Quit(); // 0x05fe84b4
	System.Void StartReplayByCmdLine(System.String inputPath); // 0x05fe24b4
	System.String GetExeRootDirectory(); // 0x05fe87a4
	System.String ProcessPath(System.String inputPath, System.String rootDir); // 0x05fe8864
	System.Void StartReplayInternal(System.String filePath); // 0x05fe8944
	System.Void AddLoop(); // 0x05fe8d1c
	System.Void RemoveLoop(); // 0x05fe9004
	System.Void OnConfigApplyFinished(System.Collections.Generic.Dictionary<System.String,System.String> remoteConfigData); // 0x05fe90a0
	System.Void OnSceneLoadingFinished(); // 0x05fe921c
	System.Void OnLoginSceneLoadingFinished(); // 0x05fe9288
	System.Void OnReplayEnd(); // 0x05fe46f8
	System.Threading.Tasks.Task LoadGameSceneAsync(); // 0x05fe4f2c
	System.Threading.Tasks.Task LoadLoginSceneAsync(); // 0x05fe92f8
	static System.Void CreateReplayMainLoop(); // 0x05fe9408
	System.Void ChangeReplaySpeed(System.Single speed); // 0x05fe9518
	System.Boolean GoToSecond(System.Int64 timeInSecond); // 0x05fe9590
	System.Void .ctor(); // 0x05fe9a0c
	static System.Void .cctor(); // 0x05fe9a84
}

// Client.Runtime
class Framework.Replay.ReplayNewMgr.<>c : System.Object
{
	static Framework.Replay.ReplayNewMgr.<>c <>9; // 0x0
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.SocClient.Network.SocClientService> <>9__22_0; // 0x8
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.SocClient.Indicator.MgrIndicator> <>9__23_0; // 0x10
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.Common.Synchronization.MgrTime> <>9__23_1; // 0x18
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.SocClient.Indicator.MgrIndicator> <>9__55_0; // 0x20
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.Common.Synchronization.MgrTime> <>9__55_1; // 0x28
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.SocClient.Network.SocClientService> <>9__55_2; // 0x30
	static System.Void .cctor(); // 0x05fe9b88
	System.Void .ctor(); // 0x05fe9bec
	WizardGames.Soc.SocClient.Network.SocClientService& <UpdateInitMgr>b__22_0(); // 0x05fe9c54
	WizardGames.Soc.SocClient.Indicator.MgrIndicator& <UpdateClearLobbyMgr>b__23_0(); // 0x05fe9ce4
	WizardGames.Soc.Common.Synchronization.MgrTime& <UpdateClearLobbyMgr>b__23_1(); // 0x05fe9d74
	WizardGames.Soc.SocClient.Indicator.MgrIndicator& <LoadLoginSceneAsync>b__55_0(); // 0x05fe9e04
	WizardGames.Soc.Common.Synchronization.MgrTime& <LoadLoginSceneAsync>b__55_1(); // 0x05fe9e94
	WizardGames.Soc.SocClient.Network.SocClientService& <LoadLoginSceneAsync>b__55_2(); // 0x05fe9f24
}

// Client.Runtime
struct Framework.Replay.ReplayNewMgr.<LoadGameSceneAsync>d__54 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	Framework.Replay.ReplayNewMgr <>4__this; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter<System.ValueTuple<System.Boolean,System.String>> <>u__1; // 0x38
	System.Runtime.CompilerServices.TaskAwaiter <>u__2; // 0x40
	System.Void MoveNext(); // 0x05fe9fb4
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x05fea55c
}

// Client.Runtime
struct Framework.Replay.ReplayNewMgr.<LoadLoginSceneAsync>d__55 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	Framework.Replay.ReplayNewMgr <>4__this; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter<System.ValueTuple<System.Boolean,System.String>> <>u__1; // 0x38
	System.Void MoveNext(); // 0x05fea600
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x05feb430
}

// Client.Runtime
class Framework.Replay.ReplayNewWorldTime : System.Object
{
	static Framework.Replay.ReplayNewWorldTime _; // 0x0
	static SocLogger logger; // 0x8
	System.Void LogicUpdate(); // 0x05fe5040
	System.Void .ctor(); // 0x05feb4d4
	static System.Void .cctor(); // 0x05feb53c
}

// Client.Runtime
class Framework.Replay.ReplayPlayerMB : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x05feb640
}

// Client.Runtime
class Framework.Replay.ReplayWorldTime : System.Object
{
	static Framework.Replay.ReplayWorldTime _; // 0x0
	static SocLogger logger; // 0x8
	System.Int64 Now; // 0x10
	System.Int64 LogicFrameCount; // 0x18
	System.Void LogicUpdate(); // 0x05feb6a8
	System.Void .ctor(); // 0x05feb740
	static System.Void .cctor(); // 0x05feb7a8
}

// Client.Runtime
class Framework.Replay.ReplayClientSDKImpl : UnityEngine.MonoBehaviour
{
	static SocLogger Logger; // 0x0
	static System.Int32 max_player_name; // 0x8
	static Framework.Replay.SDK_INTERFACE sdk_interface; // 0x10
	static System.Boolean m_initSuccess; // 0x68
	static System.String PtrToWString(System.IntPtr wstrPtr); // 0x05fec4c8
	static System.Void FillUnicodeToChar(System.Void* dst, System.Int32 max, System.String txt); // 0x05fec628
	static System.Boolean ReplayClientSetPlayStateReady(); // 0x05feb8ac
	static System.Boolean ReplayClientPlayVideo(System.IntPtr replay_file_name); // 0x05feb978
	static System.Void ReplayClientOnPlayBegin(System.Boolean is_success); // 0x05fe4a40
	static System.Boolean ReplayClientExitVideo(); // 0x05feba34
	static System.Int32 ReplayClientGetKillsInfo(System.IntPtr player_id, System.Boolean is_be_killed, System.IntPtr kills_info, System.Int32 max_num); // 0x05febb00
	static System.Boolean ReplayClientGetTimeLength(System.UInt64& p_time_length); // 0x05febd30
	static System.Boolean ReplayClientGotoTime(System.Int64 time_in_seconds); // 0x05febe30
	static System.Boolean ReplayClientSetFollowPlayer(System.IntPtr player_id); // 0x05febf90
	static System.Boolean ReplayClientSetPlayerView(Framework.Replay.ReplayClientSDK_PlayerView player_view); // 0x05fec11c
	static System.Boolean ReplayClientSetWallhackEnabled(System.Boolean isopen); // 0x05fec1f0
	static System.Boolean ReplayClientSetTimeDilation(System.Single time_dilation); // 0x05fec2c4
	static System.Boolean ReplayClientHidePlayerInfo(System.Boolean hide); // 0x05fec40c
	System.Void Start(); // 0x05fecbac
	System.Void .ctor(); // 0x05fedbb0
	static System.Void .cctor(); // 0x05fedc18
}

// Client.Runtime
class Framework.Replay.ReplayClientSDKImpl.<>c__DisplayClass10_0 : System.Object
{
	System.Int64 time_in_seconds; // 0x10
	System.Void .ctor(); // 0x05fec958
	System.Void <ReplayClientGotoTime>b__0(); // 0x05fedd04
}

// Client.Runtime
enum Framework.Replay.ReplayClientSDK_KillType : System.Enum
{
	System.Int32 value__; // 0x10
	static Framework.Replay.ReplayClientSDK_KillType KILL_TYPE_DOWN = 1;
	static Framework.Replay.ReplayClientSDK_KillType KILL_TYPE_DEATH = 2;
	static Framework.Replay.ReplayClientSDK_KillType KILL_TYPE_REBIRTH = 3;
	
}

// Client.Runtime
struct Framework.Replay.ReplayClientSDK_KillsInfo : System.ValueType
{
	System.Int64 time_in_seconds; // 0x10
	Framework.Replay.ReplayClientSDK_KillsInfo.<death_player_name>e__FixedBuffer death_player_name; // 0x18
	Framework.Replay.ReplayClientSDK_KillsInfo.<death_player_id>e__FixedBuffer death_player_id; // 0x118
	Framework.Replay.ReplayClientSDK_KillType kill_type; // 0x218
	
}

// Client.Runtime
struct Framework.Replay.ReplayClientSDK_KillsInfo.<death_player_id>e__FixedBuffer : System.ValueType
{
	System.UInt32 FixedElementField; // 0x10
	
}

// Client.Runtime
struct Framework.Replay.ReplayClientSDK_KillsInfo.<death_player_name>e__FixedBuffer : System.ValueType
{
	System.UInt32 FixedElementField; // 0x10
	
}

// Client.Runtime
enum Framework.Replay.ReplayClientSDK_PlayerView : System.Enum
{
	System.Int32 value__; // 0x10
	static Framework.Replay.ReplayClientSDK_PlayerView Replay_Client_Player_View_First_Person = 1;
	static Framework.Replay.ReplayClientSDK_PlayerView Replay_Client_Player_View_Third_Person = 3;
	
}

// Client.Runtime
class Framework.Replay.ReplayClientSetPlayStateReady : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05fed20c
	System.Boolean Invoke(); // 0x05fede94
}

// Client.Runtime
class Framework.Replay.ReplayClientPlayVideo : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05fed2d0
	System.Boolean Invoke(System.IntPtr replay_file_name); // 0x05feded8
}

// Client.Runtime
class Framework.Replay.ReplayClientExitVideo : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05fed398
	System.Boolean Invoke(); // 0x05fedf24
}

// Client.Runtime
class Framework.Replay.ReplayClientGetKillsInfo : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05fed45c
	System.Int32 Invoke(System.IntPtr player_id, System.Boolean is_be_killed, System.IntPtr kills_info, System.Int32 max_num); // 0x05fedf68
}

// Client.Runtime
class Framework.Replay.ReplayClientGetTimeLength : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05fed524
	System.Boolean Invoke(System.UInt64& p_time_length); // 0x05fedfdc
}

// Client.Runtime
class Framework.Replay.ReplayClientGotoTime : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05fed5fc
	System.Boolean Invoke(System.Int64 time_in_seconds); // 0x05fee028
}

// Client.Runtime
class Framework.Replay.ReplayClientSetFollowPlayer : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05fed6c4
	System.Boolean Invoke(System.IntPtr player_id); // 0x05fee074
}

// Client.Runtime
class Framework.Replay.ReplayClientSetPlayerView : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05fed78c
	System.Boolean Invoke(Framework.Replay.ReplayClientSDK_PlayerView player_view); // 0x05fee0c0
}

// Client.Runtime
class Framework.Replay.ReplayClientSetWallhackEnabled : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05fed854
	System.Boolean Invoke(System.Boolean isopen); // 0x05fee10c
}

// Client.Runtime
class Framework.Replay.ReplayClientSetTimeDilation : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05fed91c
	System.Boolean Invoke(System.Single time_dilation); // 0x05fee158
}

// Client.Runtime
class Framework.Replay.ReplayClientHidePlayerInfo : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05fed9e4
	System.Boolean Invoke(System.Boolean hide); // 0x05fee1ac
}

// Client.Runtime
struct Framework.Replay.SDK_INTERFACE : System.ValueType
{
	Framework.Replay.ReplayClientSetPlayStateReady set_play_state_ready_interface; // 0x10
	Framework.Replay.ReplayClientPlayVideo play_video_interface; // 0x18
	Framework.Replay.ReplayClientExitVideo exit_video_interface; // 0x20
	Framework.Replay.ReplayClientGetKillsInfo get_kills_info_interface; // 0x28
	Framework.Replay.ReplayClientGetTimeLength get_time_length_interface; // 0x30
	Framework.Replay.ReplayClientGotoTime go_to_time_interface; // 0x38
	Framework.Replay.ReplayClientSetFollowPlayer set_follow_player_interface; // 0x40
	Framework.Replay.ReplayClientSetPlayerView set_player_view_interface; // 0x48
	Framework.Replay.ReplayClientSetWallhackEnabled set_wallhack_enabled_interface; // 0x50
	Framework.Replay.ReplayClientSetTimeDilation set_time_dilation_interface; // 0x58
	Framework.Replay.ReplayClientHidePlayerInfo hide_playerinfo_interface; // 0x60
	
}

// Client.Runtime
class Framework.Replay.ReplayCallBackSDK : System.Object
{
	
	static System.Boolean replay_client_sdk_initialize(Framework.Replay.SDK_INTERFACE& sdk_interface); // 0x05fedaac
	static System.Boolean replay_client_on_play_state_ready(System.Boolean is_success); // 0x05fec76c
	static System.Boolean replay_client_on_play_begin(System.Boolean is_success); // 0x05fec810
	static System.Boolean replay_client_on_play_end(System.Boolean is_success); // 0x05fec8b4
	static System.Boolean replay_client_on_goto_time_done(System.Boolean is_success); // 0x05feddf0
	static System.Boolean replay_client_on_set_follow_player_done(System.Boolean is_success); // 0x05fec9c0
	static System.Boolean replay_client_on_set_player_view_done(System.Boolean is_success); // 0x05feca64
	static System.Boolean replay_client_on_set_wallhack_enabled_done(System.Boolean is_success); // 0x05fecb08
}

// Client.Runtime
class Framework.Replay.InitModule.ReplayMgrIndicator : WizardGames.Soc.SocClient.Indicator.MgrIndicator
{
	
	System.Void Init(); // 0x05fee1f8
	System.Threading.Tasks.Task OnEnterWorld(); // 0x05fee258
	System.Threading.Tasks.Task OnExitWorld(); // 0x05fee358
	System.Void ReportData(); // 0x05fee458
	System.Void Update(); // 0x05fee4b8
	System.Void .ctor(); // 0x05fee518
}

// Client.Runtime
struct Framework.Replay.InitModule.ReplayMgrIndicator.<OnEnterWorld>d__1 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1; // 0x30
	System.Void MoveNext(); // 0x05fee5a4
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x05fee810
}

// Client.Runtime
struct Framework.Replay.InitModule.ReplayMgrIndicator.<OnExitWorld>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1; // 0x30
	System.Void MoveNext(); // 0x05fee8b4
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x05feeb20
}

// Client.Runtime
enum Framework.Replay.DataCollect.ACEActionDefine : System.Enum
{
	System.Int32 value__; // 0x10
	static Framework.Replay.DataCollect.ACEActionDefine Reload = 1001;
	static Framework.Replay.DataCollect.ACEActionDefine Crouch = 1002;
	static Framework.Replay.DataCollect.ACEActionDefine Stand = 1003;
	static Framework.Replay.DataCollect.ACEActionDefine AdsOn = 1004;
	static Framework.Replay.DataCollect.ACEActionDefine AdsOff = 1005;
	static Framework.Replay.DataCollect.ACEActionDefine Jump = 1006;
	static Framework.Replay.DataCollect.ACEActionDefine Swim = 1007;
	static Framework.Replay.DataCollect.ACEActionDefine MoveMantle = 1008;
	static Framework.Replay.DataCollect.ACEActionDefine MoveLadder = 1009;
	static Framework.Replay.DataCollect.ACEActionDefine Dying = 1010;
	static Framework.Replay.DataCollect.ACEActionDefine Dead = 1011;
	
}

// Client.Runtime
class Framework.Replay.DataCollect.ACEDataCollecter : System.Object
{
	static SocLogger logger; // 0x0
	System.String filePath; // 0x10
	System.IO.StreamWriter writer; // 0x18
	System.Int64 replayPlayerId; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Go.BasePlayerGo> players; // 0x28
	WizardGames.Soc.Common.Unity.Go.BasePlayerGo replayPlayer; // 0x30
	WizardGames.Soc.Common.Entity.PlayerEntity replayPlayerEntity; // 0x38
	WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo MgrEntityGo; // 0x40
	WizardGames.Soc.Common.Entity.BaseMgrEntity MgrEntity; // 0x48
	WizardGames.Soc.Common.DataSet.CommonDataSet<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> fireDataEventQueue; // 0x50
	WizardGames.Soc.Common.DataSet.CommonDataSet<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> damageDataEventQueue; // 0x58
	System.Int64 lastRenderTime; // 0x60
	System.Text.StringBuilder stringBuilder; // 0x68
	System.Void .ctor(System.Int64 replayPlayerId, System.String recordFileName); // 0x05fe4ae4
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05fef2ac
	System.Void OnGoLoadedCallback(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x05feeea0
	System.Void UnAliveStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase arg1, System.Byte oldValue, System.Byte newValue); // 0x05fef5b0
	System.Void MoveStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase arg1, System.Byte oldValue, System.Byte newValue); // 0x05fef7b8
	System.Void PoseStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase arg1, System.Byte oldValue, System.Byte newValue); // 0x05fef8b4
	System.Void Initialize(System.String recordFileName); // 0x05feebc4
	System.Void WriteContent(); // 0x05fef990
	System.Void AppendLine(System.String line); // 0x05fefb54
	System.Boolean IsReplayPlayerReady(System.Boolean checkRenderTime); // 0x05fefcb0
	System.Void CollectPlayerMove(); // 0x05fe5424
	System.Void CollectPlayerWorldToScreen(); // 0x05fe58fc
	System.Void CollectPlayerFireEvent(); // 0x05fe653c
	System.Void CollectPlayerDamageEvent(); // 0x05fe6f1c
	System.Void CollectPlayerAction(Framework.Replay.DataCollect.ACEActionDefine aceActionDefine); // 0x05fef668
	System.Void CollectFrameEnd(); // 0x05fe83a0
	System.Void Close(); // 0x05fe8704
	static System.Void .cctor(); // 0x05ff0724
}

// Client.Runtime
class Framework.Replay.DataCollect.DataCollectTool : System.Object
{
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Entity.PlayerPoseStateEnum,UnityEngine.Bounds> playerStateBounds; // 0x0
	static System.Collections.Generic.List<UnityEngine.Vector3> sortVertices; // 0x8
	static UnityEngine.Vector3 testCameraPos; // 0x10
	static System.Void InitPlayerBounds(WizardGames.Soc.Common.Unity.Go.BasePlayerGo playerGo); // 0x05fef460
	static WizardGames.Soc.Common.Unity.Utility.OBB GetPlayerWorldOBB(WizardGames.Soc.Common.Unity.Go.BasePlayerGo playerGo); // 0x05fefde8
	static System.Boolean CheckCameraCulling(UnityEngine.Vector3 cameraPos, System.Single yaw, System.Single pitch, System.Single fov, WizardGames.Soc.Common.Unity.Utility.OBB obb); // 0x05ff0060
	static System.Int32 SortFunc(UnityEngine.Vector3 left, UnityEngine.Vector3 right); // 0x05ff0b40
	static UnityEngine.Vector2 WorldToScreenPointManual(UnityEngine.Vector3 cameraPos, System.Single yaw, System.Single pitch, System.Single fov, UnityEngine.Vector3 worldPos); // 0x05ff0548
	static UnityEngine.Matrix4x4 CalculateViewMatrix(UnityEngine.Vector3 position, UnityEngine.Vector2 rotation); // 0x05ff07f8
	static UnityEngine.Matrix4x4 CalculateProjectionMatrix(System.Single fov, System.Single aspect, System.Single near, System.Single far); // 0x05ff0a90
	static System.Void .cctor(); // 0x05ff0d1c
}

// Client.Runtime
class XNode.Node : UnityEngine.ScriptableObject
{
	static SocLogger logger; // 0x0
	XNode.NodeGraph graph; // 0x18
	UnityEngine.Vector2 position; // 0x20
	XNode.Node.NodePortDictionary ports; // 0x28
	static XNode.NodeGraph graphHotfix; // 0x8
	System.Collections.Generic.IEnumerable<XNode.NodePort> get_InstancePorts(); // 0x05ff0e10
	System.Collections.Generic.IEnumerable<XNode.NodePort> get_InstanceOutputs(); // 0x05ff0f18
	System.Collections.Generic.IEnumerable<XNode.NodePort> get_InstanceInputs(); // 0x05ff1020
	XNode.NodePort AddInstanceInput(System.Type type, XNode.Node.ConnectionType connectionType, XNode.Node.TypeConstraint typeConstraint, System.String fieldName); // 0x05ff1128
	XNode.NodePort AddInstanceOutput(System.Type type, XNode.Node.ConnectionType connectionType, XNode.Node.TypeConstraint typeConstraint, System.String fieldName); // 0x05ff11b8
	XNode.NodePort AddInstancePort(System.Type type, XNode.NodePort.IO direction, XNode.Node.ConnectionType connectionType, XNode.Node.TypeConstraint typeConstraint, System.String fieldName); // 0x05ff1314
	System.Void RemoveInstancePort(System.String fieldName); // 0x05ff16c4
	System.Void RemoveInstancePort(XNode.NodePort port); // 0x05ff1734
	System.Void ClearInstancePorts(); // 0x05ff1934
	System.Collections.Generic.IEnumerable<XNode.NodePort> get_Ports(); // 0x05ff1b5c
	System.Collections.Generic.IEnumerable<XNode.NodePort> get_Outputs(); // 0x05ff1c90
	System.Collections.Generic.IEnumerable<XNode.NodePort> get_Inputs(); // 0x05ff1dc4
	System.Collections.Generic.IEnumerable<XNode.NodePort> get_DynamicPorts(); // 0x05ff0e74
	System.Collections.Generic.IEnumerable<XNode.NodePort> get_DynamicOutputs(); // 0x05ff0f7c
	System.Collections.Generic.IEnumerable<XNode.NodePort> get_DynamicInputs(); // 0x05ff1084
	System.Void OnEnable(); // 0x05ff20a8
	System.Void UpdatePorts(); // 0x05ff21c8
	System.Void Init(); // 0x05ff3534
	System.Void VerifyConnections(); // 0x05ff3594
	XNode.NodePort AddDynamicInput(System.Type type, XNode.Node.ConnectionType connectionType, XNode.Node.TypeConstraint typeConstraint, System.String fieldName); // 0x05ff386c
	XNode.NodePort AddDynamicOutput(System.Type type, XNode.Node.ConnectionType connectionType, XNode.Node.TypeConstraint typeConstraint, System.String fieldName); // 0x05ff1264
	XNode.NodePort AddDynamicPort(System.Type type, XNode.NodePort.IO direction, XNode.Node.ConnectionType connectionType, XNode.Node.TypeConstraint typeConstraint, System.String fieldName); // 0x05ff13d8
	System.Void RemoveDynamicPort(System.String fieldName); // 0x05ff39b8
	System.Void RemoveDynamicPort(XNode.NodePort port); // 0x05ff17b0
	System.Void ClearDynamicPorts(); // 0x05ff1998
	XNode.NodePort GetOutputPort(System.String fieldName); // 0x05ff3b70
	XNode.NodePort GetInputPort(System.String fieldName); // 0x05ff3c48
	XNode.NodePort GetPort(System.String fieldName); // 0x05ff3abc
	System.Boolean HasPort(System.String fieldName); // 0x05ff391c
	T GetInputValue<T>(System.String fieldName, T fallback); // 0x052af1f0
	T[] GetInputValues<T>(System.String fieldName, T[] fallback); // 0x052af1f0
	System.Object GetValue(XNode.NodePort port); // 0x05ff3d20
	System.Void OnCreateConnection(XNode.NodePort from, XNode.NodePort to); // 0x05ff3e94
	System.Void OnRemoveConnection(XNode.NodePort port); // 0x05ff3f10
	System.Void ClearConnections(); // 0x05ff3f84
	System.Void .ctor(); // 0x05ff425c
	static System.Void .cctor(); // 0x05ff4418
}

// Client.Runtime
enum XNode.Node.ShowBackingValue : System.Enum
{
	System.Int32 value__; // 0x10
	static XNode.Node.ShowBackingValue Never = 0;
	static XNode.Node.ShowBackingValue Unconnected = 1;
	static XNode.Node.ShowBackingValue Always = 2;
	
}

// Client.Runtime
enum XNode.Node.ConnectionType : System.Enum
{
	System.Int32 value__; // 0x10
	static XNode.Node.ConnectionType Multiple = 0;
	static XNode.Node.ConnectionType Override = 1;
	
}

// Client.Runtime
enum XNode.Node.TypeConstraint : System.Enum
{
	System.Int32 value__; // 0x10
	static XNode.Node.TypeConstraint None = 0;
	static XNode.Node.TypeConstraint Inherited = 1;
	static XNode.Node.TypeConstraint Strict = 2;
	static XNode.Node.TypeConstraint InheritedInverse = 3;
	static XNode.Node.TypeConstraint InheritedAny = 4;
	
}

// Client.Runtime
class XNode.Node.InputAttribute : System.Attribute
{
	XNode.Node.ShowBackingValue backingValue; // 0x10
	XNode.Node.ConnectionType connectionType; // 0x14
	System.Boolean dynamicPortList; // 0x18
	XNode.Node.TypeConstraint typeConstraint; // 0x1c
	System.Void .ctor(XNode.Node.ShowBackingValue backingValue, XNode.Node.ConnectionType connectionType, XNode.Node.TypeConstraint typeConstraint, System.Boolean dynamicPortList); // 0x05ff44ec
}

// Client.Runtime
class XNode.Node.OutputAttribute : System.Attribute
{
	XNode.Node.ShowBackingValue backingValue; // 0x10
	XNode.Node.ConnectionType connectionType; // 0x14
	System.Boolean dynamicPortList; // 0x18
	XNode.Node.TypeConstraint typeConstraint; // 0x1c
	System.Void .ctor(XNode.Node.ShowBackingValue backingValue, XNode.Node.ConnectionType connectionType, XNode.Node.TypeConstraint typeConstraint, System.Boolean dynamicPortList); // 0x05ff45a0
}

// Client.Runtime
class XNode.Node.NodeTintAttribute : System.Attribute
{
	UnityEngine.Color color; // 0x10
	System.Void .ctor(System.Byte r, System.Byte g, System.Byte b); // 0x05ff4654
}

// Client.Runtime
class XNode.Node.NodeWidthAttribute : System.Attribute
{
	System.Int32 width; // 0x10
	System.Void .ctor(System.Int32 width); // 0x05ff472c
}

// Client.Runtime
class XNode.Node.NodePortDictionary : System.Collections.Generic.Dictionary<System.String,XNode.NodePort>, UnityEngine.ISerializationCallbackReceiver
{
	System.Collections.Generic.List<System.String> keys; // 0x50
	System.Collections.Generic.List<XNode.NodePort> values; // 0x58
	System.Void OnBeforeSerialize(); // 0x05ff47b0
	System.Void OnAfterDeserialize(); // 0x05ff4aa8
	System.Void .ctor(); // 0x05ff42f8
}

// Client.Runtime
class XNode.Node.<get_DynamicInputs>d__27 : System.Object, System.Collections.Generic.IEnumerable<XNode.NodePort>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<XNode.NodePort>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	XNode.NodePort <>2__current; // 0x18
	System.Int32 <>l__initialThreadId; // 0x20
	XNode.Node <>4__this; // 0x28
	System.Collections.Generic.IEnumerator<XNode.NodePort> <>7__wrap1; // 0x30
	System.Void .ctor(System.Int32 <>1__state); // 0x05ff2018
	System.Void System.IDisposable.Dispose(); // 0x05ff4d40
	System.Boolean MoveNext(); // 0x05ff4dc4
	System.Void <>m__Finally1(); // 0x05ff5134
	XNode.NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.get_Current(); // 0x05ff5210
	System.Void System.Collections.IEnumerator.Reset(); // 0x05ff5274
	System.Object System.Collections.IEnumerator.get_Current(); // 0x05ff52fc
	System.Collections.Generic.IEnumerator<XNode.NodePort> System.Collections.Generic.IEnumerable<XNode.NodePort>.GetEnumerator(); // 0x05ff5360
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x05ff5430
}

// Client.Runtime
class XNode.Node.<get_DynamicOutputs>d__25 : System.Object, System.Collections.Generic.IEnumerable<XNode.NodePort>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<XNode.NodePort>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	XNode.NodePort <>2__current; // 0x18
	System.Int32 <>l__initialThreadId; // 0x20
	XNode.Node <>4__this; // 0x28
	System.Collections.Generic.IEnumerator<XNode.NodePort> <>7__wrap1; // 0x30
	System.Void .ctor(System.Int32 <>1__state); // 0x05ff1f88
	System.Void System.IDisposable.Dispose(); // 0x05ff5494
	System.Boolean MoveNext(); // 0x05ff5518
	System.Void <>m__Finally1(); // 0x05ff5888
	XNode.NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.get_Current(); // 0x05ff5964
	System.Void System.Collections.IEnumerator.Reset(); // 0x05ff59c8
	System.Object System.Collections.IEnumerator.get_Current(); // 0x05ff5a50
	System.Collections.Generic.IEnumerator<XNode.NodePort> System.Collections.Generic.IEnumerable<XNode.NodePort>.GetEnumerator(); // 0x05ff5ab4
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x05ff5b84
}

// Client.Runtime
class XNode.Node.<get_DynamicPorts>d__23 : System.Object, System.Collections.Generic.IEnumerable<XNode.NodePort>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<XNode.NodePort>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	XNode.NodePort <>2__current; // 0x18
	System.Int32 <>l__initialThreadId; // 0x20
	XNode.Node <>4__this; // 0x28
	System.Collections.Generic.IEnumerator<XNode.NodePort> <>7__wrap1; // 0x30
	System.Void .ctor(System.Int32 <>1__state); // 0x05ff1ef8
	System.Void System.IDisposable.Dispose(); // 0x05ff5be8
	System.Boolean MoveNext(); // 0x05ff5c6c
	System.Void <>m__Finally1(); // 0x05ff5fc8
	XNode.NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.get_Current(); // 0x05ff60a4
	System.Void System.Collections.IEnumerator.Reset(); // 0x05ff6108
	System.Object System.Collections.IEnumerator.get_Current(); // 0x05ff6190
	System.Collections.Generic.IEnumerator<XNode.NodePort> System.Collections.Generic.IEnumerable<XNode.NodePort>.GetEnumerator(); // 0x05ff61f4
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x05ff62c4
}

// Client.Runtime
class XNode.Node.<get_Inputs>d__21 : System.Object, System.Collections.Generic.IEnumerable<XNode.NodePort>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<XNode.NodePort>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	XNode.NodePort <>2__current; // 0x18
	System.Int32 <>l__initialThreadId; // 0x20
	XNode.Node <>4__this; // 0x28
	System.Collections.Generic.IEnumerator<XNode.NodePort> <>7__wrap1; // 0x30
	System.Void .ctor(System.Int32 <>1__state); // 0x05ff1e68
	System.Void System.IDisposable.Dispose(); // 0x05ff6328
	System.Boolean MoveNext(); // 0x05ff63ac
	System.Void <>m__Finally1(); // 0x05ff66b0
	XNode.NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.get_Current(); // 0x05ff678c
	System.Void System.Collections.IEnumerator.Reset(); // 0x05ff67f0
	System.Object System.Collections.IEnumerator.get_Current(); // 0x05ff6878
	System.Collections.Generic.IEnumerator<XNode.NodePort> System.Collections.Generic.IEnumerable<XNode.NodePort>.GetEnumerator(); // 0x05ff68dc
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x05ff69ac
}

// Client.Runtime
class XNode.Node.<get_Outputs>d__19 : System.Object, System.Collections.Generic.IEnumerable<XNode.NodePort>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<XNode.NodePort>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	XNode.NodePort <>2__current; // 0x18
	System.Int32 <>l__initialThreadId; // 0x20
	XNode.Node <>4__this; // 0x28
	System.Collections.Generic.IEnumerator<XNode.NodePort> <>7__wrap1; // 0x30
	System.Void .ctor(System.Int32 <>1__state); // 0x05ff1d34
	System.Void System.IDisposable.Dispose(); // 0x05ff6a10
	System.Boolean MoveNext(); // 0x05ff6a94
	System.Void <>m__Finally1(); // 0x05ff6d98
	XNode.NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.get_Current(); // 0x05ff6e74
	System.Void System.Collections.IEnumerator.Reset(); // 0x05ff6ed8
	System.Object System.Collections.IEnumerator.get_Current(); // 0x05ff6f60
	System.Collections.Generic.IEnumerator<XNode.NodePort> System.Collections.Generic.IEnumerable<XNode.NodePort>.GetEnumerator(); // 0x05ff6fc4
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x05ff7094
}

// Client.Runtime
class XNode.Node.<get_Ports>d__17 : System.Object, System.Collections.Generic.IEnumerable<XNode.NodePort>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<XNode.NodePort>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	XNode.NodePort <>2__current; // 0x18
	System.Int32 <>l__initialThreadId; // 0x20
	XNode.Node <>4__this; // 0x28
	System.Collections.Generic.Dictionary.ValueCollection.Enumerator<System.String,XNode.NodePort> <>7__wrap1; // 0x30
	System.Void .ctor(System.Int32 <>1__state); // 0x05ff1c00
	System.Void System.IDisposable.Dispose(); // 0x05ff70f8
	System.Boolean MoveNext(); // 0x05ff717c
	System.Void <>m__Finally1(); // 0x05ff7384
	XNode.NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.get_Current(); // 0x05ff7408
	System.Void System.Collections.IEnumerator.Reset(); // 0x05ff746c
	System.Object System.Collections.IEnumerator.get_Current(); // 0x05ff74f4
	System.Collections.Generic.IEnumerator<XNode.NodePort> System.Collections.Generic.IEnumerable<XNode.NodePort>.GetEnumerator(); // 0x05ff7558
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x05ff7628
}

// Client.Runtime
class XNode.NodeDataCache : System.Object
{
	static SocLogger logger; // 0x0
	static XNode.NodeDataCache.PortDataCache portDataCache; // 0x8
	static System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.String,System.String>> formerlySerializedAsCache; // 0x10
	static System.Boolean get_Initialized(); // 0x05ff768c
	static System.Void UpdatePorts(XNode.Node node, System.Collections.Generic.Dictionary<System.String,XNode.NodePort> ports); // 0x05ff2258
	static System.Type GetBackingValueType(System.Type portValType); // 0x05ff7dec
	static System.Boolean IsDynamicListPort(XNode.NodePort port); // 0x05ff7b84
	static System.Void BuildCache(); // 0x05ff771c
	static System.Collections.Generic.List<System.Reflection.FieldInfo> GetNodeFields(System.Type nodeType); // 0x05ff8984
	static System.Void CachePorts(System.Type nodeType); // 0x05ff7f2c
	static System.Void .cctor(); // 0x05ff8c84
}

// Client.Runtime
class XNode.NodeDataCache.PortDataCache : System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.List<XNode.NodePort>>, UnityEngine.ISerializationCallbackReceiver
{
	System.Collections.Generic.List<System.Type> keys; // 0x50
	System.Collections.Generic.List<System.Collections.Generic.List<XNode.NodePort>> values; // 0x58
	System.Void OnBeforeSerialize(); // 0x0613c16c
	System.Void OnAfterDeserialize(); // 0x0613c464
	System.Void .ctor(); // 0x0613c634
}

// Client.Runtime
class XNode.NodeDataCache.<>c : System.Object
{
	static XNode.NodeDataCache.<>c <>9; // 0x0
	static System.Func<System.Object,System.Boolean> <>9__7_0; // 0x8
	static System.Func<System.Object,System.Boolean> <>9__10_0; // 0x10
	static System.Func<System.Object,System.Boolean> <>9__10_1; // 0x18
	static System.Func<System.Object,System.Boolean> <>9__10_2; // 0x20
	static System.Void .cctor(); // 0x0613c754
	System.Void .ctor(); // 0x0613c7b8
	System.Boolean <IsDynamicListPort>b__7_0(System.Object x); // 0x0613c820
	System.Boolean <CachePorts>b__10_0(System.Object x); // 0x0613c948
	System.Boolean <CachePorts>b__10_1(System.Object x); // 0x0613ca08
	System.Boolean <CachePorts>b__10_2(System.Object x); // 0x0613cac8
}

// Client.Runtime
class XNode.NodeDataCache.<>c__DisplayClass8_0 : System.Object
{
	System.Type baseType; // 0x10
	System.Func<System.Type,System.Boolean> <>9__0; // 0x18
	System.Void .ctor(); // 0x0613cb88
	System.Boolean <BuildCache>b__0(System.Type t); // 0x0613cbf0
}

// Client.Runtime
class XNode.NodeDataCache.<>c__DisplayClass9_0 : System.Object
{
	System.Reflection.FieldInfo parentField; // 0x10
	System.Void .ctor(); // 0x0613cc98
	System.Boolean <GetNodeFields>b__0(System.Reflection.FieldInfo x); // 0x0613cd00
}

// Client.Runtime
class XNode.NodeGraph : UnityEngine.ScriptableObject
{
	System.Collections.Generic.List<XNode.Node> nodes; // 0x18
	T AddNode<T>(); // 0x052af1f0
	XNode.Node AddNode(System.Type type); // 0x0613cdbc
	XNode.Node CopyNode(XNode.Node original); // 0x0613cf38
	System.Void RemoveNode(XNode.Node node); // 0x0613d0c8
	System.Void Clear(); // 0x0613d1e4
	XNode.NodeGraph Copy(); // 0x0613d350
	System.Void OnDestroy(); // 0x0613daa8
	System.Void .ctor(); // 0x0613db08
}

// Client.Runtime
class XNode.NodePort : System.Object
{
	static SocLogger logger; // 0x0
	System.Type valueType; // 0x10
	System.String _fieldName; // 0x18
	XNode.Node _node; // 0x20
	System.String _typeQualifiedName; // 0x28
	System.Collections.Generic.List<XNode.NodePort.PortConnection> connections; // 0x30
	XNode.NodePort.IO _direction; // 0x38
	XNode.Node.ConnectionType _connectionType; // 0x3c
	XNode.Node.TypeConstraint _typeConstraint; // 0x40
	System.Boolean _dynamic; // 0x44
	System.Int32 get_ConnectionCount(); // 0x0613dbbc
	XNode.NodePort get_Connection(); // 0x0613dc38
	XNode.NodePort.IO get_direction(); // 0x0613dda4
	System.Void set_direction(XNode.NodePort.IO value); // 0x0613de08
	XNode.Node.ConnectionType get_connectionType(); // 0x0613de80
	System.Void set_connectionType(XNode.Node.ConnectionType value); // 0x0613dee4
	XNode.Node.TypeConstraint get_typeConstraint(); // 0x0613df5c
	System.Void set_typeConstraint(XNode.Node.TypeConstraint value); // 0x0613dfc0
	System.Boolean get_IsConnected(); // 0x0613e038
	System.Boolean get_IsInput(); // 0x0613e0bc
	System.Boolean get_IsOutput(); // 0x0613e16c
	System.String get_fieldName(); // 0x0613e21c
	XNode.Node get_node(); // 0x0613e280
	System.Boolean get_IsDynamic(); // 0x0613e2e4
	System.Boolean get_IsStatic(); // 0x0613e348
	System.Type get_ValueType(); // 0x0613e3b4
	System.Void set_ValueType(System.Type value); // 0x0613e4c0
	System.Void .ctor(System.Reflection.FieldInfo fieldInfo); // 0x0613e5b4
	System.Void .ctor(XNode.NodePort nodePort, XNode.Node node); // 0x0613e854
	System.Void .ctor(System.String fieldName, System.Type type, XNode.NodePort.IO direction, XNode.Node.ConnectionType connectionType, XNode.Node.TypeConstraint typeConstraint, XNode.Node node); // 0x0613e9b4
	System.Void VerifyConnections(); // 0x0613eafc
	System.Object GetOutputValue(); // 0x0613ecb0
	System.Object GetInputValue(); // 0x0613edc8
	System.Object[] GetInputValues(); // 0x0613ee40
	T GetInputValue<T>(); // 0x052af1f0
	T[] GetInputValues<T>(); // 0x052af1f0
	System.Void Connect(XNode.NodePort port); // 0x0613efd0
	System.Collections.Generic.List<XNode.NodePort> GetConnections(); // 0x0613f8f8
	XNode.NodePort GetConnection(System.Int32 i); // 0x0613fa58
	System.Boolean IsConnectedTo(XNode.NodePort port); // 0x0613f5c8
	System.Boolean CanConnectTo(XNode.NodePort port); // 0x0613fbe0
	System.Void Disconnect(XNode.NodePort port); // 0x061400b4
	System.Void ClearConnections(); // 0x0613f6a8
	System.Void Redirect(System.Collections.Generic.List<XNode.Node> oldNodes, System.Collections.Generic.List<XNode.Node> newNodes); // 0x0613d898
	static System.Void .cctor(); // 0x061402dc
}

// Client.Runtime
enum XNode.NodePort.IO : System.Enum
{
	System.Int32 value__; // 0x10
	static XNode.NodePort.IO Input = 0;
	static XNode.NodePort.IO Output = 1;
	
}

// Client.Runtime
class XNode.NodePort.PortConnection : System.Object
{
	System.String fieldName; // 0x10
	XNode.Node node; // 0x18
	XNode.NodePort port; // 0x20
	System.Collections.Generic.List<UnityEngine.Vector2> reroutePoints; // 0x28
	XNode.NodePort get_Port(); // 0x0613dd18
	System.Void .ctor(XNode.NodePort port); // 0x0613f768
	XNode.NodePort GetPort(); // 0x061403b0
}

// Client.Runtime
class XNode.SceneGraph : UnityEngine.MonoBehaviour
{
	XNode.NodeGraph graph; // 0x30
	System.Void .ctor(); // 0x06140480
}

// Client.Runtime
class XNode.SceneGraph<T> : XNode.SceneGraph
{
	
	T get_graph(); // 0x052af1f0
	System.Void set_graph(T value); // 0x052af1f0
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class Rust.AI.AStarNode : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	Rust.AI.AStarNode Parent; // 0x20
	System.Single G; // 0x28
	System.Single H; // 0x2c
	WizardGames.Soc.Common.MonumentPath.BasePointInfo Node; // 0x30
	System.Single get_F(); // 0x061404e8
	System.Void .ctor(); // 0x06140550
	static Rust.AI.AStarNode Generate(); // 0x061405b8
	System.Void Update(System.Single g, System.Single h, Rust.AI.AStarNode parent, WizardGames.Soc.Common.MonumentPath.BasePointInfo node); // 0x06140630
	System.Boolean Satisfies(WizardGames.Soc.Common.MonumentPath.BasePointInfo node); // 0x0614070c
	static System.Boolean op_LessThan(Rust.AI.AStarNode lhs, Rust.AI.AStarNode rhs); // 0x061407c8
	static System.Boolean op_GreaterThan(Rust.AI.AStarNode lhs, Rust.AI.AStarNode rhs); // 0x06140870
}

// Client.Runtime
class Rust.AI.AStarNodeList : System.Collections.Generic.List<System.UInt64>
{
	Rust.AI.AStarNodeList.AStarNodeComparer comparer; // 0x28
	Rust.AI.AStarNode GetAStarNodeOf(WizardGames.Soc.Common.MonumentPath.BasePointInfo n); // 0x06140918
	System.Void AStarNodeSort(); // 0x06140a4c
	System.Void .ctor(); // 0x06140acc
}

// Client.Runtime
class Rust.AI.AStarNodeList.AStarNodeComparer : System.Object, System.Collections.Generic.IComparer<System.UInt64>
{
	
	System.Int32 System.Collections.Generic.IComparer<System.UInt64>.Compare(System.UInt64 lhsMid, System.UInt64 rhsMid); // 0x06140c14
	System.Void .ctor(); // 0x06140bac
}

// Client.Runtime
class Rust.Modular.ItemModVehicleChassis : ItemMod
{
	GameObjectRef entityPrefab; // 0x38
	System.Int32 socketsTaken; // 0x40
	System.Int32 get_SocketsTaken(); // 0x06140cf8
	System.Void .ctor(); // 0x06140d5c
}

// Client.Runtime
class Rust.Modular.ItemModVehicleModule : ItemMod
{
	static SocLogger logger; // 0x0
	System.Int64 TemplateId; // 0x38
	GameObjectRef entityPrefab; // 0x40
	System.Int32 socketsTaken; // 0x48
	System.Boolean doNonUserSpawn; // 0x4c
	System.Int32 get_SocketsTaken(); // 0x06140dcc
	BaseVehicleModule CreateModuleEntity(BaseRustEntity parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); // 0x06140e30
	System.Void OnAddModule(BaseRustEntity parent, BaseRustEntity entity); // 0x06141208
	BaseRustEntity InstantiatePrefab(UnityEngine.GameObject prefab, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot); // 0x061410ac
	System.Void .ctor(); // 0x06141338
	static System.Void .cctor(); // 0x061413a8
}

// Client.Runtime
class Rust.Modular.ConditionalObjectEffect : System.Object
{
	System.Int32 EffectId; // 0x10
	System.String BindChildName; // 0x18
	System.Void .ctor(); // 0x0614147c
}

// Client.Runtime
class Rust.Modular.ConditionalObject : System.Object
{
	static SocLogger logger; // 0x0
	System.Boolean shouldEmitGib; // 0x10
	System.Boolean IsEngineEffect; // 0x11
	System.Boolean IsEngineEffectCheck; // 0x12
	System.Collections.Generic.List<Rust.Modular.ConditionalObjectEffect> SpawnEffectIDs; // 0x18
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf SpawnAudioConf; // 0x20
	UnityEngine.GameObject gameObject; // 0x38
	UnityEngine.GameObject ownerGameObject; // 0x40
	Rust.Modular.ConditionalSocketSettings[] socketSettings; // 0x48
	System.Boolean restrictOnHealth; // 0x50
	System.Single healthRestrictionMin; // 0x54
	System.Single healthRestrictionMax; // 0x58
	System.Boolean restrictOnAdjacent; // 0x5c
	Rust.Modular.ConditionalObject.AdjacentCondition adjacentRestriction; // 0x60
	Rust.Modular.ConditionalObject.AdjacentMatchType adjacentMatch; // 0x64
	System.Boolean restrictOnLockable; // 0x68
	System.Boolean lockableRestriction; // 0x69
	System.Boolean ActiveDirty; // 0x6a
	System.Nullable<System.Boolean> <IsActive>k__BackingField; // 0x6b
	System.Nullable<System.Boolean> get_IsActive(); // 0x061414e4
	System.Void set_IsActive(System.Nullable<System.Boolean> value); // 0x06141548
	System.Void SetActive(System.Boolean active); // 0x061415c0
	static System.Void .cctor(); // 0x0614179c
}

// Client.Runtime
enum Rust.Modular.ConditionalObject.AdjacentCondition : System.Enum
{
	System.Int32 value__; // 0x10
	static Rust.Modular.ConditionalObject.AdjacentCondition SameInFront = 0;
	static Rust.Modular.ConditionalObject.AdjacentCondition SameBehind = 1;
	static Rust.Modular.ConditionalObject.AdjacentCondition DifferentInFront = 2;
	static Rust.Modular.ConditionalObject.AdjacentCondition DifferentBehind = 3;
	static Rust.Modular.ConditionalObject.AdjacentCondition BothDifferent = 4;
	static Rust.Modular.ConditionalObject.AdjacentCondition BothSame = 5;
	
}

// Client.Runtime
enum Rust.Modular.ConditionalObject.AdjacentMatchType : System.Enum
{
	System.Int32 value__; // 0x10
	static Rust.Modular.ConditionalObject.AdjacentMatchType GroupOrExact = 0;
	static Rust.Modular.ConditionalObject.AdjacentMatchType ExactOnly = 1;
	static Rust.Modular.ConditionalObject.AdjacentMatchType GroupNotExact = 2;
	
}

// Client.Runtime
class Rust.Modular.ConditionalSocketSettings : System.Object
{
	System.Boolean restrictOnLocation; // 0x10
	Rust.Modular.ConditionalSocketSettings.LocationCondition locationRestriction; // 0x14
	System.Boolean restrictOnWheel; // 0x18
	Rust.Modular.ModularVehicleSocket.SocketWheelType wheelRestriction; // 0x1c
	System.Boolean get_HasSocketRestrictions(); // 0x06141870
	System.Void .ctor(); // 0x061418e4
}

// Client.Runtime
enum Rust.Modular.ConditionalSocketSettings.LocationCondition : System.Enum
{
	System.Int32 value__; // 0x10
	static Rust.Modular.ConditionalSocketSettings.LocationCondition Middle = 0;
	static Rust.Modular.ConditionalSocketSettings.LocationCondition Front = 1;
	static Rust.Modular.ConditionalSocketSettings.LocationCondition Back = 2;
	static Rust.Modular.ConditionalSocketSettings.LocationCondition NotMiddle = 3;
	static Rust.Modular.ConditionalSocketSettings.LocationCondition NotFront = 4;
	static Rust.Modular.ConditionalSocketSettings.LocationCondition NotBack = 5;
	
}

// Client.Runtime
class Rust.Modular.ModularVehicleSocket : System.Object
{
	UnityEngine.Transform socketTransform; // 0x10
	Rust.Modular.ModularVehicleSocket.SocketWheelType wheelType; // 0x18
	Rust.Modular.ModularVehicleSocket.SocketLocationType locationType; // 0x1c
	UnityEngine.Transform get_Transform(); // 0x0614194c
	UnityEngine.Vector3 get_WorldPosition(); // 0x061419b0
	UnityEngine.Quaternion get_WorldRotation(); // 0x06141a20
	Rust.Modular.ModularVehicleSocket.SocketWheelType get_WheelType(); // 0x06141a90
	Rust.Modular.ModularVehicleSocket.SocketLocationType get_LocationType(); // 0x06141af4
	System.Boolean ShouldBeActive(Rust.Modular.ConditionalSocketSettings modelSettings); // 0x06141b58
	System.Void .ctor(); // 0x06141cec
}

// Client.Runtime
enum Rust.Modular.ModularVehicleSocket.SocketWheelType : System.Enum
{
	System.Int32 value__; // 0x10
	static Rust.Modular.ModularVehicleSocket.SocketWheelType NoWheel = 0;
	static Rust.Modular.ModularVehicleSocket.SocketWheelType ForwardWheel = 1;
	static Rust.Modular.ModularVehicleSocket.SocketWheelType BackWheel = 2;
	
}

// Client.Runtime
enum Rust.Modular.ModularVehicleSocket.SocketLocationType : System.Enum
{
	System.Int32 value__; // 0x10
	static Rust.Modular.ModularVehicleSocket.SocketLocationType Middle = 0;
	static Rust.Modular.ModularVehicleSocket.SocketLocationType Front = 1;
	static Rust.Modular.ModularVehicleSocket.SocketLocationType Back = 2;
	
}

// Client.Runtime
class Rust.Modular.ModuleSocketController : System.Object
{
	System.Int32 TotalSockets; // 0x10
	WizardGames.Soc.Common.Entity.IVehicleModuleCustom[] _modules; // 0x18
	System.Void .ctor(System.Int32 totalSockets); // 0x06141d54
	System.Void AddModule(WizardGames.Soc.Common.Entity.IVehicleModuleCustom moduleEntity); // 0x06141e04
	System.Void RemoveModule(WizardGames.Soc.Common.Entity.IVehicleModuleCustom moduleEntity); // 0x0614200c
	System.Boolean SocketsAreFree(System.Int32 socketIndex, System.Int32 socketsTaken); // 0x061421e8
	System.Boolean SocketIsFree(System.Int32 socketIndex); // 0x06142348
	System.Boolean SocketValid(System.Int32 socketIndex); // 0x061422c4
}

// Client.Runtime
class Rust.Modular.VehicleModuleSlidingComponent : System.Object
{
	System.Int32 SeatIndex; // 0x10
	System.String interactionColliderName; // 0x18
	System.Single moveTime; // 0x20
	Rust.Modular.VehicleModuleSlidingComponent.SlidingPart[] slidingParts; // 0x28
	System.Single positionPercent; // 0x30
	System.Boolean WantsOpenPos(BaseVehicleModule parentEntity); // 0x06142400
	System.Void ServerUpdateTick(BaseVehicleModule parentModule); // 0x061425cc
	System.Void ClientUpdateTick(BaseVehicleModule parentModule); // 0x061428a0
	System.Void CheckPosition(BaseVehicleModule parentEntity, System.Single dt); // 0x06142650
	System.Void .ctor(); // 0x06142924
}

// Client.Runtime
class Rust.Modular.VehicleModuleSlidingComponent.SlidingPart : System.Object
{
	UnityEngine.Transform transform; // 0x10
	UnityEngine.Vector3 openPosition; // 0x18
	UnityEngine.Vector3 closedPosition; // 0x24
	UnityEngine.GameObject InteractionTarget; // 0x30
	System.Void .ctor(); // 0x061429b8
}

// Client.Runtime
class Go.PureGo.MgrPureGo : WizardGames.Soc.Common.Manager.MgrBase
{
	
	T GeneratePureGoItemOnPlayer<T>(WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent parent, System.String pureGoPath, WizardGames.Soc.Common.Const.EHeldSocketType socketType, System.Boolean isFp); // 0x052af1f0
	System.Void .ctor(); // 0x06142a20
}

// Client.Runtime
class Go.PureGo.PureGoItem : System.Object
{
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent Parent; // 0x10
	System.String PureGoPath; // 0x18
	UnityEngine.GameObject PureGo; // 0x20
	System.Boolean IsActive; // 0x28
	WizardGames.Soc.SocClient.Auxiliary.FpEffectCrossSwitch CrossSwitch; // 0x30
	System.Void OnRelease(); // 0x06142a88
	System.Void ReleaseToPool(); // 0x06142ba0
	System.Void .ctor(); // 0x06142c40
}

// Client.Runtime
class Go.GoComp.SmoothHistory : System.Object
{
	UnityEngine.Vector3 LastPosition; // 0x10
	UnityEngine.Vector3 LastRotation; // 0x1c
	UnityEngine.Vector3 Position; // 0x28
	UnityEngine.Vector3 Rotation; // 0x34
	System.Int32 TotalInterval; // 0x40
	System.Int32 AccumulatorTime; // 0x44
	System.Int32 cmdSequence; // 0x48
	System.Void .ctor(); // 0x06142ca8
}

// Client.Runtime
enum Go.GoComp.StopState : System.Enum
{
	System.Int32 value__; // 0x10
	static Go.GoComp.StopState None = 0;
	static Go.GoComp.StopState Stopping = 1;
	static Go.GoComp.StopState Stopped = 2;
	
}

// Client.Runtime
class Go.GoComp.SmoothRendererNodeComp : System.Object
{
	static SocLogger <Logger>k__BackingField; // 0x0
	UnityEngine.Transform RendererNode; // 0x10
	UnityEngine.Transform rendererNodeParent; // 0x18
	System.String initName; // 0x20
	UnityEngine.Vector3 initLocalPosition; // 0x28
	UnityEngine.Vector3 offset2MainTransform; // 0x34
	UnityEngine.Renderer[] _renderers; // 0x40
	System.Int64 lastServerTime; // 0x48
	UnityEngine.Vector3 lastPosition; // 0x50
	UnityEngine.Vector3 lastRotation; // 0x5c
	UnityEngine.Vector3 position; // 0x68
	UnityEngine.Vector3 rotation; // 0x74
	System.Single frameInterval; // 0x80
	System.Boolean updatePos; // 0x84
	System.Int32 accumulatorTime; // 0x88
	WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo; // 0x90
	System.Collections.Generic.List<Go.GoComp.SmoothHistory> histories; // 0x98
	static SocLogger get_Logger(); // 0x06142d10
	System.Boolean get_Visible(); // 0x06142d98
	System.Void .ctor(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo, UnityEngine.Transform rendererNode, System.Boolean updatePos, UnityEngine.Transform root); // 0x06142e54
	System.Void SetPositionAndRotation(System.Int32 deltaTime); // 0x0614319c
	System.Void Release(); // 0x06143b0c
	System.Void GetSmoothData(System.Int32 deltaTime, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot); // 0x0614375c
	System.Void ClearHistories(); // 0x06143be0
	System.Void RecordPosAndRot(System.Int32 totalFrameTime, System.Int32 cmdSequence); // 0x06143c84
	UnityEngine.Transform Find(System.String path); // 0x06143ef4
	static System.Void .cctor(); // 0x06143fc4
}

// Client.Runtime
class Go.GoComp.SmoothComp : System.Object
{
	System.Boolean SmoothNeeded; // 0x10
	System.Boolean SkipSmooth; // 0x11
	System.Single FrameInterval; // 0x14
	System.Int64 LastServerTime; // 0x18
	UnityEngine.Vector3 LastPosition; // 0x20
	UnityEngine.Vector3 LastRotation; // 0x2c
	UnityEngine.Vector3 Position; // 0x38
	UnityEngine.Vector3 Rotation; // 0x44
	System.Single ViewYaw; // 0x50
	System.Single ViewPitch; // 0x54
	System.Boolean HasAnimation; // 0x58
	System.Boolean ParentHasAnimation; // 0x59
	System.Int64 ParentId; // 0x60
	System.Int64 MountID; // 0x68
	UnityEngine.Vector3 LocalLastPosition; // 0x70
	UnityEngine.Vector3 LocalPosition; // 0x7c
	UnityEngine.Quaternion LocalLastRotation; // 0x88
	UnityEngine.Quaternion LocalRotation; // 0x98
	System.Single LastViewYaw; // 0xa8
	System.Single LastViewPitch; // 0xac
	Go.GoComp.StopState stopState; // 0xb0
	System.Int64 stopTimeHandle; // 0xb8
	UnityEngine.MeshRenderer[] MeshRendererList; // 0xc0
	UnityEngine.SkinnedMeshRenderer[] SkinnedMeshRendererList; // 0xc8
	CommonUnity.Runtime.Replay.LongDoublePointerQueue HistoryServerTimeCache; // 0xd0
	System.Collections.Generic.Dictionary<System.Int64,CommonUnity.Runtime.Replay.ReplayPosAndRot> HistoryServerTime2PosAndRot; // 0xd8
	System.Int64 _lastRenderTime; // 0xe0
	UnityEngine.Transform Transform; // 0xe8
	static SocLogger logger; // 0x0
	static System.Int32 SqrMagnitude = 100;
	UnityEngine.Vector3 _last; // 0xf0
	UnityEngine.Vector3 _dir; // 0xfc
	System.Void .ctor(UnityEngine.Transform transform); // 0x06144098
	System.Void initData(WizardGames.Soc.Common.Entity.ISmoothCloneEntity smoothGoGetEntity, System.Int64 lastServerTime); // 0x06144208
	System.Void MarkMove(); // 0x06144acc
	System.Void MarkStopMove(); // 0x06144cb8
	System.Void StopMoveCallback(System.Int64 handle, System.Object data, System.Boolean delete); // 0x06144e40
	System.Void Dispose(); // 0x06144ff8
	System.Void UpdateViewYawAndPitch(System.Single viewYaw, System.Single viewPitch); // 0x0614511c
	System.Boolean UpdateEntityData(WizardGames.Soc.Common.Entity.ISmoothCloneEntity smoothGoGetEntity, System.Int64 lastServerTime); // 0x061451a4
	System.Void UpdateTransform(WizardGames.Soc.Common.Entity.ISmoothCloneEntity smoothEntity, System.Single factor); // 0x061457e0
	System.Void UpdateLocalTransform(WizardGames.Soc.Common.Entity.ISmoothCloneEntity smoothEntity, System.Single factor, UnityEngine.Vector3& localPos, UnityEngine.Quaternion& localRot, UnityEngine.Transform transform); // 0x06146134
	UnityEngine.Vector3 GetCalculateVelocity(); // 0x06146f28
	static System.Void .cctor(); // 0x06146fc0
}

// Client.Runtime
class Share.Framework.Replay.ReplayRpcHelper : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.HashSet<System.Int32> ignoreMethodIds; // 0x8
	static System.Collections.Generic.List<System.String> ignoreMethodNames; // 0x10
	static System.Collections.Generic.HashSet<System.Int32> attentionMethodIds; // 0x18
	static System.Boolean CanExecute(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x06147094
	static System.Void Execute(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x06147244
	static System.Void TestExecute(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x061475b0
	static System.Void .cctor(); // 0x06147e98
}

// Client.Runtime
class Share.Framework.Replay.ReplayReader : System.Object
{
	static SocLogger logger; // 0x0
	System.IO.FileStream fs; // 0x10
	System.IO.BinaryReader br; // 0x18
	WizardGames.Soc.Share.Framework.RecordInfo header; // 0x20
	WizardGames.Soc.Common.Framework.MemoryBuffer buffer; // 0x28
	System.Void .ctor(System.String filePath); // 0x061480d4
	WizardGames.Soc.Share.Framework.RecordInfo ReadReplayHeader(); // 0x06148360
	WizardGames.Soc.Share.Framework.Network.DecodedRpc ReadOneRpc(); // 0x06148544
	System.Void Dispose(); // 0x0614899c
	System.Void TryFillBuffer(); // 0x061487d8
	static System.Void .cctor(); // 0x06148aa0
}

// Client.Runtime
class Share.Common.ObjPool.PropArray<TValue> : System.Object, WizardGames.Soc.Common.Cache.IPooledObject
{
	TValue[] Array; // 0x0
	System.Int32 <AlignLen>k__BackingField; // 0x0
	System.Boolean <IsReturn>k__BackingField; // 0x0
	System.Int32 <UseCount>k__BackingField; // 0x0
	System.Int32 get_AlignLen(); // 0x0548ba98
	System.Void set_AlignLen(System.Int32 value); // 0x055056e8
	System.Boolean get_IsReturn(); // 0x054c4760
	System.Void set_IsReturn(System.Boolean value); // 0x05523a7c
	System.Int32 get_UseCount(); // 0x0548ba98
	System.Void set_UseCount(System.Int32 value); // 0x055056e8
	System.Int32 get_Length(); // 0x0548ba98
	System.Void ReturnToPool(); // 0x055049cc
	static Share.Common.ObjPool.PropArray<TValue> New(System.Int32 arrLen); // 0x054e2d84
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class Share.Common.ObjPool.PropArrayPoolInitializer : System.Object
{
	
	static System.Void Init(); // 0x06148b74
	static System.Int32 AlignLen(System.Int32 arrLen); // 0x06148c48
	static System.String GetPropPoolStat(System.Text.StringBuilder sb); // 0x06148d58
}

// Client.Runtime
class Share.Common.ObjPool.PropArrayConcurrentPool<TValue> : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Cache.PoolWithLock<Share.Common.ObjPool.PropArray<TValue>>> poolDict; // 0x8
	static System.Collections.Generic.IReadOnlyDictionary<System.Int32,System.Int32> ALIGN_LEN_CAP_DICT; // 0x10
	static System.Int32 MAX_SLICE_COUNT; // 0x18
	static System.Void Init(); // 0x054fd168
	static Share.Common.ObjPool.PropArray<TValue> Alloc(System.Int32 arrLen); // 0x054e2d84
	static System.Void Free(Share.Common.ObjPool.PropArray<TValue> array); // 0x055049cc
	static System.Void LogStat(System.Text.StringBuilder sb); // 0x055049cc
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
interface Share.Entity.Interface.ILadderEntity : 
{
	
	System.Int64 get_EntityId(); // 0x054a4380
}

// Client.Runtime
class Soc.Vehicle.GamePhysics : System.Object
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Unity.Utility.GamePhysicsSystem gamePhysicsSystem; // 0x8
	static System.Comparison<UnityEngine.RaycastHit> cached_sort_func; // 0x10
	static UnityEngine.Vector3 upperPosOffset; // 0x18
	static System.Collections.Generic.List<UnityEngine.Collider> colliderBuffer; // 0x28
	static System.Void Initialize(WizardGames.Soc.Common.Unity.Utility.GamePhysicsSystem system); // 0x06148e90
	static UnityEngine.Collider[] get_colBuffer(); // 0x06148f94
	static UnityEngine.RaycastHit[] get_hitBuffer(); // 0x061490d4
	static System.Void OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Collections.Generic.List<UnityEngine.Collider> list, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction triggerInteraction); // 0x06149214
	static System.Void BufferToList(System.Int32 count, System.Collections.Generic.List<UnityEngine.Collider> list); // 0x0614943c
	static System.Boolean Trace(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction triggerInteraction, BaseRustEntity ignoreEntity); // 0x06149618
	static System.Void TraceAllUnordered(UnityEngine.Ray ray, System.Single radius, System.Collections.Generic.List<UnityEngine.RaycastHit>& hits, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction triggerInteraction, BaseRustEntity ignoreEntity); // 0x06149844
	static System.Boolean LineOfSightRadius(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Int32 layerMask, System.Single radius, System.Single padding0, System.Single padding1, BaseRustEntity ignoreEntity); // 0x06149dcc
	static System.Boolean LineOfSight(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Int32 layerMask, BaseRustEntity ignoreEntity); // 0x0614a028
	static System.Boolean LineOfSightInternal(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Int32 layerMask, System.Single radius, System.Single padding0, System.Single padding1, BaseRustEntity ignoreEntity); // 0x06149f28
	static System.Boolean Verify(UnityEngine.RaycastHit hitInfo, BaseRustEntity ignoreEntity); // 0x06149cbc
	static System.Boolean Verify(UnityEngine.Collider collider, UnityEngine.Vector3 point, BaseRustEntity ignoreEntity); // 0x0614a154
	static System.Int32 HandleTerrainCollision(UnityEngine.Vector3 position, System.Int32 layerMask); // 0x061493a8
	static System.Void Sort(System.Collections.Generic.List<UnityEngine.RaycastHit> hits); // 0x06149c08
	static System.Boolean IsPosValid(UnityEngine.Vector3 checkPos, UnityEngine.Vector3& groundPos, System.Func<UnityEngine.GameObject,System.Boolean> checkFunc); // 0x0614a3b8
	static System.Void .cctor(); // 0x0614a874
}

// Client.Runtime
class Soc.Vehicle.GamePhysics.<>c : System.Object
{
	static Soc.Vehicle.GamePhysics.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x0614aa78
	System.Void .ctor(); // 0x0614aadc
	System.Int32 <.cctor>b__54_0(UnityEngine.RaycastHit a, UnityEngine.RaycastHit b); // 0x0614ab44
}

// Client.Runtime
enum Soc.Vehicle.DamageType : System.Enum
{
	System.Int32 value__; // 0x10
	static Soc.Vehicle.DamageType Generic = 0;
	static Soc.Vehicle.DamageType Hunger = 1;
	static Soc.Vehicle.DamageType Thirst = 2;
	static Soc.Vehicle.DamageType Cold = 3;
	static Soc.Vehicle.DamageType Drowned = 4;
	static Soc.Vehicle.DamageType Heat = 5;
	static Soc.Vehicle.DamageType Bleeding = 6;
	static Soc.Vehicle.DamageType Poison = 7;
	static Soc.Vehicle.DamageType Suicide = 8;
	static Soc.Vehicle.DamageType Bullet = 9;
	static Soc.Vehicle.DamageType Slash = 10;
	static Soc.Vehicle.DamageType Blunt = 11;
	static Soc.Vehicle.DamageType Fall = 12;
	static Soc.Vehicle.DamageType Radiation = 13;
	static Soc.Vehicle.DamageType Bite = 14;
	static Soc.Vehicle.DamageType Stab = 15;
	static Soc.Vehicle.DamageType Explosion = 16;
	static Soc.Vehicle.DamageType RadiationExposure = 17;
	static Soc.Vehicle.DamageType ColdExposure = 18;
	static Soc.Vehicle.DamageType Decay = 19;
	static Soc.Vehicle.DamageType ElectricShock = 20;
	static Soc.Vehicle.DamageType Arrow = 21;
	static Soc.Vehicle.DamageType AntiVehicle = 22;
	static Soc.Vehicle.DamageType Collision = 23;
	static Soc.Vehicle.DamageType Fun_Water = 24;
	static Soc.Vehicle.DamageType LAST = 25;
	
}

// Client.Runtime
class Soc.Vehicle.DamageTypeList : System.Object
{
	System.Single[] types; // 0x10
	System.Void Set(Soc.Vehicle.DamageType index, System.Single amount); // 0x0614ac08
	System.Single Get(Soc.Vehicle.DamageType index); // 0x0614acb4
	System.Void Scale(Soc.Vehicle.DamageType index, System.Single amount); // 0x0614ad4c
	System.Boolean Has(Soc.Vehicle.DamageType index); // 0x0614adec
	System.Void ScaleAll(System.Single amount); // 0x0614ae74
}

// Client.Runtime
enum Soc.Vehicle.HitArea : System.Enum
{
	System.Int32 value__; // 0x10
	static Soc.Vehicle.HitArea Head = 1;
	static Soc.Vehicle.HitArea Chest = 2;
	static Soc.Vehicle.HitArea Stomach = 4;
	static Soc.Vehicle.HitArea Arm = 8;
	static Soc.Vehicle.HitArea Hand = 16;
	static Soc.Vehicle.HitArea Leg = 32;
	static Soc.Vehicle.HitArea Foot = 64;
	
}

// Client.Runtime
class Soc.Vehicle.TriggerBase : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	UnityEngine.LayerMask interestLayers; // 0x30
	System.Collections.Generic.HashSet<UnityEngine.Collider> contents; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,UnityEngine.Collider> entityContents; // 0x40
	System.Boolean get_HasAnyContents(); // 0x0614af20
	System.Boolean get_HasAnyEntityContents(); // 0x0614afa8
	System.Void Awake(); // 0x0614b030
	UnityEngine.GameObject InterestedInObject(UnityEngine.Collider obj); // 0x0614b110
	System.Void OnDisable(); // 0x0614b278
	UnityEngine.GameObject OnTriggerEnterFilter(UnityEngine.GameObject go, UnityEngine.Collider obj); // 0x0614b908
	System.Void OnTriggerEnter(UnityEngine.Collider collider); // 0x0614b988
	System.Void OnObjects(); // 0x0614bba4
	WizardGames.Soc.Common.Unity.Go.BaseEntityGo GetEntityGo(UnityEngine.Collider col); // 0x0614bc04
	System.Void OnObjectAdded(UnityEngine.Collider col); // 0x0614bdac
	System.Void OnEntityEnter(WizardGames.Soc.Common.Unity.Go.BaseEntityGo ent, UnityEngine.Collider col); // 0x0614be94
	System.Void OnTriggerExit(UnityEngine.Collider collider); // 0x0614b5d0
	System.Void OnObjectRemoved(UnityEngine.Collider obj); // 0x0614c000
	System.Void OnEntityLeave(WizardGames.Soc.Common.Unity.Go.BaseEntityGo ent); // 0x0614c39c
	System.Void RemoveInvalidEntities(); // 0x0614c464
	System.Void OnEmpty(); // 0x0614d058
	System.Void RemoveObject(UnityEngine.GameObject obj); // 0x0614d100
	System.Void RemoveEntity(WizardGames.Soc.Common.Unity.Go.BaseEntityGo ent); // 0x0614cc5c
	System.Boolean SkipOnTriggerExit(UnityEngine.Collider collider); // 0x0614d218
	System.Void RemoveContentedEntity(System.Int64 entityId); // 0x0614d290
	System.Void .ctor(); // 0x0614d364
	static System.Void .cctor(); // 0x0614d470
}

// Client.Runtime
class Soc.Vehicle.TriggerWakeupVehicle : Soc.Vehicle.TriggerBase
{
	
	System.Void OnEntityEnter(WizardGames.Soc.Common.Unity.Go.BaseEntityGo ent, UnityEngine.Collider col); // 0x0614d544
	System.Void .ctor(); // 0x0614d620
}

// Client.Runtime
class Soc.Vehicle.InputMessage : System.Object
{
	System.Int32 buttons; // 0x10
	UnityEngine.Vector3 mouseDelta; // 0x14
	
}

// Client.Runtime
enum Soc.Vehicle.SeatStyleType : System.Enum
{
	System.Int32 value__; // 0x10
	static Soc.Vehicle.SeatStyleType 马乘坐驾驶 = 10001;
	static Soc.Vehicle.SeatStyleType 快艇乘坐 = 10002;
	static Soc.Vehicle.SeatStyleType 模块载具乘坐 = 10003;
	static Soc.Vehicle.SeatStyleType 直升机乘坐 = 10004;
	static Soc.Vehicle.SeatStyleType 木舟乘坐与驾驶 = 10005;
	static Soc.Vehicle.SeatStyleType 模块载具基本驾驶位 = 10006;
	static Soc.Vehicle.SeatStyleType 火车驾驶位 = 10007;
	static Soc.Vehicle.SeatStyleType 快艇驾驶 = 10008;
	static Soc.Vehicle.SeatStyleType 降落伞驾驶 = 10009;
	
}

// Client.Runtime
class Soc.Vehicle.MountPointInfo : System.Object
{
	System.Boolean CrouchDismountCheck; // 0x10
	System.Boolean IsAddMountYaw; // 0x11
	System.Boolean UseMountRoll; // 0x12
	System.Single damping; // 0x14
	System.Single frequency; // 0x18
	System.Single interpSpeed; // 0x1c
	System.Single springRatio; // 0x20
	System.Int32 Index; // 0x24
	UnityEngine.Vector2Int coordinate; // 0x28
	System.Boolean IsDrive; // 0x30
	UnityEngine.Transform Transform; // 0x38
	WizardGames.Soc.Common.Entity.MountPointPoseType MountPose; // 0x40
	UnityEngine.Vector3 fpOffset; // 0x44
	Soc.Vehicle.SeatStyleType SeatStyleType; // 0x50
	UnityEngine.Vector3 LogicSeatLocalPos; // 0x54
	UnityEngine.Quaternion LogicSeatLocalRot; // 0x60
	System.Collections.Generic.List<System.Int32> DismountPointIndexes; // 0x70
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.MountPointProtectType> ProtectType; // 0x78
	UnityEngine.Collider MountCollider; // 0x80
	System.Collections.Generic.List<System.Single> ProtectTypeThreshold; // 0x88
	System.Void InitSeatLogicInfo(UnityEngine.Transform root); // 0x0614d6a8
	System.Void .ctor(); // 0x0614d79c
}

// Client.Runtime
class Soc.Vehicle.MountPointConfig : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<UnityEngine.Vector2> MountPointsIconOffset; // 0x30
	System.Collections.Generic.List<Soc.Vehicle.MountPointInfo> MountPoints; // 0x38
	System.Collections.Generic.List<UnityEngine.Transform> DismountPoints; // 0x40
	System.Collections.Generic.List<UnityEngine.Transform> InsideDismountPoints; // 0x48
	System.Collections.Generic.List<System.Int32> DriverSeatIndexes; // 0x50
	System.Collections.Generic.List<System.Int32> PassengerSeatIndexes; // 0x58
	System.Collections.Generic.List<System.Int32> AllSeatIndexes; // 0x60
	WizardGames.Soc.Common.Entity.IBaseMountableEntity MountableEntity; // 0x68
	WizardGames.Soc.Common.Unity.Go.BaseMountableGo MountableGo; // 0x70
	static UnityEngine.Collider[] results; // 0x8
	System.Int32 get_DismountPointCount(); // 0x0614d988
	System.Void Init(WizardGames.Soc.Common.Entity.IBaseMountableEntity mountableEntity, WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo); // 0x0614da04
	UnityEngine.Vector3 GetBestPoint(WizardGames.Soc.Common.Unity.Go.IEntityGo playerGo, WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Unity.Go.SeatType seatType); // 0x0614dd6c
	Soc.Vehicle.MountPointInfo GetBestMountPointInfo(WizardGames.Soc.Common.Unity.Go.IEntityGo playerGo, WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Unity.Go.SeatType seatType); // 0x0614de2c
	Soc.Vehicle.MountPointInfo GetNeatestSeat(BasePlayer player, WizardGames.Soc.Common.Unity.Go.SeatType seatType); // 0x0614e9c4
	Soc.Vehicle.MountPointInfo GetSeatViaIndex(System.Int32 seatIndex); // 0x054e7c9c
	Soc.Vehicle.MountPointInfo GetNeatestSeat(UnityEngine.Vector3 eyePos, UnityEngine.Vector3 forwardPos, WizardGames.Soc.Common.Unity.Go.SeatType seatType, System.Int64 ignoreEntityId); // 0x0614e12c
	System.Boolean IsSeatTypeFull(WizardGames.Soc.Common.Unity.Go.SeatType seatType); // 0x0614ed8c
	System.Int32 GetEmptySeatCount(); // 0x0614f018
	System.Int64 GetPlayerIdViaSeatIndex(System.Int32 seatIndex); // 0x0614ed04
	System.Void SetSeatIndexViaPlayerId(System.Int32 seatIndex, System.Int64 value); // 0x0614f0c8
	System.Int32 GetSeatCount(WizardGames.Soc.Common.Unity.Go.SeatType seatType); // 0x0614f150
	Soc.Vehicle.MountPointInfo GetMountPointInfo(System.Int32 index); // 0x0614f210
	UnityEngine.Transform GetDismountPointInfo(System.Int32 index, System.Boolean& isInsideMount); // 0x0614f3c4
	System.Void SetDismountPoints(System.Collections.Generic.List<UnityEngine.Transform> points); // 0x0614f548
	System.Boolean IsSeatHasBeenToked(System.Int32 seatIndex); // 0x0614f5c8
	System.Void TrySetSeatCollider(System.Int32 seatIndex, System.Boolean enable); // 0x0550f700
	static System.Boolean IsSeatCanSitViaPhysicsStatic(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Collider collider, System.Int64 thisEntityId, System.Int32 layerMask, System.Int64 wantsMountPlayer); // 0x0614f784
	static System.Boolean IsSeatCanSitViaPhysicsStatic(UnityEngine.Collider collider, System.Int64 thisEntityId, System.Int32 layerMask, System.Int64 wantsMountPlayer); // 0x0614fd58
	System.Boolean IsSeatCanSitViaPhysics(System.Int32 seatIndex, System.Int64 wantsMountPlayer); // 0x054c5360
	System.Void .ctor(); // 0x061508b8
	static System.Void .cctor(); // 0x061509c0
}

// Client.Runtime
class Soc.Vehicle.Util.SpecializedVehicleUtil : System.Object
{
	
	static System.Boolean GroundSample(UnityEngine.Vector3& position); // 0x06150ad4
}

// Client.Runtime
enum Soc.Vehicle.Util.VehiclePermission : System.Enum
{
	System.Int32 value__; // 0x10
	static Soc.Vehicle.Util.VehiclePermission None = 0;
	static Soc.Vehicle.Util.VehiclePermission InteractiveList = 1;
	static Soc.Vehicle.Util.VehiclePermission Operate = 2;
	
}

// Client.Runtime
class Soc.Vehicle.Util.WheelGroundChecker : System.Object
{
	System.Collections.Generic.Dictionary<System.Int64,UnityEngine.Vector3> ContactedEntities; // 0x10
	UnityEngine.WheelCollider wheelCollider; // 0x18
	System.Boolean isGrounded; // 0x20
	System.Void .ctor(UnityEngine.WheelCollider wheelCollider); // 0x06150dbc
	System.Boolean IsWheelGrounded(WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo mgrGo); // 0x06150e94
	System.Boolean GroundCheck(UnityEngine.WheelHit& hit); // 0x06151328
	System.Void ClearContacted(); // 0x06151728
}

// Client.Runtime
class Soc.Vehicle.Util.VehicleMountableUtil : System.Object
{
	static SocLogger logger; // 0x0
	static UnityEngine.RaycastHit[] hits; // 0x8
	static System.Collections.Generic.HashSet<System.Int32> ForbidWhenModularCarGrabbed; // 0x10
	static System.Single get_playerRadius(); // 0x061517ac
	static System.Boolean IsForbidOnModularCar(WizardGames.Soc.Common.Entity.IEntity entity, System.Int32 interactiveId); // 0x0615188c
	static System.Boolean ValidDismountPosition(System.Int64 playerEntityId, System.Int64 mountEntityId, System.Boolean isStand, UnityEngine.Vector3 disPos, UnityEngine.Vector3 visualCheckOrigin, System.Boolean isInsideMount); // 0x061519f0
	static System.Boolean HitOther(UnityEngine.RaycastHit hit, System.Int64 playerEntityId, System.Int64 mountEntityId); // 0x061523c8
	static System.Boolean GetFirstDismountPoint(System.Collections.Generic.ICollection<UnityEngine.Transform> points, System.Int64 playerEntityId, System.Int64 mountEntityId, System.Boolean isStand, UnityEngine.Vector3 visualCheckOrigin, UnityEngine.Vector3& dismountPoint, System.Boolean& isInsideMount); // 0x061526e8
	static System.Boolean GetBestDismountPointViaPoints(System.Collections.Generic.ICollection<UnityEngine.Transform> points, System.Int64 playerEntityId, System.Int64 mountEntityId, System.Boolean isStand, UnityEngine.Vector3 visualCheckOrigin, UnityEngine.Vector3& dismountPoint, System.Boolean& isInsideMount, System.Collections.Generic.List<System.Boolean> isInsideMountList); // 0x06152b04
	static System.Boolean CanZipline(System.Int32 entityType); // 0x06153068
	static System.Boolean CanMountable(System.Int32 entityType); // 0x061530d0
	static System.Void GetCapsuleColliderPoints(UnityEngine.CharacterController collider, UnityEngine.Vector3& point1, UnityEngine.Vector3& point2); // 0x061502b8
	static System.Void GetCapsuleColliderPoints(UnityEngine.CapsuleCollider capsuleCollider, UnityEngine.Vector3& point1, UnityEngine.Vector3& point2); // 0x0614ffa0
	static Soc.Vehicle.Util.VehiclePermission GetPermission(WizardGames.Soc.Common.Entity.IBaseMountableEntity mountableEntity); // 0x06153170
	static System.Boolean CanMountViaAngle(WizardGames.Soc.Common.Unity.Go.BaseMountableGo go); // 0x06153768
	static Soc.Vehicle.Util.VehiclePermission GetPermission(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.Entity.IBaseMountableEntity mountableEntity); // 0x06153238
	static Rust.Modular.ModularVehicleSocket.SocketLocationType GetSocketLocationType(System.Int32 socketLocation, System.Int32 totalSlotCount, System.Int32 length); // 0x061538f4
	static System.Void .cctor(); // 0x0615398c
}

// Client.Runtime
class Soc.Vehicle.Util.Extension.ColliderExtension : System.Object
{
	
	static System.Boolean IsSameEntityOrSameParent(WizardGames.Soc.Common.Entity.IEntity a, WizardGames.Soc.Common.Entity.IEntity b); // 0x06153ba4
	static WizardGames.Soc.Common.Entity.IEntity GetEntityByIdHolder(UnityEngine.GameObject gameObject); // 0x06153dd0
	static WizardGames.Soc.Common.Unity.Go.IEntityGo GetEntityGo(System.Int64 entityId); // 0x0614cbbc
	static WizardGames.Soc.Common.Unity.Go.IEntityGo GetEntityGoByIdHolder(UnityEngine.GameObject gameObject); // 0x06153f50
	static WizardGames.Soc.Common.Entity.IEntity GetEntity(UnityEngine.Collider collider); // 0x0614fc78
	static WizardGames.Soc.Common.Unity.Go.IEntityGo GetEntityGo(UnityEngine.Collider collider); // 0x0614bccc
	static WizardGames.Soc.Common.Unity.Go.BaseEntityGo GetBaseEntityGo(UnityEngine.Collider collider); // 0x06151678
}

// Client.Runtime
class Soc.Vehicle.Util.Extension.RaycastHitExtension : System.Object
{
	
	static WizardGames.Soc.Common.Entity.IEntity GetEntity(UnityEngine.RaycastHit hit); // 0x06152608
}

// Client.Runtime
struct MMapIntegration.TpClipSettingMetaFileHeader : System.ValueType
{
	System.Int32 recordType; // 0x10
	System.Int32 version; // 0x14
	System.UInt64 memoryGuid; // 0x18
	
}

// Client.Runtime
struct MMapIntegration.TpClipSettingMetaMMap : System.ValueType
{
	MMapIntegration.MmapHashMap<MMapIntegration.TpMetaLocomotionWeightMMap> LocomotionLayerWeightCollection; // 0x10
	MMapIntegration.MmapHashMap<MMapIntegration.TpClipDataMMap> NewClipInfos; // 0x40
	MMapIntegration.MmapHashMap<MMapIntegration.AnimMoveSpeedConfMMap> MoveSpeedConfs; // 0x70
	MMapIntegration.MmapHashMap<MMapIntegration.TpMetaAdditiveWeightMMap> AddLayerWeightCollection; // 0xa0
	MMapIntegration.MmapHashMap<MMapIntegration.TpMetaOverrideWeightMMap> OcLayerWeightCollection; // 0xd0
	MMapIntegration.MmapHashMap<System.Int32> NewTpWpnStringToHash; // 0x100
	MMapIntegration.MmapHashMap<System.UInt64> AudioDict; // 0x130
	MMapIntegration.MmapArray<System.Single> LocomotionLayerStateTimeArray; // 0x160
	MMapIntegration.MmapArray<System.Single> OverrideLayerStateTimeArray; // 0x178
	MMapIntegration.MmapArray<System.Int32> OverrideLayerStateLoopArray; // 0x190
	MMapIntegration.MmapArray<System.UInt32> LocomotionSpecialArray; // 0x1a8
	MMapIntegration.NewPhaseKeyContainerMMap NewPhaseKeyContainer; // 0x1c0
	MMapIntegration.AimIKDataContainerMMap AimIKDataContainer; // 0x1f0
	MMapIntegration.AnimationCurveMMap JumpProj2ForwardInteriaCurve; // 0x220
	MMapIntegration.AnimationCurveMMap JumpProj2RightInteriaCurve; // 0x244
	MMapIntegration.ClientWeaponBindingDataMMap WeaponBindings; // 0x268
	MMapIntegration.ClientClipValueMMap WeaponClipValue; // 0x298
	MMapIntegration.ClientClipValueMMap CharClipValue; // 0x2c8
	MMapIntegration.AnimationCurveMMap TurnInPlaceLeftCurve; // 0x2f8
	MMapIntegration.AnimationCurveMMap TurnInPlaceRightCurve; // 0x31c
	MMapIntegration.AnimationCurveMMap TurnInPlaceCrouchLeftCurve; // 0x340
	MMapIntegration.AnimationCurveMMap TurnInPlaceCrouchRightCurve; // 0x364
	MMapIntegration.AnimationCurveMMap Stand2CrouchCurve; // 0x388
	MMapIntegration.AnimationCurveMMap Stand2CrouchSwapCurve; // 0x3ac
	MMapIntegration.AnimationCurveMMap Crouch2StandCurve; // 0x3d0
	MMapIntegration.AnimationCurveMMap Crouch2StandSwapCurve; // 0x3f4
	System.Int32 JumpInteriaOverride; // 0x418
	System.Single JumpStartInertialTime; // 0x41c
	System.Single JumpKeepInertialTime; // 0x420
	System.Single JumpClearInertialTime; // 0x424
	
}

// Client.Runtime
struct MMapIntegration.TpMetaAdditiveWeightMMap : System.ValueType
{
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> LJogWeightCurve; // 0x10
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> LSprintWeightCurve; // 0x28
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> LJumpWeightCurve; // 0x40
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> LSwimMoveWeightCurve; // 0x58
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> LSwimIdleWeightCurve; // 0x70
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> LIdleCrouchWeightCurve; // 0x88
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> LLadderWeightCurve; // 0xa0
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> AoWeightCurve; // 0xb8
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> AoHorseWeightCurve; // 0xd0
	
}

// Client.Runtime
struct MMapIntegration.PhaseKeyMMap : System.ValueType
{
	
	static System.UInt64 GetKey(CommonUnity.Runtime.Character.PhaseKey pair); // 0x061540cc
}

// Client.Runtime
struct MMapIntegration.Vector3MMap : System.ValueType
{
	System.Single x; // 0x10
	System.Single y; // 0x14
	System.Single z; // 0x18
	
}

// Client.Runtime
struct MMapIntegration.QuaternionMMap : System.ValueType
{
	System.Single x; // 0x10
	System.Single y; // 0x14
	System.Single z; // 0x18
	System.Single w; // 0x1c
	
}

// Client.Runtime
struct MMapIntegration.TpClipDataMMap : System.ValueType
{
	System.Single AnimationTime; // 0x10
	
}

// Client.Runtime
struct MMapIntegration.ClientWeaponBindingDataMMap : System.ValueType
{
	MMapIntegration.MmapHashMap<MMapIntegration.ClientWeaponClipInfoMMap> newBasicWeaponInfos; // 0x10
	
}

// Client.Runtime
struct MMapIntegration.ClientWeaponClipInfoMMap : System.ValueType
{
	System.UInt64 newClipNameHash; // 0x10
	System.Int32 clipHash; // 0x18
	
}

// Client.Runtime
struct MMapIntegration.ClientWeaponClipTRSValueMMap : System.ValueType
{
	MMapIntegration.Vector3MMap pos; // 0x10
	MMapIntegration.QuaternionMMap rot; // 0x1c
	MMapIntegration.Vector3MMap scale; // 0x2c
	
}

// Client.Runtime
struct MMapIntegration.ClientClipValueMMap : System.ValueType
{
	MMapIntegration.MmapHashMap<MMapIntegration.MmapHashMap<MMapIntegration.ClientWeaponClipTRSValueMMap>> ClipValues; // 0x10
	
}

// Client.Runtime
struct MMapIntegration.AnimPhaseDataMMap : System.ValueType
{
	System.Int32 phaseType; // 0x10
	System.Single normalizedTime; // 0x14
	
}

// Client.Runtime
struct MMapIntegration.AnimPhaseMapScriptObjMMap : System.ValueType
{
	MMapIntegration.MmapHashMap<MMapIntegration.PhaseGroupScriptObjMMap> AnimPhaseMap; // 0x10
	
}

// Client.Runtime
struct MMapIntegration.AnimPhaseGroupMMap : System.ValueType
{
	MMapIntegration.MmapArray<MMapIntegration.AnimPhaseDataMMap> Phases; // 0x10
	
}

// Client.Runtime
struct MMapIntegration.PhaseGroupScriptObjMMap : System.ValueType
{
	MMapIntegration.AnimPhaseGroupMMap PhaseGroup; // 0x10
	
}

// Client.Runtime
struct MMapIntegration.NewPhaseKeyContainerMMap : System.ValueType
{
	MMapIntegration.MmapHashMap<MMapIntegration.AnimPhaseMapScriptObjMMap> PhaseScriptMap; // 0x10
	
}

// Client.Runtime
struct MMapIntegration.AimIKDataContainerMMap : System.ValueType
{
	MMapIntegration.MmapHashMap<MMapIntegration.AimIKScriptObjMMap> AimIKDataMapMMap; // 0x10
	
}

// Client.Runtime
struct MMapIntegration.AimIKScriptObjMMap : System.ValueType
{
	MMapIntegration.MmapHashMap<MMapIntegration.AimIKDataMMap> AimIKDataMapMMap; // 0x10
	MMapIntegration.MmapHashMap<System.Int32> AimIKToggleMapMMap; // 0x40
	
}

// Client.Runtime
struct MMapIntegration.AimIKDataMMap : System.ValueType
{
	MMapIntegration.BoneMMap AimBone; // 0x10
	MMapIntegration.MmapArray<MMapIntegration.BoneMMap> SpineBones; // 0x1c
	System.Single weight; // 0x34
	
}

// Client.Runtime
struct MMapIntegration.BoneMMap : System.ValueType
{
	System.UInt64 BoneName; // 0x10
	System.Single weight; // 0x18
	
}

// Client.Runtime
struct MMapIntegration.AnimMoveSpeedConfMMap : System.ValueType
{
	System.Int32 Valid; // 0x10
	System.Single SpeedF; // 0x14
	System.Single SpeedB; // 0x18
	System.Single SpeedLR; // 0x1c
	System.Single LerpSpeed; // 0x20
	System.UInt32 LerpMode; // 0x24
	System.Int32 hasLimitMinFb; // 0x28
	System.Single LimitMinFB; // 0x2c
	System.Int32 hasLimitMaxFb; // 0x30
	System.Single LimitMaxFB; // 0x34
	System.Int32 hasLimitMinLR; // 0x38
	System.Single LimitMinLR; // 0x3c
	System.Int32 hasLimitMaxLR; // 0x40
	System.Single LimitMaxLR; // 0x44
	System.Single InOutLerpSpeed; // 0x48
	System.UInt32 InOutLerpMode; // 0x4c
	System.Int32 EnterMatchRuleId; // 0x50
	System.Int32 ApplyRuleId; // 0x54
	System.UInt32 EdtiorRuleDataType; // 0x58
	System.Int32 ShouldClamp01; // 0x5c
	
}

// Client.Runtime
struct MMapIntegration.AnimCurveKeyMMap : System.ValueType
{
	MMapIntegration.AnimationCurveMMap displayCurve; // 0x10
	System.Int16 index; // 0x34
	
}

// Client.Runtime
struct MMapIntegration.AnimationCurveMMap : System.ValueType
{
	MMapIntegration.MmapArray<MMapIntegration.KeyframeMMap> keys; // 0x10
	System.Int32 length; // 0x28
	System.Int32 preWrapMode; // 0x2c
	System.Int32 postWrapMode; // 0x30
	System.Single Evaluate(System.Single time, System.IntPtr baseptr, MMapIntegration.AnimationCurveMMap* ptr); // 0x06154144
	System.Single EvaluateInternal(System.Single time, System.IntPtr baseptr, MMapIntegration.AnimationCurveMMap* ptr); // 0x06154474
	System.Void FindIndexForSampling(System.Single time, System.IntPtr baseptr, System.Int32& lhs, System.Int32& rhs); // 0x061547f8
	System.Single InterpolateKeyframe(MMapIntegration.KeyframeMMap* lhs, MMapIntegration.KeyframeMMap* rhs, System.Single time); // 0x061549dc
	System.Single HermiteInterpolate(System.Single t, MMapIntegration.KeyframeMMap* lhs, MMapIntegration.KeyframeMMap* rhs); // 0x06154bf0
	System.Single HermiteInterpolate(System.Single t, System.Single p0, System.Single m0, System.Single m1, System.Single p1); // 0x06154cb0
	System.Single BezierInterpolate(System.Single t, MMapIntegration.KeyframeMMap* lhs, MMapIntegration.KeyframeMMap* rhs); // 0x06154ae8
	System.Single BezierInterpolate(System.Single t, System.Single v1, System.Single m1, System.Single w1, System.Single v2, System.Single m2, System.Single w2); // 0x06154dac
	System.Single BezierInterpolate(System.Single t, System.Single p0, System.Single p1, System.Single p2, System.Single p3); // 0x0615517c
	System.Single BezierExtractU(System.Single t, System.Single w1, System.Single w2); // 0x06154ea8
	System.Single Repeat(System.Single t, System.Single begTime, System.Single endTime); // 0x061543b8
	System.Single PingPong(System.Single t, System.Single begTime, System.Single endTime); // 0x0615470c
}

// Client.Runtime
struct MMapIntegration.KeyframeMMap : System.ValueType
{
	System.Single time; // 0x10
	System.Single value; // 0x14
	System.Single inTangent; // 0x18
	System.Single outTangent; // 0x1c
	System.Single inWeight; // 0x20
	System.Single outWeight; // 0x24
	System.Int32 weightedMode; // 0x28
	System.Int32 tangentMode; // 0x2c
	
}

// Client.Runtime
struct MMapIntegration.SkeletonMaskWeightValueMMap : System.ValueType
{
	System.Single Weight; // 0x10
	
}

// Client.Runtime
struct MMapIntegration.TpMetaLocomotionWeightMMap : System.ValueType
{
	MMapIntegration.MmapArray<MMapIntegration.SkeletonMaskWeightValueMMap> WeightListMMap; // 0x10
	
}

// Client.Runtime
class MMapIntegration.TpMetaManager : System.Object, System.IDisposable
{
	static SocLogger Logger; // 0x0
	static System.Boolean LoadFromPath<T,THeader>(System.String mmapPath); // 0x052af1f0
	System.Void Dispose(); // 0x06155270
	static System.Void .cctor(); // 0x061552d0
}

// Client.Runtime
struct MMapIntegration.TpMetaOverrideWeightMMap : System.ValueType
{
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> fastIdleStandWeightCurve; // 0x10
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> fastIdleCrouchWeightCurve; // 0x28
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> fastJogStandWeightCurve; // 0x40
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> fastJogCrouchWeightCurve; // 0x58
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> fastSprintWeightCurve; // 0x70
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> fastJumpWeightCurve; // 0x88
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> fastSwimIdleWeightCurve; // 0xa0
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> fastSwimJogWeightCurve; // 0xb8
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> fastSwimSprintWeightCurve; // 0xd0
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> fastLadderWeightCurve; // 0xe8
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> fastHorseWeightCurve; // 0x100
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> fastVehicleWeightCurve; // 0x118
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> LJogWeightCurve; // 0x130
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> LSprintWeightCurve; // 0x148
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> LJumpWeightCurve; // 0x160
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> LSwimMoveWeightCurve; // 0x178
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> LSwimIdleWeightCurve; // 0x190
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> LIdleCrouchWeightCurve; // 0x1a8
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> LLadderWeightCurve; // 0x1c0
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> AoWeightCurve; // 0x1d8
	MMapIntegration.MmapArray<MMapIntegration.AnimCurveKeyMMap> AoHorseWeightCurve; // 0x1f0
	
}

// Client.Runtime
struct KAnimation.RootMotionWarping.RootMotionWarpJob : System.ValueType
{
	static SocLogger logger; // 0x0
	System.Boolean bValid; // 0x10
	KAnimation.RootMotionWarping.RMWJobVisitCache VisitCache; // 0x18
	UnityEngine.Vector3 FinalRootPosition; // 0xe8
	UnityEngine.Quaternion FinalQuaternion; // 0xf4
	KAnimation.RootMotionWarping.RMWJobRunType JobRunType; // 0x104
	System.Void SetUp(System.Int32 DataIndex, UnityEngine.Matrix4x4 GoalInWorld); // 0x061553a4
	System.Void GetRootFinalPos(); // 0x06155780
	System.Void Initial(KAnimation.RootMotionWarping.RootMotionWarpInitParams& InitParams); // 0x0615582c
	System.Void SampleMotionTrajectory(System.Int32 TargetBoneIndex, System.String TargetBoneName, UnityEngine.Vector3[]& MotionList, UnityEngine.Quaternion[]& QuaterList, KAnimation.RootMotionWarping.RMWBoneSourceType DefaultBoneDataType); // 0x061560d8
	System.Void ProcessAnimationFromSample(UnityEngine.Animations.AnimationStream stream); // 0x061575e4
	System.Void ProcessAnimationWithTime(UnityEngine.Animations.AnimationStream stream, System.Single NextNormalTime, KAnimation.RootMotionWarping.RMWBoneSourceType boneSampleType); // 0x061579a4
	System.Void SampleAnimation(KAnimation.RootMotionWarping.RootMotionWarpSampleParams& Params, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& OutFinalPos, UnityEngine.Quaternion& OutFinalQuat); // 0x0615665c
	static System.Void .cctor(); // 0x06158fd0
}

// Client.Runtime
enum KAnimation.RootMotionWarping.RMWWarpMode : System.Enum
{
	System.Int32 value__; // 0x10
	static KAnimation.RootMotionWarping.RMWWarpMode Default = 0;
	static KAnimation.RootMotionWarping.RMWWarpMode AdjustmentWarp = 1;
	
}

// Client.Runtime
enum KAnimation.RootMotionWarping.RMWJobRunType : System.Enum
{
	System.Int32 value__; // 0x10
	static KAnimation.RootMotionWarping.RMWJobRunType Nothing = 0;
	static KAnimation.RootMotionWarping.RMWJobRunType CalculateAndCleanRM = 1;
	static KAnimation.RootMotionWarping.RMWJobRunType CalculateAndApplyRootBone = 2;
	
}

// Client.Runtime
enum KAnimation.RootMotionWarping.RMWBoneSourceType : System.Enum
{
	System.Int32 value__; // 0x10
	static KAnimation.RootMotionWarping.RMWBoneSourceType FromHandle = 0;
	static KAnimation.RootMotionWarping.RMWBoneSourceType FromBone = 1;
	static KAnimation.RootMotionWarping.RMWBoneSourceType FromSampleCache = 2;
	
}

// Client.Runtime
enum KAnimation.RootMotionWarping.RMWWarpRotationMode : System.Enum
{
	System.Int32 value__; // 0x10
	static KAnimation.RootMotionWarping.RMWWarpRotationMode Default = 0;
	static KAnimation.RootMotionWarping.RMWWarpRotationMode OrientationWarp = 1;
	static KAnimation.RootMotionWarping.RMWWarpRotationMode OrientationWarpAndAim = 2;
	
}

// Client.Runtime
enum KAnimation.RootMotionWarping.RMWWarpOverMode : System.Enum
{
	System.Int32 value__; // 0x10
	static KAnimation.RootMotionWarping.RMWWarpOverMode IgnoreAnimMotion = 0;
	static KAnimation.RootMotionWarping.RMWWarpOverMode ApplyAnimMotion = 1;
	
}

// Client.Runtime
enum KAnimation.RootMotionWarping.RMWIKAlgo : System.Enum
{
	System.Int32 value__; // 0x10
	static KAnimation.RootMotionWarping.RMWIKAlgo None = 0;
	static KAnimation.RootMotionWarping.RMWIKAlgo TwoBoneIK = 1;
	static KAnimation.RootMotionWarping.RMWIKAlgo FullBodyIk = 2;
	
}

// Client.Runtime
class KAnimation.RootMotionWarping.RootMotionWarpingData : UnityEngine.ScriptableObject, UnityEngine.ISerializationCallbackReceiver
{
	System.String RootBone; // 0x18
	UnityEngine.AnimationClip RawClip; // 0x20
	System.Int32 RawClipLength; // 0x28
	System.Int32 AnimSpeed; // 0x2c
	System.String RawAnimatedModelPath; // 0x30
	System.Int32 SampleFrequency; // 0x38
	System.Single AnimHeight; // 0x3c
	UnityEngine.AnimationCurve TpCameraYCurve; // 0x40
	System.Boolean MantleInAir; // 0x48
	System.Int32 SampleCount; // 0x4c
	WizardGames.Soc.Common.Unity.Animation.RootMotionWarpingIndexEnum TypeIndex; // 0x50
	KAnimation.RootMotionWarping.RMWRefBoneInfo[] RefBoneInfos; // 0x58
	KAnimation.RootMotionWarping.RMWRawBoneInfo[] RawBoneInfos; // 0x60
	KAnimation.RootMotionWarping.LogicWarpingPosInfo LogicWarpingPosInfo; // 0x68
	System.Void OnBeforeSerialize(); // 0x06159064
	System.Void OnAfterDeserialize(); // 0x061590c4
	System.Single GetDuration(); // 0x06159124
	System.Single GetDurationBySpeed(); // 0x06159198
	System.Int32 GetDurationIntBySpeed(); // 0x06159224
	System.Single GetPlaySpeed(); // 0x061592a4
	System.Boolean GetRawRotationCurve(System.String BoneName, UnityEngine.AnimationCurve& quatcurvex, UnityEngine.AnimationCurve& quatcurvey, UnityEngine.AnimationCurve& quatcurvez, UnityEngine.AnimationCurve& quatcurvew); // 0x06159318
	System.Boolean GetRawPositionCurve(System.String BoneName, UnityEngine.AnimationCurve& poscurvex, UnityEngine.AnimationCurve& poscurvey, UnityEngine.AnimationCurve& poscurvez); // 0x0615953c
	System.Boolean GetRawScaleCurve(System.String BoneName, UnityEngine.AnimationCurve& scalecurvex, UnityEngine.AnimationCurve& scalecurvey, UnityEngine.AnimationCurve& scalecurvez); // 0x06159720
	System.Void .ctor(); // 0x06159904
}

// Client.Runtime
struct KAnimation.RootMotionWarping.RootMotionWarpInitParams : System.ValueType
{
	UnityEngine.Animator OwnerAnimator; // 0x10
	UnityEngine.Transform RootTransform; // 0x18
	System.Boolean EnableRotation; // 0x20
	KAnimation.Common.UnsafeBoneSkeletonTree SkeletonTree; // 0x28
	KAnimation.RootMotionWarping.RootMotionWarpingData TargetWarpingData; // 0x30
	
}

// Client.Runtime
struct KAnimation.RootMotionWarping.RootMotionWarpSampleParams : System.ValueType
{
	System.Single AnimationSampleTime; // 0x10
	System.Int32 SampleIndex; // 0x14
	KAnimation.RootMotionWarping.RMWBoneSourceType BoneHandleType; // 0x18
	
}

// Client.Runtime
struct KAnimation.RootMotionWarping.RootMotionWarpJobCache : System.ValueType
{
	System.Int32 RawDataIndex; // 0x10
	System.Int32 BonIndex; // 0x14
	UnityEngine.Animations.TransformStreamHandle BoneHandle; // 0x18
	UnityEngine.Matrix4x4[] GoalInBS; // 0x28
	
}

// Client.Runtime
struct KAnimation.RootMotionWarping.RMWJobVisitCache : System.ValueType
{
	System.Single Duration; // 0x10
	System.Single SequencerTime; // 0x14
	System.Int32 GoalInBSMaxCount; // 0x18
	UnityEngine.Matrix4x4 StartRootWorldMatrix; // 0x1c
	UnityEngine.Matrix4x4 StartRootWorld2LocalMatrix; // 0x5c
	KAnimation.RootMotionWarping.RootMotionWarpJobCache[] JobCaches; // 0xa0
	System.Collections.Generic.Dictionary<System.Int32,System.String> AllBones; // 0xa8
	KAnimation.Common.UnsafeBoneSkeletonTree SkeletonTree; // 0xb0
	System.Boolean EnableRotation; // 0xb8
	System.Single AnimSpeed; // 0xbc
	System.Single TimeScale; // 0xc0
	KAnimation.RootMotionWarping.RootMotionWarpingData WarpingData; // 0xc8
	UnityEngine.Vector3 RootMotionPosition; // 0xd0
	
}

// Client.Runtime
struct KAnimation.RootMotionWarping.RMWSpineBoneInfo : System.ValueType
{
	System.String BoneName; // 0x10
	System.Single Weight; // 0x18
	
}

// Client.Runtime
struct KAnimation.RootMotionWarping.RMWRotInfo : System.ValueType
{
	KAnimation.RootMotionWarping.RMWWarpRotationMode RotationMode; // 0x10
	System.Single RotTargetWeight; // 0x14
	UnityEngine.AnimationCurve AnimRotationCurve; // 0x18
	KAnimation.RootMotionWarping.RMWSpineBoneInfo[] SpineBones; // 0x20
	
}

// Client.Runtime
struct KAnimation.RootMotionWarping.RMWIKInfo : System.ValueType
{
	KAnimation.RootMotionWarping.RMWIKAlgo IK; // 0x10
	System.Single IKWeight; // 0x14
	System.String[] TwoBoneIkNames; // 0x18
	System.String TwoBoneIkEffectBone; // 0x20
	KAnimation.RootMotionWarping.RMWFullBodyIKInfo FullBodyIKInfo; // 0x28
	
}

// Client.Runtime
struct KAnimation.RootMotionWarping.RMWFullBodyIKInfo : System.ValueType
{
	
	
}

// Client.Runtime
struct KAnimation.RootMotionWarping.RMWRefBoneInfo : System.ValueType
{
	static System.Int32 WarpingXIndex; // 0x0
	static System.Int32 WarpingYIndex; // 0x4
	static System.Int32 WarpingZIndex; // 0x8
	System.String BoneName; // 0x10
	System.Int32 BoneIndex; // 0x18
	KAnimation.RootMotionWarping.RMWWarpMode WarpMode; // 0x1c
	System.Single Start; // 0x20
	System.Single End; // 0x24
	System.Int32 StartTimeIndex; // 0x28
	System.Int32 EndTimeIndex; // 0x2c
	UnityEngine.Vector3 ConstOffset; // 0x30
	System.Int32 EffectIndex; // 0x3c
	System.Single EffectWeight; // 0x40
	KAnimation.RootMotionWarping.RMWWarpOverMode WarpOverMode; // 0x44
	System.Boolean bFixTarget; // 0x48
	UnityEngine.AnimationCurve[] AnimWarpCurves; // 0x50
	UnityEngine.AnimationCurve[] NonNormalWarpCurves; // 0x58
	KAnimation.RootMotionWarping.RMWRotInfo Rotation; // 0x60
	KAnimation.RootMotionWarping.RMWIKInfo[] IKList; // 0x78
	static System.Void .cctor(); // 0x061599b8
}

// Client.Runtime
struct KAnimation.RootMotionWarping.RMWRawBoneMatrixInBSInfo : System.ValueType
{
	System.Single Time; // 0x10
	UnityEngine.Matrix4x4 BoneMatrix; // 0x14
	UnityEngine.Vector3 CsPosition; // 0x54
	UnityEngine.Vector3 CSRotation; // 0x60
	
}

// Client.Runtime
struct KAnimation.RootMotionWarping.RMWRawBoneInfo : System.ValueType
{
	static System.Int32 QuatX; // 0x0
	static System.Int32 QuatY; // 0x4
	static System.Int32 QuatZ; // 0x8
	static System.Int32 QuatW; // 0xc
	static System.Int32 PosX; // 0x10
	static System.Int32 PosY; // 0x14
	static System.Int32 PosZ; // 0x18
	static System.Int32 ScaleX; // 0x1c
	static System.Int32 ScaleY; // 0x20
	static System.Int32 ScaleZ; // 0x24
	System.String BoneName; // 0x10
	System.Int32 BoneIndex; // 0x18
	UnityEngine.Matrix4x4 StartLocalMatrix; // 0x1c
	UnityEngine.Vector3 StartLocalPosition; // 0x5c
	UnityEngine.Vector3 StartLocalRotation; // 0x68
	UnityEngine.Vector3 FinalPosition; // 0x74
	UnityEngine.AnimationCurve[] BoneCurves; // 0x80
	KAnimation.RootMotionWarping.RMWRawBoneMatrixInBSInfo[] BoneMatrixInCS; // 0x88
	static System.Void .cctor(); // 0x06159a10
}

// Client.Runtime
struct KAnimation.RootMotionWarping.LogicWarpingPosInfo : System.ValueType
{
	UnityEngine.AnimationCurve PosY; // 0x10
	UnityEngine.AnimationCurve PosZ; // 0x18
	
}

// Client.Runtime
class KAnimation.RootMotionWarping.RootMotionWarpJobUtils : System.Object
{
	
	static System.Void Initial(KAnimation.RootMotionWarping.RootMotionWarpJob& Job, KAnimation.RootMotionWarping.RootMotionWarpInitParams& InitParams); // 0x061558a8
	static System.Void SetUp(KAnimation.RootMotionWarping.RootMotionWarpJob& Job, System.Int32 DataIndex, UnityEngine.Matrix4x4& GoalInWorld); // 0x0615544c
	static System.Int32 GetGoalIndex(KAnimation.RootMotionWarping.RMWRefBoneInfo& RefData); // 0x0615a408
	static System.Int32 GetControlSection(KAnimation.RootMotionWarping.RMWJobVisitCache& VisitCache, System.Int32 CurRefIndex, System.Single AnimationSampleTime); // 0x0615a470
	static System.Boolean CalculateSection(KAnimation.RootMotionWarping.RMWJobVisitCache& VisitCache, System.Int32 CurRefIndex, System.Single PercentInSection, KAnimation.RootMotionWarping.RMWRefBoneInfo& CurSection_RefData, KAnimation.RootMotionWarping.RootMotionWarpJobCache& CurSection_RefCache, KAnimation.RootMotionWarping.RMWRawBoneInfo& CurSection_RefRawData, KAnimation.RootMotionWarping.RootMotionWarpJobCache& RootCache, KAnimation.RootMotionWarping.RMWRawBoneInfo& RootRawData, UnityEngine.Vector3& OutRefBonePos, UnityEngine.Quaternion& OutRefBoneRotation); // 0x06158288
	static System.Void CalculatePreSectionInEnd(KAnimation.RootMotionWarping.RMWJobVisitCache& VisitCache, System.Int32 CurRefIndex, KAnimation.RootMotionWarping.RMWRefBoneInfo& PreSection_RefData, KAnimation.RootMotionWarping.RootMotionWarpJobCache& PreSection_RefCache, KAnimation.RootMotionWarping.RMWRawBoneInfo& PreSection_RefRawData, KAnimation.RootMotionWarping.RMWRefBoneInfo& CurSection_RefData, KAnimation.RootMotionWarping.RootMotionWarpJobCache& CurSection_RefCache, KAnimation.RootMotionWarping.RMWRawBoneInfo& CurSection_RefRawData, KAnimation.RootMotionWarping.RootMotionWarpJobCache& RootCache, KAnimation.RootMotionWarping.RMWRawBoneInfo& RootRawData, UnityEngine.Vector3& OutGoalPositionInBS, UnityEngine.Vector3& OutConstOffset, UnityEngine.Quaternion& outGoalQuaternionInBS, UnityEngine.Quaternion& OutQuatConstOffset); // 0x0615a87c
	static System.Void CalculateOffset(KAnimation.RootMotionWarping.RMWJobVisitCache& VisitCache, System.Int32 RefIndex, KAnimation.RootMotionWarping.RMWRefBoneInfo& CurSection_RefData, KAnimation.RootMotionWarping.RMWRawBoneInfo& CurSection_RefRawData, KAnimation.RootMotionWarping.RMWRawBoneInfo& RootRawData, UnityEngine.Vector3& OutOffset, UnityEngine.Quaternion& OutOffsetQuat); // 0x0615a578
	static System.Void CalculateRelative(KAnimation.RootMotionWarping.RMWRawBoneInfo& RootRawData, KAnimation.RootMotionWarping.RMWRawBoneInfo& CurSection_RefRawData, System.Int32 TargetIndex, UnityEngine.Vector3& OutRelativePosition, UnityEngine.Quaternion& OutRelativeQuaternion); // 0x06157414
	static System.Void CalculateRelative(KAnimation.RootMotionWarping.RootMotionWarpJobCache& RootCache, KAnimation.RootMotionWarping.RMWRawBoneInfo& RootRawData, KAnimation.RootMotionWarping.RootMotionWarpJobCache& CurSection_RefCache, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& OutRelativePosition, UnityEngine.Quaternion& CurSection_RelativeQuaternion); // 0x06157d4c
	static System.Void CalculateRelative(KAnimation.RootMotionWarping.RMWRawBoneInfo& RootRawData, System.Int32 TargetBoneIndex, KAnimation.Common.UnsafeBoneSkeletonTree& SkeletonTree, UnityEngine.Vector3& OutRelativePosition, UnityEngine.Quaternion& OutRelativeQuaternion); // 0x061580ac
}

// Client.Runtime
class KAnimation.RootMotionWarping.RootMotionWarpUtils : System.Object
{
	static SocLogger logger; // 0x0
	static System.Boolean isContinuous(System.Collections.Generic.List<System.Int32> TargetList); // 0x0615aea4
	static System.Boolean GetValidMsg(KAnimation.RootMotionWarping.RootMotionWarpingData WarpingData, System.Collections.Generic.List<System.String> MsgList); // 0x06159a74
	static System.Void .cctor(); // 0x0615aff8
}

// Client.Runtime
class KAnimation.Common.UnsafeBoneSkeletonTree : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.List<UnityEngine.Transform> TempTransList; // 0x8
	System.Int32 RootInstId; // 0x10
	Unity.Collections.LowLevel.Unsafe.UnsafeList<KAnimation.Common.BoneSkeletonTreeNode> _BoneNodes; // 0x18
	Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32> _BoneName2IndexMap; // 0x30
	Unity.Collections.LowLevel.Unsafe.UnsafeList<System.Int32> _AllTransInstIdCache; // 0x40
	System.Boolean IsValid(); // 0x062c962c
	System.Void Build(UnityEngine.Transform Bone, UnityEngine.Transform RootBone); // 0x062c96b4
	System.Void BuildBone(UnityEngine.Transform Bone, System.Int32& NodeIndex, System.Int32& ValidBoneIndex, System.Int32 NodeParentIndex); // 0x062c9a10
	System.Void Dispose(); // 0x062c9bac
	System.Int32 GetBoneIndexFromName(System.String boneName); // 0x062c9cac
	UnityEngine.Transform GetBone(System.Int32 boneIndex); // 0x062c9d8c
	UnityEngine.Transform GetBone(System.String boneName); // 0x062c9ea0
	System.Int32 GetTransformId(System.Int32 boneIndex); // 0x062c9f44
	System.Int32 GetTransformId(System.String boneName); // 0x062c9fcc
	static System.Boolean GetStreamHandle(System.Int32 inAnimId, System.String BonePath, UnityEngine.Animations.TransformStreamHandle& handle); // 0x062ca070
	System.Void .ctor(); // 0x062ca1fc
	static System.Void .cctor(); // 0x062ca264
}

// Client.Runtime
struct KAnimation.Common.TransformHandleNode : System.ValueType
{
	System.Boolean Valid; // 0x10
	System.Int32 NameHash; // 0x14
	System.Int32 FullNameHash; // 0x18
	UnityEngine.Animations.TransformStreamHandle StreamHandle; // 0x1c
	System.Void .ctor(System.String inName, System.String inFullPath); // 0x062ca350
}

// Client.Runtime
struct KAnimation.Common.BoneSkeletonTreeNode : System.ValueType
{
	System.Int32 BoneIndex; // 0x10
	System.Int32 ParentIndex; // 0x14
	
}

// Client.Runtime
class Src.Combat.HeldItem.HeldItemRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	WizardGames.Soc.Common.Entity.PlayerEntity PlayerEntity; // 0x20
	WizardGames.Soc.Common.Entity.IHeldItemEntity IHeldItemEntity; // 0x28
	WizardGames.Soc.Common.Entity.IEntity TargetEntity; // 0x30
	System.Void Dispose(); // 0x062ca40c
	System.Void .ctor(); // 0x062ca4a4
}

// Client.Runtime
interface Src.Animation.ISocAnimWarpingData : 
{
	
	
}

// Client.Runtime
class Combat.CombatConfig : System.Object
{
	static System.Int32 GameViewMode; // 0x0
	static System.Boolean MOVEDBG; // 0x4
	static System.Boolean HorseMOVEDBG; // 0x5
	static System.Boolean AirMantleToggle; // 0x6
	static System.Boolean AlwaysRollback; // 0x7
	static System.Boolean SimulateTrustClient; // 0x8
	static System.Boolean SimulateHorseTrustClient; // 0x9
	static System.Boolean ClientAnimatorDebug; // 0xa
	static System.Boolean transitFromSnapshotPose; // 0xb
	static System.Boolean FptransitFromSnapshotPose; // 0xc
	static System.Boolean EnableNewLoader; // 0xd
	static System.Boolean Smooth; // 0xe
	static System.Boolean SyncGroupDisable; // 0xf
	static System.Int32 ForceURO; // 0x10
	static System.Boolean EnablePlayerStateMachineURO; // 0x14
	static System.Boolean EnableMonsterStateMachineURO; // 0x15
	static System.Boolean ViewkickToggle; // 0x16
	static System.Boolean GunkickToggle; // 0x17
	static System.Boolean SwayToggle; // 0x18
	static System.Boolean BreatheToggle; // 0x19
	static System.Boolean UseDoubleMatrix; // 0x1a
	static System.Boolean ProjectilePierce; // 0x1b
	static System.Boolean IgnoreConditionLose; // 0x1c
	static System.Boolean GoAsyncLoad; // 0x1d
	static System.Boolean UseRootShiftSkinning; // 0x1e
	static System.Boolean AnimatorCntPrint; // 0x1f
	static System.Boolean AutoDiveDbg; // 0x20
	static System.Boolean PlayerUseItemDbg; // 0x21
	static System.Boolean JumpLandTolerantDbg; // 0x22
	static System.Boolean ViewKickDbg; // 0x23
	static System.Boolean AnimSpeedDbg; // 0x24
	static System.Boolean LadderDbg; // 0x25
	static System.Boolean EnablePlayerOC; // 0x26
	static System.Boolean IsForcePoseState; // 0x27
	static System.Int32 ForcePoseStateValue; // 0x28
	static System.Boolean EnableRollBack; // 0x2c
	static System.Boolean JumpPoseDbg; // 0x2d
	static System.Boolean MantleDbg; // 0x2e
	static System.Boolean ParachuteLog; // 0x2f
	static System.Boolean ADSShowTp; // 0x30
	static System.Boolean CharacterCollisionLog; // 0x31
	static System.Boolean UseFovRate; // 0x32
	static System.Boolean PCInputSmooth; // 0x33
	static System.Boolean FireWithLogic60Fps; // 0x34
	static System.Boolean EnableNewFootStepSystem; // 0x35
	static System.Int32 FootstepSystemLogLevel; // 0x38
	static System.Boolean ForceDisableProcessRootMotion; // 0x3c
	static System.Boolean ReadIKCurveFromMeta; // 0x3d
	static System.Boolean IkMetaDebugLog; // 0x3e
	static LandPoseSelectRule LandPoseSelectRule; // 0x40
	static System.Collections.Generic.List<WizardGames.Soc.Common.Entity.PlayerMoveStateEnum> ExceptStates; // 0x48
	static System.Boolean GMMassiveMeleeAttackMostHarmful; // 0x50
	static System.Boolean UseScaledIK; // 0x51
	static System.Boolean bOffline; // 0x52
	static System.Boolean TelescopeUsing; // 0x53
	static System.Boolean GGJCardUseFromBag; // 0x54
	static System.Boolean LadderBottomUIOn; // 0x55
	static System.Boolean DisablePlayerAnimatorRootMotionStep; // 0x56
	static System.Boolean DisableMonsterAnimatorRootMotionStep; // 0x57
	static System.Boolean DisableWeaponAnimatorRootMotionStep; // 0x58
	static System.Boolean IsMoveDebug(WizardGames.Soc.Common.Entity.PlayerEntity p); // 0x062ca50c
	static System.Boolean IsHorseMoveDebug(WizardGames.Soc.Common.Entity.HorseEntity h); // 0x062ca604
	static System.Void .cctor(); // 0x062ca694
}

// Client.Runtime
class Combat.Shoot.Formula.MgrGunkickFormula : System.Object
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,Combat.Shoot.Formula.SOCGunkickFormula> Formulas; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,Combat.Shoot.Formula.Gunkick.GunkickFormulaData> GunKickFormulaDatas; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.Dictionary<System.Int64,System.Int32>> GunPartMappingGkType; // 0x20
	WizardGames.Soc.Common.Contexts.Context _context; // 0x28
	System.Void .ctor(WizardGames.Soc.Common.Contexts.Context context); // 0x062ca7b0
	System.Void Clear(); // 0x062cab08
	System.Void InitData(); // 0x062caa50
	System.Void InitGunkickMappingData(); // 0x062cb0e8
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetPartsViaGunId(System.Int64 gunid); // 0x062cb4ec
	System.Int32 GetGktypeViaGunIdAndPartId(System.Int64 gunid, System.Int64 partid); // 0x062cb60c
	System.Void InitGunkickConfigData(); // 0x062cad70
	Combat.Shoot.Formula.Gunkick.GunkickFormulaData GetViewKickDataStructViaType(System.Int32 gkType); // 0x062cb6d4
	System.Boolean GetFormulaViaPlayerEntity(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, Combat.Shoot.Formula.SOCGunkickFormula& formula); // 0x062cba60
	Combat.Shoot.Formula.SOCGunkickFormula GetFormulaViaId(System.Int64 id); // 0x062cbb68
	System.Void RemoveGunkickFormula(System.Int64 id); // 0x062ccde0
	Combat.Shoot.Formula.SOCGunkickFormula CreateGunkickFormulaViaWeapon(System.Int64 entityId); // 0x062cbc90
	UnityEngine.Vector3 GetLocalPosInTran(UnityEngine.Transform frontSight, UnityEngine.Transform targetTransform); // 0x062cd198
	System.Void SetCenter(Combat.Shoot.Formula.Gunkick.GunkickAxisDatas datas, UnityEngine.Vector3 sightPos, UnityEngine.Vector3 frontSightPos); // 0x062cd4c0
	System.Void SetGunkickData(Combat.Shoot.Formula.GunkickAxisGroup formulaGroup, Combat.Shoot.Formula.Gunkick.GunkickAxisDatas axisData, Combat.Shoot.Formula.GunkickAxisType axisType); // 0x062cd760
	Combat.Shoot.Formula.Gunkick.GunkickFormulaData GetGunkickFormulaData(System.Int64 tableId, System.Int64 telescopeId); // 0x062ccf44
	System.Void UpdateGunkickFormula(System.Int64 id); // 0x062cdbf4
	static System.Void .cctor(); // 0x062cdd1c
}

// Client.Runtime
enum Combat.Shoot.Formula.GunkickAxisType : System.Enum
{
	System.Int32 value__; // 0x10
	static Combat.Shoot.Formula.GunkickAxisType Pitch = 0;
	static Combat.Shoot.Formula.GunkickAxisType Yaw = 1;
	static Combat.Shoot.Formula.GunkickAxisType Roll = 2;
	
}

// Client.Runtime
class Combat.Shoot.Formula.GunkickAxis : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	UnityEngine.Vector3 OriginPosition; // 0x10
	UnityEngine.Vector3 OriginPosOffset; // 0x1c
	Combat.Shoot.Formula.GunkickAxisType AxisType; // 0x28
	WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormula springFormula; // 0x30
	System.Boolean IsSightLocator; // 0x38
	UnityEngine.Matrix4x4 anchorLocalMat; // 0x3c
	static Combat.Shoot.Formula.GunkickAxis GetGunkickAxis(WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormula formula, UnityEngine.Vector3 axisPosition, Combat.Shoot.Formula.GunkickAxisType axisType, System.Boolean isSightLocator); // 0x062cd9e8
	static System.Void Release(Combat.Shoot.Formula.GunkickAxis f); // 0x062cded4
	System.Void Init(WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormula formula, UnityEngine.Vector3 axisPosition, Combat.Shoot.Formula.GunkickAxisType axisType, System.Boolean isSightLocator); // 0x062cddf0
	System.Void Start(System.Int32 during, System.Int32 seed); // 0x062cdf84
	System.Void InitMat(UnityEngine.Matrix4x4 gunLocalMat); // 0x062ce018
	System.Void SetOffset(UnityEngine.Vector3 offset); // 0x062ce174
	System.Void Update(System.Int32 during, System.Single deltaTime, UnityEngine.Matrix4x4 local2World, UnityEngine.Matrix4x4 gunLocalMat, UnityEngine.Matrix4x4& transformMat, UnityEngine.Matrix4x4& inOutTransform); // 0x062ce22c
	System.Void OnGet(); // 0x062ce930
	System.Void OnRelease(); // 0x062ce990
	System.Void OnDestroy(); // 0x062ceaa0
	System.Void .ctor(); // 0x062ceb00
}

// Client.Runtime
class Combat.Shoot.Formula.GunkickAxisGroup : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.Collections.Generic.List<Combat.Shoot.Formula.GunkickAxis> _axisList; // 0x10
	static Combat.Shoot.Formula.GunkickAxisGroup GetGunkickAxisGroup(); // 0x062ceb68
	static System.Void Release(Combat.Shoot.Formula.GunkickAxisGroup f); // 0x062cebfc
	System.Void AddAxis(Combat.Shoot.Formula.GunkickAxis axis); // 0x062cdb00
	System.Void Start(System.Int32 during, System.Int32 seed); // 0x062cecac
	System.Void Update(System.Int32 during, System.Single deltaTime, UnityEngine.Matrix4x4 local2World, UnityEngine.Matrix4x4 gunLocalMat, UnityEngine.Matrix4x4& transformMat, UnityEngine.Matrix4x4& inOutTransform); // 0x062cee3c
	System.Void InitMat(UnityEngine.Matrix4x4 gunLocalMat); // 0x062cf104
	System.Void OnRelease(); // 0x062cf29c
	System.Void OnGet(); // 0x062cf434
	System.Void OnDestroy(); // 0x062cf494
	System.Void .ctor(); // 0x062cf4f4
}

// Client.Runtime
class Combat.Shoot.Formula.SOCGunkickFormula : WizardGames.Soc.Common.Combat.Shoot.IKickFormula, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	Combat.Shoot.Formula.GunkickAxisGroup Roll; // 0x10
	Combat.Shoot.Formula.GunkickAxisGroup Pitch; // 0x18
	Combat.Shoot.Formula.GunkickAxisGroup Yaw; // 0x20
	System.Int32 CurrentFireTime; // 0x28
	UnityEngine.Matrix4x4 GunLocalMat; // 0x2c
	UnityEngine.Matrix4x4 SightLocalMat; // 0x6c
	UnityEngine.Matrix4x4 EyeGunMeshMat; // 0xac
	UnityEngine.Matrix4x4 SightGunMeshMat; // 0xec
	UnityEngine.Vector3 SightPos; // 0x12c
	UnityEngine.Vector3 EyePos; // 0x138
	System.Single <GunFovOffset>k__BackingField; // 0x144
	static Combat.Shoot.Formula.SOCGunkickFormula GetFormular(); // 0x062cd42c
	static System.Void Release(Combat.Shoot.Formula.SOCGunkickFormula f); // 0x062cce94
	System.Void set_GunFovOffset(System.Single value); // 0x062cf5a8
	System.Void Start(System.Int32 time, System.Int32 seed); // 0x062cf620
	System.Void Update(System.Int32 during, System.Single deltaTime, UnityEngine.Matrix4x4 local2World, UnityEngine.Matrix4x4 gunLocalMat, UnityEngine.Matrix4x4& transformMat, UnityEngine.Matrix4x4& inOutTransform); // 0x062cf6f0
	System.Void InitMat(UnityEngine.Matrix4x4 gunLocalMat); // 0x062cf8e4
	System.Void OnGet(); // 0x062cf9c8
	System.Void OnRelease(); // 0x062cfa60
	System.Void OnDestroy(); // 0x062cfc1c
	System.Void .ctor(); // 0x062cfc7c
}

// Client.Runtime
class Combat.Shoot.Formula.GunkickSpringFormula : WizardGames.Soc.Common.Combat.Shoot.Formula.InheritSpringFormula
{
	System.Single lastValue; // 0x48
	System.Single deltaTime; // 0x4c
	System.Void SetDeltaTime(System.Single deltaTime); // 0x062cfd04
	System.Single GetValue_Internal(System.Single during); // 0x062cfd7c
	System.Single GetValue(System.Single during); // 0x062cfe30
	System.Void .ctor(); // 0x062cd974
}

// Client.Runtime
class Combat.Shoot.Formula.Gunkick.GunkickFormulaData : System.Object
{
	Combat.Shoot.Formula.Gunkick.GunkickAxisDatas Pitch; // 0x10
	Combat.Shoot.Formula.Gunkick.GunkickAxisDatas Yaw; // 0x18
	Combat.Shoot.Formula.Gunkick.GunkickAxisDatas Roll; // 0x20
	System.Void Handle(WizardGames.Soc.Common.Data.gun.GunGunkick gg); // 0x062cb7dc
	System.Void SortOut(); // 0x062cb900
	System.Void .ctor(); // 0x062cb984
}

// Client.Runtime
class Combat.Shoot.Formula.Gunkick.GunkickAxisDatas : System.Object
{
	System.Collections.Generic.List<Combat.Shoot.Formula.Gunkick.GunkickAxisData> _datas; // 0x10
	Combat.Shoot.Formula.Gunkick.GunkickAxisData[] <Datas>k__BackingField; // 0x18
	Combat.Shoot.Formula.Gunkick.GunkickAxisData[] get_Datas(); // 0x062d0308
	System.Void set_Datas(Combat.Shoot.Formula.Gunkick.GunkickAxisData[] value); // 0x062d036c
	System.Void Handle(WizardGames.Soc.Common.Data.gun.GunGunkick gg); // 0x062cffa0
	System.Void SortOut(); // 0x062d00c8
	System.Void .ctor(); // 0x062d0254
}

// Client.Runtime
class Combat.Shoot.Formula.Gunkick.GunkickAxisData : System.Object
{
	WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormulaData _data; // 0x10
	WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormulaData get_SpringFormulaData(); // 0x062d0600
	System.Void Handle(WizardGames.Soc.Common.Data.gun.GunGunkick gg); // 0x062d0454
	System.Void SortOut(); // 0x062d05a0
	System.Void .ctor(); // 0x062d03ec
}

// Client.Runtime
class CommonUnity.Runtime.Utility.IntPtrExt : System.Object
{
	
	static System.Boolean IsValid(System.IntPtr& ptr); // 0x062d0664
}

// Client.Runtime
class CommonUnity.Runtime.Replay.LongDoublePointerQueue : System.Object
{
	System.Int64[] _items; // 0x10
	System.Int32 _head; // 0x18
	System.Int32 _tail; // 0x1c
	System.Int32 _count; // 0x20
	System.Int32 _capacity; // 0x24
	static SocLogger logger; // 0x0
	System.Int32 get_Count(); // 0x062d06d8
	System.Int64 get_Item(System.Int32 index); // 0x062d073c
	System.Void .ctor(System.Int32 initialCapacity); // 0x062d08b0
	System.Void Enqueue(System.Int64 item); // 0x062d097c
	System.Int64 Dequeue(); // 0x062d0b5c
	System.Void Clear(); // 0x062d0c88
	System.Boolean Contains(System.Int64 item); // 0x062d0d08
	System.ValueTuple<System.Int64,System.Int64> FindPreAfter(System.Int64 target); // 0x062d0dbc
	System.Void Resize(System.Int32 newCapacity); // 0x062d0a48
	static System.Void .cctor(); // 0x062d0fdc
}

// Client.Runtime
struct CommonUnity.Runtime.Replay.ReplayPosAndRot : System.ValueType
{
	UnityEngine.Vector3 Pos; // 0x10
	UnityEngine.Vector3 Rot; // 0x1c
	UnityEngine.Vector3 LocalPos; // 0x28
	UnityEngine.Quaternion LocalRot; // 0x34
	System.String ToString(); // 0x062d10b0
}

// Client.Runtime
class CommonUnity.Runtime.Replay.ReplaySyncTransformUtil : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void AddHistoryEntityData(Go.GoComp.SmoothComp smoothComp, System.Int64 serverTime, UnityEngine.Vector3 pos, UnityEngine.Vector3 rot, UnityEngine.Vector3 localPos, UnityEngine.Quaternion localRot); // 0x062d12f4
	static CommonUnity.Runtime.Replay.ReplayPosAndRot GetHistoryEntityPosAndRot(System.Collections.Generic.Dictionary<System.Int64,CommonUnity.Runtime.Replay.ReplayPosAndRot> historyServerTime2PosAndRot, System.Int64 serverTime); // 0x062d1638
	static System.Void ApplyReplayPosAndRot(Go.GoComp.SmoothComp smoothComp, CommonUnity.Runtime.Replay.ReplayPosAndRot data, System.Boolean isLast); // 0x062d16d8
	static System.Single SetNeighbourPosAndRot(Go.GoComp.SmoothComp smoothComp, System.Int64& lastRenderTime, System.Int64 renderTime); // 0x062d187c
	static System.Void .cctor(); // 0x062d1b88
}

// Client.Runtime
interface CommonUnity.Runtime.Entity.ISeekerTarget : , WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity
{
	
	System.Int64 get_TableID(); // 0x054a4380
	System.Boolean IsValid(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x054dec74
	System.Boolean get_CanBeShot(); // 0x054c4760
	UnityEngine.Vector3 get_SeekingPos(); // 0x054b1148
	UnityEngine.Vector3 GetSeekingPosSmooth(System.Int64 renderTime); // 0x062d1c5c
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Boolean> get_TargeterInfos(); // 0x054e7844
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int64> get_SeekerIds(); // 0x054e7844
}

// Client.Runtime
class CommonUnity.Runtime.Construction.Misc.MultiDeployVolumeOBB : WizardGames.Soc.Common.Unity.Construction.DeployVolumeOBB
{
	
	System.Void .ctor(); // 0x062d1eb0
}

// Client.Runtime
class CommonUnity.Runtime.Construction.Misc.ConstructionOutline : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.GpuInstance.GpuInstObject gpuInstObj; // 0x30
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer gpuInstContainer; // 0x38
	UnityEngine.MeshRenderer[] MeshRenderers; // 0x40
	System.Boolean EnableOutLine; // 0x48
	System.String OutLineCol; // 0x50
	System.Single boldness; // 0x58
	System.Single opacity; // 0x5c
	Systems.EdgesType edgesType; // 0x60
	WizardGames.Soc.Common.Construction.PartType testType; // 0x64
	UnityEngine.LayerMask obstacletestLayer; // 0x68
	System.Single obstacleCheckRadius; // 0x6c
	static System.Int32 Current; // 0x8
	System.Void Start(); // 0x062d1f18
	System.Void OnDestroy(); // 0x062d215c
	System.Void EnableEffect(); // 0x062d2404
	System.Void DisableEffect(); // 0x062d2240
	System.Void .ctor(); // 0x062d2598
	static System.Void .cctor(); // 0x062d2648
}

// Client.Runtime
struct CommonUnity.Runtime.Character.Bone : System.ValueType
{
	System.String BoneName; // 0x10
	System.Single Weight; // 0x18
	
}

// Client.Runtime
struct CommonUnity.Runtime.Character.AimIKData : System.ValueType
{
	CommonUnity.Runtime.Character.Bone AimBone; // 0x10
	System.Collections.Generic.List<CommonUnity.Runtime.Character.Bone> SpineBones; // 0x20
	System.Single weight; // 0x28
	
}

// Client.Runtime
class CommonUnity.Runtime.Character.AimIKScriptObj : UnityEngine.ScriptableObject
{
	SerializableDictionary<CommonUnity.Runtime.Character.PhaseKey,CommonUnity.Runtime.Character.AimIKData> AimIKDataMap; // 0x18
	SerializableDictionary<CommonUnity.Runtime.Character.PhaseKey,System.Boolean> AimIKToggleMap; // 0x20
	System.Void .ctor(); // 0x062d271c
}

// Client.Runtime
class CommonUnity.Runtime.Character.AimIKDataContainer : System.Object
{
	SerializableDictionary<CommonUnity.Runtime.Character.NewPhaseKey,CommonUnity.Runtime.Character.AimIKScriptObj> AimIKDataMap; // 0x10
	System.Void .ctor(); // 0x062d2828
}

// Client.Runtime
class CommonUnity.Runtime.Character.AnimPhaseConst : System.Object
{
	static SocLogger logger; // 0x0
	static System.Boolean Dbg; // 0x8
	static System.Void .cctor(); // 0x062d28dc
}

// Client.Runtime
enum CommonUnity.Runtime.Character.AnimPhaseType : System.Enum
{
	System.Int32 value__; // 0x10
	static CommonUnity.Runtime.Character.AnimPhaseType None = 0;
	static CommonUnity.Runtime.Character.AnimPhaseType LeftFoot = 1;
	static CommonUnity.Runtime.Character.AnimPhaseType RightFoot = 2;
	
}

// Client.Runtime
struct CommonUnity.Runtime.Character.AnimPhaseData : System.ValueType
{
	CommonUnity.Runtime.Character.AnimPhaseType PhaseType; // 0x10
	System.Single normalizedTime; // 0x14
	
}

// Client.Runtime
struct CommonUnity.Runtime.Character.AnimPhaseMatchKey : System.ValueType
{
	System.Boolean valid; // 0x10
	CommonUnity.Runtime.Character.AnimPhaseType PrePhaseType; // 0x14
	CommonUnity.Runtime.Character.AnimPhaseType NextPhaseType; // 0x18
	System.Single normalizedTimeOffset; // 0x1c
	System.String ToString(); // 0x062d2980
}

// Client.Runtime
class CommonUnity.Runtime.Character.AnimPhaseGroup : System.Object
{
	System.Collections.Generic.List<CommonUnity.Runtime.Character.AnimPhaseData> Phases; // 0x10
	System.Void .ctor(); // 0x062d2bc0
}

// Client.Runtime
enum CommonUnity.Runtime.Character.ECommonRes : System.Enum
{
	System.Int32 value__; // 0x10
	static CommonUnity.Runtime.Character.ECommonRes DefaultCommonRes = 0;
	static CommonUnity.Runtime.Character.ECommonRes Attack = 1;
	static CommonUnity.Runtime.Character.ECommonRes CommonAdditive = 2;
	static CommonUnity.Runtime.Character.ECommonRes CommonOverride = 3;
	static CommonUnity.Runtime.Character.ECommonRes Dead = 4;
	static CommonUnity.Runtime.Character.ECommonRes Horse = 5;
	static CommonUnity.Runtime.Character.ECommonRes Ladder = 6;
	static CommonUnity.Runtime.Character.ECommonRes LadderAction = 7;
	static CommonUnity.Runtime.Character.ECommonRes LadderPose = 8;
	static CommonUnity.Runtime.Character.ECommonRes Locomotion = 9;
	static CommonUnity.Runtime.Character.ECommonRes Mantle = 10;
	static CommonUnity.Runtime.Character.ECommonRes Pose = 11;
	static CommonUnity.Runtime.Character.ECommonRes Swim = 12;
	static CommonUnity.Runtime.Character.ECommonRes SwimPose = 13;
	static CommonUnity.Runtime.Character.ECommonRes Vehicle = 14;
	static CommonUnity.Runtime.Character.ECommonRes VehicleLowerBody = 15;
	static CommonUnity.Runtime.Character.ECommonRes ZHorseSpecial = 16;
	static CommonUnity.Runtime.Character.ECommonRes ZLocomotionSpecial = 17;
	
}

// Client.Runtime
enum CommonUnity.Runtime.Character.ESelectCommonRes : System.Enum
{
	System.Int32 value__; // 0x10
	static CommonUnity.Runtime.Character.ESelectCommonRes defaultSelectCommonRes = 0;
	static CommonUnity.Runtime.Character.ESelectCommonRes melee1h = 1;
	static CommonUnity.Runtime.Character.ESelectCommonRes melee1h1 = 2;
	static CommonUnity.Runtime.Character.ESelectCommonRes melee2h = 3;
	static CommonUnity.Runtime.Character.ESelectCommonRes melee2h1 = 4;
	static CommonUnity.Runtime.Character.ESelectCommonRes none = 5;
	static CommonUnity.Runtime.Character.ESelectCommonRes polearm = 6;
	static CommonUnity.Runtime.Character.ESelectCommonRes rock = 7;
	static CommonUnity.Runtime.Character.ESelectCommonRes torch = 8;
	static CommonUnity.Runtime.Character.ESelectCommonRes wiretool = 9;
	static CommonUnity.Runtime.Character.ESelectCommonRes bandage = 10;
	static CommonUnity.Runtime.Character.ESelectCommonRes bow = 11;
	static CommonUnity.Runtime.Character.ESelectCommonRes chainsaw = 12;
	static CommonUnity.Runtime.Character.ESelectCommonRes grenade = 13;
	static CommonUnity.Runtime.Character.ESelectCommonRes gun2hm = 14;
	static CommonUnity.Runtime.Character.ESelectCommonRes gun2hs = 15;
	static CommonUnity.Runtime.Character.ESelectCommonRes handgun = 16;
	static CommonUnity.Runtime.Character.ESelectCommonRes handgun1h = 17;
	static CommonUnity.Runtime.Character.ESelectCommonRes item2h = 18;
	static CommonUnity.Runtime.Character.ESelectCommonRes launcher = 19;
	static CommonUnity.Runtime.Character.ESelectCommonRes plan = 20;
	static CommonUnity.Runtime.Character.ESelectCommonRes unarmed = 21;
	static CommonUnity.Runtime.Character.ESelectCommonRes wire = 22;
	static CommonUnity.Runtime.Character.ESelectCommonRes common = 23;
	static CommonUnity.Runtime.Character.ESelectCommonRes waterbottle = 24;
	static CommonUnity.Runtime.Character.ESelectCommonRes waterbucke = 25;
	static CommonUnity.Runtime.Character.ESelectCommonRes lobby = 26;
	static CommonUnity.Runtime.Character.ESelectCommonRes vehicle = 27;
	static CommonUnity.Runtime.Character.ESelectCommonRes empty = 28;
	
}

// Client.Runtime
struct CommonUnity.Runtime.Character.NewPhaseKey : System.ValueType, System.IEquatable<CommonUnity.Runtime.Character.NewPhaseKey>
{
	CommonUnity.Runtime.Character.PhaseKeySource sourcePath; // 0x10
	CommonUnity.Runtime.Character.ECommonRes CommonRes; // 0x14
	CommonUnity.Runtime.Character.ESelectCommonRes SelectCommonRes; // 0x18
	System.Boolean Equals(CommonUnity.Runtime.Character.NewPhaseKey other); // 0x062d2c74
	System.Int32 GetHashCode(); // 0x062d2d20
}

// Client.Runtime
class CommonUnity.Runtime.Character.NewPhaseKeyContainer : System.Object
{
	SerializableDictionary<CommonUnity.Runtime.Character.NewPhaseKey,CommonUnity.Runtime.Character.AnimPhaseMapScriptObj> PhaseScriptMap; // 0x10
	System.Collections.Generic.HashSet<System.Int32> EditorOnlyFullPathHashSet; // 0x18
	System.Boolean TryGetValue(CommonUnity.Runtime.Character.PhaseKey& phaseKey, CommonUnity.Runtime.Character.PhaseGroupScriptObj& outPhaseGroupScriptObj); // 0x062d2ddc
	System.Void .ctor(); // 0x062d3044
}

// Client.Runtime
class CommonUnity.Runtime.Character.AnimPhaseMapScriptObj : UnityEngine.ScriptableObject
{
	System.String desc; // 0x18
	SerializableDictionary<CommonUnity.Runtime.Character.PhaseKey,CommonUnity.Runtime.Character.PhaseGroupScriptObj> AnimPhaseMap; // 0x20
	System.Void .ctor(); // 0x062d3150
}

// Client.Runtime
enum CommonUnity.Runtime.Character.PhaseKeySource : System.Enum
{
	System.Int32 value__; // 0x10
	static CommonUnity.Runtime.Character.PhaseKeySource None = 0;
	static CommonUnity.Runtime.Character.PhaseKeySource Fp = 1;
	static CommonUnity.Runtime.Character.PhaseKeySource Tp = 2;
	static CommonUnity.Runtime.Character.PhaseKeySource Monster = 3;
	
}

// Client.Runtime
struct CommonUnity.Runtime.Character.PhaseKey : System.ValueType, System.IEquatable<CommonUnity.Runtime.Character.PhaseKey>
{
	CommonUnity.Runtime.Character.PhaseKeySource sourcePath; // 0x10
	System.Int32 fullPathHash; // 0x14
	System.Int32 selectIdx; // 0x18
	System.Boolean Equals(CommonUnity.Runtime.Character.PhaseKey other); // 0x062d3204
	System.Int32 GetHashCode(); // 0x062d32a4
}

// Client.Runtime
class CommonUnity.Runtime.Character.PhaseGroupScriptObj : UnityEngine.ScriptableObject
{
	System.String desc; // 0x18
	CommonUnity.Runtime.Character.AnimPhaseGroup PhaseGroup; // 0x20
	System.Void .ctor(); // 0x062d334c
}

// Client.Runtime
class CommonUnity.Runtime.Character.Resource.AnimCurveGroup : System.Object
{
	UnityEngine.AnimationCurve[] RuntimeCurves; // 0x10
	System.Void .ctor(); // 0x062d33e8
}

// Client.Runtime
class CommonUnity.Runtime.Character.Resource.AnimStrGroup : System.Object
{
	System.String[] RuntimeStrs; // 0x10
	System.Void .ctor(); // 0x062d3480
}

// Client.Runtime
class CommonUnity.Runtime.Character.Resource.IkCurveEntry : System.Object
{
	System.String StateName; // 0x10
	UnityEngine.AnimationCurve LeftIK; // 0x18
	UnityEngine.AnimationCurve RightIK; // 0x20
	UnityEngine.AnimationCurve HorseSpecial; // 0x28
	System.Void .ctor(); // 0x062d3518
}

// Client.Runtime
class CommonUnity.Runtime.Character.Resource.SpeedWarpSerializedClipConfigScriptObj : UnityEngine.ScriptableObject
{
	SerializableDictionary<System.String,CommonUnity.Runtime.Character.Resource.SpeedWarpClipConf> templateClipConfs; // 0x18
	SerializableDictionary<System.String,CommonUnity.Runtime.Character.Resource.SpeedWarpClipGroupConf> ClipNamePairs; // 0x20
	System.Void .ctor(); // 0x062d35f8
}

// Client.Runtime
class CommonUnity.Runtime.Character.Resource.SpeedWarpClipConf : System.Object
{
	UnityEngine.AnimationClip clip; // 0x10
	System.Single animSpeed; // 0x18
	System.Void .ctor(); // 0x062d3704
}

// Client.Runtime
class CommonUnity.Runtime.Character.Resource.SpeedWarpClipGroupConf : System.Object
{
	System.Collections.Generic.List<CommonUnity.Runtime.Character.Resource.SpeedWarpClipSingleConf> clipConfs; // 0x10
	System.Void .ctor(); // 0x062d376c
}

// Client.Runtime
class CommonUnity.Runtime.Character.Resource.SpeedWarpClipSingleConf : System.Object
{
	System.String templateName; // 0x10
	System.String clipName; // 0x18
	System.Boolean customThreshold; // 0x20
	System.Single threshold; // 0x24
	System.Boolean customAnimSpeed; // 0x28
	System.Single animSpeed; // 0x2c
	System.Boolean customAnimRate; // 0x30
	System.Single timeScale; // 0x34
	System.Void .ctor(); // 0x062d3820
}

// Client.Runtime
struct CommonUnity.Runtime.Camera.TPS.TPSCameraStateTransitionType : System.ValueType
{
	WizardGames.Soc.Common.Unity.TPS.TPSCameraStateType sourceType; // 0x10
	WizardGames.Soc.Common.Unity.TPS.TPSCameraStateType targetType; // 0x14
	System.Void .ctor(WizardGames.Soc.Common.Unity.TPS.TPSCameraStateType srcType, WizardGames.Soc.Common.Unity.TPS.TPSCameraStateType tarType); // 0x062d3890
	System.Boolean Equals(System.Object obj); // 0x062d3910
	System.Int32 GetHashCode(); // 0x062d39dc
}

// Client.Runtime
class CommonUnity.Runtime.Animation.ClientAnimatorCache : System.Object
{
	WizardGames.Soc.Common.Unity.Animation.OptLateUpdatePlayableMB OptPlayableMB; // 0x10
	System.Void CleanUp(); // 0x062d3a84
	System.Void .ctor(); // 0x062d3af4
}

// Client.Runtime
class CommonUnity.Runtime.Animation.ClientAnim : System.Object
{
	System.Int64 EntityId; // 0x10
	System.Int32 AnimatorId; // 0x18
	System.Boolean WaitRemove; // 0x1c
	System.Boolean TpAnimIndexInit; // 0x1d
	WizardGames.Soc.Common.Weapon.WeaponUnique TpAnimIndex; // 0x20
	WizardGames.Soc.Common.Weapon.WeaponUnique ApplyTpAnimIndex; // 0x2c
	System.Int64 <LocomotionLayerTargetWeightTpWeaponId>k__BackingField; // 0x38
	System.Single <LocomotionLayerTargetWeightTp>k__BackingField; // 0x40
	System.Single <LocomotionLayerOverrideTargetWeightTp>k__BackingField; // 0x44
	System.Single <LocomotionLayerNowWeightTp>k__BackingField; // 0x48
	System.Single <LocomotionSpineLayerTargetWeightTp>k__BackingField; // 0x4c
	System.Single <LocomotionSpineLayerOverrideTargetWeightTp>k__BackingField; // 0x50
	System.Single <LocomotionSpineLayerNowWeightTp>k__BackingField; // 0x54
	System.Single <LocomotionWeaponLayerTargetWeightTp>k__BackingField; // 0x58
	System.Single <LocomotionWeaponLayerOverrideTargetWeightTp>k__BackingField; // 0x5c
	System.Single <LocomotionWeaponLayerNowWeightTp>k__BackingField; // 0x60
	System.Single <LocomotionLeftArmLayerTargetWeightTp>k__BackingField; // 0x64
	System.Single <LocomotionLeftArmLayerOverrideTargetWeightTp>k__BackingField; // 0x68
	System.Single <LocomotionLeftArmLayerNowWeightTp>k__BackingField; // 0x6c
	System.Single <LocomotionRightArmLayerTargetWeightTp>k__BackingField; // 0x70
	System.Single <LocomotionRightArmLayerOverrideTargetWeightTp>k__BackingField; // 0x74
	System.Single <LocomotionRightArmLayerNowWeightTp>k__BackingField; // 0x78
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.TpAniBoneMask> LocomotionLayerWeightArray; // 0x80
	Unity.Collections.NativeArray<System.Single> OverrideLayerTimeArray; // 0x90
	Unity.Collections.NativeArray<System.Boolean> OverrideLayerStateLoopArray; // 0xa0
	Unity.Collections.NativeArray<System.Single> LocomotionLayerTimeArray; // 0xb0
	Unity.Collections.NativeArray<System.Boolean> LocomotionLayerSpecialArray; // 0xc0
	System.IntPtr ActionToAoWeightAnimationCurves; // 0xd0
	System.Int32 ActionToAoWeightAnimationCurvesSize; // 0xd8
	System.Int32 ActionToAoWeightAnimationCurvesRealSize; // 0xdc
	System.IntPtr ActionToLocoWeightAnimationCurves; // 0xe0
	System.Int32 ActionToLocoWeightAnimationCurvesSize; // 0xe8
	System.Int32 ActionToLocoWeightAnimationCurvesRealSize; // 0xec
	System.IntPtr OverrideWeightAnimationCurves; // 0xf0
	System.Int32 OverrideWeightAnimationCurvesSize; // 0xf8
	System.Int32 OverrideWeightAnimationCurvesRealSize; // 0xfc
	System.IntPtr TurnInPlaceYawnCurves; // 0x100
	System.Int32 TurnInPlaceYawnCurvesSize; // 0x108
	System.Int32 TurnInPlaceYawnCurvesRealSize; // 0x10c
	System.IntPtr StandCrouchLerpCurves; // 0x110
	System.Int32 StandCrouchLerpCurvesSize; // 0x118
	System.Int32 StandCrouchLerpCurvesRealSize; // 0x11c
	Unity.Collections.NativeArray<System.Single> IkLocomotionLeft; // 0x120
	Unity.Collections.NativeArray<System.Single> IkLocomotionRight; // 0x130
	Unity.Collections.NativeArray<System.Single> IkLocomotionHorse; // 0x140
	Unity.Collections.NativeArray<System.Single> IkAdditiveLeft; // 0x150
	Unity.Collections.NativeArray<System.Single> IkAdditiveRight; // 0x160
	Unity.Collections.NativeArray<System.Single> IkAdditiveHorse; // 0x170
	Unity.Collections.NativeArray<System.Single> IkOverrideLeft; // 0x180
	Unity.Collections.NativeArray<System.Single> IkOverrideRight; // 0x190
	Unity.Collections.NativeArray<System.Single> IkOverrideHorse; // 0x1a0
	System.Collections.Generic.Queue<WizardGames.Soc.Common.Unity.Contexts.SyncSmbStepAudioData> PlayFootStepAudioMsgs; // 0x1b0
	System.Void CleanUp(); // 0x062d3b94
	System.Void DisposeNativeArray(); // 0x062d3bf8
	System.Void .ctor(); // 0x062d4004
}

// Client.Runtime
class CommonUnity.Runtime.Animation.PrintSMB : UnityEngine.StateMachineBehaviour
{
	static SocLogger logger; // 0x0
	System.String printname; // 0x18
	System.Void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex); // 0x062d40e0
	System.Void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex); // 0x062d42ac
	System.Void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex); // 0x062d4478
	System.Void .ctor(); // 0x062d4644
	static System.Void .cctor(); // 0x062d46ac
}

// Client.Runtime
enum CommonUnity.Runtime.Animation.AnimatorCountType : System.Enum
{
	System.Int32 value__; // 0x10
	static CommonUnity.Runtime.Animation.AnimatorCountType Animator_Others = 0;
	static CommonUnity.Runtime.Animation.AnimatorCountType Animator_Player = 1;
	static CommonUnity.Runtime.Animation.AnimatorCountType Animator_Monster = 2;
	static CommonUnity.Runtime.Animation.AnimatorCountType Animator_Weapon = 3;
	static CommonUnity.Runtime.Animation.AnimatorCountType Animator_Horse = 4;
	static CommonUnity.Runtime.Animation.AnimatorCountType Animator_Dig = 5;
	static CommonUnity.Runtime.Animation.AnimatorCountType Animator_NPC = 6;
	static CommonUnity.Runtime.Animation.AnimatorCountType Animator_Corpse = 7;
	static CommonUnity.Runtime.Animation.AnimatorCountType Animator_End = 8;
	
}

// Client.Runtime
struct CommonUnity.Runtime.Animation.AnimCurveKey : System.ValueType, System.IEquatable<CommonUnity.Runtime.Animation.AnimCurveKey>
{
	static UnityEngine.AnimationCurve defaultCurve; // 0x0
	System.Int16 index; // 0x10
	UnityEngine.AnimationCurve displayCurve; // 0x18
	System.Boolean get_isValid(); // 0x062d4780
	static UnityEngine.AnimationCurve op_Implicit(CommonUnity.Runtime.Animation.AnimCurveKey key); // 0x062d47ec
	System.Boolean Equals(CommonUnity.Runtime.Animation.AnimCurveKey other); // 0x062d4980
	System.Int32 GetHashCode(); // 0x062d4aec
	static System.Void .cctor(); // 0x062d4c28
}

// Client.Runtime
enum CommonUnity.Runtime.Animation.EAnimHandleType : System.Enum
{
	System.Int32 value__; // 0x10
	static CommonUnity.Runtime.Animation.EAnimHandleType Fp = 0;
	static CommonUnity.Runtime.Animation.EAnimHandleType Tp = 1;
	static CommonUnity.Runtime.Animation.EAnimHandleType Horse = 2;
	static CommonUnity.Runtime.Animation.EAnimHandleType None = 3;
	
}

// Client.Runtime
class CommonUnity.Runtime.Animation.AnimHandleCacheGroup : System.Object
{
	Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,CommonUnity.Runtime.Animation.AnimHandleCache> animHandles; // 0x10
	System.Void BindHandles(UnityEngine.Animator animator, CommonUnity.Runtime.Animation.EAnimHandleType eType); // 0x062d4c94
	System.Void Clear(); // 0x062d50f0
	System.Boolean TryGetHandle(System.Int32 animator, System.String name, UnityEngine.Animations.TransformStreamHandle& handle); // 0x062ca144
	System.Boolean TryGetHandle(System.Int32 animatorId, System.Int32 nameHash, UnityEngine.Animations.TransformStreamHandle& handle); // 0x062d53ac
	System.Void .ctor(); // 0x062d5504
}

// Client.Runtime
struct CommonUnity.Runtime.Animation.AnimHandleCache : System.ValueType
{
	CommonUnity.Runtime.Animation.EAnimHandleType EType; // 0x10
	Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,KAnimation.Common.TransformHandleNode> StreamName2Handles; // 0x18
	System.Void BindHandles(UnityEngine.Animator animator, CommonUnity.Runtime.Animation.EAnimHandleType eType); // 0x062d4e48
	System.Void Clear(); // 0x062d5308
	static System.Void AddNode(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,KAnimation.Common.TransformHandleNode>& map, UnityEngine.Animator animator, System.String name, System.String fullPath); // 0x062d6778
	static System.Void BuildDefaultFpHandles(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,KAnimation.Common.TransformHandleNode>& map, UnityEngine.Animator animator); // 0x062d556c
	static System.Void BuildDefaultTpHandles(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,KAnimation.Common.TransformHandleNode>& map, UnityEngine.Animator animator); // 0x062d58c8
	static System.Void BuildDefaultHorseHandles(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,KAnimation.Common.TransformHandleNode>& map, UnityEngine.Animator animator); // 0x062d605c
}

// Client.Runtime
class CommonUnity.Runtime.Animation.AnimKeyComparer : System.Object, System.Collections.Generic.IEqualityComparer<CommonUnity.Runtime.Animation.AnimStrKey>
{
	
	System.Boolean Equals(CommonUnity.Runtime.Animation.AnimStrKey x, CommonUnity.Runtime.Animation.AnimStrKey y); // 0x062d6904
	System.Int32 GetHashCode(CommonUnity.Runtime.Animation.AnimStrKey x); // 0x062d69d8
	System.Void .ctor(); // 0x062d6a8c
}

// Client.Runtime
class CommonUnity.Runtime.Animation.AnimKeyDict<TValue> : SerializableDictionary<CommonUnity.Runtime.Animation.AnimStrKey,TValue>
{
	static CommonUnity.Runtime.Animation.AnimKeyComparer sharedComparer; // 0x0
	System.Void .ctor(); // 0x055049cc
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
enum CommonUnity.Runtime.Animation.AnimMoveEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static CommonUnity.Runtime.Animation.AnimMoveEnum LadderMotion = 0;
	static CommonUnity.Runtime.Animation.AnimMoveEnum SwimMotion = 1;
	static CommonUnity.Runtime.Animation.AnimMoveEnum JogMotion = 2;
	static CommonUnity.Runtime.Animation.AnimMoveEnum CrouchMotion = 3;
	static CommonUnity.Runtime.Animation.AnimMoveEnum InjuredMotion = 4;
	static CommonUnity.Runtime.Animation.AnimMoveEnum End = 5;
	
}

// Client.Runtime
enum CommonUnity.Runtime.Animation.AnimMoveSpeedLerpMode : System.Enum
{
	System.Int32 value__; // 0x10
	static CommonUnity.Runtime.Animation.AnimMoveSpeedLerpMode None = 0;
	static CommonUnity.Runtime.Animation.AnimMoveSpeedLerpMode Lerp = 1;
	static CommonUnity.Runtime.Animation.AnimMoveSpeedLerpMode SmoothStep = 2;
	static CommonUnity.Runtime.Animation.AnimMoveSpeedLerpMode RestImmediate = 3;
	
}

// Client.Runtime
enum CommonUnity.Runtime.Animation.AnimEditorSpeedRuleType : System.Enum
{
	System.Int32 value__; // 0x10
	static CommonUnity.Runtime.Animation.AnimEditorSpeedRuleType FP = 0;
	
}

// Client.Runtime
struct CommonUnity.Runtime.Animation.AnimMoveSpeedConf : System.ValueType
{
	System.Boolean Valid; // 0x10
	System.Single SpeedF; // 0x14
	System.Single SpeedB; // 0x18
	System.Single SpeedLR; // 0x1c
	System.Single LerpSpeed; // 0x20
	CommonUnity.Runtime.Animation.AnimMoveSpeedLerpMode LerpMode; // 0x24
	System.Boolean hasLimitMinFb; // 0x28
	System.Single LimitMinFB; // 0x2c
	System.Boolean hasLimitMaxFb; // 0x30
	System.Single LimitMaxFB; // 0x34
	System.Boolean hasLimitMinLR; // 0x38
	System.Single LimitMinLR; // 0x3c
	System.Boolean hasLimitMaxLR; // 0x40
	System.Single LimitMaxLR; // 0x44
	System.Single InOutLerpSpeed; // 0x48
	CommonUnity.Runtime.Animation.AnimMoveSpeedLerpMode InOutLerpMode; // 0x4c
	System.Int32 EnterMatchRuleId; // 0x50
	System.Int32 ApplyRuleId; // 0x54
	CommonUnity.Runtime.Animation.AnimEditorSpeedRuleType EdtiorRuleDataType; // 0x58
	System.Boolean ShouldClamp01; // 0x5c
	
}

// Client.Runtime
struct CommonUnity.Runtime.Animation.AnimMoveSpeedLocalCache : System.ValueType
{
	CommonUnity.Runtime.Animation.AnimMoveEnum Source; // 0x10
	CommonUnity.Runtime.Animation.AnimMoveEnum EvaluateType; // 0x14
	System.Boolean Running; // 0x18
	System.Boolean Entering; // 0x19
	System.Boolean Exiting; // 0x1a
	System.Single LastSrcSpeedNormF; // 0x1c
	System.Single LastSrcSpeedNormR; // 0x20
	Unity.Mathematics.float3 LastSpeedV3; // 0x24
	System.Single LastSpeedXZ; // 0x30
	System.Boolean get_IsEvaluating(); // 0x062d6af4
}

// Client.Runtime
struct CommonUnity.Runtime.Animation.AnimMoveSpeedLocalCacheGroup : System.ValueType
{
	CommonUnity.Runtime.Animation.AnimMoveSpeedLocalCache LadderMotionCache; // 0x10
	CommonUnity.Runtime.Animation.AnimMoveSpeedLocalCache SwimMotionCache; // 0x34
	CommonUnity.Runtime.Animation.AnimMoveSpeedLocalCache JogMotionCache; // 0x58
	CommonUnity.Runtime.Animation.AnimMoveSpeedLocalCache CrouchMotionCache; // 0x7c
	CommonUnity.Runtime.Animation.AnimMoveSpeedLocalCache InjuredMotionCache; // 0xa0
	static CommonUnity.Runtime.Animation.AnimMoveSpeedLocalCache& GetCache(CommonUnity.Runtime.Animation.AnimMoveSpeedLocalCacheGroup& group, CommonUnity.Runtime.Animation.AnimMoveEnum type); // 0x062d6b70
}

// Client.Runtime
struct CommonUnity.Runtime.Animation.AnimMoveSpeedConfGroup : System.ValueType
{
	CommonUnity.Runtime.Animation.AnimMoveSpeedConf LadderMotionConf; // 0x10
	CommonUnity.Runtime.Animation.AnimMoveSpeedConf SwimMotionConf; // 0x60
	CommonUnity.Runtime.Animation.AnimMoveSpeedConf JogMotionConf; // 0xb0
	CommonUnity.Runtime.Animation.AnimMoveSpeedConf CrouchMotionConf; // 0x100
	CommonUnity.Runtime.Animation.AnimMoveSpeedConf InjuredMotionConf; // 0x150
	System.Void SetConf(CommonUnity.Runtime.Animation.AnimMoveEnum type, CommonUnity.Runtime.Animation.AnimMoveSpeedConf conf); // 0x062d6c64
	CommonUnity.Runtime.Animation.AnimMoveSpeedConf GetConf(CommonUnity.Runtime.Animation.AnimMoveEnum type); // 0x062d6d5c
}

// Client.Runtime
struct CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConfGroup : System.ValueType
{
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf Rule0; // 0x10
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf Rule1; // 0x40
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf Rule2; // 0x70
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf Rule3; // 0xa0
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf Rule4; // 0xd0
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf Rule5; // 0x100
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf Rule6; // 0x130
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf Rule7; // 0x160
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf Rule8; // 0x190
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf Rule9; // 0x1c0
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf Rule10; // 0x1f0
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf Rule11; // 0x220
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf Rule12; // 0x250
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf Rule13; // 0x280
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf Rule14; // 0x2b0
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf Rule15; // 0x2e0
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf Rule16; // 0x310
	System.Int32 Count; // 0x340
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf& Get(System.Int32 idx); // 0x062d6e54
	System.Void Set(System.Int32 idx, CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf conf); // 0x062d6f1c
}

// Client.Runtime
struct CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf : System.ValueType
{
	System.Boolean Valid; // 0x10
	System.Int32 State; // 0x14
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.CompareStateType StateType; // 0x18
	System.Single ParamFloatValue; // 0x1c
	System.Int32 ParamIntValue; // 0x20
	System.Boolean ParamBoolValue; // 0x24
	System.Int32 ParamOffset; // 0x28
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.ValueType ParamType; // 0x2c
	WizardGames.Soc.Common.Unity.StateApplyRule ApplyRule; // 0x30
	WizardGames.Soc.Common.Unity.ValueCompareRule ValueRule; // 0x34
	WizardGames.Soc.Common.Unity.StateApplyType CmpType; // 0x38
	WizardGames.Soc.Common.Unity.AnimSpeedSetType SpeedSetType; // 0x3c
	
}

// Client.Runtime
enum CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.CompareStateType : System.Enum
{
	System.Int32 value__; // 0x10
	static CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.CompareStateType None = 0;
	static CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.CompareStateType MoveState = 1;
	static CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.CompareStateType PoseState = 2;
	static CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.CompareStateType UnAliveState = 3;
	static CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.CompareStateType ActionState = 4;
	static CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.CompareStateType MoveLadderState = 5;
	
}

// Client.Runtime
enum CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.ValueType : System.Enum
{
	System.Int32 value__; // 0x10
	static CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.ValueType None = 0;
	static CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.ValueType Float = 1;
	static CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.ValueType Int = 2;
	static CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.ValueType Bool = 3;
	
}

// Client.Runtime
enum CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.MatchResult : System.Enum
{
	System.Int32 value__; // 0x10
	static CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.MatchResult Failed = 0;
	static CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.MatchResult Success = 1;
	static CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf.MatchResult Continue = 2;
	
}

// Client.Runtime
struct CommonUnity.Runtime.Animation.AnimStrKey : System.ValueType, System.IEquatable<CommonUnity.Runtime.Animation.AnimStrKey>
{
	System.Int16 index; // 0x10
	System.String displayName; // 0x18
	System.Boolean get_isValid(); // 0x062d6fd4
	static CommonUnity.Runtime.Animation.AnimStrKey op_Implicit(System.String b); // 0x062d7040
	static System.String op_Implicit(CommonUnity.Runtime.Animation.AnimStrKey key); // 0x062d717c
	System.Boolean Equals(CommonUnity.Runtime.Animation.AnimStrKey other); // 0x062d72f0
	System.Int32 GetHashCode(); // 0x062d7428
}

// Client.Runtime
class Animation.AnimBeginEventRegister : System.Object
{
	
	static System.Void Register(); // 0x062d7540
}

// Client.Runtime
struct Animation.SocAnimPreLateUpdate : System.ValueType
{
	
	static System.Void Register(UnityEngine.LowLevel.PlayerLoopSystem& systems); // 0x062d7618
}

// Client.Runtime
struct Animation.SocAnimPreLateUpdate.CustomDirectorUpdateAnimationBegin : System.ValueType
{
	
	
}

// Client.Runtime
class Animation.SocAnimPreLateUpdate.<>c : System.Object
{
	static Animation.SocAnimPreLateUpdate.<>c <>9; // 0x0
	static UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunction <>9__13_0; // 0x8
	static UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunction <>9__13_1; // 0x10
	static System.Void .cctor(); // 0x062d7fcc
	System.Void .ctor(); // 0x062d8030
	System.Void <Register>b__13_0(); // 0x062d8098
	System.Void <Register>b__13_1(); // 0x062d8164
}

// Client.Runtime
struct Animation.SocAnimPostLateUpdate : System.ValueType
{
	
	static System.Void Register(UnityEngine.LowLevel.PlayerLoopSystem& systems); // 0x062d7ba8
}

// Client.Runtime
struct Animation.SocAnimPostLateUpdate.CustomBeforeUpdateSkinnedMeshRenderer : System.ValueType
{
	
	
}

// Client.Runtime
class Animation.SocAnimPostLateUpdate.<>c : System.Object
{
	static Animation.SocAnimPostLateUpdate.<>c <>9; // 0x0
	static UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunction <>9__2_0; // 0x8
	static System.Void .cctor(); // 0x062d8230
	System.Void .ctor(); // 0x062d8294
	System.Void <Register>b__2_0(); // 0x062d82fc
}

// Client.Runtime
class Animation.AnimBehCache : System.Object
{
	System.String LeftIKPointName; // 0x10
	System.String RightIKPointName; // 0x18
	System.String LeftIKPointNameTp; // 0x20
	System.String RightIKPointNameTp; // 0x28
	System.Boolean EnableRaycast; // 0x30
	System.Boolean IsMyPlayer; // 0x31
	System.Int64 HeldItemId; // 0x38
	WizardGames.Soc.Common.Entity.PlayerEntity playerEntity; // 0x40
	UnityEngine.Vector3 nowEntityPos; // 0x48
	UnityEngine.Vector3 lastEntityPos; // 0x54
	WizardGames.Soc.Common.Combat.ColliderMaterialEnum lastMaterialEnum; // 0x60
	Animation.Event.AnimFootEvent footEvent; // 0x68
	WizardGames.Soc.Common.Combat.ColliderMaterialEnum currentMaterialEnum; // 0x88
	UnityEngine.Vector3 currentRaycastPos; // 0x8c
	System.Collections.Generic.List<Animation.Event.AnimAudioEvent> HistoryAudioList; // 0x98
	System.Collections.Generic.List<Animation.Event.AnimAudioEvent> FpHistoryAudioList; // 0xa0
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.NewLogicAnimEvent> HistoryNotifyList; // 0xa8
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.NewLogicAnimEvent> FpHistoryNotifyList; // 0xb0
	System.Collections.Generic.List<Animation.Event.AnimEffectEvent> HistoryEffectList; // 0xb8
	System.Collections.Generic.List<Animation.Event.AnimEffectEvent> FpHistoryEffectList; // 0xc0
	Effect.EffectItemHandleContainer effectHandles; // 0xc8
	System.Collections.Generic.List<System.Int64> accessory; // 0xd0
	System.Int32 RaycastIndex; // 0xd8
	System.Boolean MovedBefore; // 0xdc
	WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.PhysicsShapeType <shapeType>k__BackingField; // 0xe0
	System.Void Release(); // 0x062d83c8
	System.Void .ctor(); // 0x062d864c
}

// Client.Runtime
class Animation.PlayerFootContactCheck : System.Object
{
	static UnityEngine.RaycastCommand[] rayCastCommandArray; // 0x0
	static UnityEngine.RaycastHit[] rayCastHitResultArray; // 0x8
	static System.Int32 raycastCommandCount; // 0x10
	static Unity.Collections.NativeArray<UnityEngine.RaycastCommand> raycastCommandsNA; // 0x18
	static Unity.Collections.NativeArray<UnityEngine.RaycastHit> raycastHitsNA; // 0x28
	static Unity.Jobs.JobHandle raycastJobHandle; // 0x38
	static System.Void BeginCheck(WizardGames.Soc.Common.Contexts.Context context); // 0x062d86cc
	static System.Void EndCheck(); // 0x062d8d34
	static System.Boolean TryGetCollider(System.Int32 index, UnityEngine.RaycastHit& raycastHit); // 0x062d8e80
	static System.Void .cctor(); // 0x062d8f70
}

// Client.Runtime
class Animation.Event.AnimNotifyConst : System.Object
{
	static SocLogger logger; // 0x0
	static System.Boolean DbgLog; // 0x8
	static System.Void .cctor(); // 0x062d9034
}

// Client.Runtime
struct Animation.Event.AnimEffectEvent : System.ValueType
{
	System.Int32 EventTbId; // 0x10
	System.Single TriggerTime; // 0x14
	Effect.EffectItemHandle<Effect.EffectItem> PlayingEffect; // 0x18
	
}

// Client.Runtime
struct Animation.Event.AnimFootEvent : System.ValueType
{
	System.Boolean DisableFootstepAudio; // 0x10
	UnityEngine.Transform leftFoot; // 0x18
	UnityEngine.Transform rightFoot; // 0x20
	System.Boolean isLeftFoot; // 0x28
	System.Boolean isMoving; // 0x29
	System.Boolean firstFootstep; // 0x2a
	
}

// Client.Runtime
struct Animation.Event.AnimAudioEvent : System.ValueType
{
	System.String AudioName; // 0x10
	System.Int32 AudioEventId; // 0x18
	System.Single TriggerTime; // 0x1c
	
}

// Client.Runtime
struct Animation.Event.AnimNotifyContext : System.ValueType
{
	WizardGames.Soc.Common.Data.EAnimEventCameraType MainPlayerView; // 0x10
	System.Boolean IsSelf; // 0x14
	System.Int64 entityId; // 0x18
	WizardGames.Soc.Common.Entity.IEntity entity; // 0x20
	System.Int64 heldItemId; // 0x28
	WizardGames.Soc.Common.Entity.IEntity heldItemEntity; // 0x30
	System.Int64 heldItemTbId; // 0x38
	System.Int64 heldItemSkinId; // 0x40
	System.Collections.Generic.List<System.Int64> accessory; // 0x48
	UnityEngine.Transform OwnerGo; // 0x50
	UnityEngine.Transform HeldItemGo; // 0x58
	System.Int32 LodLv; // 0x60
	System.Collections.Generic.List<Animation.Event.AnimAudioEvent> HistoryAudioList; // 0x68
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.NewLogicAnimEvent> HistoryNotifyList; // 0x70
	System.Collections.Generic.List<Animation.Event.AnimEffectEvent> HistoryEffectList; // 0x78
	Animation.AnimBehCache HistoryBeh; // 0x80
	
}

// Client.Runtime
struct Animation.Event.AnimNotifyExecuteParams : System.ValueType
{
	Animation.Event.AnimNotifyContext context; // 0x10
	WizardGames.Soc.Common.Unity.Animation.NewLogicAnimEvent AnimEvent; // 0x88
	
}

// Client.Runtime
enum Animation.Event.AnimNotifyErrorCode : System.Enum
{
	System.Int32 value__; // 0x10
	static Animation.Event.AnimNotifyErrorCode None = 0;
	static Animation.Event.AnimNotifyErrorCode Invalid = 1;
	static Animation.Event.AnimNotifyErrorCode MissEntity = 2;
	static Animation.Event.AnimNotifyErrorCode MissTable = 3;
	static Animation.Event.AnimNotifyErrorCode MissConf = 4;
	static Animation.Event.AnimNotifyErrorCode DisableCamera = 5;
	static Animation.Event.AnimNotifyErrorCode IgnoreEntityType = 6;
	static Animation.Event.AnimNotifyErrorCode DisablePoseState = 7;
	static Animation.Event.AnimNotifyErrorCode DisableMoveState = 8;
	static Animation.Event.AnimNotifyErrorCode SingleTriggetNotAllowed = 9;
	static Animation.Event.AnimNotifyErrorCode SingleTriggetNotMatch = 10;
	
}

// Client.Runtime
class Animation.Event.AnimNotifyModule : System.Object
{
	
	static T GenericBuildAnimNotify<T>(System.Int32 id); // 0x052af1f0
	static Animation.Event.AnimNotifyErrorCode GenericExecuteAnimNotify<T>(T& animEvent, Animation.Event.AnimNotifyExecuteParams& param); // 0x052af1f0
	static Animation.Event.AnimNotifyErrorCode ExecuteAnimNotify(Animation.Event.AnimNotifyExecuteParams& param); // 0x062d90d8
}

// Client.Runtime
struct Animation.Event.AnimNotify_AudioBehaviour : System.ValueType, Animation.Event.IAnimNotify
{
	System.Boolean <Valid>k__BackingField; // 0x10
	System.Int32 <EventTbId>k__BackingField; // 0x14
	System.Boolean get_Valid(); // 0x062d9620
	System.Void set_Valid(System.Boolean value); // 0x062d9684
	System.Int32 get_EventTbId(); // 0x062d9700
	System.Void set_EventTbId(System.Int32 value); // 0x062d9764
	System.Void Build(System.Int32 id, WizardGames.Soc.Common.Data.DataItem.AnimEventConfig config); // 0x062d97dc
	System.Boolean Execute(Animation.Event.AnimNotifyExecuteParams& param); // 0x062d9a04
	System.String Map2CommonAudio(WizardGames.Soc.Common.Data.DataItem.AnimEventConfig config, System.Int64 CurrentWeaponTableId, System.Int64 CurrentWeaponSkinId, System.Boolean fp, WizardGames.Soc.Common.Entity.IEntity entity); // 0x062da978
	System.String GetMeleeAttackSound(WizardGames.Soc.Common.Data.DataItem.AnimEventConfig config, System.Int64 CurrentWeaponTableId, System.Int64 CurrentWeaponSkinId); // 0x062da608
	System.String GetMeleeThrowSound(WizardGames.Soc.Common.Data.DataItem.AnimEventConfig config, System.Int64 CurrentWeaponTableId, System.Int64 CurrentWeaponSkinId); // 0x062da87c
}

// Client.Runtime
struct Animation.Event.AnimNotify_CameraShake : System.ValueType, Animation.Event.IAnimNotify
{
	System.Boolean <Valid>k__BackingField; // 0x10
	System.Int32 <EventTbId>k__BackingField; // 0x14
	System.Boolean get_Valid(); // 0x062daa9c
	System.Void set_Valid(System.Boolean value); // 0x062dab00
	System.Int32 get_EventTbId(); // 0x062dab7c
	System.Void set_EventTbId(System.Int32 value); // 0x062dabe0
	System.Void Build(System.Int32 id, WizardGames.Soc.Common.Data.DataItem.AnimEventConfig config); // 0x062dac58
	System.Boolean Execute(Animation.Event.AnimNotifyExecuteParams& param); // 0x062dadec
}

// Client.Runtime
struct Animation.Event.AnimNotify_CreateMag : System.ValueType, Animation.Event.IAnimNotify
{
	System.Boolean <Valid>k__BackingField; // 0x10
	System.Int32 <EventTbId>k__BackingField; // 0x14
	System.Boolean get_Valid(); // 0x062db240
	System.Void set_Valid(System.Boolean value); // 0x062db2a4
	System.Int32 get_EventTbId(); // 0x062db320
	System.Void set_EventTbId(System.Int32 value); // 0x062db384
	System.Void Build(System.Int32 id, WizardGames.Soc.Common.Data.DataItem.AnimEventConfig config); // 0x062db3fc
	System.Boolean Execute(Animation.Event.AnimNotifyExecuteParams& param); // 0x062db584
	System.Void TryCreateMagObject(UnityEngine.Transform weaponTrans, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Int64 tableId, System.Int64 skinId, System.Collections.Generic.List<System.Int64> accessory, System.Boolean isSelf); // 0x062dbc14
	WizardGames.Soc.Common.Weapon.MagPhysicsData CreateMagData(UnityEngine.Transform weaponTrans, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Int64 tableId, System.Int64 skinId, System.Boolean isSelf); // 0x062dbef0
	System.Void CreateMagObject(WizardGames.Soc.Common.Weapon.MagPhysicsData magData, UnityEngine.GameObject root, System.Boolean isEx); // 0x062dc4b4
}

// Client.Runtime
class Animation.Event.AnimNotify_CreateMag.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.Common.Weapon.MagPhysicsData magData; // 0x10
	System.Boolean isEx; // 0x38
	System.Void .ctor(); // 0x062dc6c4
	System.Void <CreateMagObject>b__0(UnityEngine.GameObject go, System.Object[] owner); // 0x062dc72c
}

// Client.Runtime
struct Animation.Event.AnimNotify_EffectBehaviour : System.ValueType, Animation.Event.IAnimNotify
{
	System.Boolean <Valid>k__BackingField; // 0x10
	System.Int32 <EventTbId>k__BackingField; // 0x14
	System.Boolean get_Valid(); // 0x062dc92c
	System.Void set_Valid(System.Boolean value); // 0x062dc990
	System.Int32 get_EventTbId(); // 0x062dca0c
	System.Void set_EventTbId(System.Int32 value); // 0x062dca70
	System.Void Build(System.Int32 id, WizardGames.Soc.Common.Data.DataItem.AnimEventConfig config); // 0x062dcae8
	System.Boolean Execute(Animation.Event.AnimNotifyExecuteParams& param); // 0x062dcd20
	System.Void PlayFootEffect(Animation.AnimBehCache beh, WizardGames.Soc.Common.Entity.PlayerEntity entity, System.Int32 tableId, System.Boolean isLeft); // 0x062ddbf4
}

// Client.Runtime
struct Animation.Event.AnimNotify_FootStep : System.ValueType, Animation.Event.IAnimNotify
{
	System.Boolean <Valid>k__BackingField; // 0x10
	System.Int32 <EventTbId>k__BackingField; // 0x14
	static WizardGames.Soc.SocClient.Audio.WWise.AudioEventData.PostEventFinishedCallback CachedStaticCallback; // 0x0
	System.Boolean get_Valid(); // 0x062de168
	System.Void set_Valid(System.Boolean value); // 0x062de1cc
	System.Int32 get_EventTbId(); // 0x062de248
	System.Void set_EventTbId(System.Int32 value); // 0x062de2ac
	System.Void Build(System.Int32 id, WizardGames.Soc.Common.Data.DataItem.AnimEventConfig config); // 0x062de324
	System.Boolean Execute(Animation.Event.AnimNotifyExecuteParams& param); // 0x062de4ec
	System.String GetMonsterFootAudio(WizardGames.Soc.Common.Entity.MonsterEntity monster); // 0x062df65c
	System.Boolean CheckDistance(UnityEngine.Transform go); // 0x062dec9c
	static WizardGames.Soc.Common.Data.DamageRelation GetDamageRelation(WizardGames.Soc.Common.Entity.PlayerEntity targetPlayerEntity); // 0x062df79c
	System.Void PlayFootAudio(Animation.AnimBehCache beh, System.String soundName, WizardGames.Soc.Common.Entity.PlayerEntity entity, System.Boolean isFp); // 0x062dee8c
	static System.Void OnFootStep(WizardGames.Soc.SocClient.Audio.WWise.AudioEventData audioEventData, System.Object cookie); // 0x05523a54
	static System.Void .cctor(); // 0x062dfcd4
}

// Client.Runtime
class Animation.Event.AnimNotifyFunc : System.Object
{
	
	static System.Boolean CanPlayInView<T>(T owner, Animation.Event.AnimNotifyExecuteParams& param, WizardGames.Soc.Common.Data.DataItem.AnimEventConfig config); // 0x052af1f0
}

// Client.Runtime
struct Animation.Event.AnimNotify_IKChange : System.ValueType, Animation.Event.IAnimNotify
{
	System.Boolean <Valid>k__BackingField; // 0x10
	System.Int32 <EventTbId>k__BackingField; // 0x14
	System.Boolean get_Valid(); // 0x062dfd74
	System.Void set_Valid(System.Boolean value); // 0x062dfdd8
	System.Int32 get_EventTbId(); // 0x062dfe54
	System.Void set_EventTbId(System.Int32 value); // 0x062dfeb8
	System.Void Build(System.Int32 id, WizardGames.Soc.Common.Data.DataItem.AnimEventConfig config); // 0x062dff30
	System.String GetIKTarget(WizardGames.Soc.Common.Data.DataItem.AnimEventConfig config); // 0x062e00b8
	System.Boolean Execute(Animation.Event.AnimNotifyExecuteParams& param); // 0x062e01a8
}

// Client.Runtime
struct Animation.Event.AnimNotify_VisibleBehaviour : System.ValueType, Animation.Event.IAnimNotify
{
	System.Boolean <Valid>k__BackingField; // 0x10
	System.Int32 <EventTbId>k__BackingField; // 0x14
	System.Boolean get_Valid(); // 0x062e0784
	System.Void set_Valid(System.Boolean value); // 0x062e07e8
	System.Int32 get_EventTbId(); // 0x062e0864
	System.Void set_EventTbId(System.Int32 value); // 0x062e08c8
	System.Void Build(System.Int32 id, WizardGames.Soc.Common.Data.DataItem.AnimEventConfig config); // 0x062e0940
	System.Boolean Execute(Animation.Event.AnimNotifyExecuteParams& param); // 0x062e0ad4
}

// Client.Runtime
struct Animation.Event.AnimNotify_WeaponVisBehaviour : System.ValueType, Animation.Event.IAnimNotify
{
	System.Boolean <Valid>k__BackingField; // 0x10
	System.Int32 <EventTbId>k__BackingField; // 0x14
	System.Boolean get_Valid(); // 0x062e1278
	System.Void set_Valid(System.Boolean value); // 0x062e12dc
	System.Int32 get_EventTbId(); // 0x062e1358
	System.Void set_EventTbId(System.Int32 value); // 0x062e13bc
	System.Void Build(System.Int32 id, WizardGames.Soc.Common.Data.DataItem.AnimEventConfig config); // 0x062e1434
	System.Boolean Execute(Animation.Event.AnimNotifyExecuteParams& param); // 0x062e15bc
}

// Client.Runtime
interface Animation.Event.IAnimNotify : 
{
	
	System.Boolean get_Valid(); // 0x054c4760
	System.Int32 get_EventTbId(); // 0x0548ba98
	System.Void Build(System.Int32 id, WizardGames.Soc.Common.Data.DataItem.AnimEventConfig config); // 0x0550f6d4
	System.Boolean Execute(Animation.Event.AnimNotifyExecuteParams& param); // 0x054dec74
}

// Client.Runtime
class WizardGames.Editor.TpClipData : System.Object
{
	System.Single AnimationTime; // 0x10
	
}

// Client.Runtime
class WizardGames.Editor.FpClipData : System.Object
{
	System.Single AnimationTime; // 0x10
	System.Single AnimatorStateTime; // 0x14
	System.Single RecoveryPercentage; // 0x18
	
}

// Client.Runtime
class WizardGames.Editor.FpPoseData : System.Object
{
	UnityEngine.Vector3 Position; // 0x10
	UnityEngine.AnimationCurve PosCurve; // 0x20
	UnityEngine.Vector3 Rotation; // 0x28
	UnityEngine.AnimationCurve RotCurve; // 0x38
	System.Void .ctor(); // 0x062e1cd0
}

// Client.Runtime
class WizardGames.Editor.TpSkeletonMaskData : System.Object
{
	
	System.Void .ctor(); // 0x062e1d88
}

// Client.Runtime
struct WizardGames.Editor.SkeletonMaskWeightValue : System.ValueType
{
	System.Single Weight; // 0x10
	
}

// Client.Runtime
struct WizardGames.Editor.SkeletonDynamicsMask : System.ValueType
{
	System.Collections.Generic.List<System.Int32> MaskList; // 0x10
	
}

// Client.Runtime
enum WizardGames.Editor.ECommonRecoveryType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Editor.ECommonRecoveryType MantleLow = 0;
	static WizardGames.Editor.ECommonRecoveryType MantleHigh = 1;
	
}

// Client.Runtime
enum WizardGames.Editor.EMantleLogicType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Editor.EMantleLogicType MantleLow = 0;
	static WizardGames.Editor.EMantleLogicType MantleHigh = 1;
	
}

// Client.Runtime
struct WizardGames.Editor.ClipRecoveryData : System.ValueType
{
	System.Int32 CommonStateTime; // 0x10
	System.Single RecoveryPercentage; // 0x14
	
}

// Client.Runtime
struct WizardGames.Editor.MantleLogicData : System.ValueType
{
	UnityEngine.Vector2 MantleTargetPos; // 0x10
	UnityEngine.AnimationCurve MantleVertical; // 0x18
	UnityEngine.AnimationCurve MantleHorizontal; // 0x20
	
}

// Client.Runtime
class WizardGames.Editor.FpClipSettingCollections : UnityEngine.ScriptableObject
{
	System.Collections.Generic.List<System.String> WeaponClipNames; // 0x18
	System.Collections.Generic.List<System.String> LeftIkClipNames; // 0x20
	System.Collections.Generic.List<System.String> RightIkClipNames; // 0x28
	SerializableDictionary<System.String,WizardGames.Editor.SkeletonDynamicsMask> SkeletonDynamicsMasks; // 0x30
	System.Void .ctor(); // 0x062e1df0
}

// Client.Runtime
class WizardGames.Editor.FpClipSettingMeta : UnityEngine.ScriptableObject
{
	SerializableDictionary<CommonUnity.Runtime.Character.PhaseKey,CommonUnity.Runtime.Character.PhaseGroupScriptObj> AnimPhaseMap; // 0x18
	CommonUnity.Runtime.Animation.AnimKeyDict<WizardGames.Editor.FpClipData> NewClipInfos; // 0x20
	SerializableDictionary<WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EPoseLayer,CommonUnity.Runtime.Character.Resource.IkCurveEntry> PoseIkCurves; // 0x28
	SerializableDictionary<WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ESightLayer,CommonUnity.Runtime.Character.Resource.IkCurveEntry> SightIkCurves; // 0x30
	SerializableDictionary<WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer,CommonUnity.Runtime.Character.Resource.IkCurveEntry> LocomotionIkCurves; // 0x38
	SerializableDictionary<WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer,CommonUnity.Runtime.Character.Resource.IkCurveEntry> AdditiveIkCurves; // 0x40
	SerializableDictionary<WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer,CommonUnity.Runtime.Character.Resource.IkCurveEntry> OverrideIkCurves; // 0x48
	WizardGames.Editor.SkeletonMaskWeightValue[] newIdleWeight; // 0x50
	WizardGames.Editor.SkeletonMaskWeightValue[] newJogWeight; // 0x58
	WizardGames.Editor.SkeletonMaskWeightValue[] newJog2SprintWeight; // 0x60
	WizardGames.Editor.SkeletonMaskWeightValue[] newSprintWeight; // 0x68
	WizardGames.Editor.SkeletonMaskWeightValue[] newJumpWeight; // 0x70
	WizardGames.Editor.SkeletonMaskWeightValue[] newSwimWeight; // 0x78
	SerializableDictionary<System.String,System.String> AudioDict; // 0x80
	CommonUnity.Runtime.Animation.AnimKeyDict<System.Int32> newFpWpnStringToHash; // 0x88
	System.Boolean JumpInteriaOverride; // 0x90
	UnityEngine.AnimationCurve JumpProj2ForwardInteriaCurve; // 0x98
	UnityEngine.AnimationCurve JumpProj2RightInteriaCurve; // 0xa0
	System.Single Damping; // 0xa8
	System.Single Frequency; // 0xac
	System.Single InterpSpeed; // 0xb0
	System.Single SpringRatio; // 0xb4
	System.Boolean OpenSpring; // 0xb8
	System.Single JumpStartInertialTime; // 0xbc
	System.Single JumpKeepInertialTime; // 0xc0
	System.Single JumpClearInertialTime; // 0xc4
	WizardGames.Editor.FpPoseData StandJogPose_C; // 0xc8
	WizardGames.Editor.FpPoseData StandJogPose_F; // 0xd0
	WizardGames.Editor.FpPoseData StandJogPose_B; // 0xd8
	WizardGames.Editor.FpPoseData StandJogPose_L; // 0xe0
	WizardGames.Editor.FpPoseData StandJogPose_R; // 0xe8
	WizardGames.Editor.FpPoseData CrouchJogPose_C; // 0xf0
	WizardGames.Editor.FpPoseData CrouchJogPose_F; // 0xf8
	WizardGames.Editor.FpPoseData CrouchJogPose_B; // 0x100
	WizardGames.Editor.FpPoseData CrouchJogPose_L; // 0x108
	WizardGames.Editor.FpPoseData CrouchJogPose_R; // 0x110
	System.Boolean SprintBlockByAirNeedTransition; // 0x118
	WizardGames.Soc.Common.Unity.Character.ClientWeaponBindingData WeaponBindings; // 0x120
	WizardGames.Soc.Common.Unity.Character.ClientClipValue WeaponClipValue; // 0x128
	WizardGames.Soc.Common.Unity.Character.ClientClipValue CharClipValue; // 0x130
	UnityEngine.Vector3 AdsBaseLocatorInitOffset; // 0x138
	UnityEngine.Vector3 AdsBaseLocatorInitRotOffset; // 0x144
	UnityEngine.Vector3 AdsPosOffset; // 0x150
	UnityEngine.Vector3 AdsRotOffset; // 0x15c
	UnityEngine.Vector3 AdsW2APos; // 0x168
	UnityEngine.Quaternion AdsW2ARot; // 0x174
	UnityEngine.Vector3 AdsJ2RPos; // 0x184
	UnityEngine.Quaternion AdsJ2RRot; // 0x190
	UnityEngine.Vector3 AdsA2DPos; // 0x1a0
	UnityEngine.Quaternion AdsA2DRot; // 0x1ac
	UnityEngine.Vector3 AdsB2VPos; // 0x1bc
	UnityEngine.Quaternion AdsB2VRot; // 0x1c8
	UnityEngine.Vector3 AdsS2RPos; // 0x1d8
	UnityEngine.Quaternion AdsS2RRot; // 0x1e4
	UnityEngine.Vector3 AdsC2VPos; // 0x1f4
	UnityEngine.Quaternion AdsC2VRot; // 0x200
	SerializableDictionary<System.Int64,UnityEngine.Vector3> HangPoint2RPos; // 0x210
	SerializableDictionary<System.Int64,UnityEngine.Quaternion> HangPoint2Rot; // 0x218
	System.Single[] LocomotionLayerStateTime; // 0x220
	System.Boolean[] LocomotionLayerStateLoop; // 0x228
	System.Single[] AdditiveLayerStateTime; // 0x230
	System.Boolean[] AdditiveLayerStateLoop; // 0x238
	System.Single[] AdditiveSubLayerStateTime; // 0x240
	System.Boolean[] AdditiveSubLayerStateLoop; // 0x248
	System.Single[] OverrideLayerStateTime; // 0x250
	System.Boolean[] OverrideLayerStateLoop; // 0x258
	SerializableDictionary<WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer,WizardGames.Soc.Common.Unity.Shake.CameraShakeData> LocomotionLayerCameraShake; // 0x260
	System.Void .ctor(); // 0x062e1f50
}

// Client.Runtime
class WizardGames.Editor.SkeletonMaskTemplate : UnityEngine.ScriptableObject
{
	UnityEngine.GameObject Go; // 0x18
	System.Boolean IsFp; // 0x20
	SerializableDictionary<System.String,System.Boolean> MaskDict; // 0x28
	System.Void .ctor(); // 0x062e281c
}

// Client.Runtime
class WizardGames.Editor.TpClipSettingCollections : UnityEngine.ScriptableObject
{
	System.Collections.Generic.List<System.String> WeaponClipNames; // 0x18
	WizardGames.Soc.Common.Unity.Character.CharacterAnimationConfig AnimationWarpingConfig; // 0x20
	SerializableDictionary<System.String,WizardGames.Editor.SkeletonDynamicsMask> TpSkeletonDynamicsMasks; // 0x28
	SerializableDictionary<System.String,WizardGames.Editor.SkeletonDynamicsMask> TpSkeletonDynamicsAoMasks; // 0x30
	System.Single LocomotionLerpSpeed; // 0x38
	SerializableDictionary<WizardGames.Editor.ECommonRecoveryType,WizardGames.Editor.ClipRecoveryData> CommonRecoveryData; // 0x40
	SerializableDictionary<WizardGames.Editor.EMantleLogicType,WizardGames.Editor.MantleLogicData> MantleLogicInfo; // 0x48
	System.Void .ctor(); // 0x062e28d0
}

// Client.Runtime
class WizardGames.Editor.TpClipSettingMeta : UnityEngine.ScriptableObject
{
	SerializableDictionary<WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer,WizardGames.Soc.Common.Unity.Character.TpMetaLocomotionWeight> LocomotionLayerWeightCollection; // 0x18
	CommonUnity.Runtime.Animation.AnimKeyDict<WizardGames.Editor.TpClipData> NewClipInfos; // 0x20
	SerializableDictionary<WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer,CommonUnity.Runtime.Character.Resource.IkCurveEntry> LocomotionIkCurves; // 0x28
	SerializableDictionary<WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EAdditiveLayer,CommonUnity.Runtime.Character.Resource.IkCurveEntry> AdditiveIkCurves; // 0x30
	SerializableDictionary<WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EOverrideLayer,CommonUnity.Runtime.Character.Resource.IkCurveEntry> OverrideIkCurves; // 0x38
	SerializableDictionary<WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.ELocomotionLayer,CommonUnity.Runtime.Character.Resource.IkCurveEntry> ScientistLocomotionIkCurves; // 0x40
	SerializableDictionary<WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EAdditiveLayer,CommonUnity.Runtime.Character.Resource.IkCurveEntry> ScientistAdditiveIkCurves; // 0x48
	SerializableDictionary<WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer,CommonUnity.Runtime.Character.Resource.IkCurveEntry> ScientistOverrideIkCurves; // 0x50
	CommonUnity.Runtime.Animation.AnimKeyDict<System.Int32> newTpWpnStringToHash; // 0x58
	SerializableDictionary<System.String,System.String> AudioDict; // 0x60
	CommonUnity.Runtime.Character.NewPhaseKeyContainer NewPhaseKeyContainer; // 0x68
	CommonUnity.Runtime.Character.AimIKDataContainer AimIKDataContainer; // 0x70
	SerializableDictionary<CommonUnity.Runtime.Animation.AnimMoveEnum,CommonUnity.Runtime.Animation.AnimMoveSpeedConf> MoveSpeedConfs; // 0x78
	SerializableDictionary<WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EAdditiveLayer,WizardGames.Soc.Common.Unity.Character.TpMetaAdditiveWeight> AddLayerWeightCollection; // 0x80
	SerializableDictionary<WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EOverrideLayer,WizardGames.Soc.Common.Unity.Character.TpMetaOverrideWeight> OcLayerWeightCollection; // 0x88
	System.Boolean JumpInteriaOverride; // 0x90
	UnityEngine.AnimationCurve JumpProj2ForwardInteriaCurve; // 0x98
	UnityEngine.AnimationCurve JumpProj2RightInteriaCurve; // 0xa0
	System.Single JumpStartInertialTime; // 0xa8
	System.Single JumpKeepInertialTime; // 0xac
	System.Single JumpClearInertialTime; // 0xb0
	WizardGames.Soc.Common.Unity.Character.ClientWeaponBindingData WeaponBindings; // 0xb8
	WizardGames.Soc.Common.Unity.Character.ClientClipValue WeaponClipValue; // 0xc0
	WizardGames.Soc.Common.Unity.Character.ClientClipValue CharClipValue; // 0xc8
	System.Single[] LocomotionLayerStateTime; // 0xd0
	System.Single[] OverrideLayerStateTime; // 0xd8
	System.Boolean[] OverrideLayerStateLoop; // 0xe0
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer> LocomotionSpecial; // 0xe8
	UnityEngine.AnimationCurve TurnInPlaceLeftCurve; // 0xf0
	UnityEngine.AnimationCurve TurnInPlaceRightCurve; // 0xf8
	UnityEngine.AnimationCurve TurnInPlaceCrouchLeftCurve; // 0x100
	UnityEngine.AnimationCurve TurnInPlaceCrouchRightCurve; // 0x108
	UnityEngine.AnimationCurve Stand2CrouchCurve; // 0x110
	UnityEngine.AnimationCurve Stand2CrouchSwapCurve; // 0x118
	UnityEngine.AnimationCurve Crouch2StandCurve; // 0x120
	UnityEngine.AnimationCurve Crouch2StandSwapCurve; // 0x128
	System.Void .ctor(); // 0x062e2af0
}

// Client.Runtime
class WizardGames.Soc.MissileGo : WizardGames.Soc.Common.Unity.Go.BaseMissileGo
{
	UnityEngine.Transform VFXTransform; // 0x78
	WizardGames.Soc.SocClient.Go.KatyushaGo katyusha; // 0x80
	Effect.EffectItemHandle<Effect.TrailRendererEffect> trailFlameEffectHandle; // 0x88
	System.Void .ctor(); // 0x062e3170
	System.Void AudioEvent(System.String audioEventName, System.Boolean stop); // 0x062e31d8
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.MissileEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x062e3330
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x062e35ac
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x062e3734
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x062e37e4
	System.Void Update(); // 0x062e4030
	System.Void Clear(); // 0x062e43ec
	System.Void Remove(); // 0x062e4684
	System.Void UpdateTransform(); // 0x062e4094
	System.Void <SetMainGo>b__9_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x062e46f4
}

// Client.Runtime
class WizardGames.Soc.PlatformAsset.RuntimeAssetPostProcess : System.Object
{
	static System.ValueTuple<Protocol.Load.ILoadProvider,System.Func<System.String,System.Boolean>> func; // 0x0
	static System.Collections.Generic.List<UnityEngine.Renderer> _renderers; // 0x10
	static System.String[] testPrefixs; // 0x18
	static System.Boolean tpmetaMMap; // 0x20
	static System.String ConvertLoadPath(System.String assetPath, Protocol.Load.ILoadProvider provider); // 0x062e493c
	static System.Boolean IsAssetExistByPath(System.String testpath); // 0x062e4cb4
	static System.Boolean ShouldLoadAsset(System.String assetPath); // 0x062e4dc8
	static System.Void LoadAssetComplete(System.String assetPath, UnityEngine.Object& asset); // 0x062e4fa8
	static System.Void .cctor(); // 0x062e543c
}

// Client.Runtime
class WizardGames.Soc.CoverTest.DynamicNavMesh : WizardGames.Soc.Common.Unity.Monster.NavMeshProcess
{
	System.Boolean bInited; // 0xf8
	System.Void StartTest(UnityEngine.Bounds bound); // 0x062e55ac
	System.Void Update(); // 0x062e57d8
	System.Void .ctor(); // 0x062e5854
}

// Client.Runtime
class WizardGames.Soc.SDK.MgrPay : WizardGames.Soc.Common.Manager.MgrBase
{
	SocLogger Log; // 0x18
	System.String LobbyPayServiceRoot; // 0x20
	System.Void OnAccountLogined(); // 0x062e58e0
	System.Void CreateOrder(System.String productId, System.Int32 quantity, System.Action<System.String> success, System.Action error); // 0x062e59fc
	System.Void LaunchPay(System.String urlParams, System.Int32 quantity, System.Single price, System.Action<WizardGames.Soc.SDK.MidasWrapper.EPayResult,System.String> callback); // 0x062e5bf4
	System.Void LaunchPayForPandora(System.String appId, System.String appName, System.String platId, System.String goodsTokenUrl, System.String offerId, System.Action<System.String,System.String,WizardGames.Soc.SDK.MidasWrapper.EPayResult,System.String> callback, System.Int32 quantity, System.String pf); // 0x062e5e20
	System.Void AddCurrency(System.Int32 currencyId, System.Int32 lackNum, System.Action complete); // 0x062e6070
	System.Void .ctor(); // 0x062e613c
}

// Client.Runtime
class WizardGames.Soc.SDK.MgrPay.<>c__DisplayClass3_0 : System.Object
{
	WizardGames.Soc.SDK.MgrPay <>4__this; // 0x10
	System.Int32 quantity; // 0x18
	System.String productId; // 0x20
	System.Action<System.String> success; // 0x28
	System.Action error; // 0x30
	System.Action<SimpleJSON.JSONNode> <>9__1; // 0x38
	System.Action<SimpleJSON.JSONNode> <>9__2; // 0x40
	System.Void .ctor(); // 0x062e5b8c
	System.Void <CreateOrder>b__0(System.Boolean isLogin); // 0x062e6264
	System.Void <CreateOrder>b__1(SimpleJSON.JSONNode respons); // 0x062e6784
	System.Void <CreateOrder>b__2(SimpleJSON.JSONNode errors); // 0x062e6964
}

// Client.Runtime
class WizardGames.Soc.SDK.MgrPay.<>c__DisplayClass4_0 : System.Object
{
	WizardGames.Soc.SDK.MgrPay <>4__this; // 0x10
	System.Action<WizardGames.Soc.SDK.MidasWrapper.EPayResult,System.String> callback; // 0x18
	System.Single price; // 0x20
	System.Int32 quantity; // 0x24
	System.Void .ctor(); // 0x062e5db8
	System.Void <LaunchPay>b__0(WizardGames.Soc.SDK.MidasWrapper.EPayResult result, System.String msg); // 0x062e6a64
}

// Client.Runtime
class WizardGames.Soc.SDK.MgrPay.<>c__DisplayClass5_0 : System.Object
{
	WizardGames.Soc.SDK.MgrPay <>4__this; // 0x10
	System.Action<System.String,System.String,WizardGames.Soc.SDK.MidasWrapper.EPayResult,System.String> callback; // 0x18
	System.String appId; // 0x20
	System.String appName; // 0x28
	System.Void .ctor(); // 0x062e6008
	System.Void <LaunchPayForPandora>b__0(WizardGames.Soc.SDK.MidasWrapper.EPayResult result, System.String msg); // 0x062e6ff0
}

// Client.Runtime
enum WizardGames.Soc.SDK.ServerNodeTag : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SDK.ServerNodeTag Hot = 1;
	static WizardGames.Soc.SDK.ServerNodeTag Recommend = 2;
	static WizardGames.Soc.SDK.ServerNodeTag New = 4;
	static WizardGames.Soc.SDK.ServerNodeTag Limited = 8;
	static WizardGames.Soc.SDK.ServerNodeTag Experience = 16;
	
}

// Client.Runtime
enum WizardGames.Soc.SDK.ServerNodeFlag : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SDK.ServerNodeFlag Heavy = 16;
	static WizardGames.Soc.SDK.ServerNodeFlag Crown = 32;
	static WizardGames.Soc.SDK.ServerNodeFlag Fine = 64;
	static WizardGames.Soc.SDK.ServerNodeFlag Unavailable = 128;
	
}

// Client.Runtime
class WizardGames.Soc.SDK.ServerRoleInfo : System.Object
{
	System.String <OpenId>k__BackingField; // 0x10
	System.UInt64 <LastLoginTime>k__BackingField; // 0x18
	System.UInt64 <RoleId>k__BackingField; // 0x20
	System.Int32 <RoleLevel>k__BackingField; // 0x28
	System.String <RoleName>k__BackingField; // 0x30
	System.String <UserData>k__BackingField; // 0x38
	System.Void set_OpenId(System.String value); // 0x062e7160
	System.Void set_LastLoginTime(System.UInt64 value); // 0x062e71e0
	System.Void set_RoleId(System.UInt64 value); // 0x062e7258
	System.Int32 get_RoleLevel(); // 0x062e72d0
	System.Void set_RoleLevel(System.Int32 value); // 0x062e7334
	System.String get_RoleName(); // 0x062e73ac
	System.Void set_RoleName(System.String value); // 0x062e7410
	System.Void set_UserData(System.String value); // 0x062e7490
	System.Void SetInfo(GCloud.TDirRoleInfo roleInfo); // 0x062e7510
	System.Void .ctor(); // 0x062e7778
}

// Client.Runtime
class WizardGames.Soc.SDK.ServerNode : System.Object
{
	static SocLogger logger; // 0x0
	System.Int32 <Id>k__BackingField; // 0x10
	System.Int32 <ParentId>k__BackingField; // 0x14
	System.String <Name>k__BackingField; // 0x18
	WizardGames.Soc.SDK.ServerNodeTag <Tag>k__BackingField; // 0x20
	WizardGames.Soc.SDK.ServerNodeFlag <Flag>k__BackingField; // 0x24
	System.String <HallServerId>k__BackingField; // 0x28
	System.String <HallApiUrl>k__BackingField; // 0x30
	System.String <HallWsUrl>k__BackingField; // 0x38
	System.UInt64 <InGame_Gameid>k__BackingField; // 0x40
	System.String <InGame_GateSvr>k__BackingField; // 0x48
	System.String <InGame_RealmSvr>k__BackingField; // 0x50
	System.String <InGame_ServerUrl>k__BackingField; // 0x58
	System.Int32 <Attr1>k__BackingField; // 0x60
	System.Int32 <Attr2>k__BackingField; // 0x64
	System.Collections.Generic.List<WizardGames.Soc.SDK.ServerRoleInfo> RoleInfos; // 0x68
	System.Int32 get_Id(); // 0x062e77e0
	System.Void set_Id(System.Int32 value); // 0x062e7844
	System.Void set_ParentId(System.Int32 value); // 0x062e78bc
	System.String get_Name(); // 0x062e7934
	System.Void set_Name(System.String value); // 0x062e7998
	WizardGames.Soc.SDK.ServerNodeTag get_Tag(); // 0x062e7a18
	System.Void set_Tag(WizardGames.Soc.SDK.ServerNodeTag value); // 0x062e7a7c
	WizardGames.Soc.SDK.ServerNodeFlag get_Flag(); // 0x062e7af4
	System.Void set_Flag(WizardGames.Soc.SDK.ServerNodeFlag value); // 0x062e7b58
	System.String get_HallServerId(); // 0x062e7bd0
	System.Void set_HallServerId(System.String value); // 0x062e7c34
	System.String get_HallApiUrl(); // 0x062e7cb4
	System.Void set_HallApiUrl(System.String value); // 0x062e7d18
	System.String get_HallWsUrl(); // 0x062e7d98
	System.Void set_HallWsUrl(System.String value); // 0x062e7dfc
	System.UInt64 get_InGame_Gameid(); // 0x062e7e7c
	System.Void set_InGame_Gameid(System.UInt64 value); // 0x062e7ee0
	System.String get_InGame_GateSvr(); // 0x062e7f58
	System.Void set_InGame_GateSvr(System.String value); // 0x062e7fbc
	System.String get_InGame_RealmSvr(); // 0x062e803c
	System.Void set_InGame_RealmSvr(System.String value); // 0x062e80a0
	System.String get_InGame_ServerUrl(); // 0x062e8120
	System.Void set_InGame_ServerUrl(System.String value); // 0x062e8184
	System.Void set_Attr1(System.Int32 value); // 0x062e8204
	System.Void set_Attr2(System.Int32 value); // 0x062e827c
	System.Void SetInfo(GCloud.LeafNode node); // 0x062e82f4
	System.Collections.Generic.IReadOnlyList<WizardGames.Soc.SDK.ServerRoleInfo> GetRoleInfos(); // 0x062e8e10
	System.Void .ctor(); // 0x062e8e74
	static System.Void .cctor(); // 0x062e8edc
}

// Client.Runtime
enum WizardGames.Soc.SDK.EMSDKPlatformType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SDK.EMSDKPlatformType None = 0;
	static WizardGames.Soc.SDK.EMSDKPlatformType qq_m = 1;
	static WizardGames.Soc.SDK.EMSDKPlatformType WeChat = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SDK.EMSDKLaunchPrivilege : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SDK.EMSDKLaunchPrivilege None = 0;
	static WizardGames.Soc.SDK.EMSDKLaunchPrivilege sq_gamecenter = 1;
	static WizardGames.Soc.SDK.EMSDKLaunchPrivilege WX_GameCenter = 2;
	
}

// Client.Runtime
struct WizardGames.Soc.SDK.SDKLoginWakeUpInfo : System.ValueType
{
	static SocLogger logger; // 0x0
	System.Int64 <OpenId>k__BackingField; // 0x10
	WizardGames.Soc.SDK.EMSDKPlatformType <PlatformType>k__BackingField; // 0x18
	WizardGames.Soc.SDK.EMSDKLaunchPrivilege <LaunchPrivilege>k__BackingField; // 0x1c
	System.String <GameData>k__BackingField; // 0x20
	System.Int64 get_OpenId(); // 0x062e8fb0
	System.Void set_OpenId(System.Int64 value); // 0x062e9014
	WizardGames.Soc.SDK.EMSDKPlatformType get_PlatformType(); // 0x062e908c
	System.Void set_PlatformType(WizardGames.Soc.SDK.EMSDKPlatformType value); // 0x062e90f0
	WizardGames.Soc.SDK.EMSDKLaunchPrivilege get_LaunchPrivilege(); // 0x062e9168
	System.Void set_LaunchPrivilege(WizardGames.Soc.SDK.EMSDKLaunchPrivilege value); // 0x062e91cc
	System.String get_GameData(); // 0x062e9244
	System.Void set_GameData(System.String value); // 0x062e92a8
	System.Void SetMSDKWakeUpInfo(System.String baseRetJson); // 0x062e9328
	static System.Void .cctor(); // 0x062e9c78
}

// Client.Runtime
class WizardGames.Soc.SDK.MgrSDK : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Boolean isLogined; // 0x11
	static SocLogger Log; // 0x0
	System.Int32 timeCount; // 0x14
	static System.Boolean openIngame; // 0x8
	GCloud.ITdir tdir; // 0x18
	System.Boolean tdirInited; // 0x20
	System.Boolean queriedTdirTree; // 0x21
	System.Collections.Generic.List<WizardGames.Soc.SDK.ServerNode> allServerNodeList; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SDK.ServerNode> myServerNodeList; // 0x30
	SimpleJSON.JSONObject idipSettings; // 0x38
	System.UInt32 reLoginMsgBoxId; // 0x40
	System.Void Init(); // 0x055049cc
	System.Void CleanUp(); // 0x06603fa8
	System.Void InitTdir(); // 0x06604084
	System.Void QueryTreeHandler(GCloud.Result result, GCloud.TreeInfo tree); // 0x066046ac
	System.Int32 SortServerNodes(WizardGames.Soc.SDK.ServerNode a, WizardGames.Soc.SDK.ServerNode b); // 0x066054b4
	System.Void QueryLeafHandler(GCloud.Result result, GCloud.NodeWrapper nodeWrapper); // 0x066055d0
	System.Void QueryTdirAllTree(); // 0x0660449c
	System.Collections.Generic.IReadOnlyList<WizardGames.Soc.SDK.ServerNode> GetAllServerNodes(); // 0x06605b80
	System.Int32 GetServersCount(); // 0x06605be4
	System.Collections.Generic.IReadOnlyList<WizardGames.Soc.SDK.ServerNode> GetMyServerNodes(); // 0x06605c60
	WizardGames.Soc.SDK.ServerNode GetCurServer(); // 0x06605cc4
	System.Void SelectServerNode(WizardGames.Soc.SDK.ServerNode serverNode); // 0x066061bc
	System.Void SaveLastLoginGOpenId(System.String gOpenId); // 0x0660665c
	System.Int64 GetLastLoginGOpenId(); // 0x066066f8
	System.Void SaveCurServerId(System.Int32 serverId); // 0x066065c0
	System.Int32 GetCurServerId(); // 0x0660613c
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x066067b8
	System.Void UploadLogCallback(System.String data); // 0x06606918
	System.Void OnSdkLogined(); // 0x06606aa4
	System.Void OnAccountLogined(); // 0x06606bec
	System.Void OnLobbyReconnected(); // 0x06607b8c
	System.Void InitInGameWrapper(); // 0x06607580
	System.Void OnAccountLogout(); // 0x06607d9c
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06607e60
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x06607ec8
	System.Threading.Tasks.Task OnExitWorld(); // 0x06607f74
	System.Void Destroy(); // 0x06607fdc
	System.Void OnFps1UpdateUI(System.Single dt); // 0x06608044
	System.Void LoginSourceChannel(System.String baseRetJson); // 0x06608148
	System.Void CheckLogin(System.Action<System.Boolean> callback, System.Boolean isSlient); // 0x066084c8
	System.Void TryRelogin(); // 0x06608688
	System.Void TryReAutoLogin(); // 0x06607c5c
	System.Void UpdateLogin(); // 0x0660882c
	System.Void DoInGameChatGroupHeartbeat(); // 0x06608d50
	System.Void StartDeleteAccount(); // 0x06608dd8
	System.Void CheckDeleteAccount(); // 0x066091fc
	System.Void DeleteAccount(); // 0x066096f4
	System.Void RevokeAuth(); // 0x06609858
	SimpleJSON.JSONNode GetIDIPSetting(System.String serverId); // 0x06609c88
	System.Void .ctor(); // 0x06609d54
	static System.Void .cctor(); // 0x06609e38
	System.Void <TryRelogin>b__45_0(System.Int32 methodId, System.String loginRetStr); // 0x06609f0c
	System.Void <TryReAutoLogin>b__46_0(System.Int32 methodId, System.String loginRetStr); // 0x0660a1d0
}

// Client.Runtime
class WizardGames.Soc.SDK.MgrSDK.<>c : System.Object
{
	static WizardGames.Soc.SDK.MgrSDK.<>c <>9; // 0x0
	static System.Action <>9__44_1; // 0x8
	static System.Action <>9__46_1; // 0x10
	static System.Action <>9__51_1; // 0x18
	static System.Action<System.Int32,System.String> <>9__51_0; // 0x20
	static System.Action <>9__53_0; // 0x28
	static System.Void .cctor(); // 0x0660a898
	System.Void .ctor(); // 0x0660a8fc
	System.Void <CheckLogin>b__44_1(); // 0x0660a964
	System.Void <TryReAutoLogin>b__46_1(); // 0x0660aa10
	System.Void <DeleteAccount>b__51_0(System.Int32 code, System.String message); // 0x0660aabc
	System.Void <DeleteAccount>b__51_1(); // 0x0660ae6c
	System.Void <RevokeAuth>b__53_0(); // 0x0660af18
}

// Client.Runtime
class WizardGames.Soc.SDK.MgrSDK.<>c__DisplayClass44_0 : System.Object
{
	System.Boolean isSlient; // 0x10
	WizardGames.Soc.SDK.MgrSDK <>4__this; // 0x18
	System.Action<System.Boolean> callback; // 0x20
	System.Void .ctor(); // 0x06608620
	System.Void <CheckLogin>b__0(System.Boolean isLogin); // 0x0660afc4
}

// Client.Runtime
class WizardGames.Soc.SDK.ClientMSDKProcessor : System.Object
{
	static System.Boolean IsSwitchAccount; // 0x0
	static System.Void LoginProcess(System.Int32 method, System.String resJson); // 0x0660b4cc
	static System.Void DoSdkLogin(WizardGames.Soc.SDK.ClientMSDKProcessor.LoginRetSlim res); // 0x0660bd14
	static System.Void OnAutoLogin(WizardGames.Soc.SDK.ClientMSDKProcessor.LoginRetSlim res); // 0x0660b774
	static System.Void OnLogin(WizardGames.Soc.SDK.ClientMSDKProcessor.LoginRetSlim res); // 0x0660b948
	static System.Int32 GetAnnouncementRegion(); // 0x0660c404
	static System.String GetAnnouncementLan(); // 0x0660c460
	static System.Boolean IsEmulator(); // 0x0660befc
}

// Client.Runtime
class WizardGames.Soc.SDK.ClientMSDKProcessor.LoginRetSlim : System.Object
{
	System.String RawJson; // 0x10
	System.Int32 RetCode; // 0x18
	System.String OpenId; // 0x20
	System.String Channel; // 0x28
	System.String PictureUrl; // 0x30
	System.String UserName; // 0x38
	System.String ChannelId; // 0x40
	
}

// Client.Runtime
class WizardGames.Soc.SDK.ClientMSDKProcessor.<>c : System.Object
{
	static WizardGames.Soc.SDK.ClientMSDKProcessor.<>c <>9; // 0x0
	static System.Action <>9__10_0; // 0x8
	static System.Void .cctor(); // 0x0660c4d0
	System.Void .ctor(); // 0x0660c534
	System.Void <IsEmulator>b__10_0(); // 0x0660c59c
}

// Client.Runtime
class WizardGames.Soc.SDK.WeGameSDKProcessor : System.Object
{
	
	static System.Void LoginProcess(System.Int32 method, System.String resJson); // 0x0660c624
	static System.Void OnLogin(WizardGames.Soc.SDK.WeGameSDKProcessor.LoginRetSlim res); // 0x0660c870
	static System.Void DoSdkLoin(WizardGames.Soc.SDK.WeGameSDKProcessor.LoginRetSlim res); // 0x0660c920
}

// Client.Runtime
class WizardGames.Soc.SDK.WeGameSDKProcessor.LoginRetSlim : System.Object
{
	System.String RawJson; // 0x10
	System.Int32 RetCode; // 0x18
	System.String OpenId; // 0x20
	System.String Channel; // 0x28
	System.String PictureUrl; // 0x30
	System.String UserName; // 0x38
	System.String ChannelId; // 0x40
	
}

// Client.Runtime
class WizardGames.Soc.Client.Monster.MonsterConstParamClient : System.Object
{
	static System.Boolean EnableRagdoll; // 0x0
	static WizardGames.Soc.Client.Monster.MonsterConstParamClient.LineUpdateMode TurretLineMode; // 0x4
	static System.Int32 LoadAssetStep_StartCreateGo; // 0x8
	static System.Int32 LoadAssetStep_StartSpawn; // 0xc
	static System.Int32 LoadAssetStep_CompleteSpawn; // 0x10
	static System.Int32 LoadAssetStep_PartLoadFinish; // 0x14
	static System.Int32 LoadAssetStep_RemoveGo; // 0x18
	static System.Single CancelPreloadThreshold; // 0x1c
	static UnityEngine.Vector3 CollierCenterNormal; // 0x20
	static UnityEngine.Vector3 CollierSizeNormal; // 0x2c
	static UnityEngine.Vector3 CollierCenterLayer1; // 0x38
	static UnityEngine.Vector3 CollierSizeLayer1; // 0x44
	static System.Void .cctor(); // 0x0660cb08
}

// Client.Runtime
enum WizardGames.Soc.Client.Monster.MonsterConstParamClient.LineUpdateMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Client.Monster.MonsterConstParamClient.LineUpdateMode Fps1 = 0;
	static WizardGames.Soc.Client.Monster.MonsterConstParamClient.LineUpdateMode Fps2 = 1;
	static WizardGames.Soc.Client.Monster.MonsterConstParamClient.LineUpdateMode Fps10 = 2;
	static WizardGames.Soc.Client.Monster.MonsterConstParamClient.LineUpdateMode Fps30 = 3;
	static WizardGames.Soc.Client.Monster.MonsterConstParamClient.LineUpdateMode Unlimited = 4;
	
}

// Client.Runtime
class WizardGames.Soc.Client.Monster.Anim.AnimalAnimation.AnimalAnimationParameters : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void RenderUpdate(WizardGames.Soc.Common.Unity.Monster.Animation.AnimalAnimatorContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersAnimal& animParams); // 0x0660cbe4
	static System.Void AnimalIdleAnim(WizardGames.Soc.Common.Entity.MonsterEntity entity, WizardGames.Soc.Common.Unity.Monster.Animation.AnimalAnimatorContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersAnimal& animParams); // 0x0660ce78
	static System.Void UpdateBattleMoveBlendParams(WizardGames.Soc.Common.Unity.Monster.Animation.AnimalAnimatorContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersAnimal& animParams); // 0x0660d294
	static UnityEngine.Vector2 GetLocalMoveDir(WizardGames.Soc.Common.Entity.MonsterEntity entity, WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime runtime); // 0x0660d478
	static System.Void ClampSpeed(WizardGames.Soc.Common.Entity.MonsterEntity entity, System.Single& speed, System.Single& speedFactor); // 0x0660d610
	static System.Void .cctor(); // 0x0660d804
}

// Client.Runtime
class WizardGames.Soc.Client.Login.LoginChannel : System.Object
{
	static System.String MSDKChannel; // 0x0
	static System.String ChannelId; // 0x8
	static System.String Channel; // 0x10
	static System.Void .cctor(); // 0x0660d8d8
}

// Client.Runtime
class WizardGames.Soc.Client.Lobby.LobbyScenePrefabController : UnityEngine.MonoBehaviour
{
	UnityEngine.GameObject[] prefabs; // 0x30
	System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject> prefabDict; // 0x38
	System.Void Awake(); // 0x0660d978
	System.Void SetPrefabActiveByName(System.String name, System.Boolean show, System.Boolean isUseLowObj); // 0x0660da80
	System.Void .ctor(); // 0x0660de74
}

// Client.Runtime
enum WizardGames.Soc.Client.Lobby.ELobbyStep : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Client.Lobby.ELobbyStep Home = 0;
	static WizardGames.Soc.Client.Lobby.ELobbyStep Team = 1;
	static WizardGames.Soc.Client.Lobby.ELobbyStep GameStart = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Client.Lobby.LobbyStepController : UnityEngine.MonoBehaviour
{
	static WizardGames.Soc.Client.Lobby.LobbyStepController <Instance>k__BackingField; // 0x0
	WizardGames.Soc.Client.Lobby.LobbyStepController.StepInfo[] Steps; // 0x30
	System.Int32 curIndex; // 0x38
	UnityEngine.Camera stageCamera; // 0x40
	WizardGames.Soc.Client.Lobby.LobbyScenePrefabController lobbyScenePrefabController; // 0x48
	static WizardGames.Soc.Client.Lobby.LobbyStepController get_Instance(); // 0x0660df28
	static System.Void set_Instance(WizardGames.Soc.Client.Lobby.LobbyStepController value); // 0x0660dfa0
	System.Void Awake(); // 0x0660e02c
	System.Void Start(); // 0x0660e1e0
	System.Void OnDestroy(); // 0x0660e3cc
	UnityEngine.Camera GetStageCamera(); // 0x0660e498
	System.Void ToStep(System.Int32 index); // 0x0660e248
	System.Void SetScenePrefabActive(System.Int32 index); // 0x0660e58c
	System.Void PreStep(); // 0x0660e78c
	System.Void NextStep(); // 0x0660e808
	System.Void JumpStep(WizardGames.Soc.Client.Lobby.ELobbyStep step); // 0x0660e89c
	System.Int32 GetCurStepIndex(); // 0x0660e918
	System.Boolean IsGameStartStep(); // 0x0660e97c
	System.Collections.Generic.List<T> GetStepsOfType<T>(); // 0x052af1f0
	System.Void .ctor(); // 0x0660e9e8
}

// Client.Runtime
class WizardGames.Soc.Client.Lobby.LobbyStepController.StepInfo : System.Object
{
	UnityEngine.GameObject Obj; // 0x10
	WizardGames.Soc.Client.Lobby.ELobbyStep Step; // 0x18
	UnityEngine.Events.UnityEvent ExtraAction; // 0x20
	System.Void .ctor(); // 0x0660ea58
}

// Client.Runtime
class WizardGames.Soc.Client.Lobby.LobbyStepTimeline : UnityEngine.MonoBehaviour
{
	UnityEngine.GameObject playerCaptainRoot; // 0x30
	UnityEngine.AnimationClip[] maleTurnBackAnimationClips; // 0x38
	UnityEngine.AnimationClip[] femaleTurnBackAnimationClips; // 0x40
	UnityEngine.AnimationClip[] maleBoatingAnimationClips; // 0x48
	static SocLogger Log; // 0x0
	UnityEngine.Playables.PlayableDirector comDirector; // 0x50
	System.Collections.Generic.Dictionary<System.String,UnityEngine.Playables.PlayableBinding> curBinding; // 0x58
	UnityEngine.Timeline.AnimationTrack[] turnBackAnimationTracks; // 0x60
	UnityEngine.Timeline.AnimationTrack[] boatingAnimationTracks; // 0x68
	System.Void Awake(); // 0x0660eac0
	System.Void OnEnable(); // 0x0660f058
	System.Boolean HasTrack(System.String trackName); // 0x0660f1d4
	System.Void ChangeBinding(System.String trackName, UnityEngine.Object objNewBind, System.Int32 index, System.Boolean useBoating, System.Boolean useFemaleAnimation); // 0x0660f270
	System.Void ChangeBoatingAnimationClips(UnityEngine.Timeline.AnimationTrack track, System.Int32 index, System.Boolean useFemaleAnimation); // 0x0660f628
	System.Void ChangeTurnBackAnimationClips(UnityEngine.Timeline.AnimationTrack track, System.Int32 index, System.Boolean useFemaleAnimation); // 0x0660fc9c
	System.Void TriggerGameStart(); // 0x06610334
	System.Void CaptainModelMove(); // 0x06610504
	System.Void .ctor(); // 0x06610614
	static System.Void .cctor(); // 0x066106c8
}

// Client.Runtime
class WizardGames.Soc.Client.Lobby.LobbyStepTrackPoint : UnityEngine.MonoBehaviour
{
	Cinemachine.CinemachineVirtualCamera virtualCam; // 0x30
	System.Void OnEnable(); // 0x0661079c
	System.Void .ctor(); // 0x0661089c
}

// Client.Runtime
class WizardGames.Soc.SocWorld.Share.Ugc.UgcPropertyInfo : System.Object
{
	System.Int32 PropertyId; // 0x10
	System.String Name; // 0x18
	System.String Group; // 0x20
	System.Type PropertyType; // 0x28
	System.Single DefaultValue; // 0x30
	System.Single[] ValueRange; // 0x38
	System.String[] Options; // 0x40
	System.Void .ctor(); // 0x06610904
}

// Client.Runtime
class WizardGames.Soc.SocWorld.Share.Ugc.UgcPropertyConfigs : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.SocWorld.Share.Ugc.UgcPropertyInfo>> UgcPropertyInfoDic; // 0x0
	static System.Void .cctor(); // 0x0661096c
	static System.Void RegisterProperty(System.Int64 id, WizardGames.Soc.SocWorld.Share.Ugc.UgcPropertyInfo info); // 0x06610c48
	static System.Collections.Generic.List<WizardGames.Soc.SocWorld.Share.Ugc.UgcPropertyInfo> GetProperties(System.Int64 id); // 0x06610e88
}

// Client.Runtime
class WizardGames.Soc.SocWorld.Share.Utility.GameTimeParamHolder : System.Object
{
	WizardGames.Soc.Common.Data.global.GameTimeConfig gameTimeConfig; // 0x10
	WizardGames.Soc.Common.SimpleCustom.GameTimeParam gameTimeParam; // 0x18
	System.Int32 GameMinuteLengthMs; // 0x20
	System.Int32 get_DayLengthInSeconds(); // 0x06610fa0
	System.Int32 get_SunriseTime(); // 0x06611020
	System.Int32 get_DayTime(); // 0x066110a0
	System.Int32 get_SunsetTime(); // 0x06611120
	System.Int32 get_NightTime(); // 0x066111a0
	System.Int32 get_StartTime(); // 0x06611220
	System.Void .ctor(WizardGames.Soc.Common.Data.global.GameTimeConfig tbl); // 0x066112a0
	System.Void SetCustomGameTimeParam(WizardGames.Soc.Common.SimpleCustom.GameTimeParam param); // 0x066113d0
}

// Client.Runtime
class WizardGames.Soc.SocWorld.Share.Utility.GameTimeUtil : System.Object
{
	
	static System.Int32 GetGameMinuteLengthMs(WizardGames.Soc.SocWorld.Share.Utility.GameTimeParamHolder paramHolder); // 0x0661133c
	static System.Int32 GetDaySecondsFromLogicMs(System.Int64 sinceLogicStartMs, WizardGames.Soc.SocWorld.Share.Utility.GameTimeParamHolder paramHolder); // 0x06611460
	static WizardGames.Soc.Common.Data.GameTimeStage GetGameTimeStage(WizardGames.Soc.SocWorld.Share.Utility.GameTimeParamHolder paramHolder, System.Int64 logicSec); // 0x0661152c
}

// Client.Runtime
class WizardGames.Soc.SocLogic.Go.AirDropPlaneGo : WizardGames.Soc.Common.Unity.Go.BaseAirDropPlaneGo
{
	static SocLogger <log>k__BackingField; // 0x0
	System.Int64 lastPosChangeTime; // 0x70
	System.Int64 posChangeEventHandle; // 0x78
	UnityEngine.Transform[] wings; // 0x80
	Effect.FollowEffect[] trailEffect; // 0x88
	System.Int64 timerID; // 0x90
	System.Boolean isPlayingSound; // 0x98
	System.Single soundRange; // 0x9c
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.AirDropPlaneEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0661165c
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x06611770
	System.Void SetMainGo(UnityEngine.GameObject obj); // 0x066118fc
	System.Void SpawnTrail(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x06611d48
	System.Void PlaySound(); // 0x06612244
	System.Void StopSound(); // 0x0661238c
	System.Void Remove(); // 0x066124e0
	System.Void Clear(); // 0x06612550
	System.Boolean PlayerInRange(); // 0x066128e4
	System.Void OnPosChanged(WizardGames.Soc.Share.Framework.PositionChangeEvent e); // 0x06612bac
	System.Void .ctor(); // 0x06612cf4
	static System.Void .cctor(); // 0x06612d6c
}

// Client.Runtime
class WizardGames.Soc.SocLogic.Config.AirDropCfg : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.Procedural.SpawnFilter filter; // 0x30
	System.Void Awake(); // 0x06612e40
	System.Void .ctor(); // 0x06612ecc
}

// Client.Runtime
class WizardGames.Soc.Share.Telemetry.TelemetryBase : System.Object
{
	static SocLogger logger; // 0x0
	System.String TestLoot(System.ArraySegment<System.String> cmdInput); // 0x06612f34
	System.String TestDoRepair(System.ArraySegment<System.String> cmdInput); // 0x06612fd4
	System.String UseItem(System.ArraySegment<System.String> cmdInput); // 0x06613074
	System.String MoveItem(System.ArraySegment<System.String> cmdInput); // 0x06613114
	System.String SendTeamChat(System.ArraySegment<System.String> cmdInput); // 0x066131b4
	System.String SendUdpPacket(System.ArraySegment<System.String> cmdInput); // 0x06613254
	System.String SetGameTime(System.ArraySegment<System.String> cmdInput); // 0x066132f4
	System.String GetMyEntityLocalProp(System.ArraySegment<System.String> cmdInput); // 0x06613394
	System.String SendElectricCmd(System.ArraySegment<System.String> cmdInput); // 0x06613434
	System.String PrintBriefEntities(System.ArraySegment<System.String> cmdInput); // 0x066134d4
	System.String GetBriefEntityProperty(System.ArraySegment<System.String> cmdInput); // 0x06613574
	System.String ShowGoEntityEqual(System.ArraySegment<System.String> cmdInput); // 0x06613614
	System.String Disconnect(System.ArraySegment<System.String> cmdInput); // 0x066136b4
	System.String SwitchReconnect(System.ArraySegment<System.String> cmdInput); // 0x06613754
	System.String SendQuickTeamChat(System.ArraySegment<System.String> cmdInput); // 0x066137f4
	System.String StopMixing(System.ArraySegment<System.String> cmdInput); // 0x06613894
	System.String GetDepth(System.ArraySegment<System.String> cmdInput); // 0x06613934
	System.String List(System.ArraySegment<System.String> cmdInput); // 0x066139d4
	System.String Find(System.ArraySegment<System.String> cmdInput); // 0x06613a74
	System.String StartNetTest(System.ArraySegment<System.String> cmdInput); // 0x06613b14
	System.String StartNetTestToSimulator(System.ArraySegment<System.String> cmdInput); // 0x06613bb4
	System.String ClientNetStat(System.ArraySegment<System.String> cmdInput); // 0x06613c54
	System.String NetTestStat(System.ArraySegment<System.String> cmdInput); // 0x06613cf4
	System.String DropReceive(System.ArraySegment<System.String> cmdInput); // 0x06613d94
	System.String ChangeReceive(System.ArraySegment<System.String> cmdInput); // 0x06613e34
	System.String DropSend(System.ArraySegment<System.String> cmdInput); // 0x06613ed4
	System.String TestGetDisplayInfo(System.ArraySegment<System.String> cmdInput); // 0x06613f74
	System.String TestClientTimer(System.ArraySegment<System.String> cmdInput); // 0x06614014
	System.String PlayerDebug(System.ArraySegment<System.String> cmdInput); // 0x066140b4
	System.String ClientPlayerStateLog(System.ArraySegment<System.String> cmdInput); // 0x06614154
	System.String AddLobbyItem(System.ArraySegment<System.String> cmdInput); // 0x066141f4
	System.String InstAsset(System.ArraySegment<System.String> cmdInput); // 0x06614294
	System.String ClearAsset(System.ArraySegment<System.String> cmdInput); // 0x06614334
	System.String GetOneOutside(System.ArraySegment<System.String> cmdInput); // 0x066143d4
	System.String TestRpcParam(System.ArraySegment<System.String> cmdInput); // 0x06614474
	System.String MoveItemToPath(System.ArraySegment<System.String> cmdInput); // 0x06614514
	System.String ReadRecord(System.ArraySegment<System.String> cmdInput); // 0x066145b4
	System.String ShowRecentRpc(System.ArraySegment<System.String> cmdInput); // 0x06614654
	System.String ShowEntityRecord(System.ArraySegment<System.String> cmdInput); // 0x066146f4
	System.String PrintRoutingTable(System.ArraySegment<System.String> cmdInput); // 0x06614794
	System.String TeamChangeDuty(System.ArraySegment<System.String> cmdInput); // 0x06614834
	System.String RemoveEntity(System.ArraySegment<System.String> cmdInput); // 0x066148d4
	System.String PlayResLoadSuccesss(System.ArraySegment<System.String> cmdInput); // 0x06614974
	System.String PlayLoseAllToolCupboards(System.ArraySegment<System.String> cmdInput); // 0x06614a14
	System.String PrintEvent(System.ArraySegment<System.String> cmdInput); // 0x06614ab4
	System.String GetEntitiesInRange(System.ArraySegment<System.String> cmdInput); // 0x06614b54
	System.String GetNearestRoadPoint(System.ArraySegment<System.String> cmdInput); // 0x06614bf4
	System.String ProfileStart(System.ArraySegment<System.String> cmdInput); // 0x06614c94
	System.String ProfileEnd(System.ArraySegment<System.String> cmdInput); // 0x06614d34
	System.String LootingCheckWall(System.ArraySegment<System.String> cmdInput); // 0x06614dd4
	System.String MFSettleClose(System.ArraySegment<System.String> cmdInput); // 0x06614e74
	System.String MFSettleOpen(System.ArraySegment<System.String> cmdInput); // 0x06614f14
	System.String SetIndicator(System.ArraySegment<System.String> cmdInput); // 0x06614fb4
	System.String TestSetAuxSystemCost(System.ArraySegment<System.String> cmdInput); // 0x06615054
	System.String TestGetAuxSystemCost(System.ArraySegment<System.String> cmdInput); // 0x066150f4
	System.String TestSetAuxSystemBudgetNum(System.ArraySegment<System.String> cmdInput); // 0x06615194
	System.String TestGetAuxSystemBudgetNum(System.ArraySegment<System.String> cmdInput); // 0x06615234
	System.String opensystemBudgetTest(System.ArraySegment<System.String> cmdInput); // 0x066152d4
	System.String opensystemQueueTest(System.ArraySegment<System.String> cmdInput); // 0x06615374
	System.String SetSystemShowLog(System.ArraySegment<System.String> cmdInput); // 0x06615414
	System.String ShowBehaviorTreeCount(System.ArraySegment<System.String> cmdInput); // 0x066154b4
	System.String TestShowMonsterTypeCount(System.ArraySegment<System.String> cmdInput); // 0x06615554
	System.String TestSetFindTargetMainThread(System.ArraySegment<System.String> cmdInput); // 0x066155f4
	System.String TestShowBullet(System.ArraySegment<System.String> cmdInput); // 0x06615694
	System.String SetEntityInvincible(System.ArraySegment<System.String> cmdInput); // 0x06615734
	System.String PlayerInvincible(System.ArraySegment<System.String> cmdInput); // 0x066157d4
	System.String ShowPhysicsGO(System.ArraySegment<System.String> cmdInput); // 0x06615874
	System.String HidePhysicsGO(System.ArraySegment<System.String> cmdInput); // 0x06615914
	System.String DebugPCInfos(System.ArraySegment<System.String> cmdInput); // 0x066159b4
	System.String StateMachineUseThread(System.ArraySegment<System.String> cmdInput); // 0x06615a54
	System.String CreateRobot(System.ArraySegment<System.String> cmdInput); // 0x06615af4
	System.String RunRobot(System.ArraySegment<System.String> cmdInput); // 0x06615b94
	System.String StateMachineThreadCount(System.ArraySegment<System.String> cmdInput); // 0x06615c34
	System.String GetPlayerPos(System.ArraySegment<System.String> cmdInput); // 0x06615cd4
	System.String GetMonsterPos(System.ArraySegment<System.String> cmdInput); // 0x06615d74
	System.String KillMonster(System.ArraySegment<System.String> cmdInput); // 0x06615e14
	System.String SwitchProfile(System.ArraySegment<System.String> cmdInput); // 0x06615eb4
	System.String ToggleAI(System.ArraySegment<System.String> cmdInput); // 0x06615f54
	System.String SimulatorPlayerDebug(System.ArraySegment<System.String> cmdInput); // 0x06615ff4
	System.String SimulatorPlayerStateLog(System.ArraySegment<System.String> cmdInput); // 0x06616094
	System.String HorseAuthorityCheck(System.ArraySegment<System.String> cmdInput); // 0x06616134
	System.String UnityCrash(System.ArraySegment<System.String> cmdInput); // 0x066161d4
	System.String ShowOutpostPoints(System.ArraySegment<System.String> cmdInput); // 0x06616274
	System.String EndlessLoop(System.ArraySegment<System.String> cmdInput); // 0x06616314
	System.String PrintTrigger(System.ArraySegment<System.String> cmdInput); // 0x066163b4
	System.String DebugGunTrap(System.ArraySegment<System.String> cmdInput); // 0x06616454
	System.String GetActiveMonsterEntityIds(System.ArraySegment<System.String> cmdInput); // 0x066164f4
	System.String SetAuxSystemEnable(System.ArraySegment<System.String> cmdInput); // 0x06616594
	System.String GetBattleMonsterEntityIds(System.ArraySegment<System.String> cmdInput); // 0x06616634
	System.String GetActiveMonsterCount(System.ArraySegment<System.String> cmdInput); // 0x066166d4
	System.String SetPatrolRoamPerConfig(System.ArraySegment<System.String> cmdInput); // 0x06616774
	System.String SetMaxNotPatrolRoamConfig(System.ArraySegment<System.String> cmdInput); // 0x06616814
	System.String SetMonsterVisionBatch(System.ArraySegment<System.String> cmdInput); // 0x066168b4
	System.String SetAIMoveEnable(System.ArraySegment<System.String> cmdInput); // 0x06616954
	static System.Collections.Generic.List<WizardGames.Soc.Share.Framework.EntityBase> GetEntities(System.Int32 skip, System.Int32 limit, System.String entityTypeName, System.Int64 templateId); // 0x066169f4
	static System.Object TryGetCustomDictValue(System.Type objType, System.Object obj, System.String index); // 0x06617014
	static System.Object TryGetDictValue(System.Type objType, System.Object obj, System.String index); // 0x06617904
	System.String GetPropValueRecursive(System.Object obj, System.ArraySegment<System.String> fieldSplit, System.Int32 cursor); // 0x06618380
	System.String GetProperty(System.ArraySegment<System.String> cmdInput); // 0x06619454
	System.String SetProperty(System.ArraySegment<System.String> cmdInput); // 0x066194f4
	System.String SetEntityProperty(System.ArraySegment<System.String> cmdInput); // 0x06619594
	System.String SetEntityProperty2(System.ArraySegment<System.String> cmdInput); // 0x0661a908
	System.String GetPropInner(System.Object entity, System.String propPath); // 0x0661a990
	System.String GetEntityProperty(System.ArraySegment<System.String> cmdInput); // 0x0661b6c0
	static System.String[] CheckEntityFieldNames(System.String[] filelds); // 0x0661996c
	System.String GetEntityProperty2(System.ArraySegment<System.String> cmdInput); // 0x0661bc80
	System.String GraphNodePrint(System.ArraySegment<System.String> cmdInput); // 0x0661bcfc
	System.String NodePrint(System.ArraySegment<System.String> cmdInput); // 0x0661bebc
	System.String DebugGetEntities(System.ArraySegment<System.String> cmdInput); // 0x0661cb50
	System.String EntityStat(System.ArraySegment<System.String> cmdInput); // 0x0661d14c
	System.String PrintEntityDistance(System.ArraySegment<System.String> cmdInput); // 0x0661da14
	System.String ContinuousPrintEntityDistance(System.ArraySegment<System.String> cmdInput); // 0x0661dab4
	System.String ShowTime(System.ArraySegment<System.String> cmdInput); // 0x0661db54
	System.String FocusMonster(System.ArraySegment<System.String> cmdInput); // 0x0661dbf4
	System.String DecodeOwnClient(System.ArraySegment<System.String> cmdInput); // 0x0661dc94
	System.String DecodeOtherClient(System.ArraySegment<System.String> cmdInput); // 0x0661dd34
	System.String PropPoolStat(System.ArraySegment<System.String> cmdInput); // 0x0661ddd4
	System.String GetTimerTopList(System.ArraySegment<System.String> cmdInput); // 0x0661e63c
	System.String GetRpcExecInfo(System.ArraySegment<System.String> cmdInput); // 0x0661e6d0
	System.String ServerTime(System.ArraySegment<System.String> cmdInput); // 0x0661e764
	System.String WildInfo(System.ArraySegment<System.String> cmdInput); // 0x0661e87c
	System.String TerrInfo(System.ArraySegment<System.String> cmdInput); // 0x0661ee30
	System.String FindInChargeTerritory(System.ArraySegment<System.String> cmdInput); // 0x0661f504
	static System.Void Assert(System.Boolean condition, System.String message); // 0x0661f5a4
	System.String GetPlayerPlunderReport(System.ArraySegment<System.String> cmdInput); // 0x0661f6b0
	System.String RemoveItemShort(System.ArraySegment<System.String> cmdInput); // 0x0661fa58
	System.String RemoveElement(System.ArraySegment<System.String> cmdInput); // 0x0661fad4
	System.String ClearContainerShort(System.ArraySegment<System.String> cmdInput); // 0x06620914
	System.String ClearContainer(System.ArraySegment<System.String> cmdInput); // 0x06620990
	System.String PoolStat(System.ArraySegment<System.String> cmdInput); // 0x06620ea8
	static System.Object ConvertValue(System.Type type, System.String val); // 0x06620f48
	static System.Object ConvertValue(System.Type type, System.ArraySegment<System.String> valArgs); // 0x06621068
	static System.Object CreateInstanceFromType(System.Type targetType, System.ArraySegment<System.String> valArgs); // 0x0662144c
	System.Object GetRootObj(System.String rootName); // 0x0661fe28
	static System.String SetPropValue(System.Object obj, System.ArraySegment<System.String> fieldSplit, System.ArraySegment<System.String> valArgs); // 0x06619ac4
	static System.Object GetMostInnerObjectRecursive(System.Object obj, System.ArraySegment<System.String> fieldSplit, System.Int32 cursor); // 0x0662231c
	static System.Object GetLastObjectRecursive(System.Object obj, System.ArraySegment<System.String> fieldSplit, System.Int32 cursor); // 0x06622984
	static System.Object GetObjPropValue(System.Object obj, System.String propName); // 0x066224e8
	static System.String RemoveElementByPath(System.Object obj, System.ArraySegment<System.String> filedPath); // 0x06620064
	static System.String ClearContainer(System.Object obj, System.ArraySegment<System.String> filedPath); // 0x06620ce4
	System.String ServerMode(System.ArraySegment<System.String> cmdInput); // 0x06622b4c
	System.String ListServers(System.ArraySegment<System.String> cmdInput); // 0x06622bec
	System.String HelpOfCommands(System.ArraySegment<System.String> cmdInput); // 0x06622c8c
	System.String PrintErrorLog(System.ArraySegment<System.String> cmdInput); // 0x06622d2c
	System.String GetPlayers(System.ArraySegment<System.String> cmdInput); // 0x06622dcc
	System.String AddItem(System.ArraySegment<System.String> cmdInput); // 0x06622e6c
	System.String AddItemById(System.ArraySegment<System.String> cmdInput); // 0x06622f0c
	System.String AddItemByName(System.ArraySegment<System.String> cmdInput); // 0x06622fac
	System.String ConsumeItemById(System.ArraySegment<System.String> cmdInput); // 0x0662304c
	System.String TechnologyUnlock(System.ArraySegment<System.String> cmdInput); // 0x066230ec
	System.String CommonComposeStart(System.ArraySegment<System.String> cmdInput); // 0x0662318c
	System.String CommonComposeCancel(System.ArraySegment<System.String> cmdInput); // 0x0662322c
	System.String Drop(System.ArraySegment<System.String> cmdInput); // 0x066232cc
	System.String ResearchBenchOp(System.ArraySegment<System.String> cmdInput); // 0x0662336c
	System.String Save(System.ArraySegment<System.String> cmdInput); // 0x0662340c
	System.String ServerNetStat(System.ArraySegment<System.String> cmdInput); // 0x066234ac
	System.String ServerNetStatDelta(System.ArraySegment<System.String> cmdInput); // 0x0662354c
	System.String ReloadExcel(System.ArraySegment<System.String> cmdInput); // 0x066235ec
	System.String SetEntityPosition(System.ArraySegment<System.String> cmdInput); // 0x0662368c
	System.String SetMonsterLogEnabled(System.ArraySegment<System.String> cmdInput); // 0x0662372c
	System.String SetGM(System.ArraySegment<System.String> cmdInput); // 0x066237cc
	System.String SetUserGmEnable(System.ArraySegment<System.String> cmdInput); // 0x0662386c
	System.String SkipSimulatorCheck(System.ArraySegment<System.String> cmdInput); // 0x0662390c
	System.String SaveAndStop(System.ArraySegment<System.String> cmdInput); // 0x066239ac
	System.String LookupEntityTimer(System.ArraySegment<System.String> cmdInput); // 0x06623a4c
	System.String DeleteSpawnRule(System.ArraySegment<System.String> cmdInput); // 0x06623aec
	System.String DeleteSpawnGroup(System.ArraySegment<System.String> cmdInput); // 0x06623b8c
	System.String SpawnRuleStatCount(System.ArraySegment<System.String> cmdInput); // 0x06623c2c
	System.String SpawnRuleRecordInfo(System.ArraySegment<System.String> cmdInput); // 0x06623ccc
	System.String SpawnPrintTopoInfo(System.ArraySegment<System.String> cmdInput); // 0x06623d6c
	System.String SpawnCheckGeneraterFilter(System.ArraySegment<System.String> cmdInput); // 0x06623e0c
	System.String SpawnPrintMapTopoInfo(System.ArraySegment<System.String> cmdInput); // 0x06623eac
	System.String SpawnResetRule(System.ArraySegment<System.String> cmdInput); // 0x06623f4c
	System.String SpawnPrintJunkpileInfo(System.ArraySegment<System.String> cmdInput); // 0x06623fec
	System.String SpawnCheckJunkpileInfo(System.ArraySegment<System.String> cmdInput); // 0x0662408c
	System.String SpawnPrintGroupInfo(System.ArraySegment<System.String> cmdInput); // 0x0662412c
	System.String ResetSpawnGroup(System.ArraySegment<System.String> cmdInput); // 0x066241cc
	System.String TestOCTree(System.ArraySegment<System.String> cmdInput); // 0x0662426c
	System.String TestMinganci(System.ArraySegment<System.String> cmdInput); // 0x0662430c
	System.String AcceptTask(System.ArraySegment<System.String> cmdInput); // 0x066243ac
	System.String CompleteTask(System.ArraySegment<System.String> cmdInput); // 0x0662444c
	System.String CloseTask(System.ArraySegment<System.String> cmdInput); // 0x066244ec
	System.String SwitchTask(System.ArraySegment<System.String> cmdInput); // 0x0662458c
	System.String SwitchToLastTask(System.ArraySegment<System.String> cmdInput); // 0x0662462c
	System.String ResetTask(System.ArraySegment<System.String> cmdInput); // 0x066246cc
	System.String ResetTaskCount(System.ArraySegment<System.String> cmdInput); // 0x0662476c
	System.String ResetGuide(System.ArraySegment<System.String> cmdInput); // 0x0662480c
	System.String ClientTrigger(System.ArraySegment<System.String> cmdInput); // 0x066248ac
	System.String LogicStart(System.ArraySegment<System.String> cmdInput); // 0x0662494c
	System.String RestartDeadSheep(System.ArraySegment<System.String> cmdInput); // 0x066249ec
	System.String DeadSheepSpawn(System.ArraySegment<System.String> cmdInput); // 0x06624a8c
	System.String ModifyDeadSheepTimeout(System.ArraySegment<System.String> cmdInput); // 0x06624b2c
	System.String DeadSheepEnable(System.ArraySegment<System.String> cmdInput); // 0x06624bcc
	System.String DeadSheepList(System.ArraySegment<System.String> cmdInput); // 0x06624c6c
	System.String DeadSheepClear(System.ArraySegment<System.String> cmdInput); // 0x06624d0c
	System.String DeleteEntity(System.ArraySegment<System.String> cmdInput); // 0x06624dac
	System.String DeleteEntityByTemplateId(System.ArraySegment<System.String> cmdInput); // 0x06624e4c
	System.String DeadSheepTest(System.ArraySegment<System.String> cmdInput); // 0x06624eec
	System.String TransportTo(System.ArraySegment<System.String> cmdInput); // 0x06624f8c
	System.String SetGameHour(System.ArraySegment<System.String> cmdInput); // 0x0662502c
	System.String GetGameHour(System.ArraySegment<System.String> cmdInput); // 0x066250cc
	System.String ForwardTime(System.ArraySegment<System.String> cmdInput); // 0x0662516c
	System.String ForwardTimeSec(System.ArraySegment<System.String> cmdInput); // 0x0662520c
	System.String ForwardTimeMin(System.ArraySegment<System.String> cmdInput); // 0x066252ac
	System.String ForwardTimeHour(System.ArraySegment<System.String> cmdInput); // 0x0662534c
	System.String SetAssignTime(System.ArraySegment<System.String> cmdInput); // 0x066253ec
	System.String SetPlantStage(System.ArraySegment<System.String> cmdInput); // 0x0662548c
	System.String GetPlantAllRate(System.ArraySegment<System.String> cmdInput); // 0x0662552c
	System.String KickPlayer(System.ArraySegment<System.String> cmdInput); // 0x066255cc
	System.String SpawnModularCar(System.ArraySegment<System.String> cmdInput); // 0x0662566c
	System.String RemoveModule(System.ArraySegment<System.String> cmdInput); // 0x0662570c
	System.String AddModule(System.ArraySegment<System.String> cmdInput); // 0x066257ac
	System.String GetThreadStat(System.ArraySegment<System.String> cmdInput); // 0x0662584c
	System.String GetNodeValueByPath(System.ArraySegment<System.String> cmdInput); // 0x066258ec
	System.String ListPlayer(System.ArraySegment<System.String> cmdInput); // 0x0662598c
	System.String GetBelongItems(System.ArraySegment<System.String> cmdInput); // 0x06625a2c
	System.String TestGRpcGM(System.ArraySegment<System.String> cmdInput); // 0x06625acc
	System.String TerrtoryCheck(System.ArraySegment<System.String> cmdInput); // 0x06625b6c
	System.String GetTerritoryData(System.ArraySegment<System.String> cmdInput); // 0x06625c0c
	System.String SwitchLobby(System.ArraySegment<System.String> cmdInput); // 0x06625cac
	System.String CreateDigEntity(System.ArraySegment<System.String> cmdInput); // 0x06625d4c
	System.String CreateKatyushaEntity(System.ArraySegment<System.String> cmdInput); // 0x06625dec
	System.String CreateTrapEntity(System.ArraySegment<System.String> cmdInput); // 0x06625e8c
	System.String BuyHorse(System.ArraySegment<System.String> cmdInput); // 0x06625f2c
	System.String PrintSpawnRecordInfo(System.ArraySegment<System.String> cmdInput); // 0x06625fcc
	System.String SetSpawnRecordInfo(System.ArraySegment<System.String> cmdInput); // 0x0662606c
	System.String CheckReputationLevel(System.ArraySegment<System.String> cmdInput); // 0x0662610c
	System.String ResetReputationLevel(System.ArraySegment<System.String> cmdInput); // 0x066261ac
	System.String SetPlayerGivenSleepingBagFlag(System.ArraySegment<System.String> cmdInput); // 0x0662624c
	System.String GivePlayersSleepingBag(System.ArraySegment<System.String> cmdInput); // 0x066262ec
	System.String GmAddOil(System.ArraySegment<System.String> cmdInput); // 0x0662638c
	System.String FullGc(System.ArraySegment<System.String> cmdInput); // 0x0662642c
	System.String SetMaxOnlineCount(System.ArraySegment<System.String> cmdInput); // 0x066264cc
	System.String UpdateClientTable(System.ArraySegment<System.String> cmdInput); // 0x0662656c
	System.String PrintSafetyBoxInfo(System.ArraySegment<System.String> cmdInput); // 0x0662660c
	System.String PlayerCombatStat(System.ArraySegment<System.String> cmdInput); // 0x066266ac
	System.String Marquee(System.ArraySegment<System.String> cmdInput); // 0x0662674c
	System.String FixPlayerAoiPos(System.ArraySegment<System.String> cmdInput); // 0x066267ec
	System.String UnFixPlayerAoiPos(System.ArraySegment<System.String> cmdInput); // 0x0662688c
	System.String SlienceCmd(System.ArraySegment<System.String> cmdInput); // 0x0662692c
	System.String RecordDownlink(System.ArraySegment<System.String> cmdInput); // 0x066269cc
	System.String RecordWords(System.ArraySegment<System.String> cmdInput); // 0x06626a6c
	System.String RecordServerDownlink(System.ArraySegment<System.String> cmdInput); // 0x06626b0c
	System.String ShadowStat(System.ArraySegment<System.String> cmdInput); // 0x06626bac
	System.String ClearShadowStat(System.ArraySegment<System.String> cmdInput); // 0x06626c4c
	System.String AoiStat(System.ArraySegment<System.String> cmdInput); // 0x06626cec
	System.String AoiTop(System.ArraySegment<System.String> cmdInput); // 0x06626d8c
	System.String AddMail(System.ArraySegment<System.String> cmdInput); // 0x06626e2c
	System.String GetMailList(System.ArraySegment<System.String> cmdInput); // 0x06626ecc
	System.String AddTemplateMail(System.ArraySegment<System.String> cmdInput); // 0x06626f6c
	System.String OperateAllMail(System.ArraySegment<System.String> cmdInput); // 0x0662700c
	System.String QueryHeight(System.ArraySegment<System.String> cmdInput); // 0x066270ac
	System.String CompensationCD(System.ArraySegment<System.String> cmdInput); // 0x0662714c
	System.String ClearCompensationCD(System.ArraySegment<System.String> cmdInput); // 0x066271ec
	System.String PrintGridPonits(System.ArraySegment<System.String> cmdInput); // 0x0662728c
	System.String PlantAll(System.ArraySegment<System.String> cmdInput); // 0x0662732c
	System.String LightAllCampfire(System.ArraySegment<System.String> cmdInput); // 0x066273cc
	System.String DisableSpawnType(System.ArraySegment<System.String> cmdInput); // 0x0662746c
	System.String ShowEntityMitrics(System.ArraySegment<System.String> cmdInput); // 0x0662750c
	System.String SleepTest(System.ArraySegment<System.String> cmdInput); // 0x066275ac
	System.String CloseEntityLimit(System.ArraySegment<System.String> cmdInput); // 0x0662764c
	System.String ReloadHotfix(System.ArraySegment<System.String> cmdInput); // 0x066276ec
	System.String AutoOpenDoor(System.ArraySegment<System.String> cmdInput); // 0x0662778c
	System.String AddMarker(System.ArraySegment<System.String> cmdInput); // 0x0662782c
	System.String SpawnPlayerBot(System.ArraySegment<System.String> cmdInput); // 0x066278cc
	System.String DebugPlayerBot(System.ArraySegment<System.String> cmdInput); // 0x0662796c
	System.String GetHorseInformation(System.ArraySegment<System.String> cmdInput); // 0x06627a0c
	System.String SubscribeEntity(System.ArraySegment<System.String> cmdInput); // 0x06627aac
	System.String SetMaster(System.ArraySegment<System.String> cmdInput); // 0x06627b4c
	System.String SetIntimacy(System.ArraySegment<System.String> cmdInput); // 0x06627bec
	System.String KcpStat(System.ArraySegment<System.String> cmdInput); // 0x06627c8c
	System.String AddRuleGraph(System.ArraySegment<System.String> cmdInput); // 0x06627d2c
	System.String PrintRuleGraphContext(System.ArraySegment<System.String> cmdInput); // 0x06627dcc
	System.String PrintRuleGraphAll(System.ArraySegment<System.String> cmdInput); // 0x06627e6c
	System.String PrintRuleGraphAsyncNode(System.ArraySegment<System.String> cmdInput); // 0x06627f0c
	System.String ModifyRuleGraphAsyncNode(System.ArraySegment<System.String> cmdInput); // 0x06627fac
	System.String EnableRuleGraphNode(System.ArraySegment<System.String> cmdInput); // 0x0662804c
	System.String PrintRuleGraphVariable(System.ArraySegment<System.String> cmdInput); // 0x066280ec
	System.String ModifyRuleGraphVariable(System.ArraySegment<System.String> cmdInput); // 0x0662818c
	System.String ActivateDropAmendentId(System.ArraySegment<System.String> cmdInput); // 0x0662822c
	System.String DeactivateDropAmendentId(System.ArraySegment<System.String> cmdInput); // 0x066282cc
	System.String PoiTask(System.ArraySegment<System.String> cmdInput); // 0x0662836c
	System.String PrintAllPatrolGroup(System.ArraySegment<System.String> cmdInput); // 0x0662840c
	System.String ResetPatrolGroup(System.ArraySegment<System.String> cmdInput); // 0x066284ac
	System.String AoiLoad(System.ArraySegment<System.String> cmdInput); // 0x0662854c
	System.String ChangeSkin(System.ArraySegment<System.String> cmdInput); // 0x066285ec
	System.String StarSkin(System.ArraySegment<System.String> cmdInput); // 0x0662868c
	System.String UnStarSkin(System.ArraySegment<System.String> cmdInput); // 0x0662872c
	System.String PrintShadowMessageCount(System.ArraySegment<System.String> cmdInput); // 0x066287cc
	System.String PrintAllBoybandGroup(System.ArraySegment<System.String> cmdInput); // 0x0662886c
	System.String RemoveRoundRuleSpawnEntity(System.ArraySegment<System.String> cmdInput); // 0x0662890c
	System.String RemoveRuleSpawnEntity(System.ArraySegment<System.String> cmdInput); // 0x066289ac
	System.String SetStoryStage(System.ArraySegment<System.String> cmdInput); // 0x06628a4c
	System.String GetBeeBuzzTaskReward(System.ArraySegment<System.String> cmdInput); // 0x06628aec
	System.String ResetBeeBuzzData(System.ArraySegment<System.String> cmdInput); // 0x06628b8c
	System.String ExchangeBeeBuzzSignalCard(System.ArraySegment<System.String> cmdInput); // 0x06628c2c
	System.String SetBeeBuzzNum(System.ArraySegment<System.String> cmdInput); // 0x06628ccc
	System.String ReportGameEndTime(System.ArraySegment<System.String> cmdInput); // 0x06628d6c
	System.String EnterAttackedState(System.ArraySegment<System.String> cmdInput); // 0x06628e0c
	System.String GetBatchRecoverInfo(System.ArraySegment<System.String> cmdInput); // 0x06628eac
	System.String CalcBatchRecoverConsume(System.ArraySegment<System.String> cmdInput); // 0x06628f4c
	System.String DoBatchRecover(System.ArraySegment<System.String> cmdInput); // 0x06628fec
	System.String GetTerritorySkins(System.ArraySegment<System.String> cmdInput); // 0x0662908c
	System.String FixComboPart(System.ArraySegment<System.String> cmdInput); // 0x0662912c
	System.String GetAllLock(System.ArraySegment<System.String> cmdInput); // 0x066291cc
	System.String WatchTimer(System.ArraySegment<System.String> cmdInput); // 0x0662926c
	System.String UnWatchTimer(System.ArraySegment<System.String> cmdInput); // 0x0662930c
	System.String ReleaseLock(System.ArraySegment<System.String> cmdInput); // 0x066293ac
	System.String GetTableLong(System.ArraySegment<System.String> cmdInput); // 0x0662944c
	System.String GetTableFloat(System.ArraySegment<System.String> cmdInput); // 0x066294ec
	System.String GetTableSocText(System.ArraySegment<System.String> cmdInput); // 0x0662958c
	System.String GetTableString(System.ArraySegment<System.String> cmdInput); // 0x0662962c
	System.String GetTableBool(System.ArraySegment<System.String> cmdInput); // 0x066296cc
	System.String GetTableLongArray(System.ArraySegment<System.String> cmdInput); // 0x0662976c
	System.String GetTableFloatArray(System.ArraySegment<System.String> cmdInput); // 0x0662980c
	System.String PrintScheduleInfo(System.ArraySegment<System.String> cmdInput); // 0x066298ac
	System.String SflTest(System.ArraySegment<System.String> cmdInput); // 0x0662994c
	System.String NewbieTask(System.ArraySegment<System.String> cmdInput); // 0x066299ec
	System.String StarBoybandGroup(System.ArraySegment<System.String> cmdInput); // 0x06629a8c
	System.String RemoveNode(System.ArraySegment<System.String> cmdInput); // 0x06629b2c
	System.String AddDailyTaskScore(System.ArraySegment<System.String> cmdInput); // 0x06629bcc
	System.String BeginRecordObserverPos(System.ArraySegment<System.String> cmdInput); // 0x06629c6c
	System.String StopRecordObserverPos(System.ArraySegment<System.String> cmdInput); // 0x06629d0c
	System.String TestGlobalId(System.ArraySegment<System.String> cmdInput); // 0x06629dac
	System.String MarkOutside(System.ArraySegment<System.String> cmdInput); // 0x06629e4c
	System.String UGCSave(System.ArraySegment<System.String> cmdInput); // 0x06629eec
	System.String EntityBriefDump(System.ArraySegment<System.String> cmdInput); // 0x06629f8c
	System.String LoadEntityBriefDump(System.ArraySegment<System.String> cmdInput); // 0x0662a02c
	System.String BoxCompletedGame(System.ArraySegment<System.String> cmdInput); // 0x0662a0cc
	System.String SetGameStatus(System.ArraySegment<System.String> cmdInput); // 0x0662a16c
	System.String FindNearbyPlayers(System.ArraySegment<System.String> cmdInput); // 0x0662a20c
	System.String FindNearbyTerritory(System.ArraySegment<System.String> cmdInput); // 0x0662a2ac
	System.String LoseLeader(System.ArraySegment<System.String> cmdInput); // 0x0662a34c
	System.String BeginImpeach(System.ArraySegment<System.String> cmdInput); // 0x0662a3ec
	System.String BeginTeamTerritoryChange(System.ArraySegment<System.String> cmdInput); // 0x0662a48c
	System.String TestAppPushMessage(System.ArraySegment<System.String> cmdInput); // 0x0662a52c
	System.String NotifyRoleResourceChange(System.ArraySegment<System.String> cmdInput); // 0x0662a5cc
	System.String TestLoadParts(System.ArraySegment<System.String> cmdInput); // 0x0662a66c
	System.String TestBattleEndTlog(System.ArraySegment<System.String> cmdInput); // 0x0662a70c
	System.String PrintEntitySize(System.ArraySegment<System.String> cmdInput); // 0x0662a7ac
	System.String OnlineTeammate(System.ArraySegment<System.String> cmdInput); // 0x0662a84c
	System.String FillNodesToEntityAsMuchAsPossible(System.ArraySegment<System.String> cmdInput); // 0x0662a8ec
	System.String AddPath(System.ArraySegment<System.String> cmdInput); // 0x0662a98c
	System.String RemovePath(System.ArraySegment<System.String> cmdInput); // 0x0662aa2c
	System.String LogAlarm(System.ArraySegment<System.String> cmdInput); // 0x0662aacc
	System.String ClearWorldChat(System.ArraySegment<System.String> cmdInput); // 0x0662ab6c
	System.String GmTaskFinish(System.ArraySegment<System.String> cmdInput); // 0x0662ac0c
	System.String TestRpcToClient(System.ArraySegment<System.String> cmdInput); // 0x0662acac
	System.String FunctionSwitch(System.ArraySegment<System.String> cmdInput); // 0x0662ad4c
	System.String TestJunkpile(System.ArraySegment<System.String> cmdInput); // 0x0662adec
	System.String RoomStart(System.ArraySegment<System.String> cmdInput); // 0x0662ae8c
	System.String FindNearestDeadSheepTerritoryCabinet(System.ArraySegment<System.String> cmdInput); // 0x0662af2c
	System.String LetLogicThreadEnterInfiniteLoop(System.ArraySegment<System.String> cmdInput); // 0x0662afcc
	System.String ActivateTalentDebug(System.ArraySegment<System.String> cmdInput); // 0x0662b06c
	System.String RemoveTalentDebug(System.ArraySegment<System.String> cmdInput); // 0x0662b10c
	System.String AddEntityInAoiDebug(System.ArraySegment<System.String> cmdInput); // 0x0662b1ac
	System.String RemoveEntityInAoiDebug(System.ArraySegment<System.String> cmdInput); // 0x0662b24c
	System.String SetServerOwner(System.ArraySegment<System.String> cmdInput); // 0x0662b2ec
	System.String PrintLastLogicSampleRecord(System.ArraySegment<System.String> cmdInput); // 0x0662b38c
	System.String PrintLogicSampleRecord(System.ArraySegment<System.String> cmdInput); // 0x0662b42c
	System.String AddThreatValue(System.ArraySegment<System.String> cmdInput); // 0x0662b4cc
	System.String EtcdLeaseTest(System.ArraySegment<System.String> cmdInput); // 0x0662b56c
	System.String EtcdPutTest(System.ArraySegment<System.String> cmdInput); // 0x0662b60c
	System.String EtcdGetTest(System.ArraySegment<System.String> cmdInput); // 0x0662b6ac
	System.String EtcdWatchTest(System.ArraySegment<System.String> cmdInput); // 0x0662b74c
	System.String ServiceTest(System.ArraySegment<System.String> cmdInput); // 0x0662b7ec
	System.String GetPlayerPartLimitInfo(System.ArraySegment<System.String> cmdInput); // 0x0662b88c
	System.String OpenPoiPoolTest(System.ArraySegment<System.String> cmdInput); // 0x0662b92c
	System.String AllocateServerInfo(System.ArraySegment<System.String> cmdInput); // 0x0662b9cc
	System.String ListSwitch(System.ArraySegment<System.String> cmdInput); // 0x0662ba6c
	System.String SetSwitch(System.ArraySegment<System.String> cmdInput); // 0x0662bb0c
	System.String ShowBannedTerritory(System.ArraySegment<System.String> cmdInput); // 0x0662bbac
	System.String BanPlayer(System.ArraySegment<System.String> cmdInput); // 0x0662bc4c
	System.String UnBanPlayer(System.ArraySegment<System.String> cmdInput); // 0x0662bcec
	System.String CheckRecordToService(System.ArraySegment<System.String> cmdInput); // 0x0662bd8c
	System.String AddTeamTip(System.ArraySegment<System.String> cmdInput); // 0x0662be2c
	System.String TerrPermissionCheck(System.ArraySegment<System.String> cmdInput); // 0x0662becc
	System.String ShowTurretProp(System.ArraySegment<System.String> cmdInput); // 0x0662bf6c
	System.String TestUgcLevel(System.ArraySegment<System.String> cmdInput); // 0x0662c00c
	System.String PrintActivity(System.ArraySegment<System.String> cmdInput); // 0x0662c0ac
	System.String NowTime(System.ArraySegment<System.String> cmdInput); // 0x0662c14c
	System.String InputItemToPartEntity(System.ArraySegment<System.String> cmdInput); // 0x0662c1ec
	System.String TestPlunderService(System.ArraySegment<System.String> cmdInput); // 0x0662c28c
	System.String TestGetPlunderReport(System.ArraySegment<System.String> cmdInput); // 0x0662c32c
	System.String GetTeamRankList(System.ArraySegment<System.String> cmdInput); // 0x0662c3cc
	System.String PrintServiceDebugInfo(System.ArraySegment<System.String> cmdInput); // 0x0662c46c
	System.String BatchAddPlunderReport(System.ArraySegment<System.String> cmdInput); // 0x0662c50c
	System.String BatchAddSouDaJianTeam(System.ArraySegment<System.String> cmdInput); // 0x0662c5ac
	System.String AddTeamSouDaJianRank(System.ArraySegment<System.String> cmdInput); // 0x0662c64c
	System.String SendZhongKong(System.ArraySegment<System.String> cmdInput); // 0x0662c6ec
	System.String RemoveDailySouDaJianRank(System.ArraySegment<System.String> cmdInput); // 0x0662c78c
	System.Void .ctor(); // 0x0662c82c
	static System.Void .cctor(); // 0x0662c894
}

// Client.Runtime
class WizardGames.Soc.Share.Telemetry.TelemetryBase.<>c : System.Object
{
	static WizardGames.Soc.Share.Telemetry.TelemetryBase.<>c <>9; // 0x0
	static System.Func<System.String,System.Int64> <>9__109_0; // 0x8
	static System.Func<System.Reflection.ConstructorInfo,System.Int32> <>9__135_0; // 0x10
	static System.Void .cctor(); // 0x0662c968
	System.Void .ctor(); // 0x0662c9cc
	System.Int64 <NodePrint>b__109_0(System.String x); // 0x0662ca34
	System.Int32 <CreateInstanceFromType>b__135_0(System.Reflection.ConstructorInfo c); // 0x0662cab0
}

// Client.Runtime
struct WizardGames.Soc.Share.Telemetry.HandlerInfo : System.ValueType
{
	System.Boolean IsAsynResult; // 0x10
	System.Func<System.ArraySegment<System.String>,System.String> Func; // 0x18
	System.Void .ctor(System.Func<System.ArraySegment<System.String>,System.String> func, System.Boolean asyncResult); // 0x0662cb48
}

// Client.Runtime
class WizardGames.Soc.Share.Telemetry.CommandExecutor : System.Object
{
	static WizardGames.Soc.Share.Telemetry.CommandExecutor <Instance>k__BackingField; // 0x0
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Share.Telemetry.HandlerInfo> commandsExecutableDict; // 0x10
	static System.Void set_Instance(WizardGames.Soc.Share.Telemetry.CommandExecutor value); // 0x0662cbd8
	System.Void .ctor(WizardGames.Soc.Share.Telemetry.TelemetryBase telemetryInstance); // 0x0662cc64
	System.String ExecuteLocally(System.ArraySegment<System.String> cmdInput, System.Int32 netPeerId); // 0x0662d028
}

// Client.Runtime
class WizardGames.Soc.Share.Telemetry.ConsoleCommandAttribute : System.Attribute
{
	WizardGames.Soc.Common.Framework.Network.Endpoint <Endpoints>k__BackingField; // 0x10
	System.String <Name>k__BackingField; // 0x18
	System.String <HelpInfo>k__BackingField; // 0x20
	System.Boolean <IsAsynResult>k__BackingField; // 0x28
	System.Void set_Endpoints(WizardGames.Soc.Common.Framework.Network.Endpoint value); // 0x0662d2bc
	System.String get_Name(); // 0x0662d334
	System.Void set_Name(System.String value); // 0x0662d398
	System.Void set_HelpInfo(System.String value); // 0x0662d418
	System.Boolean get_IsAsynResult(); // 0x0662d498
	System.Void set_IsAsynResult(System.Boolean value); // 0x0662d4fc
	System.Void .ctor(); // 0x0662d578
}

// Client.Runtime
class WizardGames.Soc.Share.Telemetry.BuildInTypeHelper : System.Object
{
	static System.Type[] SupportedTypes; // 0x0
	static System.Boolean ConvertValue(System.Type type, System.String valArg, System.Object& value); // 0x06621b08
	static System.Boolean IsSupported(System.Type type); // 0x06621300
	static System.Void .cctor(); // 0x0662d5e0
}

// Client.Runtime
class WizardGames.Soc.Share.Game.NodeSystem.ItemHelper : System.Object
{
	
	static WizardGames.Soc.Common.Data.DataItem.ItemConfig GetItemConfig(System.Int64 bizId); // 0x0662da68
	static WizardGames.Soc.Common.Data.blueprintData.Blueprint GetBlueprintConfig(System.Int64 bizId); // 0x0662db54
	static WizardGames.Soc.Common.Data.blueprintData.Blueprint GetBlueprintConfigByItemId(System.Int64 bizId); // 0x0662dc40
	static WizardGames.Soc.Common.Data.blueprintData.Blueprint GetBlueprintConfigByBuildCoreId(System.Int64 bizId); // 0x0662dd88
	static WizardGames.Soc.Common.Data.DataItem.ItemConfig GetItemConfigByBlueprintId(System.Int64 bizId); // 0x0662de6c
	static WizardGames.Soc.Common.Data.DataItem.ItemConfig GetItemConfigByBlueprintItemId(System.Int64 bizId); // 0x0662df50
	static WizardGames.Soc.Common.Data.blueprintData.Blueprint GetBluePrintId2ItemId(System.Int64 bizId); // 0x0662e034
	static WizardGames.Soc.Common.Data.DataItem.ItemConfig GetBlueprintItemConfigByItemId(System.Int64 bizId); // 0x0662e118
	static System.Boolean HasFlag(WizardGames.Soc.Common.Data.DataItem.ItemConfig config, WizardGames.Soc.Common.Data.DataItem.ItemFlags flag); // 0x0662e230
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemContainerConfigCheck(WizardGames.Soc.Share.Game.NodeSystem.IItemContainerNode itemContainer, WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig); // 0x0662e3b8
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemContainerConfigCheck(WizardGames.Soc.Share.Game.NodeSystem.IItemContainerNode itemContainer, WizardGames.Soc.Share.Game.NodeSystem.IItemNode itemNode); // 0x0662e994
}

// Client.Runtime
class WizardGames.Soc.Share.Game.NodeSystem.ItemHelper.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig; // 0x10
	System.Void .ctor(); // 0x0662e92c
	System.Boolean <ItemContainerConfigCheck>b__0(WizardGames.Soc.Common.Data.DataItem.ItemFlags flag); // 0x0662eb84
	System.Boolean <ItemContainerConfigCheck>b__1(WizardGames.Soc.Common.Data.DataItem.ItemFlags flag); // 0x0662ec00
	System.Boolean <ItemContainerConfigCheck>b__2(System.Int64 itemId); // 0x0662ec7c
	System.Boolean <ItemContainerConfigCheck>b__3(WizardGames.Soc.Common.Data.ItemClassificationData classificationConfig); // 0x0662ed08
}

// Client.Runtime
interface WizardGames.Soc.Share.Game.NodeSystem.ILogicRoot : , System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Share.Game.NodeSystem.INode>>, System.Collections.IEnumerable
{
	
	WizardGames.Soc.Share.Game.NodeSystem.INode GetNodeByPath(System.Collections.Generic.IEnumerable<System.Int64> path); // 0x054f9d14
}

// Client.Runtime
interface WizardGames.Soc.Share.Game.NodeSystem.INode : 
{
	
	System.Int32 get_Id(); // 0x0548ba98
	System.Int64 get_Index(); // 0x054a4380
	WizardGames.Soc.Share.Game.NodeSystem.INode GetChildNode(System.Int64 index); // 0x054e931c
	System.Collections.Generic.IDictionary<System.Int64,System.Int64> GetChildren(); // 0x054e7844
	WizardGames.Soc.Share.Game.NodeSystem.IRootNode GetRootNode(); // 0x054e7844
	WizardGames.Soc.Share.Game.NodeSystem.INode GetParentNode(); // 0x054e7844
	System.String ToPrettyString(); // 0x054e7844
}

// Client.Runtime
interface WizardGames.Soc.Share.Game.NodeSystem.IRootNode : , System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase>>, System.Collections.IEnumerable, WizardGames.Soc.Share.Game.NodeSystem.INode
{
	
	WizardGames.Soc.Common.CustomType.NodeBase GetNodeById(System.Int64 nodeId); // 0x054e931c
	WizardGames.Soc.Share.Framework.ComponentBase GetHostComponent(); // 0x054e7844
}

// Client.Runtime
interface WizardGames.Soc.Share.Game.NodeSystem.IDirectoryNode : , System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase>>, System.Collections.IEnumerable, WizardGames.Soc.Share.Game.NodeSystem.INode
{
	
	System.Void AddAnyUpdateCallback(); // 0x055049cc
}

// Client.Runtime
enum WizardGames.Soc.Share.Game.NodeSystem.EOpCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ArgsError = -1;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode NodeNotExist = -2;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode RootNodeNotExist = -3;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode NodeIsNotDirectory = -4;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode NodeExists = -5;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode SystemNodeNotFound = -6;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode OperationNotSupportedBySystem = -7;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode InvalidPath = -8;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode NodeDetached = -9;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ClientCheating = -10;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode EntitySideHandle = -11;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode NodeTypeMismatch = -12;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode TransactionFail = -13;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ServerInternalError = -14;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode NodeAttached = -15;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode Success = 0;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode CountNotEnough = 100;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemSystemFull = 101;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemSystemCannotInput = 102;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemSystemCannotOutput = 103;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemSystemCannotAccept = 104;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemSystemNotChangePosition = 105;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemSystemAboveStackSize = 106;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemSystemStillNeedMerge = 107;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemSystemBizIdNotFound = 108;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemSystemSuccessWithDrop = 109;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemSystemHaveConflictItem = 110;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemSystemCannotInputLiquid = 111;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemSystemCannotInputBroken = 112;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemSystemCannotInputPack = 113;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemSystemCannotInputLocked = 114;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemSystemItemFlagForbidden = 115;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemNotExisted = 116;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemSystemCannotStack = 117;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemCannotSplit = 118;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode NotLootingContainer = 119;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ConfigNotFound = 200;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BotNoBattleCD = 300;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BotPlayerHpLow = 301;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BotPlayerState = 302;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BotNoPosition = 303;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BotAlreadyExsit = 304;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BotNotInSpawnTime = 305;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BotDestroy = 306;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BotCountOverLimit = 307;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BoybandNotInServerTime = 310;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BoybandRandFailed = 311;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BoybandInCD = 312;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BoybandLevelCountLimit = 313;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BoybandTotalCountLimit = 314;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BoybandTableInvaild = 315;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BoybandAllGroupOccupied = 316;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BeeBuzzNotInMonument = 320;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BeeBuzzTeamLimit = 321;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BeeBuzzConfigNotFound = 322;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BeeBuzzCardLevelNotMatch = 323;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BeeBuzzCardSpwanNotMeetingConditions = 324;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode MonumentAlreadyHaveMonster = 330;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode CosReportTooFrequency = 331;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BuffConfigNotExisted = 400;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BuffAlreadyExisted = 401;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BuffStackMax = 402;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BuffGroupMax = 403;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BuffGroupExisted = 404;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BuffParamsError = 405;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BuffCountError = 406;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BuffNotExsit = 407;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BuffPathNotExsit = 408;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode TalentEffectNotFound = 409;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode GameAlreadyPlay = 500;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode GameUnlockFailed = 501;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode DebrisContainerNotEmpty = 600;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode DebrisToItemFailed = 601;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ActivityContainerNotFound = 700;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode DrumAwardTimesLimit = 701;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode DrumGetDropRewardFailed = 702;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode DrumEntityNotFound = 703;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode DrumIsNotActivity = 704;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode DrumIsOverLootingDistance = 705;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ActivityIsClose = 706;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ContainerOccupied = 1000;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ContainerAlreadyOccupied = 1001;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ContainerNotOccupied = 1002;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ContainerCannotLooting = 1003;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ContainerCanLootingAfterSomeTime = 1004;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode HorseCannotUnload = 1005;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode SwtichLootingContainerRemove = 1006;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ComponentNotFound = 1007;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ComponentNotSupportLooting = 1008;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode HorseCannotEat = 1009;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ContainerAlreadyLooting = 1010;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode LootingUnknownError = 1011;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode RepairNoItem = 1101;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode NoRepairDataFound = 1102;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ConditionIsMax = 1103;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BoxInitError = 1201;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BoxLocking = 1202;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BoxNotBelong = 1203;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode EntityNotFound = 1301;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode EntityGoNotFound = 1302;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode CannotPick = 1303;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode EntityWallBlocked = 1304;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode EntityTypeNotSupport = 1305;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode RootNodeNotFound = 1306;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ItemNodeNotFound = 1307;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode EntityTooFar = 1308;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode PlayerNotSleep = 1401;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode PlayerInSafeArea = 1402;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode EatFoodInCD = 1501;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode MoneyNotEnough = 1601;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ModuleNotFound = 1701;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode NodeNotFound = 1702;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode StorageNotEmpty = 1703;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode CreateItemNodeFailed = 1704;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode SoltIndexError = 1705;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode SoltIndexNotEnough = 1706;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ModuleTypeError = 1707;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode CabinModuleUnique = 1708;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode CabinModuleCannotUnstall = 1709;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode CannotUnstallAllEngine = 1710;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BluePrintForbidRequire = 2001;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BluePrintDataNotFind = 2002;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BluePrintNotUnlock = 2003;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BluePrintNotCraftable = 2004;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BluePrintSkinIdError = 2005;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BluePrintSkinNoHaveError = 2006;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BluePrintAlreadyUnlock = 2007;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BluePrintCannotRemove = 2008;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ShopAlreadyOccupied = 2101;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ShopNoBuyCount = 2102;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ShopNoConfigFound = 2103;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode NoPriceItem = 2104;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode PlayerNotFound = 2105;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode PriceItemFull = 2106;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode PriceItemRepeat = 2107;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode MinganciTestFail = 2108;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BuyHorseMaxLimit = 2109;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BuyVehicleMaxLimit = 2110;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode OutOfInteractionRange = 2111;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode SoldOut = 2112;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ShopItemNotfound = 2113;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode SpawnShopItemFail = 2114;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ShopItemPointOccupied = 2115;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ShopHorseHaveNotSpawn = 2116;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode BuyVehicleHaveNotDestroy = 2117;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ShopItemIsFree = 2118;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode ShopItemIsNotSale = 2119;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode TemperatureNotMatch = 3001;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode TechnologyAlreadyUnlock = 3101;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode TechnologyStatusUnqualified = 3102;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode TechnologyNotUnlock = 3103;
	static WizardGames.Soc.Share.Game.NodeSystem.EOpCode TechConfigNotFound = 3104;
