using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	public class BattlePassTaskConfigV2
	{
		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public List<BattlePassTask> Tasks
		{
			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CTasks_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CTasks_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public BattlePassTaskConfigV2()
		{
		}
	}
}
