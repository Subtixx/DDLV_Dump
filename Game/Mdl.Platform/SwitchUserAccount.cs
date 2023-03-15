using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta.Online;
using UnityEngine;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002EA")]
	public class SwitchUserAccount : MonoBehaviour, AuthManager.IPlatformTokenProvider
	{
		[Cpp2IlInjected.Token(Token = "0x20002EB")]
		private enum OpenNetworkUserStatus
		{
			[Cpp2IlInjected.Token(Token = "0x40015DA")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40015DB")]
			Started,
			[Cpp2IlInjected.Token(Token = "0x40015DC")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x40015DD")]
			Failed,
			[Cpp2IlInjected.Token(Token = "0x40015DE")]
			NoNSA,
			[Cpp2IlInjected.Token(Token = "0x40015DF")]
			Unknown
		}

		[Cpp2IlInjected.Token(Token = "0x40015CD")]
		private static SwitchUserAccount _instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40015D1")]
		private ulong nsaTokenActualSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40015D2")]
		private byte[] nsaTokenBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40015D3")]
		private readonly TimeSpan NSATokenExpirationDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40015D4")]
		private readonly TimeSpan NSATokenRefreshOnFetchDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40015D5")]
		private readonly TimeSpan MinimalInternalToRefreshSuccessfulNSAToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40015D7")]
		private OpenNetworkUserStatus nsaStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40015D8")]
		public string _nickname;

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public static SwitchUserAccount Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD8")]
			[Cpp2IlInjected.Address(RVA = "0x106AF50", Offset = "0x1069950", VA = "0x18106AF50")]
			get
			{
				//Discarded unreachable code: IL_0034
				//IL_000f: Expected O, but got I4
				SwitchUserAccount instance = _instance;
				int num = 0;
				if (instance == (UnityEngine.Object)num)
				{
					GameObject gameObject = new GameObject("SwitchUserAccount");
					UnityEngine.Object.DontDestroyOnLoad(gameObject);
					_instance = gameObject.AddComponent<SwitchUserAccount>();
				}
				return _instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40015CE")]
		public bool IsUserOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD9")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000CDA")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x19"), Cpp2IlInjected.Token(Token = "0x40015CF")]
		public bool IsNetworkUserOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000CDB")]
			[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000CDC")]
			[Cpp2IlInjected.Address(RVA = "0x63C290", Offset = "0x63AC90", VA = "0x18063C290")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1A"), Cpp2IlInjected.Token(Token = "0x40015D0")]
		public bool IsPromptingForNintendoAccountUser
		{
			[Cpp2IlInjected.Token(Token = "0x6000CDD")]
			[Cpp2IlInjected.Address(RVA = "0x63C0B0", Offset = "0x63AAB0", VA = "0x18063C0B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000CDE")]
			[Cpp2IlInjected.Address(RVA = "0x63C280", Offset = "0x63AC80", VA = "0x18063C280")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public bool HasValidNSAToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000CDF")]
			[Cpp2IlInjected.Address(RVA = "0x106AF40", Offset = "0x1069940", VA = "0x18106AF40")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public string NSATokenForPlayfab
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE0")]
			[Cpp2IlInjected.Address(RVA = "0x106B080", Offset = "0x1069A80", VA = "0x18106B080")]
			get
			{
				//Discarded unreachable code: IL_0039
				if ((long)nsaTokenBuffer > 0)
				{
					int num = 0;
					Encoding uTF = Encoding.UTF8;
					byte[] bytes = nsaTokenBuffer;
					string @string = uTF.GetString(bytes);
					char[] trimChars = new char[1];
					return @string.TrimEnd(trimChars);
				}
				return "null";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x40015D6")]
		public DateTime LastNSATokenSuccessTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE1")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000CE2")]
			[Cpp2IlInjected.Address(RVA = "0x70BFD0", Offset = "0x70A9D0", VA = "0x18070BFD0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public string Nickname
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE3")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return _nickname;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE4")]
		[Cpp2IlInjected.Address(RVA = "0x106AAE0", Offset = "0x10694E0", VA = "0x18106AAE0")]
		public void DebugOnly_InvalidateCachedNSAToken()
		{
			byte[] array = nsaTokenBuffer;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE5")]
		[Cpp2IlInjected.Address(RVA = "0x106AB20", Offset = "0x1069520", VA = "0x18106AB20")]
		public void DebugOnly_SimulateTokenExpired()
		{
			DateTime arg = LastNSATokenSuccessTime;
			Debug.Log($"DebugOnly_SimulateTokenExpired LastNSATokenSuccessTime={arg}) before cheat");
			if ((long)nsaTokenBuffer > 0)
			{
				TimeSpan timeSpan = default(TimeSpan);
				LastNSATokenSuccessTime -= timeSpan;
			}
			DateTime arg2 = LastNSATokenSuccessTime;
			Debug.Log($"DebugOnly_SimulateTokenExpired LastNSATokenSuccessTime={arg2}) after cheat");
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE6")]
		[Cpp2IlInjected.Address(RVA = "0x106AAC0", Offset = "0x10694C0", VA = "0x18106AAC0")]
		public void ClearNSATokenFailureStatus()
		{
			//IL_0012: Expected I4, but got I8
			if (nsaStatus > OpenNetworkUserStatus.Started)
			{
				nsaStatus = OpenNetworkUserStatus.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
		public bool ForceRefreshNSAToken()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
		private bool ForceRefreshNSATokenImpl(bool forceRefreshOnlySuccess, TimeSpan refreshDelay)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void OpenUser()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void CloseUser()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEB")]
		[Cpp2IlInjected.Address(RVA = "0x106ADA0", Offset = "0x10697A0", VA = "0x18106ADA0")]
		[AsyncStateMachine(typeof(_003COpenNetworkServiceAccountAsync_003Ed__40))]
		public Task OpenNetworkServiceAccountAsync(CancellationToken ct)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void DebugTraceInfo()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000CED")]
		[Cpp2IlInjected.Address(RVA = "0x106ACB0", Offset = "0x10696B0", VA = "0x18106ACB0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CFetch_003Ed__42))]
		public Task<AuthManager.PlatformTokenFetchResult> Fetch(AuthManager.PlatformTokenFetchRequest request, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<AuthManager.PlatformTokenFetchResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0x106AE70", Offset = "0x1069870", VA = "0x18106AE70")]
		public SwitchUserAccount()
		{
			TimeSpan nSATokenExpirationDelay = default(TimeSpan);
			NSATokenExpirationDelay = nSATokenExpirationDelay;
			TimeSpan nSATokenRefreshOnFetchDelay = default(TimeSpan);
			NSATokenRefreshOnFetchDelay = nSATokenRefreshOnFetchDelay;
			TimeSpan minimalInternalToRefreshSuccessfulNSAToken = default(TimeSpan);
			MinimalInternalToRefreshSuccessfulNSAToken = minimalInternalToRefreshSuccessfulNSAToken;
			LastNSATokenSuccessTime = DateTime.MinValue;
			base._002Ector();
		}
	}
}
