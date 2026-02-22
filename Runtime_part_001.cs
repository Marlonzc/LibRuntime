	System.Action <>9__6; // 0x18
	System.Void .ctor(); // 0x06d53414
	System.Void <HandleOnlineStatus>b__3(SimpleJSON.JSONNode errorNode); // 0x06d53fac
	System.Void <HandleOnlineStatus>b__6(); // 0x06d544e0
}

// Client.Runtime
class LoginStepHelper.<>c__DisplayClass13_0 : System.Object
{
	System.Int32 onlineStatus; // 0x10
	System.Action <>9__4; // 0x18
	System.Void .ctor(); // 0x06d51f58
	System.Void <HandleOnlineStatus>b__3(SimpleJSON.JSONNode errorNode); // 0x06d5456c
	System.Void <HandleOnlineStatus>b__4(); // 0x06d54aa0
}

// Client.Runtime
class LoginStepHelper.<>c__DisplayClass4_0 : System.Object
{
	System.Boolean skipUiProcess; // 0x10
	System.Action <>9__2; // 0x18
	System.Void .ctor(); // 0x06d4e114
	System.Void <RequestGiveUpBattleWhenBackToLobby>b__0(SimpleJSON.JSONNode ret); // 0x06d54b2c
	System.Void <RequestGiveUpBattleWhenBackToLobby>b__1(SimpleJSON.JSONNode errorNode); // 0x06d54e8c
	System.Void <RequestGiveUpBattleWhenBackToLobby>b__2(); // 0x06d553c0
}

// Client.Runtime
class LoginStepHelper.<>c__DisplayClass6_0 : System.Object
{
	System.Boolean skipUiProcess; // 0x10
	System.Void .ctor(); // 0x06d4e6b0
	System.Void <RequestReconnectBattleWhenBackToLobby>b__1(SimpleJSON.JSONNode errorNode); // 0x06d5544c
}

// Client.Runtime
class LoginStepHelper.<>c__DisplayClass7_0 : System.Object
{
	System.Int32 onlineStatus; // 0x10
	System.Action <>9__2; // 0x18
	System.Void .ctor(); // 0x06d4e8e0
	System.Void <RequestGuideInfo>b__0(SimpleJSON.JSONNode ret); // 0x06d557b4
	System.Void <RequestGuideInfo>b__1(SimpleJSON.JSONNode errorNode); // 0x06d55a5c
	System.Void <RequestGuideInfo>b__2(); // 0x06d55f90
}

// Client.Runtime
struct LoginStepHelper.<EnterFreshmanFightLineup>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	System.Action<SimpleJSON.JSONNode> onSuccess; // 0x38
	System.Void MoveNext(); // 0x06d5601c
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06d56568
}

// Client.Runtime
enum ELoginStep : System.Enum
{
	System.Int32 value__; // 0x10
	static ELoginStep WaitePreload = 0;
	static ELoginStep WaitFullSnapshot = 1;
	static ELoginStep WorldLoadComplete = 2;
	
}

// Client.Runtime
class MgrLoginStep : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	ELoginStep <CurLoginStep>k__BackingField; // 0x14
	UnityEngine.Coroutine coLoginFlow; // 0x18
	System.Action lobbyLogoutAction; // 0x20
	WizardGames.Soc.SocClient.ServerList.ServerInfo <CurSvrInfo>k__BackingField; // 0x28
	System.Boolean IsInLoginFlow; // 0x30
	System.Boolean ReconnectCurSvrWhenReturnToLobby; // 0x31
	System.Boolean IsReconnectCurSvrWhenReturnToLobby; // 0x32
	System.Int64 GameRoleID; // 0x38
	System.String SCENE_PATH; // 0x40
	System.String CREATE_ROLE_SCENE_PATH; // 0x48
	System.Boolean sceneModeInPrepare; // 0x50
	System.Boolean hasDoneInitEntityInstance; // 0x51
	UnityEngine.GameObject <ObjSceneModel>k__BackingField; // 0x58
	UnityEngine.GameObject <ObjCreateRoleSceneModel>k__BackingField; // 0x60
	System.Int32 <CurGameModeID>k__BackingField; // 0x68
	System.String <CurStepInfo>k__BackingField; // 0x70
	System.Boolean <PrepareSceneModelFinished>k__BackingField; // 0x78
	WizardGames.Soc.SocClient.ServerList.ServerInfo serverInfo; // 0x80
	System.Boolean IsNotifyServerKickComingSoon; // 0x88
	System.Boolean <IsFirstAwake>k__BackingField; // 0x89
	System.Boolean <IsInLobbyLogoutFlow>k__BackingField; // 0x8a
	System.Boolean <IsServerLoadingDone>k__BackingField; // 0x8b
	System.Int64 curTimeForServerLoadingDone; // 0x90
	System.Boolean loadedCreateRole; // 0x98
	System.Boolean loadedLobby; // 0x99
	ELoginStep get_CurLoginStep(); // 0x06d565e8
	System.Void set_CurLoginStep(ELoginStep value); // 0x06d5664c
	WizardGames.Soc.SocClient.ServerList.ServerInfo get_CurSvrInfo(); // 0x06d566c4
	System.Void set_CurSvrInfo(WizardGames.Soc.SocClient.ServerList.ServerInfo value); // 0x06d56728
	System.Boolean get_HasLoggedOnGameServer(); // 0x06d4fbcc
	System.Boolean get_SceneModeInPrepare(); // 0x06d567a8
	UnityEngine.GameObject get_ObjSceneModel(); // 0x06d5680c
	System.Void set_ObjSceneModel(UnityEngine.GameObject value); // 0x06d56870
	UnityEngine.GameObject get_ObjCreateRoleSceneModel(); // 0x06d568f0
	System.Void set_ObjCreateRoleSceneModel(UnityEngine.GameObject value); // 0x06d56954
	System.Int32 get_CurGameModeID(); // 0x06d569d4
	System.Void set_CurGameModeID(System.Int32 value); // 0x06d56a38
	System.String get_CurStepInfo(); // 0x06d56ab0
	System.Void set_CurStepInfo(System.String value); // 0x06d56b14
	System.Void set_PrepareSceneModelFinished(System.Boolean value); // 0x06d56b94
	System.Boolean get_IsFirstAwake(); // 0x06d56c10
	System.Void set_IsFirstAwake(System.Boolean value); // 0x06d56c74
	System.Boolean get_IsInLobbyLogoutFlow(); // 0x06d56cf0
	System.Void set_IsInLobbyLogoutFlow(System.Boolean value); // 0x06d56d54
	System.Boolean get_IsServerLoadingDone(); // 0x06d56dd0
	System.Void set_IsServerLoadingDone(System.Boolean value); // 0x06d56e34
	System.Void StepLog(System.String log); // 0x06d4de18
	System.Void StepLogError(System.String log); // 0x06d56eb0
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06d56f64
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x06d57310
	System.Threading.Tasks.Task OnExitWorld(); // 0x06d57398
	System.Void OnAccountLogined(); // 0x06d575b0
	System.Void OnAccountEnterLobby(); // 0x06d5768c
	System.Void OnLobbyReconnected(); // 0x06d57714
	System.Void PrepareLobbyCreateRoleScene(System.Action action); // 0x06d57804
	System.Void PrepareLobbyScene(System.Action action); // 0x06d4eabc
	System.Void OnRequestUserInfo(); // 0x06d57904
	System.Void CloseCreateRoleScene(); // 0x06d55750
	System.Void OnAccountLogout(); // 0x06d57da4
	System.Void OnFastDisconnected(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x06d57e5c
	System.Boolean IsConnect(); // 0x06d57f28
	System.Boolean CheckLocalServiceConnected(UnityEngine.MonoBehaviour env); // 0x06d57ff4
	System.Collections.IEnumerator CoStartLogin(UnityEngine.MonoBehaviour env, WizardGames.Soc.SocClient.ServerList.ServerInfo info, System.Boolean isReLogin, System.Boolean needLoading); // 0x06d58440
	System.Void StartLoadScene(WizardGames.Soc.SocClient.ServerList.ServerInfo info, WizardGames.Soc.SocClient.Ui.UiLoading winLoading); // 0x06d585d0
	System.String GetSdkCoreData(); // 0x06d58a08
	System.ArraySegment<System.Byte> GetSdkCoreDataArraySegment(); // 0x06d58c04
	System.Void StartLoginFlow(WizardGames.Soc.SocClient.ServerList.ServerInfo info, UnityEngine.MonoBehaviour env, System.Boolean isReLogin, System.Boolean needLoading); // 0x06d4d888
	System.Void BreakLoginFlow(UnityEngine.MonoBehaviour env, System.Boolean removeLoading); // 0x06d53a98
	System.Void SendKeyLayout(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Int32 playId, System.Collections.Generic.Dictionary<System.String,System.String> data, System.Action callback, System.Action errorCallback); // 0x06d58ca0
	System.Void GetKeyLayout(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Int32 playId, System.Action callBack, System.Action errorCallback); // 0x06d5908c
	System.Void StartLogoutFlow(UnityEngine.MonoBehaviour env, System.Action onLogout, System.Boolean callWorldLogout); // 0x06d593f0
	System.Void StartLobbyLogout(System.Action onFullLogout, System.Boolean notifyLogoutToLobby, System.Boolean logoutMSDK, System.Boolean callWorldLogout); // 0x0552b37c
	System.Void OpenLogin(); // 0x06d59b84
	System.Void TrySDKAutoLogin(); // 0x06d59da4
	System.Threading.Tasks.Task ProcessLobbySceneLoadedKickout(); // 0x06d5a6a0
	System.Threading.Tasks.Task PrepareLobbySceneModel(System.Action onLoaded); // 0x06d5a7a0
	System.Threading.Tasks.Task PrepareLobbyCreateRoleSceneModel(System.Action onLoaded); // 0x06d5a8d4
	System.Void DestoryLobbyCreateRoleSceneModel(); // 0x06d57a74
	System.Void DestoryLobbySceneModel(); // 0x06d56ff4
	System.Void OnMSDKLoginSuccess(System.Boolean isAutoLogin, System.String openid); // 0x06d5aa08
	System.Void OnMSDKAutoLoginFailed(); // 0x06d5aba0
	System.Void OnMSDKLogout(); // 0x06d5acd4
	System.Void OnWorldServerConnected(); // 0x06d5ad8c
	System.Void OnFirstLoadingSucess(); // 0x06d5ae48
	System.Void OnFullSnapshotReceived(); // 0x06d5aedc
	System.Void OnMyPlayerLoadSuccess(); // 0x06d5b200
	System.Void OnPlayerAwake(); // 0x06d5b488
	System.Void InitEntityInstance(); // 0x06d5baa8
	System.Void SetJoinBattleData(SimpleJSON.JSONNode jsonNode); // 0x06d5bc5c
	System.Boolean IsSameBattle(SimpleJSON.JSONNode node1, SimpleJSON.JSONNode node2); // 0x06d5beb4
	System.Void OnJoinwarzoneBattle(SimpleJSON.JSONNode node); // 0x06d5c1d4
	System.Void .ctor(); // 0x06d5c68c
	static System.Void .cctor(); // 0x06d5c824
	System.Void <OnRequestUserInfo>b__78_0(SimpleJSON.JSONNode res); // 0x06d5c8f8
	System.Void <OnRequestUserInfo>b__78_2(); // 0x06d5cd18
	System.Void <OnRequestUserInfo>b__78_1(SimpleJSON.JSONNode errorNode); // 0x06d5ced0
}

// Client.Runtime
class MgrLoginStep.<>c : System.Object
{
	static MgrLoginStep.<>c <>9; // 0x0
	static System.Action <>9__78_5; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.UiNewbieCG> <>9__78_4; // 0x10
	static System.Action <>9__78_6; // 0x18
	static System.Action<System.String,System.String,System.Action,System.String,System.Action> <>9__84_0; // 0x20
	static System.Action <>9__93_2; // 0x28
	static System.Action <>9__96_0; // 0x30
	static System.Action <>9__96_1; // 0x38
	static System.Void .cctor(); // 0x06d5d370
	System.Void .ctor(); // 0x06d5d3d4
	System.Void <OnRequestUserInfo>b__78_4(WizardGames.Soc.SocClient.Ui.UiNewbieCG win); // 0x06d5d43c
	System.Void <OnRequestUserInfo>b__78_5(); // 0x06d5d568
	System.Void <OnRequestUserInfo>b__78_6(); // 0x06d5d6a0
	System.Void <CoStartLogin>b__84_0(System.String message, System.String leftStr, System.Action leftCb, System.String rightStr, System.Action rightCb); // 0x06d5d728
	System.Void <StartLobbyLogout>b__93_2(); // 0x06d5da98
	System.Void <TrySDKAutoLogin>b__96_0(); // 0x06d5db98
	System.Void <TrySDKAutoLogin>b__96_1(); // 0x06d5dc50
}

// Client.Runtime
class MgrLoginStep.<>c__DisplayClass76_0 : System.Object
{
	System.Action action; // 0x10
	System.Void .ctor(); // 0x06d5dd2c
	System.Void <PrepareLobbyCreateRoleScene>b__0(); // 0x06d5dd94
}

// Client.Runtime
class MgrLoginStep.<>c__DisplayClass77_0 : System.Object
{
	System.Action action; // 0x10
	System.Void .ctor(); // 0x06d5de0c
	System.Void <PrepareLobbyScene>b__0(); // 0x06d5de74
}

// Client.Runtime
class MgrLoginStep.<>c__DisplayClass78_0 : System.Object
{
	SimpleJSON.JSONNode res; // 0x10
	System.Void .ctor(); // 0x06d5ccb0
	System.Void <OnRequestUserInfo>b__3(); // 0x06d5deec
}

// Client.Runtime
class MgrLoginStep.<>c__DisplayClass83_0 : System.Object
{
	MgrLoginStep <>4__this; // 0x10
	UnityEngine.MonoBehaviour env; // 0x18
	System.Void .ctor(); // 0x06d583d8
	System.Void <CheckLocalServiceConnected>b__0(); // 0x06d5dff8
}

// Client.Runtime
class MgrLoginStep.<>c__DisplayClass84_0 : System.Object
{
	MgrLoginStep <>4__this; // 0x10
	UnityEngine.MonoBehaviour env; // 0x18
	System.Action <>9__1; // 0x20
	System.Void .ctor(); // 0x06d5e06c
	System.Void <CoStartLogin>b__1(); // 0x06d5e0d4
}

// Client.Runtime
class MgrLoginStep.<>c__DisplayClass85_0 : System.Object
{
	WizardGames.Soc.SocClient.ServerList.ServerInfo info; // 0x10
	System.Action <>9__1; // 0x18
	System.Void .ctor(); // 0x06d589a0
	System.Void <StartLoadScene>b__0(); // 0x06d5e148
	System.Void <StartLoadScene>b__1(); // 0x06d5e248
}

// Client.Runtime
class MgrLoginStep.<>c__DisplayClass90_0 : System.Object
{
	System.Action callback; // 0x10
	System.Action errorCallback; // 0x18
	System.Void .ctor(); // 0x06d59024
	System.Void <SendKeyLayout>b__0(SimpleJSON.JSONNode node); // 0x06d5e360
	System.Void <SendKeyLayout>b__1(SimpleJSON.JSONNode node); // 0x06d5e3f8
}

// Client.Runtime
class MgrLoginStep.<>c__DisplayClass91_0 : System.Object
{
	System.Action callBack; // 0x10
	System.Action errorCallback; // 0x18
	System.Void .ctor(); // 0x06d59388
	System.Void <GetKeyLayout>b__0(SimpleJSON.JSONNode node); // 0x06d5e490
	System.Void <GetKeyLayout>b__1(SimpleJSON.JSONNode node); // 0x06d5ea50
}

// Client.Runtime
class MgrLoginStep.<>c__DisplayClass93_0 : System.Object
{
	MgrLoginStep <>4__this; // 0x10
	System.Action onFullLogout; // 0x18
	System.Action<SimpleJSON.JSONNode> doLobbyLogout; // 0x20
	System.Boolean notifyLogoutToLobby; // 0x28
	System.Boolean logoutMSDK; // 0x29
	System.Void .ctor(); // 0x06d59b1c
	System.Void <StartLobbyLogout>b__0(SimpleJSON.JSONNode jsonNode); // 0x06d5eae8
	System.Void <StartLobbyLogout>b__1(); // 0x06d5f164
}

// Client.Runtime
class MgrLoginStep.<CoStartLogin>d__84 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	MgrLoginStep <>4__this; // 0x20
	UnityEngine.MonoBehaviour env; // 0x28
	System.Boolean isReLogin; // 0x30
	System.Boolean needLoading; // 0x31
	MgrLoginStep.<>c__DisplayClass84_0 <>8__1; // 0x38
	WizardGames.Soc.SocClient.ServerList.ServerInfo info; // 0x40
	UnityEngine.WaitForSeconds <waitCheck>5__2; // 0x48
	WizardGames.Soc.SocClient.Ui.UiLoading <winLoading>5__3; // 0x50
	System.Void .ctor(System.Int32 <>1__state); // 0x06d5854c
	System.Void System.IDisposable.Dispose(); // 0x06d5f2b8
	System.Boolean MoveNext(); // 0x054c4760
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x06d60fd8
	System.Void System.Collections.IEnumerator.Reset(); // 0x06d6103c
	System.Object System.Collections.IEnumerator.get_Current(); // 0x06d610c4
}

// Client.Runtime
struct MgrLoginStep.<OnAccountLogined>d__73 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	MgrLoginStep <>4__this; // 0x38
	System.Void MoveNext(); // 0x06d61128
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06d6138c
}

// Client.Runtime
struct MgrLoginStep.<PrepareLobbyCreateRoleScene>d__76 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	System.Action action; // 0x38
	MgrLoginStep <>4__this; // 0x40
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x48
	System.Void MoveNext(); // 0x06d6140c
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06d61664
}

// Client.Runtime
struct MgrLoginStep.<PrepareLobbyCreateRoleSceneModel>d__99 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	MgrLoginStep <>4__this; // 0x30
	System.Action onLoaded; // 0x38
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1; // 0x40
	System.Runtime.CompilerServices.TaskAwaiter <>u__2; // 0x48
	System.Void MoveNext(); // 0x06d616e4
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06d620dc
}

// Client.Runtime
struct MgrLoginStep.<PrepareLobbyScene>d__77 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	System.Action action; // 0x38
	MgrLoginStep <>4__this; // 0x40
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x48
	System.Void MoveNext(); // 0x06d62180
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06d623d8
}

// Client.Runtime
struct MgrLoginStep.<PrepareLobbySceneModel>d__98 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	MgrLoginStep <>4__this; // 0x30
	System.Action onLoaded; // 0x38
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1; // 0x40
	System.Runtime.CompilerServices.TaskAwaiter <>u__2; // 0x48
	System.Void MoveNext(); // 0x06d62458
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06d62ed0
}

// Client.Runtime
struct MgrLoginStep.<ProcessLobbySceneLoadedKickout>d__97 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	UiFullScreenVideoMono <instVideo>5__2; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x38
	System.Void MoveNext(); // 0x06d62f74
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06d634f4
}

// Client.Runtime
class FakeNpcBindingGoCom : UnityEngine.MonoBehaviour
{
	UnityEngine.GameObject HudPosGo; // 0x30
	System.Void .ctor(); // 0x06ec6148
}

// Client.Runtime
class FakeNPCHitboxComp : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x06ec61b0
}

// Client.Runtime
class OutlineUtil : UnityEngine.MonoBehaviour
{
	System.Boolean isInit; // 0x30
	System.Int32 meshRendererState; // 0x34
	System.Void set_MeshRendererState(System.Int32 value); // 0x06ec6218
	System.Int32 get_MeshRendererState(); // 0x06ec62a0
	System.Void .ctor(); // 0x06ec6304
}

// Client.Runtime
class Platform : System.Object
{
	static IPlatform instance; // 0x0
	static System.Object syncObj; // 0x8
	static IPlatform get_Instance(); // 0x06ec6374
	static System.Void .cctor(); // 0x06ec65b4
}

// Client.Runtime
interface IPlatform : 
{
	
	System.String GetNetworkOperatorName(); // 0x054e7844
	System.String GetNetworkType(); // 0x054e7844
	System.String GetTGPAHeightWeight(); // 0x054e7844
	System.Int32 GetFoldScreenState(); // 0x0548ba98
}

// Client.Runtime
class PlatformAndroid : System.Object, IPlatform
{
	static SocLogger Log; // 0x0
	System.String GetTGPAHeightWeight(); // 0x06ec6628
	System.Int32 GetFoldScreenState(); // 0x06ec6a14
	System.String GetNetworkOperatorName(); // 0x06ec6de4
	System.String GetNetworkType(); // 0x06ec7324
	System.Void .ctor(); // 0x06ec654c
	static System.Void .cctor(); // 0x06ec7864
}

// Client.Runtime
class PlatformListener : UnityEngine.MonoBehaviour
{
	static SocLogger Log; // 0x0
	static PlatformListener instance; // 0x8
	System.Void Awake(); // 0x06ec7938
	static System.Void Init(); // 0x06ec7a58
	System.Void OnFoldChange(System.String state); // 0x06ec7b74
	System.Void .ctor(); // 0x06ec7d58
	static System.Void .cctor(); // 0x06ec7dc0
}

// Client.Runtime
class TestACE_Lobby : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x06ec7e94
}

// Client.Runtime
class AutoTestMono : UnityEngine.MonoBehaviour
{
	
	System.Void LateUpdate(); // 0x06ec7efc
	System.Void OnFrameEnd(); // 0x06ec7f9c
	System.Void .ctor(); // 0x06ec8024
}

// Client.Runtime
class FpsCounter : System.Object
{
	System.Int32 count; // 0x10
	System.Single time; // 0x14
	System.Single lastfps; // 0x18
	System.Void .ctor(); // 0x06ec808c
	System.Single GetFps(); // 0x06ec80fc
}

// Client.Runtime
class PocoSnippingTools : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	System.Int32 clickCount; // 0x30
	UnityEngine.Rect targetArea; // 0x34
	System.Single nodeHeight; // 0x44
	System.Single nodeWidth; // 0x48
	System.Single nodeX; // 0x4c
	System.Single nodeY; // 0x50
	System.Boolean toggleState; // 0x54
	System.Int32 clickCountRestrict; // 0x58
	System.Boolean MainTestIsRun; // 0x5c
	System.Void Update(); // 0x06ec8184
	System.Void addProSightBnt(); // 0x06ec826c
	System.Void IsClickInTargetArea(); // 0x06ec8610
	System.Void DetectGesture(); // 0x06ec81e8
	System.Void TakeScreenshotAndUpload(); // 0x06ec86f4
	System.Void .ctor(); // 0x06ec8754
	static System.Void .cctor(); // 0x06ec8830
}

// Client.Runtime
enum ESocAutoTestState : System.Enum
{
	System.Int32 value__; // 0x10
	static ESocAutoTestState none = 0;
	static ESocAutoTestState start = 1;
	static ESocAutoTestState settag = 2;
	static ESocAutoTestState end = 3;
	static ESocAutoTestState upload = 4;
	static ESocAutoTestState uploadend = 5;
	
}

// Client.Runtime
enum ESocAutoMemroyDevState : System.Enum
{
	System.Int32 value__; // 0x10
	static ESocAutoMemroyDevState none = 0;
	static ESocAutoMemroyDevState start = 1;
	static ESocAutoMemroyDevState upload = 2;
	
}

// Client.Runtime
class SocAutoTestManager : System.Object
{
	static SocLogger logger; // 0x0
	static ESocAutoTestState SocAutoTestState; // 0x8
	static System.String uploadUrl_1; // 0x10
	static System.String uploadUrl_2; // 0x18
	static System.String uploadUrl_3; // 0x20
	static System.String uploadUrl_4; // 0x28
	static System.String uploadUrl_5; // 0x30
	static System.String uploadUrl_6; // 0x38
	static System.String uploadUrl_7; // 0x40
	static System.String uploadUrl_8; // 0x48
	static System.Int32 uwaState; // 0x50
	static System.Collections.Generic.Dictionary<System.String,System.String> devProfilerPaths; // 0x58
	static System.Collections.Generic.List<System.String> StepNames; // 0x60
	static System.String deviceName; // 0x68
	static System.String timepathfirst; // 0x70
	static System.String timepathsecond; // 0x78
	static System.Boolean IsUploading; // 0x80
	static System.String filedata_dc; // 0x88
	static System.String filedata_error; // 0x90
	static System.String filedata_averagefps; // 0x98
	static System.String filedata_memory; // 0xa0
	static System.String filedata_common; // 0xa8
	static System.String filedata_UI; // 0xb0
	static System.String filedata_fps; // 0xb8
	static System.String device_str; // 0xc0
	static System.Threading.Tasks.Task<System.String> UpLoadResult; // 0xc8
	static System.Collections.Generic.Dictionary<System.String,System.Int32> profilertag_frameindesdic; // 0xd0
	static System.Boolean isUWAUploadend; // 0xd8
	static System.String root_folder; // 0xe0
	static System.String pool_monitor_folder; // 0xe8
	static System.String spike_snapshot_folder; // 0xf0
	static System.Int32 framerate; // 0xf8
	static System.Boolean EnableDelayedTaskProfiler; // 0xfc
	static System.Boolean EnableUiProfiler; // 0xfd
	static System.Boolean EnableDevProfiler; // 0xfe
	static System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Int64>> sendMsg; // 0x100
	static System.Collections.Generic.List<System.String> keys; // 0x108
	static ESocAutoMemroyDevState SocAutoMemroyDevState; // 0x110
	static System.Collections.Generic.List<System.String> snappaths; // 0x118
	static System.Int32 releaseMemoryProfiler; // 0x120
	static System.Boolean releaseMemorysnapcomplete; // 0x124
	static System.String lastcasename; // 0x128
	static System.String lastcasedevicename; // 0x130
	static System.Int32 MAXMemoryMB; // 0x138
	static System.Int32 maxcounter; // 0x13c
	static System.Single lastusagememory; // 0x140
	static System.Int32 usagememorycounter; // 0x144
	static System.Int32 memorymode; // 0x148
	static System.String memorypath; // 0x150
	static System.String GetTimeInfo(); // 0x06ec8904
	static System.String UWAOperation(System.String operation, System.String notes, System.Int32 uwamode, System.Action<System.Boolean,System.String> callback); // 0x06ec8b08
	static System.Void StartUWA(System.String notes, System.Int32 UWAMode); // 0x06ec8f08
	static System.Void EndUWA(System.String time); // 0x06ec8fc4
	static System.Void UploadUWA(System.Action<System.Boolean,System.String> callback); // 0x06ec906c
	static System.Void SetUWATag(System.String tag); // 0x06ec9128
	static System.Void AddUWAMeta(); // 0x06ec91d0
	static System.String UWAUploadState(); // 0x06ec8d84
	static System.Void SetProfilerBegin(System.String tag); // 0x06ec9228
	static System.Void SetProfilerEnd(); // 0x06ec9288
	static System.Void StartUITimes(); // 0x06ec92e0
	static System.String EndUITimes(); // 0x06ec9374
	static System.String StartPerformanceData(System.String casename, System.String stepname, System.Int32 uwamode, System.String devicename); // 0x06ec991c
	static System.String EndPerformanceData(); // 0x06eca060
	static System.Void WriteData(); // 0x06eca4e4
	static System.String GetDeviceInfo(); // 0x06ecb1b4
	static System.Void UpLoadUwaCallBack(System.Boolean success, System.String msg); // 0x06ecb584
	static System.String SetPerformanceDataClear(); // 0x06ecb62c
	static System.Void .cctor(); // 0x06ecb7dc
}

// Client.Runtime
class SocPerfTestUtil : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Int64>> SkyPerforInfoList; // 0x8
	static System.Boolean isGetSkyPerInfo; // 0x10
	static System.Boolean isGMWin; // 0x11
	static System.String GMWinStr; // 0x18
	static System.Void .cctor(); // 0x06ecc050
}

// Client.Runtime
class TODControllPPV : UnityEngine.MonoBehaviour
{
	System.Single bloomValue; // 0x30
	UnityEngine.Rendering.Volume m_Volume; // 0x38
	UnityEngine.Rendering.Universal.Bloom m_Bloom; // 0x40
	System.Void Start(); // 0x06ecc1b0
	System.Void Update(); // 0x06ecc278
	System.Void .ctor(); // 0x06ecc4a4
}

// Client.Runtime
class CastTo<T> : System.Object
{
	
	static T From<S>(S s); // 0x052af1f0
}

