using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta.Online.Economy;
using Steamworks;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002EE")]
	public class SteamMarketplaceRequestProvider : IMarketplaceRequestProvider
	{
		[Cpp2IlInjected.Token(Token = "0x20002EF")]
		public class SteamReceiptPayload
		{
			[Cpp2IlInjected.Token(Token = "0x17000192")]
			public string SteamId
			{
				[Cpp2IlInjected.Token(Token = "0x6000CFB")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CSteamId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000CFC")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CSteamId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000CFD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SteamReceiptPayload()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0xF61900", Offset = "0xF60300", VA = "0x180F61900", Slot = "5")]
		public string GetMarketplaceName()
		{
			return "Steam";
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0xF61930", Offset = "0xF60330", VA = "0x180F61930", Slot = "6")]
		public Task<List<RedeemData>> GetMarketplacesData()
		{
			//Discarded unreachable code: IL_0043
			List<RedeemData> list = (List<RedeemData>)(object)new List<T>();
			RedeemData redeemData = new RedeemData();
			redeemData.MarketName = "Steam";
			SteamReceiptPayload steamReceiptPayload = new SteamReceiptPayload();
			int num = 0;
			CSteamID cSteamID = (CSteamID)(steamReceiptPayload.SteamId = (string)SteamUser.GetSteamID());
			redeemData.MarketData = steamReceiptPayload;
			((List<T>)(object)list).Add((T)redeemData);
			return (Task<List<RedeemData>>)(object)Task.FromResult(list);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public ServiceLabelData GetServiceLabelData()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF6")]
		[Cpp2IlInjected.Address(RVA = "0xF617F0", Offset = "0xF601F0", VA = "0x180F617F0", Slot = "8")]
		public Task<AuthCodeData> GetAuthCodeAsync()
		{
			//Discarded unreachable code: IL_001c
			AuthCodeData authCodeData = new AuthCodeData();
			int num = 0;
			CSteamID cSteamID = (CSteamID)(authCodeData.UserId = (string)SteamUser.GetSteamID());
			return (Task<AuthCodeData>)(object)Task.FromResult(authCodeData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF7")]
		[Cpp2IlInjected.Address(RVA = "0xF618B0", Offset = "0xF602B0", VA = "0x180F618B0", Slot = "9")]
		public string GetDebugInfo()
		{
			int num = 0;
			CSteamID steamID = SteamUser.GetSteamID();
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF8")]
		[Cpp2IlInjected.Address(RVA = "0xF61AC0", Offset = "0xF604C0", VA = "0x180F61AC0", Slot = "4")]
		public Task GrantAsync(CancellationToken ct)
		{
			bool flag = default(bool);
			if (!flag)
			{
			}
			string text = "[Steam] SteamMarketplaceRequestProvider - Granting promo items with result=" + "Success";
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF9")]
		[Cpp2IlInjected.Address(RVA = "0xF61BB0", Offset = "0xF605B0", VA = "0x180F61BB0")]
		private static void GrantPromoItems()
		{
			bool flag = default(bool);
			if (!flag)
			{
			}
			string text = "[Steam] SteamMarketplaceRequestProvider - Granting promo items with result=" + "Success";
		}

		[Cpp2IlInjected.Token(Token = "0x6000CFA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public SteamMarketplaceRequestProvider()
		{
		}
	}
}
