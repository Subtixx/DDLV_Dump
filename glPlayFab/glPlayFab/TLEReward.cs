using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	public class TLEReward
	{
		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		public string OnlineId
		{
			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003COnlineId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003COnlineId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000502")]
		public TLERewardType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x4000503")]
		public int Quantity
		{
			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TLEReward()
		{
		}
	}
}
