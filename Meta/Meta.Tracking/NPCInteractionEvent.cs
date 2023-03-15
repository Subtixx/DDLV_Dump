using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A75")]
	public class NPCInteractionEvent : CommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000F2D")]
		public string CharacterName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A6C")]
			[Cpp2IlInjected.Address(RVA = "0x1395520", Offset = "0x1393F20", VA = "0x181395520")]
			set
			{
				AddParameter(value, "CharacterName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F2E")]
		public string CharacterID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A6D")]
			[Cpp2IlInjected.Address(RVA = "0x13954C0", Offset = "0x1393EC0", VA = "0x1813954C0")]
			set
			{
				AddParameter(value, "CharacterID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F2F")]
		public int FriendshipLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6005A6E")]
			[Cpp2IlInjected.Address(RVA = "0x1395580", Offset = "0x1393F80", VA = "0x181395580")]
			set
			{
				AddParameter(value, "FriendshipLevel");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F30")]
		public string InteractionType
		{
			[Cpp2IlInjected.Token(Token = "0x6005A6F")]
			[Cpp2IlInjected.Address(RVA = "0x13955E0", Offset = "0x1393FE0", VA = "0x1813955E0")]
			set
			{
				AddParameter(value, "InteractionType");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F31")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A70")]
			[Cpp2IlInjected.Address(RVA = "0x1395490", Offset = "0x1393E90", VA = "0x181395490", Slot = "4")]
			get
			{
				return "npcInteraction";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F32")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005A71")]
			[Cpp2IlInjected.Address(RVA = "0x1395430", Offset = "0x1393E30", VA = "0x181395430", Slot = "5")]
			get
			{
				return TrackingEventBase.InvalidEventId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A6B")]
		[Cpp2IlInjected.Address(RVA = "0x7B2F60", Offset = "0x7B1960", VA = "0x1807B2F60")]
		public NPCInteractionEvent(ClientData clientData)
		{
			int currencyBalance = 0;
			AddCommonParameters(clientData, (byte)currencyBalance != 0);
		}
	}
}
