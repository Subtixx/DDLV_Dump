using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x20004F5")]
	public class WeatherInfluences : Dictionary<WeatherTimeline, float>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001F33")]
		public float totalWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4001F34")]
		public float mainTimelineWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001F35")]
		public WeatherTimeline mainTimeline;

		[Cpp2IlInjected.Token(Token = "0x60015EB")]
		[Cpp2IlInjected.Address(RVA = "0x837290", Offset = "0x835C90", VA = "0x180837290")]
		public new void Clear()
		{
			//IL_000f: Expected F4, but got I4
			//IL_0016: Expected O, but got I4
			((Dictionary<TKey, TValue>)(object)this).Clear();
			int num = 0;
			totalWeight = num;
			mainTimeline = (WeatherTimeline)num;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60015EC")]
		[Cpp2IlInjected.Address(RVA = "0x837170", Offset = "0x835B70", VA = "0x180837170")]
		public new void Add(WeatherTimeline timeline, float weight)
		{
			//Discarded unreachable code: IL_0006, IL_000a, IL_0010, IL_0017, IL_0023, IL_0038, IL_0041, IL_004f
			//IL_001f: Expected F4, but got O
			//IL_002b: Expected F4, but got O
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60015ED")]
		[Cpp2IlInjected.Address(RVA = "0x8372E0", Offset = "0x835CE0", VA = "0x1808372E0")]
		public WeatherInfluences()
		{
			((Dictionary<TKey, TValue>)(object)this)._002Ector();
		}
	}
}
