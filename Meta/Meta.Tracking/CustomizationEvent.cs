using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A78")]
	public class CustomizationEvent : CommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000F3E")]
		public string ObjectName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A80")]
			[Cpp2IlInjected.Address(RVA = "0x18C53B0", Offset = "0x18C3DB0", VA = "0x1818C53B0")]
			set
			{
				AddParameter(value, "ObjectName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F3F")]
		public int NbChanges
		{
			[Cpp2IlInjected.Token(Token = "0x6005A81")]
			[Cpp2IlInjected.Address(RVA = "0x18C5350", Offset = "0x18C3D50", VA = "0x1818C5350")]
			set
			{
				AddParameter(value, "NbChanges");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F40")]
		public object ProductsSpent
		{
			[Cpp2IlInjected.Token(Token = "0x6005A82")]
			[Cpp2IlInjected.Address(RVA = "0x18C5410", Offset = "0x18C3E10", VA = "0x1818C5410")]
			set
			{
				AddComplexParameter(value, "ProductsSpent");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F41")]
		public string MapLocation
		{
			[Cpp2IlInjected.Token(Token = "0x6005A83")]
			[Cpp2IlInjected.Address(RVA = "0x18C52F0", Offset = "0x18C3CF0", VA = "0x1818C52F0")]
			set
			{
				AddParameter(value, "MapLocation");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F42")]
		public bool Touchofmagic
		{
			[Cpp2IlInjected.Token(Token = "0x6005A84")]
			[Cpp2IlInjected.Address(RVA = "0x18C5470", Offset = "0x18C3E70", VA = "0x1818C5470")]
			set
			{
				AddParameter(value, "Touchofmagic");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F43")]
		public int Touchofmagicmax
		{
			[Cpp2IlInjected.Token(Token = "0x6005A85")]
			[Cpp2IlInjected.Address(RVA = "0x18C5530", Offset = "0x18C3F30", VA = "0x1818C5530")]
			set
			{
				AddParameter(value, "Touchofmagicmax");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F44")]
		public int Touchofmagicdesigns
		{
			[Cpp2IlInjected.Token(Token = "0x6005A86")]
			[Cpp2IlInjected.Address(RVA = "0x18C54D0", Offset = "0x18C3ED0", VA = "0x1818C54D0")]
			set
			{
				AddParameter(value, "Touchofmagicdesigns");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F45")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A87")]
			[Cpp2IlInjected.Address(RVA = "0x18C52C0", Offset = "0x18C3CC0", VA = "0x1818C52C0", Slot = "4")]
			get
			{
				return "customization";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F46")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005A88")]
			[Cpp2IlInjected.Address(RVA = "0x18C5260", Offset = "0x18C3C60", VA = "0x1818C5260", Slot = "5")]
			get
			{
				return TrackingEventBase.InvalidEventId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A7F")]
		[Cpp2IlInjected.Address(RVA = "0x18C5190", Offset = "0x18C3B90", VA = "0x1818C5190")]
		public CustomizationEvent(ClientData clientData)
		{
			//Discarded unreachable code: IL_0017
			AddCommonParameters(clientData, currencyBalance: true);
			ILocation location = clientData.location;
		}
	}
}
