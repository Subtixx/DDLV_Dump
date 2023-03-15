using System;
using System.Text;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class Logger : ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x1033710", Offset = "0x1032110", VA = "0x181033710", Slot = "6")]
		public void Error(string msg, params object[] arguments)
		{
			//Discarded unreachable code: IL_000c
			Encoding encoding = Console.stderr.Encoding;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x1033650", Offset = "0x1032050", VA = "0x181033650", Slot = "7")]
		public void Error(Exception e, string msg, params object[] arguments)
		{
			//Discarded unreachable code: IL_000c
			Encoding encoding = Console.stderr.Encoding;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x10337D0", Offset = "0x10321D0", VA = "0x1810337D0", Slot = "4")]
		public void Info(string msg, params object[] arguments)
		{
			Console.WriteLine(msg);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x1033830", Offset = "0x1032230", VA = "0x181033830", Slot = "5")]
		public void Warning(string msg, params object[] arguments)
		{
			Console.WriteLine(msg);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public Logger()
		{
		}
	}
}
