using System;
using Cpp2IlInjected;
using Definitions.Grid;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F01")]
	public class UnityContextExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6007BCE")]
		[Cpp2IlInjected.Address(RVA = "0x15D77E0", Offset = "0x15D61E0", VA = "0x1815D77E0")]
		public static string GetAvatarPosition(uint gridID, GridPosition gridPos, GridPosition direction)
		{
			//Discarded unreachable code: IL_0063
			object[] array;
			while (true)
			{
				array = new object[5];
				if (array != null && array == null)
				{
					continue;
				}
				array[0] = array;
				if (array != null && array == null)
				{
					continue;
				}
				array[1] = array;
				if (array != null && array == null)
				{
					continue;
				}
				array[2] = array;
				if (array == null || array != null)
				{
					array[3] = array;
					if (array == null || array != null)
					{
						break;
					}
				}
			}
			array[4] = array;
			return string.Format("{0}|{1}|{2}|{3}|{4}", array);
		}

		[Cpp2IlInjected.Token(Token = "0x6007BCF")]
		[Cpp2IlInjected.Address(RVA = "0x15D7AC0", Offset = "0x15D64C0", VA = "0x1815D7AC0")]
		public static GridPosition GetDirection(float x, float y)
		{
			int num = MakeIntValue(x);
			int num2 = MakeIntValue(x);
			/*Error: Unexpected end of block*/;
			[Cpp2IlInjected.Token(Token = "0x6007BD1")]
			[Cpp2IlInjected.Address(RVA = "0x15D7B10", Offset = "0x15D6510", VA = "0x1815D7B10")]
			static int MakeIntValue(float value)
			{
				//Discarded unreachable code: IL_0007
				return Math.Sign(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007BD0")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public UnityContextExtensions()
		{
		}
	}
}
