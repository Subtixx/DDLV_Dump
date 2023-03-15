using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B11")]
	internal class DoorConversionProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005E04")]
		[Cpp2IlInjected.Address(RVA = "0x173A6E0", Offset = "0x17390E0", VA = "0x18173A6E0", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_000e, IL_0014, IL_001a, IL_0020, IL_0026, IL_002c, IL_0032, IL_0038, IL_003d, IL_003e
			int num = 0;
			Dictionary<Item, Item> dictionary = (Dictionary<Item, Item>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E05")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public DoorConversionProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
