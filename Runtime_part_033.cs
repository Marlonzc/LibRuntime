	FairyGUI.GComponent _n33; // 0x348
	FairyGUI.GComponent _n37; // 0x350
	WizardGames.Soc.SocClient.Ui.ComTopBar _topBar; // 0x358
	FairyGUI.GList _list; // 0x360
	FairyGUI.GTextField _secTextField; // 0x368
	FairyGUI.GTextField _n55; // 0x370
	FairyGUI.GImage _n50; // 0x378
	FairyGUI.GTextField _difficultyLevel; // 0x380
	FairyGUI.Controller _state; // 0x388
	WizardGames.Soc.Common.Data.monument.BoyBandGame _cfg; // 0x390
	WizardGames.Soc.SocClient.Ui.EAngleType _angleType; // 0x398
	WizardGames.Soc.Common.Entity.BoxEntity _boxEntity; // 0x3a0
	System.Int64[] _gameIds; // 0x3a8
	System.Boolean _gameStarted; // 0x3b0
	System.Int32 _gameStartedTime; // 0x3b4
	System.Int32 _lastSecondTimeStamp; // 0x3b8
	System.Int64 _waitStartTimer; // 0x3c0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComAngle> _angleComponents; // 0x3c8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComCursor> _cursorComponents; // 0x3d0
	FairyGUI.Transition _buttonShow; // 0x3d8
	FairyGUI.Transition _loopWarning; // 0x3e0
	FairyGUI.Transition _showAnim; // 0x3e8
	System.Single _rotationalAnimationEffect; // 0x3f0
	System.Single _rotationalAnimationSpeed; // 0x3f4
	WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame.EGameOverState _gameOverState; // 0x3f8
	System.Int32 _gamePhase; // 0x3fc
	System.Int64 _timerValidSuccess; // 0x400
	FairyGUI.Controller _n17Controller; // 0x408
	WizardGames.Soc.Common.Data.units.TreasureBox _teasureBox; // 0x410
	System.Int32 _angle; // 0x418
	System.Int32 get_GamePhase(); // 0x0655418c
	System.Void set_GamePhase(System.Int32 value); // 0x065541f0
	WizardGames.Soc.Common.Component.BoxGameComponent get_boxGameComponent(); // 0x06554450
	System.Void OnInit(); // 0x065544e0
	System.Void OnEnable(); // 0x06554da4
	System.Void OnDisable(); // 0x06554e0c
	System.Void OnBackClick(FairyGUI.EventContext context); // 0x06554e74
	WizardGames.Soc.SocClient.Ui.ComAngle CreateAngle(System.Single angle, System.String resName); // 0x06555344
	WizardGames.Soc.SocClient.Ui.ComCursor CreateCursor(System.Single angle, System.String resName); // 0x06555460
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0655557c
	System.Void OnDestroy(); // 0x065555f8
	System.Void Clear(); // 0x06555668
	System.Void ShowTime(System.Boolean visible); // 0x06555e3c
	System.Void StopGame(); // 0x06555ef8
	System.Void StartGame(); // 0x0655702c
	System.Void OnMiniGameIsFinished(); // 0x06556e18
	System.Void OnMiniGameIsFailed(); // 0x065574e8
	System.Void OnChoose(); // 0x065577b8
	System.Void Init(WizardGames.Soc.Common.Entity.BoxEntity boxEntity, WizardGames.Soc.Common.Data.units.TreasureBox treasureBox); // 0x065578ec
	System.Void RefreshUi(); // 0x06557c90
	System.Void CreateAngleType(System.Int32 count, System.Single angleUnit, System.String resName, System.Int32[] keyholeStartPos, System.Int32[] leafStartPos, UnityEngine.Vector3 centerPosition, UnityEngine.Vector3 leafCenterPosition); // 0x06558448
	System.Void WaitStart(); // 0x06557340
	System.Void OnWaitStart(System.Int64 timerid, System.Object o, System.Boolean delete); // 0x06558910
	System.Void ItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x06558a74
	static System.Void ShowBoxOpeningGame(WizardGames.Soc.Common.Entity.BoxEntity boxEntity); // 0x06558dc4
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x06558f64
	System.Void UpdateGameOverState(System.Single dt); // 0x06559468
	System.Void UpdateTime(System.Single dt); // 0x06558fec
	static System.Void CloseBoxOpeningGame(); // 0x0655783c
	System.Void .ctor(); // 0x06559bd4
	static System.Void .cctor(); // 0x06559d1c
	System.Void <OnBackClick>b__43_1(); // 0x06559df0
	System.Void <StopGame>b__50_3(); // 0x06559e54
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame.EGameOverState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame.EGameOverState None = -1;
	static WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame.EGameOverState InitAnimation = 0;
	static WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame.EGameOverState WaitStart = 1;
	static WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame.EGameOverState ValidSuccess = 2;
	static WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame.EGameOverState ValidFail = 3;
	static WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame.EGameOverState LockAnimation1 = 4;
	static WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame.EGameOverState LeafExit = 5;
	static WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame.EGameOverState LockAnimation2 = 6;
	static WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame.EGameOverState End = 7;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame.<>c <>9; // 0x0
	static System.Action <>9__43_0; // 0x8
	static FairyGUI.PlayCompleteCallback <>9__50_0; // 0x10
	static FairyGUI.PlayCompleteCallback <>9__63_0; // 0x18
	static System.Void .cctor(); // 0x0655a42c
	System.Void .ctor(); // 0x0655a490
	System.Void <OnBackClick>b__43_0(); // 0x0655a4f8
	System.Void <StopGame>b__50_0(); // 0x0655a558
	System.Void <UpdateGameOverState>b__63_0(); // 0x0655a60c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame.<>c__DisplayClass50_0 : System.Object
{
	System.Int32 i; // 0x10
	WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame <>4__this; // 0x18
	System.Void .ctor(); // 0x0655a6c0
	System.Void <StopGame>b__1(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x0655a728
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame.<>c__DisplayClass50_1 : System.Object
{
	FairyGUI.GComponent com; // 0x10
	System.Void .ctor(); // 0x0655aadc
	System.Void <StopGame>b__2(); // 0x0655ab44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame.<>c__DisplayClass55_0 : System.Object
{
	FairyGUI.GComponent com; // 0x10
	System.Void .ctor(); // 0x0655ac4c
	System.Void <Init>b__0(); // 0x0655acb4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSwipeCardGame : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x338
	FairyGUI.GList lightList; // 0x340
	FairyGUI.GList lightBgList; // 0x348
	System.Collections.Generic.List<FairyGUI.Controller> lightCtrlList; // 0x350
	System.Collections.Generic.List<FairyGUI.Controller> lightBgCtrlList; // 0x358
	System.Collections.Generic.List<FairyGUI.Transition> lightBgAnimList; // 0x360
	WizardGames.Soc.SocClient.Ui.UiPoint[,] uiPointsArray; // 0x368
	FairyGUI.GComponent graphLineCom; // 0x370
	FairyGUI.GComponent graphPointCom; // 0x378
	FairyGUI.GList graphPointList; // 0x380
	FairyGUI.GComponent lightCom; // 0x388
	FairyGUI.Transition lightTrans; // 0x390
	FairyGUI.GLoader lineLoader; // 0x398
	FairyGUI.GButton handleBtn; // 0x3a0
	FairyGUI.GTextField startupText; // 0x3a8
	FairyGUI.GImage guideMask; // 0x3b0
	FairyGUI.GButton helpBtn; // 0x3b8
	FairyGUI.GGroup timeGroup; // 0x3c0
	FairyGUI.GTextField minTextField; // 0x3c8
	FairyGUI.GTextField secTextField; // 0x3d0
	FairyGUI.GTextField leftTime; // 0x3d8
	FairyGUI.GTextField startText; // 0x3e0
	FairyGUI.GTextField SuccessText; // 0x3e8
	FairyGUI.Controller handleCtrl; // 0x3f0
	FairyGUI.Controller stateCtrl; // 0x3f8
	SharedUnity.EGameState curState; // 0x400
	System.Int64 gameOverTimeTs; // 0x408
	System.Int32 gameCountdownMs; // 0x410
	WizardGames.Soc.SocClient.Ui.Vertex tempVertexUp; // 0x414
	WizardGames.Soc.SocClient.Ui.Vertex tempVertexRight; // 0x41c
	WizardGames.Soc.SocClient.Ui.Vertex tempVertexDown; // 0x424
	WizardGames.Soc.SocClient.Ui.Vertex tempVertexLeft; // 0x42c
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.Vertex,System.Int32> tempVertexToWeightDic; // 0x438
	System.Int64 mResetLeftTimeMs; // 0x440
	System.Int64 mFuseBoxEntityId; // 0x448
	WizardGames.Soc.Common.Entity.IOEntity iOEntity; // 0x450
	System.Int32 mLeftGuaranteedNum; // 0x458
	System.Int32 mSumGuaranteedNum; // 0x45c
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> successPath; // 0x460
	System.Int32 circuitBoxTimeMs; // 0x468
	System.Int64 connectedTimeId; // 0x470
	System.Int64 connectingTimeId; // 0x478
	System.Int64 effectUpdateTimeId; // 0x480
	System.Int64 coolDownTimeId; // 0x488
	FairyGUI.Transition feedbackAnim; // 0x490
	System.Boolean playCountdownSound; // 0x498
	UnityEngine.GameObject fxPrefabGo; // 0x4a0
	System.Boolean guideStarted; // 0x4a8
	FairyGUI.GComponent content; // 0x4b0
	System.String initLineUrl; // 0x4b8
	System.String blueLineUrl; // 0x4c0
	System.String redLineUrl; // 0x4c8
	System.String greenLineUrl; // 0x4d0
	System.String purpleLineUrl; // 0x4d8
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EPointColor,WizardGames.Soc.SocClient.Ui.UiSwipeCardGame.MovingEffect> effectDic; // 0x4e0
	System.Collections.Generic.List<UnityEngine.Vector2> tempRoadPosList; // 0x4e8
	System.Int32 curGraphId; // 0x4f0
	WizardGames.Soc.SocClient.Ui.ConnectedGraph graph; // 0x4f8
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> roadWeightDic; // 0x500
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Vertex> curRoadVertexList; // 0x508
	WizardGames.Soc.SocClient.Ui.Vertex curVertex; // 0x510
	WizardGames.Soc.SocClient.Ui.Vertex roadOriginVertex; // 0x518
	System.Int32 roadOriginWeight; // 0x520
	System.Int32 roadLength; // 0x524
	System.Boolean isMouseDown; // 0x528
	System.Int32 graphWidth; // 0x52c
	System.Int32 graphHeight; // 0x530
	System.Int32 blueOrigin; // 0x534
	System.Int32 blueRoad; // 0x538
	System.Int32 redOrigin; // 0x53c
	System.Int32 redRoad; // 0x540
	System.Int32 greenOrigin; // 0x544
	System.Int32 greenRoad; // 0x548
	System.Int32 purpleOrigin; // 0x54c
	System.Int32 purpleRoad; // 0x550
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.EPointColor> weightToColorDic; // 0x558
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> originToRoadDic; // 0x560
	System.Void OnInit(); // 0x0655adbc
	System.Void OnEnable(); // 0x0655c508
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0655c570
	System.Void OnFastReconnected(); // 0x0655cb5c
	System.Void Init(System.Int32 graphId, System.Int32 state, System.Int32 resetLeftTime, System.Int64 fuseBoxEntityId, System.Int32 leftGuaranteedNum, WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> gameSuccessPath); // 0x05505cc8
	System.Void InitGraph(System.Int32 graphId, System.Boolean isCompleted); // 0x0655d808
	System.Void DrawGraph(System.Boolean isCompleted); // 0x0655dd64
	System.Boolean IsSameColorWeight(System.Int32 weightX, System.Int32 weightY); // 0x0655efb4
	System.Void ClearGraph(); // 0x0655f27c
	System.Void CoolDownTimer(System.Int64 timerid, System.Object o, System.Boolean delete); // 0x0655fc4c
	System.Void OnDisable(); // 0x0655fec4
	System.Void OnDestroy(); // 0x06560198
	System.Void GameOver(System.Boolean isSuccess); // 0x05523a7c
	System.Void CancelEffectTimmer(System.Int64 timerId, System.Object callbackData, System.Boolean needDelete); // 0x06560d3c
	System.Void OnRenderLightList(System.Int32 index, FairyGUI.GObject obj); // 0x06560e68
	System.Void OnRenderLightBgList(System.Int32 index, FairyGUI.GObject obj); // 0x06560fa4
	System.Void SetGreenLight(System.Int32 num); // 0x0655dae8
	System.Void SetScreenLight(System.Int32 num, System.Boolean needAnim); // 0x0655d89c
	System.Void OnRenderLine(System.Int32 index, FairyGUI.GObject obj); // 0x065611e4
	System.Void OnRenderPoint(System.Int32 index, FairyGUI.GObject obj); // 0x065617f4
	System.Void OnTouchPointAction(); // 0x06561cfc
	System.Void OnRollOverPointAction(WizardGames.Soc.SocClient.Ui.Vertex vertex); // 0x06561d64
	System.Int32 GetGreenLightNum(); // 0x06562b3c
	System.Void OnHandleBtnClick(); // 0x055049cc
	System.Void ConnectedTimer(System.Int64 timerId, System.Object callbackData, System.Boolean needDelete); // 0x065637b8
	System.Void ConnectingTimer(System.Int64 timerId, System.Object callbackData, System.Boolean needDelete); // 0x06563884
	System.Void GiveUp(); // 0x06564014
	System.Void OnHelpBtnClick(); // 0x06564154
	System.Void UpdateSwipeCardGameState(System.Int32 graphId, System.Int32 state, System.Int32 leftGuaranteedNum, System.Int64 fuseBoxEntityId); // 0x065641f4
	System.Void OnTouchBegin(FairyGUI.EventContext context); // 0x06564364
	System.Void OnTouchEnd(); // 0x065649b4
	System.Void ClearCurRoad(); // 0x0655f468
	System.Void GraphToArray(); // 0x06560c2c
	System.Void ArrayToGraph(); // 0x0655dbd4
	System.Void OnTouchMove(FairyGUI.EventContext context); // 0x06564b7c
	System.Void DrawLine(FairyGUI.EventContext context); // 0x065643e8
	System.Void SetLineLoaderVisible(System.Boolean isShow); // 0x06562a44
	System.Void ParseTime(System.Int64 time); // 0x0655e8fc
	System.Void ResultRpc(System.Boolean success); // 0x0655cbd8
	System.Void ForceCloseRpc(); // 0x06564cd4
	System.Void OnClose(); // 0x0655ca4c
	System.Void InitEffect(); // 0x0655c290
	System.Void ClearEffect(); // 0x0655f6b8
	System.Void EffectStartMoving(WizardGames.Soc.SocClient.Ui.EPointColor color, WizardGames.Soc.SocClient.Ui.Vertex beginVertex, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Vertex> roadList, WizardGames.Soc.SocClient.Ui.Vertex endVertex); // 0x06562590
	System.Void EffectUpdate(System.Int64 timerId, System.Object callbackData, System.Boolean needDelete); // 0x06565064
	System.Boolean get_IsCurVertexEmpty(); // 0x065623a0
	System.Boolean get_ConnectSuccess(); // 0x06563df0
	System.Void CreateGraphData(); // 0x0655bf9c
	System.Void InitGraphWeight(System.Int32 graphId, System.Boolean isCompleted); // 0x0655ebd0
	System.Void InitVertexWeight(System.Int32 widthIndex, System.Int32 heightIndex, System.Int32 weight, System.Boolean isCompleted); // 0x06565474
	System.Void SetCurVertex(System.Int32 widthIndex, System.Int32 heightIndex); // 0x065624ac
	System.Void SetRoadWeight(WizardGames.Soc.SocClient.Ui.Vertex vertex, System.Int32 length); // 0x06562cec
	System.Void SetVertexWeight(WizardGames.Soc.SocClient.Ui.Vertex vertex, System.Int32 weight); // 0x06564a3c
	System.Void SetVertexWeight(System.Int32 widthIndex, System.Int32 heightIndex, System.Int32 weight); // 0x06564ad0
	System.Int32 GetVertexWeight(WizardGames.Soc.SocClient.Ui.Vertex vertex); // 0x0655edb4
	System.Int32 GetVertexWeight(System.Int32 widthIndex, System.Int32 heightIndex); // 0x0655f894
	System.Void CancelCurVertex(); // 0x06562990
	System.Boolean CanConnect(WizardGames.Soc.SocClient.Ui.Vertex targetVertex); // 0x06562418
	System.Boolean IsOriginVertex(WizardGames.Soc.SocClient.Ui.Vertex vertex); // 0x06562dc8
	System.Boolean IsOriginVertex(System.Int32 weight); // 0x0655f1c4
	System.Void ResetRoadDic(); // 0x0655fa48
	System.Void .ctor(); // 0x06565650
	System.Void <OnInit>b__54_0(); // 0x06565b30
	FairyGUI.GObject <OnInit>b__54_1(); // 0x06565c54
	FairyGUI.GObject <OnInit>b__54_2(); // 0x06565d34
	FairyGUI.GObject <OnInit>b__54_3(); // 0x06565f00
	System.Void <OnEscClose>b__56_0(); // 0x06566088
	System.Void <OnEscClose>b__56_1(); // 0x0656617c
	System.Void <GameOver>b__66_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x0656620c
	System.Void <OnRollOverPointAction>b__75_0(); // 0x065662c4
	System.Void <OnRollOverPointAction>b__75_1(); // 0x06566338
	System.Void <OnHandleBtnClick>b__77_0(); // 0x065663ac
	System.Void <OnHandleBtnClick>b__77_1(); // 0x06566410
	System.Void <ConnectingTimer>b__79_0(); // 0x06566474
	System.Void <ConnectingTimer>b__79_2(); // 0x06566504
	System.Void <GiveUp>b__80_0(); // 0x06566594
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSwipeCardGame.MovingEffect : System.Object
{
	System.Collections.Generic.List<UnityEngine.Vector2> movingRoadList; // 0x10
	FairyGUI.GImage effectImg; // 0x18
	System.Single movingTimeMs; // 0x20
	System.Int32 lineTimeMs; // 0x24
	System.Void .ctor(FairyGUI.GImage img); // 0x06564d9c
	System.Void Clear(); // 0x06564e94
	System.Void StartMoving(System.Collections.Generic.List<UnityEngine.Vector2> roadList); // 0x06564f1c
	System.Void EndMoving(); // 0x06566624
	System.Void Update(System.Single dt); // 0x0656524c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSwipeCardGame.<>c__DisplayClass71_0 : System.Object
{
	FairyGUI.Controller ctrl; // 0x10
	System.Void .ctor(); // 0x0656117c
	System.Void <SetScreenLight>b__0(); // 0x065666c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSwipeCardGame.<>c__DisplayClass79_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiForceChooseFullPop.UiInfo info; // 0x10
	WizardGames.Soc.SocClient.Ui.UiSwipeCardGame <>4__this; // 0x18
	System.Void .ctor(); // 0x06563d88
	System.Void <ConnectingTimer>b__1(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x06566734
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSwipeCardGame.<>c__DisplayClass79_1 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiForceChooseFullPop.UiInfo info; // 0x10
	WizardGames.Soc.SocClient.Ui.UiSwipeCardGame <>4__this; // 0x18
	System.Void .ctor(); // 0x06563fac
	System.Void <ConnectingTimer>b__3(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x06566808
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPoint : System.Object
{
	FairyGUI.GComponent lineRoot; // 0x10
	FairyGUI.GComponent pointRoot; // 0x18
	FairyGUI.GGroup line0; // 0x20
	FairyGUI.GGroup line1; // 0x28
	FairyGUI.GGroup line2; // 0x30
	FairyGUI.GGroup line3; // 0x38
	FairyGUI.GLoader centerClickLoader; // 0x40
	FairyGUI.Controller lineColorCtrl; // 0x48
	FairyGUI.Controller pointColorCtrl; // 0x50
	WizardGames.Soc.SocClient.Ui.EPointColor pointColor; // 0x58
	WizardGames.Soc.SocClient.Ui.Vertex vertex; // 0x5c
	WizardGames.Soc.SocClient.Ui.EPointColor get_PointColor(); // 0x065668dc
	UnityEngine.Vector2 get_GraphPos(); // 0x065628f0
	UnityEngine.Vector2 get_Pos(); // 0x06564bf8
	System.Void .ctor(System.Int32 widthIndex, System.Int32 heightIndex); // 0x065613e8
	System.Void InitLine(FairyGUI.GComponent lineRootCom); // 0x06561478
	System.Void InitPoint(FairyGUI.GComponent pointRootCom, System.Action onTouchBeginAction, System.Action<WizardGames.Soc.SocClient.Ui.Vertex> onRollOverAction); // 0x06561ab4
	System.Void HideBg(System.Int32 index); // 0x065616a8
	System.Void AddLine(WizardGames.Soc.SocClient.Ui.Vertex targetPos); // 0x0655f0dc
	System.Void ClearLine(); // 0x0655f928
	System.Void ClearRoad(); // 0x0655f9d8
	System.Void SetColor(WizardGames.Soc.SocClient.Ui.EPointColor color); // 0x0655ee3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPoint.<>c__DisplayClass19_0 : System.Object
{
	System.Action onTouchBeginAction; // 0x10
	System.Action<WizardGames.Soc.SocClient.Ui.Vertex> onRollOverAction; // 0x18
	WizardGames.Soc.SocClient.Ui.UiPoint <>4__this; // 0x20
	System.Void .ctor(); // 0x06566940
	System.Void <InitPoint>b__0(); // 0x065669a8
	System.Void <InitPoint>b__1(); // 0x06566a44
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EPointColor : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EPointColor Init = 0;
	static WizardGames.Soc.SocClient.Ui.EPointColor Blue = 1;
	static WizardGames.Soc.SocClient.Ui.EPointColor Red = 2;
	static WizardGames.Soc.SocClient.Ui.EPointColor Green = 3;
	static WizardGames.Soc.SocClient.Ui.EPointColor Purple = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTreasureHuntGame : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	static SocLogger Logger; // 0x0
	FairyGUI.GComponent _content; // 0x338
	WizardGames.Soc.SocClient.Ui.ComTopBar _topBar; // 0x340
	System.Int64 _gameId; // 0x348
	FairyGUI.GGroup _timeGroup; // 0x350
	FairyGUI.Controller _state; // 0x358
	WizardGames.Soc.Common.Data.monument.TreasureHuntGame _cfg; // 0x360
	WizardGames.Soc.Common.Entity.InteractionEntity _interactionEntity; // 0x368
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ComPlaidDrag,WizardGames.Soc.Common.CustomType.DragElement> _dragElements; // 0x370
	FairyGUI.GList _plaid; // 0x378
	FairyGUI.GLoader _bg; // 0x380
	FairyGUI.GList _rowNumber; // 0x388
	FairyGUI.GList _columnNumber; // 0x390
	System.Int32[,] _results; // 0x398
	WizardGames.Soc.Common.CustomType.CubeMiniGameTaskNode _taskNode; // 0x3a0
	WizardGames.Soc.SocClient.Ui.ComPlaidDrag _comPlaidDrag; // 0x3a8
	FairyGUI.PlayCompleteCallback _onGlowComplete; // 0x3b0
	FairyGUI.GGraph[] _gridGraphsRow; // 0x3b8
	FairyGUI.GGraph[] _gridGraphsColumn; // 0x3c0
	System.Int32[] _rowChanged; // 0x3c8
	System.Int32[] _columnChanged; // 0x3d0
	WizardGames.Soc.Common.Data.units.InteractObj get_TemplateData(); // 0x06566ac8
	System.Int32 get_InteractType(); // 0x06566bcc
	System.Void RegisterEvents(); // 0x06566c40
	System.Void RefreshTasks(); // 0x06566d38
	System.Void UnRegisterEvents(); // 0x065670b4
	System.Void OnEnable(); // 0x065671ac
	System.Void OnDisable(); // 0x0656721c
	System.Void OnInit(); // 0x0656728c
	System.Void OnGlowComplete(); // 0x06567ee8
	System.Void ShowGlow(System.Boolean visible); // 0x065681ac
	System.Void InitGlow(); // 0x06567984
	System.Void OnPlaidRenderer(System.Int32 index, FairyGUI.GObject item); // 0x065682a0
	System.Void OnPlaidDragStart(FairyGUI.EventContext context); // 0x06568674
	System.Void OnPlaidDragMove(FairyGUI.EventContext context); // 0x065687f4
	System.Void OnPlaidDragEnd(FairyGUI.EventContext context); // 0x0656887c
	System.Void ResetPlaid(); // 0x065695e4
	System.Void Init(WizardGames.Soc.Common.Entity.InteractionEntity interactionEntity, System.Int64 gameId, WizardGames.Soc.Common.CustomType.PoiTaskNode taskNode); // 0x065698c4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0656aa7c
	System.Void OnClear(); // 0x0656702c
	System.Void ClearDragElement(); // 0x06569a74
	System.Void RecordMiniGameProcess(); // 0x0656ab0c
	System.Void OnWaitStart(); // 0x0656b118
	System.Void WaitStart(System.Int64 gameId); // 0x06569bc8
	WizardGames.Soc.Common.CustomType.DragElement CreatePart(WizardGames.Soc.Common.Data.monument.TreasureHuntGamePart part, WizardGames.Soc.SocClient.Ui.ComPlaidDrag& comPlaidDrag); // 0x0656b3f0
	static System.Void ShowTreasureHuntGame(WizardGames.Soc.Common.Entity.InteractionEntity interactionEntity, System.Int64 gameId, WizardGames.Soc.Common.CustomType.PoiTaskNode taskNode); // 0x0656b9ac
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x0656bac4
	System.Void CloseTreasureHuntGame(); // 0x0656bb38
	System.Void ResetMiniGame(); // 0x0656b8c8
	System.Void ResetResults(); // 0x0656b1ac
	System.Boolean RandomReplacementPlan(); // 0x0656bbf8
	System.Boolean GuaranteedPlan(); // 0x0656bd80
	System.Boolean Replacement(System.Int32 rowStartIndex, System.Int32 columnStartIndex, WizardGames.Soc.Common.CustomType.DragElement dragElement, WizardGames.Soc.SocClient.Ui.ComPlaidDrag comPlaidDrag); // 0x0656be90
	System.Void UpdateResultsArray(WizardGames.Soc.Common.CustomType.DragElement dragElement, System.Int32 rowIndex, System.Int32 columnIndex, System.Boolean erase); // 0x06569668
	System.Void .ctor(); // 0x0656c2bc
	static System.Void .cctor(); // 0x0656c494
	System.Void <OnInit>b__38_0(System.Int32 index, FairyGUI.GObject item); // 0x0656c568
	System.Void <OnInit>b__38_1(System.Int32 index, FairyGUI.GObject item); // 0x0656c8e0
	System.Void <OnPlaidDragEnd>b__45_0(); // 0x0656cc04
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTreasureHuntGame.<>c__DisplayClass39_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiForceChooseFullPop.UiInfo infoSuccess; // 0x10
	System.Void .ctor(); // 0x06568144
	System.Void <OnGlowComplete>b__0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x0656cc6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTreasureHuntGame.<>c__DisplayClass53_0 : System.Object
{
	System.Int32 circuit; // 0x10
	System.Void .ctor(); // 0x0656b388
	System.Boolean <WaitStart>b__0(WizardGames.Soc.Common.CustomType.DragElement x); // 0x0656cd5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLevelRewardPage : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComLevelRewardPageBinder binder; // 0x10
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComLevelRewardBinder> levelBinders; // 0x18
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComFunctionBinder> funcBinders; // 0x20
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComRewardBinder> rewardBinders; // 0x28
	System.Single lastPos; // 0x30
	System.Single progressPos; // 0x34
	System.Single curProgressPos; // 0x38
	System.Single objWidth; // 0x3c
	System.Boolean isAnimaPlayed; // 0x40
	FairyGUI.GTweener tweener; // 0x48
	System.Int32 curItemIndex; // 0x50
	System.Int64 timerId; // 0x58
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiLevelRewardPage.ControllerItem> unlockControllers; // 0x60
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComLevelRewardPageBinder binder); // 0x0656cdf0
	System.Void Show(); // 0x0656d238
	System.Void CalculateProgressPos(); // 0x0656dcb0
	System.Void OnListUpdate(); // 0x0656e4b0
	System.Void UpdateProgress(); // 0x0656e6b0
	System.Int32 GetMaxExp(System.Int32 levelFrom, System.Int32 levelTo); // 0x0656e358
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x0656e94c
	System.Void AddUnlockController(WizardGames.Soc.SocClient.Ui.UiLevelRewardPage.ControllerItem ctrl); // 0x0656feac
	System.Void SetControllersUnlock(System.Int64 timerid, System.Object data, System.Boolean delete); // 0x065700f0
	System.Void Hide(); // 0x0657047c
	System.Void <Show>b__15_0(FairyGUI.GTweener t); // 0x065707b4
	System.Void <Show>b__15_1(); // 0x06570888
	System.Void <Show>b__15_2(SimpleJSON.JSONNode res); // 0x0657090c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiLevelRewardPage.ControllerItem : System.ValueType
{
	FairyGUI.Controller Ctrl; // 0x10
	FairyGUI.GTextField Title; // 0x18
	FairyGUI.GObject Icon; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLevelRewardPage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLevelRewardPage.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComLevelRewardBinder> <>9__14_0; // 0x8
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComFunctionBinder> <>9__14_1; // 0x10
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComRewardBinder> <>9__14_2; // 0x18
	static System.Void .cctor(); // 0x06570cd0
	System.Void .ctor(); // 0x06570d34
	WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComLevelRewardBinder <.ctor>b__14_0(FairyGUI.GComponent c); // 0x06570d9c
	WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComFunctionBinder <.ctor>b__14_1(FairyGUI.GComponent c); // 0x06570e40
	WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComRewardBinder <.ctor>b__14_2(FairyGUI.GComponent c); // 0x06570ee4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSkill : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.UiSkillBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x340
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x348
	WizardGames.Soc.SocClient.Ui.UiSkillPage skillPage; // 0x350
	WizardGames.Soc.SocClient.Ui.UiLevelRewardPage levelPage; // 0x358
	static System.Int32 OpenTabId; // 0x0
	System.Void OnInit(); // 0x06570f88
	System.Void OnTabClicked(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean b); // 0x065721c4
	System.Void ShowSeason(); // 0x06572e9c
	System.Void ShowNormal(); // 0x06572f14
	System.Void ShowLevel(); // 0x06572f8c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06573004
	System.Void OnEnable(); // 0x06573084
	System.Void OnDisable(); // 0x06573124
	System.Void .ctor(); // 0x065731a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSkillPage : System.Object, WizardGames.Soc.SocClient.Ui.Utils.IToolTips
{
	WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComSkillPageBinder binder; // 0x10
	WizardGames.Soc.SocClient.Talent.TalentTreeData treeData; // 0x18
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComSkillItemBinder> itemBinders; // 0x20
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComSkillGradeItemBinder> gradeItemBinders; // 0x28
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComCurrencyItemBinder> currencyBinders; // 0x30
	WizardGames.Soc.SocClient.Talent.TalentNode selectedTalent; // 0x38
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x40
	System.Int64 buyCdTimerId; // 0x48
	System.Int64 timerId; // 0x50
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComSkillPageBinder binder, WizardGames.Soc.SocClient.Ui.ComTopBar topBar); // 0x06571c5c
	System.Void CurrencyItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x06573234
	System.Void GradeItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x06573580
	System.Void ShowTips(FairyGUI.EventContext context); // 0x065741b8
	System.Void ItemRenderer(WizardGames.Soc.SocClient.Talent.TalentNode talent, FairyGUI.GObject item); // 0x06573d00
	System.Void OnTalentRightClicked(FairyGUI.EventContext context); // 0x06574474
	System.Void Show(WizardGames.Soc.SocClient.Talent.TalentTreeData treeData); // 0x065726c4
	System.Void PlaySeasonAnima(); // 0x065746e4
	System.Void AddEvents(); // 0x06575300
	System.Void RefreshCurrency(); // 0x06577424
	System.Void RemoveEvents(); // 0x06576f6c
	System.Void UpdateResetCd(System.Int64 l, System.Object data, System.Boolean delete); // 0x0657748c
	System.Void OnTalentRewardReceived(System.String talentTreeId); // 0x06577864
	System.Void OnTalentUpdate(); // 0x06577954
	System.Void OnTalentReset(); // 0x06577a48
	System.Void RefreshResetEnable(); // 0x055049cc
	System.Void OnStudyClicked(FairyGUI.EventContext context); // 0x06577aac
	System.Void OnResetClicked(FairyGUI.EventContext context); // 0x06577eb4
	System.Void OnItemClicked(FairyGUI.EventContext context); // 0x065783bc
	System.Void RefreshTalentInfo(WizardGames.Soc.SocClient.Talent.TalentNode talent); // 0x06575ae0
	System.Void OnRewardBtnClicked(); // 0x065787cc
	System.Void ReceiveAllReward(); // 0x06578f1c
	System.Void Hide(); // 0x065725a0
	System.Void SetCurrency(WizardGames.Soc.SocClient.Talent.TalentTreeData treeData); // 0x06574e58
	System.Void OnTalentLevelUp(System.Int32 talentId); // 0x06579154
	System.Void RefreshReward(); // 0x065749e8
	System.Void <PlaySeasonAnima>b__19_0(); // 0x0657961c
	System.Void <OnStudyClicked>b__28_0(System.Int64 _, System.Object _, System.Boolean _); // 0x065798cc
	System.Void <OnResetClicked>b__29_0(); // 0x0657996c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSkillPage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiSkillPage.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComSkillItemBinder> <>9__11_0; // 0x8
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComSkillGradeItemBinder> <>9__11_1; // 0x10
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComCurrencyItemBinder> <>9__11_2; // 0x18
	static System.Func<WizardGames.Soc.Common.Data.common.BTuple2,WizardGames.Soc.SocClient.Ui.UiReward.RewardData> <>9__32_2; // 0x20
	static FairyGUI.EventCallback0 <>9__35_1; // 0x28
	static System.Void .cctor(); // 0x06579a60
	System.Void .ctor(); // 0x06579ac4
	WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComSkillItemBinder <.ctor>b__11_0(FairyGUI.GComponent g); // 0x06579b2c
	WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComSkillGradeItemBinder <.ctor>b__11_1(FairyGUI.GComponent g); // 0x06579bd0
	WizardGames.Soc.SocClient.Ui.Binder.GameTheRoadOfGrowth.ComCurrencyItemBinder <.ctor>b__11_2(FairyGUI.GComponent g); // 0x06579c74
	WizardGames.Soc.SocClient.Ui.UiReward.RewardData <OnRewardBtnClicked>b__32_2(WizardGames.Soc.Common.Data.common.BTuple2 r); // 0x06579d18
	System.Void <SetCurrency>b__35_1(); // 0x06579e68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSkillPage.<>c__DisplayClass18_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSkillPage <>4__this; // 0x10
	WizardGames.Soc.SocClient.Talent.TalentTreeData treeData; // 0x18
	System.Void .ctor(); // 0x06579ef0
	System.Void <Show>b__0(System.Object _); // 0x06579f58
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSkillPage.<>c__DisplayClass32_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSkillPage <>4__this; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.talent.progressRewards> progressRewardsList; // 0x18
	System.Func<WizardGames.Soc.SocClient.Ui.UiReward.TaskRewardData,WizardGames.Soc.SocClient.Ui.UiReward.ERewardProgress> <>9__1; // 0x20
	System.Action<WizardGames.Soc.SocClient.Ui.UiReward.TaskRewardData> <>9__3; // 0x28
	System.Void .ctor(); // 0x0657a04c
	System.Int32 <OnRewardBtnClicked>b__0(WizardGames.Soc.Common.Data.talent.progressRewards a, WizardGames.Soc.Common.Data.talent.progressRewards b); // 0x0657a0b4
	WizardGames.Soc.SocClient.Ui.UiReward.ERewardProgress <OnRewardBtnClicked>b__1(WizardGames.Soc.SocClient.Ui.UiReward.TaskRewardData data); // 0x0657a1cc
	System.Void <OnRewardBtnClicked>b__3(WizardGames.Soc.SocClient.Ui.UiReward.TaskRewardData data); // 0x0657a300
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSkillPage.<>c__DisplayClass35_0 : System.Object
{
	System.Int32 index; // 0x10
	WizardGames.Soc.Common.Data.resource.OBJGenaral objGenaral; // 0x18
	System.Int32 currencyId; // 0x20
	WizardGames.Soc.SocClient.Ui.UiSkillPage <>4__this; // 0x28
	System.Void .ctor(); // 0x0657a384
	System.Void <SetCurrency>b__0(); // 0x0657a3ec
	System.String <SetCurrency>b__2(); // 0x0657a574
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSkillPage.<>c__DisplayClass36_0 : System.Object
{
	WizardGames.Soc.SocClient.Talent.TalentNode data; // 0x10
	FairyGUI.GObject child; // 0x18
	WizardGames.Soc.SocClient.Ui.UiSkillPage <>4__this; // 0x20
	System.Void .ctor(); // 0x0657a634
	System.Void <OnTalentLevelUp>b__0(); // 0x0657a69c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTaskInteracting : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static WizardGames.Soc.SocClient.Ui.UiTaskInteracting instance; // 0x0
	static System.Int64 progressHandle; // 0x8
	static System.Single maxTime; // 0x10
	static System.Int64 startTime; // 0x18
	static FairyGUI.GTextField leftTime; // 0x20
	static FairyGUI.GImage progressBarImg; // 0x28
	FairyGUI.GButton closeBtn; // 0x338
	static FairyGUI.GTextField info; // 0x30
	static SocLogger logger; // 0x38
	FairyGUI.GComponent panelRoot; // 0x340
	FairyGUI.GComponent countDown; // 0x348
	FairyGUI.GComponent content; // 0x350
	static System.Action callbackFinish; // 0x40
	System.Void OnInit(); // 0x0657a710
	System.Void OnEnable(); // 0x0657aa54
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0657abc0
	static System.Void Show(System.String text, System.Single time, System.Action callback); // 0x05514124
	static System.Void UpdateProgress(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x0657b310
	static System.Void TryCancelProgressTimer(); // 0x0657ac90
	static System.Void FinishInteract(); // 0x0657b60c
	static System.Void Hide(); // 0x0657ade8
	System.Void .ctor(); // 0x0657b738
	static System.Void .cctor(); // 0x0657b7c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GTechTreeInfo : FairyGUI.GComponent, WizardGames.Soc.SocClient.Ui.Utils.IToolTips
{
	SocLogger <Log>k__BackingField; // 0x288
	FairyGUI.GTextField moreSelectNodeTip; // 0x290
	FairyGUI.GGroup group_unlock; // 0x298
	FairyGUI.Controller moreBluePrintsCtrl; // 0x2a0
	FairyGUI.GLoader itemIcon; // 0x2a8
	FairyGUI.GComponent comItem; // 0x2b0
	FairyGUI.GTextField itemName; // 0x2b8
	FairyGUI.GTextField itemType; // 0x2c0
	FairyGUI.GRichTextField itemDescription; // 0x2c8
	WizardGames.Soc.SocClient.Ui.ComStateBtn jumpToCraftBtn; // 0x2d0
	FairyGUI.GGroup group_unlockCondition; // 0x2d8
	FairyGUI.GTextField levelText; // 0x2e0
	FairyGUI.Controller condition1StateCtrl; // 0x2e8
	FairyGUI.GTextField workbenchText; // 0x2f0
	FairyGUI.Controller condition2StateCtrl; // 0x2f8
	WizardGames.Soc.SocClient.Ui.ComPriceBtn normalLockBtn; // 0x300
	FairyGUI.GButton btnDetail; // 0x308
	FairyGUI.GButton lackingLockBtn; // 0x310
	FairyGUI.GList itemGList; // 0x318
	FairyGUI.GComponent comItemDetail; // 0x320
	FairyGUI.GComponent comWorkBenchLevelTip; // 0x328
	FairyGUI.GComponent comNeedReputationLevelTip; // 0x330
	FairyGUI.GTextField treeNodeName; // 0x338
	FairyGUI.GGroup importGroup; // 0x340
	FairyGUI.Controller nodeStatusCtrl; // 0x348
	FairyGUI.GComponent teammateUnlock; // 0x350
	FairyGUI.Controller storyLimit; // 0x358
	FairyGUI.GTextField storyNum; // 0x360
	FairyGUI.GTextField storyText; // 0x368
	System.Int64 techId; // 0x370
	System.Int64 itemId; // 0x378
	System.Int64 jumpCraftItemId; // 0x380
	System.Int32 curSelectBlueprintIndex; // 0x388
	System.Collections.Generic.List<System.Int64> blueprintIds; // 0x390
	SocLogger get_Log(); // 0x0657b8b4
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x0657b918
	System.Void ShowTips(FairyGUI.EventContext context); // 0x0657c750
	System.Void OnTeammateUnLockClick(); // 0x0657cb34
	System.Void PlayClickAnimation(System.Action completeAction); // 0x0657d424
	WizardGames.Soc.Common.Data.DataItem.ItemConfig GetItem(); // 0x0657c85c
	System.Void RefreshClickBlueprintItemInfo(); // 0x0657d4b8
	System.Void OpenInfoPanel(WizardGames.Soc.Common.Data.DataItem.Technology config); // 0x0657de70
	System.Void RefreshStoryLimit(); // 0x0657e8c0
	System.Void RefreshNodeCtrlStatus(); // 0x0657e604
	System.Boolean get_CanUnlock(); // 0x0657eccc
	System.Void ClickUnlockButton(); // 0x0657ed70
	System.Void OnEnable(); // 0x0657ee4c
	System.Void OnDisable(); // 0x0657ef88
	System.Void RefreshUnlockStatus(); // 0x0657e4ac
	System.Void OnClickOpenDetail(); // 0x0657f044
	System.Void RefreshList(System.Int64[] blueprintIdArray); // 0x0657e25c
	System.Void OnClickBlueprintItem(FairyGUI.EventContext context); // 0x0657f18c
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x0657f37c
	System.Void RefreshUnlockConditions(); // 0x0657f704
	System.Boolean IsShowJumpCraftBtn(); // 0x0657fb94
	System.Boolean IsUnlockByTeamCombination(System.Int64 id); // 0x0657eb18
	System.String GetTextLock(); // 0x0657fc88
	System.Void OnJumpToCraftBtnClick(); // 0x0657ffd8
	System.Void UpdateLock(); // 0x0657d7f8
	System.Void .ctor(); // 0x0658007c
	System.Void <ConstructFromXML>b__40_0(FairyGUI.EventContext ctx); // 0x065801a0
	System.Void <ConstructFromXML>b__40_1(FairyGUI.EventContext ctx); // 0x06580254
	System.Void <ConstructFromXML>b__40_2(FairyGUI.EventContext ctx); // 0x06580308
	System.Void <ConstructFromXML>b__40_3(FairyGUI.EventContext ctx); // 0x06580380
	System.Void <OnEnable>b__53_0(); // 0x065803f8
	System.Void <OnEnable>b__53_1(); // 0x065804d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GTechTreeNode : FairyGUI.GButton
{
	FairyGUI.Controller lockStatus; // 0x318
	FairyGUI.GLoader icon; // 0x320
	FairyGUI.Controller isByTheWay; // 0x328
	FairyGUI.Controller avaliable; // 0x330
	FairyGUI.Controller isHold; // 0x338
	FairyGUI.GProgressBar holdProgress; // 0x340
	FairyGUI.GComponent trackDot; // 0x348
	FairyGUI.GGroup linesGroup; // 0x350
	FairyGUI.Transition unlockTransition; // 0x358
	System.Int64 itemId; // 0x360
	System.Int64 <ID>k__BackingField; // 0x368
	System.String <Name>k__BackingField; // 0x370
	System.Boolean <IsKey>k__BackingField; // 0x378
	System.Int32 ParentID; // 0x37c
	System.Boolean <IsRoot>k__BackingField; // 0x380
	WizardGames.Soc.SocClient.Ui.ESelectStatus <SelectStatus>k__BackingField; // 0x384
	System.Int32 <Status>k__BackingField; // 0x388
	WizardGames.Soc.Common.Data.DataItem.Technology <Config>k__BackingField; // 0x390
	System.Collections.Generic.List<System.Int64> BlueprintIds; // 0x398
	System.Int32[] IngredientsNum; // 0x3a0
	System.Int32 curLevel; // 0x3a8
	FairyGUI.Controller manyBluePrintsCtrl; // 0x3b0
	FairyGUI.Controller importMarkCtrl; // 0x3b8
	FairyGUI.GTextField treeNodeName; // 0x3c0
	FairyGUI.GList bluePrintList; // 0x3c8
	FairyGUI.Controller lineColor; // 0x3d0
	FairyGUI.GGraph centerLine; // 0x3d8
	FairyGUI.GGraph horizontaLeftTLine; // 0x3e0
	FairyGUI.GGraph verticaLeftlLine; // 0x3e8
	FairyGUI.GGraph horizontalRightLine; // 0x3f0
	FairyGUI.GGraph verticalRightLine; // 0x3f8
	FairyGUI.GButton content; // 0x400
	FairyGUI.GLabel storyTab; // 0x408
	FairyGUI.Controller storyLimit; // 0x410
	System.Single centerLineDefaultLength; // 0x418
	System.Single centerLineDefaultWidth; // 0x41c
	System.Single horizontalLineDefaultLength; // 0x420
	System.Single verticalLineDefaultLength; // 0x424
	System.Int32 GposX; // 0x428
	System.Int32 GposY; // 0x42c
	System.Int64 get_ID(); // 0x065805b0
	System.Void set_ID(System.Int64 value); // 0x06580614
	System.Void set_Name(System.String value); // 0x0658068c
	System.Void set_IsKey(System.Boolean value); // 0x0658070c
	System.Void set_IsRoot(System.Boolean value); // 0x06580788
	WizardGames.Soc.SocClient.Ui.ESelectStatus get_SelectStatus(); // 0x06580804
	System.Void set_SelectStatus(WizardGames.Soc.SocClient.Ui.ESelectStatus value); // 0x06580868
	System.Int32 get_Status(); // 0x065808e0
	System.Void set_Status(System.Int32 value); // 0x06580944
	WizardGames.Soc.Common.Data.DataItem.Technology get_Config(); // 0x065809bc
	System.Void set_Config(WizardGames.Soc.Common.Data.DataItem.Technology value); // 0x06580a20
	System.Int64 get_ItemId(); // 0x06580aa0
	System.Void set_ItemId(System.Int64 value); // 0x06580b04
	FairyGUI.GButton get_Content(); // 0x06580b7c
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x06580be0
	System.Void Dispose(); // 0x06581490
	System.Void PlayUnlockTransition(); // 0x06581594
	System.Void Initialize(WizardGames.Soc.Common.Data.DataItem.Technology node); // 0x065816b8
	System.Void RefreshStoryLimit(); // 0x0658299c
	System.Void SetItemIcon(); // 0x06581d24
	System.Void SetLineGroupVisible(System.Boolean show); // 0x065813fc
	System.Boolean IsLineGroupVisible(); // 0x06582b2c
	System.Void SetSelectStatusAndOrder(WizardGames.Soc.SocClient.Ui.ESelectStatus status); // 0x06582bd4
	System.Void UpdateLineColor(); // 0x06582dc8
	System.Void SetLineLength(); // 0x0658255c
	System.Int64 GetItemId(System.Collections.Generic.List<System.Int64> blueprintIds, System.Int64 itemId); // 0x06581b58
	System.Void SetBluePrintsInfo(); // 0x065823b4
	System.Void RenderBluePrintItem(System.Int32 index, FairyGUI.GObject obj); // 0x06582fb0
	System.Void ResetNodeSelectStatus(); // 0x06581e9c
	System.Void set_Progress(System.Single value); // 0x0658345c
	System.Void SetSelectStatus(WizardGames.Soc.SocClient.Ui.ESelectStatus status); // 0x06582c60
	System.Void SetLockStatus(); // 0x06582064
	System.Void RefreshTag(); // 0x06582274
	System.Void RefreshInfo(); // 0x065834fc
	System.Void .ctor(); // 0x06583560
	System.Void <PlayUnlockTransition>b__69_0(); // 0x06583624
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GTechTreeNode.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.GTechTreeNode.<>c <>9; // 0x0
	static System.Comparison<System.Int64> <>9__79_0; // 0x8
	static System.Void .cctor(); // 0x06583688
	System.Void .ctor(); // 0x065836ec
	System.Int32 <SetBluePrintsInfo>b__79_0(System.Int64 a, System.Int64 b); // 0x06583754
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ESelectStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ESelectStatus Selected = 0;
	static WizardGames.Soc.SocClient.Ui.ESelectStatus NotSelected = 1;
	static WizardGames.Soc.SocClient.Ui.ESelectStatus SelectedByTheWay = 2;
	static WizardGames.Soc.SocClient.Ui.ESelectStatus UnlockNotSelected = 3;
	static WizardGames.Soc.SocClient.Ui.ESelectStatus NoAvailable = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeammateUnlockPopup : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x338
	FairyGUI.GTextField levelText; // 0x340
	FairyGUI.Controller condition1StateCtrl; // 0x348
	FairyGUI.GTextField workbenchText; // 0x350
	FairyGUI.Controller condition2StateCtrl; // 0x358
	FairyGUI.GTextField containsTxt; // 0x360
	FairyGUI.GTextField teamUnlockNames; // 0x368
	FairyGUI.GButton unlockBtn; // 0x370
	FairyGUI.GLoader iconLoader; // 0x378
	FairyGUI.GTextField consumeNum; // 0x380
	FairyGUI.GButton cancelBtn; // 0x388
	System.Int64 techId; // 0x390
	System.Void OnInit(); // 0x06583854
	System.Void OnCancelClick(); // 0x06583e40
	System.Void OnConfirmClick(); // 0x06583eac
	System.Void OnEnable(); // 0x06583f5c
	System.Void SetInfo(System.Int64 id, System.Int32 index); // 0x0657cc34
	System.Void OnDisable(); // 0x06583fc4
	System.Void OnDestroy(); // 0x0658402c
	System.Void .ctor(); // 0x06584094
	System.Void <OnInit>b__13_0(); // 0x06584120
	System.Void <SetInfo>b__17_0(SimpleJSON.JSONArray jsonArray); // 0x0658418c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTechTree : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	static SocLogger <logger>k__BackingField; // 0x0
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x338
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x340
	System.Int32 curLevel; // 0x348
	WizardGames.Soc.SocClient.Ui.GTechTreeInfo <TechTreeInfo>k__BackingField; // 0x350
	WizardGames.Soc.SocClient.Ui.EUiTechTreeOpenSource <Source>k__BackingField; // 0x358
	System.Int64 <OperatingWorkbenchId>k__BackingField; // 0x360
	static System.Int64 <OperatingWorkbenchLevel>k__BackingField; // 0x8
	System.Int64 <OperatingHubId>k__BackingField; // 0x368
	static System.Int64 <SelectBluePrintId>k__BackingField; // 0x10
	static System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.TechnologySystem> dataList; // 0x18
	static System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.TechnologyLevel> levelList; // 0x20
	static System.Int32 curConsumeScrapCount; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NavBarData> tabDataLst; // 0x370
	FairyGUI.GList treeNodeGList; // 0x378
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.Technology>> techNodeDataDic; // 0x380
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.ESelectStatus> needSetOrderIdDic; // 0x388
	System.Collections.Generic.List<System.Int32> recodListHeadIndexList; // 0x390
	static System.Int64 curSelectTreeNodeId; // 0x30
	System.Int32 curFirstTabId; // 0x398
	System.Int64 secTimer; // 0x3a0
	System.Boolean isSelectFirstUnlocked; // 0x3a8
	System.Boolean isUseRecordSelectNodeId; // 0x3a9
	System.Boolean isInGuideScroll; // 0x3aa
	System.Single touchBeginTime; // 0x3ac
	System.Boolean longTouchFinished; // 0x3b0
	WizardGames.Soc.SocClient.Ui.GTechTreeNode touchingNode; // 0x3b8
	FairyGUI.GButton btnPre; // 0x3c0
	FairyGUI.GButton btnNext; // 0x3c8
	FairyGUI.Controller btnPreCtrl; // 0x3d0
	FairyGUI.Controller btnNextCtrl; // 0x3d8
	WizardGames.Soc.SocClient.Ui.UiTechtreeFindNode uiTechtreeFindNode; // 0x3e0
	FairyGUI.Controller listTypeCtrl; // 0x3e8
	System.Int32 MAX_ROW; // 0x3f0
	FairyGUI.GComponent content; // 0x3f8
	static SocLogger get_logger(); // 0x0658442c
	WizardGames.Soc.SocClient.Ui.GTechTreeInfo get_TechTreeInfo(); // 0x065844b4
	System.Void set_TechTreeInfo(WizardGames.Soc.SocClient.Ui.GTechTreeInfo value); // 0x06584518
	WizardGames.Soc.SocClient.Ui.EUiTechTreeOpenSource get_Source(); // 0x06584598
	System.Void set_Source(WizardGames.Soc.SocClient.Ui.EUiTechTreeOpenSource value); // 0x065845fc
	System.Void set_OperatingWorkbenchId(System.Int64 value); // 0x06584674
	static System.Int64 get_OperatingWorkbenchLevel(); // 0x065846ec
	static System.Void set_OperatingWorkbenchLevel(System.Int64 value); // 0x06584774
	System.Int64 get_OperatingHubId(); // 0x06584804
	System.Void set_OperatingHubId(System.Int64 value); // 0x06584868
	static System.Int64 get_SelectBluePrintId(); // 0x065848e0
	static System.Void set_SelectBluePrintId(System.Int64 value); // 0x06584968
	System.Void OnInit(); // 0x065849f8
	System.Void OnEnable(); // 0x06586f54
	System.Void OnDisable(); // 0x06587338
	System.Void OnDestroy(); // 0x0658769c
	System.Void OnMissionChanged(); // 0x06587a34
	System.Void OnNextGuide(System.Int32 guideId, System.Int32 stepId); // 0x06587aac
	System.Int32 GetClosestIndexToCenter(FairyGUI.GList list); // 0x06587ca0
	System.Void OnTreeNodelistScrollEnd(FairyGUI.EventContext context); // 0x06587ee8
	System.Int32 GetSecTabIndexByTabId(System.Int32 firstTabId, System.Int32 secTabId); // 0x06588240
	System.Int32 GetSecTabIdByIndex(System.Int32 firstTabId, System.Int32 secIndex); // 0x065882c8
	System.Void RenderTreeNodeItem(System.Int32 index, FairyGUI.GObject obj); // 0x06588350
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x06588bf4
	System.Void OnJumpToTreeNode(System.Int64 id, System.Int32 system, System.Int32 groupId, System.Boolean isJumpImediately); // 0x06589060
	System.Void OnClickNode(System.Int64 treeNodeId, System.Boolean isJump); // 0x065891cc
	System.Void SetParentNodeSelectStatus(System.Int64 nodeId, WizardGames.Soc.SocClient.Ui.ESelectStatus status, System.Int32 maxDepth); // 0x065899ac
	WizardGames.Soc.SocClient.Ui.GTechTreeNode GetNodeByTechID(System.Int64 techId); // 0x06589484
	System.Void ResetTreeNodeSelectStatus(); // 0x06589bc4
	System.Void SetSelectNodeParentSortOrder(System.Int64 nodeId, System.Int32 maxDepth); // 0x06589de4
	System.Void InitNavTabNew(); // 0x06586390
	System.Void OnClickSecTab(WizardGames.Soc.SocClient.Ui.NavBarData data); // 0x0658a098
	System.Void OnHandleGuide(); // 0x0658a868
	System.Void OnClickFirstTab(WizardGames.Soc.SocClient.Ui.NavBarData data); // 0x0658acd4
	System.Void SetNavTabRedDot(); // 0x06589fd8
	System.Void RefreshRedDot(); // 0x0658b4f0
	System.Void ScrollToSecTabNode(System.Int32 firstTabId, System.Int32 secTabId); // 0x0658a620
	System.Int32 GetTechtreeListIndexByNodeId(System.Int64 nodeId); // 0x0658b8f0
	System.Int32 GetTechtreeListIndexByTabId(System.Int32 firstTabId, System.Int32 secTabId); // 0x0658bb40
	System.Void SetDefaultSelectNode(System.Int32 secLevel); // 0x0658bdac
	System.Void OnMoveNextNode(); // 0x0658c290
	System.Void OnMovePreNode(); // 0x0658c608
	System.Void RefreshBtnPreAndNextStatus(); // 0x065896fc
	System.Void OnRefreshSelectNode(System.Int64 id); // 0x0658c1a4
	System.Void RefreshScrapCount(); // 0x0658c9e0
	static System.Void ClearTechCache(); // 0x0658cb68
	static System.Void Open(System.Int32 homePageIndex, WizardGames.Soc.SocClient.Ui.EUiTechTreeOpenSource source, System.Int64 opHubEntityId, System.Int64 bluePrintId); // 0x0658cc08
	static System.Boolean IsAKTaskActive(); // 0x0658cf74
	static System.Void OpenByBluePrintId(System.Int64 bluePrintId); // 0x0658d068
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0658d0fc
	static System.Void Close(); // 0x0658d194
	static WizardGames.Soc.SocClient.Ui.UiTechTree GetWindow(); // 0x0658d318
	System.Void UnLockTechNodeAck(); // 0x0658d7e0
	System.Void RefreshNodeInfo(); // 0x0658da10
	System.Void RefreshCurNodesInfo(); // 0x0658df74
	System.Void RefreshChildLineColor(); // 0x0658dc6c
	System.Void SetReputationLevel(); // 0x06587228
	System.Void OnAfterTechTreeEnable(System.Int32 homePageIndex, WizardGames.Soc.SocClient.Ui.EUiTechTreeOpenSource source, System.Int64 opHubEntityId, System.Int64 bluePrintId); // 0x0658e17c
	System.Boolean GetTabIdByBluePrintId(System.Int32& firstTabId, System.Int32& secTabIndex); // 0x0658e7c0
	System.Void PlaySound(System.Boolean open, System.Int64 level); // 0x0658d3d8
	System.Void OnRefreshTechtree(System.Int32 firstTabId, System.Int32 secTabId); // 0x0658ae44
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x0658ebf4
	System.Void .ctor(); // 0x0658f108
	static System.Void .cctor(); // 0x0658f2b0
	System.Void <OnInit>b__55_0(FairyGUI.EventContext _); // 0x0658f360
	System.Void <OnInit>b__55_1(FairyGUI.EventContext _); // 0x0658f3fc
	System.Void <OnInit>b__55_4(); // 0x0658f498
	System.Void <OnInit>b__55_7(); // 0x0658f738
	System.Void <InitNavTabNew>b__73_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x0658f9dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTechTree.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTechTree.<>c <>9; // 0x0
	static System.Func<System.String> <>9__55_2; // 0x8
	static System.Func<System.Boolean> <>9__55_3; // 0x10
	static FairyGUI.EventCallback0 <>9__55_5; // 0x18
	static System.Func<System.String> <>9__55_6; // 0x20
	static FairyGUI.EventCallback0 <>9__55_8; // 0x28
	static System.Void .cctor(); // 0x0658fb20
	System.Void .ctor(); // 0x0658fb84
	System.String <OnInit>b__55_2(); // 0x0658fbec
	System.Boolean <OnInit>b__55_3(); // 0x0658fd8c
	System.Void <OnInit>b__55_5(); // 0x0658fe14
	System.String <OnInit>b__55_6(); // 0x0658fe78
	System.Void <OnInit>b__55_8(); // 0x0658ffcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTechTree.<>c__DisplayClass103_0 : System.Object
{
	System.Int32 posY; // 0x10
	System.Void .ctor(); // 0x0658eb8c
	System.Boolean <OnRefreshTechtree>b__0(WizardGames.Soc.Common.Data.DataItem.Technology t); // 0x06590030
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTechTree.<>c__DisplayClass65_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.GTechTreeNode nodeObj; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTechTree <>4__this; // 0x18
	System.Void .ctor(); // 0x06588b24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTechTree.<>c__DisplayClass65_1 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.Technology nodeConfig; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTechTree.<>c__DisplayClass65_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x06588b8c
	System.Void <RenderTreeNodeItem>b__0(); // 0x065900d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTechTree.<>c__DisplayClass74_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTechTree <>4__this; // 0x10
	System.Int32 secIndex; // 0x18
	System.Void .ctor(); // 0x0658a5b8
	System.Void <OnClickSecTab>b__0(System.Int64 _, System.Object data, System.Boolean delete); // 0x06590328
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTechTree.<>c__DisplayClass83_0 : System.Object
{
	System.Int32 posY; // 0x10
	System.Void .ctor(); // 0x0658c5a0
	System.Boolean <OnMoveNextNode>b__0(WizardGames.Soc.Common.Data.DataItem.Technology tech); // 0x06590688
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTechTree.<>c__DisplayClass84_0 : System.Object
{
	System.Int32 posY; // 0x10
	System.Void .ctor(); // 0x0658c910
	System.Boolean <OnMovePreNode>b__0(WizardGames.Soc.Common.Data.DataItem.Technology tech); // 0x0659072c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTechTree.<>c__DisplayClass85_0 : System.Object
{
	System.Int32 posY; // 0x10
	System.Void .ctor(); // 0x0658c978
	System.Boolean <RefreshBtnPreAndNextStatus>b__0(WizardGames.Soc.Common.Data.DataItem.Technology tech); // 0x065907d0
	System.Boolean <RefreshBtnPreAndNextStatus>b__1(WizardGames.Soc.Common.Data.DataItem.Technology tech); // 0x06590874
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTechTree.<>c__DisplayClass89_0 : System.Object
{
	System.Int32 homePageIndex; // 0x10
	WizardGames.Soc.SocClient.Ui.EUiTechTreeOpenSource source; // 0x14
	System.Int64 opHubEntityId; // 0x18
	System.Int64 bluePrintId; // 0x20
	System.Void .ctor(); // 0x0658cf0c
	System.Void <Open>b__0(WizardGames.Soc.Common.Unity.Ui.LayerComBase layer, WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x06590918
	System.Void <Open>b__1(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x065909e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTechtreeFindNode : System.Object
{
	FairyGUI.GLoader findBg; // 0x10
	FairyGUI.GComponent comFindNode; // 0x18
	WizardGames.Soc.SocClient.Ui.ComInputBox comInputBox; // 0x20
	FairyGUI.GList findList; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,System.String> nameDic; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<System.String>> descDic; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,System.String> blueNameDic; // 0x40
	System.Collections.Generic.List<System.Int64> findNodeIDs; // 0x48
	System.Collections.Generic.List<System.Int64> findNameNodeIDs; // 0x50
	System.Collections.Generic.List<System.Int64> findDescNodeIds; // 0x58
	FairyGUI.Controller statusCtrl; // 0x60
	FairyGUI.Controller listStatusCtrl; // 0x68
	FairyGUI.GButton btnClear; // 0x70
	FairyGUI.GButton btnSearch; // 0x78
	System.Int64 findNodeId; // 0x80
	System.Int32 defaulyListHeight; // 0x88
	System.Int32 defaultListItemHeight; // 0x8c
	System.Void Init(FairyGUI.GComponent root); // 0x06585f64
	System.Void OnClearInput(); // 0x06590d74
	System.Void OnSearch(); // 0x06590ec0
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x06591030
	System.Void OnInitComInputBox(); // 0x06590b68
	System.Void OnFocusIn(); // 0x06591354
	System.Void SetFindListHeight(); // 0x06591494
	System.Void SetListStatus(System.Boolean isShow); // 0x06590ab0
	System.Void OnClickSelectNode(WizardGames.Soc.Common.Data.DataItem.Technology config); // 0x065915a8
	System.Void OnClickFingBg(); // 0x06591674
	System.Void FindStringsContainingSubstring(); // 0x06590f58
	System.Void CacheTechnologyNameAndDesc(); // 0x065917c8
	System.Void CacheBluePrintName(); // 0x06591edc
	System.Void RemoveDuplicateKeys(); // 0x0659293c
	System.Void SortFindNode(System.String str); // 0x0659215c
	System.Void SetComInputBoxInfo(); // 0x06592b74
	System.Void .ctor(); // 0x06585d7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTechtreeFindNode.<>c__DisplayClass20_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTechtreeFindNode <>4__this; // 0x10
	WizardGames.Soc.Common.Data.DataItem.Technology config; // 0x18
	System.Void .ctor(); // 0x065912ec
	System.Void <RenderListItem>b__0(); // 0x06592ebc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTechtreeFindNode.<>c__DisplayClass31_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTechtreeFindNode <>4__this; // 0x10
	System.String str; // 0x18
	System.Void .ctor(); // 0x06592b0c
	System.Int32 <SortFindNode>b__0(System.Int64 a, System.Int64 b); // 0x06592f2c
	System.Int32 <SortFindNode>b__1(System.Int64 a, System.Int64 b); // 0x065930a8
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EUiTechTreeOpenSource : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EUiTechTreeOpenSource None = 0;
	static WizardGames.Soc.SocClient.Ui.EUiTechTreeOpenSource Workbench = 1;
	static WizardGames.Soc.SocClient.Ui.EUiTechTreeOpenSource ItemDetail = 2;
	static WizardGames.Soc.SocClient.Ui.EUiTechTreeOpenSource PermissionHub = 3;
	static WizardGames.Soc.SocClient.Ui.EUiTechTreeOpenSource ItemTips = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTempCofferSafeBoxDestroy : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x338
	FairyGUI.GTextField cdTitle; // 0x340
	FairyGUI.GTextField textCountDown; // 0x348
	FairyGUI.GButton btnDestroy; // 0x350
	FairyGUI.Controller btnDestroyState; // 0x358
	System.Int64 timerID; // 0x360
	System.Void OnInit(); // 0x06593318
	System.Void OnEnable(); // 0x06593734
	System.Void OnDisable(); // 0x06593c8c
	System.Void Tick(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x06593e20
	System.Void SafeBoxStateRefresh(); // 0x055049cc
	System.Void DestroySafeBox(); // 0x0659402c
	System.Void .ctor(); // 0x06594404
	System.Void <OnInit>b__7_0(FairyGUI.EventContext ctx); // 0x06594490
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTempCofferSafeBoxDestroy.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTempCofferSafeBoxDestroy.<>c <>9; // 0x0
	static System.Action <>9__12_0; // 0x8
	static System.Void .cctor(); // 0x06594508
	System.Void .ctor(); // 0x0659456c
	System.Void <DestroySafeBox>b__12_0(); // 0x065945d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.CameraPositionCalculator : System.Object
{
	
	System.Single get_minCameraDis(); // 0x06594680
	System.Collections.Generic.List<UnityEngine.Vector3> GetAllEmptyNodePositions(UnityEngine.GameObject root); // 0x06594768
	System.Void CalculateMinimalBoundingSphere(System.Collections.Generic.List<UnityEngine.Vector3> points, UnityEngine.Vector3& center, System.Single& radius); // 0x06594b90
	System.Single get_boundingSphereScaleFactor(); // 0x06594e08
	System.Void SetupCameraForEmptyNodes(UnityEngine.GameObject rootPrefab, UnityEngine.Camera targetCamera, System.Single angle); // 0x06594ef0
	System.Void .ctor(); // 0x065950ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBatchUpgradeTreeNode : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ConstructionFolderItemBinder foldBinder; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ConstructionItemBinder itemBinder; // 0x18
	System.Boolean get_IsFolder(); // 0x06595114
	System.Void Bind(WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ConstructionFolderItemBinder binder); // 0x06595180
	System.Void Bind(WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ConstructionItemBinder binder); // 0x06595210
	FairyGUI.GTextField get_Title(); // 0x065952a0
	FairyGUI.GComponent get_ComSelectState(); // 0x06595394
	FairyGUI.Controller get_CtrlUnlock(); // 0x06595488
	FairyGUI.Controller get_CtrlSelected(); // 0x0659557c
	FairyGUI.GTextField get_TxtNum(); // 0x06595670
	FairyGUI.GLoader get_Icon(); // 0x06595764
	FairyGUI.GList get_IconChilds(); // 0x06595818
	FairyGUI.GTextField get_TargetTitle(); // 0x065958cc
	FairyGUI.GLoader get_TargetIcon(); // 0x06595980
	FairyGUI.GList get_TargetIconChilds(); // 0x06595a34
	FairyGUI.GButton get_BtnToUnlock(); // 0x06595ae8
	FairyGUI.GTextField get_TxtWarning(); // 0x06595b9c
	System.Void OnDestroy(); // 0x06595c50
	System.Void OnGet(); // 0x06595cb0
	System.Void OnRelease(); // 0x06595d10
	System.Void .ctor(); // 0x06595d8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PartBlueprintModelHandler : System.Object
{
	static SocLogger logger; // 0x0
	UnityEngine.Transform PartBlueprintModel; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveData> curBlueprintPartData; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,System.String> allPartPrefabPathDict; // 0x20
	System.UInt64[] asyncLoadPartIdArray; // 0x28
	System.Action<System.Int64> OnModelLoadFinishEvent; // 0x30
	WizardGames.Soc.SocClient.Ui.CameraPositionCalculator cameraPositionCalculator; // 0x38
	System.Collections.Generic.List<System.UInt64> asyncLoadSplicingIdList; // 0x40
	UnityEngine.Transform rootNode; // 0x48
	System.Collections.Generic.List<UnityEngine.GameObject> needLoadSplicingObjList; // 0x50
	System.Int64 _currentBlueprintId; // 0x58
	System.Collections.Generic.Dictionary<System.Int64,UnityEngine.GameObject> _gameObjectDict; // 0x60
	System.Collections.Generic.Dictionary<System.Int64,UnityEngine.GameObject> _originGameObjectDict; // 0x68
	System.Collections.Generic.Dictionary<System.Int64,UnityEngine.GameObject> _originChildObjectDict; // 0x70
	System.Collections.Generic.HashSet<System.UInt64> asyncLoadOriginIdSet; // 0x78
	System.Int32 loadFinishCount; // 0x80
	WizardGames.Soc.Common.Unity.Ui.WindowComBase UiCustomBlueprint; // 0x88
	System.Void add_OnModelLoadFinishEvent(System.Action<System.Int64> value); // 0x06595df4
	System.Void remove_OnModelLoadFinishEvent(System.Action<System.Int64> value); // 0x06595ee4
	System.Void ShowCustomBlueprint(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveData> blueprintPartDataList, System.Int64 blueprintId); // 0x06595fd4
	System.Void SwitchToOriginalModel(); // 0x06597080
	System.Void SwitchToBaseModel(); // 0x06597f30
	System.Void InitializeBlueprintModel(); // 0x06596b58
	UnityEngine.GameObject GetRoot(System.String name); // 0x06598468
	System.Void LoadBlueprintPart(System.Int32 index); // 0x06596d9c
	System.String GetPartSkinPath(System.Int64 templateId, System.Int32 grade, System.Int32 skinId); // 0x065979a4
	System.Void StartPartLoading(System.Int32 index, System.Int64 entityId, System.Int64 templateId, UnityEngine.Vector3 pos, UnityEngine.Vector3 angle, System.String skinGoPath, System.Boolean isSplicing); // 0x06598614
	System.Void LoadOriginGo(System.Int64 entityId, System.Int64 templateId, UnityEngine.Vector3 pos, UnityEngine.Vector3 angle, System.String skinGoPath); // 0x06597a68
	System.Void LoadOriginChildGo(System.Int64 entityId, System.Int64 childPartType, UnityEngine.Vector3 pos, UnityEngine.Vector3 angle, System.String skinGoPath); // 0x06597ccc
	System.Void OnOriginChildPartLoaded(UnityEngine.GameObject partGo, System.Int64 entityId, System.Int64 templateId, UnityEngine.Vector3 pos, UnityEngine.Vector3 angle, System.String path); // 0x06598a1c
	System.Void OnOriginPartLoaded(UnityEngine.GameObject partGo, System.Int64 entityId, System.Int64 templateId, UnityEngine.Vector3 pos, UnityEngine.Vector3 angle, System.String path); // 0x06598dac
	System.Void OnPartLoaded(UnityEngine.GameObject partGo, System.Int32 asyncIdIndex, System.Int64 entityId, System.Int64 templateId, UnityEngine.Vector3 pos, UnityEngine.Vector3 angle, System.String skinGoPath, System.Boolean isSplicing); // 0x06599370
	System.Void MarkAsyncLoadComplete(System.Int32 asyncIdIndex); // 0x06599c2c
	System.Void SetupPartTransform(UnityEngine.GameObject partGo, System.Int64 templateId, System.Int64 entityId, UnityEngine.Vector3 position, UnityEngine.Vector3 angle); // 0x0659a014
	System.Void RegisterPartGameObject(System.Int64 entityId, UnityEngine.GameObject partGo, System.String skinGoPath); // 0x0659a200
	System.Void LoadBlueprintPartFinish(); // 0x06599cc8
	System.Boolean IsAllPartsLoaded(); // 0x06597698
	System.Void LoadAllPartsFinish(); // 0x0659a3a8
	System.Void SetCameraPosition(); // 0x0659a59c
	System.Void CancelAsyncOriginPartLoad(); // 0x065963d0
	System.Void CancelAsyncLoadPartId(); // 0x0659613c
	System.Void ReleaseGo(System.String path, UnityEngine.GameObject go); // 0x0659a7cc
	System.Void HideCurrentCustomBlueprint(); // 0x065965a4
	System.Void Destroy(); // 0x0659a8c4
	System.Void .ctor(); // 0x0659a96c
	static System.Void .cctor(); // 0x0659abfc
	System.Void <LoadAllPartsFinish>b__42_0(UnityEngine.GameObject a, UnityEngine.GameObject b); // 0x0659acd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PartBlueprintModelHandler.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.PartBlueprintModelHandler.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.Common.Unity.Construction.ConstructionConditionalModel,System.Boolean> <>9__30_0; // 0x8
	static System.Func<WizardGames.Soc.Common.Unity.Construction.ConstructionConditionalModel,System.Boolean> <>9__31_0; // 0x10
	static System.Void .cctor(); // 0x0659ae84
	System.Void .ctor(); // 0x0659aee8
	System.Boolean <OnOriginPartLoaded>b__30_0(WizardGames.Soc.Common.Unity.Construction.ConstructionConditionalModel model); // 0x0659af50
	System.Boolean <OnPartLoaded>b__31_0(WizardGames.Soc.Common.Unity.Construction.ConstructionConditionalModel model); // 0x0659afd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PartBlueprintModelHandler.<>c__DisplayClass26_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.PartBlueprintModelHandler <>4__this; // 0x10
	System.Int64 entityId; // 0x18
	System.Int64 templateId; // 0x20
	UnityEngine.Vector3 pos; // 0x28
	UnityEngine.Vector3 angle; // 0x34
	System.String skinGoPath; // 0x40
	System.Void .ctor(); // 0x0659b050
	System.Void <StartPartLoading>b__0(UnityEngine.GameObject go, System.Object[] objs); // 0x0659b0b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PartBlueprintModelHandler.<>c__DisplayClass27_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.PartBlueprintModelHandler <>4__this; // 0x10
	System.Int64 entityId; // 0x18
	System.Int64 templateId; // 0x20
	UnityEngine.Vector3 pos; // 0x28
	UnityEngine.Vector3 angle; // 0x34
	System.String skinGoPath; // 0x40
	System.Void .ctor(); // 0x0659b25c
	System.Void <LoadOriginGo>b__0(UnityEngine.GameObject go, System.Object[] objs); // 0x0659b2c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PartBlueprintModelHandler.<>c__DisplayClass28_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.PartBlueprintModelHandler <>4__this; // 0x10
	System.Int64 entityId; // 0x18
	System.Int64 childPartType; // 0x20
	UnityEngine.Vector3 pos; // 0x28
	UnityEngine.Vector3 angle; // 0x34
	System.String skinGoPath; // 0x40
	System.Void .ctor(); // 0x0659b368
	System.Void <LoadOriginChildGo>b__0(UnityEngine.GameObject go, System.Object[] objs); // 0x0659b3d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSubBatchRecover : WizardGames.Soc.SocClient.Ui.UiSubpageBase
{
	static SocLogger logger; // 0x0
	static System.Text.StringBuilder builder; // 0x8
	static WizardGames.Soc.SocClient.Ui.UiSubBatchRecover Inst; // 0x10
	WizardGames.Soc.SocClient.Ui.ComModal comModalCustomRecover; // 0x10
	System.String folderItemPath; // 0x18
	System.String childItemPath; // 0x20
	FairyGUI.GTree treeNode; // 0x28
	System.Collections.Generic.List<FairyGUI.GTreeNode> gTreeNodePool; // 0x30
	System.Collections.Generic.List<FairyGUI.GTreeNode> gTreeNodeUsePool; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubBatchRecoverBinder subBatchRecoverBinder; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.PartUpgradeData> curUpgradeDatas; // 0x48
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.PartUpgradeData>> curUpgradeDataDic; // 0x50
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> baseItemNeedDic; // 0x58
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> otherItemNeedDic; // 0x60
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemNeedDic; // 0x68
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> terrColItemNeedDic; // 0x70
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> storageColItemNeedDic; // 0x78
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> bagItemNeedDic; // 0x80
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> StorageBoxIngredients; // 0x88
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> TerritoryCabinetIngredients; // 0x90
	System.Collections.Generic.List<System.Int64> terrColItemIdList; // 0x98
	System.Collections.Generic.List<System.Int64> itemIdList; // 0xa0
	System.Collections.Generic.List<System.Int64> storageIdList; // 0xa8
	WizardGames.Soc.SocClient.Ui.UiTerritoryEdit <ParentNode>k__BackingField; // 0xb0
	System.Boolean isCustom; // 0xb8
	System.Boolean isInit; // 0xb9
	System.Int64 lstUpdateTime; // 0xc0
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.BtnCostItemBinder> costItemGDic; // 0xc8
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.ComBatchUpgradeTreeNode> treeNodeComDic; // 0xd0
	WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade.EUpgradeButtonState curRecoverButtonState; // 0xd8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.TemplateGrades> tGrades; // 0xe0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.TemplateGrades> cGrades; // 0xe8
	static System.String recoverStr; // 0x18
	System.String cdTime; // 0xf0
	System.Int64 unlockTime; // 0xf8
	System.Collections.Generic.List<System.Int64> waitCheckIds; // 0x100
	static WizardGames.Soc.SocClient.Ui.UiSubBatchRecover get_ActiveInstance(); // 0x0659b474
	System.String get_Name(); // 0x0659b5c0
	System.String get_Icon(); // 0x0659b660
	FairyGUI.GComponent get_ContentPanel(); // 0x0659b6d8
	FairyGUI.GTreeNode get_rootNode(); // 0x0659b77c
	WizardGames.Soc.SocClient.Ui.UiTerritoryEdit get_ParentNode(); // 0x0659b820
	System.Void set_ParentNode(WizardGames.Soc.SocClient.Ui.UiTerritoryEdit value); // 0x0659b884
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubBatchRecoverBinder binder, WizardGames.Soc.SocClient.Ui.UiTerritoryEdit parentNode); // 0x0659b904
	System.Void OnEnable(); // 0x0659c910
	System.Void OnDisable(); // 0x0659cc4c
	System.Boolean OnEscClose(); // 0x0659cf18
	WizardGames.Soc.Common.Component.TerritoryBatchUpgradeComponent GetTerrBatchUpgradeComponet(); // 0x0659d040
	WizardGames.Soc.Common.Component.TerritoryBatchRecoverComponent GetTerritoryBatchRecoverComp(); // 0x0659d10c
	WizardGames.Soc.Common.CustomType.BatchUpgradeRecord GetBatchUpgradeRecord(); // 0x0659d1a0
	System.Void RefreshView(); // 0x0659cabc
	System.Void RefreshViewState(); // 0x0659d300
	System.Void QueryConstructionData(); // 0x0659d21c
	System.Void CleanupUpgradeData(); // 0x0659cd10
	System.Void AddPartUpgradeData(WizardGames.Soc.SocClient.Ui.PartUpgradeData upgradeData); // 0x0659dc74
	System.Void RecvRecoverCost(System.Collections.Generic.Dictionary<System.Int64,System.Int32> baseCost, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.GradeCountInfo> tGrade, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.GradeCountInfo> cGrade, System.Collections.Generic.Dictionary<System.Int64,System.Int32> storageBoxIngredients, System.Collections.Generic.Dictionary<System.Int64,System.Int32> territoryCabinetIngredients); // 0x0659defc
	System.Void RefreshItemNeedData(); // 0x0659d5a0
	System.Void CalculateTerrColUseMat(); // 0x0659ed14
	System.Void SelectAllOnClick(); // 0x0659f404
	System.Void SelectBaseOnClick(); // 0x0659f46c
	System.Void SelectAll(System.Boolean force); // 0x0659e934
	System.Void SelectRepairRange(System.Boolean justBase); // 0x0659f89c
	System.Void SelectAllParts(System.Boolean isSelect); // 0x0659fa10
	System.Void RefreshFolderSelectState(WizardGames.Soc.SocClient.Ui.PartUpgradeData upgradeData); // 0x0659fcb4
	System.Void OnCustomSelectAllClick(); // 0x065a007c
	System.Void OnCustomSelectOver(System.Boolean ComModal); // 0x065a02a0
	System.Void OnRenderListNeed(System.Int32 index, FairyGUI.GObject obj); // 0x065a037c
	System.Void CreateGTreeViewNode(); // 0x0659ea98
	System.Void ClearGTreeConstructionItem(); // 0x065a06c8
	FairyGUI.GTreeNode GetGTreeNode(System.Boolean isFolder, WizardGames.Soc.SocClient.Ui.PartUpgradeData upgradeData); // 0x065a08bc
	System.Void RefreshGTreeSelectState(); // 0x0659f620
	System.Void RenderTreeNode(FairyGUI.GTreeNode node, FairyGUI.GComponent obj); // 0x065a0b4c
	System.Void FolderTreeNodeOnClick(FairyGUI.EventContext context, FairyGUI.GTreeNode node, FairyGUI.GButton button); // 0x065a1afc
	System.Void ChildTreeNodeOnClick(FairyGUI.GTreeNode node, FairyGUI.GComponent com); // 0x065a21b4
	System.Void RefreshCustomSelectAllState(WizardGames.Soc.SocClient.Ui.PartUpgradeData upgradeData); // 0x065a1e74
	System.Boolean HasEnoughMaterials(System.Collections.Generic.Dictionary<System.Int64,System.Int32> consumeItem, System.Boolean useTerrCol); // 0x065a23a8
	System.Void OnClickRecover(); // 0x065a2654
	System.Void ClearCachedData(); // 0x065a3018
	System.Void CalcGrades(); // 0x065a33a8
	System.Void RemoteCallRecover(); // 0x065a2d98
	System.Void RefreshBtnRecoverState(); // 0x0659f0b8
	System.Void UpdateCdTime(); // 0x065a3ab0
	System.Void RecoverPageInit(); // 0x0659c9ec
	System.Void UpdateRecoveringProgress(); // 0x065a3ccc
	System.Void Tick(); // 0x065a3ed8
	System.Void PrepareWaitCheckIds(); // 0x0659e860
	System.Void TickForCheckDebris(); // 0x065a4200
	static System.Void .cctor(); // 0x065a4680
	System.Void <.ctor>b__39_0(FairyGUI.EventContext ctx); // 0x065a4798
	System.Void <.ctor>b__39_1(FairyGUI.EventContext ctx); // 0x065a4810
	System.Void <.ctor>b__39_2(); // 0x065a4888
	System.Void <.ctor>b__39_3(); // 0x065a48f0
	System.Void <.ctor>b__39_4(FairyGUI.EventContext ctx); // 0x065a4958
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSubBatchRecover.<>c__DisplayClass60_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.PartUpgradeData upgradeData; // 0x10
	System.Void .ctor(); // 0x065a0014
	System.Boolean <RefreshFolderSelectState>b__0(WizardGames.Soc.SocClient.Ui.PartUpgradeData b); // 0x065a49d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSubBatchRecover.<>c__DisplayClass68_0 : System.Object
{
	System.Boolean isFolder; // 0x10
	System.Void .ctor(); // 0x065a0ae4
	System.Boolean <GetGTreeNode>b__0(FairyGUI.GTreeNode node); // 0x065a4af4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSubBatchRecover.<>c__DisplayClass70_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSubBatchRecover <>4__this; // 0x10
	FairyGUI.GTreeNode node; // 0x18
	FairyGUI.GComponent obj; // 0x20
	FairyGUI.GButton btn; // 0x28
	WizardGames.Soc.SocClient.Ui.PartUpgradeData upgradeData; // 0x30
	System.Void .ctor(); // 0x065a1a94
	System.Void <RenderTreeNode>b__0(FairyGUI.EventContext ctx); // 0x065a4b8c
	System.Void <RenderTreeNode>b__1(FairyGUI.EventContext ctx); // 0x065a4c10
	System.Void <RenderTreeNode>b__2(); // 0x065a4c9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade : WizardGames.Soc.SocClient.Ui.UiSubpageBase
{
	static SocLogger logger; // 0x0
	static System.Text.StringBuilder builder; // 0x8
	WizardGames.Soc.SocClient.Ui.ComModal comModalCustomUpgrade; // 0x10
	System.String folderItemPath; // 0x18
	System.String childItemPath; // 0x20
	FairyGUI.GTree treeNode; // 0x28
	System.Collections.Generic.List<FairyGUI.GTreeNode> gTreeNodePool; // 0x30
	System.Collections.Generic.List<FairyGUI.GTreeNode> gTreeNodeUsePool; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubBatchUpgradeBinder subBatchUpgradeBinder; // 0x40
	System.Int32 curTargetGrade; // 0x48
	System.Boolean <IsUpgrading>k__BackingField; // 0x4c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.PartUpgradeData> curUpgradeDatas; // 0x50
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.PartUpgradeData>> curUpgradeDataDic; // 0x58
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> tempItemNeedDic; // 0x60
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemNeedDic; // 0x68
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> terrColItemNeedDic; // 0x70
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> storageColItemNeedDic; // 0x78
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> bagItemNeedDic; // 0x80
	System.Collections.Generic.List<System.Int64> terrColItemIdList; // 0x88
	System.Collections.Generic.List<System.Int64> itemIdList; // 0x90
	System.Collections.Generic.List<System.Int64> storageIdList; // 0x98
	WizardGames.Soc.SocClient.Ui.UiTerritoryEdit <ParentNode>k__BackingField; // 0xa0
	WizardGames.Soc.Common.Component.TerritoryBatchUpgradeComponent batchUpgradeComponent; // 0xa8
	System.Boolean isInit; // 0xb0
	static WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade EnabledInst; // 0x10
	System.Collections.Generic.HashSet<System.Int64> cachedData; // 0xb8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.GradeCountInfo> cachedNonCombo; // 0xc0
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ComboPartInfo> cachedComboPartInfos; // 0xc8
	System.Int64 lstUpdateTime; // 0xd0
	System.Boolean versionChanged; // 0xd8
	System.Int32 cachedVersion; // 0xdc
	static System.Collections.Generic.List<WizardGames.Soc.Common.Entity.PartEntity> tempPartList; // 0x18
	System.Boolean useTerrColMat; // 0xe0
	System.Int32 selectChoiceNow; // 0xe4
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.BtnCostItemBinder> costItemGDic; // 0xe8
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.ComBatchUpgradeTreeNode> treeNodeComDic; // 0xf0
	WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade.EUpgradeButtonState curUpgradeButtonState; // 0xf8
	System.Collections.Generic.List<System.Int64> upgradeList; // 0x100
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.PartSortData> partSortDataDic; // 0x108
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.TemplateGrades> tGrades; // 0x110
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.ComboTemplateGrades> cGrades; // 0x118
	static System.String unitSecStr; // 0x20
	static System.String upgradeStr; // 0x28
	System.String cdTime; // 0x120
	System.Int64 unlockTime; // 0x128
	System.String get_Name(); // 0x065a4d38
	System.String get_Icon(); // 0x065a4dd8
	FairyGUI.GComponent get_ContentPanel(); // 0x065a4e50
	FairyGUI.GTreeNode get_rootNode(); // 0x065a4ef4
	System.Boolean get_IsUpgrading(); // 0x065a4f98
	System.Void set_IsUpgrading(System.Boolean value); // 0x065a4ffc
	WizardGames.Soc.SocClient.Ui.UiTerritoryEdit get_ParentNode(); // 0x065a5078
	System.Void set_ParentNode(WizardGames.Soc.SocClient.Ui.UiTerritoryEdit value); // 0x065a50dc
	System.Void set_BatchUpgradeComponent(WizardGames.Soc.Common.Component.TerritoryBatchUpgradeComponent value); // 0x065a515c
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> get_storageBoxIngredients(); // 0x065a51dc
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> get_territoryCabinetIngredients(); // 0x065a5250
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubBatchUpgradeBinder binder, WizardGames.Soc.SocClient.Ui.UiTerritoryEdit parentNode); // 0x065a52c4
	System.Void OnEnable(); // 0x065a66ec
	System.Void OnEnableFromStack(); // 0x065a67a0
	System.Void OnDisable(); // 0x065a6c5c
	System.Void OnDisableToStack(); // 0x065a756c
	System.Boolean OnEscClose(); // 0x065a77e4
	System.Void CleanupUpgradeData(); // 0x065a6f3c
	WizardGames.Soc.Common.Component.TerritoryBatchUpgradeComponent GetTerrBatchUpgradeComponet(); // 0x065a790c
	WizardGames.Soc.Common.CustomType.BatchUpgradeRecord GetBatchUpgradeRecord(); // 0x065a79d8
	System.Void RefreshView(); // 0x065a6b1c
	System.Void RefreshViewState(); // 0x065a7b58
	System.Void QueryConstructionData(System.Boolean refreshIfNoChanged); // 0x065a7a54
	System.Void OnUpgradeDataVersionChanged(System.Int32 dataVersion); // 0x065a8f08
	System.Void OnRequestUpgradeData(System.Int32 dataVersion, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.GradeCountInfo> nonComboPartCount, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ComboPartInfo> comboPartInfo); // 0x065a7fd8
	System.Void AddPartUpgradeData(WizardGames.Soc.SocClient.Ui.PartUpgradeData upgradeData); // 0x065a91e0
	System.Boolean CombinePartData(WizardGames.Soc.Common.SimpleCustom.ComboPartInfo comboPartInfo); // 0x065a9420
	System.Void RefreshItemNeedData(); // 0x065a9b84
	System.Void CalculateTerrColUseMat(); // 0x065aa348
	System.Void OnBatchUpgradeStatusChange(System.Int64 entityId); // 0x065aaa58
	System.Void OnBatchUpgradeFinish(System.Int64 entityId, System.Boolean interrupt); // 0x065aad74
	System.Void OnBluePrintDataChanged(); // 0x065aaf20
	System.Void OnClickUpgradeGrade(System.Int32 grade); // 0x065ab2b8
	System.Void RefreshUpgradeTargetGradeBtns(System.Int32 grade, System.Int32 oldGrade, System.Boolean play); // 0x065a8f84
	System.Void SelectAllParts(System.Boolean isSelect); // 0x065ab510
	System.Void SelectAllOnClick(); // 0x065ab6b8
	System.Void SelectAll(System.Boolean force); // 0x065a9684
	System.Void SetSelectChoice(System.Int32 choice); // 0x065ab720
	static System.Void SetSelectBig(FairyGUI.GButton btn, System.Boolean target, System.Boolean oldValue); // 0x0659fbb8
	static System.Void SetSelectSmall(FairyGUI.GButton btn, System.Boolean target, System.Boolean oldValue, System.Boolean play); // 0x065ab41c
	System.Void SelectMaximumOnClick(); // 0x065ab900
	System.Void SelectMaximum(System.Boolean force); // 0x065a97f0
	System.Void RefreshFolderSelectState(WizardGames.Soc.SocClient.Ui.PartUpgradeData upgradeData); // 0x065abc24
	System.Void SelectCustomOnClick(); // 0x065abfec
	System.Void OnCustomSelectAllClick(); // 0x065ac0c0
	System.Void OnCustomSelectOver(System.Boolean ComModal); // 0x065ac2e4
	System.Void OnRenderListNeed(System.Int32 index, FairyGUI.GObject obj); // 0x065ac3b8
	System.Void CreateGTreeViewNode(); // 0x065aa0cc
	System.Void ClearGTreeConstructionItem(); // 0x065ac710
	FairyGUI.GTreeNode GetGTreeNode(System.Boolean isFolder, WizardGames.Soc.SocClient.Ui.PartUpgradeData upgradeData); // 0x065ac904
	System.Void RefreshGTreeSelectState(); // 0x065ab03c
	System.Void RenderTreeNode(FairyGUI.GTreeNode node, FairyGUI.GComponent obj); // 0x065acb94
	System.Void FolderTreeNodeOnClick(FairyGUI.EventContext context, FairyGUI.GTreeNode node, FairyGUI.GButton button); // 0x065ad7ac
	System.Void ChildTreeNodeOnClick(FairyGUI.GTreeNode node, FairyGUI.GComponent com); // 0x065ade64
	System.Void RefreshCustomSelectAllState(WizardGames.Soc.SocClient.Ui.PartUpgradeData upgradeData); // 0x065adb24
	System.Boolean HasEnoughMaterials(System.Collections.Generic.Dictionary<System.Int64,System.Int32> consumeItem, System.Boolean useTerrCol); // 0x065ab968
	System.Void OnClickUpgrade(); // 0x065ae058
	System.Void CleanupPartSortData(); // 0x065a6d1c
	System.Void CalcUpgradeList(); // 0x065ae8d0
	System.Void ClearCachedData(); // 0x065a7144
	System.Void CalcGrades(); // 0x065af1c8
	System.Void RemoteCallUpgrade(); // 0x065ae72c
	System.Int32 UpgradeDataSort(System.Int64 id1, System.Int64 id2); // 0x065af9cc
	System.Void RefreshBtnUpgradeState(); // 0x065aa6fc
	System.Void UpdateCdTime(); // 0x065afb40
	System.Void UpgradingPageInit(); // 0x065a6a24
	System.Void UpgradingPageRefresh(); // 0x065a7dd0
	System.Void UpdateUpgradingProgress(); // 0x065afd0c
	System.Void Tick(); // 0x065aff90
	static System.Void .cctor(); // 0x065b02b4
	System.Void <.ctor>b__46_0(FairyGUI.EventContext ctx); // 0x065b0424
	System.Void <.ctor>b__46_1(FairyGUI.EventContext ctx); // 0x065b04a0
	System.Void <.ctor>b__46_2(FairyGUI.EventContext ctx); // 0x065b051c
	System.Void <.ctor>b__46_3(FairyGUI.EventContext ctx); // 0x065b0598
	System.Void <.ctor>b__46_4(FairyGUI.EventContext ctx); // 0x065b0614
	System.Void <.ctor>b__46_5(FairyGUI.EventContext ctx); // 0x065b068c
	System.Void <.ctor>b__46_6(FairyGUI.EventContext ctx); // 0x065b0704
	System.Void <.ctor>b__46_7(FairyGUI.EventContext ctx); // 0x065b077c
	System.Void <.ctor>b__46_8(); // 0x065b07f4
	System.Void <.ctor>b__46_9(); // 0x065b085c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade.EUpgradeButtonState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade.EUpgradeButtonState None = 0;
	static WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade.EUpgradeButtonState CanUpgrade = 1;
	static WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade.EUpgradeButtonState NoneSelect = 2;
	static WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade.EUpgradeButtonState MaterialNoEnough = 3;
	static WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade.EUpgradeButtonState Upgrading = 4;
	static WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade.EUpgradeButtonState Recovering = 5;
	static WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade.EUpgradeButtonState NoPermission = 6;
	static WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade.EUpgradeButtonState InCd = 7;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade.<>c__DisplayClass86_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.PartUpgradeData upgradeData; // 0x10
	System.Void .ctor(); // 0x065abf84
	System.Boolean <RefreshFolderSelectState>b__0(WizardGames.Soc.SocClient.Ui.PartUpgradeData b); // 0x065b08c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade.<>c__DisplayClass95_0 : System.Object
{
	System.Boolean isFolder; // 0x10
	System.Void .ctor(); // 0x065acb2c
	System.Boolean <GetGTreeNode>b__0(FairyGUI.GTreeNode node); // 0x065b09e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade.<>c__DisplayClass97_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade <>4__this; // 0x10
	FairyGUI.GTreeNode node; // 0x18
	FairyGUI.GComponent obj; // 0x20
	FairyGUI.GButton btn; // 0x28
	WizardGames.Soc.SocClient.Ui.PartUpgradeData upgradeData; // 0x30
	System.Void .ctor(); // 0x065ad744
	System.Void <RenderTreeNode>b__2(FairyGUI.EventContext ctx); // 0x065b0a80
	System.Void <RenderTreeNode>b__0(FairyGUI.EventContext ctx); // 0x065b0b04
	System.Void <RenderTreeNode>b__1(); // 0x065b0b90
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ECustomBlueprintSlotStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ECustomBlueprintSlotStatus None = 0;
	static WizardGames.Soc.SocClient.Ui.ECustomBlueprintSlotStatus Save = 1;
	static WizardGames.Soc.SocClient.Ui.ECustomBlueprintSlotStatus Replace = 2;
	static WizardGames.Soc.SocClient.Ui.ECustomBlueprintSlotStatus Saving = 3;
	static WizardGames.Soc.SocClient.Ui.ECustomBlueprintSlotStatus CantSave = 4;
	static WizardGames.Soc.SocClient.Ui.ECustomBlueprintSlotStatus Cd = 5;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BlueprintSlotData : System.Object
{
	System.Int32 SlotId; // 0x10
	System.String TypeName; // 0x18
	System.Int32 SlotLevel; // 0x20
	System.Int32 MinPartCount; // 0x24
	System.Int32 MaxPartCount; // 0x28
	System.Int64 UnlockTalentID; // 0x30
	System.Int32 CurrentPartCount; // 0x38
	System.Boolean IsEquipped; // 0x3c
	System.Boolean IsUnlock; // 0x3d
	System.Boolean IsInCd; // 0x3e
	System.Boolean InSaving; // 0x3f
	System.String UnlockTip; // 0x40
	System.Void .ctor(); // 0x065b0c2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSubCustomBlueprint : WizardGames.Soc.SocClient.Ui.UiSubpageBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <ParentNode>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubCustomBlueprintBinder blueprintBinder; // 0x18
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.BtnSlotCardBinder> cardItemDic; // 0x20
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComMaterialsBinder> comMaterialsItemDic; // 0x28
	System.Collections.Generic.List<System.Int64> slotIdList; // 0x30
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.BlueprintSlotData> slotDataCache; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> blueprintCostItemDic; // 0x40
	System.Collections.Generic.Dictionary<System.Int64,System.Single> blueprintMaintainItemDic; // 0x48
	System.Collections.Generic.List<System.Int64> blueprintCostItemIdList; // 0x50
	System.Collections.Generic.List<System.Int64> blueprintMaintainItemIdList; // 0x58
	WizardGames.Soc.SocClient.Ui.ECustomBlueprintSlotStatus curSlotStatus; // 0x60
	System.Int32 currentSlotId; // 0x64
	System.Int64 saveRemainTime; // 0x68
	System.String inputBlueprintName; // 0x70
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ConstructionBlueprintBriefData> blueprintBriefData; // 0x78
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveData> curSlotPartData; // 0x80
	System.Int32 curShowPartCount; // 0x88
	FairyGUI.Controller ctrBtnSwitch; // 0x90
	WizardGames.Soc.SocClient.Ui.PartBlueprintModelHandler _partBlueprintModelHandler; // 0x98
	UnityEngine.AzureSky.AzureWeatherPresetEnum preTODEnum; // 0xa0
	System.Action<System.Boolean> parentBgVisibleAction; // 0xa8
	System.Boolean canSaveBlueprint; // 0xb0
	System.Int32 SpecifiedSlotId; // 0xb4
	System.String get_Name(); // 0x065b0c94
	System.String get_Icon(); // 0x065b0d34
	FairyGUI.GComponent get_ContentPanel(); // 0x065b0e1c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase get_ParentNode(); // 0x065b0ec0
	System.Void set_ParentNode(WizardGames.Soc.Common.Unity.Ui.WindowComBase value); // 0x065b0f24
	System.Int32 get_customizeBpSaveCd(); // 0x065b0fa4
	System.Single get_blueprintRotateSpeed(); // 0x065b1098
	System.Boolean get_IsReplace(); // 0x065b1180
	System.Boolean get_isBaseGrade(); // 0x065b11ec
	WizardGames.Soc.Common.Entity.TerritoryEntity get_territoryEntity(); // 0x065b12a8
	System.Int32 get_curTerritoryPartCount(); // 0x065b1370
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubCustomBlueprintBinder binder, WizardGames.Soc.Common.Unity.Ui.WindowComBase parentNode, System.Boolean canSave, System.Action<System.Boolean> bgVisibleAction); // 0x065b13fc
	System.Void OpenBlueprintDetail(System.Int32 slotId); // 0x065b221c
	System.Void OnEnable(); // 0x065b233c
	System.Void OnDisable(); // 0x065b360c
	System.Void HandleSubscribeDictUpdate(System.Boolean isAdd); // 0x065b31cc
	System.Void RecoverTODOnExit(); // 0x065b3900
	System.Void BriefDataDictRefresh(WizardGames.Soc.Share.Framework.ECustomDictOpType op, System.Int32 key, WizardGames.Soc.Common.CustomType.ConstructionBlueprintBriefData oldVal); // 0x065b3a64
	System.Void SwitchModelShowGrade(); // 0x065b3b84
	System.Void OnFps1Update(System.Single dt); // 0x065b3c38
	System.Void OnFps30Update(System.Single dt); // 0x065b42a0
	System.Void OnModelLoadFinishEvent(System.Int64 blueprintId); // 0x065b43f0
	System.Void SetCurrentBlueprintName(System.String blueprintName); // 0x065b4628
	System.Void OnSaveButtonClick(); // 0x065b47a8
	System.Void ExecuteSaveBlueprint(); // 0x065b4cb8
	System.Void OnSlotItemClick(FairyGUI.EventContext context); // 0x065b5060
	WizardGames.Soc.Common.CustomType.ConstructionBlueprintBriefData GetBlueprintBriefData(System.Int64 slotId); // 0x065b3ec4
	System.Void SelectSlotItem(System.Int32 slotId, System.Boolean force); // 0x065b5370
	System.Void UpdateTitleArea(WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComInfoPanelBinder infoPanel, WizardGames.Soc.SocClient.Ui.BlueprintSlotData slotData, WizardGames.Soc.Common.CustomType.ConstructionBlueprintBriefData briefData); // 0x065b5750
	System.Void UpdateCapacityInfo(WizardGames.Soc.SocClient.Ui.BlueprintSlotData slotData, WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComScaleBinder scaleBinder); // 0x065b58e4
	System.Void UpdateRightPanelState(WizardGames.Soc.SocClient.Ui.BlueprintSlotData slotData, WizardGames.Soc.Common.CustomType.ConstructionBlueprintBriefData briefData); // 0x065b5d44
	WizardGames.Soc.SocClient.Ui.ECustomBlueprintSlotStatus DetermineSaveButtonStatus(WizardGames.Soc.SocClient.Ui.BlueprintSlotData slotData, WizardGames.Soc.Common.CustomType.ConstructionBlueprintBriefData briefData); // 0x065b6160
	System.Void HandleBlueprintModel(WizardGames.Soc.SocClient.Ui.BlueprintSlotData slotData, WizardGames.Soc.Common.CustomType.ConstructionBlueprintBriefData briefData); // 0x065b5dec
	System.Void UpdateCenterAreaStatus(WizardGames.Soc.SocClient.Ui.BlueprintSlotData slotData); // 0x065b5b5c
	System.Void SetSaveButtonStatus(WizardGames.Soc.SocClient.Ui.ECustomBlueprintSlotStatus status); // 0x065b4178
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject item); // 0x065b6234
	System.Void ReceiveBlueprintPartDataList(System.Int64 blueprintId, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveData> blueprintPartDataList); // 0x065b6940
	System.Void ReceiveBlueprintBriefDataList(System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ConstructionBlueprintBriefData> blueprintBriefDataList); // 0x065b7afc
	System.Int32 SlotSorter(System.Int64 a, System.Int64 b); // 0x065b8128
	System.Void RefreshBlueprintList(); // 0x065b7d68
	System.Void RefreshBlueprintMaintainUi(System.Int64 bpId); // 0x065b7320
	System.Void RefreshBuildConsumeUi(); // 0x065b6d74
	System.Void ConstructItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x065b831c
	System.Void MaintainItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x065b86fc
	WizardGames.Soc.Common.Entity.TerritoryEntity GetTerritoryEntity(); // 0x065b130c
	System.Void SetBlueprintInfoPanel(System.Boolean isEquipped); // 0x065b5eec
	static System.Int32 SlotDataSort(WizardGames.Soc.SocClient.Ui.BlueprintSlotData slotDataA, WizardGames.Soc.SocClient.Ui.BlueprintSlotData slotDataB); // 0x065b8240
	System.Void RefreshSlotDataCache(); // 0x065b2a34
	static System.Void .cctor(); // 0x065b8b00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSubpageSelect : System.Object
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.IUiSubpage> subpages; // 0x10
	System.Int32 selectedIndex; // 0x18
	WizardGames.Soc.SocClient.Ui.IUiSubpage get_SubPageNow(); // 0x065b8bd4
	System.Void AddSubpage(WizardGames.Soc.SocClient.Ui.IUiSubpage subpage); // 0x065b8c88
	System.Void OnClickSubpageLstItem(System.Int32 index); // 0x065b8d7c
	System.Void SetSelected(System.Int32 index, System.Boolean isStackOp, System.Boolean isInit); // 0x065b8e20
	System.Void DisableNow(System.Boolean isStackOp); // 0x065b90a4
	System.Void OnDestroy(); // 0x065b9244
	System.Void .ctor(); // 0x065b92ac
	static System.Void .cctor(); // 0x065b9368
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.IUiSubpage : 
{
	
	System.Void OnEnable(); // 0x055049cc
	System.Void OnDisable(); // 0x055049cc
	System.Void OnEnableFromStack(); // 0x055049cc
	System.Void OnDisableToStack(); // 0x055049cc
	System.Boolean get_IsLocked(); // 0x054c4760
	System.Boolean LockedClickedDeal(); // 0x054c4760
	System.Boolean OnEscClose(); // 0x054c4760
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSubpageBase : System.Object, WizardGames.Soc.SocClient.Ui.IUiSubpage
{
	
	System.String get_Name(); // 0x054e7844
	System.String get_Icon(); // 0x065b943c
	FairyGUI.GComponent get_ContentPanel(); // 0x054e7844
	System.Boolean get_IsLocked(); // 0x065b94bc
	System.Boolean LockedClickedDeal(); // 0x065b9520
	System.Void OnDisable(); // 0x055049cc
	System.Void OnDisableToStack(); // 0x065b9584
	System.Void OnEnable(); // 0x055049cc
	System.Void OnEnableFromStack(); // 0x065b95e8
	System.Boolean OnEscClose(); // 0x065b964c
	System.Void .ctor(); // 0x0659c8a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComUpkeepItemData : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComUpkeepItemBinder Binder; // 0x10
	WizardGames.Soc.SocClient.Ui.ComItemIcon ComItem; // 0x18
	WizardGames.Soc.Common.CustomType.ItemContainerNode Container; // 0x20
	WizardGames.Soc.Common.CustomType.BaseItemNode Node; // 0x28
	System.Int32 playerAmount; // 0x30
	System.Int32 needAmount; // 0x34
	System.Int32 remainAmount; // 0x38
	System.Int64 bizId; // 0x40
	System.String upkeepHint; // 0x48
	System.String upkeepWarning; // 0x50
	System.Void Bind(WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComUpkeepItemBinder binder, WizardGames.Soc.SocClient.Ui.ComItemIcon comItem); // 0x065b96b0
	System.Void SetNodeData(WizardGames.Soc.Common.Component.TerritoryCabinetComponent comp, System.Int64 id); // 0x065b9e88
	System.Void NodeRefresh(); // 0x065b988c
	System.Void Refresh(); // 0x065b9a78
	System.Int32 GetMaxCanMove(); // 0x065b9ff4
	System.Void .ctor(); // 0x065ba14c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSubToolcupBoard : WizardGames.Soc.SocClient.Ui.UiSubpageBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.UiTerritoryCenter parentUi; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubToolcupBoardBinder subToolcupBoard; // 0x18
	static System.Boolean IsMovingIn; // 0x8
	static WizardGames.Soc.SocClient.Ui.UiSubToolcupBoard SubpageNow; // 0x10
	static System.Int64[] dealIds; // 0x18
	static System.Int32[] idHints; // 0x20
	static System.Int32[] idWarning; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.ComUpkeepItemData> upkeepItemDatas; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComItemIcon> comItemIcons; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComUpkeepItemBinder> comItemBinders; // 0x30
	System.Int64[] idsNow; // 0x38
	System.Int32 putHours; // 0x40
	System.Int64 cachedId; // 0x48
	FairyGUI.Transition refreshTransition; // 0x50
	FairyGUI.Transition switchTransition; // 0x58
	FairyGUI.GLoader loaderTouchRotate; // 0x60
	System.Int32 oldUpkeepTime; // 0x68
	static System.Int32[] ConvertedDateTime; // 0x30
	static System.Collections.Generic.List<System.Int64> FullPutLst; // 0x38
	System.Int64 capturingTime; // 0x70
	System.String get_Name(); // 0x065ba1b4
	System.String get_Icon(); // 0x065ba254
	FairyGUI.GComponent get_ContentPanel(); // 0x065ba2cc
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubToolcupBoardBinder binder, WizardGames.Soc.SocClient.Ui.UiTerritoryCenter parent); // 0x065ba370
	System.Void OnEnable(); // 0x065badfc
	System.Void UpdateTrack(); // 0x065bb210
	System.Void OnDisable(); // 0x065bba5c
	System.Void RefreshPlayerAmount(); // 0x065bbbc4
	System.Void RefreshRemainAmount(); // 0x065bbf84
	System.Void RefreshUpkeepTime(); // 0x065bb298
	System.Void OnShowUpKeepInfo(System.Single upkeepTime, System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemCost, System.Int64 entityId); // 0x065bc488
	System.Void RefreshLst(); // 0x065bc6c4
	static System.Boolean ConvertMinuteToDate(System.Int32 upKeepMinute); // 0x065bc1d0
	System.Void OnClickUpkeepItem(FairyGUI.EventContext context); // 0x065bc9dc
	System.Void OnClickPutAll(); // 0x065bceb4
	System.Void OnClickPutThreeHours(); // 0x065bda84
	System.Void SendPutRPC(System.Int32 time, System.Int64 onlyOneBizId); // 0x065bcf20
	System.Void OnClickItemMoveToInventorySome(System.Int64 bizId); // 0x065bdaf0
	System.Void OnClickConfigMoveToBoxSome(System.Int64 bizId); // 0x065bdc88
	System.Void OnClickItemMoveToInventory(System.Int64 bizId); // 0x065bdee4
	WizardGames.Soc.SocClient.Ui.ComUpkeepItemData GetData(System.Int64 bizId); // 0x065be000
	static System.Int32 GetCanMoveCount(WizardGames.Soc.SocClient.Ui.ComUpkeepItemData data); // 0x065bde38
	System.Void OnClickPopGuide(); // 0x065be0ac
	static System.Void .cctor(); // 0x065be14c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSubToolSafeBox : WizardGames.Soc.SocClient.Ui.UiSubpageBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.UiInventoryOthersidePanel panel; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubSafeBoxBinder safeBoxBinder; // 0x18
	WizardGames.Soc.SocClient.Ui.UiTerritoryCenter parentWindow; // 0x20
	WizardGames.Soc.SocClient.Ui.EUISafeBoxState safeBoxState; // 0x28
	static System.Boolean IsSafeBoxActived; // 0x8
	System.Boolean isInDestroyCD; // 0x2c
	FairyGUI.GLoader loaderTouchRotate; // 0x30
	System.String get_Name(); // 0x065be6c8
	System.String get_Icon(); // 0x065be768
	FairyGUI.GComponent get_ContentPanel(); // 0x065be7e0
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubSafeBoxBinder binder, WizardGames.Soc.SocClient.Ui.UiTerritoryCenter window); // 0x065be884
	System.Void OnEnable(); // 0x065bec3c
	System.Void OnDisable(); // 0x065bfa98
	System.Void OnFps30Update(System.Single dt); // 0x065bfbbc
	System.Void UpdateDestroyBtn(); // 0x065bfc54
	System.Void UpdatePermissionClose(); // 0x065bfdc0
	System.Void TriggerPutInAll(System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> func); // 0x065c01b4
	System.Void DestroySafeBox(FairyGUI.EventContext context); // 0x065c0280
	System.Void OnQuickStorage(); // 0x065c054c
	System.Void UpdateSafeBoxState(); // 0x065c0c70
	System.Void SafeBoxStateRefresh(); // 0x065c0d50
	System.Void SetPartCtrl(WizardGames.Soc.SocClient.Ui.UISafeBoxStateData safeBoxStateData); // 0x065bf83c
	System.Void UpdateTrack(); // 0x065c1188
	System.Void SetBtnState(System.Boolean enableBtn, System.Int32 ctrlState); // 0x065bff10
	System.Boolean get_IsLocked(); // 0x065c1240
	System.Boolean LockedClickedDeal(); // 0x065c12ec
	static System.Void .cctor(); // 0x065c1418
	System.Void <SafeBoxStateRefresh>b__24_0(System.Boolean res); // 0x065c14ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSubToolSafeBox.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiSubToolSafeBox.<>c <>9; // 0x0
	static System.Action <>9__15_0; // 0x8
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__15_1; // 0x10
	static System.Action <>9__21_0; // 0x18
	static System.Void .cctor(); // 0x065c1684
	System.Void .ctor(); // 0x065c16e8
	System.Void <OnEnable>b__15_0(); // 0x065c1750
	System.Void <OnEnable>b__15_1(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x065c1804
	System.Void <DestroySafeBox>b__21_0(); // 0x065c191c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSubToolSafeBox.<>c__DisplayClass22_0 : System.Object
{
	System.Collections.Generic.HashSet<System.Int64> bizIdSet; // 0x10
	System.Void .ctor(); // 0x065c0c08
	System.Boolean <OnQuickStorage>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x065c197c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTerritoryCenter : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiStopLooting, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiTriggerGuide
{
	static SocLogger _logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.UiTerritoryCenterBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.UiSubpageSelect uiSubpageSelect; // 0x340
	System.Int64 PartEntityId; // 0x348
	WizardGames.Soc.SocClient.Ui.UiSubToolSafeBox subToolSafeBox; // 0x350
	WizardGames.Soc.SocClient.Ui.UiSubToolcupBoard subToolcupBoard; // 0x358
	FairyGUI.Transition tabSwitchTrans; // 0x360
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x368
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x370
	WizardGames.Soc.SocClient.Manager.UiConstructionPreviewSceneController uiPreviewSceneController; // 0x378
	System.Boolean isActiveChangeByStatck; // 0x380
	System.Void OnInit(); // 0x065c1a40
	System.Void ClickTab(System.Int32 tabId, System.Boolean btnClicked); // 0x065c2590
	System.Void RefreshSelectToFirst(); // 0x065c2c7c
	System.Void SwitchTab(System.Int32 tabId, System.Boolean btnClicked); // 0x065c2bc4
	System.Void RefreshLock(); // 0x065c2ddc
	System.Void OnFps30Update(System.Single dt); // 0x065c305c
	System.Void OnEnable(); // 0x065c3124
	System.Void OnDestroy(); // 0x065c3578
	System.Void OnDisable(); // 0x065c3670
	System.Void OnShowByLayerStack(); // 0x065c3748
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x065c37d0
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x065c386c
	static System.Void OpenWindow(System.Int64 collectionID); // 0x065c3938
	System.Void OnStartLootingAck(System.Int64 colId); // 0x065c24ec
	System.Void CheckReputationPart(UnityEngine.GameObject goModel, System.Boolean isReputationpart, System.Boolean hasAuthorized); // 0x065c3bc4
	System.Boolean CheckReputationPart(); // 0x065c4044
	static System.Void CloseWindow(); // 0x065c00c0
	System.Void StopLooting(); // 0x065c4204
	WizardGames.Soc.Common.Entity.PartEntity GetPartEntity(); // 0x065c4114
	System.Void ActiveSafeBox(); // 0x065c4484
	WizardGames.Soc.SocClient.Ui.UISafeBoxStateData GetSafeBoxState(); // 0x065bf1ec
	System.Void OnSubpageSwitch(); // 0x065bf17c
	System.Boolean TriggerGuide(); // 0x065c48f8
	System.Void .ctor(); // 0x065c4a6c
	static System.Void .cctor(); // 0x065c4b30
	System.Void <OnInit>b__10_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x065c4c04
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTerritoryCenter.<>c__DisplayClass11_0 : System.Object
{
	System.Int32 tabId; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTerritoryCenter <>4__this; // 0x18
	System.Boolean btnClicked; // 0x20
	System.Void .ctor(); // 0x065c2b5c
	System.Void <ClickTab>b__0(System.Boolean res); // 0x065c4cdc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTerritoryCenter.<>c__DisplayClass17_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTerritoryCenter <>4__this; // 0x10
	System.Int64 tempId; // 0x18
	System.Void .ctor(); // 0x065c3510
	System.Void <OnEnable>b__0(UnityEngine.GameObject goBg, UnityEngine.GameObject goModel); // 0x065c4e9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTerritoryCenter.<>c__DisplayClass23_0 : System.Object
{
	System.Int64 collectionID; // 0x10
	System.Void .ctor(); // 0x065c3b5c
	System.Void <OpenWindow>b__0(System.Boolean res); // 0x065c5044
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UISafeBoxStateData : System.Object
{
	WizardGames.Soc.Common.Entity.PartEntity partEntity; // 0x10
	WizardGames.Soc.Common.Entity.TerritoryEntity territoryEntity; // 0x18
	WizardGames.Soc.SocClient.Ui.EUISafeBoxState State; // 0x20
	System.Void .ctor(); // 0x065c4890
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EUISafeBoxState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EUISafeBoxState UnKnow = 0;
	static WizardGames.Soc.SocClient.Ui.EUISafeBoxState NotMatch = 1;
	static WizardGames.Soc.SocClient.Ui.EUISafeBoxState PartEntityNotFind = 2;
	static WizardGames.Soc.SocClient.Ui.EUISafeBoxState TerritoryEntityNotFind = 3;
	static WizardGames.Soc.SocClient.Ui.EUISafeBoxState NotActive = 4;
	static WizardGames.Soc.SocClient.Ui.EUISafeBoxState Actived = 5;
	static WizardGames.Soc.SocClient.Ui.EUISafeBoxState NoSafeBox = 6;
	static WizardGames.Soc.SocClient.Ui.EUISafeBoxState NoPermission = 7;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTerritoryEdit : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiStopLooting, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	static WizardGames.Soc.SocClient.Ui.UiTerritoryEdit Instance; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.UiTerritoryEditBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.UiSubpageSelect uiSubpageSelect; // 0x340
	WizardGames.Soc.SocClient.Ui.UiSubBatchUpgrade uiSubBatchUpgrade; // 0x348
	WizardGames.Soc.SocClient.Ui.UiSubBatchRecover uiSubBatchRecover; // 0x350
	WizardGames.Soc.SocClient.Ui.UiSubCustomBlueprint uiSubCustomBlueprint; // 0x358
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x360
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x368
	System.Boolean isActiveChangeByStatck; // 0x370
	System.Int64 attackTime; // 0x378
	System.Void OnInit(); // 0x065c518c
	System.Void OnEnable(); // 0x065c5dd0
	System.Void UpdateGuide(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x065c61e4
	System.Void OnDisable(); // 0x065c6318
	System.Void OnDestroy(); // 0x065c65dc
	System.Void OnShowByLayerStack(); // 0x065c6658
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x065c66cc
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x065c6754
	static System.Void OpenWindow(System.Int64 collectionID); // 0x065c68d0
	static System.Void CloseWindow(); // 0x065c6b0c
	System.Void StopLooting(); // 0x065c6bfc
	System.Void SetItemConfirmState(System.Int32 idx, System.Boolean force); // 0x065c6c68
	System.Void SetAttackedTime(System.Int32 cdTime); // 0x065c6f60
	System.Void UpdateAttackedTime(); // 0x065c72d0
	System.Void OnTerrCenterRemoved(System.Int64 entityId); // 0x065c781c
	System.Void OnFps10Update(System.Single dt); // 0x065c7a64
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x065c7b4c
	static WizardGames.Soc.Common.Entity.TerritoryEntity GetCurLootingTerritory(); // 0x065c7594
	System.Void SetBgVisible(System.Boolean isShow); // 0x065c7bcc
	static WizardGames.Soc.Common.Component.RootNodeComponent GetToolcupboardNode(); // 0x065c79c4
	static System.Int64 GetToolcupboardEntityId(); // 0x065c7ca0
	static System.Int64 TerritoryUpgradingTs(WizardGames.Soc.Common.Entity.TerritoryEntity territory); // 0x065c7d10
	static System.Int64 GetUpgradingCDFinishTime(WizardGames.Soc.Common.Entity.TerritoryEntity territory); // 0x065c7dd8
	static System.Int64 GetRecoveringCDFinishTime(WizardGames.Soc.Common.Entity.TerritoryEntity territory); // 0x065c7ef8
	System.Boolean HasUpgradePermission(); // 0x065c8018
	System.Boolean HasRecoverPermission(); // 0x065c81ec
	System.Void OnFps30Update(System.Single dt); // 0x065c83c0
	System.Void OnFps1Update(System.Single dt); // 0x065c8448
	System.Void .ctor(); // 0x065c84d0
	System.Void <OnInit>b__9_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x065c8594
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTerritoryEdit.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTerritoryEdit.<>c <>9; // 0x0
	static System.Action<System.Boolean> <>9__18_0; // 0x8
	static System.Void .cctor(); // 0x065c86ec
	System.Void .ctor(); // 0x065c8750
	System.Void <OpenWindow>b__18_0(System.Boolean res); // 0x065c87b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTerritoryEditPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static WizardGames.Soc.SocClient.Ui.UiTerritoryEditPop Instance; // 0x0
	WizardGames.Soc.SocClient.Ui.ComModal ComModalAttacked; // 0x338
	WizardGames.Soc.SocClient.Ui.ComModal ComModalReconfirm; // 0x340
	WizardGames.Soc.SocClient.Ui.ComModal ComModalSaveBlueprint; // 0x348
	WizardGames.Soc.SocClient.Ui.ComModal ComModalSaveBlueprintConfirm; // 0x350
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.UiTerritoryEditPopBinder binder; // 0x358
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.ItemContainerNode> TerritoryNodesDic; // 0x360
	WizardGames.Soc.SocClient.Ui.ComInputBox customBpInputBox; // 0x368
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.BtnCostItemBinder> costItemGDic; // 0x370
	System.Collections.Generic.List<System.Int64> idList; // 0x378
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> needDic; // 0x380
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> totNeedDic; // 0x388
	System.Action doubleConfirmCallback; // 0x390
	System.Int32 get_SelectedCtrlState(); // 0x065c76d8
	WizardGames.Soc.SocClient.Ui.UiSubCustomBlueprint get_uiSubCustomBlueprint(); // 0x065c88b8
	System.Int32 get_bpNameMaxLength(); // 0x065c8948
	static System.Void OpenWindow(); // 0x065c60b8
	static System.Void CloseWindow(); // 0x065c64ec
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x065c8a30
	System.Void OnInit(); // 0x065c8c14
	System.Void OnDestroy(); // 0x065c9f1c
	System.Void OnEnable(); // 0x065c9f84
	System.Void OnDisable(); // 0x065ca274
	System.Void SetItemConfirmState(System.Int32 state, System.Boolean force); // 0x065c6d14
	System.Void SetAttackedTime(System.Int32 cdTime); // 0x065c7000
	System.Void SetCostDoubleConfirm(System.Collections.Generic.List<System.Int64> lst, System.Collections.Generic.Dictionary<System.Int64,System.Int32> dic, System.Collections.Generic.Dictionary<System.Int64,System.Int32> totDic, System.Action confirmCallback, System.Boolean isBatchUpgrade); // 0x065ca30c
	System.Void OnClickDoubleConfirm(); // 0x065ca8ec
	System.Void OnClickDoubleConfirmCancel(); // 0x065ca980
	System.Void OnCostItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x065ca9ec
	static System.Void DrawCostItem(WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.BtnCostItemBinder binder, System.Int64 templateId, System.Int32 hasNum, System.Int32 needNum, System.Int32 source, System.Boolean isEnough); // 0x065cac6c
	System.Void InitCustomBlueprintPop(); // 0x065c981c
	System.Void SaveBlueprintPopOkEvent(); // 0x065cb034
	System.Void SaveBlueprintPopConfirmOkEvent(); // 0x065cb224
	System.Void OpenSaveBlueprintPop(System.Boolean isReplace); // 0x065cb4d0
	System.Void .ctor(); // 0x065cb974
	System.Void <OnInit>b__17_0(); // 0x065cbaa4
	System.Void <OnInit>b__17_1(); // 0x065cbb18
	System.Void <InitCustomBlueprintPop>b__33_0(); // 0x065cbb8c
	System.Void <InitCustomBlueprintPop>b__33_1(); // 0x065cbc00
	System.Void <InitCustomBlueprintPop>b__33_2(); // 0x065cbe18
	System.Void <InitCustomBlueprintPop>b__33_3(); // 0x065cbe8c
	System.Void <OpenSaveBlueprintPop>b__36_0(); // 0x065cbef8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTestCaseSelector : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLogin.ComTestCaseSelectorRootBinder binder; // 0x338
	System.Collections.Generic.List<System.Type> casesSelected; // 0x340
	System.String skyAutoCaseJsonFileSelected; // 0x348
	System.String selectedServerId; // 0x350
	System.String selectedServer; // 0x358
	WizardGames.Soc.SocClient.Test.Automation.MainTest mainTestInstance; // 0x360
	System.Type SkyAutoTestCaseType; // 0x368
	System.Collections.Generic.List<System.String> jsonFiles; // 0x370
	SimpleJSON.JSONArray serverDatas; // 0x378
	System.Collections.Generic.List<System.String> botBranchDatas; // 0x380
	System.String selectedBotBranch; // 0x388
	System.String jsonConfigPath; // 0x390
	System.Void OnInit(); // 0x065cbf64
	System.Threading.Tasks.Task RequestServerData(System.String serverPath); // 0x065cc644
	System.Threading.Tasks.Task<SimpleJSON.JSONArray> FetchData(System.Net.Http.HttpClient httpClient, System.String serverPath); // 0x065cc8bc
	System.Threading.Tasks.Task RequestBotBranchData(System.String serverPath, System.Int32 projectId); // 0x065cc778
	System.Void BtnConfirmClick(FairyGUI.EventContext context); // 0x065cca24
	System.Void RenderCaseItem(System.Int32 index, FairyGUI.GObject item); // 0x065ccb94
	System.Void RenderJSONConfigItem(System.Int32 index, FairyGUI.GObject item); // 0x065cce54
	System.Void RenderServerConfigItem(System.Int32 index, FairyGUI.GObject item); // 0x065cd0d4
	System.Void RenderBotBranchItem(System.Int32 index, FairyGUI.GObject item); // 0x065cd3a4
	System.Void .ctor(); // 0x065cd624
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTestCaseSelector.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTestCaseSelector.<>c <>9; // 0x0
	static System.Func<System.String,System.Boolean> <>9__15_0; // 0x8
	static System.Func<System.String,System.Boolean> <>9__15_1; // 0x10
	static System.Func<System.String,System.Boolean> <>9__15_2; // 0x18
	static System.Void .cctor(); // 0x065cd85c
	System.Void .ctor(); // 0x065cd8c0
	System.Boolean <RequestBotBranchData>b__15_0(System.String b); // 0x065cd928
	System.Boolean <RequestBotBranchData>b__15_1(System.String b); // 0x065cd9c4
	System.Boolean <RequestBotBranchData>b__15_2(System.String b); // 0x065cda60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTestCaseSelector.<>c__DisplayClass17_0 : System.Object
{
	FairyGUI.Controller ctrlCheck; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTestCaseSelector <>4__this; // 0x18
	System.Int32 index; // 0x20
	System.Void .ctor(); // 0x065ccdec
	System.Void <RenderCaseItem>b__0(FairyGUI.EventContext context); // 0x065cdafc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTestCaseSelector.<>c__DisplayClass18_0 : System.Object
{
	FairyGUI.Controller ctrlCheck; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTestCaseSelector <>4__this; // 0x18
	System.Int32 index; // 0x20
	System.Void .ctor(); // 0x065cd06c
	System.Void <RenderJSONConfigItem>b__0(FairyGUI.EventContext context); // 0x065cde9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTestCaseSelector.<>c__DisplayClass19_0 : System.Object
{
	FairyGUI.Controller ctrlCheck; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTestCaseSelector <>4__this; // 0x18
	System.Int32 index; // 0x20
	System.Void .ctor(); // 0x065cd33c
	System.Void <RenderServerConfigItem>b__0(FairyGUI.EventContext context); // 0x065cdfd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTestCaseSelector.<>c__DisplayClass20_0 : System.Object
{
	FairyGUI.Controller ctrlCheck; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTestCaseSelector <>4__this; // 0x18
	System.Int32 index; // 0x20
	System.Void .ctor(); // 0x065cd5bc
	System.Void <RenderBotBranchItem>b__0(FairyGUI.EventContext context); // 0x065ce19c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiTestCaseSelector.<FetchData>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder<SimpleJSON.JSONArray> <>t__builder; // 0x18
	System.String serverPath; // 0x30
	System.Net.Http.HttpClient httpClient; // 0x38
	System.Runtime.CompilerServices.TaskAwaiter<System.String> <>u__1; // 0x40
	System.Void MoveNext(); // 0x065ce2b8
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x065ce660
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiTestCaseSelector.<RequestBotBranchData>d__15 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	System.Int32 projectId; // 0x30
	System.String serverPath; // 0x38
	WizardGames.Soc.SocClient.Ui.UiTestCaseSelector <>4__this; // 0x40
	System.Net.Http.HttpClient <httpClient>5__2; // 0x48
	System.Runtime.CompilerServices.TaskAwaiter<System.Net.Http.HttpResponseMessage> <>u__1; // 0x50
	System.Runtime.CompilerServices.TaskAwaiter<System.String> <>u__2; // 0x58
	System.Void MoveNext(); // 0x065ce718
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x065cfa24
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiTestCaseSelector.<RequestServerData>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Ui.UiTestCaseSelector <>4__this; // 0x30
	System.String serverPath; // 0x38
	System.Net.Http.HttpClient <httpClient>5__2; // 0x40
	System.Runtime.CompilerServices.TaskAwaiter<SimpleJSON.JSONArray> <>u__1; // 0x48
	System.Void MoveNext(); // 0x065cfac8
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x065d0188
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ThrownTipData : System.Object
{
	System.Int64 TableId; // 0x10
	System.Single Duration; // 0x18
	System.Single InitDuration; // 0x1c
	UnityEngine.Vector3 Pos; // 0x20
	System.String IconPath; // 0x30
	System.Boolean IsInit; // 0x38
	System.Void Update(WizardGames.Soc.Common.Entity.ThrownEntity thrownEntity); // 0x065d022c
	System.Void Clear(); // 0x065d0450
	System.Void .ctor(); // 0x065d051c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiThrownTips : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	System.Collections.Generic.List<FairyGUI.GComponent> _thrownTips; // 0x338
	System.Collections.Generic.List<FairyGUI.Controller> _thrownTipControllers; // 0x340
	System.Collections.Generic.List<FairyGUI.GObject> _thrownTipImgDir; // 0x348
	System.Collections.Generic.List<FairyGUI.GLoader> _thrownTipIcons; // 0x350
	System.Collections.Generic.List<FairyGUI.GComponent> _RFDetonationtips; // 0x358
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.ThrownTipData> _thrownTipDatas; // 0x360
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.IRFDetonationEntity> _RFDetonationDatas; // 0x368
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ThrownTipData> _showTipDatas; // 0x370
	FairyGUI.GObjectPool _RFDetonationTipPool; // 0x378
	UnityEngine.Vector2 centerPos; // 0x380
	FairyGUI.Transition _showTrans; // 0x388
	FairyGUI.Transition _hideTrans; // 0x390
	FairyGUI.GObject imgHit1; // 0x398
	FairyGUI.GObject imgHit2; // 0x3a0
	System.Boolean isShowingDamageEdffect; // 0x3a8
	static System.Collections.Generic.Dictionary<System.Int32,System.String> distanceStrDict; // 0x0
	UnityEngine.Vector2 rectCenter; // 0x3ac
	UnityEngine.Rect rect; // 0x3b4
	UnityEngine.Vector2 leftTop; // 0x3c4
	UnityEngine.Vector2 rightTop; // 0x3cc
	UnityEngine.Vector2 leftBottom; // 0x3d4
	UnityEngine.Vector2 rightBottom; // 0x3dc
	UnityEngine.Vector2 rectCenterLocal; // 0x3e4
	FairyGUI.GComponent panelRoot; // 0x3f0
	UnityEngine.Vector3Int lastPlayerPos; // 0x3f8
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.IRFDetonationEntity> get_RFDetonationDatas(); // 0x065d0584
	System.Single get_WarningTipRadius(); // 0x065d05e8
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x065d0738
	System.Void OnInit(); // 0x065d07b8
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x065d16e8
	System.Void OnEnable(); // 0x065d1918
	System.Void OnDisable(); // 0x065d1a3c
	System.Void OnDestroy(); // 0x065d1ad8
	System.Void SortTipData(); // 0x065d1cac
	System.Void OnFps10Update(System.Single dt); // 0x065d1e10
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x065d2640
	System.Void UpdateTip(UnityEngine.Vector3 pos, FairyGUI.GComponent tip, System.Int32 tipIndex, System.String iconPath); // 0x065d242c
	System.Void UpdateRFDetonationTip(UnityEngine.Vector3 pos, FairyGUI.GComponent tip); // 0x065d2d88
	UnityEngine.Vector2 GetWithInRectPos(UnityEngine.Vector2 pos, System.Boolean& isOutside); // 0x065d33b4
	System.Single CalcAngle(UnityEngine.Vector3 thrownPos); // 0x065d3214
	System.Boolean InRange(WizardGames.Soc.SocClient.Ui.ThrownTipData data); // 0x065d34cc
	System.Boolean ShowWarningUiTip(WizardGames.Soc.SocClient.Ui.ThrownTipData data); // 0x065d22fc
	System.Void AddThrownTipData(System.Int64 entityID, WizardGames.Soc.SocClient.Ui.ThrownTipData data); // 0x065d3690
	System.Void RemoveThrownTipData(System.Int64 entityID); // 0x065d1838
	System.Void ShowThrownDamageTipInternal(); // 0x065d37d8
	static System.Void ShowThrownDamageTip(); // 0x065d38c4
	System.Void .ctor(); // 0x065d39a8
	static System.Void .cctor(); // 0x065d3a34
	System.Void <ShowThrownDamageTipInternal>b__49_0(); // 0x065d3ad0
	System.Void <ShowThrownDamageTipInternal>b__49_1(); // 0x065d3b94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiThrownTips.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiThrownTips.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.ThrownTipData> <>9__36_0; // 0x8
	static System.Void .cctor(); // 0x065d3cd4
	System.Void .ctor(); // 0x065d3d38
	System.Int32 <SortTipData>b__36_0(WizardGames.Soc.SocClient.Ui.ThrownTipData a, WizardGames.Soc.SocClient.Ui.ThrownTipData b); // 0x065d3da0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiThrownTips.<>c__DisplayClass38_0 : System.Object
{
	UnityEngine.Vector3Int nowPlayerPos; // 0x10
	System.Void .ctor(); // 0x065d2d20
	System.Int32 <OnFpsUnlimitedUpdate>b__0(WizardGames.Soc.Common.Entity.IRFDetonationEntity leftEntity, WizardGames.Soc.Common.Entity.IRFDetonationEntity rightEntity); // 0x065d3e34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattleTip : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiBattleTipData> waitBattleTipList; // 0x338
	FairyGUI.GList tipList; // 0x340
	System.Int32 scrollIndex; // 0x348
	static System.Int32 multiply; // 0x0
	System.Int64 timerId; // 0x350
	System.Void OnInit(); // 0x065d41a8
	System.Void RenderTipItem(System.Int32 index, FairyGUI.GObject obj); // 0x065d4364
	System.Void OnDestroy(); // 0x065d4570
	System.Void OnDisable(); // 0x065d4800
	System.Void Clear(); // 0x065d45e0
	System.Void ShowBattleTip(WizardGames.Soc.SocClient.Ui.UiBattleTipData data); // 0x05523a54
	System.Void Tick(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x065d4ef0
	static System.Void ShowTip(WizardGames.Soc.SocClient.Ui.UiBattleTipData data); // 0x065d50b0
	static System.Void ShowBattleTip(System.Int32 id, System.String[] args); // 0x065d5244
	System.Void .ctor(); // 0x065d5534
	static System.Void .cctor(); // 0x065d55c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattleTipData : System.Object
{
	System.String text; // 0x10
	UnityEngine.Color textColor; // 0x18
	System.Boolean <IsPlayedTransition>k__BackingField; // 0x28
	System.Boolean get_IsPlayedTransition(); // 0x065d5614
	System.Void set_IsPlayedTransition(System.Boolean value); // 0x065d5678
	System.Void .ctor(); // 0x065d56f4
	System.Void Init(System.Int32 id, System.String text, System.String textColor); // 0x065d5410
	System.Void Clear(); // 0x065d4870
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFrontSightTip : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	WizardGames.Soc.SocClient.Ui.UiFrontSightTipData uiFrontSightTipData; // 0x338
	FairyGUI.GComponent tipCom; // 0x340
	FairyGUI.GImage bgImg; // 0x348
	FairyGUI.GLoader icon; // 0x350
	FairyGUI.GRichTextField msgText; // 0x358
	FairyGUI.Transition appearTrans; // 0x360
	FairyGUI.Transition disappearTrans; // 0x368
	System.Boolean isCloseWin; // 0x370
	System.Void OnInit(); // 0x065d576c
	System.Void OnFps30Update(System.Single dt); // 0x065d5a84
	System.Void SetFrontSightTipData(System.Int32 id, System.Func<System.Boolean> disappearConditionFunc, System.Action<WizardGames.Soc.SocClient.Ui.UiFrontSightTipData> updateAction, System.String[] args); // 0x065d5c34
	static System.Void CloseFrontSightTip(); // 0x065d6098
	static System.Void ShowFrontSightTip(System.Int32 id, System.Func<System.Boolean> disappearConditionFunc, System.Action<WizardGames.Soc.SocClient.Ui.UiFrontSightTipData> updateAction, System.String[] args); // 0x065d630c
	System.Void HideAnim(); // 0x065d61cc
	System.Void .ctor(); // 0x065d6574
	System.Void <HideAnim>b__13_0(); // 0x065d6600
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFrontSightTipData : System.Object
{
	System.Int32 id; // 0x10
	System.String msgText; // 0x18
	System.Int32 totalTime; // 0x20
	System.Single remainingTime; // 0x24
	UnityEngine.Color bgColor; // 0x28
	UnityEngine.Color textColor; // 0x38
	UnityEngine.Color iconColor; // 0x48
	System.String iconUrl; // 0x58
	System.Boolean uiDisappear; // 0x60
	System.Func<System.Boolean> disappearConditionFunc; // 0x68
	System.Boolean get_Disappear(); // 0x065d666c
	System.Void .ctor(); // 0x065d59d0
	System.Void Init(System.Int32 id, System.String text, System.Int32 showTime, System.String bgColor, System.String textColor, System.String iconColor, System.String iconUrl); // 0x065d5f34
	System.Void Update(System.Single deltaTime, System.Action disappearAction); // 0x065d5b54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComShortTriggerTaskTip : System.Object
{
	FairyGUI.GTextField title; // 0x10
	FairyGUI.Transition appearTrans; // 0x18
	FairyGUI.Transition disappearTrans; // 0x20
	FairyGUI.GLoader icon; // 0x28
	FairyGUI.GLoader bg; // 0x30
	System.Action onDisappear; // 0x38
	System.Int64 timerId; // 0x40
	System.Void OnInit(FairyGUI.GComponent root); // 0x065d66f0
	System.Void OnPlayDisappearTrans(); // 0x065d6890
	System.Void ClearTimer(); // 0x065d694c
	System.Void AppearStartHook(); // 0x065d6a58
	System.Void DisappearStartHook(); // 0x065d6b44
	System.Void Clear(); // 0x065d6c30
	System.Void SetData(System.Int32 tipID, System.String tipText, System.Action onDisappear); // 0x065d6d74
	System.Void TimerCallback(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x065d71ec
	System.Void .ctor(); // 0x065d7288
	System.Void <OnPlayDisappearTrans>b__8_0(); // 0x065d72f8
	System.Void <SetData>b__13_0(); // 0x065d7370
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComStepGoalTip : System.Object
{
	FairyGUI.GTextField title; // 0x10
	FairyGUI.Transition appearTrans; // 0x18
	FairyGUI.Transition disappearTrans; // 0x20
	FairyGUI.GLoader icon; // 0x28
	FairyGUI.GLoader bg; // 0x30
	System.Int64 timerId; // 0x38
	System.Action onDisappear; // 0x40
	System.Void OnInit(FairyGUI.GComponent root); // 0x065d73d4
	System.Void ClearTimer(); // 0x065d7574
	System.Void OnPlayDisappearTrans(); // 0x065d7680
	System.Void Clear(); // 0x065d773c
	System.Void SetData(System.Int32 tipID, System.String tipText, System.Action onDisappear); // 0x065d7880
	System.Void TimerCallback(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x065d7c1c
	System.Void .ctor(); // 0x065d7cb8
	System.Void <OnPlayDisappearTrans>b__9_0(); // 0x065d7d28
	System.Void <SetData>b__11_0(); // 0x065d7da0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ShortTriggerTipData : System.Object
{
	System.Int32 <TipID>k__BackingField; // 0x10
	System.String <TipText>k__BackingField; // 0x18
	System.Int32 get_TipID(); // 0x065d7e04
	System.Void set_TipID(System.Int32 value); // 0x065d7e68
	System.String get_TipText(); // 0x065d7ee0
	System.Void set_TipText(System.String value); // 0x065d7f44
	System.Void Init(System.Int32 tipID, System.String tipText); // 0x065d7fc4
	System.Void .ctor(); // 0x065d80e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShortTriggerTip : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.ShortTriggerTipData> tipQueue; // 0x338
	WizardGames.Soc.SocClient.Ui.ComShortTriggerTaskTip comShortTriggerTaskTip; // 0x340
	WizardGames.Soc.SocClient.Ui.ComStepGoalTip comStepGoalTip; // 0x348
	FairyGUI.GLoader comLoader; // 0x350
	FairyGUI.Controller typeCtrl; // 0x358
	System.Void OnInit(); // 0x065d8150
	System.Void AddTipToQueue(System.Int32 tipID, System.String tipText); // 0x065d82b4
	System.Void ShowNextTip(); // 0x065d83c4
	System.Void OnDestroy(); // 0x065d88cc
	System.Void ShowTip(System.Int32 tipID, System.String tipText); // 0x065d8578
	static System.Void ShowShortTriggerTip(System.Int32 tipID, System.String[] param); // 0x065d8958
	System.Void .ctor(); // 0x065d8c1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComItemData : System.Object
{
	System.Int32 <TipId>k__BackingField; // 0x10
	System.Int64 <ItemId>k__BackingField; // 0x18
	System.Int32 <AddValue>k__BackingField; // 0x20
	System.Int32 <RemainValue>k__BackingField; // 0x24
	System.Boolean <IsAppearPlayedTransition>k__BackingField; // 0x28
	System.Boolean <IsPlayedSimilarTransition>k__BackingField; // 0x29
	System.Int32 get_TipId(); // 0x065d8cf4
	System.Void set_TipId(System.Int32 value); // 0x065d8d58
	System.Int64 get_ItemId(); // 0x065d8dd0
	System.Void set_ItemId(System.Int64 value); // 0x065d8e34
	System.Int32 get_AddValue(); // 0x065d8eac
	System.Void set_AddValue(System.Int32 value); // 0x065d8f10
	System.Int32 get_RemainValue(); // 0x065d8f88
	System.Void set_RemainValue(System.Int32 value); // 0x065d8fec
	System.Boolean get_IsAppearPlayedTransition(); // 0x065d9064
	System.Void set_IsAppearPlayedTransition(System.Boolean value); // 0x065d90c8
	System.Boolean get_IsPlayedSimilarTransition(); // 0x065d9144
	System.Void set_IsPlayedSimilarTransition(System.Boolean value); // 0x065d91a8
	System.Void Init(System.Int32 id, System.Int64 itemId, System.Int32 addValue, System.Int32 remainValue); // 0x065d9224
	System.Void .ctor(); // 0x065d93f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTip : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	SocLogger logger; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComItemData> waitItemTipList; // 0x340
	FairyGUI.GList tipList; // 0x348
	System.Int32 scrollIndex; // 0x350
	System.Int64 timerId; // 0x358
	System.Boolean isMergingTip; // 0x360
	System.Int32 currentScrollInterval; // 0x364
	System.Int32 currentDisappearTime; // 0x368
	System.Void OnInit(); // 0x065d9460
	System.Void RenderTipItem(System.Int32 index, FairyGUI.GObject obj); // 0x065d961c
	System.Void OnDisable(); // 0x065d9cd8
	System.Void OnDestroy(); // 0x065d9d58
	static System.Void ShowItemTip(System.Int32 id, System.Int64 itemId, System.Int32 addValue, System.Int32 remainValue); // 0x065d9fd0
	System.Boolean LastTipIsSameNewItemIdTip(System.Int32 id, System.Int64 itemId, System.Int32 addValue, System.Int32 remainValue); // 0x065da598
	System.Void SetItemTipData(System.Int32 id, System.Int64 itemId, System.Int32 addValue, System.Int32 remainValue); // 0x065da238
	System.Void UpdateScrollSpeed(System.Int32 disappearTime); // 0x055056e8
	System.Void Tick(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x065dab60
	System.Void Close(); // 0x065dacfc
	System.Void Clear(); // 0x065d9dc8
	static System.Void CloseItemTip(); // 0x065dad70
	System.Void .ctor(); // 0x065daea4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiNoItemTip : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GButton closeBtn; // 0x338
	FairyGUI.GButton confirmBtn; // 0x340
	WizardGames.Soc.SocClient.Ui.ComItemIcon comIcon; // 0x348
	FairyGUI.GTextField titleTxt; // 0x350
	FairyGUI.GTextField descTxt; // 0x358
	System.Action onCloseEvent; // 0x360
	FairyGUI.GComponent panelRoot; // 0x368
	System.Void OnInit(); // 0x065dafd4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x065db378
	System.Void .ctor(); // 0x065db408
	System.Void <OnInit>b__7_0(); // 0x065db494
	System.Void <OnInit>b__7_1(); // 0x065db51c
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.ICountDownPopTip : 
{
	
	System.Void OnEnable(); // 0x055049cc
	System.Void OnDisable(); // 0x055049cc
	System.Void Clear(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCountDownImpeache : System.Object, WizardGames.Soc.SocClient.Ui.ICountDownPopTip
{
	WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase parent; // 0x10
	FairyGUI.GButton btnApply; // 0x18
	FairyGUI.GProgressBar progress; // 0x20
	FairyGUI.GTextField text; // 0x28
	WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData data; // 0x30
	System.Single maxTime; // 0x38
	FairyGUI.GComponent root; // 0x40
	System.Int64 timerId; // 0x48
	System.Void ClearTimer(); // 0x065db5a4
	System.Void OnClickApply(); // 0x065db6ac
	System.Void OnInit(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase parent, WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData data); // 0x065db7b0
	System.Void OnImpeachStateChange(System.Int32 oldValue, System.Int32 newValue); // 0x065dbdec
	System.Void OnEnable(); // 0x065dbc68
	System.Void OnDisable(); // 0x065dbf5c
	System.Void Clear(); // 0x065dc094
	System.Void .ctor(); // 0x065dc0f8
	System.Void <OnEnable>b__12_0(); // 0x065dc160
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCountDownImpeache.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase parent; // 0x10
	System.Void .ctor(); // 0x065dbc00
	System.Void <OnInit>b__0(System.Int64 _, System.Object _, System.Boolean _); // 0x065dc1e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCountDownJumpTip : System.Object, WizardGames.Soc.SocClient.Ui.ICountDownPopTip
{
	WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase parent; // 0x10
	FairyGUI.GButton btnRefuse; // 0x18
	FairyGUI.GButton btnAccept; // 0x20
	FairyGUI.GProgressBar progress; // 0x28
	FairyGUI.GTextField text; // 0x30
	WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData data; // 0x38
	System.Single maxTime; // 0x40
	FairyGUI.GComponent root; // 0x48
	System.Int64 timerId; // 0x50
	System.Void ClearTimer(); // 0x065dc284
	System.Void OnClickAccept(); // 0x065dc38c
	System.Void OnClickRefuse(); // 0x065dc418
	System.Void OnInit(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase parent, WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData data); // 0x065dc4a4
	System.Void Clear(); // 0x065dcb48
	System.Void OnEnable(); // 0x065dc9f8
	System.Void OnDisable(); // 0x065dcbac
	System.Void .ctor(); // 0x065dcc58
	System.Void <OnEnable>b__14_0(); // 0x065dccc0
	System.Void <OnEnable>b__14_1(); // 0x065dcd48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCountDownJumpTip.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase parent; // 0x10
	System.Void .ctor(); // 0x065dc990
	System.Void <OnInit>b__0(System.Int64 _, System.Object _, System.Boolean _); // 0x065dcdd0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.VoteStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.VoteStatus None = 0;
	static WizardGames.Soc.SocClient.Ui.VoteStatus Agree = 1;
	static WizardGames.Soc.SocClient.Ui.VoteStatus Opposition = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCountDownVote : System.Object, WizardGames.Soc.SocClient.Ui.ICountDownPopTip
{
	WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase parent; // 0x10
	FairyGUI.GButton btnRefuse; // 0x18
	FairyGUI.GButton btnAccept; // 0x20
	FairyGUI.GProgressBar progress; // 0x28
	FairyGUI.GTextField text; // 0x30
	WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData data; // 0x38
	System.Single maxTime; // 0x40
	FairyGUI.GList list; // 0x48
	FairyGUI.GComponent root; // 0x50
	System.Int64 timerId; // 0x58
	System.Void ClearTimer(); // 0x065dce6c
	System.Void OnClickAccept(); // 0x065dcf74
	System.Void OnClickRefuse(); // 0x065dcff8
	System.Void OnInit(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase parent, WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData data); // 0x065dd07c
	System.Void Clear(); // 0x065dd800
	System.Void OnItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x065dd864
	System.Void OnVoteRolesChange(); // 0x065dd984
	System.Void OnEnable(); // 0x065dd6b0
	System.Void OnDisable(); // 0x065ddb2c
	System.Void .ctor(); // 0x065ddbd8
	System.Void <OnEnable>b__17_0(); // 0x065ddc40
	System.Void <OnEnable>b__17_1(); // 0x065ddcc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCountDownVote.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase parent; // 0x10
	System.Void .ctor(); // 0x065dd648
	System.Void <OnInit>b__0(System.Int64 _, System.Object _, System.Boolean _); // 0x065ddd50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFpsWarningPop : System.Object, WizardGames.Soc.SocClient.Ui.ICountDownPopTip
{
	FairyGUI.GTextField msgTitle; // 0x10
	FairyGUI.GRichTextField msgContent; // 0x18
	FairyGUI.GTextField msgTime; // 0x20
	FairyGUI.GButton closeBtn; // 0x28
	FairyGUI.GButton noBtn; // 0x30
	FairyGUI.GButton yesBtn; // 0x38
	FairyGUI.GProgressBar progress; // 0x40
	WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData data; // 0x48
	WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase uiMain; // 0x50
	System.Int64 timerId; // 0x58
	System.Single maxTime; // 0x60
	System.Void ClearTimer(); // 0x065dddec
	System.Void OnEnable(); // 0x065ddef4
	System.Void OnDisable(); // 0x065ddf54
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData data, FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase uiRoot); // 0x065ddfb8
	System.Void Clear(); // 0x065de754
	System.Void .ctor(); // 0x065de7b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFpsWarningPop.<>c__DisplayClass14_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiFpsWarningPop <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData data; // 0x18
	System.Void .ctor(); // 0x065de6ec
	System.Void <OnInit>b__0(System.Int64 _, System.Object _, System.Boolean _); // 0x065de820
	System.Void <OnInit>b__1(FairyGUI.EventContext ctx); // 0x065de8c4
	System.Void <OnInit>b__2(FairyGUI.EventContext ctx); // 0x065de958
	System.Void <OnInit>b__3(FairyGUI.EventContext ctx); // 0x065dea0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData data; // 0x10
	FairyGUI.GComponent tipCom; // 0x18
	FairyGUI.Controller typeCtrl; // 0x20
	FairyGUI.GLoader comLoader; // 0x28
	FairyGUI.Transition appearTrans; // 0x30
	FairyGUI.Transition disappearTrans; // 0x38
	System.Action btnClosecallback; // 0x40
	FairyGUI.GObject placeHolderNode; // 0x48
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ELeftInfoTipType,WizardGames.Soc.SocClient.Ui.ICountDownPopTip> countDownPopTips; // 0x50
	WizardGames.Soc.SocClient.Ui.ELeftInfoTipType currentType; // 0x58
	WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData get_Data(); // 0x065deac0
	System.Void .ctor(FairyGUI.GComponent root); // 0x065deb24
	System.Void OnEnable(); // 0x065ded3c
	System.Void OnDisable(); // 0x065df074
	System.Void Clear(); // 0x065df3a4
	System.Void OnVoteRolesChange(); // 0x065df5c4
	System.Void OnTeammateLoginNotice(System.UInt64 roleId); // 0x065df6ac
	System.Void HideTip(); // 0x065db738
	System.Void PlayAppearAnim(); // 0x065df7f8
	System.Void Refresh(WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData data, System.Action btnClosecallback); // 0x065df870
	System.Void ShowTip(); // 0x065dfed0
	System.Void HandleFpsWarningTip(); // 0x065dfff8
	System.Void HandleLeftInfoTip(); // 0x065e0650
	System.Void HandleJumpTip(); // 0x065e0878
	System.Void HandleImpeacheTip(); // 0x065e0a64
	System.Void HandleVoteTip(); // 0x065e0c50
	System.Void HandleTeamInviteTip(); // 0x065e020c
	System.Void HandleTrackMissionTip(); // 0x065e044c
	System.Void CopyPlaceHolderTransforms(FairyGUI.GObject node); // 0x065df94c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftInfoPopTip : System.Object, WizardGames.Soc.SocClient.Ui.ICountDownPopTip
{
	WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase parent; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameCommonLeftInfoTip.ComLeftInfoPopTipBinder binder; // 0x18
	System.Single cdTime; // 0x20
	System.Int64 timerId; // 0x28
	WizardGames.Soc.SocClient.Ui.MsgBoxInfo msgBoxInfo; // 0x30
	System.Boolean isBreak; // 0x38
	System.Boolean isClosedWindow; // 0x39
	System.Single displayTime; // 0x3c
	System.Void ClearTimer(); // 0x065e1024
	System.Void OnClickCancel(); // 0x065e112c
	System.Void OnInit(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase parent); // 0x065e11a4
	System.Void Clear(); // 0x065e1358
	System.Void SetInfo(WizardGames.Soc.SocClient.Ui.MsgBoxInfo info); // 0x065e13bc
	System.Void GotoDetailInfo(); // 0x065e1ea0
	System.Void OnEnable(); // 0x065e19e8
	System.Boolean isLongPress(); // 0x065e1f70
	System.Void OnDisable(); // 0x065e1ffc
	System.Void .ctor(); // 0x065e2148
	System.Void <OnEnable>b__14_0(System.Int64 _, System.Object _, System.Boolean _); // 0x065e21b8
	System.Void <OnEnable>b__14_1(); // 0x065e2274
	System.Void <OnEnable>b__14_2(); // 0x065e234c
	System.Void <OnEnable>b__14_3(); // 0x065e23cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftInfoPopTip.<>c__DisplayClass12_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> list; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLeftInfoPopTip <>4__this; // 0x18
	System.Void .ctor(); // 0x065e1980
	System.Void <SetInfo>b__0(); // 0x065e2468
	System.Void <SetInfo>b__1(); // 0x065e2528
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamInvitePop : System.Object, WizardGames.Soc.SocClient.Ui.ICountDownPopTip
{
	WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase parent; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameCommonLeftInfoTip.ComTeamInvitePopBinder binder; // 0x18
	WizardGames.Soc.SocClient.Ui.ComAvatarSquare headCom; // 0x20
	System.Collections.Generic.LinkedList<WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo> infos; // 0x28
	System.Int64 timerId; // 0x30
	WizardGames.Soc.SocClient.Ui.ComNameMedal comNameMedal; // 0x38
	System.Single get_cdTime(); // 0x065e25a0
	System.Void OnInit(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase parent); // 0x065e2688
	System.Void OnResetCom(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase parent); // 0x065e2710
	System.Void SetData(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo> newInfos); // 0x065e29b0
	System.Void RefreshInfo(); // 0x065e3144
	System.Void ShowNextInfo(); // 0x065e3dc0
	System.Void RefuseBtnClick(WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo inviteInfo); // 0x065e3fcc
	System.Void AcceptBtnClick(WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo inviteInfo); // 0x065e40dc
	System.Void ClearTimer(); // 0x065e303c
	System.Void Clear(); // 0x065e43f0
	System.Void RemoveOneInfo(System.String invitationID); // 0x065e4454
	System.Void RemoveAllInfo(); // 0x065e46a0
	System.Void OnEnable(); // 0x065e473c
	System.Void OnDisable(); // 0x065e48b0
	System.Void .ctor(); // 0x065e4b24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamInvitePop.<>c__DisplayClass11_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTeamInvitePop <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo info; // 0x18
	System.Void .ctor(); // 0x065e3d58
	System.Void <RefreshInfo>b__0(SimpleJSON.JSONNode jsonNode); // 0x065e4bd8
	System.Void <RefreshInfo>b__1(FairyGUI.EventContext _); // 0x065e4ea4
	System.Void <RefreshInfo>b__2(FairyGUI.EventContext _); // 0x065e4f28
	System.Void <RefreshInfo>b__3(); // 0x065e4fac
	System.Void <RefreshInfo>b__4(); // 0x065e507c
	System.Void <RefreshInfo>b__5(System.Int64 _, System.Object _, System.Boolean _); // 0x065e514c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamInvitePop.<>c__DisplayClass14_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo inviteInfo; // 0x10
	System.Void .ctor(); // 0x065e4388
	System.Void <AcceptBtnClick>b__0(); // 0x065e51e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTrackMissionPop : System.Object, WizardGames.Soc.SocClient.Ui.ICountDownPopTip
{
	WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase parent; // 0x10
	System.Int64 timerId; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameCommonLeftInfoTip.ComTrackMonumentMissionTipsBinder binder; // 0x20
	FairyGUI.GTextField descTxt; // 0x28
	System.Single get_cdTime(); // 0x065e52e4
	System.Void OnInit(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase parent); // 0x065e5348
	System.Void OnClickCancel(); // 0x065e5bb8
	System.Void Clear(); // 0x065e5c28
	System.Void OnClickConfirm(); // 0x065e5d94
	System.Void ClearTimer(); // 0x065e5c8c
	System.Void OnEnable(); // 0x065e56b0
	System.Void OnDisable(); // 0x065e5e54
	System.Void .ctor(); // 0x065e5f9c
	System.Void <OnEnable>b__11_0(System.Int64 _, System.Object _, System.Boolean _); // 0x065e6004
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftInfoBase : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData data; // 0x10
	FairyGUI.GComponent tipCom; // 0x18
	FairyGUI.GLoader icon; // 0x20
	FairyGUI.GTextField nameText; // 0x28
	FairyGUI.GTextField infoText; // 0x30
	FairyGUI.GTextField tagText; // 0x38
	FairyGUI.GProgressBar progressBar; // 0x40
	FairyGUI.GTextField progressNumTxt; // 0x48
	FairyGUI.GTextField pointNumTxt; // 0x50
	FairyGUI.Transition appearTrans; // 0x58
	FairyGUI.Transition disappearTrans; // 0x60
	FairyGUI.Transition medalUnlockTrans; // 0x68
	FairyGUI.GButton btnClose; // 0x70
	FairyGUI.GButton btnDetail; // 0x78
	System.Int64 timerId; // 0x80
	System.Int64 targetTime; // 0x88
	FairyGUI.Controller typeCtrl; // 0x90
	FairyGUI.Controller itemTypeCtrl; // 0x98
	FairyGUI.GLoader comLoader; // 0xa0
	WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData get_Data(); // 0x065e6098
	System.Void .ctor(FairyGUI.GComponent root); // 0x065e60fc
	System.Void OnComLoaderTouchBegin(FairyGUI.EventContext context); // 0x065e6360
	System.Void Refresh(WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData tipData, FairyGUI.GObject placeHolderNode, System.Action btnClosecallback); // 0x065e6434
	System.Void CancelTimer(); // 0x065e7a24
	System.Void Show(); // 0x055049cc
	UnityEngine.Vector2 GetIconScreenPos(); // 0x065e7c00
	System.Void Hide(); // 0x065e7d48
	System.Void <Show>b__26_2(); // 0x065e80ec
	System.Void <Show>b__26_0(System.Int64 timeId, System.Object callbackData, System.Boolean needDelete); // 0x065e8170
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftInfoBase.<>c__DisplayClass24_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLeftInfoBase <>4__this; // 0x10
	System.Action btnClosecallback; // 0x18
	System.Void .ctor(); // 0x065e7070
	System.Void <Refresh>b__0(); // 0x065e8294
	System.Void <Refresh>b__1(); // 0x065e8320
	System.Void <Refresh>b__2(); // 0x065e83ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftInfoBase.<>c__DisplayClass26_0 : System.Object
{
	FairyGUI.Transition flashTrans; // 0x10
	System.Void .ctor(); // 0x065e7b30
	System.Void <Show>b__1(); // 0x065e8424
	System.Void <Show>b__3(); // 0x065e849c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftInfoBase.<>c__DisplayClass26_1 : System.Object
{
	FairyGUI.Transition flashTrans; // 0x10
	System.Void .ctor(); // 0x065e7b98
	System.Void <Show>b__4(); // 0x065e8514
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftInfoTip : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.UiLeftInfoBase uiLeftInfoTip; // 0x338
	WizardGames.Soc.SocClient.Ui.UiLeftInfoCountDownBase uiLeftInfoCountDown; // 0x340
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData> waitingLeftInfoTipsQueue; // 0x348
	WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData curLeftInfo; // 0x350
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.ELeftInfoTipType> eLeftInfoTipTypes; // 0x358
	System.Void OnInit(); // 0x065e858c
	System.Void OnDestroy(); // 0x065e87f4
	System.Void OnEnable(); // 0x065e8974
	System.Void OnDisable(); // 0x065e8a90
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x065e8ba0
	static System.Void CloseTipWin(); // 0x065e8d68
	System.Void Clear(); // 0x065e8900
	System.Void OnCheckUiNeedClose(); // 0x065e8c18
	System.Void RefreshLeftInfoTip(WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData tipData); // 0x065e902c
	System.Void ShowLeftInfoTip(WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData tipData); // 0x065e91dc
	static System.Void ShowTip(WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData tipData); // 0x065e9480
	System.Void AddTip(WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData data); // 0x065e933c
	System.Void ClearData(); // 0x065e8e6c
	System.Void InsertInSortedOrder(WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData data); // 0x065e9674
	System.Void .ctor(); // 0x065e97a4
	System.Boolean <OnEnable>b__8_0(); // 0x065e98e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftInfoTipData : System.Object
{
	System.String iconUrl; // 0x10
	System.String newIconUrl; // 0x18
	System.String nameText; // 0x20
	System.String infoText; // 0x28
	System.String typeText; // 0x30
	System.Int32 totalTime; // 0x38
	System.Single remainingTime; // 0x3c
	System.Int32 curNum; // 0x40
	System.Int32 maxNum; // 0x44
	System.Int32 pointNum; // 0x48
	WizardGames.Soc.SocClient.Ui.ELeftInfoTipType tipType; // 0x4c
	System.Action detailCallback; // 0x50
	System.Action<UnityEngine.Vector2> closeCallbackByTaskTip; // 0x58
	System.Action RefuseCallback; // 0x60
	System.Action AgreeCallback; // 0x68
	WizardGames.Soc.SocClient.Ui.MsgBoxInfo info; // 0x70
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo> newInfos; // 0x78
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.VoteStatus> VoteDataList; // 0x80
	System.Boolean showDetailBtn; // 0x88
	System.String detailBtnText; // 0x90
	System.Int32 priority; // 0x98
	System.Void .ctor(); // 0x065e99b0
	System.Void Init(WizardGames.Soc.SocClient.Ui.ELeftInfoTipType type, System.String iconUrl, System.String nameText, System.String infoText, System.String typeText, System.Int32 showTime, System.Action detailCallback, System.Int32 curNum, System.Int32 maxNum, System.Int32 point, System.String newIconUrl, System.Action<UnityEngine.Vector2> closeCallbackByTaskTip, System.Boolean showDetailBtn, System.String detailBtnText, System.Int32 priority, System.Action RefuseCallback, System.Action AgreeCallback, WizardGames.Soc.SocClient.Ui.MsgBoxInfo info, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo> newInfos, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.VoteStatus> VoteDataList); // 0x065e9b90
	System.Void Clear(); // 0x065e7f38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiNpcTextTip : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GTextField msgText; // 0x338
	FairyGUI.Transition appearTrans; // 0x340
	FairyGUI.Transition disappearTrans; // 0x348
	System.Void OnInit(); // 0x065e9ea0
	System.Void OnDestroy(); // 0x065ea030
	static System.Void ShowTip(System.String npcText); // 0x065ea098
	System.Void ShowNpcTextTip(System.String npcText); // 0x065ea220
	static System.Void CloseTip(); // 0x065ea314
	System.Void CloseRealtimeNpcTextTipForGuide(); // 0x065ea448
	System.Void .ctor(); // 0x065ea56c
	System.Void <CloseRealtimeNpcTextTipForGuide>b__8_0(); // 0x065ea5f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComOngoingTip : System.Object
{
	FairyGUI.GLoader bg; // 0x10
	FairyGUI.GImage bgFrame; // 0x18
	FairyGUI.GLoader icon; // 0x20
	FairyGUI.GTextField titleText; // 0x28
	FairyGUI.GRichTextField mainContent; // 0x30
	FairyGUI.GRichTextField subContent; // 0x38
	FairyGUI.GTextField timeText; // 0x40
	FairyGUI.Transition appearTrans; // 0x48
	FairyGUI.Controller statusCtrl; // 0x50
	FairyGUI.GComponent root; // 0x58
	System.Int64 disappearTimerId; // 0x60
	System.Int64 countDownTimer; // 0x68
	System.Int64 targetTime; // 0x70
	WizardGames.Soc.SocClient.Ui.OngoingTipData ongoingTipData; // 0x78
	System.Void .ctor(FairyGUI.GComponent root); // 0x065ea664
	System.Boolean IsVisible(); // 0x065ea9bc
	System.Void CancelDisappearTimer(); // 0x065eaa60
	System.Void CancelCountDownTimer(); // 0x065eab6c
	System.Void Clear(); // 0x065eac78
	System.Void SetData(WizardGames.Soc.SocClient.Ui.OngoingTipData tipData); // 0x065ead54
	System.Void RefreshDisappearTime(System.Int32 configTime); // 0x055056e8
	System.Void DisappearTimerCallback(System.Int64 timeId, System.Object callbackData, System.Boolean needDelete); // 0x065eba78
	System.Void CountDownTimerCallback(System.Int64 timeId, System.Object callbackData, System.Boolean needDelete); // 0x065ebbf4
	System.Void SetStatusCtrl(); // 0x055049cc
	System.Void SetSubContent(System.String configSubContent, System.Boolean isNoFormat); // 0x065eb4c0
	System.String FormatWithParams(System.String format, System.String[] args); // 0x065ebf48
	System.Void SetMainContent(System.String configMainContent, System.Boolean isNoFormat); // 0x065eb3e8
	System.Void SetTitle(System.String configTitle, System.Boolean isNoFormat); // 0x065eb310
	System.String FormatTime(System.Int64 time); // 0x065ebd38
	System.Void <.ctor>b__15_0(); // 0x065ebff0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.OngoingTipOptionsData : System.Object
{
	System.Int32 <TipId>k__BackingField; // 0x10
	System.Func<System.Boolean> <DisappearConditionFunc>k__BackingField; // 0x18
	System.Action<WizardGames.Soc.SocClient.Ui.ComOngoingTip> <UpdateAction>k__BackingField; // 0x20
	System.Int64 <DisappearTime>k__BackingField; // 0x28
	System.Int64 <CountdownTime>k__BackingField; // 0x30
	System.String[] <TitleParams>k__BackingField; // 0x38
	System.String[] <MainContentParams>k__BackingField; // 0x40
	System.String[] <SubContentParams>k__BackingField; // 0x48
	System.Boolean <IsResident>k__BackingField; // 0x50
	System.Int32 get_TipId(); // 0x065ec060
	System.Void set_TipId(System.Int32 value); // 0x065ec0c4
	System.Func<System.Boolean> get_DisappearConditionFunc(); // 0x065ec13c
	System.Void set_DisappearConditionFunc(System.Func<System.Boolean> value); // 0x065ec1a0
	System.Action<WizardGames.Soc.SocClient.Ui.ComOngoingTip> get_UpdateAction(); // 0x065ec220
	System.Void set_UpdateAction(System.Action<WizardGames.Soc.SocClient.Ui.ComOngoingTip> value); // 0x065ec284
	System.Int64 get_DisappearTime(); // 0x065ec304
	System.Void set_DisappearTime(System.Int64 value); // 0x065ec368
	System.Int64 get_CountdownTime(); // 0x065ec3e0
	System.Void set_CountdownTime(System.Int64 value); // 0x065ec444
	System.String[] get_TitleParams(); // 0x065ec4bc
	System.String[] get_MainContentParams(); // 0x065ec520
	System.Void set_MainContentParams(System.String[] value); // 0x065ec584
	System.String[] get_SubContentParams(); // 0x065ec604
	System.Void set_SubContentParams(System.String[] value); // 0x065ec668
	System.Boolean get_IsResident(); // 0x065ec6e8
	System.Void set_IsResident(System.Boolean value); // 0x065ec74c
	System.Void .ctor(); // 0x065ec7c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.OngoingTipData : System.Object
{
	System.Int32 tipId; // 0x10
	System.Int32 type; // 0x14
	System.Func<System.Boolean> disappearConditionFunc; // 0x18
	System.Action<WizardGames.Soc.SocClient.Ui.ComOngoingTip> updateAction; // 0x20
	System.Int64 disappearTime; // 0x28
	System.Int64 countdownTime; // 0x30
	System.String[] titleParams; // 0x38
	System.String[] mainContentParams; // 0x40
	System.String[] subContentParams; // 0x48
	System.Boolean isResident; // 0x50
	System.String replacedContent; // 0x58
	WizardGames.Soc.Common.Data.ActionName hotKeyGuide; // 0x60
	System.Int32 guideStepId; // 0x64
	System.Int64 missionId; // 0x68
	System.Boolean closeWhenGuideFinish; // 0x70
	System.Void Init(System.Int32 tipId, System.Int32 type, System.Func<System.Boolean> disappearConditionFunc, System.Action<WizardGames.Soc.SocClient.Ui.ComOngoingTip> updateAction, System.Int64 disappearTime, System.Int64 countdownTime, System.String[] titleParams, System.String[] mainContentParams, System.String[] subContentParams, System.Boolean isResident, System.String replacedContent, WizardGames.Soc.Common.Data.ActionName hotKey, System.Int32 guideStepId, System.Int64 missionId, System.Boolean closeWhenGuideFinish); // 0x065ec970
	System.Void .ctor(); // 0x065ecb30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOngoingTip : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.ComOngoingTip comMaxproority; // 0x338
	WizardGames.Soc.SocClient.Ui.ComOngoingTip comNormal; // 0x340
	FairyGUI.GLoader imageGuide; // 0x348
	WizardGames.Soc.Common.Data.ActionName hotKeyGuide; // 0x350
	WizardGames.Soc.SocClient.Ui.OngoingTipData tipData; // 0x358
	System.Void OnEnable(); // 0x065ecb98
	System.Void OnDisable(); // 0x065ecd18
	System.Void OnHotKeyPressed(WizardGames.Soc.Common.Data.ActionName hotKey); // 0x065ed054
	System.Void UpdateSingleMission(); // 0x065ed1a8
	System.Void OnInit(); // 0x065ed2f4
	System.Void OnCheckUiNeedClose(); // 0x065ed5bc
	System.Void OnDestroy(); // 0x065ed78c
	static System.Void CloseUiOngoingTipById(System.Int64 tipId); // 0x065ed7f4
	static System.Void CloseUiOngoingTip(); // 0x065ed944
	static System.Void CloseUiOngoingTipWithType(System.Int32 type); // 0x065eda78
	System.Void Close(); // 0x065ed0ec
	System.Void ShowOngoingTipByData(WizardGames.Soc.SocClient.Ui.OngoingTipData tipData); // 0x065edc78
	static System.Void ShowOngoingTip(WizardGames.Soc.SocClient.Ui.OngoingTipData tipData); // 0x065ee020
	System.Void .ctor(); // 0x065ee2ac
	static System.Void .cctor(); // 0x065ee338
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ELevelInfosCtrl : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ELevelInfosCtrl LevelUpTip = 0;
	static WizardGames.Soc.SocClient.Ui.ELevelInfosCtrl SurvivalRating = 1;
	static WizardGames.Soc.SocClient.Ui.ELevelInfosCtrl TechLevelUp = 2;
	static WizardGames.Soc.SocClient.Ui.ELevelInfosCtrl TerritoryUpgrade = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonLevelUpTip : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	System.Single curTime; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiCommonLevelUpTip.LevelInfo> levelInfoList; // 0x340
	FairyGUI.Controller statusCtrl; // 0x348
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.UiCommonLevelUpTipBinder binderRoot; // 0x350
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComCommonLevelUpTipBinder binder; // 0x358
	static System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.UiCommonLevelUpTip.LevelInfo> pendingQueue; // 0x0
	System.Void OnInit(); // 0x065ee40c
	System.Void OnEnable(); // 0x065ee774
	System.Void Show(WizardGames.Soc.SocClient.Ui.ELevelInfosCtrl ctrlType, System.String desc, System.String level, System.Single showTime, System.Boolean brake, System.Action detailCallback, System.Action closeCallback); // 0x065ee87c
	static System.Void ShowTip(WizardGames.Soc.SocClient.Ui.ELevelInfosCtrl ctrlType, System.String desc, System.String level, System.Single showTime, System.Boolean brake, System.Action detailCallback, System.Action closeCallback); // 0x065eeae8
	static System.Void ShowTip(System.Int32 tipId, System.Action detailCallback, System.Action closeCallback); // 0x065eee60
	System.Void CheckType(WizardGames.Soc.SocClient.Ui.ELevelInfosCtrl ctrlType, System.Action detailCallback); // 0x065eefec
	System.Void OnDisable(); // 0x065efac8
	System.Void OnDestroy(); // 0x065efe24
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x065efe8c
	System.Void ApplyLevelInfo(WizardGames.Soc.SocClient.Ui.UiCommonLevelUpTip.LevelInfo info); // 0x065f0090
	System.Void .ctor(); // 0x065f0718
	static System.Void .cctor(); // 0x065f07a4
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiCommonLevelUpTip.LevelInfo : System.ValueType
{
	WizardGames.Soc.SocClient.Ui.ELevelInfosCtrl ctrl; // 0x10
	System.String level; // 0x18
	System.String desc; // 0x20
	System.Single showTime; // 0x28
	System.Action detailCallback; // 0x30
	System.Action closeCallback; // 0x38
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonLevelUpTip.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiCommonLevelUpTip.<>c <>9; // 0x0
	static System.Predicate<WizardGames.Soc.SocClient.Ui.UiCommonLevelUpTip.LevelInfo> <>9__13_4; // 0x8
	static System.Predicate<WizardGames.Soc.SocClient.Ui.UiCommonLevelUpTip.LevelInfo> <>9__13_5; // 0x10
	static System.Void .cctor(); // 0x065f083c
	System.Void .ctor(); // 0x065f08a0
	System.Boolean <CheckType>b__13_4(WizardGames.Soc.SocClient.Ui.UiCommonLevelUpTip.LevelInfo info); // 0x065f0908
	System.Boolean <CheckType>b__13_5(WizardGames.Soc.SocClient.Ui.UiCommonLevelUpTip.LevelInfo info); // 0x065f099c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonLevelUpTip.<>c__DisplayClass13_0 : System.Object
{
	System.Action detailCallback; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCommonLevelUpTip <>4__this; // 0x18
	System.Void .ctor(); // 0x065efa60
	System.Void <CheckType>b__0(); // 0x065f0a30
	System.Void <CheckType>b__1(); // 0x065f0aa8
	System.Void <CheckType>b__2(); // 0x065f0b20
	System.Void <CheckType>b__3(); // 0x065f0c7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRealtimeNormalTip : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiRealtimeTipData> waitRealtimeTipList; // 0x338
	FairyGUI.GList tipList; // 0x340
	FairyGUI.GComponent uiRoot; // 0x348
	System.Single rootOriginY; // 0x350
	System.Int32 maxTipNum; // 0x354
	System.Boolean isCloseTipWin; // 0x358
	System.Void OnInit(); // 0x065f0dd8
	System.Void RenderTipItem(System.Int32 index, FairyGUI.GObject obj); // 0x065f106c
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x065f13ac
	System.Void OnDestroy(); // 0x065f1ad0
	System.Void Clear(); // 0x065f15ac
	System.Void ShowRealtimeNormalTip(WizardGames.Soc.SocClient.Ui.UiRealtimeTipData data); // 0x065f1b40
	System.Void RefreshTipOffset(); // 0x065f1848
	static System.Void ShowTip(WizardGames.Soc.SocClient.Ui.UiRealtimeTipData data); // 0x065f1dac
	static System.Void ShowRealtimeWeakTwoIconTip(System.Int32 id, System.Int64 itemId1, System.Int64 itemId2, System.String[] args); // 0x065f1f40
	static System.Void ShowRealtimeWeakIconTip(System.Int32 id, System.Int64 itemId1, System.String[] args); // 0x065f249c
	static System.Void ShowRealtimeWeakTip(System.Int32 id, System.String[] args); // 0x065f27ec
	static System.Void ShowRealtimeWeakTip(System.String tipText, System.Single showtime); // 0x065f2a20
	static System.Void ShowRealtimeWeakTipWithIcon(System.String tipText, System.String url, System.Single showtime); // 0x065f2c24
	static System.Void ShowRealtimeWeakTip(System.String tipText, Systems.ServerTipData data); // 0x065f2e2c
	static System.Void HideTipsImmediately(); // 0x065f2f40
	System.Void .ctor(); // 0x065f3094
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRealtimeTipData : System.Object
{
	System.Single QuickDisappearTime; // 0x10
	System.Int32 id; // 0x14
	System.String text; // 0x18
	System.String iconUrl; // 0x20
	System.String bgColor; // 0x28
	System.String textColor; // 0x30
	System.String iconColor; // 0x38
	System.Single totalTime; // 0x40
	System.Single remainingTime; // 0x44
	System.Boolean uiDisappear; // 0x48
	System.Func<System.Boolean> disappearConditionFunc; // 0x50
	System.Action<WizardGames.Soc.SocClient.Ui.UiRealtimeTipData> updateAction; // 0x58
	System.Boolean <IsPlayedTransition>k__BackingField; // 0x60
	System.Boolean get_IsPlayedTransition(); // 0x065f3120
	System.Void set_IsPlayedTransition(System.Boolean value); // 0x065f3184
	System.Void .ctor(); // 0x065f3200
	System.Void Init(System.Int32 id, System.String text, System.Single remainingTime, System.String bgColor, System.String textColor, System.String iconColor, System.String iconUrl); // 0x065f2378
	System.Void Clear(); // 0x065f1748
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRewardTip : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	FairyGUI.Transition appearTrans; // 0x338
	static SocLogger <logger>k__BackingField; // 0x0
	FairyGUI.Transition disappearTrans; // 0x340
	System.Boolean showingTips; // 0x348
	FairyGUI.GList rewardLst; // 0x350
	System.Single totalTime; // 0x358
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Reward> data; // 0x360
	static SocLogger get_logger(); // 0x065f3290
	System.Void OnInit(); // 0x065f3318
	System.Void OnDestroy(); // 0x065f356c
	System.Void OnFps30Update(System.Single dt); // 0x065f35d4
	System.Void CloseTipWin(); // 0x065f3684
	static System.Void ShowTip(System.Collections.Generic.List<WizardGames.Soc.Common.Data.Reward> rewardsData); // 0x065f37a8
	System.Void ShowRewardTip(System.Collections.Generic.List<WizardGames.Soc.Common.Data.Reward> rewardsData); // 0x065f3954
	System.Void OnRenderReward(System.Int32 index, FairyGUI.GObject obj); // 0x065f3cb4
	System.Void .ctor(); // 0x065f3f38
	static System.Void .cctor(); // 0x065f4060
	System.Void <CloseTipWin>b__12_0(); // 0x065f40f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSurvivalTips : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	
	System.Void .ctor(); // 0x065f4164
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTaskTips : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GLoader taskIcon; // 0x338
	System.Int64 taskId; // 0x340
	System.Int64 timerId; // 0x348
	System.Int32 disappearTime; // 0x350
	System.Action<UnityEngine.Vector2> CloseAction; // 0x358
	FairyGUI.GTextField descText; // 0x360
	FairyGUI.Transition showAnim; // 0x368
	System.Boolean displayGuideInfo; // 0x370
	System.Void OnInit(); // 0x065f41f0
	System.Void OnDestroy(); // 0x065f440c
	System.Void ClearTimer(); // 0x065f447c
	static System.Void ShowTips(System.Int64 taskId); // 0x065f4580
	static System.Void ShowGuideTips(System.Boolean enable, System.String content); // 0x065f4b74
	static System.Void ShowSpecialTips(System.Boolean isDeadSheep); // 0x065f4e10
	System.Void SetTaskId(System.Int64 taskId, System.Boolean forcePlay); // 0x065f4720
	System.Void SetSpecialTaskInfo(System.Boolean isDeadSheep); // 0x065f4fa0
	System.Void SetGuideContent(System.Boolean enable, System.String content); // 0x065f4d30
	static System.Void ShowCommonTips(System.String desc, System.Action<UnityEngine.Vector2> closeAction); // 0x065f5960
	System.Void SetCommonInfo(System.String desc); // 0x065f5b24
	UnityEngine.Vector2 GetIconScreenPos(); // 0x065f527c
	System.Void SetIconAnimationEndPosition(); // 0x065f53c4
	System.Void CloseTips(); // 0x065f58e4
	System.Void .ctor(); // 0x065f5d84
	System.Void <SetSpecialTaskInfo>b__15_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x065f5e20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTaskTips.<>c__DisplayClass14_0 : System.Object
{
	System.Int64 taskId; // 0x10
	UnityEngine.Vector2 flyPos; // 0x18
	WizardGames.Soc.SocClient.Ui.UiTaskTips <>4__this; // 0x20
	System.Void .ctor(); // 0x065f5214
	System.Void <SetTaskId>b__0(System.Int64 id, System.Object data, System.Boolean delete); // 0x065f5eb4
	System.Void <SetTaskId>b__1(System.Int64 id, System.Object data, System.Boolean delete); // 0x065f5fc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTaskTips.<>c__DisplayClass18_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTaskTips <>4__this; // 0x10
	UnityEngine.Vector2 flyPos; // 0x18
	System.Void .ctor(); // 0x065f5d1c
	System.Void <SetCommonInfo>b__0(System.Int64 id, System.Object data, System.Boolean delete); // 0x065f6064
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTaskTipPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.GameTaskTipPop.UiTaskTipPopBinder binder; // 0x338
	System.Int32 disappearTime; // 0x340
	System.Int64 timerId; // 0x348
	System.Boolean isBreak; // 0x350
	WizardGames.Soc.SocClient.Ui.UiTaskTipPop.ShowParams curTipsInfo; // 0x358
	static System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.UiTaskTipPop.ShowParams> tipsQueue; // 0x0
	System.Void OnInit(); // 0x065f6124
	System.Void OnEnable(); // 0x065f69a0
	System.Void OnDisable(); // 0x065f7078
	System.Void OnDestroy(); // 0x065f7460
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x065f75bc
	static System.Void ShowTips(WizardGames.Soc.SocClient.Ui.UiTaskTipPop.ShowParams tipsInfo); // 0x065f7730
	static System.Void TryShow(); // 0x065f7c14
	System.Void Setup(WizardGames.Soc.SocClient.Ui.UiTaskTipPop.ShowParams tipsInfo); // 0x065f7a2c
	System.Boolean isLongPress(); // 0x065f8784
	System.Void OnShow(WizardGames.Soc.SocClient.Ui.UiTaskTipPop.ShowParams tipsInfo); // 0x065f7ce8
	System.Void OnClickView(); // 0x065f8810
	System.Void OnClickCancel(); // 0x065f897c
	static System.Void OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiTaskTipPop> callBack); // 0x065f7b14
	static System.Void CloseWindow(); // 0x065f7654
	System.Void .ctor(); // 0x065f8b0c
	static System.Void .cctor(); // 0x065f8c2c
	System.Void <OnEnable>b__7_1(); // 0x065f8cc4
	System.Void <OnEnable>b__7_2(); // 0x065f9010
	System.Void <OnEnable>b__7_3(); // 0x065f92d4
	System.Void <OnShow>b__15_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x065f9598
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTaskTipPop.ShowParams : System.Object
{
	WizardGames.Soc.Common.Data.MainTaskType missionType; // 0x10
	System.Boolean isMonument; // 0x14
	System.Int64 missionId; // 0x18
	System.Void .ctor(System.Int64 id); // 0x065f96c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTaskTipPop.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTaskTipPop.<>c <>9; // 0x0
	static System.Func<System.Boolean> <>9__7_0; // 0x8
	static System.Void .cctor(); // 0x065f9754
	System.Void .ctor(); // 0x065f97b8
	System.Boolean <OnEnable>b__7_0(); // 0x065f9820
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTaskTipPop.<>c__DisplayClass11_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTaskTipPop.ShowParams tipsInfo; // 0x10
	System.Void .ctor(); // 0x065f79c4
	System.Void <ShowTips>b__0(WizardGames.Soc.SocClient.Ui.UiTaskTipPop win); // 0x065f98ac
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ELeftInfoTipType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ELeftInfoTipType ManualAndTask = 0;
	static WizardGames.Soc.SocClient.Ui.ELeftInfoTipType ItemIntroduce = 1;
	static WizardGames.Soc.SocClient.Ui.ELeftInfoTipType Buff = 2;
	static WizardGames.Soc.SocClient.Ui.ELeftInfoTipType RankMedal = 3;
	static WizardGames.Soc.SocClient.Ui.ELeftInfoTipType RankBadge = 4;
	static WizardGames.Soc.SocClient.Ui.ELeftInfoTipType FpsWarning = 5;
	static WizardGames.Soc.SocClient.Ui.ELeftInfoTipType TeamInvite = 6;
	static WizardGames.Soc.SocClient.Ui.ELeftInfoTipType TrackMission = 7;
	static WizardGames.Soc.SocClient.Ui.ELeftInfoTipType MissionComplete = 8;
	static WizardGames.Soc.SocClient.Ui.ELeftInfoTipType LeftInfo = 9;
	static WizardGames.Soc.SocClient.Ui.ELeftInfoTipType Impeache = 10;
	static WizardGames.Soc.SocClient.Ui.ELeftInfoTipType Vote = 11;
	static WizardGames.Soc.SocClient.Ui.ELeftInfoTipType Jump = 12;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTipsData : System.Object
{
	static SocLogger <logger>k__BackingField; // 0x0
	System.Int32 maxShowingTip; // 0x10
	System.Int32 maxNormalShowingTip; // 0x14
	System.Int32 maxItemShowingTip; // 0x18
	System.Single leastWeakTipPlayTime; // 0x1c
	System.Single leastStrongTipPlayTime; // 0x20
	static SocLogger get_logger(); // 0x065f993c
	static UnityEngine.Color HexToColor(System.String hex); // 0x065eb1dc
	System.Void .ctor(); // 0x065f99c4
	static System.Void .cctor(); // 0x065f9a4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnlockTip : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyUnlockSystem.UiCommonUnlockSystemBinder binder; // 0x338
	System.Collections.Generic.Queue<System.Int32> queue; // 0x340
	System.Void OnInit(); // 0x065f9b20
	System.Void InitUIComponent(); // 0x065f9b90
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x065f9e14
	static System.Void Open(System.Int32 id); // 0x065fa2d8
	System.Void AddShow(System.Int32 id); // 0x065fa4f0
	System.Void Refresh(System.Int32 id); // 0x065f9f34
	System.Void .ctor(); // 0x065fa58c
	System.Void <InitUIComponent>b__2_0(FairyGUI.EventContext context); // 0x065fa664
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnlockTip.<>c__DisplayClass4_0 : System.Object
{
	System.Int32 id; // 0x10
	System.Void .ctor(); // 0x065fa488
	System.Void <Open>b__0(WizardGames.Soc.SocClient.Ui.UiUnlockTip tip); // 0x065fa6e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCurrencyExchange : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.UiCurrencyExchangeBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.UiInputNum uiInputNum; // 0x340
	WizardGames.Soc.SocClient.Ui.ComItemIcon itemSpend; // 0x348
	WizardGames.Soc.SocClient.Ui.ComItemIcon itemGet; // 0x350
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x358
	WizardGames.Soc.Common.Data.common.BTuple2 currentFrom; // 0x360
	System.Int32 currentTo; // 0x368
	WizardGames.Soc.Common.Data.resource.OBJGenaral itemSpendCfg; // 0x370
	WizardGames.Soc.Common.Data.resource.OBJGenaral itemGetCfg; // 0x378
	System.Action completeCallback; // 0x380
	System.Void OnInit(); // 0x065fa764
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x065facec
	System.Void ConfirmExchange(); // 0x065fad70
	System.Void OnEnable(); // 0x065fb388
	System.Void OnDisable(); // 0x065fb3f0
	System.Void SetNum(System.Int32 changeNum, WizardGames.Soc.Common.Data.common.BTuple2 from, System.Int32 to); // 0x065fb458
	static System.Boolean Open(System.Int32 currencyId, System.Int32 changeNum, System.Action complete); // 0x065fbc18
	System.Void .ctor(); // 0x065fbf00
	System.Void <OnInit>b__10_0(); // 0x065fbfc4
	System.Void <ConfirmExchange>b__12_0(SimpleJSON.JSONNode result); // 0x065fc030
	System.Void <ConfirmExchange>b__12_2(SimpleJSON.JSONNode res); // 0x065fc2f8
	System.Void <ConfirmExchange>b__12_1(SimpleJSON.JSONNode error); // 0x065fc390
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCurrencyExchange.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCurrencyExchange <>4__this; // 0x10
	WizardGames.Soc.Common.Data.common.BTuple2 from; // 0x18
	System.Action <>9__1; // 0x20
	System.Void .ctor(); // 0x065fbbb0
	System.Void <SetNum>b__0(System.Int32 num); // 0x065fc514
	System.Void <SetNum>b__1(); // 0x065fc8c8
	System.Void <SetNum>b__2(); // 0x065fc934
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInsufficientTips : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.UiInsufficientTipsBinder binder; // 0x338
	System.Int32 chargeNum; // 0x340
	FairyGUI.GButton btnComplete; // 0x348
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x350
	System.Action completeCallback; // 0x358
	System.Void OnInit(); // 0x065fc9a0
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x065fcd24
	System.Void OnEnable(); // 0x065fcda8
	System.Void OnDisable(); // 0x065fce10
	System.Void PurchaseImmediately(); // 0x065fce78
	System.Int32 GetChargeNum(System.Int32 insufficientNum); // 0x065fd184
	System.Void SetInsufficientNum(System.Int32 insufficientNum); // 0x065fd4cc
	static System.Void Open(System.Int32 insufficientNum, System.Action complete); // 0x065fb27c
	System.Void .ctor(); // 0x065fdf34
	System.Void <OnInit>b__5_0(); // 0x065fdfc0
	System.Void <OnInit>b__5_1(); // 0x065fe02c
	System.Void <SetInsufficientNum>b__11_0(); // 0x065fe1a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInsufficientTips.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiInsufficientTips.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.Common.Data.mall.OBJRecharge,System.Single> <>9__10_1; // 0x8
	static System.Action <>9__11_1; // 0x10
	static System.Void .cctor(); // 0x065fe24c
	System.Void .ctor(); // 0x065fe2b0
	System.Single <GetChargeNum>b__10_1(WizardGames.Soc.Common.Data.mall.OBJRecharge x); // 0x065fe318
	System.Void <SetInsufficientNum>b__11_1(); // 0x065fe398
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInsufficientTips.<>c__DisplayClass10_0 : System.Object
{
	System.Int32 insufficientNum; // 0x10
	System.Void .ctor(); // 0x065fd464
	System.Boolean <GetChargeNum>b__0(WizardGames.Soc.Common.Data.mall.OBJRecharge x); // 0x065fe45c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInsufficientTips.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiInsufficientTips <>4__this; // 0x10
	WizardGames.Soc.Common.Data.mall.OBJRecharge chargeItem; // 0x18
	System.Action<SimpleJSON.JSONNode> <>9__4; // 0x20
	System.Action<WizardGames.Soc.SDK.MidasWrapper.EPayResult,System.String> <>9__3; // 0x28
	System.Void .ctor(); // 0x065fd11c
	System.Boolean <PurchaseImmediately>b__0(WizardGames.Soc.Common.Data.mall.OBJRecharge x); // 0x065fe4ec
	System.Void <PurchaseImmediately>b__1(System.String urlParams); // 0x065fe584
	System.Void <PurchaseImmediately>b__3(WizardGames.Soc.SDK.MidasWrapper.EPayResult result, System.String msg); // 0x065fe714
	System.Void <PurchaseImmediately>b__4(SimpleJSON.JSONNode res); // 0x065febe8
	System.Void <PurchaseImmediately>b__2(); // 0x065fec8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTopUp : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.SocClient.Ui.IJumpToUIWindow
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.UiLobbyTopUpBinder binder; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJRecharge> rechargeItems; // 0x340
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x348
	System.Void OnInit(); // 0x065fed54
	System.Void ListItemClick(FairyGUI.EventContext context); // 0x065ff99c
	System.Void ListItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x065ffda0
	System.Void OnEnable(); // 0x06600570
	System.Void OnDisable(); // 0x066009f8
	System.Void JumpToUIWindow(WizardGames.Soc.SocClient.Ui.JumpData jumpData); // 0x06600a60
	System.Void .ctor(); // 0x06600ad4
	System.Void <OnInit>b__4_1(); // 0x06600b60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTopUp.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLobbyTopUp.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.Common.Data.mall.OBJRecharge,System.Boolean> <>9__4_0; // 0x8
	static System.Action<WizardGames.Soc.SDK.MidasWrapper.EPayResult,System.String> <>9__5_2; // 0x10
	static System.Action <>9__5_1; // 0x18
	static System.Void .cctor(); // 0x06600bcc
	System.Void .ctor(); // 0x06600c30
	System.Boolean <OnInit>b__4_0(WizardGames.Soc.Common.Data.mall.OBJRecharge x); // 0x06600c98
	System.Void <ListItemClick>b__5_2(WizardGames.Soc.SDK.MidasWrapper.EPayResult result, System.String msg); // 0x06600d30
	System.Void <ListItemClick>b__5_1(); // 0x06601144
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTopUp.<>c__DisplayClass5_0 : System.Object
{
	WizardGames.Soc.Common.Data.mall.OBJRecharge data; // 0x10
	System.Void .ctor(); // 0x065ffd38
	System.Void <ListItemClick>b__0(System.String urlParams); // 0x066012a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTopUp.<>c__DisplayClass7_0 : System.Object
{
	FairyGUI.GComponent child; // 0x10
	System.Void .ctor(); // 0x06600990
	System.Void <OnEnable>b__0(System.Int64 id, System.Object data, System.Boolean del); // 0x06601480
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.CargoItem : System.ValueType
{
	System.Int64 ItemId; // 0x10
	System.Int32 ItemCount; // 0x18
	System.Void .ctor(System.Int64 id, System.Int32 count); // 0x0660156c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTrainCargoPanel : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.HashSet<System.Int64> unknownAdvancedGoods; // 0x8
	static System.String cargoListResPath; // 0x10
	static System.String cargoItemResPath; // 0x18
	static System.Int64 trainEntityId; // 0x20
	static System.Int32 trainCargoId; // 0x28
	FairyGUI.GButton closeBtn; // 0x338
	FairyGUI.GList cargoPanelList; // 0x340
	FairyGUI.GGraph touchHideTips; // 0x348
	WizardGames.Soc.SocClient.Ui.ComBaseIcon selectIcon; // 0x350
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.CargoItem>> cargoItems; // 0x358
	System.Collections.Generic.List<System.Int64> trainEntityIds; // 0x360
	static System.Void SetData(System.Int64 entityId, System.Int32 cargoId); // 0x066015f0
	System.Void OnInit(); // 0x06601698
	System.Void OnEnable(); // 0x06601c3c
	System.Void OnDisable(); // 0x06603058
	static System.Void InitUnknownCargo(); // 0x06601990
	System.Void PrepareData(); // 0x06601e28
	static System.Int64 ConvertItemId(System.Int64 itemId); // 0x06603320
	System.Void ShowData(); // 0x06602660
	System.Void OnSelectIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon baseIcon); // 0x066033e8
	System.Void ClearChooseIcon(); // 0x06603290
	System.Void .ctor(); // 0x06603488
	static System.Void .cctor(); // 0x066035b8
	System.Void <OnInit>b__13_0(); // 0x06603758
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTrainCargoPanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTrainCargoPanel.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__14_0; // 0x8
	static System.Void .cctor(); // 0x0663faa4
	System.Void .ctor(); // 0x0663fb08
	System.Void <OnEnable>b__14_0(FairyGUI.EventContext _); // 0x0663fb70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.DischargeMethod : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Title>k__BackingField; // 0x18
	FairyGUI.GComponent <Icon>k__BackingField; // 0x20
	FairyGUI.GTextField <DischargeDes>k__BackingField; // 0x28
	FairyGUI.GButton <BtnItemDetail>k__BackingField; // 0x30
	FairyGUI.Controller <IsHaveState>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x40
	FairyGUI.GLabel get_Title(); // 0x0663fc3c
	FairyGUI.GComponent get_Icon(); // 0x0663fca0
	FairyGUI.GTextField get_DischargeDes(); // 0x0663fd04
	FairyGUI.GButton get_BtnItemDetail(); // 0x0663fd68
	FairyGUI.Controller get_IsHaveState(); // 0x0663fdcc
	FairyGUI.Controller get_CtrlState(); // 0x0663fe30
	System.Void .ctor(FairyGUI.GComponent root); // 0x0663fe94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTrainDischarge : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Int32 currentSelected; // 0x338
	System.Collections.Generic.List<System.Int64> DischargeMethodIds; // 0x340
	FairyGUI.GList ExchangeList; // 0x348
	WizardGames.Soc.SocClient.Ui.ComModal ComModal; // 0x350
	System.String ManualDischargeURL; // 0x358
	WizardGames.Soc.Common.Entity.IEntity <lootEntity>k__BackingField; // 0x360
	WizardGames.Soc.Common.Entity.IEntity get_lootEntity(); // 0x06640090
	System.Void OnInit(); // 0x066400f4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x066408dc
	System.Void SetDefaultSelected(); // 0x066407dc
	System.Void OnExchangeItemClick(FairyGUI.EventContext context); // 0x066409c0
	System.Void RenderExchangeItem(System.Int32 index, FairyGUI.GObject obj); // 0x06640c9c
	System.Void OnCloseClick(); // 0x06640954
	System.Void Ensure(); // 0x066415d4
	System.Boolean IsTrainDischargeActivation(); // 0x06641934
	System.Void .ctor(); // 0x06641f6c
	System.Void <OnInit>b__11_0(); // 0x06642280
	System.Void <OnInit>b__11_1(); // 0x066422e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTrainDischarge.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTrainDischarge.<>c <>9; // 0x0
	static System.Func<System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.Data.Play.TrainDischarge>,System.Int64> <>9__18_1; // 0x8
	static System.Void .cctor(); // 0x06642348
	System.Void .ctor(); // 0x066423ac
	System.Int64 <IsTrainDischargeActivation>b__18_1(System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.Data.Play.TrainDischarge> item); // 0x06642414
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTrainDischarge.<>c__DisplayClass15_0 : System.Object
{
	FairyGUI.GComponent item; // 0x10
	WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig; // 0x18
	System.Void .ctor(); // 0x0664156c
	System.Void <RenderExchangeItem>b__0(FairyGUI.EventContext context); // 0x066424a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTrainDischarge.<>c__DisplayClass18_0 : System.Object
{
	WizardGames.Soc.Common.Entity.IOEntity ioEntity; // 0x10
	System.Void .ctor(); // 0x06641f04
	System.Boolean <IsTrainDischargeActivation>b__0(System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.Data.Play.TrainDischarge> item); // 0x06642594
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBurWeaponCountdown : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static System.String UI_NMAE; // 0x0
	static WizardGames.Soc.SocClient.Ui.UiBurWeaponCountdown instance; // 0x8
	static System.Action callbackFinish; // 0x10
	static System.Int64 playerStateHandle; // 0x18
	WizardGames.Soc.SocClient.Ui.ComCountdown comCountdown; // 0x338
	System.Boolean isCounting; // 0x340
	static System.Boolean get_Active(); // 0x06642640
	System.Void OnInit(); // 0x066426dc
	System.Void OnEnable(); // 0x0664287c
	System.Void OnDisable(); // 0x06642a74
	static System.Void Show(System.Int32 timeSecond, System.Action callback); // 0x054fe06c
	static System.Void Hide(); // 0x066431cc
	System.Void PlayerStateTimer(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x06643494
	System.Void UpdatePlayerState(); // 0x06642b3c
	static System.Void RemovePlayerStateHandle(); // 0x06642cb8
	System.Void StartCountDown(System.Int32 downtimeMs); // 0x0664290c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06643528
	System.Void OnCountdownFinish(); // 0x066435ac
	System.Void CancelCountdown(System.Boolean isDistanceReason); // 0x066432f4
	static WizardGames.Soc.SocClient.Ui.UiBurWeaponCountdown OpenBurWeaponCountdown(); // 0x06643028
	System.Void .ctor(); // 0x066436bc
	static System.Void .cctor(); // 0x06643748
	System.Void <StartCountDown>b__16_0(); // 0x066437c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBurWeaponPanel : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	static System.Int64 interactionEntityId; // 0x0
	static System.Collections.Generic.List<System.Int64> allowedWeapons; // 0x8
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BurWeaponData> weaponDatas; // 0x10
	static WizardGames.Soc.SocClient.Ui.ComItemIcon curSelectIcon; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiBurWeaponPanelBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComBackpackBinder backpackBinder; // 0x340
	FairyGUI.GButton btnLeft; // 0x348
	FairyGUI.GButton btnRight; // 0x350
	static WizardGames.Soc.SocClient.Ui.ComItemIcon GetIcon(FairyGUI.GObject node); // 0x0664382c
	System.Void InitUIComponent(); // 0x06643910
	static System.Void SetInteractionEntityId(System.Int64 entityId); // 0x06643f80
	System.Void OnInit(); // 0x06644000
	System.Void OnEnable(); // 0x06644438
	System.Void ListItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x066450a0
	System.Void OnClickIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon baseIcon); // 0x066452a4
	System.Void OnFps10Update(System.Single dt); // 0x0664550c
	System.Void RegisterEvents(); // 0x06644078
	static System.Void PrepareWeaponData(); // 0x06644744
	static System.Void ShowBurWeaponPanel(); // 0x06645620
	System.Void OnDisable(); // 0x066457cc
	static System.Void OnClickConfirm(); // 0x0664587c
	static System.Void HideBurWeaponPanel(); // 0x066459bc
	System.Void .ctor(); // 0x06645a98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBurWeaponPanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiBurWeaponPanel.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__17_0; // 0x8
	static FairyGUI.EventCallback1 <>9__17_1; // 0x10
	static FairyGUI.EventCallback1 <>9__17_2; // 0x18
	static System.Void .cctor(); // 0x06645b24
	System.Void .ctor(); // 0x06645b88
	System.Void <RegisterEvents>b__17_0(FairyGUI.EventContext _); // 0x06645bf0
	System.Void <RegisterEvents>b__17_1(FairyGUI.EventContext _); // 0x06645c64
	System.Void <RegisterEvents>b__17_2(FairyGUI.EventContext _); // 0x06645cd8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BurWeaponData : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode Data; // 0x10
	System.Boolean InBag; // 0x18
	System.Void .ctor(WizardGames.Soc.Common.CustomType.BaseItemNode data, System.Boolean inBag); // 0x06645580
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.TaskSlotData : System.ValueType
{
	System.Int32 slotId; // 0x10
	System.Int64 taskId; // 0x18
	System.Int64 taskState; // 0x20
	System.Boolean isTracking; // 0x28
	System.Void .ctor(System.Int32 slotId, System.Int64 taskId, System.Int64 taskState, System.Boolean isTracking); // 0x06645d4c
	static System.Boolean op_Equality(WizardGames.Soc.SocClient.Ui.TaskSlotData left, WizardGames.Soc.SocClient.Ui.TaskSlotData right); // 0x06645df4
	static System.Boolean op_Inequality(WizardGames.Soc.SocClient.Ui.TaskSlotData left, WizardGames.Soc.SocClient.Ui.TaskSlotData right); // 0x06645ec8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTreasureHuntTask : System.Object
{
	static SocLogger logger; // 0x0
	System.Boolean isShowing; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PoiTaskNode> taskNodes; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TaskSlotData> taskSlots; // 0x20
	System.Int32 lastTrackSlot; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiTreasureHuntTaskBinder content; // 0x30
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x38
	WizardGames.Soc.SocClient.Ui.ComBaseIcon selectIcon; // 0x40
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Int32> itemTimers; // 0x48
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.TreasureHuntTaskItemBinder> itemBinders; // 0x50
	System.Int64 tickTimerId; // 0x58
	System.Int64 taskTimer; // 0x60
	System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,System.Int64,System.Int64> RefreshCurrencyCb; // 0x68
	WizardGames.Soc.Common.CustomType.PoiTaskContainer get_taskContainer(); // 0x06645f70
	static System.Int64 GetTrackTaskId(); // 0x0664608c
	static System.Boolean IsInProgress(WizardGames.Soc.Common.CustomType.PoiTaskNode node); // 0x0664617c
	static System.Boolean IsTracking(WizardGames.Soc.Common.CustomType.PoiTaskNode node); // 0x06646260
	static System.Void SetDifficulty(FairyGUI.GComponent gCom, System.Int64 taskId); // 0x06646388
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiTreasureHuntTaskBinder binder, WizardGames.Soc.SocClient.Ui.ComTopBar topBar); // 0x06646520
	System.Void OnEnable(); // 0x066466d0
	System.Void OnDisable(); // 0x066474c4
	System.Void RegisterEvents(); // 0x0664728c
	System.Void UnRegisterEvents(); // 0x06647724
	System.Void InitTasks(); // 0x055049cc
	System.Void RefreshAllCurrency(); // 0x06647bbc
	System.Void FetchTaskNodes(); // 0x06647f3c
	System.Void RefreshTasks(); // 0x06648014
	System.Void OnTrackTaskChange(); // 0x066487c4
	System.Void RefreshSingleSlot(WizardGames.Soc.Common.CustomType.PoiTaskNode task); // 0x066483d8
	System.Void RefreshSingleSlot(WizardGames.Soc.SocClient.Ui.TaskSlotData slot); // 0x06648970
	System.Void RefreshTime(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x0664a38c
	System.Void TaskTimerFunc(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x0664a730
	System.Void SetTaskTimerText(WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.TreasureHuntTaskItemBinder binder, System.Int32 index); // 0x0664a950
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x06648d4c
	System.Void SetIsShowing(System.Boolean enabled); // 0x0664ae84
	System.Void ClearChooseIcon(); // 0x06647698
	System.Void ClearItemTimers(); // 0x0664795c
	System.Void .ctor(); // 0x0664af54
	static System.Void .cctor(); // 0x0664b128
	System.Void <OnInit>b__24_0(); // 0x0664b1fc
	System.Void <OnInit>b__24_1(WizardGames.Soc.Share.Framework.CustomTypeBase _, System.Int64 _, System.Int64 _); // 0x0664b28c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTreasureHuntTask.<>c__DisplayClass39_0 : System.Object
{
	System.Collections.Generic.List<System.Int64> rewardIds; // 0x10
	System.Collections.Generic.List<System.Int64> rewardNums; // 0x18
	WizardGames.Soc.SocClient.Ui.UiTreasureHuntTask <>4__this; // 0x20
	System.Int64 taskId; // 0x28
	System.Void .ctor(); // 0x0664ae1c
	System.Void <OnItemRender>b__0(System.Int32 itemIndex, FairyGUI.GObject itemObj); // 0x0664b320
	System.Void <OnItemRender>b__1(FairyGUI.EventContext ctx); // 0x0664b62c
	System.Void <OnItemRender>b__2(FairyGUI.EventContext ctx); // 0x0664b718
	System.Void <OnItemRender>b__3(FairyGUI.EventContext ctx); // 0x0664b804
	System.Void <OnItemRender>b__4(FairyGUI.EventContext ctx); // 0x0664b8f0
	System.Void <OnItemRender>b__5(FairyGUI.EventContext ctx); // 0x0664b9dc
	System.Void <OnItemRender>b__6(FairyGUI.EventContext ctx); // 0x0664bac8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTreasureHuntTask.<>c__DisplayClass39_1 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig itemDropCfg; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTreasureHuntTask.<>c__DisplayClass39_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x0664b5c4
	System.Void <OnItemRender>b__7(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x0664bbb4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTurret : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	FairyGUI.GComponent content; // 0x338
	FairyGUI.GLoader btnMask; // 0x340
	FairyGUI.Controller controllerTurretType; // 0x348
	FairyGUI.GComponent comTitle; // 0x350
	System.Action maskClickAction; // 0x358
	System.Boolean isLooting; // 0x360
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ETurretGroupType,WizardGames.Soc.SocClient.Ui.UiTurretBaseGroup> turretGroupDic; // 0x368
	WizardGames.Soc.SocClient.Ui.UiTurretTitle turretTitle; // 0x370
	FairyGUI.GLoader btnSideClose; // 0x378
	FairyGUI.Transition transitionShow; // 0x380
	WizardGames.Soc.Common.Construction.PartType curTurretType; // 0x388
	FairyGUI.GLoader get_BtnMask(); // 0x0664be14
	System.Void set_MaskClickAction(System.Action value); // 0x0664be78
	System.Boolean get_IsLooting(); // 0x0664bf10
	System.Void OnInit(); // 0x0664bf74
	System.Void OnEnable(); // 0x0664c444
	UnityEngine.Rect GetHalfScreenHideArea(); // 0x0664c4f4
	System.Void OnDisable(); // 0x0664c5b4
	System.Void OnDestroy(); // 0x0664c664
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0664c894
	System.Void OnBtnClose(); // 0x0664c984
	System.Void RemoteCallStartLooting(System.Int64 entityId); // 0x0664c9e8
	System.Void InitData(); // 0x0664cc14
	System.Void PlayAudio(System.Boolean isOpen); // 0x0664d690
	System.Void RemoteCallStopLooting(); // 0x0664c6d4
	System.Void OnFps30Update(System.Single dt); // 0x0664da40
	System.Void RemoveWindows(); // 0x0664c90c
	WizardGames.Soc.SocClient.Ui.UiTurretBaseGroup GetGroup(WizardGames.Soc.SocClient.Ui.ETurretGroupType groupType); // 0x0664dbcc
	System.Void .ctor(); // 0x0664dca8
	System.Void <OnInit>b__18_0(); // 0x0664dd80
	System.Void <RemoteCallStartLooting>b__25_0(System.Boolean res); // 0x0664de1c
	System.Void <InitData>b__27_0(System.Collections.Generic.KeyValuePair<WizardGames.Soc.SocClient.Ui.ETurretGroupType,WizardGames.Soc.SocClient.Ui.UiTurretBaseGroup> pair); // 0x0664dea4
	System.Void <InitData>b__27_1(); // 0x0664df3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTurret.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTurret.<>c <>9; // 0x0
	static System.Action<System.Collections.Generic.KeyValuePair<WizardGames.Soc.SocClient.Ui.ETurretGroupType,WizardGames.Soc.SocClient.Ui.UiTurretBaseGroup>> <>9__29_0; // 0x8
	static System.Void .cctor(); // 0x0664dff4
	System.Void .ctor(); // 0x0664e058
	System.Void <RemoteCallStopLooting>b__29_0(System.Collections.Generic.KeyValuePair<WizardGames.Soc.SocClient.Ui.ETurretGroupType,WizardGames.Soc.SocClient.Ui.UiTurretBaseGroup> pair); // 0x0664e0c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTurret.<>c__DisplayClass30_0 : System.Object
{
	System.Single dt; // 0x10
	System.Void .ctor(); // 0x0664db64
	System.Void <OnFps30Update>b__0(System.Collections.Generic.KeyValuePair<WizardGames.Soc.SocClient.Ui.ETurretGroupType,WizardGames.Soc.SocClient.Ui.UiTurretBaseGroup> pair); // 0x0664e15c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTurretAmmoGroup : WizardGames.Soc.SocClient.Ui.UiTurretBaseGroup
{
	FairyGUI.GButton btnEquipAmmo; // 0x20
	FairyGUI.GButton btnUnEquipAmmo; // 0x28
	FairyGUI.GComponent iconAmmo; // 0x30
	FairyGUI.Controller controller; // 0x38
	FairyGUI.GLoader loaderIconAmmo; // 0x40
	FairyGUI.GTextField txtNumAmmo; // 0x48
	FairyGUI.GTextField txtAmmoName; // 0x50
	FairyGUI.Controller controllerIsEquipWeapon; // 0x58
	WizardGames.Soc.Common.CustomType.ItemContainerNode ammoItemContainerNode; // 0x60
	WizardGames.Soc.Common.CustomType.BaseItemNode ammoItemNode; // 0x68
	System.Int64 selectAmmoPopupId; // 0x70
	WizardGames.Soc.Common.CustomType.BaseItemNode get_AmmoItemNode(); // 0x0664e1fc
	System.Int64 get_SelectAmmoPopupId(); // 0x0664e260
	System.Void InitData(FairyGUI.GComponent content, WizardGames.Soc.SocClient.Ui.UiTurret uiTurret); // 0x0664e2c4
	System.Void OnFps30Update(System.Single dt); // 0x0664e7cc
	System.Void UpdateAmmoInfo(); // 0x0664e8cc
	System.Int32 GetHaveEquipAmmoCount(); // 0x0664ec54
	System.Void OnClickAmmo(); // 0x0664ee44
	System.Void UpdateSelectAmmoPopup(System.Boolean isShowTips); // 0x0664eeb4
	System.Void ShowSplitAddItemPopup(System.Int64 itemId); // 0x0664f0e4
	System.Void OnBtnEquipAmmo(); // 0x0664f358
	System.Void OnBtnUnEquipAmmo(); // 0x0664f560
	System.Void UnEquipAmmo(System.Boolean& checkSuccess); // 0x0664f5e4
	System.Void .ctor(); // 0x0664d62c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTurretAutoAmmoGroup : WizardGames.Soc.SocClient.Ui.UiTurretAmmoGroup
{
	WizardGames.Soc.SocClient.Ui.UiTurretSelectAmmoPopup selectAmmoPopup; // 0x78
	WizardGames.Soc.SocClient.Ui.UiTurretWeaponGroup get_WeaponGroup(); // 0x0664f794
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_AmmoItemContainerNode(); // 0x0664f854
	System.Void InitData(FairyGUI.GComponent content, WizardGames.Soc.SocClient.Ui.UiTurret uiTurret); // 0x0664f8b8
	System.Void OnFps30Update(System.Single dt); // 0x06650030
	System.Void UpdateAmmoInfo(); // 0x066500ac
	System.Void UpdateSelectAmmoPopup(System.Boolean isShowTips); // 0x0665020c
	System.Void OnBtnEquipAmmo(); // 0x066506f8
	System.Void UnEquipAmmo(System.Boolean& checkSuccess); // 0x066510ec
	System.Void .ctor(); // 0x0664d564
	System.Void <UpdateSelectAmmoPopup>b__8_0(System.Int64 itemId); // 0x066511f0
	System.Void <UpdateSelectAmmoPopup>b__8_1(); // 0x06651270
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ETurretGroupType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ETurretGroupType State = 0;
	static WizardGames.Soc.SocClient.Ui.ETurretGroupType Ammo = 1;
	static WizardGames.Soc.SocClient.Ui.ETurretGroupType AutoAmmo = 2;
	static WizardGames.Soc.SocClient.Ui.ETurretGroupType Weapon = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTurretBaseGroup : System.Object
{
	System.Int64 lootingEntityId; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTurret uiTurret; // 0x18
	WizardGames.Soc.Common.Entity.PartEntity get_partEntity(); // 0x0664efac
	WizardGames.Soc.Common.Construction.PartType get_partType(); // 0x0665100c
	System.Int64 get_nodeId(); // 0x0664f04c
	System.Void InitData(FairyGUI.GComponent content, WizardGames.Soc.SocClient.Ui.UiTurret uiTurret); // 0x0664e684
	System.Void DisposeData(); // 0x066512d4
	System.Void OnItemNodeUpdate(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x066513d4
	System.Void OnFps30Update(System.Single dt); // 0x0664e858
	System.Void .ctor(); // 0x0664f724
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTurretStateGroup : WizardGames.Soc.SocClient.Ui.UiTurretBaseGroup
{
	FairyGUI.GButton btnModeTip; // 0x20
	FairyGUI.GButton btnRunningState; // 0x28
	FairyGUI.Controller controllerRunningState; // 0x30
	FairyGUI.GButton btnOperationMode; // 0x38
	FairyGUI.Controller controllerOperationMode; // 0x40
	FairyGUI.Controller controllerTurretType; // 0x48
	System.Boolean isOpen; // 0x50
	System.Boolean isPeacekeeper; // 0x51
	System.Void InitData(FairyGUI.GComponent content, WizardGames.Soc.SocClient.Ui.UiTurret uiTurret); // 0x06651448
	System.Void DisposeData(); // 0x06651c8c
	System.Void OperationModeUpdateEvent(System.Boolean peacekeeper); // 0x06651e00
	System.Void SwitchStateUpdateEvent(System.Boolean open); // 0x06651e84
	System.Void UpdateRunningState(); // 0x06651a14
	System.Void UpdateOperationMode(System.Boolean isShowTips); // 0x06651a9c
	System.Boolean HasFlag(WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags flag); // 0x06651914
	System.Void OnBtnRunningState(); // 0x06651f04
	System.Void OnBtnOperationMode(); // 0x06651fb0
	System.Void OnBtnModeTip(); // 0x066520b4
	System.Void .ctor(); // 0x0664d500
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTurretTitle : System.Object
{
	FairyGUI.GButton btnClose; // 0x10
	FairyGUI.GTextField txtTitle; // 0x18
	FairyGUI.GButton btnTitleTip; // 0x20
	WizardGames.Soc.Common.Entity.PartEntity partEntity; // 0x28
	WizardGames.Soc.SocClient.Ui.UiTurret uiTurret; // 0x30
	System.Void InitData(FairyGUI.GComponent content, WizardGames.Soc.SocClient.Ui.UiTurret uiTurret, WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x0664d058
	System.Void OnBtnTitleTip(); // 0x066521b4
	System.Void OnBtnClose(); // 0x066523a4
	System.Void .ctor(); // 0x0664c3dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTurretWeaponGroup : WizardGames.Soc.SocClient.Ui.UiTurretBaseGroup
{
	WizardGames.Soc.Common.CustomType.ItemContainerNode weaponContainerNode; // 0x20
	WizardGames.Soc.Common.CustomType.BaseItemNode weaponItemNode; // 0x28
	FairyGUI.GButton btnEquipWeapon; // 0x30
	FairyGUI.GButton btnUnEquipWeapon; // 0x38
	FairyGUI.GComponent iconWeapon; // 0x40
	FairyGUI.Controller controller; // 0x48
	WizardGames.Soc.SocClient.Ui.ComItemIcon weaponIconCom; // 0x50
	FairyGUI.GTextField txtWeaponName; // 0x58
	System.Boolean isEquipWeapon; // 0x60
	WizardGames.Soc.Common.CustomType.BaseItemNode get_WeaponItemNode(); // 0x06652410
	System.Boolean get_IsEquipWeapon(); // 0x06652474
	System.Void InitData(FairyGUI.GComponent content, WizardGames.Soc.SocClient.Ui.UiTurret uiTurret); // 0x066524d8
	System.Void OnItemNodeUpdate(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x06652d34
	System.Void UpdateWeaponInfo(); // 0x066529a4
	System.Void OnClickIconWeapon(); // 0x06652dac
	System.Void OnBtnEquipWeapon(); // 0x06652ea4
	System.Void OpenTurretSideBackpack(); // 0x06652e10
	System.Void OnBtnUnEquipWeapon(); // 0x06653258
	System.Void .ctor(); // 0x0664d5c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTurretSelectAmmoPopup : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.UiExpandPopupBinder binder; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTurret uiTurret; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> amountDic; // 0x20
	System.Collections.Generic.List<System.Int64> ammoIdList; // 0x28
	WizardGames.Soc.Common.Data.DataItem.ItemConfig selectAmmoConfig; // 0x30
	System.Int32 selectIndex; // 0x38
	System.Action<System.Int64> euqipClickAction; // 0x40
	System.Action unEuqipClickAction; // 0x48
	System.Boolean isShow; // 0x50
	WizardGames.Soc.SocClient.Ui.ComStateBtn equipBtn; // 0x58
	WizardGames.Soc.SocClient.Ui.ComStateBtn unequipBtn; // 0x60
	System.Collections.Generic.Dictionary<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComItemIconSimpleBinder> itemIconSimpleBinderDic; // 0x68
	WizardGames.Soc.SocClient.Ui.UiTurretWeaponGroup get_weaponGroup(); // 0x06653404
	WizardGames.Soc.SocClient.Ui.UiTurretAutoAmmoGroup get_ammoGroup(); // 0x066534c4
	WizardGames.Soc.Common.CustomType.BaseItemNode get_weaponItemNode(); // 0x06653584
	WizardGames.Soc.Common.CustomType.BaseItemNode get_ammoItemNode(); // 0x0665362c
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_ammoContainerNode(); // 0x066536d4
	System.Void Bind(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiTurret uiTurret); // 0x0664fb74
	System.Void ItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x066538f0
	System.Void OnClickSelectItem(FairyGUI.EventContext context); // 0x06653f80
	System.Void RefreshSelectItem(FairyGUI.GComponent selectItem); // 0x0665419c
	System.Void Show(System.Action<System.Int64> euqipClickAction, System.Action unEuqipClickAction); // 0x0665046c
	System.Void UpdateSelectAmmoInfo(); // 0x066546bc
	System.Void DefaultSelectFirstItem(); // 0x06654b64
	System.Void Hide(); // 0x0665377c
	System.Void SetPopupWinPos(FairyGUI.GObject targetObj); // 0x066505dc
	System.Void OnEquipClicked(FairyGUI.EventContext context); // 0x06654dcc
	System.Void OnUnequipClicked(FairyGUI.EventContext context); // 0x06654e6c
	System.Void .ctor(); // 0x0664fa10
	System.Int32 <UpdateSelectAmmoInfo>b__29_0(System.Int64 a, System.Int64 b); // 0x06654efc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTurretSideBackpack : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static System.String UI_NMAE; // 0x0
	WizardGames.Soc.Common.CustomType.ItemContainerNode containerNodeWeapon; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> itemNodeList; // 0x340
	WizardGames.Soc.SocClient.Ui.UiTurretSideBackpackContainer sideBackpackContainer; // 0x348
	WizardGames.Soc.SocClient.Ui.ComItemIcon sourceIcon; // 0x350
	WizardGames.Soc.SocClient.Ui.UiTurret uiTurret; // 0x358
	WizardGames.Soc.SocClient.Ui.ComBackpack backpack; // 0x360
	System.Void OnInit(); // 0x06655008
	System.Void OnEnable(); // 0x06655678
	UnityEngine.Rect GetHalfScreenHideArea(); // 0x06655858
	System.Void OnDisable(); // 0x066559b4
	System.Void InitData(WizardGames.Soc.Common.CustomType.ItemContainerNode containerNodeWeapon, WizardGames.Soc.SocClient.Ui.UiTurret uiTurret); // 0x066530bc
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> GetMainIndexList(); // 0x06655cf8
	System.Void GetWeaponItem(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container); // 0x06655f38
	System.Void OnBtnComfirm(); // 0x0665619c
	static WizardGames.Soc.SocClient.Ui.UiTurretSideBackpack OpenWin(); // 0x06652f08
	System.Void .ctor(); // 0x06656ab8
	static System.Void .cctor(); // 0x06656c3c
	System.Void <OnInit>b__10_1(); // 0x06656ca4
	System.Void <OnInit>b__10_0(); // 0x06656d10
	System.Void <InitData>b__14_0(WizardGames.Soc.SocClient.Ui.ComItemIcon itemIcon); // 0x06656d7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTurretSideBackpack.<>c__DisplayClass17_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTurretSideBackpack <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTurretAutoAmmoGroup turretAmmoGroup; // 0x18
	WizardGames.Soc.Common.CustomType.BaseItemNode baseItemNode; // 0x20
	System.Void .ctor(); // 0x06656a50
	System.Void <OnBtnComfirm>b__0(); // 0x06656dfc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTurretSideBackpackContainer : WizardGames.Soc.SocClient.Ui.ClientContainerFlexible
{
	System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> selectAction; // 0xa0
	System.Void OnEnable(); // 0x066556f0
	System.Void OnDisable(); // 0x06655a58
	System.Void OnItemNodeUpdate(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x06656fa4
	System.Void OnClickItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x06657024
	System.Void DefaultSelectFirstItem(); // 0x06655bc0
	System.Void IconRenderer(System.Int32 index, FairyGUI.GObject item); // 0x0665712c
	System.Void .ctor(); // 0x06656bd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComUGCBase : FairyGUI.GButton
{
	System.String[] defaultOptions; // 0x318
	FairyGUI.GTextField textTitle; // 0x320
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.ComUGCArgs args); // 0x06657594
	System.Void SetTitle(System.String value); // 0x066576f4
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x0665779c
	System.Void .ctor(); // 0x06657870
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.ComUGCArgs : System.ValueType
{
	WizardGames.Soc.SocClient.Ui.OnComUGCValueChanged ChangedCallback; // 0x10
	System.String <Name>k__BackingField; // 0x18
	System.Single InitValue; // 0x20
	System.Single[] ValueRange; // 0x28
	System.String[] Options; // 0x30
	System.Boolean <WholeNumbers>k__BackingField; // 0x38
	System.String get_Name(); // 0x066578d8
	System.Void set_Name(System.String value); // 0x0665793c
	System.Single get_MinValue(); // 0x066579bc
	System.Single get_MaxValue(); // 0x06657a38
	System.Boolean get_WholeNumbers(); // 0x06657abc
	System.Void set_WholeNumbers(System.Boolean value); // 0x06657b20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.OnComUGCValueChanged : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x06657b9c
	System.Void Invoke(System.Object newValue); // 0x06657ccc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComUGCBinarySwitch : WizardGames.Soc.SocClient.Ui.ComUGCBase
{
	FairyGUI.GButton btn; // 0x328
	FairyGUI.GTextField off; // 0x330
	FairyGUI.GTextField on; // 0x338
	System.Int32 get_SwicthIndex(); // 0x06657d18
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.ComUGCArgs args); // 0x06657dd0
	System.Void SetOptions(System.String offStr, System.String onStr); // 0x06658028
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x0665811c
	System.Void .ctor(); // 0x06658270
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComUGCBinarySwitch.<>c__DisplayClass4_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComUGCArgs args; // 0x10
	WizardGames.Soc.SocClient.Ui.ComUGCBinarySwitch <>4__this; // 0x40
	System.Void .ctor(); // 0x06657fc0
	System.Void <OnInit>b__0(); // 0x066582d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComUGCSliderText : WizardGames.Soc.SocClient.Ui.ComUGCBase
{
	System.Double minValue; // 0x328
	System.Double maxValue; // 0x330
	FairyGUI.GSlider slider; // 0x338
	FairyGUI.GTextField textValue; // 0x340
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x066583b8
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.ComUGCArgs args); // 0x066584cc
	System.Void SetSlierMinAndMaxValue(System.Double min, System.Double max); // 0x06658798
	System.Void SetSliderValue(System.Double value); // 0x06658844
	System.Void ShowValue(System.String valueStr); // 0x0665897c
	System.Void .ctor(); // 0x06658a24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComUGCSliderText.<>c__DisplayClass3_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComUGCArgs args; // 0x10
	WizardGames.Soc.SocClient.Ui.ComUGCSliderText <>4__this; // 0x40
	System.Void .ctor(); // 0x06658730
	System.Void <OnInit>b__0(); // 0x06658a88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUGCComBase : System.Object
{
	FairyGUI.GComponent Root; // 0x10
	WizardGames.Soc.SocClient.Ui.UiUGCInspector Parent; // 0x18
	System.Void InitComponents(); // 0x06658c58
	System.Void InitData(); // 0x06658cb8
	System.Void OnEnable(); // 0x06658d18
	System.Void RegisterEvents(); // 0x06658d78
	System.Void UnregisterEvents(); // 0x06658dd8
	System.Void Destroy(); // 0x06658e38
	System.Void OnClose(); // 0x06658e98
	System.Void .ctor(); // 0x06658ef8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUGCInspector : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent _content; // 0x338
	WizardGames.Soc.SocClient.Ui.UiUGCRightNavBar _rightNavBar; // 0x340
	WizardGames.Soc.SocClient.Ui.UiUgcPanel _panel; // 0x348
	FairyGUI.Controller _panelController; // 0x350
	System.Int64 TargetPartId; // 0x358
	System.Int64 <TargetEntityId>k__BackingField; // 0x360
	System.Int64 get_TargetEntityId(); // 0x06658f60
	System.Void set_TargetEntityId(System.Int64 value); // 0x06658fc4
	System.Void OnInit(); // 0x0665903c
	System.Void InitComponents(); // 0x066590b4
	System.Void InitData(System.Int64 parentId, System.Int64 partId); // 0x06659598
	System.Void OnEnable(); // 0x066596d8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06659764
	System.Void OnRightNavBtnClicked(System.Int32 index, System.Boolean isOtherBtnClicked); // 0x06659884
	System.Int32 GetMappedIndex(System.Int32 index); // 0x06659994
	System.Void OnClose(); // 0x066597ec
	System.Void OnDestroy(); // 0x06659ac4
	System.Void RegisterEvents(); // 0x066593f4
	System.Void UnRegisterEvents(); // 0x06659b88
	System.Void .ctor(); // 0x06659c08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUgcPanel : WizardGames.Soc.SocClient.Ui.UiUGCComBase
{
	static SocLogger logger; // 0x0
	FairyGUI.GList _listVehicle; // 0x20
	FairyGUI.GList _listAnimal; // 0x28
	FairyGUI.GList _listMonster; // 0x30
	System.Int64 TargetEntityId; // 0x38
	System.Int64 TargetPartId; // 0x40
	FairyGUI.Controller _pageController; // 0x48
	System.Void InitComponentsCreate(); // 0x06659c94
	System.Void DestroyCreate(); // 0x06659f14
	System.Void OnCloseCreate(); // 0x06659f74
	System.Void RegisterEventsCreate(); // 0x06659fd4
	System.Void UnregisterEventsCreate(); // 0x0665a034
	System.Void InitDataCreate(); // 0x0665a094
	WizardGames.Soc.SocClient.Ui.UiUgcPanel.EUGCComType GetPropertyCtrlType(WizardGames.Soc.SocClient.Ui.UiUgcPanel.UgcPropertyInfoEx infoEx); // 0x0665abfc
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiUgcPanel.UgcPropertyInfoEx> GetPropertyList(System.Int64 entityId, System.Int64 partId); // 0x0665a220
	System.Void AddListItem(WizardGames.Soc.SocClient.Ui.UiUgcPanel.UgcPropertyInfoEx info); // 0x0665a6d0
	static System.String GetComUrl(System.Int32 ctrlType); // 0x0665afac
	static System.Void SetItemData(FairyGUI.GComponent itemCom, WizardGames.Soc.SocClient.Ui.UiUgcPanel.EUGCComType ctrlType, WizardGames.Soc.SocClient.Ui.ComUGCArgs args); // 0x0665b274
	System.Void InitComponents(); // 0x0665b404
	System.Void InitData(); // 0x0665b4ac
	System.Void Destroy(); // 0x0665b510
	System.Void OnClose(); // 0x0665b57c
	System.Void RegisterEvents(); // 0x0665b5e8
	System.Void UnregisterEvents(); // 0x0665b654
	System.Void ShowPageByIndex(System.Int32 index); // 0x06659a14
	System.Void .ctor(); // 0x06659534
	static System.Void .cctor(); // 0x0665b6c0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiUgcPanel.EUGCComType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiUgcPanel.EUGCComType BinarySwitch = 1;
	static WizardGames.Soc.SocClient.Ui.UiUgcPanel.EUGCComType Slider = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUgcPanel.UgcPropertyInfoEx : System.Object
{
	System.Int64 EntityId; // 0x10
	System.Single Value; // 0x18
	WizardGames.Soc.SocWorld.Share.Ugc.UgcPropertyInfo Info; // 0x20
	System.Int32 get_PropertyId(); // 0x0665aed4
	System.String get_Name(); // 0x0665b124
	System.Type get_PropertyType(); // 0x0665adfc
	System.Single[] get_ValueRange(); // 0x0665b194
	System.String[] get_Options(); // 0x0665b204
	System.Void .ctor(); // 0x0665ae6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUgcPanel.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiUgcPanel.UgcPropertyInfoEx info; // 0x10
	System.Type propertyType; // 0x18
	System.Void .ctor(); // 0x0665af44
	System.Void <AddListItem>b__0(System.Object newObjValue); // 0x0665b794
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUGCRightNavBar : WizardGames.Soc.SocClient.Ui.UiUGCComBase
{
	FairyGUI.GList _btnList; // 0x20
	FairyGUI.GComponent _closeBtn; // 0x28
	System.Collections.Generic.List<System.String> _btnDataList; // 0x30
	System.Int32 _lastIndex; // 0x38
	System.Boolean _isSelected; // 0x3c
	System.Boolean _isFold; // 0x3d
	System.Void InitComponents(); // 0x0665ba78
	System.Void Destroy(); // 0x0665bd0c
	System.Void OnEnable(); // 0x0665bdcc
	System.Void OnClose(); // 0x0665bf78
	System.Void InitBtnListData(); // 0x0665bbe8
	System.Void OnCloseBtnClicked(); // 0x0665c068
	System.Void RefreshBtnList(); // 0x0665be74
	System.Void OnBtnClicked(System.Int32 index); // 0x0665c0d4
	System.Void ResetBtn(System.Int32 index); // 0x0665c230
	System.Void .ctor(); // 0x06659474
	System.Void <RefreshBtnList>b__12_0(System.Int32 index, FairyGUI.GObject item); // 0x0665c324
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUGCRightNavBar.<>c__DisplayClass12_0 : System.Object
{
	System.Int32 index; // 0x10
	WizardGames.Soc.SocClient.Ui.UiUGCRightNavBar <>4__this; // 0x18
	System.Void .ctor(); // 0x0665c518
	System.Void <RefreshBtnList>b__1(FairyGUI.EventContext _); // 0x0665c580
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiVehicleInfo : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	FairyGUI.GTextField _heightText; // 0x338
	FairyGUI.GComponent _heightComp; // 0x340
	FairyGUI.GList _heightList; // 0x348
	FairyGUI.GImage _holeImg; // 0x350
	FairyGUI.GComponent _heightElem; // 0x358
	static SocLogger <Logger>k__BackingField; // 0x0
	WizardGames.Soc.Common.Entity.BaseMountableEntity baseMountableEntity; // 0x360
	WizardGames.Soc.Common.Unity.Go.BaseVehicleGo vehicleGo; // 0x368
	FairyGUI.GComponent rootNode; // 0x370
	FairyGUI.GImage bg; // 0x378
	FairyGUI.GImage topLeft; // 0x380
	FairyGUI.GImage topRight; // 0x388
	FairyGUI.GTextField vehicleText; // 0x390
	FairyGUI.GTextField percentText; // 0x398
	FairyGUI.GComponent node; // 0x3a0
	System.Single bgLen; // 0x3a8
	FairyGUI.Transition diffuse; // 0x3b0
	FairyGUI.Transition reset; // 0x3b8
	System.Int32 totalStartTime; // 0x3c0
	FairyGUI.GList _velocityList; // 0x3c8
	FairyGUI.GTextField _velocityText; // 0x3d0
	System.Single _oneBoxHeight; // 0x3d8
	System.Void OnInit_Height(); // 0x0665c604
	System.Void OnFps10UpdateWin_Height(System.Single dt); // 0x0665c8d8
	System.Void UpdateUI_Height(); // 0x0665cbf0
	System.Void OnDestroy_Height(); // 0x0665cc50
	static SocLogger get_Logger(); // 0x0665ccb0
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x0665cd38
	System.Void OnInit(); // 0x0665cdb8
	System.Void OnFps10Update(System.Single dt); // 0x0665d954
	System.Void OnFps30Update(System.Single dt); // 0x0665dc94
	System.Void UpdateUI(); // 0x0665d530
	System.Void OnDestroy(); // 0x0665e0a8
	System.Void OnInit_Percent(); // 0x0665d264
	System.Void OnFps30UpdateWin_Percent(System.Single dt); // 0x0665dd10
	System.Int32 get_zeroIndex(); // 0x0665e1a8
	System.Single get_zeroPos(); // 0x0665e220
	System.Void OnInit_Velocity(); // 0x0665cecc
	System.Void OnFps10UpdateWin_Velocity(System.Single dt); // 0x0665d9dc
	System.Void UpdateUI_Velocity(); // 0x0665e048
	System.Void OnDestroy_Velocity(); // 0x0665e140
	System.Void .ctor(); // 0x0665e2fc
	static System.Void .cctor(); // 0x0665e388
	System.Void <OnFps30UpdateWin_Percent>b__33_0(); // 0x0665e45c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiVehicleMissileTips : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicle.RootMissileTipsBinder rootBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicle.ComMissileTextTipsBinder textTip; // 0x340
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.UiVehicleMissileTips.MissileWarningTips> MissileWarningPool; // 0x348
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.UiVehicleMissileTips.MissileWarningTips> currentWarningTips; // 0x350
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.UiVehicleMissileTips.MissileMarkerTips> MissileMarkerPool; // 0x358
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.UiVehicleMissileTips.MissileMarkerTips> currentMarkerTips; // 0x360
	System.Collections.Generic.List<System.Int64> RemoveIds; // 0x368
	UnityEngine.Vector2 screenCenterPos; // 0x370
	System.String previousAudioEventName; // 0x378
	System.String currentAudioEventName; // 0x380
	CommonUnity.Runtime.Entity.ISeekerTarget seekerTarget; // 0x388
	WizardGames.Soc.Common.Entity.PlayerEntity get_myPlayer(); // 0x0665e4d0
	System.Void OnInit(); // 0x0665e56c
	System.Void OnDestroy(); // 0x0665f3d4
	System.Void OnEnable(); // 0x0665f534
	System.Void OnDisable(); // 0x0665f654
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x06660214
	System.Void CollectMarkerTips(System.Boolean clearAll); // 0x0665f704
	System.Void UpdateMarkerTips(); // 0x06660348
	System.Void CollectWarningTips(System.Boolean clearAll); // 0x0665fc00
	System.Void UpdateWarningTips(); // 0x0666078c
	System.Void UpdateTextTipWithAudioEvent(); // 0x06660f54
	System.Void PlayAudioEvent(); // 0x066616bc
	System.Void StopAudioEvent(); // 0x0666010c
	UnityEngine.Vector3 TryGetSmoothPosition(WizardGames.Soc.Common.Entity.IEntity entity); // 0x066617d8
	System.Void .ctor(); // 0x06662198
	static System.Void .cctor(); // 0x066622ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiVehicleMissileTips.MissileWarningTips : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicle.ComMissileDirectionTipsBinder binder; // 0x10
	FairyGUI.GLoader icon; // 0x18
	System.Single angle; // 0x20
	UnityEngine.Vector2 screenCenterPos; // 0x24
	System.Void .ctor(FairyGUI.GComponent warning, UnityEngine.Vector2 screenCenter); // 0x0665eec0
	System.Void UpdateWarningTip(UnityEngine.Vector3 worldPos, UnityEngine.Camera camera, WizardGames.Soc.SocClient.Ui.UiVehicleMissileTips.MissileWarningTips.WarningState state); // 0x06662064
	System.Single CalcIconRotationAngle(UnityEngine.Vector3 worldPos, UnityEngine.Camera camera); // 0x06662380
	System.Void SetAngle(System.Single angle); // 0x066625b0
	System.Void SetWarning(); // 0x0666269c
	System.Void SetLocked(); // 0x066627f8
	System.Void SetCome(); // 0x06662954
	System.Void SetActive(System.Boolean active); // 0x0665f070
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiVehicleMissileTips.MissileWarningTips.WarningState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiVehicleMissileTips.MissileWarningTips.WarningState Warning = 0;
	static WizardGames.Soc.SocClient.Ui.UiVehicleMissileTips.MissileWarningTips.WarningState Locked = 1;
	static WizardGames.Soc.SocClient.Ui.UiVehicleMissileTips.MissileWarningTips.WarningState Come = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiVehicleMissileTips.MissileMarkerTips : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicle.ComMissileDistanceTipsBinder binder; // 0x10
	FairyGUI.GTextField title; // 0x18
	System.Void .ctor(FairyGUI.GComponent marker); // 0x0665f144
	System.Void UpdateMarkerTip(UnityEngine.Vector3 myPos, UnityEngine.Vector3 worldPos, UnityEngine.Camera camera); // 0x06661bcc
	System.Void SetActive(System.Boolean active); // 0x0665f300
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiVehicleOperate : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	SocLogger logger; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComTransparentSideShotBinder sideShotBinder; // 0x340
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComSideShotTopBinder comSideShotTopBinder; // 0x348
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicleOperate.UiVehicleBinder viewBinder; // 0x350
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicleOperate.RootVehicleBinder rootBinder; // 0x358
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicleOperate.ComVehiclePanelBinder panelBinder; // 0x360
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.UiExpandPopupBinder popupBinder; // 0x368
	FairyGUI.GTextField titleText; // 0x370
	FairyGUI.GButton closeBtn; // 0x378
	FairyGUI.GComponent rollingArea; // 0x380
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicleOperate.ComVehicleRollingAreaBinder rollingAreaBinder; // 0x388
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicleOperate.ComVechicleAttBinder attributeNode; // 0x390
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicleOperate.ComVehicleEngineNodeBinder engineNodeBinder; // 0x398
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicleOperate.ComVehicleFuelNodeBinder fuelNodeBinder; // 0x3a0
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicleOperate.ComVehicleFireNodeBinder fireNodeBinder; // 0x3a8
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicleOperate.ComVehicleHorseGearNodeBinder horseGearNodeBinder; // 0x3b0
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicleOperate.ComVehicleStorageNodeBinder storageNodeBinder; // 0x3b8
	WizardGames.Soc.SocClient.Ui.ComItemIcon fuelIcon; // 0x3c0
	WizardGames.Soc.SocClient.Ui.ComItemIcon fireIcon; // 0x3c8
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicleOperate.BtnDecayBinder decayBtnBinder; // 0x3d0
	System.Boolean IsRegisteredEvent; // 0x3d8
	UnityEngine.Vector3 myPlayerPos; // 0x3dc
	WizardGames.Soc.Common.Entity.IBaseMountableEntity mountableEntity; // 0x3e8
	WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo; // 0x3f0
	System.Single defaultCloseWinDistanceSqr; // 0x3f8
	System.Boolean keepOthersideStateWhenDisable; // 0x3fc
	System.Boolean DontStopLootWhenDisable; // 0x3fd
	System.Action<WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType,System.Int64> OnCloseViewAction; // 0x400
	System.Collections.Generic.HashSet<System.Int64> EntitySubscribeIds; // 0x408
	System.Collections.Generic.HashSet<System.Int64> DamageCompSubscribeIds; // 0x410
	FairyGUI.Transition TransShow_anim; // 0x418
	WizardGames.Soc.SocClient.Ui.UiVehicleOperate.EBulletType hasBulletType; // 0x420
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiVehicleOperate.AttributeItemRenderData> attributeItemRenderDataList; // 0x428
	System.Collections.Generic.HashSet<System.String> moduleTypeFuncDescriptions; // 0x430
	WizardGames.Soc.Common.CustomType.ItemContainerNode FuelContainer; // 0x438
	System.Collections.Generic.List<System.Int64> fuelAddResItemIdList; // 0x440
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> fuelOwnedResAmountDic; // 0x448
	System.Boolean IsTakingOutOil; // 0x450
	WizardGames.Soc.Common.CustomType.ItemContainerNode FireContainer; // 0x458
	System.Collections.Generic.List<System.Int64> fireAddResItemIdList; // 0x460
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> fireOwnedResAmountDic; // 0x468
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap> ModuleContainerList; // 0x470
	System.Collections.Generic.List<System.Int64> moduleItemIdList; // 0x478
	System.String[] moduleIconUrl; // 0x480
	WizardGames.Soc.Common.CustomType.ItemContainerNode HorseGearContainer; // 0x488
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int64>> HorseGearItemIdDic; // 0x490
	System.Boolean canRemove; // 0x498
	System.String[] horseEquipIconUrl; // 0x4a0
	WizardGames.Soc.Common.CustomType.BaseItemNode curPopupSelectedItemNode; // 0x4a8
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap curPopupContainer; // 0x4b0
	System.Int32 curPopupIndex; // 0x4b8
	FairyGUI.GList autoNextList; // 0x4c0
	FairyGUI.GObject autoNextTarget; // 0x4c8
	System.Boolean isTipOpen; // 0x4d0
	System.Collections.Generic.List<System.Int64> curSelectedItemIdList; // 0x4d8
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> curSelectableItemAmountDic; // 0x4e0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.BaseItemNode> curSelectedItemNodeDic; // 0x4e8
	WizardGames.Soc.Common.Data.DataItem.ItemConfig curPopupSelectedItemCfg; // 0x4f0
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> itemNodes; // 0x4f8
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.GameVehicleOperate.ComVehicleAddPartIconBinder> listIconBinders; // 0x500
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComItemIconSimpleBinder> popupIconBinders; // 0x508
	System.Collections.Generic.List<System.Int64> tempSrcPath; // 0x510
	System.Collections.Generic.List<System.Int64> tempTargetPath; // 0x518
	System.Void OnInit(); // 0x06662ab0
	System.Void RegisterEvent(); // 0x06664120
	System.Void UnRegisterEvent(); // 0x06664730
	System.Void OnFps10Update(System.Single dt); // 0x066649b8
	System.Void CheckDis(); // 0x06664a38
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06664e0c
	System.Void OnEnable(); // 0x06665188
	UnityEngine.Rect GetHalfScreenHideArea(); // 0x06666384
	System.Void OnDisable(); // 0x066665d4
	System.Void OnDestroy(); // 0x06666f98
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x066673a0
	System.Void StartLoot(); // 0x066661b8
	System.Void StopLoot(); // 0x06666bc0
	System.Void RefreshAll(); // 0x066660cc
	System.Void UpdatePanelRollingAreaHeight(FairyGUI.GGroup vertical); // 0x06668a40
	System.Void OnItemNodeChange(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x06668e0c
	System.String GetDecayHungerTip(); // 0x06668fc4
	System.Void RefreshDecayHungerTip(); // 0x06664d00
	System.Void CloseDecayTip(); // 0x06666f38
	System.Void RenderAttributeNote(); // 0x0666745c
	System.Void RenderDefaultVehicleStatus(); // 0x066696b0
	System.Void RenderRowBoatVehicleStatus(); // 0x06669c24
	System.Single GetModuleFuelLevel(); // 0x0666acd8
	System.String GetAllModuleFunctionType(WizardGames.Soc.Common.Entity.IBaseMountableEntity entity); // 0x0666b02c
	System.Void RenderModularVehicleStatus(); // 0x0666a198
	System.Void RenderHorseVehicleStatus(); // 0x0666a694
	System.Void UpdateListHeight(FairyGUI.GList list); // 0x0666b5bc
	System.Void AttrListItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x0666b75c
	System.Void AttrLevelListItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x0666ba38
	System.String GetEntityDecayDes(WizardGames.Soc.Common.Entity.IBaseMountableEntity baseMountableEntity); // 0x066692d8
	System.Int32 GetTotalAttributeValue(WizardGames.Soc.SocClient.Ui.UiVehicleOperate.EAttrType attrType, WizardGames.Soc.Common.Entity.ModularCarEntity entity); // 0x0666b4ec
	WizardGames.Soc.Common.CustomType.VehicleModuleCustom GetModuleCustomByIndex(System.Int32 slotIndex, WizardGames.Soc.Common.Entity.ModularCarEntity entity); // 0x0666b400
	System.Int32 GetModuleAttributeValue(System.Int64 templateId, WizardGames.Soc.SocClient.Ui.UiVehicleOperate.EAttrType attrType); // 0x0666bbd0
	System.Void InitFuelUiData(); // 0x06665700
	System.Void InitFuelItemIdList(); // 0x0666bee0
	System.Void InitFuelIcon(); // 0x0666bd28
	System.Void RenderFuelNode(); // 0x06667804
	System.Void OpenRefuelWindow(); // 0x0666c0c8
	System.Boolean CheckPlayerFuelAmount(System.Int32& playerFuelAmount, System.Int32& vehicleAvalFuelAmount); // 0x0666c1d8
	System.Void OpenTakingOilOutWindow(); // 0x0666c75c
	System.Void UpdateFuelOwnedResAmount(); // 0x0666c594
	System.Void AutoRefuel(); // 0x0666c840
	System.Void InitFireUiData(); // 0x0666584c
	System.Void InitFireIcon(); // 0x0666cefc
	System.Void InitFireItemIdList(); // 0x0666d0b4
	System.Void RenderFireNode(); // 0x06667bc8
	System.Void OpenReFireWindow(); // 0x0666d294
	System.Boolean CheckPlayerFireAmount(System.Int32& playerFireAmount, System.Int32& vehicleAvaFireAmount); // 0x0666d3a0
	System.Void UpdateFireOwnedResAmount(); // 0x0666d75c
	System.Void OpenTakingFireOutWindow(); // 0x0666d924
	System.Void AutoReFire(); // 0x0666da08
	System.Void InitModuleUiData(); // 0x06665a2c
	System.Void GetModuleItemIdList(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap moduleContainer, System.Int32 pos); // 0x0666dbdc
	System.Void RenderEngineNode(); // 0x06668044
	System.Void ModuelContainerRender(System.Int32 index, FairyGUI.GObject obj); // 0x0666df58
	System.Void ModuelItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x0666e3e0
	System.Void OnModuelIconClick(FairyGUI.EventContext context); // 0x0666e7f4
	System.Void InitHorseGearUiData(); // 0x06665b48
	System.Void RenderHorseGearNode(); // 0x066683dc
	System.Void HorseGearItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x0666f2c8
	System.Void OnHorseGearIconClick(FairyGUI.EventContext context); // 0x0666f614
	System.Void SetupPopupWin(System.Collections.Generic.List<System.Int64> selectableList, WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap curContainer, System.Int32 curPos); // 0x0666eb14
	System.Void RenderPopupWin(FairyGUI.GObject targetObj, System.Boolean canRemove); // 0x0666eee0
	System.Void InitSelectedItemConfig(); // 0x066702d8
	System.Void SetPopupWinPos(FairyGUI.GObject targetObj); // 0x06670474
	System.Void PopupItemRender(System.Int32 index, FairyGUI.GObject item); // 0x0667109c
	System.Void RefreshSelectableItemDic(); // 0x0666f9bc
	System.Void SortItemIdsByCondition(); // 0x06670208
	System.Int32 IsHigherPriority(System.Int64 id1, System.Int64 id2); // 0x06670f08
	System.Void ClosePopupWindow(); // 0x06664f48
	System.Void OnEquipItemIconClick(FairyGUI.EventContext context); // 0x066716dc
	System.Void UpdatePopupCurSelectItem(FairyGUI.GComponent clickCom); // 0x06671824
	System.Void RefreshPopupListIconState(); // 0x066709e4
	System.Void RefreshBtnState(); // 0x06670c50
	System.Void OnEquipBtnClick(); // 0x066718b0
	System.Void OnUnEquipBtnClick(); // 0x06671c30
	System.Void UnEquip(); // 0x06672074
	System.Void SetAutoNextUtil(FairyGUI.GObject current, WizardGames.Soc.SocClient.Ui.UiVehicleOperate.ItemIconClickData clickData); // 0x0666ed00
	System.Void PopupShowItemTip(FairyGUI.GComponent clickCom); // 0x06670870
	System.Void PopupHideItemtip(); // 0x06666e9c
	System.Void SetAutoNext(FairyGUI.GObject next, FairyGUI.GList list); // 0x06671644
	System.Void CheckIfSelectNextAndDo(); // 0x06668eac
	System.Void AutoSelectNext(); // 0x066722b0
	System.Void GetStorageNowAndMax(System.Int32& nowV, System.Int32& maxV, System.Boolean refreshItemNode); // 0x06672348
	System.Void RenderStorageNode(); // 0x06668654
	System.Void StorageItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x066727ac
	System.Void OnOpenBtnClick(); // 0x06672944
	System.Void InventoryToOtherSide(System.Int64 itemNodeBizId, System.Int32 amount, System.Collections.Generic.IList<System.Int64> inventoryPathList, WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container, System.Int64 targetPos); // 0x0666ca14
	System.Void OtherSideToInventory(System.Int64 itemNodeBizId, System.Int32 amount, WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container, System.Int64 srcPos, System.Boolean withConfirm); // 0x06672a88
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x06672c80
	System.Void OnShowByLayerStack(); // 0x06672cfc
	System.Void .ctor(); // 0x06672d60
	System.Void <RegisterEvent>b__37_0(WizardGames.Soc.Share.Framework.CustomTypeBase _, System.Single __, System.Single ___); // 0x066735e4
	System.Void <RegisterEvent>b__37_1(WizardGames.Soc.Share.Framework.CustomTypeBase server, System.Single oldValue, System.Single newValue); // 0x06673678
	System.Void <RegisterEvent>b__37_2(WizardGames.Soc.Share.Framework.CustomTypeBase server, System.Single oldValue, System.Single newValue); // 0x0667370c
	System.Void <RegisterEvent>b__37_4(WizardGames.Soc.Share.Framework.CustomTypeBase server, System.Single oldValue, System.Single newValue); // 0x066737a0
	System.Void <RegisterEvent>b__37_5(WizardGames.Soc.Share.Framework.CustomTypeBase server, System.Single oldValue, System.Single newValue); // 0x06673834
	System.Void <RegisterEvent>b__37_3(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x066738c8
	System.Void <OnEnable>b__42_0(FairyGUI.EventContext _); // 0x0667395c
	System.Void <OnEnable>b__42_1(); // 0x066739d8
	System.Boolean <RenderPopupWin>b__128_0(); // 0x06673aac
	System.Void <OnUnEquipBtnClick>b__142_0(); // 0x06673b18
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiVehicleOperate.EBulletType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiVehicleOperate.EBulletType Normal = 0;
	static WizardGames.Soc.SocClient.Ui.UiVehicleOperate.EBulletType Bullet = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiVehicleOperate.AttributeItemRenderData : System.Object
{
	System.String attrName; // 0x10
	System.String attrValue; // 0x18
	System.Boolean showInLevel; // 0x20
	System.Int32 level; // 0x24
	System.Void .ctor(); // 0x06673f20
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiVehicleOperate.EAttrType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiVehicleOperate.EAttrType Durability = 0;
	static WizardGames.Soc.SocClient.Ui.UiVehicleOperate.EAttrType Speed = 1;
	static WizardGames.Soc.SocClient.Ui.UiVehicleOperate.EAttrType Defense = 2;
	static WizardGames.Soc.SocClient.Ui.UiVehicleOperate.EAttrType Function = 3;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiVehicleOperate.ItemIconClickData : System.ValueType
{
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap containerNode; // 0x10
	System.Int32 index; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiVehicleOperate.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiVehicleOperate.<>c <>9; // 0x0
	static System.Action <>9__154_0; // 0x8
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.GameVehicleOperate.ComVehicleAddPartIconBinder> <>9__165_0; // 0x10
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComItemIconSimpleBinder> <>9__165_1; // 0x18
	static System.Void .cctor(); // 0x06673f88
	System.Void .ctor(); // 0x06673fec
	System.Void <OnOpenBtnClick>b__154_0(); // 0x06674054
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicleOperate.ComVehicleAddPartIconBinder <.ctor>b__165_0(FairyGUI.GComponent c); // 0x066740e8
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComItemIconSimpleBinder <.ctor>b__165_1(FairyGUI.GComponent c); // 0x0667418c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiVehicleRefuel : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	SocLogger logger; // 0x338
	WizardGames.Soc.Common.CustomType.ItemContainerNode FuelContainer; // 0x340
	System.Collections.Generic.List<System.Int64> fuelAddResItemIdList; // 0x348
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> fuelOwnedResAmountDic; // 0x350
	System.Boolean IsTakingOutOil; // 0x358
	WizardGames.Soc.SocClient.Ui.UiVehicleOperate uiVehicleOperate; // 0x360
	WizardGames.Soc.Common.CustomType.BaseItemNode curVehicleFuelItem; // 0x368
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicleOperate.UiVehicleRefuelBinder rootBinder; // 0x370
	WizardGames.Soc.SocClient.Ui.Binder.GameVehicleOperate.ComVehicleRefuelPanelBinder panelBinder; // 0x378
	System.Void OnInit(); // 0x06674230
	System.Void OnFps10Update(System.Single dt); // 0x06674914
	System.Void OnEnable(); // 0x06675ce4
	System.Void OnDisable(); // 0x06675d44
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06675dd0
	System.Void SetupRefuelWinInfo(System.Boolean resetSliderValue); // 0x06674dd8
	System.Void SetupTakingOutOilWinInfo(System.Boolean resetSliderValue); // 0x06675494
	System.Void OnRefuelSliderValueChange(); // 0x06675a20
	System.Void AddFuelAmount(); // 0x06675e50
	System.Void SubFuelAmount(); // 0x06675fb4
	System.Void ConfirmRefuel(); // 0x06676118
	System.Void .ctor(); // 0x066764d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiVersionInfo : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	WizardGames.Soc.SocClient.Ui.UiComPhoneInfo phoneInfo; // 0x338
	FairyGUI.Controller CtrlWifi; // 0x340
	FairyGUI.GTextField TextEditionInfo; // 0x348
	FairyGUI.GTextField TextDesc; // 0x350
	FairyGUI.Controller showInHud; // 0x358
	System.Boolean showPhoneInfo; // 0x360
	System.Void OnInit(); // 0x066766b0
	System.Void OnFps1Update(System.Single dt); // 0x066771b8
	System.Void OnUiSettingChangeSafeArea(); // 0x066772b0
	System.String ReadVersion(); // 0x0667732c
	System.Void RefreshInfo(); // 0x06676b1c
	System.Void OnEnable(); // 0x066773b4
	System.Void OnDisable(); // 0x0667741c
	System.Void OnDestroy(); // 0x06677484
	System.Boolean IsAnyFullScreenOpen(); // 0x066775bc
	System.Void SetShowInHudIndex(System.Boolean show); // 0x066776b8
	System.Void .ctor(); // 0x0667785c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiVideoBox : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.UiVideoBoxContent uiVideoBoxContent; // 0x338
	System.Void .ctor(); // 0x066778e8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06677a18
	System.Void OnInit(); // 0x06677af4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiVideoBoxContent : System.Object
{
	WizardGames.Soc.Common.Unity.Ui.WindowComBase win; // 0x10
	FairyGUI.GComponent root; // 0x18
	FairyGUI.GTextField titleText; // 0x20
	FairyGUI.GButton closeBtn; // 0x28
	FairyGUI.GTextField desText; // 0x30
	System.Int32 curPageIndex; // 0x38
	FairyGUI.Transition showAnim; // 0x40
	FairyGUI.Transition hideAnim; // 0x48
	WizardGames.Soc.SocClient.Ui.ComVideo videoPlayer; // 0x50
	FairyGUI.GButton get_CloseBtn(); // 0x06677f7c
	System.Void OnInit(WizardGames.Soc.Common.Unity.Ui.WindowComBase winCom, FairyGUI.GComponent rootCom); // 0x06677bf0
	System.Void OnClickClose(); // 0x06677fe0
	System.Void SetActive(System.Boolean active); // 0x06678238
	System.Void PlayHideAnim(System.Action callback); // 0x066780a0
	System.Void .ctor(); // 0x066779a8
	System.Void <OnInit>b__11_0(FairyGUI.EventContext ctx); // 0x06678334
	System.Void <OnClickClose>b__12_0(); // 0x066783ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiVideoBoxContent.<>c__DisplayClass12_0 : System.Object
{
	System.String uiName; // 0x10
	System.Void .ctor(); // 0x066784fc
	System.Void <OnClickClose>b__1(System.Object obj); // 0x06678564
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiVideoBoxContent.<>c__DisplayClass16_0 : System.Object
{
	System.Action callback; // 0x10
	WizardGames.Soc.SocClient.Ui.UiVideoBoxContent <>4__this; // 0x18
	System.Void .ctor(); // 0x066782cc
	System.Void <PlayHideAnim>b__0(); // 0x0667861c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMic : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent comMicPanel; // 0x338
	FairyGUI.GButton btnFreeMircoAll; // 0x340
	FairyGUI.GButton btnFreeMircoTeam; // 0x348
	FairyGUI.GButton btnFreeMircoNone; // 0x350
	FairyGUI.GButton btnHoldMircoAll; // 0x358
	FairyGUI.GButton btnHoldMircoTeam; // 0x360
	FairyGUI.Controller btnControl; // 0x368
	WizardGames.Soc.SocClient.Ui.UiHudElemVoice mainBtn; // 0x370
	FairyGUI.GObject mainBtnBg; // 0x378
	System.Void OnInit(); // 0x066786a4
	System.Void OnHudBlockElemChange(); // 0x06678d2c
	System.Void OnListeningCloseWindow(UnityEngine.Vector2 uiPos); // 0x06678e60
	System.Void OnEnable(); // 0x06678f58
	System.Void OnDestroy(); // 0x06678fb8
	System.Void OpenGlobalMicroClick(); // 0x066792e0
	System.Void OpenGlobalMicroInternal(System.Boolean isSuccess); // 0x05523a7c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x066797a0
	System.Void CloseWindow(); // 0x06678d90
	System.Void OpenTeamMicroClick(); // 0x06679818
	System.Void OpenTeamMicroInternal(System.Boolean isSuccess); // 0x05523a7c
	System.Void SwitchHoldGlobalMicro(); // 0x06679d14
	System.Void SwitchHoldGlobalMicroInternal(System.Boolean isSuccess); // 0x06679f5c
	System.Void SwitchHoldTeamMicro(); // 0x0667a1a4
	System.Void SwitchHoldTeamMicroInternal(System.Boolean isSuccess); // 0x0667a428
	System.Void CloseMicClick(); // 0x0667a66c
	System.Void ChangeMainBtnIcon(System.Int32 index); // 0x0667924c
	System.Void .ctor(); // 0x0667a7ec
	System.Void <OnInit>b__11_0(FairyGUI.EventContext ctx); // 0x0667a878
	System.Void <OnInit>b__11_1(FairyGUI.EventContext ctx); // 0x0667a8f0
	System.Void <OnInit>b__11_2(FairyGUI.EventContext ctx); // 0x0667a968
	System.Void <OnInit>b__11_3(FairyGUI.EventContext ctx); // 0x0667a9e0
	System.Void <OnInit>b__11_4(FairyGUI.EventContext ctx); // 0x0667aa58
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSpeaker : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent comSpeakerPanel; // 0x338
	System.Collections.Generic.Dictionary<FairyGUI.GComponent,WizardGames.Soc.Common.Entity.TeammateSpeaker> dicTeamSpeakers; // 0x340
	FairyGUI.GList listSpeaker; // 0x348
	FairyGUI.ScrollPane listScrollPane; // 0x350
	FairyGUI.GButton btnFreeSpeakerAll; // 0x358
	FairyGUI.GButton btnFreeSpeakerTeam; // 0x360
	FairyGUI.GButton btnFreeSpeakerNone; // 0x368
	FairyGUI.GButton btnReport; // 0x370
	FairyGUI.Controller btnControl; // 0x378
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnSpeaker mainBtn; // 0x380
	FairyGUI.GObject mainBtnBg; // 0x388
	System.Single hideTipDownPer; // 0x390
	static System.String get_RetryJoinTeamSpeakerSelect(); // 0x0667aad0
	static System.String get_RetryJoinRangeSpeakerSelect(); // 0x0667ab88
	System.Void OnInit(); // 0x0667ac40
	System.Void OnHudBlockElemChange(); // 0x0667b6a0
	System.Void OnListeningCloseWindow(UnityEngine.Vector2 uiPos); // 0x0667b7d4
	System.Void OnEnable(); // 0x0667b8cc
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0667b92c
	System.Void CloseWindow(); // 0x0667b704
	System.Void ChangeMainBtnIcon(System.Int32 index); // 0x0667b9a4
	System.Void OnTeamMemberDictChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x0667ba38
	System.Void RefreshTeamView(); // 0x0667b3b4
	System.Void LoadTeammatesSpeaker(); // 0x0667bacc
	System.Void OnDestroy(); // 0x0667c718
	System.Void OpenTeamSpeakerClick(); // 0x055049cc
	System.Void OpenGlobalSpeakerClick(); // 0x055049cc
	System.Void CloseSpeakerClick(); // 0x055049cc
	System.Void .ctor(); // 0x0667cfc4
	System.Void <OnInit>b__18_0(FairyGUI.EventContext ctx); // 0x0667d09c
	System.Void <OnInit>b__18_1(FairyGUI.EventContext ctx); // 0x0667d11c
	System.Void <OnInit>b__18_2(FairyGUI.EventContext ctx); // 0x0667d19c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSpeaker.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiSpeaker.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__18_3; // 0x8
	static System.Void .cctor(); // 0x0667d21c
	System.Void .ctor(); // 0x0667d280
	System.Void <OnInit>b__18_3(FairyGUI.EventContext ctx); // 0x0667d2e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSpeaker.<>c__DisplayClass27_0 : System.Object
{
	FairyGUI.GTextField textName; // 0x10
	WizardGames.Soc.Common.CustomType.TeamMemberInfo teamMemberData; // 0x18
	FairyGUI.GSlider sliderBar; // 0x20
	WizardGames.Soc.Common.Entity.TeammateSpeaker teammateSpeaker; // 0x28
	FairyGUI.GButton btnMute; // 0x30
	System.Void .ctor(); // 0x0667c6b0
	System.Void <LoadTeammatesSpeaker>b__0(Config.LobbyRoleInfo userInfo); // 0x0667d530
	System.Void <LoadTeammatesSpeaker>b__1(); // 0x0667d5c8
	System.Void <LoadTeammatesSpeaker>b__2(); // 0x0667d878
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDetailedDataBinder : System.Object
{
	FairyGUI.GComponent _content; // 0x10
	FairyGUI.GComponent _titleList; // 0x18
	FairyGUI.GList _list; // 0x20
	WizardGames.Soc.SocClient.Ui.ComTopBar _topBar; // 0x28
	System.Int64 _listAnimationTimerId; // 0x30
	System.String _battleServerId; // 0x38
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x40
	FairyGUI.GComponent <Root>k__BackingField; // 0x48
	System.Void set_BinderRoot(FairyGUI.GComponent value); // 0x0667daac
	FairyGUI.GComponent get_Root(); // 0x0667db2c
	System.Void set_Root(FairyGUI.GComponent value); // 0x0667db90
	System.Void .ctor(FairyGUI.GComponent root); // 0x0667dc10
	System.Void List(System.String battleServerId); // 0x0667e164
	System.Void TitleList(); // 0x0667dfbc
	System.Void ShowInfo(); // 0x0667e1e4
	System.Void ListAnimation(System.Int32 index, FairyGUI.GComponent com); // 0x0667e830
	System.Void Clear(); // 0x0667e72c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDetailedDataBinder.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiDetailedDataBinder.<>c <>9; // 0x0
	static FairyGUI.ListItemRenderer <>9__16_0; // 0x8
	static System.Predicate<WizardGames.Soc.Common.SimpleCustom.GameEndResultDetailData> <>9__17_0; // 0x10
	static System.Void .cctor(); // 0x0667e8f0
	System.Void .ctor(); // 0x0667e954
	System.Void <TitleList>b__16_0(System.Int32 index, FairyGUI.GObject item); // 0x0667e9bc
	System.Boolean <ShowInfo>b__17_0(WizardGames.Soc.Common.SimpleCustom.GameEndResultDetailData data); // 0x0667ecd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDetailedDataBinder.<>c__DisplayClass17_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiDetailedDataBinder <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.LobbyBattleServerData lobbyBattleServerData; // 0x18
	System.Void .ctor(); // 0x0667e6c4
	System.Void <ShowInfo>b__1(SimpleJSON.JSONArray jsonArray); // 0x0667ed98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDetailedDataBinder.<>c__DisplayClass17_1 : System.Object
{
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Manager.LobbyPlayerInfoData> playerInfoDict; // 0x10
	WizardGames.Soc.SocClient.Ui.UiDetailedDataBinder.<>c__DisplayClass17_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x0667f2dc
	System.Void <ShowInfo>b__2(System.Int32 index, FairyGUI.GObject item); // 0x0667f344
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDetailedDataBinder.<>c__DisplayClass17_2 : System.Object
{
	System.Int32 index; // 0x10
	WizardGames.Soc.SocClient.Ui.UiDetailedDataBinder.<>c__DisplayClass17_1 CS$<>8__locals2; // 0x18
	System.Void .ctor(); // 0x0667f6c4
	System.Void <ShowInfo>b__3(System.Int32 subIndex, FairyGUI.GObject subItem); // 0x0667f72c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDetailedData : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.UiDetailedDataBinder _binder; // 0x338
	System.Void OnInit(); // 0x0667fb14
	System.Void OnShowAnimFinish(); // 0x0667fca8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0667fd10
	System.Void OnDisable(); // 0x0667fddc
	static WizardGames.Soc.SocClient.Ui.UiDetailedData ShowDetailedData(System.String battleServerId); // 0x0667fe5c
	System.Void SetInfo(System.String battleServerId); // 0x0668001c
	System.Void .ctor(); // 0x066800fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDetailedData.<>c__DisplayClass5_0 : System.Object
{
	System.String battleServerId; // 0x10
	System.Void .ctor(); // 0x0667ffb4
	System.Void <ShowDetailedData>b__0(WizardGames.Soc.SocClient.Ui.UiDetailedData win); // 0x06680188
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.WarSituationBinder : System.Object
{
	static SocLogger logger; // 0x0
	FairyGUI.Transition Appear; // 0x10
	System.String BattleServerId; // 0x18
	FairyGUI.GComponent ComDecodeTitle; // 0x20
	FairyGUI.GTextField Title; // 0x28
	FairyGUI.GTextField IntelligenceTitle; // 0x30
	FairyGUI.GTextField IntelligenceContent; // 0x38
	FairyGUI.GTextField TimeTitle; // 0x40
	FairyGUI.GTextField TimeContent; // 0x48
	FairyGUI.GTextField Anking; // 0x50
	FairyGUI.GList _list; // 0x58
	FairyGUI.GComponent _reward; // 0x60
	FairyGUI.GList _itemList; // 0x68
	FairyGUI.GButton _btnData; // 0x70
	FairyGUI.GComponent playerInformation; // 0x78
	FairyGUI.GComponent taskInformation; // 0x80
	FairyGUI.GList InformationList; // 0x88
	System.Collections.Generic.List<System.Int64> _levelRewards; // 0x90
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.common.BTuple2> _rewardList; // 0x98
	FairyGUI.GComponent Time; // 0xa0
	FairyGUI.GButton SkipBtn; // 0xa8
	FairyGUI.GButton <NextStep>k__BackingField; // 0xb0
	FairyGUI.GComponent <Root>k__BackingField; // 0xb8
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0xc0
	FairyGUI.GButton get_NextStep(); // 0x0668020c
	System.Void set_NextStep(FairyGUI.GButton value); // 0x06680270
	System.Void .ctor(FairyGUI.GComponent root); // 0x066802f0
	System.Void OnItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x06680ff0
	System.Void ShowDetailedData(FairyGUI.EventContext context); // 0x066813b8
	System.Void TaskInformation(FairyGUI.GComponent taskInformation); // 0x06680df4
	System.Void TaskInformationList(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.GameEndResultDetailData> detailDatas, System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Manager.LobbyPlayerInfoData> playerInfoDict); // 0x06681430
	System.Void OnClickShareBtn(FairyGUI.EventContext context); // 0x066815e4
	System.Void ShareCallback(); // 0x0668170c
	System.Void PlayerInformation(FairyGUI.GComponent playerInformation); // 0x06680b28
	FairyGUI.GComponent get_Root(); // 0x0668176c
	System.Void set_Root(FairyGUI.GComponent value); // 0x066817d0
	System.Void set_BinderRoot(FairyGUI.GComponent value); // 0x06681850
	System.Void RefreshStoryStageStage(WizardGames.Soc.Common.SimpleCustom.GameEndResultDetailData detailData, System.Int32 modeId); // 0x066818d0
	static System.Void .cctor(); // 0x06681b78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.WarSituationBinder.<>c__DisplayClass26_0 : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJGenaral itemCfg; // 0x10
	System.Void .ctor(); // 0x06681350
	System.Void <OnItemRenderer>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x06681c4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.WarSituationBinder.<>c__DisplayClass29_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.GameEndResultDetailData> detailDatas; // 0x10
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Manager.LobbyPlayerInfoData> playerInfoDict; // 0x18
	System.Void .ctor(); // 0x0668157c
	System.Void <TaskInformationList>b__0(System.Int32 index, FairyGUI.GObject item); // 0x06681d50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.WarSituationBinder.<>c__DisplayClass29_1 : System.Object
{
	WizardGames.Soc.SocClient.Manager.LobbyPlayerInfoData playerInfo; // 0x10
	System.Void .ctor(); // 0x06682104
	System.Void <TaskInformationList>b__1(); // 0x0668216c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWarSituation : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger Logger; // 0x0
	WizardGames.Soc.SocClient.Ui.WarSituationBinder _binder; // 0x338
	System.String _battleServerId; // 0x340
	System.Int64 _medalListAnimationTimerId; // 0x348
	System.Int64 _rewardListAnimationTimerId; // 0x350
	WizardGames.Soc.SocClient.Ui.Binder.LobbyWarSituation.ComNewRootBinder _effect; // 0x358
	WizardGames.Soc.SocClient.Ui.LobbyBattleServerData _lobbyBattleServerData; // 0x360
	WizardGames.Soc.Common.SimpleCustom.GameEndResultDetailData _detailData; // 0x368
	System.Void OnInit(); // 0x06682244
	System.Void OnDisable(); // 0x06682500
	System.Void Clear(); // 0x06682570
	System.Void ClearTimer(); // 0x066825d4
	System.Void MedalListAnimation(System.Int32 index, FairyGUI.GComponent com); // 0x06682768
	System.Void OnMedalListAnimationComplete(); // 0x06682900
	System.Void RewardListAnimation(System.Int32 index, FairyGUI.GComponent com); // 0x06682a68
	System.Void SetInfo(System.String battleServerId); // 0x06682b88
	System.Void ShowInfo(); // 0x06682cc0
	System.String GetTitle(System.Int64 reputationLevel); // 0x06683d08
	System.Void OnClickNextStepBtn(FairyGUI.EventContext context); // 0x06683e00
	static WizardGames.Soc.SocClient.Ui.UiWarSituation ShowWarSituation(System.String battleServerId); // 0x06683ef0
	System.Void .ctor(); // 0x06683fe0
	static System.Void .cctor(); // 0x0668406c
	System.Void <SetInfo>b__15_0(); // 0x06684140
	System.Void <ShowInfo>b__16_1(System.Int32 index, FairyGUI.GObject item); // 0x06684264
	System.Void <ShowInfo>b__16_2(SimpleJSON.JSONArray jsonArray); // 0x06684448
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWarSituation.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiWarSituation.<>c <>9; // 0x0
	static System.Predicate<WizardGames.Soc.Common.SimpleCustom.GameEndResultDetailData> <>9__16_0; // 0x8
	static System.Void .cctor(); // 0x066848bc
	System.Void .ctor(); // 0x06684920
	System.Boolean <ShowInfo>b__16_0(WizardGames.Soc.Common.SimpleCustom.GameEndResultDetailData data); // 0x06684988
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWaterMark : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	FairyGUI.GList WaterMarkList; // 0x338
	System.Boolean IsInGame; // 0x340
	System.Collections.Generic.List<FairyGUI.GTextField> listTexts; // 0x348
	System.Void OnInit(); // 0x06684a50
	System.Void OnDestroy(); // 0x06685088
	System.Void RefreshRoleId(); // 0x06684e4c
	System.Void OnFps1Update(System.Single dt); // 0x066850f0
	System.Void SetColor(System.UInt32 color); // 0x06684bf4
	System.Void .ctor(); // 0x06685164
}
