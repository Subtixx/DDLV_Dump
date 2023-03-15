using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A74")]
	public class UIInteractionEvent : CommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000F26")]
		public string UiName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A64")]
			[Cpp2IlInjected.Address(RVA = "0x15D7720", Offset = "0x15D6120", VA = "0x1815D7720")]
			set
			{
				AddParameter(value, "UiName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F27")]
		public string UiAction
		{
			[Cpp2IlInjected.Token(Token = "0x6005A65")]
			[Cpp2IlInjected.Address(RVA = "0x15D7660", Offset = "0x15D6060", VA = "0x1815D7660")]
			set
			{
				AddParameter(value, "UiAction");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F28")]
		public string UiLocation
		{
			[Cpp2IlInjected.Token(Token = "0x6005A66")]
			[Cpp2IlInjected.Address(RVA = "0x15D76C0", Offset = "0x15D60C0", VA = "0x1815D76C0")]
			set
			{
				AddParameter(value, "UiLocation");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F29")]
		public string UiType
		{
			[Cpp2IlInjected.Token(Token = "0x6005A67")]
			[Cpp2IlInjected.Address(RVA = "0x15D7780", Offset = "0x15D6180", VA = "0x1815D7780")]
			set
			{
				AddParameter(value, "UiType");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F2A")]
		public int CountAction
		{
			[Cpp2IlInjected.Token(Token = "0x6005A68")]
			[Cpp2IlInjected.Address(RVA = "0x15D7600", Offset = "0x15D6000", VA = "0x1815D7600")]
			set
			{
				AddParameter(value, "CountAction");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F2B")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A69")]
			[Cpp2IlInjected.Address(RVA = "0x15D75D0", Offset = "0x15D5FD0", VA = "0x1815D75D0", Slot = "4")]
			get
			{
				return "uiInteraction";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F2C")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005A6A")]
			[Cpp2IlInjected.Address(RVA = "0x15D7570", Offset = "0x15D5F70", VA = "0x1815D7570", Slot = "5")]
			get
			{
				return TrackingEventBase.InvalidEventId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A63")]
		[Cpp2IlInjected.Address(RVA = "0x7B2F60", Offset = "0x7B1960", VA = "0x1807B2F60")]
		public UIInteractionEvent(ClientData clientData)
		{
			int currencyBalance = 0;
			AddCommonParameters(clientData, (byte)currencyBalance != 0);
		}
	}
}
