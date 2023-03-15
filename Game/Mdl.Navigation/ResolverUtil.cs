using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Gameloft.Localization.Core;
using Gameloft.Localization.Formatter;
using Mdl.Systems;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BAF")]
	public class ResolverUtil
	{
		[Cpp2IlInjected.Token(Token = "0x60035DA")]
		[Cpp2IlInjected.Address(RVA = "0xCC1C00", Offset = "0xCC0600", VA = "0x180CC1C00")]
		public static IResolver CreateItemPriceResolver([Optional] IItemData item, [Optional] CurrencyCost cost, [Optional] IItemData currency)
		{
			//Discarded unreachable code: IL_0020, IL_0024, IL_002d, IL_0031, IL_0037
			Localizator _003CLocalizator_003Ek__BackingField = SystemRoot.Instance._localizationManager.Localizator;
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			if (item != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60035DB")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ResolverUtil()
		{
		}
	}
}
