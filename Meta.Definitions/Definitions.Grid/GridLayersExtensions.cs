using System;
using System.Collections;
using System.Text;
using Cpp2IlInjected;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x200070E")]
	public static class GridLayersExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x40023AF")]
		public static readonly GridLayers AllExclusiveLayers;

		[Cpp2IlInjected.Token(Token = "0x40023B0")]
		public static readonly GridLayers ClearAndBlocking;

		[Cpp2IlInjected.Token(Token = "0x6004EB0")]
		[Cpp2IlInjected.Address(RVA = "0x2F8F230", Offset = "0x2F8DC30", VA = "0x182F8F230")]
		public static bool Collide(this GridLayers gridLayersA, GridLayers gridLayersB)
		{
			if (gridLayersA != GridLayers.Blocking && gridLayersB != GridLayers.Clear)
			{
				return true;
			}
			if (gridLayersA == GridLayers.Clear || gridLayersB != GridLayers.Blocking)
			{
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EB1")]
		[Cpp2IlInjected.Address(RVA = "0x2F8F180", Offset = "0x2F8DB80", VA = "0x182F8F180")]
		public static bool Collide(this GridLayers gridLayersA, GridLayers gridLayersB, out GridLayers conflictedLayers)
		{
			int num = (conflictedLayers.value__ = 0);
			if (gridLayersA == GridLayers.Blocking || gridLayersB != GridLayers.Clear)
			{
			}
			if (gridLayersA == GridLayers.Clear || gridLayersB != GridLayers.Blocking)
			{
			}
			conflictedLayers.value__ = 32;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EB2")]
		[Cpp2IlInjected.Address(RVA = "0x2F8F320", Offset = "0x2F8DD20", VA = "0x182F8F320")]
		public unsafe static string ToFormattedString(this GridLayers gridLayers)
		{
			//Discarded unreachable code: IL_005e, IL_0064, IL_006a, IL_0070, IL_0076, IL_007c, IL_0082
			int num = 0;
			StringBuilder stringBuilder = new StringBuilder();
			IEnumerator enumerator = Enum.GetValues(typeof(GridLayers)).GetEnumerator();
			if (enumerator != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				IEnumerator enumerator2 = enumerator;
				while ((IntPtr)(void*)(int)gridLayers == (IntPtr)enumerator2)
				{
				}
				ulong num3 = default(ulong);
				if (num3 == 0)
				{
					StringBuilder stringBuilder2 = stringBuilder.Append(" | ");
				}
				IEnumerator enumerator3 = enumerator2;
			}
			StringBuilder stringBuilder3 = default(StringBuilder);
			if (stringBuilder3 != null)
			{
			}
			return stringBuilder.ToString();
		}
	}
}
