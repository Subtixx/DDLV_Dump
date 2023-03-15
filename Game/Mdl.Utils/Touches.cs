using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007CC")]
	public static class Touches
	{
		[Cpp2IlInjected.Token(Token = "0x60022A1")]
		[Cpp2IlInjected.Address(RVA = "0x13DC520", Offset = "0x13DAF20", VA = "0x1813DC520")]
		public static int ActiveTouchCount()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int touchCount = Input.touchCount;
			if (num3 < touchCount)
			{
				Touch touch = default(Touch);
				float y = touch.m_RawPosition.y;
				int tapCount = touch.m_TapCount;
				float maximumPossiblePressure = touch.m_maximumPossiblePressure;
				float azimuthAngle = touch.m_AzimuthAngle;
				if (azimuthAngle != 4E-45f && azimuthAngle != 6E-45f)
				{
					num3++;
				}
				num3++;
			}
			return num3;
		}
	}
}
