using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000238")]
	public class WeightInfo
	{
		[Cpp2IlInjected.Token(Token = "0x170004BF")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000900")]
		public int DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6001569")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600156A")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004C0")]
		public Dictionary<int, int> WeightedItems
		{
			[Cpp2IlInjected.Token(Token = "0x600156B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CWeightedItems_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600156C")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CWeightedItems_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600156D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public WeightInfo()
		{
		}
	}
}
