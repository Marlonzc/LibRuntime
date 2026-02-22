	System.Void ProcessKickOut(System.Boolean force); // 0x07587dec
	System.Void ProcessReconnect(); // 0x07587fd4
	System.Void ResetReconnectState(); // 0x075880b4
	System.Void PopReconnectCountMax(); // 0x0758814c
	System.Boolean NotifyGameLoadingState(System.Boolean on); // 0x0758836c
	System.Void ClearLoadingFinishPopFlag(); // 0x0758857c
	System.Void DoLoginCallback(System.Action<System.Int32,SimpleJSON.JSONNode> callback, System.Int32 result, SimpleJSON.JSONNode param); // 0x0758863c
	System.Void _loginAsync(SimpleJSON.JSONObject param, System.Action<System.Int32,SimpleJSON.JSONNode> callback); // 0x075860dc
	System.String AddDistChannelToSdkLoginRet(System.String sdkLoginRet); // 0x0758670c
	System.Void CallLobbyPostInternal(System.String path, WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action<SimpleJSON.JSONNode> callback, SimpleJSON.JSONObject body, System.Boolean showErrorPopup, System.Action<SimpleJSON.JSONNode> onError, System.Boolean keyLog, System.Boolean isLogin); // 0x07588818
	System.Void CallLobbyPost(System.String path, WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action<SimpleJSON.JSONNode> callback, SimpleJSON.JSONObject body, System.Boolean showErrorPopup, System.Action<SimpleJSON.JSONNode> onError, System.Boolean keyLog); // 0x07570108
	System.Void CallLobbyGetInternal(System.String path, WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String url, System.Action<SimpleJSON.JSONNode> callback, System.Boolean showErrorPopup, System.Action<SimpleJSON.JSONNode> onError, System.Boolean keyLog); // 0x07588a44
	System.Void CallLobbyGet(System.String path, WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Collections.Generic.IDictionary<System.String,System.String> param, System.Action<SimpleJSON.JSONNode> callback, System.Boolean showErrorPopup, System.Action<SimpleJSON.JSONNode> onError, System.Boolean keyLog); // 0x07570e38
	System.Void CallLobbyGet(System.String path, WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String arrKey, System.Collections.Generic.IList<System.String> param, System.Action<SimpleJSON.JSONNode> callback, System.Boolean showErrorPopup, System.Action<SimpleJSON.JSONNode> onError, System.Boolean keyLog); // 0x07588d1c
	System.Void CallLobbyGet(System.String path, WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Collections.Generic.Dictionary<System.String,System.String> param, System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.String>> arraryParam, System.Action<SimpleJSON.JSONNode> callback, System.Boolean showErrorPopup, System.Action<SimpleJSON.JSONNode> onError, System.Boolean keyLog); // 0x07588ee4
	System.Void CheckGameStateWithLobby(System.Action<System.Boolean> OnRes); // 0x075890ac
	System.Void RegisterOnWsConnectSuccessfullyOnce(System.Action action, System.Boolean overwrite); // 0x07589810
	System.Void OnConnectSuccess(); // 0x07589964
	System.Threading.Tasks.Task<System.Boolean> CheckVersion(); // 0x07589a44
	System.Void Dispose(); // 0x07584abc
	System.Void ReqNetbarRealInfo(); // 0x07589b6c
	static System.Void .cctor(); // 0x07589bcc
	System.Void <PopReconnectCountMax>b__83_0(); // 0x07589cf8
	System.Void <PopReconnectCountMax>b__83_1(); // 0x07589de4
	System.Void <PopReconnectCountMax>b__83_2(); // 0x0758a21c
	System.Void <PopReconnectCountMax>b__83_3(); // 0x0758a330
}

// Client.Runtime
enum Assets.Scripts.MicroServiceClient.MicroServiceClient.ConnectFailMethod : System.Enum
{
	System.Int32 value__; // 0x10
	static Assets.Scripts.MicroServiceClient.MicroServiceClient.ConnectFailMethod ReconnectAndAskForRetry = 0;
	static Assets.Scripts.MicroServiceClient.MicroServiceClient.ConnectFailMethod ReconnectAndLogout = 1;
	static Assets.Scripts.MicroServiceClient.MicroServiceClient.ConnectFailMethod KickOut = 2;
	
}

