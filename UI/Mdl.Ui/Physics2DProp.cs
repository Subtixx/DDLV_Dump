using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20008B1")]
	internal class Physics2DProp
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400341B")]
		public float start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400341C")]
		public float velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400341D")]
		public float v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400341E")]
		public float a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400341F")]
		public float value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003420")]
		public float acceleration;

		[Cpp2IlInjected.Token(Token = "0x60036FD")]
		[Cpp2IlInjected.Address(RVA = "0xE0F750", Offset = "0xE0E150", VA = "0x180E0F750")]
		public Physics2DProp(float start, float velocity, float acceleration, int stepsPerTimeUnit)
		{
			//IL_0026: Invalid comparison between F4 and I4
			//IL_003a: Expected F4, but got I4
			this.velocity = velocity;
			value = start;
			this.start = start;
			int num = 0;
			v = velocity;
			if (!(acceleration > (float)num))
			{
				this.acceleration = 0f;
				a = num;
			}
			this.acceleration = acceleration;
			a = acceleration;
		}
	}
}
