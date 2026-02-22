	System.Object System.Collections.IEnumerator.get_Current(); // 0x059bb104
}

// Client.Runtime
enum WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider.ESteps : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider.ESteps None = 0;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider.ESteps Checking = 1;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider.ESteps Done = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider.EOperationStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider.EOperationStatus None = 0;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider.EOperationStatus Processing = 1;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider.EOperationStatus Succeed = 2;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider.EOperationStatus Failed = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconWebRequest : System.Object, WizardGames.Soc.SocClient.PlatformPlayerInfo.IWebRequester
{
	UnityEngine.Networking.UnityWebRequest _webRequest; // 0x10
	UnityEngine.Networking.DownloadHandlerTexture _downloadhandler; // 0x18
	UnityEngine.Texture2D _cacheTexture; // 0x20
	WizardGames.Soc.SocClient.PlatformPlayerInfo.ERequestStatus <Status>k__BackingField; // 0x28
	System.Single <DownloadProgress>k__BackingField; // 0x2c
	System.UInt64 <DownloadedBytes>k__BackingField; // 0x30
	System.String <RequestNetError>k__BackingField; // 0x38
	System.Int64 <RequestHttpCode>k__BackingField; // 0x40
	System.Void set_Status(WizardGames.Soc.SocClient.PlatformPlayerInfo.ERequestStatus value); // 0x059bb168
	WizardGames.Soc.SocClient.PlatformPlayerInfo.ERequestStatus get_Status(); // 0x059bb1e0
	System.Void set_DownloadProgress(System.Single value); // 0x059bb244
	System.Single get_DownloadProgress(); // 0x059bb2bc
	System.Void set_DownloadedBytes(System.UInt64 value); // 0x059bb320
	System.UInt64 get_DownloadedBytes(); // 0x059bb398
	System.Void set_RequestNetError(System.String value); // 0x059bb3fc
	System.String get_RequestNetError(); // 0x059bb47c
	System.Void set_RequestHttpCode(System.Int64 value); // 0x059bb4e0
	System.Int64 get_RequestHttpCode(); // 0x059bb558
	System.Void .ctor(); // 0x059b77dc
	System.Void Create(System.String requestURL); // 0x059bb5bc
	System.Void Update(); // 0x059bb7e0
	System.Void Abort(); // 0x059bc450
	System.Boolean IsDone(); // 0x059bbc04
	UnityEngine.Texture2D GetRequestObject(); // 0x059bc5f0
	System.Void DisposeWebRequest(); // 0x059bc3c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.PlatformPlayerInfo.TextureMipmapConverter : System.Object
{
	
	static UnityEngine.Texture2D ConvertToNoMipmap(UnityEngine.Texture2D sourceTexture, System.Boolean markSourceForDestroy); // 0x059bbd00
}

// Client.Runtime
enum WizardGames.Soc.SocClient.PlatformPlayerInfo.ERequestStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.ERequestStatus None = 0;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.ERequestStatus InProgress = 1;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.ERequestStatus Error = 2;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.ERequestStatus Success = 3;
	
}

// Client.Runtime
interface WizardGames.Soc.SocClient.PlatformPlayerInfo.IWebRequester : 
{
	
	WizardGames.Soc.SocClient.PlatformPlayerInfo.ERequestStatus get_Status(); // 0x0548ba98
	System.Single get_DownloadProgress(); // 0x054a5abc
	System.UInt64 get_DownloadedBytes(); // 0x054e264c
	System.String get_RequestNetError(); // 0x054e7844
	System.Int64 get_RequestHttpCode(); // 0x054a4380
	System.Void Create(System.String url); // 0x05523a54
	System.Void Update(); // 0x055049cc
	System.Void Abort(); // 0x055049cc
	System.Boolean IsDone(); // 0x054c4760
	UnityEngine.Texture2D GetRequestObject(); // 0x054e7844
}