// Client.Runtime
enum Assets.Scripts.MicroServiceClient.MicroServiceClient.ReconnectMethod : System.Enum
{
	System.Int32 value__; // 0x10
	static Assets.Scripts.MicroServiceClient.MicroServiceClient.ReconnectMethod Stop = 0;
	static Assets.Scripts.MicroServiceClient.MicroServiceClient.ReconnectMethod Silence = 1;
	static Assets.Scripts.MicroServiceClient.MicroServiceClient.ReconnectMethod Popup = 2;
	
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c : System.Object
{
	static Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__68_0; // 0x8
	static System.Action<SimpleJSON.JSONNode> <>9__68_1; // 0x10
	static System.Action <>9__78_0; // 0x18
	static System.Action <>9__78_1; // 0x20
	static System.Action <>9__78_2; // 0x28
	static System.Action <>9__78_3; // 0x30
	static System.Action <>9__80_1; // 0x38
	static System.Action <>9__81_0; // 0x40
	static System.Action<System.String,System.String,System.Action,System.String,System.Action> <>9__98_0; // 0x48
	static System.Void .cctor(); // 0x0758a40c
	System.Void .ctor(); // 0x0758a470
	System.Void <UpdateLogin>b__68_0(SimpleJSON.JSONNode res); // 0x0758a4d8
	System.Void <UpdateLogin>b__68_1(SimpleJSON.JSONNode err); // 0x0758a5a0
	System.Void <_websocketLoop>b__78_0(); // 0x0758a6b8
	System.Void <_websocketLoop>b__78_1(); // 0x0758a76c
	System.Void <_websocketLoop>b__78_2(); // 0x0758a820
	System.Void <_websocketLoop>b__78_3(); // 0x0758a8d4
	System.Void <ProcessKickOut>b__80_1(); // 0x0758a988
	System.Void <ProcessReconnect>b__81_0(); // 0x0758aa34
	System.Void <CheckVersion>b__98_0(System.String message, System.String leftStr, System.Action leftCb, System.String rightStr, System.Action rightCb); // 0x0758aa98
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass64_0 : System.Object
{
	SimpleJSON.JSONNode error; // 0x10
	System.Void .ctor(); // 0x07585c5c
	System.Void <PopupResultError>b__0(); // 0x0758ae08
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass67_0 : System.Object
{
	Assets.Scripts.MicroServiceClient.MicroServiceClient <>4__this; // 0x10
	SimpleJSON.JSONObject param; // 0x18
	System.Void .ctor(); // 0x07586074
	System.Void <Login>b__0(System.Int32 res, SimpleJSON.JSONNode jsonNode); // 0x0550f6d4
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass69_0 : System.Object
{
	Assets.Scripts.MicroServiceClient.MicroServiceClient <>4__this; // 0x10
	System.Boolean logoutMSDK; // 0x18
	System.Action<SimpleJSON.JSONNode> callback; // 0x20
	System.Void .ctor(); // 0x07586d38
	System.Void <Logout>b__0(SimpleJSON.JSONNode data); // 0x0758b9c0
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass72_0 : System.Object
{
	System.String method; // 0x10
	SimpleJSON.JSONNode jsonNode; // 0x18
	System.Void .ctor(); // 0x075873f0
	System.Void <_logicMethodProcess>b__0(); // 0x0758bb5c
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass73_0 : System.Object
{
	System.Int32 startT; // 0x10
	System.Int32 step; // 0x14
	System.Int32 max; // 0x18
	System.Void .ctor(); // 0x07587688
	System.Boolean <CreateTimeoutCounter>b__0(); // 0x0758be34
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass78_0 : System.Object
{
	Assets.Scripts.MicroServiceClient.MicroServiceClient <>4__this; // 0x10
	SimpleJSON.JSONNode loginRet; // 0x18
	System.Action<System.Int32,SimpleJSON.JSONNode> onLogin; // 0x20
	System.Void .ctor(); // 0x0758beac
	System.Void <_websocketLoop>b__4(); // 0x0758bf14
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass80_0 : System.Object
{
	System.Boolean force; // 0x10
	Assets.Scripts.MicroServiceClient.MicroServiceClient <>4__this; // 0x18
	System.Void .ctor(); // 0x07587f6c
	System.Void <ProcessKickOut>b__0(); // 0x0758bfa8
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass81_0 : System.Object
{
	System.String strMsg; // 0x10
	Assets.Scripts.MicroServiceClient.MicroServiceClient <>4__this; // 0x18
	System.Void .ctor(); // 0x0758c610
	System.Void <ProcessReconnect>b__1(); // 0x0758c678
	System.Void <ProcessReconnect>b__2(); // 0x0758c6e0
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass86_0 : System.Object
{
	System.Action<System.Int32,SimpleJSON.JSONNode> callback; // 0x10
	System.Int32 result; // 0x18
	SimpleJSON.JSONNode param; // 0x20
	System.Void .ctor(); // 0x075887b0
	System.Void <DoLoginCallback>b__0(); // 0x0758c754
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass87_0 : System.Object
{
	Assets.Scripts.MicroServiceClient.MicroServiceClient <>4__this; // 0x10
	System.Action<System.Int32,SimpleJSON.JSONNode> callback; // 0x18
	System.Void .ctor(); // 0x0758c7d4
	System.Void <_loginAsync>b__0(SimpleJSON.JSONNode response); // 0x0758c83c
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass87_1 : System.Object
{
	System.String url; // 0x10
	Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass87_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x0758cc00
	System.Void <_loginAsync>b__1(SimpleJSON.JSONNode error); // 0x05523a54
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass87_2 : System.Object
{
	SimpleJSON.JSONNode response; // 0x10
	Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass87_0 CS$<>8__locals2; // 0x18
	System.Void .ctor(); // 0x0758cb98
	System.Void <_loginAsync>b__2(); // 0x0758ce18
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass95_0 : System.Object
{
	Assets.Scripts.MicroServiceClient.MicroServiceClient <>4__this; // 0x10
	System.Action<System.Boolean> OnRes; // 0x18
	System.Void .ctor(); // 0x075897a8
	System.Void <CheckGameStateWithLobby>b__0(); // 0x0758ce94
	System.Void <CheckGameStateWithLobby>b__1(); // 0x0758cf04
	System.Void <CheckGameStateWithLobby>b__2(System.Int64 _, System.Object _, System.Boolean _); // 0x0758cf74
	System.Void <CheckGameStateWithLobby>b__3(SimpleJSON.JSONNode response); // 0x0758d110
	System.Void <CheckGameStateWithLobby>b__4(SimpleJSON.JSONNode response); // 0x0758d454
}

// Client.Runtime
struct Assets.Scripts.MicroServiceClient.MicroServiceClient.<CheckVersion>d__98 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder; // 0x18
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x30
	System.Void MoveNext(); // 0x0758d5e8
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x0758e464
}

// Client.Runtime
struct Assets.Scripts.MicroServiceClient.MicroServiceClient.<OnConnectSuccess>d__97 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	Assets.Scripts.MicroServiceClient.MicroServiceClient <>4__this; // 0x38
	System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1; // 0x40
	System.Void MoveNext(); // 0x0758e51c
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x0758ec28
}

// Client.Runtime
struct Assets.Scripts.MicroServiceClient.MicroServiceClient.<ProcessReconnect>d__81 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	Assets.Scripts.MicroServiceClient.MicroServiceClient <>4__this; // 0x38
	Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass81_0 <>8__1; // 0x40
	System.Int32 <curSec>5__2; // 0x48
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x50
	System.Void MoveNext(); // 0x0758eca8
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x0758f7a4
}

// Client.Runtime
struct Assets.Scripts.MicroServiceClient.MicroServiceClient.<_heartbeatLoop>d__77 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	Assets.Scripts.MicroServiceClient.MicroServiceClient <>4__this; // 0x38
	System.ArraySegment<System.Byte> <pingBuffer>5__2; // 0x40
	System.Int32 <heartbetCountDown>5__3; // 0x50
	System.Int32 <checkTimeOutTimer>5__4; // 0x54
	System.Threading.Tasks.Task <sendTask>5__5; // 0x58
	System.Int32 <delay>5__6; // 0x60
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x68
	System.Void MoveNext(); // 0x0758f824
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x07590304
}

// Client.Runtime
struct Assets.Scripts.MicroServiceClient.MicroServiceClient.<_loginAsync>d__87 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	Assets.Scripts.MicroServiceClient.MicroServiceClient <>4__this; // 0x38
	System.Action<System.Int32,SimpleJSON.JSONNode> callback; // 0x40
	SimpleJSON.JSONObject param; // 0x48
	Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass87_0 <>8__1; // 0x50
	System.Int32 <waitSec>5__2; // 0x58
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x60
	System.Void MoveNext(); // 0x055049cc
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x07591438
}

// Client.Runtime
struct Assets.Scripts.MicroServiceClient.MicroServiceClient.<_websocketLoop>d__78 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	Assets.Scripts.MicroServiceClient.MicroServiceClient <>4__this; // 0x38
	SimpleJSON.JSONNode loginRet; // 0x40
	Assets.Scripts.MicroServiceClient.MicroServiceClient.<>c__DisplayClass78_0 <>8__1; // 0x48
	System.Action<System.Int32,SimpleJSON.JSONNode> loginCallback; // 0x50
	System.Byte[] <buffer>5__2; // 0x58
	System.Memory<System.Byte> <mem>5__3; // 0x60
	System.String <method>5__4; // 0x70
	System.Boolean <hasConnect>5__5; // 0x78
	System.Threading.Tasks.Task <taskConncect>5__6; // 0x80
	System.Func<System.Boolean> <connectTimer>5__7; // 0x88
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x90
	System.Boolean <isConnectValid>5__8; // 0x98
	System.Threading.Tasks.ValueTask<System.Net.WebSockets.ValueWebSocketReceiveResult> <receiveTask>5__9; // 0xa0
	System.Func<System.Boolean> <receiveTimer>5__10; // 0xb8
	System.Threading.Tasks.ValueTask<System.Net.WebSockets.ValueWebSocketReceiveResult> <loopReceiveTask>5__11; // 0xc0
	System.Void MoveNext(); // 0x055049cc
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x075931f0
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.ServiceClientDefine : System.Object
{
	static System.Collections.Generic.Dictionary<System.String,System.Action<SimpleJSON.JSONNode>> WebSocketMethodList; // 0x0
	static System.Void OnHotfixKeySwitchUpdate(SimpleJSON.JSONNode node); // 0x076d229c
	static System.Void OnTeamTurnToMultipleWarzoneMatch(SimpleJSON.JSONNode node); // 0x076d233c
	static System.Void OnSyncCancelGame(SimpleJSON.JSONNode node); // 0x076d23dc
	static System.Void OnSyncStartGame(SimpleJSON.JSONNode node); // 0x076d247c
	static System.Void OnCustomPlanChange(SimpleJSON.JSONNode node); // 0x076d251c
	static System.Void OnSexchange(SimpleJSON.JSONNode node); // 0x076d28c0
	static System.Void OnHoldWeaponInfoChange(SimpleJSON.JSONNode node); // 0x076d2a60
	static System.Void OnUpdateTeamMemberDisplay(SimpleJSON.JSONNode jsonNode); // 0x076d2b00
	static System.Void OnPrivilegeChange(SimpleJSON.JSONNode node); // 0x076d2ba0
	static System.Void OnRoleBonusCardsChange(SimpleJSON.JSONNode node); // 0x076d2c40
	static System.Void OnBanStatusChange(SimpleJSON.JSONNode node); // 0x076d2ce0
	static System.Void OnBattleEndSummary(SimpleJSON.JSONNode jsonNode); // 0x076d2d80
	static System.Void OnResourceUpdate(SimpleJSON.JSONNode jsonNode); // 0x076d2f40
	static System.Void OnRevokeAuth(SimpleJSON.JSONNode jsonNode); // 0x076d2fe8
	static System.Void OnTeamRecruitApply(SimpleJSON.JSONNode jsonNode); // 0x076d3084
	static System.Void OnTeamRecruitmentPublish(SimpleJSON.JSONNode jsonNode); // 0x076d32ac
	static System.Void OnTeamRecruitmentCancel(SimpleJSON.JSONNode jsonNode); // 0x076d3398
	static System.Void OnTeamRecruitApplyCancel(SimpleJSON.JSONNode jsonNode); // 0x076d3480
	static System.Void OnApplyEnterTeamResult(SimpleJSON.JSONNode jsonNode); // 0x076d35cc
	static System.Void OnApplyEnterGameTeamResult(SimpleJSON.JSONNode jsonNode); // 0x076d399c
	static System.Void OnMuteStatusChange(SimpleJSON.JSONNode jsonNode); // 0x076d3b08
	static System.Void OnLevelAndExpChange(SimpleJSON.JSONNode jsonNode); // 0x076d3ba8
	static System.Void OnRecvACEMessage(SimpleJSON.JSONNode jsonNode); // 0x076d3c48
	static System.Void OnRecvACELightFeature(SimpleJSON.JSONNode jsonNode); // 0x076d3cf0
	static System.Void OnTeamDynamicMatch(SimpleJSON.JSONNode jsonNode); // 0x076d3d98
	static System.Void OnTeamWarzoneMatch(SimpleJSON.JSONNode jsonNode); // 0x076d3e38
	static System.Void OnTeamMemberReady(SimpleJSON.JSONNode jsonNode); // 0x076d3ed8
	static System.Void OnUpdateTeamPermission(SimpleJSON.JSONNode jsonNode); // 0x076d3f78
	static System.Void OnUpdateTeamLeader(SimpleJSON.JSONNode jsonNode); // 0x076d4018
	static System.Void OnSocialRemove(SimpleJSON.JSONNode jsonNode); // 0x076d40b8
	static System.Void OnFcmByZhongKong(SimpleJSON.JSONNode jsonNode); // 0x076d4158
	static System.Void OnSocialAskAddAgree(SimpleJSON.JSONNode jsonNode); // 0x076d41f8
	static System.Void OnSocialAskAddReject(SimpleJSON.JSONNode jsonNode); // 0x076d4298
	static System.Void OnSocialAskAdd(SimpleJSON.JSONNode jsonNode); // 0x076d4338
	static System.Void OnRecruitmentMsg(SimpleJSON.JSONNode jsonNode); // 0x076d43d8
	static System.Void OnUpdateTeamMember(SimpleJSON.JSONNode jsonNode); // 0x076d44b0
	static System.Void OnUpdateTeamGameMode(SimpleJSON.JSONNode jsonNode); // 0x076d4550
	static System.Void OnTeamInvitationFeedback(SimpleJSON.JSONNode jsonNode); // 0x076d45f0
	static System.Void OnTeamInvitation(SimpleJSON.JSONNode jsonNode); // 0x076d4698
	static System.Void OnKickTeamMember(SimpleJSON.JSONNode jsonNode); // 0x076d4740
	static System.Void OnLeaveTeam(SimpleJSON.JSONNode jsonNode); // 0x076d47e8
	static System.Void OnJoinTeam(SimpleJSON.JSONNode jsonNode); // 0x076d4890
	static System.Void OnGlobalMarquee(SimpleJSON.JSONNode jsonNode); // 0x076d4938
	static System.Void DeleteGlobalMarquee(SimpleJSON.JSONNode jsonNode); // 0x076d49d8
	static System.Void OnWSNewMail(SimpleJSON.JSONNode jsonNode); // 0x076d4a78
	static System.Void OnJoinBattleServer(SimpleJSON.JSONNode jsonNode); // 0x055049cc
	static System.Void OnTribeKicked(SimpleJSON.JSONNode jsonNode); // 0x076d529c
	static System.Void OnTribeApply(SimpleJSON.JSONNode jsonNode); // 0x076d548c
	static System.Void OnTribeInvite(SimpleJSON.JSONNode jsonNode); // 0x076d552c
	static System.Void OnTribeJoin(SimpleJSON.JSONNode jsonNode); // 0x076d55cc
	static System.Void OnTribeApplyBeRefused(SimpleJSON.JSONNode jsonNode); // 0x076d56b0
	static System.Void OnGetChatMsg(SimpleJSON.JSONNode jsonNode); // 0x076d5710
	static System.Void OnGetPersnalChatMsg(SimpleJSON.JSONNode jsonNode); // 0x076d5f6c
	static System.Void GetChatMessage(SimpleJSON.JSONNode jsonNode, System.Boolean isPrivate); // 0x076d579c
	static System.Void OnGetDeletePersonalMsg(SimpleJSON.JSONNode jsonNode); // 0x076d5ff8
	static System.Void OnChatChannelChange(SimpleJSON.JSONNode jsonNode); // 0x076d6144
	static System.Void OnMainTaskForceLevelAndExpChange(SimpleJSON.JSONNode jsonNode); // 0x076d6298
	static System.Void OnTalentUpdate(SimpleJSON.JSONNode jsonNode); // 0x076d6354
	static System.Void OnBattlePassInfoChange(SimpleJSON.JSONNode data); // 0x076d63f4
	static System.Void OnMedalLevelChanged(SimpleJSON.JSONNode data); // 0x076d6494
	static System.Void OnSeasonLevelChanged(SimpleJSON.JSONNode data); // 0x076d6534
	static System.Void OnHotfixReceived(SimpleJSON.JSONNode jsonNode); // 0x076d65d4
	static System.Void OnCommunityInvitation(SimpleJSON.JSONNode jsonNode); // 0x076d6674
	static System.Void OnKickedFromCommunity(SimpleJSON.JSONNode jsonNode); // 0x076d6714
	static System.Void OnJoinCommunity(SimpleJSON.JSONNode jsonNode); // 0x076d67b4
	static System.Void OnCommunityIndentityChange(SimpleJSON.JSONNode jsonNode); // 0x076d6854
	static System.Void OnCommunityReceiveNewApplication(SimpleJSON.JSONNode jsonNode); // 0x076d68f4
	static System.Void OnSkinEquipChange(SimpleJSON.JSONNode jsonNode); // 0x076d6994
	static System.Void .cctor(); // 0x076d6a34
}

// Client.Runtime
enum Assets.Scripts.MicroServiceClient.ServiceClientDefine.EGameSource : System.Enum
{
	System.Int32 value__; // 0x10
	static Assets.Scripts.MicroServiceClient.ServiceClientDefine.EGameSource joinwarzonebattle = 0;
	static Assets.Scripts.MicroServiceClient.ServiceClientDefine.EGameSource startdynamicbattle = 1;
	static Assets.Scripts.MicroServiceClient.ServiceClientDefine.EGameSource joindynamicbattle = 2;
	static Assets.Scripts.MicroServiceClient.ServiceClientDefine.EGameSource readytojoinwarzone = 3;
	
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.ServiceClientDefine.<>c : System.Object
{
	static Assets.Scripts.MicroServiceClient.ServiceClientDefine.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__20_1; // 0x8
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__47_0; // 0x10
	static System.Void .cctor(); // 0x076d821c
	System.Void .ctor(); // 0x076d8280
	System.Void <OnApplyEnterTeamResult>b__20_1(SimpleJSON.JSONNode json); // 0x076d82e8
	System.Void <OnJoinBattleServer>b__47_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x076d839c
}

// Client.Runtime
class Assets.Scripts.MicroServiceClient.ServiceClientDefine.<>c__DisplayClass20_0 : System.Object
{
	System.Int32 gameMode; // 0x10
	System.Boolean isAppointment; // 0x14
	System.Void .ctor(); // 0x076d3934
	System.Void <OnApplyEnterTeamResult>b__0(SimpleJSON.JSONNode node); // 0x076d8468
}

// Client.Runtime
class Assets.Scripts.Indicator.QualitySettingIndicator : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Indicator.IndicatorData data; // 0x30
	System.String <Measurement>k__BackingField; // 0x38
	System.Single m_resolution; // 0x40
	System.Int32 m_upScalingMode; // 0x44
	System.Single m_upscalingResolution; // 0x48
	System.Single m_NativeDPI; // 0x4c
	System.Single m_scaledDPI; // 0x50
	System.Single m_superResolutionScale; // 0x54
	System.Int32 m_detailMat; // 0x58
	System.Int32 m_maxLODLevel; // 0x5c
	System.Void .ctor(System.String measurement); // 0x076d85a4
	System.String get_Measurement(); // 0x076d8b30
	System.Void set_Measurement(System.String value); // 0x076d8b94
	System.Boolean get_ChangeFlag(); // 0x076d8c14
	System.Void Collect(System.Collections.Generic.IList<WizardGames.Soc.Common.Indicator.IndicatorData> list, System.Boolean simple); // 0x076d8f94
	System.Void Refresh(); // 0x076d86c0
	System.Boolean CheckChange(); // 0x076d8c78
	System.Void PostQualitySettings(); // 0x076d9080
	static System.Void .cctor(); // 0x076d9394
}

// Client.Runtime
class GraphicsTest.DebugPlayerViewWrapper : System.Object, GraphicsTest.DebugViewsController.IMoveController
{
	System.Boolean initialized; // 0x10
	UnityEngine.Quaternion currentRot; // 0x14
	UnityEngine.Vector3 currentPosition; // 0x24
	System.Boolean setRotPerFrame; // 0x30
	System.Single YOffset; // 0x34
	System.Single FixedTimeline; // 0x38
	System.Boolean <SoulLeavingMode>k__BackingField; // 0x3c
	System.Boolean get_SoulLeavingMode(); // 0x076d9468
	System.Void set_SoulLeavingMode(System.Boolean value); // 0x076d94cc
	System.Boolean HasInitialized(); // 0x076d9548
	System.Void SetDebugViewMode(System.Boolean fly, System.Boolean onlyCloseTimeSync); // 0x076d95ac
	System.Void SetSoulLeavingMode(System.Boolean b); // 0x076d9824
	System.Void Initialize(); // 0x076d98d4
	System.Void Teleport(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot); // 0x076d993c
	System.Void UpdatePerFrame(); // 0x076d9b70
	System.Void .ctor(); // 0x076d9c14
}

// Client.Runtime
class GraphicsTest.GraphicsTestSingleton : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	UnityEngine.GameObject ControllerPrefab; // 0x30
	System.Single YOffset; // 0x38
	GraphicsTest.DebugPlayerViewWrapper playerViewWrapper; // 0x40
	GraphicsTest.DebugViewsController loadedController; // 0x48
	UnityEngine.GameObject loadedControllerGO; // 0x50
	System.Boolean SoulLeavingMode; // 0x58
	System.Boolean OnlyCloseTimeSyncWhenSwitchDebugView; // 0x59
	System.Int32 manualProfileIndex; // 0x5c
	System.Void Awake(); // 0x076d9cfc
	System.Void Update(); // 0x076d9db4
	System.Void LoadPlayerViewController(System.Boolean toNearest); // 0x076d9f30
	System.Void ManualProfile(); // 0x076da1c8
	System.Void SetDebugViewMode(System.Boolean fly); // 0x076d9e98
	System.Void .ctor(); // 0x076da40c
	static System.Void .cctor(); // 0x076da4b0
}

// Client.Runtime
interface CompatibilityTests.ICompatibilityTest : 
{
	
	System.String TestName(); // 0x054e7844
	System.String SpecifiedDiscriminatorName(); // 0x054e7844
	System.Boolean Begin(CompatibilityTests.IDiscriminator discriminator); // 0x054dec74
}

// Client.Runtime
class CompatibilityTests.TestContext : System.Object
{
	System.Int32 FrameIndex; // 0x10
	System.String CaseName; // 0x18
	System.Void .ctor(); // 0x076da584
}

// Client.Runtime
interface CompatibilityTests.IDiscriminator : 
{
	
	System.String GetTypeName(); // 0x054e7844
	System.Void Begin(CompatibilityTests.TestContext context); // 0x05523a54
	System.Boolean Validate(CompatibilityTests.TestContext context); // 0x054dec74
	System.Void OnStep(CompatibilityTests.TestContext context); // 0x05523a54
	System.Void End(CompatibilityTests.TestContext context); // 0x05523a54
}

// Client.Runtime
class CompatibilityTests.BasicTestContext : CompatibilityTests.TestContext
{
	
	System.Void .ctor(); // 0x076da5ec
}

// Client.Runtime
class CompatibilityTests.CompatibilityTestsRunner : UnityEngine.MonoBehaviour
{
	System.Single heartBeatIntervalSeconds; // 0x30
	static SocLogger logger; // 0x0
	CompatibilityTests.CompatibilityTestsRunner.CaseParams[] Cases; // 0x38
	System.String[] TestEntries; // 0x40
	System.String[] TestComponentTypeName; // 0x48
	System.Single[] TimeOfDayBegin; // 0x50
	System.Single[] HoursPerRealSecond; // 0x58
	System.String redirectSceneName; // 0x60
	System.Int32 sceneIndex; // 0x68
	static System.Collections.Generic.List<System.Int32> s_EnabledScenes; // 0x8
	static CompatibilityTests.CompatibilityTestsRunner s_Singleton; // 0x10
	CompatibilityTests.ICompatibilityTest currentTest; // 0x70
	static System.Single SwitchSceneDelay = 1;
	System.Collections.Generic.Dictionary<System.String,CompatibilityTests.IDiscriminator> discriminatorsDict; // 0x78
	CompatibilityTests.CompatibilityTestsRunner.NullDiscriminator nullDiscriminator; // 0x80
	CompatibilityTests.CompatibilityTestsRunner.GTCompareDiscriminator gtCompareDiscriminator; // 0x88
	System.DateTime m_LastTime; // 0x90
	System.DateTime m_CaseStartTime; // 0x98
	static CompatibilityTests.CompatibilityTestsRunner get_Sinleton(); // 0x076da650
	System.Void NotifyTestLoaded(CompatibilityTests.ICompatibilityTest test); // 0x076da6d8
	System.Void OnTestBegin(); // 0x076da8fc
	System.Void OnTestStep(); // 0x076da95c
	System.Void OnTestEnd(); // 0x076da9bc
	CompatibilityTests.IDiscriminator GetDiscriminator(System.String discriminatorName); // 0x076da840
	System.Boolean RegisterDiscriminator(CompatibilityTests.IDiscriminator disc); // 0x076daea4
	System.Void UnregisterDiscriminator(CompatibilityTests.IDiscriminator disc); // 0x076db058
	System.Void Awake(); // 0x076db168
	System.Void OnDestroy(); // 0x076db384
	System.Void Start(); // 0x076db440
	System.Void RedirectToScene(System.Int32 index); // 0x076dac04
	System.Void LoadRedirectScene(); // 0x076db954
	System.Void OnRedirectSceneLoaded(); // 0x076db9e4
	System.Collections.IEnumerator RedirectSceneLoadSpecificSceneAsync(); // 0x076dba58
	System.Void Update(); // 0x076dbb80
	System.Void LateUpdate(); // 0x076dbdfc
	System.Void .ctor(); // 0x076dbf70
	static System.Void .cctor(); // 0x076dc1a4
}

// Client.Runtime
struct CompatibilityTests.CompatibilityTestsRunner.CaseParams : System.ValueType
{
	System.String SceneName; // 0x10
	System.String MonoTypeName; // 0x18
	System.Boolean Enabled; // 0x20
	System.Single timeOfDayBegin; // 0x24
	System.Single hoursPerRealSecond; // 0x28
	
}

// Client.Runtime
class CompatibilityTests.CompatibilityTestsRunner.NullDiscriminator : System.Object, CompatibilityTests.IDiscriminator
{
	System.DateTime m_LastTime; // 0x10
	static System.TimeSpan s_StepInterval; // 0x0
	System.String GetTypeName(); // 0x076dc2d0
	System.Void Begin(CompatibilityTests.TestContext context); // 0x076dc348
	System.Boolean Validate(CompatibilityTests.TestContext context); // 0x076dc528
	System.Void OnStep(CompatibilityTests.TestContext context); // 0x076dc694
	System.Void End(CompatibilityTests.TestContext context); // 0x076dc8f8
	System.Void .ctor(); // 0x076dc0d4
	static System.Void .cctor(); // 0x076dcaa4
}

// Client.Runtime
class CompatibilityTests.CompatibilityTestsRunner.GTCompareDiscriminator : System.Object, CompatibilityTests.IDiscriminator
{
	
	System.String GetTypeName(); // 0x076dcb1c
	System.Void Begin(CompatibilityTests.TestContext context); // 0x076dcb94
	System.Boolean Validate(CompatibilityTests.TestContext context); // 0x076dcdfc
	System.Void OnStep(CompatibilityTests.TestContext context); // 0x076dd01c
	System.Void End(CompatibilityTests.TestContext context); // 0x076dd090
	System.Void .ctor(); // 0x076dc13c
}

// Client.Runtime
class CompatibilityTests.CompatibilityTestsRunner.<RedirectSceneLoadSpecificSceneAsync>d__36 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	CompatibilityTests.CompatibilityTestsRunner <>4__this; // 0x20
	UnityEngine.AsyncOperation <asyncLoad>5__2; // 0x28
	System.Void .ctor(System.Int32 <>1__state); // 0x076dbafc
	System.Void System.IDisposable.Dispose(); // 0x076dd294
	System.Boolean MoveNext(); // 0x076dd2f4
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x076ddc78
	System.Void System.Collections.IEnumerator.Reset(); // 0x076ddcdc
	System.Object System.Collections.IEnumerator.get_Current(); // 0x076ddd64
}

// Client.Runtime
class CompatibilityTests.FeatureSwitches : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	static System.String k_SEPERATOR = "-";
	static System.String K_24BitOpt = "24bitsOpt";
	static System.String K_BatchedInstancedIndirect = "instancedIndirectOpt";
	static System.String K_BatchedProceduralIndirect = "proceduralIndirectOpt";
	static System.String k_EnabledScenes = "enabled_scenes";
	static System.String K_ON = "on";
	static System.String K_OFF = "off";
	System.String currentArgName; // 0x30
	System.String currentArgValue; // 0x38
	System.Boolean proceduralIndices24BitsEnabled; // 0x40
	UnityEngine.GUIStyle guiStyle; // 0x48
	static System.Int32 FontSize = 24;
	static System.Int32 LabelSize = 420;
	System.Void Awake(); // 0x076dddc8
	System.Void ParseCommandLineArgs(); // 0x076dde2c
	System.Void SwitchProceduralIndices24Bits(); // 0x076de4e8
	System.Void .ctor(); // 0x076de548
	static System.Void .cctor(); // 0x076de5ec
}

// Client.Runtime
class CompatibilityTests.MonumentsRoam : UnityEngine.MonoBehaviour, CompatibilityTests.ICompatibilityTest
{
	static SocLogger logger; // 0x0
	GraphicsTest.DebugViewsController[] monuments; // 0x30
	UnityEngine.GameObject[] parentMonumentObjs; // 0x38
	System.Single overrideViewDuration; // 0x40
	GraphicsTest.DebugViewsController currentMonument; // 0x48
	System.Int32 currentMonumentIndex; // 0x50
	System.Collections.Generic.List<GraphicsTest.DebugViewsController> loadedMonuments; // 0x58
	System.Boolean running; // 0x60
	CompatibilityTests.IDiscriminator discriminator; // 0x68
	CompatibilityTests.MonumentsRoam.MonumentsRoamContext testContext; // 0x70
	CompatibilityTests.MonumentsRoam.MonumentsRoamContext testContextSubmit; // 0x78
	System.String TestName(); // 0x076de6c0
	System.String SpecifiedDiscriminatorName(); // 0x076de738
	System.Boolean Begin(CompatibilityTests.IDiscriminator discr); // 0x076de7b0
	System.Void Step(); // 0x076debac
	System.Void End(); // 0x076decfc
	System.Boolean IsEnded(); // 0x076dee94
	System.Void DelayStartController(); // 0x076deef8
	System.Void LaunchController(); // 0x076deb3c
	System.Boolean SwitchController(); // 0x076def7c
	System.Void OnCameraMove(GraphicsTest.DebugViewsController.MovementEvent evt); // 0x076df078
	System.Void LoadMonument(System.Int32 i); // 0x076df130
	System.Void Start(); // 0x076df4f8
	System.Void OnDestroy(); // 0x076df678
	System.Void Update(); // 0x076df8b8
	System.Void .ctor(); // 0x076df92c
	static System.Void .cctor(); // 0x076dfaa0
}

// Client.Runtime
class CompatibilityTests.MonumentsRoam.MonumentsRoamContext : CompatibilityTests.BasicTestContext
{
	System.Int32 viewIndex; // 0x20
	System.String monumentName; // 0x28
	System.Void CopyFrom(CompatibilityTests.MonumentsRoam.MonumentsRoamContext rhs); // 0x076dfb74
	System.Void .ctor(); // 0x076dfa3c
}

// Client.Runtime
class CompatibilityTests.MonumentsTeleport : CompatibilityTests.MonumentsRoam
{
	static SocLogger logger; // 0x0
	System.String TestName(); // 0x076dfc1c
	System.Void LoadMonument(System.Int32 i); // 0x076dfc94
	System.Void Start(); // 0x076e005c
	System.Void OnDestroy(); // 0x076e01dc
	System.Void Update(); // 0x076e041c
	System.Void .ctor(); // 0x076e0490
	static System.Void .cctor(); // 0x076e0518
}

// Client.Runtime
class CompatibilityTests.MonumentsWithBuildings : CompatibilityTests.MultipleMonumentsTimeline
{
	GraphicsTest.DebugViewsController buildingTransforms; // 0x88
	UnityEngine.GameObject buildingPrefab; // 0x90
	UnityEngine.Rendering.Universal.ObjectRendererManager objectRenderMgr; // 0x98
	System.String TestName(); // 0x076e05ec
	System.Void Start(); // 0x076e0664
	System.Void Update(); // 0x076e09c8
	System.Void .ctor(); // 0x076e0a50
}

// Client.Runtime
class CompatibilityTests.MonumentTimeline : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	GraphicsTest.DebugViewsController viewControllerPrefab; // 0x30
	UnityEngine.GameObject parentMonumentObj; // 0x38
	System.Int32 numFramesPerStep; // 0x40
	CompatibilityTests.MultipleMonumentsTimeline parentCompatibilityTest; // 0x48
	System.Boolean running; // 0x50
	static System.Single FreezeTime = 3;
	System.Single freezeTimer; // 0x54
	GraphicsTest.DebugViewsController viewController; // 0x58
	System.Int32 frameCounter; // 0x60
	System.Boolean Startup(); // 0x076e0c1c
	System.Void DelayLaunchViewController(); // 0x076e0ec4
	System.Void Step(); // 0x076e1058
	System.Void End(); // 0x076e10f0
	System.Boolean IsEnded(); // 0x076e1220
	System.Void OnCameraMove(GraphicsTest.DebugViewsController.MovementEvent evt); // 0x076e135c
	System.Void Start(); // 0x076e13f8
	System.Void OnDestroy(); // 0x076e1598
	System.Void PassiveUpdate(); // 0x076e16b4
	System.Void OnPostFreeze(); // 0x076e1714
	System.Void Update(); // 0x076e1780
	System.Void .ctor(); // 0x076e18f8
	static System.Void .cctor(); // 0x076e1968
}

// Client.Runtime
class CompatibilityTests.MultipleMonumentsTimeline : UnityEngine.MonoBehaviour, CompatibilityTests.ICompatibilityTest
{
	static SocLogger logger; // 0x0
	System.String discriminatorName; // 0x30
	UnityEngine.GameObject[] monumentObjs; // 0x38
	CompatibilityTests.MonumentTimeline[] monuments; // 0x40
	System.Int32 numFramesPerStep; // 0x48
	System.Single fixedTimeController; // 0x4c
	CompatibilityTests.MonumentTimeline currentMonument; // 0x50
	System.Int32 currentMonumentIndex; // 0x58
	System.Int32 currentViewIndex; // 0x5c
	System.Collections.Generic.List<CompatibilityTests.MonumentTimeline> loadedMonuments; // 0x60
	System.Boolean running; // 0x68
	CompatibilityTests.IDiscriminator discriminator; // 0x70
	CompatibilityTests.MultipleMonumentsTimeline.MultipleMonumentsTimelineContext testContext; // 0x78
	CompatibilityTests.MultipleMonumentsTimeline.MultipleMonumentsTimelineContext testContextSubmit; // 0x80
	System.String TestName(); // 0x076e1a3c
	System.String SpecifiedDiscriminatorName(); // 0x076e1ab4
	System.Boolean Begin(CompatibilityTests.IDiscriminator discr); // 0x076e1b18
	System.Void Step(); // 0x076e208c
	System.Void DoValidate(); // 0x076e213c
	System.Void End(); // 0x076e25ac
	System.Boolean IsEnded(); // 0x076e2744
	System.Void Start(); // 0x076e27a8
	System.Void LoadMonument(System.Int32 i); // 0x076e1e90
	System.Void OnMonumentTimelineLoaded(CompatibilityTests.MonumentTimeline mt); // 0x076e1524
	System.Void OnMonumentValidateStep(CompatibilityTests.MonumentTimeline mt); // 0x076e1878
	System.Void OnMonumentEnd(CompatibilityTests.MonumentTimeline mt); // 0x076e1168
	System.Void Update(); // 0x076e28d4
	System.Void .ctor(); // 0x076e0ad8
	static System.Void .cctor(); // 0x076e29c0
}

// Client.Runtime
class CompatibilityTests.MultipleMonumentsTimeline.MultipleMonumentsTimelineContext : CompatibilityTests.BasicTestContext
{
	System.Int32 viewIndex; // 0x20
	System.String monumentName; // 0x28
	System.Void CopyFrom(CompatibilityTests.MultipleMonumentsTimeline.MultipleMonumentsTimelineContext rhs); // 0x076e2a94
	System.Void .ctor(); // 0x076e295c
}

// Client.Runtime
class CompatibilityTests.SceneRedirector : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	static CompatibilityTests.SceneRedirector.Settings s_Settings; // 0x8
	static CompatibilityTests.SceneRedirector.Settings get_GSettings(); // 0x076e2b3c
	System.Void Start(); // 0x076e2bc4
	System.Void OnRedirectSceneLoaded(); // 0x076e2c9c
	System.Void .ctor(); // 0x076e2e20
	static System.Void .cctor(); // 0x076e2e88
}

// Client.Runtime
class CompatibilityTests.SceneRedirector.Settings : System.Object
{
	System.String SceneName; // 0x10
	System.String TestComponentTypeName; // 0x18
	UnityEngine.GameObject PrefabToLoad; // 0x20
	System.Action OnRedirectSceneLoaded; // 0x28
	System.Void .ctor(); // 0x076e2f9c
}

// Client.Runtime
class CompatibilityTests.SimpleFixedViewsTest : UnityEngine.MonoBehaviour, CompatibilityTests.ICompatibilityTest
{
	static SocLogger logger; // 0x0
	System.String discriminatorName; // 0x30
	GraphicsTest.DebugViewsController viewController; // 0x38
	System.Boolean running; // 0x40
	CompatibilityTests.IDiscriminator discriminator; // 0x48
	CompatibilityTests.SimpleFixedViewsTest.SimpleFixedViewsContext testContext; // 0x50
	CompatibilityTests.SimpleFixedViewsTest.SimpleFixedViewsContext testContextSubmit; // 0x58
	static System.Single FreezeTime = 5;
	System.Single freezeTimer; // 0x60
	System.String TestName(); // 0x076e3004
	System.String SpecifiedDiscriminatorName(); // 0x076e307c
	System.Boolean Begin(CompatibilityTests.IDiscriminator discr); // 0x076e30e0
	System.Void Step(); // 0x076e34bc
	System.Void DoValidate(); // 0x076e352c
	System.Void End(); // 0x076e3848
	System.Boolean IsEnded(); // 0x076e39e0
	System.Void OnCameraMove(GraphicsTest.DebugViewsController.MovementEvent evt); // 0x076e3b1c
	System.Void Start(); // 0x076e3bc0
	System.Void OnDestroy(); // 0x076e3d8c
	System.Void Update(); // 0x076e3ea8
	System.Void .ctor(); // 0x076e3ff8
	static System.Void .cctor(); // 0x076e413c
}

// Client.Runtime
class CompatibilityTests.SimpleFixedViewsTest.SimpleFixedViewsContext : CompatibilityTests.BasicTestContext
{
	System.Int32 viewIndex; // 0x20
	System.Void CopyFrom(CompatibilityTests.SimpleFixedViewsTest.SimpleFixedViewsContext rhs); // 0x076e4210
	System.Void .ctor(); // 0x076e40d8
}

// Client.Runtime
class CompatibilityTests.VideoCompatibilityTest : UnityEngine.MonoBehaviour, CompatibilityTests.ICompatibilityTest
{
	static SocLogger logger; // 0x0
	UnityEngine.Video.VideoClip[] clips; // 0x30
	UnityEngine.Video.VideoPlayer videoPlayer; // 0x38
	System.Int32 videoIndex; // 0x40
	System.Int32 numFramesForward; // 0x44
	System.Int32 numFramesPerStep; // 0x48
	System.String discriminatorName; // 0x50
	CompatibilityTests.IDiscriminator discriminator; // 0x58
	CompatibilityTests.VideoCompatibilityTest.VideoTestContext testContext; // 0x60
	CompatibilityTests.VideoCompatibilityTest.VideoTestContext testContextSubmit; // 0x68
	System.Boolean prepared; // 0x70
	System.Boolean stepNextFrame; // 0x71
	System.Int32 videoFrameCounts; // 0x74
	System.Int32 debugFrameIndex; // 0x78
	System.Int64 lastSeekFrame; // 0x80
	System.Int32 frameIndex; // 0x88
	System.String TestName(); // 0x076e42a8
	System.String SpecifiedDiscriminatorName(); // 0x076e4320
	System.Boolean Begin(CompatibilityTests.IDiscriminator discr); // 0x076e4384
	System.Void OnPrepareComplete(UnityEngine.Video.VideoPlayer src); // 0x076e4900
	System.Void OnSeekComplete(UnityEngine.Video.VideoPlayer src); // 0x076e4a10
	System.Void DoValidate(); // 0x076e4bc8
	System.Void Step(); // 0x076e4ec4
	System.Void End(); // 0x076e5290
	System.Boolean IsEnded(); // 0x076e5428
	System.Void Play(); // 0x076e54b0
	System.Void Start(); // 0x076e55c0
	System.Void Update(); // 0x076e56c0
	System.Void .ctor(); // 0x076e5824
	static System.Void .cctor(); // 0x076e5974
}

// Client.Runtime
class CompatibilityTests.VideoCompatibilityTest.VideoTestContext : CompatibilityTests.BasicTestContext
{
	System.Int32 videoFrameIndex; // 0x20
	System.String videoClipName; // 0x28
	System.Void CopyFrom(CompatibilityTests.VideoCompatibilityTest.VideoTestContext rhs); // 0x076e5a48
	System.Void .ctor(); // 0x076e5910
}

// Client.Runtime
class LZ4Sharp.LZ4Compressor64 : System.Object, WizardGames.Soc.Common.Framework.Network.INetworkCompressor
{
	static System.Byte[] DeBruijnBytePos; // 0x0
	System.Byte[] m_HashTable; // 0x10
	System.Void .ctor(); // 0x076e5af0
	static System.Void .cctor(); // 0x076e5bf8
}

// Client.Runtime
class LZ4Sharp.LZ4CompressorFactory : System.Object
{
	
	static WizardGames.Soc.Common.Framework.Network.INetworkCompressor CreateNew(); // 0x076e5c98
}

// Client.Runtime
class LZ4Sharp.LZ4Decompressor64 : System.Object, WizardGames.Soc.Common.Framework.Network.INetworkDecompressor
{
	static System.Byte[] DeBruijnBytePos; // 0x0
	System.SByte[] m_DecArray; // 0x10
	System.SByte[] m_Dec2table; // 0x18
	System.Int32 Decompress(System.Byte[] compressedBuffer, System.Int32 compressedPosition, System.Byte[] decompressedBuffer, System.Int32 decompressedPosition, System.Int32 compressedSize); // 0x076e5d18
	System.Int32 Decompress(System.Byte* compressedBuffer, System.Byte* decompressedBuffer, System.Int32 compressedSize, System.Int32 maxDecompressedSize); // 0x076e5e04
	System.Void .ctor(); // 0x076e619c
	static System.Void .cctor(); // 0x076e62a4
}

// Client.Runtime
class LZ4Sharp.Lz4DecompressorFactory : System.Object
{
	
	static WizardGames.Soc.Common.Framework.Network.INetworkDecompressor CreateNew(); // 0x076e6344
}

// Client.Runtime
class LZ4Sharp.LZ4Util : System.Object
{
	
	static System.Void CopyMemory(System.Byte* dst, System.Byte* src, System.Int64 length); // 0x076e60a0
}

// Client.Runtime
class Force.Crc32.Crc32Algorithm : System.Security.Cryptography.HashAlgorithm
{
	System.UInt32 _currentCrc; // 0x24
	System.Boolean _isBigEndian; // 0x28
	static System.UInt32 Append(System.UInt32 initial, System.Byte[] input, System.Int32 offset, System.Int32 length); // 0x076e63c4
	static System.UInt32 Compute(System.Byte[] input, System.Int32 offset, System.Int32 length); // 0x076e65e0
	System.Void Initialize(); // 0x076e666c
	System.Void HashCore(System.Byte[] input, System.Int32 offset, System.Int32 length); // 0x076e66d0
	System.Byte[] HashFinal(); // 0x076e6778
	static System.UInt32 AppendInternal(System.UInt32 initial, System.Byte[] input, System.Int32 offset, System.Int32 length); // 0x076e64fc
}

// Client.Runtime
class Force.Crc32.SafeProxy : System.Object
{
	static System.UInt32[] _table; // 0x0
	static System.Void .cctor(); // 0x076e6c38
	static System.UInt32 Append(System.UInt32 crc, System.Byte[] input, System.Int32 offset, System.Int32 length); // 0x076e6898
}

// Client.Runtime
class MessagePack.Resolvers.GeneratedResolver : System.Object, MessagePack.IFormatterResolver
{
	static MessagePack.IFormatterResolver Instance; // 0x0
	System.Void .ctor(); // 0x076e6d34
	MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>(); // 0x052af1f0
	static System.Void .cctor(); // 0x076e6d9c
}

// Client.Runtime
class MessagePack.Resolvers.GeneratedResolver.FormatterCache<T> : System.Object
{
	static MessagePack.Formatters.IMessagePackFormatter<T> Formatter; // 0x0
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class MessagePack.Resolvers.GeneratedResolverGetFormatterHelper : System.Object
{
	static System.Collections.Generic.Dictionary<System.Type,System.Int32> lookup; // 0x0
	static System.Void .cctor(); // 0x076e6e00
	static System.Object GetFormatter(System.Type t); // 0x076e6f7c
}

// Client.Runtime
class MessagePack.Formatters.WizardGames.Soc.Common.SimpleCustom.ProtectionDataFormatter : System.Object, MessagePack.Formatters.IMessagePackFormatter<WizardGames.Soc.Common.SimpleCustom.ProtectionData>, MessagePack.Formatters.IMessagePackFormatter
{
	
	System.Void Serialize(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.SimpleCustom.ProtectionData value, MessagePack.MessagePackSerializerOptions options); // 0x076e71cc
	WizardGames.Soc.Common.SimpleCustom.ProtectionData Deserialize(MessagePack.MessagePackReader& reader, MessagePack.MessagePackSerializerOptions options); // 0x076e7468
	System.Void .ctor(); // 0x076e7164
}

// Client.Runtime
class MessagePack.Formatters.WizardGames.Soc.Common.Framework.NullObjectFormatter : System.Object, MessagePack.Formatters.IMessagePackFormatter<WizardGames.Soc.Share.Framework.NullObject>, MessagePack.Formatters.IMessagePackFormatter
{
	
	System.Void Serialize(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Share.Framework.NullObject value, MessagePack.MessagePackSerializerOptions options); // 0x076e7840
	WizardGames.Soc.Share.Framework.NullObject Deserialize(MessagePack.MessagePackReader& reader, MessagePack.MessagePackSerializerOptions options); // 0x076e790c
	System.Void .ctor(); // 0x076e70fc
}

// Client.Runtime
struct SocDevKit.Network.RpcLimitCallRecord : System.ValueType
{
	System.Int32 DurationCallCount; // 0x10
	System.Boolean CheckRule(WizardGames.Soc.Common.Framework.Network.RpcLimitCall& limtitCallRule); // 0x076e7a80
}

// Client.Runtime
interface SocDevKit.Network.IClientRpcLimitCheck : 
{
	
	System.Collections.Generic.Dictionary<System.Int32,SocDevKit.Network.RpcLimitCallRecord> get_LimitCallRecords(); // 0x054e7844
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> get_OverLimitCount(); // 0x054e7844
	System.Int64 get_DurationStartTimeStamp(); // 0x054a4380
	System.Void set_DurationStartTimeStamp(System.Int64 value); // 0x055112ac
}

// Client.Runtime
class SocDevKit.Network.ClientPacketLimit : System.Object
{
	static SocLogger logger; // 0x0
	static System.Boolean CheckLimitCall(System.Int32 netPeerId, SocDevKit.Network.IClientRpcLimitCheck check, System.Int32 methodId, WizardGames.Soc.Common.Framework.Network.RpcLimitCall& limitCallRule); // 0x076e7b0c
	static System.Void OnDisconnect(SocDevKit.Network.IClientRpcLimitCheck check); // 0x076e85e4
	static System.Boolean CheckLimitCall(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, SocDevKit.Network.IClientRpcLimitCheck check, WizardGames.Soc.Common.Framework.Network.IOutgoingPacket packet); // 0x076e8780
	static System.Void LimitCallLog(System.Int32 netPeerId, SocDevKit.Network.IClientRpcLimitCheck check); // 0x076e812c
	static System.Void .cctor(); // 0x076e8a38
}

// Client.Runtime
class SocDevKit.Network.NetworkHelper : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void SendPacket(WizardGames.Soc.Share.Framework.EntityBase entity, WizardGames.Soc.Common.Framework.Network.ERpcTarget target, WizardGames.Soc.Common.Framework.Network.EntityRpcPacket packet, System.String methodName, WizardGames.Soc.Common.Framework.Network.ERpcTarget generateTarget); // 0x076e8b0c
	static System.Void .cctor(); // 0x076e9040
}

// Client.Runtime
class SocDevKit.BaseType.EntityFunctionalExtends : SocDevKit.BaseType.CustomTypeFunctionalExtends
{
	WizardGames.Soc.Share.Framework.Timer.TimerBaseKit TimerKit; // 0x28
	WizardGames.Soc.Share.Framework.Event.EventBaseKit EventKit; // 0x30
	System.Void .ctor(); // 0x076e9114
}

// Client.Runtime
class SocDevKit.BaseType.ComponentFunctionalExtends : SocDevKit.BaseType.CustomTypeFunctionalExtends
{
	System.Boolean ComponentActive; // 0x28
	System.Int32 ComponentPriority; // 0x2c
	System.Collections.Generic.HashSet<System.Int64> ComponentTimerIds; // 0x30
	System.Collections.Generic.HashSet<System.Int64> ComponentEventIds; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.HashSet<System.Int64>> ComponentTargetEventIds; // 0x40
	System.Void .ctor(); // 0x076e91e0
}

// Client.Runtime
class SocDevKit.BaseType.CustomTypeFunctionalExtends : System.Object
{
	System.Action AnyUpdateCallback; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Framework.Algorithm.SafeLinkedList<WizardGames.Soc.Share.Framework.CallbackNodeDataBase>> PropertySubscribeDict; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,System.ValueTuple<System.Int32,WizardGames.Soc.Common.Framework.Algorithm.BaseLinkedNode>> SubscribeNodes; // 0x20
	System.Void .ctor(); // 0x076e9178
}

// Client.Runtime
class SocDevKit.FrameworkShare.Memory.DevKitMemoryOwner : System.Object, System.Buffers.IMemoryOwner<System.Byte>, System.IDisposable
{
	static SocLogger logger; // 0x0
	System.ArraySegment<System.Byte> buffer; // 0x10
	System.Int32 fromPoolPower; // 0x20
	System.Boolean isReturn; // 0x24
	System.Void .ctor(System.ArraySegment<System.Byte> buffer, System.Int32 fromPoolPower); // 0x076e9244
	System.Memory<System.Byte> get_Memory(); // 0x076e92f4
	System.Void Dispose(); // 0x076e9370
	System.Void Finalize(); // 0x076e9714
	static System.Void .cctor(); // 0x076e985c
}

// Client.Runtime
class SocDevKit.FrameworkShare.Memory.PowerOfTwoMemoryPool : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Stack<SocDevKit.FrameworkShare.Memory.DevKitMemoryOwner>[] pools; // 0x8
	static System.Int32[] maxCounts; // 0x10
	static System.Int64[] applyCounters; // 0x18
	static System.Int64[] usePoolCounters; // 0x20
	static System.Int64[] releaseCounters; // 0x28
	static System.Void SetMaxCount(); // 0x076e9930
	static System.Buffers.IMemoryOwner<System.Byte> Rent(System.Int32 power); // 0x076e9c74
	static System.Void Recycle(SocDevKit.FrameworkShare.Memory.DevKitMemoryOwner mem); // 0x076e9454
	static System.Void .cctor(); // 0x076ea0b4
}

// Client.Runtime
class Electric.BaseBulb : UnityEngine.MonoBehaviour
{
	UnityEngine.MaterialPropertyBlock m_materialPropertyBlock; // 0x30
	UnityEngine.MeshRenderer m_meshRenderer; // 0x38
	static System.Int32 timeOffsetHash; // 0x0
	static System.Int32 bulbIndexHash; // 0x4
	static System.Int32 modeHash; // 0x8
	static System.Int32 flashSpeed; // 0xc
	Electric.BaseBulb.BulbType currentAnimationType; // 0x40
	WizardGames.Soc.Common.Component.ElectricChristmasLightComponent.LightMode curLightMode; // 0x44
	System.Single timeOffset; // 0x48
	System.Int32 bulbIndex; // 0x4c
	System.Boolean isOn; // 0x50
	System.Single speed; // 0x54
	System.Int32[] colorSort; // 0x58
	System.Void SetOn(System.Boolean wantsOn); // 0x076ea288
	System.Void SetSpacingIndex(System.Single timeOffset, System.Int32 bulbIndex); // 0x076ea5a4
	System.Void SetBulbAnimation(WizardGames.Soc.Common.Component.ElectricChristmasLightComponent.LightMode type); // 0x076ea65c
	System.Void UpdateMaterialProperties(); // 0x076ea308
	System.Void .ctor(); // 0x076ea744
	static System.Void .cctor(); // 0x076ea80c
}

// Client.Runtime
enum Electric.BaseBulb.BulbType : System.Enum
{
	System.Int32 value__; // 0x10
	static Electric.BaseBulb.BulbType CLOSE = 0;
	static Electric.BaseBulb.BulbType FLASHING = 1;
	static Electric.BaseBulb.BulbType SLOWGLOW = 2;
	static Electric.BaseBulb.BulbType ON = 3;
	
}

// Client.Runtime
class Effect.DissipateEffectDisplay : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int32 ProfileInstanceId; // 0x1c
	WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile; // 0x20
	System.Action<UnityEngine.GameObject> onFinishCallBack; // 0x28
	System.Single fadeoutTime; // 0x30
	System.Single dissipateTime; // 0x34
	System.Single dissipateTotalTime; // 0x38
	System.Single runningTime; // 0x3c
	static Effect.DissipateEffectDisplay Generate(WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile, System.Action<UnityEngine.GameObject> onFinishCallBack); // 0x076ea914
	System.Void UpdateDissipate(System.Int32 deltaTime); // 0x076eabdc
	System.Boolean IsFinishDissipate(); // 0x076eadd4
	System.Void FinishDissipate(); // 0x076ead3c
	System.Void Dispose(); // 0x076eae84
	System.Void .ctor(); // 0x076eaf0c
}

// Client.Runtime
enum Effect.EffectHideFlags : System.Enum
{
	System.Int32 value__; // 0x10
	static Effect.EffectHideFlags None = 0;
	static Effect.EffectHideFlags HideByQuality = 1;
	static Effect.EffectHideFlags HideByWater = 2;
	static Effect.EffectHideFlags HideByOcclusion = 4;
	static Effect.EffectHideFlags HideByCulling = 8;
	
}

// Client.Runtime
class Effect.BaseEffectItem : System.Object
{
	static System.Int64 AutoIncrementId; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32> LODLevelRefreshWaterTime; // 0x8
	System.Int64 Id; // 0x10
	UnityEngine.GameObject EffectGo; // 0x18
	WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile; // 0x20
	System.Int32 Score; // 0x28
	System.Int32 qualityLodLevel; // 0x2c
	System.Int32 TempDistanceLodLevel; // 0x30
	System.Int32 distanceLodLevel; // 0x34
	System.Int64 NextRefreshWaterTime; // 0x38
	Effect.EffectHideFlags hideFlags; // 0x40
	System.Boolean isVisible; // 0x44
	System.Boolean isPlaying; // 0x45
	System.Single setVisibleTimer; // 0x48
	System.Boolean IsPlayUI; // 0x4c
	System.Boolean HasDistributeLodLevel(); // 0x076eaf74
	System.Boolean IsPlaying(); // 0x076eafe0
	System.Void DistributeLodLevel(System.Int32 qualityLevel, System.Int32 distanceLevel); // 0x055057d4
	System.Int32 GetParticleSystemCount(System.Int32 wantLodLevel); // 0x076eb044
	System.Int32 GetGoCount(System.Int32 wantLodLevel); // 0x076eb11c
	System.Void SetEffectLODLevel(System.Int32 level); // 0x076eb1f4
	System.Int32 GetEffectLODLevel(); // 0x076eb2c8
	System.Int32 CalLodLevel(System.Single screenPercentage); // 0x076eb3b0
	System.Single GetMinScreenPercentages(); // 0x076eb488
	System.Boolean CanRefreshWaterState(System.Int64 nowTime); // 0x076eb548
	System.Void RefreshInWaterState(System.Int64 nowTime); // 0x076eb5e0
	System.Void UpdateEffectStateByFlag(); // 0x076eb6c4
	System.Void ShowOrHideEffect(System.Boolean visible); // 0x076eb768
	System.Void RefreshLimitState(System.Boolean limit); // 0x076eb878
	System.Void RefreshOcclusionState(); // 0x076eba78
	System.Void RefreshCullingState(System.Boolean culling); // 0x076ebb5c
	System.Void RefreshWaterState(System.Boolean diffWater); // 0x076ebbec
	System.Void AddEffectHideFlag(Effect.EffectHideFlags flags); // 0x076eb930
	System.Void RemoveEffectHideFlag(Effect.EffectHideFlags flags); // 0x076eb9d4
	System.Boolean HasEffectHideFlag(Effect.EffectHideFlags flags); // 0x076ebc7c
	System.Int32 CalculateStateScore(Effect.EffectShowResult showResult); // 0x0548be58
	System.Int32 CompareTo(Effect.BaseEffectItem other); // 0x076ebcfc
	System.Void OnRelease(); // 0x076ebd94
	System.Void ReleasePool(); // 0x055049cc
	System.Void .ctor(); // 0x076ebe24
	static System.Void .cctor(); // 0x076ebe9c
}

// Client.Runtime
class Effect.DecalEffectItem : Effect.EffectItem
{
	UnityEngine.Rendering.Universal.DecalProjector decal; // 0x100
	System.Single decalScale; // 0x108
	UnityEngine.Vector3 DefaultDecalScale; // 0x10c
	System.Single get_DecalScale(); // 0x076ebfa4
	System.Void set_DecalScale(System.Single value); // 0x076ec008
	System.Boolean get_autoPlayAfterLoad(); // 0x076ec1fc
	System.Void Play(); // 0x076ec260
	System.Void OnRefresh(System.Int32 deltaTime, System.Int64 nowTime); // 0x076ec8c4
	System.Void OnRelease(); // 0x076ec940
	System.Void ReleasePool(); // 0x076ecee0
	System.Void .ctor(); // 0x076ecf80
}

// Client.Runtime
enum Effect.CacheEffectType : System.Enum
{
	System.Int32 value__; // 0x10
	static Effect.CacheEffectType None = 0;
	static Effect.CacheEffectType CacheSystem = 1;
	static Effect.CacheEffectType CacheByDissipate = 2;
	
}

// Client.Runtime
class Effect.EffectItem : Effect.BaseEffectItem
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32> LODLevelRefreshTime; // 0x8
	UnityEngine.Transform EffectTrans; // 0x50
	UnityEngine.Vector3 EffectPosition; // 0x58
	System.Boolean isFollowEffect; // 0x64
	System.Boolean IsLoadFinished; // 0x65
	Effect.EffectItemData EffectData; // 0x68
	System.Boolean isDecal; // 0x70
	Effect.CharacterEffect.CharacterCacheEffectType CacheEffectType; // 0x74
	System.Int32 LivingTime; // 0x78
	System.Int64 StartTime; // 0x80
	System.Int64 EndTime; // 0x88
	WizardGames.Soc.Common.Data.effect.EffectBase effectTable; // 0x90
	WizardGames.Soc.Common.Data.effect.EffectPriority effectPriorityTable; // 0x98
	System.Int64 embeddedTargetId; // 0xa0
	UnityEngine.Vector3 embededLocalPosition; // 0xa8
	UnityEngine.Transform embeddedTransform; // 0xb8
	System.Boolean isPlayDissipate; // 0xc0
	System.Collections.Generic.HashSet<System.Action<System.Boolean,Effect.EffectItem>> LoadCompleteCB; // 0xc8
	System.Collections.Generic.HashSet<System.Action<Effect.EffectItem>> ReleaseCB; // 0xd0
	Effect.CacheEffectType cacheEffectType; // 0xd8
	System.Int32 waitTickTime; // 0xdc
	System.Boolean isReleased; // 0xe0
	System.Boolean isDissipateThenRelease; // 0xe1
	System.Boolean HasFadein; // 0xe2
	System.UInt64 asyncId; // 0xe8
	System.Action<UnityEngine.GameObject> stopEffectAction; // 0xf0
	System.Action<UnityEngine.GameObject,System.Object[]> effectLoadFinishAction; // 0xf8
	System.Int32 get_TemplateId(); // 0x076ed1ac
	System.Boolean get_IsSelfEffect(); // 0x076ed21c
	System.String get_EffectPath(); // 0x076ed304
	System.Boolean get_ControlDecal(); // 0x076ed394
	System.Boolean get_IgnoreWaterRule(); // 0x076ed408
	System.Single get_Scale(); // 0x076ed47c
	System.Int32 get_BaseScore(); // 0x076ed4f0
	System.Int32 get_PriorityOffset(); // 0x076ed564
	System.Int32 get_FxTypeId(); // 0x076ed5d8
	System.Int32 get_SelfFxPriority(); // 0x076ed64c
	System.Int32 get_InCameraPriority(); // 0x076ed6c0
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.DayAndNightState,System.Int32> get_dayAndNightStatePriority(); // 0x076ed734
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.CharacterState,System.Int32> get_characterStatePriority(); // 0x076ed7a8
	System.Boolean get_autoPlayAfterLoad(); // 0x076ed81c
	static System.Void StopEffect(UnityEngine.GameObject go); // 0x076ed880
	System.Void InitData(Effect.EffectItemData effectData); // 0x076ed8f4
	System.Void LoadEffect(); // 0x076edb08
	System.Void EffectLoadFinish(UnityEngine.GameObject effectGO, System.Object[] param); // 0x076edd9c
	System.Void Play(); // 0x076ec4f4
	System.Void Stop(System.Boolean needDissipate); // 0x076ee918
	System.Void SetEmbeddedTarget(System.Int64 embeddingTarget, System.Int32 colliderIndex); // 0x076eea74
	System.Void HandleEmbeddedTarget(); // 0x076ee72c
	System.Boolean IsResidentEffect(); // 0x076ee5b0
	System.Boolean EffectIsVisible(); // 0x076eeec8
	System.Boolean HasDissipate(); // 0x076eef94
	System.Void PlayDissipateThenRelease(); // 0x076ef08c
	System.Void AfterDissipateDestroy(UnityEngine.GameObject go); // 0x076ef29c
	System.Void AddCompleteLoadCB(System.Action<System.Boolean,Effect.EffectItem> action); // 0x076ef3b4
	System.Void RemoveCompleteLoadCB(System.Action<System.Boolean,Effect.EffectItem> action); // 0x076ef4d0
	System.Void AddReleaseCB(System.Action<Effect.EffectItem> action); // 0x076ef56c
	System.Int32 CalculateStateScore(Effect.EffectShowResult showResult); // 0x076ef688
	System.Void SetParent(UnityEngine.Transform parent); // 0x076ee838
	System.Void ResetPositionAndRot(); // 0x076ef884
	System.Void OnRefresh(System.Int32 deltaTime, System.Int64 nowTime); // 0x076efb80
	System.Void ParticleInit(); // 0x076ee2c8
	System.Void SetCacheState(Effect.CacheEffectType state); // 0x076efd2c
	Effect.CacheEffectType GetCacheState(); // 0x076efda4
	System.Void SyncMaxShowDistance(UnityEngine.LODGroup[] lodGroup); // 0x076efe08
	System.Void DistributeLodLevel(System.Int32 qualityLevel, System.Int32 distanceLevel); // 0x076efedc
	System.Void RefreshInWaterState(System.Int64 nowTime); // 0x076f00d8
	System.Boolean IsValid(); // 0x076f02c4
	System.Boolean CheckRelease(System.Int64 nowTime); // 0x076f0358
	System.Void OnRelease(); // 0x076eca10
	System.Void ReleasePool(); // 0x076f03ec
	System.Void .ctor(); // 0x076ed010
	static System.Void .cctor(); // 0x076f048c
}

// Client.Runtime
enum Effect.FollowTransformFlag : System.Enum
{
	System.Int32 value__; // 0x10
	static Effect.FollowTransformFlag FollowPosition = 2;
	static Effect.FollowTransformFlag FollowForward = 4;
	static Effect.FollowTransformFlag FollowScale = 8;
	static Effect.FollowTransformFlag FollowPosAndRot = 6;
	static Effect.FollowTransformFlag FollowPosAndScale = 10;
	static Effect.FollowTransformFlag FollowRotAndScale = 12;
	static Effect.FollowTransformFlag FollowAll = 14;
	
}

// Client.Runtime
class Effect.FollowEffect : Effect.EffectItem
{
	UnityEngine.Vector3 PosFollowOffset; // 0x100
	System.Single ForceYPos; // 0x10c
	System.Boolean NeedForceYPos; // 0x110
	System.Boolean FollowTargetActive; // 0x111
	System.Boolean NeedFollowTargetActive; // 0x112
	System.Void ResetPositionAndRot(); // 0x076f0610
	System.Void Play(); // 0x076f08a4
	System.Void OnRefresh(System.Int32 deltaTime, System.Int64 nowTime); // 0x076f09d8
	System.Void UpdateFollow(); // 0x076f0ad0
	System.Boolean CheckRelease(System.Int64 nowTime); // 0x076f0d3c
	System.Void OnRelease(); // 0x076f0e14
	System.Void ReleasePool(); // 0x076f0ec4
	System.Void .ctor(); // 0x076f0f64
}

// Client.Runtime
class Effect.MovingEffect : Effect.EffectItem
{
	UnityEngine.Vector3 Velocity; // 0x100
	UnityEngine.Vector3 Acceleration; // 0x10c
	System.Void OnRefresh(System.Int32 deltaTime, System.Int64 nowTime); // 0x076f1034
	System.Void ReleasePool(); // 0x076f117c
	System.Void .ctor(); // 0x076f121c
}

// Client.Runtime
class Effect.ParticleEffect : Effect.FollowEffect
{
	UnityEngine.ParticleSystem particleSystem; // 0x118
	UnityEngine.ParticleSystem.MinMaxCurve OriginParticles; // 0x120
	System.Int32 ParticlePerSecond; // 0x140
	UnityEngine.ParticleSystem.EmissionModule Emission; // 0x148
	System.Single CurrentFollowTime; // 0x150
	System.Int32 MaxParticleCount; // 0x154
	System.Void EffectLoadFinish(UnityEngine.GameObject effectGO, System.Object[] param); // 0x076f12a4
	System.Void OnRefresh(System.Int32 deltaTime, System.Int64 nowTime); // 0x076f1498
	System.Void OnRelease(); // 0x076f1604
	System.Void ReleasePool(); // 0x076f1708
	System.Void .ctor(); // 0x076f17a8
}

// Client.Runtime
class Effect.SceneEffectItem : Effect.BaseEffectItem
{
	
	System.Void InitProfile(WizardGames.Soc.Common.Unity.Effect.EffectProfile profile); // 0x076f1840
	System.Void DistributeLodLevel(System.Int32 qualityLevel, System.Int32 distanceLevel); // 0x076f196c
	System.Int32 CalculateStateScore(Effect.EffectShowResult showResult); // 0x076f1a5c
	System.Void RefreshInWaterState(System.Int64 nowTime); // 0x076f1ad4
	System.Void OnRelease(); // 0x076f1cac
	System.Void ReleasePool(); // 0x076f1d10
	System.Void .ctor(); // 0x076f1db0
}

// Client.Runtime
enum Effect.TrailEffectFadeType : System.Enum
{
	System.Int32 value__; // 0x10
	static Effect.TrailEffectFadeType FadeIn = 0;
	static Effect.TrailEffectFadeType FadeOut = 1;
	static Effect.TrailEffectFadeType FadeInFadeOut = 2;
	static Effect.TrailEffectFadeType None = 3;
	
}

// Client.Runtime
class Effect.TrailRendererEffect : Effect.FollowEffect
{
	static System.Int32 TintColor; // 0x0
	static System.Int32 MainColor; // 0x4
	static UnityEngine.Gradient ClearGradientColor; // 0x8
	UnityEngine.TrailRenderer TrailRender; // 0x118
	Effect.TrailEffectFadeType FadeType; // 0x120
	System.Single FadeOutTime; // 0x124
	System.Single FadeInTime; // 0x128
	System.Single CurrentFadeTime; // 0x12c
	UnityEngine.Vector3 InitPosition; // 0x130
	System.Single DelayShowDis; // 0x13c
	System.Boolean hideTrail; // 0x140
	UnityEngine.Gradient baseGradient; // 0x148
	UnityEngine.Color originColor; // 0x150
	System.Boolean hasTintColor; // 0x160
	System.Boolean hasMainColor; // 0x161
	UnityEngine.MaterialPropertyBlock materialPropertyBlock; // 0x168
	System.Void EffectLoadFinish(UnityEngine.GameObject effectGO, System.Object[] param); // 0x076f1e38
	System.Void RecordColor(); // 0x076f22cc
	System.Void ReturnColor(); // 0x076f2588
	System.Void OnRefresh(System.Int32 deltaTime, System.Int64 nowTime); // 0x076f2720
	System.Boolean CheckRelease(System.Int64 nowTime); // 0x076f2cec
	System.Void OnRelease(); // 0x076f2e10
	System.Void ReleasePool(); // 0x076f2ecc
	System.Void .ctor(); // 0x076f2f6c
	static System.Void .cctor(); // 0x076f3028
}

// Client.Runtime
class Effect.WaterEffect : Effect.FollowEffect
{
	