// Client.Runtime
class CastTo.Cache<T,S> : System.Object
{
	static System.Func<S,T> caster; // 0x0
	static System.Func<S,T> Get(); // 0x054bddbc
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
struct SignifianceScoreConf : System.ValueType
{
	System.Int32 MaxDist; // 0x10
	System.Int32 MaxRot; // 0x14
	System.Int32 EntityBaseFactor; // 0x18
	System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>[] DistScore; // 0x20
	System.Int32 DistFactor; // 0x28
	System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>[] RotScore; // 0x30
	System.Int32 RotFactor; // 0x38
	System.Void FillByGlobalFactor(WizardGames.Soc.Common.Data.signifiance.SignifianceGlobalFactor InFactorTb); // 0x06ecc50c
	System.Void FillByDistThreshold(WizardGames.Soc.Common.Data.signifiance.TbDistThreshold InDistThresholdTb, System.String InType); // 0x06ecc5a4
	System.Void FillByRotThreshold(WizardGames.Soc.Common.Data.signifiance.TbRotThreshold InRotThresholdTb, System.String InType); // 0x06ecc798
	System.Int32 CalcSocre(System.Int32 baseScore, System.Int32 InDist, System.Int32 InRot, System.Int32 EntityTypeId, System.Int32 baseScoreOffset); // 0x06ecc98c
	System.Int32 CalcScore(System.Int32 baseScore, System.Int32 InDist, System.Single InRelativeHeight); // 0x06eccb90
	System.Int32 CalcSocre2(System.Int32 InDist, System.Int32 InRot); // 0x06eccd04
	System.Int32 CalcKeyValuePair(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>[] InScoreList, System.Int32 InDiff); // 0x06eccaa0
	static SignifianceScoreConfInJob op_Implicit(SignifianceScoreConf obj); // 0x06eccddc
}

// Client.Runtime
struct SignifianceScoreConfInJob : System.ValueType
{
	System.Int32 MaxDist; // 0x10
	System.Int32 MaxRot; // 0x14
	System.Int32 EntityBaseFactor; // 0x18
	Unity.Collections.NativeArray<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> DistScore; // 0x20
	System.Int32 DistFactor; // 0x30
	Unity.Collections.NativeArray<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> RotScore; // 0x38
	System.Int32 RotFactor; // 0x48
	System.Int32 CalcSocre(System.Int32 baseScore, System.Int32 InDist, System.Int32 InRot, System.Int32 EntityTypeId, System.Int32 baseScoreOffset); // 0x06eccff4
	System.Int32 CalcSocre2(System.Int32 InDist, System.Int32 InRot); // 0x06ecd0bc
	System.Int32 CalcKeyValuePair(Unity.Collections.NativeArray<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> InScoreList, System.Int32 InDiff); // 0x06ecd198
	System.Void Dispose(); // 0x06ecd274
}

// Client.Runtime
class Dict2LongKey<TValue> : System.Object
{
	System.Collections.Generic.Dictionary<System.UInt64,TValue> Dict; // 0x0
	System.UInt64 MagicNum; // 0x0
	static System.ValueTuple<System.Int64,System.Int64> MinMax(System.Int64 key1, System.Int64 key2); // 0x054bc724
	System.Void CombineHash(System.Int64 InKey1, System.UInt64& OutSeed); // 0x055128b0
	System.UInt64 GetCombinedKey(System.Int64 InKey1, System.Int64 InKey2); // 0x054e27b8
	System.Void .ctor(System.Int32 InCapacity); // 0x055056e8
	System.Void Add(System.Int64 InKey1, System.Int64 InKey2, TValue value); // 0x052af1f0
	System.Boolean TryGetValue(System.Int64 InKey1, System.Int64 InKey2, TValue& value); // 0x054c625c
}

// Client.Runtime
struct EntityTransformRes : System.ValueType
{
	System.Int32 Dist; // 0x10
	System.Int32 Rot; // 0x14
	System.Int32 CurFrame; // 0x18
	System.Void .ctor(System.Int32 InDist, System.Int32 InRot, System.Int32 InFrameCount); // 0x06ecd334
}

// Client.Runtime
class MgrToEntityCalcCache : WizardGames.Soc.Common.Manager.MgrBase
{
	static System.Int32[] DistLods; // 0x0
	System.Int32 PoolSize; // 0x14
	Dict2LongKey<EntityTransformRes> Dict; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Bounds> HashToBoundsMap; // 0x20
	System.Int32 VerticalHalfFOV; // 0x28
	System.Int32 HorizontalHalfFOV; // 0x2c
	System.Boolean IsInit; // 0x30
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06ecd3cc
	System.Threading.Tasks.Task OnExitWorld(); // 0x06ecd490
	System.Boolean TryCalc(System.Int64 InPlayerId, UnityEngine.Vector2 InPlayerPos, UnityEngine.Vector2 InPlayerForward, System.Int64 InTargetId, UnityEngine.Vector2 InTargetPos, System.Int32& OutDist, System.Int32& OutRot); // 0x06ecd50c
	static System.Void GetEntityPos(System.Int64 entityId, WizardGames.Soc.Share.Framework.IPositionEntity entity, UnityEngine.Vector3& entityPos); // 0x06ecd860
	System.Boolean GetEntityBounds(RendererItem item, UnityEngine.Vector3 entityPos, System.Int32 entityType, System.Int64 templateId, UnityEngine.Bounds& bounds); // 0x06ecdbe0
	System.Void .ctor(); // 0x06ece1a8
	static System.Void .cctor(); // 0x06ece274
}

// Client.Runtime
class SigniLogger : System.Object
{
	static SocLogger _; // 0x0
	static System.Void .cctor(); // 0x06ece314
}

// Client.Runtime
class MgrSignifianceReq : WizardGames.Soc.Common.Manager.MgrBase
{
	ISignifianceProcess MeshLodRef; // 0x18
	ISignifianceProcess FootstepAudioRef; // 0x20
	ISignifianceProcess VehicleRef; // 0x28
	MgrSignifianceRes ResRef; // 0x30
	System.Void RegisterMeshLod(ISignifianceProcess InProcess); // 0x06ece3e8
	System.Void RegisterFootstepAudio(ISignifianceProcess InProcess); // 0x06ece47c
	System.Void RegisterResMgr(MgrSignifianceRes InResMgr); // 0x06ece510
	System.Void RegisterVehicle(ISignifianceProcess InProcess); // 0x06ece5a4
	System.Void UnregMeshLod(); // 0x06ece638
	System.Void UnregFootstepAudio(); // 0x06ece6a4
	System.Void UnregResMgr(); // 0x06ece710
	System.Void UnregVehicle(); // 0x06ece77c
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06ece7e8
	System.Threading.Tasks.Task OnExitWorld(); // 0x06ece860
	System.Void CleanUp(); // 0x06ece908
	System.Boolean TryGetAnimLod(System.Int64 InEntityId, System.Int32& OutLodLvl); // 0x06ece968
	System.Boolean TryGetMeshLod(System.Int64 InEntityId, System.Int32& OutLodLvl); // 0x06ece9f0
	System.Void ChangeQualityLevel(WizardGames.Soc.RMQualityLevel InQualityLvl); // 0x06ecec7c
	System.Void .ctor(); // 0x06ecef0c
}

// Client.Runtime
class DetailContent : UnityEngine.MonoBehaviour
{
	TMPro.TMP_Text PrefabPath; // 0x30
	System.String PrefabPathFormat; // 0x38
	TMPro.TMP_Text Score; // 0x40
	System.String ScoreFormat; // 0x48
	System.String ScoreFormatEffect; // 0x50
	TMPro.TMP_Text Lod; // 0x58
	System.String LodFormat; // 0x60
	System.String LodFormatEffect; // 0x68
	TMPro.TMP_Text Angle; // 0x70
	System.String AngleFormat; // 0x78
	TMPro.TMP_Text Distance; // 0x80
	System.String DistanceFormat; // 0x88
	TMPro.TMP_Text ScreenBodyRatio; // 0x90
	System.String ScreenBodyRatioFormat; // 0x98
	System.Void Start(); // 0x06ecef74
	System.Void SetDetailData(SignificanceDbgDetailData currentDetailData); // 0x06ecf310
	System.Void .ctor(); // 0x06ecf738
}

// Client.Runtime
class SignificanceDbgDetail : UnityEngine.MonoBehaviour
{
	UnityEngine.GameObject GeneralDetailContent; // 0x30
	System.String DisplayStringFormat; // 0x38
	TMPro.TMP_Text TopBarInfo; // 0x40
	SignificanceDbgLodList DataList; // 0x48
	DetailContent Detail; // 0x50
	System.Boolean isCollapse; // 0x58
	System.Void Start(); // 0x06ecf8e4
	System.Void SetDetailData(SignificanceDbgDetailData lodData); // 0x06ecfb94
	System.Void SetDisable(); // 0x06ecfc8c
	System.Void .ctor(); // 0x06ecfdd8
}

// Client.Runtime
class SignificanceDbgItemDisplayer : UnityEngine.MonoBehaviour
{
	SignificanceDbgDetailData LodData; // 0x30
	TMPro.TMP_Text BasicInfo; // 0x38
	System.String DisplayStringFormat; // 0x40
	UnityEngine.RectTransform MyRectTransform; // 0x48
	System.String[] _displayLodTextColors; // 0x50
	UnityEngine.UI.Button DetailBtn; // 0x58
	SignificanceDbgLodList DataList; // 0x60
	SignificanceDbgDetail DetailView; // 0x68
	System.Boolean IsSelected; // 0x70
	System.Void Init(SignificanceDbgDetailData lodData, SignificanceDbgLodList dataList, SignificanceDbgDetail detail); // 0x06ecfe6c
	System.Void UpdateDisplay(); // 0x06ed0170
	System.Void Clear(); // 0x06ed0350
	System.Void CheckDetail(); // 0x06ed0410
	System.Void SetSelected(System.Boolean selected); // 0x06ed0478
	System.Void .ctor(); // 0x06ed0590
}

// Client.Runtime
class SignificanceDbgDetailData : System.Object
{
	System.Int64 Id; // 0x10
	System.String PrefabPath; // 0x18
	System.Single Score_M; // 0x20
	System.Single Score_A; // 0x24
	System.Int32 Lod_M; // 0x28
	System.Int32 Lod_A; // 0x2c
	System.Single Angle; // 0x30
	System.Single Distance; // 0x34
	System.Single ScreenBodyRatio; // 0x38
	System.Int64 DisplayerId; // 0x40
	System.Boolean IsEffect; // 0x48
	System.Void .ctor(System.Int64 id, System.String prefabPath, System.Single scoreM, System.Single scoreA, System.Int32 lodM, System.Int32 lodA, System.Single angle, System.Single distance, System.Single screenBodyRatio); // 0x06ed0724
}

// Client.Runtime
class DisplayerIdAllocator : System.Object
{
	static System.Int64 _displayerId; // 0x0
	static System.Int64 GetDisplayerId(); // 0x06ed0840
	static System.Void ResetDisplayerId(); // 0x06ed08c0
}

// Client.Runtime
class SignificanceDbgLodList : UnityEngine.MonoBehaviour
{
	System.String DisplayerPrefabPath; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,SignificanceDbgDetailData> ModelLodData; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,SignificanceDbgDetailData> EffectLodData; // 0x40
	System.Collections.Generic.List<SignificanceDbgDetailData> filteredData; // 0x48
	System.Collections.Generic.Dictionary<System.Int64,SignificanceDbgItemDisplayer> displayingPlayer; // 0x50
	SignificanceDbgDetail DetailView; // 0x58
	UnityEngine.GameObject ListLocator; // 0x60
	System.Int64 currentSelectedDisplayerId; // 0x68
	SignificanceDbgLodList.DisplayMode currentDisplayMode; // 0x70
	System.Void Init(); // 0x06ed0938
	System.Void Clear(); // 0x06ed0c00
	System.Void RefreshList(); // 0x06ed0ee0
	System.Void AddDisplayer(SignificanceDbgDetailData data); // 0x06ed117c
	System.Void SyncDisplayerData(System.Boolean isExist, SignificanceDbgDetailData data); // 0x06ed1588
	System.Boolean SyncModelLodGroupData(System.Int64 entityId, System.Single screenBodyRatio, System.Single distance, System.Single angle); // 0x06ed16ec
	System.Boolean SyncModelScoreWithLodData(System.Int64 entityId, System.Int32 modelScore, System.Int32 lodScore); // 0x06ed1b24
	System.Boolean SyncAnimScoreWithLodData(System.Int64 entityId, System.Int32 animScore, System.Int32 lodScore); // 0x06ed1ce8
	System.Boolean RemoveModelLodData(System.Int64 entityId); // 0x06ed1e14
	System.Boolean SyncEffectLodData(System.Int64 effectId, System.Int32 effectScore, System.Int32 lodScore, System.Single angle, System.Single distance); // 0x06ed1fc4
	System.Boolean RemoveEffectLodData(System.Int64 effectId); // 0x06ed21b8
	System.Void ClearAllEffectsData(); // 0x06ed2368
	SignificanceDbgItemDisplayer CreateDisplayer(); // 0x06ed12ac
	System.String GetEntityPrefabPath(System.Int64 entityId); // 0x06ed18a0
	System.Void SetSelectedDisplayerId(System.Int64 id); // 0x06ecfd10
	System.Void SelectAllModelData(); // 0x06ed2624
	System.Void SelectAllEffectData(); // 0x06ed2940
	System.Void SortById(); // 0x06ed2c60
	System.Void SortByLod(); // 0x06ed2da4
	System.Void SortByScore(); // 0x06ed2ee8
	System.Void .ctor(); // 0x06ed302c
}

// Client.Runtime
enum SignificanceDbgLodList.DisplayMode : System.Enum
{
	System.Int32 value__; // 0x10
	static SignificanceDbgLodList.DisplayMode Model = 0;
	static SignificanceDbgLodList.DisplayMode Effect = 1;
	
}

// Client.Runtime
class SignificanceDbgLodList.<>c : System.Object
{
	static SignificanceDbgLodList.<>c <>9; // 0x0
	static System.Comparison<SignificanceDbgDetailData> <>9__25_0; // 0x8
	static System.Comparison<SignificanceDbgDetailData> <>9__26_0; // 0x10
	static System.Comparison<SignificanceDbgDetailData> <>9__27_0; // 0x18
	static System.Comparison<SignificanceDbgDetailData> <>9__28_0; // 0x20
	static System.Comparison<SignificanceDbgDetailData> <>9__29_0; // 0x28
	static System.Void .cctor(); // 0x06ed30b8
	System.Void .ctor(); // 0x06ed311c
	System.Int32 <SelectAllModelData>b__25_0(SignificanceDbgDetailData a, SignificanceDbgDetailData b); // 0x06ed3184
	System.Int32 <SelectAllEffectData>b__26_0(SignificanceDbgDetailData a, SignificanceDbgDetailData b); // 0x06ed3218
	System.Int32 <SortById>b__27_0(SignificanceDbgDetailData a, SignificanceDbgDetailData b); // 0x06ed32ac
	System.Int32 <SortByLod>b__28_0(SignificanceDbgDetailData a, SignificanceDbgDetailData b); // 0x06ed3340
	System.Int32 <SortByScore>b__29_0(SignificanceDbgDetailData a, SignificanceDbgDetailData b); // 0x06ed33d4
}

// Client.Runtime
class SignificanceDbgPanel : UnityEngine.MonoBehaviour
{
	TMPro.TMP_Text GeneralInfo; // 0x30
	UnityEngine.GameObject GeneralPanel; // 0x38
	UnityEngine.GameObject GeneraleContent; // 0x40
	System.Boolean isCollapse; // 0x48
	System.Int32 _modelDataCount; // 0x4c
	System.Int32 _effectDataCount; // 0x50
	System.String TopBarInfoFormat; // 0x58
	SignificanceDbgLodList DataList; // 0x60
	System.Int32 get_ModelDataCount(); // 0x06ed3468
	System.Void set_ModelDataCount(System.Int32 value); // 0x06ed34cc
	System.Int32 get_EffectDataCount(); // 0x06ed36dc
	System.Void set_EffectDataCount(System.Int32 value); // 0x06ed3740
	System.Int32 get_TotalDataCount(); // 0x06ed37bc
	System.Void Init(); // 0x06ed38b4
	System.Void Clear(); // 0x06ed3b58
	System.Void UpdateGeneralInfo(); // 0x06ed3548
	System.Void Toggle(); // 0x06ed3bc4
	System.Void SetDisable(); // 0x06ed3c40
	System.Void SyncLodGroupData(System.Int64 entityId, System.Single screenBodyRatio, System.Single distance, System.Single angle); // 0x06ed3cb4
	System.Void SyncAnimScoreWithLodData(System.Int64 entityId, System.Int32 animScore, System.Int32 lodScore); // 0x06ed3e20
	System.Void SyncModelScoreWithLodData(System.Int64 entityId, System.Int32 modelScore, System.Int32 lodScore); // 0x06ed3f70
	System.Void RemoveModelLodData(System.Int64 entityId); // 0x06ed40c0
	System.Void SyncEffectLodData(System.Int64 effectId, System.Int32 effectScore, System.Int32 lodScore, System.Single angle, System.Single distance); // 0x06ed41e8
	System.Void RemoveEffectLodData(System.Int64 effectId); // 0x06ed4360
	System.Void ClearAllEffectsData(); // 0x06ed4488
	System.Void .ctor(); // 0x06ed4548
}

// Client.Runtime
class PriorityQueue<T> : System.Object
{
	System.ValueTuple<T,System.Int32>[] Nodes; // 0x0
	System.Int32 Count; // 0x0
	System.Int32 Version; // 0x0
	System.Boolean IsMaxHeap; // 0x0
	System.Void .ctor(); // 0x055049cc
	System.Void .ctor(System.Int32 initialCapacity); // 0x055056e8
	System.Void CopyFrom(PriorityQueue<T> Other); // 0x05523a54
	System.Void Enqueue(T Val, System.Int32 Priority); // 0x052af1f0
	System.Void Grow(System.Int32 minCapacity); // 0x055056e8
	System.Boolean TryDequeue(T& element, System.Int32& priority); // 0x054e0cf4
	System.Void RemoveRootNode(); // 0x055049cc
	System.Void Clear(); // 0x055049cc
	static System.Int32 GetParentIndex(System.Int32 index); // 0x05485fb4
	static System.Int32 GetFirstChildIndex(System.Int32 index); // 0x05485fb4
	System.Void MoveUp(System.ValueTuple<T,System.Int32> node, System.Int32 nodeIndex); // 0x052af1f0
	System.Void MoveDown(System.ValueTuple<T,System.Int32> node, System.Int32 nodeIndex); // 0x052af1f0
}

// Client.Runtime
class SignifianceAnimProcess : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	System.Boolean IsValid; // 0x10
	System.Boolean IsEnable; // 0x11
	System.Boolean IsEnableDbgShow; // 0x12
	System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> EntityLodUpdateTime; // 0x18
	System.String BucketType; // 0x20
	System.Collections.Generic.List<System.Int64> _newEntitiesToInitialize; // 0x28
	System.Collections.Generic.List<System.Int64> _entitiesToUpdateThisFrame; // 0x30
	System.Collections.Generic.List<System.Int64> _entitiesToSlowDownThisFrame; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> _previousActiveResult; // 0x40
	System.Collections.Generic.HashSet<System.Int64> _disabledEntities; // 0x48
	System.Collections.Generic.HashSet<System.Int64> _initializedEntities; // 0x50
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x06ed45dc
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x06ed4640
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05526948
	System.Void OnDestroy(); // 0x06ed6ac4
	System.Void SlowDownAnimUROByList(System.Collections.Generic.List<System.Int64> InIdList); // 0x06ed5a4c
	System.Void StopAnimUROByList(System.Collections.Generic.List<System.Int64> InIdList); // 0x06ed61ac
	System.Void ProcessChangedAnimators(System.Collections.Generic.List<System.Int64> entityIds, System.Collections.Generic.Dictionary<System.Int64,System.Int32> currentActiveResults); // 0x06ed5fe4
	System.Void ApplyAnimUROForEntity(System.Int64 id, System.Int32 lv); // 0x055112d4
	System.Void SetUro(UnityEngine.Animator animator, System.Int32 lod, System.Int32[] curTime, System.Boolean changeUpdateFrameRate); // 0x06ed6b4c
	System.Void .ctor(); // 0x06ed74d0
	static System.Void .cctor(); // 0x06ed76dc
}

// Client.Runtime
struct SignifianceProcessProxy : System.ValueType
{
	SignifianceScoreConf Conf; // 0x10
	SignifianceBucketConf BucketConf; // 0x40
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> EntityBaseScore; // 0x50
	System.Boolean IsEnable; // 0x58
	Process_SignifianceScoreBase Process; // 0x60
	System.String BucketType; // 0x68
	SignifianceBucketConf GetBucketConf(System.Int32 lvl); // 0x06ed77b0
	System.Void InitConf(System.Int32 InQualityLvl, System.Func<WizardGames.Soc.Common.Data.signifiance.SignifianceEntityTypeFactor,System.Int32> funcGetUseBucket); // 0x06ed7a1c
	System.Void InitProcess(Process_SignifianceScoreBase process, WizardGames.Soc.Common.Contexts.Context context, System.Int32 poolSize); // 0x06ed8208
}

// Client.Runtime
class SignifianceEntityRenderingProcess : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	System.Int32 PoolSize; // 0x10
	System.Boolean IsEnableDbgShow; // 0x14
	SignifianceProcessProxy CharProcessProxy; // 0x18
	SignifianceProcessProxy VehicleProcessProxy; // 0x78
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x06ed838c
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x06ed83f0
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06ed8780
	System.Void UpdateProcess(Process_SignifianceScoreBase process, System.Int32 deltaTime); // 0x06ed8858
	System.Void ForceLod(System.Collections.Generic.List<System.Int64> InIdList, System.Int32 InLodLvl); // 0x06ed9174
	System.Void Hide(System.Collections.Generic.List<System.Int64> InIdList); // 0x06ed934c
	System.Void OnDestroy(); // 0x06ed9ce8
	System.Void .ctor(); // 0x06ed9d94
}

// Client.Runtime
class SignifianceEntityRenderingProcess.<>c : System.Object
{
	static SignifianceEntityRenderingProcess.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.Common.Data.signifiance.SignifianceEntityTypeFactor,System.Int32> <>9__6_0; // 0x8
	static System.Func<WizardGames.Soc.Common.Data.signifiance.SignifianceEntityTypeFactor,System.Int32> <>9__6_1; // 0x10
	static System.Void .cctor(); // 0x06ed9eb8
	System.Void .ctor(); // 0x06ed9f1c
	System.Int32 <OnCreate>b__6_0(WizardGames.Soc.Common.Data.signifiance.SignifianceEntityTypeFactor ent); // 0x06ed9f84
	System.Int32 <OnCreate>b__6_1(WizardGames.Soc.Common.Data.signifiance.SignifianceEntityTypeFactor ent); // 0x06eda004
}

// Client.Runtime
class Process_SignifiancePlayerBase : Process_SignifianceScoreBase
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PlayerEntity> PlayerEntities; // 0x98
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.MonsterEntity> MonsterEntities; // 0xa0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.NPCEntity> NpcEntities; // 0xa8
	System.Void Init(WizardGames.Soc.Common.Contexts.Context context, System.Int32 PoolSize, SignifianceBucketConf& InBucketConf, SignifianceScoreConf& InScoreConf, System.Collections.Generic.Dictionary<System.Int32,System.Int32> InEntityBaseScore, System.Func<System.Int32,SignifianceBucketConf> InFuncGetBucketConf); // 0x06eda084
	System.Void NotifyToken(System.Int64 InId, System.Int32 InToken); // 0x06eda658
	System.Void CalcEntityScores(System.Int64 playerId, UnityEngine.Vector2 playerPos, UnityEngine.Vector2 playerForward); // 0x06edac14
	System.Void .ctor(); // 0x06ed86b8
}

// Client.Runtime
class MgrSignifianceRes : WizardGames.Soc.Common.Manager.MgrBase
{
	static WizardGames.Soc.Common.ObjPool.ObjectPool<UnityEngine.Rendering.Universal.ObjectRenderInfo> RenderInfoPool; // 0x0
	static WizardGames.Soc.Common.ObjPool.ObjectPool<SignifianceGridCell> GridCellPool; // 0x8
	System.Boolean IsInit; // 0x11
	SignifianceGrid<SignifianceGridCell> Grid; // 0x18
	System.Boolean IsEnable; // 0x20
	System.Boolean IsEnableDbgShow; // 0x21
	System.Int32 LastPlayerIdx; // 0x24
	WizardGames.Soc.Common.Framework.Algorithm.Vector2i PlayerGridIdx; // 0x28
	Recti NearbyRect; // 0x30
	System.Collections.Generic.HashSet<System.Int32> LastNearbyList; // 0x40
	System.Collections.Generic.HashSet<System.Int32> CurNearbyList; // 0x48
	System.Collections.Generic.HashSet<System.Int32> ToRemoveList; // 0x50
	System.Collections.Generic.HashSet<System.Int32> ToAddList; // 0x58
	System.Collections.Generic.HashSet<System.Int32> ToUpdateList; // 0x60
	SignifianceScoreConf Conf; // 0x68
	SignifianceBucketConf BucketConf; // 0x98
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> EntityBaseScore; // 0xa8
	System.Collections.Generic.List<SignifianceBucketCount> Budget; // 0xb0
	PriorityQueue<System.Int32> SortedResult; // 0xb8
	System.Collections.Generic.List<SignifianceGridCell> CellToGpu; // 0xc0
	System.String BucketType; // 0xc8
	System.Diagnostics.Stopwatch UpdateTimer; // 0xd0
	System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject> PrefabDict; // 0xd8
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06edbc20
	System.Void InitBucket(System.Int32 quality_lvl); // 0x06edc49c
	System.Void InitConf(); // 0x06edbd24
	System.Threading.Tasks.Task OnExitWorld(); // 0x06edcc20
	System.Void InitGrid(); // 0x06edc8c8
	System.Void Clear(); // 0x06edcccc
	System.Void OnFps10Update(); // 0x06edd004
	System.Void AddEntity(System.Int64 InId, System.Int32 InInstanceId, System.Int32 InEntityType, UnityEngine.GameObject PrefabObj, UnityEngine.Transform InTransform); // 0x06ede2e8
	System.Void InternalAdd(System.Int64 InId, System.Int32 InInstanceId, System.Int32 InEntityType, UnityEngine.GameObject PrefabObj, UnityEngine.Transform InTransform); // 0x06ede598
	System.Void RemoveEntity(System.Int64 InId, System.Int32 InInstanceId, System.Int32 InEntityType, UnityEngine.Vector3 InPos); // 0x06ede828
	System.Void SetDbgInfo(WizardGames.Soc.Stl.SocDict<System.Int64,UnityEngine.Rendering.Universal.ObjectRenderInfo> InItemDict, System.Int32 InScore, System.Int32 InLod); // 0x06ede0d0
	System.Void NotifyQualityChange(System.Int32 InQualityLvl); // 0x06ecee78
	System.Void .ctor(); // 0x06edeca8
	static System.Void .cctor(); // 0x06edef68
}

// Client.Runtime
class MgrSignifianceRes.<>c : System.Object
{
	static MgrSignifianceRes.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x06edf154
	System.Void .ctor(); // 0x06edf1b8
	SignifianceGridCell <.cctor>b__45_0(); // 0x06edf220
}

// Client.Runtime
class Process_SignifianceScoreBase : System.Object, ISignifianceProcess
{
	System.Nullable<SignifianceScoreConf> Conf; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> EntityBaseScore; // 0x48
	System.Boolean IsInit; // 0x50
	System.Boolean IsDirty; // 0x51
	SignifianceComp Comp; // 0x58
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> ActiveResult; // 0x60
	System.Collections.Generic.List<System.Int64> DisableResult; // 0x68
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int64>> UpdateList; // 0x70
	System.Collections.Generic.List<System.Int64> ToRemoveList; // 0x78
	System.Collections.Generic.List<System.Int64> RemoveList; // 0x80
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> ScoreResult; // 0x88
	System.Func<System.Int32,SignifianceBucketConf> FuncGetBucketConf; // 0x90
	System.Void Init(WizardGames.Soc.Common.Contexts.Context context, System.Int32 PoolSize, SignifianceBucketConf& InBucketConf, SignifianceScoreConf& InScoreConf, System.Collections.Generic.Dictionary<System.Int32,System.Int32> InEntityBaseScore, System.Func<System.Int32,SignifianceBucketConf> InFuncGetBucketConf); // 0x06eda264
	System.Void Update(System.Int32 InDeltaTime); // 0x06ed90dc
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetActiveResult(); // 0x06edfbc0
	System.Void NotifyToken(System.Int64 InId, System.Int32 InToken); // 0x06eda784
	System.Void NotifyQualityChange(System.Int32 InQualityLvl); // 0x06edfc24
	static System.Boolean GetPlayerLookAt(UnityEngine.Vector2& pos, UnityEngine.Vector2& forward); // 0x06edff5c
	System.Boolean TryCalcScoreDict(System.Collections.Generic.Dictionary<System.Int64,System.Int32>& scoreDict); // 0x06ee0330
	System.Void CalcEntityScores(System.Int64 playerId, UnityEngine.Vector2 playerPos, UnityEngine.Vector2 playerForward); // 0x055126b8
	System.Void CalcPlayerEntityScores(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PlayerEntity> playerEntities, System.Int64 playerId, UnityEngine.Vector2 playerPos, UnityEngine.Vector2 playerForward); // 0x06edacfc
	System.Void CalcMonsterEntityScores(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.MonsterEntity> monsterEntities, System.Int64 playerId, UnityEngine.Vector2 playerPos, UnityEngine.Vector2 playerForward); // 0x06edb4f8
	System.Void CalcMountableEntityScores<T>(System.Collections.Generic.Dictionary<System.Int64,T> mountableEntities, System.Int64 playerId, UnityEngine.Vector2 playerPos, UnityEngine.Vector2 playerForward); // 0x052af1f0
	System.Void CalcMountableEntityScore(WizardGames.Soc.Common.Entity.BaseMountableEntity entity, System.Int64 id, System.Int64 playerId, UnityEngine.Vector2 playerPos, UnityEngine.Vector2 playerForward); // 0x06ee0bbc
	System.Boolean TryGetValuesFromLODGroup(System.Int64 entityId, RendererItem& item); // 0x06ee0834
	System.Boolean GetEntityBound(System.String entityType, System.Int32 category, SharedUnity.GameLocalBounds& bounds); // 0x06ee0a14
	System.Void .ctor(); // 0x06edbbb8
}

// Client.Runtime
class Process_SignifianceVehicleBase : Process_SignifianceScoreBase
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.HorseEntity> HorseEntities; // 0x98
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.ModularCarEntity> ModularCarEntities; // 0xa0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.TrainCarEntity> TrainCarEntities; // 0xa8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.VehicleEntity> VehicleEntities; // 0xb0
	System.Void Init(WizardGames.Soc.Common.Contexts.Context context, System.Int32 InPoolSize, SignifianceBucketConf& InBucketConf, SignifianceScoreConf& InScoreConf, System.Collections.Generic.Dictionary<System.Int32,System.Int32> InEntityBaseScore, System.Func<System.Int32,SignifianceBucketConf> InFuncGetBucketConf); // 0x06ee1070
	System.Void NotifyToken(System.Int64 InId, System.Int32 InToken); // 0x06ee12a8
	System.Void CalcEntityScores(System.Int64 playerId, UnityEngine.Vector2 playerPos, UnityEngine.Vector2 playerForward); // 0x06ee13d4
	System.Void .ctor(); // 0x06ed871c
}

// Client.Runtime
struct SignifianceBucketConf : System.ValueType
{
	static System.String AnimBucketType = "anim";
	static System.String ResBucketType = "res";
	static System.String EffectBucketType = "effect";
	static System.String FootstepBucketType = "footstep";
	static System.String EffectBucketTypePC = "effect_pc";
	static System.String CharBucketType = "char";
	static System.String VehicleBucketType = "vehicle";
	System.Int32 BucketToken; // 0x10
	System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>[] BucketList; // 0x18
	
}

// Client.Runtime
class SignifianceBucket : System.Object
{
	System.Int32 Token; // 0x10
	System.Int32 CurCapcity; // 0x14
	System.Collections.Generic.List<System.Int64> Data; // 0x18
	System.Void Init(System.Int32 InCapcity, System.Int32 InToken); // 0x06ee155c
	System.Void .ctor(); // 0x06ee162c
}

// Client.Runtime
class SignifianceBucketCount : System.Object
{
	System.Int32 Token; // 0x10
	System.Int32 Capcity; // 0x14
	System.Int32 CurLeft; // 0x18
	System.Int32 CurCount; // 0x1c
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> GridData; // 0x20
	System.Void Init(System.Int32 InCapcity, System.Int32 InToken); // 0x06edcb78
	System.Void Add(System.Int32 InCount, System.Int32 InGridIdx); // 0x06eddfbc
	System.Void Clear(); // 0x06eddf30
	System.Void .ctor(); // 0x06edcac0
}

// Client.Runtime
class SignifianceEffectBucketCount : System.Object
{
	System.Int32 Token; // 0x10
	System.Int32 Capcity; // 0x14
	System.Int32 CurCount; // 0x18
	System.Int32 get_CurLeft(); // 0x06ee1694
	System.Void Init(System.Int32 InCapcity, System.Int32 InToken); // 0x06ee16fc
	System.Void Add(System.Int64 effectId, System.Int32 occupyCount); // 0x06ee1780
	System.Void Clear(); // 0x06ee1808
	System.Void .ctor(); // 0x06ee186c
}

// Client.Runtime
interface ISignifianceProcess : 
{
	
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetActiveResult(); // 0x054e7844
	System.Boolean TryCalcScoreDict(System.Collections.Generic.Dictionary<System.Int64,System.Int32>& scoreDict); // 0x054dec74
	System.Void NotifyToken(System.Int64 InId, System.Int32 InToken); // 0x055112d4
	System.Void NotifyQualityChange(System.Int32 InQualityLvl); // 0x055056e8
}

// Client.Runtime
class SignifianceComp : System.Object
{
	System.Boolean IsInit; // 0x10
	System.Int32 CurQualityLvl; // 0x14
	System.Collections.Generic.List<SignifianceBucket> Buckets; // 0x18
	System.Int32 Duration; // 0x20
	System.Int32 CurTime; // 0x24
	PriorityQueue<System.Int64> SortedResult; // 0x28
	System.Collections.Generic.List<System.Int64> ExceedBudget; // 0x30
	ISignifianceProcess Process; // 0x38
	System.Void Init(SignifianceBucketConf& InConf, System.Int32 PoolSize, ISignifianceProcess InProcess); // 0x06edf31c
	System.Void InitBucket(SignifianceBucketConf& InConf); // 0x06edfce4
	System.Boolean Update(System.Int32 DeltaTime); // 0x06edf488
	System.Void .ctor(); // 0x06edf2ac
}

// Client.Runtime
class SignifianceDbgDrawItem : UnityEngine.MonoBehaviour
{
	System.Int64 EntityId; // 0x30
	System.Int64 EffectId; // 0x38
	UnityEngine.Canvas Canvas; // 0x40
	UnityEngine.RectTransform GrpRect; // 0x48
	TMPro.TMP_Text MeshScore; // 0x50
	TMPro.TMP_Text MeshLod; // 0x58
	TMPro.TMP_Text AnimScore; // 0x60
	TMPro.TMP_Text AnimLod; // 0x68
	TMPro.TMP_Text EntityIdText; // 0x70
	UnityEngine.GameObject Target; // 0x78
	System.Single FarDistance; // 0x80
	UnityEngine.Vector3 OriginScale; // 0x84
	UnityEngine.Color AnimColor; // 0x90
	UnityEngine.Color MeshColor; // 0xa0
	System.Void Clear(); // 0x06ee18d4
	System.Void Init(System.Int64 InEntityId); // 0x06ee1a18
	System.Void InitEffect(System.Int64 effectId); // 0x06ee1bd0
	System.Int32 InternalUpdate(); // 0x06ee1d84
	System.Void SetMeshScore(System.Int32 InMeshScore, System.Boolean isEffect); // 0x06ee23c0
	System.Void SetMeshLod(System.Int32 InMeshLod); // 0x06ee2524
	System.Void SetAnimScore(System.Int32 InAnimScore); // 0x06ee265c
	System.Void SetAnimLod(System.Int32 InAnimLod); // 0x06ee26d0
	System.Void .ctor(); // 0x06ee2744
}

