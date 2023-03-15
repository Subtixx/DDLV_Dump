using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Shops
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	public sealed class ItemPriceDatabase : IMessage<ItemPriceDatabase>, IMessage, IEquatable<ItemPriceDatabase>, IDeepCloneable<ItemPriceDatabase>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private static readonly MessageParser<ItemPriceDatabase> _parser = (MessageParser<ItemPriceDatabase>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ItemPriceDatabase()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public const int ItemPricesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private static readonly FieldCodec<ItemPrices> _repeated_itemPrices_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private readonly RepeatedField<ItemPrices> itemPrices_ = (RepeatedField<ItemPrices>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700037C")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemPriceDatabase> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000E72")]
			[Cpp2IlInjected.Address(RVA = "0x25E8EE0", Offset = "0x25E78E0", VA = "0x1825E8EE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000E73")]
			[Cpp2IlInjected.Address(RVA = "0x25E8D80", Offset = "0x25E7780", VA = "0x1825E8D80")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000E74")]
			[Cpp2IlInjected.Address(RVA = "0x25E8F40", Offset = "0x25E7940", VA = "0x1825E8F40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037F")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemPrices> ItemPrices
		{
			[Cpp2IlInjected.Token(Token = "0x6000E78")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return itemPrices_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000380")]
		public static CurrencyCost InvalidPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000E84")]
			[Cpp2IlInjected.Address(RVA = "0x25E8E50", Offset = "0x25E7850", VA = "0x1825E8E50")]
			get
			{
				//Discarded unreachable code: IL_0020
				//IL_0015: Expected I4, but got O
				//IL_001e: Expected I4, but got I8
				CurrencyCost currencyCost = new CurrencyCost();
				int num = 0;
				Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
				currencyCost.id_ = (int)hardCurrencyItem;
				currencyCost.amount_ = 1;
				return currencyCost;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E75")]
		[Cpp2IlInjected.Address(RVA = "0x25E8D00", Offset = "0x25E7700", VA = "0x1825E8D00")]
		[DebuggerNonUserCode]
		public ItemPriceDatabase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E76")]
		[Cpp2IlInjected.Address(RVA = "0x25E8C00", Offset = "0x25E7600", VA = "0x1825E8C00")]
		[DebuggerNonUserCode]
		public ItemPriceDatabase(ItemPriceDatabase other)
		{
			RepeatedField<ItemPrices> repeatedField = (itemPrices_ = (RepeatedField<ItemPrices>)(object)((RepeatedField<T>)(object)other.itemPrices_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E77")]
		[Cpp2IlInjected.Address(RVA = "0x25E7480", Offset = "0x25E5E80", VA = "0x1825E7480", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemPriceDatabase Clone()
		{
			//Discarded unreachable code: IL_003b
			ItemPriceDatabase itemPriceDatabase = new ItemPriceDatabase();
			RepeatedField<ItemPrices> repeatedField = (itemPriceDatabase.itemPrices_ = (RepeatedField<ItemPrices>)(object)new RepeatedField<T>());
			RepeatedField<ItemPrices> repeatedField2 = (itemPriceDatabase.itemPrices_ = (RepeatedField<ItemPrices>)(object)((RepeatedField<T>)(object)itemPrices_).Clone());
			UnknownFieldSet unknownFieldSet = (itemPriceDatabase._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemPriceDatabase;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E79")]
		[Cpp2IlInjected.Address(RVA = "0x25E7D10", Offset = "0x25E6710", VA = "0x1825E7D10", Slot = "0")]
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
				RepeatedField<ItemPrices> repeatedField = itemPrices_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7A")]
		[Cpp2IlInjected.Address(RVA = "0x25E7C80", Offset = "0x25E6680", VA = "0x1825E7C80", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemPriceDatabase other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<ItemPrices> repeatedField = itemPrices_;
				RepeatedField<ItemPrices> repeatedField2 = other.itemPrices_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7B")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)itemPrices_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7C")]
		[Cpp2IlInjected.Address(RVA = "0x25E8040", Offset = "0x25E6A40", VA = "0x1825E8040", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7D")]
		[Cpp2IlInjected.Address(RVA = "0x25E8970", Offset = "0x25E7370", VA = "0x1825E8970", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<ItemPrices> repeatedField = itemPrices_;
			FieldCodec<ItemPrices> repeated_itemPrices_codec = _repeated_itemPrices_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_itemPrices_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7E")]
		[Cpp2IlInjected.Address(RVA = "0x25E7370", Offset = "0x25E5D70", VA = "0x1825E7370", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<ItemPrices> repeatedField = itemPrices_;
			FieldCodec<ItemPrices> repeated_itemPrices_codec = _repeated_itemPrices_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_itemPrices_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7F")]
		[Cpp2IlInjected.Address(RVA = "0x25E7E70", Offset = "0x25E6870", VA = "0x1825E7E70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemPriceDatabase other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<ItemPrices> repeatedField = itemPrices_;
				RepeatedField<ItemPrices> repeatedField2 = other.itemPrices_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E80")]
		[Cpp2IlInjected.Address(RVA = "0x25E7EF0", Offset = "0x25E68F0", VA = "0x1825E7EF0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<ItemPrices> repeatedField = itemPrices_;
					FieldCodec<ItemPrices> repeated_itemPrices_codec = _repeated_itemPrices_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemPrices_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E81")]
		[Cpp2IlInjected.Address(RVA = "0x25E7DF0", Offset = "0x25E67F0", VA = "0x1825E7DF0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<ItemPrices> repeatedField = itemPrices_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E82")]
		[Cpp2IlInjected.Address(RVA = "0x25E7FE0", Offset = "0x25E69E0", VA = "0x1825E7FE0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E83")]
		[Cpp2IlInjected.Address(RVA = "0x25E7420", Offset = "0x25E5E20", VA = "0x1825E7420", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<ItemPrices> repeatedField = itemPrices_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E85")]
		[Cpp2IlInjected.Address(RVA = "0x25E81A0", Offset = "0x25E6BA0", VA = "0x1825E81A0")]
		public bool TryGetPrice(Item item, Item currency, out int price)
		{
			//IL_001b: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			int itemID = currency.ItemID;
			int itemID2 = item.ItemID;
			Item item2 = (Item)itemID2;
			Item currency2 = (Item)itemID;
			CurrencyCost currencyCost = default(CurrencyCost);
			if (currencyCost == null)
			{
				RepeatedField<ItemPrices> repeatedField = itemPrices_;
				Func<ItemPrices, bool> func = (Func<ItemPrices, bool>)(object)(Func<T, TResult>)delegate(ItemPrices x)
				{
					//Discarded unreachable code: IL_0011
					Item item4 = item2;
					return (IntPtr)x.id_ == (IntPtr)item4;
				};
				ItemPrices itemPrices = Enumerable.FirstOrDefault<ItemPrices>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
				if (itemPrices != null)
				{
					RepeatedField<CurrencyCost> prices_ = itemPrices.prices_;
					Func<CurrencyCost, bool> func2 = (Func<CurrencyCost, bool>)(object)(Func<T, TResult>)delegate(CurrencyCost x)
					{
						//Discarded unreachable code: IL_0011
						Item item3 = currency2;
						return (IntPtr)x.id_ == (IntPtr)item3;
					};
					if (Enumerable.FirstOrDefault<CurrencyCost>((IEnumerable<>)(object)prices_, (Func<, >)(object)func2) != null)
					{
						goto IL_0073;
					}
				}
				int num = 0;
			}
			goto IL_0073;
			IL_0073:
			int num2 = (price.m_value = currencyCost.amount_);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E86")]
		[Cpp2IlInjected.Address(RVA = "0x25E83A0", Offset = "0x25E6DA0", VA = "0x1825E83A0")]
		public unsafe bool TryGetPrices(Item item, out List<CurrencyCost> prices)
		{
			//IL_0014: Expected O, but got I4
			//IL_0084: Expected O, but got I4
			//IL_0084: Expected O, but got Ref
			//IL_00ab: Expected O, but got Ref
			//IL_00c5: Expected O, but got Ref
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			int num = 0;
			CurrencyCost currencyCost = default(CurrencyCost);
			if (currencyCost == null)
			{
				RepeatedField<ItemPrices> repeatedField = itemPrices_;
				Func<ItemPrices, bool> func = (Func<ItemPrices, bool>)(object)(Func<T, TResult>)delegate(ItemPrices x)
				{
					//Discarded unreachable code: IL_0011
					Item item3 = item2;
					return (IntPtr)x.id_ == (IntPtr)item3;
				};
				ItemPrices itemPrices = Enumerable.FirstOrDefault<ItemPrices>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
				if (itemPrices != null)
				{
					RepeatedField<CurrencyCost> prices_ = itemPrices.prices_;
					Func<CurrencyCost, bool> _003C_003E9__31_ = _003C_003Ec._003C_003E9__31_1;
					if (_003C_003E9__31_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							throw new NullReferenceException();
						};
					}
					List<CurrencyCost> list = (List<CurrencyCost>)(object)Enumerable.ToList<CurrencyCost>(Enumerable.Where<CurrencyCost>((IEnumerable<>)(object)prices_, (Func<, >)(object)_003C_003E9__31_));
				}
				((List<>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref prices))._items = (T[])num;
				bool flag = default(bool);
				if (flag)
				{
					goto IL_00c5;
				}
				List<CurrencyCost> list2 = (List<CurrencyCost>)(object)new List<T>();
				int num2 = 0;
				CurrencyCost invalidPrice = InvalidPrice;
				((List<T>)(object)list2).Add((T)invalidPrice);
				((List<>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref prices))._items = (T[])(object)list2;
				int num3 = 0;
			}
			List<CurrencyCost> list3 = (List<CurrencyCost>)(object)new List<T>();
			((List<T>)(object)list3).Add((T)currencyCost);
			((List<>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref prices))._items = (T[])(object)list3;
			goto IL_00c5;
			IL_00c5:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E87")]
		[Cpp2IlInjected.Address(RVA = "0x25E8720", Offset = "0x25E7120", VA = "0x1825E8720")]
		internal bool TryGetSoftCurrencySellPrice(Item item, ItemState state, out int price)
		{
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			int num = default(int);
			if (itemData == null)
			{
				bool result = default(bool);
				if (SellPriceFormulaItemData.GetItemSellPrice(itemData, state) == null)
				{
					return result;
				}
			}
			else
			{
				num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
			}
			price.m_value = num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E88")]
		[Cpp2IlInjected.Address(RVA = "0x25E80A0", Offset = "0x25E6AA0", VA = "0x1825E80A0")]
		internal bool TryGetDefaultSoftCurrencySellPrice(Item item, out int price)
		{
			//Discarded unreachable code: IL_004b
			//IL_0014: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			RepeatedField<ItemPrices> repeatedField = itemPrices_;
			Func<ItemPrices, bool> func = (Func<ItemPrices, bool>)(object)(Func<T, TResult>)delegate(ItemPrices x)
			{
				//Discarded unreachable code: IL_0011
				Item item3 = item2;
				return (IntPtr)x.id_ == (IntPtr)item3;
			};
			ItemPrices itemPrices = Enumerable.FirstOrDefault<ItemPrices>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			if (itemPrices != null)
			{
			}
			bool result = itemPrices != null;
			price.m_value = 1;
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E89")]
		[Cpp2IlInjected.Address(RVA = "0x25E75B0", Offset = "0x25E5FB0", VA = "0x1825E75B0")]
		public void DataValidation(List<string> errors, string name)
		{
			//Discarded unreachable code: IL_0127, IL_0145, IL_014b, IL_0151, IL_0157
			//IL_0046: Expected O, but got I4
			//IL_0046: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_00cb: Expected O, but got I4
			//IL_00e8: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			int num2 = default(int);
			IEnumerable<CurrencyCost> enumerable = default(IEnumerable<CurrencyCost>);
			int num3 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num = 0;
				RepeatedField<ItemPrices> repeatedField = itemPrices_;
				if (!flag)
				{
					return;
				}
				if (_003C_003Ec._003C_003E9__34_1 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(CurrencyCost x)
					{
						//Discarded unreachable code: IL_0015
						if (x.id_ != 0)
						{
							int num6 = 0;
						}
						return x.amount_ == 0;
					};
				}
				if (flag2)
				{
				}
				if (!flag3)
				{
					string item = $"[ItemPriceDatabase] {name}: Item[{num2}]={num2} is invalid";
					((List<T>)(object)errors).Add((T)item);
				}
				if (_003C_003Ec._003C_003E9__34_2 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CurrencyCost x) => !IsValidID(x.id_));
				}
				List<CurrencyCost> list = (List<CurrencyCost>)(object)Enumerable.ToList<CurrencyCost>((IEnumerable<>)enumerable);
				if (!Enumerable.Any<CurrencyCost>((IEnumerable<>)list))
				{
					continue;
				}
				object[] array = new object[0];
				if (name == null || array != null)
				{
					array[0] = name;
					if (num3 == 0 || num3 != 0)
					{
						array[1] = num3;
						if (num4 == 0 || num4 != 0)
						{
							array[2] = num4;
							int size = ((List<>)(object)list)._size;
							if (size == 0 || size != 0)
							{
								array[3] = size;
								string text = string.Join<CurrencyCost>(",", (IEnumerable<>)list);
								if (text != null && text == null)
								{
									break;
								}
								array[4] = text;
								string item2 = string.Format("[ItemPriceDatabase] {0}: Item[{1}]={2} contain {3} invalid prices: ids={4}", array);
								((List<T>)(object)errors).Add((T)item2);
								return;
							}
							throw new IndexOutOfRangeException();
						}
						throw new IndexOutOfRangeException();
					}
					throw new IndexOutOfRangeException();
				}
				throw new NullReferenceException();
			}
			throw new IndexOutOfRangeException();
			[Cpp2IlInjected.Token(Token = "0x6000E8B")]
			[Cpp2IlInjected.Address(RVA = "0x25E8900", Offset = "0x25E7300", VA = "0x1825E8900")]
			static bool IsValidID(int _id)
			{
				long num5 = Convert.ToInt64((uint)_id);
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8A")]
		[Cpp2IlInjected.Address(RVA = "0x25E8A30", Offset = "0x25E7430", VA = "0x1825E8A30")]
		static ItemPriceDatabase()
		{
			MessageParser<ItemPrices> parser = Definitions.Shops.ItemPrices._parser;
			uint num = default(uint);
			_parser = (MessageParser<ItemPriceDatabase>)(object)FieldCodec.ForMessage<ItemPrices>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