	System.Void OnRefresh(System.Int32 deltaTime, System.Int64 nowTime); // 0x05822e6c
	System.Void .ctor(); // 0x05822f9c
}

// Client.Runtime
class Effect.EffectItemData : System.Object
{
	static SocLogger logger; // 0x0
	static UnityEngine.Pool.ObjectPool<Effect.EffectItemData> s_Pool; // 0x8
	UnityEngine.Vector3 EffectPos; // 0x10
	UnityEngine.Vector3 EffectForward; // 0x1c
	UnityEngine.Vector3 EffectRot; // 0x28
	UnityEngine.Vector3 EffectScale; // 0x34
	UnityEngine.Transform EffectParent; // 0x40
	UnityEngine.Transform EffectFollowTarget; // 0x48
	Effect.FollowTransformFlag EffectFollowFlag; // 0x50
	System.Int32 EffectLodLevel; // 0x54
	System.Int64 EntityId; // 0x58
	System.Int32 TemplateId; // 0x60
	System.Boolean IsAutoPlay; // 0x64
	System.Boolean IsAsync; // 0x65
	System.Void .ctor(); // 0x05823004
	static Effect.EffectItemData CreateFunc(); // 0x0582306c
	static Effect.EffectItemData Get(); // 0x058230ec
	WizardGames.Soc.Common.Data.effect.EffectBase get_EffectTable(); // 0x05823194
	System.Boolean get_IsSelfEffect(); // 0x05823280
	UnityEngine.Vector3 GetEffectPos(); // 0x05823490
	System.Boolean IsResidentEffect(); // 0x05823584
	System.Void Release(); // 0x05823650
	static System.Void .cctor(); // 0x05823798
}

// Client.Runtime
enum Effect.LoadEffectItemStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static Effect.LoadEffectItemStatus Failed = 0;
	static Effect.LoadEffectItemStatus None = 1;
	static Effect.LoadEffectItemStatus Succeeded = 2;
	
}

// Client.Runtime
class Effect.EffectLoadOperation : System.Object
{
	static System.Int32 s_IncreaseId; // 0x0
	static UnityEngine.Pool.ObjectPool<Effect.EffectLoadOperation> EffectLoadOperationPool; // 0x8
	System.Int32 version; // 0x10
	Effect.EffectItem Result; // 0x18
	Effect.LoadEffectItemStatus Status; // 0x20
	System.Boolean IsLoadComplete; // 0x24
	System.Object LoadCompleteParam; // 0x28
	System.Action<Effect.EffectItem> Destroyed; // 0x30
	System.Action<System.Boolean,Effect.EffectItem,System.Object> Completed; // 0x38
	System.Action<System.Boolean,Effect.EffectItem> loadCompletedAction; // 0x40
	System.Action<Effect.EffectItem> releaseAction; // 0x48
	System.Int32 get_Version(); // 0x05823938
	static Effect.EffectLoadOperation NewHandle(); // 0x0582399c
	System.Void .ctor(); // 0x05823a1c
	static Effect.EffectLoadOperation Get(); // 0x05823b38
	System.Void add_Completed(System.Action<System.Boolean,Effect.EffectItem,System.Object> value); // 0x05823c00
	System.Void remove_Completed(System.Action<System.Boolean,Effect.EffectItem,System.Object> value); // 0x05823cf0
	System.Void LoadCompleted(System.Boolean success, Effect.EffectItem item); // 0x05823de0
	System.Void Release(Effect.EffectItem item); // 0x05823eb8
	static System.Void .cctor(); // 0x05824008
}

// Client.Runtime
struct Effect.EffectItemHandle<T> : System.ValueType
{
	Effect.EffectLoadOperation m_EffectLoadOp; // 0x0
	System.Int32 version; // 0x0
	System.Boolean get_IsValid(); // 0x054c4760
	T get_Result(); // 0x052af1f0
	UnityEngine.GameObject get_EffectGo(); // 0x054e7844
	System.Boolean get_HasEffect(); // 0x054c4760
	System.Boolean get_IsLoadComplete(); // 0x054c4760
	System.Boolean get_IsLoadSuccess(); // 0x054c4760
	System.Boolean get_IsPlaying(); // 0x054c4760
	System.Void add_Completed(System.Action<System.Boolean,Effect.EffectItem,System.Object> value); // 0x05523a54
	System.Void remove_Completed(System.Action<System.Boolean,Effect.EffectItem,System.Object> value); // 0x05523a54
	static Effect.EffectItemHandle<T> Create<T>(T effectItem); // 0x052af1f0
	System.Void .ctor(Effect.EffectLoadOperation operation); // 0x05523a54
	System.Void AddOrCallLoadCompletedCallback(System.Action<System.Boolean,Effect.EffectItem,System.Object> callback, System.Object param); // 0x0552af00
	System.Void Play(); // 0x055049cc
	System.Void Stop(System.Boolean needDissipate); // 0x05523a7c
	System.Void PlayDissipateThenRelease(); // 0x055049cc
}

// Client.Runtime
class Effect.EffectItemHandleContainer : System.Object
{
	System.Collections.Generic.Dictionary<System.Type,System.Void*[]> m_EffectItemHandleList; // 0x10
	System.Void Clear(); // 0x05824118
	System.Void .ctor(); // 0x0582419c
}

// Client.Runtime
class Effect.EffectManager : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	Effect.Manager.MgrEffect mgrEffect; // 0x30
	System.Collections.Generic.HashSet<Effect.EffectItem> removeList; // 0x38
	UnityEngine.Plane[] cameraSourcePlanes; // 0x40
	System.Collections.Generic.List<Effect.BaseEffectItem> showEffects; // 0x48
	System.Collections.Generic.List<System.Int64> showEffectIdList; // 0x50
	System.Collections.Generic.HashSet<System.Int64> dbgShowEffects; // 0x58
	System.Collections.Generic.List<System.Int64> toRemoveDbgEffects; // 0x60
	Unity.Collections.NativeArray<Unity.Mathematics.float4> cameraPlanes; // 0x68
	System.Int32 effectDataLength; // 0x78
	Unity.Collections.NativeArray<Effect.EffectData> effectDataArray; // 0x80
	Unity.Collections.NativeArray<Effect.EffectScoreData> scoreResults; // 0x90
	Unity.Jobs.JobHandle calEffectScoreJobHandle; // 0xa0
	System.Boolean hasCalculateEffectJob; // 0xb0
	Unity.Collections.NativeArray<Effect.CullEffectData> cullEffectDataArray; // 0xb8
	Unity.Collections.NativeArray<Effect.CullEffectResult> cullResults; // 0xc8
	Unity.Jobs.JobHandle cullEffectJobHandle; // 0xd8
	System.Boolean hasCullEffectJob; // 0xe8
	System.Int32 unImportantEffectUpdateTime; // 0xec
	System.Int32 unImportantEffectUpdateTimer; // 0xf0
	System.Int32 calculateScoreUpdateTimer; // 0xf4
	System.Int32 calculateScoreUpdateTime; // 0xf8
	System.Boolean NeedCalculateScore; // 0xfc
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05824250
	System.Void InitEffectMgr(Effect.Manager.MgrEffect mgrEffect); // 0x058242b4
	System.Void FinishJob(); // 0x05824334
	System.Void Update(); // 0x05824478
	System.Void RefreshEffectShowState(Effect.EffectScoreData effectScoreData, Effect.BaseEffectItem effectItem); // 0x058248f4
	System.Void LateUpdate(); // 0x05825384
	System.Void RefreshShowDecal(System.Int64 nowTime); // 0x0582685c
	System.Void RefreshShowEffects(); // 0x05824b78
	System.Void DebugShowEffects(); // 0x05824d58
	System.Boolean Add2RemoveList(Effect.EffectItem effectItem); // 0x058270b8
	System.Void OnDestroy(); // 0x058276f0
	System.Void .ctor(); // 0x05827754
	static System.Void .cctor(); // 0x0582799c
}

// Client.Runtime
class Effect.EffectManager.<>c : System.Object
{
	static Effect.EffectManager.<>c <>9; // 0x0
	static System.Comparison<Effect.BaseEffectItem> <>9__31_0; // 0x8
	static System.Void .cctor(); // 0x05827a70
	System.Void .ctor(); // 0x05827ad4
	System.Int32 <RefreshShowEffects>b__31_0(Effect.BaseEffectItem x, Effect.BaseEffectItem y); // 0x05827b3c
}

// Client.Runtime
struct Effect.EffectData : System.ValueType
{
	System.Int64 id; // 0x10
	System.Int32 effectType; // 0x18
	System.Int32 baseScore; // 0x1c
	System.Int32 priorityOffset; // 0x20
	System.Int32 fxTypeId; // 0x24
	System.Single minScreenPercentages; // 0x28
	UnityEngine.Bounds localBounds; // 0x2c
	UnityEngine.Vector3 worldPos; // 0x44
	UnityEngine.Quaternion rotation; // 0x50
	UnityEngine.Vector3 Scale; // 0x60
	System.Boolean useObb; // 0x6c
	System.Single objectSize; // 0x70
	System.Boolean IsPlayUI; // 0x74
	System.Void .ctor(Effect.EffectItem effectItem); // 0x05826db8
	System.Void .ctor(Effect.SceneEffectItem effectItem); // 0x05826b10
}

// Client.Runtime
struct Effect.EffectScoreData : System.ValueType
{
	System.Int64 id; // 0x10
	System.Int32 effectType; // 0x18
	Effect.EffectShowResult showResult; // 0x1c
	System.Int32 score; // 0x20
	System.Single screenPercentage; // 0x24
	System.Single angle; // 0x28
	System.Single distance; // 0x2c
	
}

// Client.Runtime
enum Effect.InsideResult : System.Enum
{
	System.Int32 value__; // 0x10
	static Effect.InsideResult Out = 0;
	static Effect.InsideResult In = 1;
	static Effect.InsideResult Partial = 2;
	
}

// Client.Runtime
enum Effect.EffectShowResult : System.Enum
{
	System.Int32 value__; // 0x10
	static Effect.EffectShowResult Culling = 0;
	static Effect.EffectShowResult OutDistance = 1;
	static Effect.EffectShowResult Show = 2;
	
}

// Client.Runtime
struct Effect.CalculateEffectScoreJob : System.ValueType, Unity.Jobs.IJobParallelFor
{
	Unity.Collections.NativeArray<Effect.EffectData> EffectDataArray; // 0x10
	Unity.Collections.NativeArray<Unity.Mathematics.float4> CameraPlanes; // 0x20
	Unity.Collections.NativeArray<Effect.EffectScoreData> EffectScoreResults; // 0x30
	SignifianceScoreConfInJob Conf; // 0x40
	Unity.Mathematics.float3 cameraPos; // 0x80
	Unity.Mathematics.float2 cameraForward; // 0x8c
	System.Single cameraFOV; // 0x94
	System.Single maxDisplayDistanceScale; // 0x98
	System.Void Execute(System.Int32 index); // 0x05827bcc
	System.Single Angle(Unity.Mathematics.float2 from, Unity.Mathematics.float2 to); // 0x0582830c
	Effect.InsideResult InsideFrustumPlanes(Unity.Mathematics.float3 center, Unity.Mathematics.float3 extents); // 0x05827f3c
	static System.Single DistanceToScreenPercentage(System.Single objectSize, System.Single distance, System.Single cameraFOV); // 0x058281c0
}

// Client.Runtime
struct Effect.CullEffectData : System.ValueType
{
	System.Int64 id; // 0x10
	System.Int32 effectType; // 0x18
	System.Boolean useObb; // 0x1c
	UnityEngine.Bounds localBounds; // 0x20
	UnityEngine.Vector3 worldPos; // 0x38
	UnityEngine.Quaternion rotation; // 0x44
	UnityEngine.Vector3 Scale; // 0x54
	System.Boolean IsPlayUI; // 0x60
	System.Void .ctor(Effect.EffectItem effectItem); // 0x058271e0
	System.Void .ctor(Effect.SceneEffectItem effectItem); // 0x05826cb8
}

// Client.Runtime
struct Effect.CullEffectResult : System.ValueType
{
	System.Int64 id; // 0x10
	System.Int32 effectType; // 0x18
	System.Boolean isVisible; // 0x1c
	
}

// Client.Runtime
struct Effect.CullingEffectJob : System.ValueType, Unity.Jobs.IJobParallelFor
{
	Unity.Collections.NativeArray<Effect.CullEffectData> EffectDataArray; // 0x10
	Unity.Collections.NativeArray<Unity.Mathematics.float4> CameraPlanes; // 0x20
	Unity.Collections.NativeArray<Effect.CullEffectResult> CullEffectResults; // 0x30
	System.Void Execute(System.Int32 index); // 0x058284b0
	Effect.InsideResult InsideFrustumPlanes(Unity.Mathematics.float3 center, Unity.Mathematics.float3 extents); // 0x058286fc
}

// Client.Runtime
class Effect.TrailFadeInOutData : UnityEngine.MonoBehaviour
{
	Effect.TrailEffectFadeType FadeType; // 0x30
	System.Single FadeInTime; // 0x34
	System.Single FadeOutTime; // 0x38
	System.Void .ctor(); // 0x05828980
}

// Client.Runtime
class Effect.TreeFallDownEffect : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	UnityEngine.Vector3 bornPos; // 0x1c
	UnityEngine.Vector3 bornScale; // 0x28
	UnityEngine.Vector3 hitDirection; // 0x34
	System.Single rotateY; // 0x40
	System.Int64 lastAttackPlayerId; // 0x48
	System.String resPath; // 0x50
	System.Int32 treeFallFinishEffect; // 0x58
	UnityEngine.GameObject fallDownTreeGO; // 0x60
	System.Single currentTime; // 0x68
	System.Single treeHeight; // 0x6c
	System.Boolean isPlayEffect; // 0x70
	UnityEngine.Collider meshCollider; // 0x78
	UnityEngine.CapsuleCollider capsuleCollider; // 0x80
	System.Collections.Generic.List<UnityEngine.MeshRenderer> meshRenderers; // 0x88
	static Effect.TreeFallDownEffect New(UnityEngine.Vector3 bornPos, UnityEngine.Vector3 bornScale); // 0x058289e8
	System.Void Initilize(); // 0x05828acc
	System.Void TreeLoadFinish(); // 0x05828cb0
	System.Void OnUpdate(System.Int32 deltaTime); // 0x05828fe8
	System.Boolean NeedRelease(); // 0x05829478
	System.Void OnRelease(); // 0x058294ec
	System.Void .ctor(); // 0x05829794
}

// Client.Runtime
class Effect.Manager.MgrEffect : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Logger; // 0x0
	static UnityEngine.Transform LiveEffectRoot; // 0x8
	static UnityEngine.Transform LiveDecalRoot; // 0x10
	static UnityEngine.Transform MarkerEffectRoot; // 0x18
	static UnityEngine.Transform EffectRoot; // 0x20
	static System.Int32 S_SetWantLodLevelTime; // 0x28
	Effect.EffectManager effectManager; // 0x18
	static System.Int32 k_CullingEffectLodLevel = 3;
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Unity.Effect.EffectProfile> WaitingBecomeSceneEffects; // 0x20
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Unity.Effect.EffectProfile> sceneEffectProfiles; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,Effect.EffectItem> LiveEffectsDic; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,Effect.EffectItem> LiveDecalDic; // 0x38
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Effect.EffectProfile,Effect.SceneEffectItem> LiveSceneEffectDic; // 0x40
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Effect.EffectProfile> LiveSceneEffectProfileDic; // 0x48
	System.Collections.Generic.Dictionary<System.Int64,Effect.CharacterEffect.CharacterEffectData> CharacterEffectDataDict; // 0x50
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<Effect.EffectItem>> EmbeddedEffectDic; // 0x58
	System.Collections.Generic.List<Effect.EffectItem> SelfDecalEffectList; // 0x60
	System.Collections.Generic.List<System.Int64> toDeleteEffects; // 0x68
	System.Collections.Generic.Dictionary<System.Int32,Effect.DissipateEffectDisplay> DissipateEffectDisplayDict; // 0x70
	System.Collections.Generic.List<Effect.DissipateEffectDisplay> DissipateEffectDisplayList; // 0x78
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> selfEffectTypeLimitDic; // 0x80
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> otherEffectTypeLimitDic; // 0x88
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<Effect.EffectItem>> selfEffectTypeItemDic; // 0x90
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<Effect.EffectItem>> otherEffectTypeItemDic; // 0x98
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> selfEffectTypeCountDic; // 0xa0
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> otherEffectTypeCountDic; // 0xa8
	static System.Single MaxDistance = 100;
	static System.Single MinScreenPercentages = 1.7319999933242798;
	System.Boolean LastCameraInWater; // 0xb0
	System.Boolean PlayerInterior; // 0xb1
	System.Boolean PlayerEquipHighScopeInAds; // 0xb2
	System.Int32 lastEffectLevel; // 0xb4
	SignifianceScoreConf conf; // 0xb8
	SignifianceScoreConfInJob confInJob; // 0xe8
	SignifianceEffectComp SignifianceEffectComp; // 0x128
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> EntityBaseScore; // 0x130
	System.Boolean IsEnableDbgShow; // 0x138
	Effect.EffectManager get_EffectManager(); // 0x05829848
	System.Boolean get_IsInGame(); // 0x0582335c
	System.Void Init(); // 0x058298ac
	System.Void CleanUp(); // 0x0582a724
	System.Void ClearAllEffect(); // 0x0582a78c
	System.Void DisposeJob(); // 0x0582ae50
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x0582af04
	System.Void OnCharacterAdsStateChange(System.Int64 entityId, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum newState); // 0x0582b68c
	System.Threading.Tasks.Task OnEnterWorld(); // 0x0582b8bc
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x0582ba9c
	System.Threading.Tasks.Task OnExitWorld(); // 0x0582bc94
	System.Void InitDeviceQualityConfig(); // 0x0582b92c
	System.Void InitializeEffectTypeDictionaries(System.Int32 deviceLevel); // 0x0582be94
	System.Void InitializeEffectTypeDictionary(System.Int32 id, System.Int32[] limitArray, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<Effect.EffectItem>> itemDic, System.Collections.Generic.Dictionary<System.Int32,System.Int32> countDic, System.Collections.Generic.Dictionary<System.Int32,System.Int32> limitDic, System.Int32 deviceLevel); // 0x0582c860
	System.Void LimitEffects(System.Boolean isSelf); // 0x0582c1c4
	System.Void InitGlobalConfig(); // 0x0582a12c
	System.Void ChangeQualityLevel(WizardGames.Soc.RMQualityLevel InQualityLvl); // 0x0582ca5c
	System.Void ChangePCEffectQualityLevel(); // 0x0582cad4
	Effect.CharacterEffect.CharacterEffectData GetCharacterEffectData(System.Int64 entityId); // 0x0582cb38
	Effect.EffectItemHandle<T> PlayEffect<T>(System.Int32 templateId, System.Int64 entityId, UnityEngine.Vector3 pos, UnityEngine.Vector3 forward, UnityEngine.Vector3 rotation, UnityEngine.Vector3 scale, System.Boolean isAsync); // 0x052af1f0
	Effect.EffectItemHandle<T> PlayEffect<T>(System.Int32 templateId, System.Int64 entityId, UnityEngine.Transform parent, System.Boolean isAsync); // 0x052af1f0
	Effect.EffectItemHandle<T> PlayFollowEffect<T>(System.Int32 templateId, System.Int64 entityId, UnityEngine.Transform followTarget, Effect.FollowTransformFlag followTransformFlag, UnityEngine.Vector3 initPos, UnityEngine.Vector3 initForward, UnityEngine.Vector3 initScale, System.Boolean isAsync); // 0x052af1f0
	Effect.EffectItemHandle<T> CreateEffect<T>(System.Int32 templateId, System.Int64 entityId); // 0x052af1f0
	Effect.EffectItemHandle<T> CreateEffectItemHandle<T>(Effect.EffectItemData data); // 0x052af1f0
	System.Boolean CheckDistance(Effect.EffectItemData effectData); // 0x0582cd10
	System.Boolean CheckDecalBoundingBox(Effect.EffectItemData effectData); // 0x0582ce94
	System.Boolean TryCreateEffect<T>(Effect.EffectItemData effectData, T& effectItem); // 0x052af1f0
	System.Boolean TryCreateDecalEffect(Effect.EffectItemData effectData); // 0x0582d380
	T CreateEffect<T>(Effect.EffectItemData effectData); // 0x052af1f0
	System.Void EffectLoaded(WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile); // 0x0582d4d0
	System.Void EffectUnloaded(WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile); // 0x0582ad78
	System.Void RemoveProceduralEffect(WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile); // 0x0582d6b0
	System.Void EffectEnable(WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile); // 0x0582d768
	System.Void EffectDisable(WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile); // 0x0582d848
	System.Void AddSceneEffect(WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile); // 0x058266c8
	System.Void RemoveSceneEffect(WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile); // 0x0582d588
	System.Void EntityEmbeddedEffect(System.Int64 entityId, Effect.EffectItem effectItem, System.Int32 colliderIndex); // 0x0582d928
	System.Void EntityRemoveEmbeddedEffect(System.Int64 entityId, Effect.EffectItem effectItem); // 0x0582db34
	System.Void ClearEntityEmbeddedEffect(System.Int64 entityId); // 0x0582b438
	System.Void OreStageChange(System.Int64 entityId); // 0x0582dc1c
	System.Void PlayDissipate(WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile, System.Action<UnityEngine.GameObject> onFinishCallBack); // 0x0582dc98
	System.Void StopDissipate(WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile); // 0x0582de64
	System.Boolean TryGetEffectItem(System.Int64 effectId, Effect.EffectItem& item); // 0x0582dfb8
	System.Boolean CheckEffectCreate(System.Single posX, System.Single posY, System.Single posZ); // 0x0582e060
	System.Void Release<T>(Effect.EffectItemHandle<T> effectHandle, System.Boolean immediateDestroy); // 0x052af1f0
	System.Void Release(Effect.EffectItem effectItem, System.Boolean immediateDestroy); // 0x05827410
	System.Void .ctor(); // 0x0582e1ac
	static System.Void .cctor(); // 0x0582e21c
}

// Client.Runtime
enum Effect.CharacterEffect.CharacterCacheEffectType : System.Enum
{
	System.Int32 value__; // 0x10
	static Effect.CharacterEffect.CharacterCacheEffectType None = 0;
	static Effect.CharacterEffect.CharacterCacheEffectType FireEffect = 1;
	static Effect.CharacterEffect.CharacterCacheEffectType FireSmoke = 2;
	static Effect.CharacterEffect.CharacterCacheEffectType ShellCaseSmoke = 3;
	static Effect.CharacterEffect.CharacterCacheEffectType StopFireSmoke = 4;
	
}

// Client.Runtime
class Effect.CharacterEffect.CharacterEffectData : System.Object
{
	System.Int64 entityId; // 0x10
	System.Collections.Generic.Dictionary<Effect.CharacterEffect.CharacterCacheEffectType,Effect.EffectItem> cacheEffectItemDic; // 0x18
	System.Void .ctor(System.Int64 entityId); // 0x0582cc40
	Effect.EffectItem PlayEffect(Effect.CharacterEffect.CharacterCacheEffectType effectType, System.Int32 id, System.Boolean isFollow, UnityEngine.Transform point, Effect.FollowTransformFlag flag, UnityEngine.Vector3 scale); // 0x0582e2f0
	System.Boolean TryGetEffectItem(Effect.CharacterEffect.CharacterCacheEffectType effectType, System.Int32 id, System.Boolean isFollow, Effect.EffectItem& effectItem); // 0x0582e518
	System.Boolean IsEffectItemValid(Effect.EffectItem effectItem, System.Int32 id, System.Boolean isFollow); // 0x0582e63c
	System.Void AddCacheEffectItem(Effect.CharacterEffect.CharacterCacheEffectType effectType, System.Int32 id, System.Boolean isFollow); // 0x0582e760
	System.Void OnEffectDestroyed(Effect.EffectItem effectItem); // 0x0582ea6c
	System.Void ResetData(); // 0x0582b1b0
}

// Client.Runtime
class Contexts.ClientContext : WizardGames.Soc.Common.Unity.Contexts.UnityContext
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer MgrMyPlayer; // 0xf0
	Effect.Manager.MgrEffect MgrEffect; // 0xf8
	WizardGames.Soc.SocClient.Go.MgrEntityGo MgrEntityGo; // 0x100
	Systems.MgrRaycast MgrRaycast; // 0x108
	Systems.MgrHudMsg MgrHudMsg; // 0x110
	Systems.MgrTips MgrMsgTips; // 0x118
	WizardGames.Soc.Common.Unity.MgrCamera MgrCamera; // 0x120
	WizardGames.Soc.Common.Syncronization.MgrUserCmd MgrCmd; // 0x128
	Combat.Shoot.Formula.MgrGunkickFormula MgrGunkickFormula; // 0x130
	WizardGames.Soc.SocClient.Effect.CorrectedEffectData.CorrectedEffectDataSet CorrectedEffectDataSet; // 0x138
	WizardGames.Soc.Common.Data.MgrTables Tables; // 0x140
	Unity.Jobs.JobHandle TpAnimatorJobHandle; // 0x148
	Unity.Jobs.JobHandle HumanoidAnimatorJobHandle; // 0x158
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.NewLogicAnimEvent> LogicAnimEvents; // 0x168
	System.Collections.Generic.Dictionary<System.Int64,Animation.AnimBehCache> HistoryBehList; // 0x170
	Unity.Collections.NativeArray<WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData> TpAnimationResultJobDataArray; // 0x178
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData> MonsterAnimationResultJobDataArray; // 0x188
	System.Int32 TpJobDataCount; // 0x198
	System.Int32 MonsterJobDataCount; // 0x19c
	System.Collections.Generic.Queue<WizardGames.Soc.Common.Unity.Contexts.SyncSmbStepAudioData> FpPlayFootStepAudioMsgs; // 0x1a0
	System.Void .ctor(); // 0x0582eb0c
	System.Void Clear(); // 0x0582ed3c
}

// Client.Runtime
enum Construction.Util.EBuildFirstModeTypePie : System.Enum
{
	System.Int32 value__; // 0x10
	static Construction.Util.EBuildFirstModeTypePie None = 0;
	static Construction.Util.EBuildFirstModeTypePie Build = 1;
	static Construction.Util.EBuildFirstModeTypePie Blueprint = 2;
	static Construction.Util.EBuildFirstModeTypePie Edit = 3;
	static Construction.Util.EBuildFirstModeTypePie DeviceConnection = 4;
	
}

// Client.Runtime
class Construction.Util.BuildPanelPieUtil : System.Object
{
	static SocLogger Logger; // 0x0
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase> BuildItemDataList; // 0x8
	static System.Void CollectBuildItemDataList(Construction.Util.EBuildFirstModeTypePie firstModeTypePie); // 0x0582eed4
	static System.Void GetBuildCoreDataList(WizardGames.Soc.Common.Data.constraction.BuildFirstModePie firstModeTypePie); // 0x0582f5a0
	static System.Void GetBuildComboDataList(WizardGames.Soc.Common.Data.constraction.BuildFirstModePie firstModeTypePie); // 0x0582fa50
	static System.Void GetBuildBlueprintDataList(WizardGames.Soc.Common.Data.constraction.BuildFirstModePie firstModeTypePie); // 0x0582fe34
	static System.Void GetCustomBlueprintDataList(WizardGames.Soc.Common.Data.constraction.BuildFirstModePie firstModeTypePie, System.Boolean addEmpty); // 0x05830218
	static System.Void AddEmptyCustomBlueprintData(WizardGames.Soc.Common.Data.constraction.BuildFirstModePie firstModeTypePie); // 0x05830830
	static System.Int32 GetTargetTagId(System.Collections.Generic.List<System.Int32> tagIds, System.Boolean isEditMode); // 0x05830750
	static System.Void ClearBuildDataList(); // 0x0582f394
	static System.Void SetIcon(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase partViewDataBase, System.Collections.Generic.List<System.String> iconUrlList, FairyGUI.GList glistIcon, System.Boolean isSelectedOption); // 0x05830d6c
	static WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase GetUpgradePartData(System.Int32 targetGrade, System.Boolean filterLowGrade); // 0x0583119c
	static WizardGames.Soc.Common.Data.constraction.ConstructionComboChildGroupConfig GetChildGroupUpgradeId(WizardGames.Soc.Common.Data.constraction.ConstructionComboChildGroupConfig childGroupConfig, System.Int32 targetGrade, System.Boolean isLowGrade); // 0x058317fc
	static WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase CreateBuildDataByEdit(WizardGames.Soc.Common.Data.constraction.BuildingCore buildingCore, System.Int32 grade, System.Boolean isUpgrade, System.Int32 priority, System.Int32 priorityPie); // 0x0583168c
	static WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase CreateBuildDataByEdit(WizardGames.Soc.Common.Data.constraction.ConstructionComboChildGroupConfig childGroupConfig, System.Int32 grade, System.Boolean isUpgrade); // 0x05831b98
	static System.Void .cctor(); // 0x05831ca0
}

// Client.Runtime
class Construction.Util.ClientConstructionUtils : System.Object
{
	static System.Boolean ENABLE_DEBUG_DRAW; // 0x0
	static UnityEngine.GameObject partFaceShowRoot; // 0x8
	static System.Int32 lastWorkbenchResMaxLv; // 0x10
	static System.Int64 lastWorkbenchResEntityId; // 0x18
	static UnityEngine.Vector3 lastGetWorkbenchLvPlayerPos; // 0x20
	static System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Go.BasePartDebrisGo> partDebrisGoDic; // 0x30
	static System.Collections.Generic.Dictionary<System.Int64,System.Single> entity2LightAreaEffectTimeDic; // 0x38
	static System.Boolean isShowDebris; // 0x40
	static System.Collections.Generic.List<System.String> batteryInfo; // 0x48
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Construction.PartType,System.Int32> workBenchLevelMap; // 0x50
	static System.Collections.Generic.HashSet<System.Int64> constructionIdSet; // 0x58
	static System.Collections.Generic.HashSet<System.Int64> renderedPartIdSet; // 0x60
	static WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget target; // 0x68
	static SocLogger logger; // 0x100
	static System.Collections.Generic.Dictionary<System.String,System.UInt64> loadPrefabPathToAsyncIdDic; // 0x108
	static System.Boolean openShatterPreload; // 0x110
	static System.Collections.Generic.List<Construction.Util.ShatterTask> shatterTasks; // 0x118
	static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.HashSet<System.String>> shatteredPoolPathDict; // 0x120
	static System.Int32 checkShrinkTimeInterval; // 0x128
	static System.Collections.Generic.List<System.String> needRemovePartPoolKeys; // 0x130
	static System.Collections.Generic.HashSet<System.String> needCheckPoolKeys; // 0x138
	static System.Collections.Generic.HashSet<System.String> hasCheckPoolKeys; // 0x140
	static System.Int32 processedCount; // 0x148
	static System.Int32 shatterCount; // 0x14c
	static System.Collections.Generic.Dictionary<System.String,System.Single> partShatteredTimeDict; // 0x150
	static System.Single nextCheckShrinkTime; // 0x158
	static Construction.Util.EShatterMode curShatterMode; // 0x15c
	static System.String get_TxtElectricInfoHms(); // 0x05831dcc
	static System.String get_TxtElectricInfoMS(); // 0x05831e54
	static System.String get_TxtElectricInfoS(); // 0x05831edc
	static System.String get_TxtElectricInforWm(); // 0x05831f64
	static System.String get_NotConnectStr(); // 0x05831fec
	static System.Void .cctor(); // 0x05832074
	static System.Void AddLocalPartId(System.Int64 id); // 0x05832744
	static System.Void RemoveLocalPartId(System.Int64 id); // 0x05832848
	static System.Void ClearLocalPartId(); // 0x0583294c
	static System.Void AddRenderPartId(System.Int64 entityId); // 0x05832a14
	static System.Boolean IsPartRender(System.Int64 entityId); // 0x05832ac8
	static System.Void RemoveRenderPartId(System.Int64 entityId); // 0x05832b7c
	static System.Void ClearRenderPartId(); // 0x05832c30
	static System.Void LinkTwoEntity(WizardGames.Soc.Common.Component.ConstructionSocketBaseComponent a, WizardGames.Soc.Common.Component.ConstructionSocketBaseComponent b); // 0x05832cf8
	static System.Void OnCreatePartDebrisGo(WizardGames.Soc.Common.Unity.Go.BasePartDebrisGo debrisGo); // 0x05832f1c
	static System.Void PlayKnockAudio(System.Int64 partEntityId, System.Int32 index); // 0x058330b8
	static System.Void OnRemovePartDebrisGo(System.Int64 entityId); // 0x05833290
	static System.Boolean get_NoConsumptionMode(); // 0x05833394
	static System.Boolean CheckInteractivePermission(WizardGames.Soc.Common.Entity.PartEntity partEntity, WizardGames.Soc.Common.Construction.EPrivilegeType pType, System.Boolean silent); // 0x0583349c
	static System.Boolean CheckPermissionAtPos(WizardGames.Soc.Common.Construction.EPrivilegeType pType, WizardGames.Soc.Common.Algorithm.Vector3 position, System.Int64 partType, System.Boolean silent); // 0x0583359c
	static System.Boolean CheckSightBlock(UnityEngine.Vector3 origin, UnityEngine.Vector3 aimPos); // 0x058336c0
	static WizardGames.Soc.Common.Unity.Construction.PartGoConfig GetPartGoConfig(UnityEngine.GameObject go); // 0x0583395c
	static System.Void OnEnterBuildMode(WizardGames.Soc.Common.Data.EBuildThirdModeType buildModeType); // 0x05833a28
	static System.Void ShowDebris(); // 0x05833ad4
	static System.Void HideAllDebris(); // 0x05833c8c
	static System.Void OnExitAllBuildMode(); // 0x05833e40
	static System.Void GetMaxWorkbenchLevel(UnityEngine.Vector3 playerPos, System.Int32& maxLv, System.Int64& maxLvEntityId); // 0x05833ee4
	static UnityEngine.GameObject GetPartFaceShowRoot(); // 0x058347c4
	static System.Int32 GetCurrentConstructedNum(System.Int64 partType); // 0x05834908
	static System.Boolean IsUnlockAtBluePrint(System.Int64 itemId); // 0x05834a48
	static System.Boolean GetBlueprintIdByItemId(System.Int64 itemId, System.Int64& blueprintId); // 0x05834c18
	static System.Void PlayBuildEffect(System.Int64 partType, UnityEngine.Vector3 effectPos, System.Int64 entityId); // 0x05834d5c
	static System.Void PlayLightRangeEffect(System.Int64 entityId); // 0x05834fdc
	static System.Boolean CheckIfPartNumIsUnderLimitInThisArea(System.Int64 partType, System.Int32 addNum, UnityEngine.Vector3 pos, System.Int32& ret); // 0x0583559c
	static System.Void PlayBurnAudio(WizardGames.Soc.Common.Entity.PartEntity partEntity, System.Boolean isBurn, System.Boolean flagChange); // 0x05835710
	static System.String GetShowNameByPartType(System.Int64 type); // 0x05835980
	static System.Void CreatPartOverAndPlayAudio(System.Int64 partType, UnityEngine.Vector3 pos, System.Int64 entityId, System.Int32 grade, System.Boolean isBlueprint); // 0x05835ad4
	static System.Boolean IsUnlock(System.Int64 checkId, System.Boolean isComboId); // 0x05835f94
	static System.Int64 GetConstructionBlueprintId(System.Int64 checkId, System.Boolean isComboId); // 0x05836094
	static System.Collections.Generic.List<System.Int64> FindContainerNeighbourInRayView(System.Int64 containerId); // 0x05836204
	static System.Boolean CheckContainerConfig(WizardGames.Soc.Common.Entity.PartEntity entity, UnityEngine.Ray viewRay, System.Boolean checkForward); // 0x05837284
	static WizardGames.Soc.Common.Entity.PartEntityPrebuild CreatePrebuildPartEntity(System.Int64 partType, System.Int64 comboId, System.Int32 toolboxMode); // 0x05837424
	static System.Void TryUpgradeCurAimNoneCoreConstruction(WizardGames.Soc.Common.Entity.PartEntity part, System.Action<System.Boolean> checkUpgradeCallback); // 0x05837630
	static System.Boolean CheckBuildDistance(UnityEngine.Vector3 playerPos, UnityEngine.Vector3 buildPos); // 0x058381ac
	static System.Boolean CheckCanBuild(System.Int64 templateId, UnityEngine.Vector3 pos, UnityEngine.Vector3 rot, WizardGames.Soc.Common.Entity.PartEntity ignoreEntity, System.Int32 funcIgnoreMask, System.String ignoreTag); // 0x05837e9c
	static System.Void Log(System.String info); // 0x05838464
	static System.Boolean CheckPartTypeCanBuild(System.Int64 targetType, System.Int64 originType); // 0x05837be4
	static System.Boolean CheckIfNeedCreateCombineToolBox(UnityEngine.Vector3 pos, System.String& errorInfo); // 0x058385c8
	static System.Boolean IsAnyCoreConstructionNearBy(UnityEngine.Vector3 centerPos, System.Single checkRadius); // 0x058389e0
	static System.Boolean CheckIfCanPlaceToolbox(UnityEngine.Vector3 position, WizardGames.Soc.Common.Entity.PartEntity ignoreToolBox, WizardGames.Soc.Common.Entity.TerritoryEntity& otherTerrEnt, System.Boolean canFindDeserted); // 0x05838d4c
	static System.Boolean HasOtherTerrEntity(UnityEngine.Vector3 pos, System.Single radius, WizardGames.Soc.Common.Entity.TerritoryEntity& overlappedTerrEnt, System.Int64 ignoreEntityId, System.Boolean canFindDeserted); // 0x05838f28
	static System.Void CreateToolboxOver(); // 0x05839128
	static System.Boolean CheckPartTypeTemplateId(System.Int64 templateId, WizardGames.Soc.Common.Construction.PartType partType); // 0x05839228
	static System.String GetADefaultTerritoryNameByRecordInfo(System.Boolean IsPrimaryTerritory, UnityEngine.Vector3 position); // 0x05839324
	static System.String GetADefaultTerritoryNameByEntityId(System.Int64 territoryPartId); // 0x058394b8
	static System.String GetATerritoryNameByEntityId(WizardGames.Soc.Common.Entity.TerritoryEntity territory); // 0x05839764
	static System.Boolean CanShowEditLimitTimeInfo(WizardGames.Soc.Common.Entity.PartEntity part); // 0x058398e4
	static System.Collections.Generic.List<System.String> GetBatteryInfo(System.Int64 partId, System.Int32 chargeLeft, System.Int32 chargeTime, System.Int32 usage, System.Int32 power); // 0x05839cb0
	static System.String TransitionToTime(System.Single seconds); // 0x0583a3f0
	static System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PartEntity> GetNearbyPartIdsByPhysics(UnityEngine.Vector3 playerPos, System.Single checkDistance, WizardGames.Soc.Common.Construction.PartType partType, System.Boolean needV1Type); // 0x0583a6c8
	static System.Int32 get_shatterMaxCount(); // 0x0583ab60
	static System.Boolean get_isPhysicMode(); // 0x0583ac3c
	static System.Void RestorePhysicShatterCount(); // 0x0583accc
	static System.Void ShatterGoLoadCallBack(UnityEngine.GameObject instGo, System.Object[] owner); // 0x0583ad7c
	static System.Boolean OpenShatteredPoolShrinkState(System.String poolKey); // 0x0583b518
	static System.Void OnExitWorld(); // 0x0583b5e0
	static System.Void Tick(); // 0x0583bb64
	static System.Void ShatteredPoolShrinkTick(); // 0x0583bd6c
	static System.Void OpenShatterGoPoolShrinkState(System.String partGoPrefabPath); // 0x0583c5e4
	static System.Void PreLoadShatterGoByEntityId(System.Int64 entityId); // 0x0583c818
	static System.Void PreloadShatterGo(System.Int32 grade, System.Int64 partType, System.Int64 skinId, System.Int64 additionInfo); // 0x0583c990
	static System.Void PreloadShatterGo(System.String prefabPath); // 0x0583ce60
	static System.Boolean ReleaseShatterGo(UnityEngine.GameObject instGo, System.String prefabPath); // 0x0583cf1c
	static System.Void ExecuteShatterProcess(UnityEngine.GameObject instGo, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 scale, System.String prefabPath); // 0x0583b1d0
	static System.Void PlayPhysicShatter(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.GameObject instGo, System.Action playCallback, System.Action finishCallback); // 0x0583d1f8
	static System.Boolean PlayAnimationShatter(UnityEngine.GameObject instGo, System.Action callback); // 0x0583d578
	static System.Void AnimationEndHandler(UnityEngine.GameObject instGo, UnityEngine.Animator animator, System.String clipName, System.Action callback); // 0x0583db3c
	static System.Void SetRigidbodiesKinematic(UnityEngine.GameObject target, System.Boolean state); // 0x0583da54
	static System.Void PlayConstructionShatterEffect(Construction.Util.PlayShatterEffectData playShatterEffectData); // 0x0583dcac
	static System.Boolean PlayPhysicOrAnimationShatter(Construction.Util.PlayShatterEffectData partEntity); // 0x0583de24
	static System.Void PlayParticleShatter(System.Int64 lastAttackPlayerId, UnityEngine.Vector3 position, UnityEngine.Vector3 direction); // 0x0583e738
	static System.Void PlayShatteredAudio(Construction.Util.PlayShatterEffectData playData); // 0x0583e880
	static System.Void RegisterShatterFinishCallback(UnityEngine.GameObject target, System.Single duration, System.Action finishCallback); // 0x0583d854
	static System.Void UpdateActiveTasks(); // 0x0583bbe4
	static System.Void ClearAllShatterTasks(); // 0x0583b97c
}

