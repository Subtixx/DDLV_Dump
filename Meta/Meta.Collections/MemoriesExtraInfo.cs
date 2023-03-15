using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Collections
{
	[Cpp2IlInjected.Token(Token = "0x200110A")]
	public class MemoriesExtraInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17001859")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400463E")]
		public RewardAppearanceCondition RareFind
		{
			[Cpp2IlInjected.Token(Token = "0x6008AE7")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6008AE8")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700185A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x400463F")]
		public int ShardProgress
		{
			[Cpp2IlInjected.Token(Token = "0x6008AE9")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6008AEA")]
			[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6008AEB")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public MemoriesExtraInfo()
		{
		}
	}
}
