using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005C0")]
	public sealed class CollectionGroup : IMessage<CollectionGroup>, IMessage, IEquatable<CollectionGroup>, IDeepCloneable<CollectionGroup>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001F64")]
		private static readonly MessageParser<CollectionGroup> _parser = (MessageParser<CollectionGroup>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new CollectionGroup()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F65")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001F66")]
		public const int CollectionsByItemFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001F67")]
		private static readonly FieldCodec<CollectionItemList> _repeated_collectionsByItem_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F68")]
		private readonly RepeatedField<CollectionItemList> collectionsByItem_ = (RepeatedField<CollectionItemList>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001F69")]
		public const int CollectionsByTypeFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4001F6A")]
		private static readonly FieldCodec<CollectionItemType> _repeated_collectionsByType_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001F6B")]
		private readonly RepeatedField<CollectionItemType> collectionsByType_ = (RepeatedField<CollectionItemType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700128F")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectionGroup> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60047C8")]
			[Cpp2IlInjected.Address(RVA = "0x2ECF3C0", Offset = "0x2ECDDC0", VA = "0x182ECF3C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001290")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60047C9")]
			[Cpp2IlInjected.Address(RVA = "0x2ECF2F0", Offset = "0x2ECDCF0", VA = "0x182ECF2F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001291")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60047CA")]
			[Cpp2IlInjected.Address(RVA = "0x2ECF420", Offset = "0x2ECDE20", VA = "0x182ECF420", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001292")]
		[DebuggerNonUserCode]
		public RepeatedField<CollectionItemList> CollectionsByItem
		{
			[Cpp2IlInjected.Token(Token = "0x60047CE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return collectionsByItem_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001293")]
		[DebuggerNonUserCode]
		public RepeatedField<CollectionItemType> CollectionsByType
		{
			[Cpp2IlInjected.Token(Token = "0x60047CF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return collectionsByType_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047CB")]
		[Cpp2IlInjected.Address(RVA = "0x2ECF230", Offset = "0x2ECDC30", VA = "0x182ECF230")]
		[DebuggerNonUserCode]
		public CollectionGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60047CC")]
		[Cpp2IlInjected.Address(RVA = "0x2ECF0B0", Offset = "0x2ECDAB0", VA = "0x182ECF0B0")]
		[DebuggerNonUserCode]
		public CollectionGroup(CollectionGroup other)
		{
			RepeatedField<CollectionItemList> repeatedField = (collectionsByItem_ = (RepeatedField<CollectionItemList>)(object)((RepeatedField<T>)(object)other.collectionsByItem_).Clone());
			RepeatedField<CollectionItemType> repeatedField2 = (collectionsByType_ = (RepeatedField<CollectionItemType>)(object)((RepeatedField<T>)(object)other.collectionsByType_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047CD")]
		[Cpp2IlInjected.Address(RVA = "0x2ECB7E0", Offset = "0x2ECA1E0", VA = "0x182ECB7E0", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectionGroup Clone()
		{
			//Discarded unreachable code: IL_005f
			CollectionGroup collectionGroup = new CollectionGroup();
			RepeatedField<CollectionItemList> repeatedField = (collectionGroup.collectionsByItem_ = (RepeatedField<CollectionItemList>)(object)new RepeatedField<T>());
			RepeatedField<CollectionItemType> repeatedField2 = (collectionGroup.collectionsByType_ = (RepeatedField<CollectionItemType>)(object)new RepeatedField<T>());
			RepeatedField<CollectionItemList> repeatedField3 = (collectionGroup.collectionsByItem_ = (RepeatedField<CollectionItemList>)(object)((RepeatedField<T>)(object)collectionsByItem_).Clone());
			RepeatedField<CollectionItemType> repeatedField4 = (collectionGroup.collectionsByType_ = (RepeatedField<CollectionItemType>)(object)((RepeatedField<T>)(object)collectionsByType_).Clone());
			UnknownFieldSet unknownFieldSet = (collectionGroup._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return collectionGroup;
		}

		[Cpp2IlInjected.Token(Token = "0x60047D0")]
		[Cpp2IlInjected.Address(RVA = "0x2ECBA50", Offset = "0x2ECA450", VA = "0x182ECBA50", Slot = "0")]
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
				RepeatedField<CollectionItemList> repeatedField = collectionsByItem_;
				bool flag = default(bool);
				if (flag)
				{
					RepeatedField<CollectionItemType> repeatedField2 = collectionsByType_;
					bool flag2 = default(bool);
					if (flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047D1")]
		[Cpp2IlInjected.Address(RVA = "0x2ECB990", Offset = "0x2ECA390", VA = "0x182ECB990", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectionGroup other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<CollectionItemList> repeatedField = collectionsByItem_;
				RepeatedField<CollectionItemList> repeatedField2 = other.collectionsByItem_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					RepeatedField<CollectionItemType> repeatedField3 = collectionsByType_;
					RepeatedField<CollectionItemType> repeatedField4 = other.collectionsByType_;
					if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047D2")]
		[Cpp2IlInjected.Address(RVA = "0x13AB0A0", Offset = "0x13A9AA0", VA = "0x1813AB0A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002c
			int hashCode = ((RepeatedField<T>)(object)collectionsByItem_).GetHashCode();
			int hashCode2 = ((RepeatedField<T>)(object)collectionsByType_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode2;
		}

		[Cpp2IlInjected.Token(Token = "0x60047D3")]
		[Cpp2IlInjected.Address(RVA = "0x2ECECD0", Offset = "0x2ECD6D0", VA = "0x182ECECD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60047D4")]
		[Cpp2IlInjected.Address(RVA = "0x2ECED30", Offset = "0x2ECD730", VA = "0x182ECED30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0040
			RepeatedField<CollectionItemList> repeatedField = collectionsByItem_;
			FieldCodec<CollectionItemList> repeated_collectionsByItem_codec = _repeated_collectionsByItem_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_collectionsByItem_codec);
			RepeatedField<CollectionItemType> repeatedField2 = collectionsByType_;
			FieldCodec<CollectionItemType> repeated_collectionsByType_codec = _repeated_collectionsByType_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_collectionsByType_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60047D5")]
		[Cpp2IlInjected.Address(RVA = "0x2ECB680", Offset = "0x2ECA080", VA = "0x182ECB680", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			RepeatedField<CollectionItemList> repeatedField = collectionsByItem_;
			FieldCodec<CollectionItemList> repeated_collectionsByItem_codec = _repeated_collectionsByItem_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_collectionsByItem_codec);
			RepeatedField<CollectionItemType> repeatedField2 = collectionsByType_;
			FieldCodec<CollectionItemType> repeated_collectionsByType_codec = _repeated_collectionsByType_codec;
			int num2 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_collectionsByType_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<CollectionItemList>)(repeatedField + num3);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047D6")]
		[Cpp2IlInjected.Address(RVA = "0x2ECEB80", Offset = "0x2ECD580", VA = "0x182ECEB80", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectionGroup other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				RepeatedField<CollectionItemList> repeatedField = collectionsByItem_;
				RepeatedField<CollectionItemList> repeatedField2 = other.collectionsByItem_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				RepeatedField<CollectionItemType> repeatedField3 = collectionsByType_;
				RepeatedField<CollectionItemType> repeatedField4 = other.collectionsByType_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047D7")]
		[Cpp2IlInjected.Address(RVA = "0x2ECEA20", Offset = "0x2ECD420", VA = "0x182ECEA20", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005b
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<CollectionItemList> repeatedField = collectionsByItem_;
					FieldCodec<CollectionItemList> repeated_collectionsByItem_codec = _repeated_collectionsByItem_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_collectionsByItem_codec);
				}
				if (num == 18)
				{
					RepeatedField<CollectionItemType> repeatedField2 = collectionsByType_;
					FieldCodec<CollectionItemType> repeated_collectionsByType_codec = _repeated_collectionsByType_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_collectionsByType_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047D8")]
		[Cpp2IlInjected.Address(RVA = "0x2ECBB50", Offset = "0x2ECA550", VA = "0x182ECBB50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<CollectionItemList> repeatedField = collectionsByItem_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<CollectionItemType> repeatedField2 = collectionsByType_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60047D9")]
		[Cpp2IlInjected.Address(RVA = "0x2ECEC20", Offset = "0x2ECD620", VA = "0x182ECEC20", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			switch (fieldNumber)
			{
			default:
				return;
			case 1:
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				break;
			}
			case 2:
				break;
			}
			InvalidOperationException ex2 = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60047DA")]
		[Cpp2IlInjected.Address(RVA = "0x2ECB770", Offset = "0x2ECA170", VA = "0x182ECB770", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				RepeatedField<CollectionItemType> repeatedField = collectionsByType_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047DB")]
		[Cpp2IlInjected.Address(RVA = "0x2ECE700", Offset = "0x2ECD100", VA = "0x182ECE700")]
		public bool IsItemInGroup(Item item, bool includeIgnored = false)
		{
			//Discarded unreachable code: IL_0015
			//IL_0014: Expected O, but got I4
			int itemID = item.ItemID;
			return ((List<T>)(object)this.GetItemsInGroup(includeIgnored)).Contains((T)itemID);
		}

		[Cpp2IlInjected.Token(Token = "0x60047DC")]
		[Cpp2IlInjected.Address(RVA = "0x2ECE770", Offset = "0x2ECD170", VA = "0x182ECE770")]
		public static bool IsValidItemForCollection(Item item)
		{
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (flag && flag)
			{
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				bool flag2 = default(bool);
				if (!flag2)
				{
				}
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				num += 328;
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047DD")]
		[Cpp2IlInjected.Address(RVA = "0x2ECE330", Offset = "0x2ECCD30", VA = "0x182ECE330")]
		public List<int> GetItemsInGroup(bool includeIgnored = false)
		{
			//Discarded unreachable code: IL_0086, IL_008c, IL_0092, IL_0098, IL_009e, IL_00a4, IL_00aa
			int num = 0;
			int num2 = 0;
			_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
			_003C_003Ec__DisplayClass35_.includeIgnored = includeIgnored;
			List<int> list = (_003C_003Ec__DisplayClass35_.ItemIDsToAdd = (List<int>)(object)new List<T>());
			List<int> list2 = (_003C_003Ec__DisplayClass35_.ItemIDsToIgnore = (List<int>)(object)new List<T>());
			RepeatedField<CollectionItemType> repeatedField = collectionsByType_;
			bool flag = default(bool);
			if (flag)
			{
				List<int> itemIDsToIgnore = _003C_003Ec__DisplayClass35_.ItemIDsToIgnore;
				List<int> list3 = default(List<int>);
				((List<T>)(object)_003C_003Ec__DisplayClass35_.ItemIDsToAdd).AddRange((IEnumerable<>)list3);
			}
			List<int> list4 = (_003C_003Ec__DisplayClass35_.ItemIDsToAdd = (List<int>)(object)_003C_003Ec__DisplayClass35_._003CGetItemsInGroup_003Eg__FilterItems_007C0());
			((List<T>)(object)_003C_003Ec__DisplayClass35_.ItemIDsToIgnore).Clear();
			bool flag2 = default(bool);
			if (flag2)
			{
				List<int> itemIDsToIgnore2 = _003C_003Ec__DisplayClass35_.ItemIDsToIgnore;
				List<int> itemIDsToAdd = _003C_003Ec__DisplayClass35_.ItemIDsToAdd;
			}
			return (List<int>)(object)_003C_003Ec__DisplayClass35_._003CGetItemsInGroup_003Eg__FilterItems_007C0();
		}

		[Cpp2IlInjected.Token(Token = "0x60047DE")]
		[Cpp2IlInjected.Address(RVA = "0x2ECBBE0", Offset = "0x2ECA5E0", VA = "0x182ECBBE0")]
		private static List<int> GetItemsFromType(CollectionItemType itemsByType)
		{
			//IL_008c: Expected O, but got I4
			//IL_009b: Expected O, but got I4
			//IL_0140: Expected O, but got I4
			//IL_0150: Expected O, but got I4
			CollectionItemType.CollectionTypeOneofCase collectionTypeOneofCase = default(CollectionItemType.CollectionTypeOneofCase);
			CollectionClothing collectionClothing = default(CollectionClothing);
			IEnumerable<ClothingItemData> enumerable = default(IEnumerable<ClothingItemData>);
			uint num2 = default(uint);
			SetItemData setItemData = default(SetItemData);
			int num3 = default(int);
			IEnumerable<FurnitureItemData> enumerable2 = default(IEnumerable<FurnitureItemData>);
			Func<FurnitureItemData, bool> func = default(Func<FurnitureItemData, bool>);
			IEnumerable<IHasTags> enumerable4 = default(IEnumerable<IHasTags>);
			Func<ClothingItemData, int> func3 = default(Func<ClothingItemData, int>);
			IEnumerable<ClothingItemData> enumerable6 = default(IEnumerable<ClothingItemData>);
			IEnumerable<FurnitureItemData> enumerable8 = default(IEnumerable<FurnitureItemData>);
			uint num5 = default(uint);
			SetItemData setItemData2 = default(SetItemData);
			do
			{
				IL_0000:
				int num = 0;
				CollectionItemType collectionItemType = itemsByType;
				if (collectionTypeOneofCase == CollectionItemType.CollectionTypeOneofCase.CharacterUniverse || collectionTypeOneofCase == CollectionItemType.CollectionTypeOneofCase.MemoryShard)
				{
					goto IL_0000;
				}
				if (collectionTypeOneofCase != CollectionItemType.CollectionTypeOneofCase.Clothing)
				{
					goto IL_00b6;
				}
				if (collectionClothing.typeCase_ != CollectionClothing.TypeOneofCase.Sets)
				{
					if (itemsByType.Clothing.typeCase_ != CollectionClothing.TypeOneofCase.Universe)
					{
						goto IL_0000;
					}
					List<int> list = (List<int>)(object)new List<T>();
					if (enumerable != null)
					{
						if (num < (int)num2)
						{
							num += num;
							if (num == (int)num2)
							{
								goto IL_009b;
							}
							num++;
						}
						while (setItemData == null)
						{
						}
						RepeatedField<int> tags_ = setItemData.tags_;
						num3 = itemsByType.Clothing.Universe;
						if (!((RepeatedField<T>)(object)tags_).Contains((T)num3))
						{
							goto IL_0000;
						}
						((List<T>)(object)list).Add((T)num3);
						goto IL_009b;
					}
					goto IL_00a2;
				}
				goto IL_0150;
				IL_02f3:
				int num4 = 0;
				continue;
				IL_02cb:
				IEnumerable<FurnitureItemData> enumerable3 = (IEnumerable<FurnitureItemData>)Enumerable.Where<FurnitureItemData>((IEnumerable<>)enumerable2, (Func<, >)(object)func);
				if (_003C_003Ec._003C_003E9__36_5 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FurnitureItemData x) => x.ID);
				}
				goto IL_02f3;
				IL_009b:
				num3 += num3;
				goto IL_00a2;
				IL_00a2:
				num++;
				if (enumerable != null)
				{
				}
				if (num != 0)
				{
					goto IL_0000;
				}
				if (num == 0)
				{
				}
				goto IL_00b6;
				IL_01a5:
				CollectionItemType collectionItemType2 = itemsByType;
				CollectionItemType.CollectionTypeOneofCase collectionTypeCase_ = collectionItemType2.collectionTypeCase_;
				if (collectionTypeCase_ == CollectionItemType.CollectionTypeOneofCase.Critter || collectionTypeCase_ == CollectionItemType.CollectionTypeOneofCase.Crafting || collectionTypeCase_ != CollectionItemType.CollectionTypeOneofCase.ActivityItem || collectionItemType2.ActivityItem.activityTypeCase_ == CollectionActivity.ActivityTypeOneofCase.CraftingMaterial || itemsByType.ActivityItem.activityTypeCase_ == CollectionActivity.ActivityTypeOneofCase.Crop)
				{
					goto IL_0000;
				}
				CollectionActivity activityItem = itemsByType.ActivityItem;
				CollectionItemType collectionItemType3 = itemsByType;
				if (activityItem.activityTypeCase_ == CollectionActivity.ActivityTypeOneofCase.Fish || collectionItemType3.ActivityItem.activityTypeCase_ == CollectionActivity.ActivityTypeOneofCase.Flower || itemsByType.ActivityItem.activityTypeCase_ == CollectionActivity.ActivityTypeOneofCase.Ingredient || itemsByType.ActivityItem.activityTypeCase_ == CollectionActivity.ActivityTypeOneofCase.Meal || itemsByType.ActivityItem.activityTypeCase_ == CollectionActivity.ActivityTypeOneofCase.Mineral)
				{
					goto IL_0000;
				}
				if (itemsByType.ActivityItem.activityTypeCase_ != 0)
				{
					if (itemsByType.ActivityItem.activityTypeCase_ != CollectionActivity.ActivityTypeOneofCase.ByGameplayTag)
					{
						goto IL_0000;
					}
					Func<IHasTags, bool> func2 = (Func<IHasTags, bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_0013
						int byGameplayTag = itemsByType.ActivityItem.ByGameplayTag;
						bool result = default(bool);
						return result;
					};
					IEnumerable<IHasTags> enumerable5 = (IEnumerable<IHasTags>)Enumerable.Where<IHasTags>((IEnumerable<>)enumerable4, (Func<, >)(object)func2);
					if (_003C_003Ec._003C_003E9__36_19 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							if ((object)typeof(IItemData).TypeHandle != null && (object)typeof(IItemData).TypeHandle != null)
							{
								throw new NullReferenceException();
							}
							throw new InvalidCastException();
						};
					}
					goto IL_02cb;
				}
				goto IL_02f3;
				IL_018a:
				func3 += func3;
				goto IL_0191;
				IL_0150:
				Func<ClothingItemData, bool> func4 = (Func<ClothingItemData, bool>)(object)(Func<T, TResult>)delegate(ClothingItemData x)
				{
					//Discarded unreachable code: IL_0032
					//IL_0031: Expected O, but got I4
					bool canBeCollected = x.CanBeCollected;
					if (!canBeCollected)
					{
						return canBeCollected;
					}
					RepeatedField<int> list_ = itemsByType.Clothing.Sets.list_;
					int setItemID_ = x.setItemID_;
					return ((RepeatedField<T>)(object)list_).Contains((T)setItemID_);
				};
				IEnumerable<ClothingItemData> enumerable7 = (IEnumerable<ClothingItemData>)Enumerable.Where<ClothingItemData>((IEnumerable<>)enumerable6, (Func<, >)(object)func4);
				if (_003C_003Ec._003C_003E9__36_3 == null)
				{
					func3 = (Func<ClothingItemData, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ClothingItemData x) => x.ID));
				}
				goto IL_018a;
				IL_0191:
				num++;
				if (enumerable8 != null)
				{
				}
				if (num != 0)
				{
					goto IL_0000;
				}
				if (num == 0)
				{
				}
				goto IL_01a5;
				IL_00b6:
				CollectionItemType collectionItemType4 = itemsByType;
				if (collectionItemType4.collectionTypeCase_ != CollectionItemType.CollectionTypeOneofCase.Furniture)
				{
					goto IL_01a5;
				}
				if (collectionItemType4.Furniture.typeCase_ != CollectionFurniture.TypeOneofCase.Sets)
				{
					if (itemsByType.Furniture.typeCase_ != CollectionFurniture.TypeOneofCase.Universe)
					{
						goto IL_0000;
					}
					List<int> list2 = (List<int>)(object)new List<T>();
					if (enumerable8 != null)
					{
						if (num < (int)num5)
						{
							num += num;
							if (num == (int)num5)
							{
								goto IL_018a;
							}
							num++;
						}
						while (setItemData2 == null)
						{
						}
						RepeatedField<int> tags_2 = setItemData2.tags_;
						int universe = itemsByType.Furniture.Universe;
						bool flag = ((RepeatedField<T>)(object)tags_2).Contains((T)universe);
						while (!flag)
						{
						}
						((List<T>)(object)list2).Add((T)flag);
						goto IL_0150;
					}
					goto IL_0191;
				}
				goto IL_02cb;
			}
			while (_003C_003Ec._003C_003E9__36_17 != null);
			_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ActivityItemData x) => x.ID);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60047DF")]
		[Cpp2IlInjected.Address(RVA = "0x2ECEE20", Offset = "0x2ECD820", VA = "0x182ECEE20")]
		static CollectionGroup()
		{
			MessageParser<CollectionItemList> parser = CollectionItemList._parser;
			uint num = default(uint);
			_parser = (MessageParser<CollectionGroup>)(object)FieldCodec.ForMessage<CollectionItemList>(num, (MessageParser<>)(object)parser);
			MessageParser<CollectionItemType> parser2 = CollectionItemType._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<CollectionGroup>)(object)FieldCodec.ForMessage<CollectionItemType>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}
	}
}
