using System;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Grid;

namespace Mdl.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000B0B")]
	public class FootStepEnumEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003D6F")]
		public GridFloorType type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003D70")]
		public Switch eventType;

		[Cpp2IlInjected.Token(Token = "0x60032F1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public FootStepEnumEntry()
		{
		}
	}
}
