using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A7B")]
	public class StorageFullEvent : CommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000F6C")]
		public string StorageId
		{
			[Cpp2IlInjected.Token(Token = "0x6005AB1")]
			[Cpp2IlInjected.Address(RVA = "0xC095C0", Offset = "0xC07FC0", VA = "0x180C095C0")]
			set
			{
				AddParameter(value, "StorageId");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F6D")]
		public int StorageCapacity
		{
			[Cpp2IlInjected.Token(Token = "0x6005AB2")]
			[Cpp2IlInjected.Address(RVA = "0xC09560", Offset = "0xC07F60", VA = "0x180C09560")]
			set
			{
				AddParameter(value, "StorageCapacity");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F6E")]
		public string Redirection
		{
			[Cpp2IlInjected.Token(Token = "0x6005AB3")]
			[Cpp2IlInjected.Address(RVA = "0xC09500", Offset = "0xC07F00", VA = "0x180C09500")]
			set
			{
				AddParameter(value, "Redirection");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F6F")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005AB4")]
			[Cpp2IlInjected.Address(RVA = "0xC094D0", Offset = "0xC07ED0", VA = "0x180C094D0", Slot = "4")]
			get
			{
				return "storageFull";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F70")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005AB5")]
			[Cpp2IlInjected.Address(RVA = "0xC09470", Offset = "0xC07E70", VA = "0x180C09470", Slot = "5")]
			get
			{
				return TrackingEventBase.InvalidEventId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AB0")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA90", Offset = "0x5BB490", VA = "0x1805BCA90")]
		public StorageFullEvent(ClientData clientData)
		{
			AddCommonParameters(clientData, currencyBalance: true);
		}
	}
}
