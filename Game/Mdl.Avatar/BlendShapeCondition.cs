using System;
using Cpp2IlInjected;

namespace Mdl.Avatar
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000A59")]
	public class BlendShapeCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400393A")]
		public int withThisOptionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400393B")]
		public int withThisOption;

		[Cpp2IlInjected.Token(Token = "0x6003029")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public BlendShapeCondition()
		{
		}
	}
}
