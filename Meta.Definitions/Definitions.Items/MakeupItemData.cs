using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002FD")]
	public sealed class MakeupItemData : IMessage<MakeupItemData>, IMessage, IEquatable<MakeupItemData>, IDeepCloneable<MakeupItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IHasSet, IGenericBuyable, IHasTags, IIsOnlineOnly, IOnlineAvailability, IAvailability
	{
		[Cpp2IlInjected.Token(Token = "0x4000E83")]
		private static readonly MessageParser<MakeupItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000E84")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000E85")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000E86")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000E87")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000E88")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000E89")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000E8A")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000E8B")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000E8C")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000E8D")]
		public const int MaleIconAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000E8E")]
		private string maleIconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000E8F")]
		public const int PrefabAddressFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000E90")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000E91")]
		public const int FemaleMakeupAddressFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000E92")]
		private string femaleMakeupAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000E93")]
		public const int MaleMakeupAddressFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000E94")]
		private string maleMakeupAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000E95")]
		public const int DefaultColor1FieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000E96")]
		private int defaultColor1_;

		[Cpp2IlInjected.Token(Token = "0x4000E97")]
		public const int DefaultColor2FieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000E98")]
		private int defaultColor2_;

		[Cpp2IlInjected.Token(Token = "0x4000E99")]
		public const int DefaultColor3FieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000E9A")]
		private int defaultColor3_;

		[Cpp2IlInjected.Token(Token = "0x4000E9B")]
		public const int DefaultOpacityFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000E9C")]
		private float defaultOpacity_;

		[Cpp2IlInjected.Token(Token = "0x4000E9D")]
		public const int DefaultGlossFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000E9E")]
		private float defaultGloss_;

		[Cpp2IlInjected.Token(Token = "0x4000E9F")]
		public const int SetItemIDFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000EA0")]
		private int setItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000EA1")]
		public const int TagsFieldNumber = 15;

		[Cpp2IlInjected.Token(Token = "0x4000EA2")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000EA3")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000EA4")]
		public const int DefaultCurrencyItemIDFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000EA5")]
		private int defaultCurrencyItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000EA6")]
		public const int IsUnavailableForGeneratorFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000EA7")]
		private bool isUnavailableForGenerator_;

		[Cpp2IlInjected.Token(Token = "0x4000EA8")]
		public const int IsSyncOnlineItemFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7D")]
		[Cpp2IlInjected.Token(Token = "0x4000EA9")]
		private bool isSyncOnlineItem_;

		[Cpp2IlInjected.Token(Token = "0x4000EAA")]
		public const int IsOnlineOnlyFieldNumber = 100;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7E")]
		[Cpp2IlInjected.Token(Token = "0x4000EAB")]
		private bool isOnlineOnly_;

		[Cpp2IlInjected.Token(Token = "0x4000EAC")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000EAD")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4000EAE")]
		private static readonly (TagItemType tagType, int? limit)[] usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x17000816")]
		[DebuggerNonUserCode]
		public static MessageParser<MakeupItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60021B8")]
			[Cpp2IlInjected.Address(RVA = "0x3901070", Offset = "0x38FFA70", VA = "0x183901070")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000817")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60021B9")]
			[Cpp2IlInjected.Address(RVA = "0x3900FA0", Offset = "0x38FF9A0", VA = "0x183900FA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000818")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60021BA")]
			[Cpp2IlInjected.Address(RVA = "0x3901130", Offset = "0x38FFB30", VA = "0x183901130", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000819")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60021BE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021BF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700081A")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60021C0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021C1")]
			[Cpp2IlInjected.Address(RVA = "0x3901470", Offset = "0x38FFE70", VA = "0x183901470")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700081B")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60021C2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021C3")]
			[Cpp2IlInjected.Address(RVA = "0x3901240", Offset = "0x38FFC40", VA = "0x183901240")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700081C")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60021C4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021C5")]
			[Cpp2IlInjected.Address(RVA = "0x3901320", Offset = "0x38FFD20", VA = "0x183901320")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700081D")]
		[DebuggerNonUserCode]
		public string MaleIconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60021C6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return maleIconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021C7")]
			[Cpp2IlInjected.Address(RVA = "0x3901390", Offset = "0x38FFD90", VA = "0x183901390")]
			set
			{
				string text = (maleIconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700081E")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60021C8")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021C9")]
			[Cpp2IlInjected.Address(RVA = "0x39014E0", Offset = "0x38FFEE0", VA = "0x1839014E0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700081F")]
		[DebuggerNonUserCode]
		public string FemaleMakeupAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60021CA")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return femaleMakeupAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021CB")]
			[Cpp2IlInjected.Address(RVA = "0x39012B0", Offset = "0x38FFCB0", VA = "0x1839012B0")]
			set
			{
				string text = (femaleMakeupAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000820")]
		[DebuggerNonUserCode]
		public string MaleMakeupAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60021CC")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return maleMakeupAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021CD")]
			[Cpp2IlInjected.Address(RVA = "0x3901400", Offset = "0x38FFE00", VA = "0x183901400")]
			set
			{
				string text = (maleMakeupAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000821")]
		[DebuggerNonUserCode]
		public int DefaultColor1
		{
			[Cpp2IlInjected.Token(Token = "0x60021CE")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return defaultColor1_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021CF")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				defaultColor1_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000822")]
		[DebuggerNonUserCode]
		public int DefaultColor2
		{
			[Cpp2IlInjected.Token(Token = "0x60021D0")]
			[Cpp2IlInjected.Address(RVA = "0x63F820", Offset = "0x63E220", VA = "0x18063F820")]
			get
			{
				return defaultColor2_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021D1")]
			[Cpp2IlInjected.Address(RVA = "0x63FC00", Offset = "0x63E600", VA = "0x18063FC00")]
			set
			{
				defaultColor2_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000823")]
		[DebuggerNonUserCode]
		public int DefaultColor3
		{
			[Cpp2IlInjected.Token(Token = "0x60021D2")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return defaultColor3_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021D3")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				defaultColor3_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000824")]
		[DebuggerNonUserCode]
		public float DefaultOpacity
		{
			[Cpp2IlInjected.Token(Token = "0x60021D4")]
			[Cpp2IlInjected.Address(RVA = "0x823E70", Offset = "0x822870", VA = "0x180823E70")]
			get
			{
				return defaultOpacity_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021D5")]
			[Cpp2IlInjected.Address(RVA = "0x824290", Offset = "0x822C90", VA = "0x180824290")]
			set
			{
				defaultOpacity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000825")]
		[DebuggerNonUserCode]
		public float DefaultGloss
		{
			[Cpp2IlInjected.Token(Token = "0x60021D6")]
			[Cpp2IlInjected.Address(RVA = "0x823CB0", Offset = "0x8226B0", VA = "0x180823CB0")]
			get
			{
				return defaultGloss_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021D7")]
			[Cpp2IlInjected.Address(RVA = "0x824240", Offset = "0x822C40", VA = "0x180824240")]
			set
			{
				defaultGloss_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000826")]
		[DebuggerNonUserCode]
		public int SetItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60021D8")]
			[Cpp2IlInjected.Address(RVA = "0x9604E0", Offset = "0x95EEE0", VA = "0x1809604E0")]
			get
			{
				return setItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021D9")]
			[Cpp2IlInjected.Address(RVA = "0x960750", Offset = "0x95F150", VA = "0x180960750")]
			set
			{
				setItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000827")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x60021DA")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0", Slot = "27")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000828")]
		[DebuggerNonUserCode]
		public int DefaultCurrencyItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60021DB")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0")]
			get
			{
				return defaultCurrencyItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021DC")]
			[Cpp2IlInjected.Address(RVA = "0x70CDE0", Offset = "0x70B7E0", VA = "0x18070CDE0")]
			set
			{
				defaultCurrencyItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000829")]
		[DebuggerNonUserCode]
		public bool IsUnavailableForGenerator
		{
			[Cpp2IlInjected.Token(Token = "0x60021DD")]
			[Cpp2IlInjected.Address(RVA = "0x823F10", Offset = "0x822910", VA = "0x180823F10", Slot = "31")]
			get
			{
				return isUnavailableForGenerator_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021DE")]
			[Cpp2IlInjected.Address(RVA = "0x8242B0", Offset = "0x822CB0", VA = "0x1808242B0", Slot = "32")]
			set
			{
				isUnavailableForGenerator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700082A")]
		[DebuggerNonUserCode]
		public bool IsSyncOnlineItem
		{
			[Cpp2IlInjected.Token(Token = "0x60021DF")]
			[Cpp2IlInjected.Address(RVA = "0x823D90", Offset = "0x822790", VA = "0x180823D90", Slot = "29")]
			get
			{
				return isSyncOnlineItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021E0")]
			[Cpp2IlInjected.Address(RVA = "0x824280", Offset = "0x822C80", VA = "0x180824280", Slot = "30")]
			set
			{
				isSyncOnlineItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700082B")]
		[DebuggerNonUserCode]
		public bool IsOnlineOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60021E1")]
			[Cpp2IlInjected.Address(RVA = "0x15579C0", Offset = "0x15563C0", VA = "0x1815579C0", Slot = "28")]
			get
			{
				return isOnlineOnly_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021E2")]
			[Cpp2IlInjected.Address(RVA = "0x15579E0", Offset = "0x15563E0", VA = "0x1815579E0")]
			set
			{
				isOnlineOnly_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700082C")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x60021E3")]
			[Cpp2IlInjected.Address(RVA = "0x1024670", Offset = "0x1023070", VA = "0x181024670", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60021E4")]
			[Cpp2IlInjected.Address(RVA = "0x10247F0", Offset = "0x10231F0", VA = "0x1810247F0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700082D")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60021F0")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "24")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700082E")]
		public Item SetItem
		{
			[Cpp2IlInjected.Token(Token = "0x60021F1")]
			[Cpp2IlInjected.Address(RVA = "0x9604E0", Offset = "0x95EEE0", VA = "0x1809604E0", Slot = "23")]
			get
			{
				int num = setItemID_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700082F")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60021F2")]
			[Cpp2IlInjected.Address(RVA = "0x39010D0", Offset = "0x38FFAD0", VA = "0x1839010D0", Slot = "26")]
			get
			{
				(TagItemType, int?)[] array = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000830")]
		Item IGenericBuyable.DefaultCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x60021F3")]
			[Cpp2IlInjected.Address(RVA = "0x38FF010", Offset = "0x38FDA10", VA = "0x1838FF010", Slot = "25")]
			get
			{
				long num = Convert.ToInt64((uint)defaultCurrencyItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021BB")]
		[Cpp2IlInjected.Address(RVA = "0x3900C20", Offset = "0x38FF620", VA = "0x183900C20")]
		[DebuggerNonUserCode]
		public MakeupItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60021BC")]
		[Cpp2IlInjected.Address(RVA = "0x3900D30", Offset = "0x38FF730", VA = "0x183900D30")]
		[DebuggerNonUserCode]
		public MakeupItemData(MakeupItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (maleIconAddress_ = other.maleIconAddress_);
			string text5 = (prefabAddress_ = other.prefabAddress_);
			string text6 = (femaleMakeupAddress_ = other.femaleMakeupAddress_);
			string text7 = (maleMakeupAddress_ = other.maleMakeupAddress_);
			int num2 = (defaultColor1_ = other.defaultColor1_);
			int num3 = (defaultColor2_ = other.defaultColor2_);
			int num4 = (defaultColor3_ = other.defaultColor3_);
			float num5 = (defaultOpacity_ = other.defaultOpacity_);
			float num6 = (defaultGloss_ = other.defaultGloss_);
			int num7 = (setItemID_ = other.setItemID_);
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			int num8 = (defaultCurrencyItemID_ = other.defaultCurrencyItemID_);
			bool flag = (isUnavailableForGenerator_ = other.isUnavailableForGenerator_);
			bool flag2 = (isSyncOnlineItem_ = other.isSyncOnlineItem_);
			bool flag3 = (isOnlineOnly_ = other.isOnlineOnly_);
			uint num9 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021BD")]
		[Cpp2IlInjected.Address(RVA = "0x38FEFB0", Offset = "0x38FD9B0", VA = "0x1838FEFB0", Slot = "10")]
		[DebuggerNonUserCode]
		public MakeupItemData Clone()
		{
			return new MakeupItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60021E5")]
		[Cpp2IlInjected.Address(RVA = "0x38FF070", Offset = "0x38FDA70", VA = "0x1838FF070", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((MakeupItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60021E6")]
		[Cpp2IlInjected.Address(RVA = "0x38FF0D0", Offset = "0x38FDAD0", VA = "0x1838FF0D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MakeupItemData other)
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
								string text4 = other.maleIconAddress_;
								if (!(maleIconAddress_ != text4))
								{
									string text5 = other.prefabAddress_;
									if (!(prefabAddress_ != text5))
									{
										string text6 = other.femaleMakeupAddress_;
										if (!(femaleMakeupAddress_ != text6))
										{
											string text7 = other.maleMakeupAddress_;
											if (!(maleMakeupAddress_ != text7))
											{
												int num2 = other.defaultColor1_;
												if (defaultColor1_ == num2)
												{
													int num3 = other.defaultColor2_;
													if (defaultColor2_ == num3)
													{
														int num4 = other.defaultColor3_;
														if (defaultColor3_ == num4)
														{
															int num5 = other.setItemID_;
															if (setItemID_ == num5)
															{
																RepeatedField<int> repeatedField = tags_;
																RepeatedField<int> repeatedField2 = other.tags_;
																if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
																{
																	int num6 = other.defaultCurrencyItemID_;
																	if (defaultCurrencyItemID_ == num6)
																	{
																		bool flag = other.isUnavailableForGenerator_;
																		if (isUnavailableForGenerator_ == flag)
																		{
																			bool flag2 = other.isSyncOnlineItem_;
																			if (isSyncOnlineItem_ == flag2)
																			{
																				bool flag3 = other.isOnlineOnly_;
																				if (isOnlineOnly_ == flag3)
																				{
																					uint num7 = other.glotID_;
																					if (glotID_ == num7)
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
			int num8 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021E7")]
		[Cpp2IlInjected.Address(RVA = "0x38FF5D0", Offset = "0x38FDFD0", VA = "0x1838FF5D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0169
			//IL_00f8: Expected O, but got I4
			//IL_010b: Expected O, but got I4
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
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = maleIconAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			string text5 = prefabAddress_;
			if (text5.m_stringLength != 0)
			{
				int hashCode5 = text5.GetHashCode();
			}
			string text6 = femaleMakeupAddress_;
			if (text6.m_stringLength != 0)
			{
				int hashCode6 = text6.GetHashCode();
			}
			string text7 = maleMakeupAddress_;
			if (text7.m_stringLength != 0)
			{
				int hashCode7 = text7.GetHashCode();
			}
			if (defaultColor1_ != 0)
			{
			}
			if (defaultColor2_ != 0)
			{
			}
			int num2 = defaultColor3_;
			int num3 = default(int);
			if (num2 != 0)
			{
				num3 = 0;
			}
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField = default(EqualityComparer<float>);
			if (num2 != 0)
			{
				_003CBitwiseSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				int hashCode8 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField).GetHashCode((T)num3);
			}
			if (_003CBitwiseSingleEqualityComparer_003Ek__BackingField != null)
			{
				int hashCode9 = ((EqualityComparer<T>)(object)ProtobufEqualityComparers.BitwiseSingleEqualityComparer).GetHashCode((T)num3);
			}
			if (setItemID_ != 0)
			{
			}
			int hashCode10 = ((RepeatedField<T>)(object)tags_).GetHashCode();
			if (defaultCurrencyItemID_ != 0)
			{
			}
			if (isUnavailableForGenerator_)
			{
			}
			if (isSyncOnlineItem_)
			{
			}
			if (isOnlineOnly_)
			{
			}
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode11 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60021E8")]
		[Cpp2IlInjected.Address(RVA = "0x3900550", Offset = "0x38FEF50", VA = "0x183900550", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60021E9")]
		[Cpp2IlInjected.Address(RVA = "0x39005B0", Offset = "0x38FEFB0", VA = "0x1839005B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_021c
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
			if (maleIconAddress_.m_stringLength != 0)
			{
				string value5 = maleIconAddress_;
				output.WriteString(value5);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value6 = prefabAddress_;
				output.WriteString(value6);
			}
			if (femaleMakeupAddress_.m_stringLength != 0)
			{
				string value7 = femaleMakeupAddress_;
				output.WriteString(value7);
			}
			if (maleMakeupAddress_.m_stringLength != 0)
			{
				string value8 = maleMakeupAddress_;
				output.WriteString(value8);
			}
			if (defaultColor1_ != 0)
			{
				int value9 = defaultColor1_;
				output.WriteInt32(value9);
			}
			if (defaultColor2_ != 0)
			{
				int value10 = defaultColor2_;
				output.WriteInt32(value10);
			}
			if (defaultColor3_ != 0)
			{
				int value11 = defaultColor3_;
				output.WriteInt32(value11);
			}
			if (output != null)
			{
				float value12 = defaultOpacity_;
				output.WriteFloat(value12);
			}
			if (output != null)
			{
				float value13 = defaultGloss_;
				output.WriteFloat(value13);
			}
			if (setItemID_ != 0)
			{
				int value14 = setItemID_;
				output.WriteInt32(value14);
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			if (defaultCurrencyItemID_ != 0)
			{
				int value15 = defaultCurrencyItemID_;
				output.WriteInt32(value15);
			}
			if (isUnavailableForGenerator_)
			{
				bool value16 = isUnavailableForGenerator_;
				output.WriteBool(value16);
			}
			if (isSyncOnlineItem_)
			{
				bool value17 = isSyncOnlineItem_;
				output.WriteBool(value17);
			}
			if (isOnlineOnly_)
			{
				bool value18 = isOnlineOnly_;
				output.WriteBool(value18);
			}
			if (glotID_ != 0)
			{
				uint value19 = glotID_;
				output.WriteUInt32(value19);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60021EA")]
		[Cpp2IlInjected.Address(RVA = "0x38FE910", Offset = "0x38FD310", VA = "0x1838FE910", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0226
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
			string text4 = maleIconAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			string text5 = prefabAddress_;
			if (text5.m_stringLength != 0)
			{
				int num8 = CodedOutputStream.ComputeStringSize(text5);
				num8++;
				num2 += num8;
			}
			string text6 = femaleMakeupAddress_;
			if (text6.m_stringLength != 0)
			{
				int num9 = CodedOutputStream.ComputeStringSize(text6);
				num9++;
				num2 += num9;
			}
			string text7 = maleMakeupAddress_;
			if (text7.m_stringLength != 0)
			{
				int num10 = CodedOutputStream.ComputeStringSize(text7);
				num10++;
				num2 += num10;
			}
			int num11 = defaultColor1_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
				num2 += num12;
			}
			int num13 = defaultColor2_;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeInt32Size(num13);
				num14++;
				num2 += num14;
			}
			int num15 = defaultColor3_;
			if (num15 != 0)
			{
				int num16 = CodedOutputStream.ComputeInt32Size(num15);
				num16++;
				num2 += num16;
			}
			num2 += 5;
			num2 += 5;
			int num17 = setItemID_;
			if (num17 != 0)
			{
				int num18 = CodedOutputStream.ComputeInt32Size(num17);
				num18++;
				num2 += num18;
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num19 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			int num20 = defaultCurrencyItemID_;
			num2 += num19;
			if (num20 != 0)
			{
				int num21 = CodedOutputStream.ComputeInt32Size(num20);
				num21 += 2;
				num2 += num21;
			}
			uint num22 = glotID_;
			if (num22 != 0)
			{
				int num23 = CodedOutputStream.ComputeUInt32Size(num22);
				num23 += 2;
				num2 += num23;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num24 = unknownFields.CalculateSize();
				num2 += num24;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60021EB")]
		[Cpp2IlInjected.Address(RVA = "0x38FF9C0", Offset = "0x38FE3C0", VA = "0x1838FF9C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MakeupItemData other)
		{
			//Discarded unreachable code: IL_01e7
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
				string text4 = other.maleIconAddress_;
				if (text4.m_stringLength != 0)
				{
					MaleIconAddress = text4;
				}
				string text5 = other.prefabAddress_;
				if (text5.m_stringLength != 0)
				{
					PrefabAddress = text5;
				}
				string text6 = other.femaleMakeupAddress_;
				if (text6.m_stringLength != 0)
				{
					FemaleMakeupAddress = text6;
				}
				string text7 = other.maleMakeupAddress_;
				if (text7.m_stringLength != 0)
				{
					MaleMakeupAddress = text7;
				}
				int num2 = other.defaultColor1_;
				if (num2 != 0)
				{
					defaultColor1_ = num2;
				}
				int num3 = other.defaultColor2_;
				if (num3 != 0)
				{
					defaultColor2_ = num3;
				}
				int num4 = other.defaultColor3_;
				if (num4 != 0)
				{
					defaultColor3_ = num4;
				}
				float num5 = other.defaultOpacity_;
				if (num4 != 0)
				{
					defaultOpacity_ = num5;
				}
				float num6 = other.defaultGloss_;
				if (num4 != 0)
				{
					defaultGloss_ = num6;
				}
				int num7 = other.setItemID_;
				if (num7 != 0)
				{
					setItemID_ = num7;
				}
				RepeatedField<int> repeatedField = tags_;
				RepeatedField<int> repeatedField2 = other.tags_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int num8 = other.defaultCurrencyItemID_;
				if (num8 != 0)
				{
					defaultCurrencyItemID_ = num8;
				}
				bool flag = other.isUnavailableForGenerator_;
				if (flag)
				{
					isUnavailableForGenerator_ = flag;
				}
				bool flag2 = other.isSyncOnlineItem_;
				if (flag2)
				{
					isSyncOnlineItem_ = flag2;
				}
				bool flag3 = other.isOnlineOnly_;
				if (flag3)
				{
					isOnlineOnly_ = flag3;
				}
				uint num9 = other.glotID_;
				if (num9 != 0)
				{
					glotID_ = num9;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021EC")]
		[Cpp2IlInjected.Address(RVA = "0x38FFBB0", Offset = "0x38FE5B0", VA = "0x1838FFBB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0246
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num <= 80)
			{
				goto IL_012b;
			}
			if ((int)num > 120)
			{
				if ((int)num > 160)
				{
					if (num == 168)
					{
						bool flag = (isSyncOnlineItem_ = input.ReadBool());
					}
					bool flag2 = default(bool);
					if (num == 800)
					{
						flag2 = (isOnlineOnly_ = input.ReadBool());
					}
					if (!flag2)
					{
						goto IL_022f;
					}
					int num2 = (int)(glotID_ = (uint)input.ReadInt32());
				}
				if (num == 122)
				{
					goto IL_00e3;
				}
				int num3 = default(int);
				if (num == 128)
				{
					num3 = (defaultCurrencyItemID_ = input.ReadInt32());
				}
				if (num3 != 160)
				{
					goto IL_022f;
				}
				bool flag3 = (isUnavailableForGenerator_ = input.ReadBool());
			}
			if ((int)num <= 101)
			{
				goto IL_00fc;
			}
			if (num == 109)
			{
				float num4 = (defaultGloss_ = input.ReadFloat());
			}
			int num5 = default(int);
			if (num == 112)
			{
				num5 = (setItemID_ = input.ReadInt32());
			}
			if (num5 == 120)
			{
				goto IL_00e3;
			}
			goto IL_022f;
			IL_00e3:
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			goto IL_00fc;
			IL_012b:
			string text6 = default(string);
			if ((int)num > 42)
			{
				int num7 = default(int);
				if ((int)num > 58)
				{
					string text2 = default(string);
					if (num == 66)
					{
						text2 = (MaleMakeupAddress = input.ReadString());
					}
					int num6 = default(int);
					if ((long)text2 == 72)
					{
						num6 = (defaultColor1_ = input.ReadInt32());
					}
					if (num6 != 80)
					{
						goto IL_022f;
					}
					num7 = (defaultColor2_ = input.ReadInt32());
				}
				string text4 = default(string);
				if (num7 == 50)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 58)
				{
					goto IL_022f;
				}
				text6 = (FemaleMakeupAddress = input.ReadString());
			}
			string text12 = default(string);
			if ((long)text6 > 18)
			{
				string text8 = default(string);
				if ((long)text6 == 26)
				{
					text8 = (DisplayName = input.ReadString());
				}
				string text10 = default(string);
				if ((long)text8 == 34)
				{
					text10 = (IconAddress = input.ReadString());
				}
				if ((long)text10 != 42)
				{
					goto IL_022f;
				}
				text12 = (MaleIconAddress = input.ReadString());
			}
			int num8 = default(int);
			if ((long)text12 == 8)
			{
				num8 = (iD_ = input.ReadInt32());
			}
			if (num8 == 18)
			{
				string text14 = (Name = input.ReadString());
			}
			goto IL_022f;
			IL_00fc:
			int num9 = default(int);
			if (num5 == 88)
			{
				num9 = (defaultColor3_ = input.ReadInt32());
			}
			if (num9 == 101)
			{
				float num10 = (defaultOpacity_ = input.ReadFloat());
				goto IL_012b;
			}
			goto IL_022f;
			IL_022f:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60021ED")]
		[Cpp2IlInjected.Address(RVA = "0x38FF330", Offset = "0x38FDD30", VA = "0x1838FF330", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 20)
			{
				int num = iD_;
			}
			if (fieldNumber == 100)
			{
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60021EE")]
		[Cpp2IlInjected.Address(RVA = "0x38FFF00", Offset = "0x38FE900", VA = "0x1838FFF00", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_001f, IL_002f, IL_0037, IL_003f, IL_0047, IL_004f, IL_0057, IL_005f, IL_0067, IL_006f, IL_008c, IL_0092, IL_0098, IL_009e, IL_00a4, IL_00aa, IL_00b0, IL_00b6, IL_00bc
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_004e: Expected F4, but got I4
			//IL_0056: Expected F4, but got I4
			//IL_0083: Expected I4, but got O
			//IL_008b: Expected I4, but got O
			if (fieldNumber - 1 <= 20)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
			else if (fieldNumber == 100)
			{
				object obj2 = default(object);
				isOnlineOnly_ = (byte)(int)obj2 != 0;
			}
			else
			{
				object obj3 = default(object);
				glotID_ = (uint)(int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021EF")]
		[Cpp2IlInjected.Address(RVA = "0x38FED30", Offset = "0x38FD730", VA = "0x1838FED30", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_001f, IL_0020, IL_0021, IL_0022, IL_0039
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 20)
			{
				iD_ = 0;
				return;
			}
			switch (fieldNumber)
			{
			case 100:
				isOnlineOnly_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021F4")]
		[Cpp2IlInjected.Address(RVA = "0x38FEFB0", Offset = "0x38FD9B0", VA = "0x1838FEFB0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			MakeupItemData makeupItemData = new MakeupItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60021F5")]
		[Cpp2IlInjected.Address(RVA = "0x3900A20", Offset = "0x38FF420", VA = "0x183900A20")]
		static MakeupItemData()
		{
			//Discarded unreachable code: IL_0032
			//IL_002b: Expected O, but got I4
			Func<MakeupItemData> func = default(Func<MakeupItemData>);
			_parser = (MessageParser<MakeupItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<MakeupItemData>)(object)FieldCodec.ForInt32(122u);
			(TagItemType, int?)[] array = new(TagItemType, int?)[1];
			int num = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num;
			_parser = (MessageParser<MakeupItemData>)(object)array;
		}
	}
}
