using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	public class TargetedUsersProperties
	{
		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		public List<string> TesterPlayFabIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CTesterPlayFabIds_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CTesterPlayFabIds_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		public List<string> RealUserPlayFabIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CRealUserPlayFabIds_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CRealUserPlayFabIds_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TargetedUsersProperties()
		{
		}
	}
}
