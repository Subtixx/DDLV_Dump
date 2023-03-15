using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Wind
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct WindStatus<T> where T : UnityEngine.Object
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public delegate void FixAction(T data);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public StatusType type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public FixAction action;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x225EF70", Offset = "0x225D970", VA = "0x18225EF70")]
		public WindStatus(StatusType type, string message, FixAction action)
		{
			//IL_000e: Expected I4, but got O
			//IL_0015: Expected I4, but got O
			System.Runtime.CompilerServices.Unsafe.As<WindStatus<T>, WindStatus<>>(ref this).type = type;
			System.Runtime.CompilerServices.Unsafe.As<WindStatus<T>, WindStatus<>>(ref this).type = (StatusType)message;
			System.Runtime.CompilerServices.Unsafe.As<WindStatus<T>, WindStatus<>>(ref this).type = (StatusType)action;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2951820", Offset = "0x2950220", VA = "0x182951820")]
		public void Set(IWindStatus<T> data, bool logs = false)
		{
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				if (num == (int)num2)
				{
					throw new NullReferenceException();
				}
				num++;
			}
			if (!logs)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void LogMessage(StatusType type, string message, UnityEngine.Object obj)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
