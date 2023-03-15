using Cpp2IlInjected;
using UnityEngine;

namespace SoftMasking
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	public static class MaskChannel
	{
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static Color alpha;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static Color red;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static Color green;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static Color blue;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static Color gray;

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x118AC40", Offset = "0x1189640", VA = "0x18118AC40")]
		static MaskChannel()
		{
			//IL_000e: Expected O, but got I4
			//IL_0017: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			alpha = (Color)num;
			int num5 = 0;
			red = (Color)num4;
			int num6 = 0;
			green = (Color)num5;
			int num7 = 0;
			blue = (Color)num6;
			gray = (Color)num7;
		}
	}
}
