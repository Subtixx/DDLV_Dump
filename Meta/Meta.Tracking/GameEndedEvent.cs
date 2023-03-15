using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A6F")]
	public class GameEndedEvent : CommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000EF4")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A2E")]
			[Cpp2IlInjected.Address(RVA = "0x180ED40", Offset = "0x180D740", VA = "0x18180ED40", Slot = "4")]
			get
			{
				return "gameEnded";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EF5")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005A2F")]
			[Cpp2IlInjected.Address(RVA = "0x180ECE0", Offset = "0x180D6E0", VA = "0x18180ECE0", Slot = "5")]
			get
			{
				return TrackingEventBase.InvalidEventId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A2D")]
		[Cpp2IlInjected.Address(RVA = "0x7B2F60", Offset = "0x7B1960", VA = "0x1807B2F60")]
		public GameEndedEvent(ClientData clientData)
		{
			int currencyBalance = 0;
			AddCommonParameters(clientData, (byte)currencyBalance != 0);
		}
	}
}
