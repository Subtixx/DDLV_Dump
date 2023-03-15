using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace SoftMasking
{
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	internal struct ClearListAtExit<T> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private List<T> _list;

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x6DDCC0", Offset = "0x6DC6C0", VA = "0x1806DDCC0")]
		public ClearListAtExit(List<T> list)
		{
			System.Runtime.CompilerServices.Unsafe.As<ClearListAtExit<T>, ClearListAtExit<>>(ref this)._list = list;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x3331A60", Offset = "0x3330460", VA = "0x183331A60", Slot = "4")]
		public void Dispose()
		{
		}//Discarded unreachable code: IL_0001

	}
}
