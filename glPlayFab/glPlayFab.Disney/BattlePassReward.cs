using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	public class BattlePassReward
	{
		[Cpp2IlInjected.Token(Token = "0x17000201")]
		public Content Content
		{
			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CContent_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CContent_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000637")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x60007EB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x4000638")]
		public bool IsPremium
		{
			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60007EE")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000204")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1D"), Cpp2IlInjected.Token(Token = "0x4000639")]
		public bool IsRecurrent
		{
			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x63C0F0", Offset = "0x63AAF0", VA = "0x18063C0F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x63C2C0", Offset = "0x63ACC0", VA = "0x18063C2C0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public BattlePassReward()
		{
		}
	}
}
