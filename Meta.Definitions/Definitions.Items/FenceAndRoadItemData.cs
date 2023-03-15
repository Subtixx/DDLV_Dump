using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002D3")]
	public sealed class FenceAndRoadItemData : IMessage<FenceAndRoadItemData>, IMessage, IEquatable<FenceAndRoadItemData>, IDeepCloneable<FenceAndRoadItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IGridPlaceableItemData, IHasTags, IGenericBuyable, IPriceOverrider, IItemIsVariationOf, IItemIsVariationAmountModifier, ICollectionItem
	{
		[Cpp2IlInjected.Token(Token = "0x4000CA1")]
		private static readonly MessageParser<FenceAndRoadItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000CA2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000CA3")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000CA4")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000CA5")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000CA6")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000CA7")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000CA8")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000CA9")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000CAA")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000CAB")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000CAC")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000CAD")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000CAE")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x4000CAF")]
		public const int IsVariationOfFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000CB0")]
		private int isVariationOf_;

		[Cpp2IlInjected.Token(Token = "0x4000CB1")]
		public const int VillageAreaFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000CB2")]
		private OptionalField villageArea_;

		[Cpp2IlInjected.Token(Token = "0x4000CB3")]
		public const int TagsFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4000CB4")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000CB5")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000CB6")]
		public const int DefaultCurrencyItemIDFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000CB7")]
		private int defaultCurrencyItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000CB8")]
		public const int PriceOverrideFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000CB9")]
		private PriceOverride priceOverride_;

		[Cpp2IlInjected.Token(Token = "0x4000CBA")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000CBB")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4000CBC")]
		public static ReadOnlyCollection<(TagItemType tagType, int? limit)> usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x170006E4")]
		[DebuggerNonUserCode]
		public static MessageParser<FenceAndRoadItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001E46")]
			[Cpp2IlInjected.Address(RVA = "0x2CA8DE0", Offset = "0x2CA77E0", VA = "0x182CA8DE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006E5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001E47")]
			[Cpp2IlInjected.Address(RVA = "0x2CA8CB0", Offset = "0x2CA76B0", VA = "0x182CA8CB0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006E6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001E48")]
			[Cpp2IlInjected.Address(RVA = "0x2CA8EA0", Offset = "0x2CA78A0", VA = "0x182CA8EA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006E7")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001E4D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E4E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006E8")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001E4F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E50")]
			[Cpp2IlInjected.Address(RVA = "0x2CA9090", Offset = "0x2CA7A90", VA = "0x182CA9090")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006E9")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6001E51")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E52")]
			[Cpp2IlInjected.Address(RVA = "0x2CA8FB0", Offset = "0x2CA79B0", VA = "0x182CA8FB0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006EA")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001E53")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E54")]
			[Cpp2IlInjected.Address(RVA = "0x2CA9020", Offset = "0x2CA7A20", VA = "0x182CA9020")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006EB")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001E55")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E56")]
			[Cpp2IlInjected.Address(RVA = "0x2CA9100", Offset = "0x2CA7B00", VA = "0x182CA9100")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006EC")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6001E57")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "23")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E58")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006ED")]
		[DebuggerNonUserCode]
		public int IsVariationOf
		{
			[Cpp2IlInjected.Token(Token = "0x6001E59")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0", Slot = "29")]
			get
			{
				return isVariationOf_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E5A")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				isVariationOf_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006EE")]
		[DebuggerNonUserCode]
		public OptionalField VillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x6001E5B")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return villageArea_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E5C")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			set
			{
				villageArea_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006EF")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6001E5D")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0", Slot = "25")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F0")]
		[DebuggerNonUserCode]
		public int DefaultCurrencyItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6001E5E")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return defaultCurrencyItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E5F")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				defaultCurrencyItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F1")]
		[DebuggerNonUserCode]
		public PriceOverride PriceOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6001E60")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630", Slot = "28")]
			get
			{
				return priceOverride_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E61")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			set
			{
				priceOverride_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F2")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6001E62")]
			[Cpp2IlInjected.Address(RVA = "0xDD7050", Offset = "0xDD5A50", VA = "0x180DD7050", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E63")]
			[Cpp2IlInjected.Address(RVA = "0xDD7110", Offset = "0xDD5B10", VA = "0x180DD7110", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F3")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001E6F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "32")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F4")]
		public bool CanBeCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6001E70")]
			[Cpp2IlInjected.Address(RVA = "0x2CA8C60", Offset = "0x2CA7660", VA = "0x182CA8C60", Slot = "33")]
			get
			{
				//Discarded unreachable code: IL_0014
				return !name_.Contains("Ext!");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F5")]
		public Item IsVariationOfItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001E71")]
			[Cpp2IlInjected.Address(RVA = "0x2CA8D80", Offset = "0x2CA7780", VA = "0x182CA8D80", Slot = "30")]
			get
			{
				long num = Convert.ToInt64((uint)isVariationOf_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F6")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6001E72")]
			[Cpp2IlInjected.Address(RVA = "0x2CA8E40", Offset = "0x2CA7840", VA = "0x182CA8E40", Slot = "24")]
			get
			{
				ReadOnlyCollection<(TagItemType, int?)> readOnlyCollection = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F7")]
		Item IGenericBuyable.DefaultCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001E73")]
			[Cpp2IlInjected.Address(RVA = "0x2CA6E90", Offset = "0x2CA5890", VA = "0x182CA6E90", Slot = "27")]
			get
			{
				long num = Convert.ToInt64((uint)defaultCurrencyItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E49")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8AC0", Offset = "0x2CA74C0", VA = "0x182CA8AC0")]
		[DebuggerNonUserCode]
		public FenceAndRoadItemData()
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

		[Cpp2IlInjected.Token(Token = "0x6001E4A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7CE0", Offset = "0x2CA66E0", VA = "0x182CA7CE0")]
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

		[Cpp2IlInjected.Token(Token = "0x6001E4B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA87C0", Offset = "0x2CA71C0", VA = "0x182CA87C0")]
		[DebuggerNonUserCode]
		public FenceAndRoadItemData(FenceAndRoadItemData other)
		{
			//IL_00f0: Expected O, but got I4
			//IL_011e: Expected O, but got I4
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
			PriceOverride priceOverride3 = default(PriceOverride);
			if (priceOverride2 != null)
			{
				priceOverride3 = priceOverride2.Clone();
			}
			priceOverride_ = priceOverride3;
			uint num6 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E4C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6E30", Offset = "0x2CA5830", VA = "0x182CA6E30", Slot = "10")]
		[DebuggerNonUserCode]
		public FenceAndRoadItemData Clone()
		{
			return new FenceAndRoadItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E64")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7050", Offset = "0x2CA5A50", VA = "0x182CA7050", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(FenceAndRoadItemData).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = prefabAddress_;
								bool flag4 = default(bool);
								if (!flag4)
								{
									bool flag5 = object.Equals(gridAreaData_, other);
									if (flag5 && isVariationOf_ == (flag5 ? 1 : 0) && object.Equals(villageArea_, other))
									{
										RepeatedField<int> repeatedField = tags_;
										bool flag6 = default(bool);
										if (flag6 && defaultCurrencyItemID_ == (flag6 ? 1 : 0))
										{
											bool flag7 = object.Equals(priceOverride_, other);
											if (flag7 && glotID_ == (flag7 ? 1u : 0u))
											{
												return object.Equals(_unknownFields, other);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E65")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6EF0", Offset = "0x2CA58F0", VA = "0x182CA6EF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FenceAndRoadItemData other)
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
															uint num4 = other.glotID_;
															if (glotID_ == num4)
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
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E66")]
		[Cpp2IlInjected.Address(RVA = "0x2CA75B0", Offset = "0x2CA5FB0", VA = "0x182CA75B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00f3
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
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
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
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode9 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E67")]
		[Cpp2IlInjected.Address(RVA = "0x2CA81B0", Offset = "0x2CA6BB0", VA = "0x182CA81B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E68")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8210", Offset = "0x2CA6C10", VA = "0x182CA8210", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0155
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
			if (glotID_ != 0)
			{
				uint value11 = glotID_;
				output.WriteUInt32(value11);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E69")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6930", Offset = "0x2CA5330", VA = "0x182CA6930", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01ac
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
			uint num16 = glotID_;
			if (num16 != 0)
			{
				int num17 = CodedOutputStream.ComputeUInt32Size(num16);
				num17 += 2;
				num2 += num17;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num18 = unknownFields.CalculateSize();
				num2 += num18;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E6A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7A90", Offset = "0x2CA6490", VA = "0x182CA7A90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FenceAndRoadItemData other)
		{
			//Discarded unreachable code: IL_01a5
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
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001E6B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7770", Offset = "0x2CA6170", VA = "0x182CA7770", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_01aa
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num <= 50)
			{
				goto IL_00ea;
			}
			if ((int)num > 72)
			{
				if ((int)num > 80)
				{
					if (num == 90)
					{
						PriceOverride priceOverride = priceOverride_;
						if (priceOverride == null)
						{
							PriceOverride priceOverride2 = (priceOverride_ = new PriceOverride());
						}
						input.ReadMessage(priceOverride);
					}
					if (num != 7992)
					{
						goto IL_0193;
					}
					int num2 = (int)(glotID_ = (uint)input.ReadInt32());
				}
				if (num == 74)
				{
					goto IL_00d1;
				}
				if (num != 80)
				{
					goto IL_0193;
				}
				int num3 = (defaultCurrencyItemID_ = input.ReadInt32());
			}
			int num4 = default(int);
			if (num == 56)
			{
				num4 = (isVariationOf_ = input.ReadInt32());
			}
			OptionalField optionalField = default(OptionalField);
			if (num4 == 66)
			{
				OptionalField builder = default(OptionalField);
				if (villageArea_ == null)
				{
					optionalField = (villageArea_ = new OptionalField());
					builder = villageArea_;
				}
				input.ReadMessage(builder);
			}
			if ((long)optionalField == 72)
			{
				goto IL_00d1;
			}
			goto IL_0193;
			IL_00ea:
			GridAreaData gridAreaData = default(GridAreaData);
			if ((int)num > 26)
			{
				string text2 = default(string);
				if (num == 34)
				{
					text2 = (IconAddress = input.ReadString());
				}
				string text4 = default(string);
				if ((long)text2 == 42)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 50)
				{
					goto IL_0193;
				}
				GridAreaData builder2 = default(GridAreaData);
				if (gridAreaData_ == null)
				{
					gridAreaData = (gridAreaData_ = new GridAreaData());
					builder2 = gridAreaData_;
				}
				input.ReadMessage(builder2);
			}
			int num5 = default(int);
			if ((long)gridAreaData == 8)
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
			goto IL_0193;
			IL_0193:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			return;
			IL_00d1:
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			goto IL_00ea;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E6C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7410", Offset = "0x2CA5E10", VA = "0x182CA7410", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 10)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E6D")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7DD0", Offset = "0x2CA67D0", VA = "0x182CA7DD0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0024, IL_002c, IL_0044, IL_004a, IL_0050, IL_0056, IL_005c, IL_0062, IL_0068
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0043: Expected I4, but got O
			if (fieldNumber - 1 <= 10)
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

		[Cpp2IlInjected.Token(Token = "0x6001E6E")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6C60", Offset = "0x2CA5660", VA = "0x182CA6C60", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0017, IL_0018, IL_002b
			//IL_0010: Expected I4, but got I8
			//IL_002a: Expected I4, but got I8
			if (fieldNumber - 1 <= 10)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E74")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7200", Offset = "0x2CA5C00", VA = "0x182CA7200", Slot = "31")]
		public int GetAmountOfVariation(int amount)
		{
			//Discarded unreachable code: IL_0023
			int num = isVariationOf_;
			if ((object)typeof(Item).TypeHandle == null)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num2 = Convert.ToInt64((uint)isVariationOf_);
			}
			return amount;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E75")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6E30", Offset = "0x2CA5830", VA = "0x182CA6E30", Slot = "20")]
		IItemData IItemData.Clone()
		{
			FenceAndRoadItemData fenceAndRoadItemData = new FenceAndRoadItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E76")]
		[Cpp2IlInjected.Address(RVA = "0x2CA84E0", Offset = "0x2CA6EE0", VA = "0x182CA84E0")]
		static FenceAndRoadItemData()
		{
			//Discarded unreachable code: IL_0055
			//IL_0029: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			Func<FenceAndRoadItemData> func = default(Func<FenceAndRoadItemData>);
			_parser = (MessageParser<FenceAndRoadItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<FenceAndRoadItemData>)(object)FieldCodec.ForInt32(74u);
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
			_parser = (MessageParser<FenceAndRoadItemData>)(object)parser;
		}
	}
}