// Client.Runtime
class Construction.Util.ClientConstructionUtils.<>c__DisplayClass119_0 : System.Object
{
	UnityEngine.GameObject instGo; // 0x10
	System.String prefabPath; // 0x18
	System.Void .ctor(); // 0x0583d190
	System.Void <ExecuteShatterProcess>b__0(); // 0x0583eaa8
	System.Void <ExecuteShatterProcess>b__1(); // 0x0583eb38
}

// Client.Runtime
class Construction.Util.ClientConstructionUtils.<>c__DisplayClass121_0 : System.Object
{
	UnityEngine.GameObject instGo; // 0x10
	UnityEngine.Animator animator; // 0x18
	System.String clipName; // 0x20
	System.Action callback; // 0x28
	System.Void .ctor(); // 0x0583d9ec
	System.Void <PlayAnimationShatter>b__0(); // 0x0583ebc8
}

// Client.Runtime
class Construction.Util.ClientConstructionUtils.<>c__DisplayClass54_0 : System.Object
{
	System.Int64 entityId; // 0x10
	Effect.EffectItemHandle<Effect.EffectItem> scopeFXHandle; // 0x18
	Effect.EffectItemHandle<Effect.EffectItem> planeFXHandle; // 0x28
	System.Void .ctor(); // 0x05835534
	System.Void <PlayLightRangeEffect>b__0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x0583ec70
}

// Client.Runtime
enum Construction.Util.EShatterMode : System.Enum
{
	System.Int32 value__; // 0x10
	static Construction.Util.EShatterMode Physic = 0;
	static Construction.Util.EShatterMode Animation = 1;
	static Construction.Util.EShatterMode Particle = 2;
	
}

// Client.Runtime
struct Construction.Util.ShatterTask : System.ValueType
{
	UnityEngine.GameObject Target; // 0x10
	System.Action Callback; // 0x18
	System.Single EndTime; // 0x20
	
}

// Client.Runtime
class Construction.Util.PlayShatterEffectData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.Int64 TemplateId; // 0x10
	System.Int32 Grade; // 0x18
	System.Int64 SkinId; // 0x20
	System.Int64 AdditionInfo; // 0x28
	System.Int64 LastAttackPlayerId; // 0x30
	UnityEngine.Vector3 Position; // 0x38
	UnityEngine.Quaternion Rotation; // 0x44
	System.Int32 ShowState; // 0x54
	System.Void SetData(WizardGames.Soc.Common.SimpleCustom.DestroyPartGoEvent data); // 0x0583edcc
	System.Void OnGet(); // 0x0583eeb8
	System.Void OnRelease(); // 0x0583ef18
	System.Void OnDestroy(); // 0x0583f004
	System.Void .ctor(); // 0x0583f064
}

// Client.Runtime
class Construction.Util.ClientPartAnimationUtils : System.Object
{
	static System.Int64 currentFocusEntityId; // 0x0
	static System.Int32 startFocusTime; // 0x8
	static System.Boolean hasPlayed; // 0xc
	static System.Void ClearFoucEntity(); // 0x0583f0cc
	static System.Void CheckAndPlaySkinAnimation(); // 0x0583f148
	static System.Void SetFocusEntity(System.Int64 entityId); // 0x0583f370
}

// Client.Runtime
class Construction.BuildMode.BuildEditBase : WizardGames.Soc.SocClient.Construction.BuildMode.BuildModeBase
{
	WizardGames.Soc.Common.Unity.Event.MsgHandler handler; // 0x28
	WizardGames.Soc.SocClient.Ui.UiHudElemSwitchSocket BtnSwitchSocket; // 0x30
	System.Boolean <IsMoveState>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Construction.BuildMode.BuildDeployMode deployMoveMode; // 0x40
	System.Boolean isConfirmDoubleCheck; // 0x48
	WizardGames.Soc.Common.Entity.PartEntity get_targetPartEntity(); // 0x0583f504
	WizardGames.Soc.SocClient.Manager.EditTargetPartData get_editTarget(); // 0x0583f578
	System.Boolean get_IsMoveState(); // 0x0583f610
	System.Void set_IsMoveState(System.Boolean value); // 0x0583f674
	WizardGames.Soc.SocClient.Construction.BuildMode.BuildDeployMode get_DeployMoveMode(); // 0x0583f6f0
	System.Void set_DeployMoveMode(WizardGames.Soc.SocClient.Construction.BuildMode.BuildDeployMode value); // 0x0583f7b4
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastModeType); // 0x0583f834
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextModeType); // 0x0583fc7c
	System.Void TryRotateCurAimConstruction(); // 0x05840020
	System.Void BuildModeCancelEvent(); // 0x0584031c
	System.Void ConfirmBuildOkEvent(); // 0x05840478
	System.Void StartMove(); // 0x058404d8
	System.Boolean CanMove(); // 0x0584055c
	System.Void DeployMoveFinish(); // 0x05840b10
	System.Void PartLastMoveTimeChange(System.Int64 partId); // 0x05840b74
	System.Void OnPartEntityRemove(System.Int64 partId); // 0x05841240
	System.Void OnChangePartGoTransform(System.Int64 partId); // 0x05841578
	System.Void OnTerritoryAttacked(System.Int64 partId); // 0x058415f8
	System.Void TrySetMoveStateToFalseWithHint(System.Int64 partId, System.Int32 hintId); // 0x058412c0
	System.Void SetMoveState(System.Boolean isMove, System.Boolean refreshUi); // 0x0583fdd8
	System.Void UpdateConfirmBuildOkButton(); // 0x05840c6c
	System.Boolean CanSwitchSocket(); // 0x058419e4
	System.Void UpdateRaycastTarget(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x05841be8
	System.Boolean CheckPermission(WizardGames.Soc.Common.Construction.EPrivilegeType privilegeType, System.Boolean silent); // 0x05841718
	System.Boolean CheckPermissionByPartEx(WizardGames.Soc.Common.Construction.EPrivilegeType privilegeType, WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x05840a10
	System.Boolean IsCoreConstruction(System.Int64 templateId); // 0x05841678
	System.Boolean IsCanPickUpConstruction(System.Int64 templateId); // 0x05841858
	System.Boolean IsCanPickUpSpecific(WizardGames.Soc.Common.Entity.PartEntity part); // 0x058418f8
	System.Void HideEditUINoTarget(); // 0x05841d14
	System.Void TryRemoveAimedConstruction(); // 0x05841e04
	System.Void LogicUpdate(); // 0x05842300
	System.Void RenderUpdate(); // 0x058423cc
	System.Void LateUpdate(); // 0x0584242c
	System.Void .ctor(System.Int32 modeId); // 0x05842518
	System.Void DoubleCheckConfirmRemove(); // 0x058425bc
	System.Void DoubleCheckConfirmRotate(); // 0x05842688
}

// Client.Runtime
class Construction.BuildMode.BuildSkinMode : WizardGames.Soc.SocClient.Construction.BuildMode.BuildModeBase
{
	static System.Boolean OnceChangeSkin; // 0x0
	WizardGames.Soc.Common.Entity.PartEntity targetPartEntity; // 0x28
	System.Int64 <CurrentSelectSkinId>k__BackingField; // 0x30
	WizardGames.Soc.Common.Data.EBuildThirdModeType lastMode; // 0x38
	static WizardGames.Soc.Common.Data.EBuildFirstModeType lastFirstModeType; // 0x4
	static WizardGames.Soc.Common.Data.EBuildSecondModeType lastSecondModeType; // 0x8
	System.Boolean isConfirmDoubleCheck; // 0x3c
	static WizardGames.Soc.SocClient.Ui.UiHudElemSkinPanel get_skinPanel(); // 0x058426fc
	WizardGames.Soc.Common.Entity.PartEntity get_TargetPartEntity(); // 0x05842770
	System.Int64 get_CurrentSelectSkinId(); // 0x058427d4
	System.Void set_CurrentSelectSkinId(System.Int64 value); // 0x05842838
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastModeType); // 0x058428b0
	System.Void OnTerritoryAtted(System.Int64 terrEntityId, System.Int64 stateTs); // 0x0584307c
	System.Void OnConstructionChangeSkinOver(System.Int64 partId); // 0x05843288
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextModeType); // 0x05843878
	System.Void UpdateRaycastTarget(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x05842cec
	System.Void SetBtnState(); // 0x05843540
	System.Void DoubleCheckConfirm(); // 0x05843dcc
	System.Void OnEntityGoRemove(System.Int64 entityId); // 0x05843e4c
	System.Void ConfirmBuildOkEvent(); // 0x058440dc
	System.Void BuildModeCancelEvent(); // 0x05843fcc
	System.Void EnterLastMode(); // 0x05843458
	System.Void RenderUpdate(); // 0x05844c10
	System.Void LateUpdate(); // 0x05844c70
	System.Void LogicUpdate(); // 0x05844cd0
	System.Void SetSelectSkinId(System.Int64 skinId); // 0x05844d30
	System.Void .ctor(System.Int32 modeId); // 0x05844df4
	System.Boolean IsSkinChangeCD(System.Int32& endTime, System.Int32& cdTime); // 0x05843b24
}

// Client.Runtime
class Construction.BuildMode.BuildPieEditBase : WizardGames.Soc.SocClient.Construction.BuildMode.BuildModeBase
{
	WizardGames.Soc.Common.Unity.Event.MsgHandler handler; // 0x28
	WizardGames.Soc.SocClient.Ui.UiHudElemSwitchSocket BtnSwitchSocket; // 0x30
	System.Boolean <IsMoveState>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieDeployMode deployMoveMode; // 0x40
	System.Boolean isConfirmDoubleCheck; // 0x48
	WizardGames.Soc.Common.Entity.PartEntity get_targetPartEntity(); // 0x059bdd30
	WizardGames.Soc.SocClient.Manager.EditTargetPartData get_editTarget(); // 0x059bdda4
	System.Boolean get_IsMoveState(); // 0x059bde3c
	System.Void set_IsMoveState(System.Boolean value); // 0x059bdea0
	WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieDeployMode get_DeployMoveMode(); // 0x059bdf1c
	System.Void set_DeployMoveMode(WizardGames.Soc.SocClient.Construction.BuildMode.BuildPieDeployMode value); // 0x059bdfe0
	System.Void OnEnter(WizardGames.Soc.Common.Data.EBuildThirdModeType lastModeType); // 0x059be060
	System.Void OnExit(WizardGames.Soc.Common.Data.EBuildThirdModeType nextModeType); // 0x059be4a8
	System.Void TryRotateCurAimConstruction(); // 0x059be84c
	System.Void BuildModeCancelEvent(); // 0x059beb48
	System.Void ConfirmBuildOkEvent(); // 0x059beca4
	System.Void StartMove(); // 0x059bed04
	System.Boolean CanMove(); // 0x059bed88
	System.Void DeployMoveFinish(); // 0x059bf33c
	System.Void PartLastMoveTimeChange(System.Int64 partId); // 0x059bf3a0
	System.Void OnPartEntityRemove(System.Int64 partId); // 0x059bfa6c
	System.Void OnChangePartGoTransform(System.Int64 partId); // 0x059bfda4
	System.Void OnTerritoryAttacked(System.Int64 partId); // 0x059bfe24
	System.Void TrySetMoveStateToFalseWithHint(System.Int64 partId, System.Int32 hintId); // 0x059bfaec
	System.Void SetMoveState(System.Boolean isMove, System.Boolean refreshUi); // 0x059be604
	System.Void UpdateConfirmBuildOkButton(); // 0x059bf498
	System.Boolean CanSwitchSocket(); // 0x059c0214
	System.Void UpdateRaycastTarget(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x059c0418
	System.Boolean CheckPermission(WizardGames.Soc.Common.Construction.EPrivilegeType privilegeType, System.Boolean silent); // 0x059bff44
	System.Boolean CheckPermissionByPartEx(WizardGames.Soc.Common.Construction.EPrivilegeType privilegeType, WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x059bf23c
	System.Boolean IsCoreConstruction(System.Int64 templateId); // 0x059bfea4
	System.Boolean IsCanPickUpConstruction(System.Int64 templateId); // 0x059c0088
	System.Boolean IsCanPickUpSpecific(WizardGames.Soc.Common.Entity.PartEntity part); // 0x059c0128
	System.Void HideEditUINoTarget(); // 0x059c0544
	System.Void TryRemoveAimedConstruction(); // 0x059c0634
	System.Void LogicUpdate(); // 0x059c0a4c
	System.Void RenderUpdate(); // 0x059c0b18
	System.Void LateUpdate(); // 0x059c0b78
	System.Void .ctor(System.Int32 modeId); // 0x059c0c64
	System.Void DoubleCheckConfirmRemove(); // 0x059c0d08
	System.Void DoubleCheckConfirmRotate(); // 0x059c0d7c
}

// Client.Runtime
class Config.RoleArchiveData : System.Object
{
	System.Int32 experienceGrade; // 0x10
	System.Boolean experienceGraded; // 0x14
	System.String[] privateServerTags; // 0x18
	System.String profileID; // 0x20
	System.UInt32 totalBattledSeconds; // 0x28
	System.Void SetRoleArchiveData(SimpleJSON.JSONNode jsonNode); // 0x059c0df0
	System.Void Clear(); // 0x059c0fc4
	System.Void .ctor(); // 0x059c106c
}

// Client.Runtime
struct Config.SexInfo : System.ValueType
{
	System.Int32 faceID; // 0x10
	System.Int32 hairID; // 0x14
	System.Int32 hairColorID; // 0x18
	
}

// Client.Runtime
class Config.LobbyRoleInfo : System.Object
{
	static SocLogger logger; // 0x0
	System.Int32 teamStatus; // 0x10
	System.String openID; // 0x18
	System.Int32 battleGameMode; // 0x20
	System.Int64 createTime; // 0x28
	System.Int64 exp; // 0x30
	System.Int32 faceID; // 0x38
	System.Int32 hairColorID; // 0x3c
	System.Int32 hairID; // 0x40
	System.Int64 lastlogintime; // 0x48
	System.Int64 lastlogouttime; // 0x50
	System.Int32 level; // 0x58
	System.Int64 levelMaxExp; // 0x60
	System.String nickName; // 0x68
	System.Int32 onlineStatus; // 0x70
	System.String roleId; // 0x78
	System.Int32 sex; // 0x80
	System.Int32 nameCardId; // 0x84
	System.Collections.Generic.List<System.Int32> personalTags; // 0x88
	System.Int32 portraitFrameId; // 0x90
	System.String portraitStr; // 0x98
	System.Collections.Generic.List<System.Int32> gameStyleIDs; // 0xa0
	System.Int32 suitPlan; // 0xa8
	System.Int32 weaponPlan; // 0xac
	System.Boolean completedNewbieTutorial; // 0xb0
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> styleRankPoints; // 0xb8
	Config.EUserPrivacy userPrivacy; // 0xc0
	System.Boolean deleted; // 0xc4
	System.Int32 seasonId; // 0xc8
	System.Boolean seasonUnlocked; // 0xcc
	System.Int32 seasonPoints; // 0xd0
	System.String lampGroupID; // 0xd8
	System.Int32 lampLevel; // 0xe0
	System.String lampTitle; // 0xe8
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> roleAppPrivileges; // 0xf0
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> roleBonusCards; // 0xf8
	System.UInt64 communityID; // 0x100
	System.Collections.Generic.Dictionary<System.Int32,Config.SexInfo> sexInfo; // 0x108
	System.String get_Portrait(); // 0x059c10d4
	System.Void set_Portrait(System.String value); // 0x059c12c0
	System.Int32 get_PortraitFrame(); // 0x059c1340
	System.Void set_PortraitFrame(System.Int32 value); // 0x059c14c4
	System.Int32 get_NameCard(); // 0x059c153c
	System.Void set_NameCard(System.Int32 value); // 0x059c16c0
	System.UInt64 get_RoleId(); // 0x059c1738
	System.Void .ctor(); // 0x059c17c0
	System.Void .ctor(SimpleJSON.JSONNode jsonNode); // 0x059c1920
	System.Void SetLobbyRoleInfo(SimpleJSON.JSONNode jsonNode); // 0x059c1a94
	System.Void Clear(); // 0x059c3770
	System.Void PraseRolePlayerAbstract(SimpleJSON.JSONNode appearance); // 0x059c3514
	System.Void PraseRoleAppPrivileges(SimpleJSON.JSONNode privilegeNode); // 0x059c2a78
	System.Void UpdateRoleAppPrivilege(System.Int32 id, System.Int32 expireTime); // 0x059c3a58
	System.Boolean GetRoleAppPrivilegeStateToId(System.Int32 id, WizardGames.Soc.Common.Data.EChannelFunctionType functionType); // 0x059c3b74
	System.Void PraseGameStyleIds(SimpleJSON.JSONNode styleNode); // 0x059c27d4
	System.Void PraseStyleRankPoints(SimpleJSON.JSONNode nodeDic); // 0x059c28a4
	System.Void ApplyStyleRankPoints(System.Collections.Generic.Dictionary<System.Int32,System.Int32> newStylePointMap); // 0x059c3ed4
	System.Void ApplySeasonPoints(System.Int32 seasonPoint); // 0x059c40c8
	System.Boolean get_UseChannelPortrait(); // 0x059c4180
	static System.Collections.Generic.List<System.Int32> ConvertJsonArrayToList(SimpleJSON.JSONArray jsonArray); // 0x059c2654
	System.Void PraseRoleBonusCards(SimpleJSON.JSONNode bonusNode); // 0x059c3038
	System.Void UpdateRoleBonusCards(System.Int32 bonusId, System.Int32 expireTime); // 0x059c420c
	System.Boolean GeteRoleBonusCardStateToId(System.Int32 id); // 0x059c4328
	System.Boolean IsExistRoleLowExpBonusCard(System.Int32 expCardId); // 0x059c4424
	System.Boolean IsExistRoleLowMedalBonusCard(System.Int32 medalCardId); // 0x059c47ec
	System.Void Copy(Config.LobbyRoleInfo info); // 0x059c4bcc
	static System.Void .cctor(); // 0x059c4eb4
}

// Client.Runtime
enum Config.EUserPrivacy : System.Enum
{
	System.Int32 value__; // 0x10
	static Config.EUserPrivacy None = 0;
	static Config.EUserPrivacy FriendRequest = 1;
	static Config.EUserPrivacy TeamInvite = 2;
	static Config.EUserPrivacy Apponintment = 4;
	static Config.EUserPrivacy StrangerPrivateChat = 8;
	static Config.EUserPrivacy RankMedal = 16;
	static Config.EUserPrivacy AutoChangeTribeLamp = 32;
	static Config.EUserPrivacy QuestionnaireTypeA = 64;
	static Config.EUserPrivacy QuestionnaireTypeB = 128;
	static Config.EUserPrivacy QuestionnaireTypeC = 256;
	static Config.EUserPrivacy NewbieTeachingEntered = 512;
	static Config.EUserPrivacy PlayerTypeAFinishSelectMode = 1024;
	
}

// Client.Runtime
class Config.MgrConfig : WizardGames.Soc.Common.Manager.MgrBase
{
	SocLogger logger; // 0x18
	System.Boolean CameraShake; // 0x20
	System.Boolean DisplayKeyboardGuide; // 0x21
	System.Boolean IsSyncTime; // 0x22
	System.Boolean DebugHairMat; // 0x23
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> cachedRoleAppPrivileges; // 0x28
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> cachedRoleBonusCards; // 0x30
	System.Collections.Generic.HashSet<System.String> roleIds; // 0x38
	System.Collections.Generic.Dictionary<System.String,Config.MgrConfig.CachedPlayerInfo> localCache; // 0x40
	System.Collections.Generic.Dictionary<System.String,Config.MgrConfig.CachedPlayerInfo> tempLocalCache; // 0x48
	System.Collections.Generic.List<Config.MgrConfig.CallbackInfo> callbackList; // 0x50
	System.Collections.Generic.List<Config.MgrConfig.CallbackInfo> removeCallbackList; // 0x58
	System.Collections.Generic.HashSet<System.String> tempRoleIDList; // 0x60
	System.Boolean IsNeedShowLevelUpgrade; // 0x68
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> currencysDic; // 0x70
	System.Collections.Generic.Dictionary<System.String,SimpleJSON.JSONArray> resourceUpdateCache; // 0x78
	System.Boolean pullAllCurrency; // 0x80
	System.Int32 midasRefreshCount; // 0x84
	System.Int32 SelectedCharacterModelId; // 0x88
	System.String accountName; // 0x90
	System.String token; // 0x98
	System.String JoinToken; // 0xa0
	System.Boolean isNewUser; // 0xa8
	System.String serverName; // 0xb0
	System.String serverId; // 0xb8
	System.String pictureUrl; // 0xc0
	System.String nameSDK; // 0xc8
	Config.LobbyRoleInfo lobbyRoleInfo; // 0xd0
	Config.RoleArchiveData roleArchiveData; // 0xd8
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ELevelUpgradeStyle,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.LevelUpgradeInfo>> upgradeInfos; // 0xe0
	System.String MirrorID; // 0xe8
	System.Int32 chatBubble; // 0xf0
	System.Collections.Generic.List<Config.MgrConfig.ERoleAppPrivilegeType> roleCouldOwnAppPrivilegeTypes; // 0xf8
	System.Collections.Generic.Dictionary<Config.EBanType,Config.BanInfo> banInfos; // 0x100
	System.Collections.Generic.Dictionary<Config.EBanType,System.Int32> banErrorCode; // 0x108
	System.Boolean get_HasResUpdateCache(); // 0x059c4f88
	System.Void OnAccountLogined(); // 0x059c4ff4
	System.Int32 GetCurrencyAmountById(System.Int32 id); // 0x059c5064
	System.Void ReqAllcurrency(System.Action<SimpleJSON.JSONNode> callback); // 0x059c5180
	System.Void ReqCoinInfo(System.Int32[] currencyIds, System.Action<SimpleJSON.JSONNode> callback); // 0x059c5598
	System.Void RefreshMidas(); // 0x059c5930
	System.Void ResetMidasRefreshCount(); // 0x059c5b50
	System.Collections.Generic.IReadOnlyDictionary<System.Int32,System.Int32> CachedRoleAppPrivileges(); // 0x059c5be0
	System.Void UpdatePrivilegeInfo(SimpleJSON.JSONNode node); // 0x059c5c44
	System.Collections.Generic.IReadOnlyDictionary<System.Int32,System.Int32> CachedRoleBonusCards(); // 0x059c5fe0
	System.Void UpdateRoleBonusCardInfo(SimpleJSON.JSONNode node); // 0x059c6044
	System.Void RefreshCurrencysDic(SimpleJSON.JSONArray walletArray); // 0x059c634c
	System.Void AppendToResourceUpdateCache(SimpleJSON.JSONNode node); // 0x059c65d8
	System.Void ApplyResourceUpdateCache(); // 0x059c6bbc
	System.Void OnResourceUpdate(SimpleJSON.JSONNode node); // 0x059c6d9c
	System.Void RequestUserInfo(System.UInt64 roleID, WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action<Config.LobbyRoleInfo> handler); // 0x059c74c4
	System.Void RequestSelfRoleArchiveData(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule); // 0x059c7c6c
	System.Void RequestRoleArchiveData(System.String roleID, WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action<SimpleJSON.JSONNode> callback); // 0x059c7d98
	System.Void RequestUserInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action<SimpleJSON.JSONNode> callback, System.String roleID, System.Boolean immediateRequest, System.Action<SimpleJSON.JSONNode> errorCallBack); // 0x059c7668
	System.Void ReqChatBubble(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule); // 0x059c8418
	System.Void OpenUserPrivacy(Config.EUserPrivacy privacy); // 0x059c86d8
	System.Void CloseUserPrivacy(Config.EUserPrivacy privacy); // 0x059c876c
	System.Void SaveUserPrivacy(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Boolean forceSave, System.Action successCb); // 0x059c8800
	System.Boolean IsUserPrivacyOpen(Config.EUserPrivacy userPrivacy, Config.EUserPrivacy checkPrivacy, System.Boolean showTip, System.Boolean isFriend); // 0x059c8b68
	Config.EUserPrivacy get_QuestionnaireType(); // 0x059c8e9c
	System.Boolean get_IsNewbieTeachingEntered(); // 0x059c8f2c
	System.Void RemoveCallDataByRoleId(System.String roleId); // 0x059c8fa4
	System.Void RequestUserInfoList(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action<SimpleJSON.JSONArray> callback, System.String[] roleIds, System.Boolean immediateRequest); // 0x059c9240
	System.Void RequestUserInfoList(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action<SimpleJSON.JSONArray> callback, System.Collections.Generic.HashSet<System.String> roleIds, System.Boolean immediateRequest, System.Boolean useCache); // 0x059c93d0
	System.Void CheckCacheDataDead(); // 0x059c80d0
	System.Void ExecuteCallbacks(SimpleJSON.JSONNode playerInfo, System.String roleId); // 0x059c9c94
	System.Int32 get_ChatBubbleID(); // 0x059c9f24
	System.Void set_ChatBubbleID(System.Int32 value); // 0x059ca068
	System.Void OnAccountLogout(); // 0x059ca0e0
	System.Void ToggleCameraShake(); // 0x059ca2d4
	System.Void CleanUp(); // 0x059ca340
	System.Void AppendUpgradeInfo(WizardGames.Soc.SocClient.Ui.ELevelUpgradeStyle style, System.Int32 curLv, System.Int64 curExp, System.Int32 tarLv, System.Int64 tarExp, System.Int32 styleId); // 0x059ca3a8
	System.Void OnLevelAndExpChange(SimpleJSON.JSONNode jsonNode); // 0x059ca644
	System.Boolean CanVideoPlayInCurPerformance(System.Boolean showTips); // 0x059cae58
	System.Boolean CanTimelinePlayInCurPerformance(System.Boolean showTips); // 0x059cb460
	System.Boolean ChangeCachedPlayerInfo(System.String roleId, System.Action<SimpleJSON.JSONNode> callback); // 0x059cb64c
	System.Collections.Generic.List<Config.MgrConfig.ERoleAppPrivilegeType> GetRoleCouldOwnAppPrivilegeTypes(); // 0x059cb734
	System.Void InitRoleAppPrivilegeTypesList(); // 0x059cb7a0
	System.Boolean IsShowRoleAppPrivilegeLobbyIcon(); // 0x059cc058
	System.Boolean GetRoleAppPrivilegeStateToId(System.Int32 id); // 0x059cbd68
	Config.MgrConfig.ERoleAppPrivilegeType GetSkinWeaponRoleAppPrivilegeType(System.Int64 skinWeaponId); // 0x059cc2c4
	System.Void ReqSetPlatformLaunchPrivilege(System.Int32 platformLaunchType); // 0x059cc4f8
	System.Void OnSetPlatformLaunchPrivilege(SimpleJSON.JSONNode node); // 0x059cca64
	System.Void RegisterTencentPrivilegeMethod(System.Action qqAction, System.Action wechatAction, WizardGames.Soc.Common.Data.EChannelFunctionType qqFunction, WizardGames.Soc.Common.Data.EChannelFunctionType wechatFunciton); // 0x059ccb2c
	System.Boolean CheckQQPrivilege(System.Action qqAction, WizardGames.Soc.Common.Data.EChannelFunctionType qqFunction); // 0x059ccbe0
	System.Boolean CheckWechatPrivilege(System.Action wechatAction, WizardGames.Soc.Common.Data.EChannelFunctionType wechatFunciton); // 0x059cce34
	System.Boolean CheckChanel(WizardGames.Soc.Common.Data.EChannelFunctionType function, System.String channel); // 0x059cd088
	System.Boolean CheckQQChannel(WizardGames.Soc.Common.Data.EChannelFunctionType qqFunction, System.Boolean blockPC); // 0x059cd314
	System.Boolean CheckWechatChannel(WizardGames.Soc.Common.Data.EChannelFunctionType wechatFunciton, System.Boolean blockPC); // 0x059cd43c
	System.Boolean CheckChannelBlock(WizardGames.Soc.Common.Data.EChannelFunctionType funcitonType); // 0x059cc910
	Config.MgrConfig.EUIPlayCheckRes CanUIPlayInCurPerformance(Config.MgrConfig.EUIPlayType type); // 0x059cb044
	System.Void CheckBanInfo(Config.EBanType type, WizardGames.Soc.SocClient.Http.EHttpReqModule module, System.Boolean showBanTip, System.Action unBanAction, System.Action bannedAction); // 0x059cd564
	System.Void ShowBandTips(System.Int32 errorId, Config.BanInfo info); // 0x059cd940
	System.Boolean IsBanned(Config.BanInfo info); // 0x059cd858
	System.Void RequestBanInfo(Config.EBanType type, WizardGames.Soc.SocClient.Http.EHttpReqModule module, System.Action callback); // 0x059cda6c
	System.Void UpdateBanInfo(SimpleJSON.JSONNode node); // 0x059cdcd0
	Config.BanInfo GetBanInfo(Config.EBanType type); // 0x059ce114
	System.Void .ctor(); // 0x059ce1c8
	System.Void <RequestSelfRoleArchiveData>b__41_0(SimpleJSON.JSONNode jsonNode); // 0x059ce6e0
	System.Void <ReqSetPlatformLaunchPrivilege>b__91_0(SimpleJSON.JSONNode node); // 0x059ce860
}

// Client.Runtime
enum Config.MgrConfig.EUIPlayType : System.Enum
{
	System.Int32 value__; // 0x10
	static Config.MgrConfig.EUIPlayType Video = 0;
	static Config.MgrConfig.EUIPlayType Timeline = 1;
	
}

// Client.Runtime
enum Config.MgrConfig.EUIPlayCheckRes : System.Enum
{
	System.Int32 value__; // 0x10
	static Config.MgrConfig.EUIPlayCheckRes CanPlay = 0;
	static Config.MgrConfig.EUIPlayCheckRes QualityRefuse = 1;
	static Config.MgrConfig.EUIPlayCheckRes MemoryRefuse = 2;
	
}

// Client.Runtime
class Config.MgrConfig.CachedPlayerInfo : System.Object
{
	SimpleJSON.JSONNode playerInfo; // 0x10
	System.Single cachedTime; // 0x18
	System.Void .ctor(); // 0x059ce910
}

// Client.Runtime
struct Config.MgrConfig.CallbackInfo : System.ValueType
{
	System.Action<SimpleJSON.JSONNode> callback; // 0x10
	System.String roleId; // 0x18
	
}

// Client.Runtime
enum Config.MgrConfig.ERoleAppPrivilegeType : System.Enum
{
	System.Int32 value__; // 0x10
	static Config.MgrConfig.ERoleAppPrivilegeType None = 0;
	static Config.MgrConfig.ERoleAppPrivilegeType UniversityPrivilege = 1;
	static Config.MgrConfig.ERoleAppPrivilegeType NetBarPrivilege = 2;
	static Config.MgrConfig.ERoleAppPrivilegeType QQPrivilege = 3;
	static Config.MgrConfig.ERoleAppPrivilegeType WxPrivilege = 4;
	
}

// Client.Runtime
class Config.MgrConfig.<>c : System.Object
{
	static Config.MgrConfig.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__44_0; // 0x8
	static System.Void .cctor(); // 0x059ce978
	System.Void .ctor(); // 0x059ce9dc
	System.Void <ReqChatBubble>b__44_0(SimpleJSON.JSONNode node); // 0x059cea44
}

// Client.Runtime
class Config.MgrConfig.<>c__DisplayClass103_0 : System.Object
{
	Config.MgrConfig <>4__this; // 0x10
	Config.EBanType type; // 0x18
	System.Boolean showBanTip; // 0x1c
	System.Action bannedAction; // 0x20
	System.Action unBanAction; // 0x28
	System.Void .ctor(); // 0x059cd7f0
	System.Void <CheckBanInfo>b__0(); // 0x059cebb4
}

// Client.Runtime
class Config.MgrConfig.<>c__DisplayClass106_0 : System.Object
{
	Config.MgrConfig <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x059cdc68
	System.Void <RequestBanInfo>b__0(SimpleJSON.JSONNode node); // 0x059cecf0
}

// Client.Runtime
class Config.MgrConfig.<>c__DisplayClass26_0 : System.Object
{
	Config.MgrConfig <>4__this; // 0x10
	System.Action<SimpleJSON.JSONNode> callback; // 0x18
	System.Void .ctor(); // 0x059c5530
	System.Void <ReqAllcurrency>b__0(SimpleJSON.JSONNode node); // 0x059ced9c
}

// Client.Runtime
class Config.MgrConfig.<>c__DisplayClass27_0 : System.Object
{
	Config.MgrConfig <>4__this; // 0x10
	System.Action<SimpleJSON.JSONNode> callback; // 0x18
	System.Void .ctor(); // 0x059c58c8
	System.Void <ReqCoinInfo>b__0(SimpleJSON.JSONNode node); // 0x059cf0ac
}

// Client.Runtime
class Config.MgrConfig.<>c__DisplayClass40_0 : System.Object
{
	System.Action<Config.LobbyRoleInfo> handler; // 0x10
	System.Void .ctor(); // 0x059c7600
	System.Void <RequestUserInfo>b__0(SimpleJSON.JSONNode jsonNode); // 0x059cf3ac
}

// Client.Runtime
class Config.MgrConfig.<>c__DisplayClass42_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> callback; // 0x10
	System.Void .ctor(); // 0x059c8000
	System.Void <RequestRoleArchiveData>b__0(SimpleJSON.JSONNode ret); // 0x059cf474
}

