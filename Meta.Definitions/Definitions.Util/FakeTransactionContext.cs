using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	public class FakeTransactionContext : ITransactionContext
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private readonly DateTime? nowOverride;

		[Cpp2IlInjected.Token(Token = "0x17000348")]
		public DateTime Now
		{
			[Cpp2IlInjected.Token(Token = "0x6000D99")]
			[Cpp2IlInjected.Address(RVA = "0x2CA31D0", Offset = "0x2CA1BD0", VA = "0x182CA31D0", Slot = "4")]
			get
			{
				DateTime? dateTime = nowOverride;
				if ((object)typeof(DateTime).TypeHandle != null)
				{
				}
				int num = 0;
				return DateTime.UtcNow;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000349")]
		public DateTime LocalNow
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9A")]
			[Cpp2IlInjected.Address(RVA = "0x2CA31D0", Offset = "0x2CA1BD0", VA = "0x182CA31D0", Slot = "5")]
			get
			{
				DateTime? dateTime = nowOverride;
				if ((object)typeof(DateTime).TypeHandle != null)
				{
				}
				int num = 0;
				return DateTime.UtcNow;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034A")]
		public bool IsServer
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9B")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "6")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA31A0", Offset = "0x2CA1BA0", VA = "0x182CA31A0")]
		public FakeTransactionContext([Optional] DateTime? nowOverride)
		{
		}
	}
}
