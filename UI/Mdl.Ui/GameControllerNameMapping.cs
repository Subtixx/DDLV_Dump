using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Meta.Util;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001E5")]
	public class GameControllerNameMapping
	{
		[Cpp2IlInjected.Token(Token = "0x4000861")]
		public static Dictionary<ControlType, string[]> ControlTypeControllersNames;

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public GameControllerNameMapping()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C61")]
		[Cpp2IlInjected.Address(RVA = "0xE45000", Offset = "0xE43A00", VA = "0x180E45000")]
		static GameControllerNameMapping()
		{
			//Discarded unreachable code: IL_002b, IL_003a, IL_003e, IL_0050, IL_005f, IL_0067, IL_007b, IL_0086, IL_009a, IL_00a5, IL_00b9, IL_00c4, IL_00d8, IL_00e3, IL_00f5, IL_0105, IL_0110, IL_0125, IL_0130, IL_0145, IL_0150, IL_0165, IL_0170, IL_0185, IL_0190, IL_01a3
			string[] array;
			do
			{
				Dictionary<ControlType, string[]> dictionary = (Dictionary<ControlType, string[]>)(object)new Dictionary<TKey, TValue>();
				array = new string[1];
			}
			while ("d74a350e-fe8b-4e9e-bbcd-efff16d34115" != null && array == null);
			array[0] = "d74a350e-fe8b-4e9e-bbcd-efff16d34115";
			throw new NullReferenceException();
		}
	}
}