// Client.Runtime
class Config.MgrConfig.<>c__DisplayClass43_0 : System.Object
{
	Config.MgrConfig <>4__this; // 0x10
	System.String roleID; // 0x18
	System.Action<SimpleJSON.JSONNode> errorCallBack; // 0x20
	System.Void .ctor(); // 0x059c8068
	System.Void <RequestUserInfo>b__0(SimpleJSON.JSONNode response); // 0x059cf538
	System.Void <RequestUserInfo>b__1(SimpleJSON.JSONNode json); // 0x059cf93c
}

// Client.Runtime
class Config.MgrConfig.<>c__DisplayClass47_0 : System.Object
{
	System.Action successCb; // 0x10
	System.Void .ctor(); // 0x059c8b00
	System.Void <SaveUserPrivacy>b__0(SimpleJSON.JSONNode node); // 0x059cf9dc
}

// Client.Runtime
class Config.MgrConfig.<>c__DisplayClass55_0 : System.Object
{
	Config.MgrConfig <>4__this; // 0x10
	System.Action<SimpleJSON.JSONArray> callback; // 0x18
	SimpleJSON.JSONArray oldJsonArray; // 0x20
	System.Collections.Generic.Dictionary<System.String,System.Int32> roleIdMap; // 0x28
	System.Void .ctor(); // 0x059c9c2c
	System.Void <RequestUserInfoList>b__0(SimpleJSON.JSONNode res); // 0x059cfa74
}

// Client.Runtime
class Config.MgrConfig.<>c__DisplayClass79_0 : System.Object
{
	WizardGames.Soc.Common.Data.common.OBJPlayerLevel lvCfg; // 0x10
	System.Void .ctor(); // 0x059cadf0
	System.Void <OnLevelAndExpChange>b__0(); // 0x059d003c
}

// Client.Runtime
class Config.BanInfo : System.Object
{
	System.Int64 EndTime; // 0x10
	System.Int32 Reason; // 0x18
	System.Int64 UpdateTime; // 0x20
	Config.EBanType BanType; // 0x28
	System.Void .ctor(); // 0x059ce0ac
}

// Client.Runtime
enum Config.EBanType : System.Enum
{
	System.Int32 value__; // 0x10
	static Config.EBanType BanTypeSetPortrait = 6;
	static Config.EBanType BanTypeEditProfile = 7;
	static Config.EBanType BanTypeSocialTeamInvited = 10;
	static Config.EBanType BanTypeSocialTeamRecruitment = 11;
	static Config.EBanType BanTypeSearch = 12;
	static Config.EBanType BanTypeBuild = 13;
	static Config.EBanType BanTypeUserGroup = 14;
	
}

// Client.Runtime
class Config.MgrDebugConfig : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Boolean _debugPlayer; // 0x11
	System.Boolean get_DebugPlayer(); // 0x059d0150
	System.Void .ctor(); // 0x059d01b4
}

// Client.Runtime
struct Mathd.Matrix4x4d : System.ValueType
{
	System.Double m00; // 0x10
	System.Double m01; // 0x18
	System.Double m02; // 0x20
	System.Double m03; // 0x28
	System.Double m10; // 0x30
	System.Double m11; // 0x38
	System.Double m12; // 0x40
	System.Double m13; // 0x48
	System.Double m20; // 0x50
	System.Double m21; // 0x58
	System.Double m22; // 0x60
	System.Double m23; // 0x68
	System.Double m30; // 0x70
	System.Double m31; // 0x78
	System.Double m32; // 0x80
	System.Double m33; // 0x88
	System.Double get_Item(System.Int32 index); // 0x059d021c
	System.Void set_Item(System.Int32 index, System.Double value); // 0x059d0378
	System.Void set_Item(System.Int32 row, System.Int32 column, System.Double value); // 0x059d04e8
	static Mathd.Matrix4x4d get_identity(); // 0x059d0584
	static Mathd.Matrix4x4d TRS(Mathd.Vector3d pos, Mathd.Quaterniond q, Mathd.Vector3d s); // 0x059d0664
	Mathd.Vector4d GetColumn(System.Int32 i); // 0x059d0c80
	System.String ToString(); // 0x059d0e74
	System.Int32 GetHashCode(); // 0x059d141c
	System.Boolean Equals(System.Object other); // 0x059d1608
	static Mathd.Matrix4x4d op_Multiply(Mathd.Matrix4x4d lhs, Mathd.Matrix4x4d rhs); // 0x059d1904
	static System.Boolean op_Equality(Mathd.Matrix4x4d lhs, Mathd.Matrix4x4d rhs); // 0x059d16f8
}

// Client.Runtime
struct Mathd.Quaterniond : System.ValueType
{
	System.Double x; // 0x10
	System.Double y; // 0x18
	System.Double z; // 0x20
	System.Double w; // 0x28
	System.Void .ctor(System.Double p_x, System.Double p_y, System.Double p_z, System.Double p_w); // 0x059d1bc0
	System.String ToString(); // 0x059d1c60
	System.Int32 GetHashCode(); // 0x059d1e78
	System.Boolean Equals(System.Object other); // 0x059d1f64
	static Mathd.Matrix4x4d QuaternionToMatrix(Mathd.Quaterniond quat); // 0x059d0970
	static System.Boolean op_Equality(Mathd.Quaterniond lhs, Mathd.Quaterniond rhs); // 0x059d2054
}

// Client.Runtime
struct Mathd.Vector3d : System.ValueType
{
	System.Double x; // 0x10
	System.Double y; // 0x18
	System.Double z; // 0x20
	System.Void .ctor(System.Double p_x, System.Double p_y, System.Double p_z); // 0x059d213c
	System.Double get_Item(System.Int32 index); // 0x059d0b9c
	System.String ToString(); // 0x059d21d4
	System.Int32 GetHashCode(); // 0x059d22d4
	System.Boolean Equals(System.Object other); // 0x059d2398
	static System.Boolean op_Equality(Mathd.Vector3d lhs, Mathd.Vector3d rhs); // 0x059d2484
	static Mathd.Vector3d op_Implicit(UnityEngine.Vector3 v); // 0x059d2548
	static UnityEngine.Vector3 op_Implicit(Mathd.Vector3d v); // 0x059d25f0
}

// Client.Runtime
struct Mathd.Vector4d : System.ValueType
{
	System.Double x; // 0x10
	System.Double y; // 0x18
	System.Double z; // 0x20
	System.Double w; // 0x28
	System.Void .ctor(System.Double p_x, System.Double p_y, System.Double p_z, System.Double p_w); // 0x059d0dd4
	System.String ToString(); // 0x059d2678
	System.Int32 GetHashCode(); // 0x059d151c
	System.Boolean Equals(System.Object other); // 0x059d2890
	static System.Boolean op_Equality(Mathd.Vector4d lhs, Mathd.Vector4d rhs); // 0x059d1ad8
}

// Client.Runtime
class Systems.EnhancedDisplayBase : System.Object
{
	Systems.EnhancedDisplayUnitData data; // 0x10
	System.Void .ctor(); // 0x059d2980
	System.Void Init(System.Int64 entityId); // 0x059d2a20
	System.Void Clear(); // 0x059d2aac
	System.Void RemoveOutline(); // 0x059d2b2c
	System.Void RemoveDot(); // 0x059d3000
	Systems.EnhancedDisplayUnitData GetData(); // 0x059d30a0
	System.Void CloseAllEffect(); // 0x059d3104
	System.Void Update(System.Int32 dt); // 0x055056e8
}

// Client.Runtime
class Systems.EnhancedDisplayCommon : Systems.EnhancedDisplayBase
{
	
	System.Void Update(System.Int32 dt); // 0x059d31e0
	System.Boolean CanShowDot(); // 0x059d338c
	System.Void .ctor(); // 0x059d3484
}

// Client.Runtime
class Systems.EnhancedDisplayCorpse : Systems.EnhancedDisplayBase
{
	System.Int64 corpseEntityId; // 0x18
	System.Void Init(System.Int64 entityId); // 0x059d34e8
	System.Void Clear(); // 0x059d35f4
	System.Void Update(System.Int32 dt); // 0x059d3660
	System.Boolean CanShowDot(); // 0x059d3874
	System.Void .ctor(); // 0x059d390c
}

// Client.Runtime
enum Systems.EdgesType : System.Enum
{
	System.Int32 value__; // 0x10
	static Systems.EdgesType Normal = 0;
	static Systems.EdgesType CombatMarker = 1;
	
}

// Client.Runtime
class Systems.EnhancedDisplayEffect : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Collections.Generic.Dictionary<Systems.EdgesType,System.ValueTuple<System.String,System.Single,System.Single>>> goEdgesTypeParams; // 0x8
	static System.Collections.Generic.List<UnityEngine.Renderer> renderersCacheList; // 0x10
	static UnityEngine.Renderer[] GetFilteredRenderers(UnityEngine.Transform parent); // 0x059d3970
	static System.Boolean ShouldExcludedOutline(UnityEngine.Transform transform); // 0x059d3f04
	static System.Void TryAddOutlineComponent(UnityEngine.GameObject mainGo); // 0x059d40cc
	static System.Void EnableOutline(UnityEngine.GameObject mainGo, System.String colorStr, System.Single boldness, System.Single opacity, Systems.EdgesType edgesType, System.Single blurShift); // 0x059d423c
	static System.Void EnableOutlineWithoutGo(WizardGames.Soc.Common.Entity.PartEntity partEntity, System.String colorStr, System.Single boldness, System.Single opacity, System.Single blurShift); // 0x059d4f0c
	static System.Void DisableOutlineWithoutGo(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x059d5188
	static System.Void SetOutlinableParams(EPOOutline.Outlinable outlinable, System.String colorStr, System.Single boldness, System.Single opacity, System.Single blurShift); // 0x059d4b7c
	static System.Void SetConstructionMeshRenderStateTrue(EPOOutline.Outlinable outlinable); // 0x059d5274
	static System.Void ResetConstructionMeshRenderStateFalse(EPOOutline.Outlinable outlinable); // 0x059d55c4
	static System.Void DisableOutline(UnityEngine.GameObject mainGo, Systems.EdgesType edgesType); // 0x059d2c30
	static System.Void AddOutlineComponent(UnityEngine.GameObject mainGo, System.Boolean isEliminateFx); // 0x059d59dc
	static System.Void RendererParser(UnityEngine.GameObject mainGo); // 0x059d5eb4
	static System.Void Clear(); // 0x059d60b0
	static System.Single CalculatedBrightness(System.Single brightnessNight); // 0x059d6158
	static UnityEngine.Color HexToColor(System.String hex); // 0x059d504c
	static System.Void .cctor(); // 0x059d624c
}

// Client.Runtime
class Systems.EnhancedDisplayEffect.<>c__DisplayClass8_0 : System.Object
{
	System.Collections.Generic.HashSet<UnityEngine.Transform> excludedTransforms; // 0x10
	System.Void .ctor(); // 0x059d3e9c
	System.Boolean <GetFilteredRenderers>b__0(UnityEngine.Renderer r); // 0x059d63d0
}

// Client.Runtime
class Systems.EnhancedDisplayHandle : System.Object
{
	static System.Collections.Generic.List<System.Int64> _dotEntityIdListTemp; // 0x0
	static System.Collections.Generic.HashSet<System.Int64> _entityCanShowDotCacheTemp; // 0x8
	static System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int64>> stepDotEntityIdListData; // 0x10
	static System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.HashSet<System.Int64>> stepEntityCanShowDotCacheData; // 0x18
	static System.Collections.Generic.List<System.Int64> outlineEntityIdList; // 0x20
	static System.Collections.Generic.HashSet<System.Int64> entityCanShowOutlineCache; // 0x28
	static System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PartEntity> partEntityMap; // 0x30
	static System.Int32 UpdateEnhancedDisplayEntityIdStepIndex; // 0x38
	static System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<WizardGames.Soc.Common.Profile.EProfileFunc,System.Action>> UpdateEnhancedDisplayEntityIdSteps; // 0x40
	static System.Action<WizardGames.Soc.Common.Entity.IEntity> checkEntity; // 0x48
	static System.Action<WizardGames.Soc.Common.Entity.BoxEntity> checkBoxEntity; // 0x50
	static System.Action<WizardGames.Soc.Common.Entity.ElevatorEntity> checkElevatorEntity; // 0x58
	static System.Action<WizardGames.Soc.Common.Entity.IEntity> checkVehicleEntity; // 0x60
	static System.Action<WizardGames.Soc.Common.Entity.SceneItemEntity> checkSceneItemEntity; // 0x68
	static System.Action<WizardGames.Soc.Common.Entity.IOEntity> checkIOEntity; // 0x70
	static System.Action<WizardGames.Soc.Common.Entity.PartEntity> checkPartEntity; // 0x78
	static System.Action<WizardGames.Soc.Common.Entity.DigEntity> checkDigEntity; // 0x80
	static System.Collections.Generic.List<System.Int64> get_DotEntityIdList(); // 0x059d6480
	static System.Collections.Generic.HashSet<System.Int64> get_EntityCanShowDotCache(); // 0x059d67d4
	static System.Collections.Generic.List<System.Int64> get_DotEntityIdListTemp(); // 0x059d64fc
	static System.Collections.Generic.HashSet<System.Int64> get_EntityCanShowDotCacheTemp(); // 0x059d6850
	static System.Collections.Generic.List<System.Int64> GetDotEntityIdListByStep(); // 0x059d6ba0
	static System.Collections.Generic.HashSet<System.Int64> GetEntityCanShowDotCacheByStep(); // 0x059d6d28
	static System.Void ClearStepData(); // 0x059d6eb0
	static System.Void CollectTreeEntity(); // 0x059d7070
	static System.Void CollectBoxAndOreEntity(); // 0x059d712c
	static System.Void CollectCollectableAndSceneItemEntity(); // 0x059d7288
	static System.Void CollectIOAndPartEntity(); // 0x059d7394
	static System.Void CollectCorpseAndDigEntity(); // 0x059d74d4
	static System.Void CollectVehicle(); // 0x059d75e0
	static System.Void SyncTmpDataToEnhancedDisplayEntityIds(); // 0x059d7864
	static System.Collections.Generic.Dictionary<System.Int64,T> GetEntities<T>(); // 0x052af1f0
	static System.Void UpdateAllEnhancedDisplayEntityIds(); // 0x059d78bc
	static System.Void CollectEntities<T>(System.Collections.Generic.Dictionary<System.Int64,T> entityMap, System.Action<T> checkEntityAction); // 0x052af1f0
	static System.Void CheckDistanceAndAddData(System.Int64 entityId, System.Int32 highLightId); // 0x059d7a90
	static System.Boolean CheckMountState(System.Int64 entityId); // 0x059d7f60
	static System.Boolean IsTrainCarMoving(WizardGames.Soc.Common.Entity.TrainCarEntity trainCarEntity); // 0x059d8300
	static System.Void CheckEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x059d8380
	static System.Void CheckBoxEntity(WizardGames.Soc.Common.Entity.BoxEntity boxEntity); // 0x059d8540
	static System.Void CheckElevatorEntity(WizardGames.Soc.Common.Entity.ElevatorEntity elevatorEntity); // 0x059d8790
	static System.Void CheckVehicleEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x059d8a3c
	static System.Void CheckSceneItemEntity(WizardGames.Soc.Common.Entity.SceneItemEntity sceneItemEntity); // 0x059d8bb8
	static System.Void CheckIOEntity(WizardGames.Soc.Common.Entity.IOEntity ioEntity); // 0x059d8da8
	static System.Void CheckPartEntity(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x059d8f9c
	static System.Boolean PartEntityFilter(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x059d9050
	static System.Void CheckDigEntity(WizardGames.Soc.Common.Entity.DigEntity digEntity); // 0x059d9150
	static System.Void UpdateAllOutlineEntityIds(); // 0x059d930c
	static System.Boolean GetRelicDotEntityIds<T>(T entity, System.Boolean isDistanceCheck); // 0x052af1f0
	static System.Boolean DotDistanceCheck(System.Int64 entityId, System.Int32 highLightConfigId); // 0x059d7bc0
	static System.Boolean OutlineDistanceCheck(System.Int64 entityId, System.Int32 highLightConfigId, UnityEngine.GameObject outlineMainGo); // 0x059da1f4
	static System.Boolean CanShowDot(System.Int64 entityId); // 0x059d2f54
	static System.Boolean CanShowOutline(System.Int64 entityId); // 0x059da140
	static System.ValueTuple<System.Int32,System.Single> DotIdHandle(WizardGames.Soc.Common.Entity.IEntity entity); // 0x059da5dc
	static System.ValueTuple<System.Int32,System.Single> BoxEntityDotIdHandle(WizardGames.Soc.Common.Entity.BoxEntity boxEntity); // 0x059daef0
	static System.ValueTuple<System.Int32,System.Single> TreeEntityDotIdHandle(WizardGames.Soc.Common.Entity.TreeEntity treeEntity); // 0x059db048
	static System.ValueTuple<System.Int32,System.Single> OreEntityDotIdHandle(WizardGames.Soc.Common.Entity.OreEntity oreEntity); // 0x059db1a0
	static System.ValueTuple<System.Int32,System.Single> CollectableEntityDotIdHandle(WizardGames.Soc.Common.Entity.CollectableEntity collectableEntity); // 0x059db2f8
	static System.ValueTuple<System.Int32,System.Single> CorpseEntityDotIdHandle(WizardGames.Soc.Common.Entity.CorpseEntity corpseEntity); // 0x059db450
	static System.ValueTuple<System.Int32,System.Single> SceneItemEntityDotIdHandle(); // 0x059d8c98
	static System.ValueTuple<System.Int32,System.Single> IOEntityDotIdHandle(WizardGames.Soc.Common.Entity.IOEntity ioEntity); // 0x059db6e4
	static System.ValueTuple<System.Int32,System.Single> KatyushaEntityDotIdHandle(WizardGames.Soc.Common.Entity.KatyushaEntity katyushaEntity); // 0x059db954
	static System.ValueTuple<System.Int32,System.Single> ElevatorEntityDotIdHandle(WizardGames.Soc.Common.Entity.ElevatorEntity elevatorEntity); // 0x059dbaac
	static System.ValueTuple<System.Int32,System.Single> VehicleEntityDotIdHandle(WizardGames.Soc.Common.Entity.VehicleEntity vehicleEntity); // 0x059dbc04
	static System.ValueTuple<System.Int32,System.Single> HorseEntityDotIdHandle(WizardGames.Soc.Common.Entity.HorseEntity horseEntity); // 0x059dbd5c
	static System.ValueTuple<System.Int32,System.Single> CarEntityDotIdHandle(WizardGames.Soc.Common.Entity.CarEntity carEntity); // 0x059dbeb4
	static System.ValueTuple<System.Int32,System.Single> ModularCarEntityDotIdHandle(WizardGames.Soc.Common.Entity.ModularCarEntity modularCarEntity); // 0x059dc048
	static System.ValueTuple<System.Int32,System.Single> TrainCarEntityDotIdHandle(WizardGames.Soc.Common.Entity.TrainCarEntity trainCarEntity); // 0x059dc1a0
	static System.ValueTuple<System.Int32,System.Single> RelicDotIdHandle(System.Int64 templateId); // 0x059db5a8
	static System.Int32 ThrownEntityDotIdHandle(WizardGames.Soc.Common.Entity.ThrownEntity throwEntity); // 0x059db83c
	static System.Boolean OutlinePlatformCheck(System.Int64 entityId); // 0x059d5210
	static System.Void .cctor(); // 0x059dc2f8
}

// Client.Runtime
class Systems.EnhancedDisplayMonumentIO : Systems.EnhancedDisplayBase
{
	
	System.Void Update(System.Int32 dt); // 0x05b49a6c
	System.Boolean CanShowDot(System.Int64 templateId); // 0x05b4a1dc
	System.Boolean CanShowDotExt(System.Int64 templateId); // 0x05b4a2b0
	System.Void .ctor(); // 0x05b4a504
}

// Client.Runtime
class Systems.EnhancedDisplayOutlineBed : Systems.EnhancedDisplayBase
{
	
	System.Single get_Range(); // 0x05b4a56c
	System.Void Init(System.Int64 entityId); // 0x05b4a654
	System.Void Update(System.Int32 dt); // 0x05b4a6f0
	System.Boolean IsFocused(System.Int64 curEyeTemplateId); // 0x05b4aa98
	System.Boolean IsWithinRangeOfEntity(); // 0x05b4ab24
	System.Void EnableOutlineIfNeeded(); // 0x05b4ae3c
	System.Void DisableOutlineIfEnabled(); // 0x05b4a9e0
	System.Int64 GetCurEyeTemplateId(System.Int64 curRayEntityId); // 0x05b4a8a4
	System.Void .ctor(); // 0x05b4b0f4
}

// Client.Runtime
class Systems.EnhancedDisplayOutlineBomb : Systems.EnhancedDisplayBase
{
	
	System.Void Update(System.Int32 dt); // 0x05b4b15c
	System.Boolean CanShowOutline(); // 0x05b4b2f8
	System.Void .ctor(); // 0x05b4b670
}

// Client.Runtime
class Systems.EnhancedDisplayOutlineCommon : Systems.EnhancedDisplayBase
{
	
	System.Void Init(System.Int64 entityId); // 0x05b4b6d8
	System.Void Update(System.Int32 dt); // 0x05b4b774
	System.Boolean CanShowOutline(System.Boolean useCache); // 0x05b4b8fc
	System.Void .ctor(); // 0x05b4bbe0
}

// Client.Runtime
class Systems.EnhancedDisplayOutlineData : System.Object
{
	System.Int64 entityId; // 0x10
	System.Int64 entityTypeId; // 0x18
	UnityEngine.GameObject mainGo; // 0x20
	UnityEngine.Renderer[] renderersCache; // 0x28
	UnityEngine.GameObject get_MainGo(); // 0x05b4bc48
	System.Void set_MainGo(UnityEngine.GameObject value); // 0x05b4bcac
	System.Void .ctor(); // 0x05b4be60
	System.Void OnSkinGoLoaded(); // 0x05b4bedc
	System.Void CollectRenderers(EPOOutline.Outlinable outlinable); // 0x05b4c0c0
	System.Void SetCutout(EPOOutline.Outlinable outlinable); // 0x05b4c1ac
	System.Void SetOutLine(); // 0x05b4bd34
	System.Void CacheOutlineRenderers(); // 0x05b4c674
	System.Void OutlineNotifyGo(System.Boolean enable); // 0x05b4c554
	System.Void Clear(); // 0x05b4c780
}

// Client.Runtime
class Systems.EnhancedDisplayOutlinePlayer : Systems.EnhancedDisplayBase
{
	
	System.Void Init(System.Int64 entityId); // 0x05b4c80c
	System.Void Update(System.Int32 dt); // 0x05b4cab8
	System.Void .ctor(); // 0x05b4ce08
}

// Client.Runtime
class Systems.EnhancedDisplaySpawn : Systems.EnhancedDisplayBase
{
	
	System.Void SetMainGo(UnityEngine.GameObject go); // 0x05b4ce70
	System.Void Update(System.Int32 dt); // 0x05b4cf0c
	System.Boolean CanShowDot(); // 0x05b4d0b4
	System.Void .ctor(); // 0x05b4d3ec
}

// Client.Runtime
class Systems.EnhancedDisplayTipData : System.Object
{
	System.Collections.Generic.List<System.Int64> outlineEntityIdList; // 0x10
	System.Collections.Generic.List<System.Int64> emptyEntityIdList; // 0x18
	System.Boolean open; // 0x20
	System.Collections.Generic.List<System.Int64> get_DotEntityIdList(); // 0x05b4d454
	System.Collections.Generic.List<System.Int64> get_OutlineEntityIdList(); // 0x05b4d4f4
	System.Void .ctor(); // 0x05b4db10
	System.Void Clear(); // 0x05b4dc04
	System.Collections.Generic.List<System.Int64> GetOutlineEntityIdList(); // 0x05b4d558
}

// Client.Runtime
class Systems.EnhancedDisplayUnitData : System.Object
{
	WizardGames.Soc.Common.Data.tips.HighLightConfig dotData; // 0x10
	System.Int64 entityId; // 0x18
	System.Int32 entityTypeId; // 0x20
	UnityEngine.GameObject mainGo; // 0x28
	System.Boolean isChildGo; // 0x30
	Systems.DisplayState displayState; // 0x34
	System.Int32 dotId; // 0x38
	System.Single heightOffset; // 0x3c
	System.Int32 outlineId; // 0x40
	System.Boolean isOutline; // 0x44
	System.Action<WizardGames.Soc.SocClient.Ui.EnhancedTip> ShowTipCallback; // 0x48
	WizardGames.Soc.Common.Data.tips.HighLightConfig get_DotData(); // 0x05b4dc8c
	System.Int32 get_DotLowerRangeSquared(); // 0x05b4d2d4
	System.Int32 get_DotUpperRangeSquared(); // 0x05b4d350
	System.Int32 get_OutlineLowerRangeSquared(); // 0x05b4b538
	System.Int32 get_OutlineUpperRangeSquared(); // 0x05b4b5d4
	System.Single get_Brightness(); // 0x05b4dd8c
	System.Single get_BrightnessNight(); // 0x05b4de30
	System.String get_DotIconUrl(); // 0x05b4dec8
	System.Boolean get_CanCovered(); // 0x05b4df3c
	WizardGames.Soc.Common.Data.tips.OutlineConfig get_OutlineConfig(); // 0x05b4dfb8
	System.String get_OutlineColor(); // 0x05b4af40
	System.Single get_OutlineBoldness(); // 0x05b4afe4
	System.Single get_OutlineOpacity(); // 0x05b4b06c
	System.Void Init(System.Int64 entityId, System.Boolean isCustomOutlineId); // 0x05b49c9c
	System.Void Clear(); // 0x05b4e0a4
	System.Void .ctor(); // 0x05b4e14c
}

// Client.Runtime
enum Systems.DisplayState : System.Enum
{
	System.Int32 value__; // 0x10
	static Systems.DisplayState None = 0;
	static Systems.DisplayState Dot = 1;
	
}

// Client.Runtime
class Systems.MgrEnhancedDisplayTip : WizardGames.Soc.Common.Manager.MgrBase
{
	Systems.EnhancedDisplayTipData data; // 0x18
	System.Collections.Generic.List<System.Int64> tempRemoveIdList; // 0x20
	System.Boolean isEnterWorld; // 0x28
	System.Boolean isInteractiveListEnable; // 0x29
	System.Int64 curEyeEntityId; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PartEntity> entityFilterMap; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,Systems.EnhancedDisplayBase> dotTipDic; // 0x40
	System.Collections.Generic.Dictionary<UnityEngine.GameObject,Systems.EnhancedDisplayBase> dotTipGoDic; // 0x48
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<UnityEngine.GameObject>> enhancedDisplayEntityIdToGoDic; // 0x50
	System.Collections.Generic.Dictionary<System.Int64,Systems.EnhancedDisplayBase> outlineTipDic; // 0x58
	Systems.EnhancedDisplayOutlineData outlineData; // 0x60
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x05b4e1bc
	System.Threading.Tasks.Task OnExitWorld(); // 0x05b4e2cc
	System.Void OnFps10Update(System.Int32 dt); // 0x05b4e938
	System.Void SetDisplayOpen(System.Boolean open); // 0x05b4f58c
	System.Void OnAddEntity(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean local); // 0x05b5066c
	System.Void OnRemoveEntity(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean local); // 0x05b507e8
	System.Void GetPartEntityFilterMap(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PartEntity>& entityFilterMap); // 0x05b5092c
	System.Void UpdateInteractiveListEnable(System.Boolean enable); // 0x05b509ac
	System.Void UpdateInteractiveListEyeEntityId(System.Int64 entityId); // 0x05b50a34
	System.Boolean IsInteractiveEntity(System.Int64 entityId); // 0x05b50ab8
	System.Boolean IsInBlackList(WizardGames.Soc.Common.Entity.IEntity entity, System.Int64 templateId); // 0x05b50b88
	System.Boolean IsInBlackList(System.Int32 highLightId, System.Int64 templateId); // 0x05b50d08
	System.Int32 GetHighLightIdByEntityId(System.Int64 entityId); // 0x05b50e50
	System.Void RemoveAllDotTip(); // 0x05b4e698
	System.Void UpdateDot(System.Int32 dt); // 0x05b4ea0c
	System.Void AddDot(System.Int64 entityId); // 0x05b51a60
	System.Void RemoveDot(System.Int64 entityId); // 0x05b5174c
	System.Void RemoveDotDisplay(Systems.EnhancedDisplayBase removeBase); // 0x05b52830
	System.Boolean SpawnEntityCheck(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05b5219c
	System.Collections.Generic.Dictionary<System.Int64,Systems.EnhancedDisplayBase> GetDotTipDic(); // 0x05b52ad4
	System.Void RemoveAllOutlineTip(); // 0x05b4e7e8
	System.Void OnSkinGoLoaded(System.Int64 entityId); // 0x05b52e9c
	System.Void OnResetOutline(); // 0x05b52f3c
	System.Boolean IsOutlineEnable(); // 0x05b4ba44
	System.Void UpdateOutline(System.Int32 dt); // 0x05b4f0dc
	System.Void AddOutline(System.Int64 entityId); // 0x05b52fdc
	System.Void RemoveOutline(System.Int64 entityId); // 0x05b52b38
	System.Void EnableOutline(System.Int64 entityId); // 0x05b4f6c0
	System.Void EnableOutlineForGo(System.Int64 entityId, UnityEngine.GameObject go); // 0x05b5360c
	WizardGames.Soc.Common.Data.tips.HighLightConfig GetOutlineConfigByEntityId(System.Int64 entityId); // 0x05b53404
	WizardGames.Soc.Common.Data.tips.OutlineConfig GetDefaultOutlineConfig(); // 0x05b53520
	System.Void DisableOutline(); // 0x05b503c0
	System.Boolean IsShowOutline(System.Int64 entityId); // 0x05b53964
	System.Collections.Generic.Dictionary<System.Int64,Systems.EnhancedDisplayBase> GetOutlineTipDic(); // 0x05b53c90
	Systems.EnhancedDisplayOutlineData GetOutlineData(); // 0x05b53cf4
	System.Void .ctor(); // 0x05b53d58
	System.Threading.Tasks.Task <>n__0(); // 0x05b53ff8
}

// Client.Runtime
struct Systems.MgrEnhancedDisplayTip.<AfterEnterWorld>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	Systems.MgrEnhancedDisplayTip <>4__this; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x38
	System.Void MoveNext(); // 0x05b54060
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x05b54590
}

// Client.Runtime
class Systems.MgrRaycast : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Generic.List<Systems.MgrRaycast.ClientRaycastAction> raycastActionsList; // 0x18
	System.Void Init(); // 0x05b54634
	System.Threading.Tasks.Task OnEnterWorld(); // 0x05b546e8
	System.Threading.Tasks.Task OnExitWorld(); // 0x05b54750
	System.Void RegisterRaycastEntityTypeAction(System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData>,WizardGames.Soc.SocClient.Systems.HitObjData> func); // 0x05b547b8
	System.Void UnregisterRaycastEntityTypeAction(System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData>,WizardGames.Soc.SocClient.Systems.HitObjData> func); // 0x05b5494c
	System.Void NotifyRayCastEntityTypeAction(System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> entityList, WizardGames.Soc.SocClient.Systems.HitObjData obstacle); // 0x05b54bac
	System.Int32 ParseEntity(UnityEngine.GameObject hitGo, WizardGames.Soc.Common.Entity.IEntity& entity, UnityEngine.GameObject& entityGo); // 0x05b54d38
	System.Void .ctor(); // 0x05b55418
}

// Client.Runtime
class Systems.MgrRaycast.ClientRaycastAction : System.Object
{
	System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData>,WizardGames.Soc.SocClient.Systems.HitObjData> action; // 0x10
	System.Void Init(System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData>,WizardGames.Soc.SocClient.Systems.HitObjData> action); // 0x05b55480
	System.Void Clear(); // 0x05b54b40
	System.Void Invoke(System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> arg, WizardGames.Soc.SocClient.Systems.HitObjData obstacle); // 0x05b54ca4
	System.Boolean IsAction(System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData>,WizardGames.Soc.SocClient.Systems.HitObjData> action); // 0x05b54ac0
	System.Void .ctor(); // 0x05b55500
}

// Client.Runtime
class Systems.BuffSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocSimulator.Buff.BuffItem>> entityBuffMap; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocSimulator.Buff.BuffItem> removeList; // 0x18
	WizardGames.Soc.SocSimulator.Buff.MgrBuff mgrBuff; // 0x20
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05b55568
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05b555cc
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05b556e8
	System.Void OnDestroy(); // 0x05b55c1c
	System.Void .ctor(); // 0x05b55c7c
}

// Client.Runtime
class Systems.ClientGoUpdateSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Go.IEntityGo> _updateGoes; // 0x10
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05b55ce4
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05b55d48
	System.Void OnGoAdd(WizardGames.Soc.Common.Unity.Go.IEntityGo go); // 0x05b56050
	System.Void OnGoRemove(System.Int64 entityId); // 0x05b56220
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05b562bc
	System.Void OnDestroy(); // 0x05b564dc
	System.Void .ctor(); // 0x05b567ec
}

// Client.Runtime
class Systems.ClientMeleeAttackSystem : WizardGames.Soc.Common.Unity.Systems.UserCmdSystem.MeleeAttackSystem
{
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest> predictHits; // 0x20
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05523a54
	System.Void OnDestroy(); // 0x055049cc
	System.Void PredictGatherAttack(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams); // 0x05b56acc
	System.Void CollectHit(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, UnityEngine.Vector3 origin, UnityEngine.Vector3 shoot_dir, WizardGames.Soc.Common.Entity.MeleeAttackRequest attackReq, WizardGames.Soc.Common.Contexts.Context context, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest>& candidates); // 0x05b57c70
	System.Void ProcessHit(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Entity.MeleeAttackRequest attackReq, WizardGames.Soc.Common.Contexts.Context context, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest> candidates); // 0x05b58298
	System.Void .ctor(); // 0x05b59154
}

// Client.Runtime
class Systems.MyMetabolismSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05b5922c
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05b59290
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05b59304
	Systems.MyMetabolismSystem.RadiationIntensity GetPlayerRadiationTier(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x05b5988c
	System.String GetRadiationAudio(Systems.MyMetabolismSystem.RadiationIntensity intensity); // 0x05b59954
	System.Void OnDestroy(); // 0x05b599e8
	System.Void .ctor(); // 0x05b59a48
}

// Client.Runtime
enum Systems.MyMetabolismSystem.RadiationIntensity : System.Enum
{
	System.Int32 value__; // 0x10
	static Systems.MyMetabolismSystem.RadiationIntensity Minimal = 0;
	static Systems.MyMetabolismSystem.RadiationIntensity Low = 1;
	static Systems.MyMetabolismSystem.RadiationIntensity Medium = 2;
	static Systems.MyMetabolismSystem.RadiationIntensity High = 3;
	static Systems.MyMetabolismSystem.RadiationIntensity Ultra = 4;
	
}

// Client.Runtime
class Systems.MyViewkickSystem : WizardGames.Soc.Common.Systems.ViewKickBaseSystem, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	System.Single recoilTime; // 0x1c
	System.Single stopRecoverRecoilPitch; // 0x20
	UnityEngine.Vector2 recoilOffset; // 0x24
	UnityEngine.Vector2 recoilTarget; // 0x2c
	System.Single pitchRecoilTime; // 0x34
	System.Single yawRecoilTime; // 0x38
	System.Single pitchWhenRecoverRecoil; // 0x3c
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05b59ab0
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05b59b14
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05b59ca0
	System.Void RecoverRecoil(System.Int32 deltaTime, WizardGames.Soc.Common.CustomType.WeaponCustom weaponEntity); // 0x05b5abc0
	System.Void CheckViewKickEnd(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.CustomType.WeaponCustom weaponEntity, System.Int64 clientTime); // 0x05b5a6e0
	System.Void UpdateViewKick(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.CustomType.WeaponCustom weaponEntity, System.Int64 clientTime, System.Int32 deltaTime); // 0x05b5a070
	System.Void OnDestroy(); // 0x05b5b0a0
	System.Void .ctor(); // 0x05b5b100
}

// Client.Runtime
class Systems.MyWeaponFireSystem : WizardGames.Soc.Common.Unity.Systems.UserCmdSystem.WeaponFireSystem
{
	WizardGames.Soc.Common.DataSet.CommonDataSet<Share.Common.ObjPool.Alpha3PooledObjectBase> fireRequestQueue; // 0x30
	WizardGames.Soc.Common.DataSet.CommonDataSet<Share.Common.ObjPool.Alpha3PooledObjectBase> bulletRequestQueue; // 0x38
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05b5b18c
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05b5b28c
	System.Void .ctor(); // 0x05b5b788
}

// Client.Runtime
class Systems.MyWeaponLateSystem : WizardGames.Soc.Common.Unity.Systems.UserCmdSystem.WeaponLateSystem
{
	
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05b5b814
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05b5b894
	System.Void .ctor(); // 0x05b5bb18
}

