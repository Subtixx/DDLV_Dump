using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2001109")]
	public class CritterExtraInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17001856")]
		public List<CritterItemData.Types.DailyScheduleData> CritterSchedule
		{
			[Cpp2IlInjected.Token(Token = "0x6008AE0")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CCritterSchedule_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6008AE1")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CCritterSchedule_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001857")]
		public ItemSelector FavoriteGift
		{
			[Cpp2IlInjected.Token(Token = "0x6008AE2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CFavoriteGift_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6008AE3")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CFavoriteGift_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001858")]
		public string FavoriteGiftDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6008AE4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CFavoriteGiftDescription_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6008AE5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CFavoriteGiftDescription_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008AE6")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CritterExtraInfo()
		{
		}
	}
}
