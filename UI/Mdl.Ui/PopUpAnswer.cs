using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000217")]
	public class PopUpAnswer
	{
		[Cpp2IlInjected.Token(Token = "0x17000284")]
		public object Params
		{
			[Cpp2IlInjected.Token(Token = "0x6000D2A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CParams_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D2B")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CParams_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000285")]
		public AlertButton SelectedOption
		{
			[Cpp2IlInjected.Token(Token = "0x6000D2C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CSelectedOption_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D2D")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CSelectedOption_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PopUpAnswer()
		{
		}
	}
}
