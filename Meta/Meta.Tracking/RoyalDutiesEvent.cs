using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A7C")]
	public class RoyalDutiesEvent : CommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000F71")]
		public string DutyID
		{
			[Cpp2IlInjected.Token(Token = "0x6005AB7")]
			[Cpp2IlInjected.Address(RVA = "0x1766190", Offset = "0x1764B90", VA = "0x181766190")]
			set
			{
				AddParameter(value, "DutyID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F72")]
		public string DutyName
		{
			[Cpp2IlInjected.Token(Token = "0x6005AB8")]
			[Cpp2IlInjected.Address(RVA = "0x17662B0", Offset = "0x1764CB0", VA = "0x1817662B0")]
			set
			{
				AddParameter(value, "DutyName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F73")]
		public string DutyType
		{
			[Cpp2IlInjected.Token(Token = "0x6005AB9")]
			[Cpp2IlInjected.Address(RVA = "0x1766310", Offset = "0x1764D10", VA = "0x181766310")]
			set
			{
				AddParameter(value, "DutyType");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F74")]
		public string DutyDifficulty
		{
			[Cpp2IlInjected.Token(Token = "0x6005ABA")]
			[Cpp2IlInjected.Address(RVA = "0x17660D0", Offset = "0x1764AD0", VA = "0x1817660D0")]
			set
			{
				AddParameter(value, "DutyDifficulty");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F75")]
		public int DutyItemAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6005ABB")]
			[Cpp2IlInjected.Address(RVA = "0x17661F0", Offset = "0x1764BF0", VA = "0x1817661F0")]
			set
			{
				AddParameter(value, "DutyItemAmount");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F76")]
		public string DutyItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6005ABC")]
			[Cpp2IlInjected.Address(RVA = "0x1766250", Offset = "0x1764C50", VA = "0x181766250")]
			set
			{
				AddParameter(value, "DutyItemName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F77")]
		public int DutyDustReward
		{
			[Cpp2IlInjected.Token(Token = "0x6005ABD")]
			[Cpp2IlInjected.Address(RVA = "0x1766130", Offset = "0x1764B30", VA = "0x181766130")]
			set
			{
				AddParameter(value, "DutyDustReward");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F78")]
		public bool StarpathActive
		{
			[Cpp2IlInjected.Token(Token = "0x6005ABE")]
			[Cpp2IlInjected.Address(RVA = "0x1766370", Offset = "0x1764D70", VA = "0x181766370")]
			set
			{
				AddParameter(value, "StarpathActive");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F79")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005ABF")]
			[Cpp2IlInjected.Address(RVA = "0x17660A0", Offset = "0x1764AA0", VA = "0x1817660A0", Slot = "4")]
			get
			{
				return "royalDuties";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F7A")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005AC0")]
			[Cpp2IlInjected.Address(RVA = "0x1766040", Offset = "0x1764A40", VA = "0x181766040", Slot = "5")]
			get
			{
				return TrackingEventBase.InvalidEventId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AB6")]
		[Cpp2IlInjected.Address(RVA = "0x7B2F60", Offset = "0x7B1960", VA = "0x1807B2F60")]
		public RoyalDutiesEvent(ClientData clientData)
		{
			int currencyBalance = 0;
			AddCommonParameters(clientData, (byte)currencyBalance != 0);
		}
	}
}