// Client.Runtime
class MgrSignifianceDbgDraw : WizardGames.Soc.Common.Manager.MgrBase
{
	static System.Int32 MAX_CAPCITY; // 0x0
	System.Boolean IsInited; // 0x11
	System.String PrefabPath; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,SignifianceDbgDrawItem> ItemDict; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,SignifianceDbgDrawItem> EffectItemDict; // 0x28
	System.Collections.Generic.List<System.Int64> ToRemoveList; // 0x30
	System.Collections.Generic.List<System.Int64> ToRemoveEffectList; // 0x38
	System.String PanelPrefabPath; // 0x40
	SignificanceDbgPanel panel; // 0x48
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06ee27fc
	System.Threading.Tasks.Task OnExitWorld(); // 0x06ee29a8
	System.Void Destroy(); // 0x06ee2a20
	System.Void Active(); // 0x06ee286c
	System.Void SyncLodGroupData(System.Int64 entityId, SignifianceEntityResultBehaviour lodResult); // 0x06ed9938
	System.Void SyncLodGroupDataUtil(System.Int64 entityId, System.Single screenBodyRatio, System.Single distance, System.Single angle); // 0x06ee2f68
	System.Void SyncModelScoreWithLodData(System.Int64 entityId, System.Int32 modelScore, System.Int32 lodScore); // 0x06ed9840
	System.Void SyncEffectLodData(System.Int64 effectId, System.Int32 effectScore, System.Int32 lodScore, System.Single angle, System.Single distance); // 0x06ee307c
	System.Single CalculateAngle2Player(UnityEngine.Vector3 playerPos, UnityEngine.Vector3 camForward, UnityEngine.Vector3 targetPos); // 0x06ee2d10
	System.Void Clear(); // 0x06ee2aac
	System.Void SetEffectScore(System.Int64 InEntityId, System.Int32 InScore); // 0x06ee342c
	System.Void SetEffectLod(System.Int64 InEntityId, System.Int32 InLod); // 0x06ee3500
	System.Void SetMeshScore(System.Int64 InEntityId, System.Int32 InScore); // 0x06ed976c
	System.Void SetMeshLod(System.Int64 InEntityId, System.Int32 InLod); // 0x06ed969c
	System.Void SetAnimScore(System.Int64 InEntityId, System.Int32 InScore); // 0x06ed6924
	System.Void SetAnimLod(System.Int64 InEntityId, System.Int32 InLod); // 0x06ed69f4
	System.Void Add(System.Int64 InEntityId); // 0x06ed67f0
	System.Void Remove(System.Int64 InEntityId); // 0x06ed951c
	System.Void AddEffect(System.Int64 effectId); // 0x06ee38b8
	System.Void RemoveEffect(System.Int64 effectId); // 0x06ee39ec
	System.Void ClearEffects(); // 0x06ee319c
	SignifianceDbgDrawItem CreateItem(); // 0x06ee35d0
	System.Void OnFps10Update(); // 0x06ee3b6c
	System.Void .ctor(); // 0x06ee40a4
	static System.Void .cctor(); // 0x06ee4220
}

// Client.Runtime
class SignifianceEffectComp : System.Object
{
	static SocLogger Logger; // 0x0
	SignifianceBucketConf bucketConf; // 0x10
	System.Collections.Generic.List<SignifianceEffectBucketCount> budgetList; // 0x20
	System.Boolean <IsEffectBucketEnabled>k__BackingField; // 0x28
	System.Single maxDisplayDistanceScale; // 0x2c
	System.Boolean get_IsEffectBucketEnabled(); // 0x06ee426c
	System.Void set_IsEffectBucketEnabled(System.Boolean value); // 0x06ee42d0
	System.Single get_MaxDisplayDistanceScale(); // 0x06ee434c
	System.Void InitDeviceQualityConfig(System.Int32 effectlevel); // 0x06ee43b0
	System.Void RefreshAllEffects(System.Collections.Generic.List<Effect.BaseEffectItem> showEffects); // 0x06ee486c
	System.Boolean AddEffect(Effect.BaseEffectItem baseEffectItem); // 0x06ee4a70
	System.Void .ctor(); // 0x06ee4bec
	static System.Void .cctor(); // 0x06ee4ca0
}

// Client.Runtime
enum ESignifianceVisibleStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static ESignifianceVisibleStatus Visible = 0;
	static ESignifianceVisibleStatus Occlusion = 1;
	static ESignifianceVisibleStatus Culling = 2;
	
}

// Client.Runtime
class SignifianceEntityResultBehaviour : UnityEngine.MonoBehaviour
{
	static System.Single OCCLUSION_DISTANCE = 10;
	static System.Int32 HIDE_LAST_TIME = 10;
	System.Single RelativeHeight; // 0x30
	System.Single Distance; // 0x34
	System.Int32 EngineLod; // 0x38
	System.Int32 Score; // 0x3c
	System.Int32 ScoreLod; // 0x40
	ESignifianceVisibleStatus VisibleStatus; // 0x44
	System.Int32 VisibleLastFrames; // 0x48
	System.Int32 LodHideLastFrames; // 0x4c
	UnityEngine.LODCustomCalculation Calculation; // 0x50
	System.Int32 get_RealLod(); // 0x070b49c0
	System.Void OnDestroy(); // 0x070b4a64
	System.Void SetEngineLodByMask(System.Int32 engineLodMask); // 0x070b4acc
	System.Void SetVisibleStatusAndScore(ESignifianceVisibleStatus visibleStatus, System.Int32 score); // 0x070b4cd4
	System.Void .ctor(); // 0x070b4da0
}

// Client.Runtime
class SignifianceGrid<T> : System.Object
{
	System.Collections.Generic.Dictionary<System.Int32,T> Cells; // 0x0
	System.Single CellSize; // 0x0
	System.Single CellSizeHalf; // 0x0
	System.Single CellSizeInverse; // 0x0
	System.Single CellArea; // 0x0
	System.Int32 CellCount; // 0x0
	System.Int32 CellCountHalf; // 0x0
	UnityEngine.Rect GridRect; // 0x0
	System.Void .ctor(UnityEngine.Rect InRect, System.Single InGridSize, System.Single InCellSize); // 0x0551d0d8
	System.Void Clear(); // 0x055049cc
	System.Void RemoveCell(System.Int32 InIdx); // 0x055056e8
	T GetCell(System.Int32 InIdx); // 0x052af1f0
	System.Int32 CalcGridSingleIdx(System.Single InX, System.Single InY); // 0x0548cd2c
	System.Void CalcGridCoords(System.Single InX, System.Single InY, System.Int32& OutIdx, WizardGames.Soc.Common.Framework.Algorithm.Vector2i& OutGridIdx); // 0x05513e5c
	System.Void CalcNearbyCellRect(System.Int32 InIdx, System.Single InRange, Recti& OutRect); // 0x055087c8
	UnityEngine.Vector2 CalcCellPos(System.Int32 InIdx); // 0x054b836c
	System.Int32 CalcGridSingleIdx(UnityEngine.Vector3 InPos); // 0x0548cf60
}

// Client.Runtime
class SignifianceGridCell : System.Object
{
	System.Int32 Idx; // 0x10
	System.Single Size; // 0x14
	System.Single DistanceXZ; // 0x18
	System.Single Timestamp; // 0x1c
	System.Int32 LastLod; // 0x20
	System.Int32 CurLod; // 0x24
	System.Boolean IsDirty; // 0x28
	System.Boolean IsInit; // 0x29
	System.Boolean IsGpuInited; // 0x2a
	System.Single AvoidFlashTime; // 0x2c
	UnityEngine.Vector2 Position; // 0x30
	WizardGames.Soc.Stl.SocDict<System.Int64,UnityEngine.Rendering.Universal.ObjectRenderInfo> ItemDict; // 0x38
	WizardGames.Soc.Stl.SocDict<System.Int32,System.Int32> ItemCount; // 0x40
	UnityEngine.Rendering.Universal.GPUObjectRenderer.BlockInfo BlockInfo; // 0x48
	System.Int32 get_Count(); // 0x070b4e30
	System.Void Init(UnityEngine.Vector2 InPos, System.Single InSize, System.Int32 InIdx); // 0x070b4eb4
	System.Void Clear(); // 0x070b4f78
	UnityEngine.Rendering.Universal.ObjectRenderInfo Add(System.Int64 InId, System.Int32 InInstanceId, System.Int32 InEntityType, UnityEngine.GameObject InPrefab, UnityEngine.Transform InTransform); // 0x070b51ec
	System.Void Remove(System.Int64 InId, System.Int32 InEntityType); // 0x070b5440
	UnityEngine.Rendering.Universal.ObjectRenderInfo GetRenderInfo(System.Int64 InId); // 0x070b55f8
	System.Void PrepareBlockInfo(); // 0x070b56ac
	System.Void .ctor(); // 0x070b5978
}

// Client.Runtime
struct Recti : System.ValueType
{
	System.Int32 X; // 0x10
	System.Int32 Y; // 0x14
	System.Int32 width; // 0x18
	System.Int32 height; // 0x1c
	System.Int32 get_xMax(); // 0x070b5ad8
	System.Void set_xMax(System.Int32 value); // 0x070b5b44
	System.Int32 get_yMax(); // 0x070b5bc4
	System.Void set_yMax(System.Int32 value); // 0x070b5c30
}

// Client.Runtime
class SignifianceUtil : System.Object
{
	
	static System.Int32 ConvertQualityToBucketLvl(WizardGames.Soc.RMQualityLevel InQuality); // 0x070b5cb0
	static WizardGames.Soc.Common.Data.signifiance.SignifianceBucketSize GetBucketSize(System.String bucketType, System.Int32 level); // 0x070b5e30
	static WizardGames.Soc.Common.Data.signifiance.SignifianceBucketTypeScore GetBucketTypeScore(System.String bucketType, System.Int32 bucketCategory); // 0x070b60a0
}

// Client.Runtime
class PoolElementRegister : System.Object
{
	
	static System.Void Init(); // 0x070b6310
}

// Client.Runtime
class PoolElementRegister.<>c : System.Object
{
	static PoolElementRegister.<>c <>9; // 0x0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_0; // 0x8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_1; // 0x10
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_2; // 0x18
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_3; // 0x20
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_4; // 0x28
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_5; // 0x30
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_6; // 0x38
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_7; // 0x40
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_8; // 0x48
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_9; // 0x50
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_10; // 0x58
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_11; // 0x60
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_12; // 0x68
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_13; // 0x70
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_14; // 0x78
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_15; // 0x80
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_16; // 0x88
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_17; // 0x90
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_18; // 0x98
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_19; // 0xa0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_20; // 0xa8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_21; // 0xb0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_22; // 0xb8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_23; // 0xc0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_24; // 0xc8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_25; // 0xd0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_26; // 0xd8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_27; // 0xe0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_28; // 0xe8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_29; // 0xf0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_30; // 0xf8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_31; // 0x100
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_32; // 0x108
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_33; // 0x110
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_34; // 0x118
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_35; // 0x120
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_36; // 0x128
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_37; // 0x130
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_38; // 0x138
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_39; // 0x140
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_40; // 0x148
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_41; // 0x150
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_42; // 0x158
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_43; // 0x160
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_44; // 0x168
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_45; // 0x170
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_46; // 0x178
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_47; // 0x180
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_48; // 0x188
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_49; // 0x190
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_50; // 0x198
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_51; // 0x1a0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_52; // 0x1a8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_53; // 0x1b0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_54; // 0x1b8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_55; // 0x1c0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_56; // 0x1c8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_57; // 0x1d0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_58; // 0x1d8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_59; // 0x1e0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_60; // 0x1e8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_61; // 0x1f0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_62; // 0x1f8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_63; // 0x200
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_64; // 0x208
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_65; // 0x210
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_66; // 0x218
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_67; // 0x220
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_68; // 0x228
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_69; // 0x230
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_70; // 0x238
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_71; // 0x240
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_72; // 0x248
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_73; // 0x250
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_74; // 0x258
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_75; // 0x260
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_76; // 0x268
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_77; // 0x270
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_78; // 0x278
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_79; // 0x280
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_80; // 0x288
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_81; // 0x290
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_82; // 0x298
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_83; // 0x2a0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_84; // 0x2a8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_85; // 0x2b0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_86; // 0x2b8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_87; // 0x2c0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_88; // 0x2c8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_89; // 0x2d0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_90; // 0x2d8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_91; // 0x2e0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_92; // 0x2e8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_93; // 0x2f0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_94; // 0x2f8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_95; // 0x300
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_96; // 0x308
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_97; // 0x310
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_98; // 0x318
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_99; // 0x320
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_100; // 0x328
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_101; // 0x330
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_102; // 0x338
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_103; // 0x340
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_104; // 0x348
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_105; // 0x350
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_106; // 0x358
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_107; // 0x360
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_108; // 0x368
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_109; // 0x370
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_110; // 0x378
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_111; // 0x380
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_112; // 0x388
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_113; // 0x390
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_114; // 0x398
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_115; // 0x3a0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_116; // 0x3a8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_117; // 0x3b0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_118; // 0x3b8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_119; // 0x3c0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_120; // 0x3c8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_121; // 0x3d0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_122; // 0x3d8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_123; // 0x3e0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_124; // 0x3e8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_125; // 0x3f0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_126; // 0x3f8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_127; // 0x400
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_128; // 0x408
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_129; // 0x410
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_130; // 0x418
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_131; // 0x420
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_132; // 0x428
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_133; // 0x430
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_134; // 0x438
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_135; // 0x440
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_136; // 0x448
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_137; // 0x450
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_138; // 0x458
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_139; // 0x460
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_140; // 0x468
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_141; // 0x470
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_142; // 0x478
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_143; // 0x480
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_144; // 0x488
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_145; // 0x490
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_146; // 0x498
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_147; // 0x4a0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_148; // 0x4a8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_149; // 0x4b0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_150; // 0x4b8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_151; // 0x4c0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_152; // 0x4c8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_153; // 0x4d0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_154; // 0x4d8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_155; // 0x4e0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_156; // 0x4e8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_157; // 0x4f0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_158; // 0x4f8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_159; // 0x500
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_160; // 0x508
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_161; // 0x510
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_162; // 0x518
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_163; // 0x520
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_164; // 0x528
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_165; // 0x530
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_166; // 0x538
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_167; // 0x540
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_168; // 0x548
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_169; // 0x550
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_170; // 0x558
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_171; // 0x560
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_172; // 0x568
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_173; // 0x570
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_174; // 0x578
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_175; // 0x580
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_176; // 0x588
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_177; // 0x590
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_178; // 0x598
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_179; // 0x5a0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_180; // 0x5a8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_181; // 0x5b0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_182; // 0x5b8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_183; // 0x5c0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_184; // 0x5c8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_185; // 0x5d0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_186; // 0x5d8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_187; // 0x5e0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_188; // 0x5e8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_189; // 0x5f0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_190; // 0x5f8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_191; // 0x600
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_192; // 0x608
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_193; // 0x610
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_194; // 0x618
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_195; // 0x620
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_196; // 0x628
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_197; // 0x630
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_198; // 0x638
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_199; // 0x640
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_200; // 0x648
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_201; // 0x650
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_202; // 0x658
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_203; // 0x660
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_204; // 0x668
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_205; // 0x670
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_206; // 0x678
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_207; // 0x680
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_208; // 0x688
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_209; // 0x690
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_210; // 0x698
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_211; // 0x6a0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_212; // 0x6a8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_213; // 0x6b0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_214; // 0x6b8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_215; // 0x6c0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_216; // 0x6c8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_217; // 0x6d0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_218; // 0x6d8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_219; // 0x6e0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_220; // 0x6e8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_221; // 0x6f0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_222; // 0x6f8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_223; // 0x700
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_224; // 0x708
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_225; // 0x710
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_226; // 0x718
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_227; // 0x720
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_228; // 0x728
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_229; // 0x730
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_230; // 0x738
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_231; // 0x740
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_232; // 0x748
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_233; // 0x750
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_234; // 0x758
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_235; // 0x760
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_236; // 0x768
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_237; // 0x770
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_238; // 0x778
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_239; // 0x780
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_240; // 0x788
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_241; // 0x790
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_242; // 0x798
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_243; // 0x7a0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_244; // 0x7a8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_245; // 0x7b0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_246; // 0x7b8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_247; // 0x7c0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_248; // 0x7c8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_249; // 0x7d0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_250; // 0x7d8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_251; // 0x7e0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_252; // 0x7e8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_253; // 0x7f0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_254; // 0x7f8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_255; // 0x800
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_256; // 0x808
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_257; // 0x810
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_258; // 0x818
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_259; // 0x820
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_260; // 0x828
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_261; // 0x830
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_262; // 0x838
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_263; // 0x840
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_264; // 0x848
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_265; // 0x850
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_266; // 0x858
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_267; // 0x860
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_268; // 0x868
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_269; // 0x870
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_270; // 0x878
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_271; // 0x880
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_272; // 0x888
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_273; // 0x890
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_274; // 0x898
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_275; // 0x8a0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_276; // 0x8a8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_277; // 0x8b0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_278; // 0x8b8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_279; // 0x8c0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_280; // 0x8c8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_281; // 0x8d0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_282; // 0x8d8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_283; // 0x8e0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_284; // 0x8e8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_285; // 0x8f0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_286; // 0x8f8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_287; // 0x900
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_288; // 0x908
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_289; // 0x910
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_290; // 0x918
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_291; // 0x920
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_292; // 0x928
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_293; // 0x930
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_294; // 0x938
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_295; // 0x940
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_296; // 0x948
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_297; // 0x950
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_298; // 0x958
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_299; // 0x960
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_300; // 0x968
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_301; // 0x970
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_302; // 0x978
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_303; // 0x980
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_304; // 0x988
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_305; // 0x990
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_306; // 0x998
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_307; // 0x9a0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_308; // 0x9a8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_309; // 0x9b0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_310; // 0x9b8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_311; // 0x9c0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_312; // 0x9c8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_313; // 0x9d0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_314; // 0x9d8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_315; // 0x9e0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_316; // 0x9e8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_317; // 0x9f0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_318; // 0x9f8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_319; // 0xa00
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_320; // 0xa08
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_321; // 0xa10
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_322; // 0xa18
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_323; // 0xa20
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_324; // 0xa28
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_325; // 0xa30
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_326; // 0xa38
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_327; // 0xa40
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_328; // 0xa48
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_329; // 0xa50
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_330; // 0xa58
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_331; // 0xa60
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_332; // 0xa68
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_333; // 0xa70
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_334; // 0xa78
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_335; // 0xa80
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_336; // 0xa88
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_337; // 0xa90
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_338; // 0xa98
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_339; // 0xaa0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_340; // 0xaa8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_341; // 0xab0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_342; // 0xab8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_343; // 0xac0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_344; // 0xac8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_345; // 0xad0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_346; // 0xad8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_347; // 0xae0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_348; // 0xae8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_349; // 0xaf0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_350; // 0xaf8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_351; // 0xb00
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_352; // 0xb08
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_353; // 0xb10
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_354; // 0xb18
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_355; // 0xb20
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_356; // 0xb28
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_357; // 0xb30
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_358; // 0xb38
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_359; // 0xb40
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_360; // 0xb48
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_361; // 0xb50
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_362; // 0xb58
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_363; // 0xb60
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_364; // 0xb68
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_365; // 0xb70
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_366; // 0xb78
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_367; // 0xb80
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_368; // 0xb88
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_369; // 0xb90
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_370; // 0xb98
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_371; // 0xba0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_372; // 0xba8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_373; // 0xbb0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_374; // 0xbb8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_375; // 0xbc0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_376; // 0xbc8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_377; // 0xbd0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_378; // 0xbd8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_379; // 0xbe0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_380; // 0xbe8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_381; // 0xbf0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_382; // 0xbf8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_383; // 0xc00
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_384; // 0xc08
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_385; // 0xc10
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_386; // 0xc18
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_387; // 0xc20
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_388; // 0xc28
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_389; // 0xc30
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_390; // 0xc38
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_391; // 0xc40
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_392; // 0xc48
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_393; // 0xc50
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_394; // 0xc58
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_395; // 0xc60
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_396; // 0xc68
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_397; // 0xc70
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_398; // 0xc78
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_399; // 0xc80
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_400; // 0xc88
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_401; // 0xc90
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_402; // 0xc98
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_403; // 0xca0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_404; // 0xca8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_405; // 0xcb0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_406; // 0xcb8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_407; // 0xcc0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_408; // 0xcc8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_409; // 0xcd0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_410; // 0xcd8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_411; // 0xce0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_412; // 0xce8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_413; // 0xcf0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_414; // 0xcf8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_415; // 0xd00
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_416; // 0xd08
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_417; // 0xd10
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_418; // 0xd18
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_419; // 0xd20
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_420; // 0xd28
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_421; // 0xd30
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_422; // 0xd38
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_423; // 0xd40
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_424; // 0xd48
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_425; // 0xd50
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_426; // 0xd58
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_427; // 0xd60
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_428; // 0xd68
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_429; // 0xd70
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_430; // 0xd78
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_431; // 0xd80
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_432; // 0xd88
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_433; // 0xd90
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_434; // 0xd98
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_435; // 0xda0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_436; // 0xda8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_437; // 0xdb0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_438; // 0xdb8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_439; // 0xdc0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_440; // 0xdc8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_441; // 0xdd0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_442; // 0xdd8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_443; // 0xde0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_444; // 0xde8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_445; // 0xdf0
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_446; // 0xdf8
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_447; // 0xe00
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_448; // 0xe08
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_449; // 0xe10
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_450; // 0xe18
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_451; // 0xe20
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_452; // 0xe28
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_453; // 0xe30
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_454; // 0xe38
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_455; // 0xe40
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_456; // 0xe48
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_457; // 0xe50
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_458; // 0xe58
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_459; // 0xe60
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_460; // 0xe68
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_461; // 0xe70
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_462; // 0xe78
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_463; // 0xe80
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_464; // 0xe88
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_465; // 0xe90
	static WizardGames.Soc.Common.MemCreateFunc <>9__0_466; // 0xe98
	static System.Void .cctor(); // 0x070d0bb0
	System.Void .ctor(); // 0x070d0c14
	System.Object <Init>b__0_0(); // 0x070d0c7c
	System.Object <Init>b__0_1(); // 0x070d0d08
	System.Object <Init>b__0_2(); // 0x070d0d94
	System.Object <Init>b__0_3(); // 0x070d0e20
	System.Object <Init>b__0_4(); // 0x070d0eac
	System.Object <Init>b__0_5(); // 0x070d0f38
	System.Object <Init>b__0_6(); // 0x070d0fc4
	System.Object <Init>b__0_7(); // 0x070d1050
	System.Object <Init>b__0_8(); // 0x070d10dc
	System.Object <Init>b__0_9(); // 0x070d1168
	System.Object <Init>b__0_10(); // 0x070d11f4
	System.Object <Init>b__0_11(); // 0x070d1280
	System.Object <Init>b__0_12(); // 0x070d130c
	System.Object <Init>b__0_13(); // 0x070d1398
	System.Object <Init>b__0_14(); // 0x070d1424
	System.Object <Init>b__0_15(); // 0x070d14b0
	System.Object <Init>b__0_16(); // 0x070d153c
	System.Object <Init>b__0_17(); // 0x070d15c8
	System.Object <Init>b__0_18(); // 0x070d1654
	System.Object <Init>b__0_19(); // 0x070d16e0
	System.Object <Init>b__0_20(); // 0x070d176c
	System.Object <Init>b__0_21(); // 0x070d17f8
	System.Object <Init>b__0_22(); // 0x070d1884
	System.Object <Init>b__0_23(); // 0x070d1910
	System.Object <Init>b__0_24(); // 0x070d199c
	System.Object <Init>b__0_25(); // 0x070d1a28
	System.Object <Init>b__0_26(); // 0x070d1ab4
	System.Object <Init>b__0_27(); // 0x070d1b40
	System.Object <Init>b__0_28(); // 0x070d1bcc
	System.Object <Init>b__0_29(); // 0x070d1c58
	System.Object <Init>b__0_30(); // 0x070d1ce4
	System.Object <Init>b__0_31(); // 0x070d1d70
	System.Object <Init>b__0_32(); // 0x070d1dfc
	System.Object <Init>b__0_33(); // 0x070d1e88
	System.Object <Init>b__0_34(); // 0x070d1f14
	System.Object <Init>b__0_35(); // 0x070d1fa0
	System.Object <Init>b__0_36(); // 0x070d202c
	System.Object <Init>b__0_37(); // 0x070d20b8
	System.Object <Init>b__0_38(); // 0x070d2144
	System.Object <Init>b__0_39(); // 0x070d21d0
	System.Object <Init>b__0_40(); // 0x070d225c
	System.Object <Init>b__0_41(); // 0x070d22e8
	System.Object <Init>b__0_42(); // 0x070d2374
	System.Object <Init>b__0_43(); // 0x070d2400
	System.Object <Init>b__0_44(); // 0x070d248c
	System.Object <Init>b__0_45(); // 0x070d2518
	System.Object <Init>b__0_46(); // 0x070d25a4
	System.Object <Init>b__0_47(); // 0x070d2630
	System.Object <Init>b__0_48(); // 0x070d26bc
	System.Object <Init>b__0_49(); // 0x070d2748
	System.Object <Init>b__0_50(); // 0x070d27d4
	System.Object <Init>b__0_51(); // 0x070d2860
	System.Object <Init>b__0_52(); // 0x070d28ec
	System.Object <Init>b__0_53(); // 0x070d2978
	System.Object <Init>b__0_54(); // 0x070d2a04
	System.Object <Init>b__0_55(); // 0x070d2a90
	System.Object <Init>b__0_56(); // 0x070d2b1c
	System.Object <Init>b__0_57(); // 0x070d2ba8
	System.Object <Init>b__0_58(); // 0x070d2c34
	System.Object <Init>b__0_59(); // 0x070d2cc0
	System.Object <Init>b__0_60(); // 0x070d2d4c
	System.Object <Init>b__0_61(); // 0x070d2dd8
	System.Object <Init>b__0_62(); // 0x070d2e64
	System.Object <Init>b__0_63(); // 0x070d2ef0
	System.Object <Init>b__0_64(); // 0x070d2f7c
	System.Object <Init>b__0_65(); // 0x070d3008
	System.Object <Init>b__0_66(); // 0x070d3094
	System.Object <Init>b__0_67(); // 0x070d3120
	System.Object <Init>b__0_68(); // 0x070d31ac
	System.Object <Init>b__0_69(); // 0x070d3238
	System.Object <Init>b__0_70(); // 0x070d32c4
	System.Object <Init>b__0_71(); // 0x070d3350
	System.Object <Init>b__0_72(); // 0x070d33dc
	System.Object <Init>b__0_73(); // 0x070d3468
	System.Object <Init>b__0_74(); // 0x070d34f4
	System.Object <Init>b__0_75(); // 0x070d3580
	System.Object <Init>b__0_76(); // 0x070d360c
	System.Object <Init>b__0_77(); // 0x070d3698
	System.Object <Init>b__0_78(); // 0x070d3724
	System.Object <Init>b__0_79(); // 0x070d37b0
	System.Object <Init>b__0_80(); // 0x070d383c
	System.Object <Init>b__0_81(); // 0x070d38c8
	System.Object <Init>b__0_82(); // 0x070d3954
	System.Object <Init>b__0_83(); // 0x070d39e0
	System.Object <Init>b__0_84(); // 0x070d3a6c
	System.Object <Init>b__0_85(); // 0x070d3af8
	System.Object <Init>b__0_86(); // 0x070d3b84
	System.Object <Init>b__0_87(); // 0x070d3c10
	System.Object <Init>b__0_88(); // 0x070d3c9c
	System.Object <Init>b__0_89(); // 0x070d3d28
	System.Object <Init>b__0_90(); // 0x070d3db4
	System.Object <Init>b__0_91(); // 0x070d3e40
	System.Object <Init>b__0_92(); // 0x070d3ecc
	System.Object <Init>b__0_93(); // 0x070d3f58
	System.Object <Init>b__0_94(); // 0x070d3fe4
	System.Object <Init>b__0_95(); // 0x070d4070
	System.Object <Init>b__0_96(); // 0x070d40fc
	System.Object <Init>b__0_97(); // 0x070d4188
	System.Object <Init>b__0_98(); // 0x070d4214
	System.Object <Init>b__0_99(); // 0x070d42a0
	System.Object <Init>b__0_100(); // 0x070d432c
	System.Object <Init>b__0_101(); // 0x070d43b8
	System.Object <Init>b__0_102(); // 0x070d4444
	System.Object <Init>b__0_103(); // 0x070d44d0
	System.Object <Init>b__0_104(); // 0x070d455c
	System.Object <Init>b__0_105(); // 0x070d45e8
	System.Object <Init>b__0_106(); // 0x070d4674
	System.Object <Init>b__0_107(); // 0x070d4700
	System.Object <Init>b__0_108(); // 0x070d478c
	System.Object <Init>b__0_109(); // 0x070d4818
	System.Object <Init>b__0_110(); // 0x070d48a4
	System.Object <Init>b__0_111(); // 0x070d4930
	System.Object <Init>b__0_112(); // 0x070d49bc
	System.Object <Init>b__0_113(); // 0x070d4a48
	System.Object <Init>b__0_114(); // 0x070d4ad4
	System.Object <Init>b__0_115(); // 0x070d4b60
	System.Object <Init>b__0_116(); // 0x070d4bec
	System.Object <Init>b__0_117(); // 0x070d4c78
	System.Object <Init>b__0_118(); // 0x070d4d04
	System.Object <Init>b__0_119(); // 0x070d4d90
	System.Object <Init>b__0_120(); // 0x070d4e1c
	System.Object <Init>b__0_121(); // 0x070d4ea8
	System.Object <Init>b__0_122(); // 0x070d4f34
	System.Object <Init>b__0_123(); // 0x070d4fc0
	System.Object <Init>b__0_124(); // 0x070d504c
	System.Object <Init>b__0_125(); // 0x070d50d8
	System.Object <Init>b__0_126(); // 0x070d5164
	System.Object <Init>b__0_127(); // 0x070d51f0
	System.Object <Init>b__0_128(); // 0x070d527c
	System.Object <Init>b__0_129(); // 0x070d5308
	System.Object <Init>b__0_130(); // 0x070d5394
	System.Object <Init>b__0_131(); // 0x070d5420
	System.Object <Init>b__0_132(); // 0x070d54ac
	System.Object <Init>b__0_133(); // 0x070d5538
	System.Object <Init>b__0_134(); // 0x070d55c4
	System.Object <Init>b__0_135(); // 0x070d5650
	System.Object <Init>b__0_136(); // 0x070d56dc
	System.Object <Init>b__0_137(); // 0x070d5768
	System.Object <Init>b__0_138(); // 0x070d57f4
	System.Object <Init>b__0_139(); // 0x070d5880
	System.Object <Init>b__0_140(); // 0x070d590c
	System.Object <Init>b__0_141(); // 0x070d5998
	System.Object <Init>b__0_142(); // 0x070d5a24
	System.Object <Init>b__0_143(); // 0x070d5ab0
	System.Object <Init>b__0_144(); // 0x070d5b3c
	System.Object <Init>b__0_145(); // 0x070d5bc8
	System.Object <Init>b__0_146(); // 0x070d5c54
	System.Object <Init>b__0_147(); // 0x070d5ce0
	System.Object <Init>b__0_148(); // 0x070d5d6c
	System.Object <Init>b__0_149(); // 0x070d5df8
	System.Object <Init>b__0_150(); // 0x070d5e84
	System.Object <Init>b__0_151(); // 0x070d5f10
	System.Object <Init>b__0_152(); // 0x070d5f9c
	System.Object <Init>b__0_153(); // 0x070d6028
	System.Object <Init>b__0_154(); // 0x070d60b4
	System.Object <Init>b__0_155(); // 0x070d6140
	System.Object <Init>b__0_156(); // 0x070d61cc
	System.Object <Init>b__0_157(); // 0x070d6258
	System.Object <Init>b__0_158(); // 0x070d62e4
	System.Object <Init>b__0_159(); // 0x070d6370
	System.Object <Init>b__0_160(); // 0x070d63fc
	System.Object <Init>b__0_161(); // 0x070d6488
	System.Object <Init>b__0_162(); // 0x070d6514
	System.Object <Init>b__0_163(); // 0x070d65a0
	System.Object <Init>b__0_164(); // 0x070d662c
	System.Object <Init>b__0_165(); // 0x070d66b8
	System.Object <Init>b__0_166(); // 0x070d6744
	System.Object <Init>b__0_167(); // 0x070d67d0
	System.Object <Init>b__0_168(); // 0x070d685c
	System.Object <Init>b__0_169(); // 0x070d68e8
	System.Object <Init>b__0_170(); // 0x070d6974
	System.Object <Init>b__0_171(); // 0x070d6a00
	System.Object <Init>b__0_172(); // 0x070d6a8c
	System.Object <Init>b__0_173(); // 0x070d6b18
	System.Object <Init>b__0_174(); // 0x070d6ba4
	System.Object <Init>b__0_175(); // 0x070d6c30
	System.Object <Init>b__0_176(); // 0x070d6cbc
	System.Object <Init>b__0_177(); // 0x070d6d48
	System.Object <Init>b__0_178(); // 0x070d6dd4
	System.Object <Init>b__0_179(); // 0x070d6e60
	System.Object <Init>b__0_180(); // 0x070d6eec
	System.Object <Init>b__0_181(); // 0x070d6f78
	System.Object <Init>b__0_182(); // 0x070d7004
	System.Object <Init>b__0_183(); // 0x070d7090
	System.Object <Init>b__0_184(); // 0x070d711c
	System.Object <Init>b__0_185(); // 0x070d71a8
	System.Object <Init>b__0_186(); // 0x070d7234
	System.Object <Init>b__0_187(); // 0x070d72c0
	System.Object <Init>b__0_188(); // 0x070d734c
	System.Object <Init>b__0_189(); // 0x070d73d8
	System.Object <Init>b__0_190(); // 0x070d7464
	System.Object <Init>b__0_191(); // 0x070d74f0
	System.Object <Init>b__0_192(); // 0x070d757c
	System.Object <Init>b__0_193(); // 0x070d7608
	System.Object <Init>b__0_194(); // 0x070d7694
	System.Object <Init>b__0_195(); // 0x070d7720
	System.Object <Init>b__0_196(); // 0x070d77ac
	System.Object <Init>b__0_197(); // 0x070d7838
	System.Object <Init>b__0_198(); // 0x070d78c4
	System.Object <Init>b__0_199(); // 0x070d7950
	System.Object <Init>b__0_200(); // 0x070d79dc
	System.Object <Init>b__0_201(); // 0x070d7a68
	System.Object <Init>b__0_202(); // 0x070d7af4
	System.Object <Init>b__0_203(); // 0x070d7b80
	System.Object <Init>b__0_204(); // 0x070d7c0c
	System.Object <Init>b__0_205(); // 0x070d7c98
	System.Object <Init>b__0_206(); // 0x070d7d24
	System.Object <Init>b__0_207(); // 0x070d7db0
	System.Object <Init>b__0_208(); // 0x070d7e3c
	System.Object <Init>b__0_209(); // 0x070d7ec8
	System.Object <Init>b__0_210(); // 0x070d7f54
	System.Object <Init>b__0_211(); // 0x070d7fe0
	System.Object <Init>b__0_212(); // 0x070d806c
	System.Object <Init>b__0_213(); // 0x070d80f8
	System.Object <Init>b__0_214(); // 0x070d8184
	System.Object <Init>b__0_215(); // 0x070d8210
	System.Object <Init>b__0_216(); // 0x070d829c
	System.Object <Init>b__0_217(); // 0x070d8328
	System.Object <Init>b__0_218(); // 0x070d83b4
	System.Object <Init>b__0_219(); // 0x070d8440
	System.Object <Init>b__0_220(); // 0x070d84cc
	System.Object <Init>b__0_221(); // 0x070d8558
	System.Object <Init>b__0_222(); // 0x070d85e4
	System.Object <Init>b__0_223(); // 0x070d8670
	System.Object <Init>b__0_224(); // 0x070d86fc
	System.Object <Init>b__0_225(); // 0x070d8788
	System.Object <Init>b__0_226(); // 0x070d8814
	System.Object <Init>b__0_227(); // 0x070d88a0
	System.Object <Init>b__0_228(); // 0x070d892c
	System.Object <Init>b__0_229(); // 0x070d89b8
	System.Object <Init>b__0_230(); // 0x070d8a44
	System.Object <Init>b__0_231(); // 0x070d8ad0
	System.Object <Init>b__0_232(); // 0x070d8b5c
	System.Object <Init>b__0_233(); // 0x070d8be8
	System.Object <Init>b__0_234(); // 0x070d8c74
	System.Object <Init>b__0_235(); // 0x070d8d00
	System.Object <Init>b__0_236(); // 0x070d8d8c
	System.Object <Init>b__0_237(); // 0x070d8e18
	System.Object <Init>b__0_238(); // 0x070d8ea4
	System.Object <Init>b__0_239(); // 0x070d8f30
	System.Object <Init>b__0_240(); // 0x070d8fbc
	System.Object <Init>b__0_241(); // 0x070d9048
	System.Object <Init>b__0_242(); // 0x070d90d4
	System.Object <Init>b__0_243(); // 0x070d9160
	System.Object <Init>b__0_244(); // 0x070d91ec
	System.Object <Init>b__0_245(); // 0x070d9278
	System.Object <Init>b__0_246(); // 0x070d9304
	System.Object <Init>b__0_247(); // 0x070d9390
	System.Object <Init>b__0_248(); // 0x070d941c
	System.Object <Init>b__0_249(); // 0x070d94a8
	System.Object <Init>b__0_250(); // 0x070d9534
	System.Object <Init>b__0_251(); // 0x070d95c0
	System.Object <Init>b__0_252(); // 0x070d964c
	System.Object <Init>b__0_253(); // 0x070d96d8
	System.Object <Init>b__0_254(); // 0x070d9764
	System.Object <Init>b__0_255(); // 0x070d97f0
	System.Object <Init>b__0_256(); // 0x070d987c
	System.Object <Init>b__0_257(); // 0x070d9908
	System.Object <Init>b__0_258(); // 0x070d9994
	System.Object <Init>b__0_259(); // 0x070d9a20
	System.Object <Init>b__0_260(); // 0x070d9aac
	System.Object <Init>b__0_261(); // 0x070d9b38
	System.Object <Init>b__0_262(); // 0x070d9bc4
	System.Object <Init>b__0_263(); // 0x070d9c50
	System.Object <Init>b__0_264(); // 0x070d9cdc
	System.Object <Init>b__0_265(); // 0x070d9d68
	System.Object <Init>b__0_266(); // 0x070d9df4
	System.Object <Init>b__0_267(); // 0x070d9e80
	System.Object <Init>b__0_268(); // 0x070d9f0c
	System.Object <Init>b__0_269(); // 0x070d9f98
	System.Object <Init>b__0_270(); // 0x070da024
	System.Object <Init>b__0_271(); // 0x070da0b0
	System.Object <Init>b__0_272(); // 0x070da13c
	System.Object <Init>b__0_273(); // 0x070da1c8
	System.Object <Init>b__0_274(); // 0x070da254
	System.Object <Init>b__0_275(); // 0x070da2e0
	System.Object <Init>b__0_276(); // 0x070da36c
	System.Object <Init>b__0_277(); // 0x070da3f8
	System.Object <Init>b__0_278(); // 0x070da484
	System.Object <Init>b__0_279(); // 0x070da510
	System.Object <Init>b__0_280(); // 0x070da59c
	System.Object <Init>b__0_281(); // 0x070da628
	System.Object <Init>b__0_282(); // 0x070da6b4
	System.Object <Init>b__0_283(); // 0x070da740
	System.Object <Init>b__0_284(); // 0x070da7cc
	System.Object <Init>b__0_285(); // 0x070da858
	System.Object <Init>b__0_286(); // 0x070da8e4
	System.Object <Init>b__0_287(); // 0x070da970
	System.Object <Init>b__0_288(); // 0x070da9fc
	System.Object <Init>b__0_289(); // 0x070daa88
	System.Object <Init>b__0_290(); // 0x070dab14
	System.Object <Init>b__0_291(); // 0x070daba0
	System.Object <Init>b__0_292(); // 0x070dac2c
	System.Object <Init>b__0_293(); // 0x070dacb8
	System.Object <Init>b__0_294(); // 0x070dad44
	System.Object <Init>b__0_295(); // 0x070dadd0
	System.Object <Init>b__0_296(); // 0x070dae5c
	System.Object <Init>b__0_297(); // 0x070daee8
	System.Object <Init>b__0_298(); // 0x070daf74
	System.Object <Init>b__0_299(); // 0x070db000
	System.Object <Init>b__0_300(); // 0x070db08c
	System.Object <Init>b__0_301(); // 0x070db118
	System.Object <Init>b__0_302(); // 0x070db1a4
	System.Object <Init>b__0_303(); // 0x070db230
	System.Object <Init>b__0_304(); // 0x070db2bc
	System.Object <Init>b__0_305(); // 0x070db348
	System.Object <Init>b__0_306(); // 0x070db3d4
	System.Object <Init>b__0_307(); // 0x070db460
	System.Object <Init>b__0_308(); // 0x070db4ec
	System.Object <Init>b__0_309(); // 0x070db578
	System.Object <Init>b__0_310(); // 0x070db604
	System.Object <Init>b__0_311(); // 0x070db690
	System.Object <Init>b__0_312(); // 0x070db71c
	System.Object <Init>b__0_313(); // 0x070db7a8
	System.Object <Init>b__0_314(); // 0x070db834
	System.Object <Init>b__0_315(); // 0x070db8c0
	System.Object <Init>b__0_316(); // 0x070db94c
	System.Object <Init>b__0_317(); // 0x070db9d8
	System.Object <Init>b__0_318(); // 0x070dba64
	System.Object <Init>b__0_319(); // 0x070dbaf0
	System.Object <Init>b__0_320(); // 0x070dbb7c
	System.Object <Init>b__0_321(); // 0x070dbc08
	System.Object <Init>b__0_322(); // 0x070dbc94
	System.Object <Init>b__0_323(); // 0x070dbd20
	System.Object <Init>b__0_324(); // 0x070dbdac
	System.Object <Init>b__0_325(); // 0x070dbe38
	System.Object <Init>b__0_326(); // 0x070dbec4
	System.Object <Init>b__0_327(); // 0x070dbf50
	System.Object <Init>b__0_328(); // 0x070dbfdc
	System.Object <Init>b__0_329(); // 0x070dc068
	System.Object <Init>b__0_330(); // 0x070dc0f4
	System.Object <Init>b__0_331(); // 0x070dc180
	System.Object <Init>b__0_332(); // 0x070dc20c
	System.Object <Init>b__0_333(); // 0x070dc298
	System.Object <Init>b__0_334(); // 0x070dc324
	System.Object <Init>b__0_335(); // 0x070dc3b0
	System.Object <Init>b__0_336(); // 0x070dc43c
	System.Object <Init>b__0_337(); // 0x070dc4c8
	System.Object <Init>b__0_338(); // 0x070dc554
	System.Object <Init>b__0_339(); // 0x070dc5e0
	System.Object <Init>b__0_340(); // 0x070dc66c
	System.Object <Init>b__0_341(); // 0x070dc6f8
	System.Object <Init>b__0_342(); // 0x070dc784
	System.Object <Init>b__0_343(); // 0x070dc810
	System.Object <Init>b__0_344(); // 0x070dc89c
	System.Object <Init>b__0_345(); // 0x070dc928
	System.Object <Init>b__0_346(); // 0x070dc9b4
	System.Object <Init>b__0_347(); // 0x070dca40
	System.Object <Init>b__0_348(); // 0x070dcacc
	System.Object <Init>b__0_349(); // 0x070dcb58
	System.Object <Init>b__0_350(); // 0x070dcbe4
	System.Object <Init>b__0_351(); // 0x070dcc70
	System.Object <Init>b__0_352(); // 0x070dccfc
	System.Object <Init>b__0_353(); // 0x070dcd88
	System.Object <Init>b__0_354(); // 0x070dce14
	System.Object <Init>b__0_355(); // 0x070dcea0
	System.Object <Init>b__0_356(); // 0x070dcf2c
	System.Object <Init>b__0_357(); // 0x070dcfb8
	System.Object <Init>b__0_358(); // 0x070dd044
	System.Object <Init>b__0_359(); // 0x070dd0d0
	System.Object <Init>b__0_360(); // 0x070dd15c
	System.Object <Init>b__0_361(); // 0x070dd1e8
	System.Object <Init>b__0_362(); // 0x070dd274
	System.Object <Init>b__0_363(); // 0x070dd300
	System.Object <Init>b__0_364(); // 0x070dd38c
	System.Object <Init>b__0_365(); // 0x070dd418
	System.Object <Init>b__0_366(); // 0x070dd4a4
	System.Object <Init>b__0_367(); // 0x070dd530
	System.Object <Init>b__0_368(); // 0x070dd5bc
	System.Object <Init>b__0_369(); // 0x070dd648
	System.Object <Init>b__0_370(); // 0x070dd6d4
	System.Object <Init>b__0_371(); // 0x070dd760
	System.Object <Init>b__0_372(); // 0x070dd7ec
	System.Object <Init>b__0_373(); // 0x070dd878
	System.Object <Init>b__0_374(); // 0x070dd904
	System.Object <Init>b__0_375(); // 0x070dd990
	System.Object <Init>b__0_376(); // 0x070dda1c
	System.Object <Init>b__0_377(); // 0x070ddaa8
	System.Object <Init>b__0_378(); // 0x070ddb34
	System.Object <Init>b__0_379(); // 0x070ddbc0
	System.Object <Init>b__0_380(); // 0x070ddc4c
	System.Object <Init>b__0_381(); // 0x070ddcd8
	System.Object <Init>b__0_382(); // 0x070ddd64
	System.Object <Init>b__0_383(); // 0x070dddf0
	System.Object <Init>b__0_384(); // 0x070dde7c
	System.Object <Init>b__0_385(); // 0x070ddf08
	System.Object <Init>b__0_386(); // 0x070ddf94
	System.Object <Init>b__0_387(); // 0x070de020
	System.Object <Init>b__0_388(); // 0x070de0ac
	System.Object <Init>b__0_389(); // 0x070de138
	System.Object <Init>b__0_390(); // 0x070de1c4
	System.Object <Init>b__0_391(); // 0x070de250
	System.Object <Init>b__0_392(); // 0x070de2dc
	System.Object <Init>b__0_393(); // 0x070de368
	System.Object <Init>b__0_394(); // 0x070de3f4
	System.Object <Init>b__0_395(); // 0x070de480
	System.Object <Init>b__0_396(); // 0x070de50c
	System.Object <Init>b__0_397(); // 0x070de598
	System.Object <Init>b__0_398(); // 0x070de624
	System.Object <Init>b__0_399(); // 0x070de6b0
	System.Object <Init>b__0_400(); // 0x070de73c
	System.Object <Init>b__0_401(); // 0x070de7c8
	System.Object <Init>b__0_402(); // 0x070de854
	System.Object <Init>b__0_403(); // 0x070de8e0
	System.Object <Init>b__0_404(); // 0x070de96c
	System.Object <Init>b__0_405(); // 0x070de9f8
	System.Object <Init>b__0_406(); // 0x070dea84
	System.Object <Init>b__0_407(); // 0x070deb10
	System.Object <Init>b__0_408(); // 0x070deb9c
	System.Object <Init>b__0_409(); // 0x070dec28
	System.Object <Init>b__0_410(); // 0x070decb4
	System.Object <Init>b__0_411(); // 0x070ded40
	System.Object <Init>b__0_412(); // 0x070dedcc
	System.Object <Init>b__0_413(); // 0x070dee58
	System.Object <Init>b__0_414(); // 0x070deee4
	System.Object <Init>b__0_415(); // 0x070def70
	System.Object <Init>b__0_416(); // 0x070deffc
	System.Object <Init>b__0_417(); // 0x070df088
	System.Object <Init>b__0_418(); // 0x070df114
	System.Object <Init>b__0_419(); // 0x070df1a0
	System.Object <Init>b__0_420(); // 0x070df22c
	System.Object <Init>b__0_421(); // 0x070df2b8
	System.Object <Init>b__0_422(); // 0x070df344
	System.Object <Init>b__0_423(); // 0x070df3d0
	System.Object <Init>b__0_424(); // 0x070df45c
	System.Object <Init>b__0_425(); // 0x070df4e8
	System.Object <Init>b__0_426(); // 0x070df574
	System.Object <Init>b__0_427(); // 0x070df600
	System.Object <Init>b__0_428(); // 0x070df68c
	System.Object <Init>b__0_429(); // 0x070df718
	System.Object <Init>b__0_430(); // 0x070df7a4
	System.Object <Init>b__0_431(); // 0x070df830
	System.Object <Init>b__0_432(); // 0x070df8bc
	System.Object <Init>b__0_433(); // 0x070df948
	System.Object <Init>b__0_434(); // 0x070df9d4
	System.Object <Init>b__0_435(); // 0x070dfa60
	System.Object <Init>b__0_436(); // 0x070dfaec
	System.Object <Init>b__0_437(); // 0x070dfb78
	System.Object <Init>b__0_438(); // 0x070dfc04
	System.Object <Init>b__0_439(); // 0x070dfc90
	System.Object <Init>b__0_440(); // 0x070dfd1c
	System.Object <Init>b__0_441(); // 0x070dfda8
	System.Object <Init>b__0_442(); // 0x070dfe34
	System.Object <Init>b__0_443(); // 0x070dfec0
	System.Object <Init>b__0_444(); // 0x070dff4c
	System.Object <Init>b__0_445(); // 0x070dffd8
	System.Object <Init>b__0_446(); // 0x070e0064
	System.Object <Init>b__0_447(); // 0x070e00f0
	System.Object <Init>b__0_448(); // 0x070e017c
	System.Object <Init>b__0_449(); // 0x070e0208
	System.Object <Init>b__0_450(); // 0x070e0294
	System.Object <Init>b__0_451(); // 0x070e0320
	System.Object <Init>b__0_452(); // 0x070e03ac
	System.Object <Init>b__0_453(); // 0x070e0438
	System.Object <Init>b__0_454(); // 0x070e04c4
	System.Object <Init>b__0_455(); // 0x070e0550
	System.Object <Init>b__0_456(); // 0x070e05dc
	System.Object <Init>b__0_457(); // 0x070e0668
	System.Object <Init>b__0_458(); // 0x070e06f4
	System.Object <Init>b__0_459(); // 0x070e0780
	System.Object <Init>b__0_460(); // 0x070e080c
	System.Object <Init>b__0_461(); // 0x070e0898
	System.Object <Init>b__0_462(); // 0x070e0924
	System.Object <Init>b__0_463(); // 0x070e09b0
	System.Object <Init>b__0_464(); // 0x070e0a3c
	System.Object <Init>b__0_465(); // 0x070e0ac8
	System.Object <Init>b__0_466(); // 0x070e0b54
}

