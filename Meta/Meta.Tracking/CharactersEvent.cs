using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A77")]
	public class CharactersEvent : CommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000F36")]
		public string CharacterName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A77")]
			[Cpp2IlInjected.Address(RVA = "0x725480", Offset = "0x723E80", VA = "0x180725480")]
			set
			{
				AddParameter(value, "CharacterName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F37")]
		public string CharacterID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A78")]
			[Cpp2IlInjected.Address(RVA = "0x725420", Offset = "0x723E20", VA = "0x180725420")]
			set
			{
				AddParameter(value, "CharacterID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F38")]
		public string CharacterRealm
		{
			[Cpp2IlInjected.Token(Token = "0x6005A79")]
			[Cpp2IlInjected.Address(RVA = "0x725540", Offset = "0x723F40", VA = "0x180725540")]
			set
			{
				AddParameter(value, "CharacterRealm");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F39")]
		public string CharacterState
		{
			[Cpp2IlInjected.Token(Token = "0x6005A7A")]
			[Cpp2IlInjected.Address(RVA = "0x7255A0", Offset = "0x723FA0", VA = "0x1807255A0")]
			set
			{
				AddParameter(value, "CharacterState");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F3A")]
		public int FriendshipLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6005A7B")]
			[Cpp2IlInjected.Address(RVA = "0x725600", Offset = "0x724000", VA = "0x180725600")]
			set
			{
				AddParameter(value, "FriendshipLevel");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F3B")]
		public string CharacterProfession
		{
			[Cpp2IlInjected.Token(Token = "0x6005A7C")]
			[Cpp2IlInjected.Address(RVA = "0x7254E0", Offset = "0x723EE0", VA = "0x1807254E0")]
			set
			{
				AddParameter(value, "CharacterProfession");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F3C")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A7D")]
			[Cpp2IlInjected.Address(RVA = "0x7253F0", Offset = "0x723DF0", VA = "0x1807253F0", Slot = "4")]
			get
			{
				return "characters";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F3D")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005A7E")]
			[Cpp2IlInjected.Address(RVA = "0x725390", Offset = "0x723D90", VA = "0x180725390", Slot = "5")]
			get
			{
				return TrackingEventBase.InvalidEventId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A76")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA90", Offset = "0x5BB490", VA = "0x1805BCA90")]
		public CharactersEvent(ClientData clientData)
		{
			AddCommonParameters(clientData, currencyBalance: true);
		}
	}
}
