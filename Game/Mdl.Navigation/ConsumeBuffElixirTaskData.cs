using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Meta;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BA6")]
	public class ConsumeBuffElixirTaskData : IPlayerTaskData
	{
		[Cpp2IlInjected.Token(Token = "0x1700073C")]
		public ConsumeItem.Types.Request Request
		{
			[Cpp2IlInjected.Token(Token = "0x60035C3")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CRequest_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60035C4")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CRequest_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035C5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ConsumeBuffElixirTaskData()
		{
		}
	}
}
