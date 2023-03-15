using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200044F")]
	public class EventContentHomeModel : EventContentModelBase
	{
		[Cpp2IlInjected.Token(Token = "0x1700048F")]
		public EventProgressModel Progress
		{
			[Cpp2IlInjected.Token(Token = "0x6001BEC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CProgress_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BED")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CProgress_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000490")]
		public List<EventChapterModel> Chapters
		{
			[Cpp2IlInjected.Token(Token = "0x6001BEE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CChapters_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BEF")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CChapters_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BF0")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public EventContentHomeModel()
		{
		}
	}
}
