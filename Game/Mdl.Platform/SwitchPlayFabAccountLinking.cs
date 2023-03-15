using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Systems;
using Mdl.Utils;
using Meta.Online;
using StoreFrontEnums;
using UnityEngine;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002E5")]
	public class SwitchPlayFabAccountLinking : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40015C7")]
		private CancellationTokenSource _cts = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		private static bool IsUsingNintendoAccountLinking
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC5")]
			[Cpp2IlInjected.Address(RVA = "0x106AA10", Offset = "0x1069410", VA = "0x18106AA10")]
			get
			{
				int num = 0;
				return PlatformUtils.GetRuntimePlayfabNativeAuth() == PlayfabNativeAuth.PnaSwitch;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void Awake()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void Start()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC8")]
		[Cpp2IlInjected.Address(RVA = "0x106A940", Offset = "0x1069340", VA = "0x18106A940")]
		public void OnDestroy()
		{
			if ((long)_cts == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC9")]
		[Cpp2IlInjected.Address(RVA = "0x106A6D0", Offset = "0x10690D0", VA = "0x18106A6D0")]
		[AsyncStateMachine(typeof(_003CAssignNintentoIds_003Ed__6))]
		public Task AssignNintentoIds(Action<string, Client.FailureFallback> userCredentialInitCompleted)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public static void AssignNSAToPlayfabLogin()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public static void DebugUpdateNsaTokenAvailable()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x106A7C0", Offset = "0x10691C0", VA = "0x18106A7C0")]
		private static void NotifyNSATokenIsAvailable()
		{
			//Discarded unreachable code: IL_002b, IL_002c
			Debug.Log("NotifyNSATokenIsAvailable NSA token is available, clearing offline mode");
			SystemRoot.Instance.Client.ClearForceOfflineReason(ForceOfflineReasonFlag.NintendoSwitchNoNSA);
			if (1L == 0L)
			{
			}
			BackTraceInitializer.Instance.InitializeBacktrace();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x106A9A0", Offset = "0x10693A0", VA = "0x18106A9A0")]
		public SwitchPlayFabAccountLinking()
		{
		}
	}
}
