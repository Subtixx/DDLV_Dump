using System;
using Cpp2IlInjected;
using Serilog.Core;
using Serilog.Events;

namespace Mdl.Native.iOS
{
	[Cpp2IlInjected.Token(Token = "0x20003A5")]
	public class NSLogSink : ILogEventSink
	{
		[Cpp2IlInjected.Token(Token = "0x6000F92")]
		[Cpp2IlInjected.Address(RVA = "0xF00AD0", Offset = "0xEFF4D0", VA = "0x180F00AD0", Slot = "4")]
		public void Emit(LogEvent logEvent)
		{
			//Discarded unreachable code: IL_00a1
			//IL_0009: Expected O, but got I4
			int num = 0;
			string text = logEvent.RenderMessage((IFormatProvider)num);
			char[] array = new char[1];
			uint num2 = default(uint);
			array[0] = (char)num2;
			string[] array2 = text.Split(array);
			int num3 = 0;
			int num4 = 0;
			int length = array2.Length;
			if (num3 >= length)
			{
				return;
			}
			int num5 = 0;
			string text2 = array2[num4];
			int stringLength = text2.m_stringLength;
			if (num5 < stringLength)
			{
				stringLength -= num5;
				uint val = default(uint);
				int num6 = Math.Min((int)val, stringLength);
				string text3 = "/ ";
				if (num5 == 0)
				{
					text3 = "";
				}
				string text4 = text2.Substring(num5, num6);
				string text5 = text3 + text4;
				num5 += num6;
			}
			num4++;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F93")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public NSLogSink()
		{
		}
	}
}
