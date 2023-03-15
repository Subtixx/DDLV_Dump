using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public struct QueuedDebugLogEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public readonly string logString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public readonly string stackTrace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public readonly LogType logType;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xF32D50", Offset = "0xF31750", VA = "0x180F32D50")]
		public QueuedDebugLogEntry(string logString, string stackTrace, LogType logType)
		{
			this.logString = logString;
			this.stackTrace = stackTrace;
			this.logType = logType;
		}
	}
}
