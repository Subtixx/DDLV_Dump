using System;
using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A80")]
	public sealed class CurrencyEarned : GLTrackingCommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000F8D")]
		public static string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6005AD7")]
			[Cpp2IlInjected.Address(RVA = "0x18C4000", Offset = "0x18C2A00", VA = "0x1818C4000")]
			get
			{
				return "CurrencyEarned";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F8E")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005AD8")]
			[Cpp2IlInjected.Address(RVA = "0x18C4000", Offset = "0x18C2A00", VA = "0x1818C4000", Slot = "4")]
			get
			{
				return "CurrencyEarned";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F8F")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005AD9")]
			[Cpp2IlInjected.Address(RVA = "0x18C3FF0", Offset = "0x18C29F0", VA = "0x1818C3FF0", Slot = "5")]
			get
			{
				return 425864;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F90")]
		protected override DispatchMode EventDispatchMode
		{
			[Cpp2IlInjected.Token(Token = "0x6005ADA")]
			[Cpp2IlInjected.Address(RVA = "0x7BA030", Offset = "0x7B8A30", VA = "0x1807BA030", Slot = "6")]
			get
			{
				return DispatchMode.WhenShouldTrack;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F91")]
		public int currency_name
		{
			[Cpp2IlInjected.Token(Token = "0x6005ADB")]
			[Cpp2IlInjected.Address(RVA = "0x18C4090", Offset = "0x18C2A90", VA = "0x1818C4090")]
			set
			{
				AddParameter(value, "currency_name");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F92")]
		public int currency_type
		{
			[Cpp2IlInjected.Token(Token = "0x6005ADC")]
			[Cpp2IlInjected.Address(RVA = "0x18C40F0", Offset = "0x18C2AF0", VA = "0x1818C40F0")]
			set
			{
				AddParameter(value, "currency_type");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F93")]
		public int item_name
		{
			[Cpp2IlInjected.Token(Token = "0x6005ADD")]
			[Cpp2IlInjected.Address(RVA = "0x18C41B0", Offset = "0x18C2BB0", VA = "0x1818C41B0")]
			set
			{
				AddParameter(value, "item_name");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F94")]
		public string item_type
		{
			[Cpp2IlInjected.Token(Token = "0x6005ADE")]
			[Cpp2IlInjected.Address(RVA = "0x18C4210", Offset = "0x18C2C10", VA = "0x1818C4210")]
			set
			{
				AddParameter(value, "item_type");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F95")]
		public int item_amount
		{
			[Cpp2IlInjected.Token(Token = "0x6005ADF")]
			[Cpp2IlInjected.Address(RVA = "0x18C4150", Offset = "0x18C2B50", VA = "0x1818C4150")]
			set
			{
				AddParameter(value, "item_amount");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F96")]
		public string transaction_name
		{
			[Cpp2IlInjected.Token(Token = "0x6005AE0")]
			[Cpp2IlInjected.Address(RVA = "0x18C4330", Offset = "0x18C2D30", VA = "0x1818C4330")]
			set
			{
				AddParameter(value, "transaction_name");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F97")]
		public int transaction_type
		{
			[Cpp2IlInjected.Token(Token = "0x6005AE1")]
			[Cpp2IlInjected.Address(RVA = "0x18C4390", Offset = "0x18C2D90", VA = "0x1818C4390")]
			set
			{
				AddParameter(value, "transaction_type");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F98")]
		public string transcation_location
		{
			[Cpp2IlInjected.Token(Token = "0x6005AE2")]
			[Cpp2IlInjected.Address(RVA = "0x18C43F0", Offset = "0x18C2DF0", VA = "0x1818C43F0")]
			set
			{
				AddParameter(value, "transcation_location");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F99")]
		public int currency_amount
		{
			[Cpp2IlInjected.Token(Token = "0x6005AE3")]
			[Cpp2IlInjected.Address(RVA = "0x18C4030", Offset = "0x18C2A30", VA = "0x1818C4030")]
			set
			{
				AddParameter(value, "currency_amount");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F9A")]
		public string tle_event_name
		{
			[Cpp2IlInjected.Token(Token = "0x6005AE4")]
			[Cpp2IlInjected.Address(RVA = "0x18C42D0", Offset = "0x18C2CD0", VA = "0x1818C42D0")]
			set
			{
				AddParameter(value, "tle_event_name");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F9B")]
		public string mini_event_name
		{
			[Cpp2IlInjected.Token(Token = "0x6005AE5")]
			[Cpp2IlInjected.Address(RVA = "0x18C4270", Offset = "0x18C2C70", VA = "0x1818C4270")]
			set
			{
				AddParameter(value, "mini_event_name");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AD6")]
		[Cpp2IlInjected.Address(RVA = "0x18C3C30", Offset = "0x18C2630", VA = "0x1818C3C30")]
		public unsafe CurrencyEarned(ClientData clientData, string trans_name, int trans_type, Item currencyItem, int amount, string type)
		{
			//Discarded unreachable code: IL_00b7
			//IL_000d: Expected I4, but got O
			//IL_0020: Expected I4, but got O
			(int, int) tuple = default((int, int));
			int t = (int)((ValueTuple<, >*)(&tuple))->Item1;
			AddParameter(t, "currency_name");
			int t2 = (int)((ValueTuple<, >*)(&tuple))->Item1;
			AddParameter(t2, "currency_type");
			AddParameter(trans_name, "transaction_name");
			AddParameter(trans_type, "transaction_type");
			int t3 = 0;
			AddParameter(t3, "item_name");
			int t4 = 0;
			AddParameter(t4, "item_amount");
			AddParameter("N/A", "tle_event_name");
			AddParameter("N/A", "mini_event_name");
			if (clientData == null || clientData.location == null || "mini_event_name" == null)
			{
			}
			AddParameter("", "transcation_location");
			AddCommonParameters(clientData, balance: true);
			isHighPriority = true;
		}
	}
}
