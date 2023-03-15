using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A6B")]
	public sealed class FoundersPackEvent : GLTrackingCommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000ED6")]
		public static string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6005A0A")]
			[Cpp2IlInjected.Address(RVA = "0x1808320", Offset = "0x1806D20", VA = "0x181808320")]
			get
			{
				return "foundersPack";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ED7")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A0B")]
			[Cpp2IlInjected.Address(RVA = "0x1808320", Offset = "0x1806D20", VA = "0x181808320", Slot = "4")]
			get
			{
				return "foundersPack";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ED8")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005A0C")]
			[Cpp2IlInjected.Address(RVA = "0x1808310", Offset = "0x1806D10", VA = "0x181808310", Slot = "5")]
			get
			{
				return 423174;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ED9")]
		protected override DispatchMode EventDispatchMode
		{
			[Cpp2IlInjected.Token(Token = "0x6005A0D")]
			[Cpp2IlInjected.Address(RVA = "0x7BA030", Offset = "0x7B8A30", VA = "0x1807BA030", Slot = "6")]
			get
			{
				return DispatchMode.WhenShouldTrack;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EDA")]
		public string Founder_pack_type
		{
			[Cpp2IlInjected.Token(Token = "0x6005A0E")]
			[Cpp2IlInjected.Address(RVA = "0x1808350", Offset = "0x1806D50", VA = "0x181808350")]
			set
			{
				AddParameter(value, "Founder_pack_type");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EDB")]
		public string Playfab_id
		{
			[Cpp2IlInjected.Token(Token = "0x6005A0F")]
			[Cpp2IlInjected.Address(RVA = "0x18083B0", Offset = "0x1806DB0", VA = "0x1818083B0")]
			set
			{
				AddParameter(value, "Playfab_id");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A09")]
		[Cpp2IlInjected.Address(RVA = "0x1808290", Offset = "0x1806C90", VA = "0x181808290")]
		public FoundersPackEvent(ClientData clientData)
		{
			int balance = 0;
			AddCommonParameters(clientData, (byte)balance != 0);
			isHighPriority = true;
		}
	}
}
