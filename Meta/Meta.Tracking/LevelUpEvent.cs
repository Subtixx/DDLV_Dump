using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A73")]
	public class LevelUpEvent : CommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000F1B")]
		public string LevelUpName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A58")]
			[Cpp2IlInjected.Address(RVA = "0x18A1FF0", Offset = "0x18A09F0", VA = "0x1818A1FF0")]
			set
			{
				AddParameter(value, "LevelUpName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F1C")]
		public string ObjectName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A59")]
			[Cpp2IlInjected.Address(RVA = "0x18A2050", Offset = "0x18A0A50", VA = "0x1818A2050")]
			set
			{
				AddParameter(value, "ObjectName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F1D")]
		public string CharacterName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A5A")]
			[Cpp2IlInjected.Address(RVA = "0x18A1ED0", Offset = "0x18A08D0", VA = "0x1818A1ED0")]
			set
			{
				AddParameter(value, "CharacterName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F1E")]
		public int FriendshipLevelBefore
		{
			[Cpp2IlInjected.Token(Token = "0x6005A5B")]
			[Cpp2IlInjected.Address(RVA = "0x18A1F90", Offset = "0x18A0990", VA = "0x1818A1F90")]
			set
			{
				AddParameter(value, "FriendshipLevelBefore");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F1F")]
		public int FriendshipLevelAfter
		{
			[Cpp2IlInjected.Token(Token = "0x6005A5C")]
			[Cpp2IlInjected.Address(RVA = "0x18A1F30", Offset = "0x18A0930", VA = "0x1818A1F30")]
			set
			{
				AddParameter(value, "FriendshipLevelAfter");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F20")]
		public int UserLevelBefore
		{
			[Cpp2IlInjected.Token(Token = "0x6005A5D")]
			[Cpp2IlInjected.Address(RVA = "0x18A21D0", Offset = "0x18A0BD0", VA = "0x1818A21D0")]
			set
			{
				AddParameter(value, "UserLevelBefore");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F21")]
		public int UserLevelAfter
		{
			[Cpp2IlInjected.Token(Token = "0x6005A5E")]
			[Cpp2IlInjected.Address(RVA = "0x18A2170", Offset = "0x18A0B70", VA = "0x1818A2170")]
			set
			{
				AddParameter(value, "UserLevelAfter");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F22")]
		public string SourceOfXP
		{
			[Cpp2IlInjected.Token(Token = "0x6005A5F")]
			[Cpp2IlInjected.Address(RVA = "0x18A2110", Offset = "0x18A0B10", VA = "0x1818A2110")]
			set
			{
				AddParameter(value, "SourceOfXP");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F23")]
		public object Reward
		{
			[Cpp2IlInjected.Token(Token = "0x6005A60")]
			[Cpp2IlInjected.Address(RVA = "0x18A20B0", Offset = "0x18A0AB0", VA = "0x1818A20B0")]
			set
			{
				AddComplexParameter(value, "Reward");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F24")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A61")]
			[Cpp2IlInjected.Address(RVA = "0x18A1EA0", Offset = "0x18A08A0", VA = "0x1818A1EA0", Slot = "4")]
			get
			{
				return "levelUp";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F25")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005A62")]
			[Cpp2IlInjected.Address(RVA = "0x18A1E40", Offset = "0x18A0840", VA = "0x1818A1E40", Slot = "5")]
			get
			{
				return TrackingEventBase.InvalidEventId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A57")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA90", Offset = "0x5BB490", VA = "0x1805BCA90")]
		public LevelUpEvent(ClientData clientData)
		{
			AddCommonParameters(clientData, currencyBalance: true);
		}
	}
}