// Client.Runtime
class Systems.ClientAnimDataRefreshSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PlayerEntity> playerEntities; // 0x10
	Unity.Collections.LowLevel.Unsafe.UnsafeList<System.Int64> rootMotionTrackedEntities; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<System.Int64>> entitySubscribeIds; // 0x30
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05b5bb80
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05b5bbe4
	System.Void OnDestroy(); // 0x05b5c7a4
	System.Void SubscribeEntity(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05b5c468
	System.Void UnsubscribeEntity(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05b5cd10
	System.Void OnEntityCreate(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05b5cfa4
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05b5d48c
	System.Void OnGoLoaded(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x05b5d8a4
	System.Void OnGoRemove(System.Int64 entityId); // 0x05b5e07c
	System.Void OnMoveMantleStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte oldState, System.Byte newState); // 0x05b5e484
	System.Void OnMoveLadderStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte oldState, System.Byte newState); // 0x05b5e7cc
	System.Void HandleRootMotionTracking(System.Int64 entityId, System.Boolean wasTrackedState, System.Boolean isTrackedState); // 0x05b5e668
	System.Boolean IsLocalPlayer(System.Int64 entityId); // 0x05b5e9ac
	static System.Boolean ShouldTrackMantleState(WizardGames.Soc.Common.Entity.PlayerMoveMantleStateEnum state); // 0x05b5e5f8
	static System.Boolean ShouldTrackLadderState(WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum state); // 0x05b5e940
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05b5eab4
	System.Void .ctor(); // 0x05b5f110
}

// Client.Runtime
class Systems.ClientChangeWorld : System.Object, WizardGames.Soc.Common.Synchronization.IChangeWorld
{
	
	System.Void .ctor(); // 0x05b5f1c4
}

// Client.Runtime
class Systems.ClientLateRaycastSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05b5f22c
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05b5f290
	System.Void OnDestroy(); // 0x05b5f304
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05b5f364
	System.Void RaycastMaterial(WizardGames.Soc.Common.Entity.PlayerEntity entity, Animation.AnimBehCache animCache); // 0x05b5f798
	System.Void .ctor(); // 0x05b5fa5c
	static System.Void .cctor(); // 0x05b5fac4
}

// Client.Runtime
class Systems.ClientSystemInitHandler : System.Object, WizardGames.Soc.Common.Systems.ISystemInitHandler
{
	static SocLogger logger; // 0x0
	System.Void Init(); // 0x05b5fb98
	System.Void OtherSystem(); // 0x05b6267c
	System.Void .ctor(); // 0x05b626dc
	static System.Void .cctor(); // 0x05b62744
}

// Client.Runtime
class Systems.MgrAntiAddiction : WizardGames.Soc.Common.Manager.MgrBase
{
	System.String ANTI_ADDICTION_TITLE; // 0x18
	System.String MINOR_LOGIN_OUT_OF_PLAYTIME_MSG1; // 0x20
	System.String MINOR_LOGIN_OUT_OF_PLAYTIME_MSG2; // 0x28
	System.String MINOR_GAME_OVER_TIME_MSG; // 0x30
	System.String ADULT_REST_MSG; // 0x38
	System.String RECHARGE_MSG1; // 0x40
	System.String RECHARGE_MSG2; // 0x48
	System.String RECHARGE_MSG3; // 0x50
	System.String confirmStr; // 0x58
	System.Void .ctor(); // 0x05b62818
	System.Void FcmByZhongKong(SimpleJSON.JSONNode jsonNode); // 0x05b629c4
	System.Void ShowTipMsgBox(System.String title, System.String msg, System.Action onBtnClick); // 0x05b62e08
	static System.Void Report(System.String traceID, System.String ruleName); // 0x05b6308c
	System.Void OverTimeLoginOut(); // 0x05b63298
}

// Client.Runtime
class Systems.MgrAntiAddiction.<>c : System.Object
{
	static Systems.MgrAntiAddiction.<>c <>9; // 0x0
	static System.Action <>9__18_0; // 0x8
	static System.Void .cctor(); // 0x05b633dc
	System.Void .ctor(); // 0x05b63440
	System.Void <OverTimeLoginOut>b__18_0(); // 0x05b634a8
}

// Client.Runtime
class Systems.MgrAntiAddiction.<>c__DisplayClass10_0 : System.Object
{
	System.String traceID; // 0x10
	System.String ruleName; // 0x18
	Systems.MgrAntiAddiction <>4__this; // 0x20
	System.Void .ctor(); // 0x05b62da0
	System.Void <FcmByZhongKong>b__0(); // 0x05b6355c
	System.Void <FcmByZhongKong>b__1(); // 0x05b635c0
}

// Client.Runtime
class Systems.MgrHudMsg : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.UiPlayerStatusData playerStatusData; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiHudElemMsgData> deleteTempList; // 0x20
	WizardGames.Soc.SocClient.Ui.UiHudElemPlayerStatus uiHudStatus; // 0x28
	WizardGames.Soc.SocClient.Ui.UiPlayerStatusData get_PlayerStatusData(); // 0x05b63634
	System.Void .ctor(); // 0x05b63698
	System.Void Destroy(); // 0x05b63990
	System.Threading.Tasks.Task OnEnterWorld(); // 0x054e7844
	System.Threading.Tasks.Task OnExitWorld(); // 0x054e7844
	System.Void CleanUp(); // 0x05b63f70
	System.Void OnDeadEnter(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05b64024
	System.Void Update(System.Single deltaTime); // 0x05b641fc
	System.Void ShowMsgText(System.Int32 id, System.Single time, System.String showText, System.Action<WizardGames.Soc.SocClient.Ui.UiHudElemMsgData> updateAction, System.Func<System.Boolean> disappearConditionFunc, System.Func<System.Boolean> flashingConditionFunc, System.Action buttonClickAction); // 0x05b649b4
	System.Void ShowMsgPercent(System.Int32 id, System.Single time, System.String showText, System.Single num, System.Action<WizardGames.Soc.SocClient.Ui.UiHudElemMsgData> updateAction, System.Func<System.Boolean> disappearConditionFunc, System.Func<System.Boolean> flashingConditionFunc, System.Action buttonClickAction); // 0x05b655bc
	System.Void ShowMsgNumber(System.Int32 id, System.Single time, System.String showText, System.Single num, System.Action<WizardGames.Soc.SocClient.Ui.UiHudElemMsgData> updateAction, System.Func<System.Boolean> disappearConditionFunc, System.Func<System.Boolean> flashingConditionFunc, System.Action buttonClickAction); // 0x05b65920
	System.Boolean GetDisapperAction(System.Func<System.Boolean> disappearConditionFunc, WizardGames.Soc.SocClient.Ui.UiHudElemMsgData msgData); // 0x05b65c64
	System.Boolean GetFlashingAction(System.Func<System.Boolean> flashingConditionFunc); // 0x05b65d20
	System.Void OnButtonClickAction(System.Action buttonClickAction); // 0x05b65db8
	System.Void OnButtonClickAction(); // 0x05b65e4c
	System.Void ShowMsgBase(System.Int32 id, WizardGames.Soc.SocClient.Ui.MsgAttributeSet attrSet, System.Int32 type, System.Single time, System.Action<WizardGames.Soc.SocClient.Ui.UiHudElemMsgData> updateAction, System.Func<System.Boolean> disappearConditionFunc, System.Func<System.Boolean> flashingConditionFunc, System.Action buttonClickAction); // 0x05b65170
	System.Boolean IsMsgExist(System.Int32 id); // 0x05b66558
	WizardGames.Soc.SocClient.Ui.UiHudElemMsgData GetMsgData(System.Int32 id); // 0x05b66650
	System.Void AddMsg(System.Int32 id, WizardGames.Soc.SocClient.Ui.UiHudElemMsgData data); // 0x05b65f20
	System.Void AddCoverageMsg(System.Int32 id, WizardGames.Soc.SocClient.Ui.UiHudElemMsgData data); // 0x05b661b8
	System.Void DeleteMsg(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData msgData); // 0x05b645a0
	System.Void DeleteCoverageMsg(); // 0x05b647b4
	UnityEngine.Color HexToColor(System.String hex); // 0x05b66750
	System.Boolean ReadFromTable(System.Int32 id, System.Int32& type, System.Int32& rank, System.String[]& iconUrls, System.String[]& iconRightUrls, UnityEngine.Color[]& bgColors, UnityEngine.Color[]& fontColors, UnityEngine.Color[]& iconColors, System.String& text); // 0x05b64cc8
	System.Void ShowCraftMsg(); // 0x05b668a0
	System.Void ShowMsgWorkbench(System.Int32 workbenchLevel, System.Func<System.Boolean> disappearConditionFunc); // 0x05b66c24
	System.Int32 GetMsgIdByWorktableLevel(System.Int32 workbenchLevel); // 0x05b66ce0
	System.Object GetHudElemPlayerStatus(); // 0x05b66d64
	System.Void AddSoundList(System.Collections.Generic.List<WizardGames.Soc.SocClient.Audio.WWise.AudioEventData> list); // 0x05b66de0
	System.Void SetSoundSwitch(System.String switchGroup, System.String switchState, UnityEngine.GameObject gameObject); // 0x05b66fb4
	static System.Void .cctor(); // 0x05b67120
}

// Client.Runtime
class Systems.MgrHudMsg.<>c : System.Object
{
	static Systems.MgrHudMsg.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiHudElemMsgData> <>9__34_0; // 0x8
	static System.Func<System.Boolean> <>9__34_1; // 0x10
	static System.Action <>9__34_2; // 0x18
	static System.Void .cctor(); // 0x05b671f4
	System.Void .ctor(); // 0x05b67258
	System.Void <ShowCraftMsg>b__34_0(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData msgData); // 0x05b672c0
	System.Boolean <ShowCraftMsg>b__34_1(); // 0x05b675e4
	System.Void <ShowCraftMsg>b__34_2(); // 0x05b6768c
}

// Client.Runtime
class Systems.MgrHudMsg.<>c__DisplayClass23_0 : System.Object
{
	Systems.MgrHudMsg <>4__this; // 0x10
	System.Func<System.Boolean> disappearConditionFunc; // 0x18
	WizardGames.Soc.SocClient.Ui.UiHudElemMsgData msgData; // 0x20
	System.Func<System.Boolean> flashingConditionFunc; // 0x28
	System.Action buttonClickAction; // 0x30
	System.Void .ctor(); // 0x05b65eb8
	System.Boolean <ShowMsgBase>b__0(); // 0x05b67714
	System.Boolean <ShowMsgBase>b__1(); // 0x05b67784
	System.Void <ShowMsgBase>b__2(); // 0x05b677f4
	System.Void <ShowMsgBase>b__3(); // 0x05b67864
}

// Client.Runtime
class Systems.CustomMinHeap<T> : System.Object
{
	T head; // 0x0
	T get_Head(); // 0x052af1f0
	System.Void Add(T node); // 0x052af1f0
	System.Void Delete(T node); // 0x052af1f0
	System.Void Top(T node); // 0x052af1f0
	System.Void Clear(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
interface Systems.ICustomMinHeapNode<T> : 
{
	
	T get_Child(); // 0x052af1f0
	System.Void set_Child(T value); // 0x052af1f0
	System.Int32 get_Order(); // 0x0548ba98
	System.Boolean Equal(T node); // 0x052af1f0
}

// Client.Runtime
class Systems.MgrTips : WizardGames.Soc.Common.Manager.MgrBase
{
	SocLogger <Logger>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.UiTipsData data; // 0x20
	System.Collections.Generic.Dictionary<System.Int32,System.Int64> forbidTipDict; // 0x28
	System.Collections.Generic.List<System.Int32> removeForbidTipList; // 0x30
	System.Collections.Generic.Queue<System.Action> levelUpTipPendingActions; // 0x38
	System.Boolean isLevelUpTipExclusive; // 0x40
	System.Boolean isSettlementExclusive; // 0x41
	SocLogger get_Logger(); // 0x05b678d0
	System.Void .ctor(); // 0x05b67934
	System.Void CleanUp(); // 0x05b67b78
	System.Void CleanTipUpOnLoading(); // 0x05b67bf8
	System.Void OnLevelUpTipOpened(); // 0x05b67c5c
	System.Void OnLevelUpTipClosed(); // 0x05b67dd8
	System.Void BeginSettlementExclusive(); // 0x05b67ff0
	System.Void EndSettlementExclusive(); // 0x05b68058
	System.Void ExecuteTipAction(System.Action action); // 0x05b680bc
	System.Void ProcessPendingTipActions(); // 0x05b67e54
	System.Boolean CheckForbidTips(System.Int32 tipId); // 0x05b68190
	System.Int32 GetMaxRealtimeTipShowNum(); // 0x05b686ec
	System.Void ServerPopMessage(System.Int32 type, System.Int32 msgId, System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.Alpha3PopMsgParam> lanParams); // 0x05b6875c
	System.Void ShowPopMessage(System.Int32 type, System.Int32 msgId, System.String[] args); // 0x05b68c74
	System.Void ShowBattleTip(System.Int32 id, System.String[] args); // 0x05b6922c
	System.Void ShowRealtimeWeakTip(System.Int32 id, System.String[] args); // 0x05b57aac
	System.Void ShowDebugRealtimeWeakTip(System.String tipText); // 0x05b69110
	System.Void ShowRealtimeWeakTipWithIcon(System.String tipText, System.String iconUrl); // 0x05b69448
	System.Void ShowDebugRealtimeWeakTip(System.String tipText, Systems.ServerTipData data); // 0x05b694f0
	System.Void ShowRealtimeTwoIconTip(System.Int32 id, System.Int64 itemId1, System.Int64 itemId2, System.String[] args); // 0x05b69624
	System.Void ShowRealtimeIconTip(System.Int32 id, System.Int64 itemId, System.String[] args); // 0x05b69780
	System.Void ShowMsgAddItem(System.Int32 id, System.Int32 addValue, System.Int32 remainValue, System.Int64 itemId); // 0x05b698d4
	System.Void ShowResidentFrontSightTip(System.Int32 id, System.Func<System.Boolean> disappearConditionFunc, System.Action<WizardGames.Soc.SocClient.Ui.UiFrontSightTipData> updateAction, System.String[] args); // 0x05b699b0
	System.Void HideFrontSightTip(System.Int32 id); // 0x05b69a5c
	System.Void HideOngoingTip(); // 0x05b67cec
	System.Void HideOngoingTipWithType(System.Int32 type); // 0x05b69ad4
	System.Void ShowShortTriggerTip(System.Int32 tipID, System.String[] param); // 0x05b69b74
	System.Void ShowLeftInfoTip(WizardGames.Soc.SocClient.Ui.ELeftInfoTipType type, System.String iconUrl, System.String nameText, System.String introText, System.String typeText, System.Int32 showTime, System.Action detailCallback, System.Int32 curNum, System.Int32 maxNum, System.Int32 point, System.String newIcon, System.Action<UnityEngine.Vector2> closeCallbackByTaskTip); // 0x05b69e20
	System.Void ShowLeftInfoTip(WizardGames.Soc.SocClient.Ui.ELeftInfoTipType type, System.String iconUrl, System.String nameText, System.String introText, System.String typeText, System.Int32 showTime, System.Action detailCallback, System.Action<UnityEngine.Vector2> closeCallbackByTaskTip); // 0x05b6a024
	System.Void ShowLeftInfoTip(WizardGames.Soc.SocClient.Ui.ELeftInfoTipType type, System.String iconUrl, System.String nameText, System.String introText, System.String typeText, System.Int32 showTime); // 0x05b6a1d8
	System.Void ShowLeftInfoTip(WizardGames.Soc.SocClient.Ui.ELeftInfoTipType type, System.String nameText, System.String infoText, System.Int32 showTime, System.Int32 priority, System.Action RefuseCallback, System.Action AgreeCallback, WizardGames.Soc.SocClient.Ui.MsgBoxInfo info, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo> newInfos, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.VoteStatus> VoteDataList); // 0x05b6a350
	System.Void CloseLeftInfoTip(); // 0x05b67d74
	System.Void ShowLeftInfoPop(WizardGames.Soc.SocClient.Ui.MsgBoxInfo info, System.Int32 tipId); // 0x05b6a52c
	System.Void ShowVoteTip(WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData tipData, System.Int32 tipId); // 0x05b6a764
	System.Void ShowImpeacheTip(WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData tipData, System.Int32 tipId); // 0x05b6aa64
	System.Void ShowTeamInvite(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo> infos, System.Int32 tipId); // 0x05b6ad64
	System.Void ShowJumpTip(WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData tipData, System.Int32 tipId); // 0x05b6b038
	System.Void ShowRealtimeIntroTip(System.Int64 itemTableId, System.Int32 showTime); // 0x05b6b338
	System.Void ShowRealtimeTechnologyTip(System.Int64 technologyId, System.Int32 showTime); // 0x05b6b6d8
	System.Void ShowMedalRankBadgeTip(System.Int32 medalId, System.Int32 level, System.Int32 point, System.Int64 subTaskId, System.Int32 taskCount); // 0x05b6bacc
	System.Void ShowLeftInfoTip(System.Int32 tipId, System.Int32 guideId, System.Int32 guideStepId); // 0x05b6c210
	System.Void ShowLeftInfoTip(System.Int32 tipId, System.String concatText); // 0x05b6c538
	System.Void ShowLeftInfoTipByParams(System.Int32 tipId, System.Int32 guideId, System.Int32 guideStepId, System.String[] args); // 0x05b6c8a8
	System.Void ShowRealtimeNpcTextTip(System.String npcText); // 0x05b6cb84
	System.Void CloseRealtimeNpcTextTip(); // 0x05b6cc00
	System.Void ShowRealtimeManualTip(System.Int32 secondTabId); // 0x05b6cc64
	System.Void ShowRealtimeRewardTips(System.Collections.Generic.List<WizardGames.Soc.Common.Data.Reward> rewardsData); // 0x05b6cffc
	System.Void ShowRealtimeTaskTips(System.Int64 taskId); // 0x05b6d09c
	System.Void ShowRealtimeTaskTips(System.Boolean isDeadSheep); // 0x05b6d118
	System.Boolean IsLoading(); // 0x05b69394
	System.String GetIconUrl(System.String icon, System.Int32 width, System.Int32 height); // 0x05b6d194
	System.Void ShowServerPopMessage(Systems.ServerTipData data); // 0x05b6d284
	System.String FormatServerStr(System.String[] strs); // 0x05b6d324
	System.Void ShowServerBigTitleMessage(Systems.ServerBigTitleData data); // 0x05b6d5ec
	System.Void ShowLobbyErrorCodeTip(System.Int32 codeId); // 0x05b6d67c
	System.Void ShowOngoingTip(WizardGames.Soc.SocClient.Ui.OngoingTipOptionsData tipOptionsData); // 0x05b6d870
	System.Void HideOngoingTipById(System.Int32 tipId); // 0x05b6d98c
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass21_0 : System.Object
{
	System.Collections.Generic.HashSet<System.String> roleIdList; // 0x10
	System.String[] args; // 0x18
	Systems.MgrTips <>4__this; // 0x20
	System.Int32 type; // 0x28
	System.Int32 msgId; // 0x2c
	System.Void .ctor(); // 0x05cc63a4
	System.Void <ServerPopMessage>b__0(SimpleJSON.JSONArray res); // 0x05cc640c
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass24_0 : System.Object
{
	System.Int32 id; // 0x10
	System.String[] args; // 0x18
	System.Void .ctor(); // 0x05cc664c
	System.Void <ShowRealtimeWeakTip>b__0(); // 0x05cc66b4
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass25_0 : System.Object
{
	System.String tipText; // 0x10
	System.Void .ctor(); // 0x05cc6720
	System.Void <ShowDebugRealtimeWeakTip>b__0(); // 0x05cc6788
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass27_0 : System.Object
{
	System.String tipText; // 0x10
	Systems.ServerTipData data; // 0x18
	System.Void .ctor(); // 0x05cc67f4
	System.Void <ShowDebugRealtimeWeakTip>b__0(); // 0x05cc685c
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass28_0 : System.Object
{
	System.Int32 id; // 0x10
	System.Int64 itemId1; // 0x18
	System.Int64 itemId2; // 0x20
	System.String[] args; // 0x28
	System.Void .ctor(); // 0x05cc68c4
	System.Void <ShowRealtimeTwoIconTip>b__0(); // 0x05cc692c
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass29_0 : System.Object
{
	System.Int32 id; // 0x10
	System.Int64 itemId; // 0x18
	System.String[] args; // 0x20
	System.Void .ctor(); // 0x05cc699c
	System.Void <ShowRealtimeIconTip>b__0(); // 0x05cc6a04
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass36_0 : System.Object
{
	System.Int32 tipID; // 0x10
	System.String[] param; // 0x18
	System.Void .ctor(); // 0x05cc6a70
	System.Void <ShowShortTriggerTip>b__0(); // 0x05cc6ad8
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass37_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ELeftInfoTipType type; // 0x10
	System.String iconUrl; // 0x18
	System.String nameText; // 0x20
	System.String introText; // 0x28
	System.String typeText; // 0x30
	System.Int32 showTime; // 0x38
	System.Action detailCallback; // 0x40
	System.Int32 curNum; // 0x48
	System.Int32 maxNum; // 0x4c
	System.Int32 point; // 0x50
	System.String newIcon; // 0x58
	System.Action<UnityEngine.Vector2> closeCallbackByTaskTip; // 0x60
	System.Void .ctor(); // 0x05cc6b44
	System.Void <ShowLeftInfoTip>b__0(); // 0x05cc6bac
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass38_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ELeftInfoTipType type; // 0x10
	System.String iconUrl; // 0x18
	System.String nameText; // 0x20
	System.String introText; // 0x28
	System.String typeText; // 0x30
	System.Int32 showTime; // 0x38
	System.Action detailCallback; // 0x40
	System.Action<UnityEngine.Vector2> closeCallbackByTaskTip; // 0x48
	System.Void .ctor(); // 0x05cc6cc0
	System.Void <ShowLeftInfoTip>b__0(); // 0x05cc6d28
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass39_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ELeftInfoTipType type; // 0x10
	System.String iconUrl; // 0x18
	System.String nameText; // 0x20
	System.String introText; // 0x28
	System.String typeText; // 0x30
	System.Int32 showTime; // 0x38
	System.Void .ctor(); // 0x05cc6e48
	System.Void <ShowLeftInfoTip>b__0(); // 0x05cc6eb0
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass40_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ELeftInfoTipType type; // 0x10
	System.String nameText; // 0x18
	System.String infoText; // 0x20
	System.Int32 showTime; // 0x28
	System.Int32 priority; // 0x2c
	System.Action RefuseCallback; // 0x30
	System.Action AgreeCallback; // 0x38
	WizardGames.Soc.SocClient.Ui.MsgBoxInfo info; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo> newInfos; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.VoteStatus> VoteDataList; // 0x50
	System.Void .ctor(); // 0x05cc6fd0
	System.Void <ShowLeftInfoTip>b__0(); // 0x05cc7038
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass43_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData tipData; // 0x10
	System.Void .ctor(); // 0x05cc7178
	System.Void <ShowVoteTip>b__0(); // 0x05cc71e0
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass44_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData tipData; // 0x10
	System.Void .ctor(); // 0x05cc7248
	System.Void <ShowImpeacheTip>b__0(); // 0x05cc72b0
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass46_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData tipData; // 0x10
	System.Void .ctor(); // 0x05cc7318
	System.Void <ShowJumpTip>b__0(); // 0x05cc7380
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass47_0 : System.Object
{
	Systems.MgrTips <>4__this; // 0x10
	System.String iconUrl; // 0x18
	System.String nameText; // 0x20
	System.String introText; // 0x28
	System.String typeText; // 0x30
	System.Int32 showTime; // 0x38
	System.Action detailCallback; // 0x40
	System.Boolean showDetailBtn; // 0x48
	System.Void .ctor(); // 0x05cc73e8
	System.Void <ShowRealtimeIntroTip>b__0(); // 0x05cc7450
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass47_1 : System.Object
{
	System.Int64 tableId; // 0x10
	Systems.MgrTips.<>c__DisplayClass47_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x05cc7570
	System.Void <ShowRealtimeIntroTip>b__1(); // 0x05cc75d8
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass47_2 : System.Object
{
	System.Int32 itemIndex; // 0x10
	System.Void .ctor(); // 0x05cc7884
	System.Void <ShowRealtimeIntroTip>b__2(System.Int64 _, System.Object _, System.Boolean _); // 0x05cc78ec
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass48_0 : System.Object
{
	Systems.MgrTips <>4__this; // 0x10
	WizardGames.Soc.Common.Data.DataItem.Technology technologyonfig; // 0x18
	System.String iconUrl; // 0x20
	System.String nameText; // 0x28
	System.String introText; // 0x30
	System.Int32 showTime; // 0x38
	System.Action detailCallback; // 0x40
	System.Boolean showDetailBtn; // 0x48
	System.Void .ctor(); // 0x05cc79d8
	System.Void <ShowRealtimeTechnologyTip>b__0(); // 0x05cc7a40
	System.Void <ShowRealtimeTechnologyTip>b__1(); // 0x05cc7b2c
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass50_0 : System.Object
{
	System.Int32 medalId; // 0x10
	System.Void .ctor(); // 0x05cc7ce4
	System.Void <ShowMedalRankBadgeTip>b__0(); // 0x05cc7d4c
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass56_0 : System.Object
{
	System.Int32 secondTabId; // 0x10
	System.Void .ctor(); // 0x05cc7e34
	System.Void <ShowRealtimeManualTip>b__0(); // 0x05cc7e9c
}

// Client.Runtime
class Systems.MgrTips.<>c__DisplayClass70_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.OngoingTipOptionsData tipOptionsData; // 0x10
	System.Void .ctor(); // 0x05cc7f3c
	System.Void <ShowOngoingTip>b__0(); // 0x05cc7fa4
}

// Client.Runtime
class Systems.ServerTipData : System.Object
{
	System.Int32 type; // 0x10
	System.Int32 time; // 0x14
	System.String bgColor; // 0x18
	System.String fontColor; // 0x20
	System.String[] content; // 0x28
	System.Void .ctor(); // 0x05cc8528
}

// Client.Runtime
class Systems.ServerBigTitleData : System.Object
{
	System.Int32 canCloseTime; // 0x10
	System.Int32 autoCloseTime; // 0x14
	System.String bgColor; // 0x18
	System.String titleColor; // 0x20
	System.String contentColor; // 0x28
	System.String title; // 0x30
	System.String content; // 0x38
	System.Action CloseCallback; // 0x40
	System.Int32 selectedIndex; // 0x48
	System.Void .ctor(); // 0x05cc8590
}

// Client.Runtime
class Systems.UserCmdSystem.ProjectileNonLagCompensationCmd : System.Object, WizardGames.Soc.Common.Systems.IUserCmdSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.Ability.IProjectile> projectiles; // 0x10
	WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo baseMgrEntityGo; // 0x18
	UnityEngine.RaycastHit[] cacheHitResults; // 0x20
	Systems.UserCmdSystem.ProjectileNonLagCompensationCmd.RaycastDistanceCompaper raycastDistanceCompaper; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Utility.OBB> cachedObbs; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest> hitCandidates; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest> simulateHitCandidates; // 0x40
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05cc85f8
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05cc8720
	System.Void CheckBulletMuzzleEffect(WizardGames.Soc.Common.Entity.Ability.IProjectile projectile); // 0x05cc9458
	System.Void PostBulletHitProcess(WizardGames.Soc.Common.Entity.Ability.IProjectile projectile, WizardGames.Soc.Common.SimpleCustom.HitRequest hit, WizardGames.Soc.Common.Contexts.Context context); // 0x05cc9a10
	System.Void ProjectileImpactCheckingAllNew(WizardGames.Soc.Common.Contexts.Context context, System.Int64 entityId, WizardGames.Soc.Common.Entity.Ability.IProjectile projectile, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Boolean needOverlap); // 0x05cc8eac
	System.Void GatherCmdHitInfoNew(UnityEngine.Vector3 start, WizardGames.Soc.Common.SimpleCustom.HitRequest hit, WizardGames.Soc.Common.Entity.Ability.IProjectile projectile, WizardGames.Soc.Common.SimpleCustom.UserCmd& cmd); // 0x05cc9fd8
	System.Void OnDestroy(); // 0x05ccac04
	static System.Boolean SimulatePhysicsMove(WizardGames.Soc.Common.Entity.Ability.IProjectile projectile); // 0x05ccac64
	System.Void .ctor(); // 0x05ccae1c
	static System.Void .cctor(); // 0x05ccb024
}

// Client.Runtime
class Systems.UserCmdSystem.ProjectileNonLagCompensationCmd.RaycastDistanceCompaper : System.Object, System.Collections.Generic.IComparer<UnityEngine.RaycastHit>
{
	
	System.Int32 Compare(UnityEngine.RaycastHit x, UnityEngine.RaycastHit y); // 0x05ccb0f8
	System.Void .ctor(); // 0x05ccafbc
}

// Client.Runtime
class Systems.UserCmdSystem.UserCmdGunkickSystem : System.Object, WizardGames.Soc.Common.Systems.IUserCmdSystem, WizardGames.Soc.Common.Systems.ISystem
{
	Combat.Shoot.Formula.MgrGunkickFormula mgrGunkickFormula; // 0x10
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05ccb1bc
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05ccb28c
	System.Void OnDestroy(); // 0x05ccb420
	System.Void .ctor(); // 0x05ccb480
}

// Client.Runtime
class Systems.PostUserCmdSystem.PlatformSystem : System.Object, WizardGames.Soc.Common.Systems.IUserCmdSystem, WizardGames.Soc.Common.Systems.ISystem
{
	
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05ccb4e8
	System.Void OnDestroy(); // 0x05ccb55c
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05ccb5bc
	System.Void .ctor(); // 0x05ccb850
}

// Client.Runtime
class Systems.BaseSystem.ActionEventSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	SocLogger logger; // 0x10
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05ccb8b8
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05ccb91c
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05ccb990
	System.Void OnDestroy(); // 0x05ccba20
	System.Void .ctor(); // 0x05ccba80
}

// Client.Runtime
class Systems.BaseSystem.AnimationRenderBeginSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05ccbb78
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05ccbbdc
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05ccbc50
	System.Void OnDestroy(); // 0x05ccbce4
	System.Void .ctor(); // 0x05ccbd44
}

// Client.Runtime
class Systems.BaseSystem.AnimationRenderCompleteSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	Contexts.ClientContext clientContext; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PlayerEntity> LocalPlayerEntities; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PlayerEntity> playerEntities; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.MonsterEntity> MonsterEntities; // 0x28
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x30
	WizardGames.Soc.Common.Entity.PlayerEntity myEntity; // 0x38
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05ccbdac
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05ccbe10
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05526948
	System.Void OnDestroy(); // 0x05ccca40
	System.Void .ctor(); // 0x05cccaa0
	static System.Void .cctor(); // 0x05cccb08
}

// Client.Runtime
class Systems.BaseSystem.ClientPartBasePropertySystem : WizardGames.Soc.Common.Systems.PartBasePropertyChangeSystem
{
	static System.Int64 DamageSubscribId; // 0x0
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05cccbdc
	System.Void OnDestroy(); // 0x05ccce30
	WizardGames.Soc.Common.Entity.PartEntity GetPartEntity(System.Int64 entityId); // 0x05cccf0c
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05cccfc0
	System.Void .ctor(); // 0x05ccd064
	static System.Void .cctor(); // 0x05ccd0f0
}

// Client.Runtime
class Systems.BaseSystem.ClientSeatingSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Entity.PlayerEntity> playerEntities; // 0x10
	System.Int64 subscribe1; // 0x18
	System.Int64 subscribe2; // 0x20
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05ccd13c
	System.Void OnDestroy(); // 0x05ccd1a0
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05ccd328
	System.Void OnPlayerEntityCreate(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x05ccd5a4
	System.Void OnPlayerSeatChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int64 oldValue, System.Int64 newValue); // 0x05ccd6a0
	System.Void OnPlayerSeatChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int32 oldValue, System.Int32 newValue); // 0x05ccd934
	System.Void InternalSeatChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity); // 0x05ccd738
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05ccd9cc
	System.Void PlaySeatSound(System.Int32 oldIndex, System.Int32 newIndx, WizardGames.Soc.Common.Entity.PlayerEntity entity, SocVehicle.Scripts.Entity.Vehicle.GroundVehicleAudio audio_comp); // 0x05cce66c
	System.Void .ctor(); // 0x05cceae8
	static System.Void .cctor(); // 0x05cceba0
}

// Client.Runtime
class Systems.BaseSystem.ClientStorageDebrisBasePropertyChangeSystem : WizardGames.Soc.Common.Systems.StorageDebrisBasePropertyChangeSystem
{
	
	System.Void .ctor(); // 0x05ccec74
}

// Client.Runtime
class Systems.BaseSystem.DynamicLightData : System.Object
{
	static System.Collections.Generic.List<LightComData> AllLightDatas; // 0x0
	static System.Collections.Generic.List<LightComData> SpecialLightDatas; // 0x8
	static WizardGames.Soc.Common.Utility.Grid<LightComData> LightGrid; // 0x10
	static System.Collections.Generic.Dictionary<System.Int32,Systems.BaseSystem.LightLayerInfo> LightLayerInfoDic; // 0x18
	static System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<LightGroupComData>> LightShowStageMap; // 0x20
	static System.Boolean UseGrid; // 0x28
	static System.Boolean LightGroupDirty; // 0x29
	static System.Single LightInquireMaxRange; // 0x2c
	static System.Collections.Generic.List<LightComData> notInitData; // 0x30
	static System.Void Clear(); // 0x05cced00
	static System.Void AddDynamicLight(LightComData light); // 0x05ccee6c
	static System.Void RemoveDynamicLight(LightComData light); // 0x05ccf2f4
	static System.Void AddLightGroup(LightGroupComData lightGroupCom); // 0x05ccf534
	static System.Void RemoveLightGroup(LightGroupComData lightGroupCom); // 0x05ccf7d8
	static System.Void .cctor(); // 0x05ccf934
}

// Client.Runtime
class Systems.BaseSystem.LightTypeInfo : System.Object
{
	System.Single mLightShowMaxLimitDis; // 0x10
	System.Single mShadowShowMaxLimitDis; // 0x14
	System.Int32 mLightPriority; // 0x18
	System.Void .ctor(); // 0x05ccfaf8
}

// Client.Runtime
class Systems.BaseSystem.LightLayerInfo : System.Object
{
	System.Collections.Generic.Dictionary<System.Int32,Systems.BaseSystem.LightTypeInfo> mLightTypeInfo; // 0x10
	System.Single mLayerMaxLimitLightNum; // 0x18
	System.Single mLayerCurActiveNum; // 0x1c
	System.Void Reset(); // 0x05ccfb60
	System.Void .ctor(); // 0x05ccfbc4
}

// Client.Runtime
class Systems.BaseSystem.DynamicLightSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	SocLogger <logger>k__BackingField; // 0x28
	System.Collections.Generic.List<LightComData> mLastActiveLightDatas; // 0x30
	System.Collections.Generic.List<LightComData> mAllActiveLight; // 0x38
	System.Collections.Generic.List<LightComData> mSourceLightDatas; // 0x40
	System.Int32 curQualityLevel; // 0x48
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<LightComData>> mSourceLightDataDic; // 0x50
	System.Int32 mPreQualityLevel; // 0x58
	System.Int32 mDayKey; // 0x5c
	System.Int32 mNightKey; // 0x60
	WizardGames.Soc.Common.Data.GameTimeStage preStage; // 0x64
	System.Collections.Generic.Dictionary<System.Int32,System.Single> mLightType2Range; // 0x68
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> mLightType2RangeLimitNum; // 0x70
	System.Collections.Generic.List<System.Int32> mLightRangeLimitType; // 0x78
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<LightComData>> mLightRangeChangeDic; // 0x80
	System.Int32 mLightRangeEffectNum; // 0x88
	System.Collections.Generic.List<System.Int32> mInvalidLightData; // 0x90
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05ccfc7c
	System.Collections.Generic.List<LightComData> get_mAllLightDatas(); // 0x05ccfce0
	System.Collections.Generic.List<LightComData> get_mSpecialLightDatas(); // 0x05ccfd70
	WizardGames.Soc.Common.Utility.Grid<LightComData> get_mLightGrid(); // 0x05ccfe00
	System.Void set_mLightGrid(WizardGames.Soc.Common.Utility.Grid<LightComData> value); // 0x05ccfe90
	System.Collections.Generic.Dictionary<System.Int32,Systems.BaseSystem.LightLayerInfo> get_mLightLayerInfoDic(); // 0x05ccff38
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<LightGroupComData>> get_mLightShowStageMap(); // 0x05ccffc8
	System.Single get_kLightInquireMaxRange(); // 0x05cd0058
	System.Boolean get_mUseGrid(); // 0x05cd00e8
	System.Void set_mUseGrid(System.Boolean value); // 0x05cd0178
	System.Boolean get_mLightGroupDirty(); // 0x05cd0220
	System.Void set_mLightGroupDirty(System.Boolean value); // 0x05cd02b0
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05cd0358
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05cd10ac
	System.Void OnDestroy(); // 0x05cd1840
	System.Void OnShadowCacheChange(System.Boolean open); // 0x05cd1c48
	System.Void UpdateLightGrid(); // 0x05cd11ec
	System.Void UpdateLightConfig(System.Boolean forceUpdate); // 0x05cd0834
	System.Boolean get_isNeedUpdateConfig(); // 0x05cd2694
	System.Void SetLightRangeSetting(System.Int32 lightTypeID, WizardGames.Soc.Common.Data.global.DynamicLightRangeSetting config, System.Int32 qualityLevel); // 0x05cd29d8
	System.Int32 GetLightRangeAmountLimitNum(System.Int32 quality, WizardGames.Soc.Common.Data.global.DynamicLightRangeSetting config); // 0x05cd2b44
	System.Void SetLightInfo(WizardGames.Soc.Common.Data.global.DynamicLightLod lightInfo, Systems.BaseSystem.LightTypeInfo lightTypeInfo, System.Int32 qualityLevel); // 0x05cd28b0
	System.Int32 GetLightLayerLimitNum(System.Int32 layerID, System.Int32 qualityLevel); // 0x05cd2748
	System.Void UpdateLightGridPos(LightComData lightCom, System.Single x, System.Single z); // 0x05cd24d8
	System.Void UpdateLightShowStatus(); // 0x05cd14c0
	System.Void HandleLightRange(); // 0x05cd4af4
	System.Void SetLightShadowConfig(LightComData light); // 0x05cd50c0
	System.Void HandleLightActiveShadowState(); // 0x05cd4ef0
	System.Int32 GetShadowRenderingLayers(System.Int32 lightSubLayer, System.Int32 curQualityLevel); // 0x05cd55b4
	System.Boolean IsNeedUpdateLightGroup(); // 0x05cd2c2c
	System.Void ResetData(); // 0x05cd2f34
	System.Void SetSourceLightsData(); // 0x05cd34fc
	System.Void RemoveInvalidSourceLight(); // 0x05cd3df4
	System.Void ClassificationLightByType(); // 0x05cd4100
	System.Void ReleaseSourceLightData(); // 0x05cd5764
	System.Void SortLight(); // 0x05cd469c
	System.Void HandleLightActiveStatus(); // 0x05cd4958
	System.Void HandleLightActiveStateByLayer(System.Collections.Generic.List<LightComData> lights); // 0x05cd59b0
	System.Void SetLightRangeChangeData(LightComData lightData); // 0x05cd5cd0
	System.Void SetActiveLight(LightComData light, System.Int32 lightLayer, System.Boolean isOpenShadow); // 0x05cd5ef4
	System.Void UpdateLightShowStateByTimePerid(); // 0x05cd2da8
	System.Void SetLightStageState(System.Boolean isDay); // 0x05cd62b8
	System.Void SetLightState(System.Collections.Generic.List<LightGroupComData> data, System.Boolean enable); // 0x05cd6594
	System.Void ClearContext(); // 0x05cd1bbc
	System.Void .ctor(); // 0x05cd6678
}

// Client.Runtime
class Systems.BaseSystem.DynamicLightSystem.<>c : System.Object
{
	static Systems.BaseSystem.DynamicLightSystem.<>c <>9; // 0x0
	static System.Comparison<LightComData> <>9__58_0; // 0x8
	static System.Comparison<LightComData> <>9__69_0; // 0x10
	static System.Void .cctor(); // 0x05cd69b8
	System.Void .ctor(); // 0x05cd6a1c
	System.Int32 <HandleLightRange>b__58_0(LightComData a, LightComData b); // 0x05cd6a84
	System.Int32 <SortLight>b__69_0(LightComData a, LightComData b); // 0x05cd6b18
}

// Client.Runtime
class Systems.BaseSystem.IOEntitySystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	SocLogger <logger>k__BackingField; // 0x28
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05cd6bdc
	SocLogger get_logger(); // 0x05cd6c40
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05cd6ca4
	System.Void OnDestroy(); // 0x05cd6f3c
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05cd7278
	System.Void OnCreateEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05cd757c
	System.Void OnRemoveEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05cd79d8
	System.Void .ctor(); // 0x05cd7d24
}

// Client.Runtime
class Systems.BaseSystem.MonsterSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Go.MonsterGo> monsterGos; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Go.TurretMonsterGo> turretDict; // 0x30
	System.Collections.Generic.List<System.Int64> turretIds; // 0x38
	System.Int32 m_CurrentLineIdx; // 0x40
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05cd7e1c
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05cd7e80
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05cd7ff4
	System.Void OnDestroy(); // 0x05cd88a8
	System.Void UpdateTurretLine(); // 0x05cd86a0
	System.Void OnStreamingComp(UnityEngine.GameObject _, System.String __); // 0x05cd8a7c
	System.Void .ctor(); // 0x05cd8c44
}

// Client.Runtime
class Systems.BaseSystem.SeekingTargetTokenSystem : System.Object, WizardGames.Soc.Common.Systems.IUserCmdSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Dictionary<System.Int64,CommonUnity.Runtime.Entity.ISeekerTarget> seekerTargets; // 0x8
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Defines.TableItemEnum,WizardGames.Soc.Common.Weapon.TargetingLauncherData> targetingLauncherTokens; // 0x10
	WizardGames.Soc.Common.Unity.Defines.TableItemEnum currentHoldingLauncherType; // 0x18
	WizardGames.Soc.Common.Unity.Defines.TableItemEnum preHoldingLauncherType; // 0x1c
	System.Int64 finalLockingEntityId; // 0x20
	System.Single finalLockingEntityToken; // 0x28
	System.Int64 finalUiLockingEntityId; // 0x30
	System.Single finalLockingEntityProgress; // 0x38
	System.Collections.Generic.List<System.Int64> currentLockableEntityIds; // 0x40
	WizardGames.Soc.Common.Entity.PlayerEntity get_myPlayerEntity(); // 0x05cd8db4
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05cd8e50
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05cd9184
	System.Void UpdateCurrentLockingTarget(System.Int64& currentLockingEntityId, System.Collections.Generic.List<System.Int64>& lockableEntityIds, WizardGames.Soc.Common.CustomType.WeaponCustom currentWeapon); // 0x0552d210
	System.Void CheckIfClearToken(); // 0x055049cc
	System.Boolean TargetIsGanRaoDanUsing(); // 0x05cd9b28
	System.Void SendCurrentLockingEntityAndToken(); // 0x05cd9a78
	System.Void OnSeekerTargetEntityCreate(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05cd9bfc
	System.Void OnSeekerTargetEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05cd9e1c
	System.Void OnDestroy(); // 0x05cda034
	System.Void .ctor(); // 0x05cda2a0
	static System.Void .cctor(); // 0x05cda310
}

// Client.Runtime
class Systems.BaseSystem.SmoothSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Go.ISmoothGo> childrenList; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Go.BaseMountableGo> mountableList; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Go.ISmoothGo> parentList; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Go.ISmoothGo> clearList; // 0x40
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05cda3e4
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05cda448
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05cda4bc
	static System.Void UpdateBrief(); // 0x05cddd4c
	System.Void UpdateChildren(); // 0x05cdc658
	System.Void UpdateMountableRender(System.Int32 deltaTime); // 0x05cdc4d0
	System.Void UpdateParentList(); // 0x05cdb98c
	System.Void CollectList(System.Int32 deltaTime, System.Int64 selfEntityId); // 0x05cda6d0
	System.Void .ctor(); // 0x05cde49c
	static System.Void .cctor(); // 0x05cde5fc
}

// Client.Runtime
class Systems.BaseSystem.SnapshotBulletMoveSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.DataSet.CommonDataSet<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> createData; // 0x28
	WizardGames.Soc.Common.DataSet.CommonDataSet<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> destroyData; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Go.ClientBulletGo> bulletGos; // 0x38
	System.Collections.Generic.HashSet<System.Int64> removables; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest> hitCandidates; // 0x48
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05cde6d0
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05cde734
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05cde898
	System.Void CheckWhizSound(WizardGames.Soc.Common.Entity.BulletEntity bulletEntity, UnityEngine.Vector3 preProjectilePosition, UnityEngine.Vector3 playerPosition, WizardGames.Soc.Common.Entity.Ability.IProjectile projectile); // 0x05cdf940
	System.Void PlayWhizSound(WizardGames.Soc.Common.Entity.BulletEntity bulletEntity, UnityEngine.Vector3 intersectionPoint, WizardGames.Soc.Common.Entity.Ability.IProjectile projectile); // 0x05cdfea0
	System.Boolean IntersectsSphere(UnityEngine.Vector3 sphereCenter, System.Single radius, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.Vector3& intersectionPoint); // 0x05cdfc54
	System.Void OnDestroy(); // 0x05ce0124
	System.Void .ctor(); // 0x05ce03c0
	static System.Void .cctor(); // 0x05ce0524
}

// Client.Runtime
class Systems.BaseSystem.MySystem.AutoTurretEventDataSystem : WizardGames.Soc.Common.Systems.ReactiveSystemBase
{
	
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05ce05f8
	System.Boolean get_handleSnapshotEvent(); // 0x05ce065c
	System.Int32 get_eventQueueId(); // 0x05ce06c0
	System.Void ExecuteEvent(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05ce0750
	System.Void .ctor(); // 0x05ce09cc
}

// Client.Runtime
class Systems.BaseSystem.MySystem.BoxHpZeroEventSystem : WizardGames.Soc.Common.Systems.ImmediatelyEventSystemBase
{
	
	System.Int64 RegisterListener(); // 0x05ce0a34
	System.Void Execute(System.Int32 hashCode, WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent baseSnapshotEvent); // 0x05ce0b68
	System.Void .ctor(); // 0x05ce0dd8
}

// Client.Runtime
class Systems.BaseSystem.MySystem.CameraShakeRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.String AssetPath; // 0x20
	System.Single PlayRate; // 0x28
	System.Boolean IsFp; // 0x2c
	static System.Void CreateCameraShakeRequest(System.String assetPath, System.Single playRate, System.Boolean isFp); // 0x05ce0e40
	System.Void Dispose(); // 0x05ce0fbc
	System.Void .ctor(); // 0x05ce1058
}

// Client.Runtime
class Systems.BaseSystem.MySystem.CameraShakeRuntime : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	WizardGames.Soc.Common.Unity.Shake.CameraShakeData CameraShakeData; // 0x20
	System.Single PlayRate; // 0x28
	System.Single Time; // 0x2c
	System.Boolean IsFp; // 0x30
	System.Void ReturnToPool(); // 0x05ce10c0
	System.Void Dispose(); // 0x05ce1140
	System.Void .ctor(); // 0x05ce11b0
}

// Client.Runtime
class Systems.BaseSystem.MySystem.CameraShakeSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.DataSet.CommonDataSet<Share.Common.ObjPool.Alpha3PooledObjectBase> cameraShakeRequestSet; // 0x28
	System.Collections.Generic.List<Systems.BaseSystem.MySystem.CameraShakeRuntime> cameraShakeRuntimes; // 0x30
	UnityEngine.GameObject bindGo; // 0x38
	WizardGames.Soc.Common.Unity.CameraStateController cameraStateController; // 0x40
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05ce1218
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05ce127c
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05ce142c
	System.Void ProcessCameraShake(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05ce164c
	System.Threading.Tasks.Task LoadAsset(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05ce150c
	System.Void .ctor(); // 0x05ce194c
	static System.Void .cctor(); // 0x05ce19b4
}

// Client.Runtime
class Systems.BaseSystem.MySystem.CameraShakeSystem.<>c__DisplayClass10_0 : System.Object
{
	Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject; // 0x10
	Systems.BaseSystem.MySystem.CameraShakeRequest cameraShakeRequest; // 0x18
	Systems.BaseSystem.MySystem.CameraShakeSystem <>4__this; // 0x20
	System.Void .ctor(); // 0x05ce1a88
	System.Void <LoadAsset>b__0(System.UInt64 arg1, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> result); // 0x05ce1af0
}

// Client.Runtime
struct Systems.BaseSystem.MySystem.CameraShakeSystem.<LoadAsset>d__10 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	Systems.BaseSystem.MySystem.CameraShakeSystem <>4__this; // 0x30
	System.Void MoveNext(); // 0x05ce1d5c
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x05ce20f4
}

// Client.Runtime
class Systems.BaseSystem.MySystem.ClientBoatBehSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	SocLogger logger; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.VehicleEntity> CachedVehicleEntities; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,Systems.BaseSystem.MySystem.ClientBoatBehSystem.BoatCache> BoatCaches; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> entityUpdateTime; // 0x28
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05ce2198
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05ce21fc
	System.Void OnDestroy(); // 0x05ce23a8
	System.Void OnGoRemove(WizardGames.Soc.Common.Entity.IEntity rm_entity); // 0x05ce24f0
	System.Void TryUpdateVehicle(System.Int32 deltaTime, WizardGames.Soc.Common.Entity.VehicleEntity vehicleEntity, System.Int64 entityId); // 0x05ce2dbc
	System.Void UpdateBoat(WizardGames.Soc.Common.Entity.VehicleEntity vehicleEntity, System.Int64 entityId); // 0x05ce2f44
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05ce43b8
	System.Void .ctor(); // 0x05ce4598
}

