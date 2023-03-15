using System;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000B08")]
	public class AudioSurfaceEnumSwitchMap
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003D69")]
		public AudioSurfaceType audioSurfaceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003D6A")]
		public Switch audioFloorSwitch;

		[Cpp2IlInjected.Token(Token = "0x60032EE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public AudioSurfaceEnumSwitchMap()
		{
		}
	}
}
