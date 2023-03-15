using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class GameSessionInfo
	{
		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public string DeviceName
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CDeviceName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CDeviceName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public GameSessionInfo()
		{
		}
	}
}
