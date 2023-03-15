using Cpp2IlInjected;
using Definitions.Items;
using PlayFab;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A6E")]
	public abstract class CommonBaseEvent : TrackingEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x17000EE9")]
		private int UserXP
		{
			[Cpp2IlInjected.Token(Token = "0x6005A21")]
			[Cpp2IlInjected.Address(RVA = "0x167E3A0", Offset = "0x167CDA0", VA = "0x18167E3A0")]
			set
			{
				AddParameter(value, "UserXP");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EEA")]
		private int UserLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6005A22")]
			[Cpp2IlInjected.Address(RVA = "0x167E340", Offset = "0x167CD40", VA = "0x18167E340")]
			set
			{
				AddParameter(value, "UserLevel");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EEB")]
		private int TotalPlayTime
		{
			[Cpp2IlInjected.Token(Token = "0x6005A23")]
			[Cpp2IlInjected.Address(RVA = "0x167E2E0", Offset = "0x167CCE0", VA = "0x18167E2E0")]
			set
			{
				AddParameter(value, "TotalPlayTime");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EEC")]
		private string ClientVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6005A24")]
			[Cpp2IlInjected.Address(RVA = "0x167E160", Offset = "0x167CB60", VA = "0x18167E160")]
			set
			{
				AddParameter(value, "ClientVersion");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EED")]
		private int BalanceHC
		{
			[Cpp2IlInjected.Token(Token = "0x6005A25")]
			[Cpp2IlInjected.Address(RVA = "0x167E0A0", Offset = "0x167CAA0", VA = "0x18167E0A0")]
			set
			{
				AddParameter(value, "BalanceHC");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EEE")]
		private int BalanceSC
		{
			[Cpp2IlInjected.Token(Token = "0x6005A26")]
			[Cpp2IlInjected.Address(RVA = "0x167E100", Offset = "0x167CB00", VA = "0x18167E100")]
			set
			{
				AddParameter(value, "BalanceSC");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EEF")]
		private int BalanceDreamlight
		{
			[Cpp2IlInjected.Token(Token = "0x6005A27")]
			[Cpp2IlInjected.Address(RVA = "0x167DFE0", Offset = "0x167C9E0", VA = "0x18167DFE0")]
			set
			{
				AddParameter(value, "BalanceDreamlight");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF0")]
		private int BalanceEnergy
		{
			[Cpp2IlInjected.Token(Token = "0x6005A28")]
			[Cpp2IlInjected.Address(RVA = "0x167E040", Offset = "0x167CA40", VA = "0x18167E040")]
			set
			{
				AddParameter(value, "BalanceEnergy");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF1")]
		private string PlayFabTitleId
		{
			[Cpp2IlInjected.Token(Token = "0x6005A29")]
			[Cpp2IlInjected.Address(RVA = "0x167E220", Offset = "0x167CC20", VA = "0x18167E220")]
			set
			{
				AddParameter(value, "PlayFabTitleId");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF2")]
		private string PlayfabId
		{
			[Cpp2IlInjected.Token(Token = "0x6005A2A")]
			[Cpp2IlInjected.Address(RVA = "0x167E280", Offset = "0x167CC80", VA = "0x18167E280")]
			set
			{
				AddParameter(value, "PlayfabId");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF3")]
		private bool IsDev
		{
			[Cpp2IlInjected.Token(Token = "0x6005A2B")]
			[Cpp2IlInjected.Address(RVA = "0x167E1C0", Offset = "0x167CBC0", VA = "0x18167E1C0")]
			set
			{
				AddParameter(value, "IsDev");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A20")]
		[Cpp2IlInjected.Address(RVA = "0x167DA70", Offset = "0x167C470", VA = "0x18167DA70")]
		protected void AddCommonParameters(ClientData clientData, bool currencyBalance = false, bool userInfo = true)
		{
			//Discarded unreachable code: IL_0168
			if ((long)clientData.profile != 0)
			{
				string clientVersion = clientData.clientVersion;
				AddParameter(clientVersion, "ClientVersion");
				string titleId = PlayFabSettings.staticSettings.TitleId;
				AddParameter(titleId, "PlayFabTitleId");
				string playfabUserId = clientData.playfabUserId;
				AddParameter(playfabUserId, "PlayfabId");
				bool isDev_ = clientData.profile.settings_.isDev_;
				AddParameter(isDev_, "IsDev");
				if (currencyBalance)
				{
					ProfilePlayer player_ = clientData.profile.player_;
					int num = 0;
					int itemID = CurrencyItem.HardCurrencyItem.ItemID;
					int num2 = default(int);
					itemID = num2;
					AddParameter(itemID, "BalanceHC");
					ProfilePlayer player_2 = clientData.profile.player_;
					int num3 = 0;
					int itemID2 = CurrencyItem.SoftCurrencyItem.ItemID;
					int num4 = default(int);
					itemID2 = num4;
					AddParameter(itemID2, "BalanceSC");
					ProfilePlayer player_3 = clientData.profile.player_;
					int num5 = 0;
					int itemID3 = CurrencyItem.DreamDustCurrencyItem.ItemID;
					int num6 = default(int);
					itemID3 = num6;
					AddParameter(itemID3, "BalanceDreamlight");
					ProfilePlayer player_4 = clientData.profile.player_;
					AddParameter(itemID3, "BalanceEnergy");
				}
				if (userInfo)
				{
					int level_ = clientData.profile.player_.level_;
					AddParameter(level_, "UserLevel");
					ProfilePlayer player_5 = clientData.profile.player_;
					AddParameter(level_, "UserXP");
					ProfilePlayer player_6 = clientData.profile.player_;
					AddParameter(level_, "TotalPlayTime");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A2C")]
		[Cpp2IlInjected.Address(RVA = "0x167DF80", Offset = "0x167C980", VA = "0x18167DF80")]
		protected CommonBaseEvent()
		{
		}
	}
}