// Client.Runtime
class HeldItemCompareHistory : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void CopyTo(WizardGames.Soc.Common.CustomType.WeaponCustom local, WizardGames.Soc.Common.Entity.HistoryWeaponEntity archiveHistory); // 0x070e0be0
	static System.Void CopyTo(WizardGames.Soc.Common.CustomType.MeleeCustom local, WizardGames.Soc.Common.Entity.HistoryWeaponEntity archiveHistory); // 0x070e11f0
	static System.Void CopyTo(WizardGames.Soc.Common.CustomType.ThrowWeaponCustom local, WizardGames.Soc.Common.Entity.HistoryWeaponEntity archiveHistory); // 0x070e1568
	static System.Void CopyTo(WizardGames.Soc.Common.CustomType.UseItemCustom local, WizardGames.Soc.Common.Entity.HistoryWeaponEntity archiveHistory); // 0x070e169c
	static System.Void CopyTo(WizardGames.Soc.Common.Entity.IHeldItemEntity local, WizardGames.Soc.Common.Entity.HistoryWeaponEntity archiveHistory); // 0x070e17d0
	static System.Void CopyTo(WizardGames.Soc.Common.CustomType.ConstructionItemCustom local, WizardGames.Soc.Common.Entity.HistoryWeaponEntity archiveHistory); // 0x070e19cc
	static System.Void .cctor(); // 0x070e1b00
}

// Client.Runtime
class MyChainSawFpEffectSystem : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x07270b98
}

// Client.Runtime
class TaskBattleUtil : System.Object
{
	static SocLogger logger; // 0x0
	static System.Boolean taskForceMove; // 0x8
	static UnityEngine.Transform targetNode; // 0x10
	static System.Int32 limitTickCount; // 0x18
	static System.Boolean limitYawPitchOn; // 0x1c
	static System.Single TelescopeFov; // 0x20
	static System.Boolean ForbiddenSwitchWeapon; // 0x24
	static System.Boolean SprintJoystickOff; // 0x25
	static System.Void SetPlayerInputable(System.Boolean inputable, System.Boolean alsoSetUITouchable, System.Collections.Generic.List<WizardGames.Soc.Common.Data.ActionName> allowedActions); // 0x07270c00
	static System.Boolean get_TaskForceMove(); // 0x07270eac
	static System.Void set_TaskForceMove(System.Boolean value); // 0x07270f6c
	static System.Void EnablePlayerGoFollowTarget(UnityEngine.Transform tn); // 0x07271030
	static System.Void DisablePlayerGoFollowTarget(); // 0x07271110
	static System.Void UpdatePlayerGoFollowTarget(); // 0x072711a4
	static System.Void GetCutSceneMainGo(System.Collections.Generic.List<WizardGames.Soc.Common.Data.ActionName> allowedActions); // 0x072712f8
	static System.Void ReturnCutSceneMainGo(System.Collections.Generic.List<WizardGames.Soc.Common.Data.ActionName> allowedActions); // 0x072715d4
	static System.Void EnableLimitYawPitch(System.Single minYaw, System.Single maxYaw, System.Single minPitch, System.Single maxPitch, System.Boolean autoCancel); // 0x07271880
	static System.Single GetValidAngle(System.Single angle); // 0x0727201c
	static System.Single GetNearestLerpValue(System.Single curValue, System.Single rangeSideValue); // 0x07271dd0
	static System.Void YawTick(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x072720b0
	static System.Void DisableLimitYawPitch(); // 0x07271ef4
	static System.Void LookAtTargetPos(UnityEngine.Vector3 targetPos, System.Boolean autoCancel); // 0x072723e4
	static System.Void SetCameraFovs(System.Single sceneFov, System.Single duration); // 0x0727261c
	static System.Void EnableForbiddenSwitchWeapon(); // 0x07272778
	static System.Void DisableForbiddenSwitchWeapon(); // 0x07272864
	static System.Void PlayCameraShake(System.String animPath, System.Single animTime); // 0x072728ec
	static System.Boolean GetNewbieSprintJoystickOff(); // 0x07272b6c
	static System.Void AllUITouchEnd(); // 0x07272c2c
	static System.Void .cctor(); // 0x07272d80
}

// Client.Runtime
struct TaskBattleUtil.YawLerpData : System.ValueType
{
	System.Single yawStart; // 0x10
	System.Single yawTotalLerp; // 0x14
	System.Single pitchStart; // 0x18
	System.Single pitchTotalLerp; // 0x1c
	System.Single minYaw; // 0x20
	System.Single maxYaw; // 0x24
	System.Single minPitch; // 0x28
	System.Single maxPitch; // 0x2c
	System.Int32 repeatCount; // 0x30
	System.Boolean autoCancel; // 0x34
	
}

// Client.Runtime
class TaskBattleUtil.<>c : System.Object
{
	static TaskBattleUtil.<>c <>9; // 0x0
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__27_0; // 0x8
	static System.Action<FairyGUI.TouchInfo> <>9__30_0; // 0x10
	static System.Void .cctor(); // 0x07272e74
	System.Void .ctor(); // 0x07272ed8
	System.Void <PlayCameraShake>b__27_0(System.Int64 _, System.Object _, System.Boolean _); // 0x07272f40
	System.Void <AllUITouchEnd>b__30_0(FairyGUI.TouchInfo touch); // 0x07273068
}

// Client.Runtime
class PowerOptimizationUI : UnityEngine.MonoBehaviour
{
	System.Single fps; // 0x30
	UnityEngine.GUIStyle style; // 0x38
	System.Void Start(); // 0x0727310c
	System.Void Update(); // 0x072731f0
	System.Void Awake(); // 0x072732e4
	System.Void .ctor(); // 0x07273370
}

// Client.Runtime
class TestComboConstruction : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver
{
	static System.Int32 ComboId; // 0x0
	static System.Boolean CreateComboPart; // 0x4
	static System.Int32 UpgradeComboPartType; // 0x8
	static System.Int64 ChildPartUpgradeTargetType; // 0x10
	System.Int32 _comboId; // 0x30
	System.Boolean _createComboPart; // 0x34
	System.Int32 _upgradeComboPartType; // 0x38
	System.Int64 _childPartUpgradeTargetType; // 0x40
	System.Void OnAfterDeserialize(); // 0x072733d8
	System.Void OnBeforeSerialize(); // 0x07273474
	System.Void .ctor(); // 0x07273510
}

// Client.Runtime
class TestOfflineGui : UnityEngine.MonoBehaviour
{
	UnityEngine.UI.Button BtnFirstThird; // 0x30
	UnityEngine.UI.Button BtnCameraShake; // 0x38
	System.Void Start(); // 0x07273578
	System.Void .ctor(); // 0x0727374c
}

// Client.Runtime
class TestOfflineGui.<>c : System.Object
{
	static TestOfflineGui.<>c <>9; // 0x0
	static UnityEngine.Events.UnityAction <>9__2_0; // 0x8
	static UnityEngine.Events.UnityAction <>9__2_1; // 0x10
	static System.Void .cctor(); // 0x072737b4
	System.Void .ctor(); // 0x07273818
	System.Void <Start>b__2_0(); // 0x07273880
	System.Void <Start>b__2_1(); // 0x0727391c
}

// Client.Runtime
class ThermalManagementUI : UnityEngine.MonoBehaviour
{
	System.Single _resolutionScale; // 0x30
	UnityEngine.GUIStyle style; // 0x38
	System.Void Start(); // 0x072739dc
	System.Void Awake(); // 0x07273ac0
	System.Void .ctor(); // 0x07273b4c
}

// Client.Runtime
class DraggableUIEvent : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IPointerUpHandler
{
	Vector2Event onPointerDownEvent; // 0x30
	Vector2Event onDragEvent; // 0x38
	Vector2Event onDragEventDelta; // 0x40
	Vector2Event onPointerUpEvent; // 0x48
	System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData); // 0x07273bbc
	System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData); // 0x07273c60
	System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData); // 0x07273d30
	System.Void .ctor(); // 0x07273dd4
}

// Client.Runtime
class Vector2Event : UnityEngine.Events.UnityEvent<UnityEngine.Vector2>
{
	
	System.Void .ctor(); // 0x07273e3c
}

// Client.Runtime
class DollyTrackRuntimeVisualizer : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x07273eb8
}

// Client.Runtime
class QualityManager : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x07273f20
}

// Client.Runtime
class TPNSHelper : System.Object
{
	static UnityEngine.AndroidJavaObject _plugin; // 0x0
	static System.Void .cctor(); // 0x07273f88
	static System.Void AddLocalNotification(System.Int32 id, GUA.GUALocalNotification guaLocalNotification, System.Int64 timestamp); // 0x072741b4
	static System.Void DeleteLocalNotification(System.Int64 timestamp); // 0x0727443c
	static System.String GetOfflinePushCustomContent(); // 0x07274598
	static System.Int64 GetCurrentTimeStamp(); // 0x072746c8
}

// Client.Runtime
class FinishCartoonVideoTrigger : TaskTriggerBase
{
	System.Single requestInterval; // 0x1c
	System.Single remainTime; // 0x20
	System.Void Initalize(TaskTriggerSystem taskTriggerComp, System.Int32 triggerId); // 0x072747e4
	System.Void Update(); // 0x072749f4
	System.Void Clean(); // 0x07274b64
	System.Void OnFinishCartoon(); // 0x07274d2c
	System.Void RefreshTrigger(); // 0x07274f00
	System.Void .ctor(); // 0x0727524c
}

// Client.Runtime
class FinishGameNewbieMissionCGTrigger : TaskTriggerBase
{
	
	System.Void Initalize(TaskTriggerSystem taskTriggerComp, System.Int32 triggerId); // 0x07275344
	System.Void Update(); // 0x07275468
	System.Void Clean(); // 0x072756d8
	System.Void OnFinishCG(); // 0x072757d8
	System.Void .ctor(); // 0x07275890
}

// Client.Runtime
class FinishShowUiTrigger : TaskTriggerBase
{
	
	System.Void Initalize(TaskTriggerSystem taskTriggerComp, System.Int32 triggerId); // 0x07275918
	System.Void Update(); // 0x072759a0
	System.Void Clean(); // 0x07275a7c
	System.Void OnFinishShowUi(); // 0x07275a04
	System.Void .ctor(); // 0x07275ae0
}

// Client.Runtime
class FinishSubtitleTrigger : TaskTriggerBase
{
	
	System.Void Initalize(TaskTriggerSystem taskTriggerComp, System.Int32 triggerId); // 0x07275b68
	System.Void Update(); // 0x07275c8c
	System.Void Clean(); // 0x07275dd8
	System.Void OnFinishSubtitle(); // 0x07275ed8
	System.Void .ctor(); // 0x07276004
}

// Client.Runtime
class FinishTimelineTrigger : TaskTriggerBase
{
	static SocLogger logger; // 0x0
	System.Void Initalize(TaskTriggerSystem taskTriggerComp, System.Int32 triggerId); // 0x0727608c
	System.Void Update(); // 0x072761c4
	System.Void Clean(); // 0x07276224
	System.Void OnFinishTimeline(System.Int64 timelineId); // 0x07276338
	System.Void .ctor(); // 0x072765b8
	static System.Void .cctor(); // 0x07276640
}

// Client.Runtime
class FinishViewGuideTrigger : TaskTriggerBase
{
	System.Single requestInterval; // 0x1c
	System.Single remainTime; // 0x20
	System.Void Initalize(TaskTriggerSystem taskTriggerComp, System.Int32 triggerId); // 0x07276714
	System.Void Update(); // 0x055049cc
	System.Void Clean(); // 0x072768ac
	System.Void OnFinishViewGuide(System.Int32 guideId); // 0x055056e8
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class HitFakeMonster : TaskTriggerBase
{
	
	System.Void Initalize(TaskTriggerSystem taskTriggerComp, System.Int32 triggerId); // 0x07276c34
	System.Void Clean(); // 0x07276d58
	System.Void OnHitFakeMonster(); // 0x07276e58
	System.Void .ctor(); // 0x07276ed0
}

// Client.Runtime
class LookToTargetYaw : TaskTriggerBase
{
	System.Single targetYaw; // 0x1c
	System.Single targetRadius; // 0x20
	System.Void Initalize(TaskTriggerSystem taskTriggerComp, System.Int32 triggerId); // 0x07276f58
	System.Single GetLimitYaw(System.Single yaw); // 0x07277090
	System.Boolean CheckTriggerSuccessUpdate(); // 0x07277130
	System.Void Clean(); // 0x072771fc
	System.Void .ctor(); // 0x07277260
}

// Client.Runtime
class MoveToRect : TaskTriggerBase
{
	static SocLogger logger; // 0x0
	System.Numerics.Vector3 targetPos; // 0x1c
	System.Single rotateY; // 0x28
	System.Numerics.Vector3 rectSize; // 0x2c
	System.Void Initalize(TaskTriggerSystem taskTriggerComp, System.Int32 triggerId); // 0x072772e8
	System.Boolean CheckTriggerSuccessUpdate(); // 0x0727766c
	System.Void Clean(); // 0x07277ad4
	System.Void .ctor(); // 0x07277b38
	static System.Void .cctor(); // 0x07277c00
}

// Client.Runtime
class MoveToTargetPos : TaskTriggerBase
{
	static SocLogger logger; // 0x0
	System.Numerics.Vector3 targetPos; // 0x1c
	System.Single targetRadius; // 0x28
	System.Void Initalize(TaskTriggerSystem taskTriggerComp, System.Int32 triggerId); // 0x07277cd4
	System.Boolean CheckTriggerSuccessUpdate(); // 0x07277e4c
	System.Void Clean(); // 0x072781c8
	System.Void .ctor(); // 0x0727822c
	static System.Void .cctor(); // 0x072782b4
}

// Client.Runtime
class TaskTriggerBase : System.Object
{
	static SocLogger logger; // 0x0
	TaskTriggerSystem taskTriggerComp; // 0x10
	System.Int32 taskTriggerId; // 0x18
	System.Void Initalize(TaskTriggerSystem triggerComp, System.Int32 triggerId); // 0x07274964
	System.Void Update(); // 0x07278388
	System.Boolean CheckTriggerSuccessUpdate(); // 0x07278414
	System.Void Clean(); // 0x07274cb8
	System.Void .ctor(); // 0x072752dc
	static System.Void .cctor(); // 0x07278478
}

// Client.Runtime
class TaskTriggerSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	static SocLogger logger; // 0x0
	System.Int32 taskTriggerId; // 0x28
	System.Collections.Generic.List<TaskTriggerBase> taskTriggerBases; // 0x30
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0727854c
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x072785b0
	System.Void TaskTriggerCheck(); // 0x0727870c
	System.Void CreateTaskTrigger(System.Int32 triggerId); // 0x07278aac
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x07278f30
	System.Void TriggerSuccess(TaskTriggerBase taskTriggerBase); // 0x07275520
	System.Void ReleaseTrigger(TaskTriggerBase taskTriggerBase); // 0x0727518c
	System.Void OnDestroy(); // 0x0727903c
	System.Void .ctor(); // 0x07279210
	static System.Void .cctor(); // 0x072792c4
}

