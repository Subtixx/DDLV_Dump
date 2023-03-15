using System;
using Cpp2IlInjected;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x2000526")]
	public class SliderAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002038")]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4002039")]
		public float max;

		[Cpp2IlInjected.Token(Token = "0x60016AB")]
		[Cpp2IlInjected.Address(RVA = "0xF55980", Offset = "0xF54380", VA = "0x180F55980")]
		public SliderAttribute(float min, float max)
		{
			this.min = min;
			this.max = max;
		}
	}
}
