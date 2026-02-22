	static SocLogger <logger>k__BackingField; // 0x8
	System.Type currentRunningCase; // 0x30
	static System.Collections.Generic.List<System.Type> CaseSelectList; // 0x10
	static SocLogger get_logger(); // 0x0780cb6c
	static System.Void set_logger(SocLogger value); // 0x0780cbf4
	static System.Boolean StartAutomationOrNot(); // 0x0780cc88
	System.Collections.Generic.List<System.String> GetTestCases(); // 0x0780cd08
	System.Collections.IEnumerator RunTestCases(System.Collections.Generic.List<System.Type> caseTypes, System.String runJson, System.String serverName, System.String botBranch); // 0x0780cf34
	System.Type GetRunningCase(); // 0x0780d054
	System.Void Start(); // 0x0780d0b8
	System.Void StartTestCases(System.Collections.Generic.List<System.Type> cases, System.String runJson, System.String serverName, System.String botBranch); // 0x0780d258
	System.Void .ctor(); // 0x0780d314
	static System.Void .cctor(); // 0x0780d37c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.MainTest.<RunTestCases>d__9 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.Collections.Generic.List<System.Type> caseTypes; // 0x20
	WizardGames.Soc.SocClient.Test.Automation.MainTest <>4__this; // 0x28
	System.String serverName; // 0x30
	System.String runJson; // 0x38
	System.String botBranch; // 0x40
	System.Int32 <caseIndex>5__2; // 0x48
	System.Void .ctor(System.Int32 <>1__state); // 0x0780db38
	System.Void System.IDisposable.Dispose(); // 0x0780dbbc
	System.Boolean MoveNext(); // 0x0780dc1c
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0780e108
	System.Void System.Collections.IEnumerator.Reset(); // 0x0780e16c
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0780e1f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase : UnityEngine.MonoBehaviour
{
	System.Exception e; // 0x30
	static WizardGames.Soc.SocClient.Test.Common.TestLog Log; // 0x0
	static System.Collections.Generic.Dictionary<System.String,System.String> BaseTestCaseParameters; // 0x8
	static System.String[] KeySteps; // 0x10
	System.Collections.IEnumerator InvokeByAttribute(System.Reflection.MethodInfo methodInfo, System.Type attributeType, System.Object[] args); // 0x0780e258
	System.Collections.IEnumerator CallFunctionByName(System.String functionName, System.Type attributeType, System.Object[] args); // 0x0780e3e0
	System.Object[] ConstructParameters(System.Reflection.MethodInfo methodInfo, System.String serverName, System.String botBranch); // 0x0780e568
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>>> GetExecutionOrder(System.Int32 caseIndex, System.Int32 casesCount, System.String serverName, System.String botBranch); // 0x0780eb8c
	System.Collections.IEnumerator Run(System.Int32 caseIndex, System.Int32 casesCount, System.String runJson, System.String serverName, System.String botBranch); // 0x0780dfe4
	System.Collections.IEnumerator SetUp(System.String account, System.String serverName, System.Int32 serverIndex); // 0x0780f314
	System.Collections.IEnumerator TearDown(); // 0x0780f480
	System.Void Start(); // 0x0780f590
	System.Void .ctor(); // 0x0780f640
	static System.Void .cctor(); // 0x0780f6a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase.<>c <>9; // 0x0
	static System.Converter<System.Object,WizardGames.Soc.SocClient.Test.Automation.Helper.BaseAttrAttribute> <>9__4_0; // 0x8
	static System.Func<System.String,System.String> <>9__7_0; // 0x10
	static System.Func<System.String,System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>>> <>9__7_1; // 0x18
	static System.Void .cctor(); // 0x0780f8d0
	System.Void .ctor(); // 0x0780f934
	WizardGames.Soc.SocClient.Test.Automation.Helper.BaseAttrAttribute <InvokeByAttribute>b__4_0(System.Object obj); // 0x0780f99c
	System.String <GetExecutionOrder>b__7_0(System.String step); // 0x0780fa60
	System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>> <GetExecutionOrder>b__7_1(System.String step); // 0x0780fad8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase.<CallFunctionByName>d__5 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase <>4__this; // 0x20
	System.String functionName; // 0x28
	System.Type attributeType; // 0x30
	System.Object[] args; // 0x38
	System.Void .ctor(System.Int32 <>1__state); // 0x0780e4e4
	System.Void System.IDisposable.Dispose(); // 0x0780fb8c
	System.Boolean MoveNext(); // 0x0780fbec
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0780fd64
	System.Void System.Collections.IEnumerator.Reset(); // 0x0780fdc8
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0780fe50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase.<InvokeByAttribute>d__4 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.Reflection.MethodInfo methodInfo; // 0x20
	System.Type attributeType; // 0x28
	System.Object[] args; // 0x30
	WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase <>4__this; // 0x38
	WizardGames.Soc.SocClient.Test.Automation.Helper.BaseAttrAttribute[] <realAttributes>5__2; // 0x40
	WizardGames.Soc.SocClient.Test.Automation.Helper.BaseAttrAttribute[] <>7__wrap2; // 0x48
	System.Int32 <>7__wrap3; // 0x50
	System.Void .ctor(System.Int32 <>1__state); // 0x0780e35c
	System.Void System.IDisposable.Dispose(); // 0x0780feb4
	System.Boolean MoveNext(); // 0x0780ff14
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07810290
	System.Void System.Collections.IEnumerator.Reset(); // 0x078102f4
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0781037c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase.<Run>d__8 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase <>4__this; // 0x20
	System.Int32 caseIndex; // 0x28
	System.Int32 casesCount; // 0x2c
	System.String serverName; // 0x30
	System.String botBranch; // 0x38
	System.String runJson; // 0x40
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>>> <executionOrder>5__2; // 0x48
	System.String[] <>7__wrap2; // 0x50
	System.Int32 <>7__wrap3; // 0x58
	System.String <step>5__5; // 0x60
	System.Collections.Generic.List.Enumerator<System.Collections.Generic.Dictionary<System.String,System.Object>> <>7__wrap5; // 0x68
	System.Void .ctor(System.Int32 <>1__state); // 0x0780f290
	System.Void System.IDisposable.Dispose(); // 0x078103e0
	System.Boolean MoveNext(); // 0x07810474
	System.Void <>m__Finally1(); // 0x07810aa4
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07810b28
	System.Void System.Collections.IEnumerator.Reset(); // 0x07810b8c
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07810c14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase.<SetUp>d__9 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.String serverName; // 0x20
	System.String account; // 0x28
	System.Int32 serverIndex; // 0x30
	System.Void .ctor(System.Int32 <>1__state); // 0x0780f3fc
	System.Void System.IDisposable.Dispose(); // 0x07810c78
	System.Boolean MoveNext(); // 0x07810cd8
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07810ef4
	System.Void System.Collections.IEnumerator.Reset(); // 0x07810f58
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07810fe0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase.<TearDown>d__10 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.Void .ctor(System.Int32 <>1__state); // 0x0780f50c
	System.Void System.IDisposable.Dispose(); // 0x07811044
	System.Boolean MoveNext(); // 0x078110a4
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07811308
	System.Void System.Collections.IEnumerator.Reset(); // 0x0781136c
	System.Object System.Collections.IEnumerator.get_Current(); // 0x078113f4
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Test.Automation.TestCases.DeployInfo : System.ValueType
{
	System.Int32 id; // 0x10
	System.String name; // 0x18
	System.Boolean inside; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.BuildingTastCase : WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase
{
	System.Boolean canTest; // 0x38
	System.Collections.IEnumerator Deploy(); // 0x07811458
	System.Void OpenFoundationUI(); // 0x07811580
	System.Void CloseFoundationUI(); // 0x0781169c
	System.Collections.IEnumerator BuildFoundation(); // 0x078117b8
	System.Collections.IEnumerator TestFoundation(); // 0x078118e0
	System.Collections.IEnumerator RunBuildTest(WizardGames.Soc.SocClient.Test.Automation.TestCases.DeployInfo info); // 0x07811a08
	System.Boolean FindDeployableParts(System.String name); // 0x07811b78
	System.Void TryBuild(); // 0x07811e2c
	UnityEngine.MeshRenderer GetFoundationMeshRender(); // 0x07811f00
	UnityEngine.MeshRenderer GetDeploymentMeshRender(System.String buildingName); // 0x07812078
	UnityEngine.MeshRenderer FindChildWithMeshRender(UnityEngine.Transform parent); // 0x078121d8
	System.Boolean TestBuildAble(UnityEngine.MeshRenderer meshRenderer); // 0x0781239c
	System.Collections.IEnumerator SetUp(System.String account, System.String serverName, System.Int32 serverIndex); // 0x078124a0
	System.Collections.IEnumerator BuildingTest(); // 0x0781260c
	System.Void .ctor(); // 0x07812734
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.BuildingTastCase.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Test.Automation.TestCases.BuildingTastCase.<>c <>9; // 0x0
	static System.Func<System.Boolean> <>9__1_0; // 0x8
	static System.Void .cctor(); // 0x078127c4
	System.Void .ctor(); // 0x07812828
	System.Boolean <Deploy>b__1_0(); // 0x07812890
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.BuildingTastCase.<BuildFoundation>d__4 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.BuildingTastCase <>4__this; // 0x20
	System.Void .ctor(System.Int32 <>1__state); // 0x0781185c
	System.Void System.IDisposable.Dispose(); // 0x07812928
	System.Boolean MoveNext(); // 0x078129b0
	System.Void <>m__Finally1(); // 0x07812c14
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07812c88
	System.Void System.Collections.IEnumerator.Reset(); // 0x07812cec
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07812d74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.BuildingTastCase.<BuildingTest>d__14 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.BuildingTastCase <>4__this; // 0x20
	System.Void .ctor(System.Int32 <>1__state); // 0x078126b0
	System.Void System.IDisposable.Dispose(); // 0x07812dd8
	System.Boolean MoveNext(); // 0x07812e38
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07812ef0
	System.Void System.Collections.IEnumerator.Reset(); // 0x07812f54
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07812fdc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.BuildingTastCase.<Deploy>d__1 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.BuildingTastCase <>4__this; // 0x20
	UnityEngine.Vector3 <pos>5__2; // 0x28
	System.Collections.Generic.List.Enumerator<WizardGames.Soc.SocClient.Test.Automation.TestCases.DeployInfo> <>7__wrap2; // 0x38
	System.Void .ctor(System.Int32 <>1__state); // 0x078114fc
	System.Void System.IDisposable.Dispose(); // 0x07813040
	System.Boolean MoveNext(); // 0x078130c4
	System.Void <>m__Finally1(); // 0x0781486c
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x078148f0
	System.Void System.Collections.IEnumerator.Reset(); // 0x07814954
	System.Object System.Collections.IEnumerator.get_Current(); // 0x078149dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.BuildingTastCase.<RunBuildTest>d__6 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.DeployInfo info; // 0x20
	WizardGames.Soc.SocClient.Test.Automation.TestCases.BuildingTastCase <>4__this; // 0x38
	System.Int32 <buildID>5__2; // 0x40
	System.String <buildName>5__3; // 0x48
	System.Int32 <index>5__4; // 0x50
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcuts <shortChut>5__5; // 0x58
	System.Single <endPitch>5__6; // 0x60
	System.Void .ctor(System.Int32 <>1__state); // 0x07811af4
	System.Void System.IDisposable.Dispose(); // 0x07814a40
	System.Boolean MoveNext(); // 0x07814aa0
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07815bbc
	System.Void System.Collections.IEnumerator.Reset(); // 0x07815c20
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07815ca8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.BuildingTastCase.<SetUp>d__13 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.String account; // 0x20
	System.String serverName; // 0x28
	System.Int32 serverIndex; // 0x30
	System.Void .ctor(System.Int32 <>1__state); // 0x07812588
	System.Void System.IDisposable.Dispose(); // 0x07815d0c
	System.Boolean MoveNext(); // 0x07815d6c
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07815ed8
	System.Void System.Collections.IEnumerator.Reset(); // 0x07815f3c
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07815fc4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.BuildingTastCase.<TestFoundation>d__5 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.BuildingTastCase <>4__this; // 0x20
	System.Single <endPitch>5__2; // 0x28
	System.Void .ctor(System.Int32 <>1__state); // 0x07811984
	System.Void System.IDisposable.Dispose(); // 0x07816028
	System.Boolean MoveNext(); // 0x078160bc
	System.Void <>m__Finally1(); // 0x07816548
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x078165bc
	System.Void System.Collections.IEnumerator.Reset(); // 0x07816620
	System.Object System.Collections.IEnumerator.get_Current(); // 0x078166a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.ControlingBagTestCase : WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase
{
	
	System.Collections.IEnumerator ControlBag(); // 0x0781670c
	System.Collections.IEnumerator SetUp(System.String account, System.String serverName, System.Int32 serverIndex); // 0x0781681c
	System.Collections.IEnumerator ControlBgaTest(); // 0x07816988
	System.Void .ctor(); // 0x07816ab0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.ControlingBagTestCase.<>c__DisplayClass0_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode mainitemtargetNode; // 0x10
	WizardGames.Soc.Common.CustomType.BaseItemNode throwNode; // 0x18
	System.Void .ctor(); // 0x07816b38
	System.Boolean <ControlBag>b__0(); // 0x07816ba0
	System.Boolean <ControlBag>b__1(); // 0x07816cc4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.ControlingBagTestCase.<>c__DisplayClass0_1 : System.Object
{
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container; // 0x10
	WizardGames.Soc.Common.CustomType.BaseItemNode itemtargetNode; // 0x18
	System.Void .ctor(); // 0x07816de8
	System.Boolean <ControlBag>b__2(); // 0x07816e50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.ControlingBagTestCase.<>c__DisplayClass0_2 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode itemtargetNode1; // 0x10
	System.Void .ctor(); // 0x07816f88
	System.Boolean <ControlBag>b__3(); // 0x07816ff0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.ControlingBagTestCase.<ControlBag>d__0 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.ControlingBagTestCase.<>c__DisplayClass0_1 <>8__1; // 0x20
	WizardGames.Soc.SocClient.Test.Automation.TestCases.ControlingBagTestCase.<>c__DisplayClass0_2 <>8__2; // 0x28
	WizardGames.Soc.SocClient.Test.Automation.TestCases.ControlingBagTestCase.<>c__DisplayClass0_0 <>8__3; // 0x30
	FairyGUI.GTextField <hungertext>5__2; // 0x38
	System.Int32 <fontstatus>5__3; // 0x40
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap <containerBelt>5__4; // 0x48
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap <containerMain>5__5; // 0x50
	System.Int32 <j>5__6; // 0x58
	FairyGUI.GComponent <contentPane>5__7; // 0x60
	System.Collections.Generic.List.Enumerator<WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap> <>7__wrap7; // 0x68
	System.Void .ctor(System.Int32 <>1__state); // 0x07816798
	System.Void System.IDisposable.Dispose(); // 0x07817114
	System.Boolean MoveNext(); // 0x0781719c
	System.Void <>m__Finally1(); // 0x07818e28
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07818eac
	System.Void System.Collections.IEnumerator.Reset(); // 0x07818f10
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07818f98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.ControlingBagTestCase.<ControlBgaTest>d__2 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.ControlingBagTestCase <>4__this; // 0x20
	System.Void .ctor(System.Int32 <>1__state); // 0x07816a2c
	System.Void System.IDisposable.Dispose(); // 0x07818ffc
	System.Boolean MoveNext(); // 0x0781905c
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07819114
	System.Void System.Collections.IEnumerator.Reset(); // 0x07819178
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07819200
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.ControlingBagTestCase.<SetUp>d__1 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.String account; // 0x20
	System.String serverName; // 0x28
	System.Int32 serverIndex; // 0x30
	System.Void .ctor(System.Int32 <>1__state); // 0x07816904
	System.Void System.IDisposable.Dispose(); // 0x07819264
	System.Boolean MoveNext(); // 0x078192c4
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x078193ac
	System.Void System.Collections.IEnumerator.Reset(); // 0x07819410
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07819498
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.CraftTestCase : WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase
{
	
	System.Collections.IEnumerator Craft(); // 0x078194fc
	System.Void .ctor(); // 0x0781960c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.CraftTestCase.<Craft>d__0 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.Void .ctor(System.Int32 <>1__state); // 0x07819588
	System.Void System.IDisposable.Dispose(); // 0x07819694
	System.Boolean MoveNext(); // 0x078196f4
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07819a00
	System.Void System.Collections.IEnumerator.Reset(); // 0x07819a64
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07819aec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.GatheringTestCase : WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase
{
	
	System.Collections.IEnumerator MoveAndGather(); // 0x07819b50
	System.Collections.IEnumerator Gather(WizardGames.Soc.SocClient.Test.Automation.TestCases.GatheringTestCase.GatherInfo info); // 0x07819c78
	System.Collections.IEnumerator SetUp(System.String account, System.String serverName, System.Int32 serverIndex); // 0x07819dc4
	System.Collections.IEnumerator MoveAndGatherTest(); // 0x07819f30
	System.Void .ctor(); // 0x0781a058
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Test.Automation.TestCases.GatheringTestCase.GatherInfo : System.ValueType
{
	System.Int32 id; // 0x10
	System.Int32 num; // 0x14
	System.Int32 entityType; // 0x18
	System.Int32 index; // 0x1c
	System.String name; // 0x20
	System.Int32 resourseId; // 0x28
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.GatheringTestCase.<>c__DisplayClass1_0 : System.Object
{
	System.Single result; // 0x10
	System.Void .ctor(); // 0x0781a0e0
	System.Boolean <MoveAndGather>b__0(); // 0x0781a148
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.GatheringTestCase.<Gather>d__2 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.GatheringTestCase.GatherInfo info; // 0x20
	System.String <testname>5__2; // 0x40
	System.Int32 <resourseId>5__3; // 0x48
	System.Int32 <totalnum>5__4; // 0x4c
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcuts <shortChut>5__5; // 0x50
	System.Void .ctor(System.Int32 <>1__state); // 0x07819d40
	System.Void System.IDisposable.Dispose(); // 0x0781a274
	System.Boolean MoveNext(); // 0x0781a2d4
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0781a9c0
	System.Void System.Collections.IEnumerator.Reset(); // 0x0781aa24
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0781aaac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.GatheringTestCase.<MoveAndGather>d__1 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.GatheringTestCase.<>c__DisplayClass1_0 <>8__1; // 0x20
	WizardGames.Soc.SocClient.Test.Automation.TestCases.GatheringTestCase <>4__this; // 0x28
	UnityEngine.Vector3 <player_position_beforewalk>5__2; // 0x30
	System.Int32 <i>5__3; // 0x3c
	System.Collections.Generic.List.Enumerator<WizardGames.Soc.SocClient.Test.Automation.TestCases.GatheringTestCase.GatherInfo> <>7__wrap3; // 0x40
	System.Void .ctor(System.Int32 <>1__state); // 0x07819bf4
	System.Void System.IDisposable.Dispose(); // 0x0781ab10
	System.Boolean MoveNext(); // 0x0781ab94
	System.Void <>m__Finally1(); // 0x0781b698
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0781b71c
	System.Void System.Collections.IEnumerator.Reset(); // 0x0781b780
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0781b808
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.GatheringTestCase.<MoveAndGatherTest>d__4 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.GatheringTestCase <>4__this; // 0x20
	System.Void .ctor(System.Int32 <>1__state); // 0x07819fd4
	System.Void System.IDisposable.Dispose(); // 0x0781b86c
	System.Boolean MoveNext(); // 0x0781b8cc
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0781b984
	System.Void System.Collections.IEnumerator.Reset(); // 0x0781b9e8
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0781ba70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.GatheringTestCase.<SetUp>d__3 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.String account; // 0x20
	System.String serverName; // 0x28
	System.Int32 serverIndex; // 0x30
	System.Void .ctor(System.Int32 <>1__state); // 0x07819eac
	System.Void System.IDisposable.Dispose(); // 0x0781bad4
	System.Boolean MoveNext(); // 0x0781bb34
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0781bc1c
	System.Void System.Collections.IEnumerator.Reset(); // 0x0781bc80
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0781bd08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.PosAndRot : System.Object
{
	UnityEngine.Vector3 <Position>k__BackingField; // 0x10
	UnityEngine.Vector3 <Rotation>k__BackingField; // 0x1c
	UnityEngine.Vector3 get_Position(); // 0x0781bd6c
	System.Void set_Position(UnityEngine.Vector3 value); // 0x0781bdd0
	UnityEngine.Vector3 get_Rotation(); // 0x0781be68
	System.Void set_Rotation(UnityEngine.Vector3 value); // 0x0781becc
	System.Void .ctor(); // 0x0781bf64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.PerformanceTestCase : WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase
{
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<WizardGames.Soc.SocClient.Test.Automation.TestCases.PosAndRot>> buildingPoints; // 0x38
	static System.Collections.IEnumerator WakeUp(); // 0x07815e54
	System.Single PitchAngleTranslater(System.Single x); // 0x0781c050
	System.Collections.IEnumerator BuildTest(); // 0x0781c0e4
	System.Collections.IEnumerator MapTest(); // 0x0781c20c
	System.Boolean GetSurfacePosition(UnityEngine.Vector3& worldPos); // 0x0781c334
	System.Collections.IEnumerator LookRound(); // 0x0781c4e4
	System.Collections.IEnumerator PerformanceSetUp(); // 0x0781c5f4
	System.Collections.IEnumerator LoginAndShoot(); // 0x0781c704
	System.Void .ctor(); // 0x0781c82c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.PerformanceTestCase.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Test.Automation.TestCases.PerformanceTestCase.<>c <>9; // 0x0
	static System.Func<System.Boolean> <>9__1_0; // 0x8
	static System.Void .cctor(); // 0x0781cb00
	System.Void .ctor(); // 0x0781cb64
	System.Boolean <WakeUp>b__1_0(); // 0x0781cbcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.PerformanceTestCase.<BuildTest>d__3 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.PerformanceTestCase <>4__this; // 0x20
	UnityEngine.Vector3 <point>5__2; // 0x28
	System.Collections.Generic.Dictionary.Enumerator<System.Int32,UnityEngine.GameObject> <>7__wrap2; // 0x38
	UnityEngine.GameObject <go>5__4; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Test.Automation.TestCases.PosAndRot> <posList>5__5; // 0x68
	System.Int32 <index>5__6; // 0x70
	System.Collections.Generic.List.Enumerator<WizardGames.Soc.SocClient.Test.Automation.TestCases.PosAndRot> <>7__wrap6; // 0x78
	WizardGames.Soc.SocClient.Test.Automation.TestCases.PosAndRot <pos>5__8; // 0x90
	System.Int32 <i>5__9; // 0x98
	System.Void .ctor(System.Int32 <>1__state); // 0x0781c188
	System.Void System.IDisposable.Dispose(); // 0x0781cc64
	System.Boolean MoveNext(); // 0x0781cd6c
	System.Void <>m__Finally1(); // 0x078277a0
	System.Void <>m__Finally2(); // 0x0782771c
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07827824
	System.Void System.Collections.IEnumerator.Reset(); // 0x07827888
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07827910
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.PerformanceTestCase.<LoginAndShoot>d__8 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.PerformanceTestCase <>4__this; // 0x20
	System.Void .ctor(System.Int32 <>1__state); // 0x0781c7a8
	System.Void System.IDisposable.Dispose(); // 0x07827974
	System.Boolean MoveNext(); // 0x078279d4
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07827ac4
	System.Void System.Collections.IEnumerator.Reset(); // 0x07827b28
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07827bb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.PerformanceTestCase.<LookRound>d__6 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.Single <duration>5__2; // 0x20
	System.Single <amplitude>5__3; // 0x24
	System.Single <frequency>5__4; // 0x28
	System.Single <timer>5__5; // 0x2c
	System.Single <deltaTime>5__6; // 0x30
	System.Single <initialYaw>5__7; // 0x34
	System.Single <initialPitch>5__8; // 0x38
	System.Void .ctor(System.Int32 <>1__state); // 0x0781c570
	System.Void System.IDisposable.Dispose(); // 0x07827c14
	System.Boolean MoveNext(); // 0x07827c74
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07827f48
	System.Void System.Collections.IEnumerator.Reset(); // 0x07827fac
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07828034
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.PerformanceTestCase.<MapTest>d__4 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.PerformanceTestCase <>4__this; // 0x20
	UnityEngine.Vector3 <position>5__2; // 0x28
	System.Int32 <x_brach>5__3; // 0x34
	System.Int32 <z_branch>5__4; // 0x38
	System.Int32 <x>5__5; // 0x3c
	System.Int32 <z>5__6; // 0x40
	UnityEngine.Vector3 <point>5__7; // 0x44
	System.Void .ctor(System.Int32 <>1__state); // 0x0781c2b0
	System.Void System.IDisposable.Dispose(); // 0x07828098
	System.Boolean MoveNext(); // 0x078280f8
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x078285a0
	System.Void System.Collections.IEnumerator.Reset(); // 0x07828604
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0782868c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.PerformanceTestCase.<PerformanceSetUp>d__7 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.Void .ctor(System.Int32 <>1__state); // 0x0781c680
	System.Void System.IDisposable.Dispose(); // 0x078286f0
	System.Boolean MoveNext(); // 0x07828750
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x078287fc
	System.Void System.Collections.IEnumerator.Reset(); // 0x07828860
	System.Object System.Collections.IEnumerator.get_Current(); // 0x078288e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.PerformanceTestCase.<WakeUp>d__1 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.Void .ctor(System.Int32 <>1__state); // 0x0781bfcc
	System.Void System.IDisposable.Dispose(); // 0x0782894c
	System.Boolean MoveNext(); // 0x078289ac
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07828e8c
	System.Void System.Collections.IEnumerator.Reset(); // 0x07828ef0
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07828f78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.SafeZoneTestCase : WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase
{
	
	System.Collections.IEnumerator SafeZoneTest(); // 0x07828fdc
	System.Void .ctor(); // 0x078290ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.SafeZoneTestCase.<SafeZoneTest>d__0 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.DateTime <startTime>5__2; // 0x20
	System.TimeSpan <duration>5__3; // 0x28
	System.Void .ctor(System.Int32 <>1__state); // 0x07829068
	System.Void System.IDisposable.Dispose(); // 0x07829174
	System.Boolean MoveNext(); // 0x078291d4
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07829764
	System.Void System.Collections.IEnumerator.Reset(); // 0x078297c8
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07829850
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.SkyAutoTestCase : WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase
{
	
	System.Void .ctor(); // 0x078298b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.SucideAndRespawnTestCase : WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase
{
	
	System.Collections.IEnumerator sucideAndrespawn(); // 0x0782993c
	System.Collections.IEnumerator SetUp(System.String account, System.String serverName, System.Int32 serverIndex); // 0x07829a4c
	System.Collections.IEnumerator SucideAndRespawnTest(); // 0x07829bb8
	System.Void .ctor(); // 0x07829ce0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.SucideAndRespawnTestCase.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Test.Automation.TestCases.SucideAndRespawnTestCase.<>c <>9; // 0x0
	static System.Func<System.Boolean> <>9__0_0; // 0x8
	static System.Func<System.Boolean> <>9__0_1; // 0x10
	static System.Func<System.Boolean> <>9__0_2; // 0x18
	static System.Void .cctor(); // 0x07829d68
	System.Void .ctor(); // 0x07829dcc
	System.Boolean <sucideAndrespawn>b__0_0(); // 0x07829e34
	System.Boolean <sucideAndrespawn>b__0_1(); // 0x07829f58
	System.Boolean <sucideAndrespawn>b__0_2(); // 0x0782a07c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.SucideAndRespawnTestCase.<SetUp>d__1 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.String account; // 0x20
	System.String serverName; // 0x28
	System.Int32 serverIndex; // 0x30
	System.Void .ctor(System.Int32 <>1__state); // 0x07829b34
	System.Void System.IDisposable.Dispose(); // 0x0782a1a0
	System.Boolean MoveNext(); // 0x0782a200
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0782a2e8
	System.Void System.Collections.IEnumerator.Reset(); // 0x0782a34c
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0782a3d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.SucideAndRespawnTestCase.<SucideAndRespawnTest>d__2 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.SucideAndRespawnTestCase <>4__this; // 0x20
	System.Void .ctor(System.Int32 <>1__state); // 0x07829c5c
	System.Void System.IDisposable.Dispose(); // 0x0782a438
	System.Boolean MoveNext(); // 0x0782a498
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0782a550
	System.Void System.Collections.IEnumerator.Reset(); // 0x0782a5b4
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0782a63c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.SucideAndRespawnTestCase.<sucideAndrespawn>d__0 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.Void .ctor(System.Int32 <>1__state); // 0x078299c8
	System.Void System.IDisposable.Dispose(); // 0x0782a6a0
	System.Boolean MoveNext(); // 0x0782a700
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0782b86c
	System.Void System.Collections.IEnumerator.Reset(); // 0x0782b8d0
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0782b958
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase : WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase
{
	System.Boolean canTest; // 0x38
	System.Void CamerapCoroutine(); // 0x0782b9bc
	System.Collections.IEnumerator Deploy(); // 0x0782bee8
	System.Void OpenFoundationUI(); // 0x0782bf90
	System.Void CloseFoundationUI(); // 0x0782c0ac
	System.Collections.IEnumerator BuildFoundation(); // 0x0782c1c8
	System.Collections.IEnumerator TestFoundation(); // 0x0782c270
	System.Collections.IEnumerator RunBuildTest(WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.DeployInfo info); // 0x0782c318
	System.Boolean FindDeployableParts(System.String name); // 0x0782c408
	System.Void TryBuild(); // 0x0782c6bc
	UnityEngine.MeshRenderer GetFoundationMeshRender(); // 0x0782c790
	UnityEngine.MeshRenderer GetDeploymentMeshRender(System.String buildingName); // 0x0782c908
	UnityEngine.MeshRenderer FindChildWithMeshRender(UnityEngine.Transform parent); // 0x0782ca68
	System.Boolean TestBuildAble(UnityEngine.MeshRenderer meshRenderer); // 0x0782cc2c
	static System.Void TryClearBagAndBelt(); // 0x07818b80
	System.Collections.IEnumerator Shoot(System.Int32 index); // 0x0782cd30
	System.Collections.IEnumerator ControlBag(); // 0x0782cdf0
	System.Collections.IEnumerator MoveAndGather(); // 0x0782ce80
	System.Collections.IEnumerator Gather(WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.GatherInfo info); // 0x0782cf28
	System.Collections.IEnumerator sucideAndrespawn(); // 0x0782cff4
	System.Collections.IEnumerator Main(System.String account, System.String serverName, System.Int32 serverIndex, System.Int32 index); // 0x0782d084
	System.Void .ctor(); // 0x0782d168
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.DeployInfo : System.ValueType
{
	System.Int32 id; // 0x10
	System.String name; // 0x18
	System.Boolean inside; // 0x20
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.GatherInfo : System.ValueType
{
	System.Int32 id; // 0x10
	System.Int32 num; // 0x14
	System.Int32 entityType; // 0x18
	System.Int32 index; // 0x1c
	System.String name; // 0x20
	System.Int32 resourseId; // 0x28
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<>c <>9; // 0x0
	static System.Func<System.Boolean> <>9__3_0; // 0x8
	static System.Func<System.Boolean> <>9__21_0; // 0x10
	static System.Func<System.Boolean> <>9__21_1; // 0x18
	static System.Func<System.Boolean> <>9__21_2; // 0x20
	static System.Void .cctor(); // 0x0782d1f8
	System.Void .ctor(); // 0x0782d25c
	System.Boolean <Deploy>b__3_0(); // 0x0782d2c4
	System.Boolean <sucideAndrespawn>b__21_0(); // 0x0782d35c
	System.Boolean <sucideAndrespawn>b__21_1(); // 0x0782d480
	System.Boolean <sucideAndrespawn>b__21_2(); // 0x0782d5a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<>c__DisplayClass16_0 : System.Object
{
	System.Int32 firstWeapon; // 0x10
	System.Void .ctor(); // 0x0782d6c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<>c__DisplayClass16_1 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode currenttargetNode; // 0x10
	WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<>c__DisplayClass16_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x0782d730
	System.Boolean <Shoot>b__0(); // 0x0782d798
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<>c__DisplayClass17_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode mainitemtargetNode; // 0x10
	WizardGames.Soc.Common.CustomType.BaseItemNode throwNode; // 0x18
	System.Void .ctor(); // 0x0782d910
	System.Boolean <ControlBag>b__0(); // 0x0782d978
	System.Boolean <ControlBag>b__1(); // 0x0782da9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<>c__DisplayClass17_1 : System.Object
{
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container; // 0x10
	WizardGames.Soc.Common.CustomType.BaseItemNode itemtargetNode; // 0x18
	System.Void .ctor(); // 0x0782dbc0
	System.Boolean <ControlBag>b__2(); // 0x0782dc28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<>c__DisplayClass17_2 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode itemtargetNode1; // 0x10
	System.Void .ctor(); // 0x0782dd60
	System.Boolean <ControlBag>b__3(); // 0x0782ddc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<>c__DisplayClass19_0 : System.Object
{
	System.Single result; // 0x10
	System.Void .ctor(); // 0x0782deec
	System.Boolean <MoveAndGather>b__0(); // 0x0782df54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<BuildFoundation>d__6 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase <>4__this; // 0x20
	System.Void .ctor(System.Int32 <>1__state); // 0x0782e080
	System.Void System.IDisposable.Dispose(); // 0x0782e104
	System.Boolean MoveNext(); // 0x0782e18c
	System.Void <>m__Finally1(); // 0x0782e3f4
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0782e46c
	System.Void System.Collections.IEnumerator.Reset(); // 0x0782e4d0
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0782e558
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<ControlBag>d__17 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<>c__DisplayClass17_1 <>8__1; // 0x20
	WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<>c__DisplayClass17_2 <>8__2; // 0x28
	WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<>c__DisplayClass17_0 <>8__3; // 0x30
	FairyGUI.GTextField <hungertext>5__2; // 0x38
	System.Int32 <fontstatus>5__3; // 0x40
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap <containerBelt>5__4; // 0x48
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap <containerMain>5__5; // 0x50
	System.Int32 <j>5__6; // 0x58
	FairyGUI.GComponent <contentPane>5__7; // 0x60
	System.Collections.Generic.List.Enumerator<WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap> <>7__wrap7; // 0x68
	System.Void .ctor(System.Int32 <>1__state); // 0x0782e5bc
	System.Void System.IDisposable.Dispose(); // 0x0782e640
	System.Boolean MoveNext(); // 0x0782e6c8
	System.Void <>m__Finally1(); // 0x0782ff8c
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07830010
	System.Void System.Collections.IEnumerator.Reset(); // 0x07830074
	System.Object System.Collections.IEnumerator.get_Current(); // 0x078300fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<Deploy>d__3 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase <>4__this; // 0x20
	UnityEngine.Vector3 <pos>5__2; // 0x28
	System.Collections.Generic.List.Enumerator<WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.DeployInfo> <>7__wrap2; // 0x38
	System.Void .ctor(System.Int32 <>1__state); // 0x07830160
	System.Void System.IDisposable.Dispose(); // 0x078301e4
	System.Boolean MoveNext(); // 0x07830268
	System.Void <>m__Finally1(); // 0x07831a18
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07831a9c
	System.Void System.Collections.IEnumerator.Reset(); // 0x07831b00
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07831b88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<Gather>d__20 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.GatherInfo info; // 0x20
	System.String <testname>5__2; // 0x40
	System.Int32 <resourseId>5__3; // 0x48
	System.Int32 <totalnum>5__4; // 0x4c
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcuts <shortChut>5__5; // 0x50
	System.Void .ctor(System.Int32 <>1__state); // 0x07831bec
	System.Void System.IDisposable.Dispose(); // 0x07831c70
	System.Boolean MoveNext(); // 0x07831cd0
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x078323bc
	System.Void System.Collections.IEnumerator.Reset(); // 0x07832420
	System.Object System.Collections.IEnumerator.get_Current(); // 0x078324a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<Main>d__22 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase <>4__this; // 0x20
	System.Int32 index; // 0x28
	System.Void .ctor(System.Int32 <>1__state); // 0x0783250c
	System.Void System.IDisposable.Dispose(); // 0x07832590
	System.Boolean MoveNext(); // 0x078325f0
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07832970
	System.Void System.Collections.IEnumerator.Reset(); // 0x078329d4
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07832a5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<MoveAndGather>d__19 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<>c__DisplayClass19_0 <>8__1; // 0x20
	WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase <>4__this; // 0x28
	UnityEngine.Vector3 <player_position_beforewalk>5__2; // 0x30
	System.Int32 <i>5__3; // 0x3c
	System.Collections.Generic.List.Enumerator<WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.GatherInfo> <>7__wrap3; // 0x40
	System.Void .ctor(System.Int32 <>1__state); // 0x07832ac0
	System.Void System.IDisposable.Dispose(); // 0x07832b44
	System.Boolean MoveNext(); // 0x07832bc8
	System.Void <>m__Finally1(); // 0x07833650
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x078336d4
	System.Void System.Collections.IEnumerator.Reset(); // 0x07833738
	System.Object System.Collections.IEnumerator.get_Current(); // 0x078337c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<RunBuildTest>d__8 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.DeployInfo info; // 0x20
	WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase <>4__this; // 0x38
	System.Int32 <buildID>5__2; // 0x40
	System.String <buildName>5__3; // 0x48
	System.Int32 <index>5__4; // 0x50
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcuts <shortChut>5__5; // 0x58
	System.Single <endPitch>5__6; // 0x60
	System.Void .ctor(System.Int32 <>1__state); // 0x07833824
	System.Void System.IDisposable.Dispose(); // 0x078338a8
	System.Boolean MoveNext(); // 0x07833908
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07834a3c
	System.Void System.Collections.IEnumerator.Reset(); // 0x07834aa0
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07834b28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<Shoot>d__16 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<>c__DisplayClass16_0 <>8__1; // 0x20
	WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase <>4__this; // 0x28
	System.Int32 index; // 0x30
	WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<>c__DisplayClass16_1 <>8__2; // 0x38
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap <containerBelt>5__2; // 0x40
	System.Int32 <i>5__3; // 0x48
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcuts <shortChut>5__4; // 0x50
	FairyGUI.GComponent <itemIcon>5__5; // 0x58
	System.Int32 <beforeshotNum>5__6; // 0x60
	System.Int32 <aftershotNum>5__7; // 0x64
	System.Void .ctor(System.Int32 <>1__state); // 0x07834b8c
	System.Void System.IDisposable.Dispose(); // 0x07834c10
	System.Boolean MoveNext(); // 0x07834c70
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x078360a8
	System.Void System.Collections.IEnumerator.Reset(); // 0x0783610c
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07836194
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<TestFoundation>d__7 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase <>4__this; // 0x20
	System.Single <endPitch>5__2; // 0x28
	System.Void .ctor(System.Int32 <>1__state); // 0x078361f8
	System.Void System.IDisposable.Dispose(); // 0x0783627c
	System.Boolean MoveNext(); // 0x07836310
	System.Void <>m__Finally1(); // 0x078367a8
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07836820
	System.Void System.Collections.IEnumerator.Reset(); // 0x07836884
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0783690c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.TestCase.<sucideAndrespawn>d__21 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.Void .ctor(System.Int32 <>1__state); // 0x07836970
	System.Void System.IDisposable.Dispose(); // 0x078369f4
	System.Boolean MoveNext(); // 0x07836a54
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07837bc0
	System.Void System.Collections.IEnumerator.Reset(); // 0x07837c24
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07837cac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.UiTestCase : WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase
{
	
	System.Collections.IEnumerator UiTest(); // 0x07837d10
	System.Void .ctor(); // 0x07837e20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.UiTestCase.<UiTest>d__0 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.Collections.Generic.List.Enumerator<WizardGames.Soc.Common.Data.Ui.Window> <>7__wrap1; // 0x20
	System.String <packName>5__3; // 0x38
	FairyGUI.GComponent <com>5__4; // 0x40
	System.Void .ctor(System.Int32 <>1__state); // 0x07837d9c
	System.Void System.IDisposable.Dispose(); // 0x07837eac
	System.Boolean MoveNext(); // 0x07837f40
	System.Void <>m__Finally1(); // 0x07838600
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07838684
	System.Void System.Collections.IEnumerator.Reset(); // 0x078386e8
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07838770
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.VehicleTestCase : WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase
{
	
	System.Collections.IEnumerator VehicleTest(); // 0x078387d4
	static System.Boolean GetNearestVehicleModuleEntity(System.Single targetX, System.Single targetZ, System.Single& posX, System.Single& posZ, System.Int64& entityId); // 0x078388e4
	static System.Single CalculateDistance(System.Single x1, System.Single z1, System.Single x2, System.Single z2); // 0x07838ef8
	System.Void .ctor(); // 0x07838fe8
	static System.Boolean <VehicleTest>g__IsInIslandRange|0_0(System.Single x, System.Single z, WizardGames.Soc.SocClient.Test.Automation.TestCases.VehicleTestCase.<>c__DisplayClass0_0& Client.Runtime); // 0x07839074
	static System.Boolean <VehicleTest>g__IsFacingCenterPoint|0_1(System.Single selfX, System.Single selfZ, System.Single yaw, WizardGames.Soc.SocClient.Test.Automation.TestCases.VehicleTestCase.<>c__DisplayClass0_0& Client.Runtime); // 0x07839128
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Test.Automation.TestCases.VehicleTestCase.<>c__DisplayClass0_0 : System.ValueType
{
	System.Single x1; // 0x10
	System.Single x3; // 0x14
	System.Single z1; // 0x18
	System.Single z3; // 0x1c
	System.Single centerZ; // 0x20
	System.Single centerX; // 0x24
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.VehicleTestCase.<VehicleTest>d__0 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.TestCases.VehicleTestCase.<>c__DisplayClass0_0 <>8__1; // 0x20
	System.ValueTuple<System.Single,System.Single> <playerPoint>5__2; // 0x38
	System.Int64 <entityId>5__3; // 0x40
	System.DateTime <startTime>5__4; // 0x48
	System.TimeSpan <duration>5__5; // 0x50
	System.Int32 <i>5__6; // 0x58
	System.Void .ctor(System.Int32 <>1__state); // 0x07838860
	System.Void System.IDisposable.Dispose(); // 0x0783921c
	System.Boolean MoveNext(); // 0x0783927c
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0783a0bc
	System.Void System.Collections.IEnumerator.Reset(); // 0x0783a120
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0783a1a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.VehicleTestPre : WizardGames.Soc.SocClient.Test.Automation.TestCases.BaseTestCase
{
	
	System.Collections.IEnumerator VehiclePreTest(); // 0x0783a20c
	static System.Collections.Generic.List<System.ValueTuple<System.Single,System.Single>> GenerateGrid(System.ValueTuple<System.Single,System.Single> center, System.Single distanceX, System.Single distanceY, System.Int32 rows, System.Int32 columns); // 0x0783a31c
	System.Void .ctor(); // 0x0783a504
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.VehicleTestPre.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Test.Automation.TestCases.VehicleTestPre.<>c <>9; // 0x0
	static System.Func<UnityEngine.Vector3> <>9__0_0; // 0x8
	static System.Void .cctor(); // 0x0783a590
	System.Void .ctor(); // 0x0783a5f4
	UnityEngine.Vector3 <VehiclePreTest>b__0_0(); // 0x0783a65c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.VehicleTestPre.<VehiclePreTest>d__0 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.Void .ctor(System.Int32 <>1__state); // 0x0783a298
	System.Void System.IDisposable.Dispose(); // 0x0783a708
	System.Boolean MoveNext(); // 0x0783a768
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0783ad0c
	System.Void System.Collections.IEnumerator.Reset(); // 0x0783ad70
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0783adf8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.Modules.BaseAutomation : UnityEngine.MonoBehaviour
{
	static WizardGames.Soc.SocClient.Test.Common.TestLog Log; // 0x0
	System.Void Awake(); // 0x0783ae5c
	System.Void .ctor(); // 0x0783af0c
	static System.Void .cctor(); // 0x0783af74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.Modules.LoginAutomation : WizardGames.Soc.SocClient.Test.Automation.TestCases.Modules.BaseAutomation
{
	
	static System.Boolean WaitServerInfoListInit(); // 0x0783b084
	static System.Collections.IEnumerator EnterServer(System.String serverName, System.Int32 serverIndex); // 0x0783b160
	static System.Collections.IEnumerator EnterServerWithoutSelect(System.String serverName); // 0x0783b2a0
	static System.Collections.IEnumerator Login(System.String account, System.String serverName, System.Int32 serverIndex); // 0x0783b3c8
	static System.Collections.IEnumerator LoginToLobby(System.String account); // 0x0783b51c
	static System.Collections.IEnumerator Wakeup(); // 0x0783b644
	System.Void .ctor(); // 0x0783b74c
	static System.Boolean <EnterServer>g__CheckServerGroup|1_0(System.Int32 groupIndex, System.String serverName, WizardGames.Soc.SocClient.Test.Automation.TestCases.Modules.LoginAutomation.<>c__DisplayClass1_0& Client.Runtime); // 0x0783b7d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.Modules.LoginAutomation.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Test.Automation.TestCases.Modules.LoginAutomation.<>c <>9; // 0x0
	static System.Func<System.Boolean> <>9__1_1; // 0x8
	static System.Func<System.Boolean> <>9__3_0; // 0x10
	static System.Func<System.Boolean> <>9__4_0; // 0x18
	static System.Func<System.Boolean> <>9__4_1; // 0x20
	static System.Func<System.Boolean> <>9__4_2; // 0x28
	static System.Func<System.Boolean> <>9__4_3; // 0x30
	static System.Func<System.Boolean> <>9__4_4; // 0x38
	static System.Func<System.Boolean> <>9__4_5; // 0x40
	static System.Func<System.Boolean> <>9__4_6; // 0x48
	static System.Func<System.Boolean> <>9__4_7; // 0x50
	static System.Func<System.Boolean> <>9__5_0; // 0x58
	static System.Void .cctor(); // 0x0783b9a4
	System.Void .ctor(); // 0x0783ba08
	System.Boolean <EnterServer>b__1_1(); // 0x0783ba70
	System.Boolean <Login>b__3_0(); // 0x0783bb48
	System.Boolean <LoginToLobby>b__4_0(); // 0x0783bc14
	System.Boolean <LoginToLobby>b__4_1(); // 0x0783bce0
	System.Boolean <LoginToLobby>b__4_2(); // 0x0783bdac
	System.Boolean <LoginToLobby>b__4_3(); // 0x0783be78
	System.Boolean <LoginToLobby>b__4_4(); // 0x0783bf2c
	System.Boolean <LoginToLobby>b__4_5(); // 0x0783bff8
	System.Boolean <LoginToLobby>b__4_6(); // 0x0783c0ac
	System.Boolean <LoginToLobby>b__4_7(); // 0x0783c160
	System.Boolean <Wakeup>b__5_0(); // 0x0783c214
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Test.Automation.TestCases.Modules.LoginAutomation.<>c__DisplayClass1_0 : System.ValueType
{
	FairyGUI.GList serverInfosList; // 0x10
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.Modules.LoginAutomation.<EnterServer>d__1 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.Int32 serverIndex; // 0x20
	System.String serverName; // 0x28
	WizardGames.Soc.SocClient.Test.Automation.TestCases.Modules.LoginAutomation.<>c__DisplayClass1_0 <>8__1; // 0x30
	System.Array <enumValues>5__2; // 0x38
	System.Boolean <serverOk>5__3; // 0x40
	System.Int32 <i>5__4; // 0x44
	System.Void .ctor(System.Int32 <>1__state); // 0x0783b21c
	System.Void System.IDisposable.Dispose(); // 0x0783c2ac
	System.Boolean MoveNext(); // 0x0783c30c
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0783cdcc
	System.Void System.Collections.IEnumerator.Reset(); // 0x0783ce30
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0783ceb8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.Modules.LoginAutomation.<EnterServerWithoutSelect>d__2 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.String serverName; // 0x20
	System.Void .ctor(System.Int32 <>1__state); // 0x0783b344
	System.Void System.IDisposable.Dispose(); // 0x0783cf1c
	System.Boolean MoveNext(); // 0x0783cf7c
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0783d100
	System.Void System.Collections.IEnumerator.Reset(); // 0x0783d164
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0783d1ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.Modules.LoginAutomation.<Login>d__3 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.String account; // 0x20
	System.String serverName; // 0x28
	System.Void .ctor(System.Int32 <>1__state); // 0x0783b498
	System.Void System.IDisposable.Dispose(); // 0x0783d250
	System.Boolean MoveNext(); // 0x0783d2b0
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0783d614
	System.Void System.Collections.IEnumerator.Reset(); // 0x0783d678
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0783d700
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.Modules.LoginAutomation.<LoginToLobby>d__4 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.String account; // 0x20
	FairyGUI.GComponent <content>5__2; // 0x28
	FairyGUI.GGroup <groupLoginBtns>5__3; // 0x30
	System.Int32 <numChildren>5__4; // 0x38
	FairyGUI.GComponent <logincontentPane1>5__5; // 0x40
	FairyGUI.GButton <backbtn>5__6; // 0x48
	FairyGUI.GComponent <createContent>5__7; // 0x50
	FairyGUI.GComponent <editlist>5__8; // 0x58
	FairyGUI.GTextInput <inputboxiner1>5__9; // 0x60
	FairyGUI.GButton <msgbtn3>5__10; // 0x68
	System.Int32 <i>5__11; // 0x70
	FairyGUI.GButton <btnLogin>5__12; // 0x78
	System.Void .ctor(System.Int32 <>1__state); // 0x0783b5c0
	System.Void System.IDisposable.Dispose(); // 0x0783d764
	System.Boolean MoveNext(); // 0x0783d7c4
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0783ee90
	System.Void System.Collections.IEnumerator.Reset(); // 0x0783eef4
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0783ef7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.TestCases.Modules.LoginAutomation.<Wakeup>d__5 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.Void .ctor(System.Int32 <>1__state); // 0x0783b6c8
	System.Void System.IDisposable.Dispose(); // 0x0783efe0
	System.Boolean MoveNext(); // 0x0783f040
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0783f314
	System.Void System.Collections.IEnumerator.Reset(); // 0x0783f378
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0783f400
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.Helper.ParametersHelper : System.Object
{
	static System.String ClipboardText; // 0x0
	static System.Boolean StartAutomationOrNot(); // 0x0783f464
	static System.Void .cctor(); // 0x0783f510
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.Helper.BaseAttrAttribute : System.Attribute
{
	static SocLogger <Log>k__BackingField; // 0x0
	System.Diagnostics.Stopwatch Stopwatch; // 0x10
	static SocLogger get_Log(); // 0x0783f56c
	System.Void .ctor(System.Reflection.ParameterInfo[] args); // 0x0783f5f4
	System.Collections.IEnumerator BeforeInvoke(System.Reflection.MethodInfo methodInfo, System.Object[] args); // 0x0783f6a8
	System.Collections.IEnumerator AfterInvoke(System.Reflection.MethodInfo methodInfo, System.Object[] args); // 0x0783f7ec
	static System.Void .cctor(); // 0x0783f940
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.Helper.BaseAttrAttribute.<AfterInvoke>d__7 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.Helper.BaseAttrAttribute <>4__this; // 0x20
	System.Reflection.MethodInfo methodInfo; // 0x28
	System.Void .ctor(System.Int32 <>1__state); // 0x0783f8bc
	System.Void System.IDisposable.Dispose(); // 0x0783fa14
	System.Boolean MoveNext(); // 0x0783fa74
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0783fc6c
	System.Void System.Collections.IEnumerator.Reset(); // 0x0783fcd0
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0783fd58
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.Helper.BaseAttrAttribute.<BeforeInvoke>d__6 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Test.Automation.Helper.BaseAttrAttribute <>4__this; // 0x20
	System.Void .ctor(System.Int32 <>1__state); // 0x0783f768
	System.Void System.IDisposable.Dispose(); // 0x0783fdbc
	System.Boolean MoveNext(); // 0x0783fe1c
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x0783fee0
	System.Void System.Collections.IEnumerator.Reset(); // 0x0783ff44
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0783ffcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.Helper.SetUpAttribute : WizardGames.Soc.SocClient.Test.Automation.Helper.BaseAttrAttribute
{
	
	System.Void .ctor(); // 0x07840030
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.Helper.TearDownAttribute : WizardGames.Soc.SocClient.Test.Automation.Helper.BaseAttrAttribute
{
	
	System.Void .ctor(); // 0x0784012c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.Helper.TestAttribute : WizardGames.Soc.SocClient.Test.Automation.Helper.BaseAttrAttribute
{
	
	System.Void .ctor(); // 0x07840228
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.Helper.Utils : System.Object
{
	static SocLogger Logger; // 0x0
	static System.Net.Http.HttpClient httpClient; // 0x8
	static System.String url; // 0x10
	static T GetGameObjectField<T>(System.String windowName, System.String objectName); // 0x052af1f0
	static T GetGameObjectProperty<T>(System.String windowName, System.String objectName); // 0x052af1f0
	static System.Boolean LamdaGetGameObjectProperty<T>(System.String windowName, System.String objectName); // 0x052af1f0
	static T GetField<T>(System.Object instance, System.String fieldName); // 0x052af1f0
	static T GetProperty<T>(System.Object instance, System.String propertyName); // 0x052af1f0
	static System.Void CallMethod(System.Object instance, System.String name, System.Object[] param); // 0x0783cc78
	static System.Void .cctor(); // 0x07840324
}

// Client.Runtime
class WizardGames.Soc.SocClient.Terrain.MgrTerrain : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	static System.Int32 TerrainSizeDefault; // 0x8
	static UnityEngine.Vector2 OriPositionDefault; // 0xc
	WizardGames.Soc.Procedural.TerrainMeta socTerrainMeta; // 0x18
	UnityEngine.Terrain unityTerrain; // 0x20
	UnityEngine.Vector2 oriPosition; // 0x28
	System.Int32 terrainSize; // 0x30
	UnityEngine.Texture2D miniMapTex; // 0x38
	UnityEngine.Rect terrainRect; // 0x40
	System.Boolean <IsProcedureTerrainScene>k__BackingField; // 0x50
	System.Collections.Generic.Dictionary<System.Int64,System.Action<System.Single>> getPosYCallback; // 0x58
	System.Boolean get_IsProcedureTerrainScene(); // 0x07840464
	System.Void set_IsProcedureTerrainScene(System.Boolean value); // 0x078404c8
	System.Int32 get_TerrainSize(); // 0x07840544
	UnityEngine.Texture2D get_MiniMapTex(); // 0x078405a8
	UnityEngine.Rect get_TerrainRect(); // 0x0784060c
	UnityEngine.Vector2 get_OriPosition(); // 0x07840670
	System.Threading.Tasks.Task OnEnterWorld(); // 0x078406d0
	System.Threading.Tasks.Task OnExitWorld(); // 0x07840d14
	System.Void InitializeOnEnterGameScene(); // 0x07840740
	System.Single GetPosY(System.Single x, System.Single z); // 0x07840e64
	System.Boolean IsTerrainEmpty(); // 0x0784105c
	System.Void AddPosYCallback(System.Int64 seq, System.Action<System.Single> callback); // 0x07841128
	System.Void HandlePosYCallback(System.Int64 seq, System.Single y); // 0x078411d0
	System.Void .ctor(); // 0x078413cc
	static System.Void .cctor(); // 0x078414dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Technology.MgrTechnology : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Generic.HashSet<System.Int64> bpIdsChecker; // 0x18
	static SocLogger <Log>k__BackingField; // 0x0
	static System.Int32 <ScrapItemId>k__BackingField; // 0x8
	static System.Int32[] WorkbenchTemplateIds; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> <NodeStatusCache>k__BackingField; // 0x20
	System.Boolean <IsCacheDirty>k__BackingField; // 0x28
	System.Collections.Generic.HashSet<System.Int64> needUnlockNodeIds; // 0x30
	System.Collections.Generic.HashSet<System.Int64> previousUnlockedTechIds; // 0x38
	System.Collections.Generic.HashSet<System.Int64> notifiedTechnologyIds; // 0x40
	WizardGames.Soc.Common.Component.BlueprintComponent get_BlueprintComponent(); // 0x078415d0
	static SocLogger get_Log(); // 0x07841684
	static System.Int32 get_ScrapItemId(); // 0x0784170c
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> get_NodeStatusCache(); // 0x07841794
	System.Void set_IsCacheDirty(System.Boolean value); // 0x078417f8
	System.Void UpdateTechTreeClientCache(); // 0x07841874
	System.Int64 GetTechIdByBluePrintId(System.Int64 bluePrintId); // 0x07842188
	System.Boolean IsTechnologyUnlocked(System.Int64 id); // 0x07842408
	System.Boolean IsAllBlueprintUnlock(System.Collections.Generic.List<System.Int64> blueprintIds); // 0x07842504
	System.Int32 GetTechNodeStatus(System.Int64 id, System.Boolean isBluePrint); // 0x07842c10
	System.Boolean IsExistBluePrintId(System.Int64 bluePrintId); // 0x07842fe4
	System.Boolean IsBlueprintUnlockInTechTree(System.Int64[] bpIds); // 0x0784325c
	System.Int32 GetUnlockConsume(System.Int64[] blueprintIds, System.Int32[] ingredientsNum); // 0x078436c8
	System.Void GetTeamRoleIdNameByTechId(System.Int64 techId, System.Action<SimpleJSON.JSONArray> callback, System.Boolean isBluePrint); // 0x07843800
	System.Int32 GetNodeParentNum(System.Int64 nodeId, System.Int32 maxDepth); // 0x07843e0c
	System.Boolean IsReputationLevelEnough(System.Int64 techId); // 0x07844004
	System.Int32 GetReputationLevel(); // 0x07844120
	System.Void GetOperatingWorkbench(WizardGames.Soc.SocClient.Ui.EUiTechTreeOpenSource source, System.Int64 operatingHubId, System.Int32& maxLv, System.Int64& maxEntityId); // 0x078441f8
	System.Int32 GetConsume(System.Int64 id, System.Int32 maxDepth); // 0x07844434
	System.Void ShowCanNotSupportCommonTip(System.Int32 curLevel); // 0x078446b8
	System.Boolean CanSupportUnlockNode(System.Int32 curLevel, WizardGames.Soc.SocClient.Ui.EUiTechTreeOpenSource source, System.Int64 opHubEntityId); // 0x078449b0
	System.Boolean CanSupportUnlockNodeById(System.Int64 id); // 0x07844aac
	System.Void UnlockNodes(System.Int64 id); // 0x07844c24
	System.Boolean IsAKTaskActive(); // 0x07845438
	System.Boolean IsAKOnlyNode(System.Int64 nodeId); // 0x07845534
	System.Boolean IsAKBlueprint(System.Int64 blueprintId); // 0x0784566c
	System.Void ShowTechnologyTipIfNeeded(System.Int64 techId, System.Boolean isTeammateTech); // 0x07841f1c
	System.Void CheckTeammateTechnologiesOnJoin(System.Collections.Generic.IEnumerable<System.Int64> teammateTechnologyIds); // 0x078456f0
	System.Void CheckTeammateTechnologyUpgrade(System.Collections.Generic.IEnumerable<System.Int64> newTechIds, System.Collections.Generic.IEnumerable<System.Int64> oldTechIds); // 0x078459cc
	System.Void ClearNotifiedTechnologyIds(); // 0x07845d6c
	System.Void .ctor(); // 0x07845df0
	static System.Void .cctor(); // 0x07845f74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Technology.MgrTechnology.<>c__DisplayClass32_0 : System.Object
{
	System.Action<SimpleJSON.JSONArray> callback; // 0x10
	System.Void .ctor(); // 0x07843da4
	System.Void <GetTeamRoleIdNameByTechId>b__0(SimpleJSON.JSONArray jsonArray); // 0x07846080
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Talent.ETalentEffect : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Talent.ETalentEffect NotActived = 0;
	static WizardGames.Soc.SocClient.Talent.ETalentEffect EventWithoutTime = 1;
	static WizardGames.Soc.SocClient.Talent.ETalentEffect EventWithTime = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Talent.TalentNode : System.Object
{
	System.Int32 id; // 0x10
	WizardGames.Soc.Common.Data.Play.OBJTalent <TalentCfg>k__BackingField; // 0x18
	WizardGames.Soc.Common.Data.Play.OBJTalentLevel <LevelCfg>k__BackingField; // 0x20
	WizardGames.Soc.Common.Data.Play.OBJTalentLevel <NextLevelCfg>k__BackingField; // 0x28
	System.Int32 <MaxLevel>k__BackingField; // 0x30
	System.Int32 level; // 0x34
	System.Int32 AccountLevel; // 0x38
	System.Int32 get_Id(); // 0x0784610c
	System.Void set_Id(System.Int32 value); // 0x07846170
	WizardGames.Soc.Common.Data.Play.OBJTalent get_TalentCfg(); // 0x078462f4
	System.Void set_TalentCfg(WizardGames.Soc.Common.Data.Play.OBJTalent value); // 0x07846358
	WizardGames.Soc.Common.Data.Play.OBJTalentLevel get_LevelCfg(); // 0x078463d8
	System.Void set_LevelCfg(WizardGames.Soc.Common.Data.Play.OBJTalentLevel value); // 0x0784643c
	WizardGames.Soc.Common.Data.Play.OBJTalentLevel get_NextLevelCfg(); // 0x078464bc
	System.Void set_NextLevelCfg(WizardGames.Soc.Common.Data.Play.OBJTalentLevel value); // 0x07846520
	System.Int32 get_MaxLevel(); // 0x078465a0
	System.Void set_MaxLevel(System.Int32 value); // 0x07846604
	System.Int32 get_Level(); // 0x0784667c
	System.Void set_Level(System.Int32 value); // 0x078466e0
	System.Void .ctor(); // 0x07846b28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Talent.TalentTreeData : System.Object
{
	System.Int64 LastResetTime; // 0x10
	System.String id; // 0x18
	WizardGames.Soc.Common.Data.Play.OBJTalentTree TalentTreeCfg; // 0x20
	System.Collections.Generic.HashSet<System.Int32> LevelRewardReceived; // 0x28
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Talent.TalentNode> TalentDic; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Talent.TalentNode> TalentList; // 0x38
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.SocClient.Talent.TalentNode>> talentGradeDic; // 0x40
	System.Collections.Generic.List<System.Int32> talentGradeList; // 0x48
	System.String get_Id(); // 0x07846b90
	System.Void set_Id(System.String value); // 0x07846bf4
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Talent.TalentNode> GetTalentListByGrade(System.Int32 grade); // 0x078475b4
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Talent.TalentNode> GetTalentListByIndex(System.Int32 index); // 0x07847660
	System.Int32 get_TalentGradeCount(); // 0x07847738
	System.Int32 get_TotalLevel(); // 0x078477bc
	System.Int32 get_CurrRewardProgress(); // 0x078479d0
	System.Int32 get_NextRewardProgress(); // 0x07847b9c
	System.Int32 get_MaxRewardProgress(); // 0x07847d74
	System.Boolean get_IsSeasonTalent(); // 0x07847e20
	System.Int32 get_SeasonNumber(); // 0x07847ea8
	System.Boolean get_ResetCDOver(); // 0x07847f7c
	System.Void .ctor(); // 0x078480dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Talent.TalentTreeData.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Talent.TalentTreeData.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Talent.TalentNode> <>9__7_0; // 0x8
	static System.Comparison<System.Int32> <>9__7_1; // 0x10
	static System.Void .cctor(); // 0x0784831c
	System.Void .ctor(); // 0x07848380
	System.Int32 <set_Id>b__7_0(WizardGames.Soc.SocClient.Talent.TalentNode a, WizardGames.Soc.SocClient.Talent.TalentNode b); // 0x078483e8
	System.Int32 <set_Id>b__7_1(System.Int32 a, System.Int32 b); // 0x07848510
}

// Client.Runtime
class WizardGames.Soc.SocClient.Talent.MgrTalent : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Talent.MgrTalent.LevelData> levelList; // 0x18
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Talent.TalentTreeData> talentTrees; // 0x20
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Talent.TalentNode> levelTalentDic; // 0x28
	System.Int32 playerLevel; // 0x30
	System.Int32 CurFactionId; // 0x34
	System.Single LastRequestTime; // 0x38
	System.Collections.Generic.List<System.String> TalentTreeIdList; // 0x40
	System.String <RewardType>k__BackingField; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Talent.MgrTalent.LevelData> get_LevelList(); // 0x078486a4
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Talent.TalentTreeData> get_TalentTrees(); // 0x078493d8
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Talent.TalentNode> get_LevelTalentDic(); // 0x0784943c
	WizardGames.Soc.SocClient.Talent.TalentTreeData GetTalentTree(System.String talentTreeId); // 0x078499a8
	System.Void Init(); // 0x07849a5c
	System.Void Destroy(); // 0x07849b60
	System.Void OnAccountLogined(); // 0x07849c64
	System.Void OnAccountLogout(); // 0x0784a088
	System.Void OnRedDotPulled(); // 0x0784a124
	System.Void OnForceLevelAndExpChanged(SimpleJSON.JSONNode ret); // 0x0784a388
	System.Void OnTalentUpdate(SimpleJSON.JSONNode ret); // 0x0784a4f0
	System.Void GetTalentTreeInfo(System.Boolean force); // 0x0784a7d4
	System.Void OnGetTalentTreeInfo(SimpleJSON.JSONNode ret); // 0x0784aa3c
	System.Void ReceiveReward(System.String talentTreeId, System.Int32 progress); // 0x0784b064
	System.Void OnReceiveReward(SimpleJSON.JSONNode ret); // 0x0784b364
	System.Void BuyLevel(System.String talentTreeId, System.Int32 talentId, System.Int32 sourceLevel, System.Int32 targetLevel); // 0x0784b6a0
	System.Void OnBuyLevel(SimpleJSON.JSONNode ret); // 0x0784b9d4
	System.String get_RewardType(); // 0x0784bd90
	System.Void set_RewardType(System.String value); // 0x0784bdf4
	System.Void ResetTalentTree(System.String talentTreeId); // 0x0784be74
	System.Void OnResetTalentTree(SimpleJSON.JSONNode ret); // 0x0784c278
	WizardGames.Soc.SocClient.Talent.TalentNode GetTalent(System.Int32 talentId); // 0x0784c6a0
	System.Boolean IsTalentActived(System.Int32 talentId); // 0x0784c8d4
	System.String GetTalentUnlockDesc(System.Int32 talentId); // 0x0784c9b4
	System.Int32 GetTalentByConstructionBlueprintId(System.Int64 blueprintId); // 0x0784cf78
	WizardGames.Soc.SocClient.Talent.ETalentEffect GetEventTalentGrade(WizardGames.Soc.Common.Data.MarkerType markerType); // 0x0784d44c
	System.ValueTuple<System.String,System.Int32> GetEventTalentDesc(WizardGames.Soc.Common.Data.MarkerType markerType); // 0x0784d5f4
	System.String GetEventTalentTimeDesc(WizardGames.Soc.Common.Data.MarkerType markerType); // 0x0784dcb8
	System.Single GetGoodsTalentRatio(WizardGames.Soc.Common.Data.BuffType buffType); // 0x0784e080
	System.ValueTuple<System.Int32,System.Int32> GetTalentBuffData(WizardGames.Soc.Common.Data.BuffType buffType); // 0x0784e110
	System.Boolean GetTalentBoolValue(WizardGames.Soc.Common.Data.BuffType buffType); // 0x0784e244
	System.Int32 GetTalentIntValue(WizardGames.Soc.Common.Data.BuffType buffType); // 0x0784e2d0
	System.Boolean IsCampingTentOpen(); // 0x0784e354
	System.Int32 GetSafeLogoutTimeAll(); // 0x0784e3bc
	System.String GetCampingTentDesc(); // 0x0784e4bc
	System.Void RefreshRedDot(); // 0x0784a2cc
	System.Boolean HasTalentSkillReward(); // 0x0784e59c
	System.Boolean HasSeasonSkillReward(); // 0x0784e780
	System.Void .ctor(); // 0x0784e964
	static System.Void .cctor(); // 0x0784eb28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Talent.MgrTalent.UnlockData : System.Object
{
	System.String Title; // 0x10
	System.String Desc; // 0x18
	System.String Icon; // 0x20
	System.Void .ctor(); // 0x0784ec78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Talent.MgrTalent.TalentData : System.Object
{
	WizardGames.Soc.Common.Data.Play.OBJTalent Talent; // 0x10
	WizardGames.Soc.Common.Data.Play.OBJTalentLevel Level; // 0x18
	System.String Icon; // 0x20
	System.Void .ctor(); // 0x0784ece0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Talent.MgrTalent.RewardData : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJGenaral Item; // 0x10
	System.Int32 Amount; // 0x18
	System.Void .ctor(); // 0x0784ed48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Talent.MgrTalent.LevelData : System.Object
{
	System.Int32 Level; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Talent.MgrTalent.RewardData> Rewards; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Talent.MgrTalent.TalentData> Talents; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Talent.MgrTalent.UnlockData> Unlocks; // 0x28
	System.Boolean unlocked; // 0x30
	System.Boolean get_Unlocked(); // 0x0784edb0
	System.Void set_Unlocked(System.Boolean value); // 0x0784ee14
	System.Void .ctor(System.Int32 level); // 0x0784ef64
	System.Boolean HaveReward(); // 0x0784f0b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.CameraHitShakeDataSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	WizardGames.Soc.Common.DataSet.CommonDataSet<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> magicFieldCreateEventQueue; // 0x28
	WizardGames.Soc.Common.DataSet.CommonDataSet<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> damageEventQueue; // 0x30
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0784f180
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05523a54
	System.Void OnDestroy(); // 0x055049cc
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0784f560
	System.Boolean isMeleeOrWeaponDamage(WizardGames.Soc.Common.SimpleCustom.DamageType damageType); // 0x07850888
	System.Boolean HasWallBetween(UnityEngine.Vector3 pos, WizardGames.Soc.Common.Unity.Character.SocCharacterController cpc); // 0x07850278
	static System.Void CreateCameraHitShakeData(WizardGames.Soc.Common.Contexts.Context context, UnityEngine.Vector3 dir, UnityEngine.Vector3 pos, System.Int64 weaponTableId, System.Single para, System.Int32 shotLenId); // 0x07850738
	System.Void CreateFallDownCameraShakeData(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams); // 0x0785091c
	System.Void .ctor(); // 0x07850a98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.RollSpringFormula : WizardGames.Soc.Common.Combat.Shoot.Formula.Viewkick.ViewkickRollFormula
{
	
	System.Void .ctor(); // 0x07850b00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.YawSpringFormula : WizardGames.Soc.Common.Combat.Shoot.Formula.Viewkick.ViewkickRollFormula
{
	
	System.Void .ctor(); // 0x07850b68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.PitchSpringFormula : WizardGames.Soc.Common.Combat.Shoot.Formula.Viewkick.ViewkickRollFormula
{
	
	System.Void .ctor(); // 0x07850bd0
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Systems.HitShakeRollSpringFormula : System.ValueType
{
	WizardGames.Soc.SocClient.Systems.RollSpringFormula RollSpringFormula; // 0x10
	WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormulaData RollSpringFormulaData; // 0x18
	System.Boolean IsLeft; // 0x20
	System.Single During; // 0x24
	System.Int32 PercentAddCount; // 0x28
	System.String LastShakeType; // 0x30
	System.String NowShakeType; // 0x38
	System.Single TimeLength; // 0x40
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Systems.HitShakeYawSpringFormula : System.ValueType
{
	WizardGames.Soc.SocClient.Systems.YawSpringFormula YawSpringFormula; // 0x10
	WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormulaData YawSpringFormulaData; // 0x18
	System.Boolean IsLeft; // 0x20
	System.Single During; // 0x24
	System.Single TimeLength; // 0x28
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Systems.HitShakePitchSpringFormula : System.ValueType
{
	WizardGames.Soc.SocClient.Systems.PitchSpringFormula PitchSpringFormula; // 0x10
	WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormulaData PitchSpringFormulaData; // 0x18
	System.Boolean IsLeft; // 0x20
	System.Single During; // 0x24
	System.Single TimeLength; // 0x28
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Systems.HitShakeYawPitch : System.ValueType
{
	System.Single DeltaTime; // 0x10
	System.Single ShakeAngle; // 0x14
	System.Int32 ShotLenTableID; // 0x18
	System.Single TimeLength; // 0x1c
	System.Int32 CurveIndex; // 0x20
	System.Single MaxAngele; // 0x24
	System.String ShakeType; // 0x28
	System.Single OffsetPara; // 0x30
	System.Boolean IsLeft; // 0x34
	System.Single hitAngle; // 0x38
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Systems.YawPitchPair : System.ValueType
{
	System.Single yaw; // 0x10
	System.Single pitch; // 0x14
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.CameraHitShakeSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.DataSet.CommonDataSet<Share.Common.ObjPool.Alpha3PooledObjectBase> _cameraHitShakeDataSet; // 0x28
	WizardGames.Soc.SocClient.Systems.HitShakeRollSpringFormula _hitShakeRoll; // 0x30
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Systems.HitShakeYawPitch> _hitShakeYawPitches; // 0x68
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Systems.HitShakeYawPitch> _nextFrameYawPitches; // 0x70
	WizardGames.Soc.SocClient.Systems.HitShakeYawSpringFormula _yawSpringFormula; // 0x78
	WizardGames.Soc.SocClient.Systems.HitShakePitchSpringFormula _pitchSpringFormula; // 0x98
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Systems.YawPitchPair> _hitType2AngleSum; // 0xb8
	System.Int32 _yawPitchPercentAddCount; // 0xc0
	WizardGames.Soc.Common.Unity.Character.CameraHitConfig _CameraHitConfig; // 0xc8
	UnityEngine.GameObject bindGo; // 0xd0
	System.Single fovRatio; // 0xd8
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x07850c38
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x07850c9c
	System.Void AdsStateChange(System.Int64 entityId, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum newState); // 0x07851208
	System.Threading.Tasks.Task InitCameraHitConfig(); // 0x078510f8
	System.Void OnDestroy(); // 0x07851460
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x07851630
	System.Int32 RollInit(WizardGames.Soc.Common.Data.animation.ShotLensRollAnimation shotLenData, System.Single hitAngle); // 0x07852374
	WizardGames.Soc.SocClient.Systems.HitShakeYawPitch YawPitchInit(WizardGames.Soc.SocClient.Systems.HitShakeYawPitch info); // 0x07851f94
	System.Single GetMaxOffsetAngle(System.Single[] angles, System.Single[] paras, System.Single x); // 0x07853734
	System.Void YawPitchUpdate(System.Int32 deltaTime); // 0x07852850
	System.Void RollSpringFormulaInit(WizardGames.Soc.Common.Data.animation.ShotLensRollAnimation data, System.Boolean isLeft); // 0x078535ec
	System.Void YawSpringFormulaInit(WizardGames.Soc.Common.Data.animation.ShotLensPitchYawAnimation data, WizardGames.Soc.SocClient.Systems.HitShakeYawPitch info, System.Single rand); // 0x078538f4
	System.Void PitchSpringFormulaInit(WizardGames.Soc.Common.Data.animation.ShotLensPitchYawAnimation data, WizardGames.Soc.SocClient.Systems.HitShakeYawPitch info, System.Single rand); // 0x07853ad4
	System.Single GetHitWeightRatio(); // 0x07854ae4
	System.Void RollUpdate(System.Int32 deltaTime); // 0x0785256c
	System.Single GetPitchValue(WizardGames.Soc.SocClient.Systems.HitShakeYawPitch info, System.Int32 deltaTime); // 0x07854100
	System.Single GetYawValue(WizardGames.Soc.SocClient.Systems.HitShakeYawPitch info, System.Int32 deltaTime); // 0x07853f58
	System.Int32 GetShotLenTableId(System.Int64 weaponTableId); // 0x07851b64
	System.Single GetShakeAngle(System.Single hitAngle); // 0x07851df8
	System.Void HitType2AngleSumInit(); // 0x07853cb4
	System.Void AddYawPitchValue(System.Single yaw, System.Single pitch, System.String hitType); // 0x078542a8
	System.Void LimitYawPitchToTypeMaxAngle(); // 0x07854408
	System.Void ChangeHitType2AngleSum(System.Single yaw, System.Single pitch, System.String hitType); // 0x07854c78
	System.Int32 GetMutexValue(System.String lastType, System.String nowType); // 0x07853250
	System.Void .ctor(); // 0x07854da0
	static System.Void .cctor(); // 0x07854e10
	System.Void <InitCameraHitConfig>b__17_0(System.UInt64 arg1, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> result); // 0x07854ee4
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Systems.CameraHitShakeSystem.<InitCameraHitConfig>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Systems.CameraHitShakeSystem <>4__this; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter<WizardGames.Soc.Common.Unity.Character.CameraHitConfig> <>u__1; // 0x38
	System.Void MoveNext(); // 0x07854fdc
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x07855444
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.ClientEquipUpdateSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger Log; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> equipSkinCache; // 0x10
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Entity.IEquipEntity> equipEntities; // 0x18
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Entity.IEquipEntity> toRemove; // 0x20
	System.Collections.Generic.List<System.Int64> subscribeIdList; // 0x28
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x078554e8
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0785554c
	System.Void CostumesChange(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, WizardGames.Soc.Share.Framework.TypeBase oldValue, WizardGames.Soc.Share.Framework.TypeBase newValue); // 0x07855bd4
	System.Void WearItemSkinChanged(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int64 oldValue, System.Int64 newValue); // 0x07855d80
	System.Void EquipChanged(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x07855ec0
	System.Void OnCreateEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x078560e4
	System.Void PutInEquipEntities(System.Int64 entityId); // 0x07856204
	System.Void PutInEquipEntities(WizardGames.Soc.Common.Entity.IEquipEntity equipEntity); // 0x07855cd0
	static System.Void HandleEquipShowOption(System.Collections.Generic.List<System.Int64> wearItemTableIds, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x07856310
	static System.Void HandleEquipShowOption(System.Collections.Generic.List<System.Int64> wearItemTableIds, WizardGames.Soc.Common.Entity.CorpseEntity corpseEntity); // 0x078569d8
	static System.Void HandleEquipShowOption(System.Collections.Generic.List<System.Int64> wearItemTableIds, System.Collections.Generic.IEnumerable<System.Int64> costumes, System.Int64 entityId, System.Boolean hideHelmet, System.Boolean hideBag, System.Boolean onlyShowEquip); // 0x07856464
	System.Boolean TryUpdateEquips(WizardGames.Soc.Common.Entity.IEquipEntity equipEntity); // 0x07856b2c
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x078573ec
	System.Void OnDestroy(); // 0x078577bc
	System.Void .ctor(); // 0x07857a14
	static System.Void .cctor(); // 0x07857ba8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.ClientLifeCycleSystem : WizardGames.Soc.Common.Systems.ReactiveSystemBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PlayerEntity> playerEntities; // 0x38
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Entity.PlayerEntity> rebornPlayerEntities; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.PlayerEntity> toRemoveList; // 0x48
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Go.IEntityGo> goDictionary; // 0x50
	WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo MgrGo; // 0x58
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PlayerEntity> woundedPlayers; // 0x60
	System.Int32 raycastMask; // 0x68
	System.Int64 subscribeId; // 0x70
	System.Boolean get_handleSnapshotEvent(); // 0x07857c7c
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x07857ce0
	System.Int32 get_eventQueueId(); // 0x07857d44
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05523a54
	System.Void OnEntityCreate(WizardGames.Soc.Common.Entity.IEntity entity); // 0x078584a8
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x078585f8
	System.Void OnLifeCycleFlagsChange(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int32 oldValue, System.Int32 newValue); // 0x0785870c
	System.Void CheckUIDying(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity, System.Int32 oldValue, System.Int32 newValue); // 0x07858b7c
	System.Void OnEnterPoseDyingStateIncap(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x078591b4
	System.Void OnLeavePoseDyingStateIncap(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0785927c
	System.Void OnDestroy(); // 0x055049cc
	System.Void ExecuteEvent(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x07859844
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0785a920
	System.Void HandleReborn(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x07858e18
	System.Void HandleRecover(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0785a38c
	System.Void HandleDying(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0785a5fc
	System.Void HandleWounded(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0785a168
	System.Void HandleDied(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0785a670
	System.Void OnDead(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0785bd00
	System.Void OnReborn(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0785bf04
	System.Void OnEnterActive(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0785c15c
	System.Void SetAidButton(WizardGames.Soc.Common.Entity.PlayerEntity serverMyEntity); // 0x0785b0a8
	WizardGames.Soc.SocClient.Systems.ClientLifeCycleSystem.LifeEventType GetLifeEvent(System.Int32 currentLifeFlag, System.Int32 lastLifeFlag); // 0x07859fe8
	System.Void .ctor(); // 0x0785c27c
	static System.Void .cctor(); // 0x0785c378
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Systems.ClientLifeCycleSystem.LifeEventType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Systems.ClientLifeCycleSystem.LifeEventType Reborning = 0;
	static WizardGames.Soc.SocClient.Systems.ClientLifeCycleSystem.LifeEventType Reborn = 1;
	static WizardGames.Soc.SocClient.Systems.ClientLifeCycleSystem.LifeEventType Wounded = 2;
	static WizardGames.Soc.SocClient.Systems.ClientLifeCycleSystem.LifeEventType Recover = 3;
	static WizardGames.Soc.SocClient.Systems.ClientLifeCycleSystem.LifeEventType Dying = 4;
	static WizardGames.Soc.SocClient.Systems.ClientLifeCycleSystem.LifeEventType DyingEnd = 5;
	static WizardGames.Soc.SocClient.Systems.ClientLifeCycleSystem.LifeEventType Died = 6;
	static WizardGames.Soc.SocClient.Systems.ClientLifeCycleSystem.LifeEventType UnDefine = 7;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.ClientLifeCycleSystem.<>c__DisplayClass19_0 : System.Object
{
	System.Boolean isAidingOther; // 0x10
	System.Void .ctor(); // 0x0785914c
	System.Void <CheckUIDying>b__0(WizardGames.Soc.SocClient.Ui.UiDying uiDyingWin); // 0x0785c44c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.ClientPlayer30FPSSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x10
	static SocLogger <mLogger>k__BackingField; // 0x0
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0785c4d4
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0785c538
	System.Void OnDestroy(); // 0x0785c608
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0785c668
	System.Void .ctor(); // 0x0785c778
	static System.Void .cctor(); // 0x0785c7e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.ClientPlayerInteractiveSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.DataSet.CommonDataSet<Share.Common.ObjPool.Alpha3PooledObjectBase> PlayerInteractiveDisplayRequestSet; // 0x28
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer myPlayer; // 0x30
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0785c8b4
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0785c918
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0785ca0c
	System.Void OnDestroy(); // 0x0785cda0
	System.Void .ctor(); // 0x0785ce00
	static System.Void .cctor(); // 0x0785ce68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.ClientPlayerSafetySystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger <logger>k__BackingField; // 0x0
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x10
	System.Action<WizardGames.Soc.SocClient.Ui.ComOngoingTip> _showDistanceFromInner; // 0x18
	System.Text.StringBuilder stringConnection; // 0x20
	WizardGames.Soc.Common.Character.ESafeAreaType lastSafeAreaType; // 0x28
	System.Boolean hostileNeedUpdate; // 0x2c
	WizardGames.Soc.Common.Unity.Soc.Common.Unity.Runtime.Safety.SafeAreaFuns.EHostileHintType hostileHintType; // 0x30
	System.Boolean CloseHoldItem; // 0x34
	System.Single tipHideTime; // 0x38
	System.Boolean isShowingDynamicMonumentTip; // 0x3c
	static SocLogger get_logger(); // 0x0785cf3c
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0785cfc4
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0785d028
	System.Void OnDestroy(); // 0x0785d184
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0785d1f4
	System.Void ShowHostileHudMsg(System.Single totalTime); // 0x0785ddac
	System.Void HostileHudUpdateFunction(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData data); // 0x0785eea8
	System.Boolean HostileHudDisappear(); // 0x0785f1d4
	System.Void ShowInnerHUDMsg(); // 0x0785d944
	System.Void ShowBetweenHUDMsg(); // 0x0785daf8
	System.Boolean InnerHUDDisappear(); // 0x0785f358
	System.Boolean BetweenHUDDisappear(); // 0x0785f4b4
	System.Void ShowInfoTip(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0785dfbc
	System.Void ShowWarningTip(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0785e3c8
	System.Void ShowErrorTip(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0785e71c
	System.Boolean get_IsShowingDynamicMonumentTip(); // 0x07860078
	System.Void set_IsShowingDynamicMonumentTip(System.Boolean value); // 0x0785eacc
	System.Void ShowDynamicMonumentTip(); // 0x078600dc
	System.Void HideDynamicMonumentTip(); // 0x07860248
	System.Void OnEntityEnterMonument(); // 0x0785fb5c
	System.Single GetResumeDangerTime(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0785dcac
	System.Void ShowDistanceFromInner(WizardGames.Soc.SocClient.Ui.ComOngoingTip tip); // 0x07860398
	System.Boolean IsHoldInvalidWeapon(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0785f678
	System.Void UpdateDynamicMonumentHint(UnityEngine.Vector3 pos); // 0x0785eb7c
	System.Int32 CheckPlayerNearDynamicMonument(UnityEngine.Vector3 playerPos); // 0x078606d0
	System.Void .ctor(); // 0x07860984
	static System.Void .cctor(); // 0x078609f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.ClientPlayerSafetySystem.<>c__DisplayClass24_0 : System.Object
{
	WizardGames.Soc.SocClient.Systems.ClientPlayerSafetySystem <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.PlayerEntity entity; // 0x18
	System.Void .ctor(); // 0x0785f610
	System.Boolean <ShowInfoTip>b__0(); // 0x07860ac8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.ClientPlayerSafetySystem.<>c__DisplayClass25_0 : System.Object
{
	WizardGames.Soc.SocClient.Systems.ClientPlayerSafetySystem <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.PlayerEntity entity; // 0x18
	System.Void .ctor(); // 0x0785fa8c
	System.Boolean <ShowWarningTip>b__0(); // 0x07860b7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.ClientPlayerSafetySystem.<>c__DisplayClass26_0 : System.Object
{
	WizardGames.Soc.SocClient.Systems.ClientPlayerSafetySystem <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.PlayerEntity entity; // 0x18
	System.Void .ctor(); // 0x0785faf4
	System.Boolean <ShowErrorTip>b__0(); // 0x07860c44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.ClientSwitchHeldItemSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.DataSet.CommonDataSet<Share.Common.ObjPool.Alpha3PooledObjectBase> PlayerSwitchHeldItemSet; // 0x28
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer myPlayer; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Combat.PlayerSwitchHeldItemData> finalSwitchData; // 0x38
	System.Int64 weaponChangeSubscribe; // 0x40
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x07860d0c
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x07860d70
	System.Void OnCreateEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07860fdc
	static System.Void OnCurrentHeldItemChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldId, System.Int64 newId); // 0x078611d0
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x07861454
	System.Void CheckAutoDriveState(System.Int64 oldId, System.Int64 newId); // 0x07861bfc
	System.Void OnDestroy(); // 0x07861e70
	System.Void .ctor(); // 0x07861ff0
	static System.Void .cctor(); // 0x078620a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.GapPropertyChangeSystem : WizardGames.Soc.Common.Systems.ReactiveSystemBase
{
	
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0786217c
	System.Boolean get_handleSnapshotEvent(); // 0x078621e0
	System.Int32 get_eventQueueId(); // 0x07862244
	System.Int32 get_MaxProcessNumPerTick(); // 0x078622a8
	System.Void ExecuteEvent(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0786230c
	System.Void OnDestroy(); // 0x078624bc
	System.Void .ctor(); // 0x0786251c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.TerritoryOutsideUpdateSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x07862584
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x078625e8
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x078626b8
	System.Void OnDestroy(); // 0x078627ac
	System.Void .ctor(); // 0x07862864
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.WireUpdateViewSystem : WizardGames.Soc.Common.Systems.ReactiveSystemBase
{
	
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x078628cc
	System.Boolean get_handleSnapshotEvent(); // 0x07862930
	System.Int32 get_eventQueueId(); // 0x07862994
	System.Int32 get_MaxProcessNumPerTick(); // 0x078629f8
	System.Void ExecuteEvent(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x07862a5c
	System.Void OnDestroy(); // 0x07862bac
	System.Void .ctor(); // 0x07862c0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.HumanoidCorpseRenderSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.CorpseEntity> corpseEntities; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Go.IEntityGo> gos; // 0x30
	WizardGames.Soc.Common.DataSet.CommonDataSet<Share.Common.ObjPool.Alpha3PooledObjectBase> corpseRenderDataSet; // 0x38
	System.Collections.Generic.List<System.Int32> tmpDeathParamList; // 0x40
	WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo MgrGo; // 0x48
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Corpse.CorpseRenderData> noResponseCorpseRenderDataSet; // 0x50
	System.Int32 corpseShowDeathMaxDistance; // 0x58
	System.Collections.Generic.List<UnityEngine.Collider> tempHits; // 0x60
	System.String defaultDeathAnimPath; // 0x68
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x07862c74
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x07862cd8
	System.Void OnDestroy(); // 0x07863008
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x078630d0
	System.Void ExecuteMonsterCorpse(WizardGames.Soc.SocClient.Corpse.CorpseRenderData data); // 0x07863d18
	System.Void PlayAnimatorState(WizardGames.Soc.SocClient.Corpse.CorpseRenderData data, UnityEngine.Animator animator, System.String animatorStateName, System.Single normalizedTime); // 0x0786462c
	System.Void TryPlayDeadAudio(WizardGames.Soc.SocClient.Corpse.CorpseRenderData data, WizardGames.Soc.Common.Entity.CorpseEntity entity); // 0x07864348
	System.Void .ctor(); // 0x078647a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.CorrectEffectTransSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	WizardGames.Soc.SocClient.Effect.CorrectedEffectData.CorrectedEffectDataSet correctedEffectDataSet; // 0x10
	System.UInt64 loadConfigTask; // 0x18
	static WizardGames.Soc.Common.Unity.Character.CorrectEffectConfig correctEffectConfig; // 0x0
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x20
	UnityEngine.GameObject bindGo; // 0x28
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x07864838
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0786489c
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x07864af0
	System.Void OnDestroy(); // 0x07864e38
	System.Void .ctor(); // 0x07864f60
	System.Void <OnCreate>b__7_0(System.UInt64 loaderid, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> result); // 0x07864fc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.DamageMessage : System.Object
{
	
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.DamageDataSystem : WizardGames.Soc.Common.Systems.ReactiveSystemBase
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.DamageMessage> DamageMessages; // 0x8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.DamageDataCache> damageDataCacheList; // 0x38
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x078650cc
	System.Boolean get_handleSnapshotEvent(); // 0x07865130
	System.Int32 get_eventQueueId(); // 0x07865194
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x07865224
	System.Void ExecuteEvent(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x07865318
	System.Void CreateDamageAudioData(WizardGames.Soc.Common.SimpleCustom.DamageDataEvent data); // 0x07866628
	System.Void CreateDamageVoiceAudioData(WizardGames.Soc.Common.SimpleCustom.DamageDataEvent data); // 0x0786701c
	System.Boolean OpenDamageScreenEffectWindow(WizardGames.Soc.Common.Entity.PlayerEntity entity, System.Action onWinEnabledAction); // 0x07867480
	System.Boolean OpenEmitFontWindow(WizardGames.Soc.Common.Entity.PlayerEntity entity, System.Action onWinEnabledAction); // 0x07867648
	System.Void .ctor(); // 0x07867a18
	static System.Void .cctor(); // 0x07867acc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.DamageDataSystem.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.Common.SimpleCustom.DamageDataEvent data; // 0x10
	WizardGames.Soc.SocClient.Systems.DamageDataSystem <>4__this; // 0x18
	System.Void .ctor(); // 0x078665c0
	System.Void <ExecuteEvent>b__0(); // 0x07867ba0
	System.Void <ExecuteEvent>b__1(); // 0x07867c58
	System.Void <ExecuteEvent>b__2(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07867e2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.DamageDataSystem.<>c__DisplayClass14_0 : System.Object
{
	System.Action onWinEnabledAction; // 0x10
	System.Void .ctor(); // 0x07867948
	System.Void <OpenDamageScreenEffectWindow>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07867f40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.DamageDataSystem.<>c__DisplayClass15_0 : System.Object
{
	System.Action onWinEnabledAction; // 0x10
	System.Void .ctor(); // 0x078679b0
	System.Void <OpenEmitFontWindow>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07867fd8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.DamageDataCache : System.Object
{
	System.Int64 targetId; // 0x10
	System.Single damage; // 0x18
	System.Byte damageBuff; // 0x1c
	System.Single hitPointX; // 0x20
	System.Single hitPointY; // 0x24
	System.Single hitPointZ; // 0x28
	WizardGames.Soc.Common.Combat.HitPart hitPart; // 0x2c
	System.Int32 killType; // 0x30
	System.Int32 targetType; // 0x34
	System.Int32 damageType; // 0x38
	System.Int32 damageRelation; // 0x3c
	System.Int64 WeaponTableId; // 0x40
	System.Void Init(WizardGames.Soc.Common.SimpleCustom.DamageDataEvent damageDataEvent); // 0x078677fc
	System.Void CopyFrom(WizardGames.Soc.SocClient.Systems.DamageDataCache data); // 0x07868070
	System.Void Clear(); // 0x078678d0
	System.Void .ctor(); // 0x07868124
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.EffectDataSystem : WizardGames.Soc.Common.Systems.ReactiveSystemBase
{
	SocLogger logger; // 0x38
	Effect.Manager.MgrEffect mgrEffect; // 0x40
	System.Action<System.Boolean,Effect.EffectItem,System.Object> loadMovingEffectCompleted; // 0x48
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0786818c
	System.Boolean get_handleSnapshotEvent(); // 0x078681f0
	System.Int32 get_eventQueueId(); // 0x07868254
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x078682e4
	System.Void ExecuteEvent(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x07868418
	System.Boolean EffectEventAnalyse(WizardGames.Soc.Common.SimpleCustom.EffectDataEvent data); // 0x078689e8
	System.Void LoadMovingEffectCompleted(System.Boolean success, Effect.EffectItem effectItem, System.Object o); // 0x078690f8
	System.Boolean ShouldPlayDecal(WizardGames.Soc.Common.SimpleCustom.EffectDataEvent data); // 0x07868e10
	System.Void .ctor(); // 0x0786925c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.EffectDissipateSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	System.Collections.Generic.List<Effect.DissipateEffectDisplay> dissipateEffectDisplays; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,Effect.DissipateEffectDisplay> dissipateEffectDisplayDict; // 0x18
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x07869354
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x078693b8
	System.Void OnDestroy(); // 0x07869490
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0786950c
	System.Void .ctor(); // 0x078696a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.FireEffectSystem : WizardGames.Soc.Common.Systems.ReactiveSystemBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.gun.GunEffect>> FirstGunEffectMap; // 0x38
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.gun.GunEffect>> ThirdGunEffectMap; // 0x40
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.WeaponCustom> weaponEntities; // 0x48
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.part.PartEffect,WizardGames.Soc.Common.Data.part.PartBase> corrections; // 0x50
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0786970c
	System.Boolean get_handleSnapshotEvent(); // 0x07869770
	System.Int32 get_eventQueueId(); // 0x078697d4
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x07869838
	System.Void ExecuteEvent(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x07869bb0
	System.Void ModifyFpEffectCrossSwitch(UnityEngine.GameObject effect, System.Boolean crossSwitch); // 0x0786c308
	System.Void InitWeaponFireEffectTable(); // 0x07869920
	System.Void AddGunEffectMap(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.gun.GunEffect>> gunEffectMap, WizardGames.Soc.Common.Data.gun.GunEffect gunEffect); // 0x0786c438
	System.Void TryUseCharacterEffectDataCache(System.Int64 playerEntityId, Effect.CharacterEffect.CharacterEffectData effectData, WizardGames.Soc.Common.Data.gun.GunEffect effectTable, UnityEngine.Transform point, System.Boolean isFp, System.Int32 overwriteID, UnityEngine.Vector3 scale); // 0x0786bc08
	System.Void UpdateFireEffectCorrection(WizardGames.Soc.Common.CustomType.WeaponCustom weapon, System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.part.PartEffect,WizardGames.Soc.Common.Data.part.PartBase>& corrections); // 0x0786b71c
	System.Void .ctor(); // 0x0786c648
	static System.Void .cctor(); // 0x0786c700
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.FireEffectSystem.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Effect.WeaponEffectData.WeaponEffectData data; // 0x10
	System.Int64 weaponEntityId; // 0x18
	WizardGames.Soc.SocClient.Systems.FireEffectSystem <>4__this; // 0x20
	Effect.CharacterEffect.CharacterEffectData characterEffectData; // 0x28
	System.Boolean isFp; // 0x30
	System.Void .ctor(); // 0x058455f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.FireEffectSystem.<>c__DisplayClass12_1 : System.Object
{
	WizardGames.Soc.Common.Data.gun.GunEffect effectTable; // 0x10
	WizardGames.Soc.Common.Entity.PlayerEntity entity; // 0x18
	WizardGames.Soc.Common.Entity.MonsterEntity monsterEntity; // 0x20
	UnityEngine.Transform point; // 0x28
	System.Int32 overwriteEffectId; // 0x30
	UnityEngine.Vector3 scale; // 0x34
	System.Int32 expectedSwitchSeq; // 0x40
	WizardGames.Soc.SocClient.Systems.FireEffectSystem.<>c__DisplayClass12_0 CS$<>8__locals1; // 0x48
	System.Void .ctor(); // 0x05845660
	System.Void <ExecuteEvent>b__0(System.Int64 timerId, System.Object d, System.Boolean needDelete); // 0x058456c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.GunkickSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	Combat.Shoot.Formula.MgrGunkickFormula mgrGunkickFormula; // 0x10
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x18
	System.Boolean init_gunkick; // 0x20
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05845854
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05523a54
	System.Void OnSwitchCompleteAction(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x05845a68
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05845ae8
	System.Void OnDestroy(); // 0x055049cc
	System.Void .ctor(); // 0x05846364
	static System.Void .cctor(); // 0x058463cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.GunTrapSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	System.Collections.Generic.LinkedList<WizardGames.Soc.Common.Component.GunTrapComponent> componentList; // 0x28
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05846460
	System.Void AddComponent(WizardGames.Soc.Common.Component.GunTrapComponent gunTrapComponent); // 0x058464c4
	System.Void RemoveComponent(WizardGames.Soc.Common.Component.GunTrapComponent gunTrapComponent); // 0x05846560
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x058465fc
	System.Void .ctor(); // 0x058467a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.HeldItemInvisibleBitData : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int64 EntityID; // 0x20
	System.Boolean IsFp; // 0x28
	System.Boolean Invisible; // 0x29
	WizardGames.Soc.Common.State.Character.HeldItemInvisibleStateEnum Flag; // 0x2c
	static SocLogger logger; // 0x0
	static System.Void CreateInvisibleBitData(System.Int64 hostId, WizardGames.Soc.Common.State.Character.HeldItemInvisibleStateEnum flag, System.Int32 inVisibleState, System.Boolean visible, System.Boolean isFp, System.Boolean needCompare); // 0x05846854
	static System.Boolean IsStateEqual(WizardGames.Soc.Common.State.Character.HeldItemInvisibleStateEnum flag, System.Int32 inVisibleState, System.Boolean visible); // 0x058469e0
	System.Void Dispose(); // 0x05846a6c
	System.Void .ctor(); // 0x05846ae4
	static System.Void .cctor(); // 0x05846b4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.HelditemVisiableSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	WizardGames.Soc.Common.DataSet.CommonDataSet<Share.Common.ObjPool.Alpha3PooledObjectBase> HeldItemInvisibleBitSet; // 0x28
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer myPlayer; // 0x30
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05846c20
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05846c84
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05846d78
	System.Boolean SetInvisible(System.Int32& flag, WizardGames.Soc.Common.State.Character.HeldItemInvisibleStateEnum bit, System.Boolean invisible); // 0x05847108
	System.Void .ctor(); // 0x058471b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.JackhammerChargeDetectSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer myPlayer; // 0x28
	WizardGames.Soc.SocClient.Manager.MgrConstruction construction; // 0x30
	System.Collections.Generic.List<System.Int64> caches; // 0x38
	System.Single checkDis; // 0x40
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05847220
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05847284
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x058473c4
	System.Void CheckRechargeable(WizardGames.Soc.Common.Entity.IItemEntity item, System.Int32 deltaTime, System.Boolean active); // 0x05847b6c
	static System.Void RemoteCallJackHammerCharge(WizardGames.Soc.Common.Entity.IRechargeableEntity entity); // 0x05847f6c
	System.Void .ctor(); // 0x05848470
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.LightSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.ClientLight.LightItem> lightItemList; // 0x10
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05848524
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05848588
	System.Void OnDestroy(); // 0x05848640
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x058486ac
	System.Void .ctor(); // 0x05848a10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.MonsterAnimatorAfterLoopRenderSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.MonsterEntity> monsterEntities; // 0x10
	WizardGames.Soc.Common.Unity.Monster.Animation.AnimalAnimatorContext animatorContext; // 0x18
	WizardGames.Soc.Common.Unity.Character.AnimParametersAnimal animParams; // 0x30
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05848a78
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05848adc
	System.Void OnDestroy(); // 0x05848bb8
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05848c18
	System.Void .ctor(); // 0x05848fc4
	static System.Void .cctor(); // 0x0584902c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.MonsterAnimatorJobSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static System.Int32 DebugEntityId; // 0x0
	static SocLogger logger; // 0x8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.MonsterEntity> MonsterEntities; // 0x10
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData> jobDataArray; // 0x18
	WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData jobConstData; // 0x28
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.TpMaskWeightConfGroup> MaskArray; // 0x30
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.TpMaskWeightConfGroup> AoMaskArray; // 0x40
	static System.Collections.Generic.Dictionary<System.Int64,UnityEngine.Vector3> _targetPositionsCache; // 0x10
	System.UInt16 jobDataCount; // 0x50
	System.Int64 currentWeaponIdSubscribeId; // 0x58
	Contexts.ClientContext clientContext; // 0x60
	System.IntPtr _hdAnimationNestedArray; // 0x68
	System.UInt16 _hdAnimationNestedArraySize; // 0x70
	System.Int32 _hdAnimationNestedArrayRealSize; // 0x74
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05849100
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05849164
	System.Void OnEntityCreate(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05849e6c
	System.Void OnEntityDowngrade(WizardGames.Soc.Common.Entity.IEntity entity); // 0x0584a0cc
	System.Void SubscribePropertyChange(WizardGames.Soc.Common.Entity.MonsterEntity entity); // 0x05849fd4
	System.Void UnSubscribePropertyChange(WizardGames.Soc.Common.Entity.MonsterEntity entity); // 0x0584a234
	System.Void CurrentWeaponIdChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0584a868
	System.Void UpdateTpAniHeldItemData(WizardGames.Soc.Common.Entity.MonsterEntity entity); // 0x0584a2bc
	System.Void OnDestroy(); // 0x0584a958
	static System.Void ClearFrameCache(); // 0x0584ac5c
	static System.Boolean TryGetAimCachePosition(System.Int64 targetId, UnityEngine.Vector3& position); // 0x0584ad04
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0584add0
	System.Void DynamicsExpandNativeArrayCapacity<T>(Unity.Collections.NativeArray<T>& dataArray, System.Int32 count); // 0x052af1f0
	WizardGames.Soc.Common.Unity.Animation.SocAnimatorRuntime GetAnimator(WizardGames.Soc.Common.Entity.MonsterEntity entity); // 0x0584bc90
	System.Void .ctor(); // 0x0584bdec
	static System.Void .cctor(); // 0x0584be5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.MountableClientLateTickSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.IBaseMountableEntity> mountableEntities; // 0x10
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0584bf94
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0584bff8
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0584c0c8
	System.Void OnDestroy(); // 0x0584c408
	System.Void .ctor(); // 0x0584c468
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.MountableClientTickSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.IBaseMountableEntity> mountableEntities; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> entityUpdateTime; // 0x18
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0584c4d0
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0584c534
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0584c6e0
	System.Void UpdateEntity(WizardGames.Soc.Common.Entity.IBaseMountableEntity entity, System.Int32 deltaTime); // 0x0584c8f8
	System.Void OnGoRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x0584cc2c
	System.Void OnDestroy(); // 0x0584cd40
	System.Void .ctor(); // 0x0584ce88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioEventSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PlayerEntity> playerEntities; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Go.IEntityGo> gos; // 0x30
	WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo baseMgrEntityGo; // 0x38
	System.Collections.Generic.Dictionary<System.Int32,System.ValueTuple<System.Action<WizardGames.Soc.Common.Contexts.Context,WizardGames.Soc.Common.Entity.PlayerEntity>,System.Action<WizardGames.Soc.Common.Contexts.Context,WizardGames.Soc.Common.Entity.PlayerEntity>>> eventDict; // 0x40
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0584cf40
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05523a54
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0584d580
	System.Void Execute(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0584d874
	System.Void OnDestroy(); // 0x055049cc
	System.Void MyFireEvent(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0584de00
	System.Void OtherFireEvent(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0584e0f8
	System.Void MyFireEndEvent(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0584e470
	System.Void OtherFireEndEvent(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0584e644
	System.Void UnEquipWeapon(System.Int64 entityId, System.Int64 weaponId); // 0x0584e828
	System.Void MySwitchEvent(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0584e940
	System.Void OtherSwitchEvent(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0584e9c8
	System.Void MyPullBoltEvent(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0584ea44
	System.Void OtherPullBoltEvent(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0584eb74
	System.Void OnStartReload(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams player); // 0x0584ede0
	System.Void MyReloadEvent(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0584ef18
	System.Void OtherReloadEvent(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0584f02c
	System.Void .ctor(); // 0x0584f27c
	static System.Void .cctor(); // 0x0584f2e4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Systems.ERecoilState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Systems.ERecoilState Idle = 0;
	static WizardGames.Soc.SocClient.Systems.ERecoilState Start = 1;
	static WizardGames.Soc.SocClient.Systems.ERecoilState RecoilStart = 2;
	static WizardGames.Soc.SocClient.Systems.ERecoilState Recoil = 3;
	static WizardGames.Soc.SocClient.Systems.ERecoilState Resume = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.RecoilData : System.Object
{
	System.Boolean Valid; // 0x10
	UnityEngine.Vector3 Offset; // 0x14
	UnityEngine.Vector3 Forward; // 0x20
	System.Single ResumeTime; // 0x2c
	System.Single RecoilMaxForward; // 0x30
	System.Single RecoilMinForward; // 0x34
	System.Single RecoilRandSlider; // 0x38
	System.Single RecoilRandUp; // 0x3c
	System.Single FirstRecoilForward; // 0x40
	System.Single GunKickAnimMinZ; // 0x44
	System.Single GunKickAnimSlopeZ; // 0x48
	System.Single ResumeMaxTime; // 0x4c
	System.Single RecoilStartForward; // 0x50
	System.Single RecoilForwardWeight; // 0x54
	System.Single OffsetSliderWeight; // 0x58
	System.Single HipDecline; // 0x5c
	System.Int32 ShotsFired; // 0x60
	System.Int32 DecreaseShotsFired; // 0x64
	WizardGames.Soc.SocClient.Systems.ERecoilState State; // 0x68
	SocWeaponRecoilCurve RecoilCurve; // 0x70
	System.String curvePath; // 0x78
	System.UInt64 curveTaskId; // 0x80
	WizardGames.AssetPool.AssetPoolHandle curveAssetHandle; // 0x88
	UnityEngine.GameObject bindGo; // 0x90
	System.Void Init(WizardGames.Soc.Common.Data.gun.GunRecoil data); // 0x0584f3b8
	System.Void OnCurveLoadFinish(System.UInt64 loaderId, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> results); // 0x0584f6ac
	System.Void Release(); // 0x0584f7e8
	System.Void ReleaseCurve(); // 0x0584f554
	System.Void .ctor(); // 0x0584f84c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.MyGunAnimSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer MgrMyPlayer; // 0x10
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0584f8c8
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0584f92c
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 interval, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0584f9fc
	System.Void OnDestroy(); // 0x0584ff0c
	System.Void .ctor(); // 0x0584ff6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.MyGunSwaySystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	WizardGames.Soc.Common.Utility.SpringDamper _dampingAdsYaw; // 0x10
	WizardGames.Soc.Common.Utility.SpringDamper _dampingAdsPitch; // 0x18
	WizardGames.Soc.Common.Utility.SpringDamper _dampingYaw; // 0x20
	WizardGames.Soc.Common.Utility.SpringDamper _dampingPitch; // 0x28
	System.Single _lastMouseYaw; // 0x30
	System.Single _lastMousePitch; // 0x34
	System.Single _lastSpeedYaw; // 0x38
	System.Single _lastSpeedPitch; // 0x3c
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer _mgrMyPlayer; // 0x40
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0584ffd4
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05850038
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 interval, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05850270
	System.Void OnDestroy(); // 0x05850ff4
	System.Void .ctor(); // 0x05851054
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.MyHitRequestSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Effect.CorrectedEffectData.CorrectedEffectDataSet correctedEffectDataSet; // 0x10
	System.Collections.Generic.List<System.Int32> bulletHoleRiggingEntityTypeList; // 0x18
	WizardGames.Soc.Common.DataSet.CommonDataSet<Share.Common.ObjPool.Alpha3PooledObjectBase> hitRequestQueue; // 0x20
	System.Action<System.Boolean,Effect.EffectItem,System.Object> bloodEffectLoadCompleted; // 0x28
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x058510bc
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05851120
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0585176c
	System.Void OnDestroy(); // 0x05852928
	System.Int32 GetEntityTypeByCfgID(System.Int32 id); // 0x058515f0
	System.Void PlayMyHitFX(WizardGames.Soc.Common.SimpleCustom.HitRequest hitRequest, WizardGames.Soc.Common.Entity.IEntity target, WizardGames.Soc.Common.Combat.ColliderMaterialEnum materialEnum); // 0x05851a70
	System.Void DoPlayFx(System.Int64 hit_icon, System.Int32 hit_fx, System.Int32 hit_fx_extra, WizardGames.Soc.Common.SimpleCustom.HitRequest hitRequest, WizardGames.Soc.Common.Entity.IEntity target, WizardGames.Soc.Common.Combat.ColliderMaterialEnum materialEnum); // 0x05852988
	System.Boolean IsMovingTarget(System.Int64 targetId); // 0x05853810
	System.Void BloodEffectLoadCompleted(System.Boolean success, Effect.EffectItem effectItem, System.Object o); // 0x058539b4
	System.Void DoPlaySFx(System.String sfx_event, System.Boolean ui, System.String sfx_event_extra, WizardGames.Soc.Common.SimpleCustom.HitRequest hitRequest, WizardGames.Soc.Common.Combat.ColliderMaterialEnum materialEnum); // 0x0585327c
	System.Void .ctor(); // 0x05853a88
	static System.Void .cctor(); // 0x05853af0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.MyHitRequestSystem.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Systems.MyHitRequestSystem.<>c <>9; // 0x0
	static System.Func<System.UInt64,System.UInt64,System.Boolean> <>9__7_0; // 0x8
	static WizardGames.Soc.SocClient.Audio.WWise.AudioEventData.PostEventFinishedCallback <>9__11_0; // 0x10
	static WizardGames.Soc.SocClient.Audio.WWise.AudioEventData.PostEventFinishedCallback <>9__15_0; // 0x18
	static System.Void .cctor(); // 0x05853bc4
	System.Void .ctor(); // 0x05853c28
	System.Boolean <OnCreate>b__7_0(System.UInt64 arg1, System.UInt64 arg2); // 0x05853c90
	System.Void <PlayMyHitFX>b__11_0(WizardGames.Soc.SocClient.Audio.WWise.AudioEventData eventData, System.Object obj); // 0x05853dec
	System.Void <DoPlaySFx>b__15_0(WizardGames.Soc.SocClient.Audio.WWise.AudioEventData eventData, System.Object obj); // 0x05853f28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.MyJogPoseAnimSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x10
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05854004
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05854068
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05526948
	System.Void OnDestroy(); // 0x058544a4
	System.Void .ctor(); // 0x05854504
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.MySleepSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x10
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0585456c
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x058545d0
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x058546a0
	System.Void OnDestroy(); // 0x05854d38
	System.Void .ctor(); // 0x05854d98
	static System.Void .cctor(); // 0x05854e00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.MyWeaponPreSystem : WizardGames.Soc.Common.Unity.Systems.UserCmdSystem.WeaponPreSystem
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer MyPlayer; // 0x10
	System.Boolean changeFpWeapon; // 0x18
	System.Boolean changeTpWeapon; // 0x19
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05854ed4
	System.Void OnDestroy(); // 0x05855064
	System.Void EquipWeapon(System.Int64 oldEquipId, System.Int64 newEquipId); // 0x05855180
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05855204
	System.Void .ctor(); // 0x0585549c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.MyWeaponSpreadSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	System.Single preSpread; // 0x10
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05855504
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05855568
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x058555dc
	System.Void OnDestroy(); // 0x058557f0
	System.Void .ctor(); // 0x05855850
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.ObserverSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	UnityEngine.RaycastHit[] Hits; // 0x10
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x058558b8
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0585591c
	System.Void OnGoAdd(WizardGames.Soc.Common.Unity.Go.IEntityGo entityGo); // 0x05523a54
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05526948
	System.Void OnDestroy(); // 0x05856e48
	System.Void .ctor(); // 0x055049cc
	static System.Void .cctor(); // 0x05856f5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.ObserverSystem.<>c__DisplayClass5_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.HpBarInfo info; // 0x10
	System.Void .ctor(); // 0x05856094
	System.Void <OnGoAdd>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05857030
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.TpOffsetYawSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x10
	WizardGames.Soc.SocClient.Control.InputAdditional InputAdditional; // 0x18
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05857120
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05857184
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05857254
	System.Void OnDestroy(); // 0x0585768c
	System.Void .ctor(); // 0x058576ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.NaturalSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	System.Int32 torch; // 0x28
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Gathering.OreMarker> oreMarkerDict; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.OreEntity> nearOreDict; // 0x40
	System.Collections.Generic.List<System.Int64> toRemoveList; // 0x48
	System.Int32 showOreMaxDistance; // 0x50
	System.Int32 showOreMaxDistanceSqr; // 0x54
	UnityEngine.Vector3 lastCheckPlayerPos; // 0x58
	System.Single lastCheckRotY; // 0x64
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0585778c
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x058577f0
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05857a08
	System.Void .ctor(); // 0x05858720
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.PlayerTpAnimatorSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PlayerEntity> LocalPlayerEntities; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PlayerEntity> playerEntities; // 0x18
	Contexts.ClientContext clientContext; // 0x20
	WizardGames.Soc.Common.Entity.PlayerEntity myEntity; // 0x28
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.TpAniPlayerDebugBone> DebugBones; // 0x30
	Unity.Collections.NativeArray<WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData> tpAnimationJobDataArray; // 0x40
	WizardGames.Soc.SocClient.Player.Animation.TpAniConstData tpConstData; // 0x50
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.TpMaskWeightConfGroup> MaskArray; // 0xa0
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.TpMaskWeightConfGroup> AoMaskArray; // 0xb0
	System.IntPtr TpAnimationNestedArray; // 0xc0
	System.Int32 TpAnimationNestedArraySize; // 0xc8
	System.Int32 TpAnimationNestedArrayRealSize; // 0xcc
	Unity.Collections.NativeArray<WizardGames.Soc.SocClient.Player.Animation.SnapEventData> snapEventDataArray; // 0xd0
	System.Int32 snapEventCount; // 0xe0
	System.Int32 jobDataCount; // 0xe4
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Character.TpVehicleSeatTbData> tpVehicleSeatTbData; // 0xe8
	WizardGames.Soc.Common.DataSet.CommonDelegate.EventDelegate2<WizardGames.Soc.Common.SimpleCustom.QuickDrawEvent,WizardGames.Soc.SocClient.Player.Animation.ESnapEvent> quickDrawEventDelegate; // 0xf0
	WizardGames.Soc.Common.DataSet.CommonDelegate.EventDelegate2<WizardGames.Soc.Common.SimpleCustom.FireDataEvent,WizardGames.Soc.SocClient.Player.Animation.ESnapEvent> fireEventDelegate; // 0xf8
	WizardGames.Soc.Common.DataSet.CommonDelegate.EventDelegate2<WizardGames.Soc.Common.SimpleCustom.OpenDoorEvent,WizardGames.Soc.SocClient.Player.Animation.ESnapEvent> openDoorEventDelegate; // 0x100
	WizardGames.Soc.Common.DataSet.CommonDelegate.EventDelegate2<WizardGames.Soc.Common.SimpleCustom.PickUpEvent,WizardGames.Soc.SocClient.Player.Animation.ESnapEvent> pickUpEventDelegate; // 0x108
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Entity.PlayerEntity> waitGoEntities; // 0x110
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.Animation.SnapEventData>> SnapEventDataDic; // 0x118
	System.Int64 UnaliveStateSubscribeId; // 0x120
	System.Int64 MoveStateSubscribeId; // 0x128
	System.Int64 MoveJumpStateSubscribeId; // 0x130
	System.Int64 MoveLadderStateSubscribeId; // 0x138
	System.Int64 MoveSwimStateSubscribeId; // 0x140
	System.Int64 MoveZiplineSubscribeId; // 0x148
	System.Int64 PoseStateSubscribeId; // 0x150
	System.Int64 PoseDyingStateSubscribeId; // 0x158
	System.Int64 ActionStateSubscribeId; // 0x160
	System.Int64 AttackSubStateSubscribeId; // 0x168
	System.Int64 ReloadStateSubscribeId; // 0x170
	System.Int64 BowStateSubscribeId; // 0x178
	System.Int64 ThrowStateSubscribeId; // 0x180
	System.Int64 ActionHoldStateSubscribeId; // 0x188
	System.Int64 AdsStateSubscribeId; // 0x190
	System.Int64 gestureSubscribeId; // 0x198
	System.Int64 ladderTargetIdSubscribeId; // 0x1a0
	System.Int64 ladderAbsorbTargetIdSubscribeId; // 0x1a8
	System.Int64 ladderEnterDirSubscribeId; // 0x1b0
	System.Int64 ladderLeaveDirSubscribeId; // 0x1b8
	System.Int64 ladderMoveFlagSubscribeId; // 0x1c0
	System.Int64 mountableIdSubscribeId; // 0x1c8
	System.Int64 horseMountDirSubscribeId; // 0x1d0
	System.Int64 vehicleTypeSubscribeId; // 0x1d8
	System.Int64 mountableTypeSubscribeId; // 0x1e0
	System.Int64 isDriverSubscribeId; // 0x1e8
	System.Int64 rotateYSubscribeId; // 0x1f0
	System.Int64 cmdYawSubscribeId; // 0x1f8
	System.Int64 adsOffsetProgressSubscribeId; // 0x200
	System.Int64 currentWeaponIdSubscribeId; // 0x208
	System.Int64 movement8DirectionSubscribeId; // 0x210
	System.Int64 movement4DirectionSubscribeId; // 0x218
	System.Int64 rootMotionWarpingIndexSubscribeId; // 0x220
	System.Int64 inputSprintSubscribeId; // 0x228
	System.Int64 HeightSubscribeId; // 0x230
	System.Int64 speedXSubscribeId; // 0x238
	System.Int64 speedZSubscribeId; // 0x240
	System.Int64 speedYSubscribeId; // 0x248
	System.Int64 stateRecoveryReasonSubscribeId; // 0x250
	System.Int64 tryFireSubscribeId; // 0x258
	System.Int64 cmdPitchSubscribeId; // 0x260
	System.Int64 useAnimIndexSubscribeId; // 0x268
	System.Int64 item8SubscribeId; // 0x270
	System.Int64 mountSeatIndexSubscribeId; // 0x278
	System.Int64 attachHitMatIndexSubscribeId; // 0x280
	System.Int64 useHitIndexSubscribeId; // 0x288
	System.Int64 interactiveIdSubscribeId; // 0x290
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05858794
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x058587f8
	System.Void UpdateTpSkeletonDynamicsMaskData(); // 0x05859cb8
	System.Void UpdateTpSkeletonDynamicsAoMaskData(); // 0x0585a214
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05526948
	static System.Void DynamicsExpandNativeArrayCapacity<T>(Unity.Collections.NativeArray<T>& dataArray, System.Int32 count); // 0x052af1f0
	static System.Void DynamicsExpandNativeArrayCapacity<T>(System.IntPtr& dataArray, System.Int32& realSize, System.Int32 dataSize); // 0x052af1f0
	System.Void OnDestroy(); // 0x0585e8dc
	WizardGames.Soc.Common.Unity.Animation.SocAnimatorRuntime GetTpAnimator(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0585da30
	System.Void UpdateSnapEvent(Contexts.ClientContext context); // 0x0585d980
	System.Void CollectSnapEvent(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05523a54
	System.Void MakeSnapEvent(WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent snapshotEvent, WizardGames.Soc.SocClient.Player.Animation.ESnapEvent snapEvent); // 0x05525b70
	System.Void MakeSnapEvent(WizardGames.Soc.Common.SimpleCustom.FireDataEvent snapshotEvent, WizardGames.Soc.SocClient.Player.Animation.ESnapEvent snapEvent); // 0x0585f860
	System.Void UpdateDrawEvent(Contexts.ClientContext context); // 0x0585ee44
	System.Void UpdateQuickDrawEvent(Contexts.ClientContext context); // 0x0585f024
	System.Void UpdateFireEvent(Contexts.ClientContext context); // 0x0585f188
	System.Void UpdateOpenDoorEvent(Contexts.ClientContext context); // 0x0585f2ec
	System.Void UpdatePickUpEvent(Contexts.ClientContext context); // 0x0585f44c
	System.Void OnCreateEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x0585fa8c
	System.Void OnEntityDowngrade(WizardGames.Soc.Common.Entity.IEntity entity); // 0x0585fbe0
	System.Void OnTransChange(System.Int64 entityId); // 0x0586009c
	System.Void SubscribePropertyChange(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0585c4d0
	System.Void HeightChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05527728
	System.Void UnSubscribePropertyChange(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0585fd34
	System.Void InitPlayerJobData(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0586037c
	System.Void InitTpAniPlayerStateData(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05523a54
	System.Void UpdateTpAniHeldItemData(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05523a54
	System.Void UpdateTpAniHeldItemDataItem8(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x05523a54
	System.Void UpdateTpAniVehicleData(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05523a54
	System.Void UpdateTpAniVehicleDataSeatIndex(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05523a54
	System.Void PlayerUnaliveStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase inEntity, WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum oldValue, WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum newValue); // 0x0552b2a8
	System.Void PlayerMoveStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase inEntity, WizardGames.Soc.Common.Entity.PlayerMoveStateEnum oldValue, WizardGames.Soc.Common.Entity.PlayerMoveStateEnum newValue); // 0x0552b2a8
	System.Void PlayerMoveJumpStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase inEntity, System.Byte oldValue, System.Byte newValue); // 0x0552b2a8
	System.Void PlayerMoveLadderStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase inEntity, System.Byte oldValue, System.Byte newValue); // 0x0552b2a8
	System.Void PlayerMoveSwimStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase inEntity, System.Byte oldValue, System.Byte newValue); // 0x0552b2a8
	System.Void PlayerMoveZiplineStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase inEntity, System.Byte oldValue, System.Byte newValue); // 0x0552b2a8
	System.Void PlayerPoseStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase inEntity, System.Byte oldValue, System.Byte newValue); // 0x0552b2a8
	System.Void PlayerPoseDyingStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase inEntity, System.Byte oldValue, System.Byte newValue); // 0x0552b2a8
	System.Void PlayerActionStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase inEntity, System.Byte oldValue, System.Byte newValue); // 0x0552b2a8
	System.Void PlayerAttackSubStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase inEntity, System.Byte oldValue, System.Byte newValue); // 0x0552b2a8
	System.Void PlayerReloadStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase inEntity, System.Byte oldValue, System.Byte newValue); // 0x0552b2a8
	System.Void PlayerBowStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase inEntity, System.Byte oldValue, System.Byte newValue); // 0x0552b2a8
	System.Void PlayerThrowStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase inEntity, System.Byte oldValue, System.Byte newValue); // 0x0552b2a8
	System.Void PlayerAdsStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase inEntity, System.Byte oldValue, System.Byte newValue); // 0x0552b2a8
	System.Void GestureChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05525bf4
	System.Void LadderTargetIdChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x058628e4
	System.Void LadderAbsorbTargetIdChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x058629c4
	System.Void UpdateLadder(WizardGames.Soc.Common.Entity.PlayerEntity player); // 0x05523a54
	System.Void LadderEnterDirChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05525bf4
	System.Void LadderMoveFlagChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05525bf4
	System.Void LadderLeaveDirChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05525bf4
	System.Void MountableIdChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x05527160
	System.Void HorseMountDirChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 o, System.Int32 n); // 0x05525bf4
	System.Void VehicleTypeChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05525bf4
	System.Void MountableTypeChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05525bf4
	System.Void IsDriverChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0552b2a8
	System.Void RotateYChangeCallBack(WizardGames.Soc.Common.Entity.PlayerEntity player); // 0x05523a54
	System.Void CmdYawChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05527728
	System.Void AdsOffsetProgressChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05527728
	System.Void CurrentWeaponIdChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x05527160
	System.Void Movement8DirectionChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05525bf4
	System.Void Movement4DirectionChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05525bf4
	System.Void RootMotionWarpingIndexChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05525bf4
	System.Void InputSprintChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0552b2a8
	System.Void SpeedXChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05527728
	System.Void SpeedZChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05527728
	System.Void SpeedYChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05527728
	System.Void StateRecoveryReasonChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05525bf4
	System.Void TryFireChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05525bf4
	System.Void AttackHitMatChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05525bf4
	System.Void UseHitIndexChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte oldValue, System.Byte newValue); // 0x0552b2a8
	static System.Void ProcessTpJumpPose(WizardGames.Soc.Common.Entity.PlayerEntity player, CommonUnity.Runtime.Animation.ClientAnim anim, System.Single deltaSeconds); // 0x0585db8c
	System.Void InteractiveIdChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05525bf4
	System.Void CmdPitchChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05527728
	System.Void UseAnimIndexChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte oldValue, System.Byte newValue); // 0x0552b2a8
	System.Void Item8ChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x058641cc
	System.Void MountSeatIndexChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x058642bc
	static System.Void PlayInteractionState(WizardGames.Soc.Common.Entity.PlayerEntity entity, WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EOverrideLayer nextState, System.Single transitionTime, System.Single playRate, WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EOverrideLayer nowState); // 0x05508414
	System.Void .ctor(); // 0x05864488
	static System.Void .cctor(); // 0x0586454c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.PlayerTpAnimatorSystem.<>c__DisplayClass93_0 : System.Object
{
	WizardGames.Soc.SocClient.Systems.PlayerTpAnimatorSystem <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.PlayerEntity entity; // 0x18
	System.Void .ctor(); // 0x0586481c
	System.Void <SubscribePropertyChange>b__0(WizardGames.Soc.Share.Framework.PositionChangeEvent e); // 0x05864884
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.PlayerInvisibleBitData : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int64 EntityID; // 0x20
	System.Boolean IsFpModel; // 0x28
	System.Boolean IsFpMode; // 0x29
	System.Boolean Invisible; // 0x2a
	WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum Flag; // 0x2c
	static SocLogger logger; // 0x0
	static System.Void CreateInvisibleBitData(System.Int64 hostId, WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum flag, System.Int32 inVisibleState, System.Boolean visible, System.Boolean IsFpModel, System.Boolean IsFpCamera, System.Boolean needCompare); // 0x0586490c
	static System.Boolean IsStateEqual(WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum flag, System.Int32 inVisibleState, System.Boolean visible); // 0x05864aa8
	System.Void Dispose(); // 0x05864b34
	System.Void .ctor(); // 0x05864bac
	static System.Void .cctor(); // 0x05864c14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.PlayerVisibleSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	WizardGames.Soc.Common.DataSet.CommonDataSet<Share.Common.ObjPool.Alpha3PooledObjectBase> PlayernvisibleBitSet; // 0x28
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer myPlayer; // 0x30
	System.Collections.Generic.HashSet<System.Int64> ChangablePlayers; // 0x38
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05864ce8
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05864d4c
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05526948
	System.Boolean SetInvisible(System.Int32& flag, WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum bit, System.Boolean invisible); // 0x05865ad0
	System.Void .ctor(); // 0x05865b80
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Systems.HitObjDataValue : System.ValueType, System.IEquatable<WizardGames.Soc.SocClient.Systems.HitObjDataValue>
{
	System.Int32 DataIndex; // 0x10
	System.Int64 EntityId; // 0x18
	WizardGames.Soc.Common.Combat.SocRaycastHit raycastHit; // 0x20
	UnityEngine.GameObject hitGo; // 0x60
	UnityEngine.Vector3 direction; // 0x68
	System.Int32 entityTypeId; // 0x74
	WizardGames.Soc.Common.Entity.IEntity entity; // 0x78
	UnityEngine.GameObject entityGo; // 0x80
	System.Single distance; // 0x88
	System.Void Init(UnityEngine.RaycastHit raycastHit, UnityEngine.GameObject hitGo, UnityEngine.Vector3 direction, System.Int32 entityTypeId, WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject entityGo); // 0x05865c34
	System.Boolean Equals(WizardGames.Soc.SocClient.Systems.HitObjDataValue other); // 0x05865f78
	System.Boolean Equals(System.Object obj); // 0x05866118
	System.Int32 GetHashCode(); // 0x058661f0
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Systems.RaycastInfo : System.ValueType
{
	UnityEngine.Vector3 origin; // 0x10
	UnityEngine.Vector3 direction; // 0x1c
	System.Single distance; // 0x28
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.RaycastComparer : System.Object, System.Collections.Generic.IComparer<UnityEngine.RaycastHit>
{
	
	System.Int32 Compare(UnityEngine.RaycastHit hit1, UnityEngine.RaycastHit hit2); // 0x05866254
	System.Void .ctor(); // 0x05866318
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.RaycastSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer myPlayer; // 0x10
	Systems.MgrRaycast mgrRaycast; // 0x18
	WizardGames.Soc.SocClient.Systems.RaycastComparer raycastComparer; // 0x20
	UnityEngine.Ray viewRay; // 0x28
	UnityEngine.RaycastHit[] rayCastHitArrayCache; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> hitObjsList; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> ObstacleList; // 0x50
	static System.Comparison<WizardGames.Soc.SocClient.Systems.HitObjData> _HitSortAction; // 0x8
	static System.Comparison<WizardGames.Soc.SocClient.Systems.HitObjDataValue> rayHitComparer; // 0x10
	static System.Comparison<WizardGames.Soc.Common.Unity.Character.HitCastData> CastHitComparer; // 0x18
	WizardGames.Soc.SocClient.Systems.HitObjData defaultHitObjData; // 0x58
	System.Int32 rayDistance; // 0x60
	System.Int32 raycastMask; // 0x64
	System.Int32 obstacleMask; // 0x68
	static System.Int64[] ignoreEntityIds; // 0x20
	WizardGames.Soc.Common.Unity.Character.PlayerRayCastContext<WizardGames.Soc.SocClient.Systems.HitObjDataValue> rayCastContext; // 0x70
	WizardGames.Soc.Common.Unity.Character.PlayerRefRayCastContext<WizardGames.Soc.SocClient.Systems.HitObjDataValue> rayCastRefContext; // 0xb0
	static System.String IgnoreColliderName; // 0x28
	static WizardGames.Soc.SocClient.Systems.RaycastInfo CurrentRaycastInfo; // 0x30
	System.Collections.Generic.List<UnityEngine.RaycastHit> tempHits; // 0xd8
	System.Collections.Generic.List<WizardGames.Soc.Common.Combat.SocRaycastHit> tmpSocHitsList; // 0xe0
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05866380
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x058663e4
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05866758
	System.Void OnDestroy(); // 0x05866dc0
	System.Void PlayerClientRaycast(System.Single distance); // 0x058667f4
	System.Void OnCameraMove(UnityEngine.Matrix4x4 matrix4X4); // 0x05868be8
	System.Boolean RayCastBuildContext(WizardGames.Soc.Common.Unity.Character.PlayRayCastRule& Rule, WizardGames.Soc.Common.Unity.Character.PlayerRayCastContext<WizardGames.Soc.SocClient.Systems.HitObjDataValue>& RayCastContext, WizardGames.Soc.Common.Unity.Character.PlayerRefRayCastContext<WizardGames.Soc.SocClient.Systems.HitObjDataValue>& RayCastRefContext); // 0x05866f00
	static System.Void RayCastTestObject(WizardGames.Soc.Common.Unity.Character.PlayRayCastRule& Rule, WizardGames.Soc.Common.Unity.Character.PlayerRayCastContext<WizardGames.Soc.SocClient.Systems.HitObjDataValue>& RayCastContext, WizardGames.Soc.Common.Unity.Character.PlayerRefRayCastContext<WizardGames.Soc.SocClient.Systems.HitObjDataValue>& RayCastRefContext); // 0x05867560
	static System.Void TryBuildHitResult(WizardGames.Soc.Common.Unity.Character.PlayRayCastRule& Rule, WizardGames.Soc.Common.Unity.Character.PlayerRayCastContext<WizardGames.Soc.SocClient.Systems.HitObjDataValue>& RayCastContext, WizardGames.Soc.Common.Unity.Character.PlayerRefRayCastContext<WizardGames.Soc.SocClient.Systems.HitObjDataValue>& RayCastRefContext, WizardGames.Soc.Common.Unity.Character.HitCastData& hit_cache, UnityEngine.RaycastHit& hit, UnityEngine.LayerMask go_layer, UnityEngine.Collider hit_collider, System.UInt32& visit_index); // 0x058697b4
	static System.Boolean CanTestObstacle(WizardGames.Soc.Common.Unity.Character.PlayRayCastRule& Rule, UnityEngine.LayerMask go_layer, UnityEngine.Collider hit_collider); // 0x058695e4
	static System.Boolean IsIgnore(WizardGames.Soc.Common.Unity.Character.PlayerRayCastContext<WizardGames.Soc.SocClient.Systems.HitObjDataValue>& RayCastContext, WizardGames.Soc.Common.Unity.Character.HitCastData& hit_cache); // 0x05869394
	static System.Boolean IsObstacle(WizardGames.Soc.Common.Unity.Character.PlayRayCastRule& Rule, WizardGames.Soc.Common.Unity.Character.HitCastData& hit_cache, UnityEngine.Collider hit_collider); // 0x058696c8
	static System.Boolean TryBuildObstacleData(WizardGames.Soc.Common.Unity.Character.PlayRayCastRule& Rule, WizardGames.Soc.Common.Unity.Character.HitCastData& hit_cache, UnityEngine.LayerMask go_layer, UnityEngine.Collider hit_collider); // 0x058694e8
	static System.Int32 _RayCast(WizardGames.Soc.Common.Unity.Character.PlayRayCastRule& Rule, WizardGames.Soc.Common.Unity.Character.PlayerRayCastContext<WizardGames.Soc.SocClient.Systems.HitObjDataValue>& RayCastContext, WizardGames.Soc.Common.Unity.Character.PlayerRefRayCastContext<WizardGames.Soc.SocClient.Systems.HitObjDataValue>& RayCastRefContext, System.Boolean is_test_valid_collides, System.Boolean is_test_exclude_collides, System.Int32 hit_count, System.Single max_distance); // 0x05868dbc
	System.Void RayHitObject(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, System.Single distance); // 0x05868410
	System.Boolean IsInRaycastMask(System.Int32 layer); // 0x0586a3a4
	System.Boolean IsInObstacleMask(System.Int32 layer); // 0x05869ed0
	System.Boolean HandleObstacle(UnityEngine.Collider hitCollider, WizardGames.Soc.Common.Combat.SocRaycastHit hitInfo, UnityEngine.Vector3 direction, System.Int32 layer); // 0x05869f50
	System.Boolean HandleEntity(UnityEngine.Collider hitCollider, WizardGames.Soc.Common.Combat.SocRaycastHit hitInfo, UnityEngine.Vector3 direction, System.Int32& entityNum); // 0x0586a424
	System.Void RemoveRedundantObjects(System.Int32 entityNum); // 0x0586aa54
	System.Void ClearEntity(); // 0x058681f8
	System.Void .ctor(); // 0x0586abbc
	static System.Void .cctor(); // 0x0586aee4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.RaycastSystem.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Systems.RaycastSystem.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x0586b1a0
	System.Void .ctor(); // 0x0586b204
	System.Int32 <.cctor>b__46_0(WizardGames.Soc.SocClient.Systems.HitObjData a, WizardGames.Soc.SocClient.Systems.HitObjData b); // 0x0586b26c
	System.Int32 <.cctor>b__46_1(WizardGames.Soc.SocClient.Systems.HitObjDataValue x, WizardGames.Soc.SocClient.Systems.HitObjDataValue y); // 0x0586b300
	System.Int32 <.cctor>b__46_2(WizardGames.Soc.Common.Unity.Character.HitCastData x, WizardGames.Soc.Common.Unity.Character.HitCastData y); // 0x0586b3c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.HitObjData : System.Object
{
	WizardGames.Soc.Common.Combat.SocRaycastHit raycastHit; // 0x10
	UnityEngine.GameObject hitGo; // 0x50
	UnityEngine.Vector3 direction; // 0x58
	System.Int32 entityTypeId; // 0x64
	WizardGames.Soc.Common.Entity.IEntity entity; // 0x68
	UnityEngine.GameObject entityGo; // 0x70
	System.Single distance; // 0x78
	System.Void .ctor(); // 0x05866668
	System.Void Init(WizardGames.Soc.Common.Combat.SocRaycastHit raycastHit, UnityEngine.GameObject hitGo, UnityEngine.Vector3 direction, System.Int32 entityTypeId, WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject entityGo); // 0x0586a21c
	static System.Boolean Equals(WizardGames.Soc.SocClient.Systems.HitObjData a, WizardGames.Soc.SocClient.Systems.HitObjData& b); // 0x0586b480
	WizardGames.Soc.SocClient.Systems.HitObjData DeepCopy(); // 0x0586b580
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.TreeFallDownRenderSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	WizardGames.Soc.Common.DataSet.CommonDataSet<Share.Common.ObjPool.Alpha3PooledObjectBase> treeFallDownEffectDataSet; // 0x28
	System.Collections.Generic.List<Effect.TreeFallDownEffect> treeFallDownEffectList; // 0x30
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0586b67c
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0586b6e0
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0586b7dc
	System.Void .ctor(); // 0x0586ba3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.ClientOfflineSystemInitHandler : Systems.ClientSystemInitHandler
{
	
	System.Void OtherSystem(); // 0x0586baa4
	System.Void .ctor(); // 0x0586bb0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.AmbienceSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	System.Collections.Generic.List<UnityEngine.GameObject> emitterList; // 0x10
	UnityEngine.GameObject myEntityObj; // 0x18
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0586bb98
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0586bbfc
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0586bcb4
	System.Void OnDestroy(); // 0x0586bfcc
	System.Void InitMyEntityObj(); // 0x0586bdd4
	System.Void .ctor(); // 0x0586c070
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.AudioAnimRaycastSystem : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32> BucketIdxToFrameCount; // 0x0
	System.Int32 PoolSize; // 0x10
	SignifianceScoreConf Conf; // 0x18
	SignifianceBucketConf BucketConf; // 0x48
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> EntityBaseScore; // 0x58
	System.Boolean IsEnable; // 0x60
	WizardGames.Soc.SocClient.Audio.Process_SignificanceAudioRaycast Process; // 0x68
	System.String BucketType; // 0x70
	System.Void InitConf(System.Int32 InQualityLvl); // 0x0586c124
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0586cc30
	System.Void OnDestroy(); // 0x0586cde0
	System.Void OnUpdate(System.Int32 deltaTime); // 0x0586ce7c
	SignifianceBucketConf GetBucketConf(System.Int32 lvl); // 0x0586c9cc
	System.Void .ctor(); // 0x0586d548
	static System.Void .cctor(); // 0x0586d5dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.AudioEventAnalyseManager : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.AudioSystem.IAudioEventAnalyse> audioEventAnalyseList; // 0x10
	WizardGames.Soc.Common.Entity.BaseMgrLocalEntity mgrEntity; // 0x18
	System.Void .ctor(WizardGames.Soc.Common.Contexts.Context context); // 0x0586d6c4
	System.Void AnalyseAudioEvent(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x0586da8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.BaseAudioEventAnalyse : System.Object, WizardGames.Soc.SocClient.Systems.AudioSystem.IAudioEventAnalyse
{
	
	System.Boolean TryAnalyseAudioEvent(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x0586dbf0
	System.Void .ctor(); // 0x0586dc68
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Systems.AudioSystem.IAudioEventAnalyse : 
{
	
	System.Boolean TryAnalyseAudioEvent(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x054dec74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.ItemAudioAnalyse : WizardGames.Soc.SocClient.Systems.AudioSystem.BaseAudioEventAnalyse
{
	
	System.Boolean TryAnalyseAudioEvent(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x0586dcd0
	System.Void .ctor(); // 0x0586da28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.NormalAudioAnalyse : WizardGames.Soc.SocClient.Systems.AudioSystem.BaseAudioEventAnalyse
{
	
	System.Boolean TryAnalyseAudioEvent(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x0586dedc
	System.Void .ctor(); // 0x0586d960
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.WeaponAudioAnalyse : WizardGames.Soc.SocClient.Systems.AudioSystem.BaseAudioEventAnalyse
{
	
	System.Boolean TryAnalyseAudioEvent(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x0586e5d4
	System.Void .ctor(); // 0x0586d9c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.AudioOcclusionSystem : System.Object
{
	static System.Int32 PoolSize; // 0x0
	static System.Single OcclusionValue; // 0x4
	System.Collections.Generic.Queue<AkGameObj> akGameObjQueue; // 0x10
	System.Collections.Generic.HashSet<AkGameObj> akGameObjSet; // 0x18
	UnityEngine.RaycastHit[] hitsFromListener; // 0x20
	UnityEngine.RaycastHit[] hitsFromEmitter; // 0x28
	UnityEngine.Vector3 rayCastOffset; // 0x30
	System.Collections.Generic.Dictionary<Wwise.Wooduan.Components.AkSpatialAudioRoom,UnityEngine.Collider> roomColliderCache; // 0x40
	System.Void OnUpdate(); // 0x0586e9fc
	System.Void OnDestroy(); // 0x0586f758
	System.Void UpdateGameObjSet(); // 0x0586f7dc
	System.Boolean AddEmitter(WizardGames.Soc.SocClient.Audio.WWise.AudioEventData eventData, System.Boolean isLoop); // 0x0586fc18
	System.Void UpdateQueue(); // 0x0586f0f0
	System.Boolean TryGetEntityPosition(AkGameObj akGameObj, UnityEngine.Vector3& entityPosition); // 0x0586f4dc
	System.Single CalculateRelativeHeight(AkGameObj akComponent); // 0x0586f2cc
	System.Void .ctor(); // 0x0586fe6c
	static System.Void .cctor(); // 0x05870088
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.BaseAudioSubsystem : System.Object
{
	SocLogger logger; // 0x10
	UnityEngine.GameObject currentAudioEmitter; // 0x18
	WizardGames.Soc.Common.Unity.Audio.AudioClassification systemType; // 0x20
	System.Void .ctor(WizardGames.Soc.Common.Unity.Audio.AudioClassification type); // 0x058700d8
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x058701ac
	System.Void Tick(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x05870220
	System.Boolean CheckEnterCondition(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x058702ec
	System.Void GetAudioEmitter(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x0587036c
	System.Void StopAudio(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x05870410
	System.Void PlayAudio(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x058704d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.ClientAudioSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	System.Int32 CurrentMonumentId; // 0x10
	WizardGames.Soc.SocClient.Systems.AudioSystem.AudioOcclusionSystem OcclusionSystem; // 0x18
	WizardGames.Soc.SocClient.Systems.AudioSystem.AudioAnimRaycastSystem AudioAnimRaycastSystem; // 0x20
	SocLogger logger; // 0x28
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Audio.AudioClassification,WizardGames.Soc.SocClient.Systems.AudioSystem.BaseAudioSubsystem> audioSubsystems; // 0x30
	WizardGames.Soc.Common.Unity.Audio.AudioDataSet audioDataSet; // 0x38
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x40
	WizardGames.Soc.SocClient.Systems.AudioSystem.AudioEventAnalyseManager audioEventAnalyseManager; // 0x48
	WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo mgrEntityGo; // 0x50
	WizardGames.Soc.Common.DataSet.CommonDataSet<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> audioDataEventQueue; // 0x58
	WizardGames.Soc.Common.DataSet.CommonDataSet<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> hitSoundDataEventQueue; // 0x60
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x058706e0
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05870744
	System.Void OnDestroy(); // 0x05870de4
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05870f50
	System.Void RegisterSubsystem(WizardGames.Soc.Common.Contexts.Context context); // 0x058709c8
	System.Void DistributeData(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x05871a30
	System.Void ReleaseAudioData(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x05871bf4
	System.Void PlayHitSound(WizardGames.Soc.Common.SimpleCustom.HitSoundDataEvent hitSound); // 0x05523a54
	System.Void UpdateBGM(); // 0x0587173c
	System.Void .ctor(); // 0x05872cc4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.ClientAudioSystem.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Systems.AudioSystem.ClientAudioSystem.<>c <>9; // 0x0
	static WizardGames.Soc.SocClient.Audio.WWise.AudioEventData.PostEventFinishedCallback <>9__16_0; // 0x8
	static System.Void .cctor(); // 0x05872e44
	System.Void .ctor(); // 0x05872ea8
	System.Void <OnUpdate>b__16_0(WizardGames.Soc.SocClient.Audio.WWise.AudioEventData eventData, System.Object obj); // 0x05872f10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.ConstructionAudioSubsystem : WizardGames.Soc.SocClient.Systems.AudioSystem.BaseAudioSubsystem
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PartEntity> partEntites; // 0x28
	Contexts.ClientContext clientContext; // 0x30
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05872ff0
	System.Boolean CheckEnterCondition(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x0587314c
	System.Void GetAudioEmitter(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x058731f4
	System.Void .ctor(WizardGames.Soc.Common.Unity.Audio.AudioClassification type); // 0x05872ad4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.MissileAudioSubsystem : WizardGames.Soc.SocClient.Systems.AudioSystem.BaseAudioSubsystem
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.MissileEntity> missilesEntities; // 0x28
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0587334c
	System.Boolean CheckEnterCondition(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x05873428
	System.Void PlayAudio(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x058734d0
	System.Void .ctor(WizardGames.Soc.Common.Unity.Audio.AudioClassification type); // 0x05872bcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.MonsterAudioSubsystem : WizardGames.Soc.SocClient.Systems.AudioSystem.BaseAudioSubsystem
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.MonsterEntity> monsterEntites; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,System.Boolean> entityState; // 0x30
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05873738
	System.Boolean CheckEnterCondition(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x058738b4
	System.Void GetAudioEmitter(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x0587395c
	WizardGames.Soc.Common.CustomType.WeaponCustom GetWeaponById(WizardGames.Soc.Common.Entity.MonsterEntity monsterEntity, System.Int64 weaponId); // 0x05873b30
	System.Void PlayAudio(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x05873c2c
	System.Void TryPlayFireAudio(WizardGames.Soc.Common.Data.units.MonsterGunPara gunPara, WizardGames.Soc.Common.Data.Display.WeaponDisplay tbWeapon, WizardGames.Soc.Common.Entity.MonsterEntity monsterEntity, WizardGames.Soc.SocClient.Go.MonsterGo monsterGo, System.Int64 audioPlayId); // 0x058741a8
	System.Void TryStopFireAudio(WizardGames.Soc.Common.Data.units.MonsterGunPara gunPara, WizardGames.Soc.SocClient.Go.MonsterGo monsterGo, System.Int64 audioPlayId); // 0x05874770
	System.Void MonsterRemoveWeaponAudio(System.Int64 monsterId, WizardGames.Soc.Common.Data.units.MonsterGunPara gunPara, UnityEngine.GameObject mainGo); // 0x05874a58
	System.Void .ctor(WizardGames.Soc.Common.Unity.Audio.AudioClassification type); // 0x05872a0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.MyPlayerAudioSubsystem : WizardGames.Soc.SocClient.Systems.AudioSystem.BaseAudioSubsystem
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PlayerEntity> playerEntities; // 0x30
	System.Boolean myEntityIsFire; // 0x38
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05874bbc
	System.Boolean CheckEnterCondition(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x05874cf0
	System.Void GetAudioEmitter(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x05874d90
	System.Void PlayAudio(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x05874ee0
	System.Void .ctor(WizardGames.Soc.Common.Unity.Audio.AudioClassification type); // 0x05872914
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.NormalAudioSubsystem : WizardGames.Soc.SocClient.Systems.AudioSystem.BaseAudioSubsystem
{
	
	System.Boolean CheckEnterCondition(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x05875260
	System.Void .ctor(WizardGames.Soc.Common.Unity.Audio.AudioClassification type); // 0x05872c48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.OtherPlayersAudioSubsystem : WizardGames.Soc.SocClient.Systems.AudioSystem.BaseAudioSubsystem
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PlayerEntity> playerEntities; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Go.IEntityGo> gos; // 0x30
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,System.Boolean> entityIsFires; // 0x40
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x058752e0
	System.Void GetAudioEmitter(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x058754a4
	System.Boolean CheckEnterCondition(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x058755e4
	System.Void PlayAudio(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x058756cc
	System.Void .ctor(WizardGames.Soc.Common.Unity.Audio.AudioClassification type); // 0x05872990
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.PlaneAudioSubsystem : WizardGames.Soc.SocClient.Systems.AudioSystem.BaseAudioSubsystem
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.AirDropPlaneEntity> planeEntities; // 0x28
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05875bd0
	System.Boolean CheckEnterCondition(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x05875cac
	System.Void PlayAudio(WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x05875d54
	System.Void .ctor(WizardGames.Soc.Common.Unity.Audio.AudioClassification type); // 0x05872b50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.SpatialAudioRoom : System.Object
{
	System.String name; // 0x10
	UnityEngine.GameObject audioGo; // 0x18
	WwiseAuxBusReference reverbAuxBus; // 0x20
	System.UInt64 gameObjectID; // 0x28
	AK.Wwise.Event roomToneEvent; // 0x30
	System.Void .ctor(System.String name, WwiseAuxBusReference reverbAuxBus); // 0x05875fbc
	AkRoomParams GetRoomParams(); // 0x058760f4
	System.UInt64 GetGameObjectID(); // 0x0587629c
	System.Void RegisterInWwise(); // 0x05876300
	System.Void UnregisterInWwise(); // 0x058764c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.SpatialAudioSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger Logger; // 0x0
	static System.Collections.Generic.List<System.String> ReverbAuxBusFileList; // 0x8
	static System.Collections.Generic.Dictionary<System.UInt32,System.Byte> auxBusToRoomTypeMap; // 0x10
	static System.Collections.Generic.Dictionary<System.Byte,WizardGames.Soc.SocClient.Systems.AudioSystem.SpatialAudioRoom> roomTypeToRoomMap; // 0x18
	static System.Byte CurrentRoomType; // 0x20
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x05876670
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x058766d4
	System.Void OnDestroy(); // 0x05876c78
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0587709c
	static System.Void UpdateSpatialAudioRoom(AkGameObj akGameObj); // 0x05877a0c
	static System.Void UpdateSelfMonumentSpatialAudio(AkGameObj akGameObj); // 0x05877524
	System.Void LoadReverbAuxBusData(); // 0x05876950
	System.Void UnloadReverbAuxBusData(); // 0x05876e64
	static System.Byte GetRoomType(Wwise.Wooduan.Components.AkSpatialAudioRoom room); // 0x05878230
	static System.Byte GetRoomType(System.UInt32 busId); // 0x05878340
	static UnityEngine.Vector3 GetMyEntityPosition(); // 0x05878000
	System.Void .ctor(); // 0x05878410
	static System.Void .cctor(); // 0x05878478
}

// Client.Runtime
class WizardGames.Soc.SocClient.Systems.AudioSystem.SurfaceAudioSubSystem : WizardGames.Soc.SocClient.Systems.AudioSystem.BaseAudioSubsystem
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x28
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05878780
	System.Boolean CheckEnterCondition(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Unity.Audio.AudioData audioData); // 0x0587885c
	System.Void .ctor(WizardGames.Soc.Common.Unity.Audio.AudioClassification type); // 0x05872898
}

// Client.Runtime
class WizardGames.Soc.SocClient.Suit.GameboySuitAbility : WizardGames.Soc.SocClient.Suit.SuitAbilityComponent
{
	System.Int64 selfHpSubscribe; // 0x30
	WizardGames.Soc.Common.Entity.PlayerEntity playerEntity; // 0x38
	System.Single lowHpRate; // 0x40
	System.Collections.Generic.List<UnityEngine.GameObject> healthyHpEffects; // 0x48
	System.Collections.Generic.List<UnityEngine.GameObject> lowHpEffects; // 0x50
	System.Void InitPlayer(WizardGames.Soc.Common.Entity.PlayerEntity _playerEntity); // 0x058788ec
	System.Void LobbyInit(); // 0x05878d54
	System.Void OnHpChangeCallback(WizardGames.Soc.Share.Framework.CustomTypeBase arg1, System.Single arg2, System.Single arg3); // 0x05878db8
	System.Void UpdateEffect(); // 0x05878ab8
	System.Void Release(); // 0x05878e4c
	System.Void .ctor(); // 0x05878f20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Suit.SuitAbilityComponent : UnityEngine.MonoBehaviour
{
	
	System.Void InitPlayer(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x05523a54
	System.Void LobbyInit(); // 0x055049cc
	System.Void Release(); // 0x055049cc
	System.Void .ctor(); // 0x05879008
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Suit.StageTimeScope : System.ValueType
{
	System.Double TimeStart; // 0x10
	System.Double TimeEnd; // 0x18
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Suit.SuitPerformanceStage : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Suit.SuitPerformanceStage None = 0;
	static WizardGames.Soc.SocClient.Suit.SuitPerformanceStage Appearance = 1;
	static WizardGames.Soc.SocClient.Suit.SuitPerformanceStage Idle = 2;
	static WizardGames.Soc.SocClient.Suit.SuitPerformanceStage Exit = 4;
	static WizardGames.Soc.SocClient.Suit.SuitPerformanceStage AppearanceThenIdle = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Suit.SuitPerformance : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.SocClient.Suit.StageTimeScope[] StageTimeScopes; // 0x30
	WizardGames.Soc.SocClient.Suit.SuitPerformanceProp[] performanceProps; // 0x38
	UnityEngine.Playables.PlayableDirector playableDirector; // 0x40
	System.Boolean isPlaying; // 0x48
	System.Boolean isManualPlay; // 0x49
	WizardGames.Soc.SocClient.Suit.SuitPerformanceStage performanceStages; // 0x4c
	WizardGames.Soc.SocClient.Suit.StageTimeScope currentStageTimeScope; // 0x50
	WizardGames.Soc.SocClient.Suit.SuitPerformanceStage _currentPerformanceStage; // 0x60
	System.Collections.Generic.List<System.String> playingAudio; // 0x68
	WizardGames.Soc.Common.Data.collection.OBJCostumeSuit suitData; // 0x70
	WizardGames.Soc.SocClient.Suit.SuitPerformanceStage get_currentPerformanceStage(); // 0x05879070
	System.Void set_currentPerformanceStage(WizardGames.Soc.SocClient.Suit.SuitPerformanceStage value); // 0x058790d4
	System.Void Awake(); // 0x05879260
	System.Void OnEnable(); // 0x05879320
	System.Void OnDisable(); // 0x058793c0
	System.Void Update(); // 0x05879524
	System.Void EditorUpdate(); // 0x058797dc
	System.Void StageUpdate(); // 0x058795c4
	System.Void BindAnimator(UnityEngine.Animator animator); // 0x05879994
	System.Void ReleaseAnimator(); // 0x05879e58
	System.Void Play(); // 0x0587a210
	System.Void Play(WizardGames.Soc.SocClient.Suit.SuitPerformanceStage stages); // 0x0587a278
	System.ValueTuple<WizardGames.Soc.SocClient.Suit.SuitPerformanceStage,WizardGames.Soc.SocClient.Suit.StageTimeScope> GetCurrentStage(); // 0x05879840
	System.Void Stop(System.Boolean playEnd); // 0x05879428
	System.Void ShowOrHideProps(System.Boolean show); // 0x05879d58
	System.Void OnStateChange(WizardGames.Soc.SocClient.Suit.SuitPerformanceStage o, WizardGames.Soc.SocClient.Suit.SuitPerformanceStage n); // 0x05879164
	System.Void PlayAudio(System.String audioEvent); // 0x0587a580
	System.Void StopAudio(); // 0x0587a3a8
	System.Void BindSuitData(WizardGames.Soc.Common.Data.collection.OBJCostumeSuit data); // 0x0587a6a4
	System.Void OnDestroy(); // 0x0587a724
	System.Void .ctor(); // 0x0587a7e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Suit.SuitPerformanceProp : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x0587a8c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Story.MgrStory : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Logger; // 0x0
	System.Boolean FirstEnterGamePlay; // 0x11
	System.Int32 curStage; // 0x14
	System.Int64 timeId; // 0x18
	System.Boolean ShowStoryPlan; // 0x20
	System.Collections.Generic.List<System.Int64> receivedTaskIds; // 0x28
	static System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.StoryStageStage> stageList; // 0x8
	System.Boolean _showScriptPermanentReminder; // 0x30
	System.Void Init(); // 0x055049cc
	System.Threading.Tasks.Task OnEnterWorld(); // 0x0587ac50
	System.Void OnStoryTaskReceiveTaskResult(System.Int32 result); // 0x0587acc0
	System.Void ReceiveRewards(System.Int64 taskId); // 0x0587aff4
	WizardGames.Soc.Common.Data.DataItem.ItemConfig GetItemCfg(System.Int32 rewardId, System.Int32& rewardNum); // 0x0587b130
	System.Boolean CanStageGetReward(WizardGames.Soc.Common.Data.Play.StoryStageStage stage); // 0x0587b3b0
	System.Boolean CanStoryGetReward(); // 0x0587b4bc
	static System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.StoryStageStage> GetStageList(); // 0x0587b5c8
	System.Void UpdateStage(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x0587baa4
	System.Int32 GetMaxWorldLevel(); // 0x0587bf0c
	System.Void ShowScriptPermanentReminder(); // 0x0587bc9c
	System.Void UpdateOngoingTip(WizardGames.Soc.SocClient.Ui.ComOngoingTip ongoingTip); // 0x0587c110
	WizardGames.Soc.Common.Data.Play.StoryStageStage GetCurrStage(); // 0x0587c344
	WizardGames.Soc.Common.Data.Play.StoryStageStage GetStageById(System.Int32 stageId); // 0x0587c4c4
	WizardGames.Soc.Common.Data.Play.StoryStageStage GetLastStage(); // 0x0587c5ec
	System.String GetRaidTime(); // 0x0587c6bc
	System.Int64 GetStageEndTime(); // 0x0587c760
	System.Int64 GetEndTime(); // 0x0587c098
	System.Int64 GetSelectStageStartTime(System.Int32 selectStageId); // 0x0587cb34
	System.Int64 GetTotalDurationOfTheRemainingStage(); // 0x0587c840
	System.Void OnCharacterStateChange(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Entity.PlayerCharacterStateEnum lastState, WizardGames.Soc.Common.Entity.PlayerCharacterStateEnum curState); // 0x0587ce74
	System.Boolean IsItemDrawStoryStageLock(System.Int64 itemId, System.Int32& unLockStageId); // 0x0587e020
	System.Void ShowPicBox(WizardGames.Soc.Common.Data.Play.StoryStageStage stage); // 0x0587d6b8
	System.Void OnSomeTaskChanged(); // 0x0587e580
	System.Boolean CanGoodSell(System.Int32 itemId); // 0x0587e620
	WizardGames.Soc.Common.Data.Play.StoryStageStage GoodSellStage(System.Int32 itemId); // 0x0587e778
	System.String GoodSellLockedTips(System.Int32 itemId); // 0x0587ea34
	System.Boolean IsTechUnlocked(System.Int64 treeNodeId); // 0x0587ee20
	WizardGames.Soc.Common.Data.Play.StoryStageStage TechUnlockStage(System.Int64 treeNodeId); // 0x0587f098
	System.Void CleanUp(); // 0x055049cc
	System.Void .ctor(); // 0x0587f570
	static System.Void .cctor(); // 0x0587f634
}

// Client.Runtime
class WizardGames.Soc.SocClient.Story.MgrStory.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Story.MgrStory.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Data.Play.StoryStageStage> <>9__15_0; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMissionBook> <>9__29_0; // 0x10
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestTraining> <>9__29_3; // 0x18
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestTraining> <>9__29_2; // 0x20
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMissionBook> <>9__29_1; // 0x28
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMissionBook> <>9__31_0; // 0x30
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestTraining> <>9__31_3; // 0x38
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestTraining> <>9__31_2; // 0x40
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMissionBook> <>9__31_1; // 0x48
	static System.Void .cctor(); // 0x0587f760
	System.Void .ctor(); // 0x0587f7c4
	System.Int32 <GetStageList>b__15_0(WizardGames.Soc.Common.Data.Play.StoryStageStage a, WizardGames.Soc.Common.Data.Play.StoryStageStage b); // 0x0587f82c
	System.Void <OnCharacterStateChange>b__29_0(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x0587f8c0
	System.Void <OnCharacterStateChange>b__29_3(WizardGames.Soc.SocClient.Ui.UiMainQuestTraining win); // 0x0587f948
	System.Void <OnCharacterStateChange>b__29_2(WizardGames.Soc.SocClient.Ui.UiMainQuestTraining win); // 0x0587f9d8
	System.Void <OnCharacterStateChange>b__29_1(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x0587fa68
	System.Void <ShowPicBox>b__31_0(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x0587faf0
	System.Void <ShowPicBox>b__31_3(WizardGames.Soc.SocClient.Ui.UiMainQuestTraining win); // 0x0587fb78
	System.Void <ShowPicBox>b__31_2(WizardGames.Soc.SocClient.Ui.UiMainQuestTraining win); // 0x0587fc08
	System.Void <ShowPicBox>b__31_1(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x0587fc98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Story.MgrStory.<>c__DisplayClass29_0 : System.Object
{
	System.Int32 factionId; // 0x10
	System.Void .ctor(); // 0x0587d650
	System.Void <OnCharacterStateChange>b__4(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x0587fd20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Story.MgrStory.<>c__DisplayClass31_0 : System.Object
{
	System.Int32 factionId; // 0x10
	System.Void .ctor(); // 0x0587e518
	System.Void <ShowPicBox>b__4(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x0587fdac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Story.MgrStory.<>c__DisplayClass7_0 : System.Object
{
	WizardGames.Soc.SocClient.Story.MgrStory <>4__this; // 0x10
	WizardGames.Soc.Common.Data.Play.QuestPhase cfg; // 0x18
	System.Void .ctor(); // 0x0587af8c
	System.Void <OnStoryTaskReceiveTaskResult>b__0(WizardGames.Soc.SocClient.Ui.UiCommonRewardPop win); // 0x0587fe38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Story.StoryStageStageExtension : System.Object
{
	
	static System.Collections.Generic.List<System.Int64> GetStageTasks(WizardGames.Soc.Common.Data.Play.StoryStageStage stage); // 0x0588005c
	static System.Collections.Generic.List<System.Int64> GetLevelRewards(System.Int32 modeId); // 0x058802dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Story.StoryStageStageExtension.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Story.StoryStageStageExtension.<>c <>9; // 0x0
	static System.Comparison<System.Int64> <>9__0_1; // 0x8
	static System.Func<WizardGames.Soc.Common.Data.Play.OBJPlaySettlementReward,System.Int64> <>9__1_0; // 0x10
	static System.Void .cctor(); // 0x05880854
	System.Void .ctor(); // 0x058808b8
	System.Int32 <GetStageTasks>b__0_1(System.Int64 a, System.Int64 b); // 0x05880920
	System.Int64 <GetLevelRewards>b__1_0(WizardGames.Soc.Common.Data.Play.OBJPlaySettlementReward r); // 0x05880ad0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Story.StoryStageStageExtension.<>c__DisplayClass0_0 : System.Object
{
	WizardGames.Soc.Common.Data.Play.StoryStageStage stage; // 0x10
	System.Void .ctor(); // 0x05880274
	System.Boolean <GetStageTasks>b__0(System.Int64 m); // 0x05880b64
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Setting.EFpsSettingSource : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Setting.EFpsSettingSource BASIC = 0;
	static WizardGames.Soc.SocClient.Setting.EFpsSettingSource POWER_OPT = 1;
	static WizardGames.Soc.SocClient.Setting.EFpsSettingSource THERMAL = 2;
	static WizardGames.Soc.SocClient.Setting.EFpsSettingSource AFK = 3;
	static WizardGames.Soc.SocClient.Setting.EFpsSettingSource VIDEOPLAY = 4;
	static WizardGames.Soc.SocClient.Setting.EFpsSettingSource LENGTH = 5;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Setting.EFpsSettingPostMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Setting.EFpsSettingPostMode NONE = 0;
	static WizardGames.Soc.SocClient.Setting.EFpsSettingPostMode POST = 1;
	static WizardGames.Soc.SocClient.Setting.EFpsSettingPostMode POST_WITHOUT_SLICE = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.FpsSetting : System.Object
{
	static System.Int32 _inactiveFrameRate; // 0x0
	static System.Int32 _defaultFrameRate; // 0x4
	static System.Int32 _targetFrameRate; // 0x8
	static System.Int32[] _frameRateArray; // 0x10
	static System.Action<System.Int32,System.Int32> FrameRateChangedFunc; // 0x18
	static System.Void .cctor(); // 0x05880bf0
	static System.Void SetFrameRate(System.Int32 frameRate); // 0x05880db4
	static System.Int32 get_TargetFrameRate(); // 0x05881354
	static System.Int32 GetBasicFrameRate(); // 0x058813dc
	static System.Boolean IsSourceActive(WizardGames.Soc.SocClient.Setting.EFpsSettingSource source); // 0x0588147c
	static System.Int32 GetOtherSourceFrameRate(WizardGames.Soc.SocClient.Setting.EFpsSettingSource source); // 0x05881538
	static System.Void ResetTargetFrameRate(WizardGames.Soc.SocClient.Setting.EFpsSettingSource source); // 0x058815e8
	static System.Void SetTargetFrameRate(System.Int32 value, WizardGames.Soc.SocClient.Setting.EFpsSettingSource source, WizardGames.Soc.SocClient.Setting.EFpsSettingPostMode postMode); // 0x05880e44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.GMCommandAttributeBase : System.Attribute
{
	System.Int32 <TitleLangKey>k__BackingField; // 0x10
	System.String <Title>k__BackingField; // 0x18
	System.String <GroupInfo>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Setting.GMPermmision <Permission>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Setting.GMCommandType <Type>k__BackingField; // 0x2c
	System.Boolean <IsInGameConfig>k__BackingField; // 0x30
	System.String <DefaultValueProvider>k__BackingField; // 0x38
	System.Int32 get_TitleLangKey(); // 0x05881680
	System.String get_Title(); // 0x058816e4
	System.String get_GroupInfo(); // 0x05881748
	WizardGames.Soc.SocClient.Setting.GMPermmision get_Permission(); // 0x058817ac
	System.Void set_Permission(WizardGames.Soc.SocClient.Setting.GMPermmision value); // 0x05881810
	WizardGames.Soc.SocClient.Setting.GMCommandType get_Type(); // 0x05881888
	System.Void set_Type(WizardGames.Soc.SocClient.Setting.GMCommandType value); // 0x058818ec
	System.Boolean get_IsInGameConfig(); // 0x05881964
	System.Void set_IsInGameConfig(System.Boolean value); // 0x058819c8
	System.String get_DefaultValueProvider(); // 0x05881a44
	System.Void set_DefaultValueProvider(System.String value); // 0x05881aa8
	System.Void .ctor(System.String chineseTitle, System.String groupInfo, WizardGames.Soc.SocClient.Setting.GMCommandType type, System.Boolean bInGameConfig); // 0x05881b28
	System.String GetDynamicDefaultValueString(); // 0x05881d30
	WizardGames.Soc.SocClient.Setting.SettingConfig CreateSettingConfig(System.Action<System.String> actionDelegate, WizardGames.Soc.SocClient.Setting.GMCommands gmCommandsInstance); // 0x054fbfdc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.GMSwitchCommandAttribute : WizardGames.Soc.SocClient.Setting.GMCommandAttributeBase
{
	System.String <DefaultValue>k__BackingField; // 0x40
	System.Int32[] <OptionsLangKeys>k__BackingField; // 0x48
	System.String[] <OptionsTempTitles>k__BackingField; // 0x50
	System.Boolean <NeedSave>k__BackingField; // 0x58
	System.Int32[] <DisableIndexes>k__BackingField; // 0x60
	System.String get_DefaultValue(); // 0x0588291c
	System.Void set_DefaultValue(System.String value); // 0x05882980
	System.Int32[] get_OptionsLangKeys(); // 0x05882a00
	System.String[] get_OptionsTempTitles(); // 0x05882a64
	System.Boolean get_NeedSave(); // 0x05882ac8
	System.Int32[] get_DisableIndexes(); // 0x05882b2c
	System.Void .ctor(System.String chineseTitle, System.String groupInfo, WizardGames.Soc.SocClient.Setting.GMCommandType type, System.Boolean bInGameConfig, System.String defaultValue, System.String defaultValueProvider); // 0x05882b90
	WizardGames.Soc.SocClient.Setting.SettingConfig CreateSettingConfig(System.Action<System.String> actionDelegate, WizardGames.Soc.SocClient.Setting.GMCommands gmCommandsInstance); // 0x05882d1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.GMButtonCommandAttribute : WizardGames.Soc.SocClient.Setting.GMCommandAttributeBase
{
	
	System.Void .ctor(System.String chineseTitle, System.String groupInfo, WizardGames.Soc.SocClient.Setting.GMCommandType type, System.Boolean bInGameConfig); // 0x05882fe4
	WizardGames.Soc.SocClient.Setting.SettingConfig CreateSettingConfig(System.Action<System.String> actionDelegate, WizardGames.Soc.SocClient.Setting.GMCommands gmCommandsInstance); // 0x05883094
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.GMParamButtonCommandAttribute : WizardGames.Soc.SocClient.Setting.GMCommandAttributeBase
{
	System.String <DefaultValue>k__BackingField; // 0x40
	System.String <InputTipText>k__BackingField; // 0x48
	System.String get_DefaultValue(); // 0x05883194
	System.Void set_DefaultValue(System.String value); // 0x058831f8
	System.String get_InputTipText(); // 0x05883278
	System.Void set_InputTipText(System.String value); // 0x058832dc
	System.Void .ctor(System.String chineseTitle, System.String groupInfo, WizardGames.Soc.SocClient.Setting.GMCommandType type, System.Boolean bInGameConfig, System.String defaultValue, System.String inputTipText, System.String defaultValueProvider); // 0x0588335c
	WizardGames.Soc.SocClient.Setting.SettingConfig CreateSettingConfig(System.Action<System.String> actionDelegate, WizardGames.Soc.SocClient.Setting.GMCommands gmCommandsInstance); // 0x0588355c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Setting.GMPermmision : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Setting.GMPermmision Publish = 0;
	static WizardGames.Soc.SocClient.Setting.GMPermmision Dev = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Setting.GMCommandType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Setting.GMCommandType Local = 0;
	static WizardGames.Soc.SocClient.Setting.GMCommandType Server = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.GMCommandMeta : System.Object
{
	System.String Key; // 0x10
	System.String Title; // 0x18
	System.String SubTabName; // 0x20
	System.String SubGroupName; // 0x28
	System.Int32 TabPriority; // 0x30
	System.Int32 GroupPriority; // 0x34
	WizardGames.Soc.SocClient.Setting.GMPermmision Permission; // 0x38
	WizardGames.Soc.SocClient.Setting.GMCommandType Type; // 0x3c
	WizardGames.Soc.SocClient.Setting.SettingConfig Config; // 0x40
	System.Boolean IsInGameConfig; // 0x48
	System.Void .ctor(); // 0x05883768
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Setting.GMCommandsSortInfo : System.ValueType
{
	System.String SubTabName; // 0x10
	System.String SubGroupName; // 0x18
	System.Int32 TabPriority; // 0x20
	System.Int32 GroupPriority; // 0x24
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.GMCommandsControlSortDef : System.Object
{
	static WizardGames.Soc.Common.Framework.Algorithm.OrderedDictionary<System.String,System.Collections.Generic.List<System.String>> SortMapping; // 0x0
	static WizardGames.Soc.SocClient.Setting.GMCommandsSortInfo GetGmCommandsSortPriority(System.String groupInfo); // 0x058837d0
	static System.Void .cctor(); // 0x05883ac4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.GMCommands : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Setting.GMCommandMeta> GMCmdList; // 0x10
	System.Void .ctor(); // 0x05884988
	WizardGames.Soc.SocClient.Setting.GMPermmision GetUserPermission(); // 0x05885ab8
	System.Void Clear(); // 0x05885b1c
	System.Void RegisterGMCommands(); // 0x05884a44
	System.Void SetPlayerInvincible(System.String param); // 0x05886140
	System.Void SetAcceleration(System.String param); // 0x05886250
	System.Void SetDelayCompensation(System.String param); // 0x058865c0
	System.Void ToggleFlyMode(System.String param); // 0x058866c4
	System.Void ToggleObserverMode(System.String param); // 0x05886844
	System.Void TogglePerfSightCollect(System.String param); // 0x058869d8
	System.Void ToggleShaderVariantsUpload(System.String param); // 0x05886af8
	System.Void ObserverSetTransform(System.String param); // 0x05886bdc
	System.Void ObserverTransportToPlayer(System.String param); // 0x05886da4
	System.Void AdjustComfort(System.String param); // 0x05886e8c
	System.Void AddFireInPlace(System.String param); // 0x05886fe8
	System.Void ResetHandbook(System.String param); // 0x058870fc
	System.Void UnlockAllHandBook(System.String param); // 0x058871b0
	System.Void UnlockOneHandbook(System.String param); // 0x05887264
	System.Void CompleteCurrentTaskStage(System.String param); // 0x05887338
	System.Void ResetTask(System.String param); // 0x05887404
	System.Void JumpToPreviousTaskStage(System.String param); // 0x058874d0
	System.Void GetTaskById(System.String param); // 0x0588759c
	System.Void FinishDailyTask(System.String param); // 0x05887698
	System.Void AddCurrency(System.String param); // 0x05887794
	System.Void JumpToTaskStageById(System.String param); // 0x05887c34
	System.Void KillSelf(System.String param); // 0x05887d30
	System.Void FillBackpack(System.String param); // 0x058881cc
	System.Void AddWeapons(System.String param); // 0x058882a0
	System.Void ToggleExpandBackpack(System.String param); // 0x058883ec
	System.Void AddBullets(System.String param); // 0x05888544
	System.Void ToggleHarmLog(System.String param); // 0x05888804
	System.Void EscapeFromStuck(System.String param); // 0x05888954
	System.Void LoadMapDataRuntime(System.String param); // 0x05888e1c
	System.Void RegisterGMCommands_Publish(); // 0x05885bc0
	System.Void AddStyleScore(System.String param); // 0x05889004
	System.Void AddStyleRank(System.String param); // 0x058891a4
	System.Void AddMedal(System.String param); // 0x05889344
	System.Void SetLobbyServerTime(System.String param); // 0x05523a54
	System.Void GetLobbyServerTime(System.String param); // 0x05523a54
	System.Void ResetLobbyServerTime(System.String param); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.GMCommands.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Setting.GMCommands.<>c <>9; // 0x0
	static System.Func<System.Reflection.MethodInfo,System.Boolean> <>9__4_0; // 0x8
	static System.Action<SimpleJSON.JSONNode> <>9__24_0; // 0x10
	static System.Action <>9__26_0; // 0x18
	static System.Action <>9__32_0; // 0x20
	static System.Void .cctor(); // 0x058894e4
	System.Void .ctor(); // 0x05889548
	System.Boolean <RegisterGMCommands>b__4_0(System.Reflection.MethodInfo m); // 0x058895b0
	System.Void <AddCurrency>b__24_0(SimpleJSON.JSONNode ret); // 0x0588964c
	System.Void <KillSelf>b__26_0(); // 0x05889700
	System.Void <EscapeFromStuck>b__32_0(); // 0x058897b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.GMCommands.<>c__DisplayClass34_0 : System.Object
{
	WizardGames.Soc.Common.Data.Item.RefreshProp item; // 0x10
	WizardGames.Soc.Common.Data.ItemCount[] btnProps; // 0x18
	System.Void .ctor(); // 0x05888f9c
	System.Void <RegisterGMCommands_Publish>b__0(System.String param); // 0x05889884
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.GMCommands.<>c__DisplayClass4_0 : System.Object
{
	System.Action staticAction; // 0x10
	System.Void .ctor(); // 0x05886070
	System.Void <RegisterGMCommands>b__1(System.String param); // 0x05889bd4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.GMCommands.<>c__DisplayClass4_1 : System.Object
{
	System.Action instanceAction; // 0x10
	System.Void .ctor(); // 0x058860d8
	System.Void <RegisterGMCommands>b__2(System.String param); // 0x05889c60
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Setting.IComSettingBase : 
{
	
	System.Void OnConfigValueChanged(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.MgrSetting : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Setting.SettingConfig> settingConfigs; // 0x18
	System.Collections.Generic.Dictionary<System.String,System.String> otherPlatformSetting; // 0x20
	System.Collections.Generic.HashSet<System.String> hasApplyedSet; // 0x28
	System.Collections.Generic.List<UnityEngine.Transform> allPoints; // 0x30
	System.Boolean canSeeOthers; // 0x38
	static System.Boolean isDynamicLightOpen; // 0x8
	System.Boolean isInGame; // 0x39
	static System.Boolean isShowScreenCap; // 0x9
	System.Collections.Generic.HashSet<System.String> reloadOnEnterWorld; // 0x40
	System.Action<System.Collections.Generic.Dictionary<System.String,System.String>> <OnConfigApplyFinished>k__BackingField; // 0x48
	System.Collections.Generic.Dictionary<System.String,System.Int32> tbConfigData; // 0x50
	System.Collections.Generic.Dictionary<System.String,System.Int32> tbConfigDataPC; // 0x58
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.ESettingItemGroup,System.Int32> groupToId; // 0x60
	System.Boolean IsUseNewbiePerformanceConfig; // 0x68
	System.Int32 refreshFrameRateFlag; // 0x6c
	WizardGames.Soc.SocClient.Setting.MgrSetting.LockFrameHandler _lockFrameHandler; // 0x70
	System.Int32 deviceLevel; // 0x78
	System.Boolean IsPowerSavingMode; // 0x7c
	System.Boolean isLobbyGmOpen; // 0x7d
	System.Boolean isBattleSvrListOpen; // 0x7e
	System.Boolean RecordChange; // 0x7f
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.String>> TabNameTpGroupDataDic; // 0x80
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Setting.MgrSetting.GmTabData,System.Collections.Generic.List<WizardGames.Soc.SocClient.Setting.GMCommandMeta>> GroupNameToCommandDataDic; // 0x88
	System.Collections.Generic.Dictionary<System.String,System.Int32> TabPriorityDic; // 0x90
	System.Collections.Generic.Dictionary<System.String,System.Int32> GroupPriorityDic; // 0x98
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.ESettingTab,System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.ESettingItemGroup,System.Collections.Generic.List<System.Int32>>> configData; // 0xa0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.ESettingTab> tabList; // 0xa8
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.ESettingTab,System.Int32> tabToId; // 0xb0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.ESettingTab> canShowTabs; // 0xb8
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.ESettingTab> NewbieShieldTabs; // 0xc0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.ESettingTab> publishHideTabs; // 0xc8
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.ESettingTab_PC,System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.ESettingItemGroup,System.Collections.Generic.List<System.Int32>>> configDataPC; // 0xd0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.ESettingTab_PC> tabListPC; // 0xd8
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.ESettingTab_PC,System.Int32> tabToIdPC; // 0xe0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.ESettingTab_PC> canShowTabsPC; // 0xe8
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.ESettingTab_PC> NewbieShieldTabsPC; // 0xf0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.ESettingTab_PC> publishHideTabsPC; // 0xf8
	WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator audioDeviceEnumerator; // 0x100
	System.String _currentQualityDesc; // 0x108
	WizardGames.Soc.SettingsFramework.Framework.LightQuality <CurrentLightQuality>k__BackingField; // 0x110
	WizardGames.Soc.SocClient.Setting.ESettingCommonQualityLevel <CurrentEffectQualityLevel>k__BackingField; // 0x114
	WizardGames.Soc.SettingsFramework.Framework.ISettingBase qualitySettingBase; // 0x118
	WizardGames.Soc.SettingsFramework.Framework.ISettingBase qualitySettingBaseLobby; // 0x120
	System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.String>> gameQualityChildSettings; // 0x128
	System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.String>> gameQualityChildLobbySettings; // 0x130
	System.Collections.Generic.HashSet<System.String> qualityChildDynamicValueKeys; // 0x138
	System.Collections.Generic.HashSet<System.String> qualityChildFixedValueKeys; // 0x140
	System.Collections.Generic.HashSet<System.String> qualityChildLobbyKeys; // 0x148
	System.Collections.Generic.List<System.String> ignoreChildSettingKeys; // 0x150
	System.Collections.Generic.List<System.Int32> supportFpsValueArray; // 0x158
	WizardGames.Soc.SocClient.Setting.EMobileQualityLevel <CurrentMobileQualityLevel>k__BackingField; // 0x160
	WizardGames.Soc.SettingsFramework.Framework.ISettingBase deviceQualitySettingBase; // 0x168
	WizardGames.Soc.SettingsFramework.Framework.ISettingBase deviceQualitySettingBaseLobby; // 0x170
	System.Int32 lobbyDeviceQualityOptionIndex; // 0x178
	System.Int32 deviceQualityOptionIndex; // 0x17c
	System.Collections.Generic.HashSet<System.String> publicQualityChildKeys; // 0x180
	System.Void LoadAimConfig(); // 0x05889cec
	System.Void GetAimValue(System.String value, System.Int32& size, UnityEngine.Color& color); // 0x0588b17c
	System.Void ApplyAimSetting(System.String value); // 0x0588b948
	System.Boolean get_isNewbieMode(); // 0x0588baf0
	static System.Boolean get_IsDynamicLightOpen(); // 0x0588bb78
	System.Boolean get_IsInGame(); // 0x0588bc00
	System.Action<System.Collections.Generic.Dictionary<System.String,System.String>> get_OnConfigApplyFinished(); // 0x0588bc64
	System.Void set_OnConfigApplyFinished(System.Action<System.Collections.Generic.Dictionary<System.String,System.String>> value); // 0x0588bcc8
	System.Void Init(); // 0x0588bd48
	System.Void OnAccountLogined(); // 0x0588c9d0
	System.Void OnAccountEnterLobby(); // 0x0588cab8
	System.Threading.Tasks.Task OnEnterWorld(); // 0x0588ce70
	System.Threading.Tasks.Task OnExitWorld(); // 0x0588d670
	System.Void Update(); // 0x0588d788
	System.Void OnFps1Update(System.Single dt); // 0x0588d7e8
	System.Void CleanUp(); // 0x0588d86c
	System.Void ReadConfig(); // 0x0588cb30
	System.Void RestoreAllSettingValue(); // 0x0588ca40
	System.Void ApplyConfig(System.Collections.Generic.Dictionary<System.String,System.String> configData); // 0x0588de48
	System.Void InitCloudSettingConfig(); // 0x0588d91c
	System.Void InitLocalSettingConfig(System.Boolean bindPlayer); // 0x0588c5a8
	System.Void ApplyQualityChildSettingInLobby(); // 0x0588cd08
	System.Void ApplyQualityAndFpsSettingInGame(); // 0x0588ea38
	System.Void SetLocalConfigValue(System.String key, System.String value, System.Boolean bindPlayer); // 0x0588ebdc
	System.String GetLocalConfigValue(System.String key, System.Boolean bindPlayer); // 0x0588e28c
	System.Void SaveLocalConfig(); // 0x0588eefc
	System.Void OnAccountLogout(); // 0x0588ef84
	System.Void GenConfig(); // 0x0588eff4
	System.Collections.Generic.Dictionary<System.String,System.String> GetPlayerConfig(); // 0x0588f2cc
	WizardGames.Soc.SocClient.Setting.SettingConfig GetConfig(System.String key); // 0x0588afc4
	System.Void AddConfig(System.String settingKey, WizardGames.Soc.SocClient.Setting.SettingConfig config); // 0x0588f818
	System.Void RemoveConfig(System.String settingKey); // 0x058900ec
	System.Void AddGameConfig(System.String settingKey, WizardGames.Soc.SocClient.Setting.SettingConfig config); // 0x058901c4
	System.Void AddGameConfigFromTable(System.String key, System.Boolean needSave, System.Action<System.String> clickAction, System.Boolean hasExtSwitchName, System.Action<System.String> extSwitchAction); // 0x0588a430
	System.Void DoAddConfig(System.String key, WizardGames.Soc.SocClient.Setting.SettingConfig config, System.Boolean triggerOnEnterWorld); // 0x05890338
	System.Int32[] GetConfigOptionsKeys(System.String key); // 0x058903ec
	System.Int32 GetConfigDefaultIndex(System.String key); // 0x058905b8
	System.Int32 GetConfigTitleLanguageId(System.String key); // 0x058906b0
	System.Void AddSwitchLanguageConfig(); // 0x05890758
	System.Void LoadConfig(); // 0x0588bdd4
	WizardGames.Soc.Common.Data.Item.Setting GetSettingConfigByKey(System.String key); // 0x0588fdd0
	WizardGames.Soc.Common.Data.Item.Setting_PC GetSettingConfigByKey_PC(System.String key); // 0x0588fab4
	System.Void LoadItemGroup(); // 0x05892828
	System.Int32 GetGroupIdByGroup(WizardGames.Soc.Common.Data.ESettingItemGroup group); // 0x05892ab0
	System.Boolean IsConfigOpen(System.String key); // 0x05892b64
	System.Void LoadGameConfigList(); // 0x0588c298
	System.Void LoadBasicsConfig(); // 0x05892bfc
	static System.Void RefreshSafeArea(); // 0x058982fc
	System.Void LoadAgreements(); // 0x058981a4
	System.Void LoadControlConfig(); // 0x05894adc
	System.Void LoadGamingPerformanceConfig(); // 0x05897dd0
	System.Int32 GetValidDeviceLevel(System.Int32 groupId); // 0x05898424
	System.Void CheckDeviceLevelChange(); // 0x0588dbd4
	System.Void SetGameQuality(WizardGames.Soc.RMQualityLevelBeta qualityLevel, System.Boolean needPostInfo); // 0x05898df8
	System.Void SetGameFPS(System.Int32 fps, System.Boolean needSliceData); // 0x05899010
	System.Void SensitivityConfigWarning(System.String name, System.Single num); // 0x05899368
	System.Void LoadSoundConfig(); // 0x058965e0
	System.Void LoadPrivacyConfig(); // 0x0589730c
	System.Void LoadPickupConfig(); // 0x05897748
	System.Void SetCustomSchemeIndex(System.Int32 index); // 0x05899554
	System.Void FindNodeUiParse(FairyGUI.GComponent node); // 0x0589974c
	System.Void ParseNodeConfig(FairyGUI.GComponent com); // 0x0589988c
	System.Boolean CheckAutoOpenDoorPermission(UnityEngine.Vector3 playerPos, WizardGames.Soc.Common.Entity.TerritoryEntity& terrEnt); // 0x05899be4
	System.Int32 GetLockFrameCount(); // 0x05899ed0
	System.String GetUiSettingName(); // 0x05899f74
	System.Void OpenUiSetting(); // 0x0589a010
	System.Void HideUiSetting(); // 0x0589a0cc
	System.Boolean IsUiSettingActive(); // 0x0589a17c
	System.String GetSettingUiAssetPath(System.String name); // 0x0589a248
	static System.Boolean get_IsGmOpen(); // 0x0589a334
	System.Void InitLobbyGmOpen(); // 0x0588c32c
	System.Void ClearGMControlInfoCache(); // 0x0589a440
	System.Void CacheGMControlInfo(WizardGames.Soc.SocClient.Setting.GMCommandMeta cmd); // 0x0589a51c
	System.Void SortGMControlInfo(); // 0x0589a928
	System.Void LoadGmCommandConfig(); // 0x05897ae0
	System.Void LoadTabDataFromTb(); // 0x05891bc4
	System.Void LoadConfigFromTb(); // 0x0589200c
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.ESettingTab> GetCanShowTabs(); // 0x0589ab30
	System.Boolean IsNewbieShieldTab(WizardGames.Soc.Common.Data.ESettingTab tab); // 0x0589ae98
	System.Int32 GetTabId(WizardGames.Soc.Common.Data.ESettingTab tab); // 0x0589af34
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.ESettingItemGroup,System.Collections.Generic.List<System.Int32>> GetConfigDataByTab(WizardGames.Soc.Common.Data.ESettingTab tab); // 0x0589b010
	System.Void LoadBasicsConfigMobile(); // 0x05897d70
	System.Boolean IsUsePCUi(); // 0x0588e228
	System.Void LoadTabDataFromTb_PC(); // 0x05890f60
	System.Void LoadConfigFromTb_PC(); // 0x058913a8
	System.Void LoadBasicsConfigPc(); // 0x05897cf4
	System.Void LoadBuildInteractiveConfigPC(); // 0x0589b0ec
	System.Void LoadKeyboardGuideConfigPC(); // 0x0589b384
	System.Void LoadSoundConfigPC(); // 0x0589b4d0
	System.Void LoadMicChannelConfigPC(); // 0x0589b9b8
	System.Void AddMicConfig(System.String key, WizardGames.Soc.SocClient.Setting.SettingConfig settingConfig, System.Boolean saveImmediately); // 0x0589bce0
	System.Void HidePlayerMicVolumeControls(); // 0x0589bff8
	System.Void ShowPlayerMicVolumeControlsByTeammateCount(); // 0x0589c1b4
	System.Int32 GetTeammateCountExcludingSelf(); // 0x0589c5f0
	System.String get_CurrentQualityDesc(); // 0x0589c9e8
	System.Void set_CurrentQualityDesc(System.String value); // 0x0589ca4c
	WizardGames.Soc.SettingsFramework.Framework.LightQuality get_CurrentLightQuality(); // 0x0589cb98
	System.Void set_CurrentLightQuality(WizardGames.Soc.SettingsFramework.Framework.LightQuality value); // 0x0589cbfc
	WizardGames.Soc.SocClient.Setting.ESettingCommonQualityLevel get_CurrentEffectQualityLevel(); // 0x0589cc74
	System.Void set_CurrentEffectQualityLevel(WizardGames.Soc.SocClient.Setting.ESettingCommonQualityLevel value); // 0x0589ccd8
	System.Void ApplyLobbyQualityAllChildSetting(); // 0x0588e7d4
	System.Void ApplySingleFixedChildSetting(System.String qualityChildKey); // 0x0589cd50
	System.Void ApplySingleDynamicChildSetting(System.String qualityChildKey); // 0x0589d5c0
	System.Void ApplyChildSettingValue(WizardGames.Soc.SettingsFramework.Framework.ISettingBase childSettingBase, System.Int32 optionIndex); // 0x0589d238
	System.Void RefreshQualityChildData(WizardGames.Soc.SettingsFramework.Framework.SettingBase settingBase, System.Int32 curIndex); // 0x0589db30
	System.Void InitLobbyAndGameSettingBase(); // 0x058986a8
	System.Void LoadAllChildSettingBaseData(); // 0x0589e2cc
	System.Void LoadSettings(WizardGames.Soc.SettingsFramework.Framework.ISettingBase settingBase, System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.String>> targetList, System.Collections.Generic.HashSet<System.String> keyList, System.Collections.Generic.HashSet<System.String> fixedValueKeys, System.Collections.Generic.HashSet<System.String> dynamicValueKeys, System.String settingType); // 0x0589e480
	System.Void ProcessCompositeOption(WizardGames.Soc.SettingsFramework.CompositeSettingOption compositeOption, System.Collections.Generic.Dictionary<System.String,System.String> childDict, System.Collections.Generic.HashSet<System.String> keyList, System.Collections.Generic.HashSet<System.String> fixedValueKeys, System.Collections.Generic.HashSet<System.String> dynamicValueKeys, System.String settingType); // 0x0589e9dc
	System.Void HandleScreenStyle(System.String selectValue); // 0x0589f2bc
	WizardGames.Soc.SocClient.Setting.EMobileQualityLevel get_CurrentMobileQualityLevel(); // 0x0589f550
	System.Void set_CurrentMobileQualityLevel(WizardGames.Soc.SocClient.Setting.EMobileQualityLevel value); // 0x0589f5b4
	System.Void LoadScreenSettingMobile(); // 0x05898850
	System.Void ApplyScreenSettingInGameMobile(); // 0x0588d600
	System.Void LoadScreenStyleConfig(); // 0x058a0750
	System.Void SetSuperSamplingResolutionDefault(); // 0x05898a88
	WizardGames.Soc.Common.Data.Device.QualityFPSDefault GetQualityFPSDefaultConfig(System.Int32 groupId); // 0x058a0f20
	System.Boolean TryGetQualityFPSConfigData(System.Int32 level, System.Int32& defaultQualityIndex, System.Int32& defaultFpsIndex, System.Int32[]& supportedQuality, System.Int32[]& supportedFps); // 0x058a11cc
	System.Int32 GetQualityDefaultValue(); // 0x058a1594
	System.Void SetQualityAndFpsInNewbie(); // 0x0588d2b4
	System.Void LoadGameQualityConfig(); // 0x0589f9f0
	System.Void ReloadSettingConfig(WizardGames.Soc.SocClient.Setting.SettingSwitchConfig newSwitchConfig, System.String key, System.Int32 defaultIndex); // 0x058a1b98
	WizardGames.Soc.SocClient.Ui.MsgBoxInfo CheckFpsSupport(System.Int32 qualitySelectedIndex); // 0x058a1ce4
	System.Int32 FindQualityMaxSupportFPSIndex(System.Int32 level, System.Int32 qualityIndex); // 0x058a20f8
	System.Int32 FindFPSMaxSupportQualityIndex(System.Int32 level, System.Int32 fpsSelectIndex); // 0x058a2808
	System.Boolean IsValidQualitySelection(System.String selected); // 0x058a3238
	System.ValueTuple<System.Collections.Generic.List<System.Int32>,System.Collections.Generic.List<System.String>,System.Collections.Generic.List<System.Int32>> PrepareQualityOptions(System.Int32[] supportedQuality); // 0x058a16f4
	WizardGames.Soc.SocClient.Setting.SettingSwitchConfig CreateQualitySetting(System.Int32[] optionsKeys, System.String[] tempOptionTitles, System.Int32[] disableIndexes); // 0x058a1a74
	System.Void HandleQualitySelectionMobile(System.String selected); // 0x058a3304
	System.Void AdjustMaxFpsIfNeeded(System.Int32 groupId, System.Int32 qualitySelectedIndex); // 0x058a3d44
	System.Void LoadGameFPSConfig(System.Boolean isReload); // 0x0589fe68
	System.Void HandleFpsSelection(System.String selected); // 0x058a42e4
	System.Boolean IsValidFpsSelection(System.String selected); // 0x058a47d8
	System.Void AdjustMaxQualityIfNeeded(System.Int32 groupId, System.Int32 fpsLevelIndex); // 0x058a459c
	WizardGames.Soc.SocClient.Ui.MsgBoxInfo CheckFpsWarningTip(System.Int32 selectedIndex); // 0x058a48a4
	WizardGames.Soc.SocClient.Ui.MsgBoxInfo CheckQualitySupport(System.Int32 selectedIndex); // 0x058a4ac4
	System.Void InitDeviceLevelQualitySetting(); // 0x058988d8
	System.Void SetGameDeviceQualityOptionIndex(System.Int32 index); // 0x058a0a84
	System.Int32 GetDefaultDeviceQualityValueForLobby(); // 0x058a4fb8
	System.Int32 GetDeviceQualityDefaultIndexForLobby(); // 0x058a4d94
	System.Void SetMobileDeviceQualityForLobby(); // 0x0588e360
	System.Void LoadAllChildSettingBaseConfig(); // 0x0589f62c
	WizardGames.Soc.Common.Data.Device.QualityDesc GetCurrentQualityDesc(); // 0x058a3820
	System.Void RefreshAllSettingOptionState(); // 0x058a40bc
	System.Void HandleAllPublicChildSetting(System.Collections.Generic.Dictionary<System.String,System.String> childDict); // 0x058a526c
	System.Void HandleAllPrivateChildSetting(System.Collections.Generic.Dictionary<System.String,System.String> childDict); // 0x058a5b80
	System.Void DoSenesitivityAction(System.String key, System.String param, System.Int64 id, System.Collections.Generic.Dictionary<System.Int64,System.Single>& config); // 0x058a6210
	System.Void LoadSensitivityConfig(); // 0x05894e70
	System.Void .ctor(); // 0x058a630c
	static System.Void .cctor(); // 0x058a7350
	System.Void <ReadConfig>b__44_0(SimpleJSON.JSONNode res); // 0x058a7438
	System.Void <LoadBasicsConfig>b__75_17(System.String param); // 0x058a75d4
	System.Void <LoadBasicsConfig>b__75_18(System.String param); // 0x058a778c
	System.Void <LoadBasicsConfig>b__75_19(System.String param); // 0x058a7a00
	System.Void <LoadBasicsConfig>b__75_20(System.String param); // 0x058a7c74
	System.Void <LoadBasicsConfig>b__75_31(System.String param); // 0x058a7f2c
	System.Void <LoadBasicsConfig>b__75_32(System.String param); // 0x058a8288
	System.Void <LoadBasicsConfig>b__75_33(System.String selected); // 0x058a85e4
	System.Void <LoadControlConfig>b__78_0(System.String param); // 0x058a869c
	System.Void <LoadSoundConfig>b__85_13(System.String selected); // 0x058a8828
	System.Int32 <SortGMControlInfo>b__113_0(System.String a, System.String b); // 0x058a8a70
	System.Void <LoadSoundConfigPC>b__164_2(System.String param); // 0x058a8b54
	System.Void <LoadSoundConfigPC>b__164_4(System.String param); // 0x058a8bf8
	System.Void <LoadSoundConfigPC>b__164_5(System.String param); // 0x058a8db4
	System.Void <LoadSensitivityConfig>b__269_0(System.String param); // 0x058a8e58
	System.Void <LoadSensitivityConfig>b__269_1(System.String param); // 0x058a8f50
	System.Void <LoadSensitivityConfig>b__269_2(System.String param); // 0x058a90b0
	System.Void <LoadSensitivityConfig>b__269_3(System.String param); // 0x058a9210
	System.Void <LoadSensitivityConfig>b__269_4(System.String param); // 0x058a9370
	System.Void <LoadSensitivityConfig>b__269_5(System.String param); // 0x058a94d0
	System.Void <LoadSensitivityConfig>b__269_6(System.String param); // 0x058a95b0
	System.Void <LoadSensitivityConfig>b__269_7(System.String param); // 0x058a9694
	System.Void <LoadSensitivityConfig>b__269_8(System.String param); // 0x058a9778
	System.Void <LoadSensitivityConfig>b__269_9(System.String param); // 0x058a985c
	System.Void <LoadSensitivityConfig>b__269_10(System.String param); // 0x058a9940
	System.Void <LoadSensitivityConfig>b__269_11(System.String param); // 0x058a9a24
	System.Void <LoadSensitivityConfig>b__269_12(System.String param); // 0x058a9b08
	System.Void <LoadSensitivityConfig>b__269_13(System.String param); // 0x058a9bec
	System.Void <LoadSensitivityConfig>b__269_14(System.String param); // 0x058a9cd0
	System.Void <LoadSensitivityConfig>b__269_15(System.String param); // 0x058a9db0
	System.Void <LoadSensitivityConfig>b__269_16(System.String param); // 0x058a9e94
	System.Void <LoadSensitivityConfig>b__269_17(System.String param); // 0x058a9f78
	System.Void <LoadSensitivityConfig>b__269_18(System.String param); // 0x058aa05c
	System.Void <LoadSensitivityConfig>b__269_19(System.String param); // 0x058aa140
	System.Void <LoadSensitivityConfig>b__269_20(System.String param); // 0x058aa224
	System.Void <LoadSensitivityConfig>b__269_21(System.String param); // 0x058aa308
	System.Void <LoadSensitivityConfig>b__269_22(System.String param); // 0x058aa3e8
	System.Void <LoadSensitivityConfig>b__269_23(System.String param); // 0x058aa4cc
	System.Void <LoadSensitivityConfig>b__269_24(System.String param); // 0x058aa5b0
	System.Void <LoadSensitivityConfig>b__269_25(System.String param); // 0x058aa694
	System.Void <LoadSensitivityConfig>b__269_26(System.String param); // 0x058aa778
	System.Void <LoadSensitivityConfig>b__269_27(System.String param); // 0x058aa85c
	System.Void <LoadSensitivityConfig>b__269_28(System.String param); // 0x058aa940
	System.Void <LoadSensitivityConfig>b__269_29(System.String param); // 0x058aaa24
	System.Void <LoadSensitivityConfig>b__269_30(System.String param); // 0x058aab08
	System.Void <LoadSensitivityConfig>b__269_31(System.String param); // 0x058aabe8
	System.Void <LoadSensitivityConfig>b__269_32(System.String param); // 0x058aaccc
	System.Void <LoadSensitivityConfig>b__269_33(System.String param); // 0x058aadb0
	System.Void <LoadSensitivityConfig>b__269_34(System.String param); // 0x058aae94
	System.Void <LoadSensitivityConfig>b__269_35(System.String param); // 0x058aaf78
	System.Void <LoadSensitivityConfig>b__269_36(System.String param); // 0x058ab05c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Setting.MgrSetting.GmTabData : System.ValueType
{
	System.String TabName; // 0x10
	System.String GroupName; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.MgrSetting.PointInfo : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.SocClient.Setting.MgrSetting.PointInfo.EPointType type; // 0x30
	System.Single coverDot; // 0x34
	System.Single radius; // 0x38
	System.Void OnDrawGizmos(); // 0x058ab68c
	System.Void .ctor(); // 0x058abce4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Setting.MgrSetting.PointInfo.EPointType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Setting.MgrSetting.PointInfo.EPointType Move = 0;
	static WizardGames.Soc.SocClient.Setting.MgrSetting.PointInfo.EPointType Cover = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.MgrSetting.PathInfo : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Setting.MgrSetting.PointInfo> points; // 0x30
	System.Void OnDrawGizmos(); // 0x058abd4c
	System.Void .ctor(); // 0x058ac034
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.MgrSetting.LockFrameHandler : System.Object
{
	System.Int32 _lastStableFrameRate; // 0x10
	System.Int32 _frameStableTime; // 0x14
	System.Int32 _stableLowFrameTimes; // 0x18
	System.Void OnFps1Update(); // 0x058ac0e8
	System.Int32 GetStableLowFrameCount(); // 0x058ac3ac
	System.Void .ctor(); // 0x058ac410
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator : UnityEngine.MonoBehaviour
{
	static System.Guid CLSID_PolicyConfigClient; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.AudioDeviceInfo> GetAudioInputDevices(); // 0x058ac478
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.AudioDeviceInfo> GetAudioOutputDevices(); // 0x058acb84
	System.Int32 GetAudioInputDevicesCount(); // 0x058acbec
	System.Int32 GetAudioOutputDevicesCount(); // 0x058acc70
	System.Boolean SwitchInputDevice(System.Int32 deviceIndex); // 0x058accf4
	System.Boolean SwitchOutputDevice(System.Int32 deviceIndex); // 0x058adc70
	WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.AudioDeviceInfo GetDefaultAudioDevice(WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DataFlow flow); // 0x058ad31c
	System.Boolean SetDefaultAudioDevice(System.String deviceId, WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DataFlow flow); // 0x058ad6b8
	WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.IMMDeviceEnumerator GetDeviceEnumerator(); // 0x058ae298
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.AudioDeviceInfo> GetAudioDevices(WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DataFlow flow); // 0x058ac4e0
	System.String GetStringProperty(WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.IMMDevice device, System.String propertyName); // 0x058ae480
	static System.Int32 CoCreateInstance(System.Guid& rclsid, System.IntPtr pUnkOuter, WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.CLSCTX dwClsContext, System.Guid& riid, System.IntPtr& ppv); // 0x058ae9e8
	System.Void .ctor(); // 0x058aeab4
	static System.Void .cctor(); // 0x058aeb1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.AudioDeviceInfo : System.Object
{
	System.String <Id>k__BackingField; // 0x10
	System.String <FriendlyName>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DataFlow <DataFlow>k__BackingField; // 0x20
	System.String get_Id(); // 0x058aeb98
	System.Void set_Id(System.String value); // 0x058aebfc
	System.String get_FriendlyName(); // 0x058aec7c
	System.Void set_FriendlyName(System.String value); // 0x058aece0
	System.Void set_DataFlow(WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DataFlow value); // 0x058aed60
	System.Void .ctor(); // 0x058ae980
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.IPolicyConfig : 
{
	
	System.Void $__Stripped0_GetMixFormat(); // 0x055049cc
	System.Void $__Stripped1_GetDeviceFormat(); // 0x055049cc
	System.Void $__Stripped2_ResetDeviceFormat(); // 0x055049cc
	System.Void $__Stripped3_SetDeviceFormat(); // 0x055049cc
	System.Void $__Stripped4_GetProcessingPeriod(); // 0x055049cc
	System.Void $__Stripped5_SetProcessingPeriod(); // 0x055049cc
	System.Void $__Stripped6_GetShareMode(); // 0x055049cc
	System.Void $__Stripped7_SetShareMode(); // 0x055049cc
	System.Void $__Stripped8_GetPropertyValue(); // 0x055049cc
	System.Void $__Stripped9_SetPropertyValue(); // 0x055049cc
	System.Int32 SetDefaultEndpoint(System.String deviceId, WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.Role role); // 0x058aedd8
	System.Void $__Stripped10_SetEndpointVisibility(); // 0x055049cc
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.IMMDeviceEnumerator : 
{
	
	System.Int32 EnumAudioEndpoints(WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DataFlow dataFlow, WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DeviceState stateMask, WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.IMMDeviceCollection& devices); // 0x058aee78
	System.Int32 GetDefaultAudioEndpoint(WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DataFlow dataFlow, WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.Role role, WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.IMMDevice& endpoint); // 0x058aef88
	System.Void $__Stripped0_GetDevice(); // 0x055049cc
	System.Void $__Stripped1_RegisterEndpointNotificationCallback(); // 0x055049cc
	System.Void $__Stripped2_UnregisterEndpointNotificationCallback(); // 0x055049cc
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.IMMDeviceCollection : 
{
	
	System.Int32 GetCount(System.UInt32& count); // 0x058af098
	System.Int32 Item(System.UInt32 nDevice, WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.IMMDevice& device); // 0x058af114
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.IMMDevice : 
{
	
	System.Void $__Stripped0_Activate(); // 0x055049cc
	System.Int32 OpenPropertyStore(WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.StorageAccessMode access, WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.IPropertyStore& properties); // 0x058af21c
	System.Int32 GetId(System.IntPtr& deviceId); // 0x058af324
	System.Void $__Stripped1_GetState(); // 0x055049cc
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.IPropertyStore : 
{
	
	System.Void $__Stripped0_GetCount(); // 0x055049cc
	System.Void $__Stripped1_GetAt(); // 0x055049cc
	System.Int32 GetValue(WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.PropertyKey& key, WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.PropVariant& value); // 0x058af3a0
	System.Void $__Stripped2_SetValue(); // 0x055049cc
	System.Void $__Stripped3_Commit(); // 0x055049cc
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.PropertyKey : System.ValueType
{
	System.Guid fmtid; // 0x10
	System.UInt32 pid; // 0x20
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.PropVariant : System.ValueType
{
	System.UInt16 vt; // 0x10
	System.IntPtr pointerValue; // 0x18
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DataFlow : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DataFlow eRender = 0;
	static WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DataFlow eCapture = 1;
	static WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DataFlow eAll = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DeviceState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DeviceState DeviceStateActive = 1;
	static WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DeviceState DeviceStateDisabled = 2;
	static WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DeviceState DeviceStateNotPresent = 4;
	static WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DeviceState DeviceStateUnplugged = 8;
	static WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.DeviceState DeviceStateMaskAll = 15;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.CLSCTX : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.CLSCTX CLSCTX_INPROC_SERVER = 1;
	static WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.CLSCTX CLSCTX_INPROC_HANDLER = 2;
	static WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.CLSCTX CLSCTX_LOCAL_SERVER = 4;
	static WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.CLSCTX CLSCTX_REMOTE_SERVER = 16;
	static WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.CLSCTX CLSCTX_ALL = 23;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.Role : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.Role eConsole = 0;
	static WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.Role eMultimedia = 1;
	static WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.Role eCommunications = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.StorageAccessMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.StorageAccessMode STGM_READ = 0;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.<>c__DisplayClass5_0 : System.Object
{
	WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.AudioDeviceInfo currentDefault; // 0x10
	System.Void .ctor(); // 0x058ad2b4
	System.Boolean <SwitchInputDevice>b__0(WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.AudioDeviceInfo d); // 0x058af424
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.<>c__DisplayClass6_0 : System.Object
{
	WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.AudioDeviceInfo currentDefault; // 0x10
	System.Void .ctor(); // 0x058ae230
	System.Boolean <SwitchOutputDevice>b__0(WizardGames.Soc.SocClient.Setting.MgrSetting.AudioDeviceEnumerator.AudioDeviceInfo d); // 0x058af53c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.MgrSetting.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Setting.MgrSetting.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__55_0; // 0x8
	static System.Comparison<WizardGames.Soc.Common.Data.language.LanguageConfig> <>9__66_0; // 0x10
	static System.Func<System.String,System.Boolean> <>9__66_1; // 0x18
	static System.Func<System.Int32,WizardGames.Soc.SocClient.Ui.MsgBoxInfo> <>9__66_3; // 0x20
	static System.Action<System.String> <>9__75_0; // 0x28
	static System.Action<System.String> <>9__75_1; // 0x30
	static System.Action<System.String> <>9__75_2; // 0x38
	static System.Action<System.String> <>9__75_3; // 0x40
	static System.Action<System.String> <>9__75_4; // 0x48
	static System.Action<System.String> <>9__75_5; // 0x50
	static System.Action<System.String> <>9__75_6; // 0x58
	static System.Action<System.String> <>9__75_7; // 0x60
	static System.Action<System.String> <>9__75_8; // 0x68
	static System.Action<System.String> <>9__75_9; // 0x70
	static System.Action<System.String> <>9__75_10; // 0x78
	static System.Action<System.String> <>9__75_11; // 0x80
	static System.Action<System.String> <>9__75_12; // 0x88
	static System.Action<System.String> <>9__75_13; // 0x90
	static System.Action<System.String> <>9__75_14; // 0x98
	static System.Action<System.String> <>9__75_15; // 0xa0
	static System.Action<System.String> <>9__75_16; // 0xa8
	static System.Action<System.String> <>9__75_21; // 0xb0
	static System.Action<System.String> <>9__75_22; // 0xb8
	static System.Action<System.String> <>9__75_23; // 0xc0
	static System.Action<System.String> <>9__75_24; // 0xc8
	static System.Action<System.String> <>9__75_25; // 0xd0
	static System.Action<System.String> <>9__75_26; // 0xd8
	static System.Action<System.String> <>9__75_27; // 0xe0
	static System.Action<System.String> <>9__75_28; // 0xe8
	static System.Action<System.String> <>9__75_29; // 0xf0
	static System.Action<System.String> <>9__75_30; // 0xf8
	static System.Action<System.String> <>9__75_34; // 0x100
	static System.Action<System.String> <>9__75_35; // 0x108
	static System.Action<System.String> <>9__75_36; // 0x110
	static System.Action<System.String> <>9__75_37; // 0x118
	static System.Action<System.String> <>9__75_38; // 0x120
	static System.Action<System.String> <>9__75_39; // 0x128
	static System.Action<System.String> <>9__75_40; // 0x130
	static System.Action<System.String> <>9__75_41; // 0x138
	static System.Action<System.String> <>9__78_1; // 0x140
	static System.Action<System.String> <>9__78_2; // 0x148
	static System.Action<System.String> <>9__85_0; // 0x150
	static System.Action<System.String> <>9__85_1; // 0x158
	static System.Action<System.String> <>9__85_2; // 0x160
	static System.Action<System.String> <>9__85_3; // 0x168
	static System.Action<System.String> <>9__85_4; // 0x170
	static System.Action<System.String> <>9__85_5; // 0x178
	static System.Action<System.String> <>9__85_6; // 0x180
	static System.Action<System.String> <>9__85_7; // 0x188
	static System.Action<System.String> <>9__85_8; // 0x190
	static System.Action<System.String> <>9__85_9; // 0x198
	static System.Action<System.String> <>9__85_10; // 0x1a0
	static System.Action<System.String> <>9__85_11; // 0x1a8
	static System.Action<System.String> <>9__85_12; // 0x1b0
	static System.Action<System.String> <>9__85_14; // 0x1b8
	static System.Action<System.String> <>9__85_15; // 0x1c0
	static System.Action<System.String> <>9__85_16; // 0x1c8
	static System.Action<System.String> <>9__85_17; // 0x1d0
	static System.Action<System.String> <>9__85_18; // 0x1d8
	static System.Action<System.String> <>9__85_19; // 0x1e0
	static System.Action<System.String> <>9__86_0; // 0x1e8
	static System.Action<System.String> <>9__86_1; // 0x1f0
	static System.Action<System.String> <>9__86_2; // 0x1f8
	static System.Action<System.String> <>9__86_3; // 0x200
	static System.Action<System.String> <>9__86_4; // 0x208
	static System.Comparison<WizardGames.Soc.Common.Data.Item.SettingTab> <>9__132_0; // 0x210
	static System.Comparison<System.Int32> <>9__133_0; // 0x218
	static System.Comparison<WizardGames.Soc.Common.Data.Item.SettingTab_PC> <>9__154_0; // 0x220
	static System.Comparison<System.Int32> <>9__155_0; // 0x228
	static System.Action<System.String> <>9__162_0; // 0x230
	static System.Func<System.String,System.Boolean> <>9__162_1; // 0x238
	static System.Action<System.String> <>9__163_0; // 0x240
	static System.Action<System.String> <>9__164_0; // 0x248
	static System.Action<System.String> <>9__164_1; // 0x250
	static System.Action<System.String> <>9__164_3; // 0x258
	static System.Action<System.String> <>9__269_37; // 0x260
	static System.Action<System.String> <>9__269_38; // 0x268
	static System.Action<System.String> <>9__269_39; // 0x270
	static System.Action<System.String> <>9__269_40; // 0x278
	static System.Action<System.String> <>9__269_41; // 0x280
	static System.Action<System.String> <>9__269_42; // 0x288
	static System.Action<System.String> <>9__269_43; // 0x290
	static System.Action<System.String> <>9__269_44; // 0x298
	static System.Action<System.String> <>9__269_45; // 0x2a0
	static System.Void .cctor(); // 0x058af654
	System.Void .ctor(); // 0x058af6b8
	System.Void <GenConfig>b__55_0(SimpleJSON.JSONNode res); // 0x058af720
	System.Int32 <AddSwitchLanguageConfig>b__66_0(WizardGames.Soc.Common.Data.language.LanguageConfig a, WizardGames.Soc.Common.Data.language.LanguageConfig b); // 0x058af794
	System.Boolean <AddSwitchLanguageConfig>b__66_1(System.String selected); // 0x058af828
	WizardGames.Soc.SocClient.Ui.MsgBoxInfo <AddSwitchLanguageConfig>b__66_3(System.Int32 selectIndex); // 0x058af98c
	System.Void <LoadBasicsConfig>b__75_0(System.String selected); // 0x058afa78
	System.Void <LoadBasicsConfig>b__75_1(System.String selected); // 0x058afe38
	System.Void <LoadBasicsConfig>b__75_2(System.String selected); // 0x058b01f8
	System.Void <LoadBasicsConfig>b__75_3(System.String selected); // 0x058b05b8
	System.Void <LoadBasicsConfig>b__75_4(System.String selected); // 0x058b0978
	System.Void <LoadBasicsConfig>b__75_5(System.String selected); // 0x058b0d38
	System.Void <LoadBasicsConfig>b__75_6(System.String selected); // 0x058b0e14
	System.Void <LoadBasicsConfig>b__75_7(System.String selected); // 0x058b0f5c
	System.Void <LoadBasicsConfig>b__75_8(System.String selected); // 0x058b10a4
	System.Void <LoadBasicsConfig>b__75_9(System.String selected); // 0x058b11ec
	System.Void <LoadBasicsConfig>b__75_10(System.String selected); // 0x058b12d0
	System.Void <LoadBasicsConfig>b__75_11(System.String selected); // 0x058b13c4
	System.Void <LoadBasicsConfig>b__75_12(System.String selected); // 0x058b1438
	System.Void <LoadBasicsConfig>b__75_13(System.String selected); // 0x058b1504
	System.Void <LoadBasicsConfig>b__75_14(System.String selected); // 0x058b15f4
	System.Void <LoadBasicsConfig>b__75_15(System.String selectIndex); // 0x058b16e4
	System.Void <LoadBasicsConfig>b__75_16(System.String selected); // 0x058b1824
	System.Void <LoadBasicsConfig>b__75_21(System.String selected); // 0x058b19f8
	System.Void <LoadBasicsConfig>b__75_22(System.String selected); // 0x058b1b04
	System.Void <LoadBasicsConfig>b__75_23(System.String selected); // 0x058b1c68
	System.Void <LoadBasicsConfig>b__75_24(System.String selected); // 0x058b1dc4
	System.Void <LoadBasicsConfig>b__75_25(System.String selected); // 0x058b1eb8
	System.Void <LoadBasicsConfig>b__75_26(System.String selected); // 0x058b1fac
	System.Void <LoadBasicsConfig>b__75_27(System.String selected); // 0x058b20a0
	System.Void <LoadBasicsConfig>b__75_28(System.String param); // 0x058b2184
	System.Void <LoadBasicsConfig>b__75_29(System.String selected); // 0x058b22c0
	System.Void <LoadBasicsConfig>b__75_30(System.String selected); // 0x058b23c0
	System.Void <LoadBasicsConfig>b__75_34(System.String selected); // 0x058b2494
	System.Void <LoadBasicsConfig>b__75_35(System.String selected); // 0x058b2580
	System.Void <LoadBasicsConfig>b__75_36(System.String selected); // 0x058b2664
	System.Void <LoadBasicsConfig>b__75_37(System.String param); // 0x058b2790
	System.Void <LoadBasicsConfig>b__75_38(System.String param); // 0x058b291c
	System.Void <LoadBasicsConfig>b__75_39(System.String selected); // 0x058b2a8c
	System.Void <LoadBasicsConfig>b__75_40(System.String selected); // 0x058b2b70
	System.Void <LoadBasicsConfig>b__75_41(System.String selected); // 0x058b2c54
	System.Void <LoadControlConfig>b__78_1(System.String selected); // 0x058b2d00
	System.Void <LoadControlConfig>b__78_2(System.String selected); // 0x058b2e64
	System.Void <LoadSoundConfig>b__85_0(System.String param); // 0x058b3004
	System.Void <LoadSoundConfig>b__85_1(System.String selected); // 0x058b30d4
	System.Void <LoadSoundConfig>b__85_2(System.String param); // 0x058b31c8
	System.Void <LoadSoundConfig>b__85_3(System.String selected); // 0x058b3298
	System.Void <LoadSoundConfig>b__85_4(System.String param); // 0x058b338c
	System.Void <LoadSoundConfig>b__85_5(System.String selected); // 0x058b345c
	System.Void <LoadSoundConfig>b__85_6(System.String param); // 0x058b3550
	System.Void <LoadSoundConfig>b__85_7(System.String selected); // 0x058b3620
	System.Void <LoadSoundConfig>b__85_8(System.String param); // 0x058b3714
	System.Void <LoadSoundConfig>b__85_9(System.String selected); // 0x058b37e4
	System.Void <LoadSoundConfig>b__85_10(System.String param); // 0x058b38d8
	System.Void <LoadSoundConfig>b__85_11(System.String selected); // 0x058b39a8
	System.Void <LoadSoundConfig>b__85_12(System.String param); // 0x058b3a9c
	System.Void <LoadSoundConfig>b__85_14(System.String param); // 0x058b3b68
	System.Void <LoadSoundConfig>b__85_15(System.String selected); // 0x058b3c34
	System.Void <LoadSoundConfig>b__85_16(System.String selected); // 0x058b3d30
	System.Void <LoadSoundConfig>b__85_17(System.String selected); // 0x058b3e14
	System.Void <LoadSoundConfig>b__85_18(System.String selected); // 0x058b3f04
	System.Void <LoadSoundConfig>b__85_19(System.String selected); // 0x058b3ff4
	System.Void <LoadPrivacyConfig>b__86_0(System.String selected); // 0x058b40e4
	System.Void <LoadPrivacyConfig>b__86_1(System.String selected); // 0x058b423c
	System.Void <LoadPrivacyConfig>b__86_2(System.String selected); // 0x058b4394
	System.Void <LoadPrivacyConfig>b__86_3(System.String selected); // 0x058b44ec
	System.Void <LoadPrivacyConfig>b__86_4(System.String selected); // 0x058b4644
	System.Int32 <LoadTabDataFromTb>b__132_0(WizardGames.Soc.Common.Data.Item.SettingTab a, WizardGames.Soc.Common.Data.Item.SettingTab b); // 0x058b479c
	System.Int32 <LoadConfigFromTb>b__133_0(System.Int32 a, System.Int32 b); // 0x058b4830
	System.Int32 <LoadTabDataFromTb_PC>b__154_0(WizardGames.Soc.Common.Data.Item.SettingTab_PC a, WizardGames.Soc.Common.Data.Item.SettingTab_PC b); // 0x058b49c4
	System.Int32 <LoadConfigFromTb_PC>b__155_0(System.Int32 a, System.Int32 b); // 0x058b4a58
	System.Void <LoadBuildInteractiveConfigPC>b__162_0(System.String selected); // 0x058b4bec
	System.Boolean <LoadBuildInteractiveConfigPC>b__162_1(System.String value); // 0x058b4dd0
	System.Void <LoadKeyboardGuideConfigPC>b__163_0(System.String selected); // 0x058b50b4
	System.Void <LoadSoundConfigPC>b__164_0(System.String param); // 0x058b51a4
	System.Void <LoadSoundConfigPC>b__164_1(System.String param); // 0x058b5450
	System.Void <LoadSoundConfigPC>b__164_3(System.String param); // 0x058b571c
	System.Void <LoadSensitivityConfig>b__269_37(System.String param); // 0x058b5800
	System.Void <LoadSensitivityConfig>b__269_38(System.String param); // 0x058b5874
	System.Void <LoadSensitivityConfig>b__269_39(System.String param); // 0x058b58e8
	System.Void <LoadSensitivityConfig>b__269_40(System.String param); // 0x058b595c
	System.Void <LoadSensitivityConfig>b__269_41(System.String param); // 0x058b59d0
	System.Void <LoadSensitivityConfig>b__269_42(System.String param); // 0x058b5a44
	System.Void <LoadSensitivityConfig>b__269_43(System.String param); // 0x058b5ab8
	System.Void <LoadSensitivityConfig>b__269_44(System.String param); // 0x058b5b2c
	System.Void <LoadSensitivityConfig>b__269_45(System.String param); // 0x058b5ba0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.MgrSetting.<>c__DisplayClass164_0 : System.Object
{
	System.Int32 i; // 0x10
	System.Void .ctor(); // 0x058b5c14
	System.Void <LoadSoundConfigPC>b__6(System.String param); // 0x058b5c7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.MgrSetting.<>c__DisplayClass165_0 : System.Object
{
	WizardGames.Soc.SocClient.Setting.SettingSwitchConfig micTypeSettingSwitchConfig; // 0x10
	WizardGames.Soc.SocClient.Setting.SettingSlideBarConfig micVolumeSettingSlideBarConfig; // 0x18
	System.Void .ctor(); // 0x058b5e0c
	System.Void <LoadMicChannelConfigPC>b__0(System.String settingKey, System.String value); // 0x058b5e74
	System.Void <LoadMicChannelConfigPC>b__1(System.String settingKey, System.String value); // 0x058b5fc4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.MgrSetting.<>c__DisplayClass262_0 : System.Object
{
	System.String dynamicValueKey; // 0x10
	WizardGames.Soc.SocClient.Setting.MgrSetting <>4__this; // 0x18
	System.Void .ctor(); // 0x058b6078
	System.Void <LoadAllChildSettingBaseConfig>b__0(System.String selectValue); // 0x058b60e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.MgrSetting.<>c__DisplayClass60_0 : System.Object
{
	WizardGames.Soc.SocClient.Setting.MgrSetting <>4__this; // 0x10
	System.Action<System.String> oriCall; // 0x18
	System.Void .ctor(); // 0x058b61b4
	System.Void <AddGameConfig>b__0(System.String val); // 0x058b621c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.MgrSetting.<>c__DisplayClass66_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.language.LanguageConfig> enableCfgs; // 0x10
	System.Void .ctor(); // 0x058b62bc
	System.Void <AddSwitchLanguageConfig>b__2(System.String option); // 0x058b6324
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.MgrSetting.<>c__DisplayClass75_0 : System.Object
{
	WizardGames.Soc.Common.Entity.TerritoryEntity terrEnt; // 0x10
	System.Void .ctor(); // 0x058b66f8
	System.Void <LoadBasicsConfig>b__42(); // 0x058b6760
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.MgrSetting.<>c__DisplayClass75_1 : System.Object
{
	WizardGames.Soc.Common.Entity.TerritoryEntity terrEnt; // 0x10
	System.Void .ctor(); // 0x058b67e4
	System.Void <LoadBasicsConfig>b__43(); // 0x058b684c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.MgrSetting.<>c__DisplayClass87_0 : System.Object
{
	WizardGames.Soc.Common.Data.Item.Pickup pickupData; // 0x10
	System.Void .ctor(); // 0x058b68d0
	System.Void <LoadPickupConfig>b__0(System.String param); // 0x058b6938
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Setting.ESettingCommonQualityLevel : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Setting.ESettingCommonQualityLevel Low = 0;
	static WizardGames.Soc.SocClient.Setting.ESettingCommonQualityLevel Medium = 1;
	static WizardGames.Soc.SocClient.Setting.ESettingCommonQualityLevel High = 2;
	static WizardGames.Soc.SocClient.Setting.ESettingCommonQualityLevel Ultra = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Setting.EMobileQualityLevel : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Setting.EMobileQualityLevel Smooth = 0;
	static WizardGames.Soc.SocClient.Setting.EMobileQualityLevel Balanced = 1;
	static WizardGames.Soc.SocClient.Setting.EMobileQualityLevel Exquisite = 2;
	static WizardGames.Soc.SocClient.Setting.EMobileQualityLevel HD = 3;
	static WizardGames.Soc.SocClient.Setting.EMobileQualityLevel UltraHD = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Setting.EAimPart : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Setting.EAimPart Preview = 0;
	static WizardGames.Soc.SocClient.Setting.EAimPart Size = 1;
	static WizardGames.Soc.SocClient.Setting.EAimPart Color = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.SettingAimConfig : WizardGames.Soc.SocClient.Setting.SettingConfig
{
	System.Int32 SLIDER_DEFAULT_DELAY_TIME; // 0xa0
	System.Int32 DefaultSize; // 0xa4
	System.String DefaultColor; // 0xa8
	System.Int32 MaxSize; // 0xb0
	System.String[] ScaleIconUrls; // 0xb8
	System.String[] ColorOptions; // 0xc0
	System.Collections.Generic.List<System.Int32> TitleKeys; // 0xc8
	System.Collections.Generic.List<System.String> BtnTipContents; // 0xd0
	System.String get_DefaultValue(); // 0x058b6a50
	System.Void .ctor(System.Action<System.String> onCLickAction, System.Int32[] titleKeys, System.Int32 max, System.Boolean needSave); // 0x058b6b84
	System.Int32 GetDelayTime(); // 0x058b6e60
	System.String GetAimDefaultValue(); // 0x058b6ab4
	System.ValueTuple<System.Int32,System.String> GetAimValue(); // 0x058b6ec4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.SettingConfig : System.Object
{
	static SocLogger logger; // 0x0
	System.String curValue; // 0x10
	System.Boolean needSave; // 0x18
	WizardGames.Soc.Common.Data.ESettingSaveMethod savingMethod; // 0x1c
	System.Boolean <IsScreenSetting>k__BackingField; // 0x20
	System.Boolean <IsMicSetting>k__BackingField; // 0x21
	System.Boolean <NeedSaveImmediately>k__BackingField; // 0x22
	System.Func<System.String,System.Boolean> selectLegalCheck; // 0x28
	System.Action<System.String> clickAction; // 0x30
	System.Action<System.String> applyAction; // 0x38
	System.Func<System.Int32,WizardGames.Soc.SocClient.Ui.MsgBoxInfo> clickAskBeforeAction; // 0x40
	System.Func<System.Int32,WizardGames.Soc.SocClient.Ui.MsgBoxInfo> clickAskAction; // 0x48
	System.Action<System.String,System.String> TargetSettingValueChangedAction; // 0x50
	System.Action ConfigValueChanged; // 0x58
	System.Boolean isClickBlocked; // 0x60
	System.Int32 BTN_DEFAULT_DELAY_TIME; // 0x64
	System.String <SettingKey>k__BackingField; // 0x68
	System.Collections.Generic.HashSet<System.String> relationSetting; // 0x70
	WizardGames.Soc.SocClient.Ui.ESettingCtrlType <GmCmdCtrlType>k__BackingField; // 0x78
	System.String ChineseTitle; // 0x80
	System.String EnglishTitle; // 0x88
	System.Boolean enable; // 0x90
	System.String <DefaultValue>k__BackingField; // 0x98
	System.Boolean get_IsScreenSetting(); // 0x058b709c
	System.Void set_IsMicSetting(System.Boolean value); // 0x058b7100
	System.Boolean get_NeedSaveImmediately(); // 0x058b717c
	System.Void set_NeedSaveImmediately(System.Boolean value); // 0x058b71e0
	System.Void add_ConfigValueChanged(System.Action value); // 0x058b725c
	System.Void remove_ConfigValueChanged(System.Action value); // 0x058b7334
	System.String get_SettingKey(); // 0x058b740c
	System.Void set_SettingKey(System.String value); // 0x058b7470
	WizardGames.Soc.SocClient.Ui.ESettingCtrlType get_GmCmdCtrlType(); // 0x058b74f0
	System.Void set_GmCmdCtrlType(WizardGames.Soc.SocClient.Ui.ESettingCtrlType value); // 0x058b7554
	System.String get_CurValue(); // 0x058b75cc
	System.Boolean get_NeedSave(); // 0x058b7630
	System.Void set_NeedSave(System.Boolean value); // 0x058b7694
	WizardGames.Soc.Common.Data.ESettingSaveMethod get_SavingMethod(); // 0x058b7710
	System.Void set_SavingMethod(WizardGames.Soc.Common.Data.ESettingSaveMethod value); // 0x058b7774
	System.Boolean get_SaveLocal(); // 0x058b77ec
	System.Boolean get_Enable(); // 0x058b7858
	System.Void set_Enable(System.Boolean value); // 0x058b5f28
	System.String get_DefaultValue(); // 0x058b7934
	System.Boolean get_IsCurValueInit(); // 0x058b7998
	System.Int32 GetDelayTime(); // 0x058b7a0c
	System.String GetSaveValue(); // 0x058b7a70
	System.Void SaveSettingValue(); // 0x058b7ad4
	System.Void SetCurValue(System.String value, System.Boolean recordChange); // 0x058b7de0
	System.Void SyncView(); // 0x058b78bc
	System.Void SetDefaultValue(System.String value); // 0x058b8188
	System.Void SetMaxValue(System.String maxValue); // 0x058b81fc
	System.Void RevertToDefaultValue(); // 0x058b8270
	System.Boolean IsChanged(); // 0x058b83e4
	System.Void ApplySavedValue(System.String value); // 0x058b85cc
	System.Void ExecuteDelayedClickAction(System.Boolean recordChange); // 0x058b8090
	System.Void ApplyScreenSettingValue(System.Boolean executeAction); // 0x058b8350
	System.Void ExecuteApplyAction(); // 0x058b8680
	System.Void NotifyRelationSettingValueChanged(System.String targetKey, System.String value); // 0x058b8ac8
	System.Void DirectSetCurValue(System.String value); // 0x058b8cb4
	System.Boolean CanWork(); // 0x058b8864
	System.Void AddRelationSetting(System.String key); // 0x058b8d34
	System.Boolean HasRelationSetting(); // 0x058b8e60
	System.Void .ctor(); // 0x058b6d80
	static System.Void .cctor(); // 0x058b8ee8
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Setting.SettingConfig.<ExecuteDelayedClickAction>d__69 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	System.Boolean recordChange; // 0x38
	WizardGames.Soc.SocClient.Setting.SettingConfig <>4__this; // 0x40
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x48
	System.Void MoveNext(); // 0x058b8fbc
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x058b9444
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.SettingController : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Setting.IComSettingBase comSettingUi; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Setting.SettingConfig> settingConfigs; // 0x18
	static WizardGames.Soc.SocClient.Setting.SettingController GetSettingController(WizardGames.Soc.SocClient.Setting.IComSettingBase comUi, System.Collections.Generic.List<WizardGames.Soc.SocClient.Setting.SettingConfig> configs); // 0x058b94c4
	System.Void Init(WizardGames.Soc.SocClient.Setting.IComSettingBase comUi, System.Collections.Generic.List<WizardGames.Soc.SocClient.Setting.SettingConfig> configs); // 0x058b9594
	System.Void Reset(); // 0x058b9a70
	System.Void Release(); // 0x058b9ce8
	System.Void OnGet(); // 0x058b9d88
	System.Void OnRelease(); // 0x058b9de8
	System.Void OnDestroy(); // 0x058b9e4c
	System.Void .ctor(); // 0x058b9eac
	static System.Void .cctor(); // 0x058b9f60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.SettingFillParamConfig : WizardGames.Soc.SocClient.Setting.SettingConfig
{
	System.Int32 titleKey; // 0xa0
	System.String titleTemp; // 0xa8
	System.String defaultValue; // 0xb0
	System.String promptText; // 0xb8
	System.Void .ctor(System.Action<System.String> onCLickAction, System.Int32 titleKey, System.String defaultValue, System.String tempTitle, System.String promptText); // 0x058ba034
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.SettingSlideBarConfig : WizardGames.Soc.SocClient.Setting.SettingConfig
{
	System.Int32 SLIDER_DEFAULT_DELAY_TIME; // 0xa0
	System.Int32 titleKey; // 0xa4
	System.Double defaultValue; // 0xa8
	System.Double min; // 0xb0
	System.Double max; // 0xb8
	WizardGames.Soc.SocClient.Setting.SettingSlideBarConfig.ControlStyle style; // 0xc0
	System.Boolean showBtnTick; // 0xc4
	System.Boolean needPercentageSign; // 0xc5
	System.Boolean isIntInput; // 0xc6
	FairyGUI.ProgressTitleType titleType; // 0xc8
	System.Single step; // 0xcc
	System.String get_DefaultValue(); // 0x058ba1f4
	System.Void .ctor(System.Action<System.String> onCLickAction, System.Int32 titleKey, WizardGames.Soc.SocClient.Setting.SettingSlideBarConfig.ControlStyle style, System.Boolean showBtnTick, System.Double min, System.Double max, System.Double defaultValue, System.Boolean needSave, System.Boolean needPercentageSign, System.Boolean isIntInput, FairyGUI.ProgressTitleType titleType, System.Single step); // 0x058ba2c4
	System.Int32 GetDelayTime(); // 0x058ba4c4
	WizardGames.Soc.SocClient.Setting.SettingSwitchConfig GetExtConfig(); // 0x058ba528
	System.Void RevertToDefaultValue(); // 0x058ba6b4
	System.Boolean IsChanged(); // 0x058ba73c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Setting.SettingSlideBarConfig.ControlStyle : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Setting.SettingSlideBarConfig.ControlStyle ShowBtn = 0;
	static WizardGames.Soc.SocClient.Setting.SettingSlideBarConfig.ControlStyle ShowText = 1;
	static WizardGames.Soc.SocClient.Setting.SettingSlideBarConfig.ControlStyle Hide = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Setting.EItemContentType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Setting.EItemContentType Text = 0;
	static WizardGames.Soc.SocClient.Setting.EItemContentType Icon = 1;
	static WizardGames.Soc.SocClient.Setting.EItemContentType All = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.SettingSwitchConfig : WizardGames.Soc.SocClient.Setting.SettingConfig
{
	System.Int32 TitleLanId; // 0xa0
	System.Int32[] <OptionsTitleKeys>k__BackingField; // 0xa8
	System.String[] optionsTempTitles; // 0xb0
	System.String[] <OptionsIcons>k__BackingField; // 0xb8
	System.Int32[] disableIndexes; // 0xc0
	System.String[] saveValues; // 0xc8
	System.String defaultValue; // 0xd0
	WizardGames.Soc.SocClient.Setting.EItemContentType <ItemContentType>k__BackingField; // 0xd8
	System.Int32[] get_OptionsTitleKeys(); // 0x058ba7d4
	System.Void set_OptionsTitleKeys(System.Int32[] value); // 0x058ba838
	System.String[] get_OptionsIcons(); // 0x058ba8b8
	System.Void set_OptionsIcons(System.String[] value); // 0x058ba91c
	System.Int32[] get_DisableIndexes(); // 0x058ba99c
	System.Void set_DisableIndexes(System.Int32[] value); // 0x058baa00
	System.String get_DefaultValue(); // 0x058baa88
	System.Boolean get_hasSpecialSaveValue(); // 0x058baaec
	WizardGames.Soc.SocClient.Setting.EItemContentType get_ItemContentType(); // 0x058bab68
	System.Void set_ItemContentType(WizardGames.Soc.SocClient.Setting.EItemContentType value); // 0x058babcc
	System.Void .ctor(System.Action<System.String> onClickAction, System.Int32[] optionsKeys, System.Int32 titleLanId, System.String defaultValue, System.Boolean needSave, System.String[] tempOptionTitles, System.Int32[] disableIndexes, WizardGames.Soc.SocClient.Ui.ESettingCtrlType ctrlType); // 0x058bac44
	System.Void SetDefaultValue(System.String value); // 0x058baf58
	System.Void SetOptionsIcons(System.String[] icons, WizardGames.Soc.SocClient.Setting.EItemContentType contentType); // 0x058bafd8
	System.Void SetMaxValue(System.String maxValue); // 0x058bb100
	System.String ConvertValue(System.String value); // 0x058bb4d0
	System.Void CheckCtrlType(); // 0x058bb7b4
	System.Void SetOptionsTitleKeys(System.Int32[] optionKeys); // 0x058bae80
	System.Void RefreshSaveValues(); // 0x058bbad0
	System.Void SetSaveValues(System.String[] saveValues); // 0x058bbddc
	System.Int32 get_TitleLen(); // 0x058bb674
	System.String GetTitle(System.Int32 index); // 0x058bbeb8
	System.Void ApplySavedValue(System.String savedValue); // 0x058bc0a8
	System.Int32 GetIndexBySaveValue(System.String valueKey); // 0x058bc2cc
	System.String GetSaveValue(); // 0x058bc378
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.SettingTextBtnConfig : WizardGames.Soc.SocClient.Setting.SettingConfig
{
	System.Int32 titleKey; // 0xa0
	System.String titleTemp; // 0xa8
	System.Void .ctor(System.Action<System.String> onCLickAction, System.Int32 titleKey, System.String tempTitle); // 0x058bc4bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Setting.SettingTextConfig : WizardGames.Soc.SocClient.Setting.SettingConfig
{
	System.String Url; // 0xa0
	System.Int32 title; // 0xa8
	System.Void .ctor(System.String url, System.Int32 title, System.Boolean needSave); // 0x058bc62c
}

// Client.Runtime
class WizardGames.Soc.SocClient.ServerList.ServerInfo : System.Object
{
	WizardGames.Soc.Common.SimpleCustom.RegisterBattleServerModel basicServerInfo; // 0x10
	System.String id; // 0x18
	System.String ServerIp; // 0x20
	System.Int32 TcpPort; // 0x28
	System.Int32 UdpPort; // 0x2c
	WizardGames.Soc.SocClient.ServerList.ServerType svrType; // 0x30
	WizardGames.Soc.Common.Unity.Scene.SceneConfig config; // 0x38
	System.Boolean isOffline; // 0x40
	System.Int32 ping; // 0x44
	System.String openServerTime; // 0x48
	System.Int32 NetworkVersion; // 0x50
	System.Int32 CompatibilityLoginLevel; // 0x54
	System.Int64 RpcVersion; // 0x58
	System.Int64 RpcCustomTypeVersion; // 0x60
	System.Int64 EntityVersionVerifyCode; // 0x68
	System.Int32 DisableClientResourceVersionCheck; // 0x70
	System.Int64 ResourceVersion; // 0x78
	System.Void .ctor(); // 0x058bc70c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.ServerList.EServerVersionStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.ServerList.EServerVersionStatus CanUse = 0;
	static WizardGames.Soc.SocClient.ServerList.EServerVersionStatus PartCanUse = 1;
	static WizardGames.Soc.SocClient.ServerList.EServerVersionStatus NotAllowedLogin = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.ServerList.ServerType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.ServerList.ServerType None = -1;
	static WizardGames.Soc.SocClient.ServerList.ServerType Official = 0;
	static WizardGames.Soc.SocClient.ServerList.ServerType Public = 1;
	static WizardGames.Soc.SocClient.ServerList.ServerType OutNet = 2;
	static WizardGames.Soc.SocClient.ServerList.ServerType Plan = 3;
	static WizardGames.Soc.SocClient.ServerList.ServerType Program = 4;
	static WizardGames.Soc.SocClient.ServerList.ServerType Local = 5;
	static WizardGames.Soc.SocClient.ServerList.ServerType MapVerify = 6;
	static WizardGames.Soc.SocClient.ServerList.ServerType TeamBattle = 7;
	static WizardGames.Soc.SocClient.ServerList.ServerType Official_En = 8;
	static WizardGames.Soc.SocClient.ServerList.ServerType Official_Ch = 9;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.ServerList.EServerChannelType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.ServerList.EServerChannelType Default = 0;
	static WizardGames.Soc.SocClient.ServerList.EServerChannelType Developer = 1;
	static WizardGames.Soc.SocClient.ServerList.EServerChannelType CE_EN = 2;
	static WizardGames.Soc.SocClient.ServerList.EServerChannelType CE_ZH = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.ServerList.SvrGroup : System.Object
{
	WizardGames.Soc.SocClient.ServerList.ServerType <type>k__BackingField; // 0x10
	System.Int32 nameKey; // 0x14
	System.String icon; // 0x18
	FairyGUI.GButton btnTab; // 0x20
	FairyGUI.GTextField textServerNum; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.ServerList.ServerInfo> serverInfos; // 0x30
	SimpleJSON.JSONNode serverMsg; // 0x38
	WizardGames.Soc.SocClient.ServerList.ServerType get_type(); // 0x058bc7d8
	System.Void set_type(WizardGames.Soc.SocClient.ServerList.ServerType value); // 0x058bc83c
	System.String get_Name(); // 0x058bc8b4
	System.Void set_Selected(System.Boolean value); // 0x058bc944
	System.Void .ctor(); // 0x058bc9d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.ServerList.MgrServerList : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.ServerList.SvrGroup[] svrConfig; // 0x18
	static System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.ServerList.EServerChannelType,System.Collections.Generic.List<System.Int32>> channelConfig; // 0x8
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Utility.SocPing> server2PingNum; // 0x20
	WizardGames.Soc.SocClient.ServerList.EServerChannelType serverChannelType; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.ServerList.SvrGroup> svrGroups; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.ServerList.ServerInfo> serverInfoList; // 0x38
	System.String localIP; // 0x40
	System.Int32 isReceiveServerListMsg; // 0x48
	System.Boolean isCheckVersion; // 0x4c
	System.Void Init(); // 0x058bcac8
	System.Void CleanUp(); // 0x058bce48
	System.Void DestoryPingDic(); // 0x058bceac
	System.Void ServerInfoInit(); // 0x058bcb38
	System.Void ReqRefreshSvrList(WizardGames.Soc.SocClient.ServerList.SvrGroup svr); // 0x058bd060
	System.Void ReqSvrListFromRemote(WizardGames.Soc.SocClient.ServerList.SvrGroup svr); // 0x058bddc4
	System.Boolean IsPrivateServerTags(); // 0x058bdaac
	System.Void ReqGetWhiteListBattleServerRemote(WizardGames.Soc.SocClient.ServerList.SvrGroup svr); // 0x058bdbb0
	System.Void ReqRefreshLocalSvrList(); // 0x058bd16c
	System.Boolean CheckVersionInfo(System.Int32 networkVersion, System.Int32 compatibilityLoginLevel, System.Int64 rpcVersion, System.Int64 rpcCustomTypeVersion, System.Int64 entityVersionVerifyCode, System.Int32 disableClientResourceVersionCheck, System.Int64 resourceVersion, WizardGames.Soc.SocClient.ServerList.EServerVersionStatus& status); // 0x054c51c8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.ServerList.ServerInfo> HandleToServerList(WizardGames.Soc.SocClient.ServerList.SvrGroup svr); // 0x058be2cc
	System.Collections.Generic.List<WizardGames.Soc.SocClient.ServerList.ServerInfo> ParseToServerList(System.Collections.Generic.List<WizardGames.Soc.SocClient.ServerList.ServerInfo>& serverInfos, SimpleJSON.JSONNode json, System.Boolean checkVersion, WizardGames.Soc.SocClient.ServerList.ServerType serverType); // 0x058be3f4
	static System.String FromLongTimeStamp(System.Int64 timeStamp); // 0x058bed54
	System.Void OnResSvrListUpdate(); // 0x058bf168
	System.Void CopyData(System.Collections.Generic.List<WizardGames.Soc.SocClient.ServerList.ServerInfo> src, System.Collections.Generic.List<WizardGames.Soc.SocClient.ServerList.ServerInfo> dst); // 0x058bf6cc
	System.Void RefreshSvrList(WizardGames.Soc.SocClient.ServerList.SvrGroup svr); // 0x058bf8e8
	System.Void Update(); // 0x058bfa50
	System.Void GetServersPingNum(System.Collections.Generic.List<WizardGames.Soc.SocClient.ServerList.ServerInfo> serverInfos); // 0x058bfac4
	System.Void GetServersPingNum(WizardGames.Soc.SocClient.ServerList.ServerInfo serverInfo); // 0x058bf048
	System.Boolean IsObjMoreSignNeedShow(FairyGUI.GList listLabel, System.Single itemWidth); // 0x058bfc3c
	System.String GetPlayType(System.Int32 playType); // 0x058bfd5c
	System.String GetPlayStage(System.Int32 playStage); // 0x058bfec8
	System.String GetCleanType(System.Int32 clearType); // 0x058c0034
	System.String GetServertags(System.Int32 servertag); // 0x058c01a0
	System.Void .ctor(); // 0x058c030c
	static System.Void .cctor(); // 0x058c0ba8
}

// Client.Runtime
class WizardGames.Soc.SocClient.ServerList.MgrServerList.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.ServerList.SvrGroup svr; // 0x10
	WizardGames.Soc.SocClient.ServerList.MgrServerList <>4__this; // 0x18
	System.Void .ctor(); // 0x058be088
	System.Void <ReqSvrListFromRemote>b__0(SimpleJSON.JSONNode result); // 0x058c1584
}

// Client.Runtime
class WizardGames.Soc.SocClient.ServerList.MgrServerList.<>c__DisplayClass17_0 : System.Object
{
	WizardGames.Soc.SocClient.ServerList.SvrGroup svr; // 0x10
	WizardGames.Soc.SocClient.ServerList.MgrServerList <>4__this; // 0x18
	System.Void .ctor(); // 0x058be0f0
	System.Void <ReqGetWhiteListBattleServerRemote>b__0(SimpleJSON.JSONNode result); // 0x058c17f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Search.SearchResult : System.Object
{
	System.Int64 <TaskId>k__BackingField; // 0x10
	System.Int64 <SearchId>k__BackingField; // 0x18
	System.String <SearchMarkerName>k__BackingField; // 0x20
	System.Boolean <IsSearchEntity>k__BackingField; // 0x28
	System.Boolean <Valid>k__BackingField; // 0x29
	System.Int64 <EntityId>k__BackingField; // 0x30
	UnityEngine.Vector3 <Position>k__BackingField; // 0x38
	System.Single <Scope>k__BackingField; // 0x44
	System.Single SearchMarkerHudOffsetHeight; // 0x48
	System.Int64 get_TaskId(); // 0x058c1a5c
	System.Void set_TaskId(System.Int64 value); // 0x058c1ac0
	System.Int64 get_SearchId(); // 0x058c1b38
	System.Void set_SearchId(System.Int64 value); // 0x058c1b9c
	System.String get_SearchMarkerName(); // 0x058c1c14
	System.Void set_SearchMarkerName(System.String value); // 0x058c1c78
	System.Boolean get_IsSearchEntity(); // 0x058c1cf8
	System.Void set_IsSearchEntity(System.Boolean value); // 0x058c1d5c
	System.Boolean get_Valid(); // 0x058c1dd8
	System.Void set_Valid(System.Boolean value); // 0x058c1e3c
	System.Int64 get_EntityId(); // 0x058c1eb8
	System.Void set_EntityId(System.Int64 value); // 0x058c1f1c
	UnityEngine.Vector3 get_Position(); // 0x058c1f94
	System.Void set_Position(UnityEngine.Vector3 value); // 0x058c1ff8
	System.Single get_Scope(); // 0x058c2090
	System.Void set_Scope(System.Single value); // 0x058c20f4
	System.Void Initialize(System.Int64 taskId, System.Int64 searchId); // 0x058c216c
	System.Void RefreshMarkerIsSearchEntity(); // 0x058c22f8
	System.Void RefreshMarkerHudOffsetHeight(); // 0x058c250c
	System.Void RefreshMarkerHudName(); // 0x058c2868
	System.Int64 GetEntityTemplateId(); // 0x058c26f8
	System.Void SetResult(UnityEngine.Vector3 pos, System.Boolean valid, System.Int64 entityId, System.Single scope); // 0x058c2ac8
	System.Void RefreshMarkerHudInfo(); // 0x058c228c
	System.Void SetIsSearchEntity(System.Boolean isSearchEntity); // 0x058c2d28
	System.Void FormatInvalid(); // 0x058c2dd8
	System.Void Clear(); // 0x058c2fd0
	System.Void .ctor(); // 0x058c32ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Search.DeaSheepTerritorySearchTask : WizardGames.Soc.SocClient.Search.SearchTask
{
	
	System.Void RunInner(System.Boolean forceRun); // 0x058c3314
	System.Void .ctor(); // 0x058c349c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Search.EntitySearchTask : WizardGames.Soc.SocClient.Search.SearchTask
{
	System.Type entityType; // 0x58
	System.Single preCheckSqrMagnitude; // 0x60
	System.Void Initialize(System.Int64 searchId, System.Action<WizardGames.Soc.SocClient.Search.SearchResult> onResultGetOrUpdate, System.Action<System.Int64,System.Int64> onTaskRelease); // 0x058c35f8
	System.Void RunInner(System.Boolean forceRun); // 0x058c3d40
	System.Void Release(); // 0x058c54fc
	System.Boolean NeedSearch(); // 0x058c4bac
	System.Boolean CheckSpecialConditions(WizardGames.Soc.Common.Entity.IEntity entity); // 0x058c5274
	System.Boolean IsInSafeArea(UnityEngine.Vector3 pos); // 0x058c51a4
	System.Void .ctor(); // 0x058c5940
}

// Client.Runtime
class WizardGames.Soc.SocClient.Search.ItemInMonumentSearchTask : WizardGames.Soc.SocClient.Search.SearchTask
{
	
	System.Void RunInner(System.Boolean forceRun); // 0x058c59a4
	System.Void .ctor(); // 0x058c62b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Search.JunkpileSearchTask : WizardGames.Soc.SocClient.Search.SearchTask
{
	
	System.Void RunInner(System.Boolean forceRun); // 0x058c631c
	System.Void .ctor(); // 0x058c64f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Search.MissionGuideDataSearchTask : WizardGames.Soc.SocClient.Search.SearchTask
{
	System.Boolean hasAddedListener; // 0x58
	WizardGames.Soc.Common.CustomType.TaskContainer get_taskContainer(); // 0x058c6554
	System.Void Initialize(System.Int64 searchId, System.Action<WizardGames.Soc.SocClient.Search.SearchResult> onResultGetOrUpdate, System.Action<System.Int64,System.Int64> onTaskRelease); // 0x058c6798
	System.Void GuideDataChange(); // 0x058c68dc
	System.Void RunInner(System.Boolean forceRun); // 0x058c6a38
	System.Void Release(); // 0x058c7754
	System.Void .ctor(); // 0x058c7858
}

// Client.Runtime
class WizardGames.Soc.SocClient.Search.MissionPVEPositionSearchTask : WizardGames.Soc.SocClient.Search.SearchTask
{
	
	System.Void RunInner(System.Boolean forceRun); // 0x058c78bc
	System.Void .ctor(); // 0x058c7f08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Search.MonumentAreaSearchTask : WizardGames.Soc.SocClient.Search.SearchTask
{
	
	System.Void RunInner(System.Boolean forceRun); // 0x058c7f6c
	System.Void .ctor(); // 0x058c8b4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Search.PartWithPasswordPermSearchTask : WizardGames.Soc.SocClient.Search.SearchTask
{
	
	System.Void RunInner(System.Boolean forceRun); // 0x058c8bb0
	System.Void .ctor(); // 0x058c8d54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Search.SearchGroup : System.Object
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Search.SearchResult> results; // 0x10
	UnityEngine.Transform playerTransform; // 0x18
	System.Int64 timerId; // 0x20
	System.Int64[] TaskIds; // 0x28
	WizardGames.Soc.SocClient.Search.SearchResult CurResult; // 0x30
	System.Collections.Generic.HashSet<System.Int64> searchIdsSet; // 0x38
	System.Int64 missionId; // 0x40
	System.Action<WizardGames.Soc.SocClient.Search.SearchResult> OnResultGetOrUpdate; // 0x48
	System.Action<System.Int64,System.Int64> OnOldResultRelease; // 0x50
	System.Void .ctor(System.Int64[] searchIds, System.Int64 missionId); // 0x05527094
	System.Void CheckGroup(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x058c9094
	System.Void OnResultChange(WizardGames.Soc.SocClient.Search.SearchResult result); // 0x058c98dc
	System.Void OnResultRelease(System.Int64 taskId, System.Int64 searchId); // 0x058c9a78
	System.Void FindNearestResult(); // 0x058c9160
	System.Void Release(); // 0x058c9de4
	System.Void ClearTimer(); // 0x058c9e84
	static System.Void .cctor(); // 0x058c9f90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Search.SearchTask : System.Object
{
	SocLogger log; // 0x10
	System.Int64 <TaskId>k__BackingField; // 0x18
	System.Int64 <SearchId>k__BackingField; // 0x20
	WizardGames.Soc.Common.Data.Search.SearchConfig searchConfig; // 0x28
	System.Action<WizardGames.Soc.SocClient.Search.SearchResult> onResultGetOrUpdate; // 0x30
	System.Action<System.Int64,System.Int64> onTaskRelease; // 0x38
	WizardGames.Soc.SocClient.Search.SearchResult <SearchResult>k__BackingField; // 0x40
	System.Int64 autoCheckTimer; // 0x48
	UnityEngine.Transform myPlayerTransform; // 0x50
	System.Int64 get_TaskId(); // 0x058ca064
	System.Void set_TaskId(System.Int64 value); // 0x058ca0c8
	System.Int64 get_SearchId(); // 0x058ca140
	System.Void set_SearchId(System.Int64 value); // 0x058ca1a4
	WizardGames.Soc.SocClient.Search.SearchResult get_SearchResult(); // 0x058ca21c
	System.Void set_SearchResult(WizardGames.Soc.SocClient.Search.SearchResult value); // 0x058ca280
	System.Void Initialize(System.Int64 searchId, System.Action<WizardGames.Soc.SocClient.Search.SearchResult> onResultGetOrUpdate, System.Action<System.Int64,System.Int64> onTaskRelease); // 0x05512cd0
	System.Void RunTask(System.Boolean forceRun); // 0x058ca300
	System.Void RunInner(System.Boolean forceRun); // 0x05523a7c
	System.Void Release(); // 0x058c557c
	System.Void OnResultGetOrUpdate(); // 0x058c534c
	System.Void MakeResultInvalidAndUpdate(); // 0x058c4af4
	System.Single GetTargetDistanceInSqrMagnitude(UnityEngine.Vector3 targetPos); // 0x058c50e0
	System.Void .ctor(); // 0x058c3500
	System.Void <Initialize>b__18_0(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x058ca468
}

// Client.Runtime
class WizardGames.Soc.SocClient.Search.SpecialHorseEntityTask : WizardGames.Soc.SocClient.Search.SearchTask
{
	System.Single preCheckSqrMagnitude; // 0x58
	static System.Collections.Generic.HashSet<System.Int64> hasSearedMissionIds; // 0x0
	System.Boolean hasAddedListener; // 0x5c
	System.Void Initialize(System.Int64 searchId, System.Action<WizardGames.Soc.SocClient.Search.SearchResult> onResultGetOrUpdate, System.Action<System.Int64,System.Int64> onTaskRelease); // 0x058ca500
	System.Void RunInner(System.Boolean forceRun); // 0x058ca6cc
	System.Void Release(); // 0x058cba00
	System.Void OnMountableTypeChange(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int32 oldValue, System.Int32 newValue); // 0x058cbb28
	System.Boolean NeedSearch(); // 0x058cb574
	System.Boolean CheckSpecialConditions(WizardGames.Soc.Common.Entity.HorseEntity horseEntity); // 0x058cb940
	System.Boolean IsInSafeArea(UnityEngine.Vector3 pos); // 0x058cb870
	System.Void .ctor(); // 0x058cbcd0
	static System.Void .cctor(); // 0x058cbd34
}

// Client.Runtime
class WizardGames.Soc.SocClient.SceneLoader.ClientSceneLoader : System.Object
{
	
	static System.Threading.Tasks.Task LoadSceneAsync(WizardGames.Soc.Common.Unity.Scene.SceneName scene, System.Action onSuccess); // 0x058cbdcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.SceneLoader.ClientSceneLoader.<>c : System.Object
{
	static WizardGames.Soc.SocClient.SceneLoader.ClientSceneLoader.<>c <>9; // 0x0
	static System.Action <>9__0_0; // 0x8
	static System.Void .cctor(); // 0x058cbef4
	System.Void .ctor(); // 0x058cbf58
	System.Void <LoadSceneAsync>b__0_0(); // 0x058cbfc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.SceneLoader.ClientSceneLoader.<>c__DisplayClass0_0 : System.Object
{
	WizardGames.Soc.Common.Unity.Scene.SceneName scene; // 0x10
	System.Void .ctor(); // 0x058cc2c0
	System.Void <LoadSceneAsync>b__1(); // 0x058cc328
}

