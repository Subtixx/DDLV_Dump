using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Meta.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2001107")]
	public class FishExtraInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17001851")]
		public string FishSchedule
		{
			[Cpp2IlInjected.Token(Token = "0x6008AD4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CFishSchedule_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6008AD5")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CFishSchedule_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001852")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4004637")]
		public float BestCatch
		{
			[Cpp2IlInjected.Token(Token = "0x6008AD6")]
			[Cpp2IlInjected.Address(RVA = "0x837330", Offset = "0x835D30", VA = "0x180837330")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6008AD7")]
			[Cpp2IlInjected.Address(RVA = "0x837350", Offset = "0x835D50", VA = "0x180837350")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6008AD8")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public FishExtraInfo()
		{
		}
	}
}
