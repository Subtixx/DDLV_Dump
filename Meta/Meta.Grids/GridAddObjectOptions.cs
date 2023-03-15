using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Grids
{
	[Cpp2IlInjected.Token(Token = "0x200108B")]
	public class GridAddObjectOptions
	{
		[Cpp2IlInjected.Token(Token = "0x17001762")]
		public LocationSource RewardSpawnAnimationLocation
		{
			[Cpp2IlInjected.Token(Token = "0x6008678")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CRewardSpawnAnimationLocation_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6008679")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CRewardSpawnAnimationLocation_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001763")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400444E")]
		public bool IgnoreRewardSpawnAnimation
		{
			[Cpp2IlInjected.Token(Token = "0x600867A")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600867B")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600867C")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public GridAddObjectOptions()
		{
		}
	}
}