// Client.Runtime
class UiActDebugStopWatch : System.Object
{
	static System.Collections.Generic.Stack<System.Single> startTime; // 0x0
	static System.Void Start(); // 0x07279398
	static System.Single Stop(); // 0x0727944c
	static System.Void .cctor(); // 0x07279524
}

// Client.Runtime
class UiLoopCostDebuger : System.Object
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Stack<UiLoopCostDebuger.UiLoopCostItem> itemStack; // 0x10
	System.Int32 startFrameCount; // 0x18
	UiLoopCostDebuger.UiLoopCostItem <RootItem>k__BackingField; // 0x20
	UiLoopCostDebuger.UiLoopCostItem get_topItem(); // 0x072795bc
	System.Int32 get_RunFrameCount(); // 0x07279648
	UiLoopCostDebuger.UiLoopCostItem get_RootItem(); // 0x072796b8
	System.Void set_RootItem(UiLoopCostDebuger.UiLoopCostItem value); // 0x0727971c
	System.Void .ctor(System.String name); // 0x0727979c
	System.String GetUiName(System.Object ui); // 0x07279b58
	System.Void StartCall(System.String name); // 0x07279cbc
	System.Void StartCall(System.Object ui); // 0x0727a0b4
	System.Void EndCall(System.String name); // 0x0727a13c
	System.Void EndCall(System.Object ui); // 0x0727a628
	static System.Void .cctor(); // 0x0727a6b0
}

// Client.Runtime
class UiLoopCostDebuger.UiLoopCostItem : System.Object
{
	System.Collections.Generic.Dictionary<System.String,UiLoopCostDebuger.UiLoopCostItem> subItems; // 0x10
	System.Single startTime; // 0x18
	System.String Name; // 0x20
	System.Single <TotalCost>k__BackingField; // 0x28
	System.Single <PerCallCost>k__BackingField; // 0x2c
	System.Int32 <CallTimes>k__BackingField; // 0x30
	UiLoopCostDebuger.UiLoopCostItem <ParentItem>k__BackingField; // 0x38
	System.Single get_TotalCost(); // 0x0727a784
	System.Void set_TotalCost(System.Single value); // 0x0727a7e8
	System.Single get_PerCallCost(); // 0x0727a860
	System.Void set_PerCallCost(System.Single value); // 0x0727a8c4
	System.Int32 get_CallTimes(); // 0x0727a93c
	System.Void set_CallTimes(System.Int32 value); // 0x0727a9a0
	UiLoopCostDebuger.UiLoopCostItem get_ParentItem(); // 0x0727aa18
	System.Void set_ParentItem(UiLoopCostDebuger.UiLoopCostItem value); // 0x0727aa7c
	System.Int32 get_SubItemCount(); // 0x0727aafc
	System.Void .ctor(System.String name); // 0x07279994
	System.Void AddSubItem(UiLoopCostDebuger.UiLoopCostItem item); // 0x07279ef4
	UiLoopCostDebuger.UiLoopCostItem GetSubItem(System.String name); // 0x07279e18
	System.Void Start(); // 0x0727a048
	System.Void Stop(); // 0x0727a364
	System.Void GetSortedCostsByTotal(System.Collections.Generic.List<UiLoopCostDebuger.UiLoopCostItem>& res); // 0x0727ab88
}

// Client.Runtime
class UiLoopCostDebuger.UiLoopCostItem.<>c : System.Object
{
	static UiLoopCostDebuger.UiLoopCostItem.<>c <>9; // 0x0
	static System.Comparison<UiLoopCostDebuger.UiLoopCostItem> <>9__27_0; // 0x8
	static System.Void .cctor(); // 0x0727af10
	System.Void .ctor(); // 0x0727af74
	System.Int32 <GetSortedCostsByTotal>b__27_0(UiLoopCostDebuger.UiLoopCostItem a, UiLoopCostDebuger.UiLoopCostItem b); // 0x0727afdc
}

// Client.Runtime
class LoadingScene : UnityEngine.MonoBehaviour
{
	
	System.Void Start(); // 0x0727b104
	System.Void .ctor(); // 0x0727b3d8
}

// Client.Runtime
class LoadingScene.<>c : System.Object
{
	static LoadingScene.<>c <>9; // 0x0
	static System.Func<System.Int32,System.String> <>9__0_0; // 0x8
	static System.Action<System.String,System.Single> <>9__0_1; // 0x10
	static System.Void .cctor(); // 0x0727b440
	System.Void .ctor(); // 0x0727b4a4
	System.String <Start>b__0_0(System.Int32 key); // 0x0727b50c
	System.Void <Start>b__0_1(System.String str, System.Single val); // 0x0727b5ac
}

// Client.Runtime
class MgrClientCondition : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.ClientConditionParser parser; // 0x18
	System.Boolean IgnoreAllUILock; // 0x20
	System.Collections.Generic.Dictionary<System.String,System.Int32> windowsUnlockConditionData; // 0x28
	System.Collections.Generic.Dictionary<System.String,System.Int32> compentsUnlockConditionData; // 0x30
	System.Collections.Generic.HashSet<System.Int32> hudComps; // 0x38
	System.Collections.Generic.Dictionary<System.String,System.Boolean> dicSwitch; // 0x40
	System.Void Init(); // 0x0727b664
	System.Void Destroy(); // 0x0727bc98
	System.Void ReadDataFromTable(); // 0x0727b7b8
	System.Boolean IsHudUnockCompent(System.Int32 hudId); // 0x0727bd5c
	System.Boolean CheckWindowsUnlockCondition(System.String uniqueName, System.Boolean showLockedHit); // 0x0727be04
	System.Boolean CheckCompentsUnlockCondition(System.String compentKey); // 0x0727c308
	System.Void HandleCompentUnlockDisplay(FairyGUI.GObject compent, System.String key, System.Boolean unlock); // 0x0727c474
	System.Void HandleBtnDisplay(FairyGUI.GButton btn, System.Boolean unlock, WizardGames.Soc.Common.Data.Ui.CompentUnlockCondition config); // 0x0727c7e0
	System.Void HandleImageDisplay(FairyGUI.GLoader loader, System.Boolean unlock, WizardGames.Soc.Common.Data.Ui.CompentUnlockCondition config); // 0x0727ca14
	System.Boolean CheckCondition(System.Int32 conditionId); // 0x0727c16c
	System.Boolean CheckHotfixConidtion(System.String key); // 0x0727c090
	System.Void UpdateHotfixKeySwitch(SimpleJSON.JSONNode node); // 0x0727cc60
	System.Void OnLobbyReconnected(); // 0x0727cf1c
	System.Void .ctor(); // 0x0727cfe0
	static System.Void .cctor(); // 0x0727d094
}

// Client.Runtime
class MgrClientCondition.<>c__DisplayClass13_0 : System.Object
{
	MgrClientCondition <>4__this; // 0x10
	WizardGames.Soc.Common.Data.Ui.CompentUnlockCondition config; // 0x18
	System.Void .ctor(); // 0x0727cbf8
	System.Void <HandleBtnDisplay>b__0(FairyGUI.EventContext context); // 0x0727d168
}

// Client.Runtime
class ChildGOCounter : UnityEngine.MonoBehaviour
{
	System.Int32 GameobjectCount; // 0x30
	System.Int32 MeshComCount; // 0x34
	System.Void Start(); // 0x0727d344
	System.Void Count(UnityEngine.Transform trans); // 0x0727d3b8
	System.Void .ctor(); // 0x0727d4f8
}

// Client.Runtime
class SimpleLogin : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	UnityEngine.GameObject checkingBlockLayerGo; // 0x30
	UnityEngine.GameObject localNetLayerGo; // 0x38
	UnityEngine.GameObject outNetLayerGo; // 0x40
	UnityEngine.UI.Button btnDust; // 0x48
	UnityEngine.UI.Button btnRandom; // 0x50
	UnityEngine.UI.Button btnClearCache; // 0x58
	UnityEngine.Transform transContentOffline; // 0x60
	UnityEngine.Transform transTempOffline; // 0x68
	UnityEngine.UI.Toggle onlineToggle; // 0x70
	UnityEngine.UI.Toggle character1Toggle; // 0x78
	System.Void InitLocalNetCanvas(); // 0x0727d560
	System.Void InitOutNetCanvas(); // 0x0727d888
	System.Void DirectEnterGameOnline(System.Int32 sceneId); // 0x0727d9a8
	System.Void Start(); // 0x0727daf4
	System.Void ClearCache(); // 0x0727dbd4
	System.Void OnClickOnline(WizardGames.Soc.Common.Unity.Scene.SceneConfig cfg); // 0x0727de98
	System.Collections.IEnumerator LoadGameSpaceOnline(System.Boolean bOnline); // 0x0727da34
	System.Void .ctor(); // 0x0727dfb4
	static System.Void .cctor(); // 0x0727e01c
	System.Void <InitOutNetCanvas>b__12_0(); // 0x0727e0f0
	System.Void <InitOutNetCanvas>b__12_1(); // 0x0727e158
}

// Client.Runtime
class SimpleLogin.<>c__DisplayClass11_0 : System.Object
{
	WizardGames.Soc.Common.Unity.Scene.SceneConfig cfg; // 0x10
	SimpleLogin <>4__this; // 0x18
	System.Void .ctor(); // 0x0727d820
	System.Void <InitLocalNetCanvas>b__0(); // 0x0727e1c0
}

// Client.Runtime
class SimpleLogin.<LoadGameSpaceOnline>d__17 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.Boolean bOnline; // 0x20
	SimpleLogin <>4__this; // 0x28
	System.Void .ctor(System.Int32 <>1__state); // 0x0727df30
	System.Void System.IDisposable.Dispose(); // 0x0727e230
	System.Boolean MoveNext(); // 0x0727e290
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0727e40c
	System.Void System.Collections.IEnumerator.Reset(); // 0x0727e470
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0727e4f8
}

// Client.Runtime
struct SimpleLogin.<Start>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	SimpleLogin <>4__this; // 0x38
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x40
	System.Void MoveNext(); // 0x0727e55c
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x0727e874
}

// Client.Runtime
class ComCommonMarquee : System.Object
{
	FairyGUI.GTextField textTitle; // 0x10
	System.Single fTitleW; // 0x18
	System.Single fDeltaMove; // 0x1c
	System.Single fDeltaStayStart; // 0x20
	System.Single fDeltaStayEnd; // 0x24
	FairyGUI.GComponent comMarquee; // 0x28
	System.Single fMoveSpeed; // 0x30
	System.Single fStartStayTime; // 0x34
	System.Single fEndStayTime; // 0x38
	System.Boolean isRun; // 0x3c
	System.Single get_fMarqueeW(); // 0x0727e8f4
	System.Void set_strText(System.String value); // 0x0727e998
	System.Void Bind(FairyGUI.GComponent com); // 0x0727eb2c
	System.Void Reset(); // 0x0727ea30
	System.Void DoUpdate(); // 0x0727ec0c
	System.Void .ctor(); // 0x0727ed64
}

// Client.Runtime
class ComCommonScrollBar : FairyGUI.GScrollBar
{
	FairyGUI.Controller ctrlHover; // 0x2c8
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x0727ede4
	System.Void SetScrollPane(FairyGUI.ScrollPane target, System.Boolean vertical); // 0x0727ee98
	System.Void OnScrollOver(); // 0x0727f1c8
	System.Void OnScrollOut(); // 0x0727f244
	System.Void Dispose(); // 0x0727f2c0
	System.Void .ctor(); // 0x0727f5bc
}

// Client.Runtime
class ComRecipeBase : FairyGUI.GComponent
{
	System.Action OnClickIcon; // 0x288
	System.Action OnClick; // 0x290
	WizardGames.Soc.SocClient.Ui.ComItemIcon Icon; // 0x298
	FairyGUI.GTextField Num; // 0x2a0
	FairyGUI.Controller CtrlPressState; // 0x2a8
	System.Void OnClickIconHandler(FairyGUI.EventContext context); // 0x0727f624
	System.Void OnClickHandler(FairyGUI.EventContext context); // 0x0727f6bc
	System.Void SetCommonElement(WizardGames.Soc.SocClient.Ui.ComItemIcon loadIcon, FairyGUI.Controller pressState); // 0x0727f754
	System.Void .ctor(); // 0x0727f834
}

// Client.Runtime
class ComToken : FairyGUI.GButton
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComTokenBinder binder; // 0x318
	WizardGames.Soc.Common.Data.resource.OBJGenaral tokenCfg; // 0x320
	System.Action btnAddClickCallback; // 0x328
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x0727f89c
	System.Void OnSelfClick(FairyGUI.EventContext context); // 0x0727fc98
	System.Void BtnAddClick(FairyGUI.EventContext context); // 0x0727fd7c
	System.Void .ctor(); // 0x0727fe28
}

// Client.Runtime
class ComToken.<>c : System.Object
{
	static ComToken.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__8_0; // 0x8
	static FairyGUI.EventCallback1 <>9__8_1; // 0x10
	static System.Void .cctor(); // 0x0727fe90
	System.Void .ctor(); // 0x0727fef4
	System.Void <ConstructFromXML>b__8_0(FairyGUI.EventContext context); // 0x0727ff5c
	System.Void <ConstructFromXML>b__8_1(FairyGUI.EventContext context); // 0x0727ffe0
}

// Client.Runtime
class MailNavBar : WizardGames.Soc.SocClient.Ui.ComCommonNavBar
{
	
	FairyGUI.GList GetListCom(); // 0x07280064
	System.Void .ctor(); // 0x072800c8
}

// Client.Runtime
class ComPageIndicator : FairyGUI.GComponent
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComPageIndicatorBinder binder; // 0x288
	FairyGUI.GList targetList; // 0x290
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x07280130
	System.Void OnBtnLeftArrowClicked(FairyGUI.EventContext context); // 0x0728036c
	System.Void OnBtnRightArrowClicked(FairyGUI.EventContext context); // 0x072804ac
	System.Void .ctor(); // 0x072805ec
	static System.Void .cctor(); // 0x07280654
}

// Client.Runtime
class SouDJRankPreviewBgSwitch : UnityEngine.MonoBehaviour
{
	UnityEngine.GameObject ModelRoot; // 0x30
	UnityEngine.Camera SceneCamera; // 0x38
	UnityEngine.GameObject[] playerObjArr; // 0x40
	System.Void .ctor(); // 0x07280728
}

// Client.Runtime
class GameTeamPreviewBgSwitch : UnityEngine.MonoBehaviour
{
	UnityEngine.GameObject ModelRoot; // 0x30
	UnityEngine.Camera SceneCamera; // 0x38
	UnityEngine.GameObject[] playerObjArr; // 0x40
	System.Void .ctor(); // 0x07280790
}

// Client.Runtime
class MgrCenterConsole : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<System.Int32> sortedGroup; // 0x18
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.GameConsoleGroupType,System.Collections.Generic.List<System.Int32>> allConsoleSortedData; // 0x20
	System.Collections.Generic.IReadOnlyList<System.Int32> get_SortedGroup(); // 0x072807f8
	System.Void Init(); // 0x0728085c
	System.Void Destroy(); // 0x072808c4
	System.Void CleanUp(); // 0x0728092c
	System.Threading.Tasks.Task OnEnterWorld(); // 0x072809dc
	System.Void ReadDataFromTable(); // 0x07280a4c
	System.Collections.Generic.List<System.Int32> GetGroupDataByGroupType(WizardGames.Soc.Common.Data.GameConsoleGroupType groupType); // 0x072814e8
	System.Boolean IsShowBattleReportAttackRedDot(); // 0x07281608
	System.Boolean IsShowBattleReportDefendRedDot(); // 0x072819b0
	System.Void ClearBattleReportRedDot(System.Int64 id); // 0x07281c8c
	System.String GenerateSaveKey(System.Int64 id); // 0x072818e4
	System.Int32 GetEnableBtnCount(WizardGames.Soc.Common.Data.GameConsoleGroupType groupType); // 0x07281d54
	System.Void .ctor(); // 0x07281ef8
	static System.Void .cctor(); // 0x07282004
}

// Client.Runtime
class MgrCenterConsole.<>c : System.Object
{
	static MgrCenterConsole.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Data.Ui.GameCenterConsoleGroup> <>9__9_0; // 0x8
	static System.Comparison<System.Int32> <>9__9_1; // 0x10
	static System.Void .cctor(); // 0x072820d8
	System.Void .ctor(); // 0x0728213c
	System.Int32 <ReadDataFromTable>b__9_0(WizardGames.Soc.Common.Data.Ui.GameCenterConsoleGroup a, WizardGames.Soc.Common.Data.Ui.GameCenterConsoleGroup b); // 0x072821a4
	System.Int32 <ReadDataFromTable>b__9_1(System.Int32 a, System.Int32 b); // 0x07282238
}

// Client.Runtime
class UiOthersideVehicleStorage : WizardGames.Soc.SocClient.Ui.UiOthersideNearByContainer
{
	static System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ItemContainerNode> allItemContainerNodes; // 0x0
	WizardGames.Soc.Common.Entity.IBaseMountableEntity baseMountableEntity; // 0x150
	System.String GetNormalColTitle(WizardGames.Soc.Share.Framework.EntityBase col, System.Int32 index, System.Boolean preSetLootName); // 0x072823dc
	static System.String GetVehicleContainerName(WizardGames.Soc.Share.Framework.EntityBase entity, WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container); // 0x07282714
	System.Void GetCurContainerTotalVolume(System.Int32& curVolume, System.Int32& maxVolume); // 0x07282a30
	static System.Void OpenWinInLoot(System.Action onClose, System.Boolean dontStopLootWhenClose); // 0x07282c1c
	static System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ItemContainerNode> GetAllItemContainerNode(); // 0x07282cf0
	System.Void OnEnable(); // 0x07283224
	System.Void OnDisable(); // 0x07283530
	System.Void Refresh(); // 0x07283754
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x072837bc
	System.Void Close(); // 0x07283874
	System.Void CheckCloseWin(); // 0x07283958
	System.Void OnUpdateFps30(System.Single dt); // 0x07283ae8
	System.Void RefreshTabs(); // 0x07283b70
	System.Void UpdateContainerPos(); // 0x07283f48
	System.Void SetAllContainers(); // 0x07283fd0
	System.Void ShowAllContainer(); // 0x07283ca0
	System.Void RefreshOtherSideName(); // 0x07284268
	System.Void .ctor(); // 0x072843c0
}

// Client.Runtime
class UiOthersideVehicleStorage.<>c : System.Object
{
	static UiOthersideVehicleStorage.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.CustomType.ItemContainerNode> <>9__6_0; // 0x8
	static System.Void .cctor(); // 0x07284428
	System.Void .ctor(); // 0x0728448c
	System.Int32 <GetAllItemContainerNode>b__6_0(WizardGames.Soc.Common.CustomType.ItemContainerNode a, WizardGames.Soc.Common.CustomType.ItemContainerNode b); // 0x072844f4
}

// Client.Runtime
class UiInventoryOthersideOthersideMoveSign : System.Object
{
	FairyGUI.GComponent comRoot; // 0x10
	FairyGUI.GObject objToMe; // 0x18
	FairyGUI.GObject objToOther; // 0x20
	System.Void set_Visible(System.Boolean value); // 0x072846dc
	System.Void .ctor(FairyGUI.GComponent root); // 0x072848f4
	System.Void RefreshSigns(); // 0x0728477c
}

// Client.Runtime
class GameLiftingPlatformBg : UnityEngine.MonoBehaviour
{
	UnityEngine.GameObject ModelRoot; // 0x30
	UnityEngine.Camera SceneCamera; // 0x38
	System.Void .ctor(); // 0x07284a0c
}

// Client.Runtime
class UiLobbyPlayBtns : System.Object
{
	FairyGUI.GButton btnPlay; // 0x10
	FairyGUI.GComponent root; // 0x18
	FairyGUI.Controller controller; // 0x20
	FairyGUI.GButton btnOldServer; // 0x28
	WizardGames.Soc.SocClient.Ui.ComRedDot btnOldServerRedDot; // 0x30
	FairyGUI.Controller redDotPosCtrl; // 0x38
	FairyGUI.Controller redStatusCtrl; // 0x40
	FairyGUI.GButton btnBackTeam; // 0x48
	FairyGUI.GTextField modeName; // 0x50
	FairyGUI.GTextField teamNum; // 0x58
	FairyGUI.GTextField battleNum; // 0x60
	FairyGUI.GButton btnQuit; // 0x68
	FairyGUI.GGroup group_canStartGame; // 0x70
	FairyGUI.GTextField canStartGame; // 0x78
	FairyGUI.Transition canStartGameTrans; // 0x80
	System.Void .ctor(FairyGUI.GComponent comRoot); // 0x07284a74
	System.Void RefreshPreModeStatus(); // 0x0728522c
	System.Void OnCreateLobbyTeamNotice(System.Boolean isAppointment); // 0x07285450
	System.Void RefreshPlayBtnStatus(); // 0x072854dc
	System.Void RefreshRedDot(); // 0x0728599c
	System.Boolean HasOldBattleNum(); // 0x07285898
	System.Void OnQuitTeam(); // 0x07285c54
	System.Void OpenUiLobbyTeam(); // 0x07286078
	System.Void OnEnable(); // 0x07286204
	System.Void OnDisable(); // 0x07286448
	System.Void OnHandleLobbyOnReconnected(SimpleJSON.JSONNode node, System.Boolean _isApointment); // 0x07286694
	System.Void OnClickPlay(); // 0x07286714
	System.Void OnClickOldServer(); // 0x072867a4
	System.Void <.ctor>b__15_0(FairyGUI.EventContext ctx); // 0x072869a8
	System.Void <.ctor>b__15_1(FairyGUI.EventContext ctx); // 0x07286a20
	System.Void <.ctor>b__15_2(FairyGUI.EventContext ctx); // 0x07286a98
	System.Void <OnQuitTeam>b__21_0(); // 0x07286b10
	System.Void <OnQuitTeam>b__21_1(); // 0x07286c0c
}

// Client.Runtime
class UiLobbyPlayBtns.<>c : System.Object
{
	static UiLobbyPlayBtns.<>c <>9; // 0x0
	static System.Action <>9__28_0; // 0x8
	static System.Void .cctor(); // 0x07286ccc
	System.Void .ctor(); // 0x07286d30
	System.Void <OnClickOldServer>b__28_0(); // 0x07286d98
}

// Client.Runtime
class UiLobbyQuickJoin : System.Object
{
	FairyGUI.GComponent root; // 0x10
	FairyGUI.GTextField textSvrName; // 0x18
	System.Single infoUpdateRemainT; // 0x20
	System.Int64 timerId; // 0x28
	System.Void .ctor(FairyGUI.GComponent comRoot); // 0x07286e54
	System.Void Destroy(); // 0x07287208
	System.Void OnDisabled(); // 0x07287268
	System.Void SetActive(System.Boolean state); // 0x07287048
	System.Void RefreshSvrInfo(); // 0x07287374
	System.Void DoUpdate(); // 0x07287120
	System.Void OnClickLogin(); // 0x072874a4
	System.Void <.ctor>b__6_0(FairyGUI.EventContext ctx); // 0x07287990
}

// Client.Runtime
class UiLobbyQuickJoin.<>c : System.Object
{
	static UiLobbyQuickJoin.<>c <>9; // 0x0
	static System.Action <>9__12_0; // 0x8
	static System.Void .cctor(); // 0x07287a08
	System.Void .ctor(); // 0x07287a6c
	System.Void <OnClickLogin>b__12_0(); // 0x07287ad4
}

// Client.Runtime
class UiTXAdditionalBtns : System.Object
{
	FairyGUI.GButton btnAdditional; // 0x10
	FairyGUI.GComponent comAdditional; // 0x18
	FairyGUI.GList additionalList; // 0x20
	FairyGUI.GObject bg; // 0x28
	FairyGUI.Transition clickAnim; // 0x30
	System.Collections.Generic.Dictionary<UiTXAdditionalBtns.ETXAdditionalBtnType,System.Action> TXAddtionalBtns; // 0x38
	System.Collections.Generic.List<UiTXAdditionalBtns.ETXAdditionalBtnType> curList; // 0x40
	System.Collections.Generic.Dictionary<UiTXAdditionalBtns.ETXAdditionalBtnType,System.String> nameList; // 0x48
	System.Collections.Generic.Dictionary<UiTXAdditionalBtns.ETXAdditionalBtnType,System.String> iconList; // 0x50
	System.Void OpenUrl(UiTXAdditionalBtns.ETXAdditionalBtnType type); // 0x07287c3c
	System.Void .ctor(FairyGUI.GComponent comRoot, FairyGUI.GButton btn); // 0x07288050
	System.Void Init(); // 0x072884d4
	System.Void CheckTencentPrivilege(); // 0x072889a4
	System.Void OnClickTXTqWx(); // 0x07288d14
	System.Void OnClickTXTqQQ(); // 0x07288e48
	System.Void OnClickAdditional(FairyGUI.EventContext context); // 0x07288f7c
	System.Void OnTouchBegin(FairyGUI.EventContext context); // 0x07289188
	System.Void RenderAdditionalItem(System.Int32 index, FairyGUI.GObject item); // 0x07289390
	System.Void CheckNeedRefreshRedDot(UiTXAdditionalBtns.ETXAdditionalBtnType type); // 0x07289734
	System.Void AddListInfo(); // 0x07288b9c
	System.String GenerateOriginParams(); // 0x07289868
	System.String EncodeOriginParams(System.String originParams); // 0x07289edc
	System.String GenerateXinYueUrl(); // 0x07287e6c
	System.Void <Init>b__12_0(); // 0x0728a1f4
	System.Void <Init>b__12_1(); // 0x0728a25c
	System.Void <Init>b__12_2(); // 0x0728a2c4
}

// Client.Runtime
enum UiTXAdditionalBtns.ETXAdditionalBtnType : System.Enum
{
	System.Int32 value__; // 0x10
	static UiTXAdditionalBtns.ETXAdditionalBtnType TXSupport = 0;
	static UiTXAdditionalBtns.ETXAdditionalBtnType TXProtect = 4;
	static UiTXAdditionalBtns.ETXAdditionalBtnType TXXinYue = 5;
	static UiTXAdditionalBtns.ETXAdditionalBtnType TXTqQQ = 100;
	static UiTXAdditionalBtns.ETXAdditionalBtnType TXTqWx = 101;
	
}

// Client.Runtime
class UiTXAdditionalBtns.XinYueOriginJson : System.Object
{
	System.String pid; // 0x10
	System.String gid; // 0x18
	System.String reg; // 0x20
	System.String plat; // 0x28
	System.String ch; // 0x30
	System.String area; // 0x38
	System.String part; // 0x40
	System.String openid; // 0x48
	System.String appid; // 0x50
	System.String role; // 0x58
	System.String msdkt; // 0x60
	System.String t; // 0x68
	System.String r; // 0x70
	System.String ava; // 0x78
	System.String nick; // 0x80
	System.String channelid; // 0x88
	System.Void .ctor(); // 0x07289e74
}

// Client.Runtime
class UiTXAdditionalBtns.<>c__DisplayClass18_0 : System.Object
{
	UiTXAdditionalBtns <>4__this; // 0x10
	UiTXAdditionalBtns.ETXAdditionalBtnType type; // 0x18
	System.Action action; // 0x20
	System.Void .ctor(); // 0x072896cc
	System.Void <RenderAdditionalItem>b__0(); // 0x0728a32c
}

// Client.Runtime
class DoMoveUtil : System.Object
{
	UnityEngine.Vector3 uiModelCameraPosition; // 0x10
	UnityEngine.Transform uiModelCamera; // 0x20
	DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> tweener; // 0x28
	DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> rotateTweener; // 0x30
	UnityEngine.Transform targetObj; // 0x38
	UnityEngine.Transform rotateObj; // 0x40
	System.Void Init(UnityEngine.Transform cameraObj); // 0x0728a448
	System.Void StartDoMove(UnityEngine.Transform target, UnityEngine.Transform rotate, System.Single distance); // 0x0728a4ec
	System.Void StartDoRotate(UnityEngine.Vector3 targetRotate); // 0x0728a75c
	System.Void EndDoMove(); // 0x0728a840
	System.Void ResetNoAnim(); // 0x0728a8f4
	System.Void DOMove(UnityEngine.Vector3 pos); // 0x0728a658
	System.Void .ctor(); // 0x0728a9b8
}

// Client.Runtime
class MallModelPreviewBgSwitch : UnityEngine.MonoBehaviour
{
	UnityEngine.GameObject bgRole; // 0x30
	UnityEngine.GameObject bgItem; // 0x38
	UnityEngine.GameObject bgCommon; // 0x40
	System.Void ShowRoleBg(); // 0x0728aa20
	System.Void ShowItemBg(); // 0x0728aabc
	System.Void ShowCustomBg(); // 0x0728ab58
	System.Void .ctor(); // 0x0728abf4
}

