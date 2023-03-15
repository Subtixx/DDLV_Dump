using System;
using System.Diagnostics;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils.Log
{
	[Cpp2IlInjected.Token(Token = "0x20007D5")]
	public static class ScopedDebug
	{
		[Cpp2IlInjected.Token(Token = "0x20007D6")]
		public abstract class Helper : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002C0B")]
			private string message;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002C0C")]
			private float startTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4002C0D")]
			private bool isLogging;

			[Cpp2IlInjected.Token(Token = "0x60022CB")]
			[Cpp2IlInjected.Address(RVA = "0x1440710", Offset = "0x143F110", VA = "0x181440710")]
			protected Helper(bool isLogging, string message)
			{
				this.message = message;
				this.isLogging = isLogging;
				int num = 0;
				float num2 = (startTime = Time.time);
			}

			[Cpp2IlInjected.Token(Token = "0x60022CC")]
			[Cpp2IlInjected.Address(RVA = "0x14406F0", Offset = "0x143F0F0", VA = "0x1814406F0")]
			[Conditional("DEBUG")]
			private void ExecLog(string message)
			{
				if (isLogging)
				{
					ExecLogInternal(message);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60022CD")]
			[Cpp2IlInjected.Address(Slot = "5")]
			protected abstract void ExecLogInternal(string message);

			[Cpp2IlInjected.Token(Token = "0x60022CE")]
			[Cpp2IlInjected.Address(RVA = "0x14406E0", Offset = "0x143F0E0", VA = "0x1814406E0", Slot = "4")]
			public void Dispose()
			{
				int num = 0;
				float time = Time.time;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20007D7")]
		protected class LogHelper : Helper
		{
			[Cpp2IlInjected.Token(Token = "0x60022CF")]
			[Cpp2IlInjected.Address(RVA = "0x1440710", Offset = "0x143F110", VA = "0x181440710")]
			public LogHelper(bool isLogging, string message)
			{
				base.message = message;
				base.isLogging = isLogging;
				int num = 0;
				float num2 = (base.startTime = Time.time);
			}

			[Cpp2IlInjected.Token(Token = "0x60022D0")]
			[Cpp2IlInjected.Address(RVA = "0x1440760", Offset = "0x143F160", VA = "0x181440760", Slot = "5")]
			protected override void ExecLogInternal(string message)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022CA")]
		[Cpp2IlInjected.Address(RVA = "0xCCACE0", Offset = "0xCC96E0", VA = "0x180CCACE0")]
		public static Helper LogIf(bool condition, string message)
		{
			LogHelper logHelper = new LogHelper(condition, message);
			/*Error: Unexpected end of block*/;
		}
	}
}
