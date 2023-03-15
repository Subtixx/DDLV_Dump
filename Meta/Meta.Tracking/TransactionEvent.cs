using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A72")]
	public class TransactionEvent : CommonBaseEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000F00")]
		private string TransactionName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A3C")]
			[Cpp2IlInjected.Address(RVA = "0x7A0630", Offset = "0x79F030", VA = "0x1807A0630")]
			set
			{
				AddParameter(value, "TransactionName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F01")]
		public string TransactionLocation
		{
			[Cpp2IlInjected.Token(Token = "0x6005A3D")]
			[Cpp2IlInjected.Address(RVA = "0x7A05D0", Offset = "0x79EFD0", VA = "0x1807A05D0")]
			set
			{
				AddParameter(value, "TransactionLocation");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F02")]
		public string TransactionType
		{
			[Cpp2IlInjected.Token(Token = "0x6005A3E")]
			[Cpp2IlInjected.Address(RVA = "0x7A0690", Offset = "0x79F090", VA = "0x1807A0690")]
			set
			{
				AddParameter(value, "TransactionType");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F03")]
		public object ProductsSpent
		{
			[Cpp2IlInjected.Token(Token = "0x6005A3F")]
			[Cpp2IlInjected.Address(RVA = "0x7A0450", Offset = "0x79EE50", VA = "0x1807A0450")]
			set
			{
				AddComplexParameter(value, "ProductsSpent");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F04")]
		public int RevenueValidated
		{
			[Cpp2IlInjected.Token(Token = "0x6005A40")]
			[Cpp2IlInjected.Address(RVA = "0x7A04B0", Offset = "0x79EEB0", VA = "0x1807A04B0")]
			set
			{
				AddParameter(value, "RevenueValidated");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F05")]
		public object ProductsReceived
		{
			[Cpp2IlInjected.Token(Token = "0x6005A41")]
			[Cpp2IlInjected.Address(RVA = "0x7A03F0", Offset = "0x79EDF0", VA = "0x1807A03F0")]
			set
			{
				AddComplexParameter(value, "ProductsReceived");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F06")]
		public string MiniEventID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A42")]
			[Cpp2IlInjected.Address(RVA = "0x7A0270", Offset = "0x79EC70", VA = "0x1807A0270")]
			set
			{
				AddParameter(value, "MiniEventID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F07")]
		public string MicroEventID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A43")]
			[Cpp2IlInjected.Address(RVA = "0x7A0210", Offset = "0x79EC10", VA = "0x1807A0210")]
			set
			{
				AddParameter(value, "MicroEventID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F08")]
		public string MissionID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A44")]
			[Cpp2IlInjected.Address(RVA = "0x7A02D0", Offset = "0x79ECD0", VA = "0x1807A02D0")]
			set
			{
				AddParameter(value, "MissionID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F09")]
		public string ObjectName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A45")]
			[Cpp2IlInjected.Address(RVA = "0x7A0390", Offset = "0x79ED90", VA = "0x1807A0390")]
			set
			{
				AddParameter(value, "ObjectName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F0A")]
		public string ObjectLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6005A46")]
			[Cpp2IlInjected.Address(RVA = "0x7A0330", Offset = "0x79ED30", VA = "0x1807A0330")]
			set
			{
				AddParameter(value, "ObjectLevel");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F0B")]
		public string EarningSource
		{
			[Cpp2IlInjected.Token(Token = "0x6005A47")]
			[Cpp2IlInjected.Address(RVA = "0x7A0030", Offset = "0x79EA30", VA = "0x1807A0030")]
			set
			{
				AddParameter(value, "EarningSource");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F0C")]
		public float BonusFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x6005A48")]
			[Cpp2IlInjected.Address(RVA = "0x79FE50", Offset = "0x79E850", VA = "0x18079FE50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F0D")]
		public float BonusFood
		{
			[Cpp2IlInjected.Token(Token = "0x6005A49")]
			[Cpp2IlInjected.Address(RVA = "0x79FDF0", Offset = "0x79E7F0", VA = "0x18079FDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F0E")]
		public float BonusMicroEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6005A4A")]
			[Cpp2IlInjected.Address(RVA = "0x79FEB0", Offset = "0x79E8B0", VA = "0x18079FEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F0F")]
		public int ItemsInBackpack
		{
			[Cpp2IlInjected.Token(Token = "0x6005A4B")]
			[Cpp2IlInjected.Address(RVA = "0x7A00F0", Offset = "0x79EAF0", VA = "0x1807A00F0")]
			set
			{
				AddParameter(value, "ItemsInBackpack");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F10")]
		public int ItemsInStorage
		{
			[Cpp2IlInjected.Token(Token = "0x6005A4C")]
			[Cpp2IlInjected.Address(RVA = "0x7A0150", Offset = "0x79EB50", VA = "0x1807A0150")]
			set
			{
				AddParameter(value, "ItemsInStorage");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F11")]
		public string AbGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6005A4D")]
			[Cpp2IlInjected.Address(RVA = "0x79FD90", Offset = "0x79E790", VA = "0x18079FD90")]
			set
			{
				AddParameter(value, "AbGroup");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F12")]
		public string MapLocation
		{
			[Cpp2IlInjected.Token(Token = "0x6005A4E")]
			[Cpp2IlInjected.Address(RVA = "0x7A01B0", Offset = "0x79EBB0", VA = "0x1807A01B0")]
			set
			{
				AddParameter(value, "MapLocation");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F13")]
		public string CharacterID
		{
			[Cpp2IlInjected.Token(Token = "0x6005A4F")]
			[Cpp2IlInjected.Address(RVA = "0x79FF10", Offset = "0x79E910", VA = "0x18079FF10")]
			set
			{
				AddParameter(value, "CharacterID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F14")]
		public string CharacterName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A50")]
			[Cpp2IlInjected.Address(RVA = "0x79FF70", Offset = "0x79E970", VA = "0x18079FF70")]
			set
			{
				AddParameter(value, "CharacterName");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F15")]
		public string CharacterProfession
		{
			[Cpp2IlInjected.Token(Token = "0x6005A51")]
			[Cpp2IlInjected.Address(RVA = "0x79FFD0", Offset = "0x79E9D0", VA = "0x18079FFD0")]
			set
			{
				AddParameter(value, "CharacterProfession");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F16")]
		public int StaminaGained
		{
			[Cpp2IlInjected.Token(Token = "0x6005A52")]
			[Cpp2IlInjected.Address(RVA = "0x7A0510", Offset = "0x79EF10", VA = "0x1807A0510")]
			set
			{
				AddParameter(value, "StaminaGained");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F17")]
		public int GainedBuff
		{
			[Cpp2IlInjected.Token(Token = "0x6005A53")]
			[Cpp2IlInjected.Address(RVA = "0x7A0090", Offset = "0x79EA90", VA = "0x1807A0090")]
			set
			{
				AddParameter(value, "GainedBuff");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F18")]
		public bool StarpathActive
		{
			[Cpp2IlInjected.Token(Token = "0x6005A54")]
			[Cpp2IlInjected.Address(RVA = "0x7A0570", Offset = "0x79EF70", VA = "0x1807A0570")]
			set
			{
				AddParameter(value, "StarpathActive");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F19")]
		public override string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6005A55")]
			[Cpp2IlInjected.Address(RVA = "0x79FD60", Offset = "0x79E760", VA = "0x18079FD60", Slot = "4")]
			get
			{
				return "transaction";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F1A")]
		protected override int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6005A56")]
			[Cpp2IlInjected.Address(RVA = "0x79FD00", Offset = "0x79E700", VA = "0x18079FD00", Slot = "5")]
			get
			{
				return TrackingEventBase.InvalidEventId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A3B")]
		[Cpp2IlInjected.Address(RVA = "0x79F900", Offset = "0x79E300", VA = "0x18079F900")]
		public TransactionEvent(string transactionName, ClientData clientData, Character hangingOutWithCharacter, int addToItemsInBP = 0, string transactionLocation = "")
		{
			//Discarded unreachable code: IL_010c
			//IL_001d: Expected I4, but got I8
			//IL_001d: Expected I4, but got I8
			AddParameter(transactionName, "TransactionName");
			int num = 0;
			ulong num2 = default(ulong);
			AddCommonParameters(clientData, (byte)num2 != 0, (byte)num2 != 0);
			if (clientData != null)
			{
				Profile profile = clientData.profile;
				if (profile != null)
				{
					ContainerInventory backpack = profile.Backpack;
					if (backpack != null)
					{
						int numberOfItems = backpack.NumberOfItems;
					}
				}
				if (num == 0)
				{
				}
			}
			AddParameter(num, "ItemsInBackpack");
			if (clientData != null)
			{
				Profile profile2 = clientData.profile;
				if (profile2 != null)
				{
					ContainerInventory homeStorage = profile2.HomeStorage;
					if (homeStorage != null)
					{
						int numberOfItems2 = homeStorage.NumberOfItems;
					}
				}
			}
			AddParameter(num, "ItemsInStorage");
			if (clientData == null || clientData.location != null)
			{
			}
			string t = default(string);
			AddParameter(t, "TransactionLocation");
			if (clientData == null || clientData.location == null || "TransactionLocation" == null)
			{
			}
			AddParameter("", "MapLocation");
			if (hangingOutWithCharacter != null)
			{
				string name_ = hangingOutWithCharacter.Data.name_;
				AddParameter(name_, "CharacterName");
				ProfessionItemData profession = hangingOutWithCharacter.Profession;
				string empty = default(string);
				if (profession == null || profession.name_ == null)
				{
					empty = string.Empty;
				}
				AddParameter(empty, "CharacterProfession");
			}
		}
	}
}
