using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace UnityEngine
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public struct BgColorScopeGUI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public Color PrevValue
		{
			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xA45890", Offset = "0xA44290", VA = "0x180A45890")]
			[CompilerGenerated]
			readonly get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0xA8B990", Offset = "0xA8A390", VA = "0x180A8B990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x163F520", Offset = "0x163DF20", VA = "0x18163F520")]
		public static IDisposable Scope(Color color)
		{
			Color backgroundColor = GUI.backgroundColor;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x163F5D0", Offset = "0x163DFD0", VA = "0x18163F5D0")]
		public BgColorScopeGUI(Color color)
		{
			Color backgroundColor = GUI.backgroundColor;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x163F4B0", Offset = "0x163DEB0", VA = "0x18163F4B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
