using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003E2")]
	public sealed class NpcDiscussionItemData : IMessage<NpcDiscussionItemData>, IMessage, IEquatable<NpcDiscussionItemData>, IDeepCloneable<NpcDiscussionItemData>, IMessageFieldAccessor, IDialogueItemData, IItemData, IUpdateVersion, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40014D4")]
		private static readonly MessageParser<NpcDiscussionItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40014D5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40014D6")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40014D7")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x40014D8")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40014D9")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x40014DA")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40014DB")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40014DC")]
		public const int Character1ItemIDFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40014DD")]
		private int character1ItemID_;

		[Cpp2IlInjected.Token(Token = "0x40014DE")]
		public const int Character2ItemIDFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40014DF")]
		private int character2ItemID_;

		[Cpp2IlInjected.Token(Token = "0x40014E0")]
		public const int IconAddressFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40014E1")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40014E2")]
		public const int PrefabAddressFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40014E3")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40014E4")]
		public const int DialogueAssetAddressFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40014E5")]
		private string dialogueAssetAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40014E6")]
		public const int PreviousDiscussionIDFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40014E7")]
		private int previousDiscussionID_;

		[Cpp2IlInjected.Token(Token = "0x40014E8")]
		public const int SeasonFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40014E9")]
		private Season season_;

		[Cpp2IlInjected.Token(Token = "0x40014EA")]
		public const int TimeOfDayFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40014EB")]
		private string timeOfDay_ = "";

		[Cpp2IlInjected.Token(Token = "0x40014EC")]
		public const int ScheduleFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40014ED")]
		private ScheduleType schedule_;

		[Cpp2IlInjected.Token(Token = "0x40014EE")]
		public const int LocationFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40014EF")]
		private CharacterLocation location_;

		[Cpp2IlInjected.Token(Token = "0x40014F0")]
		public const int SpecificWeatherFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40014F1")]
		private bool specificWeather_;

		[Cpp2IlInjected.Token(Token = "0x40014F2")]
		public const int WeathersFieldNumber = 15;

		[Cpp2IlInjected.Token(Token = "0x40014F3")]
		private static readonly FieldCodec<string> _repeated_weathers_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40014F4")]
		private readonly RepeatedField<string> weathers_ = (RepeatedField<string>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40014F5")]
		public const int NecessaryCharactersInVillageFieldNumber = 16;

		[Cpp2IlInjected.Token(Token = "0x40014F6")]
		private static readonly FieldCodec<int> _repeated_necessaryCharactersInVillage_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40014F7")]
		private readonly RepeatedField<int> necessaryCharactersInVillage_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40014F8")]
		public const int OnlyFromMissionFieldNumber = 17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40014F9")]
		private bool onlyFromMission_;

		[Cpp2IlInjected.Token(Token = "0x40014FA")]
		public const int ConditionsFieldNumber = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40014FB")]
		private ConditionsList conditions_;

		[Cpp2IlInjected.Token(Token = "0x40014FC")]
		public const int UpdateVersionFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40014FD")]
		private string updateVersion_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000BE6")]
		[DebuggerNonUserCode]
		public static MessageParser<NpcDiscussionItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002ED8")]
			[Cpp2IlInjected.Address(RVA = "0x29F84A0", Offset = "0x29F6EA0", VA = "0x1829F84A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BE7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002ED9")]
			[Cpp2IlInjected.Address(RVA = "0x29F83D0", Offset = "0x29F6DD0", VA = "0x1829F83D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BE8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002EDA")]
			[Cpp2IlInjected.Address(RVA = "0x29F8500", Offset = "0x29F6F00", VA = "0x1829F8500", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BE9")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002EDF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "25")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EE0")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BEA")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002EE1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "27")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EE2")]
			[Cpp2IlInjected.Address(RVA = "0x29F8760", Offset = "0x29F7160", VA = "0x1829F8760")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BEB")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002EE3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "28")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EE4")]
			[Cpp2IlInjected.Address(RVA = "0x29F8680", Offset = "0x29F7080", VA = "0x1829F8680")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BEC")]
		[DebuggerNonUserCode]
		public int Character1ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6002EE5")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return character1ItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EE6")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				character1ItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BED")]
		[DebuggerNonUserCode]
		public int Character2ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6002EE7")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return character2ItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EE8")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				character2ItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BEE")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002EE9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "29")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EEA")]
			[Cpp2IlInjected.Address(RVA = "0x29F86F0", Offset = "0x29F70F0", VA = "0x1829F86F0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BEF")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002EEB")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "30")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EEC")]
			[Cpp2IlInjected.Address(RVA = "0x29F87D0", Offset = "0x29F71D0", VA = "0x1829F87D0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BF0")]
		[DebuggerNonUserCode]
		public string DialogueAssetAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002EED")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "14")]
			get
			{
				return dialogueAssetAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EEE")]
			[Cpp2IlInjected.Address(RVA = "0x29F8610", Offset = "0x29F7010", VA = "0x1829F8610")]
			set
			{
				string text = (dialogueAssetAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BF1")]
		[DebuggerNonUserCode]
		public int PreviousDiscussionID
		{
			[Cpp2IlInjected.Token(Token = "0x6002EEF")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return previousDiscussionID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EF0")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				previousDiscussionID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BF2")]
		[DebuggerNonUserCode]
		public Season Season
		{
			[Cpp2IlInjected.Token(Token = "0x6002EF1")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830", Slot = "17")]
			get
			{
				return season_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EF2")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				season_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BF3")]
		[DebuggerNonUserCode]
		public string TimeOfDay
		{
			[Cpp2IlInjected.Token(Token = "0x6002EF3")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0", Slot = "18")]
			get
			{
				return timeOfDay_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EF4")]
			[Cpp2IlInjected.Address(RVA = "0x29F8840", Offset = "0x29F7240", VA = "0x1829F8840")]
			set
			{
				string text = (timeOfDay_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BF4")]
		[DebuggerNonUserCode]
		public ScheduleType Schedule
		{
			[Cpp2IlInjected.Token(Token = "0x6002EF5")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750", Slot = "19")]
			get
			{
				return schedule_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EF6")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				schedule_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BF5")]
		[DebuggerNonUserCode]
		public CharacterLocation Location
		{
			[Cpp2IlInjected.Token(Token = "0x6002EF7")]
			[Cpp2IlInjected.Address(RVA = "0x1811A30", Offset = "0x1810430", VA = "0x181811A30", Slot = "20")]
			get
			{
				return location_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EF8")]
			[Cpp2IlInjected.Address(RVA = "0x1811B80", Offset = "0x1810580", VA = "0x181811B80")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BF6")]
		[DebuggerNonUserCode]
		public bool SpecificWeather
		{
			[Cpp2IlInjected.Token(Token = "0x6002EF9")]
			[Cpp2IlInjected.Address(RVA = "0xFB01D0", Offset = "0xFAEBD0", VA = "0x180FB01D0", Slot = "21")]
			get
			{
				return specificWeather_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EFA")]
			[Cpp2IlInjected.Address(RVA = "0xFB0200", Offset = "0xFAEC00", VA = "0x180FB0200")]
			set
			{
				specificWeather_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BF7")]
		[DebuggerNonUserCode]
		public RepeatedField<string> Weathers
		{
			[Cpp2IlInjected.Token(Token = "0x6002EFB")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0", Slot = "22")]
			get
			{
				return weathers_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BF8")]
		[DebuggerNonUserCode]
		public RepeatedField<int> NecessaryCharactersInVillage
		{
			[Cpp2IlInjected.Token(Token = "0x6002EFC")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640", Slot = "23")]
			get
			{
				return necessaryCharactersInVillage_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BF9")]
		[DebuggerNonUserCode]
		public bool OnlyFromMission
		{
			[Cpp2IlInjected.Token(Token = "0x6002EFD")]
			[Cpp2IlInjected.Address(RVA = "0x725070", Offset = "0x723A70", VA = "0x180725070")]
			get
			{
				return onlyFromMission_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EFE")]
			[Cpp2IlInjected.Address(RVA = "0x725360", Offset = "0x723D60", VA = "0x180725360")]
			set
			{
				onlyFromMission_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BFA")]
		[DebuggerNonUserCode]
		public ConditionsList Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x6002EFF")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80", Slot = "24")]
			get
			{
				return conditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F00")]
			[Cpp2IlInjected.Address(RVA = "0x7DB490", Offset = "0x7D9E90", VA = "0x1807DB490")]
			set
			{
				conditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BFB")]
		[DebuggerNonUserCode]
		public string UpdateVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6002F01")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0", Slot = "32")]
			get
			{
				return updateVersion_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F02")]
			[Cpp2IlInjected.Address(RVA = "0x29F88B0", Offset = "0x29F72B0", VA = "0x1829F88B0", Slot = "33")]
			set
			{
				string text = (updateVersion_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BFC")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002F0E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "26")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BFD")]
		public Item Character1Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002F0F")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				int num = character1ItemID_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BFE")]
		public Item Character2Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002F10")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				int num = character2ItemID_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BFF")]
		public Item PreviousDiscussion
		{
			[Cpp2IlInjected.Token(Token = "0x6002F11")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950", Slot = "16")]
			get
			{
				int num = previousDiscussionID_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C00")]
		Item IDialogueItemData.CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002F12")]
			[Cpp2IlInjected.Address(RVA = "0x29F6440", Offset = "0x29F4E40", VA = "0x1829F6440", Slot = "15")]
			get
			{
				return Item.Invalid;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EDB")]
		[Cpp2IlInjected.Address(RVA = "0x29F8230", Offset = "0x29F6C30", VA = "0x1829F8230")]
		[DebuggerNonUserCode]
		public NpcDiscussionItemData()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EDC")]
		[Cpp2IlInjected.Address(RVA = "0x29F7260", Offset = "0x29F5C60", VA = "0x1829F7260")]
		private void OnConstruction()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EDD")]
		[Cpp2IlInjected.Address(RVA = "0x29F7ED0", Offset = "0x29F68D0", VA = "0x1829F7ED0")]
		[DebuggerNonUserCode]
		public NpcDiscussionItemData(NpcDiscussionItemData other)
		{
			//IL_01b3: Expected O, but got I4
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			int num2 = (character1ItemID_ = other.character1ItemID_);
			int num3 = (character2ItemID_ = other.character2ItemID_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			string text5 = (dialogueAssetAddress_ = other.dialogueAssetAddress_);
			int num4 = (previousDiscussionID_ = other.previousDiscussionID_);
			Season season = (season_ = other.season_);
			string text6 = (timeOfDay_ = other.timeOfDay_);
			ScheduleType scheduleType = (schedule_ = other.schedule_);
			CharacterLocation characterLocation = (location_ = other.location_);
			bool flag = (specificWeather_ = other.specificWeather_);
			RepeatedField<string> repeatedField = (weathers_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)other.weathers_).Clone());
			RepeatedField<int> repeatedField2 = (necessaryCharactersInVillage_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.necessaryCharactersInVillage_).Clone());
			bool flag2 = (onlyFromMission_ = other.onlyFromMission_);
			ConditionsList conditionsList2 = other.conditions_;
			if (conditionsList2 != null)
			{
				ConditionsList conditionsList3 = conditionsList2.Clone();
			}
			int num5 = 0;
			conditions_ = (ConditionsList)num5;
			string text7 = (updateVersion_ = other.updateVersion_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EDE")]
		[Cpp2IlInjected.Address(RVA = "0x29F62A0", Offset = "0x29F4CA0", VA = "0x1829F62A0", Slot = "10")]
		[DebuggerNonUserCode]
		public NpcDiscussionItemData Clone()
		{
			return new NpcDiscussionItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F03")]
		[Cpp2IlInjected.Address(RVA = "0x29F64A0", Offset = "0x29F4EA0", VA = "0x1829F64A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((NpcDiscussionItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F04")]
		[Cpp2IlInjected.Address(RVA = "0x29F6500", Offset = "0x29F4F00", VA = "0x1829F6500", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(NpcDiscussionItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							int num2 = other.character1ItemID_;
							if (character1ItemID_ == num2)
							{
								int num3 = other.character2ItemID_;
								if (character2ItemID_ == num3)
								{
									string text3 = other.iconAddress_;
									if (!(iconAddress_ != text3))
									{
										string text4 = other.prefabAddress_;
										if (!(prefabAddress_ != text4))
										{
											string text5 = other.dialogueAssetAddress_;
											if (!(dialogueAssetAddress_ != text5))
											{
												int num4 = other.previousDiscussionID_;
												if (previousDiscussionID_ == num4)
												{
													Season season = other.season_;
													if (season_ == season)
													{
														string text6 = other.timeOfDay_;
														if (!(timeOfDay_ != text6))
														{
															ScheduleType scheduleType = other.schedule_;
															if (schedule_ == scheduleType)
															{
																CharacterLocation characterLocation = other.location_;
																if (location_ == characterLocation)
																{
																	bool flag = other.specificWeather_;
																	if (specificWeather_ == flag)
																	{
																		RepeatedField<string> repeatedField = weathers_;
																		RepeatedField<string> repeatedField2 = other.weathers_;
																		if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
																		{
																			RepeatedField<int> repeatedField3 = necessaryCharactersInVillage_;
																			RepeatedField<int> repeatedField4 = other.necessaryCharactersInVillage_;
																			if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
																			{
																				bool flag2 = other.onlyFromMission_;
																				if (onlyFromMission_ == flag2)
																				{
																					ConditionsList objB = other.conditions_;
																					if (object.Equals(conditions_, objB))
																					{
																						string text7 = other.updateVersion_;
																						if (!(updateVersion_ != text7))
																						{
																							UnknownFieldSet unknownFields = other._unknownFields;
																							return object.Equals(_unknownFields, unknownFields);
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F05")]
		[Cpp2IlInjected.Address(RVA = "0x29F6970", Offset = "0x29F5370", VA = "0x1829F6970", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0156
			int num = 0;
			if (iD_ != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			if (character1ItemID_ != 0)
			{
			}
			if (character2ItemID_ != 0)
			{
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			string text5 = dialogueAssetAddress_;
			if (text5.m_stringLength != 0)
			{
				int hashCode5 = text5.GetHashCode();
			}
			if (previousDiscussionID_ != 0)
			{
			}
			if (season_ != 0)
			{
			}
			string text6 = timeOfDay_;
			if (text6.m_stringLength != 0)
			{
				int hashCode6 = text6.GetHashCode();
			}
			if (schedule_ != 0)
			{
			}
			if (location_ != 0)
			{
			}
			if (specificWeather_)
			{
			}
			int hashCode7 = ((RepeatedField<T>)(object)weathers_).GetHashCode();
			int hashCode8 = ((RepeatedField<T>)(object)necessaryCharactersInVillage_).GetHashCode();
			if (onlyFromMission_)
			{
			}
			ConditionsList conditionsList = conditions_;
			if (conditionsList != null)
			{
				int hashCode9 = conditionsList.GetHashCode();
			}
			string text7 = updateVersion_;
			if (text7.m_stringLength != 0)
			{
				int hashCode10 = text7.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode11 = unknownFields.GetHashCode();
			}
			return hashCode8;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F06")]
		[Cpp2IlInjected.Address(RVA = "0x29F78D0", Offset = "0x29F62D0", VA = "0x1829F78D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F07")]
		[Cpp2IlInjected.Address(RVA = "0x29F7930", Offset = "0x29F6330", VA = "0x1829F7930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_01de
			if (iD_ != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (character1ItemID_ != 0)
			{
				int value4 = character1ItemID_;
				output.WriteInt32(value4);
			}
			if (character2ItemID_ != 0)
			{
				int value5 = character2ItemID_;
				output.WriteInt32(value5);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value6 = iconAddress_;
				output.WriteString(value6);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value7 = prefabAddress_;
				output.WriteString(value7);
			}
			if (dialogueAssetAddress_.m_stringLength != 0)
			{
				string value8 = dialogueAssetAddress_;
				output.WriteString(value8);
			}
			if (previousDiscussionID_ != 0)
			{
				int value9 = previousDiscussionID_;
				output.WriteInt32(value9);
			}
			if (season_ != 0)
			{
			}
			if (timeOfDay_.m_stringLength != 0)
			{
				string value10 = timeOfDay_;
				output.WriteString(value10);
			}
			if (schedule_ != 0)
			{
			}
			if (location_ != 0)
			{
			}
			if (specificWeather_)
			{
				bool value11 = specificWeather_;
				output.WriteBool(value11);
			}
			RepeatedField<string> repeatedField = weathers_;
			FieldCodec<string> repeated_weathers_codec = _repeated_weathers_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_weathers_codec);
			RepeatedField<int> repeatedField2 = necessaryCharactersInVillage_;
			FieldCodec<int> repeated_necessaryCharactersInVillage_codec = _repeated_necessaryCharactersInVillage_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_necessaryCharactersInVillage_codec);
			if (onlyFromMission_)
			{
				bool value12 = onlyFromMission_;
				output.WriteBool(value12);
			}
			if ((long)conditions_ != 0)
			{
				ConditionsList value13 = conditions_;
				output.WriteMessage(value13);
			}
			if (updateVersion_.m_stringLength != 0)
			{
				string value14 = updateVersion_;
				output.WriteString(value14);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F08")]
		[Cpp2IlInjected.Address(RVA = "0x29F5BD0", Offset = "0x29F45D0", VA = "0x1829F5BD0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_020f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Expected O, but got Unknown
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Expected O, but got Unknown
			//IL_0254: Unknown result type (might be due to invalid IL or missing references)
			//IL_0257: Expected O, but got Unknown
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			int num6 = character1ItemID_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num2 += num7;
			}
			int num8 = character2ItemID_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num2 += num9;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num10 = CodedOutputStream.ComputeStringSize(text3);
				num10++;
				num2 += num10;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num11 = CodedOutputStream.ComputeStringSize(text4);
				num11++;
				num2 += num11;
			}
			string text5 = dialogueAssetAddress_;
			if (text5.m_stringLength != 0)
			{
				int num12 = CodedOutputStream.ComputeStringSize(text5);
				num12++;
				num2 += num12;
			}
			int num13 = previousDiscussionID_;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeInt32Size(num13);
				num14++;
				num2 += num14;
			}
			Season season = season_;
			if (season != 0)
			{
				int num15 = CodedOutputStream.ComputeEnumSize((int)season);
				num15++;
				num2 += num15;
			}
			string text6 = timeOfDay_;
			if (text6.m_stringLength != 0)
			{
				int num16 = CodedOutputStream.ComputeStringSize(text6);
				num16++;
				num2 += num16;
			}
			ScheduleType scheduleType = schedule_;
			if (scheduleType != 0)
			{
				int num17 = CodedOutputStream.ComputeEnumSize((int)scheduleType);
				num17++;
				num2 += num17;
			}
			CharacterLocation characterLocation = location_;
			if (characterLocation != 0)
			{
				int num18 = CodedOutputStream.ComputeEnumSize((int)characterLocation);
				num18++;
				num2 += num18;
			}
			RepeatedField<string> repeatedField = weathers_;
			FieldCodec<string> repeated_weathers_codec = _repeated_weathers_codec;
			int num19 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_weathers_codec);
			RepeatedField<int> repeatedField2 = necessaryCharactersInVillage_;
			FieldCodec<int> repeated_necessaryCharactersInVillage_codec = _repeated_necessaryCharactersInVillage_codec;
			int num20 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_necessaryCharactersInVillage_codec);
			ConditionsList conditionsList = conditions_;
			if (conditionsList != null)
			{
				int num21 = CodedOutputStream.ComputeMessageSize(conditionsList);
				num21 += 2;
				repeatedField2 = (RepeatedField<int>)(repeatedField2 + num21);
			}
			string text7 = updateVersion_;
			if (text7.m_stringLength != 0)
			{
				int num22 = CodedOutputStream.ComputeStringSize(text7);
				num22 += 2;
				repeatedField2 = (RepeatedField<int>)(repeatedField2 + num22);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num23 = unknownFields.CalculateSize();
				repeatedField2 = (RepeatedField<int>)(repeatedField2 + num23);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F09")]
		[Cpp2IlInjected.Address(RVA = "0x29F7000", Offset = "0x29F5A00", VA = "0x1829F7000", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(NpcDiscussionItemData other)
		{
			//Discarded unreachable code: IL_01fc
			if (other == null)
			{
				return;
			}
			int num = other.iD_;
			if (num != 0)
			{
				iD_ = num;
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			string text2 = other.displayName_;
			if (text2.m_stringLength != 0)
			{
				DisplayName = text2;
			}
			int num2 = other.character1ItemID_;
			if (num2 != 0)
			{
				character1ItemID_ = num2;
			}
			int num3 = other.character2ItemID_;
			if (num3 != 0)
			{
				character2ItemID_ = num3;
			}
			string text3 = other.iconAddress_;
			if (text3.m_stringLength != 0)
			{
				IconAddress = text3;
			}
			string text4 = other.prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				PrefabAddress = text4;
			}
			string text5 = other.dialogueAssetAddress_;
			if (text5.m_stringLength != 0)
			{
				DialogueAssetAddress = text5;
			}
			int num4 = other.previousDiscussionID_;
			if (num4 != 0)
			{
				previousDiscussionID_ = num4;
			}
			Season season = other.season_;
			if (season != 0)
			{
				season_ = season;
			}
			string text6 = other.timeOfDay_;
			if (text6.m_stringLength != 0)
			{
				TimeOfDay = text6;
			}
			ScheduleType scheduleType = other.schedule_;
			if (scheduleType != 0)
			{
				schedule_ = scheduleType;
			}
			CharacterLocation characterLocation = other.location_;
			if (characterLocation != 0)
			{
				location_ = characterLocation;
			}
			bool flag = other.specificWeather_;
			if (flag)
			{
				specificWeather_ = flag;
			}
			RepeatedField<string> repeatedField = weathers_;
			RepeatedField<string> repeatedField2 = other.weathers_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			RepeatedField<int> repeatedField3 = necessaryCharactersInVillage_;
			RepeatedField<int> repeatedField4 = other.necessaryCharactersInVillage_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			bool flag2 = other.onlyFromMission_;
			if (flag2)
			{
				onlyFromMission_ = flag2;
			}
			if ((long)other.conditions_ != 0)
			{
				ConditionsList conditionsList2 = default(ConditionsList);
				if (conditions_ == null)
				{
					ConditionsList conditionsList = (conditions_ = new ConditionsList());
					conditionsList2 = conditions_;
				}
				ConditionsList other2 = other.conditions_;
				conditionsList2.MergeFrom(other2);
			}
			string text7 = other.updateVersion_;
			if (text7.m_stringLength != 0)
			{
				UpdateVersion = text7;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002F0A")]
		[Cpp2IlInjected.Address(RVA = "0x29F6C20", Offset = "0x29F5620", VA = "0x1829F6C20", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_024d
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 80)
			{
				if ((int)num > 122)
				{
					if ((int)num > 130)
					{
						if (num == 136)
						{
							bool flag = (onlyFromMission_ = input.ReadBool());
						}
						ConditionsList conditionsList = default(ConditionsList);
						if (num == 146)
						{
							ConditionsList builder = default(ConditionsList);
							if (conditions_ == null)
							{
								conditionsList = (conditions_ = new ConditionsList());
								builder = conditions_;
							}
							input.ReadMessage(builder);
						}
						if ((long)conditionsList != 162)
						{
							goto IL_0236;
						}
						string text2 = (UpdateVersion = input.ReadString());
					}
					num += 4294967168u;
					if (num != 4294967293u)
					{
						goto IL_0236;
					}
					RepeatedField<int> repeatedField = necessaryCharactersInVillage_;
					FieldCodec<int> repeated_necessaryCharactersInVillage_codec = _repeated_necessaryCharactersInVillage_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_necessaryCharactersInVillage_codec);
				}
				bool flag2 = default(bool);
				if ((int)num > 96)
				{
					int num2 = default(int);
					if (num == 104)
					{
						num2 = (int)(location_ = (CharacterLocation)input.ReadInt32());
					}
					if (num2 == 112)
					{
						flag2 = (specificWeather_ = input.ReadBool());
					}
					if (!flag2)
					{
						goto IL_0236;
					}
					RepeatedField<string> repeatedField2 = weathers_;
					FieldCodec<string> repeated_weathers_codec = _repeated_weathers_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_weathers_codec);
				}
				string text4 = default(string);
				if (flag2)
				{
					text4 = (TimeOfDay = input.ReadString());
				}
				if ((long)text4 != 96)
				{
					goto IL_0236;
				}
				int num3 = (int)(schedule_ = (ScheduleType)input.ReadInt32());
			}
			string text10 = default(string);
			if ((int)num > 40)
			{
				int num5 = default(int);
				if ((int)num > 58)
				{
					string text6 = default(string);
					if (num == 66)
					{
						text6 = (DialogueAssetAddress = input.ReadString());
					}
					int num4 = default(int);
					if ((long)text6 == 72)
					{
						num4 = (previousDiscussionID_ = input.ReadInt32());
					}
					if (num4 != 80)
					{
						goto IL_0236;
					}
					num5 = (int)(season_ = (Season)input.ReadInt32());
				}
				string text8 = default(string);
				if (num5 == 50)
				{
					text8 = (IconAddress = input.ReadString());
				}
				if ((long)text8 != 58)
				{
					goto IL_0236;
				}
				text10 = (PrefabAddress = input.ReadString());
			}
			int num7 = default(int);
			if ((long)text10 > 18)
			{
				string text12 = default(string);
				if ((long)text10 == 26)
				{
					text12 = (DisplayName = input.ReadString());
				}
				int num6 = default(int);
				if ((long)text12 == 32)
				{
					num6 = (character1ItemID_ = input.ReadInt32());
				}
				if (num6 != 40)
				{
					goto IL_0236;
				}
				num7 = (character2ItemID_ = input.ReadInt32());
			}
			int num8 = default(int);
			if (num7 == 8)
			{
				num8 = (iD_ = input.ReadInt32());
			}
			if (num8 == 18)
			{
				string text14 = (Name = input.ReadString());
			}
			goto IL_0236;
			IL_0236:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002F0B")]
		[Cpp2IlInjected.Address(RVA = "0x29F6700", Offset = "0x29F5100", VA = "0x1829F6700", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 19)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F0C")]
		[Cpp2IlInjected.Address(RVA = "0x29F72C0", Offset = "0x29F5CC0", VA = "0x1829F72C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_001e, IL_0026, IL_002e, IL_002f, IL_0030, IL_0031, IL_003e, IL_0046, IL_004e, IL_004f, IL_005c, IL_0064, IL_006c, IL_0074, IL_007c, IL_0084, IL_008a, IL_0090, IL_0096, IL_009c, IL_00a2, IL_00a8, IL_00ae, IL_00b4, IL_00ba
			//IL_000e: Expected I4, but got O
			//IL_0083: Expected O, but got I4
			if (fieldNumber - 1 <= 19)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F0D")]
		[Cpp2IlInjected.Address(RVA = "0x29F6040", Offset = "0x29F4A40", VA = "0x1829F6040", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_0019, IL_001a, IL_001d, IL_001e, IL_001f, IL_0020, IL_0022
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 19)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F13")]
		[Cpp2IlInjected.Address(RVA = "0x29F62A0", Offset = "0x29F4CA0", VA = "0x1829F62A0", Slot = "31")]
		IItemData IItemData.Clone()
		{
			NpcDiscussionItemData npcDiscussionItemData = new NpcDiscussionItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F14")]
		[Cpp2IlInjected.Address(RVA = "0x29F6300", Offset = "0x29F4D00", VA = "0x1829F6300", Slot = "34")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0033
			if (character1ItemID_ != 0)
			{
				context.AddInvalidMemberError("Please select character1", "Character1ItemID");
			}
			if (character2ItemID_ != 0)
			{
				context.AddInvalidMemberError("Please select character2", "Character2ItemID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F15")]
		[Cpp2IlInjected.Address(RVA = "0x29F7D70", Offset = "0x29F6770", VA = "0x1829F7D70")]
		static NpcDiscussionItemData()
		{
			Func<NpcDiscussionItemData> func = default(Func<NpcDiscussionItemData>);
			_parser = (MessageParser<NpcDiscussionItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<NpcDiscussionItemData>)(object)FieldCodec.ForString(122u);
			uint num = default(uint);
			_parser = (MessageParser<NpcDiscussionItemData>)(object)FieldCodec.ForInt32(num);
			/*Error: Unexpected end of block*/;
		}
	}
}
