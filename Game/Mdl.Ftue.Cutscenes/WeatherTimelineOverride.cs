using System;
using Cpp2IlInjected;
using Mdl.Graphic.Weather;

namespace Mdl.Ftue.Cutscenes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20005F4")]
	public class WeatherTimelineOverride
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002424")]
		public string overrideId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002425")]
		public WeatherTimeline timelineOverride;

		[Cpp2IlInjected.Token(Token = "0x6001A68")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public WeatherTimelineOverride()
		{
		}
	}
}
