using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A6D")]
	public abstract class GLTrackingCommonBaseEvent : TrackingEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x17000EE2")]
		private int user_level
		{
			[Cpp2IlInjected.Token(Token = "0x6005A18")]
			[Cpp2IlInjected.Address(RVA = "0x180BDF0", Offset = "0x180A7F0", VA = "0x18180BDF0")]
			set
			{
				AddParameter(value, "user_level");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE3")]
		private int total_play_time
		{
			[Cpp2IlInjected.Token(Token = "0x6005A19")]
			[Cpp2IlInjected.Address(RVA = "0x180BD90", Offset = "0x180A790", VA = "0x18180BD90")]
			set
			{
				AddParameter(value, "total_play_time");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE4")]
		private int session_index
		{
			[Cpp2IlInjected.Token(Token = "0x6005A1A")]
			[Cpp2IlInjected.Address(RVA = "0x180BCD0", Offset = "0x180A6D0", VA = "0x18180BCD0")]
			set
			{
				AddParameter(value, "session_index");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE5")]
		private int dreamlight_balance
		{
			[Cpp2IlInjected.Token(Token = "0x6005A1B")]
			[Cpp2IlInjected.Address(RVA = "0x180BBB0", Offset = "0x180A5B0", VA = "0x18180BBB0")]
			set
			{
				AddParameter(value, "dreamlight_balance");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE6")]
		private int energy_balance
		{
			[Cpp2IlInjected.Token(Token = "0x6005A1C")]
			[Cpp2IlInjected.Address(RVA = "0x180BC10", Offset = "0x180A610", VA = "0x18180BC10")]
			set
			{
				AddParameter(value, "energy_balance");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE7")]
		private int hard_currency_balance
		{
			[Cpp2IlInjected.Token(Token = "0x6005A1D")]
			[Cpp2IlInjected.Address(RVA = "0x180BC70", Offset = "0x180A670", VA = "0x18180BC70")]
			set
			{
				AddParameter(value, "hard_currency_balance");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE8")]
		private int soft_currency01_balance
		{
			[Cpp2IlInjected.Token(Token = "0x6005A1E")]
			[Cpp2IlInjected.Address(RVA = "0x180BD30", Offset = "0x180A730", VA = "0x18180BD30")]
			set
			{
				AddParameter(value, "soft_currency01_balance");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A17")]
		[Cpp2IlInjected.Address(RVA = "0x180B800", Offset = "0x180A200", VA = "0x18180B800")]
		protected void AddCommonParameters(ClientData clientData, bool balance = false)
		{
			//Discarded unreachable code: IL_00ff
			Profile profile = clientData.profile;
			if (profile != null)
			{
				int session_ = profile.gameInfo_.session_;
				AddParameter(session_, "session_index");
				ProfilePlayer player_ = clientData.profile.player_;
				AddParameter(session_, "user_level");
				ProfilePlayer player_2 = clientData.profile.player_;
				AddParameter(session_, "total_play_time");
				if (balance)
				{
					ProfilePlayer player_3 = clientData.profile.player_;
					int num = 0;
					int itemID = CurrencyItem.HardCurrencyItem.ItemID;
					int num2 = default(int);
					itemID = num2;
					AddParameter(itemID, "hard_currency_balance");
					ProfilePlayer player_4 = clientData.profile.player_;
					int num3 = 0;
					int itemID2 = CurrencyItem.SoftCurrencyItem.ItemID;
					int num4 = default(int);
					itemID2 = num4;
					AddParameter(itemID2, "soft_currency01_balance");
					ProfilePlayer player_5 = clientData.profile.player_;
					int num5 = 0;
					int itemID3 = CurrencyItem.DreamDustCurrencyItem.ItemID;
					int num6 = default(int);
					itemID3 = num6;
					AddParameter(itemID3, "dreamlight_balance");
					ProfilePlayer player_6 = clientData.profile.player_;
					AddParameter(itemID3, "energy_balance");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A1F")]
		[Cpp2IlInjected.Address(RVA = "0x180BB50", Offset = "0x180A550", VA = "0x18180BB50")]
		protected GLTrackingCommonBaseEvent()
		{
		}
	}
}
