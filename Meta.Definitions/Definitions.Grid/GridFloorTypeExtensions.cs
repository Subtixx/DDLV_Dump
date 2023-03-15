using System;
using System.Collections;
using System.Text;
using Cpp2IlInjected;
using Definitions.Scene;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x200070D")]
	public static class GridFloorTypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x40023AB")]
		public static readonly GridFloorType VillageGrass;

		[Cpp2IlInjected.Token(Token = "0x40023AC")]
		public static readonly GridFloorType Exterior = VillageGrass;

		[Cpp2IlInjected.Token(Token = "0x40023AD")]
		public static readonly GridFloorType Interior;

		[Cpp2IlInjected.Token(Token = "0x40023AE")]
		public static readonly GridFloorType All = Interior;

		[Cpp2IlInjected.Token(Token = "0x6004EA6")]
		[Cpp2IlInjected.Address(RVA = "0x2F8ED00", Offset = "0x2F8D700", VA = "0x182F8ED00")]
		public static bool IsWallOnFloorGrid(this GridFloorType gridFloorType)
		{
			return gridFloorType == (GridFloorType)3072;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EA7")]
		[Cpp2IlInjected.Address(RVA = "0x2F8ED10", Offset = "0x2F8D710", VA = "0x182F8ED10")]
		public static bool IsWallOnly(this GridFloorType gridFloorType)
		{
			return gridFloorType == GridFloorType.Wall;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EA8")]
		[Cpp2IlInjected.Address(RVA = "0x2F8EC90", Offset = "0x2F8D690", VA = "0x182F8EC90")]
		public static bool IsSurface(this GridFloorType gridFloorType)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004EA9")]
		[Cpp2IlInjected.Address(RVA = "0x2F8ED20", Offset = "0x2F8D720", VA = "0x182F8ED20")]
		public static bool IsWater(this GridFloorType gridFloorType)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004EAA")]
		[Cpp2IlInjected.Address(RVA = "0x2F8EC80", Offset = "0x2F8D680", VA = "0x182F8EC80")]
		public static bool IsShore(this GridFloorType gridFloorType)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004EAB")]
		[Cpp2IlInjected.Address(RVA = "0x2F8ECA0", Offset = "0x2F8D6A0", VA = "0x182F8ECA0")]
		public unsafe static bool IsVoid(this GridFloorType gridFloorType)
		{
			return (IntPtr)"{il2cpp field on {'constant10' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0xC}" == (IntPtr)(void*)(int)gridFloorType;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EAC")]
		[Cpp2IlInjected.Address(RVA = "0x13A24F0", Offset = "0x13A0EF0", VA = "0x1813A24F0")]
		public static bool Is(this GridFloorType gridFloorType, GridFloorType other)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004EAD")]
		[Cpp2IlInjected.Address(RVA = "0x2F8F060", Offset = "0x2F8DA60", VA = "0x182F8F060")]
		public static bool ToVillageAreaType(this GridFloorType gridFloorType, out VillageAreaType villageAreaType)
		{
			while (true)
			{
				if (gridFloorType > GridFloorType.Savannah)
				{
					if (gridFloorType == GridFloorType.Forest)
					{
					}
					if (gridFloorType == GridFloorType.DarkMountains)
					{
					}
					if (gridFloorType != GridFloorType.Cliff)
					{
						break;
					}
				}
				if (gridFloorType == GridFloorType.Cliff || gridFloorType == GridFloorType.Cliff)
				{
					continue;
				}
				if (gridFloorType != GridFloorType.Cliff && gridFloorType != GridFloorType.Beach)
				{
					if (gridFloorType == GridFloorType.Urban)
					{
					}
					if (gridFloorType != GridFloorType.Savannah)
					{
					}
				}
				break;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EAE")]
		[Cpp2IlInjected.Address(RVA = "0x2F8ED30", Offset = "0x2F8D730", VA = "0x182F8ED30")]
		public unsafe static string ToFormattedString(this GridFloorType gridFloorType)
		{
			//Discarded unreachable code: IL_005e, IL_0064, IL_006a, IL_0070, IL_0076, IL_007c, IL_0082
			int num = 0;
			StringBuilder stringBuilder = new StringBuilder();
			IEnumerator enumerator = Enum.GetValues(typeof(GridFloorType)).GetEnumerator();
			if (enumerator != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				IEnumerator enumerator2 = enumerator;
				while ((IntPtr)(void*)(int)gridFloorType == (IntPtr)enumerator2)
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
