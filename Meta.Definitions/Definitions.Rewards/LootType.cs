using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000211")]
	public sealed class LootType : IMessage<LootType>, IMessage, IEquatable<LootType>, IDeepCloneable<LootType>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000212")]
		public enum ItemTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000868")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000869")]
			ActivityItem = 3,
			[Cpp2IlInjected.Token(Token = "0x400086A")]
			Furniture = 4,
			[Cpp2IlInjected.Token(Token = "0x400086B")]
			Clothing = 5,
			[Cpp2IlInjected.Token(Token = "0x400086C")]
			Currency = 8,
			[Cpp2IlInjected.Token(Token = "0x400086D")]
			Decal = 10,
			[Cpp2IlInjected.Token(Token = "0x400086E")]
			MemoryShard = 13,
			[Cpp2IlInjected.Token(Token = "0x400086F")]
			ActivityData = 205
		}

		[Cpp2IlInjected.Token(Token = "0x400085C")]
		private static readonly MessageParser<LootType> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400085D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400085E")]
		public const int ActivityItemFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x400085F")]
		public const int FurnitureFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4000860")]
		public const int ClothingFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4000861")]
		public const int CurrencyFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x4000862")]
		public const int DecalFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4000863")]
		public const int MemoryShardFieldNumber = 13;

		[Cpp2IlInjected.Token(Token = "0x4000864")]
		public const int ActivityDataFieldNumber = 205;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000865")]
		private object itemType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000866")]
		private ItemTypeOneofCase itemTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x17000471")]
		[DebuggerNonUserCode]
		public static MessageParser<LootType> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60013E9")]
			[Cpp2IlInjected.Address(RVA = "0x38FE760", Offset = "0x38FD160", VA = "0x1838FE760")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000472")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60013EA")]
			[Cpp2IlInjected.Address(RVA = "0x38FE5D0", Offset = "0x38FCFD0", VA = "0x1838FE5D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000473")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60013EB")]
			[Cpp2IlInjected.Address(RVA = "0x38FE7C0", Offset = "0x38FD1C0", VA = "0x1838FE7C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000474")]
		[DebuggerNonUserCode]
		public LootActivityItem ActivityItem
		{
			[Cpp2IlInjected.Token(Token = "0x60013EF")]
			[Cpp2IlInjected.Address(RVA = "0x38FE450", Offset = "0x38FCE50", VA = "0x1838FE450")]
			get
			{
				int num = 0;
				if (itemTypeCase_ == ItemTypeOneofCase.ActivityItem)
				{
					object obj = itemType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60013F0")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
			set
			{
				itemType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000475")]
		[DebuggerNonUserCode]
		public LootFurnitureItem Furniture
		{
			[Cpp2IlInjected.Token(Token = "0x60013F1")]
			[Cpp2IlInjected.Address(RVA = "0x38FE6A0", Offset = "0x38FD0A0", VA = "0x1838FE6A0")]
			get
			{
				int num = 0;
				if (itemTypeCase_ == ItemTypeOneofCase.Furniture)
				{
					object obj = itemType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60013F2")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D90", Offset = "0x5C4790", VA = "0x1805C5D90")]
			set
			{
				itemType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000476")]
		[DebuggerNonUserCode]
		public LootClothingItem Clothing
		{
			[Cpp2IlInjected.Token(Token = "0x60013F3")]
			[Cpp2IlInjected.Address(RVA = "0x38FE4B0", Offset = "0x38FCEB0", VA = "0x1838FE4B0")]
			get
			{
				int num = 0;
				if (itemTypeCase_ == ItemTypeOneofCase.Clothing)
				{
					object obj = itemType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60013F4")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D50", Offset = "0x5C4750", VA = "0x1805C5D50")]
			set
			{
				itemType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000477")]
		[DebuggerNonUserCode]
		public LootCurrencyItem Currency
		{
			[Cpp2IlInjected.Token(Token = "0x60013F5")]
			[Cpp2IlInjected.Address(RVA = "0x38FE510", Offset = "0x38FCF10", VA = "0x1838FE510")]
			get
			{
				int num = 0;
				if (itemTypeCase_ == ItemTypeOneofCase.Currency)
				{
					object obj = itemType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60013F6")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E50", Offset = "0x5C4850", VA = "0x1805C5E50")]
			set
			{
				itemType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000478")]
		[DebuggerNonUserCode]
		public LootItem Decal
		{
			[Cpp2IlInjected.Token(Token = "0x60013F7")]
			[Cpp2IlInjected.Address(RVA = "0x38FE570", Offset = "0x38FCF70", VA = "0x1838FE570")]
			get
			{
				int num = 0;
				if (itemTypeCase_ == ItemTypeOneofCase.Decal)
				{
					object obj = itemType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60013F8")]
			[Cpp2IlInjected.Address(RVA = "0x1D16FC0", Offset = "0x1D159C0", VA = "0x181D16FC0")]
			set
			{
				itemType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000479")]
		[DebuggerNonUserCode]
		public LootItem MemoryShard
		{
			[Cpp2IlInjected.Token(Token = "0x60013F9")]
			[Cpp2IlInjected.Address(RVA = "0x38FE700", Offset = "0x38FD100", VA = "0x1838FE700")]
			get
			{
				int num = 0;
				if (itemTypeCase_ == ItemTypeOneofCase.MemoryShard)
				{
					object obj = itemType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60013FA")]
			[Cpp2IlInjected.Address(RVA = "0x1D17040", Offset = "0x1D15A40", VA = "0x181D17040")]
			set
			{
				itemType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047A")]
		[DebuggerNonUserCode]
		public LootActivityDataItem ActivityData
		{
			[Cpp2IlInjected.Token(Token = "0x60013FB")]
			[Cpp2IlInjected.Address(RVA = "0x38FE3F0", Offset = "0x38FCDF0", VA = "0x1838FE3F0")]
			get
			{
				int num = 0;
				if (itemTypeCase_ == ItemTypeOneofCase.ActivityData)
				{
					object obj = itemType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60013FC")]
			[Cpp2IlInjected.Address(RVA = "0x38FE8D0", Offset = "0x38FD2D0", VA = "0x1838FE8D0")]
			set
			{
				itemType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047B")]
		[DebuggerNonUserCode]
		public ItemTypeOneofCase ItemTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x60013FD")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return itemTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013EC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LootType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60013ED")]
		[Cpp2IlInjected.Address(RVA = "0x38FDE10", Offset = "0x38FC810", VA = "0x1838FDE10")]
		[DebuggerNonUserCode]
		public LootType(LootType other)
		{
			//IL_0069: Expected I4, but got I8
			//IL_00bf: Expected I4, but got I8
			//IL_0115: Expected I4, but got I8
			//IL_016b: Expected I4, but got I8
			//IL_0188: Expected I4, but got O
			//IL_01a5: Expected I4, but got O
			//IL_01f3: Expected I4, but got I8
			ItemTypeOneofCase itemTypeOneofCase = other.itemTypeCase_;
			LootActivityItem activityItem = other.ActivityItem;
			LootActivityItem lootActivityItem = new LootActivityItem();
			LootActivityItem.ActivityItemOneofCase activityItemCase_ = activityItem.activityItemCase_;
			if (activityItemCase_ == LootActivityItem.ActivityItemOneofCase.ActivityItemType)
			{
				int activityItemType = (int)activityItem.ActivityItemType;
				lootActivityItem.activityItem_ = typeof(ActivityItemType).TypeHandle;
			}
			if (activityItemCase_ == LootActivityItem.ActivityItemOneofCase.CropType)
			{
				CropType cropType = activityItem.CropType;
			}
			UnknownFieldSet unknownFieldSet = (lootActivityItem._unknownFields = UnknownFieldSet.Clone(activityItem._unknownFields));
			itemType_ = lootActivityItem;
			itemTypeCase_ = ItemTypeOneofCase.ActivityItem;
			LootFurnitureItem furniture = other.Furniture;
			LootFurnitureItem lootFurnitureItem = new LootFurnitureItem();
			if (furniture.furnitureItemCase_ == LootFurnitureItem.FurnitureItemOneofCase.FurnitureItemType)
			{
				int furnitureItemType = (int)furniture.FurnitureItemType;
				lootFurnitureItem.furnitureItem_ = typeof(FurnitureItemType).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet2 = (lootFurnitureItem._unknownFields = UnknownFieldSet.Clone(furniture._unknownFields));
			itemType_ = lootFurnitureItem;
			itemTypeCase_ = ItemTypeOneofCase.Furniture;
			LootClothingItem clothing = other.Clothing;
			LootClothingItem lootClothingItem = new LootClothingItem();
			if (clothing.clothingItemCase_ == LootClothingItem.ClothingItemOneofCase.ClothingItemType)
			{
				int clothingItemType = (int)clothing.ClothingItemType;
				lootClothingItem.clothingItem_ = typeof(ClothingItemType).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet3 = (lootClothingItem._unknownFields = UnknownFieldSet.Clone(clothing._unknownFields));
			itemType_ = lootClothingItem;
			itemTypeCase_ = ItemTypeOneofCase.Clothing;
			LootCurrencyItem currency = other.Currency;
			LootCurrencyItem lootCurrencyItem = new LootCurrencyItem();
			if (currency.currencyItemCase_ == LootCurrencyItem.CurrencyItemOneofCase.CurrencyType)
			{
				int currencyType = (int)currency.CurrencyType;
				lootCurrencyItem.currencyItem_ = typeof(CurrencyType).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet4 = (lootCurrencyItem._unknownFields = UnknownFieldSet.Clone(currency._unknownFields));
			itemType_ = lootCurrencyItem;
			itemTypeCase_ = ItemTypeOneofCase.Currency;
			itemTypeCase_ = (ItemTypeOneofCase)(itemType_ = other.Decal.Clone());
			itemTypeCase_ = (ItemTypeOneofCase)(itemType_ = other.MemoryShard.Clone());
			if (itemTypeOneofCase == ItemTypeOneofCase.ActivityData)
			{
				ItemTypeOneofCase itemTypeOneofCase2 = other.itemTypeCase_;
				if (other.itemType_ == null)
				{
					throw new InvalidCastException();
				}
				LootActivityDataItem lootActivityDataItem = new LootActivityDataItem();
				ActivityDataItemType activityDataItemType = default(ActivityDataItemType);
				int num = (int)activityDataItemType;
				lootActivityDataItem.activityDataItem_ = typeof(ActivityDataItemType).TypeHandle;
				UnknownFieldSet unknownFields = default(UnknownFieldSet);
				lootActivityDataItem._unknownFields = unknownFields;
				itemType_ = lootActivityDataItem;
				itemTypeCase_ = ItemTypeOneofCase.ActivityData;
			}
			UnknownFieldSet unknownFieldSet5 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60013EE")]
		[Cpp2IlInjected.Address(RVA = "0x38FC1E0", Offset = "0x38FABE0", VA = "0x1838FC1E0", Slot = "10")]
		[DebuggerNonUserCode]
		public LootType Clone()
		{
			return new LootType(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60013FE")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearItemType()
		{
			//IL_0010: Expected O, but got I4
			itemType_ = (itemTypeCase_ = ItemTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60013FF")]
		[Cpp2IlInjected.Address(RVA = "0x38FC450", Offset = "0x38FAE50", VA = "0x1838FC450", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001400")]
		[Cpp2IlInjected.Address(RVA = "0x38FC240", Offset = "0x38FAC40", VA = "0x1838FC240", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LootType other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (itemTypeCase_ == ItemTypeOneofCase.ActivityItem)
				{
					object obj = itemType_;
					if (obj != null && obj == null)
					{
						goto IL_0134;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.itemTypeCase_ == ItemTypeOneofCase.ActivityItem)
				{
					obj2 = other.itemType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					LootFurnitureItem furniture = Furniture;
					LootFurnitureItem furniture2 = other.Furniture;
					if (object.Equals(furniture, furniture2))
					{
						LootClothingItem clothing = Clothing;
						LootClothingItem clothing2 = other.Clothing;
						if (object.Equals(clothing, clothing2))
						{
							LootCurrencyItem currency = Currency;
							LootCurrencyItem currency2 = other.Currency;
							if (object.Equals(currency, currency2))
							{
								LootItem decal = Decal;
								LootItem decal2 = other.Decal;
								if (object.Equals(decal, decal2))
								{
									LootItem memoryShard = MemoryShard;
									LootItem memoryShard2 = other.MemoryShard;
									if (object.Equals(memoryShard, memoryShard2))
									{
										LootActivityDataItem activityData = ActivityData;
										LootActivityDataItem activityData2 = other.ActivityData;
										if (object.Equals(activityData, activityData2))
										{
											ItemTypeOneofCase itemTypeOneofCase = other.itemTypeCase_;
											if (itemTypeCase_ == itemTypeOneofCase)
											{
												UnknownFieldSet unknownFields = other._unknownFields;
												bool flag = object.Equals(_unknownFields, unknownFields);
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
			goto IL_0134;
			IL_0134:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001401")]
		[Cpp2IlInjected.Address(RVA = "0x38FC630", Offset = "0x38FB030", VA = "0x1838FC630", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0107
			while (true)
			{
				ItemTypeOneofCase itemTypeOneofCase = itemTypeCase_;
				int num = 0;
				if (itemTypeOneofCase == ItemTypeOneofCase.ActivityItem)
				{
					object obj = itemType_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (itemTypeOneofCase != ItemTypeOneofCase.Furniture)
				{
					continue;
				}
				object obj2 = itemType_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (itemTypeCase_ != ItemTypeOneofCase.Clothing)
					{
						continue;
					}
					object obj3 = itemType_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (itemTypeCase_ != ItemTypeOneofCase.Currency)
						{
							continue;
						}
						object obj4 = itemType_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (itemTypeCase_ != ItemTypeOneofCase.Decal)
							{
								continue;
							}
							object obj5 = itemType_;
							if (obj5 != null)
							{
								int hashCode5 = obj5.GetHashCode();
								if (itemTypeCase_ != ItemTypeOneofCase.MemoryShard)
								{
									continue;
								}
								object obj6 = itemType_;
								if (obj6 != null)
								{
									int hashCode6 = obj6.GetHashCode();
									if (itemTypeCase_ == ItemTypeOneofCase.ActivityData)
									{
										object obj7 = itemType_;
										if (obj7 == null)
										{
											break;
										}
										int hashCode7 = obj7.GetHashCode();
									}
									UnknownFieldSet unknownFields = _unknownFields;
									if (unknownFields != null)
									{
										int hashCode8 = unknownFields.GetHashCode();
									}
									return 1;
								}
							}
							throw new InvalidCastException();
						}
						throw new InvalidCastException();
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001402")]
		[Cpp2IlInjected.Address(RVA = "0x38FD920", Offset = "0x38FC320", VA = "0x1838FD920", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001403")]
		[Cpp2IlInjected.Address(RVA = "0x38FD980", Offset = "0x38FC380", VA = "0x1838FD980", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0136
			//IL_002f: Expected O, but got I4
			while (true)
			{
				ItemTypeOneofCase itemTypeOneofCase = itemTypeCase_;
				int num = 0;
				if (itemTypeOneofCase == ItemTypeOneofCase.ActivityItem)
				{
					if (itemTypeCase_ == ItemTypeOneofCase.ActivityItem)
					{
						object obj = itemType_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (itemTypeOneofCase != ItemTypeOneofCase.Furniture)
				{
					continue;
				}
				if (itemTypeCase_ == ItemTypeOneofCase.Furniture)
				{
					object obj2 = itemType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (itemTypeCase_ != ItemTypeOneofCase.Clothing)
				{
					continue;
				}
				if (itemTypeCase_ == ItemTypeOneofCase.Clothing)
				{
					object obj3 = itemType_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (itemTypeCase_ != ItemTypeOneofCase.Currency)
				{
					continue;
				}
				if (itemTypeCase_ == ItemTypeOneofCase.Currency)
				{
					object obj4 = itemType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (itemTypeCase_ != ItemTypeOneofCase.Decal)
				{
					continue;
				}
				if (itemTypeCase_ == ItemTypeOneofCase.Decal)
				{
					object obj5 = itemType_;
					if (obj5 != null && obj5 == null)
					{
						break;
					}
				}
				if (itemTypeCase_ != ItemTypeOneofCase.MemoryShard)
				{
					continue;
				}
				if (itemTypeCase_ == ItemTypeOneofCase.MemoryShard)
				{
					object obj6 = itemType_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (itemTypeCase_ == ItemTypeOneofCase.ActivityData && itemTypeCase_ == ItemTypeOneofCase.ActivityData)
				{
					object obj7 = itemType_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001404")]
		[Cpp2IlInjected.Address(RVA = "0x38FBD10", Offset = "0x38FA710", VA = "0x1838FBD10", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (itemTypeCase_ == ItemTypeOneofCase.ActivityItem)
			{
				if (itemTypeCase_ == ItemTypeOneofCase.ActivityItem)
				{
					object obj = itemType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (itemTypeCase_ == ItemTypeOneofCase.Furniture)
			{
				if (itemTypeCase_ != ItemTypeOneofCase.Furniture)
				{
				}
				object obj2 = itemType_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (itemTypeCase_ == ItemTypeOneofCase.Clothing)
			{
				if (itemTypeCase_ != ItemTypeOneofCase.Clothing)
				{
				}
				object obj3 = itemType_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (itemTypeCase_ == ItemTypeOneofCase.Currency)
			{
				if (itemTypeCase_ != ItemTypeOneofCase.Currency)
				{
				}
				object obj4 = itemType_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (itemTypeCase_ == ItemTypeOneofCase.Decal)
			{
				if (itemTypeCase_ != ItemTypeOneofCase.Decal)
				{
				}
				object obj5 = itemType_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (itemTypeCase_ == ItemTypeOneofCase.MemoryShard)
			{
				if (itemTypeCase_ != ItemTypeOneofCase.MemoryShard)
				{
				}
				object obj6 = itemType_;
				if (obj6 != null && obj6 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			if (itemTypeCase_ == ItemTypeOneofCase.ActivityData)
			{
				if (itemTypeCase_ == ItemTypeOneofCase.ActivityData)
				{
					object obj7 = itemType_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				num += 2;
				int num8 = default(int);
				num += num8;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num9 = unknownFields.CalculateSize();
				num += num9;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001405")]
		[Cpp2IlInjected.Address(RVA = "0x38FD160", Offset = "0x38FBB60", VA = "0x1838FD160", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LootType other)
		{
			//Discarded unreachable code: IL_00cb, IL_00d4, IL_00eb, IL_00f3, IL_00f8, IL_0102, IL_0114, IL_012b, IL_0133, IL_0138, IL_0142, IL_0157, IL_0175, IL_017d, IL_0182, IL_018b, IL_01a9, IL_01bc, IL_01c5, IL_01dc, IL_01e4, IL_01e9, IL_01f3
			//IL_002f: Expected I4, but got O
			//IL_0061: Expected I4, but got O
			//IL_00eb: Expected I4, but got O
			//IL_012b: Expected I4, but got O
			//IL_0165: Expected O, but got I4
			//IL_0175: Expected I4, but got O
			//IL_0199: Expected O, but got I4
			//IL_01a9: Expected I4, but got O
			//IL_01dc: Expected I4, but got O
			while (other != null)
			{
				if ((long)typeof(LootItem).TypeHandle > 10)
				{
					continue;
				}
				if (ActivityItem == null)
				{
					itemTypeCase_ = (ItemTypeOneofCase)(itemType_ = new LootActivityItem());
				}
				LootActivityItem activityItem = ActivityItem;
				LootActivityItem activityItem2 = other.ActivityItem;
				activityItem.MergeFrom(activityItem2);
				if (Furniture == null)
				{
					itemTypeCase_ = (ItemTypeOneofCase)(itemType_ = new LootFurnitureItem());
				}
				LootFurnitureItem furniture = Furniture;
				LootFurnitureItem furniture2 = other.Furniture;
				if (furniture2 != null)
				{
					if (furniture2.furnitureItemCase_ == LootFurnitureItem.FurnitureItemOneofCase.FurnitureItemType)
					{
						FurnitureItemType furnitureItemType = furniture2.FurnitureItemType;
					}
					UnknownFieldSet unknownFields = furniture2._unknownFields;
					UnknownFieldSet unknownFieldSet = (furniture._unknownFields = UnknownFieldSet.MergeFrom(furniture._unknownFields, unknownFields));
				}
				UnknownFieldSet unknownFields2 = other._unknownFields;
				UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001406")]
		[Cpp2IlInjected.Address(RVA = "0x38FCA40", Offset = "0x38FB440", VA = "0x1838FCA40", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_007f: Expected I4, but got O
			//IL_00f0: Expected I4, but got O
			//IL_0156: Expected I4, but got O
			//IL_016f: Expected O, but got I4
			//IL_01c7: Expected I4, but got O
			//IL_0216: Expected I4, but got O
			//IL_027e: Expected I4, but got O
			//IL_02e0: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 82)
				{
					if (num == 106)
					{
						int fieldNumber = 0;
						LootItem lootItem = default(LootItem);
						lootItem.ClearFieldValue(fieldNumber);
						if (itemTypeCase_ == ItemTypeOneofCase.MemoryShard)
						{
							if (itemTypeCase_ != ItemTypeOneofCase.MemoryShard)
							{
							}
							object obj = itemType_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
							if (obj != null)
							{
								UnknownFieldSet unknownFields = lootItem._unknownFields;
								UnknownFieldSet unknownFields2 = default(UnknownFieldSet);
								lootItem._unknownFields = unknownFields2;
							}
						}
						input.ReadMessage(lootItem);
						itemType_ = lootItem;
						itemTypeCase_ = (ItemTypeOneofCase)lootItem;
					}
					if (num != 1642)
					{
						goto IL_02e0;
					}
					LootActivityDataItem lootActivityDataItem = new LootActivityDataItem();
					UnknownFieldSet unknownFieldSet = default(UnknownFieldSet);
					if (itemTypeCase_ == ItemTypeOneofCase.ActivityData)
					{
						if (itemTypeCase_ != ItemTypeOneofCase.ActivityData)
						{
						}
						object obj2 = itemType_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
						if (obj2 != null)
						{
							UnknownFieldSet unknownFields3 = lootActivityDataItem._unknownFields;
							lootActivityDataItem._unknownFields = unknownFieldSet;
						}
					}
					input.ReadMessage(lootActivityDataItem);
					itemType_ = lootActivityDataItem;
					itemTypeCase_ = (ItemTypeOneofCase)unknownFieldSet;
				}
				UnknownFieldSet unknownFieldSet2 = default(UnknownFieldSet);
				int num2 = default(int);
				if (num == 66)
				{
					LootCurrencyItem lootCurrencyItem = new LootCurrencyItem();
					if (itemTypeCase_ == ItemTypeOneofCase.Currency)
					{
						if (itemTypeCase_ != ItemTypeOneofCase.Currency)
						{
						}
						object obj3 = itemType_;
						if (obj3 != null && obj3 == null)
						{
							throw new InvalidCastException();
						}
						if (obj3 != null)
						{
							UnknownFieldSet unknownFields4 = lootCurrencyItem._unknownFields;
							lootCurrencyItem._unknownFields = unknownFieldSet2;
						}
					}
					num2 = 0;
					input.ReadMessage(lootCurrencyItem);
					itemType_ = lootCurrencyItem;
					itemTypeCase_ = (ItemTypeOneofCase)unknownFieldSet2;
				}
				if ((long)unknownFieldSet2 != 82)
				{
					goto IL_02e0;
				}
				int fieldNumber2 = 0;
				LootItem lootItem2 = default(LootItem);
				lootItem2.SetFieldValue(fieldNumber2, num2);
				UnknownFieldSet unknownFieldSet3 = default(UnknownFieldSet);
				if (itemTypeCase_ == ItemTypeOneofCase.Decal)
				{
					if (itemTypeCase_ != ItemTypeOneofCase.Decal)
					{
					}
					object obj4 = itemType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
					if (obj4 != null)
					{
						UnknownFieldSet unknownFields5 = lootItem2._unknownFields;
						lootItem2._unknownFields = unknownFieldSet3;
					}
				}
				input.ReadMessage(lootItem2);
				itemType_ = lootItem2;
				itemTypeCase_ = (ItemTypeOneofCase)unknownFieldSet3;
			}
			if (num == 26)
			{
				LootActivityItem builder = new LootActivityItem();
				if (itemTypeCase_ == ItemTypeOneofCase.ActivityItem)
				{
					if (itemTypeCase_ != ItemTypeOneofCase.ActivityItem)
					{
					}
					object obj5 = itemType_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				itemType_ = builder;
				itemTypeCase_ = (ItemTypeOneofCase)typeof(LootActivityItem).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet4 = default(UnknownFieldSet);
			if ((long)typeof(LootActivityItem).TypeHandle == 34)
			{
				LootFurnitureItem lootFurnitureItem = new LootFurnitureItem();
				if (itemTypeCase_ == ItemTypeOneofCase.Furniture)
				{
					if (itemTypeCase_ != ItemTypeOneofCase.Furniture)
					{
					}
					object obj6 = itemType_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
					if (obj6 != null)
					{
						UnknownFieldSet unknownFields6 = lootFurnitureItem._unknownFields;
						lootFurnitureItem._unknownFields = unknownFieldSet4;
					}
				}
				input.ReadMessage(lootFurnitureItem);
				itemType_ = lootFurnitureItem;
				itemTypeCase_ = (ItemTypeOneofCase)unknownFieldSet4;
			}
			if ((long)unknownFieldSet4 == 42)
			{
				LootClothingItem lootClothingItem = new LootClothingItem();
				UnknownFieldSet unknownFieldSet5 = default(UnknownFieldSet);
				if (itemTypeCase_ == ItemTypeOneofCase.Clothing)
				{
					if (itemTypeCase_ != ItemTypeOneofCase.Clothing)
					{
					}
					object obj7 = itemType_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
					if (obj7 != null)
					{
						UnknownFieldSet unknownFields7 = lootClothingItem._unknownFields;
						lootClothingItem._unknownFields = unknownFieldSet5;
					}
				}
				input.ReadMessage(lootClothingItem);
				itemType_ = lootClothingItem;
				itemTypeCase_ = (ItemTypeOneofCase)unknownFieldSet5;
			}
			goto IL_02e0;
			IL_02e0:
			UnknownFieldSet unknownFieldSet6 = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001407")]
		[Cpp2IlInjected.Address(RVA = "0x38FC4B0", Offset = "0x38FAEB0", VA = "0x1838FC4B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			LootActivityItem activityItem = ActivityItem;
			LootFurnitureItem furniture = Furniture;
			LootClothingItem clothing = Clothing;
			LootCurrencyItem currency = Currency;
			LootItem decal = Decal;
			LootItem memoryShard = MemoryShard;
			if (fieldNumber == 205)
			{
				while (itemTypeCase_ != ItemTypeOneofCase.ActivityData)
				{
				}
				object obj = itemType_;
				while (obj == null)
				{
				}
				if (obj == null)
				{
					goto IL_0064;
				}
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			goto IL_0064;
			IL_0064:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001408")]
		[Cpp2IlInjected.Address(RVA = "0x38FD620", Offset = "0x38FC020", VA = "0x1838FD620", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002e, IL_0032, IL_0039, IL_0041, IL_0045, IL_004c, IL_0054, IL_0058, IL_005c, IL_0064, IL_0068, IL_006c, IL_0074, IL_0078, IL_007c, IL_00b3, IL_00b9, IL_00bf, IL_00c5, IL_00cb
			//IL_0022: Expected O, but got I4
			//IL_002d: Expected I4, but got O
			//IL_00a6: Expected I4, but got O
			if ((long)typeof(LootItem).TypeHandle <= 10)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				itemType_ = num;
				itemTypeCase_ = (ItemTypeOneofCase)typeof(LootItem).TypeHandle;
			}
			else
			{
				while (fieldNumber != 205)
				{
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				itemType_ = value;
				itemTypeCase_ = (ItemTypeOneofCase)typeof(LootItem).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001409")]
		[Cpp2IlInjected.Address(RVA = "0x38FC0F0", Offset = "0x38FAAF0", VA = "0x1838FC0F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0011: Expected O, but got I4
			if (fieldNumber == 205)
			{
				int num = 0;
				itemType_ = num;
				itemTypeCase_ = (ItemTypeOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600140A")]
		[Cpp2IlInjected.Address(RVA = "0x38FC990", Offset = "0x38FB390", VA = "0x1838FC990", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "ItemType"))
			{
				ItemTypeOneofCase itemTypeOneofCase = itemTypeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600140B")]
		[Cpp2IlInjected.Address(RVA = "0x38FC170", Offset = "0x38FAB70", VA = "0x1838FC170", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "ItemType"))
			{
				itemType_ = (itemTypeCase_ = ItemTypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600140C")]
		[Cpp2IlInjected.Address(RVA = "0x38FDD00", Offset = "0x38FC700", VA = "0x1838FDD00")]
		static LootType()
		{
			Func<LootType> func = default(Func<LootType>);
			_parser = (MessageParser<LootType>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