// Client.Runtime
class MgrSouDJ : WizardGames.Soc.Common.Manager.MgrBase
{
	MgrSouDJ.ESouDJState selfState; // 0x14
	static SocLogger logger; // 0x0
	System.Boolean enableDebugLog; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamRankInfo> dailyRankList; // 0x20
	System.Int32 dailyTotalPage; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamRankInfo> battleRankList; // 0x30
	System.Int32 battleTotalPage; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.PlayerDisplaySimple>> rankTeamMembersCache; // 0x40
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> rankTeamMembersCacheTimestamp; // 0x48
	System.Int32 teamMembersCacheInvalidSec; // 0x50
	System.Void Init(); // 0x0728ac5c
	MgrSouDJ.ESouDJState GetState(); // 0x0728acc4
	MgrSouDJ.ESouDJStageName GetCurStage(); // 0x0728af88
	System.Int32 GetCurRounds(); // 0x0728b484
	WizardGames.Soc.Common.Data.Play.SouDJRoundCfg GetCurRoundConfig(); // 0x0728b520
	System.Boolean IsEndRound(); // 0x0728b72c
	System.Int32 GetActivityId(); // 0x0728b79c
	WizardGames.Soc.Common.Component.TeamSouDaJianComponent GetTeamSouDJCom(); // 0x0728b9cc
	System.Int32 GetCabineCoinNum(); // 0x0728bb38
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.SouDJStageCfg> GetCurStageCfg(System.Int32 stageId); // 0x0728b108
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.SouDJStageCfg> GetDefaultStageCfg(); // 0x0728bbb8
	WizardGames.Soc.Common.Data.Play.SouDaJianReward GetCurDayReward(System.Int32 rankId); // 0x0728be74
	WizardGames.Soc.Common.Data.Play.SouDaJianReward GetPreviouDayReward(System.Int32 rankId); // 0x0728c284
	WizardGames.Soc.Common.Data.Play.SouDaJianReward GetLastReward(System.Int32 rankGroupId); // 0x0728c3b8
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.SouDaJianReward> GetSouDaJianReward(System.Int32 groupId); // 0x0728bf94
	System.Boolean GetIsTrueOpen(); // 0x0728af18
	System.Int32 GetCurStageRemainTime(); // 0x0728c484
	System.Int32 GetNextSignUpTime(); // 0x0728c618
	System.Int32 NextRoundOpenTime(); // 0x0728c67c
	System.Void Destroy(); // 0x0728c71c
	System.Int32 GetSelfDailyRank(); // 0x0728c784
	System.Int32 GetSelfOverallRank(); // 0x0728c804
	System.Int32 GetCupNum(); // 0x0728c884
	System.Int32 GetSelfDailyScore(); // 0x0728c900
	System.Int32 GetSelfOverallScore(); // 0x0728c97c
	System.Boolean IsEliminated(); // 0x0728c9f8
	System.Int32 GetDailyTotalPage(); // 0x0728cbbc
	System.Int32 GetBattleTotalPage(); // 0x0728cc20
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamRankInfo> GetDailyRankList(); // 0x0728cc84
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamRankInfo> GetBattleRankList(); // 0x0728cce8
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.PlayerDisplaySimple> GetRankTeamMembersCache(System.Int64 teamEntityId); // 0x0728cd4c
	System.Void RequestDailyRankList(System.Int32 page); // 0x0728ce00
	System.Void DailyRankListAck(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamRankInfo> teamDailyRankList, System.Int32 page, System.Int32 totalPage); // 0x0728cedc
	System.Void RequestBattleRankList(System.Int32 page); // 0x0728d848
	System.Void BattleRankListAck(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamRankInfo> teamBattleRankList, System.Int32 currPage, System.Int32 totalPage); // 0x0728d924
	System.Void OnReceiveRankListData(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamRankInfo> rankList, System.Int32 currPage, System.Int32 totalPage, System.Boolean isDaily); // 0x0728cf84
	System.Void RequestSelfTeamDetailInfo(); // 0x0728d9cc
	System.Void RequestOneTeamDetailInfo(System.Int64 teamEntityId); // 0x0728daac
	System.Void RequestOneTeamDetailInfo_Internal(System.Int64 teamEntityId); // 0x0728dcf0
	System.Void OneTeamDetailInfoAck(System.Int64 teamEntityId, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.PlayerDisplaySimple> teamMembers); // 0x0728ddcc
	System.Void .ctor(); // 0x0728e260
	static System.Void .cctor(); // 0x0728e40c
}

// Client.Runtime
enum MgrSouDJ.ESouDJState : System.Enum
{
	System.Int32 value__; // 0x10
	static MgrSouDJ.ESouDJState CantSignUp = 0;
	static MgrSouDJ.ESouDJState NotSignUp = 1;
	static MgrSouDJ.ESouDJState AlreadySignUp = 2;
	static MgrSouDJ.ESouDJState SignUpSuccess = 3;
	static MgrSouDJ.ESouDJState SignUpFail = 4;
	
}

// Client.Runtime
enum MgrSouDJ.ESouDJStageName : System.Enum
{
	System.Int32 value__; // 0x10
	static MgrSouDJ.ESouDJStageName None = -1;
	static MgrSouDJ.ESouDJStageName SignUp = 0;
	static MgrSouDJ.ESouDJStageName Ready = 1;
	static MgrSouDJ.ESouDJStageName Fight = 2;
	static MgrSouDJ.ESouDJStageName End = 3;
	
}

// Client.Runtime
class UiSouDJWnd : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ComSumUpBinder binderRoot; // 0x10
	WizardGames.Soc.SocClient.Ui.UiStory storyParent; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.SouDJStageCfg> curSouDjCfgList; // 0x20
	MgrSouDJ.ESouDJStageName curStage; // 0x28
	MgrSouDJ.ESouDJStageName selectStage; // 0x2c
	MgrSouDJ.ESouDJState SouDJState; // 0x30
	System.Int32 curRound; // 0x34
	FairyGUI.GLoader bg; // 0x38
	WizardGames.Soc.SocClient.Ui.ComTopBar topbar; // 0x40
	System.Boolean isKeepSouDJWnd; // 0x48
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiStory story, WizardGames.Soc.SocClient.Ui.Binder.GameStory.ComSumUpBinder root, FairyGUI.GLoader rootBg, WizardGames.Soc.SocClient.Ui.ComTopBar rootTopbar); // 0x0728e4e0
	System.Void UpdataWnd(); // 0x0728eeac
	System.Void OnStageChange(); // 0x0728f8a4
	System.Void UpdateStageList(System.Boolean isFirst); // 0x0728ef3c
	System.Void UpdateState(); // 0x0728f958
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x0728fa0c
	System.Void UpdateRightStage(FairyGUI.EventContext context); // 0x0728fff4
	System.Void SetFourthStage(); // 0x07290d7c
	System.Void SetThirdStage(); // 0x07290b78
	System.Void SetSecondStage(); // 0x072909dc
	System.Void SetFirstStage(); // 0x072901ec
	System.Void SetSignUpFailBtn(); // 0x07291320
	System.Void UpdateTimeInfo(); // 0x0728f2d8
	System.Void SetCurStageLastTime(); // 0x072914fc
	System.Void SetLeftDesc(); // 0x072910b0
	System.Void ShowTopReward(); // 0x07292020
	System.Void SetRunkData(); // 0x07290f50
	System.Void UpdataDayRank(); // 0x072928f0
	System.Void SetDayRewardItem(WizardGames.Soc.Common.Data.Play.SouDaJianReward rewardCfg); // 0x07294054
	System.Void OnClickItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x07294918
	System.Void UpdataAllRank(); // 0x07293624
	System.Void SetStatu(System.String pageName); // 0x07291f4c
	System.Void SetBtnStatu(System.String pageName); // 0x07290fdc
	System.Void OnClickSignUp(); // 0x07294b90
	System.Void OnClickYellowBtn(); // 0x072955d0
	System.Void OnClickOpenMap(); // 0x07295b48
	System.Void OnClickSkipCabine(); // 0x07295c00
	System.Void OnClickAllRank(); // 0x07295c64
	System.Void OnClickDayRank(); // 0x07295cc8
	System.Void OnClickHelp(); // 0x07295d2c
	System.Void Hide(); // 0x07295dec
	System.Void Destroy(); // 0x07295e64
	System.Void .ctor(); // 0x07295fb4
}

// Client.Runtime
class UiSouDJWnd.<>c : System.Object
{
	static UiSouDJWnd.<>c <>9; // 0x0
	static System.Action <>9__34_0; // 0x8
	static System.Action <>9__35_0; // 0x10
	static System.Void .cctor(); // 0x0740879c
	System.Void .ctor(); // 0x07408800
	System.Void <OnClickSignUp>b__34_0(); // 0x07408868
	System.Void <OnClickYellowBtn>b__35_0(); // 0x07408914
}

// Client.Runtime
class ItemIconPool : System.Object, WizardGames.Soc.SocClient.Ui.IItemIconProvider
{
	System.Int32 poolResidentCapacity; // 0x10
	System.Boolean usePoolResident; // 0x14
	System.String resourceURL; // 0x18
	FairyGUI.GComponent poolRoot; // 0x20
	FairyGUI.GObjectPool iconPool; // 0x28
	System.String poolName; // 0x30
	System.Single autoRemoveTimeSec; // 0x38
	System.Void .ctor(FairyGUI.GComponent parent, System.String name, System.Int32 residentCapacity); // 0x074089c0
	System.Void ClearPool(System.Boolean claerResident); // 0x07408e94
	WizardGames.Soc.SocClient.Ui.ComItemIcon GetIconInternal(System.Boolean fromPoolOnly); // 0x07408f8c
	System.Void RestPool(); // 0x074090ec
	System.Void InitResidentIconData(); // 0x07408ca4
	WizardGames.Soc.SocClient.Ui.ComItemIcon GetIcon(); // 0x07409428
	System.Void ReturnIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0740915c
	System.Void OnFps1Update(System.Single dt); // 0x07409490
}

// Client.Runtime
class TweenConfig : UnityEngine.MonoBehaviour
{
	DG.Tweening.Ease ease; // 0x30
	System.Single duration; // 0x34
	System.Void .ctor(); // 0x074095f4
}

// Client.Runtime
class ConditionalGibbable : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	System.Int32 LayoutID; // 0x30
	System.Collections.Generic.List<UnityEngine.MeshRenderer> functionMeshRenderers; // 0x38
	System.Collections.Generic.List<ConditionalGibbable.ConditionHp> conditions; // 0x40
	UnityEngine.Material GibMaterial; // 0x48
	System.Single BaseDropSpeed; // 0x50
	UnityEngine.Material instanceGibMaterial; // 0x58
	System.Single curLayoutValue; // 0x60
	System.Single targetLayoutValue; // 0x64
	System.Single RealDropSpeed; // 0x68
	Sirenix.Serialization.SerializationData <SerializationData>k__BackingField; // 0x70
	System.Void Awake(); // 0x07409668
	System.Void ReplaceMeshRenderer(UnityEngine.MeshRenderer[] meshRenderers); // 0x074097a0
	System.Void InitConditional(System.Single healthFraction); // 0x07409a48
	System.Void RefreshConditional(System.Single healthFraction); // 0x07409bf8
	System.Void UpdateLayout(); // 0x07409e50
	System.Void OnDestroy(); // 0x07409f98
	Sirenix.Serialization.SerializationData get_SerializationData(); // 0x0740a038
	System.Void set_SerializationData(Sirenix.Serialization.SerializationData value); // 0x0740a0bc
	System.Void .ctor(); // 0x0740a168
	static System.Void .cctor(); // 0x0740a2a4
}

// Client.Runtime
class ConditionalGibbable.ConditionHp : System.Object
{
	System.Int32 TargetLayout; // 0x10
	System.Single HealthRestrictionMin; // 0x14
	System.Void .ctor(); // 0x0740a378
}

// Client.Runtime
class Gib : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	UnityEngine.MeshFilter _meshFilter; // 0x30
	UnityEngine.MeshRenderer _meshRenderer; // 0x38
	UnityEngine.MeshCollider _meshCollider; // 0x40
	UnityEngine.BoxCollider _boxCollider; // 0x48
	UnityEngine.SphereCollider _sphereCollider; // 0x50
	UnityEngine.CapsuleCollider _capsuleCollider; // 0x58
	UnityEngine.Rigidbody _rigidbody; // 0x60
	static UnityEngine.Vector2 InWaterDrag; // 0x8
	static UnityEngine.Vector2 InWaterAngularDrag; // 0x10
	System.Int64 DestroyGib_timerId; // 0x68
	System.Void DestroyViaConvar(); // 0x0740a3e8
	System.Void DestroyGib(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x0740a4fc
	System.Void SetUpDestroy(System.Single minTime, System.Single maxTime); // 0x0740a80c
	static Gib Create(UnityEngine.Mesh mesh, UnityEngine.Material[] materials, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); // 0x0740ab2c
	static Gib CreateGibRoot(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); // 0x0740ad18
	System.Void CreatePhysics(UnityEngine.Mesh physicsMesh, UnityEngine.PhysicMaterial physicsMaterial, UnityEngine.Vector3 vel, System.Boolean inWater); // 0x0740b02c
	System.Void CreatePhysics(UnityEngine.Mesh physicsMesh, UnityEngine.PhysicMaterial physicsMaterial, UnityEngine.Vector3 vel, UnityEngine.Vector3 angVel, System.Boolean inWater); // 0x0740b148
	System.Void CreatePhysics(Gibbable.OverrideMesh overrideMesh, UnityEngine.PhysicMaterial physicsMaterial, UnityEngine.Vector3 vel, System.Single scale, System.Boolean inWater); // 0x0740b438
	System.Void CreatePhysics(Gibbable.OverrideMesh overrideMesh, UnityEngine.PhysicMaterial physicsMaterial, UnityEngine.Vector3 vel, UnityEngine.Vector3 angVel, System.Single scale, System.Boolean inWater); // 0x0740b578
	System.Void EnableCollider(Gibbable.ColliderType type); // 0x0740ba20
	System.Void SetupCollider(Gibbable.OverrideMesh overrideMesh, UnityEngine.PhysicMaterial physicsMaterial, System.Single scale); // 0x0740b834
	System.Void .ctor(); // 0x0740bb3c
	static System.Void .cctor(); // 0x0740bba4
}

// Client.Runtime
class Gibbable : UnityEngine.MonoBehaviour
{
	UnityEngine.GameObject gibSource; // 0x30
	UnityEngine.Material[] customMaterials; // 0x38
	UnityEngine.GameObject materialSource; // 0x40
	System.Boolean copyMaterialBlock; // 0x48
	System.Boolean applyDamageTexture; // 0x49
	UnityEngine.PhysicMaterial physicsMaterial; // 0x50
	System.Int32 fxPrefab; // 0x58
	System.Boolean spawnFxPrefab; // 0x5c
	System.Boolean important; // 0x5d
	System.Single explodeScale; // 0x60
	System.Single scaleOverride; // 0x64
	System.Int32 uniqueId; // 0x68
	Gibbable.BoundsEffectType boundsEffectType; // 0x6c
	System.Boolean isConditional; // 0x70
	UnityEngine.Bounds effectBounds; // 0x74
	UnityEngine.Quaternion worldRotation; // 0x8c
	System.Collections.Generic.List<Gibbable.OverrideMesh> MeshOverrides; // 0xa0
	static UnityEngine.MaterialPropertyBlock propertyBlock; // 0x0
	static UnityEngine.Material copyMaterial; // 0x8
	Gib newGib; // 0xa8
	Gibbable.GibMesh[] gibRenderers; // 0xb0
	System.Void Awake(); // 0x0740bc90
	System.Void Refresh(); // 0x0740bd18
	System.Void .ctor(); // 0x0740c098
}

// Client.Runtime
struct Gibbable.OverrideMesh : System.ValueType
{
	System.Boolean enabled; // 0x10
	Gibbable.ColliderType ColliderType; // 0x14
	UnityEngine.Vector3 BoxSize; // 0x18
	UnityEngine.Vector3 ColliderCentre; // 0x24
	System.Single ColliderRadius; // 0x30
	System.Single CapsuleHeight; // 0x34
	System.Int32 CapsuleDirection; // 0x38
	System.Boolean BlockMaterialCopy; // 0x3c
	
}

// Client.Runtime
enum Gibbable.ColliderType : System.Enum
{
	System.Int32 value__; // 0x10
	static Gibbable.ColliderType Box = 0;
	static Gibbable.ColliderType Sphere = 1;
	static Gibbable.ColliderType Capsule = 2;
	
}

// Client.Runtime
enum Gibbable.ParentingType : System.Enum
{
	System.Int32 value__; // 0x10
	static Gibbable.ParentingType None = 0;
	static Gibbable.ParentingType GibsOnly = 1;
	static Gibbable.ParentingType FXOnly = 2;
	static Gibbable.ParentingType All = 3;
	
}

// Client.Runtime
enum Gibbable.BoundsEffectType : System.Enum
{
	System.Int32 value__; // 0x10
	static Gibbable.BoundsEffectType None = 0;
	static Gibbable.BoundsEffectType Electrical = 1;
	static Gibbable.BoundsEffectType Glass = 2;
	static Gibbable.BoundsEffectType Scrap = 3;
	static Gibbable.BoundsEffectType Stone = 4;
	static Gibbable.BoundsEffectType Wood = 5;
	
}

// Client.Runtime
struct Gibbable.GibMesh : System.ValueType
{
	UnityEngine.Transform transform; // 0x10
	UnityEngine.MeshFilter filter; // 0x18
	UnityEngine.MeshCollider collider; // 0x20
	UnityEngine.Vector3 localPosition; // 0x28
	UnityEngine.Quaternion localRotation; // 0x34
	UnityEngine.Material[] materials; // 0x48
	
}

// Client.Runtime
class VehicleDebug.VehicleInteractionDebug : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Go.VehicleTrigger> VehicleTriggerCollection; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,System.Single> TriggerMountableEntityIds; // 0x38
	System.Int64 RaycastMountableEntityId; // 0x40
	System.Int64 InteractionMountableEntityId; // 0x48
	System.Void Start(); // 0x0740c160
	System.Void Update(); // 0x0740c240
	System.Void .ctor(); // 0x0740c2e0
}

// Client.Runtime
class Vehicle.ClientMountableUtil : System.Object
{
	
	static System.Void OnLoadFinishResetView(WizardGames.Soc.Common.Entity.IBaseMountableEntity mountableEntity, WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo); // 0x0740c348
	static System.Boolean CanRepairViaRes(WizardGames.Soc.Common.Unity.Go.BaseVehicleGo vehicleGo, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0740c730
}

// Client.Runtime
class Vehicle.HorsePositionFixed : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.Common.Entity.HorseEntity HorseEntity; // 0x30
	System.Void OnAnimatorMove(); // 0x0740c9a0
	System.Void .ctor(); // 0x0740cc5c
}

// Client.Runtime
class Vehicle.MgrVehicle : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Go.VehicleTrigger> VehicleTriggerCollection; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,System.Single> TriggerMountableEntityIds; // 0x20
	System.Int64 RaycastMountableEntityId; // 0x28
	System.Int64 InteractionMountableEntityId; // 0x30
	static SocLogger logger; // 0x8
	static System.Int32 SHATTER_ANIM_TIME = 2;
	static System.Int32 MAX_PLAY_SHATTERED_COUNT = 2;
	static System.DateTime[] shatteredTimes; // 0x10
	System.Threading.Tasks.Task OnEnterWorld(); // 0x0740ccc4
	System.Threading.Tasks.Task OnExitWorld(); // 0x0740cddc
	System.Void Register(WizardGames.Soc.SocClient.Go.VehicleTrigger vt); // 0x0740ce90
	System.Void UnRegister(WizardGames.Soc.SocClient.Go.VehicleTrigger vt); // 0x0740d050
	System.Void UpdateVehicleTrigger(); // 0x0740d20c
	System.Void UpdateMountableInteractiveIdList(System.Collections.Generic.List<System.Int32> interactiveIdList, System.Int64& entityId, System.String& showName); // 0x0740d458
	System.Void OutMountInteractive(System.Collections.Generic.List<System.Int32> interactiveIdList, System.Int64& entityId, System.String& showName); // 0x0740d594
	System.String ShowVehicleName(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo); // 0x0740e670
	System.Void Repair(WizardGames.Soc.Common.Entity.IBaseMountableEntity mountableEntity, WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo, System.Collections.Generic.List<System.Int32> interactiveIdList); // 0x0740e370
	System.Void VehicleOp(WizardGames.Soc.Common.Entity.IBaseMountableEntity mountableEntity, WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo, System.Collections.Generic.List<System.Int32> interactiveIdList); // 0x0740e118
	System.Void HorseFeed(WizardGames.Soc.Common.Entity.IBaseMountableEntity mountableEntity, System.Collections.Generic.List<System.Int32> interactiveIdList); // 0x0740dcc0
	System.Void HorseFollow(WizardGames.Soc.Common.Entity.IBaseMountableEntity mountableEntity, System.Collections.Generic.List<System.Int32> interactiveIdList); // 0x0740de20
	System.Int32 GetVehicleLockInteractiveId(WizardGames.Soc.Common.Entity.IBaseMountableEntity mountableEntity, WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo); // 0x0740e960
	System.Void VehicleLock(WizardGames.Soc.Common.Entity.IBaseMountableEntity mountableEntity, WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo, System.Collections.Generic.List<System.Int32> interactiveIdList); // 0x0740dbf8
	System.Void TryLockVehicle(System.Int64 entityId); // 0x0740ed2c
	System.Void AddInteractiveId(System.Collections.Generic.List<System.Int32> interactiveIdList, System.Int32 interactiveId); // 0x0740e6fc
	System.Boolean InteractiveIdCheck(System.Int32 interactiveId); // 0x0740f028
	System.Void TrainInteractive(WizardGames.Soc.Common.Unity.Go.BaseMountableGo go, System.Collections.Generic.List<System.Int32> interactiveIdList); // 0x0740e4a0
	System.Void Mount(WizardGames.Soc.Common.Unity.Go.BaseMountableGo go, System.Collections.Generic.List<System.Int32> interactiveIdList); // 0x0740da0c
	System.Void HorseMountInteractive(WizardGames.Soc.Common.Unity.Go.BaseSocHorseGo horseGo, System.Collections.Generic.List<System.Int32> interactiveIdList); // 0x0740f16c
	System.Boolean IsVehicleLock(WizardGames.Soc.Common.Entity.IBaseMountableEntity mountableEntity); // 0x0740ebb4
	System.Boolean IsCabinModule(WizardGames.Soc.Common.Entity.IVehicleModuleCustom IVehicleModuleCustom); // 0x0740f5c8
	WizardGames.Soc.Common.Entity.ModularCarEntity GetModularCarEntity(WizardGames.Soc.Common.Entity.IVehicleModuleCustom IVehicleModuleCustom); // 0x0740f44c
	System.Void RotPedal(WizardGames.Soc.Common.Unity.Go.VehicleRotateParam param, System.Boolean targetOrDefault, System.Boolean pitchOrRoll); // 0x0740f780
	System.Single CalcTargetValve(System.Single now, System.Single target, System.Single speed, System.Single dt); // 0x0740f9c4
	System.Void TryShatteredEffect(WizardGames.Soc.Common.Unity.Go.BaseModularCarGo baseModularCarGo); // 0x0740fb04
	System.Void PlayShatteredEffect(System.String prefabPath, UnityEngine.Vector3 pos, UnityEngine.Quaternion rotation); // 0x07410260
	System.Void LoadFinish(UnityEngine.GameObject obj, System.Object[] owner); // 0x07410598
	System.Void BrokenFinishCallback(System.Single delayTime, System.Action callback); // 0x07410ab8
	System.Void .ctor(); // 0x07410bc0
	static System.Void .cctor(); // 0x07410c28
}

// Client.Runtime
class Vehicle.MgrVehicle.<>c : System.Object
{
	static Vehicle.MgrVehicle.<>c <>9; // 0x0
	static System.Action<UnityEngine.GameObject,System.Object[]> <>9__35_0; // 0x8
	static System.Void .cctor(); // 0x07410d68
	System.Void .ctor(); // 0x07410dcc
	System.Void <PlayShatteredEffect>b__35_0(UnityEngine.GameObject obj, System.Object[] owner); // 0x07410e34
}

// Client.Runtime
class Vehicle.MgrVehicle.<>c__DisplayClass36_0 : System.Object
{
	UnityEngine.Animator animator; // 0x10
	System.Object[] owner; // 0x18
	UnityEngine.GameObject obj; // 0x20
	System.Void .ctor(); // 0x07410a50
	System.Void <LoadFinish>b__0(); // 0x07410f24
}

// Client.Runtime
struct Vehicle.MgrVehicle.<BrokenFinishCallback>d__37 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	System.Single delayTime; // 0x38
	System.Action callback; // 0x40
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x48
	System.Void MoveNext(); // 0x07411028
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x07411268
}

// Client.Runtime
class Utility.ClientEntityUtils : System.Object
{
	static UnityEngine.Animator[] all_animators; // 0x0
	static System.Int32 GetPlayerAllAnimators(System.Int64 entityId, UnityEngine.Animator[]& out_animators); // 0x074112e8
	static System.Int32 GetMonsterAllAnimators(System.Int64 entityId, UnityEngine.Animator[]& out_animators); // 0x07411be0
	static System.Int32 GetCorpseAllAnimators(System.Int64 entityId, UnityEngine.Animator[]& out_animators); // 0x07411f68
	static System.Int32 GetHorseAllAnimators(System.Int64 entityId, UnityEngine.Animator[]& out_animators); // 0x074121c0
	static System.Int32 GetElevatorAllAnimators(System.Int64 entityId, UnityEngine.Animator[]& out_animators); // 0x07412418
	static System.Int32 GetDigAllAnimators(System.Int64 entityId, UnityEngine.Animator[]& out_animators); // 0x07412670
	static System.Int32 GetNpcAllAnimators(System.Int64 entityId, UnityEngine.Animator[]& out_animators); // 0x074128c8
	static UnityEngine.Transform GetTpWeaponRenderTransform(WizardGames.Soc.Common.Entity.PlayerEntity CurPlayer); // 0x07411a3c
	static T GetPlayerHeldEntityById<T>(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Int64 entityId, System.Boolean local); // 0x052af1f0
	static System.Boolean TryGetEntityTableIDByType(System.Int32 entityType, System.Int32& id); // 0x07412b20
	static System.Boolean TryGetEntityTableByType(System.Int32 entityType, WizardGames.Soc.Common.Data.global.GlobalEntity& table); // 0x07412c50
	static System.Void .cctor(); // 0x07412db8
}

// Client.Runtime
class Utility.DisplayBounds : UnityEngine.MonoBehaviour
{
	UnityEngine.Renderer[] renderers; // 0x30
	UnityEngine.Vector3 Center; // 0x38
	UnityEngine.Vector3 Extents; // 0x44
	UnityEngine.Vector3 worldpos; // 0x50
	UnityEngine.Vector3 worldrot; // 0x5c
	UnityEngine.Animator animator; // 0x68
	System.Boolean hasTransformHierarchy; // 0x70
	System.Void Awake(); // 0x07412e2c
	System.Void Refresh(); // 0x07412ee8
	System.Void LateUpdate(); // 0x0741308c
	System.Void OnDrawGizmos(); // 0x074132fc
	System.Void .ctor(); // 0x07413700
}

// Client.Runtime
class FairyGUI.FGUIGoPool : UnityEngine.MonoBehaviour, FairyGUI.IDisplayObjectFactoryHook
{
	static SocLogger logger; // 0x0
	static System.Int32 EXPAND_SIZE = 8;
	static System.String POOL_NAME = "FGUIGoPool";
	static System.String POOL_OBJ_NAME = "FGUIOBJ";
	UnityEngine.Transform cacheTransform; // 0x30
	System.Collections.Generic.Queue<UnityEngine.GameObject> pool; // 0x38
	System.Collections.Generic.Queue<UnityEngine.GameObject> poolWithRender; // 0x40
	System.Boolean refreshPoolName; // 0x48
	System.Type[] typesForNormal; // 0x50
	System.Type[] typesForRenderer; // 0x58
	System.Int32 <NormalReiszeTimes>k__BackingField; // 0x60
	System.Int32 <WithRenderReiszeTimes>k__BackingField; // 0x64
	System.Int32 get_PoolCount(); // 0x07413768
	System.Int32 get_PoolWithRenderCount(); // 0x074137e8
	System.Int32 get_NormalReiszeTimes(); // 0x07413868
	System.Void set_NormalReiszeTimes(System.Int32 value); // 0x074138cc
	System.Int32 get_WithRenderReiszeTimes(); // 0x07413944
	System.Void set_WithRenderReiszeTimes(System.Int32 value); // 0x074139a8
	System.Void Awake(); // 0x07413a20
	System.Void CreateGoToPool(System.Collections.Generic.Queue<UnityEngine.GameObject> pool, System.Boolean withRenderer); // 0x07413b58
	System.Void RefillGoPool(System.Collections.Generic.Queue<UnityEngine.GameObject> pool, System.Int32 tarSize, System.Boolean withRenderer); // 0x07413ce8
	System.Void RefillPool(System.Int32 normalSize, System.Int32 withRendererSize); // 0x07413e20
	System.Void ClearChildrenOfGo(UnityEngine.GameObject go); // 0x07413f6c
	UnityEngine.GameObject CreateGameObject(System.String name, System.Boolean withRenderer); // 0x07414070
	System.Void DestroyGameObject(UnityEngine.GameObject obj); // 0x07414468
	System.Void ClearAllGo(); // 0x0741483c
	System.Void OnDestroy(); // 0x07414b2c
	System.Void .ctor(); // 0x07414b90
	static System.Void .cctor(); // 0x07414d44
}

// Client.Runtime
class TrailerRecorder.RecordStageManager : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x07414e18
}

// Client.Runtime
class TrailerCamera.CameraTypeManager : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x07414e80
}

// Client.Runtime
class TrailerCamera.DollyCameraManager : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x07414ee8
}

// Client.Runtime
class TrailerCamera.InputSetSlider : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x07414f50
}

// Client.Runtime
class TrailerCamera.PointManager : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x07414fb8
}

// Client.Runtime
class TrailerCamera.SocFunctionManager : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x07415020
}

// Client.Runtime
class TrailerCamera.TrailerAudioManager : UnityEngine.MonoBehaviour
{
	
	System.Void SwitchAmbientSound(System.Boolean isOn); // 0x07415088
	System.Void .ctor(); // 0x0741513c
}

// Client.Runtime
class TrailerCamera.TrailerCameraManager : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x074151a4
}

// Client.Runtime
class TrailerCamera.TrailerRecorder : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x0741520c
}

// Client.Runtime
class TrailerCamera.UpdateTextFloat : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x07415274
}

// Client.Runtime
class TrailerCamera.VolumeManager : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x074152dc
}

// Client.Runtime
class TinyCameraTool.InputSetSlider : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x07415344
}

// Client.Runtime
class TinyCameraTool.SocFunctionManager : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x074153ac
}

// Client.Runtime
class TinyCameraTool.TinyCameraToolUIManager : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x07415414
}

// Client.Runtime
class TinyCameraTool.TrailerCameraManager : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x0741547c
}

// Client.Runtime
class TinyCameraTool.UpdateTextFloat : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x074154e4
}

// Client.Runtime
class TinyCameraTool.VolumeManager : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x0741554c
}

// Client.Runtime
class MaterialTrack.ExtensionMethods : System.Object
{
	
	static UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(UnityEngine.Shader shader, System.String propertyName); // 0x074155b4
	static UnityEngine.Texture2D ToTexture2D(UnityEngine.Color color); // 0x07415664
	static UnityEngine.Texture2D ToTexture2D(UnityEngine.Vector4 vector); // 0x07415768
	static UnityEngine.Vector4 GetTextureScaleOffset(UnityEngine.MaterialPropertyBlock block, System.String name); // 0x07415808
	static System.Void SetTextureScaleOffset(UnityEngine.MaterialPropertyBlock block, System.String name, UnityEngine.Vector4 value); // 0x074158b4
	static UnityEngine.Color TextureDefaultNameToColor(System.String name); // 0x074159a8
}

// Client.Runtime
interface MaterialTrack.IMaterialProvider : 
{
	
	
}

// Client.Runtime
class MaterialTrack.MaterialBehaviour : MaterialTrack.RendererBehaviour
{
	static System.String USE_MAT_FIELD = "materialMode";
	static System.String MAT_FIELD = "material";
	UnityEngine.Material material; // 0xb0
	System.Boolean materialMode; // 0xb8
	System.Void .ctor(); // 0x07415ad4
	System.Void CopyFrom(MaterialTrack.MaterialBehaviour other); // 0x07415c4c
	System.Void ApplyFromMaterial(UnityEngine.Material source); // 0x07415ddc
	System.Void ApplyToMaterial(UnityEngine.Material target); // 0x07416090
	System.Void ApplyToTexture(UnityEngine.Material target); // 0x074162f8
	System.Void Lerp(MaterialTrack.MaterialBehaviour a, MaterialTrack.MaterialBehaviour b, System.Single t); // 0x07416420
	System.Boolean IsBlendableWith(MaterialTrack.RendererBehaviour other); // 0x0741678c
}

// Client.Runtime
class MaterialTrack.MaterialClip : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
{
	MaterialTrack.MaterialBehaviour template; // 0x18
	UnityEngine.Timeline.ClipCaps get_clipCaps(); // 0x07416934
	UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner); // 0x07416998
	System.Void .ctor(); // 0x07416a94
}

// Client.Runtime
class MaterialTrack.MaterialLayerMixer : UnityEngine.Playables.PlayableBehaviour
{
	static System.Boolean frameClean; // 0x0
	System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x07416b30
	System.Void .ctor(); // 0x07416c08
	static System.Void .cctor(); // 0x07416c70
}

// Client.Runtime
class MaterialTrack.MaterialMixer : UnityEngine.Playables.PlayableBehaviour, MaterialTrack.IMaterialProvider
{
	static System.Collections.Generic.List<System.Int32> s_ActiveClips; // 0x0
	static MaterialTrack.MaterialBehaviour s_MBMix1; // 0x8
	static MaterialTrack.MaterialBehaviour s_MBMix2; // 0x10
	UnityEngine.Material boundMaterial; // 0x10
	UnityEngine.Material defaultMaterial; // 0x18
	System.Boolean firstFrameHappened; // 0x20
	System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable); // 0x07416cbc
	System.Void ResetMaterial(); // 0x07416d40
	System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x07416e24
	static MaterialTrack.MaterialBehaviour GetBehaviour(UnityEngine.Playables.Playable playable, System.Int32 inputPort); // 0x074174f0
	System.Void .ctor(); // 0x07417890
	static System.Void .cctor(); // 0x074178f8
}

