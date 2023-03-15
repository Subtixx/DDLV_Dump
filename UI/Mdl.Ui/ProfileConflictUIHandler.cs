using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Online;
using Mdl.Systems;
using Meta;
using Meta.Online;
using Meta.Util;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007F0")]
	public class ProfileConflictUIHandler : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002E9E")]
		private CancellationTokenSource _cancellationTokenSource;

		[Cpp2IlInjected.Token(Token = "0x17000720")]
		private static Meta.Online.Client MetaClient
		{
			[Cpp2IlInjected.Token(Token = "0x6003297")]
			[Cpp2IlInjected.Address(RVA = "0xE1E430", Offset = "0xE1CE30", VA = "0x180E1E430")]
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

		[Cpp2IlInjected.Token(Token = "0x17000721")]
		private static ProfileConflictResolver MetaProfileConflictResolver
		{
			[Cpp2IlInjected.Token(Token = "0x6003298")]
			[Cpp2IlInjected.Address(RVA = "0xE1E4E0", Offset = "0xE1CEE0", VA = "0x180E1E4E0")]
			get
			{
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					Meta.Online.Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
					if (metaClient != null)
					{
						OnlineClient _003COnlineClient_003Ek__BackingField = metaClient.OnlineClient;
						if (_003COnlineClient_003Ek__BackingField != null)
						{
							return _003COnlineClient_003Ek__BackingField.profileConflictResolver;
						}
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000722")]
		public CancellationToken CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x6003299")]
			[Cpp2IlInjected.Address(RVA = "0xE1E410", Offset = "0xE1CE10", VA = "0x180E1E410")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _cancellationTokenSource.Token;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600329A")]
		[Cpp2IlInjected.Address(RVA = "0xE1D170", Offset = "0xE1BB70", VA = "0x180E1D170")]
		public void Awake()
		{
			//Discarded unreachable code: IL_004b
			//IL_0030: Expected O, but got I4
			CancellationTokenSource cancellationTokenSource = (_cancellationTokenSource = new CancellationTokenSource());
			int num = 0;
			if (!DebugSettings.Settings.showStartMenu_)
			{
				Mdl.Online.Client client = SystemRoot.Instance.Client;
				int num2 = 0;
				if (client != (UnityEngine.Object)num2)
				{
					Mdl.Online.Client.MetaClientCreated value = StartHandlingProfileConflictOnMetaClientCreated;
					Mdl.Online.Client client2 = default(Mdl.Online.Client);
					client2.OnMetaClientCreated += value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600329B")]
		[Cpp2IlInjected.Address(RVA = "0xE1D470", Offset = "0xE1BE70", VA = "0x180E1D470")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_00b5
			//IL_0025: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			CancellationTokenSource cancellationTokenSource = _cancellationTokenSource;
			int num = 0;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				_cancellationTokenSource.Dispose();
				_cancellationTokenSource = (CancellationTokenSource)num;
			}
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			Mdl.Online.Client client = default(Mdl.Online.Client);
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				client = _003CInstance_003Ek__BackingField.Client;
			}
			int num2 = 0;
			if (client != (UnityEngine.Object)num2)
			{
				Mdl.Online.Client client2 = SystemRoot.Instance.Client;
				Mdl.Online.Client.MetaClientCreated value = StartHandlingProfileConflictOnMetaClientCreated;
				client2.OnMetaClientCreated -= value;
			}
			int num3 = 0;
			if (MetaProfileConflictResolver != null)
			{
				int num4 = 0;
				ProfileConflictResolver metaProfileConflictResolver = MetaProfileConflictResolver;
				ProfileConflictResolver.ConflictResolved value2 = OnProfileConflictResolved;
				metaProfileConflictResolver.OnConflictResolved -= value2;
				int num5 = 0;
				ProfileConflictResolver metaProfileConflictResolver2 = MetaProfileConflictResolver;
				ProfileConflictResolver.ConflictDetected value3 = HandleProfileConflict;
				metaProfileConflictResolver2.OnConflictDetected -= value3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600329C")]
		[Cpp2IlInjected.Address(RVA = "0xE1DEB0", Offset = "0xE1C8B0", VA = "0x180E1DEB0")]
		private void StartHandlingProfileConflictOnMetaClientCreated()
		{
			//Discarded unreachable code: IL_0026
			Mdl.Online.Client client = SystemRoot.Instance.Client;
			Mdl.Online.Client.MetaClientCreated value = StartHandlingProfileConflictOnMetaClientCreated;
			client.OnMetaClientCreated -= value;
			StartHandlingProfileConflict();
		}

		[Cpp2IlInjected.Token(Token = "0x600329D")]
		[Cpp2IlInjected.Address(RVA = "0xE1DFE0", Offset = "0xE1C9E0", VA = "0x180E1DFE0")]
		public void StartHandlingProfileConflict()
		{
			//Discarded unreachable code: IL_0084
			int num = 0;
			if (MetaProfileConflictResolver == null)
			{
				Debug.LogError("Calling ProfileConflictUIHandler.StartHandlingProfileConflict before OnlineClient is started is not supported.");
				return;
			}
			int num2 = 0;
			ProfileConflictResolver metaProfileConflictResolver = MetaProfileConflictResolver;
			ProfileConflictResolver.ConflictResolved value = OnProfileConflictResolved;
			metaProfileConflictResolver.OnConflictResolved += value;
			int num3 = 0;
			if (!MetaProfileConflictResolver.IsCheckingConflicts)
			{
				int num4 = 0;
				ProfileConflictResolver metaProfileConflictResolver2 = MetaProfileConflictResolver;
				int num5 = 0;
				AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
				int num6 = 0;
			}
			int num7 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			int num8 = 0;
			ProfileConflictResolver metaProfileConflictResolver3 = MetaProfileConflictResolver;
			ProfileConflictResolver.ConflictDetected value2 = HandleProfileConflict;
			metaProfileConflictResolver3.OnConflictDetected += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x600329E")]
		[Cpp2IlInjected.Address(RVA = "0xE1E330", Offset = "0xE1CD30", VA = "0x180E1E330")]
		[AsyncStateMachine(typeof(_003CWaitForProfileConflictStep_003Ed__11))]
		private Task WaitForProfileConflictStep()
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600329F")]
		[Cpp2IlInjected.Address(RVA = "0xE1D750", Offset = "0xE1C150", VA = "0x180E1D750")]
		private void OnProfileConflictResolved(ProfileConflictResolutionResult result)
		{
			//Discarded unreachable code: IL_0023
			if (!result.pickedByUser && result.resolutionType == ProfileConflictResolutionResult.ConflictResolutionType.UsingRemote)
			{
				MiniProfile usedMiniProfile = result.usedMiniProfile;
				int num = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032A0")]
		[Cpp2IlInjected.Address(RVA = "0xE1D380", Offset = "0xE1BD80", VA = "0x180E1D380")]
		[AsyncStateMachine(typeof(_003CHandleProfileConflict_003Ed__13))]
		private void HandleProfileConflict(ProfileConflictResolver conflictResolver)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		[Cpp2IlInjected.Token(Token = "0x60032A1")]
		[Cpp2IlInjected.Address(RVA = "0xE1D8C0", Offset = "0xE1C2C0", VA = "0x180E1D8C0")]
		[AsyncStateMachine(typeof(_003CShowConflictPromptAutoPickServerProfile_003Ed__14))]
		private Task<bool> ShowConflictPromptAutoPickServerProfile(ProfileConflictResolver pcr, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60032A2")]
		[Cpp2IlInjected.Address(RVA = "0xE1DA20", Offset = "0xE1C420", VA = "0x180E1DA20")]
		[AsyncStateMachine(typeof(_003CShowConflictPrompt_003Ed__15))]
		private Task<bool> ShowConflictPrompt(ProfileConflictResolver pcr, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60032A3")]
		[Cpp2IlInjected.Address(RVA = "0xE1DB60", Offset = "0xE1C560", VA = "0x180E1DB60")]
		[AsyncStateMachine(typeof(_003CShowCustomerCareProfileDisclaimerPrompt_003Ed__16))]
		private Task ShowCustomerCareProfileDisclaimerPrompt(ProfileConflictResolver pcr, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60032A4")]
		[Cpp2IlInjected.Address(RVA = "0xE1DC60", Offset = "0xE1C660", VA = "0x180E1DC60")]
		[AsyncStateMachine(typeof(_003CShowCustomerCareProfilePrompt_003Ed__17))]
		private Task<bool> ShowCustomerCareProfilePrompt(ProfileConflictResolver pcr, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60032A5")]
		[Cpp2IlInjected.Address(RVA = "0xE1DDA0", Offset = "0xE1C7A0", VA = "0x180E1DDA0")]
		[AsyncStateMachine(typeof(_003CShowProfileRecoveredPrompt_003Ed__18))]
		private Task ShowProfileRecoveredPrompt(MiniProfile recoveredMiniProfile, bool local)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60032A6")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ProfileConflictUIHandler()
		{
		}
	}
}
