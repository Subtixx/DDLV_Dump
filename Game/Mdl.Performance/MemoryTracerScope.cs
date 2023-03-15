using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Performance
{
	[Cpp2IlInjected.Token(Token = "0x2000492")]
	public struct MemoryTracerScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4001CDD")]
		private string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4001CDE")]
		private long _memoryAtStart;

		[Cpp2IlInjected.Token(Token = "0x6001453")]
		[Cpp2IlInjected.Address(RVA = "0xBC5C50", Offset = "0xBC4650", VA = "0x180BC5C50")]
		public MemoryTracerScope(string name)
		{
			//IL_0010: Expected I8, but got I4
			_name = name;
			int num = 0;
			_memoryAtStart = num;
			string message = default(string);
			Debug.Log(message);
		}

		[Cpp2IlInjected.Token(Token = "0x6001454")]
		[Cpp2IlInjected.Address(RVA = "0xBC5B70", Offset = "0xBC4570", VA = "0x180BC5B70", Slot = "4")]
		public void Dispose()
		{
			long memoryAtStart = _memoryAtStart;
			string message = default(string);
			Debug.Log(message);
		}

		[Cpp2IlInjected.Token(Token = "0x6001455")]
		[Cpp2IlInjected.Address(RVA = "0xBC5B50", Offset = "0xBC4550", VA = "0x180BC5B50")]
		public static MemoryTracerScope Create(string name)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001456")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0")]
		public static long GetAllocatableNativeMemory()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
