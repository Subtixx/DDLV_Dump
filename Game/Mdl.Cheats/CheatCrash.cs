using System;
using System.IO;
using System.Threading;
using Backtrace.Unity;
using Backtrace.Unity.Model;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.Diagnostics;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x200083C")]
	[CreateAssetMenu]
	public class CheatCrash : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600251B")]
		[Cpp2IlInjected.Address(RVA = "0xA7C310", Offset = "0xA7AD10", VA = "0x180A7C310")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatCrash.cs", 14)]
		public void ThrowException()
		{
			Exception ex = new Exception("Cheat crash, ignore this exception");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600251C")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF50", Offset = "0xA7A950", VA = "0x180A7BF50")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatCrash.cs", 20)]
		public void CrashAbort()
		{
			UnityEngine.Diagnostics.Utils.ForceCrash(ForcedCrashCategory.Abort);
		}

		[Cpp2IlInjected.Token(Token = "0x600251D")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF60", Offset = "0xA7A960", VA = "0x180A7BF60")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatCrash.cs", 22)]
		public void CrashAccessViolation()
		{
			UnityEngine.Diagnostics.Utils.ForceCrash(ForcedCrashCategory.AccessViolation);
		}

		[Cpp2IlInjected.Token(Token = "0x600251E")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF70", Offset = "0xA7A970", VA = "0x180A7BF70")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatCrash.cs", 24)]
		public void CrashFatalError()
		{
			UnityEngine.Diagnostics.Utils.ForceCrash(ForcedCrashCategory.FatalError);
		}

		[Cpp2IlInjected.Token(Token = "0x600251F")]
		[Cpp2IlInjected.Address(RVA = "0xA7C000", Offset = "0xA7AA00", VA = "0x180A7C000")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatCrash.cs", 26)]
		public void CrashPureVirtualFunction()
		{
			UnityEngine.Diagnostics.Utils.ForceCrash(ForcedCrashCategory.PureVirtualFunction);
		}

		[Cpp2IlInjected.Token(Token = "0x6002520")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF80", Offset = "0xA7A980", VA = "0x180A7BF80")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatCrash.cs", 29)]
		public void CrashNativeAsset()
		{
			UnityEngine.Diagnostics.Utils.NativeAssert("native assert");
		}

		[Cpp2IlInjected.Token(Token = "0x6002521")]
		[Cpp2IlInjected.Address(RVA = "0xA7BFC0", Offset = "0xA7A9C0", VA = "0x180A7BFC0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatCrash.cs", 31)]
		public void CrashNativeError()
		{
			UnityEngine.Diagnostics.Utils.NativeError("native error");
		}

		[Cpp2IlInjected.Token(Token = "0x6002522")]
		[Cpp2IlInjected.Address(RVA = "0xA7C1D0", Offset = "0xA7ABD0", VA = "0x180A7C1D0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatCrash.cs", 34)]
		public void ServerErrorFakeRPCException()
		{
			//Discarded unreachable code: IL_0021
			//IL_001b: Expected O, but got I4
			Client metaClient = SystemRoot.Instance.MetaClient;
			DebugFakeRPCException.Types.Request request = new DebugFakeRPCException.Types.Request();
			int num = 0;
			metaClient.DebugFakeRPCException(request, (CancellationToken)num).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002523")]
		[Cpp2IlInjected.Address(RVA = "0xA7C0F0", Offset = "0xA7AAF0", VA = "0x180A7C0F0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatCrash.cs", 39)]
		public void MetaLogError()
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002524")]
		[Cpp2IlInjected.Address(RVA = "0xA7C010", Offset = "0xA7AA10", VA = "0x180A7C010")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatCrash.cs", 44)]
		public void MetaLogErrorNullLog()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002525")]
		[Cpp2IlInjected.Address(RVA = "0xA7BE80", Offset = "0xA7A880", VA = "0x180A7BE80")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatCrash.cs", 50)]
		public void BacktraceEntry()
		{
			//IL_001d: Expected O, but got I4
			Exception ex = new Exception("backtrace entry");
			int num = 0;
			BacktraceClient backtraceClient = default(BacktraceClient);
			if ((object)backtraceClient != null)
			{
				int num2 = 0;
				BacktraceReport backtraceReport = default(BacktraceReport);
				backtraceClient.Send(backtraceReport, (Action<>)num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002526")]
		[Cpp2IlInjected.Address(RVA = "0xA7C360", Offset = "0xA7AD60", VA = "0x180A7C360")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatCrash.cs", 63)]
		public void WriteAllTextCrashOnSwitch()
		{
			string contents = "test write out in file " + "MDLSave:/test_mdlsave.txt";
			File.WriteAllText("MDLSave:/test_mdlsave.txt", contents);
		}

		[Cpp2IlInjected.Token(Token = "0x6002527")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public CheatCrash()
		{
		}
	}
}
