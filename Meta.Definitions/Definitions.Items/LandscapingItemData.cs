using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002BE")]
	public sealed class LandscapingItemData : IMessage<LandscapingItemData>, IMessage, IEquatable<LandscapingItemData>, IDeepCloneable<LandscapingItemData>, IMessageFieldAccessor, IMessageOneofAccessor, IItemData, IHasGlotID, IGridPlaceableItemData, IHasTags, IGenericBuyable, IGridStateDataProvider, IPriceOverrider, IHasSubGridInteraction, IItemIsVariationOf
	{
		[Cpp2IlInjected.Token(Token = "0x20002BF")]
		public enum InteractionsOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000C56")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000C57")]
			SubGrid = 12
		}

		[Cpp2IlInjected.Token(Token = "0x4000C36")]
		private static readonly MessageParser<LandscapingItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000C37")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000C38")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000C39")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000C3A")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000C3B")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000C3C")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000C3D")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000C3E")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000C3F")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000C40")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000C41")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000C42")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000C43")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000C44")]
		public const int IsVariationOfFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000C45")]
		private int isVariationOf_;

		[Cpp2IlInjected.Token(Token = "0x4000C46")]
		public const int VillageAreaFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000C47")]
		private OptionalField villageArea_;

		[Cpp2IlInjected.Token(Token = "0x4000C48")]
		public const int TagsFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4000C49")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000C4A")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000C4B")]
		public const int DefaultCurrencyItemIDFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000C4C")]
		private int defaultCurrencyItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000C4D")]
		public const int PriceOverrideFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000C4E")]
		private PriceOverride priceOverride_;

		[Cpp2IlInjected.Token(Token = "0x4000C4F")]
		public const int SubGridFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x4000C50")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000C51")]
		private uint glotID_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000C52")]
		private object interactions_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000C53")]
		private InteractionsOneofCase interactionsCase_;

		[Cpp2IlInjected.Token(Token = "0x4000C54")]
		public static ReadOnlyCollection<(TagItemType tagType, int? limit)> usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x1700069F")]
		[DebuggerNonUserCode]
		public static MessageParser<LandscapingItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001D27")]
			[Cpp2IlInjected.Address(RVA = "0x2743950", Offset = "0x2742350", VA = "0x182743950")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006A0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001D28")]
			[Cpp2IlInjected.Address(RVA = "0x2743820", Offset = "0x2742220", VA = "0x182743820")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006A1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001D29")]
			[Cpp2IlInjected.Address(RVA = "0x2743A70", Offset = "0x2742470", VA = "0x182743A70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006A2")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001D2E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "16")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D2F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006A3")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001D30")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "18")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D31")]
			[Cpp2IlInjected.Address(RVA = "0x2743C60", Offset = "0x2742660", VA = "0x182743C60")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006A4")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6001D32")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "19")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D33")]
			[Cpp2IlInjected.Address(RVA = "0x2743B80", Offset = "0x2742580", VA = "0x182743B80")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006A5")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001D34")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "20")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D35")]
			[Cpp2IlInjected.Address(RVA = "0x2743BF0", Offset = "0x27425F0", VA = "0x182743BF0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006A6")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001D36")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "21")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D37")]
			[Cpp2IlInjected.Address(RVA = "0x2743CD0", Offset = "0x27426D0", VA = "0x182743CD0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006A7")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6001D38")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "25")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D39")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006A8")]
		[DebuggerNonUserCode]
		public int IsVariationOf
		{
			[Cpp2IlInjected.Token(Token = "0x6001D3A")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0", Slot = "34")]
			get
			{
				return isVariationOf_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D3B")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				isVariationOf_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006A9")]
		[DebuggerNonUserCode]
		public OptionalField VillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x6001D3C")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return villageArea_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D3D")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			set
			{
				villageArea_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006AA")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6001D3E")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0", Slot = "27")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006AB")]
		[DebuggerNonUserCode]
		public int DefaultCurrencyItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6001D3F")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return defaultCurrencyItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D40")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				defaultCurrencyItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006AC")]
		[DebuggerNonUserCode]
		public PriceOverride PriceOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6001D41")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630", Slot = "31")]
			get
			{
				return priceOverride_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D42")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			set
			{
				priceOverride_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006AD")]
		[DebuggerNonUserCode]
		public SubGridInteraction SubGrid
		{
			[Cpp2IlInjected.Token(Token = "0x6001D43")]
			[Cpp2IlInjected.Address(RVA = "0x27439B0", Offset = "0x27423B0", VA = "0x1827439B0", Slot = "32")]
			get
			{
				int num = 0;
				if (interactionsCase_ == InteractionsOneofCase.SubGrid)
				{
					object obj = interactions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001D44")]
			[Cpp2IlInjected.Address(RVA = "0x2743D40", Offset = "0x2742740", VA = "0x182743D40", Slot = "33")]
			set
			{
				interactions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006AE")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6001D45")]
			[Cpp2IlInjected.Address(RVA = "0xDD7050", Offset = "0xDD5A50", VA = "0x180DD7050", Slot = "23")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D46")]
			[Cpp2IlInjected.Address(RVA = "0xDD7110", Offset = "0xDD5B10", VA = "0x180DD7110", Slot = "24")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006AF")]
		[DebuggerNonUserCode]
		public InteractionsOneofCase InteractionsCase
		{
			[Cpp2IlInjected.Token(Token = "0x6001D47")]
			[Cpp2IlInjected.Address(RVA = "0x1024670", Offset = "0x1023070", VA = "0x181024670")]
			get
			{
				return interactionsCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B0")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001D56")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "28")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B1")]
		public Item IsVariationOfItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001D57")]
			[Cpp2IlInjected.Address(RVA = "0x27438F0", Offset = "0x27422F0", VA = "0x1827438F0", Slot = "35")]
			get
			{
				long num = Convert.ToInt64((uint)isVariationOf_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B2")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6001D58")]
			[Cpp2IlInjected.Address(RVA = "0x2743A10", Offset = "0x2742410", VA = "0x182743A10", Slot = "26")]
			get
			{
				ReadOnlyCollection<(TagItemType, int?)> readOnlyCollection = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B3")]
		Item IGenericBuyable.DefaultCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001D59")]
			[Cpp2IlInjected.Address(RVA = "0x2741870", Offset = "0x2740270", VA = "0x182741870", Slot = "29")]
			get
			{
				long num = Convert.ToInt64((uint)defaultCurrencyItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D2A")]
		[Cpp2IlInjected.Address(RVA = "0x2743680", Offset = "0x2742080", VA = "0x182743680")]
		[DebuggerNonUserCode]
		public LandscapingItemData()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			OptionalField optionalField = new OptionalField
			{
				useField_ = false
			};
			int num = (int)(optionalField.VillageArea = VillageAreaType.Beach);
			optionalField.showRandomCheckbox_ = false;
			villageArea_ = optionalField;
			PriceOverride priceOverride = (priceOverride_ = new PriceOverride());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D2B")]
		[Cpp2IlInjected.Address(RVA = "0x2742750", Offset = "0x2741150", VA = "0x182742750")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			OptionalField optionalField = new OptionalField();
			optionalField.useField_ = false;
			int num = (int)(optionalField.VillageArea = VillageAreaType.Beach);
			optionalField.showRandomCheckbox_ = false;
			villageArea_ = optionalField;
			PriceOverride priceOverride = (priceOverride_ = new PriceOverride());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D2C")]
		[Cpp2IlInjected.Address(RVA = "0x2743300", Offset = "0x2741D00", VA = "0x182743300")]
		[DebuggerNonUserCode]
		public LandscapingItemData(LandscapingItemData other)
		{
			//IL_00f0: Expected O, but got I4
			//IL_011e: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_0194: Expected I4, but got O
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			OptionalField optionalField = new OptionalField
			{
				useField_ = false
			};
			int num = (int)(optionalField.VillageArea = VillageAreaType.Beach);
			optionalField.showRandomCheckbox_ = false;
			villageArea_ = optionalField;
			PriceOverride priceOverride = (priceOverride_ = new PriceOverride());
			int num2 = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			GridAreaData gridAreaData2 = other.gridAreaData_;
			int num3 = 0;
			if (gridAreaData2 != null)
			{
				GridAreaData gridAreaData3 = gridAreaData2.Clone();
			}
			gridAreaData_ = (GridAreaData)num3;
			int num4 = (isVariationOf_ = other.isVariationOf_);
			OptionalField optionalField2 = other.villageArea_;
			if (optionalField2 != null)
			{
				OptionalField optionalField3 = optionalField2.Clone();
			}
			villageArea_ = (OptionalField)num3;
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			int num5 = (defaultCurrencyItemID_ = other.defaultCurrencyItemID_);
			PriceOverride priceOverride2 = other.priceOverride_;
			if (priceOverride2 != null)
			{
				PriceOverride priceOverride3 = priceOverride2.Clone();
			}
			priceOverride_ = (PriceOverride)num3;
			uint num6 = (glotID_ = other.glotID_);
			if (other.interactionsCase_ == InteractionsOneofCase.SubGrid)
			{
				if (other.interactions_ == null)
				{
					throw new InvalidCastException();
				}
				SubGridInteraction subGridInteraction = default(SubGridInteraction);
				interactions_ = subGridInteraction;
				interactionsCase_ = (InteractionsOneofCase)subGridInteraction;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D2D")]
		[Cpp2IlInjected.Address(RVA = "0x2741760", Offset = "0x2740160", VA = "0x182741760", Slot = "10")]
		[DebuggerNonUserCode]
		public LandscapingItemData Clone()
		{
			return new LandscapingItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D48")]
		[Cpp2IlInjected.Address(RVA = "0x1E24D20", Offset = "0x1E23720", VA = "0x181E24D20")]
		[DebuggerNonUserCode]
		public void ClearInteractions()
		{
			//IL_0010: Expected O, but got I4
			interactions_ = (interactionsCase_ = InteractionsOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D49")]
		[Cpp2IlInjected.Address(RVA = "0x2741A80", Offset = "0x2740480", VA = "0x182741A80", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((LandscapingItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D4A")]
		[Cpp2IlInjected.Address(RVA = "0x27418D0", Offset = "0x27402D0", VA = "0x1827418D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LandscapingItemData other)
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
									GridAreaData objB = other.gridAreaData_;
									if (object.Equals(gridAreaData_, objB))
									{
										int num2 = other.isVariationOf_;
										if (isVariationOf_ == num2)
										{
											OptionalField objB2 = other.villageArea_;
											if (object.Equals(villageArea_, objB2))
											{
												RepeatedField<int> repeatedField = tags_;
												RepeatedField<int> repeatedField2 = other.tags_;
												if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
												{
													int num3 = other.defaultCurrencyItemID_;
													if (defaultCurrencyItemID_ == num3)
													{
														PriceOverride objB3 = other.priceOverride_;
														if (object.Equals(priceOverride_, objB3))
														{
															SubGridInteraction subGrid = SubGrid;
															SubGridInteraction subGrid2 = other.SubGrid;
															if (object.Equals(subGrid, subGrid2))
															{
																uint num4 = other.glotID_;
																if (glotID_ == num4)
																{
																	InteractionsOneofCase interactionsOneofCase = other.interactionsCase_;
																	if (interactionsCase_ == interactionsOneofCase)
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
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D4B")]
		[Cpp2IlInjected.Address(RVA = "0x2741CA0", Offset = "0x27406A0", VA = "0x182741CA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0118
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != num2)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != num2)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != num2)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != num2)
			{
				int hashCode4 = text4.GetHashCode();
			}
			GridAreaData gridAreaData = gridAreaData_;
			if (gridAreaData != null)
			{
				int hashCode5 = gridAreaData.GetHashCode();
			}
			if (isVariationOf_ != 0)
			{
			}
			OptionalField optionalField = villageArea_;
			if (optionalField != null)
			{
				int hashCode6 = optionalField.GetHashCode();
			}
			int hashCode7 = ((RepeatedField<T>)(object)tags_).GetHashCode();
			if (defaultCurrencyItemID_ != 0)
			{
			}
			PriceOverride priceOverride = priceOverride_;
			if (priceOverride != null)
			{
				int hashCode8 = priceOverride.GetHashCode();
			}
			if (interactionsCase_ == InteractionsOneofCase.SubGrid)
			{
				object obj = interactions_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode9 = obj.GetHashCode();
			}
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode10 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D4C")]
		[Cpp2IlInjected.Address(RVA = "0x2742C80", Offset = "0x2741680", VA = "0x182742C80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D4D")]
		[Cpp2IlInjected.Address(RVA = "0x2742CE0", Offset = "0x27416E0", VA = "0x182742CE0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_017b
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
			if ((long)gridAreaData_ != 0)
			{
				GridAreaData value6 = gridAreaData_;
				output.WriteMessage(value6);
			}
			if (isVariationOf_ != 0)
			{
				int value7 = isVariationOf_;
				output.WriteInt32(value7);
			}
			if ((long)villageArea_ != 0)
			{
				OptionalField value8 = villageArea_;
				output.WriteMessage(value8);
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			if (defaultCurrencyItemID_ != 0)
			{
				int value9 = defaultCurrencyItemID_;
				output.WriteInt32(value9);
			}
			if ((long)priceOverride_ != 0)
			{
				PriceOverride value10 = priceOverride_;
				output.WriteMessage(value10);
			}
			if (interactionsCase_ == InteractionsOneofCase.SubGrid && interactionsCase_ == InteractionsOneofCase.SubGrid)
			{
				object obj = interactions_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (glotID_ != 0)
			{
				uint value11 = glotID_;
				output.WriteUInt32(value11);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D4E")]
		[Cpp2IlInjected.Address(RVA = "0x2741160", Offset = "0x273FB60", VA = "0x182741160", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01db
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != num2)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != num2)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != num2)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != num2)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			GridAreaData gridAreaData = gridAreaData_;
			if (gridAreaData != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(gridAreaData);
				num8++;
				num2 += num8;
			}
			int num9 = isVariationOf_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num2 += num10;
			}
			OptionalField optionalField = villageArea_;
			if (optionalField != null)
			{
				int num11 = CodedOutputStream.ComputeMessageSize(optionalField);
				num11++;
				num2 += num11;
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num12 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			int num13 = defaultCurrencyItemID_;
			num2 += num12;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeInt32Size(num13);
				num14++;
				num2 += num14;
			}
			PriceOverride priceOverride = priceOverride_;
			if (priceOverride != null)
			{
				int num15 = CodedOutputStream.ComputeMessageSize(priceOverride);
				num15++;
				num2 += num15;
			}
			if (interactionsCase_ == InteractionsOneofCase.SubGrid)
			{
				if (interactionsCase_ == InteractionsOneofCase.SubGrid)
				{
					object obj = interactions_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				num2++;
				int num16 = default(int);
				num2 += num16;
			}
			uint num17 = glotID_;
			if (num17 != 0)
			{
				int num18 = CodedOutputStream.ComputeUInt32Size(num17);
				num18 += 2;
				num2 += num18;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num19 = unknownFields.CalculateSize();
				num2 += num19;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D4F")]
		[Cpp2IlInjected.Address(RVA = "0x2742390", Offset = "0x2740D90", VA = "0x182742390", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LandscapingItemData other)
		{
			//Discarded unreachable code: IL_022f
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
			if ((long)other.gridAreaData_ != 0)
			{
				GridAreaData gridAreaData2 = default(GridAreaData);
				if (gridAreaData_ == null)
				{
					GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
					gridAreaData2 = gridAreaData_;
				}
				GridAreaData other2 = other.gridAreaData_;
				gridAreaData2.MergeFrom(other2);
			}
			int num2 = other.isVariationOf_;
			if (num2 != 0)
			{
				isVariationOf_ = num2;
			}
			if ((long)other.villageArea_ != 0)
			{
				OptionalField optionalField2 = default(OptionalField);
				if (villageArea_ == null)
				{
					OptionalField optionalField = (villageArea_ = new OptionalField());
					optionalField2 = villageArea_;
				}
				OptionalField other3 = other.villageArea_;
				optionalField2.MergeFrom(other3);
			}
			RepeatedField<int> repeatedField = tags_;
			RepeatedField<int> repeatedField2 = other.tags_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			int num3 = other.defaultCurrencyItemID_;
			if (num3 != 0)
			{
				defaultCurrencyItemID_ = num3;
			}
			if ((long)other.priceOverride_ != 0)
			{
				PriceOverride priceOverride2 = default(PriceOverride);
				if (priceOverride_ == null)
				{
					PriceOverride priceOverride = (priceOverride_ = new PriceOverride());
					priceOverride2 = priceOverride_;
				}
				PriceOverride other4 = other.priceOverride_;
				priceOverride2.MergeFrom(other4);
			}
			uint num4 = other.glotID_;
			if (num4 != 0)
			{
				glotID_ = num4;
			}
			if (other.interactionsCase_ == InteractionsOneofCase.SubGrid)
			{
				InteractionsOneofCase interactionsOneofCase = interactionsCase_;
				object obj = default(object);
				if (interactionsOneofCase == InteractionsOneofCase.SubGrid)
				{
					obj = interactions_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					SubGridInteraction subGridInteraction = (SubGridInteraction)(interactions_ = new SubGridInteraction());
					interactionsCase_ = interactionsOneofCase;
				}
				if (interactionsCase_ == InteractionsOneofCase.SubGrid)
				{
					object obj2 = interactions_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.interactionsCase_ == InteractionsOneofCase.SubGrid)
				{
					object obj3 = other.interactions_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001D50")]
		[Cpp2IlInjected.Address(RVA = "0x2741F90", Offset = "0x2740990", VA = "0x182741F90", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_006e: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 56)
			{
				if ((int)num > 74)
				{
					if ((int)num > 90)
					{
						if (num == 98)
						{
							SubGridInteraction subGridInteraction = new SubGridInteraction();
							if (interactionsCase_ == InteractionsOneofCase.SubGrid)
							{
								if (interactionsCase_ != InteractionsOneofCase.SubGrid)
								{
								}
								object obj = interactions_;
								if (obj != null && obj == null)
								{
									throw new InvalidCastException();
								}
							}
							input.ReadMessage(subGridInteraction);
							interactions_ = subGridInteraction;
							interactionsCase_ = (InteractionsOneofCase)subGridInteraction;
						}
						if (num != 7992)
						{
							goto IL_01f2;
						}
						int num2 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					int num3 = default(int);
					if (num == 80)
					{
						num3 = (defaultCurrencyItemID_ = input.ReadInt32());
					}
					if (num3 != 90)
					{
						goto IL_01f2;
					}
					PriceOverride builder = default(PriceOverride);
					if (priceOverride_ == null)
					{
						PriceOverride priceOverride = (priceOverride_ = new PriceOverride());
						builder = priceOverride_;
					}
					input.ReadMessage(builder);
				}
				OptionalField optionalField = default(OptionalField);
				if (num == 66)
				{
					OptionalField builder2 = default(OptionalField);
					if (villageArea_ == null)
					{
						optionalField = (villageArea_ = new OptionalField());
						builder2 = villageArea_;
					}
					input.ReadMessage(builder2);
				}
				if ((long)optionalField != 4294967293L)
				{
					goto IL_01f2;
				}
				RepeatedField<int> repeatedField = tags_;
				FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			}
			string text4 = default(string);
			if ((int)num > 26)
			{
				int num4 = default(int);
				if ((int)num > 42)
				{
					GridAreaData gridAreaData = default(GridAreaData);
					if (num == 50)
					{
						GridAreaData builder3 = default(GridAreaData);
						if (gridAreaData_ == null)
						{
							gridAreaData = (gridAreaData_ = new GridAreaData());
							builder3 = gridAreaData_;
						}
						input.ReadMessage(builder3);
					}
					if ((long)gridAreaData != 56)
					{
						goto IL_01f2;
					}
					num4 = (isVariationOf_ = input.ReadInt32());
				}
				string text2 = default(string);
				if (num4 == 34)
				{
					text2 = (IconAddress = input.ReadString());
				}
				if ((long)text2 != 42)
				{
					goto IL_01f2;
				}
				text4 = (PrefabAddress = input.ReadString());
			}
			int num5 = default(int);
			if ((long)text4 == 8)
			{
				num5 = (iD_ = input.ReadInt32());
			}
			string text6 = default(string);
			if (num5 == 18)
			{
				text6 = (Name = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (DisplayName = input.ReadString());
			}
			goto IL_01f2;
			IL_01f2:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001D51")]
		[Cpp2IlInjected.Address(RVA = "0x2741AE0", Offset = "0x27404E0", VA = "0x182741AE0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 11)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D52")]
		[Cpp2IlInjected.Address(RVA = "0x2742840", Offset = "0x2741240", VA = "0x182742840", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0012, IL_0018, IL_001f, IL_0020, IL_0024, IL_0028, IL_0029, IL_002d, IL_0031, IL_0032, IL_0036, IL_003a, IL_003b, IL_003f, IL_0043, IL_0044, IL_0045, IL_0049, IL_004d, IL_004e, IL_0052, IL_0056, IL_005a, IL_005e, IL_006f, IL_0075, IL_007b, IL_0081, IL_0087, IL_008d, IL_0093
			//IL_0011: Expected I4, but got O
			//IL_006e: Expected I4, but got O
			if (fieldNumber - 1 <= 11)
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

		[Cpp2IlInjected.Token(Token = "0x6001D53")]
		[Cpp2IlInjected.Address(RVA = "0x2741510", Offset = "0x273FF10", VA = "0x182741510", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0014, IL_0020, IL_002c, IL_0038, IL_0044, IL_0057, IL_0074, IL_00a7
			//IL_004d: Expected O, but got I4
			//IL_0060: Expected O, but got I4
			//IL_007f: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			if (fieldNumber - 1 <= 11)
			{
				int num = (iD_ = 0);
			}
			else if (fieldNumber == 999)
			{
				int num2 = (int)(glotID_ = 0u);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D54")]
		[Cpp2IlInjected.Address(RVA = "0x2741ED0", Offset = "0x27408D0", VA = "0x182741ED0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Interactions"))
			{
				InteractionsOneofCase interactionsOneofCase = interactionsCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D55")]
		[Cpp2IlInjected.Address(RVA = "0x27416F0", Offset = "0x27400F0", VA = "0x1827416F0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Interactions"))
			{
				interactions_ = (interactionsCase_ = InteractionsOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D5A")]
		[Cpp2IlInjected.Address(RVA = "0x27417C0", Offset = "0x27401C0", VA = "0x1827417C0")]
		public IGridStateData GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			if (interactionsCase_ != InteractionsOneofCase.SubGrid)
			{
				int num = 0;
			}
			if (interactions_ != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D5B")]
		[Cpp2IlInjected.Address(RVA = "0x2741760", Offset = "0x2740160", VA = "0x182741760", Slot = "22")]
		IItemData IItemData.Clone()
		{
			LandscapingItemData landscapingItemData = new LandscapingItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D5C")]
		[Cpp2IlInjected.Address(RVA = "0x2743020", Offset = "0x2741A20", VA = "0x182743020")]
		static LandscapingItemData()
		{
			//Discarded unreachable code: IL_0055
			//IL_0029: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			Func<LandscapingItemData> func = default(Func<LandscapingItemData>);
			_parser = (MessageParser<LandscapingItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<LandscapingItemData>)(object)FieldCodec.ForInt32(74u);
			(TagItemType, int?)[] array = new(TagItemType, int?)[4];
			int num = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num;
			int num2 = 0;
			((ValueTuple<, >[])(object)array)[2] = (ValueTuple<, >)num2;
			int num3 = 0;
			((ValueTuple<, >[])(object)array)[4] = (ValueTuple<, >)num3;
			int num4 = 0;
			((ValueTuple<, >[])(object)array)[5] = (ValueTuple<, >)num4;
			ReadOnlyCollection<(TagItemType, int?)> parser = default(ReadOnlyCollection<(TagItemType, int?)>);
			_parser = (MessageParser<LandscapingItemData>)(object)parser;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D5D")]
		[Cpp2IlInjected.Address(RVA = "0x27417C0", Offset = "0x27401C0", VA = "0x1827417C0", Slot = "30")]
		IGridStateData IGridStateDataProvider.GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			if (interactionsCase_ != InteractionsOneofCase.SubGrid)
			{
				int num = 0;
			}
			if (interactions_ != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}
	}
}
