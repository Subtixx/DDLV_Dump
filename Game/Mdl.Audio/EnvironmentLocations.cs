using System;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Grid;

namespace Mdl.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000AD7")]
	public class EnvironmentLocations
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003C1F")]
		public GridFloorType areaType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003C20")]
		public State locationState;

		[Cpp2IlInjected.Token(Token = "0x60031FA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public EnvironmentLocations()
		{
		}
	}
}
