using System;
using Cpp2IlInjected;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x20004FF")]
	[Flags]
	public enum PostProcess
	{
		[Cpp2IlInjected.Token(Token = "0x4001F7A")]
		Bloom = 1,
		[Cpp2IlInjected.Token(Token = "0x4001F7B")]
		ColorAdjustements = 2,
		[Cpp2IlInjected.Token(Token = "0x4001F7C")]
		ColorCurves = 4,
		[Cpp2IlInjected.Token(Token = "0x4001F7D")]
		DepthOfField = 8,
		[Cpp2IlInjected.Token(Token = "0x4001F7E")]
		DepthOfFieldBokeh = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4001F7F")]
		Fog = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4001F80")]
		LiftGammaGain = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4001F81")]
		SplitToning = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4001F82")]
		Tonemapping = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4001F83")]
		Vignette = 0x200
	}
}
