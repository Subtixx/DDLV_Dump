using System;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using DeltaDNA;
using Mdl.Platform;
using Mdl.Systems;
using Meta;
using Meta.Online;
using Meta.Util;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007B7")]
	public class SavegameManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002BBD")]
		public SavegameManagerConfig Config = new SavegameManagerConfig
		{
			AutoSaveEveryXSeconds = 300f,
			SaveOnSuspendDelaySeconds = 120,
			IsDelayingWrite = true
		};

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002BBF")]
		private readonly SaveOnExitPolicyType DefaultPolicyTypeToUse = SaveOnExitPolicyType.OnQuit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002BC0")]
		private SaveOnExitPolicyType SaveOnExitPolicy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002BC1")]
		private DateTime LastSaveOnSuspendTime;

		[Cpp2IlInjected.Token(Token = "0x170004C9")]
		private Client MetaClient
		{
			[Cpp2IlInjected.Token(Token = "0x6002249")]
			[Cpp2IlInjected.Address(RVA = "0xCC80E0", Offset = "0xCC6AE0", VA = "0x180CC80E0")]
			get
			{
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					return _003CInstance_003Ek__BackingField.MetaClient;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CA")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4002BBE")]
		private bool IsInit
		{
			[Cpp2IlInjected.Token(Token = "0x600224A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600224B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600224C")]
		[Cpp2IlInjected.Address(RVA = "0xCC7930", Offset = "0xCC6330", VA = "0x180CC7930")]
		private void InitSaveOnExitPolicyType()
		{
			//Discarded unreachable code: IL_0081
			//IL_0064: Expected O, but got I4
			int num = 0;
			if (DebugSettings.Settings.overrideSaveOnExitPolicy_ != 0)
			{
				int num2 = 0;
				SaveOnExitPolicyType saveOnExitPolicyType = (SaveOnExitPolicy = DebugSettings.Settings.overrideSaveOnExitPolicy_);
			}
			if (SaveOnExitPolicy == SaveOnExitPolicyType.Default)
			{
				SaveOnExitPolicyType defaultPolicyTypeToUse = DefaultPolicyTypeToUse;
				int num3 = 0;
				SaveOnExitPolicy = defaultPolicyTypeToUse;
				switch (Application.platform)
				{
				}
			}
			SaveOnExitPolicyType saveOnExitPolicy = SaveOnExitPolicy;
			string text = ((Enum)saveOnExitPolicy).ToString();
			SaveOnExitPolicyType saveOnExitPolicyType2 = (SaveOnExitPolicy = saveOnExitPolicy);
			string text2 = "SaveGameMgr.SaveOnExitPolicy is " + text;
		}

		[Cpp2IlInjected.Token(Token = "0x600224D")]
		[Cpp2IlInjected.Address(RVA = "0xCC7F00", Offset = "0xCC6900", VA = "0x180CC7F00")]
		public void Start()
		{
			//Discarded unreachable code: IL_002f
			int num = 0;
			DateTime dateTime = (LastSaveOnSuspendTime = DateTime.Now);
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client.StartUpHandler value = InitAfterVillageLoaded;
			metaClient.OnStartUp += value;
		}

		[Cpp2IlInjected.Token(Token = "0x600224E")]
		[Cpp2IlInjected.Address(RVA = "0xCC7CA0", Offset = "0xCC66A0", VA = "0x180CC7CA0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0065
			//IL_0016: Expected O, but got I4
			IsInit = false;
			SwitchNotifications instance = SwitchNotifications.Instance;
			int num = 0;
			if (instance != (UnityEngine.Object)num && SaveOnExitPolicy == SaveOnExitPolicyType.SwitchExitRequest)
			{
				SwitchNotifications instance2 = SwitchNotifications.Instance;
				SwitchNotifications.ApplicationQuitCB value = DoSaveOnExitImpl;
				instance2.OnApplicationQuit -= value;
			}
			if (MetaClient != null)
			{
				Client metaClient = MetaClient;
				Client.StartUpHandler value2 = InitAfterVillageLoaded;
				metaClient.OnStartUp -= value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600224F")]
		[Cpp2IlInjected.Address(RVA = "0xCC7510", Offset = "0xCC5F10", VA = "0x180CC7510")]
		private void InitAfterVillageLoaded(Profile profile, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0169
			//IL_005e: Expected I4, but got I8
			//IL_0067: Expected I4, but got I8
			//IL_0076: Expected O, but got I4
			//IL_00d1: Invalid comparison between F4 and I4
			//IL_0105: Expected F4, but got I4
			//IL_0140: Expected O, but got I4
			int num = 0;
			if (DebugSettings.Settings.overrideSaveOnExitPolicy_ != 0)
			{
				int num2 = 0;
				SaveOnExitPolicyType saveOnExitPolicyType = (SaveOnExitPolicy = DebugSettings.Settings.overrideSaveOnExitPolicy_);
			}
			if (SaveOnExitPolicy == SaveOnExitPolicyType.Default)
			{
				SaveOnExitPolicyType defaultPolicyTypeToUse = DefaultPolicyTypeToUse;
				int num3 = 0;
				SaveOnExitPolicy = defaultPolicyTypeToUse;
				RuntimePlatform platform = Application.platform;
				if (platform != RuntimePlatform.IPhonePlayer && platform != RuntimePlatform.Android)
				{
					if (platform != RuntimePlatform.Switch)
					{
						goto IL_0067;
					}
					SaveOnExitPolicy = SaveOnExitPolicyType.SwitchExitRequest;
				}
				SaveOnExitPolicy = SaveOnExitPolicyType.OnPause;
			}
			goto IL_0067;
			IL_0067:
			SaveOnExitPolicyType saveOnExitPolicy = SaveOnExitPolicy;
			string text = ((Enum)saveOnExitPolicy).ToString();
			SaveOnExitPolicyType saveOnExitPolicyType2 = (SaveOnExitPolicy = saveOnExitPolicy);
			string text2 = "SaveGameMgr.SaveOnExitPolicy is " + text;
			Client metaClient = MetaClient;
			SavegameManagerConfig config = Config;
			LocalProfileHolder _003CLocalProfileHolder_003Ek__BackingField = metaClient.LocalProfileHolder;
			bool flag = (_003CLocalProfileHolder_003Ek__BackingField.IsDelayingWrite = config.IsDelayingWrite);
			float autoSaveEveryXSeconds = Config.AutoSaveEveryXSeconds;
			int num4 = 0;
			if (!(autoSaveEveryXSeconds <= (float)num4) && MetaClient.LocalProfileHolder.IsDelayingWrite)
			{
				float autoSaveEveryXSeconds2 = Config.AutoSaveEveryXSeconds;
				int num5 = 0;
				InvokeRepeating("AutoSaveCallback", num5, autoSaveEveryXSeconds2);
			}
			Client metaClient2 = MetaClient;
			Client.StartUpHandler value = InitAfterVillageLoaded;
			metaClient2.OnStartUp -= value;
			if (SaveOnExitPolicy == SaveOnExitPolicyType.SwitchExitRequest)
			{
				SwitchNotifications instance = SwitchNotifications.Instance;
				int num6 = 0;
				if (!(instance != (UnityEngine.Object)num6))
				{
				}
				SwitchNotifications instance2 = SwitchNotifications.Instance;
				SwitchNotifications.ApplicationQuitCB value2 = DoSaveOnExitImpl;
				instance2.OnApplicationQuit += value2;
			}
			IsInit = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002250")]
		[Cpp2IlInjected.Address(RVA = "0xCC7480", Offset = "0xCC5E80", VA = "0x180CC7480")]
		private void DoSaveRequest(bool forceSaving)
		{
			//Discarded unreachable code: IL_0024
			//IL_0022: Expected O, but got I4
			SaveProfile.Types.Request request = new SaveProfile.Types.Request();
			request.forceSaving_ = forceSaving;
			Client metaClient = MetaClient;
			if (metaClient != null)
			{
				int num = 0;
				Task<SaveProfile.Types.Response> task = (Task<SaveProfile.Types.Response>)(object)metaClient.SaveProfileAsync(request, (CancellationToken)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002251")]
		[Cpp2IlInjected.Address(RVA = "0xCC8050", Offset = "0xCC6A50", VA = "0x180CC8050")]
		public void TriggerSave(bool forceSaving)
		{
			if (IsInit)
			{
				DoSaveRequest(forceSaving);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002252")]
		[Cpp2IlInjected.Address(RVA = "0xCC7320", Offset = "0xCC5D20", VA = "0x180CC7320")]
		private void AutoSaveCallback()
		{
			int forceSaving = 0;
			DoSaveRequest((byte)forceSaving != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002253")]
		[Cpp2IlInjected.Address(RVA = "0xCC7390", Offset = "0xCC5D90", VA = "0x180CC7390")]
		private void DoSaveOnExitImpl()
		{
			//Discarded unreachable code: IL_0038
			Client metaClient = MetaClient;
			if (metaClient != null && (long)metaClient.LocalProfileHolder != 0)
			{
				MetaClient.LocalProfileHolder.SaveOnExit();
			}
			((DDNA)(object)Singleton<T>.Instance)?.ForceSaveToDisk();
		}

		[Cpp2IlInjected.Token(Token = "0x6002254")]
		[Cpp2IlInjected.Address(RVA = "0xCC7C30", Offset = "0xCC6630", VA = "0x180CC7C30")]
		private void OnApplicationQuit()
		{
			if (SaveOnExitPolicy == SaveOnExitPolicyType.OnQuit)
			{
				DoSaveOnExitImpl();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002255")]
		[Cpp2IlInjected.Address(RVA = "0xCC7E50", Offset = "0xCC6850", VA = "0x180CC7E50")]
		private void SaveOnSuspendImpl()
		{
			//Discarded unreachable code: IL_0031
			int num = 0;
			DateTime now = DateTime.Now;
			DateTime lastSaveOnSuspendTime = LastSaveOnSuspendTime;
			TimeSpan timeSpan = now - lastSaveOnSuspendTime;
			SavegameManagerConfig config = Config;
			if (false)
			{
				DoSaveOnExitImpl();
				LastSaveOnSuspendTime = now;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002256")]
		[Cpp2IlInjected.Address(RVA = "0xCC7AB0", Offset = "0xCC64B0", VA = "0x180CC7AB0")]
		private void OnApplicationFocus(bool focus)
		{
			string text = string.Format("SaveGameMgr.OnApplicationFocus({0})", "SaveGameMgr.OnApplicationFocus({0})");
			if (SaveOnExitPolicy == SaveOnExitPolicyType.OnFocusOut && !focus)
			{
				SaveOnSuspendImpl();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002257")]
		[Cpp2IlInjected.Address(RVA = "0xCC7B70", Offset = "0xCC6570", VA = "0x180CC7B70")]
		private void OnApplicationPause(bool pause)
		{
			string text = string.Format("SaveGameMgr.OnApplicationPause({0})", "SaveGameMgr.OnApplicationPause({0})");
			if (SaveOnExitPolicy == SaveOnExitPolicyType.OnPause && pause)
			{
				SaveOnSuspendImpl();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002258")]
		[Cpp2IlInjected.Address(RVA = "0xCC8060", Offset = "0xCC6A60", VA = "0x180CC8060")]
		public SavegameManager()
		{
		}//IL_001b: Expected I4, but got I8
		//IL_0032: Expected I4, but got I8

	}
}
