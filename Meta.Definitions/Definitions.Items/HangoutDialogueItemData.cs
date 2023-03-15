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
	[Cpp2IlInjected.Token(Token = "0x20003DE")]
	public sealed class HangoutDialogueItemData : IMessage<HangoutDialogueItemData>, IMessage, IEquatable<HangoutDialogueItemData>, IDeepCloneable<HangoutDialogueItemData>, IMessageFieldAccessor, IDialogueItemData, IItemData, IUpdateVersion, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x20003DF")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20003E0")]
			public enum HangoutDialogueType
			{
				[Cpp2IlInjected.Token(Token = "0x40014D0")]
				[OriginalName("HangoutDialogueType_Start")]
				Start,
				[Cpp2IlInjected.Token(Token = "0x40014D1")]
				[OriginalName("HangoutDialogueType_End")]
				End,
				[Cpp2IlInjected.Token(Token = "0x40014D2")]
				[OriginalName("HangoutDialogueType_Cancel")]
				Cancel
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40014A7")]
		private static readonly MessageParser<HangoutDialogueItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40014A8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40014A9")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40014AA")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x40014AB")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40014AC")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x40014AD")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40014AE")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40014AF")]
		public const int CharacterItemIDFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40014B0")]
		private int characterItemID_;

		[Cpp2IlInjected.Token(Token = "0x40014B1")]
		public const int IconAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40014B2")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40014B3")]
		public const int PrefabAddressFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40014B4")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40014B5")]
		public const int DialogueAssetAddressFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40014B6")]
		private string dialogueAssetAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40014B7")]
		public const int PreviousDiscussionIDFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40014B8")]
		private int previousDiscussionID_;

		[Cpp2IlInjected.Token(Token = "0x40014B9")]
		public const int SeasonFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40014BA")]
		private Season season_;

		[Cpp2IlInjected.Token(Token = "0x40014BB")]
		public const int TimeOfDayFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40014BC")]
		private string timeOfDay_ = "";

		[Cpp2IlInjected.Token(Token = "0x40014BD")]
		public const int ScheduleFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40014BE")]
		private ScheduleType schedule_;

		[Cpp2IlInjected.Token(Token = "0x40014BF")]
		public const int LocationFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40014C0")]
		private CharacterLocation location_;

		[Cpp2IlInjected.Token(Token = "0x40014C1")]
		public const int SpecificWeatherFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40014C2")]
		private bool specificWeather_;

		[Cpp2IlInjected.Token(Token = "0x40014C3")]
		public const int WeathersFieldNumber = 14;

		[Cpp2IlInjected.Token(Token = "0x40014C4")]
		private static readonly FieldCodec<string> _repeated_weathers_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40014C5")]
		private readonly RepeatedField<string> weathers_ = (RepeatedField<string>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40014C6")]
		public const int NecessaryCharactersInVillageFieldNumber = 15;

		[Cpp2IlInjected.Token(Token = "0x40014C7")]
		private static readonly FieldCodec<int> _repeated_necessaryCharactersInVillage_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40014C8")]
		private readonly RepeatedField<int> necessaryCharactersInVillage_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40014C9")]
		public const int DialogueTypeFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40014CA")]
		private Types.HangoutDialogueType dialogueType_;

		[Cpp2IlInjected.Token(Token = "0x40014CB")]
		public const int ConditionsFieldNumber = 17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40014CC")]
		private ConditionsList conditions_;

		[Cpp2IlInjected.Token(Token = "0x40014CD")]
		public const int UpdateVersionFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40014CE")]
		private string updateVersion_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000BCE")]
		[DebuggerNonUserCode]
		public static MessageParser<HangoutDialogueItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002E9B")]
			[Cpp2IlInjected.Address(RVA = "0x2F9CC70", Offset = "0x2F9B670", VA = "0x182F9CC70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BCF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002E9C")]
			[Cpp2IlInjected.Address(RVA = "0x2F9CBA0", Offset = "0x2F9B5A0", VA = "0x182F9CBA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002E9D")]
			[Cpp2IlInjected.Address(RVA = "0x2F9CCD0", Offset = "0x2F9B6D0", VA = "0x182F9CCD0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD1")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002EA2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "25")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EA3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD2")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002EA4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "27")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EA5")]
			[Cpp2IlInjected.Address(RVA = "0x2F9CF30", Offset = "0x2F9B930", VA = "0x182F9CF30")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD3")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002EA6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "28")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EA7")]
			[Cpp2IlInjected.Address(RVA = "0x2F9CE50", Offset = "0x2F9B850", VA = "0x182F9CE50")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD4")]
		[DebuggerNonUserCode]
		public int CharacterItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6002EA8")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return characterItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EA9")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				characterItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD5")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002EAA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "29")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EAB")]
			[Cpp2IlInjected.Address(RVA = "0x2F9CEC0", Offset = "0x2F9B8C0", VA = "0x182F9CEC0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD6")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002EAC")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "30")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EAD")]
			[Cpp2IlInjected.Address(RVA = "0x2F9CFA0", Offset = "0x2F9B9A0", VA = "0x182F9CFA0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD7")]
		[DebuggerNonUserCode]
		public string DialogueAssetAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002EAE")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "14")]
			get
			{
				return dialogueAssetAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EAF")]
			[Cpp2IlInjected.Address(RVA = "0x2F9CDE0", Offset = "0x2F9B7E0", VA = "0x182F9CDE0")]
			set
			{
				string text = (dialogueAssetAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD8")]
		[DebuggerNonUserCode]
		public int PreviousDiscussionID
		{
			[Cpp2IlInjected.Token(Token = "0x6002EB0")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return previousDiscussionID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EB1")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				previousDiscussionID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BD9")]
		[DebuggerNonUserCode]
		public Season Season
		{
			[Cpp2IlInjected.Token(Token = "0x6002EB2")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830", Slot = "17")]
			get
			{
				return season_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EB3")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				season_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BDA")]
		[DebuggerNonUserCode]
		public string TimeOfDay
		{
			[Cpp2IlInjected.Token(Token = "0x6002EB4")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0", Slot = "18")]
			get
			{
				return timeOfDay_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EB5")]
			[Cpp2IlInjected.Address(RVA = "0x2F9D010", Offset = "0x2F9BA10", VA = "0x182F9D010")]
			set
			{
				string text = (timeOfDay_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BDB")]
		[DebuggerNonUserCode]
		public ScheduleType Schedule
		{
			[Cpp2IlInjected.Token(Token = "0x6002EB6")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750", Slot = "19")]
			get
			{
				return schedule_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EB7")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				schedule_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BDC")]
		[DebuggerNonUserCode]
		public CharacterLocation Location
		{
			[Cpp2IlInjected.Token(Token = "0x6002EB8")]
			[Cpp2IlInjected.Address(RVA = "0x1811A30", Offset = "0x1810430", VA = "0x181811A30", Slot = "20")]
			get
			{
				return location_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EB9")]
			[Cpp2IlInjected.Address(RVA = "0x1811B80", Offset = "0x1810580", VA = "0x181811B80")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BDD")]
		[DebuggerNonUserCode]
		public bool SpecificWeather
		{
			[Cpp2IlInjected.Token(Token = "0x6002EBA")]
			[Cpp2IlInjected.Address(RVA = "0xFB01D0", Offset = "0xFAEBD0", VA = "0x180FB01D0", Slot = "21")]
			get
			{
				return specificWeather_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EBB")]
			[Cpp2IlInjected.Address(RVA = "0xFB0200", Offset = "0xFAEC00", VA = "0x180FB0200")]
			set
			{
				specificWeather_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BDE")]
		[DebuggerNonUserCode]
		public RepeatedField<string> Weathers
		{
			[Cpp2IlInjected.Token(Token = "0x6002EBC")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0", Slot = "22")]
			get
			{
				return weathers_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BDF")]
		[DebuggerNonUserCode]
		public RepeatedField<int> NecessaryCharactersInVillage
		{
			[Cpp2IlInjected.Token(Token = "0x6002EBD")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640", Slot = "23")]
			get
			{
				return necessaryCharactersInVillage_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BE0")]
		[DebuggerNonUserCode]
		public Types.HangoutDialogueType DialogueType
		{
			[Cpp2IlInjected.Token(Token = "0x6002EBE")]
			[Cpp2IlInjected.Address(RVA = "0x1024670", Offset = "0x1023070", VA = "0x181024670")]
			get
			{
				return dialogueType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EBF")]
			[Cpp2IlInjected.Address(RVA = "0x10247F0", Offset = "0x10231F0", VA = "0x1810247F0")]
			set
			{
				dialogueType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BE1")]
		[DebuggerNonUserCode]
		public ConditionsList Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x6002EC0")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80", Slot = "24")]
			get
			{
				return conditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EC1")]
			[Cpp2IlInjected.Address(RVA = "0x7DB490", Offset = "0x7D9E90", VA = "0x1807DB490")]
			set
			{
				conditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BE2")]
		[DebuggerNonUserCode]
		public string UpdateVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6002EC2")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0", Slot = "32")]
			get
			{
				return updateVersion_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EC3")]
			[Cpp2IlInjected.Address(RVA = "0x2F9D080", Offset = "0x2F9BA80", VA = "0x182F9D080", Slot = "33")]
			set
			{
				string text = (updateVersion_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BE3")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002ECF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "26")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BE4")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002ED0")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40", Slot = "15")]
			get
			{
				int num = characterItemID_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BE5")]
		public Item PreviousDiscussion
		{
			[Cpp2IlInjected.Token(Token = "0x6002ED1")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950", Slot = "16")]
			get
			{
				int num = previousDiscussionID_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E9E")]
		[Cpp2IlInjected.Address(RVA = "0x2F9CA00", Offset = "0x2F9B400", VA = "0x182F9CA00")]
		[DebuggerNonUserCode]
		public HangoutDialogueItemData()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E9F")]
		[Cpp2IlInjected.Address(RVA = "0x2F9BAB0", Offset = "0x2F9A4B0", VA = "0x182F9BAB0")]
		private void OnConstruction()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EA0")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C6B0", Offset = "0x2F9B0B0", VA = "0x182F9C6B0")]
		[DebuggerNonUserCode]
		public HangoutDialogueItemData(HangoutDialogueItemData other)
		{
			//IL_01a3: Expected O, but got I4
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			int num2 = (characterItemID_ = other.characterItemID_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			string text5 = (dialogueAssetAddress_ = other.dialogueAssetAddress_);
			int num3 = (previousDiscussionID_ = other.previousDiscussionID_);
			Season season = (season_ = other.season_);
			string text6 = (timeOfDay_ = other.timeOfDay_);
			ScheduleType scheduleType = (schedule_ = other.schedule_);
			CharacterLocation characterLocation = (location_ = other.location_);
			bool flag = (specificWeather_ = other.specificWeather_);
			RepeatedField<string> repeatedField = (weathers_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)other.weathers_).Clone());
			RepeatedField<int> repeatedField2 = (necessaryCharactersInVillage_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.necessaryCharactersInVillage_).Clone());
			Types.HangoutDialogueType hangoutDialogueType = (dialogueType_ = other.dialogueType_);
			ConditionsList conditionsList2 = other.conditions_;
			if (conditionsList2 != null)
			{
				ConditionsList conditionsList3 = conditionsList2.Clone();
			}
			int num4 = 0;
			conditions_ = (ConditionsList)num4;
			string text7 = (updateVersion_ = other.updateVersion_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EA1")]
		[Cpp2IlInjected.Address(RVA = "0x2F9AC10", Offset = "0x2F99610", VA = "0x182F9AC10", Slot = "10")]
		[DebuggerNonUserCode]
		public HangoutDialogueItemData Clone()
		{
			return new HangoutDialogueItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC4")]
		[Cpp2IlInjected.Address(RVA = "0x2F9AF30", Offset = "0x2F99930", VA = "0x182F9AF30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((HangoutDialogueItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC5")]
		[Cpp2IlInjected.Address(RVA = "0x2F9AD30", Offset = "0x2F99730", VA = "0x182F9AD30", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(HangoutDialogueItemData other)
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
							int num2 = other.characterItemID_;
							if (characterItemID_ == num2)
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
											int num3 = other.previousDiscussionID_;
											if (previousDiscussionID_ == num3)
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
																			Types.HangoutDialogueType hangoutDialogueType = other.dialogueType_;
																			if (dialogueType_ == hangoutDialogueType)
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
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC6")]
		[Cpp2IlInjected.Address(RVA = "0x2F9B1F0", Offset = "0x2F99BF0", VA = "0x182F9B1F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_014d
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
			if (characterItemID_ != 0)
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
			if (dialogueType_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x6002EC7")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C0E0", Offset = "0x2F9AAE0", VA = "0x182F9C0E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC8")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C140", Offset = "0x2F9AB40", VA = "0x182F9C140", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_01b5
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
			if (characterItemID_ != 0)
			{
				int value4 = characterItemID_;
				output.WriteInt32(value4);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value5 = iconAddress_;
				output.WriteString(value5);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value6 = prefabAddress_;
				output.WriteString(value6);
			}
			if (dialogueAssetAddress_.m_stringLength != 0)
			{
				string value7 = dialogueAssetAddress_;
				output.WriteString(value7);
			}
			if (previousDiscussionID_ != 0)
			{
				int value8 = previousDiscussionID_;
				output.WriteInt32(value8);
			}
			if (season_ != 0)
			{
			}
			if (timeOfDay_.m_stringLength != 0)
			{
				string value9 = timeOfDay_;
				output.WriteString(value9);
			}
			if (schedule_ != 0)
			{
			}
			if (location_ != 0)
			{
			}
			if (specificWeather_)
			{
				bool value10 = specificWeather_;
				output.WriteBool(value10);
			}
			RepeatedField<string> repeatedField = weathers_;
			FieldCodec<string> repeated_weathers_codec = _repeated_weathers_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_weathers_codec);
			RepeatedField<int> repeatedField2 = necessaryCharactersInVillage_;
			FieldCodec<int> repeated_necessaryCharactersInVillage_codec = _repeated_necessaryCharactersInVillage_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_necessaryCharactersInVillage_codec);
			if (dialogueType_ != 0)
			{
			}
			if ((long)conditions_ != 0)
			{
				ConditionsList value11 = conditions_;
				output.WriteMessage(value11);
			}
			if (updateVersion_.m_stringLength != 0)
			{
				string value12 = updateVersion_;
				output.WriteString(value12);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC9")]
		[Cpp2IlInjected.Address(RVA = "0x2F9A550", Offset = "0x2F98F50", VA = "0x182F9A550", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Expected O, but got Unknown
			//IL_0211: Unknown result type (might be due to invalid IL or missing references)
			//IL_0214: Expected O, but got Unknown
			//IL_0239: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Expected O, but got Unknown
			//IL_0256: Unknown result type (might be due to invalid IL or missing references)
			//IL_0259: Expected O, but got Unknown
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
			int num6 = characterItemID_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num2 += num7;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num8 = CodedOutputStream.ComputeStringSize(text3);
				num8++;
				num2 += num8;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num9 = CodedOutputStream.ComputeStringSize(text4);
				num9++;
				num2 += num9;
			}
			string text5 = dialogueAssetAddress_;
			if (text5.m_stringLength != 0)
			{
				int num10 = CodedOutputStream.ComputeStringSize(text5);
				num10++;
				num2 += num10;
			}
			int num11 = previousDiscussionID_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
				num2 += num12;
			}
			Season season = season_;
			if (season != 0)
			{
				int num13 = CodedOutputStream.ComputeEnumSize((int)season);
				num13++;
				num2 += num13;
			}
			string text6 = timeOfDay_;
			if (text6.m_stringLength != 0)
			{
				int num14 = CodedOutputStream.ComputeStringSize(text6);
				num14++;
				num2 += num14;
			}
			ScheduleType scheduleType = schedule_;
			if (scheduleType != 0)
			{
				int num15 = CodedOutputStream.ComputeEnumSize((int)scheduleType);
				num15++;
				num2 += num15;
			}
			CharacterLocation characterLocation = location_;
			if (characterLocation != 0)
			{
				int num16 = CodedOutputStream.ComputeEnumSize((int)characterLocation);
				num16++;
				num2 += num16;
			}
			RepeatedField<string> repeatedField = weathers_;
			FieldCodec<string> repeated_weathers_codec = _repeated_weathers_codec;
			int num17 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_weathers_codec);
			RepeatedField<int> repeatedField2 = necessaryCharactersInVillage_;
			FieldCodec<int> repeated_necessaryCharactersInVillage_codec = _repeated_necessaryCharactersInVillage_codec;
			int num18 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_necessaryCharactersInVillage_codec);
			Types.HangoutDialogueType hangoutDialogueType = dialogueType_;
			if (hangoutDialogueType != 0)
			{
				int num19 = CodedOutputStream.ComputeEnumSize((int)hangoutDialogueType);
				num19 += 2;
				repeatedField = (RepeatedField<string>)(repeatedField + num19);
			}
			ConditionsList conditionsList = conditions_;
			if (conditionsList != null)
			{
				int num20 = CodedOutputStream.ComputeMessageSize(conditionsList);
				num20 += 2;
				repeatedField = (RepeatedField<string>)(repeatedField + num20);
			}
			string text7 = updateVersion_;
			if (text7.m_stringLength != 0)
			{
				int num21 = CodedOutputStream.ComputeStringSize(text7);
				num21 += 2;
				repeatedField = (RepeatedField<string>)(repeatedField + num21);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num22 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<string>)(repeatedField + num22);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECA")]
		[Cpp2IlInjected.Address(RVA = "0x2F9B850", Offset = "0x2F9A250", VA = "0x182F9B850", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(HangoutDialogueItemData other)
		{
			//Discarded unreachable code: IL_01e7
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
			int num2 = other.characterItemID_;
			if (num2 != 0)
			{
				characterItemID_ = num2;
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
			int num3 = other.previousDiscussionID_;
			if (num3 != 0)
			{
				previousDiscussionID_ = num3;
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
			Types.HangoutDialogueType hangoutDialogueType = other.dialogueType_;
			if (hangoutDialogueType != 0)
			{
				dialogueType_ = hangoutDialogueType;
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

		[Cpp2IlInjected.Token(Token = "0x6002ECB")]
		[Cpp2IlInjected.Address(RVA = "0x2F9B480", Offset = "0x2F99E80", VA = "0x182F9B480", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0234
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 72)
			{
				if ((int)num > 114)
				{
					if ((int)num > 122)
					{
						if (num == 128)
						{
							int num2 = (int)(dialogueType_ = (Types.HangoutDialogueType)input.ReadInt32());
						}
						ConditionsList conditionsList = default(ConditionsList);
						if (num == 138)
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
							goto IL_021d;
						}
						string text2 = (UpdateVersion = input.ReadString());
					}
					num += 4294967176u;
					if (num != 4294967293u)
					{
						goto IL_021d;
					}
					RepeatedField<int> repeatedField = necessaryCharactersInVillage_;
					FieldCodec<int> repeated_necessaryCharactersInVillage_codec = _repeated_necessaryCharactersInVillage_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_necessaryCharactersInVillage_codec);
				}
				bool flag = default(bool);
				if ((int)num > 88)
				{
					int num3 = default(int);
					if (num == 96)
					{
						num3 = (int)(location_ = (CharacterLocation)input.ReadInt32());
					}
					if (num3 == 104)
					{
						flag = (specificWeather_ = input.ReadBool());
					}
					if (!flag)
					{
						goto IL_021d;
					}
					RepeatedField<string> repeatedField2 = weathers_;
					FieldCodec<string> repeated_weathers_codec = _repeated_weathers_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_weathers_codec);
				}
				string text4 = default(string);
				if (flag)
				{
					text4 = (TimeOfDay = input.ReadString());
				}
				if ((long)text4 != 88)
				{
					goto IL_021d;
				}
				int num4 = (int)(schedule_ = (ScheduleType)input.ReadInt32());
			}
			string text10 = default(string);
			if ((int)num > 32)
			{
				int num6 = default(int);
				if ((int)num > 50)
				{
					string text6 = default(string);
					if (num == 58)
					{
						text6 = (DialogueAssetAddress = input.ReadString());
					}
					int num5 = default(int);
					if ((long)text6 == 64)
					{
						num5 = (previousDiscussionID_ = input.ReadInt32());
					}
					if (num5 != 72)
					{
						goto IL_021d;
					}
					num6 = (int)(season_ = (Season)input.ReadInt32());
				}
				string text8 = default(string);
				if (num6 == 42)
				{
					text8 = (IconAddress = input.ReadString());
				}
				if ((long)text8 != 50)
				{
					goto IL_021d;
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
				if ((long)text12 != 32)
				{
					goto IL_021d;
				}
				num7 = (characterItemID_ = input.ReadInt32());
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
			goto IL_021d;
			IL_021d:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECC")]
		[Cpp2IlInjected.Address(RVA = "0x2F9AF90", Offset = "0x2F99990", VA = "0x182F9AF90", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6002ECD")]
		[Cpp2IlInjected.Address(RVA = "0x2F9BB10", Offset = "0x2F9A510", VA = "0x182F9BB10", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_001e, IL_0026, IL_0027, IL_0028, IL_0029, IL_0036, IL_003e, IL_0046, IL_0047, IL_0054, IL_005c, IL_0064, IL_006c, IL_0074, IL_007c, IL_0082, IL_0088, IL_008e, IL_0094, IL_009a, IL_00a0, IL_00a6, IL_00ac, IL_00b2
			//IL_000e: Expected I4, but got O
			//IL_007b: Expected O, but got I4
			if (fieldNumber - 1 <= 19)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECE")]
		[Cpp2IlInjected.Address(RVA = "0x2F9A9C0", Offset = "0x2F993C0", VA = "0x182F9A9C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_0019, IL_001c, IL_001d, IL_001e, IL_001f, IL_0021
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 19)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002ED2")]
		[Cpp2IlInjected.Address(RVA = "0x2F9AC10", Offset = "0x2F99610", VA = "0x182F9AC10", Slot = "31")]
		IItemData IItemData.Clone()
		{
			HangoutDialogueItemData hangoutDialogueItemData = new HangoutDialogueItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002ED3")]
		[Cpp2IlInjected.Address(RVA = "0x2F9AC70", Offset = "0x2F99670", VA = "0x182F9AC70", Slot = "34")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001a
			if (characterItemID_ != 0)
			{
				context.AddInvalidMemberError("Please select character", "CharacterItemID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002ED4")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C550", Offset = "0x2F9AF50", VA = "0x182F9C550")]
		static HangoutDialogueItemData()
		{
			Func<HangoutDialogueItemData> func = default(Func<HangoutDialogueItemData>);
			_parser = (MessageParser<HangoutDialogueItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<HangoutDialogueItemData>)(object)FieldCodec.ForString(114u);
			_parser = (MessageParser<HangoutDialogueItemData>)(object)FieldCodec.ForInt32(122u);
			/*Error: Unexpected end of block*/;
		}
	}
}