// Client.Runtime
class Systems.BaseSystem.MySystem.ClientBoatBehSystem.AverageVelocity : System.Object
{
	UnityEngine.Vector3 pos; // 0x10
	System.Single time; // 0x1c
	System.Single averageSpeed; // 0x20
	UnityEngine.Vector3 averageVelocity; // 0x24
	System.Void Record(UnityEngine.Vector3 newPos); // 0x05ce4244
	UnityEngine.Vector3 get_Average(); // 0x05ce4744
	System.Void .ctor(); // 0x05ce47a8
}

// Client.Runtime
class Systems.BaseSystem.MySystem.ClientBoatBehSystem.BoatCache : System.Object
{
	System.Nullable<System.Boolean> wasEngineOn; // 0x10
	System.Nullable<System.Boolean> wasInWater; // 0x12
	System.Single nextSplashAccent; // 0x14
	System.Nullable<UnityEngine.Vector3> LastPosition; // 0x18
	System.Nullable<System.Int32> prevSteering; // 0x28
	Systems.BaseSystem.MySystem.ClientBoatBehSystem.AverageVelocity averageVelocity; // 0x30
	System.Void .ctor(); // 0x05ce41a8
}

// Client.Runtime
class Systems.BaseSystem.MySystem.ClientCH47BehSystem : WizardGames.Soc.Common.Systems.CommonCopterBehSystem
{
	System.Collections.Generic.Dictionary<System.Int64,Systems.BaseSystem.MySystem.ClientCH47BehSystem.CH47Cache> ch47Caches; // 0x20
	System.Action<System.Boolean,Effect.EffectItem,System.Object> loadGroundEffectCompleted; // 0x28
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05ce4810
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05ce4874
	System.Void OnDestroy(); // 0x05ce4a28
	System.Void OnGoRemove(WizardGames.Soc.Common.Entity.IEntity rmEntity); // 0x05ce4b7c
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05ce4e98
	System.Void UpdateFlyGroundEffect(System.Int64 entityId, WizardGames.Soc.Common.Entity.VehicleEntity entity, WizardGames.Soc.SocClient.Go.ClientCH47Go ch47Go, CH47HelicopterAIController ch47HelicopterCom, Systems.BaseSystem.MySystem.ClientCH47BehSystem.CH47Cache dataCache, System.Int32 deltaTime); // 0x05ce55d0
	System.Void StopGroundEffects(System.Int64 entity_id, Systems.BaseSystem.MySystem.ClientCH47BehSystem.CH47Cache entity_data_cache, System.Int32 effect_tb_id); // 0x05ce63a0
	System.Void PlayGroundEffect(WizardGames.Soc.SocClient.Go.ClientCH47Go ch47Go, CH47HelicopterAIController ch47, Systems.BaseSystem.MySystem.ClientCH47BehSystem.CH47Cache ch47Cache, System.Int32 effectTableId); // 0x05ce64c0
	System.Void LoadGroundEffectCompleted(System.Boolean success, Effect.EffectItem effectItem, System.Object o); // 0x05ce6720
	System.Void UpdateDamageEffect(System.Int64 entityId, WizardGames.Soc.Common.Entity.VehicleEntity entity, WizardGames.Soc.SocClient.Go.ClientCH47Go ch47Go, CH47HelicopterAIController ch47HelicopterCom, Systems.BaseSystem.MySystem.ClientCH47BehSystem.CH47Cache dataCache, System.Int32 deltaTime); // 0x05ce5f10
	System.Void PlayDamageEffect(WizardGames.Soc.SocClient.Go.ClientCH47Go ch47Go, CH47HelicopterAIController ch47, Systems.BaseSystem.MySystem.ClientCH47BehSystem.CH47Cache ch47Cache, System.Int32 effectTableId, UnityEngine.Transform transform); // 0x05ce6ab0
	System.Void StopDamageEffects(System.Int64 entity_id, Systems.BaseSystem.MySystem.ClientCH47BehSystem.CH47Cache entity_data_cache, System.Int32 effect_tb_id); // 0x05ce6ca4
	System.Void UpdateEngineVolume(System.Int64 entityId, WizardGames.Soc.Common.Entity.VehicleEntity entity, WizardGames.Soc.SocClient.Go.ClientCH47Go ch47Go, CH47HelicopterAIController ch47HelicopterCom, Systems.BaseSystem.MySystem.ClientCH47BehSystem.CH47Cache dataCache, System.Int32 deltaTime); // 0x05ce621c
	System.Void .ctor(); // 0x05ce6dc4
}

// Client.Runtime
class Systems.BaseSystem.MySystem.ClientCH47BehSystem.CH47Cache : System.Object
{
	System.Int32 CurDamageEffectPhase; // 0x10
	System.Int32 LastUpdateTime; // 0x14
	System.Int32 LastGroundEffectId; // 0x18
	System.Collections.Generic.List<UnityEngine.Transform> GroundPoints; // 0x20
	System.Collections.Generic.List<UnityEngine.Transform> GroundEffects; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,Effect.EffectItemHandle<Effect.EffectItem>> PlayingEffects; // 0x30
	System.Void .ctor(); // 0x05ce5488
}

// Client.Runtime
class Systems.BaseSystem.MySystem.ClientCopterBehSystem : WizardGames.Soc.Common.Systems.CommonCopterBehSystem
{
	System.Collections.Generic.Dictionary<System.Int64,Systems.BaseSystem.MySystem.ClientCopterBehSystem.CopterCache> CopterCaches; // 0x20
	System.Collections.Generic.List<System.Single> SortedHpConf; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<System.Single>> sortedHpConfDic; // 0x30
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05ce6e78
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05ce6edc
	System.Void OnDestroy(); // 0x05ce703c
	System.Void OnGoRemove(WizardGames.Soc.Common.Entity.IEntity rm_entity); // 0x05ce7190
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05ce823c
	System.Void PlayHitEffect(System.Int64 entity_id, WizardGames.Soc.Common.Entity.VehicleEntity test_entity, WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountable_go, MiniCopter mini_copter_component, Systems.BaseSystem.MySystem.ClientCopterBehSystem.CopterCache entity_data_cache, System.Int32 deltaTime); // 0x05cebefc
	System.Void PlayHpEffect(System.Int64 entity_id, WizardGames.Soc.Common.Entity.VehicleEntity test_entity, WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountable_go, MiniCopter mini_copter_component, Systems.BaseSystem.MySystem.ClientCopterBehSystem.CopterCache entity_data_cache, System.Int32 deltaTime); // 0x05cec2d4
	System.Void PlayFlyGroundEffect(System.Int64 entity_id, WizardGames.Soc.Common.Entity.VehicleEntity test_entity, WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountable_go, MiniCopter mini_copter_component, Systems.BaseSystem.MySystem.ClientCopterBehSystem.CopterCache entity_data_cache, System.Int32 deltaTime); // 0x05ceb68c
	System.Void PlayIdleEffect(System.Int64 entity_id, WizardGames.Soc.Common.Entity.VehicleEntity test_entity, WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountable_go, MiniCopter mini_copter_component, Systems.BaseSystem.MySystem.ClientCopterBehSystem.CopterCache entity_data_cache, System.Int32 deltaTime); // 0x05cea948
	System.Void UpdateTailRotor(System.Int64 entity_id, WizardGames.Soc.Common.Entity.VehicleEntity test_entity, WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountable_go, MiniCopter mini_copter_component, Systems.BaseSystem.MySystem.ClientCopterBehSystem.CopterCache entity_data_cache, System.Int32 deltaTime); // 0x05cecba4
	System.Void _StopEffect(System.Int64 entity_id, Systems.BaseSystem.MySystem.ClientCopterBehSystem.CopterCache entity_data_cache, System.Int32 effect_tb_id); // 0x05cedb18
	System.Void _PlayEffect(System.Int64 entity_id, Systems.BaseSystem.MySystem.ClientCopterBehSystem.CopterCache entity_data_cache, UnityEngine.Transform cur_trans, System.Int32 effect_tb_id, System.String effect_bind_name, System.Nullable<UnityEngine.Vector3>& cur_world_pos, System.Nullable<UnityEngine.Vector3>& cur_world_rot, System.Nullable<UnityEngine.Vector3>& cur_world_forward, Effect.FollowTransformFlag ftf); // 0x05ced004
	System.Void EmitHpAudio(System.Int64 entity_id, WizardGames.Soc.Common.Entity.VehicleEntity test_entity, WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountable_go, MiniCopter mini_copter_component, Systems.BaseSystem.MySystem.ClientCopterBehSystem.CopterCache cache, System.Boolean has_custom_sound, SocVehicle.Scripts.Entity.Vehicle.GroundVehicleAudio audio_comp, SocVehicle.Scripts.Entity.Vehicle.VehicleSoundConf& default_sound_conf); // 0x05ce9e8c
	System.Void EmitRevSpeedAudio(System.Int64 entity_id, WizardGames.Soc.Common.Entity.VehicleEntity test_entity, WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountable_go, MiniCopter mini_copter_component, System.Boolean has_custom_sound, SocVehicle.Scripts.Entity.Vehicle.GroundVehicleAudio audio_comp, SocVehicle.Scripts.Entity.Vehicle.VehicleSoundConf& default_sound_conf); // 0x05ce979c
	System.Void EmitDamageAudio(System.Int64 entity_id, WizardGames.Soc.Common.Entity.VehicleEntity test_entity, MiniCopter mini_copter_component, WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountable_go, System.Boolean has_custom_sound, SocVehicle.Scripts.Entity.Vehicle.GroundVehicleAudio audio_comp, SocVehicle.Scripts.Entity.Vehicle.VehicleSoundConf& default_sound_conf); // 0x05ce9418
	System.Void EmitEngineAudio(System.Int64 entity_id, WizardGames.Soc.Common.Entity.VehicleEntity test_entity, WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountable_go, System.Boolean has_custom_sound, SocVehicle.Scripts.Entity.Vehicle.GroundVehicleAudio audio_comp, Systems.BaseSystem.MySystem.ClientCopterBehSystem.CopterCache cache, MiniCopter mini_copter_component, SocVehicle.Scripts.Entity.Vehicle.VehicleSoundConf& default_sound_conf); // 0x05ce9a1c
	System.Void EmitLowFuelAudio(System.Int64 entity_id, WizardGames.Soc.Common.Entity.VehicleEntity test_entity, WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountable_go, MiniCopter mini_copter_component, System.Boolean is_self, Systems.BaseSystem.MySystem.ClientCopterBehSystem.CopterCache cache, System.Boolean has_custom_sound, SocVehicle.Scripts.Entity.Vehicle.GroundVehicleAudio audio_comp, SocVehicle.Scripts.Entity.Vehicle.VehicleSoundConf& default_sound_conf); // 0x05cea63c
	System.Void .ctor(); // 0x05cedcc0
}

// Client.Runtime
struct Systems.BaseSystem.MySystem.ClientCopterBehSystem.StopEffectData : System.ValueType, System.IEquatable<Systems.BaseSystem.MySystem.ClientCopterBehSystem.StopEffectData>
{
	System.Int32 EffectId; // 0x10
	System.Int32 DelayTime; // 0x14
	System.Boolean Equals(Systems.BaseSystem.MySystem.ClientCopterBehSystem.StopEffectData other); // 0x05e462a8
	System.Boolean Equals(System.Object obj); // 0x05e46340
	System.Int32 GetHashCode(); // 0x05e46404
}

// Client.Runtime
class Systems.BaseSystem.MySystem.ClientCopterBehSystem.CopterCache : System.Object
{
	System.Boolean IsLowFuelMode; // 0x10
	System.Boolean IsStarting; // 0x11
	System.Int32 LowHpMode; // 0x14
	System.Int32 LastPlayHpIndex; // 0x18
	System.Int32 LastPlayHpEffectIndex; // 0x1c
	System.Int32 LastTestGroundTime; // 0x20
	System.Int32 LastGroundEffectId; // 0x24
	System.Single LastPropellerSpeed; // 0x28
	System.Single LastYawAngle; // 0x2c
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> DelayStopEffectDic; // 0x30
	System.Collections.Generic.List<Systems.BaseSystem.MySystem.ClientCopterBehSystem.StopEffectData> DelayStopEffectTimeList; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,Effect.EffectItemHandle<Effect.EffectItem>> PlayingEffects; // 0x40
	System.Collections.Generic.Dictionary<System.Int64,Effect.EffectItemHandle<Effect.ParticleEffect>> PlayingFollowEffects; // 0x48
	System.Collections.Generic.List<UnityEngine.Transform> rootGos; // 0x50
	System.Collections.Generic.List<UnityEngine.Transform> rootrearGos; // 0x58
	System.Collections.Generic.List<UnityEngine.Transform> rootrearWingGos; // 0x60
	System.Collections.Generic.List<UnityEngine.Transform> leverGos; // 0x68
	System.Collections.Generic.List<System.Single> SortedPropeller; // 0x70
	System.Void .ctor(); // 0x05e464ac
}

// Client.Runtime
class Systems.BaseSystem.MySystem.ClientModularCarBehSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.ModularCarEntity> CachedCarEntities; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.ModularCarEntity> LocalCachedCarEntities; // 0x18
	System.Action<UnityEngine.GameObject> MotionCallback; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModularCarCache> CachedCarCache; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModuleCache> CachedModuleCache; // 0x30
	System.Int32 emissionColorID; // 0x38
	System.Int64 subscribeId; // 0x40
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> entityUpdateTime; // 0x48
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05e4675c
	static System.Void .cctor(); // 0x05e467c0
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05e46934
	System.Void OnTryStartEngine(System.Int64 entityId); // 0x05e46c7c
	static System.Void OnVehicleModuleHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase module, System.Single oldValue, System.Single newValue); // 0x05e46ea8
	System.Void OnDestroy(); // 0x05e47064
	System.Void OnProfilerGoRemove(WizardGames.Soc.Common.Entity.IEntity rm_entity); // 0x05e472ac
	System.Void OnGoRemove(WizardGames.Soc.Common.Entity.IEntity rm_entity); // 0x05e47328
	System.Void OnDestroySnapShotEvent(System.Int32 hashCode, WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent baseSnapshotEvent); // 0x05e48a00
	System.Void UpdateModularCar(System.Int64 eid, WizardGames.Soc.Common.Entity.ModularCarEntity vehicleEntity); // 0x05e4b3ac
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05e53258
	System.Void UpdateVehicle(System.Int32 deltaTime, WizardGames.Soc.Common.Entity.ModularCarEntity vehicleEntity, UnityEngine.Vector3 playerPos, System.Int64 eid); // 0x05e53600
	static System.Boolean IsVehicleInValid(WizardGames.Soc.Common.Entity.ModularCarEntity vehicleEntity, System.Int64 eid, ModularCar& modular_car, UnityEngine.GameObject& car_main_go); // 0x05e4c738
	System.Boolean IsAttachModuleInValid(BaseVehicleModule baseVehicleModule, System.Int64& module_eid, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModuleCache& module_cache, UnityEngine.GameObject& module_main_go); // 0x05e50b20
	System.Void RefreshLightSound(ModularCar modular_car, System.Boolean has_custom_sound, SocVehicle.Scripts.Entity.Vehicle.GroundVehicleAudio audio_comp, SocVehicle.Scripts.Entity.Vehicle.VehicleSoundConf default_sound_conf, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModularCarCache car_cache, WizardGames.Soc.Common.Entity.ModularCarEntity vehicleEntity, UnityEngine.GameObject car_main_go); // 0x05e4e1dc
	System.Void RefreshSeat2WindowSounds(ModularCar modular_car, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModuleCache module_cache, BaseVehicleModule baseVehicleModule, System.Int64 module_eid, WizardGames.Soc.Common.Unity.Audio.GameAudioConf& shutter_open_sound, WizardGames.Soc.Common.Unity.Audio.GameAudioConf& shutter_close_sound); // 0x05e51608
	System.Void RefreshSeat1WindowSounds(ModularCar modular_car, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModuleCache module_cache, BaseVehicleModule baseVehicleModule, System.Int64 module_eid, WizardGames.Soc.Common.Unity.Audio.GameAudioConf& shutter_open_sound, WizardGames.Soc.Common.Unity.Audio.GameAudioConf& shutter_close_sound); // 0x05e50dfc
	System.Void RefreshSuspensionSounds(System.Boolean has_custom_sound, SocVehicle.Scripts.Entity.Vehicle.GroundVehicleAudio audio_comp, SocVehicle.Scripts.Entity.Vehicle.VehicleSoundConf& default_sound_conf, ModularCar modular_car, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModularCarCache car_cache); // 0x05e4ff00
	System.Void RefreshSkinSounds(ModularCar modular_car, System.Boolean has_custom_sound, SocVehicle.Scripts.Entity.Vehicle.GroundVehicleAudio audio_comp, SocVehicle.Scripts.Entity.Vehicle.VehicleSoundConf& default_sound_conf, System.Boolean inWater, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModularCarCache car_cache, UnityEngine.GameObject car_main_go); // 0x05e4e4b0
	System.Void RefreshMovementRattleSound(Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModularCarCache car_cache, ModularCar modular_car, UnityEngine.GameObject car_main_go, System.Boolean has_custom_sound, SocVehicle.Scripts.Entity.Vehicle.GroundVehicleAudio audio_comp, SocVehicle.Scripts.Entity.Vehicle.VehicleSoundConf& default_sound_conf); // 0x05e4f74c
	System.Void RefreshTyreAudio(Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModularCarCache car_cache, ModularCar modular_car, UnityEngine.GameObject car_main_go, System.Boolean has_custom_sound, SocVehicle.Scripts.Entity.Vehicle.GroundVehicleAudio audio_comp, SocVehicle.Scripts.Entity.Vehicle.VehicleSoundConf& default_sound_conf); // 0x05e4eed4
	System.Void UpdateTyreSound(ModularCar modular_car, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModularCarCache car_cache, System.Int32 index, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData, WizardGames.Soc.Common.Unity.Audio.GameAudioConf& tyreRollingSoundDef, WizardGames.Soc.Common.Unity.Audio.GameAudioConf& tyreRollingWaterSoundDef, WizardGames.Soc.Common.Unity.Audio.GameAudioConf& tyreRollingGrassSoundDef, WizardGames.Soc.Common.Unity.Audio.GameAudioConf& tyreRollingSnowSoundDef); // 0x05e53894
	System.Void RefreshWaterLoopSound(System.Boolean has_custom_sound, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModularCarCache car_cache, SocVehicle.Scripts.Entity.Vehicle.GroundVehicleAudio audio_comp, SocVehicle.Scripts.Entity.Vehicle.VehicleSoundConf& default_sound_conf, ModularCar modular_car, UnityEngine.GameObject car_main_go); // 0x05e4cbec
	System.Void GenerateGibs(Rust.Modular.ConditionalObject conditional, System.Int32 conditional_index, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModuleCache module_cache, BaseVehicleModule baseVehicleModule); // 0x05e52278
	System.Void RefreshActiveBeh(ModularCar modular_car, Rust.Modular.ConditionalObject conditional, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModuleCache module_cache, System.Int32 condition_index, System.Int64 module_eid); // 0x05e51f98
	static System.Void _StopConditionalEffect(Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModuleEffectCache& condition_cache); // 0x05e5404c
	static System.Void _PlayConditionEffect(Rust.Modular.ConditionalObject conditional, System.Int64 module_eid, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModuleEffectCache condition_cache, Effect.FollowTransformFlag playflag); // 0x05e53c9c
	System.Void RefreshSeatingBeh(ModularCar modular_car, System.Boolean has_custom_sound, SocVehicle.Scripts.Entity.Vehicle.GroundVehicleAudio audio_comp, SocVehicle.Scripts.Entity.Vehicle.VehicleSoundConf& default_sound_conf, BaseVehicleModule baseVehicleModule, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModularCarCache car_cache, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModuleCache module_cache); // 0x05e52c1c
	System.Void SetCheckEngineLightState(VehicleModuleSeating seating_module, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModuleCache moduleCache, System.Boolean isOn); // 0x05e54164
	System.Void SetFuelLightState(VehicleModuleSeating seating_module, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModuleCache moduleCache, System.Boolean isOn); // 0x05e54298
	System.Void SetLightState(VehicleModuleSeating seating_module, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModuleCache moduleCache, System.Boolean isOn, System.Int32 lightMatIndex, UnityEngine.Color lightEmission); // 0x05e543cc
	System.Void RefreshEngineModuleEffect(BaseVehicleModule baseVehicleModule, ModularCar modular_car, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModularCarCache car_cache, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModuleCache module_cache, System.Int64 module_eid); // 0x05e51d54
	System.Void RefreshBrakeSound(System.Boolean has_custom_sound, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModularCarCache car_cache, SocVehicle.Scripts.Entity.Vehicle.GroundVehicleAudio audio_comp, SocVehicle.Scripts.Entity.Vehicle.VehicleSoundConf& default_sound_conf, System.Int64 eid, ModularCar modular_car, UnityEngine.GameObject car_main_go); // 0x05e4dd6c
	System.Void RefreshEngineSound(ModularCar modular_car, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModularCarCache car_cache, WizardGames.Soc.Common.Entity.ModularCarEntity vehicleEntity, System.Boolean has_custom_sound, SocVehicle.Scripts.Entity.Vehicle.GroundVehicleAudio audio_comp, UnityEngine.GameObject car_main_go, SocVehicle.Scripts.Entity.Vehicle.VehicleSoundConf& default_sound_conf); // 0x05e4cf68
	System.Void RefreshMotionEffect(ModularCar modular_car, WizardGames.Soc.Common.Entity.ModularCarEntity vehicleEntity, UnityEngine.GameObject car_main_go, System.Boolean is_ground, System.Int64 eid, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModularCarCache car_cache); // 0x05e5052c
	System.Void RefreshModuleHp(Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModularCarCache car_cache, Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModuleCache moduleCache, UnityEngine.GameObject module_main_go, ModularCar modular_car, BaseVehicleModule baseVehicleModule); // 0x05e52510
	UnityEngine.Vector3 Position(Gibbable gibbable, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); // 0x05e54638
	UnityEngine.Material[] GetMaterialsForGib(Gibbable gibbable, Gibbable.GibMesh mesh); // 0x05e547fc
	System.Boolean GetMeshOverride(Gibbable gibbable, System.Int32 index, Gibbable.OverrideMesh& m); // 0x05e548c0
	System.Void CreateGibs(Gibbable gibbable, System.Int64 entityId, UnityEngine.Transform forObject, Gibbable.ParentingType parentingType, UnityEngine.Vector3 initialVelocity, UnityEngine.Vector3 fxPos, UnityEngine.Quaternion fxRotation); // 0x05e493dc
	System.Boolean IsMyPlayerInCar(WizardGames.Soc.Common.Entity.ModularCarEntity modularCarEntity); // 0x05e4c914
	System.Void .ctor(); // 0x05e549f4
	System.Void <OnCreate>b__18_0(System.Int32 hashCode, WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent baseSnapshotEvent); // 0x05e54b84
}

// Client.Runtime
class Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientWheelCache : System.Object
{
	System.Single prevWheelExtensionPercent; // 0x10
	System.Boolean wheelWasGrounded; // 0x14
	System.Single lastSuspensionSoundPlayed; // 0x18
	System.Void .ctor(); // 0x05e5382c
}

// Client.Runtime
class Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModularCarCache : System.Object
{
	Effect.EffectItemHandle<Effect.FollowEffect> MotionEffectOp; // 0x10
	UnityEngine.Transform target_trans; // 0x20
	System.Boolean isMotionEffect; // 0x28
	System.Boolean IsMovingOrOn; // 0x29
	System.Boolean IsInWater; // 0x2a
	System.Boolean LastIsInWater; // 0x2b
	System.Boolean IsBrake; // 0x2c
	WizardGames.Soc.Common.Combat.ColliderMaterialEnum CurrentMaterialType; // 0x2d
	System.Int32 noMovementCount; // 0x30
	System.Single AbsForwardSpeed; // 0x34
	System.Boolean LastSpeedWasStationary; // 0x38
	System.Single lastMovementStopSoundPlayed; // 0x3c
	System.Single lastMovementStartSoundPlayed; // 0x40
	System.Single skidRatio; // 0x44
	System.Nullable<System.Boolean> LightOn; // 0x48
	System.Nullable<System.Boolean> engineOn; // 0x4a
	System.Nullable<System.Boolean> engineFailed; // 0x4c
	System.Boolean enginestarting; // 0x4e
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf PlayingMovementRattleSound; // 0x50
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf PlayingSkidSound; // 0x68
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf[] PlayingWheelSound; // 0x80
	System.Collections.Generic.Dictionary<System.Int32,Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientWheelCache> WheelExtensionData; // 0x88
	System.Void .ctor(); // 0x05e46dc0
}