// Client.Runtime
class MaterialTrack.MaterialTrack : UnityEngine.Timeline.TrackAsset, UnityEngine.Timeline.ILayerable
{
	
	UnityEngine.Playables.Playable CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount); // 0x074179f0
	UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount); // 0x07417aec
	System.Void InitializeClips(MaterialTrack.IMaterialProvider provider); // 0x07417c30
	System.Void .ctor(); // 0x0741815c
}

// Client.Runtime
class MaterialTrack.RendererBehaviour : UnityEngine.Playables.PlayableBehaviour, MaterialTrack.IMaterialProvider
{
	static System.String TYPE_FIELD = "propertyType";
	static System.String NAME_FIELD = "propertyName";
	static System.String TEX_FIELD = "texture";
	static System.String VEC_FIELD = "vector";
	static System.String TEX_TARGET_FIELD = "textureTarget";
	static System.String COLORGRADIENT_FIELD = "colorGradient";
	static System.String VALUECURVE_FIELD = "valueCurve";
	static System.String COLOR_FIELD = "color";
	static System.String USEHUD_FIELD = "useHDR";
	MaterialTrack.IMaterialProvider provider; // 0x10
	System.String propertyName; // 0x18
	UnityEngine.Rendering.ShaderPropertyType propertyType; // 0x20
	UnityEngine.Texture texture; // 0x28
	UnityEngine.Vector4 vector; // 0x30
	MaterialTrack.RendererBehaviour.TextureTarget textureTarget; // 0x40
	System.Boolean useHDR; // 0x44
	UnityEngine.Color color; // 0x48
	UnityEngine.ParticleSystem.MinMaxGradient colorGradient; // 0x58
	UnityEngine.ParticleSystem.MinMaxCurve valueCurve; // 0x90
	static System.Boolean triedFindShader; // 0x0
	static UnityEngine.Material blendMaterial; // 0x8
	static UnityEngine.Material get_BlendMaterial(); // 0x074181e8
	System.Void .ctor(); // 0x07415b38
	System.Void CopyFrom(MaterialTrack.RendererBehaviour other); // 0x07415cec
	System.Boolean HasProperty(UnityEngine.Material material); // 0x07416264
	System.Void Lerp(MaterialTrack.RendererBehaviour a, MaterialTrack.RendererBehaviour b, System.Single t); // 0x074165a0
	System.Void EvaluateValue(System.Single normalizedTime); // 0x07417784
	System.Void ApplyFromPropertyBlock(UnityEngine.MaterialPropertyBlock source); // 0x07418718
	System.Void ApplyToPropertyBlock(UnityEngine.MaterialPropertyBlock target); // 0x07418838
	System.Void ApplyFromMaterial(UnityEngine.Material source); // 0x07415ea8
	UnityEngine.Texture BlendTextures(UnityEngine.Texture a, UnityEngine.Texture b, System.Single t); // 0x07418390
	System.Boolean IsBlendableWith(MaterialTrack.RendererBehaviour other); // 0x07416870
}

// Client.Runtime
enum MaterialTrack.RendererBehaviour.TextureTarget : System.Enum
{
	System.Int32 value__; // 0x10
	static MaterialTrack.RendererBehaviour.TextureTarget Asset = 0;
	static MaterialTrack.RendererBehaviour.TextureTarget TilingOffset = 1;
	
}

// Client.Runtime
class MaterialTrack.RendererClip : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
{
	MaterialTrack.RendererBehaviour template; // 0x18
	UnityEngine.Timeline.ClipCaps get_clipCaps(); // 0x074189cc
	UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner); // 0x07418a30
	System.Void .ctor(); // 0x07418b2c
}

// Client.Runtime
class MaterialTrack.RendererMixer : UnityEngine.Playables.PlayableBehaviour, MaterialTrack.IMaterialProvider
{
	static System.String MAT_IDX_FIELD = "materialIndex";
	static System.Int32 DEFAULT_MATERIAL_INDEX = -1;
	static System.Collections.Generic.List<System.Int32> s_ActiveClips; // 0x0
	static MaterialTrack.RendererBehaviour s_RBMix1; // 0x8
	static MaterialTrack.RendererBehaviour s_RBMix2; // 0x10
	static UnityEngine.MaterialPropertyBlock s_Block; // 0x18
	System.Int32 materialIndex; // 0x10
	System.Int32 oldMaterialIndex; // 0x14
	UnityEngine.Renderer boundRenderer; // 0x18
	UnityEngine.Material[] availableMaterials; // 0x20
	UnityEngine.Material[] get_AvailableMaterials(); // 0x07418bc8
	System.Int32 get_MaterialCount(); // 0x07418c64
	System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable); // 0x07418cd8
	System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable); // 0x07418df4
	System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x07418f60
	static System.Single GetPlayableProgress(UnityEngine.Playables.Playable playable, System.Int32 inputPort); // 0x07417680
	static MaterialTrack.RendererBehaviour GetBehaviour(UnityEngine.Playables.Playable playable, System.Int32 inputPort); // 0x07419848
	System.Void ApplyToBehaviour(UnityEngine.MaterialPropertyBlock source, MaterialTrack.RendererBehaviour target, System.Int32 fallbackMaterialIndex); // 0x07419a68
	System.Boolean IsMaterialIndexValid(System.Int32 index); // 0x074199d8
	System.Void ClearSlots(); // 0x0741973c
	System.Void ClearAllSlots(); // 0x07418ec0
	System.Void .ctor(); // 0x07419bbc
	static System.Void .cctor(); // 0x07419c2c
}

// Client.Runtime
class MaterialTrack.RendererTrack : UnityEngine.Timeline.TrackAsset, UnityEngine.Timeline.ILayerable
{
	MaterialTrack.RendererMixer template; // 0xa0
	UnityEngine.Playables.Playable CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount); // 0x07419d24
	UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount); // 0x07419e20
	System.Void InitializeClips(MaterialTrack.IMaterialProvider provider); // 0x07419f78
	static System.String BuildClipName(MaterialTrack.RendererBehaviour data); // 0x07418064
	System.Void .ctor(); // 0x0741a308
}

// Client.Runtime
class System.OnLateUpdatePostSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer MgrMyPlayer; // 0x10
	static System.Int32 LiquidPCScaleId; // 0x0
	System.Single lastScale; // 0x18
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0741a3c8
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0741a42c
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0741a4fc
	System.Void PostHandleFov(); // 0x0741a590
	System.Void OnDestroy(); // 0x0741a8f4
	System.Void .ctor(); // 0x0741a954
	static System.Void .cctor(); // 0x0741a9bc
}

// Client.Runtime
class System.OnLateUpdatePreSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x10
	WizardGames.Soc.Common.Unity.MgrCamera mgrCamera; // 0x18
	static System.Int32 LiquidPCScaleId; // 0x0
	System.Single lastScale; // 0x20
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0741aa24
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0741aa88
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0741ab94
	System.Void PreHandleFov(); // 0x0741ac28
	System.Void OnDestroy(); // 0x0741af40
	System.Void .ctor(); // 0x0741afa0
	static System.Void .cctor(); // 0x0741b008
}

// Client.Runtime
class System.TpHeldItemDisplaySystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	SocLogger logger; // 0x10
	Contexts.ClientContext ClientContext; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Go.IEntityGo> players; // 0x20
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer MyPlayer; // 0x28
	WizardGames.Soc.Common.Data.character.TbChracterParameter characterParameter; // 0x30
	UnityEngine.Transform myEye; // 0x38
	UnityEngine.Camera cam; // 0x40
	System.Boolean init; // 0x48
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0741b070
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0741b0d4
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0741b2b4
	System.Boolean CheckBlocked(UnityEngine.Vector3 headPos, UnityEngine.Vector3 Direction, System.Single dis, WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Unity.Go.ClientPlayerGo playerGo); // 0x0741bbe0
	System.Void OnDestroy(); // 0x0741c808
	System.Void .ctor(); // 0x0741c868
}

// Client.Runtime
class Player.Animation.PlayerMetaController : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Weapon.WeaponUnique,WizardGames.Editor.FpClipSettingMeta> FpClipSettingMetas; // 0x8
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Weapon.WeaponUnique,WizardGames.Soc.Common.Unity.Character.TpMetaDataProxy> TpClipSettingMetas; // 0x10
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Weapon.WeaponUnique,System.Int32> FpCache; // 0x18
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Weapon.WeaponUnique,System.Int32> TpCache; // 0x20
	static System.Void Clear(); // 0x0741c920
	static System.Void AddFp(WizardGames.Soc.Common.Weapon.WeaponUnique weaponUnique, WizardGames.Editor.FpClipSettingMeta meta); // 0x0741ca38
	static WizardGames.Editor.FpClipSettingMeta GetFp(WizardGames.Soc.Common.Weapon.WeaponUnique weaponUnique, System.Int64 entityId); // 0x0741cbf4
	static System.Void RemoveFp(WizardGames.Soc.Common.Weapon.WeaponUnique weaponUnique); // 0x0741ce20
	static System.Void AddTp(WizardGames.Soc.Common.Weapon.WeaponUnique weaponUnique, WizardGames.Soc.Common.Unity.Character.TpMetaDataProxy meta); // 0x0741cfe8
	static WizardGames.Soc.Common.Unity.Character.TpMetaDataProxy GetTp(WizardGames.Soc.Common.Weapon.WeaponUnique weaponUnique, System.Int64 entityId); // 0x0741d1b8
	static System.Void RemoveTp(WizardGames.Soc.Common.Weapon.WeaponUnique weaponUnique); // 0x0741d500
	static System.Void .cctor(); // 0x0741d6c8
}

// Client.Runtime
class UnityEngine.DDraw : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	static UnityEngine.GameObject store; // 0x8
	static UnityEngine.DDraw singleton; // 0x10
	static UnityEngine.Camera mainCamera; // 0x18
	System.Collections.Generic.List<UnityEngine.DDraw.BaseObject> list; // 0x30
	static System.Int32 AutoYPosition; // 0x20
	static System.Single LastAutoY; // 0x24
	static UnityEngine.Material lineMaterial; // 0x28
	static UnityEngine.GUISkin _skin; // 0x30
	static UnityEngine.DDraw Get(); // 0x0741d8cc
	static System.Void Capsule(UnityEngine.Vector3 pos, UnityEngine.Quaternion rotation, System.Single fRadius, System.Single fHeight, UnityEngine.Color color, System.Single fDuration, System.Boolean distanceFade); // 0x0741db8c
	static System.Void Sphere(UnityEngine.Vector3 vPos, System.Single fRadius, UnityEngine.Color color, System.Single fDuration, System.Boolean distanceFade); // 0x0741def0
	static System.Void SphereGizmo(UnityEngine.Vector3 vPos, System.Single fRadius, UnityEngine.Color color, System.Single fDuration, System.Boolean distanceFade, System.Boolean ztest); // 0x0741e288
	static System.Void Line(UnityEngine.Vector3 vPos, UnityEngine.Vector3 vPosB, UnityEngine.Color color, System.Single fDuration, System.Boolean distanceFade, System.Boolean ztest); // 0x0741e630
	static System.Void Line(UnityEngine.Vector3 vPos, UnityEngine.Vector3 vNormal, System.Single magnitude, UnityEngine.Color color, System.Single fDuration, System.Boolean distanceFade, System.Boolean ztest); // 0x0741e88c
	static System.Void Arrow(UnityEngine.Vector3 vPos, UnityEngine.Vector3 vPosB, System.Single headSize, UnityEngine.Color color, System.Single fDuration); // 0x0741ec78
	static System.Void ArrowPadded(UnityEngine.Vector3 vPos, UnityEngine.Vector3 vPosB, System.Single padding, System.Single headSize, UnityEngine.Color color, System.Single fDuration); // 0x0741f33c
	static System.Void Arrow(UnityEngine.Vector3 vPos, UnityEngine.Vector3 vNormal, System.Single magnitude, System.Single headSize, UnityEngine.Color color, System.Single fDuration); // 0x0741ef6c
	static System.Void Bounds(UnityEngine.Bounds bnds, UnityEngine.Color color, System.Single fDuration, System.Boolean distanceFade, System.Boolean ztest); // 0x0741f694
	static System.Void Bounds(UnityEngine.Matrix4x4 matrix, UnityEngine.Bounds bnds, UnityEngine.Color color, System.Single fDuration); // 0x0741f9d0
	static System.Void Box(UnityEngine.Vector3 vPos, System.Single fSize, UnityEngine.Color color, System.Single fDuration, System.Boolean distanceFade); // 0x0741fcc0
	static System.Void Box(UnityEngine.Vector3 vPos, UnityEngine.Quaternion rot, UnityEngine.Vector3 size, UnityEngine.Color color, System.Single fDuration, System.Boolean distanceFade); // 0x0741ffd0
	static System.Void Box(UnityEngine.Vector3 vPos); // 0x07420254
	static System.Void Box(UnityEngine.Matrix4x4 matrix, UnityEngine.Color color, System.Single fDuration); // 0x07420340
	static System.Void Text(System.String text, UnityEngine.Vector3 vPos, UnityEngine.Color color, System.Single fDuration); // 0x074205c0
	static System.Void ScreenText(System.String text, System.Int32 x, System.Int32 y, UnityEngine.Color color, System.Single fDuration); // 0x074208c8
	static System.Void ScreenText(System.String text, System.Int32 x, UnityEngine.Color color, System.Single fDuration); // 0x07420bc4
	System.Void Awake(); // 0x07420e7c
	System.Void OnPreRender(); // 0x07420f10
	System.Void OnPostRender(); // 0x07421070
	static System.Void CreateLineMaterial(); // 0x0742129c
	System.Void OnEnable(); // 0x07421610
	System.Void OnDisable(); // 0x07421728
	System.Void BeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext arg1, UnityEngine.Camera arg2); // 0x07421840
	System.Void EndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext arg1, UnityEngine.Camera arg2); // 0x0742193c
	static UnityEngine.GUISkin get_skin(); // 0x07421a38
	System.Void .ctor(); // 0x07421b78
	static System.Void .cctor(); // 0x07421c2c
}

// Client.Runtime
class UnityEngine.DDraw.BaseObject : System.Object
{
	UnityEngine.Vector3 position; // 0x10
	UnityEngine.Matrix4x4 transform; // 0x1c
	UnityEngine.Color color; // 0x5c
	System.Single end; // 0x6c
	System.Single start; // 0x70
	System.Single delta; // 0x74
	System.Boolean distanceFade; // 0x78
	System.Boolean ztest; // 0x79
	System.Collections.Generic.Stack<UnityEngine.Matrix4x4> matrixStack; // 0x80
	static UnityEngine.Vector3[] vDisc; // 0x0
	static UnityEngine.Vector3[] vPlane; // 0x8
	System.Void Draw(); // 0x07421d18
	System.Void Render(); // 0x07421d78
	System.Void PushMatrix(UnityEngine.Matrix4x4 mat); // 0x07421eb0
	System.Void PopMatrix(); // 0x07422044
	System.Void DrawHalfDisc(); // 0x074220e4
	System.Void DrawDisc(); // 0x074223fc
	System.Void Begin(System.Int32 type); // 0x07422244
	System.Void .ctor(); // 0x074225a0
	static System.Void .cctor(); // 0x0742265c
}

// Client.Runtime
class UnityEngine.DDraw.CapsuleObj : UnityEngine.DDraw.BaseObject
{
	System.Single radius; // 0x88
	System.Single height; // 0x8c
	System.Void Draw(); // 0x074228dc
	System.Void .ctor(); // 0x0741de68
}

// Client.Runtime
class UnityEngine.DDraw.SphereObj : UnityEngine.DDraw.BaseObject
{
	
	System.Void Draw(); // 0x07423184
	System.Void .ctor(); // 0x0741e200
}

// Client.Runtime
class UnityEngine.DDraw.SphereGizmoObj : UnityEngine.DDraw.BaseObject
{
	static UnityEngine.Matrix4x4 XZ; // 0x0
	static UnityEngine.Matrix4x4 YZ; // 0x40
	static UnityEngine.Matrix4x4 XY; // 0x80
	System.Void Draw(); // 0x07423348
	System.Void .ctor(); // 0x0741e5a8
	static System.Void .cctor(); // 0x07423470
}

// Client.Runtime
class UnityEngine.DDraw.LineObj : UnityEngine.DDraw.BaseObject
{
	
	System.Void Draw(); // 0x07423740
	System.Void .ctor(); // 0x0741ebf0
}

// Client.Runtime
class UnityEngine.DDraw.CubeObj : UnityEngine.DDraw.BaseObject
{
	
	System.Void Draw(); // 0x07423828
	System.Void .ctor(); // 0x0741f948
}

// Client.Runtime
class UnityEngine.DDraw.ArrowHead : UnityEngine.DDraw.BaseObject
{
	
	System.Void Draw(); // 0x07423a78
	System.Void .ctor(); // 0x0741f60c
}

// Client.Runtime
class UnityEngine.DDraw.TextObj : UnityEngine.DDraw.BaseObject
{
	System.String text; // 0x88
	UnityEngine.Rect rect; // 0x90
	System.Boolean draw; // 0xa0
	System.Void Draw(); // 0x07423ba4
	System.Void .ctor(); // 0x0742081c
}

// Client.Runtime
class UnityEngine.DDraw.ScreenTextObj : UnityEngine.DDraw.BaseObject
{
	System.String text; // 0x88
	System.Int32 x; // 0x90
	System.Int32 y; // 0x94
	System.Void Draw(); // 0x07423ca8
	System.Void .ctor(); // 0x07420b18
}

// Client.Runtime
class UnityEngine.DDraw.<>c : System.Object
{
	static UnityEngine.DDraw.<>c <>9; // 0x0
	static System.Predicate<UnityEngine.DDraw.BaseObject> <>9__26_0; // 0x8
	static System.Void .cctor(); // 0x07423d08
	System.Void .ctor(); // 0x07423d6c
	System.Boolean <OnPreRender>b__26_0(UnityEngine.DDraw.BaseObject o); // 0x07423dd4
}

// Client.Runtime
class UnityEngine.Rendering.Universal.RuntimeResourceReloader : System.Object
{
	static SocLogger logger; // 0x0
	static System.String PackagePath; // 0x8
	static System.Collections.Generic.Dictionary<System.String,UnityEngine.Object> resourceCache; // 0x10
	static System.Collections.Generic.HashSet<System.Object> visitedObjects; // 0x18
	static System.Collections.Generic.Queue<UnityEngine.Rendering.Universal.ReloadTask> reloadTasks; // 0x20
	static UnityEngine.Rendering.Universal.ReloadStatistics statistics; // 0x28
	static System.Boolean isReloading; // 0x30
	static System.Single lastUpdateTime; // 0x34
	static System.Int32 maxTasksPerFrame; // 0x38
	static System.Void ReloadAllShadersInAssetBundle(); // 0x07423e70
	static System.Void StartReloading(); // 0x07424014
	static System.Void CreateReloadTasks(System.Object container, System.String basePath, System.Int32 depth); // 0x07424db4
	static System.Void ProcessField(System.Object container, System.Reflection.FieldInfo fieldInfo, System.String basePath, System.Int32 depth); // 0x074253c0
	static System.Void ProcessArrayField(System.Object container, System.Reflection.FieldInfo fieldInfo, System.String basePath, UnityEngine.Rendering.ReloadAttribute attribute, System.Int32 depth); // 0x074260ec
	static System.Boolean Update(); // 0x0742478c
	static System.Void ProcessReloadTask(UnityEngine.Rendering.Universal.ReloadTask task); // 0x07426dd8
	static System.Type GetTaskTargetType(UnityEngine.Rendering.Universal.ReloadTask task); // 0x0742727c
	static System.Void SetTaskValue(UnityEngine.Rendering.Universal.ReloadTask task, UnityEngine.Object newRes); // 0x07427990
	static System.Void CompleteReloading(); // 0x07426804
	static System.Boolean IsReloadGroup(System.Array field); // 0x074265f4
	static System.Boolean IsNull(System.Object field); // 0x0742533c
	static System.Object GetFieldValueSafely(System.Reflection.FieldInfo fieldInfo, System.Object container); // 0x074259c8
	static UnityEngine.Object Load(System.String path, System.Type type, UnityEngine.Rendering.ReloadAttribute.Package location); // 0x074273a8
	static System.Void RefreshRenderPipeline(); // 0x07427d0c
	static System.Void Clear(); // 0x07424994
	static System.Boolean IsReloadGroup(System.Reflection.FieldInfo info); // 0x07425798
	static UnityEngine.Rendering.ReloadAttribute GetReloadAttribute(System.Reflection.FieldInfo fieldInfo); // 0x07425b74
	static System.Boolean IsShaderType(System.Type type); // 0x07425dc4
	static System.String GetFullPath(System.String basePath, UnityEngine.Rendering.ReloadAttribute attribute, System.Int32 index); // 0x07425f38
	static System.Void .cctor(); // 0x07428004
}

// Client.Runtime
enum UnityEngine.Rendering.Universal.ReloadTaskType : System.Enum
{
	System.Int32 value__; // 0x10
	static UnityEngine.Rendering.Universal.ReloadTaskType Field = 0;
	static UnityEngine.Rendering.Universal.ReloadTaskType ArrayElement = 1;
	
}

// Client.Runtime
class UnityEngine.Rendering.Universal.ReloadTask : System.Object
{
	UnityEngine.Rendering.Universal.ReloadTaskType TaskType; // 0x10
	System.Object Container; // 0x18
	System.Reflection.FieldInfo FieldInfo; // 0x20
	System.Array Array; // 0x28
	System.Int32 ArrayIndex; // 0x30
	System.String Path; // 0x38
	UnityEngine.Rendering.ReloadAttribute.Package Package; // 0x40
	System.Void .ctor(); // 0x07425ed0
}

// Client.Runtime
class UnityEngine.Rendering.Universal.ReloadStatistics : System.Object
{
	System.Int32 <ProcessedShaderCount>k__BackingField; // 0x10
	System.Int32 <LoadedResourceCount>k__BackingField; // 0x14
	System.Int32 <CachedResourceCount>k__BackingField; // 0x18
	System.Int32 <ErrorCount>k__BackingField; // 0x1c
	System.Single <TotalElapsedTime>k__BackingField; // 0x20
	System.Int32 get_ProcessedShaderCount(); // 0x074281c0
	System.Void set_ProcessedShaderCount(System.Int32 value); // 0x07428224
	System.Int32 get_LoadedResourceCount(); // 0x0742829c
	System.Void set_LoadedResourceCount(System.Int32 value); // 0x07428300
	System.Int32 get_CachedResourceCount(); // 0x07428378
	System.Void set_CachedResourceCount(System.Int32 value); // 0x074283dc
	System.Int32 get_ErrorCount(); // 0x07428454
	System.Void set_ErrorCount(System.Int32 value); // 0x074284b8
	System.Single get_TotalElapsedTime(); // 0x07428530
	System.Void set_TotalElapsedTime(System.Single value); // 0x07428594
	System.Void Reset(); // 0x07424bd4
	System.String ToString(); // 0x0742860c
	System.Void .ctor(); // 0x07428158
}

// Client.Runtime
class UnityEngine.AI.NavMeshModifierVolume : UnityEngine.MonoBehaviour
{
	UnityEngine.Vector3 m_Size; // 0x30
	UnityEngine.Vector3 m_Center; // 0x3c
	System.Int32 m_Area; // 0x48
	System.Collections.Generic.List<System.Int32> m_AffectedAgents; // 0x50
	static System.Collections.Generic.List<UnityEngine.AI.NavMeshModifierVolume> s_NavMeshModifiers; // 0x0
	UnityEngine.Vector3 get_size(); // 0x074288fc
	System.Void set_size(UnityEngine.Vector3 value); // 0x07428960
	UnityEngine.Vector3 get_center(); // 0x074289f8
	System.Void set_center(UnityEngine.Vector3 value); // 0x07428a5c
	System.Int32 get_area(); // 0x07428af4
	System.Void set_area(System.Int32 value); // 0x07428b58
	static System.Collections.Generic.List<UnityEngine.AI.NavMeshModifierVolume> get_activeModifiers(); // 0x07428bd0
	System.Void OnEnable(); // 0x07428c58
	System.Void OnDisable(); // 0x07428db0
	System.Boolean AffectsAgentType(System.Int32 agentTypeID); // 0x07428e64
	System.Void AddAgentType(System.Int32 agentTypeID); // 0x07428f60
	System.Void ClearAgentTypes(); // 0x07429078
	System.Void .ctor(); // 0x074290fc
	static System.Void .cctor(); // 0x074291c8
}

// Client.Runtime
class Monster.MonsterUtil : System.Object
{
	static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.Int32>> monumentPaths; // 0x0
	static System.Boolean NotDay(); // 0x07429260
	static System.Boolean IsNight(); // 0x07429334
	static System.Void .cctor(); // 0x07429404
}

