using System;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class ILoggerExtension
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x38DDAE0", Offset = "0x38DC4E0", VA = "0x1838DDAE0")]
		public static void Debug(this ILogger logger, string message)
		{
			//Discarded unreachable code: IL_0003
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x38DDC30", Offset = "0x38DC630", VA = "0x1838DDC30")]
		public static void Info(this ILogger logger, string message)
		{
			//Discarded unreachable code: IL_0003
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x38DDD10", Offset = "0x38DC710", VA = "0x1838DDD10")]
		public static void Warning(this ILogger logger, string message)
		{
			//Discarded unreachable code: IL_0003
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x38DDCA0", Offset = "0x38DC6A0", VA = "0x1838DDCA0")]
		public static void Warning(this ILogger logger, Exception e)
		{
			//Discarded unreachable code: IL_0003
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x38DDBC0", Offset = "0x38DC5C0", VA = "0x1838DDBC0")]
		public static void Error(this ILogger logger, string message)
		{
			//Discarded unreachable code: IL_0003
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x38DDB50", Offset = "0x38DC550", VA = "0x1838DDB50")]
		public static void Error(this ILogger logger, Exception e)
		{
			//Discarded unreachable code: IL_0003
			int num = 0;
		}
	}
}
