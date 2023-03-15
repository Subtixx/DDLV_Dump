using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Navigation;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000224")]
	public class MapMenuParams
	{
		[Cpp2IlInjected.Token(Token = "0x17000139")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40012E8")]
		public bool ShowCrops
		{
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60008F3")]
			[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x11"), Cpp2IlInjected.Token(Token = "0x40012E9")]
		public bool ShowCharacters
		{
			[Cpp2IlInjected.Token(Token = "0x60008F4")]
			[Cpp2IlInjected.Address(RVA = "0x5706D0", Offset = "0x56F0D0", VA = "0x1805706D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60008F5")]
			[Cpp2IlInjected.Address(RVA = "0x570700", Offset = "0x56F100", VA = "0x180570700")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x12"), Cpp2IlInjected.Token(Token = "0x40012EA")]
		public bool ShowFastTravelDestinations
		{
			[Cpp2IlInjected.Token(Token = "0x60008F6")]
			[Cpp2IlInjected.Address(RVA = "0x5706F0", Offset = "0x56F0F0", VA = "0x1805706F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60008F7")]
			[Cpp2IlInjected.Address(RVA = "0x570720", Offset = "0x56F120", VA = "0x180570720")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		public FastTravelDestination FastTravelOrigin
		{
			[Cpp2IlInjected.Token(Token = "0x60008F8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CFastTravelOrigin_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60008F9")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CFastTravelOrigin_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public MapMenuParams()
		{
		}
	}
}
