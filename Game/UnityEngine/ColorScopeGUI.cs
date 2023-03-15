using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace UnityEngine
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public struct ColorScopeGUI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public Color PrevValue
		{
			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0xA45890", Offset = "0xA44290", VA = "0x180A45890")]
			[CompilerGenerated]
			readonly get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0xA8B990", Offset = "0xA8A390", VA = "0x180A8B990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xA8B860", Offset = "0xA8A260", VA = "0x180A8B860")]
		public static IDisposable Scope(Color color)
		{
			Color color2 = GUI.color;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xA8B910", Offset = "0xA8A310", VA = "0x180A8B910")]
		public ColorScopeGUI(Color color)
		{
			Color color2 = GUI.color;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7F0", Offset = "0xA8A1F0", VA = "0x180A8B7F0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
