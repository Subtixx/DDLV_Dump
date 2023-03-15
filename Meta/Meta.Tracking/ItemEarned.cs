using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A81")]
	public sealed class ItemEarned : GLTrackingCommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x400292F")]
		public static string Name;

		[Cpp2IlInjected.Token(Token = "0x17000F9C")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005AE7")]
			[Cpp2IlInjected.Address(RVA = "0x1712310", Offset = "0x1710D10", VA = "0x181712310", Slot = "4")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F9D")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005AE8")]
			[Cpp2IlInjected.Address(RVA = "0x1712300", Offset = "0x1710D00", VA = "0x181712300", Slot = "5")]
			get
			{
				return 425871;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F9E")]
		protected override DispatchMode EventDispatchMode
		{
			[Cpp2IlInjected.Token(Token = "0x6005AE9")]
			[Cpp2IlInjected.Address(RVA = "0x7BA030", Offset = "0x7B8A30", VA = "0x1807BA030", Slot = "6")]
			get
			{
				return DispatchMode.WhenShouldTrack;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F9F")]
		public int item_name
		{
			[Cpp2IlInjected.Token(Token = "0x6005AEA")]
			[Cpp2IlInjected.Address(RVA = "0x17123D0", Offset = "0x1710DD0", VA = "0x1817123D0")]
			set
			{
				AddParameter(value, "item_name");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FA0")]
		public string item_type
		{
			[Cpp2IlInjected.Token(Token = "0x6005AEB")]
			[Cpp2IlInjected.Address(RVA = "0x1712430", Offset = "0x1710E30", VA = "0x181712430")]
			set
			{
				AddParameter(value, "item_type");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FA1")]
		public int item_amount
		{
			[Cpp2IlInjected.Token(Token = "0x6005AEC")]
			[Cpp2IlInjected.Address(RVA = "0x1712370", Offset = "0x1710D70", VA = "0x181712370")]
			set
			{
				AddParameter(value, "item_amount");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FA2")]
		public int transcation_type
		{
			[Cpp2IlInjected.Token(Token = "0x6005AED")]
			[Cpp2IlInjected.Address(RVA = "0x1712550", Offset = "0x1710F50", VA = "0x181712550")]
			set
			{
				AddParameter(value, "transcation_type");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FA3")]
		public string transaction_name
		{
			[Cpp2IlInjected.Token(Token = "0x6005AEE")]
			[Cpp2IlInjected.Address(RVA = "0x17124F0", Offset = "0x1710EF0", VA = "0x1817124F0")]
			set
			{
				AddParameter(value, "transaction_name");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FA4")]
		public string transaction_location
		{
			[Cpp2IlInjected.Token(Token = "0x6005AEF")]
			[Cpp2IlInjected.Address(RVA = "0x1712490", Offset = "0x1710E90", VA = "0x181712490")]
			set
			{
				AddParameter(value, "transaction_location");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AE6")]
		[Cpp2IlInjected.Address(RVA = "0x1712090", Offset = "0x1710A90", VA = "0x181712090")]
		public ItemEarned(ClientData clientData, string trans_name, int trans_type, Item item, int amount)
		{
			//Discarded unreachable code: IL_006f
			int t = default(int);
			AddParameter(t, "item_name");
			AddParameter("N/A", "item_type");
			AddParameter(trans_name, "transaction_name");
			AddParameter(trans_type, "transcation_type");
			if (clientData == null || clientData.location == null || "transcation_type" == null)
			{
			}
			AddParameter("", "transaction_location");
			AddCommonParameters(clientData, balance: true);
			isHighPriority = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AF0")]
		[Cpp2IlInjected.Address(RVA = "0x1712040", Offset = "0x1710A40", VA = "0x181712040")]
		static ItemEarned()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
