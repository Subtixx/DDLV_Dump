using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A6C")]
	public sealed class AgeGateEvent : GLTrackingCommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000EDC")]
		public static string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6005A11")]
			[Cpp2IlInjected.Address(RVA = "0x18E6A00", Offset = "0x18E5400", VA = "0x1818E6A00")]
			get
			{
				return "userDemographicsInfo";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EDD")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A12")]
			[Cpp2IlInjected.Address(RVA = "0x18E6A00", Offset = "0x18E5400", VA = "0x1818E6A00", Slot = "4")]
			get
			{
				return "userDemographicsInfo";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EDE")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005A13")]
			[Cpp2IlInjected.Address(RVA = "0x18E69F0", Offset = "0x18E53F0", VA = "0x1818E69F0", Slot = "5")]
			get
			{
				return 187101;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EDF")]
		protected override DispatchMode EventDispatchMode
		{
			[Cpp2IlInjected.Token(Token = "0x6005A14")]
			[Cpp2IlInjected.Address(RVA = "0x7BA030", Offset = "0x7B8A30", VA = "0x1807BA030", Slot = "6")]
			get
			{
				return DispatchMode.WhenShouldTrack;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE0")]
		public int User_age
		{
			[Cpp2IlInjected.Token(Token = "0x6005A15")]
			[Cpp2IlInjected.Address(RVA = "0x18E6A30", Offset = "0x18E5430", VA = "0x1818E6A30")]
			set
			{
				AddParameter(value, "User_age");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE1")]
		public int User_gender
		{
			[Cpp2IlInjected.Token(Token = "0x6005A16")]
			[Cpp2IlInjected.Address(RVA = "0x18E6A90", Offset = "0x18E5490", VA = "0x1818E6A90")]
			set
			{
				AddParameter(value, "User_gender");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A10")]
		[Cpp2IlInjected.Address(RVA = "0x18E6990", Offset = "0x18E5390", VA = "0x1818E6990")]
		public AgeGateEvent(ClientData client)
		{
			AddParameter(214607, "User_gender");
		}
	}
}
