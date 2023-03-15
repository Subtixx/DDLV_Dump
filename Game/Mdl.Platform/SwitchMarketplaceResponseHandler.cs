using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Meta.Online.Economy;
using PlayFab;
using PlayFab.EconomyModels;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002DD")]
	public class SwitchMarketplaceResponseHandler : IMarketplaceResponseHandler
	{
		[Cpp2IlInjected.Token(Token = "0x40015B6")]
		private static readonly string PLAYFAB_STRING_LOOKUP_FOR_ERROR_1502 = "503:";

		[Cpp2IlInjected.Token(Token = "0x40015B7")]
		private static readonly string PLAYFAB_STRING_LOOKUP_FOR_ERROR_9501;

		[Cpp2IlInjected.Token(Token = "0x40015B8")]
		private static readonly uint NINTENDO_ERROR_CATEGORY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40015B9")]
		private Dictionary<string, uint> PlayfabMsgParsingToNintendoErrorCode;

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0x1068500", Offset = "0x1066F00", VA = "0x181068500", Slot = "4")]
		public void HandleRedeemResponse(RedeemResponse redeemResponse)
		{
			//Discarded unreachable code: IL_0025
			PlayFabResult<RedeemMarketplaceAssetsResult> redeemMarketplaceAssetsResult = redeemResponse.redeemMarketplaceAssetsResult;
			if ("Nintendo" == null)
			{
				return;
			}
			Dictionary<string, uint> playfabMsgParsingToNintendoErrorCode = PlayfabMsgParsingToNintendoErrorCode;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0x1068720", Offset = "0x1067120", VA = "0x181068720")]
		public SwitchMarketplaceResponseHandler()
		{
			//Discarded unreachable code: IL_000c, IL_0012, IL_0020
			Dictionary<string, uint> dictionary = (Dictionary<string, uint>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0x1068690", Offset = "0x1067090", VA = "0x181068690")]
		static SwitchMarketplaceResponseHandler()
		{
			PLAYFAB_STRING_LOOKUP_FOR_ERROR_1502 = "400:";
		}
	}
}
