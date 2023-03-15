using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A7D")]
	public class ClientInfoEvent : CommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000F7B")]
		public string PlayfabEntityId
		{
			[Cpp2IlInjected.Token(Token = "0x6005AC2")]
			[Cpp2IlInjected.Address(RVA = "0x1673A70", Offset = "0x1672470", VA = "0x181673A70")]
			set
			{
				AddParameter(value, "PlayfabEntityId");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F7C")]
		public string buildFullName
		{
			[Cpp2IlInjected.Token(Token = "0x6005AC3")]
			[Cpp2IlInjected.Address(RVA = "0x1673AD0", Offset = "0x16724D0", VA = "0x181673AD0")]
			set
			{
				AddParameter(value, "buildFullName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F7D")]
		public string ClientStore
		{
			[Cpp2IlInjected.Token(Token = "0x6005AC4")]
			[Cpp2IlInjected.Address(RVA = "0x1673A10", Offset = "0x1672410", VA = "0x181673A10")]
			set
			{
				AddParameter(value, "ClientStore");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F7E")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005AC5")]
			[Cpp2IlInjected.Address(RVA = "0x16739E0", Offset = "0x16723E0", VA = "0x1816739E0", Slot = "4")]
			get
			{
				return "clientInfo";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F7F")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005AC6")]
			[Cpp2IlInjected.Address(RVA = "0x1673980", Offset = "0x1672380", VA = "0x181673980", Slot = "5")]
			get
			{
				return TrackingEventBase.InvalidEventId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AC1")]
		[Cpp2IlInjected.Address(RVA = "0x1673900", Offset = "0x1672300", VA = "0x181673900")]
		public ClientInfoEvent(ClientData clientData)
		{
			int userInfo = 0;
			int currencyBalance = 0;
			AddCommonParameters(clientData, (byte)currencyBalance != 0, (byte)userInfo != 0);
		}
	}
}