// Client.Runtime
class LobbyFriend.FriendInfo : System.Object
{
	static SocLogger logger; // 0x0
	System.String roleId; // 0x10
	System.String icon; // 0x18
	System.Int32 frameId; // 0x20
	System.Int32 level; // 0x24
	System.String name; // 0x28
	System.Int32 status; // 0x30
	System.String lastlogintime; // 0x38
	System.String lastlogouttime; // 0x40
	System.Int32 intimacy; // 0x48
	System.Boolean deleted; // 0x4c
	System.Int32 battleGameMode; // 0x50
	System.Int32 teamStatus; // 0x54
	Config.EUserPrivacy userPrivacy; // 0x58
	System.Int32 styleID; // 0x5c
	System.Int32 rankPoint; // 0x60
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> styleRankDic; // 0x68
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> roleAppPrivileges; // 0x70
	System.Int32 seasonPoints; // 0x78
	System.UInt64 communityID; // 0x80
	static WizardGames.Soc.Common.ObjPool.PoolConfig<LobbyFriend.FriendInfo> poolConfig; // 0x8
	static WizardGames.Soc.Common.ObjPool.ObjectPool<LobbyFriend.FriendInfo> _pool; // 0x40
	System.Void .ctor(); // 0x0742949c
	System.Void PraseRoleAppPrivileges(SimpleJSON.JSONNode privilegeNode); // 0x07429580
	System.Boolean GetRoleAppPrivilegeStateToId(System.Int32 id, WizardGames.Soc.Common.Data.EChannelFunctionType functionType); // 0x07429754
	static WizardGames.Soc.Common.ObjPool.ObjectPool<LobbyFriend.FriendInfo> get_FriendInfoPool(); // 0x07429b80
	static LobbyFriend.FriendInfo NewFriendInfo(); // 0x07429cd4
	static System.Void Return(LobbyFriend.FriendInfo info); // 0x07429d74
	System.Void Dispose(); // 0x07429e2c
	static System.Void .cctor(); // 0x07429f34
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.String,System.Int32> roleId2RequestTime; // 0x18
	System.Collections.Generic.Dictionary<System.String,System.String> askRoleId2Name; // 0x20
	System.Collections.Generic.List<LobbyFriend.FriendInfo> friendInfos; // 0x28
	System.Collections.Generic.List<System.String> friendRoleIds; // 0x30
	System.Collections.Generic.List<LobbyFriend.FriendInfo> playerIdInfos; // 0x38
	System.Collections.Generic.List<LobbyFriend.FriendInfo> playerNameInfos; // 0x40
	System.Boolean isSearchId; // 0x48
	System.Boolean isSearchName; // 0x49
	static System.String searchText; // 0x8
	System.Collections.Generic.Dictionary<System.String,LobbyFriend.FriendInfo> requestInfos; // 0x50
	System.Collections.Generic.List<System.String> requestIds; // 0x58
	System.Int32 askCd; // 0x60
	System.Int32 limitFriendNum; // 0x64
	System.Collections.Generic.List<System.String> blackIdInfos; // 0x68
	System.Collections.Generic.List<System.String> requestAddFriendRoleIdSortList; // 0x70
	System.Collections.Generic.Dictionary<System.String,LobbyFriend.FriendInfo> requestSortInfos; // 0x78
	WizardGames.Soc.SocClient.PersistentData.CommonAccountPersistentData perData; // 0x80
	System.Boolean isFirstRequestFriend; // 0x88
	System.Collections.Generic.Dictionary<System.String,LobbyFriend.FriendInfo> blackInfos; // 0x90
	System.String[] lastResponseJsonArray; // 0x98
	System.Collections.Generic.Dictionary<System.String,System.Int32> requestFriendInfoDic; // 0xa0
	System.Collections.Generic.Dictionary<System.String,System.Int32> friendsIntimacy; // 0xa8
	System.Int32 newRequestNum; // 0xb0
	System.Collections.Generic.Dictionary<System.String,LobbyFriend.FriendInfo> get_RequestSortInfos(); // 0x0742a0b0
	System.Void set_NewRequestNum(System.Int32 value); // 0x0742a290
	System.Int32 get_NewRequestNum(); // 0x0742a3bc
	System.Void .ctor(); // 0x0742a420
	System.Void OnLobbyReconnected(); // 0x0742a880
	System.Void OnFastReconnected(); // 0x0742a8e8
	System.Void RefreshFriendsIntimacy(System.String roleId, System.Int32 lastValue); // 0x0742a950
	System.Boolean IsFriend(System.String roleId); // 0x0742aa34
	System.Boolean IsBlack(System.String roleId); // 0x0742aaf4
	System.Void ReqAllFriendInfo(); // 0x0742ab90
	System.Void ReqGetUserInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule); // 0x0742ad20
	System.Void HandleFriends(SimpleJSON.JSONNode json); // 0x0742aeb8
	System.Void ReqFriendInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule); // 0x0742b564
	System.String[] HandleFriendListJson(SimpleJSON.JSONNode json); // 0x0742b04c
	System.Void ReqDetailInfo(System.String[] infos, WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule); // 0x0742b448
	System.Void ReqPlayerInfoById(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String roleId, System.Action callback); // 0x0742b6a8
	System.Void ClearLastSearch(); // 0x0742b824
	System.Void ReqPlayerInfoByName(System.String text, WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action callback); // 0x0742b8f4
	System.Int32 TryPostAddFriendReq(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String roleId, System.String name, Config.EUserPrivacy userPrivacy, System.String friendSource); // 0x0742bbcc
	System.Void RemoveFriendByLocal(System.String roleId); // 0x0742c45c
	System.Void PostAddFriendReq(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String roleId, System.String name, System.String friendSource); // 0x0742c134
	System.Void ClearRequestList(); // 0x0742c5c8
	System.Void ReqGetRequestInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action callback); // 0x0742c6d8
	System.Void HandleApplyInfo(System.String[] roleIds, System.Action callback); // 0x0742c950
	System.Void GetRequestDetailInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String[] infos, System.Action callback); // 0x0742cad0
	System.Void RemoveRequestByLocal(System.String roleId, System.Boolean isAll); // 0x0742cc40
	LobbyFriend.FriendInfo ParseFriendInfo(SimpleJSON.JSONNode element); // 0x0742ce10
	System.Void ReturnFriendInfoToPool(System.Collections.Generic.List<LobbyFriend.FriendInfo> data); // 0x0742d780
	System.Void ReqGetBlackInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action callBack); // 0x0742d918
	System.Void HandleBlackInfo(System.String[] roleIds, System.Action callBack); // 0x0742db04
	System.Void GetBlackDetailInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String[] infos, System.Action callback); // 0x0742dbec
	System.Void TryRemoveBlackByLocal(System.String roleId); // 0x0742dd5c
	System.Void OnClickAgree(System.String roleId, System.String name, System.Action callback); // 0x0742de9c
	System.Void OnClickReject(System.String roleId, System.String name, System.Action callback); // 0x0742e350
	System.Void OnClickAgreeAll(System.Action callback); // 0x0742e704
	System.Void OnClickRejectAll(System.Action callback); // 0x0742ead0
	System.Void OnClickBlock(System.String roleId, System.String name, System.Action callBack); // 0x0742ecdc
	System.Void ConfirmBlackPlayer(System.String roleId, System.String name, System.Action callBack); // 0x0742f228
	System.Void ConfirmUnBlock(System.String roleId, System.String name); // 0x0742f50c
	System.Void UnBlockPlayer(System.String roleId, System.String name); // 0x0742f78c
	System.Void PrivateChat(System.String roleId); // 0x0742fc08
	System.Void ReqPlayerName(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String[] roleIds, System.Action<System.String[]> callBack); // 0x0742fd48
	System.Void PlayerAgreeMyAsk(SimpleJSON.JSONNode jsonNode); // 0x0742febc
	System.Void PlayerRejectMyAsk(SimpleJSON.JSONNode jsonNode); // 0x07430204
	System.Void PlayerAskAdd(SimpleJSON.JSONNode jsonNode); // 0x0743050c
	System.Void PlayerRemoveMe(SimpleJSON.JSONNode jsonNode); // 0x07430740
	System.Boolean CheckAskExpired(System.String roleId); // 0x0742c01c
	System.Int32 CheckHasNewRequest(); // 0x0743086c
	System.Void SortFriendList(System.Collections.Generic.List<LobbyFriend.FriendInfo> friendList); // 0x07430904
	System.Void RecordFriendIds(System.String[] jsonArray); // 0x0742b2ec
	System.Void DeleteFriend(System.String roleID, System.String roleName); // 0x07430cc8
	System.String GetFrindSelectPage(LobbyFriend.FriendInfo friendInfo); // 0x07431164
	System.Void OnAccountLogout(); // 0x07431254
	System.Void OnAccountLogined(); // 0x074314a8
	System.Void OnAccountEnterLobby(); // 0x0743157c
	static System.Void .cctor(); // 0x074315ec
	System.Void <ReqAllFriendInfo>b__35_0(SimpleJSON.JSONNode res); // 0x074316c0
	System.Void <ReqGetUserInfo>b__36_0(SimpleJSON.JSONNode res); // 0x07431824
	System.Void <ReqDetailInfo>b__40_0(SimpleJSON.JSONArray jsonArray); // 0x0743193c
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c : System.Object
{
	static LobbyFriend.MgrLobbyFriend.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__61_1; // 0x8
	static System.Comparison<LobbyFriend.FriendInfo> <>9__75_0; // 0x10
	static System.Comparison<LobbyFriend.FriendInfo> <>9__75_1; // 0x18
	static System.Void .cctor(); // 0x0756c9ec
	System.Void .ctor(); // 0x0756ca50
	System.Void <OnClickAgreeAll>b__61_1(SimpleJSON.JSONNode error); // 0x0756cab8
	System.Int32 <SortFriendList>b__75_0(LobbyFriend.FriendInfo x, LobbyFriend.FriendInfo y); // 0x0756ce84
	System.Int32 <SortFriendList>b__75_1(LobbyFriend.FriendInfo x, LobbyFriend.FriendInfo y); // 0x0756cf1c
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass41_0 : System.Object
{
	LobbyFriend.MgrLobbyFriend <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x0756cfb4
	System.Void <ReqPlayerInfoById>b__0(SimpleJSON.JSONNode res); // 0x0756d01c
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass43_0 : System.Object
{
	LobbyFriend.MgrLobbyFriend <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x0756d26c
	System.Void <ReqPlayerInfoByName>b__0(SimpleJSON.JSONNode res); // 0x0756d2d4
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass46_0 : System.Object
{
	System.String name; // 0x10
	LobbyFriend.MgrLobbyFriend <>4__this; // 0x18
	System.String roleId; // 0x20
	System.Void .ctor(); // 0x0756d5d0
	System.Void <PostAddFriendReq>b__0(SimpleJSON.JSONNode jsonNode); // 0x0756d638
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass49_0 : System.Object
{
	LobbyFriend.MgrLobbyFriend <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x0756d924
	System.Void <ReqGetRequestInfo>b__0(SimpleJSON.JSONNode res); // 0x0756d98c
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass51_0 : System.Object
{
	LobbyFriend.MgrLobbyFriend <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x0756daf4
	System.Void <GetRequestDetailInfo>b__0(SimpleJSON.JSONArray jsonArray); // 0x0756db5c
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass55_0 : System.Object
{
	LobbyFriend.MgrLobbyFriend <>4__this; // 0x10
	System.Action callBack; // 0x18
	System.Void .ctor(); // 0x0756dfa4
	System.Void <ReqGetBlackInfo>b__0(SimpleJSON.JSONNode res); // 0x0756e00c
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass57_0 : System.Object
{
	LobbyFriend.MgrLobbyFriend <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x0756e124
	System.Void <GetBlackDetailInfo>b__0(SimpleJSON.JSONArray jsonArray); // 0x0756e18c
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass59_0 : System.Object
{
	System.String name; // 0x10
	LobbyFriend.MgrLobbyFriend <>4__this; // 0x18
	System.String roleId; // 0x20
	System.Action callback; // 0x28
	System.Void .ctor(); // 0x0756e5dc
	System.Void <OnClickAgree>b__0(SimpleJSON.JSONNode jsonNode); // 0x0756e644
	System.Void <OnClickAgree>b__1(SimpleJSON.JSONNode error); // 0x0756e7a4
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass60_0 : System.Object
{
	System.String name; // 0x10
	LobbyFriend.MgrLobbyFriend <>4__this; // 0x18
	System.String roleId; // 0x20
	System.Action callback; // 0x28
	System.Void .ctor(); // 0x0756e9bc
	System.Void <OnClickReject>b__0(SimpleJSON.JSONNode jsonNode); // 0x0756ea24
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass61_0 : System.Object
{
	System.Boolean isOverflow; // 0x10
	LobbyFriend.MgrLobbyFriend <>4__this; // 0x18
	WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__2; // 0x20
	System.Void .ctor(); // 0x0756eb64
	System.Void <OnClickAgreeAll>b__0(SimpleJSON.JSONNode jsonNode); // 0x0756ebcc
	System.Void <OnClickAgreeAll>b__2(System.Int64 a, System.Object b, System.Boolean c); // 0x0756eebc
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass62_0 : System.Object
{
	LobbyFriend.MgrLobbyFriend <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x0756ef90
	System.Void <OnClickRejectAll>b__0(SimpleJSON.JSONNode jsonNode); // 0x0756eff8
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass63_0 : System.Object
{
	LobbyFriend.MgrLobbyFriend <>4__this; // 0x10
	System.String roleId; // 0x18
	System.String name; // 0x20
	System.Action callBack; // 0x28
	System.Void .ctor(); // 0x0756f15c
	System.Void <OnClickBlock>b__0(); // 0x0756f1c4
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass64_0 : System.Object
{
	System.String name; // 0x10
	LobbyFriend.MgrLobbyFriend <>4__this; // 0x18
	System.String roleId; // 0x20
	System.Action callBack; // 0x28
	System.Void .ctor(); // 0x0756f23c
	System.Void <ConfirmBlackPlayer>b__0(SimpleJSON.JSONNode jsonNode); // 0x0756f2a4
	System.Void <ConfirmBlackPlayer>b__1(SimpleJSON.JSONNode error); // 0x0756f3d0
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass65_0 : System.Object
{
	LobbyFriend.MgrLobbyFriend <>4__this; // 0x10
	System.String roleId; // 0x18
	System.Void .ctor(); // 0x0756f5e8
	System.Void <ConfirmUnBlock>b__0(SimpleJSON.JSONNode jsonNode); // 0x0756f650
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass66_0 : System.Object
{
	LobbyFriend.MgrLobbyFriend <>4__this; // 0x10
	System.String roleId; // 0x18
	System.String name; // 0x20
	System.Void .ctor(); // 0x0756f778
	System.Void <UnBlockPlayer>b__0(); // 0x0756f7e0
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass67_0 : System.Object
{
	System.UInt64 id; // 0x10
	System.Void .ctor(); // 0x0756f854
	System.Void <PrivateChat>g__deal|0(WizardGames.Soc.SocClient.Ui.UiChat chat); // 0x0756f8bc
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass68_0 : System.Object
{
	System.String[] roleIds; // 0x10
	System.Action<System.String[]> callBack; // 0x18
	System.Void .ctor(); // 0x0756f9b8
	System.Void <ReqPlayerName>b__0(SimpleJSON.JSONArray jsonArray); // 0x0756fa20
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass69_0 : System.Object
{
	System.String playerName; // 0x10
	System.Void .ctor(); // 0x0756fc60
	System.Void <PlayerAgreeMyAsk>b__0(System.String[] names); // 0x0756fcc8
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass70_0 : System.Object
{
	System.String playerName; // 0x10
	System.Void .ctor(); // 0x0756fd5c
	System.Void <PlayerRejectMyAsk>b__0(System.String[] names); // 0x0756fdc4
}

// Client.Runtime
class LobbyFriend.MgrLobbyFriend.<>c__DisplayClass78_0 : System.Object
{
	System.String roleID; // 0x10
	LobbyFriend.MgrLobbyFriend <>4__this; // 0x18
	System.Action<SimpleJSON.JSONNode> <>9__1; // 0x20
	System.Void .ctor(); // 0x0756fe58
	System.Void <DeleteFriend>b__0(); // 0x0756fec0
	System.Void <DeleteFriend>b__1(SimpleJSON.JSONNode jsonNode); // 0x0757035c
}

// Client.Runtime
class LobbyFriend.MgrLobbyPlatformFriend : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<LobbyFriend.PlatformFriendInfo> platformFriendList; // 0x18
	System.Collections.Generic.List<LobbyFriend.PlatformFriendInfo> searchFriendList; // 0x20
	System.Collections.Generic.Dictionary<System.String,System.Boolean> inviteStatusDic; // 0x28
	System.Int64 lastPullTimeStamp; // 0x30
	System.Void Init(); // 0x075704d0
	System.Void Destroy(); // 0x07570638
	System.Void OnAccountLogout(); // 0x075706d0
	System.Void CleanUp(); // 0x07570768
	System.Void ClearAll(); // 0x07570568
	System.Void OnAccountLogined(); // 0x075707d8
	System.Void ReqGetPlatformFriendInfos(); // 0x0757083c
	System.Collections.Generic.IReadOnlyList<System.String> HandlePlatformFriendListJson(SimpleJSON.JSONNode json); // 0x07570ff0
	System.Void ReqPlatFriendList(SimpleJSON.JSONNode jsonNode); // 0x07571aec
	System.Void ReqPlayerList(SimpleJSON.JSONNode jsonNode); // 0x07572294
	System.Int32 SortFriendList(LobbyFriend.PlatformFriendInfo x, LobbyFriend.PlatformFriendInfo y); // 0x075728e8
	LobbyFriend.PlatformFriendInfo GetPlatformFriendInfo(System.String openID); // 0x07571688
	System.Collections.Generic.IReadOnlyList<LobbyFriend.PlatformFriendInfo> GetPlatformFriendInfoByIdOrName(System.String nameOrId); // 0x07572d90
	System.Collections.Generic.IReadOnlyList<LobbyFriend.PlatformFriendInfo> GetPlatformFriendList(); // 0x07573114
	System.String GetFriendSelectPage(Config.LobbyRoleInfo friendInfo); // 0x075732d0
	System.Void SetInviteStatus(System.String openID, System.Boolean inviteStatus); // 0x075733c0
	System.Boolean GetInviteStatus(System.String openID); // 0x075734cc
	System.Void .ctor(); // 0x07573564
	static System.Void .cctor(); // 0x075736a8
}

// Client.Runtime
class LobbyFriend.MgrLobbyPlatformFriend.<>c : System.Object
{
	static LobbyFriend.MgrLobbyPlatformFriend.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__13_0; // 0x8
	static System.Action<SimpleJSON.JSONNode> <>9__15_0; // 0x10
	static System.Void .cctor(); // 0x0757377c
	System.Void .ctor(); // 0x075737e0
	System.Void <ReqGetPlatformFriendInfos>b__13_0(SimpleJSON.JSONNode node); // 0x07573848
	System.Void <ReqPlatFriendList>b__15_0(SimpleJSON.JSONNode node); // 0x0757395c
}

// Client.Runtime
class LobbyFriend.PlatformFriendInfo : System.Object
{
	Config.LobbyRoleInfo <FriendInfo>k__BackingField; // 0x10
	System.String <UserName>k__BackingField; // 0x18
	System.String <PictureURL>k__BackingField; // 0x20
	System.String <OpenID>k__BackingField; // 0x28
	Config.LobbyRoleInfo get_FriendInfo(); // 0x07573a38
	System.Void set_FriendInfo(Config.LobbyRoleInfo value); // 0x07573a9c
	System.String get_UserName(); // 0x07573b1c
	System.Void set_UserName(System.String value); // 0x07573b80
	System.String get_PictureURL(); // 0x07573c00
	System.Void set_PictureURL(System.String value); // 0x07573c64
	System.String get_OpenID(); // 0x07573ce4
	System.Void set_OpenID(System.String value); // 0x07573d48
	System.Void .ctor(System.String userName, System.Int32 Gender, System.String pictureURL, System.String openID); // 0x0757188c
	System.Void UpdateInfo(System.String userName, System.Int32 Gender, System.String pictureURL, System.String openID); // 0x07571944
	System.Void UpdateFriendInfo(Config.LobbyRoleInfo friendInfo); // 0x07572834
	System.Boolean GetRoleAppPrivilegeStateToId(System.Int32 id, WizardGames.Soc.Common.Data.EChannelFunctionType functionType); // 0x07573dc8
}

// Client.Runtime
class LobbyFriend.MgrLobbyTempFriend : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<LobbyFriend.TempFriendInfo> tempFriendList; // 0x18
	System.Collections.Generic.Dictionary<System.String,LobbyFriend.TempFriendInfo> tempFriendDic; // 0x20
	System.Boolean hasNewTempFriend; // 0x28
	System.Void set_HasNewTempFriend(System.Boolean value); // 0x07573eac
	System.Void Init(); // 0x07573fa4
	System.Threading.Tasks.Task OnEnterWorld(); // 0x07574158
	System.Void OnPlayerCreate(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07574450
	System.Threading.Tasks.Task OnExitWorld(); // 0x075746c4
	System.Void OnTempFriendChanged(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.UInt64 seq, WizardGames.Soc.Common.CustomType.RecentFriend oldMsg); // 0x07574838
	System.Boolean CheckHasNewTempFriend(); // 0x07574d50
	System.Void TryAddOneTempFriend(System.String roleId, System.String lastModifyTime, System.Collections.Generic.List<System.Int32> reasonList); // 0x07574a7c
	System.Void TryRemoveTempFriend(System.String roleId); // 0x07574c48
	System.Void CheckRefreshTempFriend(); // 0x07575410
	System.Void RefreshTempFriendList(System.Boolean isForce); // 0x07574f0c
	System.Void TryReqTempFriendInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule); // 0x07575594
	System.Void ReqTempFriendInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule); // 0x075742bc
	System.Void HandleRecentList(SimpleJSON.JSONNode json); // 0x075756a0
	System.Void ReqDetailInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String[] infos); // 0x07575478
	System.Void SortTempFriend(); // 0x07575a7c
	System.Void Destroy(); // 0x07575ec0
	System.Void .ctor(); // 0x07575fc4
	static System.Void .cctor(); // 0x0757602c
	System.Void <ReqTempFriendInfo>b__18_0(SimpleJSON.JSONNode res); // 0x07576100
	System.Void <ReqDetailInfo>b__20_0(SimpleJSON.JSONArray jsonArray); // 0x07576218
}

// Client.Runtime
class LobbyFriend.MgrLobbyTempFriend.<>c : System.Object
{
	static LobbyFriend.MgrLobbyTempFriend.<>c <>9; // 0x0
	static System.Comparison<LobbyFriend.TempFriendInfo> <>9__21_0; // 0x8
	static System.Comparison<LobbyFriend.TempFriendInfo> <>9__21_1; // 0x10
	static System.Void .cctor(); // 0x0757707c
	System.Void .ctor(); // 0x075770e0
	System.Int32 <SortTempFriend>b__21_0(LobbyFriend.TempFriendInfo x, LobbyFriend.TempFriendInfo y); // 0x07577148
	System.Int32 <SortTempFriend>b__21_1(LobbyFriend.TempFriendInfo x, LobbyFriend.TempFriendInfo y); // 0x07577270
}

// Client.Runtime
class LobbyFriend.TempFriendInfo : System.Object
{
	LobbyFriend.FriendInfo <FriendInfo>k__BackingField; // 0x10
	System.String <RoleID>k__BackingField; // 0x18
	System.String <LastModifyTime>k__BackingField; // 0x20
	System.Collections.Generic.List<System.Int32> reasonList; // 0x28
	System.Void set_FriendInfo(LobbyFriend.FriendInfo value); // 0x07577398
	LobbyFriend.FriendInfo get_FriendInfo(); // 0x07577418
	System.Void set_RoleID(System.String value); // 0x0757747c
	System.Void set_LastModifyTime(System.String value); // 0x075774fc
	System.Void .ctor(System.String roleId, System.String lastModifyTime, System.Collections.Generic.List<System.Int32> _reasonList); // 0x07574db4
	System.Void SetFriendInfo(LobbyFriend.FriendInfo friend); // 0x07576fc8
	System.Void UpdateTempFriendInfo(System.String roleId, System.String lastModifyTime, System.Collections.Generic.List<System.Int32> _reasonList); // 0x075752c4
}

// Client.Runtime
class Assets.Scripts.UI.Window.UI.UiMission.MissionTabData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	WizardGames.Soc.Common.Data.Play.MissionTab cfg; // 0x10
	WizardGames.Soc.Common.Data.MissionTabType get_TabType(); // 0x0757757c
	System.String get_Name(); // 0x075775f0
	System.Int32 get_Priority(); // 0x07577688
	System.Boolean get_IsLock(); // 0x075776fc
	System.String get_Icon(); // 0x075777bc
	System.Void Init(WizardGames.Soc.Common.Data.Play.MissionTab cfg); // 0x0757784c
	System.Void OnGet(); // 0x075778cc
	System.Void OnRelease(); // 0x0757792c
	System.Void OnDestroy(); // 0x07577998
	System.Void .ctor(); // 0x075779f8
}

// Client.Runtime
class Assets.Scripts.Telemetry.ClientTelemetryImpl : WizardGames.Soc.Share.Telemetry.TelemetryBase
{
	static Assets.Scripts.Telemetry.ClientTelemetryImpl Instance; // 0x0
	static WizardGames.Soc.Share.Telemetry.CommandExecutor executor; // 0x8
	static System.Int32 seq; // 0x10
	static WizardGames.Soc.Share.Telemetry.CommandExecutor get_Executor(); // 0x07577a60
	System.String TestLoot(System.ArraySegment<System.String> cmdInput); // 0x07577ae8
	System.String TestDoRepair(System.ArraySegment<System.String> cmdInput); // 0x07577dc4
	System.String UseItem(System.ArraySegment<System.String> cmdInput); // 0x07577ef4
	System.String MoveItem(System.ArraySegment<System.String> cmdInput); // 0x07578184
	System.String SendTeamChat(System.ArraySegment<System.String> cmdInput); // 0x0757849c
	System.String PrintEntityDistance(System.ArraySegment<System.String> cmdInput); // 0x0757864c
	System.String ContinuousPrintEntityDistance(System.ArraySegment<System.String> cmdInput); // 0x0757967c
	System.String SendUdpPacket(System.ArraySegment<System.String> cmdInput); // 0x07579a28
	System.String GetMyEntityLocalProp(System.ArraySegment<System.String> cmdInput); // 0x07579b48
	System.String SendElectricCmd(System.ArraySegment<System.String> cmdInput); // 0x07579ca8
	System.String GetProperty(System.ArraySegment<System.String> cmdInput); // 0x07579d3c
	System.String SetProperty(System.ArraySegment<System.String> cmdInput); // 0x0757a370
	System.String PrintBriefEntities(System.ArraySegment<System.String> cmdInput); // 0x0757a954
	System.String GetBriefEntityProperty(System.ArraySegment<System.String> cmdInput); // 0x0757a9e8
	System.String TerrPermissionCheck(System.ArraySegment<System.String> cmdInput); // 0x0757aa7c
	System.String Disconnect(System.ArraySegment<System.String> cmdInput); // 0x0757b134
	System.String ShowGoEntityEqual(System.ArraySegment<System.String> cmdInput); // 0x0757b37c
	System.String SwitchReconnect(System.ArraySegment<System.String> cmdInput); // 0x0757b710
	System.String ShowTime(System.ArraySegment<System.String> cmdInput); // 0x0757b7a4
	System.String SendQuickTeamChat(System.ArraySegment<System.String> cmdInput); // 0x0757bf84
	System.String StopMixing(System.ArraySegment<System.String> cmdInput); // 0x0757c26c
	System.String GetDepth(System.ArraySegment<System.String> cmdInput); // 0x0757c4e8
	System.String GetEntityProperty(System.ArraySegment<System.String> cmdInput); // 0x0757c6a8
	System.String StartNetTest(System.ArraySegment<System.String> cmdInput); // 0x0757cee4
	System.String StartNetTestToSimulator(System.ArraySegment<System.String> cmdInput); // 0x0757d154
	System.String NetTestStat(System.ArraySegment<System.String> cmdInput); // 0x0757d3c4
	System.String ClientNetStat(System.ArraySegment<System.String> cmdInput); // 0x0757d82c
	System.String DropReceive(System.ArraySegment<System.String> cmdInput); // 0x0757e14c
	System.String DropSend(System.ArraySegment<System.String> cmdInput); // 0x0757e454
	System.String ChangeReceive(System.ArraySegment<System.String> cmdInput); // 0x0757e75c
	System.String TestClientTimer(System.ArraySegment<System.String> cmdInput); // 0x054f524c
	System.String PlayerDebug(System.ArraySegment<System.String> cmdInput); // 0x0757ed84
	System.String ClientPlayerStateLog(System.ArraySegment<System.String> cmdInput); // 0x054f524c
	System.String AddLobbyItem(System.ArraySegment<System.String> cmdInput); // 0x0757f1ac
	System.String InstAsset(System.ArraySegment<System.String> cmdInput); // 0x0757f77c
	System.String ClearAsset(System.ArraySegment<System.String> cmdInput); // 0x0757fad4
	System.String GetOneOutside(System.ArraySegment<System.String> cmdInput); // 0x0757fb94
	System.String TestRpcParam(System.ArraySegment<System.String> cmdInput); // 0x0757fcc4
	System.String MoveItemToPath(System.ArraySegment<System.String> cmdInput); // 0x07580074
	System.String FindNearbyTerritory(System.ArraySegment<System.String> cmdInput); // 0x075805b4
	System.String FindInChargeTerritory(System.ArraySegment<System.String> cmdInput); // 0x07580eac
	System.String ReadRecord(System.ArraySegment<System.String> cmdInput); // 0x075812b4
	System.String ShowRecentRpc(System.ArraySegment<System.String> cmdInput); // 0x0758152c
	System.String SflTest(System.ArraySegment<System.String> cmdInput); // 0x07581610
	System.String ShowEntityRecord(System.ArraySegment<System.String> cmdInput); // 0x07581954
	System.String PoolStat(System.ArraySegment<System.String> cmdInput); // 0x07581a8c
	System.Void .ctor(); // 0x07581cd4
	static System.Void .cctor(); // 0x07581d60
}

// Client.Runtime
class Assets.Scripts.Telemetry.ClientTelemetryImpl.<>c : System.Object
{
	static Assets.Scripts.Telemetry.ClientTelemetryImpl.<>c <>9; // 0x0
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__35_2; // 0x8
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__35_0; // 0x10
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__35_1; // 0x18
	static System.Func<System.String,System.Int64> <>9__43_0; // 0x20
	static System.Func<System.String,System.Int64> <>9__43_1; // 0x28
	static System.Void .cctor(); // 0x07581e24
	System.Void .ctor(); // 0x07581e88
	System.Void <TestClientTimer>b__35_0(System.Int64 _, System.Object _, System.Boolean _); // 0x07581ef0
	System.Void <TestClientTimer>b__35_2(System.Int64 _, System.Object _, System.Boolean _); // 0x07582204
	System.Void <TestClientTimer>b__35_1(System.Int64 _, System.Object _, System.Boolean _); // 0x075823c4
	System.Int64 <MoveItemToPath>b__43_0(System.String num); // 0x07582584
	System.Int64 <MoveItemToPath>b__43_1(System.String num); // 0x07582600
}

// Client.Runtime
class Assets.Scripts.Telemetry.ClientTelemetryImpl.<>c__DisplayClass10_0 : System.Object
{
	System.Int32 entityTypeId; // 0x10
	System.Void .ctor(); // 0x075799c0
	System.Void <ContinuousPrintEntityDistance>b__0(System.Int64 _, System.Object __, System.Boolean ___); // 0x0758267c
}

// Client.Runtime
class Assets.Scripts.Plant.PlantBoxItemData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	WizardGames.Soc.Common.Data.PlantStage <Stage>k__BackingField; // 0x10
	System.Single <WaterRate>k__BackingField; // 0x14
	System.Single <GroudRate>k__BackingField; // 0x18
	System.Single <TemperatureRate>k__BackingField; // 0x1c
	System.Single <LightRate>k__BackingField; // 0x20
	System.Single <StartGrowTime>k__BackingField; // 0x24
	System.Boolean <IsCanManure>k__BackingField; // 0x28
	System.Int32 totalStageTime; // 0x2c
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> GeneList; // 0x30
	System.Int64 <Slot>k__BackingField; // 0x38
	System.Int64 <SeedId>k__BackingField; // 0x40
	System.Int32 <NodeIndex>k__BackingField; // 0x48
	WizardGames.Soc.Common.Data.DataItem.ItemConfig plantSeedCfg; // 0x50
	WizardGames.Soc.Common.Data.PlantStage get_Stage(); // 0x075830bc
	System.Void set_Stage(WizardGames.Soc.Common.Data.PlantStage value); // 0x07583120
	System.Single get_WaterRate(); // 0x07583198
	System.Void set_WaterRate(System.Single value); // 0x075831fc
	System.Single get_GroudRate(); // 0x07583274
	System.Void set_GroudRate(System.Single value); // 0x075832d8
	System.Single get_TemperatureRate(); // 0x07583350
	System.Void set_TemperatureRate(System.Single value); // 0x075833b4
	System.Single get_LightRate(); // 0x0758342c
	System.Void set_LightRate(System.Single value); // 0x07583490
	System.Single get_StartGrowTime(); // 0x07583508
	System.Void set_StartGrowTime(System.Single value); // 0x0758356c
	System.Boolean get_IsCanManure(); // 0x075835e4
	System.Void set_IsCanManure(System.Boolean value); // 0x07583648
	System.Int64 get_Slot(); // 0x075836c4
	System.Void set_Slot(System.Int64 value); // 0x07583728
	System.Int64 get_SeedId(); // 0x075837a0
	System.Void set_SeedId(System.Int64 value); // 0x07583804
	System.Void set_NodeIndex(System.Int32 value); // 0x0758387c
	System.Void Refresh(WizardGames.Soc.Common.CustomType.PlantNode item); // 0x075838f4
	System.Boolean CanManure(); // 0x07583f3c
	System.Int32 get_GrowRate(); // 0x07583fec
	System.Boolean CanHybrid(); // 0x075840d4
	System.Void OnGet(); // 0x07584184
	System.Void OnRelease(); // 0x075841e4
	System.Void OnDestroy(); // 0x07584244
	System.Void .ctor(); // 0x075842a4
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.MicroServiceClient : System.Object
{
	static SocLogger logger; // 0x0
	static Assets.Scripts.MicroServiceClient.MicroServiceClient <Instance>k__BackingField; // 0x8
	static System.Object innerLock; // 0x10
	static System.Int32 _wsloopEnterCount; // 0x18
	static System.Int32 _heartbeatEnterCount; // 0x1c
	static System.Int32 _wsloopReconnectCount; // 0x20
	System.String uid; // 0x10
	System.String token; // 0x18
	System.Boolean websocketConnected; // 0x20
	System.Boolean isInLogin; // 0x21
	System.Int32 websocketFailCount; // 0x24
	System.Int32 wsReconnectMaxCount; // 0x28
	System.Int32 wsReconnectMaxCountWhenSilence; // 0x2c
	System.Int32 lastReconnectTimeSec; // 0x30
	System.Int32 heartbeatTimeStamp; // 0x34
	System.Int32 skipKickoutBoxTimeSec; // 0x38
	Assets.Scripts.MicroServiceClient.MicroServiceClient.ConnectFailMethod connectFailMethod; // 0x3c
	Assets.Scripts.MicroServiceClient.MicroServiceClient.ReconnectMethod reconnectMethod; // 0x40
	System.Threading.CancellationTokenSource connectToken; // 0x48
	System.Threading.CancellationTokenSource receiveToken; // 0x50
	System.Threading.CancellationTokenSource loopToken; // 0x58
	System.Threading.CancellationTokenSource heartbeatToken; // 0x60
	System.Net.WebSockets.ClientWebSocket webSocket; // 0x68
	System.Boolean isInGameLoading; // 0x70
	System.Boolean popToAskReconnectAfterGameLoad; // 0x71
	System.Boolean showErrorTip; // 0x72
	System.Action onWsConnectSuccessfully; // 0x78
	System.Int64 bugCheckTimerID; // 0x80
	System.Boolean <IsDevLogin>k__BackingField; // 0x88
	System.Boolean IsKickOutInLoading; // 0x89
	static Assets.Scripts.MicroServiceClient.MicroServiceClient get_Instance(); // 0x0758430c
	static System.Void set_Instance(Assets.Scripts.MicroServiceClient.MicroServiceClient value); // 0x07584394
	System.Boolean get_IsWorking(); // 0x07584428
	System.Boolean get_IsConnected(); // 0x07584498
	System.Boolean get_IsInReconnect(); // 0x07584504
	System.Boolean get_IsDevLogin(); // 0x0758459c
	System.Void set_IsDevLogin(System.Boolean value); // 0x07584600
	static System.String get_API(); // 0x0758467c
	static System.String get_WS(); // 0x075846e8
	System.Void .ctor(); // 0x07584754
	static System.Void InitMicroServiceClient(); // 0x07584878
	static System.ValueTuple<System.Int32,System.String> _getGrpcErrorCode(UnityEngine.Networking.UnityWebRequest request); // 0x07584bf0
	static SimpleJSON.JSONNode TryParseResult(UnityEngine.Networking.UnityWebRequest request, System.Boolean showErrorPopup); // 0x07584cf4
	static System.String ParseBanTimeDesc(System.Int64 endTime); // 0x07584ffc
	static System.Void ParseErrorMsgFromErrorInfo(SimpleJSON.JSONNode errorInfo, WizardGames.Soc.Common.Data.Lobby.LobbyErrorCodePopStyle& style, System.String& msg); // 0x07585584
	static System.Void PopupResultError(SimpleJSON.JSONNode error); // 0x0756ccf4
	System.Boolean CheckReconnectMethod(Assets.Scripts.MicroServiceClient.MicroServiceClient.ReconnectMethod method); // 0x07585cc4
	System.Void SetReconnectMethod(Assets.Scripts.MicroServiceClient.MicroServiceClient.ReconnectMethod method); // 0x07585d48
	System.Void Login(System.Boolean isDevChannel, SimpleJSON.JSONObject param); // 0x07585e84
	System.Void UpdateLogin(SimpleJSON.JSONObject param); // 0x05523a54
	System.Void Logout(System.Action<SimpleJSON.JSONNode> callback, System.Boolean notifyLogoutToLobby, System.Boolean logoutMSDK); // 0x075869e4
	System.String _parseReceiveRes(System.Net.WebSockets.ValueWebSocketReceiveResult& reveive, System.Byte[]& buffer, System.Int32& count, System.String& res, SimpleJSON.JSONNode& jsonNode); // 0x07586da0
	System.Boolean _isConnectSuccess(System.String receivedMethod); // 0x07586fc4
	System.Void _logicMethodProcess(System.String method, SimpleJSON.JSONNode jsonNode); // 0x075871bc
	System.Func<System.Boolean> CreateTimeoutCounter(System.Int32 step, System.Int32 max); // 0x07587590
	System.Void OnHeartBeat(System.Boolean fromPong); // 0x07587458
	System.Boolean HeartBeatTimeOutCheck(); // 0x075876f0
	System.Boolean HeartBeatCancelCheck(); // 0x07587af8
	System.Void _heartbeatLoop(); // 0x07587be4
	System.Void _websocketLoop(System.Action<System.Int32,SimpleJSON.JSONNode> loginCallback, SimpleJSON.JSONNode loginRet); // 0x0552af00
	System.Void CancelWebsocket(); // 0x0758780c
