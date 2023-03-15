using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Localization.Formatter;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Mdl.Ui;
using Meta;
using Meta.Online;
using Rewired.Data.Mapping;

namespace Mdl.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000353")]
	public class AccountLinkingManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000354")]
		public enum DebugAlertType
		{
			[Cpp2IlInjected.Token(Token = "0x4001700")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001701")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4001702")]
			CheatUi
		}

		[Cpp2IlInjected.Token(Token = "0x2000355")]
		public enum CompleteAndLoginGameloftId
		{
			[Cpp2IlInjected.Token(Token = "0x4001704")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4001705")]
			ConfirmationFailed,
			[Cpp2IlInjected.Token(Token = "0x4001706")]
			ConfirmedAndLoginFailed
		}

		[Cpp2IlInjected.Token(Token = "0x2000356")]
		public enum ProfileDescType
		{
			[Cpp2IlInjected.Token(Token = "0x4001708")]
			Local,
			[Cpp2IlInjected.Token(Token = "0x4001709")]
			Remote,
			[Cpp2IlInjected.Token(Token = "0x400170A")]
			CustomerCare
		}

		[Cpp2IlInjected.Token(Token = "0x40016FE")]
		private static AccountLinkingManager _instance;

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public static AccountLinkingManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000E49")]
			[Cpp2IlInjected.Address(RVA = "0xA3BF90", Offset = "0xA3A990", VA = "0x180A3BF90")]
			get
			{
				AccountLinkingManager accountLinkingManager = new AccountLinkingManager();
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		private OnlineClient client
		{
			[Cpp2IlInjected.Token(Token = "0x6000E4A")]
			[Cpp2IlInjected.Address(RVA = "0xA3C040", Offset = "0xA3AA40", VA = "0x180A3C040")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.MetaOnlineClient;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		private AuthManager authMgr
		{
			[Cpp2IlInjected.Token(Token = "0x6000E4B")]
			[Cpp2IlInjected.Address(RVA = "0xA3C010", Offset = "0xA3AA10", VA = "0x180A3C010")]
			get
			{
				//Discarded unreachable code: IL_000c
				return client.AuthentificationManager;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		private AuthManager.GameloftIDAuthenticator gameloftIdAuthenticator
		{
			[Cpp2IlInjected.Token(Token = "0x6000E4C")]
			[Cpp2IlInjected.Address(RVA = "0xA3C0F0", Offset = "0xA3AAF0", VA = "0x180A3C0F0")]
			get
			{
				//Discarded unreachable code: IL_0011
				return client.AuthentificationManager.GameloftIDAuthenticatorInst;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4D")]
		[Cpp2IlInjected.Address(RVA = "0xA3A590", Offset = "0xA38F90", VA = "0x180A3A590")]
		private Task<AlertButton> DebugUIAlert(DebugAlertType type, string message, IEnumerable<AlertButton> buttons, string title = "", bool showCloseButton = true, [Optional] CancellationToken ct)
		{
			//Discarded unreachable code: IL_0015
			//IL_000a: Expected O, but got I4
			if (type != DebugAlertType.Normal)
			{
				return (Task<AlertButton>)(object)Task.FromResult((AlertButton)0);
			}
			BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
			int num = 0;
			Task<AlertButton> result = default(Task<AlertButton>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4E")]
		[Cpp2IlInjected.Address(RVA = "0xA3A2F0", Offset = "0xA38CF0", VA = "0x180A3A2F0")]
		[AsyncStateMachine(typeof(_003CCreateGameloftIdAccount_003Ed__11))]
		public Task<bool> CreateGameloftIdAccount(DebugAlertType alertType, string email, string pwd)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4F")]
		[Cpp2IlInjected.Address(RVA = "0xA3A190", Offset = "0xA38B90", VA = "0x180A3A190")]
		[AsyncStateMachine(typeof(_003CCompleteGameloftIdAccountCreationAndLogin_003Ed__13))]
		public Task<CompleteAndLoginGameloftId> CompleteGameloftIdAccountCreationAndLogin(string verificationCode, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CompleteAndLoginGameloftId>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E50")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC30", Offset = "0xA3A630", VA = "0x180A3BC30")]
		[AsyncStateMachine(typeof(_003CTellUserIfNotLoggedIn_003Ed__14))]
		public Task TellUserIfNotLoggedIn()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E51")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3D0", Offset = "0xA39DD0", VA = "0x180A3B3D0")]
		[AsyncStateMachine(typeof(_003CLoginToGameloftIdAccount_003Ed__15))]
		public Task<bool> LoginToGameloftIdAccount(DebugAlertType alertType, string email, string pwd, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E52")]
		[Cpp2IlInjected.Address(RVA = "0xA3B6C0", Offset = "0xA3A0C0", VA = "0x180A3B6C0")]
		[AsyncStateMachine(typeof(_003CRefreshGameloftIdPasswordAndLogin_003Ed__16))]
		public Task<bool> RefreshGameloftIdPasswordAndLogin(string email, string pwd, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E53")]
		[Cpp2IlInjected.Address(RVA = "0xA3B550", Offset = "0xA39F50", VA = "0x180A3B550")]
		[AsyncStateMachine(typeof(_003CLogoutFromGameloftIdAccountAndReloginWithDefault_003Ed__17))]
		public Task<bool> LogoutFromGameloftIdAccountAndReloginWithDefault(DebugAlertType alertType, bool showConfirm = true, bool showAlert = true, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E54")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE60", Offset = "0xA3A860", VA = "0x180A3BE60")]
		[AsyncStateMachine(typeof(_003CTryLastNativeAuthRecoveryAndForceLink_003Ed__18))]
		private Task<bool> TryLastNativeAuthRecoveryAndForceLink(CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E55")]
		[Cpp2IlInjected.Address(RVA = "0xA3BD30", Offset = "0xA3A730", VA = "0x180A3BD30")]
		[AsyncStateMachine(typeof(_003CTryGameCustomIdUnlink_003Ed__19))]
		private Task<bool> TryGameCustomIdUnlink()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E56")]
		[Cpp2IlInjected.Address(RVA = "0xA3A710", Offset = "0xA39110", VA = "0x180A3A710")]
		public Task<bool> ForgetGameloftIDCredentials()
		{
			//Discarded unreachable code: IL_0016
			return (Task<bool>)(object)client.AuthentificationManager.GameloftIDAuthenticatorInst.ForgetMe();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E57")]
		[Cpp2IlInjected.Address(RVA = "0xA3B350", Offset = "0xA39D50", VA = "0x180A3B350")]
		public Task<bool> IsStillConnectedToInternet()
		{
			//Discarded unreachable code: IL_0010
			//IL_000d: Expected O, but got I4
			OnlineClient onlineClient = client;
			IList<HardwareJoystickMap.Platform> variants_base = (IList<HardwareJoystickMap.Platform>)((HardwareJoystickMap.Platform_NintendoSwitch_Base)0).get_variants_base();
			Task<bool> result = default(Task<bool>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E58")]
		[Cpp2IlInjected.Address(RVA = "0xA3B960", Offset = "0xA3A360", VA = "0x180A3B960")]
		[AsyncStateMachine(typeof(_003CSendResetPasswordToGameloftIdEmail_003Ed__22))]
		public Task<bool> SendResetPasswordToGameloftIdEmail(DebugAlertType alertType, string email)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E59")]
		[Cpp2IlInjected.Address(RVA = "0xA3BAB0", Offset = "0xA3A4B0", VA = "0x180A3BAB0")]
		[AsyncStateMachine(typeof(_003CSetNewGameloftIdPassword_003Ed__23))]
		public Task<bool> SetNewGameloftIdPassword(DebugAlertType alertType, string email, string newPassword, string verificationCode)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5A")]
		[Cpp2IlInjected.Address(RVA = "0xA3B820", Offset = "0xA3A220", VA = "0x180A3B820")]
		[AsyncStateMachine(typeof(_003CSaveOnlineProfile_003Ed__24))]
		public Task<bool> SaveOnlineProfile(DebugAlertType alertType, bool forceTestInternet)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5B")]
		[Cpp2IlInjected.Address(RVA = "0xA3A750", Offset = "0xA39150", VA = "0x180A3A750")]
		public string GetDebugInfos()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A460", Offset = "0xA38E60", VA = "0x180A3A460")]
		public void DebugOpenPlayFabGM()
		{
			//Discarded unreachable code: IL_0039
			string debugGetPlayFabUserGMLink = SystemRoot.Instance.MetaOnlineClient.DebugGetPlayFabUserGMLink;
			if (string.IsNullOrEmpty(debugGetPlayFabUserGMLink))
			{
				object[] args = Array.Empty<object>();
				GameLog.Info("Could not fetch playfab GM url", args);
			}
			else
			{
				object[] args2 = Array.Empty<object>();
				GameLog.Info(debugGetPlayFabUserGMLink, args2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5D")]
		[Cpp2IlInjected.Address(RVA = "0xA3B230", Offset = "0xA39C30", VA = "0x180A3B230")]
		public static string GetProfileDesc(MiniProfile miniProfile, bool local)
		{
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5E")]
		[Cpp2IlInjected.Address(RVA = "0xA3AA30", Offset = "0xA39430", VA = "0x180A3AA30")]
		public static string GetProfileDesc(MiniProfile miniProfile, ProfileDescType profileDescType)
		{
			//Discarded unreachable code: IL_00a8, IL_00c4, IL_00ca, IL_00d0, IL_00d6, IL_00dc, IL_00e9, IL_00ed, IL_00f1, IL_0107, IL_0142
			//IL_0057: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			//IL_00a0: Expected O, but got I4
			//IL_00a0: Expected O, but got I4
			//IL_0105: Expected O, but got I4
			//IL_0105: Expected O, but got I4
			//IL_012b: Expected O, but got I4
			int num = 0;
			if (miniProfile != null)
			{
				string msg = string.Format("[ACLinking] GetProfileDesc - Generic hard currency quantity set to {0}'.", "SpentTime");
				object[] args = Array.Empty<object>();
				GameLog.Info(msg, args);
				int num2 = 0;
				int itemID = CurrencyItem.HardCurrencyItem.ItemID;
				bool flag = default(bool);
				if (flag)
				{
					MapField<int, int> platformSpecificHardCurrencies_ = miniProfile.platformSpecificHardCurrencies_;
					bool flag2 = default(bool);
					if (flag2)
					{
						string text = $"[ACLinking] GetProfileDesc - Found platform specific currency '{flag2}' with a quantity of {flag2}.";
					}
				}
				string msg2 = $"[ACLinking] GetProfileDesc - Platform specific currency '{flag}' not found.";
				object[] args2 = Array.Empty<object>();
				GameLog.Info(msg2, args2);
				Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
				if (string.IsNullOrEmpty(miniProfile.playerName_))
				{
					int num3 = 0;
					int num4 = 0;
					string text2 = LocalizationManager.FromStringID("menu.conflict_profile_message_unnamed", (IResolver)num4, (string)num3);
				}
				throw new NullReferenceException();
			}
			return "";
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5F")]
		[Cpp2IlInjected.Address(RVA = "0xA3B240", Offset = "0xA39C40", VA = "0x180A3B240")]
		private static string GetProfileTitle(ProfileDescType profileDescType)
		{
			//IL_0020: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			int num = 0;
			if (profileDescType == ProfileDescType.Local || profileDescType == ProfileDescType.Local || profileDescType == ProfileDescType.Remote)
			{
				int num2 = 0;
				int num3 = 0;
				string text = LocalizationManager.FromStringID("menu.conflict_profile_local_description", (IResolver)num3, (string)num2);
			}
			return "<size=25><uppercase>" + (string)num + "</uppercase></size>";
		}

		[Cpp2IlInjected.Token(Token = "0x6000E60")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public AccountLinkingManager()
		{
		}
	}
}
