using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A76")]
	public class DlcDownloadEvent : CommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000F33")]
		public string DlcID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A73")]
			[Cpp2IlInjected.Address(RVA = "0x1739CA0", Offset = "0x17386A0", VA = "0x181739CA0")]
			set
			{
				AddParameter(value, "DlcID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F34")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A74")]
			[Cpp2IlInjected.Address(RVA = "0x1739C70", Offset = "0x1738670", VA = "0x181739C70", Slot = "4")]
			get
			{
				return "dlcDownload";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F35")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005A75")]
			[Cpp2IlInjected.Address(RVA = "0x1739C10", Offset = "0x1738610", VA = "0x181739C10", Slot = "5")]
			get
			{
				return TrackingEventBase.InvalidEventId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A72")]
		[Cpp2IlInjected.Address(RVA = "0x7B2F60", Offset = "0x7B1960", VA = "0x1807B2F60")]
		public DlcDownloadEvent(ClientData clientData)
		{
			int currencyBalance = 0;
			AddCommonParameters(clientData, (byte)currencyBalance != 0);
		}
	}
}
