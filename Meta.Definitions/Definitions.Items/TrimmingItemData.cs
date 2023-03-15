using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Epic.OnlineServices;
using Epic.OnlineServices.Sessions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000305")]
	public sealed class TrimmingItemData : IMessage<TrimmingItemData>, IMessage, IEquatable<TrimmingItemData>, IDeepCloneable<TrimmingItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IHasTags, IHasTraits, IHasSet, IHasRarity, ITrimmingData, IOnlineAvailability, IAvailability
	{
		[Cpp2IlInjected.Token(Token = "0x4000EE1")]
		private static readonly MessageParser<TrimmingItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000EE2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000EE3")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000EE4")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000EE5")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000EE6")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000EE7")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000EE8")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000EE9")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000EEA")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000EEB")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000EEC")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000EED")]
		public const int MaterialAddressFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000EEE")]
		private string materialAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000EEF")]
		public const int AccentPrefabAddressFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000EF0")]
		private string accentPrefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000EF1")]
		public const int RarityFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000EF2")]
		private int rarity_;

		[Cpp2IlInjected.Token(Token = "0x4000EF3")]
		public const int SetItemIDFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000EF4")]
		private int setItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000EF5")]
		public const int TagsFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4000EF6")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000EF7")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000EF8")]
		public const int ComplexityFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000EF9")]
		private Complexity complexity_;

		[Cpp2IlInjected.Token(Token = "0x4000EFA")]
		public const int ComplexityStrengthFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000EFB")]
		private int complexityStrength_;

		[Cpp2IlInjected.Token(Token = "0x4000EFC")]
		public const int MoodFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000EFD")]
		private Mood mood_;

		[Cpp2IlInjected.Token(Token = "0x4000EFE")]
		public const int MoodStrengthFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000EFF")]
		private int moodStrength_;

		[Cpp2IlInjected.Token(Token = "0x4000F00")]
		public const int SturdinessFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000F01")]
		private Sturdiness sturdiness_;

		[Cpp2IlInjected.Token(Token = "0x4000F02")]
		public const int SturdinessStrengthFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000F03")]
		private int sturdinessStrength_;

		[Cpp2IlInjected.Token(Token = "0x4000F04")]
		public const int NormalityFieldNumber = 17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000F05")]
		private Normality normality_;

		[Cpp2IlInjected.Token(Token = "0x4000F06")]
		public const int NormalityStrengthFieldNumber = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000F07")]
		private int normalityStrength_;

		[Cpp2IlInjected.Token(Token = "0x4000F08")]
		public const int IsUnavailableForGeneratorFieldNumber = 19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000F09")]
		private bool isUnavailableForGenerator_;

		[Cpp2IlInjected.Token(Token = "0x4000F0A")]
		public const int AudioSurfaceTypeFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000F0B")]
		private AudioSurfaceType audioSurfaceType_;

		[Cpp2IlInjected.Token(Token = "0x4000F0C")]
		public const int IsSyncOnlineItemFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000F0D")]
		private bool isSyncOnlineItem_;

		[Cpp2IlInjected.Token(Token = "0x4000F0E")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000F0F")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4000F10")]
		private static readonly (TagItemType tagType, int? limit)[] usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x17000853")]
		[DebuggerNonUserCode]
		public static MessageParser<TrimmingItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600226A")]
			[Cpp2IlInjected.Address(RVA = "0x35516C0", Offset = "0x35500C0", VA = "0x1835516C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000854")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600226B")]
			[Cpp2IlInjected.Address(RVA = "0x3551590", Offset = "0x354FF90", VA = "0x183551590")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000855")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600226C")]
			[Cpp2IlInjected.Address(RVA = "0x35517E0", Offset = "0x35501E0", VA = "0x1835517E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000856")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002271")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002272")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000857")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002273")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002274")]
			[Cpp2IlInjected.Address(RVA = "0x3551AB0", Offset = "0x35504B0", VA = "0x183551AB0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000858")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002275")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002276")]
			[Cpp2IlInjected.Address(RVA = "0x3551960", Offset = "0x3550360", VA = "0x183551960")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000859")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002277")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002278")]
			[Cpp2IlInjected.Address(RVA = "0x35519D0", Offset = "0x35503D0", VA = "0x1835519D0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700085A")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002279")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600227A")]
			[Cpp2IlInjected.Address(RVA = "0x3551B20", Offset = "0x3550520", VA = "0x183551B20")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700085B")]
		[DebuggerNonUserCode]
		public string MaterialAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600227B")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "35")]
			get
			{
				return materialAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600227C")]
			[Cpp2IlInjected.Address(RVA = "0x3551A40", Offset = "0x3550440", VA = "0x183551A40")]
			set
			{
				string text = (materialAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700085C")]
		[DebuggerNonUserCode]
		public string AccentPrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600227D")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "36")]
			get
			{
				return accentPrefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600227E")]
			[Cpp2IlInjected.Address(RVA = "0x35518F0", Offset = "0x35502F0", VA = "0x1835518F0")]
			set
			{
				string text = (accentPrefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700085D")]
		[DebuggerNonUserCode]
		public int Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x600227F")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950", Slot = "34")]
			get
			{
				return rarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002280")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				rarity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700085E")]
		[DebuggerNonUserCode]
		public int SetItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6002281")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get
			{
				return setItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002282")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				setItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700085F")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6002283")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0", Slot = "24")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000860")]
		[DebuggerNonUserCode]
		public Complexity Complexity
		{
			[Cpp2IlInjected.Token(Token = "0x6002284")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750", Slot = "25")]
			get
			{
				return complexity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002285")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				complexity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000861")]
		[DebuggerNonUserCode]
		public int ComplexityStrength
		{
			[Cpp2IlInjected.Token(Token = "0x6002286")]
			[Cpp2IlInjected.Address(RVA = "0x1811A30", Offset = "0x1810430", VA = "0x181811A30", Slot = "26")]
			get
			{
				return complexityStrength_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002287")]
			[Cpp2IlInjected.Address(RVA = "0x1811B80", Offset = "0x1810580", VA = "0x181811B80")]
			set
			{
				complexityStrength_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000862")]
		[DebuggerNonUserCode]
		public Mood Mood
		{
			[Cpp2IlInjected.Token(Token = "0x6002288")]
			[Cpp2IlInjected.Address(RVA = "0x724F70", Offset = "0x723970", VA = "0x180724F70", Slot = "27")]
			get
			{
				return mood_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002289")]
			[Cpp2IlInjected.Address(RVA = "0x7252F0", Offset = "0x723CF0", VA = "0x1807252F0")]
			set
			{
				mood_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000863")]
		[DebuggerNonUserCode]
		public int MoodStrength
		{
			[Cpp2IlInjected.Token(Token = "0x600228A")]
			[Cpp2IlInjected.Address(RVA = "0x9604E0", Offset = "0x95EEE0", VA = "0x1809604E0", Slot = "28")]
			get
			{
				return moodStrength_;
			}
			[Cpp2IlInjected.Token(Token = "0x600228B")]
			[Cpp2IlInjected.Address(RVA = "0x960750", Offset = "0x95F150", VA = "0x180960750")]
			set
			{
				moodStrength_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000864")]
		[DebuggerNonUserCode]
		public Sturdiness Sturdiness
		{
			[Cpp2IlInjected.Token(Token = "0x600228C")]
			[Cpp2IlInjected.Address(RVA = "0xDD7050", Offset = "0xDD5A50", VA = "0x180DD7050", Slot = "29")]
			get
			{
				return sturdiness_;
			}
			[Cpp2IlInjected.Token(Token = "0x600228D")]
			[Cpp2IlInjected.Address(RVA = "0xDD7110", Offset = "0xDD5B10", VA = "0x180DD7110")]
			set
			{
				sturdiness_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000865")]
		[DebuggerNonUserCode]
		public int SturdinessStrength
		{
			[Cpp2IlInjected.Token(Token = "0x600228E")]
			[Cpp2IlInjected.Address(RVA = "0xDD7040", Offset = "0xDD5A40", VA = "0x180DD7040", Slot = "30")]
			get
			{
				return sturdinessStrength_;
			}
			[Cpp2IlInjected.Token(Token = "0x600228F")]
			[Cpp2IlInjected.Address(RVA = "0xDD7100", Offset = "0xDD5B00", VA = "0x180DD7100")]
			set
			{
				sturdinessStrength_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000866")]
		[DebuggerNonUserCode]
		public Normality Normality
		{
			[Cpp2IlInjected.Token(Token = "0x6002290")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0", Slot = "31")]
			get
			{
				return normality_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002291")]
			[Cpp2IlInjected.Address(RVA = "0x70CDE0", Offset = "0x70B7E0", VA = "0x18070CDE0")]
			set
			{
				normality_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000867")]
		[DebuggerNonUserCode]
		public int NormalityStrength
		{
			[Cpp2IlInjected.Token(Token = "0x6002292")]
			[Cpp2IlInjected.Address(RVA = "0xAE8600", Offset = "0xAE7000", VA = "0x180AE8600", Slot = "32")]
			get
			{
				return normalityStrength_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002293")]
			[Cpp2IlInjected.Address(RVA = "0x1525600", Offset = "0x1524000", VA = "0x181525600")]
			set
			{
				normalityStrength_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000868")]
		[DebuggerNonUserCode]
		public bool IsUnavailableForGenerator
		{
			[Cpp2IlInjected.Token(Token = "0x6002294")]
			[Cpp2IlInjected.Address(RVA = "0x725070", Offset = "0x723A70", VA = "0x180725070", Slot = "39")]
			get
			{
				return isUnavailableForGenerator_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002295")]
			[Cpp2IlInjected.Address(RVA = "0x725360", Offset = "0x723D60", VA = "0x180725360", Slot = "40")]
			set
			{
				isUnavailableForGenerator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000869")]
		[DebuggerNonUserCode]
		public AudioSurfaceType AudioSurfaceType
		{
			[Cpp2IlInjected.Token(Token = "0x6002296")]
			[Cpp2IlInjected.Address(RVA = "0x1D8F910", Offset = "0x1D8E310", VA = "0x181D8F910")]
			get
			{
				return audioSurfaceType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002297")]
			[Cpp2IlInjected.Address(RVA = "0x1D8FD50", Offset = "0x1D8E750", VA = "0x181D8FD50")]
			set
			{
				audioSurfaceType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700086A")]
		[DebuggerNonUserCode]
		public bool IsSyncOnlineItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002298")]
			[Cpp2IlInjected.Address(RVA = "0xBD6330", Offset = "0xBD4D30", VA = "0x180BD6330", Slot = "37")]
			get
			{
				return isSyncOnlineItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002299")]
			[Cpp2IlInjected.Address(RVA = "0x102A930", Offset = "0x1029330", VA = "0x18102A930", Slot = "38")]
			set
			{
				isSyncOnlineItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700086B")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x600229A")]
			[Cpp2IlInjected.Address(RVA = "0xA8E0A0", Offset = "0xA8CAA0", VA = "0x180A8E0A0", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600229B")]
			[Cpp2IlInjected.Address(RVA = "0x125C200", Offset = "0x125AC00", VA = "0x18125C200", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700086C")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60022A7")]
			[Cpp2IlInjected.Address(RVA = "0x3551660", Offset = "0x3550060", VA = "0x183551660", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)iD_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700086D")]
		public Item SetItem
		{
			[Cpp2IlInjected.Token(Token = "0x60022A8")]
			[Cpp2IlInjected.Address(RVA = "0x3551720", Offset = "0x3550120", VA = "0x183551720", Slot = "33")]
			get
			{
				long num = Convert.ToInt64((uint)setItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700086E")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60022A9")]
			[Cpp2IlInjected.Address(RVA = "0x3551780", Offset = "0x3550180", VA = "0x183551780", Slot = "23")]
			get
			{
				(TagItemType, int?)[] array = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600226D")]
		[Cpp2IlInjected.Address(RVA = "0x3551470", Offset = "0x354FE70", VA = "0x183551470")]
		[DebuggerNonUserCode]
		public TrimmingItemData()
		{
			//IL_005e: Expected I4, but got I8
			//IL_0067: Expected I4, but got I8
			//IL_0070: Expected I4, but got I8
			//IL_0079: Expected I4, but got I8
			//IL_0082: Expected I4, but got I8
			rarity_ = 1;
			complexityStrength_ = 1;
			moodStrength_ = 1;
			sturdinessStrength_ = 1;
			normalityStrength_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600226E")]
		[Cpp2IlInjected.Address(RVA = "0x3550320", Offset = "0x354ED20", VA = "0x183550320")]
		private void OnConstruction()
		{
			//IL_0009: Expected I4, but got I8
			//IL_0012: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			//IL_0024: Expected I4, but got I8
			//IL_002d: Expected I4, but got I8
			rarity_ = 1;
			complexityStrength_ = 1;
			moodStrength_ = 1;
			sturdinessStrength_ = 1;
			normalityStrength_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600226F")]
		[Cpp2IlInjected.Address(RVA = "0x35511E0", Offset = "0x354FBE0", VA = "0x1835511E0")]
		[DebuggerNonUserCode]
		public TrimmingItemData(TrimmingItemData other)
		{
			//IL_005e: Expected I4, but got I8
			//IL_0067: Expected I4, but got I8
			//IL_0070: Expected I4, but got I8
			//IL_0079: Expected I4, but got I8
			//IL_0082: Expected I4, but got I8
			rarity_ = 1;
			complexityStrength_ = 1;
			moodStrength_ = 1;
			sturdinessStrength_ = 1;
			normalityStrength_ = 1;
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			string text5 = (materialAddress_ = other.materialAddress_);
			string text6 = (accentPrefabAddress_ = other.accentPrefabAddress_);
			int num2 = (rarity_ = other.rarity_);
			int num3 = (setItemID_ = other.setItemID_);
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			Complexity complexity = (complexity_ = other.complexity_);
			int num4 = (complexityStrength_ = other.complexityStrength_);
			Mood mood = (mood_ = other.mood_);
			int num5 = (moodStrength_ = other.moodStrength_);
			Sturdiness sturdiness = (sturdiness_ = other.sturdiness_);
			int num6 = (sturdinessStrength_ = other.sturdinessStrength_);
			Normality normality = (normality_ = other.normality_);
			int num7 = (normalityStrength_ = other.normalityStrength_);
			bool flag = (isUnavailableForGenerator_ = other.isUnavailableForGenerator_);
			AudioSurfaceType audioSurfaceType = (audioSurfaceType_ = other.audioSurfaceType_);
			bool flag2 = (isSyncOnlineItem_ = other.isSyncOnlineItem_);
			uint num8 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002270")]
		[Cpp2IlInjected.Address(RVA = "0x354F570", Offset = "0x354DF70", VA = "0x18354F570", Slot = "10")]
		[DebuggerNonUserCode]
		public TrimmingItemData Clone()
		{
			return new TrimmingItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600229C")]
		[Cpp2IlInjected.Address(RVA = "0x354F7B0", Offset = "0x354E1B0", VA = "0x18354F7B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((TrimmingItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600229D")]
		[Cpp2IlInjected.Address(RVA = "0x354F5D0", Offset = "0x354DFD0", VA = "0x18354F5D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TrimmingItemData other)
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
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									string text5 = other.materialAddress_;
									if (!(materialAddress_ != text5))
									{
										string text6 = other.accentPrefabAddress_;
										if (!(accentPrefabAddress_ != text6))
										{
											int num2 = other.rarity_;
											if (rarity_ == num2)
											{
												int num3 = other.setItemID_;
												if (setItemID_ == num3)
												{
													RepeatedField<int> repeatedField = tags_;
													RepeatedField<int> repeatedField2 = other.tags_;
													if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
													{
														Complexity complexity = other.complexity_;
														if (complexity_ == complexity)
														{
															int num4 = other.complexityStrength_;
															if (complexityStrength_ == num4)
															{
																Mood mood = other.mood_;
																if (mood_ == mood)
																{
																	int num5 = other.moodStrength_;
																	if (moodStrength_ == num5)
																	{
																		Sturdiness sturdiness = other.sturdiness_;
																		if (sturdiness_ == sturdiness)
																		{
																			int num6 = other.sturdinessStrength_;
																			if (sturdinessStrength_ == num6)
																			{
																				Normality normality = other.normality_;
																				if (normality_ == normality)
																				{
																					int num7 = other.normalityStrength_;
																					if (normalityStrength_ == num7)
																					{
																						bool flag = other.isUnavailableForGenerator_;
																						if (isUnavailableForGenerator_ == flag)
																						{
																							AudioSurfaceType audioSurfaceType = other.audioSurfaceType_;
																							if (audioSurfaceType_ == audioSurfaceType)
																							{
																								bool flag2 = other.isSyncOnlineItem_;
																								if (isSyncOnlineItem_ == flag2)
																								{
																									uint num8 = other.glotID_;
																									if (glotID_ == num8)
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
					}
				}
			}
			int num9 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600229E")]
		[Cpp2IlInjected.Address(RVA = "0x354FAF0", Offset = "0x354E4F0", VA = "0x18354FAF0", Slot = "2")]
		[DebuggerNonUserCode]
		public unsafe override int GetHashCode()
		{
			//Discarded unreachable code: IL_0159
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
			string text5 = materialAddress_;
			if (text5.m_stringLength != 0)
			{
				int hashCode5 = text5.GetHashCode();
			}
			string text6 = accentPrefabAddress_;
			if (text6.m_stringLength != 0)
			{
				int hashCode6 = text6.GetHashCode();
			}
			if (rarity_ != 0)
			{
				Result resultCode = ((SessionSearchFindCallbackInfo*)text6)->ResultCode;
			}
			if (setItemID_ != 0)
			{
				Result resultCode2 = ((SessionSearchFindCallbackInfo*)text6)->ResultCode;
			}
			int hashCode7 = ((RepeatedField<T>)(object)tags_).GetHashCode();
			if (complexity_ != 0)
			{
			}
			if (complexityStrength_ != 0)
			{
			}
			if (mood_ != 0)
			{
			}
			if (moodStrength_ != 0)
			{
			}
			if (sturdiness_ != 0)
			{
			}
			if (sturdinessStrength_ != 0)
			{
			}
			if (normality_ != 0)
			{
			}
			if (normalityStrength_ != 0)
			{
			}
			if (isUnavailableForGenerator_)
			{
			}
			if (audioSurfaceType_ != 0)
			{
			}
			if (isSyncOnlineItem_)
			{
			}
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode8 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600229F")]
		[Cpp2IlInjected.Address(RVA = "0x3550A50", Offset = "0x354F450", VA = "0x183550A50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60022A0")]
		[Cpp2IlInjected.Address(RVA = "0x3550AB0", Offset = "0x354F4B0", VA = "0x183550AB0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0203
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
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			if (materialAddress_.m_stringLength != 0)
			{
				string value6 = materialAddress_;
				output.WriteString(value6);
			}
			if (accentPrefabAddress_.m_stringLength != 0)
			{
				string value7 = accentPrefabAddress_;
				output.WriteString(value7);
			}
			if (rarity_ != 0)
			{
				int value8 = rarity_;
				output.WriteInt32(value8);
			}
			if (setItemID_ != 0)
			{
				int value9 = setItemID_;
				output.WriteInt32(value9);
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			if (complexity_ != 0)
			{
			}
			if (complexityStrength_ != 0)
			{
				int value10 = complexityStrength_;
				output.WriteInt32(value10);
			}
			if (mood_ != 0)
			{
			}
			if (moodStrength_ != 0)
			{
				int value11 = moodStrength_;
				output.WriteInt32(value11);
			}
			if (sturdiness_ != 0)
			{
			}
			if (sturdinessStrength_ != 0)
			{
				int value12 = sturdinessStrength_;
				output.WriteInt32(value12);
			}
			if (normality_ != 0)
			{
			}
			if (normalityStrength_ != 0)
			{
				int value13 = normalityStrength_;
				output.WriteInt32(value13);
			}
			if (isUnavailableForGenerator_)
			{
				bool value14 = isUnavailableForGenerator_;
				output.WriteBool(value14);
			}
			if (audioSurfaceType_ != 0)
			{
			}
			if (isSyncOnlineItem_)
			{
				bool value15 = isSyncOnlineItem_;
				output.WriteBool(value15);
			}
			if (glotID_ != 0)
			{
				uint value16 = glotID_;
				output.WriteUInt32(value16);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60022A1")]
		[Cpp2IlInjected.Address(RVA = "0x354EDE0", Offset = "0x354D7E0", VA = "0x18354EDE0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_02be
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
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			string text5 = materialAddress_;
			if (text5.m_stringLength != 0)
			{
				int num8 = CodedOutputStream.ComputeStringSize(text5);
				num8++;
				num2 += num8;
			}
			string text6 = accentPrefabAddress_;
			if (text6.m_stringLength != 0)
			{
				int num9 = CodedOutputStream.ComputeStringSize(text6);
				num9++;
				num2 += num9;
			}
			int num10 = rarity_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num2 += num11;
			}
			int num12 = setItemID_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				num2 += num13;
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num14 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			Complexity complexity = complexity_;
			num2 += num14;
			if (complexity != 0)
			{
				int num15 = CodedOutputStream.ComputeEnumSize((int)complexity);
				num15++;
				num2 += num15;
			}
			int num16 = complexityStrength_;
			if (num16 != 0)
			{
				int num17 = CodedOutputStream.ComputeInt32Size(num16);
				num17++;
				num2 += num17;
			}
			Mood mood = mood_;
			if (mood != 0)
			{
				int num18 = CodedOutputStream.ComputeEnumSize((int)mood);
				num18++;
				num2 += num18;
			}
			int num19 = moodStrength_;
			if (num19 != 0)
			{
				int num20 = CodedOutputStream.ComputeInt32Size(num19);
				num20++;
				num2 += num20;
			}
			Sturdiness sturdiness = sturdiness_;
			if (sturdiness != 0)
			{
				int num21 = CodedOutputStream.ComputeEnumSize((int)sturdiness);
				num21++;
				num2 += num21;
			}
			int num22 = sturdinessStrength_;
			if (num22 != 0)
			{
				int num23 = CodedOutputStream.ComputeInt32Size(num22);
				num23 += 2;
				num2 += num23;
			}
			Normality normality = normality_;
			if (normality != 0)
			{
				int num24 = CodedOutputStream.ComputeEnumSize((int)normality);
				num24 += 2;
				num2 += num24;
			}
			int num25 = normalityStrength_;
			if (num25 != 0)
			{
				int num26 = CodedOutputStream.ComputeInt32Size(num25);
				num26 += 2;
				num2 += num26;
			}
			AudioSurfaceType audioSurfaceType = audioSurfaceType_;
			if (audioSurfaceType != 0)
			{
				int num27 = CodedOutputStream.ComputeEnumSize((int)audioSurfaceType);
				num27 += 2;
				num2 += num27;
			}
			uint num28 = glotID_;
			if (num28 != 0)
			{
				int num29 = CodedOutputStream.ComputeUInt32Size(num28);
				num29 += 2;
				num2 += num29;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num30 = unknownFields.CalculateSize();
				num2 += num30;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60022A2")]
		[Cpp2IlInjected.Address(RVA = "0x3550130", Offset = "0x354EB30", VA = "0x183550130", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TrimmingItemData other)
		{
			//Discarded unreachable code: IL_020c
			if (other != null)
			{
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
				string text5 = other.materialAddress_;
				if (text5.m_stringLength != 0)
				{
					MaterialAddress = text5;
				}
				string text6 = other.accentPrefabAddress_;
				if (text6.m_stringLength != 0)
				{
					AccentPrefabAddress = text6;
				}
				int num2 = other.rarity_;
				if (num2 != 0)
				{
					rarity_ = num2;
				}
				int num3 = other.setItemID_;
				if (num3 != 0)
				{
					setItemID_ = num3;
				}
				RepeatedField<int> repeatedField = tags_;
				RepeatedField<int> repeatedField2 = other.tags_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				Complexity complexity = other.complexity_;
				if (complexity != 0)
				{
					complexity_ = complexity;
				}
				int num4 = other.complexityStrength_;
				if (num4 != 0)
				{
					complexityStrength_ = num4;
				}
				Mood mood = other.mood_;
				if (mood != 0)
				{
					mood_ = mood;
				}
				int num5 = other.moodStrength_;
				if (num5 != 0)
				{
					moodStrength_ = num5;
				}
				Sturdiness sturdiness = other.sturdiness_;
				if (sturdiness != 0)
				{
					sturdiness_ = sturdiness;
				}
				int num6 = other.sturdinessStrength_;
				if (num6 != 0)
				{
					sturdinessStrength_ = num6;
				}
				Normality normality = other.normality_;
				if (normality != 0)
				{
					normality_ = normality;
				}
				int num7 = other.normalityStrength_;
				if (num7 != 0)
				{
					normalityStrength_ = num7;
				}
				bool flag = other.isUnavailableForGenerator_;
				if (flag)
				{
					isUnavailableForGenerator_ = flag;
				}
				AudioSurfaceType audioSurfaceType = other.audioSurfaceType_;
				if (audioSurfaceType != 0)
				{
					audioSurfaceType_ = audioSurfaceType;
				}
				bool flag2 = other.isSyncOnlineItem_;
				if (flag2)
				{
					isSyncOnlineItem_ = flag2;
				}
				uint num8 = other.glotID_;
				if (num8 != 0)
				{
					glotID_ = num8;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022A3")]
		[Cpp2IlInjected.Address(RVA = "0x354FDB0", Offset = "0x354E7B0", VA = "0x18354FDB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0278
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 82)
			{
				if ((int)num > 128)
				{
					if ((int)num > 152)
					{
						if (num == 160)
						{
							int num2 = (int)(audioSurfaceType_ = (AudioSurfaceType)input.ReadInt32());
						}
						bool flag = default(bool);
						if (num == 168)
						{
							flag = (isSyncOnlineItem_ = input.ReadBool());
						}
						if (!flag)
						{
							goto IL_0261;
						}
						int num3 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					int num4 = default(int);
					if (num == 136)
					{
						num4 = (int)(normality_ = (Normality)input.ReadInt32());
					}
					int num5 = default(int);
					if (num4 == 144)
					{
						num5 = (normalityStrength_ = input.ReadInt32());
					}
					if (num5 != 152)
					{
						goto IL_0261;
					}
					bool flag2 = (isUnavailableForGenerator_ = input.ReadBool());
				}
				int num8 = default(int);
				if ((int)num > 104)
				{
					int num6 = default(int);
					if (num == 112)
					{
						num6 = (moodStrength_ = input.ReadInt32());
					}
					int num7 = default(int);
					if (num6 == 120)
					{
						num7 = (int)(sturdiness_ = (Sturdiness)input.ReadInt32());
					}
					if (num7 != 128)
					{
						goto IL_0261;
					}
					num8 = (sturdinessStrength_ = input.ReadInt32());
				}
				int num9 = default(int);
				if (num8 == 88)
				{
					num9 = (int)(complexity_ = (Complexity)input.ReadInt32());
				}
				int num10 = default(int);
				if (num9 == 96)
				{
					num10 = (complexityStrength_ = input.ReadInt32());
				}
				if (num10 != 104)
				{
					goto IL_0261;
				}
				int num11 = (int)(mood_ = (Mood)input.ReadInt32());
			}
			int num13 = default(int);
			if ((int)num > 42)
			{
				int num12 = default(int);
				if ((int)num > 64)
				{
					if (num == 72)
					{
						num12 = (setItemID_ = input.ReadInt32());
					}
					num12 += -80;
					if (num12 != -3)
					{
						goto IL_0261;
					}
					RepeatedField<int> repeatedField = tags_;
					FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
				}
				string text2 = default(string);
				if (num12 == 50)
				{
					text2 = (MaterialAddress = input.ReadString());
				}
				string text4 = default(string);
				if ((long)text2 == 58)
				{
					text4 = (AccentPrefabAddress = input.ReadString());
				}
				if ((long)text4 != 64)
				{
					goto IL_0261;
				}
				num13 = (rarity_ = input.ReadInt32());
			}
			string text10 = default(string);
			if (num13 > 18)
			{
				string text6 = default(string);
				if (num13 == 26)
				{
					text6 = (DisplayName = input.ReadString());
				}
				string text8 = default(string);
				if ((long)text6 == 34)
				{
					text8 = (IconAddress = input.ReadString());
				}
				if ((long)text8 != 42)
				{
					goto IL_0261;
				}
				text10 = (PrefabAddress = input.ReadString());
			}
			int num14 = default(int);
			if ((long)text10 == 8)
			{
				num14 = (iD_ = input.ReadInt32());
			}
			if (num14 == 18)
			{
				string text12 = (Name = input.ReadString());
			}
			goto IL_0261;
			IL_0261:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60022A4")]
		[Cpp2IlInjected.Address(RVA = "0x354F810", Offset = "0x354E210", VA = "0x18354F810", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 20)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60022A5")]
		[Cpp2IlInjected.Address(RVA = "0x3550350", Offset = "0x354ED50", VA = "0x183550350", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0012, IL_001c, IL_001d, IL_001e, IL_001f, IL_0020, IL_0021, IL_0031, IL_0039, IL_0041, IL_0049, IL_0051, IL_0059, IL_0061, IL_0069, IL_0071, IL_0079, IL_0081, IL_0089, IL_0091, IL_00a9, IL_00af, IL_00b5, IL_00bb, IL_00c1, IL_00c7, IL_00cd, IL_00d3
			//IL_0011: Expected I4, but got O
			//IL_001b: Expected O, but got I4
			//IL_00a8: Expected I4, but got O
			if (fieldNumber - 1 <= 20)
			{
				object obj = default(object);
				iD_ = (int)obj;
				return;
			}
			while (fieldNumber != 999)
			{
			}
			object obj2 = default(object);
			glotID_ = (uint)(int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x60022A6")]
		[Cpp2IlInjected.Address(RVA = "0x354F2D0", Offset = "0x354DCD0", VA = "0x18354F2D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_001f, IL_0020, IL_0021, IL_0022, IL_0023, IL_0024, IL_0025, IL_0038
			//IL_0010: Expected I4, but got I8
			//IL_0037: Expected I4, but got I8
			if (fieldNumber - 1 <= 20)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022AA")]
		[Cpp2IlInjected.Address(RVA = "0x354F570", Offset = "0x354DF70", VA = "0x18354F570", Slot = "20")]
		IItemData IItemData.Clone()
		{
			TrimmingItemData trimmingItemData = new TrimmingItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60022AB")]
		[Cpp2IlInjected.Address(RVA = "0x3550F60", Offset = "0x354F960", VA = "0x183550F60")]
		static TrimmingItemData()
		{
			//Discarded unreachable code: IL_0048
			//IL_0029: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			Func<TrimmingItemData> func = default(Func<TrimmingItemData>);
			_parser = (MessageParser<TrimmingItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<TrimmingItemData>)(object)FieldCodec.ForInt32(82u);
			(TagItemType, int?)[] array = new(TagItemType, int?)[3];
			int num = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num;
			int num2 = 0;
			((ValueTuple<, >[])(object)array)[2] = (ValueTuple<, >)num2;
			int num3 = 0;
			((ValueTuple<, >[])(object)array)[4] = (ValueTuple<, >)num3;
			_parser = (MessageParser<TrimmingItemData>)(object)array;
		}
	}
}
