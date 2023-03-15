using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace Mdl.Log
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class Serilogger
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string ContextKey = "Context";

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static Logger BaseLogger
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x4151640", Offset = "0x4150040", VA = "0x184151640")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x41516A0", Offset = "0x41500A0", VA = "0x1841516A0")]
			[CompilerGenerated]
			private set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x4151350", Offset = "0x414FD50", VA = "0x184151350")]
		public static LoggerConfiguration CreateBaseConfig(LogEventLevel minLevel = LogEventLevel.Information)
		{
			return new LoggerConfiguration();
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4151480", Offset = "0x414FE80", VA = "0x184151480")]
		public static void SetBaseLogger(Logger logger)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x41513A0", Offset = "0x414FDA0", VA = "0x1841513A0")]
		public static ILogger Create(string context)
		{
			//Discarded unreachable code: IL_0004
			int num = 0;
			ILogger result = default(ILogger);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1B22670", Offset = "0x1B21070", VA = "0x181B22670")]
		public static ILogger Create<T>()
		{
			//Discarded unreachable code: IL_000c
			Type type = default(Type);
			string fullName = type.FullName;
			int num = 0;
			ILogger result = default(ILogger);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x41515B0", Offset = "0x414FFB0", VA = "0x1841515B0")]
		static Serilogger()
		{
			Logger logger = new LoggerConfiguration().CreateLogger();
			throw new NullReferenceException();
		}
	}
}
