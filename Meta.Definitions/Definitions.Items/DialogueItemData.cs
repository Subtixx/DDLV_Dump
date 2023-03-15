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
	[Cpp2IlInjected.Token(Token = "0x20003DC")]
	public sealed class DialogueItemData : IMessage<DialogueItemData>, IMessage, IEquatable<DialogueItemData>, IDeepCloneable<DialogueItemData>, IMessageFieldAccessor, IDialogueItemData, IItemData, IUpdateVersion, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001480")]
		private static readonly MessageParser<DialogueItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001481")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001482")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001483")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001484")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001485")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001486")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001487")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001488")]
		public const int CharacterItemIDFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001489")]
		private int characterItemID_;

		[Cpp2IlInjected.Token(Token = "0x400148A")]
		public const int IconAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400148B")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400148C")]
		public const int PrefabAddressFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400148D")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400148E")]
		public const int DialogueAssetAddressFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400148F")]
		private string dialogueAssetAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001490")]
		public const int PreviousDiscussionIDFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001491")]
		private int previousDiscussionID_;

		[Cpp2IlInjected.Token(Token = "0x4001492")]
		public const int SeasonFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4001493")]
		private Season season_;

		[Cpp2IlInjected.Token(Token = "0x4001494")]
		public const int TimeOfDayFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001495")]
		private string timeOfDay_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001496")]
		public const int ScheduleFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001497")]
		private ScheduleType schedule_;

		[Cpp2IlInjected.Token(Token = "0x4001498")]
		public const int LocationFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4001499")]
		private CharacterLocation location_;

		[Cpp2IlInjected.Token(Token = "0x400149A")]
		public const int SpecificWeatherFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400149B")]
		private bool specificWeather_;

		[Cpp2IlInjected.Token(Token = "0x400149C")]
		public const int WeathersFieldNumber = 14;

		[Cpp2IlInjected.Token(Token = "0x400149D")]
		private static readonly FieldCodec<string> _repeated_weathers_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400149E")]
		private readonly RepeatedField<string> weathers_ = (RepeatedField<string>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400149F")]
		public const int NecessaryCharactersInVillageFieldNumber = 15;

		[Cpp2IlInjected.Token(Token = "0x40014A0")]
		private static readonly FieldCodec<int> _repeated_necessaryCharactersInVillage_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40014A1")]
		private readonly RepeatedField<int> necessaryCharactersInVillage_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40014A2")]
		public const int ConditionsFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40014A3")]
		private ConditionsList conditions_;

		[Cpp2IlInjected.Token(Token = "0x40014A4")]
		public const int UpdateVersionFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40014A5")]
		private string updateVersion_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000BB7")]
		[DebuggerNonUserCode]
		public static MessageParser<DialogueItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002E60")]
			[Cpp2IlInjected.Address(RVA = "0x2C3D450", Offset = "0x2C3BE50", VA = "0x182C3D450")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BB8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002E61")]
			[Cpp2IlInjected.Address(RVA = "0x2C3D380", Offset = "0x2C3BD80", VA = "0x182C3D380")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BB9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002E62")]
			[Cpp2IlInjected.Address(RVA = "0x2C3D4B0", Offset = "0x2C3BEB0", VA = "0x182C3D4B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BBA")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002E67")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "25")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E68")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BBB")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002E69")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "27")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E6A")]
			[Cpp2IlInjected.Address(RVA = "0x2C3D710", Offset = "0x2C3C110", VA = "0x182C3D710")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BBC")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002E6B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "28")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E6C")]
			[Cpp2IlInjected.Address(RVA = "0x2C3D630", Offset = "0x2C3C030", VA = "0x182C3D630")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BBD")]
		[DebuggerNonUserCode]
		public int CharacterItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6002E6D")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return characterItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E6E")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				characterItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BBE")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002E6F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "29")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E70")]
			[Cpp2IlInjected.Address(RVA = "0x2C3D6A0", Offset = "0x2C3C0A0", VA = "0x182C3D6A0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BBF")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002E71")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "30")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E72")]
			[Cpp2IlInjected.Address(RVA = "0x2C3D780", Offset = "0x2C3C180", VA = "0x182C3D780")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BC0")]
		[DebuggerNonUserCode]
		public string DialogueAssetAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002E73")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "14")]
			get
			{
				return dialogueAssetAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E74")]
			[Cpp2IlInjected.Address(RVA = "0x2C3D5C0", Offset = "0x2C3BFC0", VA = "0x182C3D5C0")]
			set
			{
				string text = (dialogueAssetAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BC1")]
		[DebuggerNonUserCode]
		public int PreviousDiscussionID
		{
			[Cpp2IlInjected.Token(Token = "0x6002E75")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return previousDiscussionID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E76")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				previousDiscussionID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BC2")]
		[DebuggerNonUserCode]
		public Season Season
		{
			[Cpp2IlInjected.Token(Token = "0x6002E77")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830", Slot = "17")]
			get
			{
				return season_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E78")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				season_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BC3")]
		[DebuggerNonUserCode]
		public string TimeOfDay
		{
			[Cpp2IlInjected.Token(Token = "0x6002E79")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0", Slot = "18")]
			get
			{
				return timeOfDay_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E7A")]
			[Cpp2IlInjected.Address(RVA = "0x2C3D7F0", Offset = "0x2C3C1F0", VA = "0x182C3D7F0")]
			set
			{
				string text = (timeOfDay_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BC4")]
		[DebuggerNonUserCode]
		public ScheduleType Schedule
		{
			[Cpp2IlInjected.Token(Token = "0x6002E7B")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750", Slot = "19")]
			get
			{
				return schedule_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E7C")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				schedule_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BC5")]
		[DebuggerNonUserCode]
		public CharacterLocation Location
		{
			[Cpp2IlInjected.Token(Token = "0x6002E7D")]
			[Cpp2IlInjected.Address(RVA = "0x1811A30", Offset = "0x1810430", VA = "0x181811A30", Slot = "20")]
			get
			{
				return location_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E7E")]
			[Cpp2IlInjected.Address(RVA = "0x1811B80", Offset = "0x1810580", VA = "0x181811B80")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BC6")]
		[DebuggerNonUserCode]
		public bool SpecificWeather
		{
			[Cpp2IlInjected.Token(Token = "0x6002E7F")]
			[Cpp2IlInjected.Address(RVA = "0xFB01D0", Offset = "0xFAEBD0", VA = "0x180FB01D0", Slot = "21")]
			get
			{
				return specificWeather_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E80")]
			[Cpp2IlInjected.Address(RVA = "0xFB0200", Offset = "0xFAEC00", VA = "0x180FB0200")]
			set
			{
				specificWeather_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BC7")]
		[DebuggerNonUserCode]
		public RepeatedField<string> Weathers
		{
			[Cpp2IlInjected.Token(Token = "0x6002E81")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0", Slot = "22")]
			get
			{
				return weathers_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BC8")]
		[DebuggerNonUserCode]
		public RepeatedField<int> NecessaryCharactersInVillage
		{
			[Cpp2IlInjected.Token(Token = "0x6002E82")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640", Slot = "23")]
			get
			{
				return necessaryCharactersInVillage_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BC9")]
		[DebuggerNonUserCode]
		public ConditionsList Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x6002E83")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80", Slot = "24")]
			get
			{
				return conditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E84")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BCA")]
		[DebuggerNonUserCode]
		public string UpdateVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6002E85")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80", Slot = "32")]
			get
			{
				return updateVersion_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002E86")]
			[Cpp2IlInjected.Address(RVA = "0x2C3D860", Offset = "0x2C3C260", VA = "0x182C3D860", Slot = "33")]
			set
			{
				string text = (updateVersion_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BCB")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002E92")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "26")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BCC")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002E93")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40", Slot = "15")]
			get
			{
				int num = characterItemID_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BCD")]
		public Item PreviousDiscussion
		{
			[Cpp2IlInjected.Token(Token = "0x6002E94")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950", Slot = "16")]
			get
			{
				int num = previousDiscussionID_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E63")]
		[Cpp2IlInjected.Address(RVA = "0x2C3D1E0", Offset = "0x2C3BBE0", VA = "0x182C3D1E0")]
		[DebuggerNonUserCode]
		public DialogueItemData()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E64")]
		[Cpp2IlInjected.Address(RVA = "0x2C3C310", Offset = "0x2C3AD10", VA = "0x182C3C310")]
		private void OnConstruction()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E65")]
		[Cpp2IlInjected.Address(RVA = "0x2C3CE90", Offset = "0x2C3B890", VA = "0x182C3CE90")]
		[DebuggerNonUserCode]
		public DialogueItemData(DialogueItemData other)
		{
			//IL_0193: Expected O, but got I4
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

		[Cpp2IlInjected.Token(Token = "0x6002E66")]
		[Cpp2IlInjected.Address(RVA = "0x2C3B500", Offset = "0x2C39F00", VA = "0x182C3B500", Slot = "10")]
		[DebuggerNonUserCode]
		public DialogueItemData Clone()
		{
			return new DialogueItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E87")]
		[Cpp2IlInjected.Address(RVA = "0x2C3B620", Offset = "0x2C3A020", VA = "0x182C3B620", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((DialogueItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E88")]
		[Cpp2IlInjected.Address(RVA = "0x2C3B680", Offset = "0x2C3A080", VA = "0x182C3B680", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DialogueItemData other)
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
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E89")]
		[Cpp2IlInjected.Address(RVA = "0x2C3BAA0", Offset = "0x2C3A4A0", VA = "0x182C3BAA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0144
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

		[Cpp2IlInjected.Token(Token = "0x6002E8A")]
		[Cpp2IlInjected.Address(RVA = "0x2C3C8F0", Offset = "0x2C3B2F0", VA = "0x182C3C8F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002E8B")]
		[Cpp2IlInjected.Address(RVA = "0x2C3C950", Offset = "0x2C3B350", VA = "0x182C3C950", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_01ac
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

		[Cpp2IlInjected.Token(Token = "0x6002E8C")]
		[Cpp2IlInjected.Address(RVA = "0x2C3AE90", Offset = "0x2C39890", VA = "0x182C3AE90", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Expected O, but got Unknown
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Expected O, but got Unknown
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected O, but got Unknown
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
			ConditionsList conditionsList = conditions_;
			if (conditionsList != null)
			{
				int num19 = CodedOutputStream.ComputeMessageSize(conditionsList);
				num19 += 2;
				repeatedField = (RepeatedField<string>)(repeatedField + num19);
			}
			string text7 = updateVersion_;
			if (text7.m_stringLength != 0)
			{
				int num20 = CodedOutputStream.ComputeStringSize(text7);
				num20 += 2;
				repeatedField = (RepeatedField<string>)(repeatedField + num20);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num21 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<string>)(repeatedField + num21);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E8D")]
		[Cpp2IlInjected.Address(RVA = "0x2C3BD10", Offset = "0x2C3A710", VA = "0x182C3BD10", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DialogueItemData other)
		{
			//Discarded unreachable code: IL_01d2
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

		[Cpp2IlInjected.Token(Token = "0x6002E8E")]
		[Cpp2IlInjected.Address(RVA = "0x2C3BF60", Offset = "0x2C3A960", VA = "0x182C3BF60", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0216
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num <= 72)
			{
				goto IL_0115;
			}
			if ((int)num <= 104)
			{
				goto IL_00b0;
			}
			if ((int)num > 120)
			{
				if (num == 122)
				{
					goto IL_0097;
				}
				if (num == 130)
				{
					ConditionsList conditionsList = conditions_;
					if (conditionsList == null)
					{
						ConditionsList conditionsList2 = (conditions_ = new ConditionsList());
					}
					input.ReadMessage(conditionsList);
				}
				if (num != 162)
				{
					goto IL_01ff;
				}
				string text2 = (UpdateVersion = input.ReadString());
			}
			if (num == 114)
			{
				RepeatedField<string> repeatedField = weathers_;
				FieldCodec<string> repeated_weathers_codec = _repeated_weathers_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_weathers_codec);
			}
			if (num == 120)
			{
				goto IL_0097;
			}
			goto IL_01ff;
			IL_00b0:
			bool flag = default(bool);
			if ((int)num > 88)
			{
				int num2 = default(int);
				if (num == 96)
				{
					num2 = (int)(location_ = (CharacterLocation)input.ReadInt32());
				}
				if (num2 != 104)
				{
					goto IL_01ff;
				}
				flag = (specificWeather_ = input.ReadBool());
			}
			string text4 = default(string);
			if (flag)
			{
				text4 = (TimeOfDay = input.ReadString());
			}
			if ((long)text4 == 88)
			{
				int num3 = (int)(schedule_ = (ScheduleType)input.ReadInt32());
				goto IL_0115;
			}
			goto IL_01ff;
			IL_0115:
			string text10 = default(string);
			if ((int)num > 32)
			{
				int num5 = default(int);
				if ((int)num > 50)
				{
					string text6 = default(string);
					if (num == 58)
					{
						text6 = (DialogueAssetAddress = input.ReadString());
					}
					int num4 = default(int);
					if ((long)text6 == 64)
					{
						num4 = (previousDiscussionID_ = input.ReadInt32());
					}
					if (num4 != 72)
					{
						goto IL_01ff;
					}
					num5 = (int)(season_ = (Season)input.ReadInt32());
				}
				string text8 = default(string);
				if (num5 == 42)
				{
					text8 = (IconAddress = input.ReadString());
				}
				if ((long)text8 != 50)
				{
					goto IL_01ff;
				}
				text10 = (PrefabAddress = input.ReadString());
			}
			int num6 = default(int);
			if ((long)text10 > 18)
			{
				string text12 = default(string);
				if ((long)text10 == 26)
				{
					text12 = (DisplayName = input.ReadString());
				}
				if ((long)text12 != 32)
				{
					goto IL_01ff;
				}
				num6 = (characterItemID_ = input.ReadInt32());
			}
			int num7 = default(int);
			if (num6 == 8)
			{
				num7 = (iD_ = input.ReadInt32());
			}
			if (num7 == 18)
			{
				string text14 = (Name = input.ReadString());
			}
			goto IL_01ff;
			IL_0097:
			RepeatedField<int> repeatedField2 = necessaryCharactersInVillage_;
			FieldCodec<int> repeated_necessaryCharactersInVillage_codec = _repeated_necessaryCharactersInVillage_codec;
			((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_necessaryCharactersInVillage_codec);
			goto IL_00b0;
			IL_01ff:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002E8F")]
		[Cpp2IlInjected.Address(RVA = "0x2C3B860", Offset = "0x2C3A260", VA = "0x182C3B860", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6002E90")]
		[Cpp2IlInjected.Address(RVA = "0x2C3C370", Offset = "0x2C3AD70", VA = "0x182C3C370", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_001e, IL_0026, IL_0027, IL_0028, IL_0029, IL_0036, IL_003e, IL_0046, IL_0047, IL_0054, IL_005c, IL_0064, IL_006c, IL_0074, IL_007a, IL_0080, IL_0086, IL_008c, IL_0092, IL_0098, IL_009e, IL_00a4, IL_00aa
			//IL_000e: Expected I4, but got O
			//IL_0073: Expected O, but got I4
			if (fieldNumber - 1 <= 19)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E91")]
		[Cpp2IlInjected.Address(RVA = "0x2C3B2C0", Offset = "0x2C39CC0", VA = "0x182C3B2C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_0019, IL_001c, IL_001d, IL_001e, IL_0020
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 19)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E95")]
		[Cpp2IlInjected.Address(RVA = "0x2C3B500", Offset = "0x2C39F00", VA = "0x182C3B500", Slot = "31")]
		IItemData IItemData.Clone()
		{
			DialogueItemData dialogueItemData = new DialogueItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E96")]
		[Cpp2IlInjected.Address(RVA = "0x2C3B560", Offset = "0x2C39F60", VA = "0x182C3B560", Slot = "34")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001a
			if (characterItemID_ != 0)
			{
				context.AddInvalidMemberError("Please select character", "CharacterItemID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E97")]
		[Cpp2IlInjected.Address(RVA = "0x2C3CD30", Offset = "0x2C3B730", VA = "0x182C3CD30")]
		static DialogueItemData()
		{
			Func<DialogueItemData> func = default(Func<DialogueItemData>);
			_parser = (MessageParser<DialogueItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<DialogueItemData>)(object)FieldCodec.ForString(114u);
			_parser = (MessageParser<DialogueItemData>)(object)FieldCodec.ForInt32(122u);
			/*Error: Unexpected end of block*/;
		}
	}
}
