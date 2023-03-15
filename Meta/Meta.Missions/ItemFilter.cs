using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2000FED")]
	public sealed class ItemFilter : IMessage<ItemFilter>, IMessage, IEquatable<ItemFilter>, IDeepCloneable<ItemFilter>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400416A")]
		private static readonly MessageParser<ItemFilter> _parser = (MessageParser<ItemFilter>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ItemFilter()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400416B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400416C")]
		public const int DataFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400416D")]
		private ItemFilterData data_;

		[Cpp2IlInjected.Token(Token = "0x17001660")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6007FFA")]
			[Cpp2IlInjected.Address(RVA = "0x17167B0", Offset = "0x17151B0", VA = "0x1817167B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001661")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007FFB")]
			[Cpp2IlInjected.Address(RVA = "0x1716330", Offset = "0x1714D30", VA = "0x181716330")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001662")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007FFC")]
			[Cpp2IlInjected.Address(RVA = "0x17168C0", Offset = "0x17152C0", VA = "0x1817168C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001663")]
		[DebuggerNonUserCode]
		public ItemFilterData Data
		{
			[Cpp2IlInjected.Token(Token = "0x6008000")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return data_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008001")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				data_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001664")]
		public int ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x600800F")]
			[Cpp2IlInjected.Address(RVA = "0x1716400", Offset = "0x1714E00", VA = "0x181716400")]
			get
			{
				ItemFilterData itemFilterData = data_;
				if (itemFilterData != null)
				{
					return itemFilterData.item_;
				}
				Item invalid = Item.Invalid;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001665")]
		public bool TargetSpecificItems
		{
			[Cpp2IlInjected.Token(Token = "0x6008010")]
			[Cpp2IlInjected.Address(RVA = "0x1716810", Offset = "0x1715210", VA = "0x181716810")]
			get
			{
				//Discarded unreachable code: IL_0014, IL_0025
				ItemFilterData itemFilterData = data_;
				if (itemFilterData == null)
				{
				}
				int item_ = itemFilterData.item_;
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001666")]
		public int MinRarity
		{
			[Cpp2IlInjected.Token(Token = "0x6008012")]
			[Cpp2IlInjected.Address(RVA = "0x1716470", Offset = "0x1714E70", VA = "0x181716470")]
			get
			{
				//Discarded unreachable code: IL_00a3
				ItemFilterData itemFilterData = data_;
				if (itemFilterData != null)
				{
					int item_ = itemFilterData.item_;
					bool flag = Enumerable.Any<int>((IEnumerable<>)(object)data_.itemList_);
					ItemFilterData itemFilterData2 = data_;
					if (!flag)
					{
					}
					RepeatedField<int> itemList_ = itemFilterData2.itemList_;
					Func<int, int> _003C_003E9__36_ = _003C_003Ec._003C_003E9__36_0;
					if (_003C_003E9__36_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
							IItemData itemData2 = default(IItemData);
							if (itemData2 == null)
							{
								return int.MaxValue;
							}
							throw new NullReferenceException();
						};
					}
					int num = Enumerable.Min<int>((IEnumerable<>)(object)itemList_, (Func<, >)(object)_003C_003E9__36_);
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					int item_2 = data_.item_;
					IItemData itemData = default(IItemData);
					if (itemData != null)
					{
						int num2 = 0;
						uint num3 = default(uint);
						if (num2 < (int)num3)
						{
							num2 += num2;
							num2++;
						}
						if (num2 != int.MaxValue)
						{
							int result = default(int);
							return result;
						}
					}
				}
				return 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007FFD")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ItemFilter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6007FFE")]
		[Cpp2IlInjected.Address(RVA = "0x17162C0", Offset = "0x1714CC0", VA = "0x1817162C0")]
		[DebuggerNonUserCode]
		public ItemFilter(ItemFilter other)
		{
			//IL_0021: Expected O, but got I4
			ItemFilterData itemFilterData = other.data_;
			if (itemFilterData != null)
			{
				ItemFilterData itemFilterData2 = itemFilterData.Clone();
			}
			int num = 0;
			data_ = (ItemFilterData)num;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007FFF")]
		[Cpp2IlInjected.Address(RVA = "0x1713C80", Offset = "0x1712680", VA = "0x181713C80", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemFilter Clone()
		{
			//Discarded unreachable code: IL_0038
			//IL_0021: Expected O, but got I4
			ItemFilter itemFilter = new ItemFilter();
			ItemFilterData itemFilterData = data_;
			if (itemFilterData != null)
			{
				ItemFilterData itemFilterData2 = itemFilterData.Clone();
			}
			int num = 0;
			itemFilter.data_ = (ItemFilterData)num;
			UnknownFieldSet unknownFieldSet = (itemFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6008002")]
		[Cpp2IlInjected.Address(RVA = "0x17140D0", Offset = "0x1712AD0", VA = "0x1817140D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(data_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008003")]
		[Cpp2IlInjected.Address(RVA = "0x15BA5B0", Offset = "0x15B8FB0", VA = "0x1815BA5B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemFilterData objB = other.data_;
				if (object.Equals(data_, objB))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008004")]
		[Cpp2IlInjected.Address(RVA = "0x15BAEA0", Offset = "0x15B98A0", VA = "0x1815BAEA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ItemFilterData itemFilterData = data_;
				if (itemFilterData != null)
				{
					int hashCode = itemFilterData.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6008005")]
		[Cpp2IlInjected.Address(RVA = "0x17160A0", Offset = "0x1714AA0", VA = "0x1817160A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008006")]
		[Cpp2IlInjected.Address(RVA = "0x15BC830", Offset = "0x15BB230", VA = "0x1815BC830", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002c
			if ((long)data_ != 0)
			{
				ItemFilterData value = data_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008007")]
		[Cpp2IlInjected.Address(RVA = "0x1713BE0", Offset = "0x17125E0", VA = "0x181713BE0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ItemFilterData itemFilterData = data_;
				num = 0;
				if (itemFilterData != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(itemFilterData);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6008008")]
		[Cpp2IlInjected.Address(RVA = "0x1715210", Offset = "0x1713C10", VA = "0x181715210", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemFilter other)
		{
			//Discarded unreachable code: IL_0053
			if (other == null)
			{
				return;
			}
			if ((long)other.data_ != 0)
			{
				ItemFilterData itemFilterData = data_;
				if (itemFilterData == null)
				{
					ItemFilterData itemFilterData2 = (data_ = new ItemFilterData());
				}
				ItemFilterData other2 = other.data_;
				itemFilterData.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6008009")]
		[Cpp2IlInjected.Address(RVA = "0x17152E0", Offset = "0x1713CE0", VA = "0x1817152E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0046
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				ItemFilterData itemFilterData = data_;
				if (itemFilterData == null)
				{
					ItemFilterData itemFilterData2 = (data_ = new ItemFilterData());
				}
				input.ReadMessage(itemFilterData);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600800A")]
		[Cpp2IlInjected.Address(RVA = "0x17142B0", Offset = "0x1712CB0", VA = "0x1817142B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ItemFilterData itemFilterData = data_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600800B")]
		[Cpp2IlInjected.Address(RVA = "0x1716020", Offset = "0x1714A20", VA = "0x181716020", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				data_ = (ItemFilterData)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600800C")]
		[Cpp2IlInjected.Address(RVA = "0x15B97E0", Offset = "0x15B81E0", VA = "0x1815B97E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600800D")]
		[Cpp2IlInjected.Address(RVA = "0x1715F10", Offset = "0x1714910", VA = "0x181715F10")]
		public Item RandomItemFromFilter(Random random)
		{
			//IL_000e: Expected I4, but got I8
			//IL_000e: Expected O, but got I4
			int verifyItemCanBeReached = 0;
			int num = 0;
			ulong num2 = default(ulong);
			return RandomItemFromFilter(random, (IProfile)num, (byte)verifyItemCanBeReached != 0, (byte)num2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600800E")]
		[Cpp2IlInjected.Address(RVA = "0x1715C50", Offset = "0x1714650", VA = "0x181715C50")]
		private Item RandomItemFromFilter(Random random, IProfile profile, bool verifyItemCanBeReached = false, bool firstItem = false)
		{
			//Discarded unreachable code: IL_0051
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			ItemType type_ = data_.type_;
			IEnumerable<IItemData> allByType = (IEnumerable<IItemData>)_003CInstance_003Ek__BackingField.GetAllByType(type_);
			Func<IItemData, Item> _003C_003E9__29_ = _003C_003Ec._003C_003E9__29_0;
			if (_003C_003E9__29_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				};
			}
			IEnumerable<IItemData> enumerable = (IEnumerable<IItemData>)Enumerable.Select<IItemData, Item>((IEnumerable<>)allByType, (Func<, >)(object)_003C_003E9__29_);
			List<Item> list = default(List<Item>);
			int size = ((List<>)(object)list)._size;
			return Item.Invalid;
		}

		[Cpp2IlInjected.Token(Token = "0x6008011")]
		[Cpp2IlInjected.Address(RVA = "0x1715F40", Offset = "0x1714940", VA = "0x181715F40")]
		public IEnumerable<Item> SelectedItems()
		{
			while (true)
			{
				ItemFilterData itemFilterData = data_;
				if (itemFilterData != null && itemFilterData.SelectedItems() == null)
				{
					/*Error: Could not find block for branch target IL_0014*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008013")]
		[Cpp2IlInjected.Address(RVA = "0x1713410", Offset = "0x1711E10", VA = "0x181713410")]
		public List<Item> ApplyFilterEditor(IEnumerable<Item> unfilterList, IProfile profile)
		{
			//IL_000b: Expected I4, but got I8
			//IL_000b: Expected I4, but got I8
			ulong num = default(ulong);
			ulong num2 = default(ulong);
			return (List<Item>)(object)this.ApplyFilter((IEnumerable<>)unfilterList, profile, true, (byte)num != 0, (byte)num2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6008014")]
		[Cpp2IlInjected.Address(RVA = "0x1713B20", Offset = "0x1712520", VA = "0x181713B20")]
		public List<Item> ApplyFilter(IEnumerable<Item> unfilterList)
		{
			//IL_0010: Expected I4, but got I8
			//IL_0010: Expected I4, but got I8
			//IL_0010: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			ulong num3 = default(ulong);
			ulong num4 = default(ulong);
			return (List<Item>)(object)this.ApplyFilter((IEnumerable<>)unfilterList, (IProfile)num2, (byte)num != 0, (byte)num3 != 0, (byte)num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6008015")]
		[Cpp2IlInjected.Address(RVA = "0x1713840", Offset = "0x1712240", VA = "0x181713840")]
		private List<Item> ApplyFilter(IEnumerable<Item> unfilterList, IProfile profile, bool isGenerator, bool verifyItemCanBeReached = false, bool firstItem = false)
		{
			//Discarded unreachable code: IL_005e
			Item[] array = ((IEnumerable<>)unfilterList).ToArray<Item>();
			Func<Item, (Item, ItemState)> _003C_003E9__39_ = _003C_003Ec._003C_003E9__39_0;
			if (_003C_003E9__39_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					int num = 0;
					/*Error: Unexpected end of block*/;
				};
			}
			IEnumerable<Item> enumerable = (IEnumerable<Item>)Enumerable.Select<Item, (Item, ItemState)>((IEnumerable<>)(object)array, (Func<, >)(object)_003C_003E9__39_);
			Func<(Item, ItemState), Item> func = default(Func<(Item, ItemState), Item>);
			if (_003C_003Ec._003C_003E9__39_1 == null)
			{
				func = (Func<(Item, ItemState), Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			List<(Item, ItemState)> list = default(List<(Item, ItemState)>);
			return (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<(Item, ItemState), Item>((IEnumerable<>)list, (Func<, >)(object)func));
		}

		[Cpp2IlInjected.Token(Token = "0x6008016")]
		[Cpp2IlInjected.Address(RVA = "0x1713710", Offset = "0x1712110", VA = "0x181713710")]
		public bool ApplyFilter(Item item, [Optional] ItemState state, [Optional] IProfile profile)
		{
			//Discarded unreachable code: IL_002d
			//IL_0016: Expected O, but got I4
			//IL_0027: Expected I4, but got I8
			//IL_0027: Expected I4, but got I8
			int itemID = item.ItemID;
			List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)new List<T>();
			int num = 0;
			((List<T>)(object)list).Add((T)num);
			int num2 = 0;
			ulong num3 = default(ulong);
			ulong num4 = default(ulong);
			return Enumerable.Any<(Item, ItemState)>((IEnumerable<>)this.ApplyFilter((IEnumerable<>)list, profile, (byte)num2 != 0, (byte)num3 != 0, (byte)num4 != 0));
		}

		[Cpp2IlInjected.Token(Token = "0x6008017")]
		[Cpp2IlInjected.Address(RVA = "0x1713AF0", Offset = "0x17124F0", VA = "0x181713AF0")]
		public List<(Item, ItemState)> ApplyFilter(IEnumerable<(Item item, ItemState state)> unfilterList)
		{
			//IL_0010: Expected I4, but got I8
			//IL_0010: Expected I4, but got I8
			//IL_0010: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			ulong num3 = default(ulong);
			ulong num4 = default(ulong);
			return (List<(Item, ItemState)>)(object)this.ApplyFilter((IEnumerable<>)unfilterList, (IProfile)num2, (byte)num != 0, (byte)num3 != 0, (byte)num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6008018")]
		[Cpp2IlInjected.Address(RVA = "0x1713440", Offset = "0x1711E40", VA = "0x181713440")]
		private unsafe List<(Item, ItemState)> ApplyFilter(IEnumerable<(Item item, ItemState state)> unfilterList, IProfile profile, bool isGenerator, bool verifyItemCanBeReached = false, bool firstItem = false)
		{
			bool verifyItemCanBeReached2 = false;
			ItemFilterData itemFilterData = data_;
			if (itemFilterData != null)
			{
				int item_ = itemFilterData.item_;
				if (Enumerable.Any<int>((IEnumerable<>)(object)data_.itemList_))
				{
					Func<(Item, ItemState), bool> func = (Func<(Item, ItemState), bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_0031, IL_0033
						ItemFilterData itemFilterData6 = data_;
						ItemDatabase _003CInstance_003Ek__BackingField4 = ItemDatabase.Instance;
						bool flag15 = default(bool);
						if (!flag15)
						{
							return flag15;
						}
						ItemFilter itemFilter2 = this;
						return (IntPtr)itemFilter2.data_.item_ == (IntPtr)itemFilter2;
					};
					Func<(Item, ItemState), bool> func2 = (Func<(Item, ItemState), bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_0031, IL_0033
						ItemFilterData itemFilterData5 = data_;
						ItemDatabase _003CInstance_003Ek__BackingField3 = ItemDatabase.Instance;
						bool flag14 = default(bool);
						if (!flag14)
						{
							return flag14;
						}
						ItemFilter itemFilter = this;
						return (IntPtr)itemFilter.data_.item_ == (IntPtr)itemFilter;
					};
					return (List<(Item, ItemState)>)(object)Enumerable.ToList<(Item, ItemState)>(Enumerable.Take<(Item, ItemState)>(Enumerable.Where<(Item, ItemState)>((IEnumerable<>)unfilterList, (Func<, >)(object)func2), int.MaxValue));
				}
			}
			if ((long)data_ != 0)
			{
				HashSet<Item> mealsWithRecipes = default(HashSet<Item>);
				Func<RecipeItemData, bool> func3 = default(Func<RecipeItemData, bool>);
				Func<(Item, ItemState), bool> func4 = (Func<(Item, ItemState), bool>)(object)(Func<T, TResult>)delegate
				{
					ItemFilterData itemFilterData4 = data_;
					ItemType type_ = itemFilterData4.type_;
					ItemType itemType = default(ItemType);
					if (itemType == type_ && type_ == ItemType.ActivityItem)
					{
						ActivityItemType activityItemType_ = itemFilterData4.activityItemType_;
						if (activityItemType_ != ActivityItemType.Ingredient)
						{
							if (isGenerator && activityItemType_ == (ActivityItemType)type_)
							{
								if (mealsWithRecipes == null)
								{
									Func<RecipeItemData, bool> func10 = default(Func<RecipeItemData, bool>);
									if (func3 == null)
									{
										func10 = (func3 = (Func<RecipeItemData, bool>)(object)(Func<T, TResult>)delegate(RecipeItemData y)
										{
											IProfile profile2 = profile;
											int iD = y.ID;
											int num13 = 0;
											if ((long)num13 < (long)(IntPtr)profile2)
											{
												num13 += num13;
												num13++;
											}
											iD += iD;
											iD += 440;
											throw new NullReferenceException();
										});
									}
									IEnumerable<> enumerable6 = default(IEnumerable<>);
									IEnumerable<RecipeItemData> enumerable7 = (IEnumerable<RecipeItemData>)Enumerable.Where<RecipeItemData>(enumerable6, (Func<, >)(object)func10);
									Func<RecipeItemData, Item> func11 = default(Func<RecipeItemData, Item>);
									if (_003C_003Ec._003C_003E9__42_7 == null)
									{
										func11 = (Func<RecipeItemData, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(RecipeItemData y)
										{
											int resultItemID = y.ResultItemID;
											throw new NullReferenceException();
										});
									}
									mealsWithRecipes = (HashSet<Item>)(object)new HashSet<T>((IEqualityComparer<>)Enumerable.Select<RecipeItemData, Item>((IEnumerable<>)enumerable7, (Func<, >)(object)func11));
								}
								bool result3 = default(bool);
								return result3;
							}
							ActivityItemType activityItemType = default(ActivityItemType);
							return (IntPtr)(void*)(int)activityItemType == (IntPtr)"{il2cpp field on {'constant69' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0x2C}";
						}
						ICookingIngredient cookingIngredient = default(ICookingIngredient);
						if (cookingIngredient != null)
						{
						}
					}
					throw new NullReferenceException();
				};
				IEnumerable<(Item, ItemState)> enumerable = (IEnumerable<(Item, ItemState)>)Enumerable.Where<(Item, ItemState)>((IEnumerable<>)unfilterList, (Func<, >)(object)func4);
				Func<int, bool> func5 = default(Func<int, bool>);
				Func<(Item, ItemState), bool> func6 = (Func<(Item, ItemState), bool>)(object)(Func<T, TResult>)delegate
				{
					//IL_00d1: Expected I4, but got O
					//IL_01a4: Expected O, but got I4
					//IL_01c1: Expected O, but got I4
					//IL_02e7: Expected O, but got I4
					IItemData itemData = default(IItemData);
					IEnumerable<Item> enumerable3 = default(IEnumerable<Item>);
					_003C_003Ec__DisplayClass42_1 CS_0024_003C_003E8__locals0 = default(_003C_003Ec__DisplayClass42_1);
					IEnumerable<> enumerable4 = default(IEnumerable<>);
					bool flag2 = default(bool);
					bool flag3 = default(bool);
					List<string> list4 = default(List<string>);
					bool flag4 = default(bool);
					bool flag5 = default(bool);
					ulong num9 = default(ulong);
					bool flag6 = default(bool);
					FishRarity fishRarity = default(FishRarity);
					bool flag7 = default(bool);
					Item item2 = default(Item);
					Predicate<int> predicate = default(Predicate<int>);
					RepeatedField<int> ingredientsType_4 = default(RepeatedField<int>);
					MealData mealData = default(MealData);
					MealData mealData2 = default(MealData);
					Func<int, bool> func9 = default(Func<int, bool>);
					bool flag13 = default(bool);
					RecipeItemData recipeItemData = default(RecipeItemData);
					bool flag9 = default(bool);
					bool flag10 = default(bool);
					int num11 = default(int);
					IEnumerable<int> enumerable5 = default(IEnumerable<int>);
					bool flag11 = default(bool);
					bool flag12 = default(bool);
					SeedType seedType = default(SeedType);
					while (true)
					{
						int num2 = 0;
						int num3 = 0;
						int num4 = 0;
						int num5 = 0;
						ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
						int num6 = 0;
						HashSet<Item> hashSet;
						if (!itemData.IsMissionItem())
						{
							Item invalid = Item.Invalid;
							hashSet = (HashSet<Item>)(object)new HashSet<T>();
							((HashSet<T>)(object)hashSet)?.UnionWith((IEnumerable<>)enumerable3);
							if (enumerable3 != null)
							{
							}
							List<VillageAreaType> list = (List<VillageAreaType>)(object)new List<T>();
							List<FishRarity> list2 = (List<FishRarity>)(object)new List<T>();
							if (itemData != null)
							{
							}
							CS_0024_003C_003E8__locals0.fishItemData = (FishItemData)itemData;
							if ((IntPtr)CS_0024_003C_003E8__locals0.fishItemData == (IntPtr)num2)
							{
								goto IL_00f1;
							}
							Func<FishingDataItemData, bool> func8 = (Func<FishingDataItemData, bool>)(object)(Func<T, TResult>)delegate(FishingDataItemData y)
							{
								//Discarded unreachable code: IL_0024
								Item item3 = y.result_.Item;
								if (CS_0024_003C_003E8__locals0.fishItemData.ID == 0)
								{
								}
								return !y.isHidden_;
							};
							List<FishingDataItemData> list3 = (List<FishingDataItemData>)(object)Enumerable.ToList<FishingDataItemData>(Enumerable.Where<FishingDataItemData>(enumerable4, (Func<, >)(object)func8));
							if (Enumerable.Any<FishingDataItemData>((IEnumerable<>)list3))
							{
								if (flag2)
								{
									while (flag3)
									{
									}
								}
								int num7 = 0;
								if (num2 != 0)
								{
									continue;
								}
								FishingDataItemData fishingDataItemData = Enumerable.First<FishingDataItemData>((IEnumerable<>)list3);
								string appearanceCondition_ = fishingDataItemData.appearanceCondition_;
								if (fishingDataItemData.specificWeather_)
								{
									list4 = (List<string>)(object)new List<T>((int)fishingDataItemData.weathers_);
								}
								int num8 = 0;
								if (flag4)
								{
									while (!flag5)
									{
									}
								}
								if (num2 != 0)
								{
									continue;
								}
								if (num9 != 0)
								{
									goto IL_00f1;
								}
							}
						}
						goto IL_0186;
						IL_018d:
						if (!data_.fishLocation_.IsValidLocation((List<>)num6) || !data_.fishRarity_.IsValidRarity((List<>)num6))
						{
							continue;
						}
						if (!string.IsNullOrEmpty(data_.constraint_))
						{
							string constraint_ = data_.constraint_;
							while (flag6)
							{
							}
						}
						if (!data_.fishIncludeTrash_)
						{
							while (fishRarity == FishRarity.Trash)
							{
							}
						}
						if (!string.IsNullOrEmpty(data_.fishWeather_))
						{
							string fishWeather_ = data_.fishWeather_;
							while (!flag7)
							{
							}
						}
						if (itemData != null && itemData != null)
						{
							int itemID = item2.ItemID;
						}
						Item mealQuestType = MealItemData.MealQuestType;
						if (num2 != 0 && *(Item*)num2 == *(Item*)mealQuestType)
						{
							continue;
						}
						ItemFilterData itemFilterData2 = data_;
						if (itemFilterData2.minMealStarRating_ > 0)
						{
							while (itemData == null)
							{
							}
						}
						RepeatedField<int> ingredientsType_3 = itemFilterData2.ingredientsType_;
						if (_003C_003Ec._003C_003E9__42_8 == null)
						{
							predicate = (Predicate<int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((int y) => (IntPtr)y != (IntPtr)"{il2cpp field on {'constant10' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x0}"));
						}
						bool flag8 = ((RepeatedField<>)(object)ingredientsType_3).Any<int>((Predicate<>)(object)predicate);
						if (flag8)
						{
							if (itemData == null)
							{
								while (!flag8)
								{
								}
								ingredientsType_4 = data_.ingredientsType_;
								if (((RepeatedField<T>)(object)ingredientsType_4).Contains((T)flag8))
								{
									goto IL_034e;
								}
							}
							if (ingredientsType_4 != null && mealData != null)
							{
								RepeatedField<int> ingredientsUsed_ = mealData2.ingredientsUsed_;
								if (func5 == null)
								{
									func9 = (func5 = (Func<int, bool>)(object)(Func<T, TResult>)((int id) => !flag13));
								}
								if (!((IEnumerable<>)(object)ingredientsUsed_).All<int>((Func<, >)(object)func9))
								{
									goto IL_034e;
								}
							}
							RepeatedField<RecipeItemData.Types.Ingredient> ingredients_ = recipeItemData.ingredients_;
							Predicate<RecipeItemData.Types.Ingredient> predicate2 = (Predicate<RecipeItemData.Types.Ingredient>)(object)new Predicate<T>(IsRightRecipeIngredient);
							if (!((RepeatedField<>)(object)ingredients_).Any<RecipeItemData.Types.Ingredient>((Predicate<>)(object)predicate2))
							{
								continue;
							}
						}
						goto IL_034e;
						IL_00f1:
						int size = ((List<>)(object)list4)._size;
						if (flag9 && flag10)
						{
							goto IL_0186;
						}
						int num10 = 0;
						if (num10 > 0)
						{
						}
						if (num10 > 0)
						{
						}
						if (num11 > 0)
						{
							if (_003C_003Ec._003C_003E9__42_13 == null)
							{
								_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
								{
									throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
								};
							}
							List<Item> list5 = (List<Item>)(object)Enumerable.ToList<Item>((IEnumerable<>)enumerable5);
							HashSet<Item> hashSet2 = (HashSet<Item>)(object)new HashSet<T>();
							((HashSet<T>)(object)hashSet2).UnionWith((IEnumerable<>)list5);
							int count = ((HashSet<>)(object)hashSet2)._count;
							((HashSet<T>)(object)hashSet2).IntersectWith((IEnumerable<>)hashSet);
							HashSet<>.Slot[] slots = (HashSet<>.Slot[])(object)((HashSet<>)(object)hashSet2)._slots;
							int count2 = ((HashSet<>)(object)hashSet2)._count;
							if ((long)"{il2cpp array field local80->}" != 0)
							{
								continue;
							}
							if (count2 != count)
							{
								goto IL_0186;
							}
						}
						goto IL_018d;
						IL_034e:
						ItemFilterData itemFilterData3 = data_;
						bool onlySeedCrop_ = itemFilterData3.onlySeedCrop_;
						if (onlySeedCrop_ || itemFilterData3.cropType_ != 0)
						{
							while (itemData == null)
							{
							}
							while (itemData == null)
							{
							}
							if (onlySeedCrop_)
							{
								while (!flag11)
								{
								}
							}
							if (data_.cropType_ != 0)
							{
								while (!flag12)
								{
								}
							}
						}
						SeedTypeCondition seedType_ = data_.seedType_;
						if (seedType_ != 0)
						{
							while (itemData == null)
							{
							}
							while (itemData == null)
							{
							}
							int num12 = (int)seedType_;
							while (seedType == SeedType.Regular)
							{
							}
						}
						if (itemData != null)
						{
							/*Error: Could not find block for branch target IL_03d1*/;
						}
						continue;
						IL_0186:
						if (0 == 0)
						{
							continue;
						}
						goto IL_018d;
					}
				};
				IEnumerable<(Item, ItemState)> enumerable2 = (IEnumerable<(Item, ItemState)>)Enumerable.Where<(Item, ItemState)>((IEnumerable<>)enumerable, (Func<, >)(object)func6);
			}
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6008047")]
			[Cpp2IlInjected.Address(RVA = "0x12009F0", Offset = "0x11FF3F0", VA = "0x1812009F0")]
			bool IsRightIngredientsType(Item ingredientItem)
			{
				//Discarded unreachable code: IL_0020
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				bool flag = default(bool);
				if (!flag)
				{
					return flag;
				}
				RepeatedField<int> ingredientsType_ = data_.ingredientsType_;
				bool result = default(bool);
				return result;
			}
			Func<Item, bool> func7 = default(Func<Item, bool>);
			[Cpp2IlInjected.Token(Token = "0x6008044")]
			[Cpp2IlInjected.Address(RVA = "0x1200B50", Offset = "0x11FF550", VA = "0x181200B50")]
			bool IsRightRecipeIngredient(RecipeItemData.Types.Ingredient recipeIngredient)
			{
				//Discarded unreachable code: IL_0070
				//IL_0064: Expected O, but got I4
				RecipeItemData.Types.Ingredient.IngredientOneofCase ingredientCase_ = recipeIngredient.ingredientCase_;
				if (recipeIngredient != null)
				{
					if (recipeIngredient != null)
					{
						if (ingredientCase_ != RecipeItemData.Types.Ingredient.IngredientOneofCase.ItemID)
						{
							int num = 0;
						}
						Item[] itemsList = recipeIngredient.ItemsList;
						Func<Item, bool> cpp2il__autoParamName__idx_ = default(Func<Item, bool>);
						if (func7 == null)
						{
							cpp2il__autoParamName__idx_ = (func7 = (Func<Item, bool>)(object)(Func<T, TResult>)((Item z) => IsRightIngredientsType(z)));
						}
						return ((IEnumerable<>)(object)itemsList).Any<Item>((Func<, >)(object)cpp2il__autoParamName__idx_);
					}
					RepeatedField<int> ingredientsType_2 = data_.ingredientsType_;
					int any = recipeIngredient.Any;
					return ((RepeatedField<T>)(object)ingredientsType_2).Contains((T)any);
				}
				Item? item = (Item?)recipeIngredient.get_Item();
				bool result2 = default(bool);
				return result2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008019")]
		[Cpp2IlInjected.Address(RVA = "0x1714180", Offset = "0x1712B80", VA = "0x181714180")]
		private bool FishLocationUnlocked(FishingDataItemData fishData, IProfile profile)
		{
			if ((long)profile == 0)
			{
				return true;
			}
			RepeatedField<VillageAreaType> locations_ = fishData.locations_;
			Predicate<VillageAreaType> predicate = (Predicate<VillageAreaType>)(object)(Predicate<T>)delegate
			{
				//Discarded unreachable code: IL_001d
				//IL_001d: Expected I4, but got O
				IProfile profile2 = profile;
				int num = 0;
				if ((long)num < (long)(IntPtr)profile2)
				{
					num += num;
					num++;
				}
				return (byte)(int)typeof(IProfile).TypeHandle != 0;
			};
			bool flag = ((RepeatedField<>)(object)locations_).Any<VillageAreaType>((Predicate<>)(object)predicate);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600801A")]
		[Cpp2IlInjected.Address(RVA = "0x1713D20", Offset = "0x1712720", VA = "0x181713D20")]
		private bool CropHasValidSeed(CropItemData cropItemData, IProfile profile)
		{
			//Discarded unreachable code: IL_0056, IL_005c, IL_0062
			int num = 0;
			int num2 = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IEnumerable<> enumerable = default(IEnumerable<>);
			int iD = default(int);
			if (enumerable != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					if (num == (int)num3)
					{
						goto IL_0032;
					}
					num++;
				}
				iD = cropItemData.ID;
				while (iD == 0)
				{
				}
				if (profile == null)
				{
					goto IL_0032;
				}
				goto IL_003c;
			}
			goto IL_0040;
			IL_003c:
			num++;
			goto IL_0040;
			IL_0040:
			num++;
			if (enumerable != null)
			{
			}
			bool result = default(bool);
			if (num != 0)
			{
				return result;
			}
			throw new NullReferenceException();
			IL_0032:
			iD += 312;
			goto IL_003c;
		}

		[Cpp2IlInjected.Token(Token = "0x600801B")]
		[Cpp2IlInjected.Address(RVA = "0x1714330", Offset = "0x1712D30", VA = "0x181714330")]
		public int GetItemQuantity(Item item, int amount = 1, [Optional] ItemState state)
		{
			//Discarded unreachable code: IL_0022
			//IL_0017: Expected O, but got I4
			//IL_0017: Expected O, but got I4
			int itemID = item.ItemID;
			Dictionary<(Item, ItemState), int> dictionary = (Dictionary<(Item, ItemState), int>)(object)new Dictionary<TKey, TValue>();
			int num = 0;
			((Dictionary<TKey, TValue>)(object)dictionary).Add((TKey)num, (TValue)amount);
			int num2 = 0;
			return this.GetItemsQuantity((Dictionary<, >)(object)dictionary, (byte)num2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600801C")]
		[Cpp2IlInjected.Address(RVA = "0x1714A20", Offset = "0x1713420", VA = "0x181714A20")]
		public int GetItemsQuantity(Dictionary<Item, int> itemList, bool useDifferentItem = false)
		{
			//Discarded unreachable code: IL_0050
			Func<KeyValuePair<Item, int>, (Item, ItemState)> _003C_003E9__46_ = _003C_003Ec._003C_003E9__46_0;
			if (_003C_003E9__46_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					int num = 0;
					/*Error: Unexpected end of block*/;
				};
			}
			Func<KeyValuePair<Item, int>, int> func = default(Func<KeyValuePair<Item, int>, int>);
			if (_003C_003Ec._003C_003E9__46_1 == null)
			{
				func = (Func<KeyValuePair<Item, int>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Dictionary<Item, KeyValuePair<Item, int>> dictionary = (Dictionary<Item, KeyValuePair<Item, int>>)(object)Enumerable.ToDictionary<KeyValuePair<Item, int>, (Item, ItemState), int>((IEnumerable<>)itemList, (Func<, >)(object)_003C_003E9__46_, (Func<, >)(object)func);
			return this.GetItemsQuantity((Dictionary<, >)(object)dictionary, useDifferentItem);
		}

		[Cpp2IlInjected.Token(Token = "0x600801D")]
		[Cpp2IlInjected.Address(RVA = "0x1714C50", Offset = "0x1713650", VA = "0x181714C50")]
		public int GetItemsQuantity(Dictionary<(Item item, ItemState state), int> itemList, bool useDifferentItem = false)
		{
			IEnumerable<((Item, ItemState), int)> enumerable = (IEnumerable<((Item, ItemState), int)>)this.EnumItemsQuantity((Dictionary<, >)(object)itemList);
			if (!useDifferentItem)
			{
				Func<((Item, ItemState), int), int> _003C_003E9__47_ = _003C_003Ec._003C_003E9__47_1;
				if (_003C_003E9__47_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				return Enumerable.Sum<((Item, ItemState), int)>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__47_);
			}
			Func<((Item, ItemState), int), Item> func = default(Func<((Item, ItemState), int), Item>);
			if (_003C_003Ec._003C_003E9__47_0 == null)
			{
				func = (Func<((Item, ItemState), int), Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			return Enumerable.Count<Item>(Enumerable.Distinct<Item>(Enumerable.Select<((Item, ItemState), int), Item>((IEnumerable<>)enumerable, (Func<, >)(object)func)));
		}

		[Cpp2IlInjected.Token(Token = "0x600801E")]
		[Cpp2IlInjected.Address(RVA = "0x1714ED0", Offset = "0x17138D0", VA = "0x181714ED0")]
		public int GetItemsQuantity(List<Dictionary<(Item item, ItemState state), int>> itemList, bool useDifferentItem = false)
		{
			//Discarded unreachable code: IL_0019, IL_001f, IL_0025
			int num = 0;
			Dictionary<(Item, ItemState), int> dictionary = (Dictionary<(Item, ItemState), int>)(object)new Dictionary<TKey, TValue>();
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			if (!flag || !flag2 || !flag3)
			{
			}
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600801F")]
		[Cpp2IlInjected.Address(RVA = "0x1714640", Offset = "0x1713040", VA = "0x181714640")]
		public Dictionary<Item, int> GetItemsQuantityByItem(Dictionary<Item, int> itemList)
		{
			//Discarded unreachable code: IL_009c
			Func<KeyValuePair<Item, int>, (Item, ItemState)> _003C_003E9__49_ = _003C_003Ec._003C_003E9__49_0;
			if (_003C_003E9__49_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					int num = 0;
					/*Error: Unexpected end of block*/;
				};
			}
			Func<KeyValuePair<Item, int>, int> func = default(Func<KeyValuePair<Item, int>, int>);
			if (_003C_003Ec._003C_003E9__49_1 == null)
			{
				func = (Func<KeyValuePair<Item, int>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Dictionary<Item, KeyValuePair<Item, int>> dictionary = (Dictionary<Item, KeyValuePair<Item, int>>)(object)Enumerable.ToDictionary<KeyValuePair<Item, int>, (Item, ItemState), int>((IEnumerable<>)itemList, (Func<, >)(object)_003C_003E9__49_, (Func<, >)(object)func);
			Dictionary<(Item, ItemState), int> itemsQuantityByItem = (Dictionary<(Item, ItemState), int>)(object)this.GetItemsQuantityByItem((Dictionary<, >)(object)dictionary);
			Func<KeyValuePair<(Item, ItemState), int>, Item> func2 = default(Func<KeyValuePair<(Item, ItemState), int>, Item>);
			if (_003C_003Ec._003C_003E9__49_2 == null)
			{
				func2 = (Func<KeyValuePair<(Item, ItemState), int>, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Func<KeyValuePair<(Item, ItemState), int>, int> func3 = default(Func<KeyValuePair<(Item, ItemState), int>, int>);
			if (_003C_003Ec._003C_003E9__49_3 == null)
			{
				func3 = (Func<KeyValuePair<(Item, ItemState), int>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			return (Dictionary<Item, int>)(object)Enumerable.ToDictionary<KeyValuePair<(Item, ItemState), int>, Item, int>((IEnumerable<>)itemsQuantityByItem, (Func<, >)(object)func2, (Func<, >)(object)func3);
		}

		[Cpp2IlInjected.Token(Token = "0x6008020")]
		[Cpp2IlInjected.Address(RVA = "0x1714430", Offset = "0x1712E30", VA = "0x181714430")]
		public Dictionary<(Item, ItemState), int> GetItemsQuantityByItem(Dictionary<(Item item, ItemState state), int> itemList)
		{
			//Discarded unreachable code: IL_0032, IL_0038, IL_003e
			int num = 0;
			Dictionary<(Item, ItemState), int> result = (Dictionary<(Item, ItemState), int>)(object)new Dictionary<TKey, TValue>();
			IEnumerable<((Item, ItemState), int)> enumerable = (IEnumerable<((Item, ItemState), int)>)this.EnumItemsQuantity((Dictionary<, >)(object)itemList);
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num != (int)num2)
					{
						num++;
					}
				}
				num += 312;
			}
			if (enumerable != null)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008021")]
		[Cpp2IlInjected.Address(RVA = "0x1714040", Offset = "0x1712A40", VA = "0x181714040")]
		[IteratorStateMachine(typeof(_003CEnumItemsQuantity_003Ed__51))]
		private IEnumerable<((Item, ItemState), int)> EnumItemsQuantity(Dictionary<(Item item, ItemState state), int> itemList)
		{
			_003CEnumItemsQuantity_003Ed__51 _003CEnumItemsQuantity_003Ed__ = new _003CEnumItemsQuantity_003Ed__51(-2);
			_003CEnumItemsQuantity_003Ed__._003C_003E4__this = this;
			_003CEnumItemsQuantity_003Ed__._003C_003E3__itemList = itemList;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008022")]
		[Cpp2IlInjected.Address(RVA = "0x1713B50", Offset = "0x1712550", VA = "0x181713B50")]
		private static bool CalculateRandomMask(ref int mask, int nbAttempt, int randomCount)
		{
			if (randomCount > 0)
			{
				uint num = num - (uint)randomCount;
				num += 2;
				if ((int)num > randomCount)
				{
					int num2 = 0;
				}
				if ((int)num > 0)
				{
					while (num != 0)
					{
					}
				}
				uint value = default(uint);
				mask.m_value = (int)value;
			}
			return nbAttempt < 50;
		}

		[Cpp2IlInjected.Token(Token = "0x6008023")]
		[Cpp2IlInjected.Address(RVA = "0x1715BA0", Offset = "0x17145A0", VA = "0x181715BA0")]
		public static ItemFilter New(Item item)
		{
			//Discarded unreachable code: IL_0023
			ItemFilter itemFilter = new ItemFilter();
			ItemFilterData itemFilterData = new ItemFilterData();
			itemFilterData.item_ = 0;
			ItemType type_ = default(ItemType);
			itemFilterData.type_ = type_;
			itemFilter.data_ = itemFilterData;
			return itemFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6008024")]
		[Cpp2IlInjected.Address(RVA = "0x17153C0", Offset = "0x1713DC0", VA = "0x1817153C0")]
		public static ItemFilter New(ItemSelector itemSelector, IProfile profile, Random random, bool onlySeedCrop = false, bool verifyCanReachItem = false, bool checkValidity = true, [Optional] string debugName)
		{
			ItemFilter result = default(ItemFilter);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008025")]
		[Cpp2IlInjected.Address(RVA = "0x1715490", Offset = "0x1713E90", VA = "0x181715490")]
		public static ItemFilter New(ItemSelector itemSelector, IProfile profile, Random random, bool onlySeedCrop, bool verifyCanReachItem, bool checkValidity, out int randomCount, [Optional] string debugName)
		{
			//IL_0079: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			ItemFilter itemFilter = new ItemFilter();
			int num = 0;
			if (itemFilter != null)
			{
				int num2 = 0;
				if (itemFilter != null)
				{
					if (itemFilter != null)
					{
						if (itemFilter != null)
						{
							if (num == 1)
							{
								ItemFilterData itemFilterData = default(ItemFilterData);
								itemFilter.data_ = itemFilterData;
								ItemFilterData itemFilterData2 = itemFilter.data_;
								bool flag = default(bool);
								bool flag2 = default(bool);
								bool flag3 = default(bool);
								if (profile != null && !flag && !flag2 && !flag3)
								{
									num2++;
									uint num4 = default(uint);
									int num5 = default(int);
									if ((long)(IntPtr)random > 0L)
									{
										int num3 = 0;
										while (-25 <= 0)
										{
										}
										num3 += (int)num4;
										while (4294967271u != 0)
										{
										}
										num5 = 0;
									}
									string text = $"FilterGenerator have no possible result: {num5}\nrandomCount={num4}, nbAttempt={num4}:";
								}
							}
							goto IL_007b;
						}
						ItemFilterData itemFilterData3 = default(ItemFilterData);
						itemFilter.data_ = itemFilterData3;
						while (profile == null)
						{
						}
						Item item = default(Item);
						itemFilter.data_ = (ItemFilterData)item;
						uint num6 = num6 + 2;
						int num7 = 0;
						while ((int)num6 <= 0)
						{
						}
						uint num8 = default(uint);
						num7 += (int)num8;
						while (num6 != 0)
						{
						}
						int num9 = 0;
					}
					ItemFilterData itemFilterData4 = default(ItemFilterData);
					itemFilter.data_ = itemFilterData4;
				}
				throw new NullReferenceException();
			}
			goto IL_007b;
			IL_007b:
			return itemFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6008026")]
		[Cpp2IlInjected.Address(RVA = "0x17161B0", Offset = "0x1714BB0", VA = "0x1817161B0")]
		static ItemFilter()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