// Client.Runtime
struct Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModuleEffectCache : System.ValueType
{
	Effect.EffectItemHandle<Effect.FollowEffect>[] Effects; // 0x10
	Gibbable gibCache; // 0x18
	System.Boolean IsDeploy; // 0x20
	
}

// Client.Runtime
class Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModuleCache : System.Object
{
	UnityEngine.MaterialPropertyBlock[] MatBlocks; // 0x10
	UnityEngine.Renderer[] Renderers; // 0x18
	UnityEngine.AnimationCurve Curve; // 0x20
	System.Boolean ShouldRefreshMaterials; // 0x28
	System.Nullable<System.Boolean> PreSeat1Window; // 0x29
	System.Nullable<System.Boolean> PreSeat2Window; // 0x2b
	System.Nullable<System.Boolean> HornOn; // 0x2d
	Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModuleEffectCache[] ConditionCaches; // 0x30
	UnityEngine.MaterialPropertyBlock dashboardLightPB; // 0x38
	System.Void .ctor(); // 0x05e537c4
}

// Client.Runtime
class Systems.BaseSystem.MySystem.ClientModularCarBehSystem.<>c__DisplayClass51_0 : System.Object
{
	Systems.BaseSystem.MySystem.ClientModularCarBehSystem.ClientModularCarCache car_cache; // 0x10
	System.Void .ctor(); // 0x05e545d0
	System.Void <RefreshMotionEffect>b__0(UnityEngine.GameObject go); // 0x05e54c0c
	System.Void <RefreshMotionEffect>b__1(UnityEngine.GameObject go); // 0x05e54ce0
}

// Client.Runtime
class Systems.BaseSystem.MySystem.ClientVehicleLateUpdateSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Entity.ModularCarEntity> moduleEntities; // 0x10
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.CustomType.VehicleModuleCustom> vehicleEntities; // 0x18
	System.Int64 subscribeId1; // 0x20
	System.Int64 subscribeId2; // 0x28
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05e54db4
	System.Void OnDestroy(); // 0x05e54e18
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05e54fa0
	System.Void OnEntityCreate(WizardGames.Soc.Common.Entity.IEntity baseEntity); // 0x05e551d0
	System.Void OnVehicleHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Single oldValue, System.Single newValue); // 0x05e55318
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05526948
	System.Void .ctor(); // 0x05e557d0
	static System.Void .cctor(); // 0x05e558e4
}

// Client.Runtime
class Systems.BaseSystem.MySystem.CorpseDataEventSystem : WizardGames.Soc.Common.Systems.ReactiveSystemBase
{
	
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05e559b8
	System.Boolean get_handleSnapshotEvent(); // 0x05e55a1c
	System.Int32 get_eventQueueId(); // 0x05e55a80
	System.Void ExecuteEvent(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05e55b10
	System.Void .ctor(); // 0x05e55d4c
}

// Client.Runtime
class Systems.BaseSystem.MySystem.CreatePartAndPlayAudioEventSystem : WizardGames.Soc.Common.Systems.ImmediatelyEventSystemBase
{
	
	System.Int64 RegisterListener(); // 0x05e55db4
	System.Void Execute(System.Int32 hashCode, WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent baseSnapshotEvent); // 0x05e55ee8
	System.Void .ctor(); // 0x05e56030
}

// Client.Runtime
class Systems.BaseSystem.MySystem.DestroyPartGoEventSystem : WizardGames.Soc.Common.Systems.ImmediatelyEventSystemBase
{
	
	System.Int64 RegisterListener(); // 0x05e56098
	System.Void Execute(System.Int32 hashCode, WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent baseSnapshotEvent); // 0x05e561cc
	System.Void .ctor(); // 0x05e5638c
}

// Client.Runtime
class Systems.BaseSystem.MySystem.DropCombineEventSystem : WizardGames.Soc.Common.Systems.ReactiveSystemBase
{
	
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05e563f4
	System.Boolean get_handleSnapshotEvent(); // 0x05e56458
	System.Int32 get_eventQueueId(); // 0x05e564bc
	System.Void ExecuteEvent(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05e5654c
	System.Void .ctor(); // 0x05e5667c
}

// Client.Runtime
class Systems.BaseSystem.MySystem.ElevatorDataSystem : WizardGames.Soc.Common.Systems.ReactiveSystemBase
{
	
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05e566e4
	System.Boolean get_handleSnapshotEvent(); // 0x05e56748
	System.Int32 get_eventQueueId(); // 0x05e567ac
	System.Void ExecuteEvent(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05e5683c
	System.Void .ctor(); // 0x05e569d4
}

// Client.Runtime
class Systems.BaseSystem.MySystem.FireDataEventSystem : WizardGames.Soc.Common.Systems.ReactiveSystemBase
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PlayerEntity> playerEntities; // 0x38
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05e56a3c
	System.Boolean get_handleSnapshotEvent(); // 0x05e56aa0
	System.Int32 get_eventQueueId(); // 0x05e56b04
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05e56b94
	System.Void ExecuteEvent(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05e56c74
	static System.Void UpdateFireEventWithEntity(WizardGames.Soc.Common.SimpleCustom.FireDataEvent dataEvent, WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05e56e34
	System.Void .ctor(); // 0x05e56f38
}

// Client.Runtime
class Systems.BaseSystem.MySystem.GunTrapFireEventDataSystem : WizardGames.Soc.Common.Systems.ReactiveSystemBase
{
	
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05e56fa0
	System.Boolean get_handleSnapshotEvent(); // 0x05e57004
	System.Int32 get_eventQueueId(); // 0x05e57068
	System.Void ExecuteEvent(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05e570f8
	System.Void .ctor(); // 0x05e57298
}

// Client.Runtime
class Systems.BaseSystem.MySystem.MergeMagicFieldEventSystem : WizardGames.Soc.Common.Systems.ImmediatelyEventSystemBase
{
	
	System.Int64 RegisterListener(); // 0x05e57300
	System.Void Execute(System.Int32 hashCode, WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent baseSnapshotEvent); // 0x05e57434
	System.Void .ctor(); // 0x05e57688
}

// Client.Runtime
class Systems.BaseSystem.MySystem.MonsterFireEventDataSystem : WizardGames.Soc.Common.Systems.ReactiveSystemBase
{
	
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05e576f0
	System.Boolean get_handleSnapshotEvent(); // 0x05e57754
	System.Int32 get_eventQueueId(); // 0x05e577b8
	System.Void ExecuteEvent(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05e57848
	System.Void .ctor(); // 0x05e57e60
}

// Client.Runtime
class Systems.BaseSystem.MySystem.MyTpAdsAimOffsetSystem : System.Object, WizardGames.Soc.Common.Systems.IUserCmdSystem, WizardGames.Soc.Common.Systems.ISystem
{
	System.Single MaxDis; // 0x10
	UnityEngine.Vector3 offset; // 0x14
	UnityEngine.RaycastHit[] hitBuffer; // 0x20
	System.Collections.Generic.List<UnityEngine.RaycastHit> hits; // 0x28
	System.Boolean needOffset; // 0x30
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05e57ec8
	System.Void CameraChangeState(WizardGames.Soc.Common.Unity.CameraState lastCameraState, WizardGames.Soc.Common.Unity.CameraState nowCameraState); // 0x05e58010
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05e587b8
	System.Void OnDestroy(); // 0x05e58950
	UnityEngine.Vector3 CameraDirToShootDir(); // 0x05e58240
	System.Void .ctor(); // 0x05e58a90
}

// Client.Runtime
class Systems.BaseSystem.MySystem.PickAndDropSuccessEventSystem : WizardGames.Soc.Common.Systems.ReactiveSystemBase
{
	
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05e58b80
	System.Boolean get_handleSnapshotEvent(); // 0x05e58be4
	System.Int32 get_eventQueueId(); // 0x05e58c48
	System.Void ExecuteEvent(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05e58cd8
	System.Void .ctor(); // 0x05e58d70
}

// Client.Runtime
class Systems.BaseSystem.MySystem.PlayerGoProxyLateUpdateSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Go.IEntityGo> players; // 0x10
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x18
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05e58dd8
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05e58e3c
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05e58f0c
	System.Void OnDestroy(); // 0x05e59270
	System.Void .ctor(); // 0x05e592d0
	static System.Void .cctor(); // 0x05e59338
}

// Client.Runtime
class Systems.BaseSystem.MySystem.PlayerInteractiveEventSystem : WizardGames.Soc.Common.Systems.ImmediatelyEventSystemBase
{
	
	System.Int64 RegisterListener(); // 0x05e5940c
	System.Void Execute(System.Int32 hashCode, WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent baseSnapshotEvent); // 0x05e59540
	System.Void .ctor(); // 0x05e5969c
}

// Client.Runtime
class Systems.BaseSystem.MySystem.PlayKnockDoorAudioEventSystem : WizardGames.Soc.Common.Systems.ImmediatelyEventSystemBase
{
	
	System.Int64 RegisterListener(); // 0x05e59704
	System.Void Execute(System.Int32 hashCode, WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent baseSnapshotEvent); // 0x05e59838
	System.Void .ctor(); // 0x05e59958
}

// Client.Runtime
class Systems.BaseSystem.MySystem.PlayLockEffectEventSystem : WizardGames.Soc.Common.Systems.ImmediatelyEventSystemBase
{
	
	System.Int64 RegisterListener(); // 0x05e599c0
	System.Void Execute(System.Int32 hashCode, WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent baseSnapshotEvent); // 0x05e59af4
	System.Void .ctor(); // 0x05e59c14
}

// Client.Runtime
class Systems.BaseSystem.MySystem.PureGoDataEventSystem : WizardGames.Soc.Common.Systems.ReactiveSystemBase
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PlayerEntity> playerEntities; // 0x38
	WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo MgrGo; // 0x40
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05e59c7c
	System.Boolean get_handleSnapshotEvent(); // 0x05e59ce0
	System.Int32 get_eventQueueId(); // 0x05e59d44
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05e59dd4
	System.Void OnDestroy(); // 0x05e59f0c
	System.Void ExecuteEvent(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05e59f84
	System.Void .ctor(); // 0x05e5a294
}

// Client.Runtime
class Systems.BaseSystem.MySystem.ShowUpkeepInfoToClientEventSystem : WizardGames.Soc.Common.Systems.ImmediatelyEventSystemBase
{
	
	System.Int64 RegisterListener(); // 0x05e5a2fc
	System.Void Execute(System.Int32 hashCode, WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent baseSnapshotEvent); // 0x05e5a430
	System.Void .ctor(); // 0x05e5a4b8
}

// Client.Runtime
class Systems.BaseSystem.MySystem.SwimSprayEventSystem : WizardGames.Soc.Common.Systems.ReactiveSystemBase
{
	WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo MgrGo; // 0x38
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05e5a520
	System.Boolean get_handleSnapshotEvent(); // 0x05e5a584
	System.Int32 get_eventQueueId(); // 0x05e5a5e8
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05e5a678
	System.Void OnDestroy(); // 0x05e5a758
	System.Void ExecuteEvent(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05e5a7d0
	System.Void .ctor(); // 0x05e5aca4
}

// Client.Runtime
class Systems.BaseSystem.MySystem.TrainBarricadeHpZeroEventSystem : WizardGames.Soc.Common.Systems.ImmediatelyEventSystemBase
{
	
	System.Int64 RegisterListener(); // 0x05e5ad0c
	System.Void Execute(System.Int32 hashCode, WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent baseSnapshotEvent); // 0x05e5ae40
	System.Void .ctor(); // 0x05e5af9c
}

// Client.Runtime
class Systems.BaseSystem.MySystem.TrainHpZeroEventSystem : WizardGames.Soc.Common.Systems.ImmediatelyEventSystemBase
{
	
	System.Int64 RegisterListener(); // 0x05e5b004
	System.Void Execute(System.Int32 hashCode, WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent baseSnapshotEvent); // 0x05e5b138
	System.Void .ctor(); // 0x05e5b294
}

// Client.Runtime
class Systems.BaseSystem.MySystem.UpgradePartAudioEventEventSystem : WizardGames.Soc.Common.Systems.ImmediatelyEventSystemBase
{
	
	System.Int64 RegisterListener(); // 0x05e5b2fc
	System.Void Execute(System.Int32 hashCode, WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent baseSnapshotEvent); // 0x05e5b430
	System.Void .ctor(); // 0x05e5b750
}

// Client.Runtime
class Systems.BaseSystem.MySystem.ClientNewAnimEventSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	System.Single LastCheckTime; // 0x10
	System.Int64 subscribeId; // 0x18
	System.Int64 subscribeId1; // 0x20
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Data.DataItem.AnimEventConfig> _configCache; // 0x8
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05e5b7b8
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05e5b81c
	System.Void OnPlayerSeatChange(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int64 oldValue, System.Int64 newValue); // 0x05e5ba44
	System.Void OnLifeCycleFlagsChange(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int32 oldValue, System.Int32 newValue); // 0x05e5ce50
	System.Void OnWeaponDeploy(System.Int64 charEntityId, System.Int64 weaponEntityId); // 0x05e5d038
	static System.Void CleanAudioAndEffects(System.Int64 charEntityId, WizardGames.Soc.Common.Entity.IEntity owner, System.Boolean force); // 0x05e5bba8
	System.Void OnDestroy(); // 0x05e5d0e4
	System.Int32 GetFootstepAnimEvTbId(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05e5d280
	WizardGames.Soc.Common.Data.DataItem.AnimEventConfig GetConfig(System.Int32 eventId); // 0x05e5d3bc
	System.Boolean ConfigShouldCheckLod(WizardGames.Soc.Common.Data.DataItem.AnimEventConfig config); // 0x05e5d5b4
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05e5d658
	static System.Boolean buildContext(WizardGames.Soc.Common.Unity.Animation.NewLogicAnimEvent event_data, System.Int64 mainPlayerId, Contexts.ClientContext ctx, WizardGames.Soc.Common.Data.EAnimEventCameraType curCameraType, Animation.Event.AnimNotifyContext& animNotifyContext); // 0x05e5f020
	System.Void CleanOutOfDateEffects(Animation.AnimBehCache animBehCache); // 0x05e5ff8c
	System.Void CleanEffects(System.Collections.Generic.List<Animation.Event.AnimEffectEvent> effects); // 0x05e6001c
	System.Void CleanOutOfDateNotify(System.Single curTime, Animation.AnimBehCache animBehCache); // 0x05e5fee0
	System.Void CleanNotify(System.Single curTime, System.Collections.Generic.List<Animation.Event.AnimAudioEvent> notifyList); // 0x05e6015c
	System.Void .ctor(); // 0x05e6026c
	static System.Void .cctor(); // 0x05e602d4
}

// Client.Runtime
class _workroom.CarPhysicsView : UnityEngine.MonoBehaviour
{
	CarPhysicsViewData CarPhysicsViewData; // 0x30
	System.Void Start(); // 0x05e60400
	System.Void .ctor(); // 0x05e6049c
}

// Client.Runtime
class _workroom.RigidbodyDebug : UnityEngine.MonoBehaviour
{
	UnityEngine.Rigidbody Rigidbody; // 0x30
	System.Boolean IsSleeping; // 0x38
	System.Single brakeTorque; // 0x3c
	System.Void Start(); // 0x05e60504
	System.Void Update(); // 0x05e60590
	System.Void Refresh(); // 0x05e605f4
	System.Void .ctor(); // 0x05e60670
}

// Client.Runtime
class _workroom.WheelDebug : UnityEngine.MonoBehaviour
{
	UnityEngine.WheelCollider Collider; // 0x30
	System.Single motorTorque; // 0x38
	System.Single brakeTorque; // 0x3c
	System.Void Start(); // 0x05e606d8
	System.Void Update(); // 0x05e60764
	System.Void Refresh(); // 0x05e607c8
	System.Void .ctor(); // 0x05e60854
}

// Client.Runtime
class SocVehicle.Scripts.Light.VehicleLight : UnityEngine.MonoBehaviour
{
	System.Boolean IsBreak; // 0x30
	System.Int32 LightEffectId; // 0x34
	System.Int32 LightId; // 0x38
	Effect.EffectItemHandle<Effect.EffectItem> lightEffect; // 0x40
	WizardGames.Soc.SocClient.ClientLight.LightItem lightItem; // 0x50
	System.Boolean isActive; // 0x58
	System.Boolean isLightActive; // 0x59
	System.Void SetLightVisuals(System.Boolean headlightsOn, System.Boolean brakesOn, System.Int64 vehicleId, System.Int64 parentVehicleId); // 0x05e608bc
	System.Void SetLight(System.Boolean value, System.Boolean showLight); // 0x05e60c68
	static System.Void SetLightVisuals(System.Collections.Generic.IReadOnlyList<SocVehicle.Scripts.Light.VehicleLight> lights, System.Boolean headlightsOn, System.Boolean brakesOn, System.Int64 vehicleId, System.Int64 parentVehicleId); // 0x05e60f20
	System.Void .ctor(); // 0x05e61234
}

// Client.Runtime
class SocVehicle.Scripts.Entity.Vehicle.GroundVehicleAudio : UnityEngine.MonoBehaviour
{
	SocVehicle.Scripts.Entity.Vehicle.VehicleSoundConf SoundConf; // 0x30
	System.Void .ctor(); // 0x05e6129c
}

// Client.Runtime
class SocVehicle.Scripts.Entity.Vehicle.VehicleSoundConf : System.Object
{
	System.Boolean OpenDbg; // 0x10
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf CopterAlarmSoundDef; // 0x18
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf CopterEngineStartDef; // 0x30
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf CopterEngineStopDef; // 0x48
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf CopterDamageDef; // 0x60
	System.String CopterRTPCRevSpeed; // 0x78
	System.String CarRTPCVehicleSpeed; // 0x80
	System.String CarRTPCRevSpeed; // 0x88
	System.String BoatRTPCVehicleSpeed; // 0x90
	System.String BoatRTPCRevSpeed; // 0x98
	SerializableDictionary<WizardGames.Soc.Common.Unity.Go.SeatType,WizardGames.Soc.Common.Unity.Audio.GameAudioConf> mountSoundDefs; // 0xa0
	SerializableDictionary<WizardGames.Soc.Common.Unity.Go.SeatType,WizardGames.Soc.Common.Unity.Audio.GameAudioConf> swapSoundDefs; // 0xa8
	SerializableDictionary<WizardGames.Soc.Common.Unity.Go.SeatType,WizardGames.Soc.Common.Unity.Audio.GameAudioConf> dismountSoundDefs; // 0xb0
	System.Single hit_test_dist; // 0xb8
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf engineStartSound; // 0xc0
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf engineStopSound; // 0xd8
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf engineStartFailSound; // 0xf0
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf engineLoopsSound; // 0x108
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf badPerformanceLoop; // 0x120
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf HoodOpenSoundDef; // 0x138
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf HoodCloseSoundDef; // 0x150
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf ShutterOpenSoundDef; // 0x168
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf ShutterCloseSoundDef; // 0x180
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf CollisionAudioConf; // 0x198
	System.Single CollisionAudioSpeedThreshOld; // 0x1b0
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf VehiclePushSoundDef; // 0x1b8
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf VehicleFireStartSoundDef; // 0x1d0
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf VehicleFireGanRaoDanSoundDef; // 0x1e8
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf GanRaoDanLoopSoundDef; // 0x200
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf VehicleRepairSuccessSoundDef; // 0x218
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf movementSplashAccentSoundDef; // 0x230
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf engineSteerSoundDef; // 0x248
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf BoatPushInWaterSoundDef; // 0x260
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf BoatPushInLandSoundDef; // 0x278
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf waterSplashSoundDef; // 0x290
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf waterLoops; // 0x2a8
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf brakeSoundDef; // 0x2c0
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf lightsToggleSound; // 0x2d8
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf hornLoop; // 0x2f0
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf hornStart; // 0x308
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf skidSoundLoop; // 0x320
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf skidSoundDirtLoop; // 0x338
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf skidSoundSnowLoop; // 0x350
	System.Single SkidThrottleThreshold; // 0x368
	System.Single skidMinSlip; // 0x36c
	System.Single skidMaxSlip; // 0x370
	System.Single skidratiochangerate; // 0x374
	System.Single skinplaythreshold; // 0x378
	System.Single isStationaryThreshold; // 0x37c
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf movementStartOneshot; // 0x380
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf movementStopOneshot; // 0x398
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf movementRattleLoop; // 0x3b0
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf suspensionLurchSound; // 0x3c8
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf suspensionMinLurchSound; // 0x3e0
	System.Single movementStartStopMinTimeBetweenSounds; // 0x3f8
	System.Single suspensionLurchMinExtensionDelta; // 0x3fc
	System.Single suspensionLurchMaxExtensionDelta; // 0x400
	System.Single suspensionLurchMinTimeBetweenSounds; // 0x404
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf tyreRollingSoundDef; // 0x408
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf tyreRollingWaterSoundDef; // 0x420
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf tyreRollingGrassSoundDef; // 0x438
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf tyreRollingSnowSoundDef; // 0x450
	System.Void .ctor(); // 0x05e61304
}

// Client.Runtime
class SocProfiler.Runtime.OverheadRecorder : System.Object
{
	System.Boolean IsRecordGCAlloc; // 0x10
	Unity.Profiling.ProfilerMarker _marker; // 0x18
	Unity.Profiling.ProfilerRecorder _recorder; // 0x20
	System.Int32 Deep; // 0x28
	System.Int64 _begin; // 0x30
	System.Int64 _end; // 0x38
	System.Double lastGC; // 0x40
	System.Double lastTime; // 0x48
	System.Double totalTime; // 0x50
	System.Int32 count; // 0x58
	System.Int64 <GCAlloc>k__BackingField; // 0x60
	System.String <Name>k__BackingField; // 0x68
	System.Diagnostics.Stopwatch _stopwatch; // 0x70
	System.Int32 get_Count(); // 0x05e616fc
	System.Int64 get_GCAlloc(); // 0x05e61760
	System.Void set_GCAlloc(System.Int64 value); // 0x05e617c4
	System.String get_Name(); // 0x05e6183c
	System.Void .ctor(System.String name); // 0x05e618a0
	System.Void Begin(); // 0x05e619ac
	System.Double End(); // 0x05e61a6c
	System.Void Reset(); // 0x05e61ca0
	System.String Content(); // 0x05e61d0c
}

// Client.Runtime
class SocProfiler.Runtime.RecorderGroup : System.Object
{
	System.Collections.Generic.Dictionary<System.String,SocProfiler.Runtime.OverheadRecorder> RecorderMapping; // 0x10
	System.Void .ctor(); // 0x05e62008
	System.Boolean TryGetValue(System.String maker, SocProfiler.Runtime.OverheadRecorder& recorder); // 0x05e620bc
	System.Void Add(System.String maker, SocProfiler.Runtime.OverheadRecorder recorder); // 0x05e62164
	System.Void Reset(); // 0x05e6220c
}

// Client.Runtime
class SocProfiler.Runtime.SocRuntimeProfiler : System.Object
{
	static SocLogger logger; // 0x0
	static Unity.Profiling.ProfilerRecorder GCAllocatedInFrame; // 0x8
	static System.Collections.Generic.Dictionary<System.String,SocProfiler.Runtime.RecorderGroup> _recorderGroups; // 0x10
	static System.Collections.Generic.Dictionary<System.String,System.Int32> _deeps; // 0x18
	static System.Void .cctor(); // 0x05e62398
	static System.Void Begin(System.String group, System.String marker, System.Boolean recordGCAlloc); // 0x05e62568
	static System.Double End(System.String group, System.String marker); // 0x05e627ec
	static System.String Content(System.String group); // 0x05e62b40
}

// Client.Runtime
class SocProfiler.Runtime.UnitExtension : System.Object
{
	
	static System.Double toKB(System.Int64 value); // 0x05e61c38
}

// Client.Runtime
class Framework.Replay.ReplayInputController : WizardGames.Soc.SocClient.Control.MgrControl
{
	
	System.Void Init(); // 0x05fd76c0
	System.Void CollectInput(); // 0x05fd77e8
	System.Void .ctor(); // 0x05fd7848
}

// Client.Runtime
class Framework.Replay.ReplayMgrCamera : WizardGames.Soc.Common.Unity.MgrCamera
{
	
	System.Void RenderUpdate(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x05fd78b0
	System.Void .ctor(); // 0x05fd7c4c
}

// Client.Runtime
class Framework.Replay.ReplayMgrEntityGo : WizardGames.Soc.SocClient.Go.MgrEntityGo
{
	
	System.Void .ctor(); // 0x05fd7cd8
}

// Client.Runtime
class Framework.Replay.ReplayMgrMyPlayer : WizardGames.Soc.Common.Syncronization.MgrMyPlayer
{
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.SimpleCustom.ReplayUserCmd> replayCmds; // 0x2b0
	System.Int32 ReplayCmdSeq; // 0x2b8
	System.Int32 LastVisitCmdSeq; // 0x2bc
	System.Int32 RemoveTime; // 0x2c0
	System.Int32 MaxPersistentCmd; // 0x2c4
	System.Int32 LastRemoveTime; // 0x2c8
	System.Boolean CollectCmd; // 0x2cc
	System.Void FillReplayCmd(WizardGames.Soc.Common.SimpleCustom.ReplayUserCmd cmd); // 0x05fd7d64
	System.Void Init(); // 0x05fd7e30
	System.Void PredictMove(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x05fd7edc
	System.Void RemoveOldCmds(System.Int32 MaxCmd); // 0x05fd80c0
	System.Void Start(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity); // 0x05fd8368
	System.Void .ctor(); // 0x05fd83e8
}

// Client.Runtime
class Framework.Replay.ReplayMgrPredict : WizardGames.Soc.Common.Syncronization.MgrPredict
{
	
	System.Void CompareHistory(); // 0x05fd84d0
	System.Void Rollback(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity, System.Int64 cmdSequence, WizardGames.Soc.Common.Entity.HistoryPlayerEntity localEntity); // 0x05fd8570
	System.Void SaveUserCmdResultHistory(); // 0x05fd8654
	System.Void .ctor(); // 0x05fd86f4
}

// Client.Runtime
class Framework.Replay.ReplayMgrUserCmd : WizardGames.Soc.Common.Syncronization.MgrUserCmd
{
	
	System.Void SendUserCmd(System.Int64 serverWorldTime, System.Int64 renderTime, System.Boolean isOnline); // 0x05fd8780
	System.Void CreateUserCmd(); // 0x05fd886c
	System.Void SetCmdSequence(System.Int32 cmdSequence); // 0x05fd895c
	System.Void .ctor(); // 0x05fd89e8
}

// Client.Runtime
class Framework.Replay.ReplayPlayerMgr : System.Object
{
	static Framework.Replay.ReplayPlayerMgr _; // 0x0
	static SocLogger logger; // 0x8
	WizardGames.Soc.Common.Unity.CameraState CurrentState; // 0x10
	System.Boolean InitView; // 0x14
	System.Boolean Inited; // 0x15
	System.Void Register(); // 0x05fd8a74
	System.Void UnRegister(); // 0x05fd8f84
	System.Void Init(); // 0x05fd9494
	System.Void Destroy(); // 0x05fd973c
	System.Void PreUpdate(System.Single dt); // 0x05fd97a0
	static System.Void ForceTpView(WizardGames.Soc.Common.Syncronization.MgrMyPlayer myPlayer); // 0x05fd9bd8
	System.Void PostUpdate(System.Single dt); // 0x05fdbc6c
	System.Void .ctor(); // 0x05fdbe8c
	static System.Void .cctor(); // 0x05fdbefc
}

// Client.Runtime
class Framework.Replay.ReplayPlayerMgr.<>c : System.Object
{
	static Framework.Replay.ReplayPlayerMgr.<>c <>9; // 0x0
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.SocClient.Control.MgrControl> <>9__6_0; // 0x8
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.Common.Syncronization.MgrPredict> <>9__6_1; // 0x10
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.Common.Syncronization.MgrMyPlayer> <>9__6_2; // 0x18
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.Common.Syncronization.MgrUserCmd> <>9__6_3; // 0x20
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.SocClient.Go.MgrEntityGo> <>9__6_4; // 0x28
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.Common.Unity.MgrCamera> <>9__6_5; // 0x30
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.SocClient.Control.MgrControl> <>9__7_0; // 0x38
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.Common.Syncronization.MgrPredict> <>9__7_1; // 0x40
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.Common.Syncronization.MgrMyPlayer> <>9__7_2; // 0x48
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.Common.Syncronization.MgrUserCmd> <>9__7_3; // 0x50
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.SocClient.Go.MgrEntityGo> <>9__7_4; // 0x58
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.Common.Unity.MgrCamera> <>9__7_5; // 0x60
	static System.Void .cctor(); // 0x05fdc000
	System.Void .ctor(); // 0x05fdc064
	WizardGames.Soc.SocClient.Control.MgrControl& <Register>b__6_0(); // 0x05fdc0cc
	WizardGames.Soc.Common.Syncronization.MgrPredict& <Register>b__6_1(); // 0x05fdc15c
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer& <Register>b__6_2(); // 0x05fdc1ec
	WizardGames.Soc.Common.Syncronization.MgrUserCmd& <Register>b__6_3(); // 0x05fdc27c
	WizardGames.Soc.SocClient.Go.MgrEntityGo& <Register>b__6_4(); // 0x05fdc30c
	WizardGames.Soc.Common.Unity.MgrCamera& <Register>b__6_5(); // 0x05fdc39c
	WizardGames.Soc.SocClient.Control.MgrControl& <UnRegister>b__7_0(); // 0x05fdc42c
	WizardGames.Soc.Common.Syncronization.MgrPredict& <UnRegister>b__7_1(); // 0x05fdc4bc
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer& <UnRegister>b__7_2(); // 0x05fdc54c
	WizardGames.Soc.Common.Syncronization.MgrUserCmd& <UnRegister>b__7_3(); // 0x05fdc5dc
	WizardGames.Soc.SocClient.Go.MgrEntityGo& <UnRegister>b__7_4(); // 0x05fdc66c
	WizardGames.Soc.Common.Unity.MgrCamera& <UnRegister>b__7_5(); // 0x05fdc6fc
}

// Client.Runtime
class Framework.Replay.ReplayTouchInput : WizardGames.Soc.SocClient.Control.TouchInput
{
	
	System.Void Update(System.Single dt); // 0x05fdc78c
	System.Void .ctor(); // 0x05fd775c
}

// Client.Runtime
class Framework.Replay.ReplayUtils : System.Object
{
	static SocLogger Logger; // 0x0
	static System.Boolean ShouldRollback(); // 0x05fd7bbc
	static Framework.Replay.ReplayDetailInfo GetReplayDetailInfo(WizardGames.Soc.Share.Framework.RecordInfo recordInfo, Share.Framework.Replay.ReplayReader& replayReader); // 0x05fdc800
	static System.Void ShallowCopyDiff(WizardGames.Soc.Common.Entity.PlayerEntity self, WizardGames.Soc.Common.Entity.PlayerEntity other); // 0x05fdd038
	static System.Void ShallowCopy(WizardGames.Soc.Common.Entity.PlayerEntity self, WizardGames.Soc.Common.Entity.PlayerEntity other); // 0x05fd9d94
	static T CloneOrCopyData<T>(T target, T src); // 0x052af1f0
	static T CloneOrCopyDataDic<T>(T target, T src); // 0x052af1f0
	static System.Void ReplaceMcCommon<T,U>(Framework.Replay.ReplayUtils.OnGetMcTarget<U> action); // 0x052af1f0
	static System.Void RevertReplaceMcCommon<T,U>(Framework.Replay.ReplayUtils.OnGetMcTarget<T> action); // 0x052af1f0
	static System.Void ReplaceMc<T,U>(Framework.Replay.ReplayUtils.OnGetMcTarget<U> action); // 0x052af1f0
	static System.Void .cctor(); // 0x05fe0504
}

// Client.Runtime
class Framework.Replay.ReplayUtils.OnGetMcTarget<T> : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05525a60
	T& Invoke(); // 0x054e7844
}

// Client.Runtime
class Framework.Replay.ReplayUtils.<>c__10<T,U> : System.Object
{
	static Framework.Replay.ReplayUtils.<>c__10<T,U> <>9; // 0x0
	static System.Func<WizardGames.Soc.Common.Manager.MgrBase> <>9__10_0; // 0x8
	static System.Func<WizardGames.Soc.Common.Manager.MgrBase> <>9__10_1; // 0x10
	static System.Void .cctor(); // 0x054fd168
	System.Void .ctor(); // 0x055049cc
	WizardGames.Soc.Common.Manager.MgrBase <RevertReplaceMcCommon>b__10_0(); // 0x054e7844
	WizardGames.Soc.Common.Manager.MgrBase <RevertReplaceMcCommon>b__10_1(); // 0x054e7844
}

// Client.Runtime
class Framework.Replay.ReplayUtils.<>c__9<T,U> : System.Object
{
	static Framework.Replay.ReplayUtils.<>c__9<T,U> <>9; // 0x0
	static System.Func<WizardGames.Soc.Common.Manager.MgrBase> <>9__9_0; // 0x8
	static System.Func<WizardGames.Soc.Common.Manager.MgrBase> <>9__9_1; // 0x10
	static System.Void .cctor(); // 0x054fd168
	System.Void .ctor(); // 0x055049cc
	WizardGames.Soc.Common.Manager.MgrBase <ReplaceMcCommon>b__9_0(); // 0x054e7844
	WizardGames.Soc.Common.Manager.MgrBase <ReplaceMcCommon>b__9_1(); // 0x054e7844
}

// Client.Runtime
class Framework.Replay.MgrReplayTime : WizardGames.Soc.Common.Synchronization.MgrTime
{
	
	System.Void UpdateRenderTime(System.Int32 timeInterval); // 0x05fe05d8
	System.Void SetRenderWorldTime(System.Int64 renderWorldTime); // 0x05fe06ec
	System.Void .ctor(); // 0x05fe076c
}

// Client.Runtime
class Framework.Replay.ReplayClientService : WizardGames.Soc.SocClient.Network.SocClientService
{
	static SocLogger logger; // 0x0
	Framework.Replay.ReplayNetworkEndpoint _Endpoint; // 0x58
	System.Void StartService(); // 0x05fe07f8
	System.Void StopService(); // 0x05fe12c0
	System.Void UpdateService(System.Boolean canBlock, System.Int32 warningCount); // 0x05fe1328
	System.Void HandlePacket(WizardGames.Soc.Common.Framework.Network.BasePacket packet); // 0x05fe13a4
	System.Void .ctor(); // 0x05fe1424
	static System.Void .cctor(); // 0x05fe1648
}

// Client.Runtime
class Framework.Replay.ReplayNetworkEndpoint : System.Object, WizardGames.Soc.Common.Framework.Network.Client.INetworkEndpoint, WizardGames.Soc.Common.Framework.Network.Client.INetworkEndpointForClient, SocDevKit.Network.IClientRpcLimitCheck
{
	static SocLogger logger; // 0x0
	System.Boolean _IsConnected; // 0x10
	System.Action <OnConnected>k__BackingField; // 0x18
	System.Action <OnConnectFailed>k__BackingField; // 0x20
	System.Action<WizardGames.Soc.Common.Framework.Network.DisconnectReason> <OnDisconnect>k__BackingField; // 0x28
	System.Collections.Concurrent.ConcurrentQueue<WizardGames.Soc.Common.Framework.Network.BasePacket> <DecodedPackets>k__BackingField; // 0x30
	System.Collections.Generic.Dictionary<System.Int32,SocDevKit.Network.RpcLimitCallRecord> <LimitCallRecords>k__BackingField; // 0x38
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> <OverLimitCount>k__BackingField; // 0x40
	System.Int64 <DurationStartTimeStamp>k__BackingField; // 0x48
	System.Boolean get_IsWorking(); // 0x05fe171c
	System.Action get_OnConnected(); // 0x05fe1780
	System.Void set_OnConnected(System.Action value); // 0x05fe17e4
	System.Action get_OnConnectFailed(); // 0x05fe1864
	System.Void set_OnConnectFailed(System.Action value); // 0x05fe18c8
	System.Action<WizardGames.Soc.Common.Framework.Network.DisconnectReason> get_OnDisconnect(); // 0x05fe1948
	System.Void set_OnDisconnect(System.Action<WizardGames.Soc.Common.Framework.Network.DisconnectReason> value); // 0x05fe19ac
	System.Collections.Concurrent.ConcurrentQueue<WizardGames.Soc.Common.Framework.Network.BasePacket> get_DecodedPackets(); // 0x05fe1a2c
	System.Void SendPacket(WizardGames.Soc.Common.Framework.Network.IOutgoingPacket packet); // 0x05fe1a90
	System.Void Disconnect(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x05fe1b04
	System.Void Connect(); // 0x05fe1bec
	System.Collections.Generic.Dictionary<System.Int32,SocDevKit.Network.RpcLimitCallRecord> get_LimitCallRecords(); // 0x05fe1cbc
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> get_OverLimitCount(); // 0x05fe1d20
	System.Int64 get_DurationStartTimeStamp(); // 0x05fe1d84
	System.Void set_DurationStartTimeStamp(System.Int64 value); // 0x05fe1de8
	System.Void .ctor(); // 0x05fe14e4
	static System.Void .cctor(); // 0x05fe1e60
}

// Client.Runtime
enum Framework.Replay.ReplayMode : System.Enum
{
	System.Int32 value__; // 0x10
	static Framework.Replay.ReplayMode ReplayPredict = 0;
	static Framework.Replay.ReplayMode ReplayObserver = 1;
	
}

// Client.Runtime
class Framework.Replay.ReplayConfig : System.Object
