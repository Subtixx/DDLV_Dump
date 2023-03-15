using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CloudScripts;
using Cpp2IlInjected;
using Meta.Util;
using Serilog;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000FA5")]
	public class ProfileConflictResolver
	{
		[Cpp2IlInjected.Token(Token = "0x2000FA6")]
		public enum State
		{
			[Cpp2IlInjected.Token(Token = "0x4004073")]
			NotChecked,
			[Cpp2IlInjected.Token(Token = "0x4004074")]
			Checking,
			[Cpp2IlInjected.Token(Token = "0x4004075")]
			Conflicted,
			[Cpp2IlInjected.Token(Token = "0x4004076")]
			ErrorFetchingServerMiniProfile,
			[Cpp2IlInjected.Token(Token = "0x4004077")]
			Resolved
		}

		[Cpp2IlInjected.Token(Token = "0x2000FA7")]
		public enum ConflictState
		{
			[Cpp2IlInjected.Token(Token = "0x4004079")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400407A")]
			LocalRecommended,
			[Cpp2IlInjected.Token(Token = "0x400407B")]
			ServerRecommended,
			[Cpp2IlInjected.Token(Token = "0x400407C")]
			LocalServer,
			[Cpp2IlInjected.Token(Token = "0x400407D")]
			AutoPickLocalProfile,
			[Cpp2IlInjected.Token(Token = "0x400407E")]
			AutoPickServerProfile
		}

		[Cpp2IlInjected.Token(Token = "0x2000FA8")]
		public delegate void ConflictDetected(ProfileConflictResolver profileConflictResolver);

		[Cpp2IlInjected.Token(Token = "0x2000FA9")]
		public delegate void ConflictResolved(ProfileConflictResolutionResult result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004069")]
		private Client client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400406E")]
		public OnlineClient.CustomerCareProfile.Result CustomerCareConflictResult;

		[Cpp2IlInjected.Token(Token = "0x17001630")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4004068")]
		public State CurrentState
		{
			[Cpp2IlInjected.Token(Token = "0x6007EED")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007EEE")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001631")]
		private ILogger Log
		{
			[Cpp2IlInjected.Token(Token = "0x6007EEF")]
			[Cpp2IlInjected.Address(RVA = "0x7BA190", Offset = "0x7B8B90", VA = "0x1807BA190")]
			get
			{
				//Discarded unreachable code: IL_000c
				return client.Log;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001632")]
		public MiniProfile LocalMiniProfile
		{
			[Cpp2IlInjected.Token(Token = "0x6007EF0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CLocalMiniProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007EF1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CLocalMiniProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001633")]
		public OnlineClient.FetchMiniProfileResult ServerMiniProfileFetchResult
		{
			[Cpp2IlInjected.Token(Token = "0x6007EF2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CServerMiniProfileFetchResult_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007EF3")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CServerMiniProfileFetchResult_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001634")]
		public MiniProfile ServerMiniProfile
		{
			[Cpp2IlInjected.Token(Token = "0x6007EF4")]
			[Cpp2IlInjected.Address(RVA = "0x951D40", Offset = "0x950740", VA = "0x180951D40")]
			get
			{
				OnlineClient.FetchMiniProfileResult fetchMiniProfileResult;
				do
				{
					fetchMiniProfileResult = ServerMiniProfileFetchResult;
				}
				while (fetchMiniProfileResult == null);
				return fetchMiniProfileResult.MiniProfile;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001635")]
		public OnlineClient.FetchProfileResult ServerProfileFetchResult
		{
			[Cpp2IlInjected.Token(Token = "0x6007EF5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CServerProfileFetchResult_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007EF6")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CServerProfileFetchResult_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001636")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x400406D")]
		public ConflictState CurrentConflictState
		{
			[Cpp2IlInjected.Token(Token = "0x6007EF7")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007EF8")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001637")]
		public bool HasCustomerCareOrConflictToResolve
		{
			[Cpp2IlInjected.Token(Token = "0x6007EF9")]
			[Cpp2IlInjected.Address(RVA = "0x951C10", Offset = "0x950610", VA = "0x180951C10")]
			get
			{
				if (CurrentConflictState > ConflictState.None)
				{
					return true;
				}
				OnlineClient.CustomerCareProfile.Result customerCareConflictResult = CustomerCareConflictResult;
				if (customerCareConflictResult != null)
				{
					return customerCareConflictResult.HasCustomeCareProfileToApply;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001638")]
		public bool HasPendingConflictToResolve
		{
			[Cpp2IlInjected.Token(Token = "0x6007EFA")]
			[Cpp2IlInjected.Address(RVA = "0x951C50", Offset = "0x950650", VA = "0x180951C50")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001639")]
		public bool IsConflictLocalRecommended
		{
			[Cpp2IlInjected.Token(Token = "0x6007EFB")]
			[Cpp2IlInjected.Address(RVA = "0x951C80", Offset = "0x950680", VA = "0x180951C80")]
			get
			{
				return CurrentConflictState == ConflictState.LocalRecommended;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700163A")]
		public bool IsConflictServerRecommended
		{
			[Cpp2IlInjected.Token(Token = "0x6007EFC")]
			[Cpp2IlInjected.Address(RVA = "0x951C90", Offset = "0x950690", VA = "0x180951C90")]
			get
			{
				return CurrentConflictState == ConflictState.ServerRecommended;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700163B")]
		public bool IsConflictedLocalServer
		{
			[Cpp2IlInjected.Token(Token = "0x6007EFD")]
			[Cpp2IlInjected.Address(RVA = "0x951CB0", Offset = "0x9506B0", VA = "0x180951CB0")]
			get
			{
				return CurrentConflictState == ConflictState.LocalServer;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700163C")]
		public bool IsConflictedAutoPickServerProfile
		{
			[Cpp2IlInjected.Token(Token = "0x6007EFE")]
			[Cpp2IlInjected.Address(RVA = "0x951CA0", Offset = "0x9506A0", VA = "0x180951CA0")]
			get
			{
				return CurrentConflictState == ConflictState.AutoPickServerProfile;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700163D")]
		public bool HasCustomerCareProfile
		{
			[Cpp2IlInjected.Token(Token = "0x6007EFF")]
			[Cpp2IlInjected.Address(RVA = "0x951C30", Offset = "0x950630", VA = "0x180951C30")]
			get
			{
				OnlineClient.CustomerCareProfile.Result customerCareConflictResult = CustomerCareConflictResult;
				if (customerCareConflictResult != null)
				{
					return customerCareConflictResult.HasCustomeCareProfileToApply;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700163E")]
		public MiniProfile CustomerCareMiniProfile
		{
			[Cpp2IlInjected.Token(Token = "0x6007F00")]
			[Cpp2IlInjected.Address(RVA = "0x951BF0", Offset = "0x9505F0", VA = "0x180951BF0")]
			get
			{
				OnlineClient.CustomerCareProfile.Result customerCareConflictResult = CustomerCareConflictResult;
				if (customerCareConflictResult != null)
				{
					DoProfileBackup.DisplayProperties displayProps = customerCareConflictResult.DisplayProps;
					if (displayProps != null)
					{
						return displayProps.ToMiniProfile();
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700163F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x400406F")]
		public bool IsConflictForcedByDebug
		{
			[Cpp2IlInjected.Token(Token = "0x6007F03")]
			[Cpp2IlInjected.Address(RVA = "0x951C70", Offset = "0x950670", VA = "0x180951C70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007F04")]
			[Cpp2IlInjected.Address(RVA = "0x951E90", Offset = "0x950890", VA = "0x180951E90")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001640")]
		public bool IsServerNewer
		{
			[Cpp2IlInjected.Token(Token = "0x6007F05")]
			[Cpp2IlInjected.Address(RVA = "0x951CD0", Offset = "0x9506D0", VA = "0x180951CD0")]
			get
			{
				OnlineClient.FetchMiniProfileResult fetchMiniProfileResult = ServerMiniProfileFetchResult;
				if (fetchMiniProfileResult != null)
				{
					MiniProfile miniProfile = fetchMiniProfileResult.MiniProfile;
					if (miniProfile != null)
					{
						MiniProfile other = LocalMiniProfile;
						return miniProfile.IsOlder(other);
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001641")]
		public bool IsServerOlder
		{
			[Cpp2IlInjected.Token(Token = "0x6007F06")]
			[Cpp2IlInjected.Address(RVA = "0x951D10", Offset = "0x950710", VA = "0x180951D10")]
			get
			{
				OnlineClient.FetchMiniProfileResult fetchMiniProfileResult = ServerMiniProfileFetchResult;
				if (fetchMiniProfileResult != null)
				{
					MiniProfile miniProfile = fetchMiniProfileResult.MiniProfile;
					if (miniProfile != null)
					{
						MiniProfile other = LocalMiniProfile;
						return miniProfile.IsOlder(other);
					}
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001642")]
		public bool IsCheckingConflicts
		{
			[Cpp2IlInjected.Token(Token = "0x6007F07")]
			[Cpp2IlInjected.Address(RVA = "0x951C60", Offset = "0x950660", VA = "0x180951C60")]
			get
			{
				return CurrentState == State.Checking;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001643")]
		public bool IsResolvingConflicts
		{
			[Cpp2IlInjected.Token(Token = "0x6007F08")]
			[Cpp2IlInjected.Address(RVA = "0x951CC0", Offset = "0x9506C0", VA = "0x180951CC0")]
			get
			{
				return CurrentState != State.Resolved;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000A6")]
		public event ConflictDetected OnConflictDetected
		{
			[Cpp2IlInjected.Token(Token = "0x6007F09")]
			[Cpp2IlInjected.Address(RVA = "0x951AB0", Offset = "0x9504B0", VA = "0x180951AB0")]
			[CompilerGenerated]
			add
			{
				ConflictDetected onConflictDetected = this.OnConflictDetected;
				Delegate @delegate = Delegate.Combine(onConflictDetected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onConflictDetected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007F0A")]
			[Cpp2IlInjected.Address(RVA = "0x951D50", Offset = "0x950750", VA = "0x180951D50")]
			[CompilerGenerated]
			remove
			{
				ConflictDetected onConflictDetected = this.OnConflictDetected;
				Delegate @delegate = Delegate.Remove(onConflictDetected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onConflictDetected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000A7")]
		public event ConflictResolved OnConflictResolved
		{
			[Cpp2IlInjected.Token(Token = "0x6007F0B")]
			[Cpp2IlInjected.Address(RVA = "0x951B50", Offset = "0x950550", VA = "0x180951B50")]
			[CompilerGenerated]
			add
			{
				ConflictResolved onConflictResolved = this.OnConflictResolved;
				Delegate @delegate = Delegate.Combine(onConflictResolved, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onConflictResolved)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007F0C")]
			[Cpp2IlInjected.Address(RVA = "0x951DF0", Offset = "0x9507F0", VA = "0x180951DF0")]
			[CompilerGenerated]
			remove
			{
				ConflictResolved onConflictResolved = this.OnConflictResolved;
				Delegate @delegate = Delegate.Remove(onConflictResolved, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onConflictResolved)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007F01")]
		[Cpp2IlInjected.Address(RVA = "0x950F20", Offset = "0x94F920", VA = "0x180950F20")]
		public MiniProfile GetLocalMiniProfile()
		{
			//Discarded unreachable code: IL_003c
			MiniProfile miniProfile = LocalMiniProfile;
			if (miniProfile == null)
			{
				Profile profile = client.LocalProfileHolder.profile;
				if (profile == null || profile.GetMiniProfile() == null)
				{
					return client.LocalStorage.MiniProfile;
				}
			}
			return miniProfile;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F02")]
		[Cpp2IlInjected.Address(RVA = "0x9511B0", Offset = "0x94FBB0", VA = "0x1809511B0")]
		private void ResetConflictState()
		{
			//IL_0009: Expected I4, but got I8
			CurrentConflictState = ConflictState.None;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F0D")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950450", VA = "0x180951A50")]
		public ProfileConflictResolver(Client client)
		{
			//IL_0016: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			this.client = client;
			int num = 0;
			LocalMiniProfile = (MiniProfile)num;
			ServerProfileFetchResult = (OnlineClient.FetchProfileResult)num;
			CurrentConflictState = (ConflictState)num;
			CurrentState = (State)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F0E")]
		[Cpp2IlInjected.Address(RVA = "0x94F940", Offset = "0x94E340", VA = "0x18094F940")]
		private void ClearAll(State goToState)
		{
			//IL_0009: Expected O, but got I8
			//IL_0014: Expected I4, but got I8
			LocalMiniProfile = (MiniProfile)0;
			CurrentConflictState = ConflictState.None;
			CurrentState = goToState;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F0F")]
		[Cpp2IlInjected.Address(RVA = "0x950F90", Offset = "0x94F990", VA = "0x180950F90")]
		public void GoOffline()
		{
			//IL_0009: Expected O, but got I4
			//IL_0010: Expected O, but got I4
			int num = 0;
			LocalMiniProfile = (MiniProfile)num;
			ServerProfileFetchResult = (OnlineClient.FetchProfileResult)num;
			CurrentConflictState = (ConflictState)num;
			CurrentState = (State)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F10")]
		[Cpp2IlInjected.Address(RVA = "0x950FD0", Offset = "0x94F9D0", VA = "0x180950FD0")]
		public void MarkAsNewUser()
		{
			//Discarded unreachable code: IL_0050
			//IL_000f: Expected O, but got I4
			//IL_0018: Expected I4, but got I8
			//IL_0038: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_004f: Expected I4, but got I8
			ProfileConflictResolutionResult profileConflictResolutionResult = new ProfileConflictResolutionResult();
			int num = 0;
			profileConflictResolutionResult.usedMiniProfile = (MiniProfile)num;
			profileConflictResolutionResult.resolutionType = ProfileConflictResolutionResult.ConflictResolutionType.NewUser;
			profileConflictResolutionResult.pickedByDebugCode = (byte)num != 0;
			this.OnConflictResolved?.Invoke(profileConflictResolutionResult);
			LocalMiniProfile = (MiniProfile)num;
			ServerProfileFetchResult = (OnlineClient.FetchProfileResult)num;
			CurrentConflictState = (ConflictState)num;
			CurrentState = State.Resolved;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F11")]
		[Cpp2IlInjected.Address(RVA = "0x951090", Offset = "0x94FA90", VA = "0x180951090")]
		public void MarkAsProfileReset()
		{
			//Discarded unreachable code: IL_0050
			//IL_000f: Expected O, but got I4
			//IL_0018: Expected I4, but got I8
			//IL_0038: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_004f: Expected I4, but got I8
			ProfileConflictResolutionResult profileConflictResolutionResult = new ProfileConflictResolutionResult();
			int num = 0;
			profileConflictResolutionResult.usedMiniProfile = (MiniProfile)num;
			profileConflictResolutionResult.resolutionType = ProfileConflictResolutionResult.ConflictResolutionType.ProfileReset;
			profileConflictResolutionResult.pickedByDebugCode = (byte)num != 0;
			this.OnConflictResolved?.Invoke(profileConflictResolutionResult);
			LocalMiniProfile = (MiniProfile)num;
			ServerProfileFetchResult = (OnlineClient.FetchProfileResult)num;
			CurrentConflictState = (ConflictState)num;
			CurrentState = State.Resolved;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F12")]
		[Cpp2IlInjected.Address(RVA = "0x951150", Offset = "0x94FB50", VA = "0x180951150")]
		private void MarkAsResolved(ProfileConflictResolutionResult result)
		{
			//IL_001b: Expected I4, but got I8
			//IL_0024: Expected I4, but got I8
			this.OnConflictResolved?.Invoke(result);
			CurrentConflictState = ConflictState.None;
			CurrentState = State.Resolved;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F13")]
		[Cpp2IlInjected.Address(RVA = "0x951920", Offset = "0x950320", VA = "0x180951920")]
		[AsyncStateMachine(typeof(_003CStartLocalRemoteConflictChecks_003Ed__72))]
		public Task StartLocalRemoteConflictChecks(OnlineClient.LoginRequestParams loginRequestParams, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F14")]
		[Cpp2IlInjected.Address(RVA = "0x950E00", Offset = "0x94F800", VA = "0x180950E00")]
		[AsyncStateMachine(typeof(_003CDoAutoResolve_003Ed__73))]
		private Task DoAutoResolve(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F15")]
		[Cpp2IlInjected.Address(RVA = "0x9515C0", Offset = "0x94FFC0", VA = "0x1809515C0")]
		public Task<bool> ResolveUseLocal(bool pickedByUser, CancellationToken ct)
		{
			if (CurrentConflictState > ConflictState.None)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<bool>)(object)result;
			}
			ILogger _003CLog_003Ek__BackingField = client.Log;
			Task<> task = Task.FromResult(result: false);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007F16")]
		[Cpp2IlInjected.Address(RVA = "0x951470", Offset = "0x94FE70", VA = "0x180951470")]
		[AsyncStateMachine(typeof(_003CResolveUseLocalImpl_003Ed__75))]
		public Task<bool> ResolveUseLocalImpl(bool pickedByUser, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F17")]
		[Cpp2IlInjected.Address(RVA = "0x9517C0", Offset = "0x9501C0", VA = "0x1809517C0")]
		[AsyncStateMachine(typeof(_003CResolveUseRemote_003Ed__76))]
		public Task<bool> ResolveUseRemote(bool pickedByUser, bool forceWhilePlaying, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F18")]
		[Cpp2IlInjected.Address(RVA = "0x9511C0", Offset = "0x94FBC0", VA = "0x1809511C0")]
		[AsyncStateMachine(typeof(_003CResolveCustomerCareUseLocal_003Ed__77))]
		public Task<bool> ResolveCustomerCareUseLocal(bool pickedByUser, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F19")]
		[Cpp2IlInjected.Address(RVA = "0x951310", Offset = "0x94FD10", VA = "0x180951310")]
		[AsyncStateMachine(typeof(_003CResolveCustomerCareUseRemote_003Ed__78))]
		public Task<bool> ResolveCustomerCareUseRemote(bool pickedByUser, bool forceWhilePlaying, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F1A")]
		[Cpp2IlInjected.Address(RVA = "0x94F990", Offset = "0x94E390", VA = "0x18094F990")]
		private void CompareProfiles()
		{
			//Discarded unreachable code: IL_072e
			//IL_0034: Expected I4, but got I8
			//IL_03b8: Expected I4, but got I8
			//IL_0548: Expected I4, but got I8
			//IL_062d: Expected I4, but got I8
			//IL_0669: Expected I4, but got I8
			//IL_0689: Expected I4, but got I8
			//IL_0700: Expected I4, but got I8
			//IL_072b: Expected O, but got I4
			//IL_072b: Expected O, but got I4
			MiniProfile miniProfile;
			OnlineClient.FetchMiniProfileResult fetchMiniProfileResult;
			bool flag3 = default(bool);
			while (true)
			{
				miniProfile = LocalMiniProfile;
				fetchMiniProfileResult = ServerMiniProfileFetchResult;
				if (miniProfile == null)
				{
					if (fetchMiniProfileResult != null)
					{
						if (fetchMiniProfileResult.MiniProfile != miniProfile)
						{
							ILogger _003CLog_003Ek__BackingField = this.client.Log;
							CurrentConflictState = ConflictState.AutoPickServerProfile;
						}
						if (fetchMiniProfileResult != null && (long)fetchMiniProfileResult.MiniProfile != 0)
						{
							goto IL_005d;
						}
					}
					ILogger _003CLog_003Ek__BackingField2 = this.client.Log;
				}
				if ((long)fetchMiniProfileResult.MiniProfile == 0)
				{
					break;
				}
				goto IL_005d;
				IL_005d:
				if (fetchMiniProfileResult.MiniProfile.gameInfo_.lastSaveDeviceInfo_ == null)
				{
					Client client = this.client;
				}
				Client client2 = this.client;
				MiniProfile miniProfile2 = LocalMiniProfile;
				ILogger _003CLog_003Ek__BackingField3 = client2.Log;
				string debugProfileDesc = miniProfile2.GetDebugProfileDesc();
				string debugProfileDesc2 = ServerMiniProfileFetchResult.MiniProfile.GetDebugProfileDesc();
				string text = "[AL][Online/CompareProfiles] Local Profile=" + debugProfileDesc + "\nServer Profile=" + debugProfileDesc2;
				int num = 0;
				if (!DebugSettings.Settings.DoResetProfile)
				{
					ProfileGameInfo gameInfo_ = ServerMiniProfileFetchResult.MiniProfile.gameInfo_;
					string profileUID_ = LocalMiniProfile.gameInfo_.profileUID_;
					if (!(gameInfo_.profileUID_ != profileUID_))
					{
						MiniProfile miniProfile3 = ServerMiniProfileFetchResult.MiniProfile;
						MiniProfile other = LocalMiniProfile;
						bool flag = miniProfile3.IsOlder(other);
						OnlineClient.FetchMiniProfileResult fetchMiniProfileResult2 = ServerMiniProfileFetchResult;
						if (!flag)
						{
							MiniProfile miniProfile4 = fetchMiniProfileResult2.MiniProfile;
							MiniProfile other2 = LocalMiniProfile;
							if (!miniProfile4.IsNewer(other2))
							{
								ILogger _003CLog_003Ek__BackingField4 = this.client.Log;
							}
							MiniProfile miniProfile5 = ServerMiniProfileFetchResult.MiniProfile;
							MiniProfile other3 = LocalMiniProfile;
							bool flag2 = miniProfile5.IsLastSaveFrom(other3);
							Client client3 = this.client;
							if (!flag2)
							{
								ILogger _003CLog_003Ek__BackingField5 = client3.Log;
								string[] array = new string[9];
								if ("[AL][Online/CompareProfiles] Server Profile (" != null && "[AL][Online/CompareProfiles] Server Profile (" == null)
								{
									continue;
								}
								array[0] = "[AL][Online/CompareProfiles] Server Profile (";
								string dataComparedStr = ServerMiniProfileFetchResult.MiniProfile.DataComparedStr;
								if (dataComparedStr != null && dataComparedStr == null)
								{
									continue;
								}
								array[1] = dataComparedStr;
								if (") is newer than Local Profile (" != null && ") is newer than Local Profile (" == null)
								{
									continue;
								}
								array[2] = ") is newer than Local Profile (";
								string dataComparedStr2 = LocalMiniProfile.DataComparedStr;
								if (dataComparedStr2 != null && dataComparedStr2 == null)
								{
									continue;
								}
								array[3] = dataComparedStr2;
								if (") but comes from another device '" != null && ") but comes from another device '" == null)
								{
									continue;
								}
								array[4] = ") but comes from another device '";
								MiniProfile miniProfile6 = ServerMiniProfileFetchResult.MiniProfile;
								string deviceID_ = miniProfile6.gameInfo_.lastSaveDeviceInfo_.deviceID_;
								if (deviceID_ != null && miniProfile6 == null)
								{
									continue;
								}
								array[5] = deviceID_;
								if ("', while local is '" != null && "', while local is '" == null)
								{
									continue;
								}
								array[6] = "', while local is '";
								ProfileGameInfo gameInfo_2 = LocalMiniProfile.gameInfo_;
								string deviceID_2 = gameInfo_2.DeviceInfo.deviceID_;
								if (deviceID_2 != null && gameInfo_2 == null)
								{
									continue;
								}
								array[7] = deviceID_2;
								if ("' => server profile commended." != null && "' => server profile commended." == null)
								{
									continue;
								}
							}
							string[] array2 = new string[5];
							if ("[AL][Online/CompareProfiles] Server Profile (" != null && "[AL][Online/CompareProfiles] Server Profile (" == null)
							{
								continue;
							}
							array2[0] = "[AL][Online/CompareProfiles] Server Profile (";
							string dataComparedStr3 = ServerMiniProfileFetchResult.MiniProfile.DataComparedStr;
							if (dataComparedStr3 != null && dataComparedStr3 == null)
							{
								continue;
							}
							array2[1] = dataComparedStr3;
							if (") is newer than Local Profile (" != null && ") is newer than Local Profile (" == null)
							{
								continue;
							}
							array2[2] = ") is newer than Local Profile (";
							string dataComparedStr4 = LocalMiniProfile.DataComparedStr;
							if (dataComparedStr4 != null && dataComparedStr4 == null)
							{
								continue;
							}
							array2[3] = dataComparedStr4;
							if (") and comes from same device => server profile recommended." != null && ") and comes from same device => server profile recommended." == null)
							{
								continue;
							}
							array2[4] = ") and comes from same device => server profile recommended.";
							string text2 = string.Concat(array2);
							CurrentConflictState = ConflictState.ServerRecommended;
						}
						MiniProfile miniProfile7 = LocalMiniProfile;
						Client client4 = this.client;
						if (!flag3)
						{
							ILogger _003CLog_003Ek__BackingField6 = client4.Log;
							string[] array3 = new string[5];
							if ("[AL][Online/CompareProfiles] Server Profile (" != null && "[AL][Online/CompareProfiles] Server Profile (" == null)
							{
								continue;
							}
							array3[0] = "[AL][Online/CompareProfiles] Server Profile (";
							string dataComparedStr5 = ServerMiniProfileFetchResult.MiniProfile.DataComparedStr;
							if (dataComparedStr5 != null && dataComparedStr5 == null)
							{
								continue;
							}
							array3[1] = dataComparedStr5;
							if (") is older than Local Profile (" != null && ") is older than Local Profile (" == null)
							{
								continue;
							}
							array3[2] = ") is older than Local Profile (";
							string dataComparedStr6 = LocalMiniProfile.DataComparedStr;
							if (dataComparedStr6 != null && dataComparedStr6 == null)
							{
								continue;
							}
							array3[3] = dataComparedStr6;
							if (") and comes from another device => conflict resolving required." != null && ") and comes from another device => conflict resolving required." == null)
							{
								continue;
							}
						}
						string[] array4 = new string[5];
						if ("[AL][Online/CompareProfiles] Local Profile (" != null && "[AL][Online/CompareProfiles] Local Profile (" == null)
						{
							continue;
						}
						array4[0] = "[AL][Online/CompareProfiles] Local Profile (";
						string dataComparedStr7 = LocalMiniProfile.DataComparedStr;
						if (dataComparedStr7 != null && dataComparedStr7 == null)
						{
							continue;
						}
						array4[1] = dataComparedStr7;
						if (") is newer than Server Profile (" != null && ") is newer than Server Profile (" == null)
						{
							continue;
						}
						array4[2] = ") is newer than Server Profile (";
						string dataComparedStr8 = ServerMiniProfileFetchResult.MiniProfile.DataComparedStr;
						if (dataComparedStr8 != null && dataComparedStr8 == null)
						{
							continue;
						}
						array4[3] = dataComparedStr8;
						if (") and from same device => auto pick local profile." != null && ") and from same device => auto pick local profile." == null)
						{
							continue;
						}
						array4[4] = ") and from same device => auto pick local profile.";
						string text3 = string.Concat(array4);
						CurrentConflictState = ConflictState.AutoPickLocalProfile;
					}
					ILogger _003CLog_003Ek__BackingField7 = this.client.Log;
					string[] array5 = new string[5];
					if ("[AL][Online/CompareProfiles] PUI desync detected with Local Profile UID=(" != null && "[AL][Online/CompareProfiles] PUI desync detected with Local Profile UID=(" == null)
					{
						continue;
					}
					array5[0] = "[AL][Online/CompareProfiles] PUI desync detected with Local Profile UID=(";
					string profileUID_2 = LocalMiniProfile.gameInfo_.profileUID_;
					if (profileUID_2 != null && "[AL][Online/CompareProfiles] PUI desync detected with Local Profile UID=(" == null)
					{
						continue;
					}
					array5[1] = profileUID_2;
					if (") and Server Profile UID=(" != null && ") and Server Profile UID=(" == null)
					{
						continue;
					}
					array5[2] = ") and Server Profile UID=(";
					MiniProfile miniProfile8 = ServerMiniProfileFetchResult.MiniProfile;
					string profileUID_3 = miniProfile8.gameInfo_.profileUID_;
					if (profileUID_3 != null && miniProfile8 == null)
					{
						continue;
					}
					array5[3] = profileUID_3;
					if (") => conflict resolving required." != null && ") => conflict resolving required." == null)
					{
						continue;
					}
					array5[4] = ") => conflict resolving required.";
					string text4 = string.Concat(array5);
					CurrentConflictState = ConflictState.LocalServer;
				}
				ILogger _003CLog_003Ek__BackingField8 = this.client.Log;
				int num2 = 0;
				if (DebugSettings.Settings.dontRestoreRemoteSave_ && CurrentConflictState == ConflictState.ServerRecommended)
				{
					ILogger _003CLog_003Ek__BackingField9 = this.client.Log;
					CurrentConflictState = ConflictState.None;
				}
				int num3 = 0;
				if (!DebugSettings.Settings.forceConflictPrompt_)
				{
					IsConflictForcedByDebug = false;
				}
				CurrentConflictState = ConflictState.LocalServer;
				bool flag4 = (IsConflictForcedByDebug = CurrentConflictState != ConflictState.LocalServer);
				break;
			}
			OnlineClient.FetchPlayFabFileResult.ResultTypes resultType = fetchMiniProfileResult.ResultType;
			if (resultType != OnlineClient.FetchPlayFabFileResult.ResultTypes.FileNotFoundOnServer)
			{
				if (resultType != OnlineClient.FetchPlayFabFileResult.ResultTypes.FileDeserializationError)
				{
					goto IL_0700;
				}
				ILogger _003CLog_003Ek__BackingField10 = this.client.Log;
				string dataComparedStr9 = miniProfile.DataComparedStr;
				string text5 = "[AL][Online/CompareProfiles] Had a Server Profile but was not able to deserialized it (savefile no longer valid) => auto pick local profile: " + dataComparedStr9;
			}
			ILogger _003CLog_003Ek__BackingField11 = this.client.Log;
			string dataComparedStr10 = miniProfile.DataComparedStr;
			string text6 = "[AL][Online/CompareProfiles] No Server Profile => auto pick local profile: " + dataComparedStr10;
			CurrentConflictState = ConflictState.AutoPickLocalProfile;
			goto IL_0700;
			IL_0700:
			ILogger _003CLog_003Ek__BackingField12 = this.client.Log;
			ConflictState conflictState = CurrentConflictState;
			bool flag5 = IsConflictForcedByDebug;
			string text7 = $"[AL][Online/CompareProfiles] Profiles comparison done with following results => ConflictState={conflictState}, IsConflictForcedByDebug={conflictState}.";
		}
	}
}