// Client.Runtime
class WizardGames.Soc.SocClient.PlatformPlayerInfo.MgrPlatformPlayerInfo : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider> _providerDic; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider> _providerList; // 0x20
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader> _loaderDic; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader> _loaderList; // 0x30
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader> _downloaderDic; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader> _downloaderList; // 0x40
	System.Collections.Generic.List<System.String> _downloaderRemoveList; // 0x48
	System.Collections.Generic.Dictionary<System.String,System.String> _nickNameDic; // 0x50
	System.Void OnFpsUnlimitedUpdate(System.Int32 timeSinceLastUpdate); // 0x059bc654
	System.Void Destroy(); // 0x059bcd2c
	System.Void LoadHeadIcon(System.String roleId, System.String url, System.Action<WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconHandle> onFinished); // 0x059bd32c
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconHandle LoadHeadIconInternal(System.String roleId, System.String url); // 0x059bd490
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider TryGetProvider(System.String providerGUID); // 0x059bd604
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader CreateHeadIconLoader(System.String roleId, System.String url); // 0x059ba210
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader TryGetHeadIconLoader(System.String roleId); // 0x059bd6b8
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader CreateHeadIconDownloader(System.String roleId, System.String url); // 0x059b95ec
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader TryGetHeadIconDownloader(System.String roleId); // 0x059bd76c
	System.Void .ctor(); // 0x059bd820
	static System.Void .cctor(); // 0x059bdb18
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Announcement.IAnnouncementProvider : 
{
	
	System.Boolean get_IsInRequest(); // 0x054c4760
	System.Void Init(); // 0x055049cc
	System.Void ReqAnnouncement(System.String group, System.Action onRet, System.Boolean useExtraJson); // 0x0552d23c
	System.Void GetAllAnnouncements(System.Collections.Generic.List<System.Object>& res); // 0x05523a54
	System.String GetAnnouncementTitle(System.Object info); // 0x054f9d14
	System.String GetExternalAnnouncement(System.Object info); // 0x054f9d14
	System.Boolean IsAnnouncementNew(System.Object info); // 0x054dec74
	System.Boolean HasNewAnnouncements(); // 0x054c4760
	System.Boolean HasPopAfterLoginAnnouncements(); // 0x054c4760
	System.Boolean HasPopEnterBattleAnnouncements(); // 0x054c4760
	System.Void RecordNewAnnouncements(System.Object info); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Announcement.MgrAnnouncement : WizardGames.Soc.Common.Manager.MgrBase
{
	static System.String NoPopKeyAfterLogin; // 0x0
	static System.String NoPopKeyEnterBattle; // 0x8
	WizardGames.Soc.SocClient.Announcement.IAnnouncementProvider provider; // 0x18
	WizardGames.Soc.SDK.Adatper.AnnouncementFilter curAnnouncementFilter; // 0x20
	System.Collections.Generic.List<System.Object> listForRet; // 0x28
	System.Boolean isLogined; // 0x30
	System.Int32 popTodayCount; // 0x34
	System.Boolean isEnterBattle; // 0x38
	System.Void Init(); // 0x059dcfdc
	System.Threading.Tasks.Task OnEnterWorld(); // 0x059dd30c
	System.Void ReqAnnouncement(System.String group, System.Action onRet, System.Boolean useExtraJson); // 0x059dd37c
	System.Collections.Generic.List<System.Object> GetAllAnnouncements(); // 0x059dd50c
	System.String GetAnnouncementTitle(System.Object info); // 0x059dd5f4
	System.String GetExternalAnnouncement(System.Object info); // 0x059dd6e0
	System.Boolean IsAnnouncementNew(System.Object info); // 0x059dd7cc
	System.Boolean HasNewAnnouncements(); // 0x059dd8b8
	System.Boolean HasPopAfterLoginAnnouncements(); // 0x059dd990
	System.Boolean HasPopEnterBattleAnnouncements(); // 0x059dda68
	System.Void RecordNewAnnouncements(System.Object info); // 0x059ddb40
	System.Void OnAccountLogined(); // 0x059ddc28
	System.Void RequestBattleServerAnnouncement(); // 0x059ddd04
	System.Void RequestAfterLoginAnnouncement(System.Boolean autoOpenWindow); // 0x059dddcc
	System.Void RecordNewAnnouncementInClient(System.String noPopKey); // 0x059ddf44
	System.Boolean IsRecordNewAnnouncementInClient(System.String noPopKey); // 0x059de24c
	System.Boolean IsPopTodayMax(); // 0x059de550
	System.Void ClearPopCount(); // 0x059de648
	System.Void RecordPopCount(); // 0x059de6f4
	System.Void .ctor(); // 0x059de7a8
	static System.Void .cctor(); // 0x059de85c
	System.Void <RequestBattleServerAnnouncement>b__21_0(); // 0x059de8f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Announcement.MgrAnnouncement.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Announcement.MgrAnnouncement.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__21_1; // 0x8
	static System.Void .cctor(); // 0x059deabc
	System.Void .ctor(); // 0x059deb20
	System.Void <RequestBattleServerAnnouncement>b__21_1(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x059deb88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Announcement.MgrAnnouncement.<>c__DisplayClass22_0 : System.Object
{
	System.Boolean autoOpenWindow; // 0x10
	System.Void .ctor(); // 0x059ddedc
	System.Void <RequestAfterLoginAnnouncement>b__0(); // 0x059dec5c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Announcement.MgrAnnouncement.<OnAccountLogined>d__20 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Announcement.MgrAnnouncement <>4__this; // 0x38
	System.Void MoveNext(); // 0x059ded64
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x059dee78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Announcement.MSDKAnnouncementProvider : System.Object, WizardGames.Soc.SocClient.Announcement.IAnnouncementProvider
{
	System.Boolean isInRequest; // 0x10
	System.Action onNoticeRet; // 0x18
	GCloud.MSDK.MSDKNoticeRet lastRet; // 0x20
	System.Collections.Generic.Dictionary<System.Int32,System.Object> id2Infos; // 0x28
	System.Collections.Generic.List<System.Object> sortedAvaliableInfos; // 0x30
	System.Collections.Generic.HashSet<System.Int32> recNoticeIds; // 0x38
	System.Collections.Generic.Dictionary<System.String,System.String> extraJsonMap; // 0x40
	System.Boolean get_IsInRequest(); // 0x059deef8
	System.Void Init(); // 0x059def5c
	System.Void ReadLocalNoticeRec(); // 0x059df010
	System.Void WriteLocalNoticeRec(); // 0x059df18c
	System.Void OnNoticeRet(GCloud.MSDK.MSDKNoticeRet ret); // 0x059df47c
	System.Void SortNotices(); // 0x059df530
	System.Void ReqAnnouncement(System.String group, System.Action onRet, System.Boolean useExtraJson); // 0x059dfb70
	System.Void GetAllAnnouncements(System.Collections.Generic.List<System.Object>& res); // 0x059dff98
	System.String GetAnnouncementTitle(System.Object info); // 0x059e02bc
	System.String GetExternalAnnouncement(System.Object info); // 0x059e035c
	System.Boolean IsAnnouncementNew(System.Object info); // 0x059e03fc
	System.Boolean HasNewAnnouncements(); // 0x059e04e8
	System.Boolean HasPopAfterLoginAnnouncements(); // 0x059e0728
	System.Boolean HasPopEnterBattleAnnouncements(); // 0x059e09fc
	System.Void RecordNewAnnouncements(System.Object info); // 0x059e0d44
	System.Void .ctor(); // 0x059dd150
}

// Client.Runtime
class WizardGames.Soc.SocClient.Announcement.MSDKAnnouncementProvider.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Announcement.MSDKAnnouncementProvider.<>c <>9; // 0x0
	static System.Comparison<System.Object> <>9__14_0; // 0x8
	static System.Void .cctor(); // 0x059e1190
	System.Void .ctor(); // 0x059e11f4
	System.Int32 <SortNotices>b__14_0(System.Object a, System.Object b); // 0x059e125c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Mail.MailUtil : System.Object
{
	static SocLogger Log; // 0x0
	static System.Collections.Generic.Dictionary<System.String,System.String> GenerateGetParams(WizardGames.Soc.SocClient.Mail.Core.ERequestOp op, System.String id, WizardGames.Soc.SocClient.Mail.Core.EMailType type, WizardGames.Soc.SocClient.Mail.Core.EReadStatus status); // 0x059e1378
	static SimpleJSON.JSONObject GeneratePostParamBody(WizardGames.Soc.SocClient.Mail.Core.ERequestOp op, System.String[] ids); // 0x059e15e8
	static System.Void SortMailInfo(System.Collections.Generic.List<WizardGames.Soc.SocClient.Mail.Core.MailInfo> mails); // 0x059e17ac
	static System.String GetSenderName(WizardGames.Soc.SocClient.Mail.Core.MailInfo mail); // 0x059e18f0
	static System.String GetTitle(SimpleJSON.JSONNode serverNode, System.Int32 templateId); // 0x059e1b88
	static System.String GetSendTimeString(System.DateTime time); // 0x059e1d14
	static System.String GetValidDaysString(System.Int32 days); // 0x059e1e70
	static System.DateTime ConvertTimestampToDate(System.Int64 timeStamp); // 0x059e2048
	static System.Int32 GetValidDays(System.Int64 targetTimeStamp); // 0x059e2134
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.Mail.Core.Attachment> ParseAttachments(SimpleJSON.JSONArray serverData, System.Int32 templateId); // 0x059e224c
	static System.Void .cctor(); // 0x059e2948
}

// Client.Runtime
class WizardGames.Soc.SocClient.Mail.MailUtil.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Mail.MailUtil.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Mail.Core.MailInfo> <>9__3_0; // 0x8
	static System.Void .cctor(); // 0x059e2a1c
	System.Void .ctor(); // 0x059e2a80
	System.Int32 <SortMailInfo>b__3_0(WizardGames.Soc.SocClient.Mail.Core.MailInfo x, WizardGames.Soc.SocClient.Mail.Core.MailInfo y); // 0x059e2ae8
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Mail.Core.EMailSource : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Mail.Core.EMailSource Lobby = 0;
	static WizardGames.Soc.SocClient.Mail.Core.EMailSource Game = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Mail.Core.EReadStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Mail.Core.EReadStatus Invalid = 0;
	static WizardGames.Soc.SocClient.Mail.Core.EReadStatus UnRead = 1;
	static WizardGames.Soc.SocClient.Mail.Core.EReadStatus Readed = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Mail.Core.EMailType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Mail.Core.EMailType Invalid = 0;
	static WizardGames.Soc.SocClient.Mail.Core.EMailType System = 1;
	static WizardGames.Soc.SocClient.Mail.Core.EMailType Notice = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Mail.Core.MailInfo : System.Object
{
	static SocLogger Log; // 0x0
	System.String <Id>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Mail.Core.EMailType <MailType>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Mail.Core.EReadStatus <ReadStatus>k__BackingField; // 0x1c
	System.Int64 invalidTime; // 0x20
	System.DateTime <SendTime>k__BackingField; // 0x28
	System.Int64 <SendTimeStamp>k__BackingField; // 0x30
	System.String <Title>k__BackingField; // 0x38
	System.Int32 <TemplateId>k__BackingField; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Mail.Core.Attachment> <Attachments>k__BackingField; // 0x48
	System.Collections.Generic.List<System.String> <Params>k__BackingField; // 0x50
	System.Boolean HaveAttached; // 0x58
	System.String <ContentStr>k__BackingField; // 0x60
	WizardGames.Soc.SocClient.Mail.Core.EMailSource MailSource; // 0x68
	System.String get_Id(); // 0x059e2c40
	System.Void set_Id(System.String value); // 0x059e2ca4
	WizardGames.Soc.SocClient.Mail.Core.EMailType get_MailType(); // 0x059e2d24
	System.Void set_MailType(WizardGames.Soc.SocClient.Mail.Core.EMailType value); // 0x059e2d88
	WizardGames.Soc.SocClient.Mail.Core.EReadStatus get_ReadStatus(); // 0x059e2e00
	System.Void set_ReadStatus(WizardGames.Soc.SocClient.Mail.Core.EReadStatus value); // 0x059e2e64
	System.Int32 get_InvalidDays(); // 0x059e2edc
	System.DateTime get_SendTime(); // 0x059e2f7c
	System.Void set_SendTime(System.DateTime value); // 0x059e2fe0
	System.Int64 get_SendTimeStamp(); // 0x059e3058
	System.Void set_SendTimeStamp(System.Int64 value); // 0x059e30bc
	System.String get_Title(); // 0x059e3134
	System.Void set_Title(System.String value); // 0x059e3198
	System.Int32 get_TemplateId(); // 0x059e3218
	System.Void set_TemplateId(System.Int32 value); // 0x059e327c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Mail.Core.Attachment> get_Attachments(); // 0x059e32f4
	System.Void set_Attachments(System.Collections.Generic.List<WizardGames.Soc.SocClient.Mail.Core.Attachment> value); // 0x059e3358
	System.Collections.Generic.List<System.String> get_Params(); // 0x059e33d8
	System.Void set_Params(System.Collections.Generic.List<System.String> value); // 0x059e343c
	System.String get_ContentStr(); // 0x059e34bc
	System.Void set_ContentStr(System.String value); // 0x059e3520
	System.Boolean get_HasAttachments(); // 0x059e35a0
	System.Void SetLobbyMailInfo(SimpleJSON.JSONNode node); // 0x059e3668
	System.Void SetGameMailInfo(System.String id, WizardGames.Soc.Common.CustomType.MailNode info); // 0x059e48f8
	System.Void ParseLobbyMailContent(SimpleJSON.JSONNode node); // 0x059e3f7c
	System.Void SetLobbyMailContent(System.String content); // 0x059e551c
	System.Void SetReadStatus(WizardGames.Soc.SocClient.Mail.Core.EReadStatus status); // 0x059e55d0
	System.Void SetLobbyAttachStatus(); // 0x059e56cc
	System.Void SetGameAttachStatus(WizardGames.Soc.Common.CustomType.MailNode info); // 0x059e573c
	System.Void .ctor(); // 0x059e5960
	static System.Void .cctor(); // 0x059e5a98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Mail.Core.Attachment : System.Object
{
	System.String <ItemId>k__BackingField; // 0x10
	System.Int32 <ItemNum>k__BackingField; // 0x18
	System.Boolean <HaveAttached>k__BackingField; // 0x1c
	System.String get_ItemId(); // 0x059e5b6c
	System.Void set_ItemId(System.String value); // 0x059e5bd0
	System.Int32 get_ItemNum(); // 0x059e5c50
	System.Void set_ItemNum(System.Int32 value); // 0x059e5cb4
	System.Boolean get_HaveAttached(); // 0x059e5d2c
	System.Void set_HaveAttached(System.Boolean value); // 0x059e5d90
	System.Void .ctor(); // 0x059e28e0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Mail.Core.ERequestOp : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Mail.Core.ERequestOp Delete = 0;
	static WizardGames.Soc.SocClient.Mail.Core.ERequestOp GetContent = 1;
	static WizardGames.Soc.SocClient.Mail.Core.ERequestOp List = 2;
	static WizardGames.Soc.SocClient.Mail.Core.ERequestOp MarkRead = 3;
	static WizardGames.Soc.SocClient.Mail.Core.ERequestOp RecvAttachment = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Log.SocClientLogService : WizardGames.Soc.Common.LogService.SocUnityLogService
{
	static SocLogger logger; // 0x0
	System.Void .ctor(); // 0x059e5e0c
	System.Void InitService(System.String loggerName, System.String configPath, System.String logPath); // 0x059e5e98
	static System.Void .cctor(); // 0x059e619c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Data.LanguageUtils : System.Object
{
	
	static WizardGames.Soc.Common.Data.language.LanguageConfig GetCurLanCfg(WizardGames.Soc.Common.Data.language.TbLanguageConfig cfg); // 0x059e6270
	static System.Boolean IsEnable(WizardGames.Soc.Common.Data.language.LanguageConfig cfg); // 0x059e6360
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.LobbyTeammateSpeaker : System.Object
{
	WizardGames.Soc.SocClient.Manager.LobbyTeamMemberData teamMemberData; // 0x10
	System.Int32 speakerValue; // 0x18
	System.Boolean isMuteValue; // 0x1c
	System.Void .ctor(WizardGames.Soc.SocClient.Manager.LobbyTeamMemberData teamMemberData); // 0x059e6420
	System.Int32 get_SpeakerValue(); // 0x059e6728
	System.Void set_SpeakerValue(System.Int32 value); // 0x059e65fc
	System.Boolean get_IsMuteValue(); // 0x059e678c
	System.Void set_IsMuteValue(System.Boolean value); // 0x059e67f0
	System.Void ClearRecord(); // 0x059e6908
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	WizardGames.Soc.SocClient.Manager.LobbyTeamData curTeamData; // 0x18
	WizardGames.Soc.SocClient.Manager.LobbyTeamData curAppointmentTeamData; // 0x20
	System.Int32 CurModeId; // 0x28
	System.Boolean TeamJoinBattle; // 0x2c
	WizardGames.Soc.SocClient.Manager.LobbyTeamPlayerModel lobbyTeamPlayerModel; // 0x30
	WizardGames.Soc.SocClient.ServerList.ServerInfo serverInfo; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo> LobbyInviteInfos; // 0x40
	System.Collections.Generic.Dictionary<System.Int32,System.String> teamDicIndex; // 0x48
	System.Collections.Generic.Dictionary<System.String,System.Int64> roleId2InviteCD; // 0x50
	System.Collections.Generic.Dictionary<System.String,System.Int64> roleId2AppointmentInviteCD; // 0x58
	System.Collections.Generic.List<System.Int32> deleteIndexs; // 0x60
	System.Collections.Generic.List<System.String> checkDeleteOldTeamModelRoleIds; // 0x68
	System.Int64 appointmentTimerId; // 0x70
	System.Int64 appointmentTimerId1; // 0x78
	System.Int64 appointmentTimerId2; // 0x80
	System.Int64 appointmentTimerId3; // 0x88
	System.Int64 fakeMathingTimeOutTimerId; // 0x90
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> isFirstOpenQuickInviteDic; // 0x98
	System.UInt64 lastMatchWarzoneTime; // 0xa0
	System.Boolean IsAppointmentByJoinBattle; // 0xa8
	WizardGames.Soc.SocClient.Manager.EReadyToJoinWarzone ReadyToJoinWarzoneType; // 0xac
	System.Boolean isUiLobbyMainInit; // 0xb0
	System.Boolean isReqMyTeamSuccess; // 0xb1
	System.Boolean CheckAppointmentTeamPushNotice; // 0xb2
	System.String CallTeammateOnlineBattleServerId; // 0xb8
	System.Boolean IsNewBieForbidTeamGmOpen; // 0xc0
	System.Nullable<System.Boolean> cachedShieldTeamInvitePop; // 0xc1
	WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo settleNewBieTeamInviteInfo; // 0xc8
	System.UInt32 msgBoxId; // 0xd0
	System.Int32 queueTime; // 0xd4
	System.Int32 serverQueuePos; // 0xd8
	System.Boolean isHandleCancelServerQueueUp; // 0xdc
	WizardGames.Soc.SocClient.Ui.TeamShareCdInfo normalLobbyTeamShareCdInfo; // 0xe0
	WizardGames.Soc.SocClient.Ui.TeamShareCdInfo appointmentLobbyTeamShareCdInfo; // 0xe8
	WizardGames.Soc.SocClient.Ui.TeamShareCdInfo battleTeamShareCdInfo; // 0xf0
	System.Boolean ForbidShareTeam; // 0xf8
	System.Boolean ForbidSelfRecommend; // 0xf9
	System.Single NextSendMsgInGameWorldChat; // 0xfc
	WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType CurVoiceRoomType; // 0x100
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.LobbyTeammateSpeaker> teammateSpeakers; // 0x108
	static System.Collections.Generic.List<System.String> s_RemoveList; // 0x8
	System.Boolean get_NewbieTeamIsOpen(); // 0x059e6a24
	System.Void Init(); // 0x059e6b74
	System.Void Destroy(); // 0x059e6d2c
	System.Threading.Tasks.Task OnEnterWorld(); // 0x059e6eac
	System.Threading.Tasks.Task OnExitWorld(); // 0x059e6f4c
	System.Void OnAccountLogout(); // 0x059e6fec
	System.Void OnLobbyReconnected(); // 0x059e7188
	System.Void InitLobbyTeamModelPoint(); // 0x059e7648
	System.Void OnStartNewBattle(SimpleJSON.JSONNode node); // 0x059e76b8
	System.Void OnJoinOldBattleByInvite(SimpleJSON.JSONNode node); // 0x059e7994
	System.Void OnLobbyTeamInviteDel(System.String delId); // 0x059e7a28
	System.Void OnLobbyTeamInviteClear(); // 0x059e7be4
	System.Boolean IsNewBieServer(System.Int32 gameMode); // 0x059e7d54
	System.Void OnAccountLogined(); // 0x059e7e60
	System.Void OnAccountEnterLobby(); // 0x059e7ec8
	System.Void InitReq(); // 0x059e7f38
	System.Void OnHandleSyncCancelGameByLogin(System.Boolean isAppointment); // 0x059e88cc
	System.Void InitTeamData(System.Boolean isFirstLogin); // 0x059e800c
	System.Void CheckTeamData(System.Boolean isAppointment); // 0x059e937c
	System.Void CheckDeleteOldTeamModelByCurTeamData(System.Boolean isAppointment); // 0x059e94d4
	System.Boolean IsDynamicByModeId(System.Int32 modeId); // 0x059e9ab4
	System.Void ResponseTeamInfo(SimpleJSON.JSONNode ret, System.Action<SimpleJSON.JSONNode> callback, System.Boolean isAppointment); // 0x059e9c48
	System.Void CheckNeedDepartureTips(System.Int32 modeID, System.Boolean isAppointment); // 0x059ea618
	System.Void CreatePlayerModel(System.String roleId, System.Boolean isAppointment); // 0x059ea9c8
	System.Void DeletePlayerModel(System.String roleId); // 0x059eac68
	System.Void DeleteAllPlayerModel(System.Boolean isAppointment); // 0x059eaee4
	System.Void CheckDeleteOldTeamModel(System.Collections.Generic.List<System.String> roleIds, System.Boolean isAppointment); // 0x059e96f8
	System.Boolean IndexIsUse(System.Int32 index); // 0x059eafe8
	System.Int32 GetIndexByRoleId(System.String roleId); // 0x059eb0cc
	System.Void RemoveTeamMember(System.String roleId, System.Boolean isAppointment); // 0x059eb2c0
	System.Void SetMatchState(System.Int32 state, System.String stoppedRoleID, System.Boolean isAppointment); // 0x059eb590
	System.Void OnOpenLobbyTeamByCurAppointmentPush(); // 0x059eb924
	System.Void OnRefreshByLobbyAnimFinish(); // 0x059ebc60
	System.Void OnNeedBackToUiLobbyTeam(SimpleJSON.JSONNode node); // 0x059ebfcc
	System.Void OnTeamMemberReady(SimpleJSON.JSONNode jsonNode); // 0x059ec648
	System.Boolean IsInAppointmentMode(); // 0x059ecac8
	System.Boolean IsAppointmentModeByModeID(System.Int32 modeID); // 0x059ecb8c
	System.Int64 GetTeamAppointmentTime(); // 0x059ecd28
	System.Boolean GetReadyByRoleId(System.String roleId, System.Boolean isAppointment); // 0x059ecdd4
	System.Void OpenUiHistoryBattle(System.Int32 selectModeId); // 0x059ecfa4
	System.Void OpenUiHistoryBattleByBattleServerId(System.String battleServerId, System.Action callback); // 0x059ed4f8
	WizardGames.Soc.Common.Data.Play.ENUMGameType GetCurGameTypeByModeId(System.Int32 modeId); // 0x059e9b3c
	System.Boolean IsAllReady(System.Boolean isAppointment); // 0x059eda88
	System.Boolean IsTeamMemberReadyByRoleId(System.String roleId, System.Boolean isAppointment); // 0x059edc94
	WizardGames.Soc.SocClient.Manager.LobbyTeamData GetCurTeamInfo(System.Boolean isAppointment); // 0x059e8a2c
	System.Void SetTeamFakeMating(System.Boolean isAppointment, System.Boolean isFakeMatching); // 0x059edf0c
	System.Void SetEnablePowerOptimizationByMatchStatus(System.Boolean isAppointment); // 0x059eb810
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.LobbyTeamMemberData> GetCurTeamMemberDataList(System.Boolean isAppointment); // 0x059edfa8
	System.Int32 GetPermission(System.Boolean isAppointment); // 0x059ee030
	System.Boolean HasLobbyTeam(System.Boolean isAppointment); // 0x059ebbb0
	System.Boolean IsCaptain(System.String roleId, System.Boolean isAppointment); // 0x059e8ab0
	System.String GetModeNameByModeId(System.Int32 modeId); // 0x059ee118
	System.Void ErrorCodeTransTip(System.Int32 codeId); // 0x059ee268
	System.Int32 GetCurTeamMemberCount(System.Boolean isAppointment); // 0x059ee4b4
	System.Void ClearCurMemberInfo(System.Boolean isAppointment); // 0x059e7074
	System.Void SendAcceptInvite(WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo lobbyTeamInviteData, System.Action callback); // 0x059ee664
	System.Void SettleNewbieBattle(WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo lobbyTeamInviteData, System.Action callback); // 0x059ee8a8
	System.Void OnHandleFromLobbyInvite(WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo lobbyTeamInviteData, System.Action callback); // 0x059eea20
	System.Void OnHandleJumpBattle(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String jumpServerId, System.Action callback); // 0x059ec300
	System.Void OnHanldeJumpLobby(System.Action callback); // 0x059ef1d4
	System.Void OnHandleFromBattleInvite(WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo lobbyTeamInviteData, System.Action callback); // 0x059eec54
	System.Void HandleInviteInLobby(WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo lobbyTeamInviteData, System.Action callback); // 0x059ef474
	System.Void HandleInviteInBattle(WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo lobbyTeamInviteData, System.Action callback); // 0x059ef984
	System.Void AcceptInvite(WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo lobbyTeamInviteData, System.Action callback, System.Boolean jumpToGame); // 0x059eff68
	System.Void HandleSuccessInvite(WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo lobbyTeamInviteData, System.Boolean jumpToGame, System.Action callback); // 0x059f00d0
	System.Int32 GetShineTeamTipId(System.Int32 tipId); // 0x059f0488
	System.Boolean IsInCurTeam(System.String roleId, System.Boolean isAppointment); // 0x059f0684
	System.Boolean HasPermission(System.Boolean isAppointment); // 0x059f07ec
	System.Boolean CheckIsInviteCdIng(System.String roleId, System.Boolean isAppointment, System.Int32& leftTime); // 0x059f0920
	System.Void AddInviteCd(System.String roleId, System.Boolean isAppointment); // 0x059f0b14
	System.Void SetLobbyTeamInviteRead(); // 0x059f0bfc
	System.Boolean IsLobbyTeamInvite(); // 0x059f0dd4
	System.Void CheckNeedInvitePop(); // 0x059e8120
	System.String GetInviteSource(WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo info); // 0x059f1078
	System.Void CancelTipByAppointmentTeamDisband(); // 0x059f121c
	System.Void RegistAppointmentServerOpenTimer(); // 0x059f159c
	System.Void RegistAppointmentTimerToLeftPop(); // 0x059f19f0
	System.Void RegistAppointmentTimerToPlayTransition(); // 0x059f1e88
	System.Void RegistAppointmentTimerToShowLeaveTeamTip(); // 0x059f2310
	System.Void AddAppointmentTeamPush(System.Int32 modeId, System.Int64 appointmentTime); // 0x059f27e4
	System.Void CancelAppointmentTeamPush(); // 0x059f14fc
	System.Void CheckAppointmentTeamDisband(); // 0x059f2d50
	System.Boolean IsTeamMatching(System.Boolean needTips); // 0x059f34c4
	System.Boolean IsTeamMatchingByAppointment(System.Boolean needTips, System.Boolean isAppointment); // 0x059f356c
	System.Boolean IsTeamMatchingSuccess(System.Boolean isAppointment); // 0x059f3704
	System.Int32 CurTeamMaxMemberCount(System.Boolean isAppointment); // 0x059ea8ec
	System.Void GetCurTeamMemberPlatform(System.Int32 curClientPlatform, System.Boolean isAppointment, System.Action<System.Boolean> callback); // 0x059f37d0
	System.Boolean CheckCurTeamMemberPlatform(System.Boolean isAppointment); // 0x059f3bbc
	System.Int32 GetCurClientPlatform(System.Int32 modeId); // 0x059f3fa4
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> GetShowOptInfoByRoleId(System.String roleId, System.Boolean isAppointment); // 0x059f4148
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> GetCostumeSlotInfoByRoleId(System.String roleId, System.Boolean isAppointment); // 0x059f4320
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> GetEquipmentSlotInfoByRoleId(System.String roleId, System.Boolean isAppointment); // 0x059f44f8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.LobbyTeamMemberData> GetSortedTeamMemberDataList(System.Boolean isAppointment); // 0x059f46d0
	System.Void OnCancelFakeMathingTimeOutTimerId(); // 0x059ee558
	System.String GetPlantformName(System.Int32 index); // 0x059f49cc
	System.Collections.Generic.List<System.String> GetMemberRoleIDList(System.Boolean isAppointment); // 0x059e8bec
	System.String GetFormatTime(System.Int64 appointmentTime); // 0x059f4abc
	System.Void SetClientModifiedPreferenceList(System.Boolean isAppointment, System.String roleId, System.Collections.Generic.List<System.Int32> dataList); // 0x059f4ebc
	System.Collections.Generic.List<System.Int32> GetClientModifiedPreferenceList(System.Boolean isAppointment, System.String roleId); // 0x059f509c
	System.Void SaveListToPlayerPrefs(System.Collections.Generic.List<System.Int32> listA); // 0x059f52bc
	System.Collections.Generic.List<System.Int32> LoadListFromPlayerPrefs(); // 0x059f546c
	SimpleJSON.JSONArray GetDefaultJobsJSONArray(); // 0x059f5858
	System.String GetPreferenceOptionNameById(System.Int32 optionId); // 0x059f59b8
	System.Void OpenBattleServerQueuePopup(System.Int32 pos); // 0x059f5bdc
	System.Void UpdateBattleServerQueueContent(); // 0x059f60fc
	System.Void OnExitBattleServerQueue(); // 0x059f6250
	System.Void OnHandleCancelServerQueueUp(System.Boolean isTimeout); // 0x059f64f4
	System.String GetModeInfo(System.Int32 curMaxTeamNum, System.Int32 clientPlatform, System.Int32 modeId, System.String region, System.String separator); // 0x059f68c4
	System.Void SetShieldTeamInvitePop(System.Boolean shield); // 0x059f6b38
	System.Boolean IsShieldTeamInvitePop(); // 0x059f0f44
	System.Void OnReqSyncCancelGame(System.Boolean isAppointment, System.Action callback); // 0x059f6c7c
	System.Void ReqStopMatch(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Boolean isAppointment, System.Action callback); // 0x059f6eac
	System.Void ReqReadyTeam(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Boolean ready, System.Boolean isAppointment, System.Action callback); // 0x059f7178
	System.Void ReqAllInviteInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Boolean isAppointment, System.Action callback); // 0x059e8614
	System.Void ReqChangeTeamPermission(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Int32 permission, System.Action callback, System.Boolean isAppointment); // 0x059f7490
	System.Void ReqChangeTeamLeader(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String newLeaderId, System.Boolean isAppointment, System.Action callback); // 0x059f77a4
	System.Void ReqMyTeamInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action<SimpleJSON.JSONNode> callback, System.Boolean isAppointment, System.Boolean isNeedRegistTimer); // 0x059e7350
	System.Void ReqUpdateTeamMember(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Boolean isAppointment); // 0x059f7aec
	System.Void ReqTurnToMultipleWarzoneMatch(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Boolean isAppointment, System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MatchOptionsData> optionsDataList, System.Action callback); // 0x059f7ff4
	System.Void ReqUpdateTeamMode(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Int32 modeId, System.Boolean isAppointment, System.Int32 battlePlatform, System.Int32 teamCapacity, System.String region, System.Int64 appointmentTime); // 0x059f8568
	System.Void ReqRandomRoleIds(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action<SimpleJSON.JSONNode> callback); // 0x059f8998
	System.Void ReqSearchRole(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String val, System.Action<SimpleJSON.JSONNode> callback, System.Action errorCallback); // 0x059f8b74
	System.Void ReqKickTeamMember(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String roleId, System.Boolean isAppointment); // 0x059f8e48
	System.Void ResponseRefuseInvite(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String invitationID, System.Action callback, System.Action errorCallback, System.Boolean isAppointment); // 0x059f9190
	System.Void ResponseRefuseAllInvite(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Collections.Generic.List<System.String> invitationIDList, System.Boolean isAppointment); // 0x059f9604
	System.Void ResponseAcceptInvite(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String invitationID, System.Action<SimpleJSON.JSONNode> callback, System.Boolean isAppointment); // 0x059eed28
	System.Void ReqInviteLobby(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String roleId, System.Boolean isAppointment, System.Int32 sourceID); // 0x059f9a00
	System.Void ReqSyncCancelGame(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Boolean isAppointment, System.Collections.Generic.List<System.String> memberRoleIDList, System.Action callback); // 0x059e8f14
	System.Void ReqSyncStartGame(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Boolean isAppointment, System.Collections.Generic.List<System.String> memberRoleIDList, System.String randomSeed, System.Action callback); // 0x059f9cbc
	System.Void ReqStartGame(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Boolean isAppointment, System.Action callback); // 0x059fa1a4
	System.Void ReqLeaveTeam(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action callback, System.Boolean isAppointment); // 0x059fa49c
	System.Void ReqCreateTeam(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Int32 selectMode, System.Action callback, System.Action errorCallback, System.Int64 appointmentTime, System.Int32 teamMaxMember, System.Int32 createBattlePlatform, System.String createRegion); // 0x059fa7c8
	System.Void OnTeamTurnToMultipleWarzoneMatch(SimpleJSON.JSONNode node); // 0x059faf48
	System.Void OnSyncCancelGame(SimpleJSON.JSONNode node); // 0x059fb170
	System.Void OnSyncStartGame(SimpleJSON.JSONNode node); // 0x059fb42c
	System.Void OnStartGame(SimpleJSON.JSONNode node); // 0x059fb91c
	System.Void OnLobbyTeamInviteAdd(SimpleJSON.JSONNode node); // 0x059fbc64
	System.Void OnUpdateTeamLeader(SimpleJSON.JSONNode node); // 0x059fc578
	System.Void OnUpdateTeamPermission(SimpleJSON.JSONNode node); // 0x059fca20
	System.Void OnJoinTeam(SimpleJSON.JSONNode node); // 0x059fcd30
	System.Void OnLeaveTeam(SimpleJSON.JSONNode node); // 0x059fd6f4
	System.Void OnKickTeam(SimpleJSON.JSONNode node); // 0x059fdef4
	System.Void OnInviteCallback(SimpleJSON.JSONNode node); // 0x059fe30c
	System.Void OnUpdateTeamMemberDisplay(SimpleJSON.JSONNode jsonNode); // 0x059fe80c
	System.Void OnTeamDynamicMatch(SimpleJSON.JSONNode jsonNode); // 0x059fe9dc
	System.Void OnTeamWarzoneMatch(SimpleJSON.JSONNode jsonNode); // 0x059fed5c
	System.Void OnUpdateTeamMember(SimpleJSON.JSONNode jsonNode); // 0x059ff15c
	System.Void UpdateTeamMode(SimpleJSON.JSONNode jsonNode); // 0x059ff63c
	System.Int32 get_shareTeamMaxCount(); // 0x059ffbb0
	System.Int32 get_shareTeamCdTime(); // 0x059ffc98
	System.Boolean CurTeamShareIsInCd(WizardGames.Soc.SocClient.Ui.ETeamType teamType, System.Int64& leftTime); // 0x059ffd80
	System.Void ChangeTeamShareCd(WizardGames.Soc.SocClient.Ui.ETeamType teamType); // 0x05a00014
	static System.String get_UiSpeakerSelect(); // 0x05a002f8
	static System.String get_UiMicSelect(); // 0x05a003b0
	System.Void RefreshTeammateSpeaker(System.Boolean isAppointment); // 0x059e9ecc
	WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType GetTeamType(); // 0x05a00468
	WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType GetCurVoiceRootType(); // 0x059fd640
	WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType SetOtherType(WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType type); // 0x05a00514
	System.Void QuitVoiceRoom(WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType type); // 0x05a005c0
	System.Int32 GetMicState(); // 0x05a00664
	System.Void SetMicState(System.Int32 state); // 0x05a006f4
	System.Int32 GetSpeeakerState(); // 0x05a00798
	System.Void SetSpeeakerState(System.Int32 state); // 0x05a00828
	System.Void .ctor(); // 0x05a008cc
	static System.Void .cctor(); // 0x05a00d88
	System.Void <OnLobbyReconnected>b__37_0(SimpleJSON.JSONNode node); // 0x05a00eb4
	System.Void <OnLobbyReconnected>b__37_1(SimpleJSON.JSONNode node); // 0x05a0118c
	System.Void <OnStartNewBattle>b__39_0(); // 0x05a01344
	System.Void <InitTeamData>b__48_0(SimpleJSON.JSONNode node); // 0x05a01428
	System.Void <InitTeamData>b__48_1(SimpleJSON.JSONNode node); // 0x05a0157c
	System.Void <OnExitBattleServerQueue>b__140_0(); // 0x05a01718
	System.Void <OnExitBattleServerQueue>b__140_1(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05a017d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__49_1; // 0x8
	static System.Action<Config.LobbyRoleInfo> <>9__61_0; // 0x10
	static System.Action <>9__70_1; // 0x18
	static System.Action <>9__71_1; // 0x20
	static System.Action <>9__88_1; // 0x28
	static System.Action<SimpleJSON.JSONArray> <>9__119_0; // 0x30
	static System.Action<SimpleJSON.JSONNode> <>9__161_2; // 0x38
	static System.Action<SimpleJSON.JSONNode> <>9__162_4; // 0x40
	static System.Action <>9__165_3; // 0x48
	static System.Action<SimpleJSON.JSONNode> <>9__175_0; // 0x50
	static System.Action<SimpleJSON.JSONNode> <>9__176_0; // 0x58
	static System.Action<SimpleJSON.JSONNode> <>9__176_1; // 0x60
	static System.Action<SimpleJSON.JSONNode> <>9__177_0; // 0x68
	static System.Action<SimpleJSON.JSONNode> <>9__178_0; // 0x70
	static System.Action<SimpleJSON.JSONNode> <>9__178_1; // 0x78
	static System.Void .cctor(); // 0x05a0219c
	System.Void .ctor(); // 0x05a02200
	System.Void <CheckTeamData>b__49_1(SimpleJSON.JSONNode json); // 0x05a02268
	System.Void <SetMatchState>b__61_0(Config.LobbyRoleInfo userInfo); // 0x05a0231c
	System.Void <OpenUiHistoryBattle>b__70_1(); // 0x05a02420
	System.Void <OpenUiHistoryBattleByBattleServerId>b__71_1(); // 0x05a02480
	System.Void <SettleNewbieBattle>b__88_1(); // 0x05a024e0
	System.Void <CheckCurTeamMemberPlatform>b__119_0(SimpleJSON.JSONArray jsonArray); // 0x05a02540
	System.Void <ResponseAcceptInvite>b__161_2(SimpleJSON.JSONNode json); // 0x05a0279c
	System.Void <ReqInviteLobby>b__162_4(SimpleJSON.JSONNode node); // 0x05a02850
	System.Void <ReqStartGame>b__165_3(); // 0x05a02994
	System.Void <OnJoinTeam>b__175_0(SimpleJSON.JSONNode jsonNode); // 0x05a029f4
	System.Void <OnLeaveTeam>b__176_0(SimpleJSON.JSONNode jsonNode); // 0x05a02b38
	System.Void <OnLeaveTeam>b__176_1(SimpleJSON.JSONNode jsonNode); // 0x05a02c7c
	System.Void <OnKickTeam>b__177_0(SimpleJSON.JSONNode jsonNode); // 0x05a02dc0
	System.Void <OnInviteCallback>b__178_0(SimpleJSON.JSONNode jsonNode); // 0x05a02f04
	System.Void <OnInviteCallback>b__178_1(SimpleJSON.JSONNode jsonNode); // 0x05a03048
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass107_0 : System.Object
{
	System.Int64 startTime; // 0x10
	System.Int64 targetTime; // 0x18
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x20
	System.Void .ctor(); // 0x05a0318c
	System.Void <RegistAppointmentServerOpenTimer>b__0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05a031f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass108_0 : System.Object
{
	System.Int64 startTime; // 0x10
	System.Int64 targetTime; // 0x18
	System.Int32 time; // 0x20
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x28
	System.Action <>9__2; // 0x30
	System.Action <>9__1; // 0x38
	System.Void .ctor(); // 0x05a03404
	System.Void <RegistAppointmentTimerToLeftPop>b__0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05a0346c
	System.Void <RegistAppointmentTimerToLeftPop>b__1(); // 0x05a03a60
	System.Void <RegistAppointmentTimerToLeftPop>b__2(); // 0x05a03b44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass109_0 : System.Object
{
	System.Int64 startTime; // 0x10
	System.Int64 targetTime; // 0x18
	System.Int32 time; // 0x20
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x28
	System.Void .ctor(); // 0x05a03c48
	System.Void <RegistAppointmentTimerToPlayTransition>b__0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05a03cb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass109_1 : System.Object
{
	System.String tips; // 0x10
	System.Void .ctor(); // 0x05a040dc
	System.Void <RegistAppointmentTimerToPlayTransition>b__1(WizardGames.Soc.SocClient.Ui.UiTeamDepartureTips win); // 0x05a04144
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass110_0 : System.Object
{
	System.Int64 startTime; // 0x10
	System.Int64 targetTime; // 0x18
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x20
	System.Void .ctor(); // 0x05a041cc
	System.Void <RegistAppointmentTimerToShowLeaveTeamTip>b__0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05a04234
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass113_0 : System.Object
{
	System.String battleServerId; // 0x10
	System.Void .ctor(); // 0x05a0456c
	System.Void <CheckAppointmentTeamDisband>b__0(); // 0x05a045d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass118_0 : System.Object
{
	System.Action<System.Boolean> callback; // 0x10
	System.Void .ctor(); // 0x05a04678
	System.Void <GetCurTeamMemberPlatform>b__0(SimpleJSON.JSONArray jsonArray); // 0x05a046e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass146_0 : System.Object
{
	System.Action callback; // 0x10
	System.Void .ctor(); // 0x05a04b54
	System.Void <OnReqSyncCancelGame>b__0(); // 0x05a04bbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass147_0 : System.Object
{
	System.Action callback; // 0x10
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x18
	System.Boolean isAppointment; // 0x20
	System.Void .ctor(); // 0x05a04c74
	System.Void <ReqStopMatch>b__0(SimpleJSON.JSONNode ret); // 0x05a04cdc
	System.Void <ReqStopMatch>b__1(SimpleJSON.JSONNode error); // 0x05a04df8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass148_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x10
	System.Boolean isAppointment; // 0x18
	System.Boolean ready; // 0x19
	System.Action callback; // 0x20
	System.Void .ctor(); // 0x05a04f58
	System.Void <ReqReadyTeam>b__0(SimpleJSON.JSONNode ret); // 0x05a04fc0
	System.Void <ReqReadyTeam>b__1(SimpleJSON.JSONNode error); // 0x05a050e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass149_0 : System.Object
{
	System.Boolean isAppointment; // 0x10
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x18
	System.Action callback; // 0x20
	System.Void .ctor(); // 0x05a05248
	System.Void <ReqAllInviteInfo>b__0(SimpleJSON.JSONNode res); // 0x05a052b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass150_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x10
	System.Boolean isAppointment; // 0x18
	System.Int32 permission; // 0x1c
	System.Action callback; // 0x20
	System.Void .ctor(); // 0x05a05614
	System.Void <ReqChangeTeamPermission>b__0(SimpleJSON.JSONNode ret); // 0x05a0567c
	System.Void <ReqChangeTeamPermission>b__1(SimpleJSON.JSONNode error); // 0x05a05784
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass151_0 : System.Object
{
	System.Action callback; // 0x10
	System.Boolean isAppointment; // 0x18
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x20
	System.Void .ctor(); // 0x05a058e4
	System.Void <ReqChangeTeamLeader>b__0(SimpleJSON.JSONNode ret); // 0x05a0594c
	System.Void <ReqChangeTeamLeader>b__1(SimpleJSON.JSONNode error); // 0x05a05a18
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass152_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x10
	System.Action<SimpleJSON.JSONNode> callback; // 0x18
	System.Boolean isAppointment; // 0x20
	System.Boolean isNeedRegistTimer; // 0x21
	System.Void .ctor(); // 0x05a05b78
	System.Void <ReqMyTeamInfo>b__0(SimpleJSON.JSONNode res); // 0x05a05be0
	System.Void <ReqMyTeamInfo>b__1(SimpleJSON.JSONNode error); // 0x05a05ef0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass153_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x10
	System.Boolean isAppointment; // 0x18
	System.Int32 clientPlatform; // 0x1c
	System.Collections.Generic.List<System.Int32> jobList; // 0x20
	System.Void .ctor(); // 0x05a0614c
	System.Void <ReqUpdateTeamMember>b__0(SimpleJSON.JSONNode res); // 0x05a061b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass154_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.LobbyTeamData curTeamInfo; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MatchOptionsData> optionsDataList; // 0x18
	System.Action callback; // 0x20
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x28
	System.Void .ctor(); // 0x05a063d0
	System.Void <ReqTurnToMultipleWarzoneMatch>b__0(SimpleJSON.JSONNode ret); // 0x05a06438
	System.Void <ReqTurnToMultipleWarzoneMatch>b__1(SimpleJSON.JSONNode error); // 0x05a064e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass155_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x10
	System.Boolean isAppointment; // 0x18
	System.Int32 modeId; // 0x1c
	System.Int32 battlePlatform; // 0x20
	System.Int32 teamCapacity; // 0x24
	System.String region; // 0x28
	System.Int64 appointmentTime; // 0x30
	System.Void .ctor(); // 0x05a06648
	System.Void <ReqUpdateTeamMode>b__0(SimpleJSON.JSONNode res); // 0x05a066b0
	System.Void <ReqUpdateTeamMode>b__1(SimpleJSON.JSONNode error); // 0x05a069f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass156_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> callback; // 0x10
	System.Void .ctor(); // 0x05a06b58
	System.Void <ReqRandomRoleIds>b__0(SimpleJSON.JSONNode res); // 0x05a06bc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass157_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> callback; // 0x10
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x18
	System.Action errorCallback; // 0x20
	System.Void .ctor(); // 0x05a06c84
	System.Void <ReqSearchRole>b__0(SimpleJSON.JSONNode res); // 0x05a06cec
	System.Void <ReqSearchRole>b__1(SimpleJSON.JSONNode error); // 0x05a06e14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass158_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x10
	System.String roleId; // 0x18
	System.Boolean isAppointment; // 0x20
	System.Void .ctor(); // 0x05a06f8c
	System.Void <ReqKickTeamMember>b__0(SimpleJSON.JSONNode res); // 0x05a06ff4
	System.Void <ReqKickTeamMember>b__1(SimpleJSON.JSONNode error); // 0x05a070c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass159_0 : System.Object
{
	System.String invitationID; // 0x10
	System.Action callback; // 0x18
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x20
	System.Action errorCallback; // 0x28
	System.Void .ctor(); // 0x05a07220
	System.Void <ResponseRefuseInvite>b__0(SimpleJSON.JSONNode ret); // 0x05a07288
	System.Void <ResponseRefuseInvite>b__1(SimpleJSON.JSONNode error); // 0x05a073e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass160_0 : System.Object
{
	System.Collections.Generic.List<System.String> invitationIDList; // 0x10
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x18
	System.Void .ctor(); // 0x05a075e0
	System.Void <ResponseRefuseAllInvite>b__0(SimpleJSON.JSONNode ret); // 0x05a07648
	System.Void <ResponseRefuseAllInvite>b__1(SimpleJSON.JSONNode error); // 0x05a07798
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass161_0 : System.Object
{
	System.String invitationID; // 0x10
	WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule; // 0x18
	System.Boolean isAppointment; // 0x1c
	System.Action<SimpleJSON.JSONNode> callback; // 0x20
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x28
	System.Void .ctor(); // 0x05a079a8
	System.Void <ResponseAcceptInvite>b__0(SimpleJSON.JSONNode ret); // 0x05a07a10
	System.Void <ResponseAcceptInvite>b__1(SimpleJSON.JSONNode error); // 0x05a07cf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass162_0 : System.Object
{
	Config.EUserPrivacy eUserPrivacy; // 0x10
	System.String roleId; // 0x18
	System.Boolean isAppointment; // 0x20
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x28
	System.Int32 sourceID; // 0x30
	WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule; // 0x34
	System.Action<SimpleJSON.JSONNode> <>9__2; // 0x38
	System.Action<SimpleJSON.JSONNode> <>9__3; // 0x40
	System.Void .ctor(); // 0x05a07ff0
	System.Void <ReqInviteLobby>b__0(SimpleJSON.JSONNode node); // 0x05a08058
	System.Void <ReqInviteLobby>b__2(SimpleJSON.JSONNode res); // 0x05a087dc
	System.Void <ReqInviteLobby>b__3(SimpleJSON.JSONNode error); // 0x05a089f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass162_1 : System.Object
{
	SimpleJSON.JSONObject param; // 0x10
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass162_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x05a08774
	System.Void <ReqInviteLobby>b__1(); // 0x05a08b9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass163_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x10
	System.Boolean isAppointment; // 0x18
	System.Action callback; // 0x20
	System.Void .ctor(); // 0x05a08dd0
	System.Void <ReqSyncCancelGame>b__0(SimpleJSON.JSONNode res); // 0x05a08e38
	System.Void <ReqSyncCancelGame>b__1(SimpleJSON.JSONNode error); // 0x05a08f74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass164_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x10
	System.Boolean isAppointment; // 0x18
	System.Action callback; // 0x20
	System.Collections.Generic.List<System.String> memberRoleIDList; // 0x28
	WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule; // 0x30
	System.Void .ctor(); // 0x05a090d4
	System.Void <ReqSyncStartGame>b__0(SimpleJSON.JSONNode res); // 0x05a0913c
	System.Void <ReqSyncStartGame>b__1(SimpleJSON.JSONNode error); // 0x05a09244
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass165_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x10
	System.Boolean isAppointment; // 0x18
	System.Action callback; // 0x20
	WizardGames.Soc.SocClient.Manager.LobbyTeamData teamData; // 0x28
	WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule; // 0x30
	System.Action <>9__2; // 0x38
	System.Void .ctor(); // 0x05a0948c
	System.Void <ReqStartGame>b__0(SimpleJSON.JSONNode res); // 0x05a094f4
	System.Void <ReqStartGame>b__1(SimpleJSON.JSONNode error); // 0x05a0960c
	System.Void <ReqStartGame>b__2(); // 0x05a09bac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass166_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x10
	System.Boolean isAppointment; // 0x18
	System.Action callback; // 0x20
	System.Void .ctor(); // 0x05a09cfc
	System.Void <ReqLeaveTeam>b__0(SimpleJSON.JSONNode res); // 0x05a09d64
	System.Void <ReqLeaveTeam>b__1(SimpleJSON.JSONNode error); // 0x05a09f70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass167_0 : System.Object
{
	System.Int64 appointmentTime; // 0x10
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x18
	System.Action callback; // 0x20
	System.Int32 selectMode; // 0x28
	System.Action errorCallback; // 0x30
	System.Action<SimpleJSON.JSONNode> <>9__2; // 0x38
	System.Void .ctor(); // 0x05a0a0d0
	System.Void <ReqCreateTeam>b__0(SimpleJSON.JSONNode res); // 0x05a0a138
	System.Void <ReqCreateTeam>b__2(SimpleJSON.JSONNode ret); // 0x05a0a424
	System.Void <ReqCreateTeam>b__1(SimpleJSON.JSONNode error); // 0x05a0a510
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass170_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.LobbyTeamData teamData; // 0x10
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x18
	System.Boolean isAppointment; // 0x20
	System.Void .ctor(); // 0x05a0a688
	System.Void <OnSyncStartGame>b__0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05a0a6f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass179_0 : System.Object
{
	System.String updateRoleID; // 0x10
	System.String teamID; // 0x18
	System.Void .ctor(); // 0x05a0a8a0
	System.Void <OnUpdateTeamMemberDisplay>b__0(SimpleJSON.JSONNode node); // 0x05a0a908
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass203_0 : System.Object
{
	System.String roleId; // 0x10
	System.Void .ctor(); // 0x05a0a9d4
	System.Boolean <RefreshTeammateSpeaker>b__0(WizardGames.Soc.SocClient.Manager.LobbyTeamMemberData obj); // 0x05a0aa3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass49_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x10
	System.Boolean isAppointment; // 0x18
	System.Void .ctor(); // 0x05a0ab08
	System.Void <CheckTeamData>b__0(SimpleJSON.JSONNode ret); // 0x05a0ab70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass53_0 : System.Object
{
	WizardGames.Soc.Common.Data.Play.OBJGameMode config; // 0x10
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x18
	System.Boolean isAppointment; // 0x20
	System.Int32 modeID; // 0x24
	System.Void .ctor(); // 0x05a0ae74
	System.Void <CheckNeedDepartureTips>b__0(WizardGames.Soc.SocClient.Ui.UiTeamDepartureTips win); // 0x05a0aedc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass65_0 : System.Object
{
	System.String roleID; // 0x10
	System.Void .ctor(); // 0x05a0af98
	System.Boolean <OnTeamMemberReady>b__0(WizardGames.Soc.SocClient.Manager.LobbyTeamMemberData x); // 0x05a0b000
	System.Boolean <OnTeamMemberReady>b__1(WizardGames.Soc.SocClient.Manager.LobbyTeamMemberData x); // 0x05a0b0cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass69_0 : System.Object
{
	System.String roleId; // 0x10
	System.Void .ctor(); // 0x05a0b198
	System.Boolean <GetReadyByRoleId>b__0(WizardGames.Soc.SocClient.Manager.LobbyTeamMemberData x); // 0x05a0b200
	System.Boolean <GetReadyByRoleId>b__1(WizardGames.Soc.SocClient.Manager.LobbyTeamMemberData x); // 0x05a0b2cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass70_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x10
	System.Int32 selectModeId; // 0x18
	System.Void .ctor(); // 0x05a0b398
	System.Void <OpenUiHistoryBattle>b__0(); // 0x05a0b400
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass71_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x10
	System.Action callback; // 0x18
	System.String battleServerId; // 0x20
	System.Void .ctor(); // 0x05a0b50c
	System.Void <OpenUiHistoryBattleByBattleServerId>b__0(); // 0x05a0b574
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass88_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo lobbyTeamInviteData; // 0x10
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x18
	System.Void .ctor(); // 0x05a0b694
	System.Void <SettleNewbieBattle>b__0(Config.LobbyRoleInfo userInfo); // 0x05a0b6fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass88_1 : System.Object
{
	Config.LobbyRoleInfo userInfo; // 0x10
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass88_0 CS$<>8__locals1; // 0x18
	System.Action<SimpleJSON.JSONNode> <>9__3; // 0x20
	System.Void .ctor(); // 0x05a0bcc8
	System.Void <SettleNewbieBattle>b__2(); // 0x05a0bd30
	System.Void <SettleNewbieBattle>b__3(SimpleJSON.JSONNode jsonNode); // 0x05a0be44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass89_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo lobbyTeamInviteData; // 0x10
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x18
	System.Action callback; // 0x20
	System.Action <>9__6; // 0x28
	System.Action <>9__5; // 0x30
	System.Void .ctor(); // 0x05a0bf9c
	System.Void <OnHandleFromLobbyInvite>b__0(SimpleJSON.JSONNode jsonNode); // 0x05a0c004
	System.Void <OnHandleFromLobbyInvite>b__1(Config.LobbyRoleInfo userInfo); // 0x05a0c0f8
	System.Void <OnHandleFromLobbyInvite>b__5(); // 0x05a0c728
	System.Void <OnHandleFromLobbyInvite>b__6(); // 0x05a0c840
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass89_1 : System.Object
{
	Config.LobbyRoleInfo userInfo; // 0x10
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass89_0 CS$<>8__locals1; // 0x18
	System.Action<SimpleJSON.JSONNode> <>9__4; // 0x20
	System.Action<SimpleJSON.JSONNode> <>9__7; // 0x28
	System.Void .ctor(); // 0x05a0c6c0
	System.Void <OnHandleFromLobbyInvite>b__2(); // 0x05a0c910
	System.Void <OnHandleFromLobbyInvite>b__4(SimpleJSON.JSONNode jsonNode); // 0x05a0ca24
	System.Void <OnHandleFromLobbyInvite>b__3(); // 0x05a0cce4
	System.Void <OnHandleFromLobbyInvite>b__7(SimpleJSON.JSONNode jsonNode); // 0x05a0cdf8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass90_0 : System.Object
{
	WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule; // 0x10
	System.String jumpServerId; // 0x18
	System.Action callback; // 0x20
	System.Action <>9__1; // 0x28
	System.Void .ctor(); // 0x05a0cf30
	System.Void <OnHandleJumpBattle>b__0(); // 0x05a0cf98
	System.Void <OnHandleJumpBattle>b__1(); // 0x05a0d0b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass91_0 : System.Object
{
	System.Action callback; // 0x10
	System.Action <>9__1; // 0x18
	System.Void .ctor(); // 0x05a0d1a0
	System.Void <OnHanldeJumpLobby>b__0(); // 0x05a0d208
	System.Void <OnHanldeJumpLobby>b__1(); // 0x05a0d320
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass93_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo lobbyTeamInviteData; // 0x18
	System.Action callback; // 0x20
	System.String modeName; // 0x28
	System.String gameServerName; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> btns; // 0x38
	System.Void .ctor(); // 0x05a0d3f0
	System.Void <HandleInviteInLobby>b__1(); // 0x05a0d458
	System.Void <HandleInviteInLobby>b__2(); // 0x05a0d4d0
	System.Void <HandleInviteInLobby>b__0(Config.LobbyRoleInfo userInfo); // 0x05a0d548
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass94_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo lobbyTeamInviteData; // 0x18
	System.Action callback; // 0x20
	System.String modeName; // 0x28
	System.Void .ctor(); // 0x05a0d6d4
	System.Void <HandleInviteInBattle>b__1(); // 0x05a0d73c
	System.Void <HandleInviteInBattle>b__2(); // 0x05a0d7b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass94_1 : System.Object
{
	System.String gameServerName; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> btns; // 0x18
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass94_0 CS$<>8__locals1; // 0x20
	System.Void .ctor(); // 0x05a0d82c
	System.Void <HandleInviteInBattle>b__0(Config.LobbyRoleInfo userInfo); // 0x05a0d894
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass95_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo lobbyTeamInviteData; // 0x18
	System.Boolean jumpToGame; // 0x20
	System.Action callback; // 0x28
	System.Void .ctor(); // 0x05a0da2c
	System.Void <AcceptInvite>b__0(SimpleJSON.JSONNode jsonNode); // 0x05a0da94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrLobbyTeam.<>c__DisplayClass96_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo lobbyTeamInviteData; // 0x10
	WizardGames.Soc.SocClient.Ui.MgrLobbyTeam <>4__this; // 0x18
	System.Action <>9__1; // 0x20
	System.Void .ctor(); // 0x05a0dcc4
	System.Void <HandleSuccessInvite>b__0(); // 0x05a0dd2c
	System.Void <HandleSuccessInvite>b__1(); // 0x05a0de44
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType None = 0;
	static WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType Team = 1;
	static WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType AppointmentTeam = 2;
	static WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType TeamAndAppointmentTeam = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMail : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger log; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMail.RootLobbyMailContentBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.Mail.UiMailContentPanel mailContentPanel; // 0x340
	System.String selectedMailId; // 0x348
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Mail.Core.MailInfo> mailInfos; // 0x350
	WizardGames.Soc.SocClient.Mail.Core.EMailSource curMailSource; // 0x358
	WizardGames.Soc.SocClient.Ui.ComRedDot lobbyMailRedDot; // 0x360
	WizardGames.Soc.SocClient.Ui.ComRedDot gameMailRedDot; // 0x368
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x370
	MailNavBar navBar; // 0x378
	System.Int64 lastClickBtnTime; // 0x380
	System.Void OnInit(); // 0x05a0df50
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05a0ec98
	System.Void OnEnable(); // 0x05a0ed18
	System.Void OnDisable(); // 0x05a0f568
	System.Void InitTab(); // 0x05a0e55c
	System.Void SetDefaultTab(); // 0x05a0efb0
	System.Void InitMailList(); // 0x05a0ea80
	System.Void ResetMailInfos(); // 0x05a0f488
	System.Void RefreshRedDot(); // 0x05a0fed0
	System.Void RefreshMailList(); // 0x05a0f888
	System.Void RenderListMailItem(System.Int32 index, FairyGUI.GObject obj); // 0x05a103bc
	System.Void OnMailItemClick(FairyGUI.EventContext context); // 0x05a10950
	System.Void SelectMail(System.String id); // 0x05a0ffec
	System.Void MailContentFetchDoneCallback(System.String id); // 0x05a10c48
	System.Void OnReadAllClick(); // 0x05a10d04
	System.Void OnDeleteAllHaveReadClick(); // 0x05a11054
	System.Void OnReceiveAllClick(); // 0x05a1165c
	System.Void .ctor(); // 0x05a11880
	static System.Void .cctor(); // 0x05a11958
	System.Void <InitTab>b__15_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x05a11a2c
	System.Void <OnDeleteAllHaveReadClick>b__26_0(); // 0x05a11b50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrQuickActBubble : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.MgrQuickActBubble.CheckObj> checkObjs; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.MgrQuickActBubble.CheckObj> triggerObjs; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemNums; // 0x28
	System.Single showBubbleTime; // 0x30
	System.Int64 CurrentShowItem; // 0x38
	System.Void Init(); // 0x05a11cb8
	System.Func<System.Single> CreateGetterByType(WizardGames.Soc.Common.Data.TipsBubbleType bubbleType); // 0x05a12080
	System.Void OnTipsBubbleEnd(); // 0x05a1249c
	System.Boolean CheckShowBubbleTimer(System.Int32 deltaTime); // 0x05a126bc
	System.Void CheckAndSetCurShowItem(); // 0x05a12764
	System.Void OnFps2Update(System.Int32 deltaTime); // 0x05a12b70
	System.Void OnItemUseFinished(); // 0x05a12f70
	System.Void .ctor(); // 0x05a12fd4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrQuickActBubble.CheckObj : System.Object
{
	System.Int32 startCheckTimer; // 0x10
	System.Func<System.Single> getVal; // 0x18
	WizardGames.Soc.Common.Data.tips.TipsBubble Cfg; // 0x20
	System.Int32 get_ShowTimeMs(); // 0x05a12af8
	System.Int32 get_IntervalMs(); // 0x05a13118
	System.Void .ctor(WizardGames.Soc.Common.Data.tips.TipsBubble cfg, System.Func<System.Single> getter); // 0x05a123f0
	System.Void Reset(); // 0x05a12650
	System.Boolean DoCheck(System.Int32 ms); // 0x05a12e90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrQuickActBubble.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.MgrQuickActBubble.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.MgrQuickActBubble.CheckObj> <>9__6_0; // 0x8
	static System.Func<System.Single> <>9__7_0; // 0x10
	static System.Func<System.Single> <>9__7_1; // 0x18
	static System.Func<System.Single> <>9__7_2; // 0x20
	static System.Func<System.Single> <>9__7_3; // 0x28
	static System.Func<System.Single> <>9__7_4; // 0x30
	static System.Void .cctor(); // 0x05a13190
	System.Void .ctor(); // 0x05a131f4
	System.Int32 <Init>b__6_0(WizardGames.Soc.SocClient.Ui.MgrQuickActBubble.CheckObj a, WizardGames.Soc.SocClient.Ui.MgrQuickActBubble.CheckObj b); // 0x05a1325c
	System.Single <CreateGetterByType>b__7_0(); // 0x05a13300
	System.Single <CreateGetterByType>b__7_1(); // 0x05a133f0
	System.Single <CreateGetterByType>b__7_2(); // 0x05a134e0
	System.Single <CreateGetterByType>b__7_3(); // 0x05a135d0
	System.Single <CreateGetterByType>b__7_4(); // 0x05a136c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrReportEvent : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	static AttributionData attributionData; // 0x8
	static System.String userAgent; // 0x10
	System.Boolean isLogined; // 0x11
	System.Int32 lastCheckTime; // 0x14
	System.Int32 onlineDurationSeconds; // 0x18
	System.Int32 <BatchCloseCount>k__BackingField; // 0x1c
	System.Int32 <CurrBatchCloseCount>k__BackingField; // 0x20
	System.Collections.Generic.List<System.String> uiStack; // 0x28
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Manager.UiReportEventData> uiReportEvents; // 0x30
	System.Void Init(); // 0x05a137b0
	System.Void Destroy(); // 0x05a13930
	System.Void OnAccountLogined(); // 0x05a13ab0
	System.Void OnAccountLogout(); // 0x05a13d7c
	System.Void OnFps1UpdateUI(System.Single dt); // 0x05a13dec
	static System.Int32 PlatId(); // 0x05a14708
	System.Int32 InstallChannel(); // 0x05a14764
	static System.String AppId(); // 0x05a147f4
	System.String GetOAID(); // 0x05a1493c
	System.String GetCAIDSync(); // 0x05a14a00
	System.String GetOldCAID(); // 0x05a14a80
	System.Void OnReportPlayerLoginDataRunEnd(System.String data); // 0x05a14b00
	System.Void ReportPlayerLoginData(); // 0x05a13cac
	System.Int32 get_BatchCloseCount(); // 0x05a14bbc
	System.Void set_BatchCloseCount(System.Int32 value); // 0x05a14c20
	System.Int32 get_CurrBatchCloseCount(); // 0x05a14c98
	System.Void set_CurrBatchCloseCount(System.Int32 value); // 0x05a14cfc
	System.Void PushUi(System.String uiName); // 0x05a14d74
	System.Void PopUi(); // 0x05a14e90
	System.String get_LastUiName(); // 0x05a14fd4
	System.Void RecordUiInfo(System.String uiName, WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType triggerType, WizardGames.Soc.SocClient.Manager.EUiJumpSource jumpSource); // 0x05a15098
	System.Void ReportUiOpen(System.String uiName, System.Boolean ignoreReport); // 0x05a1523c
	System.Void ReportUiClose(System.String uiName, System.Boolean ignoreReport); // 0x05a153d8
	System.Void OnLobbyPlayerInfoInited(); // 0x05a157ac
	SimpleJSON.JSONObject QQReportBaseData(System.String roleName); // 0x05a15bfc
	System.Void QQReportSendData(SimpleJSON.JSONObject reportData); // 0x05a16520
	System.Void QQReportUpdateLogin(); // 0x05a15810
	System.Void QQReportRegister(System.String firstName); // 0x05a16a00
	System.Void QQReportRoleLevel(System.Int32 roleLevel); // 0x05a16e98
	System.Void QQReportCharge(System.Int32 amount); // 0x05a171d0
	System.Void QQReportOnlineDuration(); // 0x05a1439c
	System.Void .ctor(); // 0x05a17650
	static System.Void .cctor(); // 0x05a1775c
	System.Void <ReportPlayerLoginData>b__30_0(); // 0x05a178d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrReportEvent.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.MgrReportEvent.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__51_0; // 0x8
	static System.Action<SimpleJSON.JSONNode> <>9__51_1; // 0x10
	static System.Void .cctor(); // 0x05a17f40
	System.Void .ctor(); // 0x05a17fa4
	System.Void <QQReportSendData>b__51_0(SimpleJSON.JSONNode res); // 0x05a1800c
	System.Void <QQReportSendData>b__51_1(SimpleJSON.JSONNode err); // 0x05a18190
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrUiModel : WizardGames.Soc.Common.Manager.MgrBase
{
	SocLogger Log; // 0x18
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.MgrUiModel.ModelType,System.String> typeToPrefabPath; // 0x20
	UnityEngine.Transform transStageRoot; // 0x28
	System.Collections.Generic.Dictionary<FairyGUI.GLoader,WizardGames.Soc.SocClient.Ui.MgrUiModel.RegisterInfo> loaderInfos; // 0x30
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.MgrUiModel.ModelType,WizardGames.Soc.SocClient.Ui.MgrUiModel.StageInfo> stageInfoCache; // 0x38
	UnityEngine.RenderTexture rtForModel; // 0x40
	FairyGUI.NTexture ntForModel; // 0x48
	FairyGUI.NTexture myPlayerHomepageNTForModel; // 0x50
	UnityEngine.RenderTexture myPlayerHomepageRTForModel; // 0x58
	System.Boolean useLoaderSize; // 0x60
	UnityEngine.RenderTexture rtFormLoaderSize; // 0x68
	FairyGUI.NTexture ntFormLoaderSize; // 0x70
	System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Collections.Generic.Dictionary<UnityEngine.Renderer,WizardGames.Soc.SocClient.Ui.MgrUiModel.RendererInfo>> rendererInfos; // 0x78
	System.Int32 RTWidth; // 0x80
	System.Int32 RTHeight; // 0x84
	System.Int32 get_rtReferenceCount(); // 0x05a18314
	System.Int32 get_myPlayerHomepageRTReferenceCount(); // 0x05a18448
	System.Void Init(); // 0x05a1857c
	System.Void CreateRT(); // 0x05a185e4
	System.Void CreatePlayerHomepageRT(System.Int32 width, System.Int32 height); // 0x05a187d8
	System.Void CreateFormLoader(System.Int32 width, System.Int32 height); // 0x05a189b0
	System.Void DisposeRT(); // 0x05a18bb8
	System.Void DisposeMyPlayerHomepageRT(); // 0x05a18c98
	System.Void DisPoseFpPlayerRT(); // 0x05a18d78
	System.Void DisposeAllRT(); // 0x05a18e58
	WizardGames.Soc.SocClient.Ui.MgrUiModel.StageInfo RegisterLoader(FairyGUI.GLoader loader, WizardGames.Soc.SocClient.Ui.MgrUiModel.ModelType type, System.Action onRemove); // 0x05a18ecc
	System.Void UnregisterLoader(FairyGUI.GLoader loader); // 0x05a193e0
	System.Void ReleaseGo(WizardGames.Soc.SocClient.Ui.MgrUiModel.ModelType type); // 0x05a19744
	System.Void ReleaseLoader(FairyGUI.GLoader loader); // 0x05a19614
	System.Void CleanUp(); // 0x05a19908
	System.Threading.Tasks.Task OnEnterWorld(); // 0x05a19cf8
	System.Void Show(FairyGUI.GLoader loader, UnityEngine.RenderTexture ownerRt, FairyGUI.NTexture ownerNt, System.Boolean isUseLoaderSize); // 0x05a19d70
	System.Void Hide(FairyGUI.GLoader loader); // 0x05a1a2dc
	System.Void ReleaseAssets(); // 0x05a19a40
	System.Void SetGoLayer(UnityEngine.GameObject go, System.Int32 layer, System.UInt32 renderingLayer, System.Boolean includeInactive); // 0x05a1a668
	System.Void ResetGoLayer(UnityEngine.GameObject go, System.Boolean includeInactive); // 0x05a1aa0c
	System.Int32 GetShouldUseModelSex(System.Int32 equipGender); // 0x05a1ad1c
	System.Int32 GetPresentUserSex(); // 0x05a1adb0
	System.Void .ctor(); // 0x05a1ae94
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.MgrUiModel.RendererInfo : System.ValueType
{
	System.Int32 layer; // 0x10
	System.UInt32 renderingLayer; // 0x14
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.MgrUiModel.ModelType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.MgrUiModel.ModelType Item = 0;
	static WizardGames.Soc.SocClient.Ui.MgrUiModel.ModelType LobbyItem = 1;
	static WizardGames.Soc.SocClient.Ui.MgrUiModel.ModelType PlayerHomepage = 2;
	static WizardGames.Soc.SocClient.Ui.MgrUiModel.ModelType None = 1000;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrUiModel.StageInfo : System.Object
{
	UnityEngine.GameObject objStage; // 0x10
	UnityEngine.Camera camera; // 0x18
	UnityEngine.Vector3 cameraRawPos; // 0x20
	UnityEngine.Quaternion cameraRawRot; // 0x2c
	UnityEngine.GameObject objModelHolder; // 0x40
	FairyGUI.GLoader curShowLoader; // 0x48
	System.Void Reset(); // 0x05a1b220
	System.Void .ctor(); // 0x05a19378
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.MgrUiModel.RegisterInfo : System.ValueType
{
	WizardGames.Soc.SocClient.Ui.MgrUiModel.ModelType type; // 0x10
	System.Action onRemove; // 0x18
	System.Boolean isShow; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrUiModel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.MgrUiModel.<>c <>9; // 0x0
	static System.Func<System.Collections.Generic.KeyValuePair<FairyGUI.GLoader,WizardGames.Soc.SocClient.Ui.MgrUiModel.RegisterInfo>,System.Boolean> <>9__9_0; // 0x8
	static System.Func<System.Collections.Generic.KeyValuePair<FairyGUI.GLoader,WizardGames.Soc.SocClient.Ui.MgrUiModel.RegisterInfo>,System.Boolean> <>9__11_0; // 0x10
	static System.Void .cctor(); // 0x05a1b35c
	System.Void .ctor(); // 0x05a1b3c0
	System.Boolean <get_rtReferenceCount>b__9_0(System.Collections.Generic.KeyValuePair<FairyGUI.GLoader,WizardGames.Soc.SocClient.Ui.MgrUiModel.RegisterInfo> e); // 0x05a1b428
	System.Boolean <get_myPlayerHomepageRTReferenceCount>b__11_0(System.Collections.Generic.KeyValuePair<FairyGUI.GLoader,WizardGames.Soc.SocClient.Ui.MgrUiModel.RegisterInfo> e); // 0x05a1b4c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTableElementCreator : System.Object
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.SocClient.Ui.UiTableElementCreator Instance; // 0x8
	System.Collections.Generic.Dictionary<System.String,System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase>> typeToWindowCreatorMap; // 0x10
	System.Collections.Generic.Dictionary<System.String,System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem>> typeToHudCreatorMap; // 0x18
	static System.Void Init(); // 0x05a1b558
	static System.Void CreateTypeToCreatorMap(System.Collections.Generic.Dictionary<System.String,System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase>>& typeToWindowCreatorMap, System.Collections.Generic.Dictionary<System.String,System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem>>& typeToHudCreatorMap); // 0x05a1b708
	static System.Boolean HasWindow(System.String typeName); // 0x05a31a08
	static System.Boolean HasHudElem(System.String typeName); // 0x05a31ac4
	static WizardGames.Soc.Common.Unity.Ui.WindowComBase CreateWindow(System.String typeName); // 0x05a31b80
	static WizardGames.Soc.Common.Unity.Ui.UiEditableElem CreateHudElem(System.String typeName); // 0x05a31c78
	System.Void .ctor(); // 0x05a1b6a0
	static System.Void .cctor(); // 0x05a31d70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTableElementCreator.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTableElementCreator.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_0; // 0x8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_1; // 0x10
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_2; // 0x18
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_3; // 0x20
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_4; // 0x28
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_5; // 0x30
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_6; // 0x38
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_7; // 0x40
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_8; // 0x48
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_9; // 0x50
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_10; // 0x58
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_11; // 0x60
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_12; // 0x68
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_13; // 0x70
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_14; // 0x78
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_15; // 0x80
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_16; // 0x88
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_17; // 0x90
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_18; // 0x98
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_19; // 0xa0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_20; // 0xa8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_21; // 0xb0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_22; // 0xb8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_23; // 0xc0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_24; // 0xc8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_25; // 0xd0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_26; // 0xd8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_27; // 0xe0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_28; // 0xe8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_29; // 0xf0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_30; // 0xf8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_31; // 0x100
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_32; // 0x108
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_33; // 0x110
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_34; // 0x118
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_35; // 0x120
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_36; // 0x128
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_37; // 0x130
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_38; // 0x138
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_39; // 0x140
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_40; // 0x148
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_41; // 0x150
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_42; // 0x158
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_43; // 0x160
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_44; // 0x168
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_45; // 0x170
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_46; // 0x178
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_47; // 0x180
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_48; // 0x188
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_49; // 0x190
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_50; // 0x198
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_51; // 0x1a0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_52; // 0x1a8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_53; // 0x1b0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_54; // 0x1b8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_55; // 0x1c0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_56; // 0x1c8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_57; // 0x1d0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_58; // 0x1d8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_59; // 0x1e0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_60; // 0x1e8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_61; // 0x1f0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_62; // 0x1f8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_63; // 0x200
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_64; // 0x208
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_65; // 0x210
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_66; // 0x218
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_67; // 0x220
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_68; // 0x228
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_69; // 0x230
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_70; // 0x238
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_71; // 0x240
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_72; // 0x248
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_73; // 0x250
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_74; // 0x258
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_75; // 0x260
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_76; // 0x268
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_77; // 0x270
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_78; // 0x278
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_79; // 0x280
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_80; // 0x288
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_81; // 0x290
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_82; // 0x298
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_83; // 0x2a0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_84; // 0x2a8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_85; // 0x2b0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_86; // 0x2b8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_87; // 0x2c0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_88; // 0x2c8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_89; // 0x2d0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_90; // 0x2d8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_91; // 0x2e0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_92; // 0x2e8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_93; // 0x2f0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_94; // 0x2f8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_95; // 0x300
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_96; // 0x308
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_97; // 0x310
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_98; // 0x318
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_99; // 0x320
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_100; // 0x328
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_101; // 0x330
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_102; // 0x338
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_103; // 0x340
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_104; // 0x348
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_105; // 0x350
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_106; // 0x358
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_107; // 0x360
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_108; // 0x368
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_109; // 0x370
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_110; // 0x378
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_111; // 0x380
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_112; // 0x388
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_113; // 0x390
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_114; // 0x398
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_115; // 0x3a0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_116; // 0x3a8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_117; // 0x3b0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_118; // 0x3b8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_119; // 0x3c0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_120; // 0x3c8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_121; // 0x3d0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_122; // 0x3d8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_123; // 0x3e0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_124; // 0x3e8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_125; // 0x3f0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_126; // 0x3f8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_127; // 0x400
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_128; // 0x408
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_129; // 0x410
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_130; // 0x418
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_131; // 0x420
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_132; // 0x428
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_133; // 0x430
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_134; // 0x438
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_135; // 0x440
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_136; // 0x448
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_137; // 0x450
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_138; // 0x458
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_139; // 0x460
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_140; // 0x468
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_141; // 0x470
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_142; // 0x478
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_143; // 0x480
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_144; // 0x488
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_145; // 0x490
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_146; // 0x498
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_147; // 0x4a0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_148; // 0x4a8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_149; // 0x4b0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_150; // 0x4b8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_151; // 0x4c0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_152; // 0x4c8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_153; // 0x4d0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_154; // 0x4d8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_155; // 0x4e0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_156; // 0x4e8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_157; // 0x4f0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_158; // 0x4f8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_159; // 0x500
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_160; // 0x508
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_161; // 0x510
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_162; // 0x518
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_163; // 0x520
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_164; // 0x528
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_165; // 0x530
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_166; // 0x538
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_167; // 0x540
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_168; // 0x548
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_169; // 0x550
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_170; // 0x558
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_171; // 0x560
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_172; // 0x568
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_173; // 0x570
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_174; // 0x578
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_175; // 0x580
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_176; // 0x588
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_177; // 0x590
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_178; // 0x598
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_179; // 0x5a0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_180; // 0x5a8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_181; // 0x5b0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_182; // 0x5b8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_183; // 0x5c0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_184; // 0x5c8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_185; // 0x5d0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_186; // 0x5d8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_187; // 0x5e0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_188; // 0x5e8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_189; // 0x5f0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_190; // 0x5f8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_191; // 0x600
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_192; // 0x608
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_193; // 0x610
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_194; // 0x618
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_195; // 0x620
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_196; // 0x628
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_197; // 0x630
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_198; // 0x638
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_199; // 0x640
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_200; // 0x648
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_201; // 0x650
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_202; // 0x658
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_203; // 0x660
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_204; // 0x668
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_205; // 0x670
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_206; // 0x678
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_207; // 0x680
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_208; // 0x688
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_209; // 0x690
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_210; // 0x698
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_211; // 0x6a0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_212; // 0x6a8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_213; // 0x6b0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_214; // 0x6b8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_215; // 0x6c0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_216; // 0x6c8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_217; // 0x6d0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_218; // 0x6d8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_219; // 0x6e0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_220; // 0x6e8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_221; // 0x6f0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_222; // 0x6f8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_223; // 0x700
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_224; // 0x708
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_225; // 0x710
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_226; // 0x718
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_227; // 0x720
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_228; // 0x728
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_229; // 0x730
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_230; // 0x738
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_231; // 0x740
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_232; // 0x748
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_233; // 0x750
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_234; // 0x758
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_235; // 0x760
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_236; // 0x768
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_237; // 0x770
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_238; // 0x778
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_239; // 0x780
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_240; // 0x788
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_241; // 0x790
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_242; // 0x798
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_243; // 0x7a0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_244; // 0x7a8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_245; // 0x7b0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_246; // 0x7b8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_247; // 0x7c0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_248; // 0x7c8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_249; // 0x7d0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_250; // 0x7d8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_251; // 0x7e0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_252; // 0x7e8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_253; // 0x7f0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_254; // 0x7f8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_255; // 0x800
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_256; // 0x808
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_257; // 0x810
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_258; // 0x818
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_259; // 0x820
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_260; // 0x828
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_261; // 0x830
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_262; // 0x838
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_263; // 0x840
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_264; // 0x848
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_265; // 0x850
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_266; // 0x858
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_267; // 0x860
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_268; // 0x868
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_269; // 0x870
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_270; // 0x878
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_271; // 0x880
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_272; // 0x888
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_273; // 0x890
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_274; // 0x898
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_275; // 0x8a0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_276; // 0x8a8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_277; // 0x8b0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_278; // 0x8b8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_279; // 0x8c0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_280; // 0x8c8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_281; // 0x8d0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_282; // 0x8d8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_283; // 0x8e0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_284; // 0x8e8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_285; // 0x8f0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_286; // 0x8f8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_287; // 0x900
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_288; // 0x908
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_289; // 0x910
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_290; // 0x918
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_291; // 0x920
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_292; // 0x928
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_293; // 0x930
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_294; // 0x938
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_295; // 0x940
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_296; // 0x948
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_297; // 0x950
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_298; // 0x958
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_299; // 0x960
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_300; // 0x968
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_301; // 0x970
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_302; // 0x978
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_303; // 0x980
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_304; // 0x988
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_305; // 0x990
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_306; // 0x998
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_307; // 0x9a0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_308; // 0x9a8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_309; // 0x9b0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_310; // 0x9b8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_311; // 0x9c0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_312; // 0x9c8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_313; // 0x9d0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_314; // 0x9d8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_315; // 0x9e0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_316; // 0x9e8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_317; // 0x9f0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_318; // 0x9f8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_319; // 0xa00
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_320; // 0xa08
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_321; // 0xa10
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_322; // 0xa18
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_323; // 0xa20
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_324; // 0xa28
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_325; // 0xa30
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_326; // 0xa38
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_327; // 0xa40
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_328; // 0xa48
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_329; // 0xa50
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_330; // 0xa58
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_331; // 0xa60
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_332; // 0xa68
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_333; // 0xa70
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_334; // 0xa78
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_335; // 0xa80
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_336; // 0xa88
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_337; // 0xa90
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_338; // 0xa98
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_339; // 0xaa0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_340; // 0xaa8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_341; // 0xab0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_342; // 0xab8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_343; // 0xac0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_344; // 0xac8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_345; // 0xad0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_346; // 0xad8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_347; // 0xae0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_348; // 0xae8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_349; // 0xaf0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_350; // 0xaf8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_351; // 0xb00
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_352; // 0xb08
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_353; // 0xb10
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_354; // 0xb18
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_355; // 0xb20
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_356; // 0xb28
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_357; // 0xb30
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_358; // 0xb38
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_359; // 0xb40
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_360; // 0xb48
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_361; // 0xb50
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_362; // 0xb58
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_363; // 0xb60
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_364; // 0xb68
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_365; // 0xb70
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_366; // 0xb78
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_367; // 0xb80
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_368; // 0xb88
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_369; // 0xb90
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_370; // 0xb98
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_371; // 0xba0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_372; // 0xba8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_373; // 0xbb0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_374; // 0xbb8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_375; // 0xbc0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_376; // 0xbc8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_377; // 0xbd0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_378; // 0xbd8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_379; // 0xbe0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_380; // 0xbe8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__5_381; // 0xbf0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_382; // 0xbf8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_383; // 0xc00
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_384; // 0xc08
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_385; // 0xc10
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_386; // 0xc18
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_387; // 0xc20
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_388; // 0xc28
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_389; // 0xc30
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_390; // 0xc38
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_391; // 0xc40
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_392; // 0xc48
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_393; // 0xc50
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_394; // 0xc58
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_395; // 0xc60
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_396; // 0xc68
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_397; // 0xc70
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_398; // 0xc78
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_399; // 0xc80
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_400; // 0xc88
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_401; // 0xc90
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_402; // 0xc98
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_403; // 0xca0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_404; // 0xca8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_405; // 0xcb0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_406; // 0xcb8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_407; // 0xcc0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_408; // 0xcc8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_409; // 0xcd0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_410; // 0xcd8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_411; // 0xce0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_412; // 0xce8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_413; // 0xcf0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_414; // 0xcf8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_415; // 0xd00
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_416; // 0xd08
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_417; // 0xd10
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_418; // 0xd18
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_419; // 0xd20
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_420; // 0xd28
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_421; // 0xd30
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_422; // 0xd38
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_423; // 0xd40
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_424; // 0xd48
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_425; // 0xd50
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_426; // 0xd58
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_427; // 0xd60
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_428; // 0xd68
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_429; // 0xd70
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_430; // 0xd78
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_431; // 0xd80
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_432; // 0xd88
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_433; // 0xd90
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_434; // 0xd98
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_435; // 0xda0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_436; // 0xda8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_437; // 0xdb0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_438; // 0xdb8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_439; // 0xdc0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_440; // 0xdc8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_441; // 0xdd0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_442; // 0xdd8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_443; // 0xde0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_444; // 0xde8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_445; // 0xdf0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_446; // 0xdf8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_447; // 0xe00
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_448; // 0xe08
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_449; // 0xe10
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_450; // 0xe18
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_451; // 0xe20
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_452; // 0xe28
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_453; // 0xe30
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_454; // 0xe38
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_455; // 0xe40
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_456; // 0xe48
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_457; // 0xe50
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_458; // 0xe58
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_459; // 0xe60
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_460; // 0xe68
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_461; // 0xe70
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_462; // 0xe78
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_463; // 0xe80
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_464; // 0xe88
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_465; // 0xe90
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_466; // 0xe98
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_467; // 0xea0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_468; // 0xea8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_469; // 0xeb0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_470; // 0xeb8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_471; // 0xec0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_472; // 0xec8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_473; // 0xed0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_474; // 0xed8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_475; // 0xee0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_476; // 0xee8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_477; // 0xef0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_478; // 0xef8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_479; // 0xf00
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_480; // 0xf08
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__5_481; // 0xf10
	static System.Void .cctor(); // 0x05a31e44
	System.Void .ctor(); // 0x05a31ea8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_0(); // 0x05a31f10
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_1(); // 0x05a31f9c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_2(); // 0x05a323c4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_3(); // 0x05a32450
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_4(); // 0x05a324dc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_5(); // 0x05a32568
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_6(); // 0x05a325f4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_7(); // 0x05a32680
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_8(); // 0x05a3270c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_9(); // 0x05a32798
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_10(); // 0x05a32824
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_11(); // 0x05a328b0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_12(); // 0x05a3293c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_13(); // 0x05a329c8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_14(); // 0x05a32a54
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_15(); // 0x05a32ae0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_16(); // 0x05a32b6c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_17(); // 0x05a32bf8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_18(); // 0x05a32c84
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_19(); // 0x05a32d10
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_20(); // 0x05a32d9c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_21(); // 0x05a32e28
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_22(); // 0x05a32eb4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_23(); // 0x05a32f40
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_24(); // 0x05a32fcc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_25(); // 0x05a33058
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_26(); // 0x05a330e4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_27(); // 0x05a33170
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_28(); // 0x05a331fc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_29(); // 0x05a33288
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_30(); // 0x05a33314
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_31(); // 0x05a333a0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_32(); // 0x05a3342c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_33(); // 0x05a334b8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_34(); // 0x05a33544
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_35(); // 0x05a335d0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_36(); // 0x05a3365c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_37(); // 0x05a336e8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_38(); // 0x05a33774
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_39(); // 0x05a33800
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_40(); // 0x05a3388c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_41(); // 0x05a33918
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_42(); // 0x05a339a4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_43(); // 0x05a33a30
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_44(); // 0x05a33abc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_45(); // 0x05a33b48
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_46(); // 0x05a33bd4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_47(); // 0x05a33c60
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_48(); // 0x05a33cec
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_49(); // 0x05a33d78
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_50(); // 0x05a33e04
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_51(); // 0x05a33e90
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_52(); // 0x05a33f1c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_53(); // 0x05a33fa8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_54(); // 0x05a34034
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_55(); // 0x05a340c0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_56(); // 0x05a3414c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_57(); // 0x05a341d8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_58(); // 0x05a34264
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_59(); // 0x05a342f0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_60(); // 0x05a3437c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_61(); // 0x05a34408
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_62(); // 0x05a34494
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_63(); // 0x05a34520
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_64(); // 0x05a345ac
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_65(); // 0x05a34638
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_66(); // 0x05a346c4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_67(); // 0x05a34750
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_68(); // 0x05a347dc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_69(); // 0x05a34868
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_70(); // 0x05a348f4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_71(); // 0x05a34980
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_72(); // 0x05a34a0c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_73(); // 0x05a34a98
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_74(); // 0x05a34b24
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_75(); // 0x05a34bb0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_76(); // 0x05a34c3c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_77(); // 0x05a34cc8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_78(); // 0x05a34d54
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_79(); // 0x05a34de0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_80(); // 0x05a34e6c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_81(); // 0x05a34ef8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_82(); // 0x05a34f84
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_83(); // 0x05a35010
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_84(); // 0x05a3509c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_85(); // 0x05a35128
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_86(); // 0x05a351b4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_87(); // 0x05a35240
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_88(); // 0x05a352cc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_89(); // 0x05a35358
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_90(); // 0x05a353e4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_91(); // 0x05a35470
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_92(); // 0x05a354fc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_93(); // 0x05a35588
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_94(); // 0x05a35614
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_95(); // 0x05a356a0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_96(); // 0x05a3572c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_97(); // 0x05a357b8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_98(); // 0x05a35844
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_99(); // 0x05a358d0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_100(); // 0x05a3595c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_101(); // 0x05a359e8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_102(); // 0x05a35a74
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_103(); // 0x05a35b00
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_104(); // 0x05a35b8c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_105(); // 0x05a35c18
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_106(); // 0x05a35ca4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_107(); // 0x05a35d30
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_108(); // 0x05a35dbc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_109(); // 0x05a35e48
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_110(); // 0x05a35ed4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_111(); // 0x05a35f60
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_112(); // 0x05a35fec
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_113(); // 0x05a36078
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_114(); // 0x05a36104
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_115(); // 0x05a36190
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_116(); // 0x05a3621c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_117(); // 0x05a362a8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_118(); // 0x05a36334
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_119(); // 0x05a363c0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_120(); // 0x05a3644c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_121(); // 0x05a364d8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_122(); // 0x05a36564
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_123(); // 0x05a365f0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_124(); // 0x05a3667c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_125(); // 0x05a36708
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_126(); // 0x05a36794
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_127(); // 0x05a36820
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_128(); // 0x05a368ac
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_129(); // 0x05a36938
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_130(); // 0x05a369c4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_131(); // 0x05a36a50
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_132(); // 0x05a36adc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_133(); // 0x05a36b68
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_134(); // 0x05a36bf4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_135(); // 0x05a36c80
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_136(); // 0x05a36d0c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_137(); // 0x05a36d98
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_138(); // 0x05a36e24
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_139(); // 0x05a36eb0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_140(); // 0x05a36f3c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_141(); // 0x05a36fc8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_142(); // 0x05a37054
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_143(); // 0x05a370e0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_144(); // 0x05a3716c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_145(); // 0x05a371f8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_146(); // 0x05a37284
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_147(); // 0x05a37310
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_148(); // 0x05a3739c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_149(); // 0x05a37428
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_150(); // 0x05a374b4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_151(); // 0x05a37540
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_152(); // 0x05a375cc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_153(); // 0x05a37658
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_154(); // 0x05a376e4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_155(); // 0x05a37770
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_156(); // 0x05a377fc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_157(); // 0x05a37888
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_158(); // 0x05a37914
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_159(); // 0x05a379a0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_160(); // 0x05a37a2c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_161(); // 0x05a37ab8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_162(); // 0x05a37b44
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_163(); // 0x05a37bd0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_164(); // 0x05a37c5c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_165(); // 0x05a37ce8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_166(); // 0x05a37d74
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_167(); // 0x05a37e00
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_168(); // 0x05a37e8c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_169(); // 0x05a37f18
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_170(); // 0x05a37fa4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_171(); // 0x05a38030
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_172(); // 0x05a380bc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_173(); // 0x05a38148
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_174(); // 0x05a381d4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_175(); // 0x05a38260
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_176(); // 0x05a382ec
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_177(); // 0x05a38378
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_178(); // 0x05a38404
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_179(); // 0x05a38490
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_180(); // 0x05a3851c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_181(); // 0x05a385a8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_182(); // 0x05a38634
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_183(); // 0x05a386c0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_184(); // 0x05a3874c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_185(); // 0x05a387d8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_186(); // 0x05a38864
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_187(); // 0x05a388f0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_188(); // 0x05a3897c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_189(); // 0x05a38a08
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_190(); // 0x05a38a94
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_191(); // 0x05a38b20
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_192(); // 0x05a38bac
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_193(); // 0x05a38c38
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_194(); // 0x05a38cc4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_195(); // 0x05a38d50
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_196(); // 0x05a38ddc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_197(); // 0x05a38e68
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_198(); // 0x05a38ef4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_199(); // 0x05a38f80
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_200(); // 0x05a3900c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_201(); // 0x05a39098
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_202(); // 0x05a39124
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_203(); // 0x05a391b0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_204(); // 0x05a3923c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_205(); // 0x05a392c8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_206(); // 0x05a39354
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_207(); // 0x05a393e0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_208(); // 0x05a3946c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_209(); // 0x05a394f8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_210(); // 0x05a39584
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_211(); // 0x05a39610
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_212(); // 0x05a3969c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_213(); // 0x05a39728
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_214(); // 0x05a397b4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_215(); // 0x05a39840
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_216(); // 0x05a398cc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_217(); // 0x05a39958
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_218(); // 0x05a399e4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_219(); // 0x05a39a70
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_220(); // 0x05a39afc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_221(); // 0x05a39b88
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_222(); // 0x05a39c14
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_223(); // 0x05a39ca0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_224(); // 0x05a39d2c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_225(); // 0x05a39db8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_226(); // 0x05a39e44
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_227(); // 0x05a39ed0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_228(); // 0x05a39f5c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_229(); // 0x05a39fe8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_230(); // 0x05a3a074
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_231(); // 0x05a3a100
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_232(); // 0x05a3a18c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_233(); // 0x05a3a218
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_234(); // 0x05a3a2a4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_235(); // 0x05a3a330
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_236(); // 0x05a3a3bc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_237(); // 0x05a3a448
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_238(); // 0x05a3a4d4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_239(); // 0x05a3a560
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_240(); // 0x05a3a5ec
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_241(); // 0x05a3a678
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_242(); // 0x05a3a704
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_243(); // 0x05a3a790
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_244(); // 0x05a3a81c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_245(); // 0x05a3a8a8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_246(); // 0x05a3a934
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_247(); // 0x05a3a9c0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_248(); // 0x05a3aa4c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_249(); // 0x05a3aad8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_250(); // 0x05a3ab64
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_251(); // 0x05a3abf0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_252(); // 0x05a3ac7c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_253(); // 0x05a3ad08
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_254(); // 0x05a3ad94
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_255(); // 0x05a3ae20
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_256(); // 0x05a3aeac
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_257(); // 0x05a3af38
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_258(); // 0x05a3afc4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_259(); // 0x05a3b050
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_260(); // 0x05a3b0dc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_261(); // 0x05a3b168
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_262(); // 0x05a3b1f4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_263(); // 0x05a3b280
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_264(); // 0x05a3b30c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_265(); // 0x05a3b398
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_266(); // 0x05a3b424
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_267(); // 0x05a3b4b0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_268(); // 0x05a3b53c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_269(); // 0x05a3b5c8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_270(); // 0x05a3b654
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_271(); // 0x05a3b6e0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_272(); // 0x05a3b76c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_273(); // 0x05a3b7f8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_274(); // 0x05a3b884
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_275(); // 0x05a3b910
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_276(); // 0x05a3b99c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_277(); // 0x05a3ba28
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_278(); // 0x05a3bab4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_279(); // 0x05a3bb40
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_280(); // 0x05a3bbcc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_281(); // 0x05a3bc58
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_282(); // 0x05a3bce4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_283(); // 0x05a3bd70
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_284(); // 0x05a3bdfc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_285(); // 0x05a3be88
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_286(); // 0x05a3bf14
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_287(); // 0x05a3bfa0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_288(); // 0x05a3c02c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_289(); // 0x05a3c0b8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_290(); // 0x05a3c144
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_291(); // 0x05a3c1d0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_292(); // 0x05a3c25c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_293(); // 0x05a3c2e8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_294(); // 0x05a3c374
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_295(); // 0x05a3c400
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_296(); // 0x05a3c48c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_297(); // 0x05a3c518
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_298(); // 0x05a3c5a4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_299(); // 0x05a3c630
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_300(); // 0x05a3c6bc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_301(); // 0x05a3c748
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_302(); // 0x05a3c7d4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_303(); // 0x05a3c860
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_304(); // 0x05a3c8ec
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_305(); // 0x05a3c978
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_306(); // 0x05a3ca04
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_307(); // 0x05a3ca90
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_308(); // 0x05a3cb1c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_309(); // 0x05a3cba8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_310(); // 0x05a3cc34
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_311(); // 0x05a3ccc0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_312(); // 0x05a3cd4c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_313(); // 0x05a3cdd8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_314(); // 0x05a3ce64
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_315(); // 0x05a3cef0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_316(); // 0x05a3cf7c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_317(); // 0x05a3d008
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_318(); // 0x05a3d094
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_319(); // 0x05a3d120
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_320(); // 0x05a3d1ac
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_321(); // 0x05a3d238
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_322(); // 0x05a3d2c4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_323(); // 0x05a3d350
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_324(); // 0x05a3d3dc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_325(); // 0x05a3d468
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_326(); // 0x05a3d4f4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_327(); // 0x05a3d580
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_328(); // 0x05a3d60c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_329(); // 0x05a3d698
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_330(); // 0x05a3d724
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_331(); // 0x05a3d7b0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_332(); // 0x05a3d83c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_333(); // 0x05a3d8c8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_334(); // 0x05a3d954
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_335(); // 0x05a3d9e0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_336(); // 0x05a3da6c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_337(); // 0x05a3daf8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_338(); // 0x05a3db84
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_339(); // 0x05a3dc10
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_340(); // 0x05a3dc9c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_341(); // 0x05a3dd28
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_342(); // 0x05a3ddb4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_343(); // 0x05a3de40
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_344(); // 0x05a3decc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_345(); // 0x05a3df58
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_346(); // 0x05a3dfe4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_347(); // 0x05a3e070
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_348(); // 0x05a3e0fc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_349(); // 0x05a3e188
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_350(); // 0x05a3e214
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_351(); // 0x05a3e2a0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_352(); // 0x05a3e32c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_353(); // 0x05a3e3b8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_354(); // 0x05a3e444
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_355(); // 0x05a3e4d0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_356(); // 0x05a3e55c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_357(); // 0x05a3e5e8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_358(); // 0x05a3e674
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_359(); // 0x05a3e700
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_360(); // 0x05a3e78c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_361(); // 0x05a3e818
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_362(); // 0x05a3e8a4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_363(); // 0x05a3e930
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_364(); // 0x05a3e9bc
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_365(); // 0x05a3ea48
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_366(); // 0x05a3ead4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_367(); // 0x05a3eb60
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_368(); // 0x05a3ebec
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_369(); // 0x05a3ec78
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_370(); // 0x05a3ed04
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_371(); // 0x05a3ed90
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_372(); // 0x05a3ee1c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_373(); // 0x05a3eea8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_374(); // 0x05a3ef34
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_375(); // 0x05a3efc0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_376(); // 0x05a3f04c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_377(); // 0x05a3f0d8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_378(); // 0x05a3f164
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_379(); // 0x05a3f1f0
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_380(); // 0x05a3f27c
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <CreateTypeToCreatorMap>b__5_381(); // 0x05a3f308
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_382(); // 0x05a3f394
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_383(); // 0x05a3f420
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_384(); // 0x05a3f4ac
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_385(); // 0x05a3f538
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_386(); // 0x05a3f5c4
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_387(); // 0x05a3f650
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_388(); // 0x05a3f6dc
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_389(); // 0x05a3f768
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_390(); // 0x05a3f7f4
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_391(); // 0x05a3f880
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_392(); // 0x05a3f90c
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_393(); // 0x05a3f998
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_394(); // 0x05a3fa24
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_395(); // 0x05a3fab0
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_396(); // 0x05a3fb3c
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_397(); // 0x05a3fbc8
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_398(); // 0x05a3fc54
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_399(); // 0x05a3fce0
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_400(); // 0x05a3fd6c
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_401(); // 0x05a3fdf8
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_402(); // 0x05a3fe84
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_403(); // 0x05a3ff10
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_404(); // 0x05a3ff9c
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_405(); // 0x05a40028
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_406(); // 0x05a400b4
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_407(); // 0x05a40140
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_408(); // 0x05a401cc
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_409(); // 0x05a40258
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_410(); // 0x05a402e4
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_411(); // 0x05a40370
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_412(); // 0x05a403fc
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_413(); // 0x05a40488
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_414(); // 0x05a40514
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_415(); // 0x05a405a0
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_416(); // 0x05a4062c
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_417(); // 0x05a406b8
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_418(); // 0x05a40744
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_419(); // 0x05a407d0
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_420(); // 0x05a4085c
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_421(); // 0x05a408e8
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_422(); // 0x05a40974
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_423(); // 0x05a40a00
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_424(); // 0x05a40a8c
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_425(); // 0x05a40b18
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_426(); // 0x05a40ba4
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_427(); // 0x05a40c30
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_428(); // 0x05a40cbc
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_429(); // 0x05a40d48
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_430(); // 0x05a40dd4
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_431(); // 0x05a40e60
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_432(); // 0x05a40eec
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_433(); // 0x05a40f78
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_434(); // 0x05a41004
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_435(); // 0x05a41090
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_436(); // 0x05a4111c
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_437(); // 0x05a411a8
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_438(); // 0x05a41234
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_439(); // 0x05a412c0
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_440(); // 0x05a4134c
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_441(); // 0x05a413d8
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_442(); // 0x05a41464
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_443(); // 0x05a414f0
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_444(); // 0x05a4157c
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_445(); // 0x05a41608
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_446(); // 0x05a41694
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_447(); // 0x05a41720
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_448(); // 0x05a417ac
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_449(); // 0x05a41838
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_450(); // 0x05a418c4
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_451(); // 0x05a41950
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_452(); // 0x05a419dc
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_453(); // 0x05a41a68
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_454(); // 0x05a41af4
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_455(); // 0x05a41b80
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_456(); // 0x05a41c0c
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_457(); // 0x05a41c98
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_458(); // 0x05a41d24
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_459(); // 0x05a41db0
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_460(); // 0x05a41e3c
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_461(); // 0x05a41ec8
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_462(); // 0x05a41f54
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_463(); // 0x05a41fe0
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_464(); // 0x05a4206c
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_465(); // 0x05a420f8
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_466(); // 0x05a42184
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_467(); // 0x05a42210
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_468(); // 0x05a4229c
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_469(); // 0x05a42328
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_470(); // 0x05a423b4
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_471(); // 0x05a42440
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_472(); // 0x05a424cc
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_473(); // 0x05a42558
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_474(); // 0x05a425e4
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_475(); // 0x05a42670
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_476(); // 0x05a426fc
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_477(); // 0x05a42788
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_478(); // 0x05a42814
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_479(); // 0x05a428a0
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_480(); // 0x05a4292c
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CreateTypeToCreatorMap>b__5_481(); // 0x05a429b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimAnimMode : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AimAnimModeEnum> aimAnimModeEnumList; // 0x10
	System.Collections.Generic.List<System.Single> phaseTimeList; // 0x18
	System.Collections.Generic.List<System.Single> phaseDistanceList; // 0x20
	System.Collections.Generic.List<System.Single> phaseAlphaList; // 0x28
	System.Single progressTime; // 0x30
	System.Single totalTime; // 0x34
	System.Single progressMoving; // 0x38
	System.Single alpha; // 0x3c
	System.Single displacement; // 0x40
	System.Void .ctor(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AimAnimModeEnum> aimAnimModeEnumList, System.Collections.Generic.List<System.Single> phaseTimeList, System.Collections.Generic.List<System.Single> phaseDistanceList, System.Collections.Generic.List<System.Single> phaseAlphaList); // 0x05a42a44
	System.Single LinearMode(System.Single curTime, System.Single phaseTime, System.Single floorDistance, System.Single upperDistance); // 0x054a6054
	System.Single InverseMode(System.Single curTime, System.Single aimFloor, System.Single aimCeiling, System.Single inverseFloor, System.Single inverseCeiling); // 0x054a6094
	System.Void UpdateModeData(System.Collections.Generic.List<System.Single> phaseDistanceListNew); // 0x05a42ba4
	System.Single CalculateDisplacementOfMove(System.Boolean isMoving, System.Single deltaTime, System.Single expandTime, System.Single shrinkTime, System.Single offset); // 0x05a42c24
	System.Single CalculateDisplacementOfFire(System.Single deltaTime); // 0x05a42d2c
	System.Void PlayAimAnim(); // 0x05a42fec
	System.Boolean IsAimAnimPlaying(); // 0x05a4325c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimAnimModeCustom : WizardGames.Soc.SocClient.Ui.AimAnimMode
{
	
	System.Void .ctor(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AimAnimModeEnum> aimAnimModeEnumList, System.Collections.Generic.List<System.Single> phaseTimeList, System.Collections.Generic.List<System.Single> phaseDistanceList, System.Collections.Generic.List<System.Single> phaseAlphaList); // 0x05a432c8
	System.Single LinearMode(System.Single curTime, System.Single phaseTime, System.Single floorDistance, System.Single upperDistance); // 0x05a43374
	System.Single InverseMode(System.Single curTime, System.Single aimFloor, System.Single aimCeiling, System.Single inverseFloor, System.Single inverseCeiling); // 0x05a43434
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.AimAnimModeEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.AimAnimModeEnum None = 0;
	static WizardGames.Soc.SocClient.Ui.AimAnimModeEnum LinearMode = 1;
	static WizardGames.Soc.SocClient.Ui.AimAnimModeEnum InverseMode = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimAsset : System.Object
{
	FairyGUI.Transition aimHitTrans; // 0x10
	FairyGUI.Transition aimHeadShotTrans; // 0x18
	FairyGUI.Transition aimHitBuildingTrans; // 0x20
	FairyGUI.Transition aimBuildingHeadShotTrans; // 0x28
	FairyGUI.GComponent aim_x; // 0x30
	FairyGUI.GComponent mainPanel; // 0x38
	System.Collections.Generic.Dictionary<System.String,FairyGUI.GComponent> aimUiStyleDic; // 0x40
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,FairyGUI.GImage>> aimUiStyleImageDic; // 0x48
	WizardGames.Soc.SocClient.Ui.ComHarm ComHarm; // 0x50
	System.Void .ctor(); // 0x05a4352c
	System.Void Init(FairyGUI.GComponent ui); // 0x05a43638
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimConfig : System.Object
{
	UnityEngine.Color aimInitColor; // 0x10
	UnityEngine.Color aimChangedColor; // 0x20
	UnityEngine.Color aimHitColor; // 0x30
	UnityEngine.Color aimKillColor; // 0x40
	System.Single recoverColorTime; // 0x50
	System.Collections.Generic.List<System.Single> sizeOfAimNormalStyleList; // 0x58
	System.Collections.Generic.List<System.Single> phaseTimeOfAimNormalStyleList; // 0x60
	System.Collections.Generic.List<System.Single> sizeOfAimShotGunStyleList; // 0x68
	System.Collections.Generic.List<System.Single> phaseTimeOfAimShotGunStyleList; // 0x70
	System.Boolean runTimeSpreadControl; // 0x78
	System.Single angularSpeed; // 0x7c
	System.Collections.Generic.List<System.Single> get_PhaseTimeOfAimNormalStyleList(); // 0x05a4389c
	System.Collections.Generic.List<System.Single> get_PhaseTimeOfAimShotGunStyleList(); // 0x05a43900
	System.Boolean get_RunTimeSpreadControl(); // 0x05a43964
	System.Void .ctor(); // 0x05a439c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimData : System.Object
{
	WizardGames.Soc.SocClient.Ui.AimConfig aimConfig; // 0x10
	System.Int64 weaponId; // 0x18
	System.Boolean isMoving; // 0x20
	UnityEngine.Color curColor; // 0x24
	System.Single curSpread; // 0x34
	System.Single renderSpread; // 0x38
	System.Single AimAnimSpeed; // 0x3c
	UnityEngine.Vector2 aimScreenPosition; // 0x40
	WizardGames.Soc.SocClient.Ui.AimConfig get_AimConfig(); // 0x05a44398
	System.Boolean get_IsMoving(); // 0x05a443fc
	UnityEngine.Color get_CurColor(); // 0x05a44460
	System.Single get_CurSpread(); // 0x05a444c4
	System.Void set_CurSpread(System.Single value); // 0x05a44528
	System.Single get_RenderSpread(); // 0x05a445a0
	System.Void set_RenderSpread(System.Single value); // 0x05a44604
	System.Single get_HitAimOffsetAngle(); // 0x05a4467c
	System.Void .ctor(); // 0x05a447f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimAttackNewHeadshotStyle : WizardGames.Soc.SocClient.Ui.AimStyle
{
	
	System.Void Init(WizardGames.Soc.SocClient.Ui.AimData data, WizardGames.Soc.SocClient.Ui.AimAsset asset); // 0x05a448b0
	System.Void OnEnter(); // 0x05a44948
	System.Void OnExit(); // 0x05a449a8
	System.Void OnUpdate(System.Single dt); // 0x05a44a20
	System.Void ShowUI(); // 0x05a44a94
	System.Void HideUI(); // 0x05a45398
	System.Void ChangeColor(UnityEngine.Color color); // 0x05a455f4
	System.Void PlayAimAnim(); // 0x05a45718
	System.Void StopAimAnim(); // 0x05a4579c
	System.Boolean IsPlaying(); // 0x05a45820
	System.Void SetAimAnimMode(); // 0x05a458d4
	System.Void AimAnim(System.Single dt); // 0x05a45934
	System.Void .ctor(); // 0x05a459a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimAttackNewHitStyle : WizardGames.Soc.SocClient.Ui.AimStyle
{
	
	System.Void Init(WizardGames.Soc.SocClient.Ui.AimData data, WizardGames.Soc.SocClient.Ui.AimAsset asset); // 0x05a45a74
	System.Void OnEnter(); // 0x05a45b0c
	System.Void ShowUI(); // 0x05a45b6c
	System.Void HideUI(); // 0x05a45e3c
	System.Void OnExit(); // 0x05a45efc
	System.Void OnUpdate(System.Single dt); // 0x05a45f90
	System.Void ChangeColor(UnityEngine.Color color); // 0x05a46004
	System.Void PlayAimAnim(); // 0x05a46128
	System.Void StopAimAnim(); // 0x05a461bc
	System.Boolean IsPlaying(); // 0x05a46250
	System.Void SetAimAnimMode(); // 0x05a4631c
	System.Void AimAnim(System.Single dt); // 0x05a4637c
	System.Void .ctor(); // 0x05a463f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimBowStyle : WizardGames.Soc.SocClient.Ui.AimStyle
{
	FairyGUI.GImage aimBowPoint; // 0x48
	FairyGUI.GImage aimBowLineRight; // 0x50
	FairyGUI.GImage aimBowLineLeft; // 0x58
	FairyGUI.GImage aimBowLineDown1; // 0x60
	FairyGUI.GImage aimBowLineDown2; // 0x68
	FairyGUI.GImage aimBowLineDown3; // 0x70
	UnityEngine.Vector2 rightPos; // 0x78
	UnityEngine.Vector2 leftPos; // 0x80
	System.Boolean initUIPosition; // 0x88
	UnityEngine.Vector2 initRightPos; // 0x8c
	UnityEngine.Vector2 initLeftPos; // 0x94
	System.Boolean isInStateTwo; // 0x9c
	WizardGames.Soc.Common.Entity.PlayerAdsStateEnum lastAdsState; // 0x9d
	System.Void InitUi(WizardGames.Soc.SocClient.Ui.AimData data, FairyGUI.GObject obj); // 0x05a46454
	System.Void OnEnter(); // 0x05a4677c
	System.Void OnExit(); // 0x05a46b34
	System.Void OnClientAdsStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase inEntity, System.Byte oldValue, System.Byte newValue); // 0x05a46d3c
	System.Void OnUpdate(System.Single dt); // 0x05a47564
	System.Void PlayAimAnim(); // 0x05a47698
	System.Void SetAimAnimMode(); // 0x05a476f8
	System.Void AimAnim(System.Single dt); // 0x05a47b54
	System.Void PlayAnim(WizardGames.Soc.Common.Entity.PlayerBowStateEnum state); // 0x05a46e64
	System.Void .ctor(); // 0x05a47c30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimBowStyle.<>c__DisplayClass22_0 : System.Object
{
	FairyGUI.Transition trans0; // 0x10
	WizardGames.Soc.SocClient.Ui.AimBowStyle <>4__this; // 0x18
	FairyGUI.Transition trans1; // 0x20
	System.Void .ctor(); // 0x05a47bc8
	System.Void <PlayAnim>b__0(); // 0x05a47c94
	System.Void <PlayAnim>b__1(); // 0x05a47d14
	System.Void <PlayAnim>b__2(); // 0x05a47d98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimCrossBowStyle : WizardGames.Soc.SocClient.Ui.AimStyle
{
	FairyGUI.GImage aimNormalRight; // 0x48
	FairyGUI.GImage aimNormalDown; // 0x50
	FairyGUI.GImage aimNormalLeft; // 0x58
	UnityEngine.Vector2 rightPos; // 0x60
	UnityEngine.Vector2 downPos; // 0x68
	UnityEngine.Vector2 leftPos; // 0x70
	System.Boolean initUIPosition; // 0x78
	UnityEngine.Vector2 initRightPos; // 0x7c
	UnityEngine.Vector2 initDownPos; // 0x84
	UnityEngine.Vector2 initLeftPos; // 0x8c
	UnityEngine.Vector2 get_RightPos(); // 0x05a47e18
	UnityEngine.Vector2 get_DownPos(); // 0x05a47e78
	UnityEngine.Vector2 get_LeftPos(); // 0x05a47ed8
	System.Void InitUi(WizardGames.Soc.SocClient.Ui.AimData data, FairyGUI.GObject obj); // 0x05a47f38
	System.Void OnEnter(); // 0x05a481a4
	System.Void OnExit(); // 0x05a48330
	System.Void OnUpdate(System.Single dt); // 0x05a48390
	System.Void PlayAimAnim(); // 0x05a48404
	System.Void SetAimAnimMode(); // 0x05a48464
	System.Void AimAnim(System.Single dt); // 0x05a484c4
	System.Void .ctor(); // 0x05a48c24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimFlameThrowerStyle : WizardGames.Soc.SocClient.Ui.AimStyle
{
	FairyGUI.GImage aimNormalUp; // 0x48
	FairyGUI.GImage aimNormalRight; // 0x50
	FairyGUI.GImage aimNormalDown; // 0x58
	FairyGUI.GImage aimNormalLeft; // 0x60
	UnityEngine.Vector2 upPos; // 0x68
	UnityEngine.Vector2 rightPos; // 0x70
	UnityEngine.Vector2 downPos; // 0x78
	UnityEngine.Vector2 leftPos; // 0x80
	System.Boolean initUIPosition; // 0x88
	UnityEngine.Vector2 initUpPos; // 0x8c
	UnityEngine.Vector2 initRightPos; // 0x94
	UnityEngine.Vector2 initDownPos; // 0x9c
	UnityEngine.Vector2 initLeftPos; // 0xa4
	UnityEngine.Vector2 upDir; // 0xac
	UnityEngine.Vector2 rightDir; // 0xb4
	UnityEngine.Vector2 downDir; // 0xbc
	UnityEngine.Vector2 leftDir; // 0xc4
	UnityEngine.Vector2 get_UpPos(); // 0x05a48c88
	UnityEngine.Vector2 get_RightPos(); // 0x05a48ce8
	UnityEngine.Vector2 get_DownPos(); // 0x05a48d48
	UnityEngine.Vector2 get_LeftPos(); // 0x05a48da8
	System.Void InitUi(WizardGames.Soc.SocClient.Ui.AimData data, FairyGUI.GObject obj); // 0x05a48e08
	System.Void OnEnter(); // 0x05a490d0
	System.Void OnExit(); // 0x05a4919c
	System.Void OnUpdate(System.Single dt); // 0x05a491fc
	System.Void PlayAimAnim(); // 0x05a49270
	System.Void SetAimAnimMode(); // 0x05a492d0
	System.Void AimAnim(System.Single dt); // 0x05a49330
	System.Void .ctor(); // 0x05a49470
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimHitBuildingStyle : WizardGames.Soc.SocClient.Ui.AimStyle
{
	
	System.Void Init(WizardGames.Soc.SocClient.Ui.AimData data, WizardGames.Soc.SocClient.Ui.AimAsset asset); // 0x05a494ec
	System.Void OnEnter(); // 0x05a49584
	System.Void ShowUI(); // 0x05a495e4
	System.Void HideUI(); // 0x05a498b4
	System.Void OnExit(); // 0x05a4995c
	System.Void OnUpdate(System.Single dt); // 0x05a499d4
	System.Void ChangeColor(UnityEngine.Color color); // 0x05a49a48
	System.Void PlayAimAnim(); // 0x05a49b6c
	System.Void StopAimAnim(); // 0x05a49be4
	System.Boolean IsPlaying(); // 0x05a49c5c
	System.Void SetAimAnimMode(); // 0x05a49d10
	System.Void AimAnim(System.Single dt); // 0x05a49d70
	System.Void .ctor(); // 0x05a49de4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimHitHeadBuildingStyle : WizardGames.Soc.SocClient.Ui.AimStyle
{
	
	System.Void Init(WizardGames.Soc.SocClient.Ui.AimData data, WizardGames.Soc.SocClient.Ui.AimAsset asset); // 0x05a49e48
	System.Void OnEnter(); // 0x05a49ee0
	System.Void ShowUI(); // 0x05a49f40
	System.Void HideUI(); // 0x05a4a210
	System.Void OnExit(); // 0x05a4a2b8
	System.Void OnUpdate(System.Single dt); // 0x05a4a330
	System.Void ChangeColor(UnityEngine.Color color); // 0x05a4a3a4
	System.Void PlayAimAnim(); // 0x05a4a4c8
	System.Void StopAimAnim(); // 0x05a4a540
	System.Boolean IsPlaying(); // 0x05a4a5b8
	System.Void SetAimAnimMode(); // 0x05a4a664
	System.Void AimAnim(System.Single dt); // 0x05a4a6c4
	System.Void .ctor(); // 0x05a4a738
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimKnifeStyle : WizardGames.Soc.SocClient.Ui.AimStyle
{
	FairyGUI.GImage aimPoint; // 0x48
	System.Void InitUi(WizardGames.Soc.SocClient.Ui.AimData data, FairyGUI.GObject obj); // 0x05a4a79c
	System.Void OnEnter(); // 0x05a4a918
	System.Void OnExit(); // 0x05a4a9dc
	System.Void OnUpdate(System.Single dt); // 0x05a4aa3c
	System.Void PlayAimAnim(); // 0x05a4aab0
	System.Void SetAimAnimMode(); // 0x05a4ab10
	System.Void AimAnim(System.Single dt); // 0x05a4ab70
	System.Void .ctor(); // 0x05a4abe4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimMachineGunStyle : WizardGames.Soc.SocClient.Ui.AimStyle
{
	FairyGUI.GImage aimNormalUp; // 0x48
	FairyGUI.GImage aimNormalRight; // 0x50
	FairyGUI.GImage aimNormalDown; // 0x58
	FairyGUI.GImage aimNormalLeft; // 0x60
	UnityEngine.Vector2 upPos; // 0x68
	UnityEngine.Vector2 rightPos; // 0x70
	UnityEngine.Vector2 downPos; // 0x78
	UnityEngine.Vector2 leftPos; // 0x80
	System.Boolean initUIPosition; // 0x88
	UnityEngine.Vector2 initUpPos; // 0x8c
	UnityEngine.Vector2 initRightPos; // 0x94
	UnityEngine.Vector2 initDownPos; // 0x9c
	UnityEngine.Vector2 initLeftPos; // 0xa4
	System.Collections.Generic.List<System.Single> phaseDistanceList; // 0xb0
	System.Single coefficient; // 0xb8
	System.Single constant; // 0xbc
	UnityEngine.GameObject ShootLineEndPoint; // 0xc0
	UnityEngine.Vector2 get_UpPos(); // 0x05a4ac48
	UnityEngine.Vector2 get_RightPos(); // 0x05a4aca8
	UnityEngine.Vector2 get_DownPos(); // 0x05a4ad08
	UnityEngine.Vector2 get_LeftPos(); // 0x05a4ad68
	System.Collections.Generic.List<System.Single> get_PhaseDistanceList(); // 0x05a4adc8
	System.Void InitUi(WizardGames.Soc.SocClient.Ui.AimData data, FairyGUI.GObject obj); // 0x05a4aedc
	System.Void OnEnter(); // 0x05a4b26c
	System.Void OnExit(); // 0x05a4b350
	System.Void OnUpdate(System.Single dt); // 0x05a4b3c4
	System.Void PlayAimAnim(); // 0x05a4b4b0
	System.Void SetAimAnimMode(); // 0x05a4b594
	System.Void AimAnim(System.Single dt); // 0x05a4b808
	System.Void .ctor(); // 0x05a4bc80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimMGLStyle : WizardGames.Soc.SocClient.Ui.AimStyle
{
	FairyGUI.GImage Left1; // 0x48
	FairyGUI.GImage Left2; // 0x50
	FairyGUI.GImage Left3; // 0x58
	FairyGUI.GImage Right1; // 0x60
	FairyGUI.GImage Right2; // 0x68
	FairyGUI.GImage Right3; // 0x70
	UnityEngine.Vector2 left1Pos; // 0x78
	UnityEngine.Vector2 right1Pos; // 0x80
	UnityEngine.Vector2 left2Pos; // 0x88
	UnityEngine.Vector2 right2Pos; // 0x90
	UnityEngine.Vector2 left3Pos; // 0x98
	UnityEngine.Vector2 right3Pos; // 0xa0
	System.Boolean initUIPosition; // 0xa8
	UnityEngine.Vector2 initLeft1Pos; // 0xac
	UnityEngine.Vector2 initRight1Pos; // 0xb4
	UnityEngine.Vector2 initLeft2Pos; // 0xbc
	UnityEngine.Vector2 initRight2Pos; // 0xc4
	UnityEngine.Vector2 initLeft3Pos; // 0xcc
	UnityEngine.Vector2 initRight3Pos; // 0xd4
	System.Void InitUi(WizardGames.Soc.SocClient.Ui.AimData data, FairyGUI.GObject obj); // 0x05a4bea4
	System.Void OnEnter(); // 0x05a4c22c
	System.Void OnExit(); // 0x05a4c2f8
	System.Void OnUpdate(System.Single dt); // 0x05a4c358
	System.Void PlayAimAnim(); // 0x05a4c3cc
	System.Void SetAimAnimMode(); // 0x05a4c42c
	System.Void AimAnim(System.Single dt); // 0x05a4c48c
	System.Void .ctor(); // 0x05a4c5b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimNormalStyle : WizardGames.Soc.SocClient.Ui.AimStyle
{
	FairyGUI.GImage aimNormalUp; // 0x48
	FairyGUI.GImage aimNormalRight; // 0x50
	FairyGUI.GImage aimNormalDown; // 0x58
	FairyGUI.GImage aimNormalLeft; // 0x60
	FairyGUI.GImage aimNormalCircle; // 0x68
	FairyGUI.GImage aimNormalAim_x; // 0x70
	UnityEngine.Vector2 upPos; // 0x78
	UnityEngine.Vector2 rightPos; // 0x80
	UnityEngine.Vector2 downPos; // 0x88
	UnityEngine.Vector2 leftPos; // 0x90
	System.Boolean initUIPosition; // 0x98
	UnityEngine.Vector2 initUpPos; // 0x9c
	UnityEngine.Vector2 initRightPos; // 0xa4
	UnityEngine.Vector2 initDownPos; // 0xac
	UnityEngine.Vector2 initLeftPos; // 0xb4
	System.Collections.Generic.List<System.Single> phaseDistanceList; // 0xc0
	System.Single coefficient; // 0xc8
	System.Single constant; // 0xcc
	UnityEngine.GameObject ShootLineEndPoint; // 0xd0
	UnityEngine.Vector2 get_UpPos(); // 0x05a4c618
	UnityEngine.Vector2 get_RightPos(); // 0x05a4c678
	UnityEngine.Vector2 get_DownPos(); // 0x05a4c6d8
	UnityEngine.Vector2 get_LeftPos(); // 0x05a4c738
	System.Collections.Generic.List<System.Single> get_PhaseDistanceList(); // 0x05a4c798
	System.Void InitUi(WizardGames.Soc.SocClient.Ui.AimData data, FairyGUI.GObject obj); // 0x05a4c8ac
	System.Void OnEnter(); // 0x05a4cc90
	System.Void OnExit(); // 0x05a4cd74
	System.Void OnUpdate(System.Single dt); // 0x05a4cde8
	System.Void PlayAimAnim(); // 0x05a4d788
	System.Void SetAimAnimMode(); // 0x05a4d86c
	System.Void AimAnim(System.Single dt); // 0x05a4dae0
	System.Void ChangeAimCenter(); // 0x05a4d020
	System.Void .ctor(); // 0x05a4de3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimRifleStyle : WizardGames.Soc.SocClient.Ui.AimStyle
{
	FairyGUI.GImage aimNormalUp; // 0x48
	FairyGUI.GImage aimNormalRight; // 0x50
	FairyGUI.GImage aimNormalDown; // 0x58
	FairyGUI.GImage aimNormalLeft; // 0x60
	FairyGUI.GImage aimNormalCircle; // 0x68
	UnityEngine.Vector2 upPos; // 0x70
	UnityEngine.Vector2 rightPos; // 0x78
	UnityEngine.Vector2 downPos; // 0x80
	UnityEngine.Vector2 leftPos; // 0x88
	System.Boolean initUIPosition; // 0x90
	UnityEngine.Vector2 initUpPos; // 0x94
	UnityEngine.Vector2 initRightPos; // 0x9c
	UnityEngine.Vector2 initDownPos; // 0xa4
	UnityEngine.Vector2 initLeftPos; // 0xac
	System.Collections.Generic.List<System.Single> phaseDistanceList; // 0xb8
	System.Single coefficient; // 0xc0
	System.Single constant; // 0xc4
	UnityEngine.GameObject ShootLineEndPoint; // 0xc8
	UnityEngine.Vector2 get_UpPos(); // 0x05a4e060
	UnityEngine.Vector2 get_RightPos(); // 0x05a4e0c0
	UnityEngine.Vector2 get_DownPos(); // 0x05a4e120
	UnityEngine.Vector2 get_LeftPos(); // 0x05a4e180
	System.Collections.Generic.List<System.Single> get_PhaseDistanceList(); // 0x05a4e1e0
	System.Void InitUi(WizardGames.Soc.SocClient.Ui.AimData data, FairyGUI.GObject obj); // 0x05a4e2f4
	System.Void OnEnter(); // 0x05a4e6c8
	System.Void OnExit(); // 0x05a4e7ac
	System.Void OnUpdate(System.Single dt); // 0x05a4e820
	System.Void PlayAimAnim(); // 0x05a4e90c
	System.Void SetAimAnimMode(); // 0x05a4e9f0
	System.Void AimAnim(System.Single dt); // 0x05a4ec64
	System.Void .ctor(); // 0x05a4edac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimRocketLauncherStyle : WizardGames.Soc.SocClient.Ui.AimStyle
{
	FairyGUI.GImage aimNormalUp; // 0x48
	FairyGUI.GImage aimNormalRight; // 0x50
	FairyGUI.GImage aimNormalDown; // 0x58
	FairyGUI.GImage aimNormalLeft; // 0x60
	UnityEngine.Vector2 upPos; // 0x68
	UnityEngine.Vector2 rightPos; // 0x70
	UnityEngine.Vector2 downPos; // 0x78
	UnityEngine.Vector2 leftPos; // 0x80
	System.Boolean initUIPosition; // 0x88
	UnityEngine.Vector2 initUpPos; // 0x8c
	UnityEngine.Vector2 initRightPos; // 0x94
	UnityEngine.Vector2 initDownPos; // 0x9c
	UnityEngine.Vector2 initLeftPos; // 0xa4
	UnityEngine.Vector2 upDir; // 0xac
	UnityEngine.Vector2 rightDir; // 0xb4
	UnityEngine.Vector2 downDir; // 0xbc
	UnityEngine.Vector2 leftDir; // 0xc4
	UnityEngine.Vector2 get_UpPos(); // 0x05a4efd0
	UnityEngine.Vector2 get_RightPos(); // 0x05a4f030
	UnityEngine.Vector2 get_DownPos(); // 0x05a4f090
	UnityEngine.Vector2 get_LeftPos(); // 0x05a4f0f0
	System.Void InitUi(WizardGames.Soc.SocClient.Ui.AimData data, FairyGUI.GObject obj); // 0x05a4f150
	System.Void OnEnter(); // 0x05a4f418
	System.Void OnExit(); // 0x05a4f4e4
	System.Void OnUpdate(System.Single dt); // 0x05a4f544
	System.Void PlayAimAnim(); // 0x05a4f5b8
	System.Void SetAimAnimMode(); // 0x05a4f618
	System.Void AimAnim(System.Single dt); // 0x05a4f678
	System.Void .ctor(); // 0x05a4f7b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimShotGunStyle : WizardGames.Soc.SocClient.Ui.AimStyle
{
	FairyGUI.GImage aimShotgunUp; // 0x48
	FairyGUI.GImage aimShotgunRight; // 0x50
	FairyGUI.GImage aimShotgunDown; // 0x58
	FairyGUI.GImage aimShotgunLeft; // 0x60
	UnityEngine.Vector2 upPos; // 0x68
	UnityEngine.Vector2 rightPos; // 0x70
	UnityEngine.Vector2 downPos; // 0x78
	UnityEngine.Vector2 leftPos; // 0x80
	System.Boolean initUIPosition; // 0x88
	UnityEngine.Vector2 initUpPos; // 0x8c
	UnityEngine.Vector2 initRightPos; // 0x94
	UnityEngine.Vector2 initDownPos; // 0x9c
	UnityEngine.Vector2 initLeftPos; // 0xa4
	System.Collections.Generic.List<System.Single> phaseDistanceList; // 0xb0
	System.Single coefficient; // 0xb8
	System.Single constant; // 0xbc
	System.Boolean _init; // 0xc0
	UnityEngine.Vector2 get_UpPos(); // 0x05a4f834
	UnityEngine.Vector2 get_RightPos(); // 0x05a4f8d4
	UnityEngine.Vector2 get_DownPos(); // 0x05a4f970
	UnityEngine.Vector2 get_LeftPos(); // 0x05a4fa10
	System.Collections.Generic.List<System.Single> get_PhaseDistanceList(); // 0x05a4faac
	System.Void InitUi(WizardGames.Soc.SocClient.Ui.AimData data, FairyGUI.GObject obj); // 0x05a4fbf0
	System.Void OnEnter(); // 0x05a4fecc
	System.Void OnExit(); // 0x05a50074
	System.Void OnUpdate(System.Single dt); // 0x05a500d4
	System.Void PlayAimAnim(); // 0x05a50148
	System.Void SetAimAnimMode(); // 0x05a5022c
	System.Void AimAnim(System.Single dt); // 0x05a50504
	System.Void .ctor(); // 0x05a5064c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimSniperRifleStyle : WizardGames.Soc.SocClient.Ui.AimStyle
{
	FairyGUI.GImage aimNormalUp; // 0x48
	FairyGUI.GImage aimNormalRight; // 0x50
	FairyGUI.GImage aimNormalDown; // 0x58
	FairyGUI.GImage aimNormalLeft; // 0x60
	FairyGUI.GImage aimNormalCircle; // 0x68
	UnityEngine.Vector2 upPos; // 0x70
	UnityEngine.Vector2 rightPos; // 0x78
	UnityEngine.Vector2 downPos; // 0x80
	UnityEngine.Vector2 leftPos; // 0x88
	System.Boolean initUIPosition; // 0x90
	UnityEngine.Vector2 initUpPos; // 0x94
	UnityEngine.Vector2 initRightPos; // 0x9c
	UnityEngine.Vector2 initDownPos; // 0xa4
	UnityEngine.Vector2 initLeftPos; // 0xac
	System.Collections.Generic.List<System.Single> phaseDistanceList; // 0xb8
	System.Single coefficient; // 0xc0
	System.Single constant; // 0xc4
	UnityEngine.GameObject ShootLineEndPoint; // 0xc8
	UnityEngine.Vector2 get_UpPos(); // 0x05a50920
	UnityEngine.Vector2 get_RightPos(); // 0x05a50980
	UnityEngine.Vector2 get_DownPos(); // 0x05a509e0
	UnityEngine.Vector2 get_LeftPos(); // 0x05a50a40
	System.Collections.Generic.List<System.Single> get_PhaseDistanceList(); // 0x05a50aa0
	System.Void InitUi(WizardGames.Soc.SocClient.Ui.AimData data, FairyGUI.GObject obj); // 0x05a50bb4
	System.Void OnEnter(); // 0x05a50f88
	System.Void OnExit(); // 0x05a5106c
	System.Void OnUpdate(System.Single dt); // 0x05a510e0
	System.Void PlayAimAnim(); // 0x05a511cc
	System.Void SetAimAnimMode(); // 0x05a512b0
	System.Void AimAnim(System.Single dt); // 0x05a51524
	System.Void .ctor(); // 0x05a51880
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AimStyle : System.Object
{
	WizardGames.Soc.SocClient.Ui.AimData aimData; // 0x10
	WizardGames.Soc.SocClient.Ui.AimAsset aimAsset; // 0x18
	WizardGames.Soc.SocClient.Ui.AimAnimMode aimAnimMode; // 0x20
	FairyGUI.GComponent aimUi; // 0x28
	WizardGames.Soc.Common.Entity.PlayerAdsStateEnum lastAdsState; // 0x30
	System.Single adsTimer; // 0x34
	System.Single lastStartDisplacement; // 0x38
	System.Single curDisplacement; // 0x3c
	System.Single time; // 0x40
	WizardGames.Soc.Common.Entity.PlayerMoveStateEnum lastMoveState; // 0x44
	System.Void InitUi(WizardGames.Soc.SocClient.Ui.AimData data, FairyGUI.GObject obj); // 0x05a51aa4
	System.Void Init(WizardGames.Soc.SocClient.Ui.AimData data, WizardGames.Soc.SocClient.Ui.AimAsset asset); // 0x05a51b20
	System.Void OnEnter(); // 0x05a48270
	System.Void ShowUI(); // 0x05a51b9c
	System.Void HideUI(); // 0x05a51bfc
	System.Void OnExit(); // 0x055049cc
	System.Void ClearUi(); // 0x05a51c5c
	System.Void OnUpdate(System.Single dt); // 0x05513724
	System.Void ChangeColor(UnityEngine.Color color); // 0x05a51cc8
	System.Void PlayAimAnim(); // 0x055049cc
	System.Void StopAimAnim(); // 0x05a51dec
	System.Void SetAimAnimMode(); // 0x055049cc
	System.Void AimAnim(System.Single dt); // 0x05a485d8
	System.Void ShowAim(System.Boolean show); // 0x05a51e4c
	System.Void SetAimAngle(System.Single rotation); // 0x05a51ed4
	System.Void SetAlpha(System.Single alpha); // 0x05a51f5c
	System.Boolean IsPlaying(); // 0x05a51fe4
	System.Void .ctor(); // 0x05a45a0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComHarm : System.Object
{
	FairyGUI.GComponent ComRoot; // 0x10
	FairyGUI.Transition Anim; // 0x18
	FairyGUI.Controller StyleCnotroller; // 0x20
	FairyGUI.PlayCompleteCallback OnComplete; // 0x28
	System.Void .ctor(FairyGUI.GComponent root); // 0x05a43734
	System.Void Show(System.Boolean vehicle, System.Boolean resist); // 0x05a52088
	System.Void <.ctor>b__4_0(); // 0x05a52170
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.CrossHairController : System.Object
{
	static System.Collections.Generic.Dictionary<System.String,System.String> AimPath; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,System.String> Suffix; // 0x8
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.AimStyle> aimStyleDic; // 0x10
	System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject> aimNode; // 0x18
	WizardGames.Soc.SocClient.Ui.AimData aimData; // 0x20
	WizardGames.Soc.SocClient.Ui.AimAsset aimAsset; // 0x28
	WizardGames.Soc.SocClient.Ui.AimStyle curAimStyle; // 0x30
	System.String lastAimStyle; // 0x38
	System.Single curAlpha; // 0x40
	System.Single sourceAlpha; // 0x44
	System.Single targetAlpha; // 0x48
	System.Single progress; // 0x4c
	System.Single blendTime; // 0x50
	System.Int32 idx; // 0x54
	UnityEngine.Color _color; // 0x58
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.AimData aimData); // 0x05a521e4
	System.Void Init(WizardGames.Soc.SocClient.Ui.AimAsset aimAsset); // 0x05a5268c
	System.Void Destroy(); // 0x05a5270c
	System.Void Update(System.Single dt); // 0x05a5276c
	System.Void UpdateAimSize(System.Single dt); // 0x05a527f4
	System.Void UpdateAimAlpha(System.Single dt); // 0x05a5287c
	System.Void SetTargetAlpha(System.Single alpha, System.Single blendTime); // 0x05a52fc4
	System.Single CalcAlphaByCharacterState(); // 0x05a529fc
	System.Single CalcAlphaByWeaponState(); // 0x05a530f0
	System.Void ChangeStyle(System.String aimStyle, System.Int32 index); // 0x05a53580
	System.Void ShowStyle(System.String aimStyle, System.Int32 index); // 0x05a5393c
	System.Void RemoveStyle(System.String aimStyle); // 0x05a53770
	System.Void SetSizeAndColor(System.Int32 index, UnityEngine.Color color); // 0x05a53c84
	System.Void InitSizeAndColor(System.Int32 index, UnityEngine.Color color); // 0x05a53d44
	static System.Void .cctor(); // 0x05a53dfc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.HitController : System.Object
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.AimStyle> hitFeedbackStyles; // 0x10
	WizardGames.Soc.SocClient.Ui.AimData aimData; // 0x18
	WizardGames.Soc.SocClient.Ui.AimAsset aimAsset; // 0x20
	WizardGames.Soc.SocClient.Ui.AimStyle curHitStyle; // 0x28
	System.String curHitStyleName; // 0x30
	System.Single lastHitAimOffsetAngle; // 0x38
	System.Single hitAnimCurTime; // 0x3c
	WizardGames.Soc.SocClient.Ui.AimStyle curKillStyle; // 0x40
	System.String curKillStyleName; // 0x48
	System.Void set_CurHitStyle(System.String value); // 0x05a54200
	System.Void set_CurKillStyle(System.String value); // 0x05a5444c
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.AimData aimData); // 0x05a54694
	System.Void Init(WizardGames.Soc.SocClient.Ui.AimAsset asset); // 0x05a54720
	System.Void Destroy(); // 0x05a54a88
	System.Void Update(System.Single dt); // 0x05a54ae8
	System.Void ShowHitFeedback(System.String styleName, UnityEngine.Color color); // 0x05a54c88
	System.Void StopHitFeedback(); // 0x05a54348
	System.Void ShowKillFeedback(System.String styleName, UnityEngine.Color color); // 0x05a54e48
	System.Void StopKillFeedback(); // 0x05a54590
	static System.Void .cctor(); // 0x05a54f40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrAim : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	System.Int32 AimHideFlag; // 0x338
	WizardGames.Soc.SocClient.Ui.AimData aimData; // 0x340
	System.Int64 subFieldChangeId; // 0x348
	WizardGames.Soc.SocClient.Ui.AimAsset aimAsset; // 0x350
	WizardGames.Soc.SocClient.Ui.CrossHairController crossHairController; // 0x358
	WizardGames.Soc.SocClient.Ui.HitController hitController; // 0x360
	System.Boolean initialize; // 0x368
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.MgrAim.HitRequestSet> pendingRequest; // 0x370
	System.Collections.Generic.List<System.Int64> removeList; // 0x378
	System.Collections.Generic.LinkedList<System.Int32> GCache; // 0x380
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.MgrAim.GNode> GObjectCache; // 0x388
	System.Int32 GCacheMaxSize; // 0x390
	System.Int32 GCacheBaseSize; // 0x394
	System.Int32 delayFrame; // 0x398
	FairyGUI.GComponent panelRoot; // 0x3a0
	FairyGUI.GProgressBar combar; // 0x3a8
	static WizardGames.Soc.SocClient.Ui.MgrAim get_WindowComBase(); // 0x05a44d64
	System.Void UpdateDelayFrame(); // 0x05a54fd4
	System.Void ReleaseGCacheAndGObjectCache(); // 0x05a552a8
	System.Void InitGCacheAndGObjectCache(); // 0x05a554c0
	System.Void StopProcess(System.String aimPath, System.String suffix); // 0x05a45440
	System.Void TryReleaseNotProcess(); // 0x05a5507c
	FairyGUI.GObject GetGObject(System.String aimPath, System.String suffix); // 0x05a44e64
	System.Void .ctor(); // 0x05a32024
	System.Void SetSizeAndColor(System.Int32 index, UnityEngine.Color color); // 0x05a5567c
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x05a5575c
	System.Void OnInit(); // 0x055049cc
	System.Void OnAmmoIDChanged(WizardGames.Soc.Share.Framework.CustomTypeBase weapon, System.Int32 oldValue, System.Int32 newValue); // 0x05a56254
	System.Void OnCharacterAdsStateChange(System.Int64 entityId, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum newState); // 0x05a56340
	System.Void OnDestroy(); // 0x055049cc
	System.Void BuildStateSwitchEvent(System.Boolean isInBuildMode); // 0x05a567ac
	System.Void OnFps30Update(System.Single dt); // 0x05a56908
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05a56e44
	System.Void Updatecombar(); // 0x05a5760c
	System.Void ShowCombar(); // 0x05a5785c
	System.Void RemoveCombar(); // 0x05a577c8
	System.Void ShowAimX(); // 0x05a57b5c
	System.Void RemoveAimX(); // 0x05a57e20
	System.Void UpdateAimX(); // 0x05a56ee8
	System.Void SetWeapon(); // 0x05a56124
	System.String GetCurrentAimStyle(); // 0x05a57f78
	System.Void ShowHitOrKillUi(WizardGames.Soc.SocClient.Systems.DamageDataCache damageDataCache); // 0x05a582b4
	System.Void OnHitRequest(WizardGames.Soc.Common.SimpleCustom.HitRequest hitRequest); // 0x05a5868c
	System.Void ShowHitUi(WizardGames.Soc.Common.SimpleCustom.HitRequest hitRequest); // 0x05a5896c
	System.Boolean HitWeakpoint(WizardGames.Soc.Common.SimpleCustom.HitRequest hitRequest); // 0x05a588dc
	System.Boolean HitWeakpoint(WizardGames.Soc.SocClient.Systems.DamageDataCache damageDataCache); // 0x05a58604
	System.Void ShowShotAim(); // 0x05a58f08
	System.Void UpdateWeaponCurSpread(System.Single curSpread); // 0x05a57ec0
	System.Void OnCenterRouletteOpen(); // 0x05a58f68
	System.Void OnCenterRouletteClose(); // 0x05a59060
	System.Void OnTimelineHideAim(); // 0x05a59158
	System.Void OnTimelineShowAim(); // 0x05a591c0
	System.Void OnEnterBuildMode(); // 0x05a568a0
	System.Void OnExitBuildMode(); // 0x05a56838
	System.Void OnLittleEyeEntered(); // 0x05a59228
	System.Void OnLittleEyeExited(); // 0x05a59290
	System.Void TeleScopeStateChange(System.Boolean state); // 0x05a592f8
	System.Boolean IsAimVisible(); // 0x05a59388
	System.Void AddFlag(System.Int32 flag); // 0x05a58fd0
	System.Void RemoveFlag(System.Int32 flag); // 0x05a590c8
	System.Void UpdateContentPane(); // 0x05a593f4
	static System.Void ShowShotAimCallBack(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x05a595e4
	static System.Void SetWeaponCallBack(System.Int64 entityId); // 0x05a596f8
	System.Void MeleeThrowChange(System.Int64 id, System.Boolean throwState); // 0x05a597bc
	System.Void ShowContentPane(); // 0x05a59474
	System.Void HideContentPane(); // 0x05a5952c
	System.Void SetAimScreenPosition(System.Single x, System.Single y); // 0x05a59894
	System.Void OnUpdateCameraRender(UnityEngine.Matrix4x4 localToWorldMatrix4X4); // 0x05a59a4c
	static System.Single Lerp(System.Single a, System.Single b, System.Single t); // 0x05a4bb64
	System.Void AddPendingHitRequest(WizardGames.Soc.Common.SimpleCustom.HitRequest hitRequest); // 0x05a58bec
	System.Void UpdatePendingHitRequest(); // 0x05a56988
	System.Void ProcessHitRequest(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest> hitRequests); // 0x05a59c70
	System.Void OnPhotoModeEntered(); // 0x05a59d90
	System.Void OnPhotoModeExited(); // 0x05a59df8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrAim.HitRequestSet : System.Object
{
	System.Int32 frame; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest> requests; // 0x18
	System.Void .ctor(); // 0x05a59bbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrAim.GNode : System.Object
{
	System.Collections.Generic.LinkedListNode<System.Int32> ListNode; // 0x10
	FairyGUI.GObject GObject; // 0x18
	System.Boolean process; // 0x20
	System.Void .ctor(System.Collections.Generic.LinkedListNode<System.Int32> ListNode, FairyGUI.GObject GObject); // 0x05a555d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDamageFeedback : System.Object
{
	static SocLogger logger; // 0x0
	FairyGUI.GComponent root; // 0x10
	FairyGUI.GComponent signRoot; // 0x18
	FairyGUI.GComponent trisignRoot; // 0x20
	FairyGUI.GObject[] signs; // 0x28
	FairyGUI.GObject[] trisigns; // 0x30
	FairyGUI.GObject[] icons; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiDamageFeedback.NewHitSign> hits; // 0x40
	FairyGUI.GImage damageCircle; // 0x48
	FairyGUI.GImage damageTriangle; // 0x50
	WizardGames.Soc.Common.Unity.Ui.WindowComBase baseUi; // 0x58
	UnityEngine.Rendering.Universal.ChromaticAberration chromaticAberration; // 0x60
	System.Int32 lastChangeHp; // 0x68
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.UiDamageFeedback.HitSign> hitSignDic; // 0x70
	System.Boolean init; // 0x78
	FairyGUI.GComponent DamageScreenEffect; // 0x80
	FairyGUI.Controller hitCtrl; // 0x88
	FairyGUI.Controller branchCtrl; // 0x90
	System.Boolean inCold; // 0x98
	System.Boolean inPoisonAudio; // 0x99
	System.Boolean inDrownAudio; // 0x9a
	System.Int32 lastIndex; // 0x9c
	System.Void InitController(WizardGames.Soc.Common.Unity.Ui.WindowComBase base_ui, FairyGUI.GComponent root, FairyGUI.GComponent bg); // 0x05a59e60
	System.Void OnTemperatureChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05a5a5d4
	System.Void OnPoisonChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05a5ab10
	System.Void OnOxygenChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05a5ae70
	System.Void OnLifeFlagsChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05a5b1d4
	System.Void OnHandleDamage(WizardGames.Soc.Common.SimpleCustom.DamageDataEvent data); // 0x05a5b598
	System.Int32 GetHitIdx(WizardGames.Soc.Common.SimpleCustom.DamageDataEvent data); // 0x05a5c0a8
	WizardGames.Soc.SocClient.Ui.UiDamageFeedback.NewHitSign GetOrCreateSign(UnityEngine.GameObject go); // 0x05a5bb40
	System.Boolean IsSevereInjury(WizardGames.Soc.Common.Data.Combat.DamageType t); // 0x05a5b900
	System.Void ShowNormalInjury(); // 0x05a5bab0
	System.Void ShowSevereInjury(); // 0x05a5ba20
	System.Void EnsureUI(); // 0x05a5c2cc
	System.Void ShowBloodEffect(System.Int32 index); // 0x05a5c32c
	System.Void UpdateInCold(System.Boolean inCold); // 0x05a5a7a4
	System.Void Reset(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05a5c75c
	System.Void PlayHpAnim(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05a5c7d8
	System.Void OnHandleHpChange(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05a5cca4
	System.Void Destroy(); // 0x05a5ce28
	System.Void OnReborn(); // 0x05a5cfd4
	System.Void Update(System.Single dt); // 0x05a5d1a8
	System.Single GetAngle(UnityEngine.Vector3 sourceDir); // 0x05a5d734
	System.Boolean IsShowing(); // 0x05a5da6c
	System.Void .ctor(); // 0x05a5dcac
	static System.Void .cctor(); // 0x05a5ddb8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDamageFeedback.NewHitSign : System.Object
{
	System.Boolean showing; // 0x10
	System.Single startTime; // 0x14
	System.Single accTime; // 0x18
	FairyGUI.GComponent sign; // 0x20
	FairyGUI.GComponent root; // 0x28
	FairyGUI.GComponent signRoot; // 0x30
	UnityEngine.Vector2 center; // 0x38
	UnityEngine.Vector3 curGoPos; // 0x40
	FairyGUI.Controller controller; // 0x50
	FairyGUI.Transition show; // 0x58
	FairyGUI.Transition hide; // 0x60
	UnityEngine.GameObject target; // 0x68
	System.Int32 curIdx; // 0x70
	System.Boolean isFall; // 0x74
	System.Void Init(FairyGUI.GComponent root, FairyGUI.GComponent signRoot, FairyGUI.GComponent ui); // 0x05a5dffc
	System.Void Show(System.Int32 idx, UnityEngine.GameObject go, System.Boolean isFall); // 0x05a5e1dc
	System.Void Update(System.Single dt); // 0x05a5e428
	System.Void SetSignShowAngle(); // 0x05a5e33c
	System.Void UpdateSignPos(System.Single angleZ); // 0x05a5e93c
	System.Single GetAngle(UnityEngine.Vector3 sourceDir); // 0x05a5e604
	System.Void .ctor(); // 0x05a5ebfc
	System.Void <Update>b__17_0(); // 0x05a5ec6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDamageFeedback.HitSign : System.Object
{
	System.Single DamageUiReduceSpeed; // 0x10
	System.Single DamageUiStartReduceTime; // 0x14
	System.Single CenterDamageUiLiveTime; // 0x18
	System.Single CenterDamageUiStartDisppearTime; // 0x1c
	UnityEngine.Vector3 curGoPos; // 0x20
	FairyGUI.GLoader loader; // 0x30
	System.Boolean isFall; // 0x38
	System.Single fillAmount; // 0x3c
	System.Single time; // 0x40
	FairyGUI.GComponent root; // 0x48
	FairyGUI.GComponent signRoot; // 0x50
	UnityEngine.Vector2 center; // 0x58
	System.Single showingTime; // 0x60
	System.Single timeForBlood; // 0x64
	UnityEngine.Vector3 get_CurGoPos(); // 0x05a5ecd0
	System.Void ReduceSignShowAngle(System.Single dt); // 0x05a5ed34
	System.Void UpdateSignPos(System.Single angleZ); // 0x05a5edd4
	System.Void SetLoaderOff(); // 0x05a5f300
	System.Void CloseAllLoader(); // 0x05a5f390
	System.Boolean IsHitSignShowing(); // 0x05a5f404
	System.Single GetRadius(System.Single angle); // 0x05a5f030
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDamageScreenEffect : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	WizardGames.Soc.SocClient.Ui.UiDamageFeedback uiDamageFeedback; // 0x338
	WizardGames.Soc.SocClient.Ui.UiRadiationOverlap uiRadiationOverlap; // 0x340
	System.Int64 closeWindowTs; // 0x348
	System.Int32 closeWindowTimeMs; // 0x350
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x05a5f4c0
	System.Void OnInit(); // 0x05a5f54c
	System.Void OnEnable(); // 0x05a5f8dc
	System.Void OnDestroy(); // 0x05a5f9d0
	System.Void CloseWindowCheckTimer(); // 0x05a5fa4c
	System.Void UpdateEffect(System.Single dt); // 0x05a5fc6c
	System.Void OnReborn(); // 0x05a6007c
	System.Void OnFps1Update(System.Single dt); // 0x05a60174
	System.Void OnFps10Update(System.Single dt); // 0x05a601ec
	System.Void OnDisable(); // 0x05a60268
	System.Void OnFps30Update(System.Single dt); // 0x05a60394
	System.Void .ctor(); // 0x05a6041c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRadiationOverlap : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Entity.PlayerEntity serverMyPlayer; // 0x10
	UnityEngine.Rendering.Universal.ColorAdjustments colorAdjustments; // 0x18
	UnityEngine.Rendering.Universal.FilmGrain filmGrain; // 0x20
	System.Single radiationPoisonCache; // 0x28
	System.String ppvName; // 0x30
	UnityEngine.GameObject PPV_Radiation; // 0x38
	WizardGames.Soc.Common.Entity.PlayerEntity get_ServerMyPlayer(); // 0x05a605b4
	System.Void Init(); // 0x05a5f6d8
	System.Void Update(); // 0x05a5fcec
	System.Single Lerp(System.Single cache, System.Single target, System.Single close, System.Single speed); // 0x05a60918
	System.Boolean IsShowing(); // 0x05a5fb8c
	System.Void OnReborn(); // 0x05a600f8
	System.Void OnDisable(); // 0x05a602e8
	System.Void .ctor(); // 0x05a60528
	static System.Void .cctor(); // 0x05a609f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.EmitFontComponent : FairyGUI.GComponent
{
	UnityEngine.Camera mainCamera; // 0x288
	FairyGUI.GComponent emitFontCom; // 0x290
	FairyGUI.GTextField numberText; // 0x298
	UnityEngine.Vector3 originPos; // 0x2a0
	System.Single targetX; // 0x2ac
	System.Boolean isCritical; // 0x2b0
	System.Int32 damageNum; // 0x2b4
	System.Single duration; // 0x2b8
	System.Single targetX1; // 0x2bc
	System.Single targetX2; // 0x2c0
	System.Single targetY; // 0x2c4
	UnityEngine.Color normalColor; // 0x2c8
	UnityEngine.Color criticalColor; // 0x2d8
	System.Single a1; // 0x2e8
	System.Single a2; // 0x2ec
	System.Single a3; // 0x2f0
	System.Single a4; // 0x2f4
	System.String pkgName; // 0x2f8
	System.String resName; // 0x300
	UnityEngine.Vector2 criticalStartScale; // 0x308
	UnityEngine.Vector2 criticalEndScale; // 0x310
	UnityEngine.Vector2 uncriticalStartScale; // 0x318
	UnityEngine.Vector2 uncriticalEndScale; // 0x320
	WizardGames.Soc.SocClient.Ui.UiEmitFont emitFontRoot; // 0x328
	FairyGUI.Transition leftEffct; // 0x330
	FairyGUI.Transition rightEffct; // 0x338
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiEmitFont root); // 0x05a60ac4
	System.Void Dispose(); // 0x05a60d64
	System.Void SetHurt(UnityEngine.Vector3 damagePos, System.Int32 damage, System.Boolean critical, UnityEngine.Camera camera, System.Boolean isLeft); // 0x05a60dec
	System.Boolean UpdatePosition(UnityEngine.Vector2 offset); // 0x05a61084
	System.Void Stop(); // 0x05a61370
	System.Void OnCompleted(); // 0x05a613f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiEmitFont : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	UnityEngine.Camera mainCamera; // 0x338
	System.Int64 closeWindowTs; // 0x340
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Systems.DamageDataCache> damageDataCacheQueue; // 0x348
	System.Int64 updateEmitTimerId; // 0x350
	UnityEngine.Vector3 posCache; // 0x358
	System.Int32 closeWindowTimeMs; // 0x364
	System.Int32 queueLimitNum; // 0x368
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.EmitFontComponent> emitFontCacheQueue; // 0x370
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.EmitFontComponent> activeFonts; // 0x378
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.EmitFontComponent> removable; // 0x380
	System.Void .ctor(); // 0x05a61538
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x05a617b8
	System.Void OnInit(); // 0x05a61838
	System.Void OnEnable(); // 0x05a61968
	System.Void OnDestroy(); // 0x05a61a0c
	System.Void UpdateEmitTimer(System.Int64 timerId, System.Object callbackData, System.Boolean needDelete); // 0x05a61b3c
	System.Void ShowEmit(WizardGames.Soc.SocClient.Systems.DamageDataCache damageDataCache); // 0x05523a54
	System.Void ShowEmitInternal(WizardGames.Soc.SocClient.Systems.DamageDataCache damageDataCache); // 0x05a61db4
	WizardGames.Soc.SocClient.Ui.EmitFontComponent CreateEmitFontCom(); // 0x05a62be0
	System.Void Release(WizardGames.Soc.SocClient.Ui.EmitFontComponent emitFont); // 0x05a61474
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05a62d38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomePattern : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	FairyGUI.GTextField desText; // 0x338
	FairyGUI.GRichTextField timeText; // 0x340
	FairyGUI.GImage toolCupboardHpBarImg; // 0x348
	FairyGUI.GTextField toolCupboardHpText; // 0x350
	FairyGUI.GList leftHeadList; // 0x358
	FairyGUI.GList rightHeadList; // 0x360
	FairyGUI.GLoader clickAreaLoader; // 0x368
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.UiPlayerHead> leftPlayerHeadDic; // 0x370
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.UiPlayerHead> rightPlayerHeadDic; // 0x378
	System.String hudBloodNoDamageStr; // 0x380
	WizardGames.Soc.SocClient.Ui.UiBombHomePatternController uiController; // 0x388
	WizardGames.Soc.SocClient.Ui.UiBombHomePatternData uiData; // 0x390
	FairyGUI.GComponent gameCenterInfoCom; // 0x398
	System.Int64 updateDefendToolBoxHpTimerId; // 0x3a0
	FairyGUI.GComponent startTipCom; // 0x3a8
	FairyGUI.GTextField defendNumTipText; // 0x3b0
	FairyGUI.GTextField attackNumTipText; // 0x3b8
	FairyGUI.Transition startTipShowTrans; // 0x3c0
	FairyGUI.Transition startTipHideTrans; // 0x3c8
	System.Single startTipShowTs; // 0x3d0
	System.Single startTipShowTimeMs; // 0x3d4
	System.Void OnInitCenterInfo(FairyGUI.GComponent gameInfoCom); // 0x05a63054
	System.Void RenderLeftHeadList(System.Int32 index, FairyGUI.GObject obj); // 0x05a639fc
	System.Void RenderRightHeadList(System.Int32 index, FairyGUI.GObject obj); // 0x05a63d20
	System.Void PlayMemberInfoChange(); // 0x05a636c4
	System.Void PatternStateChangeCenterInfo(WizardGames.Soc.SocClient.Ui.PatternState curState, WizardGames.Soc.SocClient.Ui.PatternState lastState); // 0x05a64008
	System.Void SetDesText(System.String str); // 0x05a64504
	System.Void SetTimeText(System.String str); // 0x05a64674
	System.Void SetToolCupboardHpText(System.String str); // 0x05a645bc
	System.Void SetToolCupboardHpBarFillAmount(System.Single fillAmount); // 0x05a647c4
	System.Void ShowTimeChange(); // 0x05a64880
	System.Void ShowStatisticalPanel(); // 0x05a64aec
	System.Void UpdateDefendToolBoxHpTimer(System.Int64 timerId, System.Object callbackData, System.Boolean needDelete); // 0x05a64b50
	System.Void .ctor(); // 0x05a64d28
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x05a65108
	System.Void OnInit(); // 0x05a65188
	System.Void OnEnable(); // 0x05a65504
	System.Void OnDisable(); // 0x05a65a48
	System.Void UpdateTimeCheckTimer(); // 0x05a65ebc
	System.Void PatternStateChange(WizardGames.Soc.SocClient.Ui.PatternState curState, WizardGames.Soc.SocClient.Ui.PatternState lastState); // 0x055057d4
	System.Void HudInEdit(System.Boolean isInEdit); // 0x05a66618
	System.Void OnFps1Update(System.Single dt); // 0x05a666a4
	System.Void <UpdateTimeCheckTimer>b__38_0(); // 0x05a6671c
	System.Void <PatternStateChange>b__39_0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05a66794
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomePatternController : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiBombHomePatternData uiData; // 0x10
	System.Action<WizardGames.Soc.SocClient.Ui.PatternState,WizardGames.Soc.SocClient.Ui.PatternState> PatternStateChangeAction; // 0x18
	System.Action PlayMemberInfoChangeAction; // 0x20
	System.Action ShowTimeChangeAction; // 0x28
	System.Void set_PatternState(WizardGames.Soc.SocClient.Ui.PatternState value); // 0x05a65994
	System.Void set_Time(System.Int32 value); // 0x05a66d54
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiBombHomePatternData uiData); // 0x05a6507c
	System.Void OnEnableUi(); // 0x05a65650
	System.Void OnDisableUi(); // 0x05a65bfc
	System.Void OnUpdateTime(); // 0x05a660a0
	System.Void ServerStageUpdate(WizardGames.Soc.Common.Data.Play1.StageType stageType); // 0x05a66e0c
	System.Void GameOver(System.Boolean isVictory); // 0x05a66f4c
	System.Void ShowBombHomeTip(); // 0x05a67058
	System.Void SyncBombHomeTime(System.Int32 stageStartTime, WizardGames.Soc.Common.Data.Play1.StageType stageType); // 0x05a670b8
	System.Void BombHomeCleanup(); // 0x05a671ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomePatternData : System.Object
{
	System.Int32 resetTime; // 0x10
	System.Int32 prepaeationTime; // 0x14
	System.Int32 playingTime; // 0x18
	System.Int32 settlementTime; // 0x1c
	System.Int32 defendNumMax; // 0x20
	System.Int32 attackNumMax; // 0x24
	System.String combatTimeStr; // 0x28
	System.String killCountStr; // 0x30
	System.String destroyedBuildingsCountStr; // 0x38
	System.String assistCountStr; // 0x40
	System.String deathCountStr; // 0x48
	System.String damageStr; // 0x50
	System.Int32 defendEnum; // 0x58
	System.Int32 attackEnum; // 0x5c
	WizardGames.Soc.SocClient.Ui.PatternState patternState; // 0x60
	System.Int32 defendNum; // 0x64
	System.Int32 attackNum; // 0x68
	WizardGames.Soc.Common.Data.Play.CampType campType; // 0x6c
	System.Int32 time; // 0x70
	System.Int32 combatStartTime; // 0x74
	System.Int32 killCount; // 0x78
	System.Int32 destroyBuildingsCount; // 0x7c
	System.Int32 assistCount; // 0x80
	System.Int32 deathCount; // 0x84
	System.Int32 damagePlayerCount; // 0x88
	System.Int32 damagePartCount; // 0x8c
	System.Int32 stageStartTime; // 0x90
	WizardGames.Soc.SocClient.Ui.GameResult gameResult; // 0x94
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.PlayerInfo> attackPlayerInfoDic; // 0x98
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.PlayerInfo> defendPlayerInfoDic; // 0xa0
	System.Int32 get_CombatTime(); // 0x05a67258
	System.Numerics.Vector2 get_AllDefendToolBoxHPInfo(); // 0x05a6472c
	System.Void .ctor(); // 0x05a64efc
	System.Void Clear(); // 0x05a65910
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.PatternState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.PatternState NoneState = 0;
	static WizardGames.Soc.SocClient.Ui.PatternState ResetState = 1;
	static WizardGames.Soc.SocClient.Ui.PatternState WaitingState = 2;
	static WizardGames.Soc.SocClient.Ui.PatternState PreparationState = 3;
	static WizardGames.Soc.SocClient.Ui.PatternState PlayingState = 4;
	static WizardGames.Soc.SocClient.Ui.PatternState SettlementState = 5;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.GameResult : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.GameResult Victory = 0;
	static WizardGames.Soc.SocClient.Ui.GameResult Failure = 1;
	static WizardGames.Soc.SocClient.Ui.GameResult CombatConcluded = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlayerInfo : System.Object
{
	System.UInt64 roleId; // 0x10
	System.Int32 seatNo; // 0x18
	System.Int32 lifeCycleFlags; // 0x1c
	System.Single hp; // 0x20
	System.Single maxHp; // 0x24
	System.String headIconUrl; // 0x28
	System.Single get_HpProportion(); // 0x05a6730c
	System.Boolean get_isWound(); // 0x05a67384
	System.Boolean get_isDead(); // 0x05a673f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeSettlement : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent settlementCom; // 0x338
	FairyGUI.GTextField defendNumSettlementText; // 0x340
	FairyGUI.GTextField attackNumSettlementText; // 0x348
	FairyGUI.GTextField infoTitleText1; // 0x350
	FairyGUI.GTextField infoTitleText2; // 0x358
	FairyGUI.GTextField infoTitleText3; // 0x360
	FairyGUI.GTextField infoTitleText4; // 0x368
	FairyGUI.GTextField infoTitleText5; // 0x370
	FairyGUI.GTextField infoNumText1; // 0x378
	FairyGUI.GTextField infoNumText2; // 0x380
	FairyGUI.GTextField infoNumText3; // 0x388
	FairyGUI.GTextField infoNumText4; // 0x390
	FairyGUI.GTextField infoNumText5; // 0x398
	FairyGUI.GButton proceedToNextRoundBtn; // 0x3a0
	FairyGUI.GImage btnMask; // 0x3a8
	FairyGUI.Controller resultCtrl; // 0x3b0
	FairyGUI.Controller winResultCtrl; // 0x3b8
	System.Void OnInit(); // 0x05a6749c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05a67bb8
	System.Void OnEnable(); // 0x05a67ca8
	System.Void SetInfo(WizardGames.Soc.SocClient.Ui.UiBombHomePatternData info); // 0x05a66864
	System.Void .ctor(); // 0x05a67d3c
	System.Void <OnInit>b__17_0(); // 0x05a67dc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHead : System.Object
{
	FairyGUI.GComponent headCom; // 0x10
	FairyGUI.GLoader headLoader; // 0x18
	FairyGUI.GImage bloodBarImg; // 0x20
	FairyGUI.GImage frameImg; // 0x28
	FairyGUI.Controller sideCtrl; // 0x30
	FairyGUI.Controller stateCtrl; // 0x38
	FairyGUI.Controller bloodBarStateCtrl; // 0x40
	System.Int64 playerId; // 0x48
	System.Boolean isAttacker; // 0x50
	System.Void .ctor(FairyGUI.GComponent headCom, System.Boolean isAttacker); // 0x05a63af4
	System.Void Update(WizardGames.Soc.SocClient.Ui.PlayerInfo info, WizardGames.Soc.SocClient.Ui.UiBombHomePatternData uiData); // 0x05a63e0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDying : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	WizardGames.Soc.SocClient.Ui.UiDyingController uiController; // 0x338
	WizardGames.Soc.SocClient.Ui.UiDyingData uiData; // 0x340
	WizardGames.Soc.SocClient.Ui.UiDyingConfig uiConfig; // 0x348
	FairyGUI.GComponent btnCom; // 0x350
	FairyGUI.Controller aidOtherCtrl; // 0x358
	System.String uiDyingName; // 0x360
	System.Int32 msgBoxCounter; // 0x368
	System.Boolean hasClosedMsgBoxWhenOtherAiding; // 0x36c
	FairyGUI.GComponent panelRoot; // 0x370
	FairyGUI.GButton btnSuicide; // 0x378
	FairyGUI.GButton leftBtn; // 0x380
	FairyGUI.GButton cancelBtn; // 0x388
	FairyGUI.GLoader leftBtnIconLoader; // 0x390
	FairyGUI.GProgressBar aidBarImg; // 0x398
	FairyGUI.GTextField aidCutdown; // 0x3a0
	FairyGUI.GProgressBar selfAidBarImg; // 0x3a8
	FairyGUI.GTextField selfAidCutdown; // 0x3b0
	FairyGUI.GTextField text; // 0x3b8
	FairyGUI.GTextField spawnProb; // 0x3c0
	FairyGUI.GTextField title; // 0x3c8
	FairyGUI.GImage di; // 0x3d0
	FairyGUI.GImage proportion; // 0x3d8
	FairyGUI.GButton tipBtn; // 0x3e0
	FairyGUI.GComponent tipCom; // 0x3e8
	FairyGUI.Controller btnWithBarController; // 0x3f0
	FairyGUI.GTextField tipText; // 0x3f8
	System.Int64 startCountdown; // 0x400
	FairyGUI.GComponent btnWithBarCom; // 0x408
	FairyGUI.GImage suicideBarBarImg; // 0x410
	FairyGUI.GImage suicideBarBarImg2; // 0x418
	FairyGUI.GTextField remainTime; // 0x420
	System.Void .ctor(); // 0x05a67ea8
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x05a68284
	System.Void OnInit(); // 0x05a68304
	System.Void OnChangeWasAided(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int64 oldValue, System.Int64 newValue); // 0x05a691c0
	System.Void ShowSuicideMsgBox(); // 0x05a693b8
	System.Void OnEnable(); // 0x05a69b04
	System.Void OnDisable(); // 0x05a6a030
	System.Void OnDestroy(); // 0x05a6a308
	System.Void OnFps10Update(System.Single dt); // 0x05a6a3b4
	System.Void OnSettingWinOpen(System.Boolean isOpen); // 0x05a6ae70
	System.Void InAidingOtherState(System.Boolean aiding); // 0x05a6af90
	System.Void RefreshEscCallback(); // 0x05a6b108
	System.Void SetTextFieldText(FairyGUI.GTextField textField, System.String textStr); // 0x05a6b394
	FairyGUI.GButton get_LeftBtn(); // 0x05a6b460
	System.Void OnInitDyingBtn(); // 0x05a685e4
	System.Void OnEnableDyingBtn(); // 0x05a69f80
	System.Void OnUpdateDyingBtn(); // 0x05a6a7c8
	System.Void CancelSelfCover(); // 0x05a6bc14
	System.Void DyingStateChangeDyingBtn(WizardGames.Soc.SocClient.Ui.EUiDyingState curState, WizardGames.Soc.SocClient.Ui.EUiDyingState lastState); // 0x05a6bf74
	System.Void LeftButtonPress(); // 0x05a6c060
	System.Void ResetBarAmount(); // 0x05a6bd38
	System.Void SetLeftBtnStyle(); // 0x05a6b588
	System.Void ChangeTipCom(); // 0x05a6c31c
	System.Void OnInitRemainTimeBar(FairyGUI.GComponent node); // 0x05a69088
	System.Void OnUpdateRemainTimeBar(); // 0x05a6abe8
	System.Void <OnEnable>b__15_0(); // 0x05a6c868
	System.Void <OnEnable>b__15_1(); // 0x05a6c8e4
	System.Boolean <RefreshEscCallback>b__21_0(); // 0x05a6ca20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDying.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiDying.<>c <>9; // 0x0
	static System.Action <>9__14_0; // 0x8
	static FairyGUI.EventCallback1 <>9__43_0; // 0x10
	static System.Void .cctor(); // 0x05a6caa4
	System.Void .ctor(); // 0x05a6cb08
	System.Void <ShowSuicideMsgBox>b__14_0(); // 0x05a6cb70
	System.Void <OnInitDyingBtn>b__43_0(FairyGUI.EventContext context); // 0x05a6cc20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDyingController : WizardGames.Soc.Common.Manager.MgrBase
{
	WizardGames.Soc.SocClient.Ui.UiDyingData data; // 0x18
	WizardGames.Soc.SocClient.Ui.UiDyingConfig config; // 0x20
	System.Boolean isAidingOther; // 0x28
	System.Boolean isAidingOtherInConstruction; // 0x29
	System.Action<WizardGames.Soc.SocClient.Ui.EUiDyingState,WizardGames.Soc.SocClient.Ui.EUiDyingState> DyingStateChangeAction; // 0x30
	System.Action<System.Boolean> AidingOtherAction; // 0x38
	WizardGames.Soc.SocClient.Ui.UiDyingData get_DyingData(); // 0x05a6cd88
	WizardGames.Soc.SocClient.Ui.UiDyingConfig get_DyingConfig(); // 0x05a6cdec
	System.Void set_UiDyingState(WizardGames.Soc.SocClient.Ui.EUiDyingState value); // 0x05a6bb60
	System.Void .ctor(); // 0x05a68050
	System.Void UiEnable(); // 0x05a69eb4
	System.Threading.Tasks.Task OnExitWorld(); // 0x05a6d034
	System.Void DyingStateChange(WizardGames.Soc.SocClient.Ui.EUiDyingState curState, WizardGames.Soc.SocClient.Ui.EUiDyingState lastState); // 0x05a6d0bc
	System.Void InAidingOtherState(System.Boolean aiding); // 0x05a6d330
	System.Void UpdateDyingInfo(); // 0x05a6a4d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDyingData : System.Object
{
	WizardGames.Soc.Common.Entity.PlayerEntity myPlayerEntity; // 0x10
	System.Int64 suicideTs; // 0x18
	WizardGames.Soc.SocClient.Ui.EUiDyingState uiDyingState; // 0x20
	System.Int32 waitingInEmergencyState; // 0x24
	System.Boolean suicideByWoundBtn; // 0x28
	WizardGames.Soc.Common.Entity.PlayerEntity get_MyPlayerEntity(); // 0x05a699b4
	System.Boolean get_IsWounded(); // 0x05a6b2ec
	System.Boolean get_IsDead(); // 0x05a6ad88
	System.Boolean get_WasAided(); // 0x05a6bab8
	System.Boolean get_IsOtherAiding(); // 0x05a692b0
	System.Boolean get_IsAidingOther(); // 0x05a69e28
	System.Boolean get_IsIncapacitated(); // 0x05a6c56c
	System.Boolean get_CanSelfAid(); // 0x05a6c150
	System.String get_ResurrectChance(); // 0x05a6c1f4
	System.Single get_DyingCountdown(); // 0x05a6c3e0
	System.Single get_EmergencyProgress(); // 0x05a6b9ac
	System.Single get_AidCompleteDuration(); // 0x05a6b4c4
	System.Int32 get_AidDurationLeft(); // 0x05a6b874
	System.Boolean get_HasMedicine(); // 0x05a69904
	System.Void .ctor(); // 0x05a6ce50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDyingConfig : System.Object
{
	System.Int32 suicideTimeMs; // 0x10
	System.String leftBarInEmergencyUrl; // 0x18
	System.String leftBarInEmergencyGrayUrl; // 0x20
	System.String selfAidProbStr; // 0x28
	System.String dyingTipTextStr; // 0x30
	System.String medicineTipTextStr; // 0x38
	System.String rescueSelfStr; // 0x40
	System.String inRescueStr; // 0x48
	System.Single get_LieTime(); // 0x05a6c610
	System.Single get_CrawlTime(); // 0x05a6c73c
	System.Void .ctor(); // 0x05a6ceb8
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EUiDyingState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EUiDyingState None = 0;
	static WizardGames.Soc.SocClient.Ui.EUiDyingState WaitingForDeath = 1;
	static WizardGames.Soc.SocClient.Ui.EUiDyingState InEmergency = 2;
	static WizardGames.Soc.SocClient.Ui.EUiDyingState Suiciding = 3;
	static WizardGames.Soc.SocClient.Ui.EUiDyingState Dead = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrPopQueue : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.List<System.String> popList; // 0x8
	System.String[] ignoreUI; // 0x18
	System.Void Init(); // 0x05a6d4c4
	System.Void PopWindow(System.String uiName, System.Boolean forceDelay); // 0x05a6d5dc
	System.Void OnHideUi(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05a6dc84
	System.Boolean HasPopWinOpened(WizardGames.Soc.Common.Unity.Ui.LayerComBase layer); // 0x05a6da8c
	System.Void OpenNextPanel(); // 0x05a6dba8
	System.Void Destroy(); // 0x05a6dcfc
	System.Void .ctor(); // 0x05a6de14
	static System.Void .cctor(); // 0x05a6df1c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.MgrPopQueue.<OpenNextPanel>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Ui.MgrPopQueue <>4__this; // 0x38
	WizardGames.Soc.Common.Unity.Ui.LayerComBase <layer>5__2; // 0x40
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x48
	System.Void MoveNext(); // 0x05a6e048
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x05a6e454
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrUi : WizardGames.Soc.Common.Unity.Ui.MgrUiBase
{
	static SocLogger <Logger>k__BackingField; // 0x0
	System.String curMuiltLanAssetPackage; // 0xf0
	FairyGUI.GComponent curFGUIPopupLayer; // 0xf8
	System.Collections.Generic.Dictionary<System.String,System.String> uiOpenSound; // 0x100
	System.Collections.Generic.Dictionary<System.String,System.String> uiCloseSound; // 0x108
	System.Int32 uberAHashCount; // 0x110
	System.Boolean IsInLotteryCGVideo; // 0x114
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.MgrUi.FontInfo> autoChangeFonts; // 0x118
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.MgrUi.FontInfo> commonFonts; // 0x120
	System.Collections.Generic.Dictionary<System.String,System.String> abPathToFontName; // 0x128
	System.Collections.Generic.HashSet<System.String> needUnloadAbPath; // 0x130
	System.Collections.Generic.HashSet<System.String> dontAutoRemoveWhenOutOfDate; // 0x138
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.HashSet<FairyGUI.PackageItemAtlas>> autoRemoveAtlasItems; // 0x140
	ItemIconPool <GlobalIconPool>k__BackingField; // 0x148
	FairyGUI.GComponent <ComItemWidgetsRoot>k__BackingField; // 0x150
	WizardGames.Soc.SocClient.Ui.ComIconSeedPool <GlobalComSeedPool>k__BackingField; // 0x158
	WizardGames.Soc.SocClient.Ui.ComIconDoubleClick globalComDoubleClickTips; // 0x160
	System.Collections.Generic.HashSet<System.String> lootingUiSet; // 0x168
	System.Boolean DontHideUiInventoryWhenStopLooting; // 0x170
	System.Int32 <IsBlockCursorSwitch>k__BackingField; // 0x174
	System.Boolean <IsHighLobbyModelScene>k__BackingField; // 0x178
	System.Boolean IsUsedStaticLobbyModel; // 0x179
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.MgrUi.RendererScaleInfo> rendererInfoDic; // 0x180
	UnityEngine.Rendering.Universal.CustomSuperResolutionMode curUpScalingMode; // 0x188
	System.Int32 CloseUpScalingModeCount; // 0x18c
	WizardGames.Soc.SettingsFramework.Framework.CompositeGroup qualityGroup; // 0x190
	System.Collections.Generic.Dictionary<UnityEngine.AzureSky.AzureWeatherPresetEnum,UnityEngine.AzureSky.EAzureControllerPresetEnum> weatherDic; // 0x198
	UnityEngine.AzureSky.AzureWeatherPresetEnum preTODEnum; // 0x1a0
	WizardGames.Soc.SocClient.Ui.ComCommonVideo videoInstance; // 0x1a8
	System.Int32 currentSwitchCursorMode; // 0x1b0
	System.Collections.Generic.HashSet<System.String> _activeCursorKeys; // 0x1b8
	WizardGames.Soc.Common.Data.ECursorShowType _currentCursorShowType; // 0x1c0
	WizardGames.Soc.SocClient.Manager.EResponseLevel <CursorResponseLevel>k__BackingField; // 0x1c4
	static SocLogger get_Logger(); // 0x05a6e4d4
	System.Int32 get_DesignW(); // 0x05a6e55c
	System.Int32 get_DesignH(); // 0x05a6e5c0
	System.String get_ResPath(); // 0x05a6e624
	System.String get_DefaultFont(); // 0x05a6e69c
	WizardGames.Soc.Common.Unity.Event.MgrMsg get_eventCenter(); // 0x05a6e714
	System.Boolean get_IsTouchOnUi(); // 0x05a6e7a4
	ItemIconPool get_GlobalIconPool(); // 0x05a6e8cc
	System.Void set_GlobalIconPool(ItemIconPool value); // 0x05a6e930
	FairyGUI.GComponent get_ComItemWidgetsRoot(); // 0x05a6e9b0
	System.Void set_ComItemWidgetsRoot(FairyGUI.GComponent value); // 0x05a6ea14
	WizardGames.Soc.SocClient.Ui.ComIconSeedPool get_GlobalComSeedPool(); // 0x05a6ea94
	System.Void set_GlobalComSeedPool(WizardGames.Soc.SocClient.Ui.ComIconSeedPool value); // 0x05a6eaf8
	System.Int32 get_IsBlockCursorSwitch(); // 0x05a6eb78
	System.Void set_IsBlockCursorSwitch(System.Int32 value); // 0x05a6ebdc
	System.Boolean get_IsHighLobbyModelScene(); // 0x05a6ec54
	System.Void set_IsHighLobbyModelScene(System.Boolean value); // 0x05a6ecb8
	System.Void Init(); // 0x05a6ed34
	System.Void SetIsHighLobbyModelScene(System.Boolean value); // 0x05a708bc
	System.Void Destroy(); // 0x05a7096c
	System.Void InitTexiFieldLanSetting(); // 0x05a70464
	WizardGames.Soc.Common.Data.MuiltLanTextStyleCfg GetFontTextStyleOffset(System.String fontName, WizardGames.Soc.Common.Data.language.LanguageConfig lanCfg); // 0x05a70c14
	System.Int32 HandleTextSizeMuiltLanStyle(FairyGUI.TextFormat tf, System.Int32 oriSize); // 0x05a70e78
	System.Int32 HandleTextLineSpacingMuiltLanStyle(FairyGUI.TextFormat tf, System.Int32 oriSpacing); // 0x05a71094
	System.Int32 HandleTextLetterSpacingMuiltLanStyle(FairyGUI.TextFormat tf, System.Int32 oriSpacing); // 0x05a712a0
	System.Void RegisterProximaCmds(); // 0x05a70734
	System.Void ShowComDoubleClickTips(FairyGUI.GComponent parent, System.String tips); // 0x05a714ac
	System.Void HideComDoubleClickTips(FairyGUI.GComponent parent); // 0x05a71708
	System.Boolean ComDoubleClickTipsIsVisible(FairyGUI.GComponent parent); // 0x05a71864
	System.Void InitMuiltLanguage(); // 0x05a6fe1c
	System.Void AppendAutoChangeFonts(WizardGames.Soc.SocClient.Ui.MgrUi.EFontType type, System.String assetPath); // 0x05a71998
	System.String GetFontName(System.String originFontName); // 0x05a71aa8
	System.Threading.Tasks.Task OnEnterWorld(); // 0x05a71b88
	System.Threading.Tasks.Task OnExitWorld(); // 0x05a71c98
	System.Void RegisterSpecialPackageLoader(); // 0x05a71da8
	System.Void DoGamePreLoad(); // 0x05a721b4
	System.Void DoLobbyPreLoad(); // 0x05a72378
	System.Void ClearAllWindow(System.Boolean alsoClearPersistent); // 0x05a723e0
	System.Void PopFullScreenWinStackToBottomWin(); // 0x05a72a0c
	System.Void OnLowMemory(); // 0x05a72e18
	System.Boolean IsShowHomeBtn(); // 0x05a72f3c
	System.Void AppendToAutoRemoveAtlas(FairyGUI.PackageItemAtlas item); // 0x05a73060
	System.Void RemoveFromAutoRemoveAtlas(FairyGUI.PackageItemAtlas item); // 0x05a73274
	System.Void CheckAndRemoveAtlas(); // 0x05a72538
	System.Void OnFps1UpdateOtherMgrUIData(System.Single dt); // 0x05a73420
	System.Void OnFps1UpdateUI(System.Single dt); // 0x05a734e0
	System.Void OnFpsUnlimitedUpdateUI(System.Single dt); // 0x05a73af8
	System.Void OnFpsUnlimitedUpdateUI_Input(System.Single dt); // 0x05a73c7c
	System.Void InitStageCamera(); // 0x05a6faac
	System.Void RefreshStageCameraState(UnityEngine.Camera sceneCamera); // 0x05a73de0
	System.Void RefreshStageCameraState(); // 0x05a73d2c
	System.Void CreateAllLayers(); // 0x05a74194
	System.Void CreateCustomPopupLayer(); // 0x05a743b8
	System.Void RegisterAllWindow(); // 0x05a7478c
	System.Void RegisterAllComs(); // 0x05a74c70
	System.Void RegisterItemComs(); // 0x05a761d8
	System.Void RegisterBtnComs(); // 0x05a764d0
	System.Void RegisterSettingComs(); // 0x05a76a58
	System.Void RegisterLittleGameComs(); // 0x05a76d8c
	System.Void RegisterUGCInspectorComs(); // 0x05a76f38
	System.Void RegisterComBtnKeyTipsComs(); // 0x05a7691c
	System.Void BrforeWindowAddToStage(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05a770dc
	System.Void BrforeWindowRemoveFromStage(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05a7737c
	System.Void OnWindowAddToStage(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05a77694
	System.Void OnWindowRemoveFromStage(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05a780bc
	System.Boolean StartGuide(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05a77c48
	System.Void HandleWinOnHideOrRemove(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05a784c8
	System.Void AddLootingInfo(System.String name); // 0x05a78640
	System.Void RemoveLootingInfo(System.String name); // 0x05a785a4
	System.Void CloseWinWhenStopLooting(); // 0x05a78718
	System.Boolean PackageFilter(System.String packName); // 0x05a7891c
	System.String CheckAndLoadLanAssetPackage(System.String lanStr); // 0x05a789e0
	System.String TransMuiltKeyImgKey(System.String key); // 0x05a78d8c
	System.String TransMultiImgUrl(System.String defaultUrl); // 0x05a78edc
	System.String TransMuiltLanFontName(System.String fontName, System.Boolean isBold); // 0x05a79098
	UnityEngine.Object TransFontNameToABPathAndTryLoad(System.String fontName); // 0x05a792c0
	System.Void UnloadFontAbs(); // 0x05a7949c
	System.Void ResetTextFieldAvoidOnHeadChars(WizardGames.Soc.SocClient.Data.LanguageId tarLanId); // 0x05a70a3c
	System.Void OnLanguageSwitch(WizardGames.Soc.SocClient.Data.LanguageId tarLanId); // 0x05a7965c
	System.Boolean IsWindowPersistent(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05a79730
	System.String PrepareItemIconUrl(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, WizardGames.Soc.Common.Data.DataItem.SkinConfig skinCfg, System.Boolean tryAsHorizontal); // 0x05a7981c
	System.Void PlayFGUIClickSound(System.Int32 audioId); // 0x05a799e4
	System.Void PlaySocAudio(System.String soundEvent); // 0x05a79b40
	System.Void SetLoaderImgShaderForUiModel(FairyGUI.GLoader loader); // 0x05a79ca0
	System.Void AddListArrow(FairyGUI.GList list); // 0x05a79e78
	System.Void CreateArrowRootObject(FairyGUI.GList bindList, WizardGames.Soc.SocClient.Ui.ComListArrow.EArrowStyle style, System.String arrowIcon); // 0x05a7a10c
	System.Void AddListEmptyCom(FairyGUI.GList list); // 0x05a7a494
	System.Void CreateEmptyRootObject(FairyGUI.GList bindList, System.String url); // 0x05a7a55c
	System.Boolean IsScreenPosInUI(UnityEngine.Vector2 screenPos, FairyGUI.GObject targetUI); // 0x05a7a840
	System.Boolean IsScreenPosInUI(UnityEngine.Vector2 screenPos, UnityEngine.Vector2 targetXY, System.Single targetHeight, System.Single targetWidth); // 0x05a7abc8
	System.Boolean CheckPackage_SingleTexturePerAB(System.String packageName, System.Boolean bLoadFromAb, System.String proxyPostfix); // 0x05a7aca8
	FairyGUI.UIPackage LoadPackage_SingleTexturePerAB(System.String packageName, System.Boolean bLoadFromAb, System.String proxyPostfix); // 0x05a7aee0
	static System.Void TextureCustomDestory(UnityEngine.Texture nt); // 0x05a7b47c
	System.Void HideAllWindowsByWounded(); // 0x05a7b51c
	System.Void HideAllWindowsByDeath(System.Boolean isForceRemove); // 0x05a7b980
	System.Void HideAllWindowsByNewbieStory(); // 0x05a7be6c
	System.Void GetUiGoPoolInfos(System.Int32& nomalSize, System.Int32& withRenderSize, System.Int32& normalResizeTimes, System.Int32& renderResizeTimes); // 0x05a7c350
	T GetCurrentFont<T>(System.Boolean isBold); // 0x052af1f0
	System.Boolean RemoteSwitchUI(System.String uiName, System.Boolean toggle); // 0x05a7c5c4
	System.Void JumpToOpenUI(System.String uiName, WizardGames.Soc.SocClient.Ui.JumpData data, WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType triggerType, WizardGames.Soc.SocClient.Manager.EUiJumpSource jumpSource); // 0x05a7c68c
	System.Void JumpToOpenUI(System.Int32 id, WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType triggerType, WizardGames.Soc.SocClient.Manager.EUiJumpSource jumpSource); // 0x05a7c910
	System.Void ForeachWindow(System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> action, System.Boolean visibleOnly); // 0x05a7cab4
	System.Boolean HasFullWinIsOpen(); // 0x05a7ccd4
	System.Void AddUberAHashCount(); // 0x05a7cdd4
	System.Void SubUberAHashCount(); // 0x05a7ce88
	System.Void CreateRTSetRenderScaleOne(System.Single rtWidth, System.Single rtHeight, UnityEngine.RenderTexture& rtForModel, UnityEngine.Camera camera, System.Int32 depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite); // 0x05a7cf3c
	System.Void ExpandRenderScaleOne(UnityEngine.Camera camera); // 0x05a7d12c
	System.Void RevertRenderScale(UnityEngine.Camera camera); // 0x05a7d678
	System.Void CloseUpScalingMode(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05a77a10
	System.Void SetUpScalingMode(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05a782e8
	System.Int32 GetQualityVideoParams(); // 0x05a7da00
	System.String GetVideoQualitySuffix(System.Int32 qualityLevel); // 0x05a7e0b4
	System.String UpdateAdjustedPath(System.String basePath, System.Boolean enableQualityMatc, System.Boolean enableLanguageMatch); // 0x05a7e1d0
	System.Void AddDependciesPackage(System.Collections.Generic.List<System.String> packageNames, System.String uiName); // 0x05a7e5f4
	System.Void RemoveDependciesPackage(System.Collections.Generic.List<System.String> packageNames, System.String uiName); // 0x05a7e7ac
	System.Void SwitchWeather(UnityEngine.AzureSky.AzureWeatherPresetEnum presetEnum, WizardGames.Soc.SocClient.Entity.ERegSrc regSrc, UnityEngine.AzureSky.EAzureControllerPresetEnum newPreset); // 0x05a7e95c
	System.Void RecoverWeather(UnityEngine.AzureSky.AzureWeatherPresetEnum presetEnum, WizardGames.Soc.SocClient.Entity.ERegSrc regSrc); // 0x05a7ebe8
	System.Void InitVideoMgr(); // 0x05a70794
	System.Void VideoStartPlay(WizardGames.Soc.SocClient.Ui.ComCommonVideo video); // 0x05a7eea0
	System.Void VideoStop(WizardGames.Soc.SocClient.Ui.ComCommonVideo video); // 0x05a7f034
	System.Boolean get_CursorVisible(); // 0x05a7f158
	System.Int32 get_SwitchCursorMode(); // 0x05a7f1c4
	System.Void set_CursorResponseLevel(WizardGames.Soc.SocClient.Manager.EResponseLevel value); // 0x05a7f228
	System.Void UpdateCursorState(); // 0x05a7f2a0
	System.Boolean get_shouldHideCursor(); // 0x05a7f470
	System.Void WindowStateChangeEvent(WizardGames.Soc.Common.Unity.Ui.WindowComBase window, System.Boolean isOpen); // 0x05a7f4f4
	System.Void UpdateCursorRegistration(System.String key, System.Boolean show, WizardGames.Soc.SocClient.Ui.MgrUi.ECursorVisible cursorVisible); // 0x05a7f734
	System.Void EnterCursorSwitchButton(); // 0x05a7fd74
	System.Void ReleaseCursorSwitchButton(); // 0x05a7ff40
	System.Void AddCursorKey(System.String key, WizardGames.Soc.SocClient.Ui.MgrUi.ECursorVisible cursorVisible); // 0x05a7f9e8
	System.Void RemoveCursorKey(System.String key); // 0x05a7fbc4
	System.Boolean ShouldUpdateCursorState(); // 0x05a8010c
	System.Void UpdateCursorVisibility(System.Boolean force); // 0x05a7f6c0
	System.Void ProcessCursor(); // 0x05a80318
	System.Void SetCursorVisibility(System.Boolean isVisible, System.Boolean force, WizardGames.Soc.SocClient.Ui.MgrUi.ECursorVisible cursorVisible); // 0x05a8018c
	System.Void SetCursorControlSwitchMobile(); // 0x05a80378
	System.Void OnPlatformInit(); // 0x05a706d4
	System.Void OnPlatformDestroy(); // 0x05a709dc
	System.Void RegisterPlatformComs(); // 0x05a77030
	System.Single GetScaleFactor(); // 0x05a74674
	System.Boolean CheckIsNarrowWin(); // 0x05a8042c
	System.Void OnParallaxMoveEffectUpdate(System.Single dt); // 0x05a73c08
	System.Void InitSafeSizeMinX(); // 0x05a6f958
	System.Int32 GetCurrentQualityIndex(); // 0x05a7df08
	WizardGames.Soc.SettingsFramework.Framework.CompositeGroup GetCompositeGroup(); // 0x05a7de18
	UnityEngine.Rect OnCalCfgSpecialAdapt(UnityEngine.Rect safeArea); // 0x05a805e8
	System.ValueTuple<System.Boolean,UnityEngine.Rect> OnCalCfgAdapt(UnityEngine.Rect safeArea); // 0x05a80798
	System.Void HotKeyRunEnvAddFromStage(System.Int32 index); // 0x05a77308
	System.Void HotKeyRunEnvRemoveFromStage(System.Int32 index); // 0x05a77620
	System.Void .ctor(); // 0x05a80a4c
	static System.Void .cctor(); // 0x05a81090
	FairyGUI.UIPackage <Init>b__64_0(System.String packName); // 0x05a81164
	System.Void <Init>b__64_1(System.String packName); // 0x05a811f0
	System.Threading.Tasks.Task <>n__0(); // 0x05a81274
	System.Threading.Tasks.Task <>n__1(); // 0x05a812dc
	System.Void <CreateArrowRootObject>b__134_0(); // 0x05a81344
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.MgrUi.EFontType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.MgrUi.EFontType BoldTMP = 0;
	static WizardGames.Soc.SocClient.Ui.MgrUi.EFontType RegularTMP = 1;
	static WizardGames.Soc.SocClient.Ui.MgrUi.EFontType BoldBitmap = 2;
	static WizardGames.Soc.SocClient.Ui.MgrUi.EFontType RegularBitmap = 3;
	static WizardGames.Soc.SocClient.Ui.MgrUi.EFontType Title = 4;
	static WizardGames.Soc.SocClient.Ui.MgrUi.EFontType Common = 5;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.MgrUi.FontInfo : System.ValueType
{
	WizardGames.Soc.SocClient.Ui.MgrUi.EFontType fontType; // 0x10
	System.String abPath; // 0x18
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.MgrUi.RendererScaleInfo : System.ValueType
{
	System.Single oldRendererScale; // 0x10
	System.Int32 count; // 0x14
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.MgrUi.ECursorVisible : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.MgrUi.ECursorVisible None = 0;
	static WizardGames.Soc.SocClient.Ui.MgrUi.ECursorVisible Hide = 1;
	static WizardGames.Soc.SocClient.Ui.MgrUi.ECursorVisible Show = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrUi.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.MgrUi.<>c <>9; // 0x0
	static FairyGUI.UIObjectFactory.GLoaderCreator <>9__64_2; // 0x8
	static System.Void .cctor(); // 0x05a81af0
	System.Void .ctor(); // 0x05a81b54
	FairyGUI.GLoader <Init>b__64_2(); // 0x05a81bbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrUi.<>c__DisplayClass140_0 : System.Object
{
	System.String proxyPostfix; // 0x10
	System.String packageName; // 0x18
	WizardGames.Soc.SocClient.Ui.MgrUi <>4__this; // 0x20
	System.String descPath; // 0x28
	System.Void .ctor(); // 0x05a81c48
	System.Object <LoadPackage_SingleTexturePerAB>b__0(System.String name, System.String extension, System.Type type, FairyGUI.DestroyMethod& destroyMethod); // 0x05a81cb0
	System.Void <LoadPackage_SingleTexturePerAB>b__1(FairyGUI.UIPackage pkg); // 0x05a81ef0
	System.Byte[] <LoadPackage_SingleTexturePerAB>b__2(); // 0x05a81f74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrUi.<>c__DisplayClass142_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Ui.WindowComBase> toRemove; // 0x10
	System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__0; // 0x18
	System.Void .ctor(); // 0x05a820bc
	System.Void <HideAllWindowsByWounded>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05a82124
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrUi.<>c__DisplayClass143_0 : System.Object
{
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Ui.WindowComBase,System.Boolean> toRemove; // 0x10
	System.Boolean isForceRemove; // 0x18
	System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__0; // 0x20
	System.Void .ctor(); // 0x05a82280
	System.Void <HideAllWindowsByDeath>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05a822e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrUi.<>c__DisplayClass144_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Ui.WindowComBase> toRemove; // 0x10
	System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__0; // 0x18
	System.Void .ctor(); // 0x05a823f0
	System.Void <HideAllWindowsByNewbieStory>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05a82458
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrUi.<>c__DisplayClass148_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.JumpData data; // 0x10
	System.Void .ctor(); // 0x05a826b0
	System.Void <JumpToOpenUI>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05a82718
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrUi.<>c__DisplayClass150_0 : System.Object
{
	System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> action; // 0x10
	System.Void .ctor(); // 0x05a82858
	System.Void <ForeachWindow>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05a828c0
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.MgrUi.<OnEnterWorld>d__80 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Ui.MgrUi <>4__this; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x38
	System.Void MoveNext(); // 0x05a82964
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x05a82df4
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.MgrUi.<OnExitWorld>d__81 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Ui.MgrUi <>4__this; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x38
	System.Void MoveNext(); // 0x05a82e98
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x05a83354
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GObjectExtend : System.Object
{
	
	static FairyGUI.EventCallback1 GetSoundClickCallBack(FairyGUI.GObject obj, System.String soundEvent, FairyGUI.EventCallback1 callback); // 0x05a833f8
	static FairyGUI.EventCallback1 SetSoundClick(FairyGUI.GObject obj, System.String soundEvent, FairyGUI.EventCallback1 callback, System.Boolean useAdd); // 0x05a83570
	static System.Void BindArrowVisibleExtCondition(FairyGUI.GList list, System.Func<System.Boolean> func); // 0x05a836e8
	static System.Void ForceSetArrowVisible(FairyGUI.GList list, System.Boolean visible); // 0x05a83924
	static System.Void SetArrowVisible(FairyGUI.GList list, System.Boolean visible); // 0x05a83b14
	static System.Void SetCompliantUrl(FairyGUI.GLoader loader, System.String url); // 0x05a83d1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GObjectExtend.<>c__DisplayClass0_0 : System.Object
{
	System.String soundEvent; // 0x10
	FairyGUI.EventCallback1 callback; // 0x18
	System.Void .ctor(); // 0x05a83508
	System.Void <GetSoundClickCallBack>b__0(FairyGUI.EventContext ctx); // 0x05a83e44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReputationBadge : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	FairyGUI.Controller showSelectCtrl; // 0x338
	FairyGUI.GList selectBadgeList; // 0x340
	FairyGUI.GTextField badgeLevelTxt; // 0x348
	System.Int64 curLootingEntityId; // 0x350
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.UiReputationBadgeItem> showBadgeItemDic; // 0x358
	System.Collections.Generic.List<FairyGUI.GButton> btnList; // 0x360
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Reputation.BadgeSlotData> badgeSlotDatas; // 0x368
	System.Collections.Generic.List<System.Boolean> badgesAppearAnimStatus; // 0x370
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Reputation.BadgeData> badgeDatas; // 0x378
	System.Int32 lastLevel; // 0x380
	System.Int32 lastSlotIndex; // 0x384
	System.Int32 selectSlotIndex; // 0x388
	System.Int32 selectBadgeIndex; // 0x38c
	FairyGUI.GGroup groupSelectAnim; // 0x390
	FairyGUI.Transition selectAnim; // 0x398
	FairyGUI.GImage targetImage; // 0x3a0
	FairyGUI.GGraph emptyClickArea; // 0x3a8
	FairyGUI.GComponent badgeSelectRoot; // 0x3b0
	FairyGUI.GTextField badgeNameTxt; // 0x3b8
	FairyGUI.GTextField badgeDescTxt; // 0x3c0
	FairyGUI.GTextField badgeUnlockLevelTxt; // 0x3c8
	FairyGUI.Controller levelLimitCtr; // 0x3d0
	FairyGUI.GProgressBar unlockProgress; // 0x3d8
	FairyGUI.GButton equipBtn; // 0x3e0
	FairyGUI.Controller islockCtr; // 0x3e8
	FairyGUI.GComponent content; // 0x3f0
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x3f8
	System.Int32 defaultCloseWinDistanceSqr; // 0x400
	System.Void OnInit(); // 0x05a83fb0
	System.Void OnEnable(); // 0x05a84b50
	System.Void OnDisable(); // 0x05a851a4
	System.Void OnDestroy(); // 0x05a853a0
	System.Void OnEntityRemoved(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05a854d0
	System.Void OnTeamMemberChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x05a856c8
	System.Void RefreshReputationLevel(); // 0x05a85814
	System.Void OnClickSlot(System.Int32 index); // 0x05a85934
	System.Void PlaySelectAnim(System.Int32 index); // 0x05a85c50
	System.Void AutoSelectBadge(); // 0x05a86000
	System.Void RefreshBadges(); // 0x05a84f78
	System.Void OnRenderShowBadgeItem(System.Int32 index, FairyGUI.GButton gBtn); // 0x05a8669c
	System.Void OnSelectBadgeClick(System.Int32 index); // 0x05a8708c
	System.Void OnRenderSelectBadgeItem(System.Int32 index, FairyGUI.GObject obj); // 0x05a87654
	System.Void OnClickEquipBack(FairyGUI.EventContext context); // 0x05a87a00
	System.Void OnUpdateSlots(); // 0x05a87cbc
	System.Void OnUpdateBadges(); // 0x05a87d34
	System.Void RefreshSlots(); // 0x05a84e74
	System.Void InitUiReputationBadges(); // 0x05a84900
	System.Boolean HasUnlockedSlot(); // 0x05a86520
	static System.Void OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiReputationBadge> callBack); // 0x05a87da4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05a87e04
	static System.Void CloseWindow(FairyGUI.EventContext context); // 0x05a855dc
	static WizardGames.Soc.SocClient.Ui.UiReputationBadge GetWindow(); // 0x05a87e7c
	System.Void OnFps10Update(System.Single dt); // 0x05a87f3c
	System.Void CheckDistance(); // 0x05a88004
	System.Void .ctor(); // 0x05a88230
	System.Void <OnInit>b__27_0(); // 0x05a8847c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReputationBadge.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiReputationBadge.<>c <>9; // 0x0
	static FairyGUI.PlayCompleteCallback <>9__35_0; // 0x8
	static System.Void .cctor(); // 0x05a884f8
	System.Void .ctor(); // 0x05a8855c
	System.Void <PlaySelectAnim>b__35_0(); // 0x05a885c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReputationBadge.<>c__DisplayClass37_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiReputationBadge <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Int32 choseIndex; // 0x1c
	System.Void .ctor(); // 0x05a864b8
	System.Void <AutoSelectBadge>b__0(System.Int64 timerId, System.Object myData, System.Boolean delete); // 0x05a88624
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReputationBadge.<>c__DisplayClass41_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiReputationBadge <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x05a87998
	System.Void <OnRenderSelectBadgeItem>b__0(); // 0x05a88700
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReputationBadgeItem : System.Object
{
	FairyGUI.GButton btn; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> index2TypeCtrlDic; // 0x18
	FairyGUI.Controller state; // 0x20
	FairyGUI.GTextField badge_name_txt; // 0x28
	FairyGUI.GTextField unlock_level_txt; // 0x30
	FairyGUI.GLoader badge_icon; // 0x38
	FairyGUI.Controller typeCtrl; // 0x40
	FairyGUI.Controller selectCtrl; // 0x48
	System.Int32 index; // 0x50
	System.Action<System.Int32> callback; // 0x58
	FairyGUI.Controller get_StateCtrl(); // 0x05a887c4
	FairyGUI.GTextField get_BadgeNameTxt(); // 0x05a88828
	FairyGUI.GTextField get_UnlockLevelTxt(); // 0x05a8888c
	FairyGUI.GLoader get_BadgeIcon(); // 0x05a888f0
	System.Void .ctor(FairyGUI.GButton gBtn, System.Int32 index, System.Action<System.Int32> callback); // 0x05a86c20
	System.Void OnClickReputationBadgeItem(); // 0x05a889f4
	System.Void SetTypeCtrl(); // 0x05a88954
	System.Void SetSelectCtrl(System.Boolean isSelected); // 0x05a87000
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReputationRecord : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	WizardGames.Soc.SocClient.Ui.UiReputationRecordData uiReputationRecordData; // 0x338
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x340
	FairyGUI.GTextField levelTextField; // 0x348
	FairyGUI.GTextField prestigeValTextField; // 0x350
	FairyGUI.GTextField leftNumTextField; // 0x358
	FairyGUI.GImage progressImg; // 0x360
	FairyGUI.GList recordList; // 0x368
	FairyGUI.GList pageTipList; // 0x370
	System.Void .ctor(); // 0x05a88a78
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x05a88d58
	System.Void OnInit(); // 0x05a88dd8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05a8948c
	System.Void OnDestroy(); // 0x05a8950c
	System.Void OnEnable(); // 0x05a896cc
	System.Void OnDisable(); // 0x05a8a888
	System.Void OnFps10Update(System.Single dt); // 0x05a8ae70
	System.Void RenderRecordPage(System.Int32 index, FairyGUI.GObject obj); // 0x05a8af30
	System.Void OnScrollBarScroll(); // 0x05a8b0ac
	System.Void RefreshPageTipList(); // 0x05a8a390
	System.Void RenderRecordItem(System.Int32 index, FairyGUI.GObject obj); // 0x05a8b110
	System.Void RenderPageTipList(System.Int32 index, FairyGUI.GObject obj); // 0x05a8bb18
	System.Void RecordUpdateAction(System.Int32 recordNum); // 0x05a8bc08
	System.Void RequestRecordName(); // 0x05a8a540
	System.Void OnUpdateRecordName(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.PlayerBriefInfo> playerBriefInfoList); // 0x05a8bc80
	System.Void OnUpdateReputationName(System.Collections.Generic.Dictionary<System.Int64,System.String> id2Names); // 0x05a8be34
	System.Void PlayerTotalReputationUpdateAction(System.Int32 reputation); // 0x05a8bed0
	System.Void PlayerLevelUpdateAction(System.Int32 level); // 0x05a8c0ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReputationRecordData : System.Object
{
	System.Int32 lastRecordNum; // 0x10
	System.Int32 lastPlayerTotalReputation; // 0x14
	System.Int32 lastPlayerLevel; // 0x18
	System.Collections.Generic.List<System.UInt64> recordRoleIdList; // 0x20
	System.Collections.Generic.Dictionary<System.UInt64,System.String> recordRoleId2Names; // 0x28
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int64>> rankDic; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,System.Boolean> idsDic; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,System.String> id2Names; // 0x40
	System.Int32 curPageIndex; // 0x48
	System.Action<System.Int32> RecordUpdateAction; // 0x50
	System.Action<System.Int32> PlayerTotalReputationUpdateAction; // 0x58
	System.Action<System.Int32> PlayerLevelUpdateAction; // 0x60
	System.Int32 recordPageMax; // 0x68
	System.Int32 recordPageItemMax; // 0x6c
	System.Int64 subscribeId; // 0x70
	WizardGames.Soc.Common.Component.TerritoryCabinetComponent get_reputationConverter(); // 0x05a8c194
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.PlayerReputationRecord> get_RecordDict(); // 0x05a8a2dc
	WizardGames.Soc.Common.CustomType.BaseItemNode get_reputationNode(); // 0x05a8c298
	System.Int32 get_Reputation(); // 0x05a8a260
	System.Int32 get_Level(); // 0x05a8a080
	System.Int32 get_ReputationMax(); // 0x05a8a158
	System.Void OnEnable(); // 0x05a89e48
	System.Void OnDisable(); // 0x05a8accc
	System.Void Clear(); // 0x05a89584
	System.Void OnReputationRecordsChange(); // 0x05a8c324
	System.Void OnReputationNodeChange(); // 0x05a8c3f8
	System.Void OnLevelNodeChange(WizardGames.Soc.Share.Framework.CustomTypeBase comp, System.Int32 oldLevel, System.Int32 newLevel); // 0x05a8c494
	System.Void .ctor(); // 0x05a88b38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReputationRewardData : System.Object
{
	System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> defaultLevelRewardDic; // 0x10
	System.Collections.Generic.List<System.Int32> levelList; // 0x18
	System.Int32 selectedLevel; // 0x20
	System.Int32 selectedIndex; // 0x24
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> outGameRewardDic; // 0x28
	System.Collections.Generic.List<System.Int32> tempIntList; // 0x30
	System.Void .ctor(); // 0x05a8c568
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ReputationRewardRoot : System.Object
{
	static SocLogger logger; // 0x0
	FairyGUI.GList rewardList; // 0x10
	FairyGUI.GComponent expCom; // 0x18
	FairyGUI.GTextField levelTxt; // 0x20
	FairyGUI.GProgressBar expProgress; // 0x28
	WizardGames.Soc.SocClient.Ui.UiReputationRewardWnd parentWnd; // 0x30
	WizardGames.Soc.SocClient.Ui.ComBaseIcon lastClickIcon; // 0x38
	WizardGames.Soc.Common.Data.Reputation.ReputationLevelConfig <CurGetCfg>k__BackingField; // 0x40
	System.Int32 selectIndex; // 0x48
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.SimpleCustom.IntHashSetData> <AllSelectRewardId>k__BackingField; // 0x50
	System.Boolean NeedShowAni; // 0x58
	System.Void set_CurGetCfg(WizardGames.Soc.Common.Data.Reputation.ReputationLevelConfig value); // 0x05a8c6f8
	WizardGames.Soc.Common.Data.Reputation.ReputationLevelConfig get_CurGetCfg(); // 0x05a8c778
	System.Void set_AllSelectRewardId(System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.SimpleCustom.IntHashSetData> value); // 0x05a8c7dc
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.SimpleCustom.IntHashSetData> get_AllSelectRewardId(); // 0x05a8c85c
	System.Void Init(FairyGUI.GComponent rewardRoot, WizardGames.Soc.SocClient.Ui.UiReputationRewardWnd parent); // 0x05a8c8c0
	System.Void UpdateWnd(); // 0x05a8cc80
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05a8d0c4
	System.Void UpdateRewardCom(System.Int32 index, FairyGUI.GComponent com); // 0x05a8d160
	System.Void UpdateItemIcon(WizardGames.Soc.Common.Data.Reward dropReward, FairyGUI.GComponent com, System.Boolean isLock, System.Boolean isGet); // 0x05a8e0d8
	System.Void UpdateSelelctItemIcon(System.Int32 selectId, FairyGUI.GComponent com, System.Boolean isLock, System.Boolean isGet); // 0x05a8e424
	System.Void UpdateOutGameItemIcon(WizardGames.Soc.Common.Data.resource.ReleaseElements outItem, FairyGUI.GComponent com, System.Boolean isLock, System.Boolean isGet); // 0x05a8e7d4
	System.Void OnClickSelectItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, System.Int32 selectItemId); // 0x05a8ebc0
	System.Void OnClickItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05a8ee28
	System.Void OnClickOutGameItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05a8efe0
	System.Void OnHideItemTipsBack(); // 0x05a8f1a0
	System.Void CheckClickIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon newIcon); // 0x05a8ed8c
	System.Void OnClickGetReawrdBtn(WizardGames.Soc.Common.Data.Reputation.ReputationLevelConfig level); // 0x05a8f22c
	System.Void OnGetSelectRewardTip(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiSelectRewardTip.SelectItemInfo> selectItems); // 0x05a8f778
	System.Void ReqGetBattleReward(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiSelectRewardTip.SelectItemInfo> selectItems); // 0x05a8fc38
	System.Void ShowGetRewardTip(); // 0x05a8fda8
	System.Void OnDestory(); // 0x05a8fed4
	System.Void .ctor(); // 0x05a90054
	static System.Void .cctor(); // 0x05a900bc
	System.Void <ShowGetRewardTip>b__32_0(WizardGames.Soc.SocClient.Ui.UiCommonRewardPop win); // 0x05a90190
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ReputationRewardRoot.<>c__DisplayClass20_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ReputationRewardRoot <>4__this; // 0x10
	WizardGames.Soc.Common.Data.Reputation.ReputationLevelConfig cfgData; // 0x18
	FairyGUI.GButton getBtn; // 0x20
	System.Void .ctor(); // 0x05a8e070
	System.Void <UpdateRewardCom>b__0(); // 0x05a90c10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ReputationRewardRoot.<>c__DisplayClass22_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ReputationRewardRoot <>4__this; // 0x10
	System.Int32 selectId; // 0x18
	System.Void .ctor(); // 0x05a8eb58
	System.Void <UpdateSelelctItemIcon>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05a90cb4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommitInfoTips : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GTextField diskNumTxt; // 0x338
	FairyGUI.GLabel buffTxt; // 0x340
	FairyGUI.GList memberList; // 0x348
	WizardGames.Soc.SocClient.Ui.ComModal bgCom; // 0x350
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.TeamMemberInfo> dataList; // 0x358
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> btnInfos; // 0x360
	FairyGUI.GComponent levelUpAnimCom; // 0x368
	FairyGUI.GComponent panelRoot; // 0x370
	System.Void OnInit(); // 0x05a90d3c
	System.Void UpdateWnd(); // 0x05a9155c
	System.Int32 GetAddNum(); // 0x05a91d44
	System.Void UpdateMemberInfo(); // 0x05a91c90
	System.Void SortMemberList(); // 0x05a917c4
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05a91fc0
	System.Void StartUpgradeAnim(FairyGUI.GProgressBar backProgress, FairyGUI.GProgressBar frontProgress, System.Double startValue, System.Double endValue, System.Int32 curLevel, System.Boolean turned, System.Action<System.Int32> lvUpCallback); // 0x05a92bcc
	System.Void OnConfireBack(); // 0x05a93018
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05a93118
	System.Void CloseBack(); // 0x05a9319c
	System.Void OnEnable(); // 0x05a93208
	System.Void OnDisable(); // 0x05a9346c
	System.Void .ctor(); // 0x05a93570
	System.Void <OnInit>b__8_0(); // 0x05a935fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommitInfoTips.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiCommitInfoTips.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.CustomType.TeamMemberInfo> <>9__13_0; // 0x8
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__19_0; // 0x10
	static System.Void .cctor(); // 0x05a936ac
	System.Void .ctor(); // 0x05a93710
	System.Int32 <SortMemberList>b__13_0(WizardGames.Soc.Common.CustomType.TeamMemberInfo p1, WizardGames.Soc.Common.CustomType.TeamMemberInfo p2); // 0x05a93778
	System.Void <OnEnable>b__19_0(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x05a938e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommitInfoTips.<>c__DisplayClass14_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCommitInfoTips <>4__this; // 0x10
	FairyGUI.GComponent com; // 0x18
	System.Void .ctor(); // 0x05a92b64
	System.Void <OnItemRender>b__0(System.Int32 lv); // 0x05a93a28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommitInfoTips.<>c__DisplayClass15_0 : System.Object
{
	FairyGUI.GProgressBar backProgress; // 0x10
	System.Int32 fixSpeed; // 0x18
	System.Double endValue; // 0x20
	System.Int32 curLevel; // 0x28
	FairyGUI.GProgressBar frontProgress; // 0x30
	System.Action<System.Int32> lvUpCallback; // 0x38
	WizardGames.Soc.SocClient.Ui.UiCommitInfoTips <>4__this; // 0x40
	System.Void .ctor(); // 0x05a92fb0
	System.Void <StartUpgradeAnim>b__0(System.Int64 id, System.Object data, System.Boolean del); // 0x05a93c30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInfoCarckWnd : System.Object
{
	WizardGames.Soc.Common.Entity.PlayerEntity playerEntity; // 0x10
	FairyGUI.GComponent root; // 0x18
	WizardGames.Soc.SocClient.Ui.UiReputationRewardWnd parent; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiInfoCarckWnd.InfoItemData> itemDatas; // 0x28
	FairyGUI.GTextField convertEffTxt; // 0x30
	FairyGUI.GTextField cabinetLevelTxt; // 0x38
	FairyGUI.GTextField carckTime; // 0x40
	FairyGUI.GLoader cabineLoader; // 0x48
	FairyGUI.GButton closeCabinetBtn; // 0x50
	FairyGUI.GComponent diskItem; // 0x58
	FairyGUI.GProgressBar diskProgress; // 0x60
	WizardGames.Soc.SocClient.Ui.ComStateBtn commitInfoBtn; // 0x68
	FairyGUI.GButton memberInfoBtn; // 0x70
	FairyGUI.GButton badgeBtn; // 0x78
	FairyGUI.GButton levelDescBtn; // 0x80
	FairyGUI.GButton efficiencyDescBtn; // 0x88
	FairyGUI.GComponent hintCom; // 0x90
	FairyGUI.GTextField diskStateTxt; // 0x98
	FairyGUI.Controller haveDiskCtr; // 0xa0
	FairyGUI.Transition openLightAnim; // 0xa8
	FairyGUI.Transition closeLightAnim; // 0xb0
	FairyGUI.Transition lightLoopAnim; // 0xb8
	FairyGUI.Transition rotateAmim; // 0xc0
	FairyGUI.GComponent transformingCom; // 0xc8
	System.Boolean lastCabinetIsRun; // 0xd0
	FairyGUI.Transition commitBtnAnim; // 0xd8
	System.Boolean cabineLevelIsChange; // 0xe0
	static SocLogger <logger>k__BackingField; // 0x0
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiReputationRewardWnd parentWnd, FairyGUI.GComponent rootCom); // 0x05a94104
	System.Void OnDisable(); // 0x05a957f0
	System.Void OnEnable(); // 0x05a958c4
	System.Void RefreshShowBtn(System.Boolean isNormal); // 0x05a95668
	System.Void OnReputationExpChanged(WizardGames.Soc.Share.Framework.CustomTypeBase _, System.Int32 oldValue, System.Int32 newValue); // 0x05a95b14
	System.Void OnOutputContainChange(); // 0x05a95ba4
	System.Void OnInputContainChange(); // 0x05a964a8
	System.Void OnFps10Update(); // 0x05a967e8
	System.Void UpdataWnd(); // 0x05a95704
	System.Void UpdataInfoItem(); // 0x05a96514
	System.Void StartCabinetAnim(); // 0x05a95224
	System.Void UpdateTransformingAnim(); // 0x05a97034
	System.Void StopCabinetAnim(); // 0x05a9533c
	System.Void UpdateDisk(); // 0x05a95c08
	System.Void UpdataCommitAnim(); // 0x05a95a6c
	System.Void OnReputationLevelChanged(WizardGames.Soc.Share.Framework.CustomTypeBase _, System.Int32 oldValue, System.Int32 newValue); // 0x05a97520
	System.Void UpdateNextTip(); // 0x05a96afc
	System.Void OpenGameReward(); // 0x05a97b88
	System.Void OpenMedalWnd(); // 0x05a97ea8
	System.Void OnCabineLevelChange(); // 0x05a97f08
	System.Void UpdataLevel(); // 0x05a96854
	System.Void UpdataCarckTime(); // 0x05a9668c
	System.Boolean CheckIsConverting(); // 0x05a95138
	System.Void UpdataConvertEff(); // 0x05a969a8
	System.Void OnClickDiskBack(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05a9808c
	System.Void ClickLevelDescBack(); // 0x05a98340
	System.Void ClickEfficiencyDescBack(); // 0x05a983e8
	System.Void OnRollOut(); // 0x05a95860
	System.Void CloseCabinetBack(); // 0x05a98490
	System.Void CommitInfoBack(); // 0x05a98ab4
	System.Void MemberInfoBack(); // 0x05a98bd8
	System.Void BadgeInfoBack(); // 0x05a98ce0
	System.Void OnCloseWnd(); // 0x05a98d88
	System.Void .ctor(); // 0x05a9923c
	static System.Void .cctor(); // 0x05a992a4
	System.Void <StartCabinetAnim>b__40_0(); // 0x05a99378
	System.Void <OnCabineLevelChange>b__49_0(System.Int64 a, System.Object b, System.Boolean c); // 0x05a99400
	System.Void <CloseCabinetBack>b__58_0(); // 0x05a99494
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInfoCarckWnd.InfoItemData : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg; // 0x10
	WizardGames.Soc.Common.Data.Reputation.ReputationConvertConfig convertCfg; // 0x18
	FairyGUI.GComponent com; // 0x20
	WizardGames.Soc.SocClient.Ui.ComItemIcon itemIcon; // 0x28
	System.Int32 count; // 0x30
	System.Boolean isConverting; // 0x34
	WizardGames.Soc.SocClient.Ui.UiNoItemTip noItemTip; // 0x38
	System.Void Init(); // 0x05a954a4
	System.Void Updata(); // 0x05a96da0
	System.Void OnClickBack(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05a99634
	System.Void .ctor(); // 0x05a9543c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInfoCarckWnd.InfoItemData.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiInfoCarckWnd.InfoItemData <>4__this; // 0x10
	WizardGames.Soc.Common.CustomType.BaseItemNode packItemNode; // 0x18
	System.Void .ctor(); // 0x05a99a34
	System.Boolean <OnClickBack>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x05a99a9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInfoCarckWnd.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiInfoCarckWnd.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiInfoCarckWnd.InfoItemData> <>9__63_0; // 0x8
	static System.Void .cctor(); // 0x05a99b5c
	System.Void .ctor(); // 0x05a99bc0
	System.Void <OnCloseWnd>b__63_0(WizardGames.Soc.SocClient.Ui.UiInfoCarckWnd.InfoItemData item); // 0x05a99c28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInfoCarckWnd.<>c__DisplayClass45_0 : System.Object
{
	System.Int32 oldValue; // 0x10
	System.Int32 newValue; // 0x14
	WizardGames.Soc.SocClient.Ui.UiInfoCarckWnd <>4__this; // 0x18
	System.Void .ctor(); // 0x05a97ab8
	System.Void <OnReputationLevelChanged>b__0(System.Int64 a, System.Object b, System.Boolean c); // 0x05a99d18
	System.Void <OnReputationLevelChanged>b__1(System.Int64 a, System.Object b, System.Boolean c); // 0x05a9a0d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInfoCarckWnd.<>c__DisplayClass45_1 : System.Object
{
	System.Int32 i; // 0x10
	WizardGames.Soc.SocClient.Ui.UiInfoCarckWnd.<>c__DisplayClass45_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x05a97b20
	System.Void <OnReputationLevelChanged>b__2(System.Int64 a, System.Object b, System.Boolean c); // 0x05a9a23c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMemberInfoTips : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GTextField cabinetLevelTxt; // 0x338
	FairyGUI.GTextField cabinetDescTxt; // 0x340
	FairyGUI.GList memberList; // 0x348
	WizardGames.Soc.SocClient.Ui.ComModal bgCom; // 0x350
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.TeamMemberInfo> dataList; // 0x358
	FairyGUI.Controller arrowCtr; // 0x360
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> btnInfos; // 0x368
	FairyGUI.GComponent panelRoot; // 0x370
	System.Void OnInit(); // 0x05a9a434
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05a9ac38
	System.Void UpdateWnd(); // 0x05a9aa70
	System.Void UpdateMemberInfo(); // 0x05a9b188
	System.Void UpdataSelectMember(); // 0x05a9b244
	System.Void SortMemberList(); // 0x05a9acbc
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05a9b454
	System.Void OnConfireBack(); // 0x05a9bd4c
	System.Void OnEnable(); // 0x05a9bdb8
	System.Void OnDisable(); // 0x05a9bef4
	System.Void .ctor(); // 0x05a9bf5c
	System.Void <OnInit>b__8_0(); // 0x05a9bfe8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMemberInfoTips.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiMemberInfoTips.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.CustomType.TeamMemberInfo> <>9__13_0; // 0x8
	static System.Void .cctor(); // 0x05a9c054
	System.Void .ctor(); // 0x05a9c0b8
	System.Int32 <SortMemberList>b__13_0(WizardGames.Soc.Common.CustomType.TeamMemberInfo p1, WizardGames.Soc.Common.CustomType.TeamMemberInfo p2); // 0x05a9c120
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReputationRewardWnd : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	WizardGames.Soc.SocClient.Ui.ReputationRewardRoot rewardRootCtr; // 0x338
	WizardGames.Soc.SocClient.Ui.UiInfoCarckWnd infoCarckWnd; // 0x340
	FairyGUI.GComponent rewardRoot; // 0x348
	FairyGUI.Controller rewardTypeSelect; // 0x350
	FairyGUI.GComponent modelRoot; // 0x358
	FairyGUI.GLoader modelLoader; // 0x360
	FairyGUI.GTextField modelNameTxt; // 0x368
	FairyGUI.GTextField modelRewardTypeTxt; // 0x370
	FairyGUI.GTextField modelUnLockLevelTxt; // 0x378
	FairyGUI.GObject modelUnlockLevelBg; // 0x380
	FairyGUI.GTextField modelDescTxt; // 0x388
	FairyGUI.GLoader bgLoader; // 0x390
	FairyGUI.GTextField lobbyLevelTxt; // 0x398
	FairyGUI.Transition switchAnim; // 0x3a0
	FairyGUI.GButton alwaysSkipBtn; // 0x3a8
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x3b0
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x3b8
	System.Boolean isAlwaysSkip; // 0x3c0
	System.Single defaultCloseWinDistanceSqr; // 0x3c4
	WizardGames.Soc.SocClient.Ui.UiReputationRewardWnd.ERepuationRewardType <RewardType>k__BackingField; // 0x3c8
	WizardGames.Soc.SocClient.Ui.UiReputationRewardData <UiReputationRewardData>k__BackingField; // 0x3d0
	System.String isSkipAnimKey; // 0x3d8
	FairyGUI.GComponent content; // 0x3e0
	System.Void set_RewardType(WizardGames.Soc.SocClient.Ui.UiReputationRewardWnd.ERepuationRewardType value); // 0x05a9c290
	WizardGames.Soc.SocClient.Ui.UiReputationRewardWnd.ERepuationRewardType get_RewardType(); // 0x05a9c308
	System.Void set_UiReputationRewardData(WizardGames.Soc.SocClient.Ui.UiReputationRewardData value); // 0x05a9c36c
	System.Void OnInit(); // 0x05a9c3ec
	System.Void OnEnable(); // 0x05a9d2c8
	System.Void OnDisable(); // 0x05a9d6c0
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean local); // 0x05a9d8d0
	System.Void OnTeamMemberChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x05a9da20
	System.Void UpdateFatigue(); // 0x05a9db6c
	System.Void ClickFatigueBack(); // 0x05a9df3c
	System.Void OnFatigueHideBack(); // 0x05a9e050
	System.Void OnRewardDictChange(); // 0x05a9e0b4
	System.Void UpdateWnd(); // 0x05a9d644
	System.Void UpdateModelRootCom(); // 0x05a9ebd4
	System.Void UpdataBtnRed(); // 0x05a97238
	System.Void OnFireClickGameBtn(); // 0x05a97cc8
	System.Void OnClickGameBtn(); // 0x05a9f074
	System.Void OnClickInfoCarckBtn(); // 0x05a9f288
	System.Void OnFireClickLobbyBtn(); // 0x05a9f448
	System.Void OnClickLobbyBtn(); // 0x05a9f4a8
	System.Void OnClickAlwaysSkipBtn(FairyGUI.EventContext context); // 0x05a9f508
	static System.Void OpenWin(); // 0x05a97d40
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05a9f6a4
	System.Void CheckDistance(); // 0x05a9f768
	System.Void OnDestroy(); // 0x05a9f9a0
	System.Void OnFps10Update(System.Single dt); // 0x05a9fae0
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05a9fbb4
	System.Void .ctor(); // 0x05a9fcb8
	System.Void <OnInit>b__29_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x05a9fd78
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiReputationRewardWnd.ERepuationRewardType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiReputationRewardWnd.ERepuationRewardType None = 0;
	static WizardGames.Soc.SocClient.Ui.UiReputationRewardWnd.ERepuationRewardType Game = 1;
	static WizardGames.Soc.SocClient.Ui.UiReputationRewardWnd.ERepuationRewardType Lobby = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReputationRewardWnd.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiReputationRewardWnd.<>c <>9; // 0x0
	static System.Func<System.String> <>9__34_0; // 0x8
	static System.Void .cctor(); // 0x05a9fe94
	System.Void .ctor(); // 0x05a9fef8
	System.String <UpdateFatigue>b__34_0(); // 0x05a9ff60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRewardAnimPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.GameReputation.UiRewardAnimPopBinder binder; // 0x338
	FairyGUI.GComponent comCallAirdropAnim; // 0x340
	FairyGUI.Transition callAirAnim; // 0x348
	FairyGUI.GComponent getRewardAnimIconRoot; // 0x350
	FairyGUI.GLoader[] rewardAnimIcons; // 0x358
	FairyGUI.GImage[] rewardAnimIconsBlueprintBgs; // 0x360
	FairyGUI.GButton skipBtn; // 0x368
	WizardGames.Soc.SocClient.Ui.ReputationRewardRoot rewardRootCtr; // 0x370
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x378
	System.Void OnInit(); // 0x05aa0140
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05aa0888
	System.Void OnEnable(); // 0x05aa08fc
	System.Void OnDisable(); // 0x05aa09b8
	System.Void SetData(WizardGames.Soc.SocClient.Ui.ReputationRewardRoot _rewardRootCtr, WizardGames.Soc.SocClient.Ui.ComTopBar _topBar); // 0x05a9e234
	System.Void SkipAnim(); // 0x05aa0a74
	System.Void PlayGetRewardAnim(); // 0x05a9e2cc
	System.Void OnFinish(); // 0x05aa0b14
	System.Void OnDestroy(); // 0x05aa0ba4
	System.Void .ctor(); // 0x05aa0c1c
	System.Void <PlayGetRewardAnim>b__15_0(); // 0x05aa0ca8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectRewardTip : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static System.String repuationRewardTipKey; // 0x0
	FairyGUI.GTextField rewardNumTxt; // 0x338
	FairyGUI.GButton getBtn; // 0x340
	FairyGUI.GButton cancelBtn; // 0x348
	FairyGUI.GList rewardList; // 0x350
	FairyGUI.GObject bgObj; // 0x358
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.ReputRwdConfig> selectRewardCfgList; // 0x360
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiSelectRewardTip.SelectItemInfo> saveSelectItems; // 0x368
	System.Int32 selectMaxNum; // 0x370
	System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiSelectRewardTip.SelectItemInfo>> GetRewardEvent; // 0x378
	FairyGUI.GComponent allCoin; // 0x380
	FairyGUI.GComponent costCoin; // 0x388
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiSelectRewardTip.SelectItemInfo> selectInfoList; // 0x390
	FairyGUI.GComponent panelRoot; // 0x398
	System.Void OnInit(); // 0x05aa1180
	System.Void OnEnable(); // 0x05aa1834
	System.Void UpdataTip(System.Int32 selectRewardId, System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiSelectRewardTip.SelectItemInfo>> onGetRewardBack); // 0x05aa189c
	System.Void UpdataCoin(); // 0x05aa1ed8
	System.Void UpdataCostCoin(); // 0x05aa1f54
	System.Void OnRewardUnLockBack(WizardGames.Soc.Share.Framework.ECustomHashSetOpType opType, System.Int64 id); // 0x05aa2108
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05aa2184
	System.Void TryAddSelelctId(WizardGames.Soc.SocClient.Ui.UiSelectRewardTip.SelectItemInfo selectInfo, System.Boolean isForce); // 0x05aa2a10
	System.Void UdpateSelectTxt(); // 0x05aa2bac
	System.Void OnClickSelectReward(WizardGames.Soc.SocClient.Ui.UiSelectRewardTip.SelectItemInfo itemInfo, WizardGames.Soc.SocClient.Ui.ComBaseIcon comItemIcon, System.Boolean isLock); // 0x05aa2db4
	System.Void SetSelectCtr(FairyGUI.GComponent com, System.Boolean isSelect); // 0x05aa2cd0
	System.Void OnClickItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, WizardGames.Soc.Common.Data.Play.ReputRwdConfig reputRwdCfg, System.Boolean isLock, FairyGUI.EventContext context); // 0x05aa2f00
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05aa30c8
	System.Void OnClickGetBack(); // 0x05aa31fc
	System.Void Reset(); // 0x05aa3520
	System.Void OnDisable(); // 0x05aa35dc
	System.Void OnDestroy(); // 0x05aa3670
	System.Void .ctor(); // 0x05aa3834
	static System.Void .cctor(); // 0x05aa38c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectRewardTip.SelectItemInfo : System.Object
{
	System.Boolean isLock; // 0x10
	System.Int32 costCoin; // 0x14
	WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg; // 0x18
	System.Int32 dropId; // 0x20
	WizardGames.Soc.Common.Data.Play.ReputRwdConfig reputCfg; // 0x28
	FairyGUI.GComponent com; // 0x30
	System.Void .ctor(); // 0x05aa29a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectRewardTip.<>c__DisplayClass22_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSelectRewardTip <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ComItemIcon comItemIcon; // 0x18
	WizardGames.Soc.Common.Data.Play.ReputRwdConfig reputRwdCfg; // 0x20
	System.Boolean isLock; // 0x28
	WizardGames.Soc.SocClient.Ui.UiSelectRewardTip.SelectItemInfo itemInfo; // 0x30
	System.Void .ctor(); // 0x05aa2940
	System.Void <OnItemRender>b__0(FairyGUI.EventContext context); // 0x05aa3928
	System.Void <OnItemRender>b__1(FairyGUI.EventContext context); // 0x05aa39b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.DeadInfoMapBg : System.Object
{
	FairyGUI.GComponent root; // 0x10
	FairyGUI.GComponent container; // 0x18
	FairyGUI.GLoader loaderMapTex; // 0x20
	System.Void .ctor(FairyGUI.GComponent bgRoot); // 0x05aa3a40
	System.Void Init(); // 0x05aa3b64
	System.Void InitMapTexLoader(); // 0x05aa3cd4
	System.Void AutoSetPosition(); // 0x05aa3f14
	UnityEngine.Vector2 TransformUiRootNodeCenterToTarget(FairyGUI.GObject targetObj); // 0x05aa42f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.KeyboardHandler : System.Object
{
	System.String lastInput; // 0x10
	System.Int64 keyboardTickTimer; // 0x18
	System.Void ClearTimer(); // 0x05aa43bc
	System.Void Finalize(); // 0x05aa44c4
	System.Void .ctor(); // 0x05aa45a4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ERebornPoint : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ERebornPoint Nearby = 0;
	static WizardGames.Soc.SocClient.Ui.ERebornPoint Outpost = 1;
	static WizardGames.Soc.SocClient.Ui.ERebornPoint Archive = 2;
	static WizardGames.Soc.SocClient.Ui.ERebornPoint Random = 3;
	static WizardGames.Soc.SocClient.Ui.ERebornPoint Bed = 4;
	static WizardGames.Soc.SocClient.Ui.ERebornPoint SleepingBag = 5;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RespawnRebornPoint : System.Object
{
	System.Int64 <Id>k__BackingField; // 0x10
	System.String Name; // 0x18
	WizardGames.Soc.SocClient.Ui.ERebornPoint <Type>k__BackingField; // 0x20
	UnityEngine.Vector3 <Position>k__BackingField; // 0x24
	System.Int64 <UnlockTime>k__BackingField; // 0x30
	System.Int64 <CdTime>k__BackingField; // 0x38
	System.String <Icon>k__BackingField; // 0x40
	System.Int32 <OutpostId>k__BackingField; // 0x48
	System.Int64 get_Id(); // 0x05aa4638
	System.Void set_Id(System.Int64 value); // 0x05aa469c
	WizardGames.Soc.SocClient.Ui.ERebornPoint get_Type(); // 0x05aa4714
	System.Void set_Type(WizardGames.Soc.SocClient.Ui.ERebornPoint value); // 0x05aa4778
	UnityEngine.Vector3 get_Position(); // 0x05aa47f0
	System.Void set_Position(UnityEngine.Vector3 value); // 0x05aa4854
	System.Int64 get_UnlockTime(); // 0x05aa48ec
	System.Void set_UnlockTime(System.Int64 value); // 0x05aa4950
	System.Int64 get_CdTime(); // 0x05aa49c8
	System.Void set_CdTime(System.Int64 value); // 0x05aa4a2c
	System.String get_Icon(); // 0x05aa4aa4
	System.Void set_Icon(System.String value); // 0x05aa4b08
	System.Int32 get_OutpostId(); // 0x05aa4b88
	System.Void set_OutpostId(System.Int32 value); // 0x05aa4bec
	System.Void .ctor(System.Int64 id, System.String name, WizardGames.Soc.SocClient.Ui.ERebornPoint type, UnityEngine.Vector3 position, System.Int64 unlockTime, System.Int64 cdTime, System.String icon); // 0x05aa4c64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCloseEyes : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	System.Single tick; // 0x338
	FairyGUI.Transition show_anim; // 0x340
	FairyGUI.GComponent effectRoot; // 0x348
	FairyGUI.GComponent effectMask; // 0x350
	System.Void OnInit(); // 0x05aa4f58
	System.Void OnEnable(); // 0x05aa5180
	System.Void AnimCompleteCallback(); // 0x05aa52e0
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05aa5354
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05aa54b8
	System.Void .ctor(); // 0x05aa55b8
	System.Void <OnInit>b__5_0(); // 0x05aa5644
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDeadInfo : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GList list_briefItem; // 0x338
	FairyGUI.GList list_totalItem; // 0x340
	FairyGUI.GList list_damageRecords; // 0x348
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.BaseItemNode> dropItems; // 0x350
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.BaseItemNode> protectedItems; // 0x358
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.SummarizedDamageRecord> damageRecords; // 0x360
	FairyGUI.GComponent rootUI; // 0x368
	WizardGames.Soc.SocClient.Ui.ComAvatarSquare loader_avatar; // 0x370
	FairyGUI.GTextField text_name; // 0x378
	FairyGUI.GTextField text_weapon; // 0x380
	FairyGUI.GTextField text_ammo; // 0x388
	FairyGUI.GLoader loader_weapon; // 0x390
	WizardGames.Soc.Common.Entity.PlayerEntity serverEntity; // 0x398
	FairyGUI.Controller qualityCtrl; // 0x3a0
	FairyGUI.Controller showWeaponCtrl; // 0x3a8
	System.String killerPlayerName; // 0x3b0
	System.Int64 killerPlayerRoleId; // 0x3b8
	WizardGames.Soc.SocClient.Ui.DeadInfoMapBg mapBg; // 0x3c0
	FairyGUI.GButton uiReportBtn; // 0x3c8
	System.Int64 showAnimTimerId; // 0x3d0
	System.Int64 autoRebornTimerId; // 0x3d8
	System.Void OnInit(); // 0x05aa56a8
	System.Void OnClickReportBtn(); // 0x05aa5e88
	System.Void SetDeathSummaryNew(); // 0x05aa5f98
	System.Int32 CollisionDeathSummary(); // 0x05aa689c
	System.Void ShowWeaponInfo(System.Int64 weaponTableId, System.Int64 weaponSkinId, System.Int64 hitAmmoTableId); // 0x05aa6ac4
	System.Void ShowWeaponInfo(System.String weaponName, System.String weaponIcon); // 0x05aa6e70
	System.Void ShowKillerInfo(System.String killerName, System.Int64 roleId); // 0x05aa6f30
	System.Void ShowKillerInfo(System.String killerName, System.String iconUrl); // 0x05aa69e8
	System.Int32 DamageFromMonster(); // 0x05aa6420
	System.Int32 DamageFromPlayer(); // 0x05aa67a8
	System.Int32 EnvironmentDeathSummary(WizardGames.Soc.Common.SimpleCustom.DamageType damageType); // 0x05aa666c
	System.Int32 DamageType2WaysToDieId(WizardGames.Soc.Common.SimpleCustom.DamageType damageType); // 0x05aa7080
	System.Int32 DamageFromConstruction(); // 0x05aa7114
	System.Void HandleIndirectDamageDead(); // 0x05aa62ec
	System.Int32 DamageFromVehicle(); // 0x05aa73f8
	System.Void ShowSourcesDamage(System.Int32 waysToDieID); // 0x05aa61bc
	System.Void DamageFromTrap(); // 0x05aa72c8
	System.String SurvivalTimeFormat(System.Int64 survivalTime); // 0x05aa763c
	System.Void OnEnable(); // 0x05aa7788
	System.Void SetSufferDamageInfo(FairyGUI.GComponent com_sufferDamageInfo, WizardGames.Soc.Common.SimpleCustom.SummarizedDamageRecord record); // 0x05aa84b8
	WizardGames.Soc.Common.Data.DamageSourceIcon GetDamageSourceIcon(System.Int32 waysToDieID); // 0x05aa86f4
	WizardGames.Soc.Common.Data.DamageSourceIcon GetDamageSourceIcon(WizardGames.Soc.Common.SimpleCustom.SummarizedDamageRecord record, System.Int32& waysToDieID); // 0x05aa885c
	System.Void SetAttackDamageInfo(FairyGUI.GComponent com_damageInfo, WizardGames.Soc.Common.SimpleCustom.SummarizedDamageRecord record, System.String& hitName); // 0x05aa8a64
	System.Void SetDamageTypeString(FairyGUI.GComponent com, WizardGames.Soc.Common.SimpleCustom.SummarizedDamageRecord record); // 0x05aa8e08
	System.Void DamageRecordsRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05aa909c
	System.Void SetDamageInfo(FairyGUI.GComponent damageInfo, System.Collections.Generic.Dictionary<System.Int32,System.Single> damageByPart); // 0x05aa8548
	System.Void SetDamagePartInfo(FairyGUI.GComponent hitPart, System.Single damage); // 0x05aa93d4
	System.Void DropItemsRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05aa94d4
	System.Void ShowSummarizedDamageRecords(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.SummarizedDamageRecord> records); // 0x05aa97e0
	System.Void ShowDeathDropItems(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.BaseItemNode> dropItems, WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.BaseItemNode> protectedItems); // 0x05aa7cc8
	System.Void OnDisable(); // 0x05aa997c
	System.Void OnShowAnimFinish(); // 0x05aa9b44
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05aa9c08
	System.Void RefreshAutoRebornTips(); // 0x05aa7ffc
	System.Void ClearAutoRebornTimer(); // 0x05aa9a38
	System.Void .ctor(); // 0x05aa9e3c
	System.Void <OnInit>b__22_0(FairyGUI.EventContext ctx); // 0x05aa9ec8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDeadInfo.<>c__DisplayClass55_0 : System.Object
{
	FairyGUI.GComponent resurrectionCountdownCom; // 0x10
	System.Int32 remainAutoRebornTime; // 0x18
	System.Void .ctor(); // 0x05aa9dd4
	System.Void <RefreshAutoRebornTips>b__0(System.Int64 id, System.Object _, System.Boolean delete); // 0x05aa9f40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRespawn : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	SocLogger log; // 0x338
	WizardGames.Soc.SocClient.Ui.UiRespawnBtn uiRespawnBtn; // 0x340
	WizardGames.Soc.SocClient.Ui.Map.RespawnMap respawnMap; // 0x348
	FairyGUI.GList rebornPointList; // 0x350
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RespawnRebornPoint> rebornPoints; // 0x358
	System.Int64 timerId; // 0x360
	System.Int64 AutoRebornTimerId; // 0x368
	System.Int64 selectHintTimerId; // 0x370
	System.Single initMapScale; // 0x378
	System.Single frameChangeScale; // 0x37c
	UnityEngine.Vector3 deadPos; // 0x380
	System.Void OnPickEquipmentSuccessCallback(System.Int32 suitId); // 0x05aaa0e8
	System.Void RefreshChooseSuitPanel(); // 0x05aaa1d4
	System.Void RefreshChooseSuitInfo(WizardGames.Soc.Common.CustomType.PgcGraphDataHost dataHost); // 0x05aaa434
	System.Void OpenChooseSuitView(FairyGUI.EventContext context); // 0x05aab0cc
	System.Void .ctor(); // 0x05aab2c8
	System.Void OnEnable(); // 0x05aab618
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05aac2fc
	System.Void PlayFirstOpenViewAnimation(); // 0x05aabcc8
	System.Void OnDisable(); // 0x05aac4a0
	System.Void OnDestroy(); // 0x05aac90c
	System.Void OnInit(); // 0x05aacb70
	System.Void OnSelectedMarkerInfoChanged(); // 0x05aad420
	System.Void ClearListSelection(); // 0x05aadaa8
	System.Void ParseRebornPointDatas(); // 0x05aabec8
	System.Void SortRebornPoints(); // 0x05aafb38
	WizardGames.Soc.SocClient.Ui.RespawnRebornPoint GetNearbyRebornPoint(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity); // 0x05aae47c
	WizardGames.Soc.SocClient.Ui.RespawnRebornPoint GetArchiveRebornPoint(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity); // 0x05aae8a8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RespawnRebornPoint> GetOutpostRebornPoints(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity); // 0x05aaeadc
	WizardGames.Soc.SocClient.Ui.RespawnRebornPoint GetRandomRebornPoint(); // 0x05aaf258
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RespawnRebornPoint> GetSleepBagBedRebornPoints(); // 0x05aaf404
	System.Void RenderRebornPointItem(System.Int32 index, FairyGUI.GObject obj); // 0x05ab011c
	System.Void OnRebornPointItemClick(FairyGUI.EventContext context); // 0x05ab06f0
	System.Void _OnRebornPointItemClick(FairyGUI.GButton btn); // 0x05aad838
	System.Int32 GetItemStatusCtrlIndex(WizardGames.Soc.SocClient.Ui.RespawnRebornPoint data); // 0x05ab0590
	System.Void SetCdTimer(); // 0x05aafd04
	System.Void RefreshCdTime(System.Int64 timerId, System.Object _, System.Boolean needDelete); // 0x05ab09f8
	System.Void ClearTimer(); // 0x05aac5e8
	System.Void OnFps1Update(System.Single dt); // 0x05ab0ec8
	System.Void OnFps30Update(System.Single dt); // 0x05ab1008
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x05ab1090
	static System.Void OpenWindow(); // 0x05aa9d18
	System.Void ShowAllShareCdPoint(WizardGames.Soc.SocClient.Ui.RespawnRebornPoint curPoint); // 0x05aadeb0
	System.Void BeginSelectHintTimer(); // 0x05aadc94
	System.Void StopSelectHintAnimation(); // 0x05ab08a8
	System.Void ClearSelectHintTimer(); // 0x05aac800
	System.Void RefreshAutoReborn(); // 0x05aab770
	System.Void ClearAutoRebornTimer(); // 0x05aac6f4
	System.Void <OnInit>b__21_0(FairyGUI.EventContext ctx); // 0x05ab1178
	System.Void <BeginSelectHintTimer>b__43_0(System.Int64 _, System.Object _, System.Boolean _); // 0x05ab12b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRespawn.<>c__DisplayClass25_0 : System.Object
{
	System.Int64 curTime; // 0x10
	UnityEngine.Vector3 playerPos; // 0x18
	System.Void .ctor(); // 0x05ab00b4
	System.Int32 <SortRebornPoints>b__0(WizardGames.Soc.SocClient.Ui.RespawnRebornPoint a, WizardGames.Soc.SocClient.Ui.RespawnRebornPoint b); // 0x05ab13c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRespawn.<>c__DisplayClass46_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiRespawn <>4__this; // 0x10
	System.Int32 remainAutoRebornTime; // 0x18
	System.Void .ctor(); // 0x05ab1110
	System.Void <RefreshAutoReborn>b__0(System.Int64 id, System.Object _, System.Boolean delete); // 0x05ab1900
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRespawnBtn : System.Object
{
	SocLogger log; // 0x10
	FairyGUI.GButton respawnBtn; // 0x18
	FairyGUI.GTextField title; // 0x20
	FairyGUI.GTextField txtCd; // 0x28
	FairyGUI.GTextField txtHint; // 0x30
	FairyGUI.GTextField txtPointType; // 0x38
	FairyGUI.GLoader loaderIcon; // 0x40
	FairyGUI.Controller respawnBtnStateCtrl; // 0x48
	System.String rebornPointInCdStr; // 0x50
	System.Single lastClickTime; // 0x58
	WizardGames.Soc.SocClient.Ui.RespawnRebornPoint rebornPointData; // 0x60
	System.Void Init(FairyGUI.GComponent node); // 0x05aad124
	System.Void OnEnable(); // 0x05aabc18
	System.Void RefreshBtnCd(); // 0x05ab1b44
	System.Void RefreshBtn(); // 0x05ab0e18
	System.Void RespawnBtnClick(); // 0x05ab237c
	System.Void RebornPointRespawn(); // 0x05ab2424
	System.Void RandomPointRespawn(System.Int32 type); // 0x05ab2910
	System.Void SelectSleepingBag(System.Int64 id); // 0x05ab2ac0
	System.Void SelectedPointChange(WizardGames.Soc.SocClient.Ui.RespawnRebornPoint data); // 0x05aadb50
	System.Void OnDestroy(); // 0x05aacaf0
	System.Void .ctor(); // 0x05aab4d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GameOBPlayerListColor : System.Object
{
	
