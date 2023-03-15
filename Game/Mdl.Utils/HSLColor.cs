using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000752")]
	public static class HSLColor
	{
		[Cpp2IlInjected.Token(Token = "0x6002090")]
		[Cpp2IlInjected.Address(RVA = "0x154A8C0", Offset = "0x15492C0", VA = "0x18154A8C0")]
		public static Color32 GetColorFromHSL(double h, double s, double l)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002091")]
		[Cpp2IlInjected.Address(RVA = "0x154AF60", Offset = "0x1549960", VA = "0x18154AF60")]
		private static double QqhToRgb(double q1, double q2, double hue)
		{
			//Discarded unreachable code: IL_0002, IL_0004
			return q1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002092")]
		[Cpp2IlInjected.Address(RVA = "0x154AB20", Offset = "0x1549520", VA = "0x18154AB20")]
		public static Vector3 GetHSLFromColor(Color32 color)
		{
			int num = 0;
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002093")]
		[Cpp2IlInjected.Address(RVA = "0x154ADA0", Offset = "0x15497A0", VA = "0x18154ADA0")]
		public static Color32 GetHueFromAngle(int angle)
		{
			//IL_0022: Expected F4, but got I4
			//IL_0040: Expected F4, but got I4
			//IL_0065: Expected F4, but got I4
			//IL_0084: Expected F4, but got I4
			//IL_0098: Expected F4, but got I4
			int min = 0;
			uint max = default(uint);
			int num = Mathf.Clamp(angle, min, (int)max);
			num += -300;
			int num2 = 0;
			float t = default(float);
			int num3 = Mathf.RoundToInt(Mathf.Lerp(255f, num2, t));
			num3 += -240;
			float t2 = default(float);
			int num4 = Mathf.RoundToInt(Mathf.Lerp(0f, 255f, t2));
			num4 += -180;
			num4 += -120;
			float t3 = default(float);
			int num5 = Mathf.RoundToInt(Mathf.Lerp(0f, 255f, t3));
			num5 += -60;
			int num6 = 0;
			float t4 = default(float);
			num4 = Mathf.RoundToInt(Mathf.Lerp(255f, num6, t4));
			float t5 = default(float);
			int num7 = Mathf.RoundToInt(Mathf.Lerp(0f, 255f, t5));
			/*Error: Unexpected end of block*/;
		}
	}
}
